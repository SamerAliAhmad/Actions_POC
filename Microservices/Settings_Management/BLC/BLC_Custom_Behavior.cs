using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.IO;
using MongoDB.Driver;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Bson;
using System.Text.Json;
using MongoDB.Bson.IO;

namespace BLC
{
    public partial class BLC
    {
        #region Ticket
        #region Resolve_Ticket
        public Dictionary<string, string> Resolve_Ticket(string i_Input)
        {
            #region Declaration And Initialization Section.
            string oTicket_PlainText = string.Empty;
            Enum_BR_Codes oException_Message = Enum_BR_Codes.BR_0002; // Invalid Ticket as Default Message
            Dictionary<string, string> oList_Ticket_Parsed_Element = new Dictionary<string, string>();
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Resolve_Ticket", i_Input, false);
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                try
                {
                    oTicket_PlainText = Crypto.Decrypt(i_Input);

                    if (!string.IsNullOrEmpty(oTicket_PlainText))
                    {
                        var oList_Ticket_Element = oTicket_PlainText.Split(Global.Ticket_Separator, StringSplitOptions.RemoveEmptyEntries).Where(element => element.Contains(":"));

                        foreach (var oTicket_Element in oList_Ticket_Element)
                        {
                            var oList_Ticket_Element_Key_Value = oTicket_Element.Split(":", 2);
                            oList_Ticket_Parsed_Element.Add(oList_Ticket_Element_Key_Value[0], oList_Ticket_Element_Key_Value[1]);
                        }
                        if ((DateTime.Now - DateTime.Parse(oList_Ticket_Parsed_Element["START_DATE"])).TotalMinutes > double.Parse(oList_Ticket_Parsed_Element["SESSION_PERIOD"]))
                        {
                            oException_Message = Enum_BR_Codes.ER_0003; // Session Expired
                            throw new BLC_Exception(Get_Message_Content(oException_Message));
                        }
                    }
                }
                catch
                {
                    throw new BLC_Exception(Get_Message_Content(oException_Message));
                }
            }
            else
            {
                oList_Ticket_Parsed_Element.Add(Global.User_ID, "1");
                oList_Ticket_Parsed_Element.Add(Global.Owner_ID, "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Resolve_Ticket", i_Input, false);
            }
            #endregion
            #region Return Section.
            return oList_Ticket_Parsed_Element;
            #endregion
        }
        #endregion
        #region Is_Valid_Ticket
        public bool Is_Valid_Ticket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool is_valid_ticket = false;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Is_Valid_Ticket", i_Input, false);
            }
            #endregion
            #region Body Section.
            try
            {
                var oTicket_Parts = Resolve_Ticket(i_Input);
                var current_date_str = Tools.GetDateString(DateTime.Today);

                if (oTicket_Parts[Global.Start_Date] == current_date_str) // Session Started In Different Day.
                {
                    var minutes_elapsed_since_midnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                    if (minutes_elapsed_since_midnight <= Convert.ToInt32(oTicket_Parts[Global.Start_Minute]) + Convert.ToInt32(oTicket_Parts[Global.Session_Period]))
                    {
                        is_valid_ticket = true;
                    }
                }
            }
            catch
            {
                is_valid_ticket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Is_Valid_Ticket", i_Input, false);
            }
            #endregion
            #region Return Section.
            return is_valid_ticket;
            #endregion
        }
        #endregion
        #endregion
        #region Get_Default_Organization_URL_By_Setup_Value
        public string Get_Default_Organization_URL_By_Setup_Value(Default_settings i_Default_settings, string Setup_Value)
        {
            var oDefault_settings_image = i_Default_settings.List_Default_settings_image.LastOrDefault(oDefault_settings_image => oDefault_settings_image.Image_type_setup.VALUE == Setup_Value);
            if (oDefault_settings_image != null && oDefault_settings_image != default)
            {
                return $"{Global.Assets_Endpoint}/{Global.Assets_Default_Image_Path}/{oDefault_settings_image.IMAGE_NAME}.{oDefault_settings_image.IMAGE_EXTENSION}";
            }
            return null;
        }
        #endregion
        #region Upload_Default_Settings_Picture
        public string Upload_Default_Settings_Picture(Params_Upload_Default_Settings_Picture i_Params_Upload_Default_Settings_Picture)
        {
            if (
                i_Params_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID != null &&
                i_Params_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID > 0 &&
                i_Params_Upload_Default_Settings_Picture.List_Uploaded_File != null &&
                i_Params_Upload_Default_Settings_Picture.List_Uploaded_File.Count > 0
            )
            {
                Default_settings oDefault_settings = Get_Default_settings_By_OWNER_ID(new Params_Get_Default_settings_By_OWNER_ID
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).FirstOrDefault();

                if (oDefault_settings != null && oDefault_settings != default)
                {
                    var formFile = i_Params_Upload_Default_Settings_Picture.List_Uploaded_File.First();
                    var fileName = formFile.FileName;
                    var extension = Path.GetExtension(fileName).Replace(".", "");

                    Default_settings_image oDefault_settings_image = new Default_settings_image
                    {
                        IMAGE_EXTENSION = extension,
                        DEFAULT_SETTINGS_IMAGE_ID = -1,
                        IMAGE_NAME = Tools.Get_Unique_String(),
                        OWNER_ID = this.oBLC_Initializer.Owner_ID,
                        DEFAULT_SETTINGS_ID = oDefault_settings.DEFAULT_SETTINGS_ID,
                        IMAGE_TYPE_SETUP_ID = i_Params_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID,
                    };

                    string Object_Name = $"{Global.Assets_Default_Image_Path}/{oDefault_settings_image.IMAGE_NAME}.{oDefault_settings_image.IMAGE_EXTENSION}";

                    try
                    {
                        byte[] data;

                        using (var oMemoryStream = new MemoryStream())
                        {
                            formFile.CopyTo(oMemoryStream);
                            data = oMemoryStream.ToArray();
                        }
                        this._service_mesh.Upload_Object(new Service_Mesh.Params_Upload_Object()
                        {
                            Data = data,
                            Object_Name = Object_Name
                        });
                    }
                    catch
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0026)); // Upload Failed.
                    }

                    if (
                        oDefault_settings.List_Default_settings_image != null &&
                        oDefault_settings.List_Default_settings_image.Count > 0 &&
                        oDefault_settings.List_Default_settings_image.Any(oDefault_settings_image => oDefault_settings_image.IMAGE_TYPE_SETUP_ID == i_Params_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID)
                    )
                    {
                        this._service_mesh.Delete_Object_List(new Service_Mesh.Params_Delete_Object_List()
                        {
                            List_Object_Name = oDefault_settings.List_Default_settings_image
                                                .Where(oDefault_settings_image => oDefault_settings_image.IMAGE_TYPE_SETUP_ID == i_Params_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID)
                                                .Select(oDefault_settings_image =>
                                                {
                                                    Delete_Default_settings_image(new Params_Delete_Default_settings_image
                                                    {
                                                        DEFAULT_SETTINGS_IMAGE_ID = oDefault_settings_image.DEFAULT_SETTINGS_IMAGE_ID
                                                    });
                                                    return $"{Global.Assets_Default_Image_Path}/{oDefault_settings_image.IMAGE_NAME}.{oDefault_settings_image.IMAGE_EXTENSION}";
                                                })
                        });
                    }

                    Edit_Default_settings_image(oDefault_settings_image);

                    return $"{Global.Assets_Endpoint}/{Object_Name}";
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0030)); // An Error has Occured! Contact Support.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Delete_Default_Settings_Picture
        public bool Delete_Default_Settings_Picture(Params_Delete_Default_Settings_Picture i_Params_Delete_Default_Settings_Picture)
        {
            if (i_Params_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID != null &&
                i_Params_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID > 0)
            {
                List<Default_settings_image> oList_Default_settings_image = Get_Default_settings_image_By_OWNER_ID(new Params_Get_Default_settings_image_By_OWNER_ID
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });

                if (
                    oList_Default_settings_image != null &&
                    oList_Default_settings_image.Count > 0 &&
                    oList_Default_settings_image.Any(oDefault_settings_image => oDefault_settings_image.IMAGE_TYPE_SETUP_ID == i_Params_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID)
                )
                {
                    this._service_mesh.Delete_Object_List(new Service_Mesh.Params_Delete_Object_List()
                    {
                        List_Object_Name = oList_Default_settings_image
                                            .Where(oDefault_settings_image => oDefault_settings_image.IMAGE_TYPE_SETUP_ID == i_Params_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID)
                                            .Select(oDefault_settings_image =>
                                            {
                                                Delete_Default_settings_image(new Params_Delete_Default_settings_image
                                                {
                                                    DEFAULT_SETTINGS_IMAGE_ID = oDefault_settings_image.DEFAULT_SETTINGS_IMAGE_ID
                                                });
                                                return $"{Global.Assets_Default_Image_Path}/{oDefault_settings_image.IMAGE_NAME}.{oDefault_settings_image.IMAGE_EXTENSION}";
                                            })
                    });
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region UI Initial Settings
        #region Get_Initial_Districtnex_UI_Settings
        public Initial_Districtnex_UI_Settings Get_Initial_Districtnex_UI_Settings()
        {
            this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));
            Setup oSetup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Application Name"
            }).List_Setup.Find(setup => setup.VALUE == "Districtnex UI");
            return new Initial_Districtnex_UI_Settings()
            {
                Default_settings = Get_Default_settings_By_OWNER_ID(new Params_Get_Default_settings_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).FirstOrDefault(),
                BUILD_NUMBER = Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(new Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID()
                {
                    IS_CURRENT = true,
                    APPLICATION_NAME_SETUP_ID = oSetup.SETUP_ID
                }).LastOrDefault()?.BUILD_NUMBER,
            };
        }
        #endregion
        #region Get_Initial_Districtnex_Admin_Settings
        public Initial_Districtnex_Admin_Settings Get_Initial_Districtnex_Admin_Settings()
        {
            this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));
            Setup oSetup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Application Name"
            }).List_Setup.Find(setup => setup.VALUE == "Districtnex Admin");
            return new Initial_Districtnex_Admin_Settings()
            {
                Default_settings = Get_Default_settings_By_OWNER_ID(new Params_Get_Default_settings_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).FirstOrDefault(),
                BUILD_NUMBER = Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(new Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID()
                {
                    IS_CURRENT = true,
                    APPLICATION_NAME_SETUP_ID = oSetup.SETUP_ID
                }).LastOrDefault()?.BUILD_NUMBER,
            };
        }
        #endregion
        #endregion
        #region Update_Otp_Index
        public void Update_Otp_Index(Params_Update_Otp_Index i_Params_Update_Otp_Index)
        {
            this._MongoDb.Update_Otp_Index(i_Params_Update_Otp_Index.OTP_TTL_IN_SECONDS);
        }
        #endregion
        #region Edit_Removed_extrusion_Custom
        public void Edit_Removed_extrusion_Custom(Params_Edit_Removed_extrusion_Custom i_Params_Edit_Removed_extrusion_Custom)
        {
            i_Params_Edit_Removed_extrusion_Custom.List_Removed_extrusion = i_Params_Edit_Removed_extrusion_Custom.List_Removed_extrusion.DistinctBy(removed_extrusion => new
            {
                removed_extrusion.LEVEL_ID,
                removed_extrusion.DATA_LEVEL_SETUP_ID,
                removed_extrusion.EXTRUSION_IDENTIFIER,
            }).ToList();
            List<Removed_extrusion> oList_Removed_extrusion = Get_Removed_extrusion_By_OWNER_ID(new Params_Get_Removed_extrusion_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
            });
            i_Params_Edit_Removed_extrusion_Custom.List_Removed_extrusion.RemoveAll(removed_extrusion => oList_Removed_extrusion
                                                                                                        .Any(oRemoved_extrusion => removed_extrusion.DATA_LEVEL_SETUP_ID == oRemoved_extrusion.DATA_LEVEL_SETUP_ID
                                                                                                                                && removed_extrusion.LEVEL_ID == oRemoved_extrusion.LEVEL_ID
                                                                                                                                && removed_extrusion.EXTRUSION_IDENTIFIER == oRemoved_extrusion.EXTRUSION_IDENTIFIER));
            i_Params_Edit_Removed_extrusion_Custom.List_Removed_extrusion = i_Params_Edit_Removed_extrusion_Custom.List_Removed_extrusion.Select(removed_extrusion =>
            {
                removed_extrusion.REMOVED_EXTRUSION_ID = -1;
                return removed_extrusion;
            }).ToList();
            Edit_Removed_extrusion_List(new Params_Edit_Removed_extrusion_List()
            {
                List_To_Edit = i_Params_Edit_Removed_extrusion_Custom.List_Removed_extrusion
            });
        }
        #endregion
        #region Edit_Removed_extrusion_Custom_Old
        public void Edit_Removed_extrusion_Custom_Old(Params_Edit_Removed_extrusion_Custom_Old i_Params_Edit_Removed_extrusion_Custom_Old)
        {
            if (Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(new Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID()
            {
                DATA_LEVEL_SETUP_ID = i_Params_Edit_Removed_extrusion_Custom_Old.DATA_LEVEL_SETUP_ID
            }).Where(removed_extrusion => removed_extrusion.EXTRUSION_IDENTIFIER == i_Params_Edit_Removed_extrusion_Custom_Old.ID && removed_extrusion.LEVEL_ID == i_Params_Edit_Removed_extrusion_Custom_Old.LEVEL_ID).Count() == 0)
            {
                Edit_Removed_extrusion(new Removed_extrusion()
                {
                    REMOVED_EXTRUSION_ID = -1,
                    DATA_LEVEL_SETUP_ID = i_Params_Edit_Removed_extrusion_Custom_Old.DATA_LEVEL_SETUP_ID,
                    EXTRUSION_IDENTIFIER = i_Params_Edit_Removed_extrusion_Custom_Old.ID,
                    LEVEL_ID = i_Params_Edit_Removed_extrusion_Custom_Old.LEVEL_ID,
                });
            }
        }
        #endregion
        #region Clean_Removed_extrusions
        public void Clean_Removed_extrusions()
        {
            List<Removed_extrusion> oList_Removed_extrusion = Get_Removed_extrusion_By_OWNER_ID(new Params_Get_Removed_extrusion_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            Edit_Removed_extrusion_List(new Params_Edit_Removed_extrusion_List()
            {
                List_To_Delete = oList_Removed_extrusion.GroupBy(removed_extrusion => new
                {
                    removed_extrusion.LEVEL_ID,
                    removed_extrusion.EXTRUSION_IDENTIFIER,
                    removed_extrusion.DATA_LEVEL_SETUP_ID,
                }, (x, y) => new
                {
                    Key = x,
                    Value = y.Skip(1)
                }).SelectMany(removed_extrusion => removed_extrusion.Value.Select(removed_extrusion_inner => removed_extrusion_inner.REMOVED_EXTRUSION_ID)),
            });
        }
        #endregion
        #region Create_Time_series_Collection
        public void Create_Time_series_Collection(Params_Create_Time_series_Collection i_Params_Create_Time_series_Collection)
        {
            this._MongoDb.Create_Time_series_Collection(i_Params_Create_Time_series_Collection.TIME_SERIES_COLLECTION_NAME);
        }
        #endregion
        #region Drop_Collection
        public void Drop_Collection(Params_Drop_Collection i_Params_Drop_Collection)
        {
            this._MongoDb.Drop_Collection(i_Params_Drop_Collection.COLLECTION_NAME);
        }
        #endregion
        #region Edit_Object_View
        public void Edit_Object_View(Params_Edit_Object_View i_Params_Edit_Object_View)
        {
            if (i_Params_Edit_Object_View.DISTRICT_ID != null)
            {
                List<Service_Mesh.District_view> oList_District_view = this._service_mesh.Get_District_view_By_DISTRICT_ID(new Service_Mesh.Params_Get_District_view_By_DISTRICT_ID()
                {
                    DISTRICT_ID = i_Params_Edit_Object_View.DISTRICT_ID
                }).i_Result;
                Service_Mesh.District_view oDistrict_view = oList_District_view.Find(district_view => district_view.VIEW_TYPE_SETUP_ID == i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID);
                if (oDistrict_view != null)
                {
                    oDistrict_view.BEARING = i_Params_Edit_Object_View.BEARING;
                    oDistrict_view.PITCH = i_Params_Edit_Object_View.PITCH;
                    oDistrict_view.ZOOM = i_Params_Edit_Object_View.ZOOM;
                    oDistrict_view.LONGITUDE = i_Params_Edit_Object_View.LONGITUDE;
                    oDistrict_view.LATITUDE = i_Params_Edit_Object_View.LATITUDE;
                }
                else
                {
                    oDistrict_view = new Service_Mesh.District_view()
                    {
                        DISTRICT_VIEW_ID = -1,
                        DISTRICT_ID = i_Params_Edit_Object_View.DISTRICT_ID,
                        BEARING = i_Params_Edit_Object_View.BEARING,
                        PITCH = i_Params_Edit_Object_View.PITCH,
                        ZOOM = i_Params_Edit_Object_View.ZOOM,
                        LONGITUDE = i_Params_Edit_Object_View.LONGITUDE,
                        LATITUDE = i_Params_Edit_Object_View.LATITUDE,
                        VIEW_TYPE_SETUP_ID = i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID,
                    };
                }
                this._service_mesh.Edit_District_view(oDistrict_view);
            }
            else if (i_Params_Edit_Object_View.AREA_ID != null)
            {
                List<Service_Mesh.Area_view> oList_Area_view = this._service_mesh.Get_Area_view_By_AREA_ID(new Service_Mesh.Params_Get_Area_view_By_AREA_ID()
                {
                    AREA_ID = i_Params_Edit_Object_View.AREA_ID
                }).i_Result;
                Service_Mesh.Area_view oArea_view = oList_Area_view.Find(area_view => area_view.VIEW_TYPE_SETUP_ID == i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID);
                if (oArea_view != null)
                {
                    oArea_view.BEARING = i_Params_Edit_Object_View.BEARING;
                    oArea_view.PITCH = i_Params_Edit_Object_View.PITCH;
                    oArea_view.ZOOM = i_Params_Edit_Object_View.ZOOM;
                    oArea_view.LONGITUDE = i_Params_Edit_Object_View.LONGITUDE;
                    oArea_view.LATITUDE = i_Params_Edit_Object_View.LATITUDE;
                }
                else
                {
                    oArea_view = new Service_Mesh.Area_view()
                    {
                        AREA_VIEW_ID = -1,
                        AREA_ID = i_Params_Edit_Object_View.AREA_ID,
                        BEARING = i_Params_Edit_Object_View.BEARING,
                        PITCH = i_Params_Edit_Object_View.PITCH,
                        ZOOM = i_Params_Edit_Object_View.ZOOM,
                        LONGITUDE = i_Params_Edit_Object_View.LONGITUDE,
                        LATITUDE = i_Params_Edit_Object_View.LATITUDE,
                        VIEW_TYPE_SETUP_ID = i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID,
                    };
                }
                this._service_mesh.Edit_Area_view(oArea_view);
            }
            else
            if (i_Params_Edit_Object_View.SITE_ID != null)
            {
                List<Service_Mesh.Site_view> oList_Site_view = this._service_mesh.Get_Site_view_By_SITE_ID(new Service_Mesh.Params_Get_Site_view_By_SITE_ID()
                {
                    SITE_ID = i_Params_Edit_Object_View.SITE_ID
                }).i_Result;
                Service_Mesh.Site_view oSite_view = oList_Site_view.Find(site_view => site_view.VIEW_TYPE_SETUP_ID == i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID);
                if (oSite_view != null)
                {
                    oSite_view.BEARING = i_Params_Edit_Object_View.BEARING;
                    oSite_view.PITCH = i_Params_Edit_Object_View.PITCH;
                    oSite_view.ZOOM = i_Params_Edit_Object_View.ZOOM;
                    oSite_view.LONGITUDE = i_Params_Edit_Object_View.LONGITUDE;
                    oSite_view.LATITUDE = i_Params_Edit_Object_View.LATITUDE;
                }
                else
                {
                    oSite_view = new Service_Mesh.Site_view()
                    {
                        SITE_VIEW_ID = -1,
                        SITE_ID = i_Params_Edit_Object_View.SITE_ID,
                        BEARING = i_Params_Edit_Object_View.BEARING,
                        PITCH = i_Params_Edit_Object_View.PITCH,
                        ZOOM = i_Params_Edit_Object_View.ZOOM,
                        LONGITUDE = i_Params_Edit_Object_View.LONGITUDE,
                        LATITUDE = i_Params_Edit_Object_View.LATITUDE,
                        VIEW_TYPE_SETUP_ID = i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID,
                    };
                }
                this._service_mesh.Edit_Site_view(oSite_view);
            }
            if (i_Params_Edit_Object_View.ENTITY_ID != null)
            {
                List<Service_Mesh.Entity_view> oList_Entity_view = this._service_mesh.Get_Entity_view_By_ENTITY_ID(new Service_Mesh.Params_Get_Entity_view_By_ENTITY_ID()
                {
                    ENTITY_ID = i_Params_Edit_Object_View.ENTITY_ID
                }).i_Result;
                Service_Mesh.Entity_view oEntity_view = oList_Entity_view.Find(entity_view => entity_view.VIEW_TYPE_SETUP_ID == i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID);
                if (oEntity_view != null)
                {
                    oEntity_view.BEARING = i_Params_Edit_Object_View.BEARING;
                    oEntity_view.PITCH = i_Params_Edit_Object_View.PITCH;
                    oEntity_view.ZOOM = i_Params_Edit_Object_View.ZOOM;
                    oEntity_view.LONGITUDE = i_Params_Edit_Object_View.LONGITUDE;
                    oEntity_view.LATITUDE = i_Params_Edit_Object_View.LATITUDE;
                }
                else
                {
                    oEntity_view = new Service_Mesh.Entity_view()
                    {
                        ENTITY_VIEW_ID = -1,
                        ENTITY_ID = i_Params_Edit_Object_View.ENTITY_ID,
                        BEARING = i_Params_Edit_Object_View.BEARING,
                        PITCH = i_Params_Edit_Object_View.PITCH,
                        ZOOM = i_Params_Edit_Object_View.ZOOM,
                        LONGITUDE = i_Params_Edit_Object_View.LONGITUDE,
                        LATITUDE = i_Params_Edit_Object_View.LATITUDE,
                        VIEW_TYPE_SETUP_ID = i_Params_Edit_Object_View.VIEW_TYPE_SETUP_ID,
                    };
                }
                this._service_mesh.Edit_Entity_view(oEntity_view);
            }
        }
        #endregion
        #region Send_Support_Email
        public void Send_Support_Email(Params_Send_Support_Email i_Params_Send_Support_Email)
        {
            #region Get SMTP Credentials
            string smtp_email = "";
            string smtp_password = "";
            var get_smtp_email = Task.Run(() =>
            {
                smtp_email = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = ConfigurationManager.AppSettings["SUPPORT_SMTP_EMAIL"]
                }).i_Result;
            });
            var get_smtp_password = Task.Run(() =>
            {
                smtp_password = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = ConfigurationManager.AppSettings["SUPPORT_SMTP_PASSWORD"]
                }).i_Result;
            });
            Task.WaitAll(get_smtp_email, get_smtp_password);
            #endregion
            using (SmtpClient client = new SmtpClient()
            {
                Port = 587,
                EnableSsl = true, // Set to avoid secure connection exception
                Host = "smtp.office365.com",
                UseDefaultCredentials = false, // This is required before setting the credentials property
                TargetName = "STARTTLS/smtp.office365.com", // Set to avoid MustIssueStartTlsFirst exception
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(smtp_email, smtp_password)
            })
            {
                MailMessage message = new MailMessage()
                {
                    IsBodyHtml = true,
                    From = new MailAddress(smtp_email),
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                    Subject = i_Params_Send_Support_Email.TITLE + " From " + ConfigurationManager.AppSettings["CLOUD_PROVIDER"],
                    Body = "<p>" + i_Params_Send_Support_Email.MESSAGE + "</p>",

                };
                message.Priority = MailPriority.High;
                if (i_Params_Send_Support_Email.List_Email == null || i_Params_Send_Support_Email.List_Email?.Count == 0)
                {
                    message.To.Add("rodolphkhlat@outlook.com");
                    message.To.Add("eliasnajems@gmail.com");
                    message.To.Add("districtnex@gmail.com");
                }
                else
                {
                    i_Params_Send_Support_Email.List_Email.ForEach(email =>
                    {
                        message.To.Add(email);
                    });
                }
                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        #endregion
        #region Chart_configuration
        #region Get_Dimension_chart_configuration
        public List<Dimension_chart_configuration> Get_Dimension_chart_configuration()
        {
            List<Dimension_chart_configuration> oList_Dimension_chart_configuration = null;

            IEnumerable<DALC.Dimension_chart_configuration> oList_DBEntry = _MongoDb.Get_Dimension_chart_configuration();
            if (oList_DBEntry != null)
            {
                oList_Dimension_chart_configuration = new List<Dimension_chart_configuration>();
                if (oList_DBEntry.Count() > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension_chart_configuration oDimension_chart_configuration = new Dimension_chart_configuration();
                        Props.Copy_Prop_Values(oDBEntry, oDimension_chart_configuration);
                        oDimension_chart_configuration.LIST_SETTING = new List<Setting>();
                        if (oDBEntry.LIST_SETTING != null && oDBEntry.LIST_SETTING.Count > 0)
                        {
                            foreach (var _Setting in oDBEntry.LIST_SETTING)
                            {
                                Setting oSetting = new Setting();
                                Props.Copy_Prop_Values(_Setting, oSetting);
                                oDimension_chart_configuration.LIST_SETTING.Add(oSetting);
                            }
                        }
                        oList_Dimension_chart_configuration.Add(oDimension_chart_configuration);
                    }
                }
            }

            return oList_Dimension_chart_configuration;
        }
        #endregion
        #region Get_Kpi_chart_configuration
        public List<Kpi_chart_configuration> Get_Kpi_chart_configuration()
        {
            List<Kpi_chart_configuration> oList_Kpi_chart_configuration = null;

            IEnumerable<DALC.Kpi_chart_configuration> oList_DBEntry = _MongoDb.Get_Kpi_chart_configuration();
            if (oList_DBEntry != null)
            {
                oList_Kpi_chart_configuration = new List<Kpi_chart_configuration>();
                if (oList_DBEntry.Count() > 0)
                {
                    oList_Kpi_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_chart_configuration>>(oList_DBEntry);
                }
            }

            return oList_Kpi_chart_configuration;
        }
        #endregion
        #region Get_Specialized_chart_configuration
        public List<Specialized_chart_configuration> Get_Specialized_chart_configuration()
        {
            List<Specialized_chart_configuration> oList_Specialized_chart_configuration = null;

            IEnumerable<DALC.Specialized_chart_configuration> oList_DBEntry = _MongoDb.Get_Specialized_chart_configuration();
            if (oList_DBEntry != null)
            {
                oList_Specialized_chart_configuration = new List<Specialized_chart_configuration>();
                if (oList_DBEntry.Count() > 0)
                {
                    oList_Specialized_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<List<Specialized_chart_configuration>>(oList_DBEntry);
                }
            }

            return oList_Specialized_chart_configuration;
        }
        #endregion
        #region Get_Specialized_chart_configuration_By_MODULE
        public List<Specialized_chart_configuration> Get_Specialized_chart_configuration_By_MODULE(Params_Get_Specialized_chart_configuration_By_MODULE i_Params_Get_Specialized_chart_configuration_By_MODULE)
        {
            List<Specialized_chart_configuration> oList_Specialized_chart_configuration = null;

            IEnumerable<DALC.Specialized_chart_configuration> oList_DBEntry = _MongoDb.Get_Specialized_chart_configuration_By_MODULE(
                MODULE: i_Params_Get_Specialized_chart_configuration_By_MODULE.MODULE
            );
            if (oList_DBEntry != null)
            {
                oList_Specialized_chart_configuration = new List<Specialized_chart_configuration>();
                if (oList_DBEntry.Count() > 0)
                {
                    oList_Specialized_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<List<Specialized_chart_configuration>>(oList_DBEntry);
                }
            }

            return oList_Specialized_chart_configuration;
        }
        #endregion

        #region Edit_Dimension_chart_configuration
        public Dimension_chart_configuration Edit_Dimension_chart_configuration(Dimension_chart_configuration i_Dimension_chart_configuration)
        {
            DALC.Dimension_chart_configuration oDimension_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<DALC.Dimension_chart_configuration>(i_Dimension_chart_configuration);

            i_Dimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID = _MongoDb.Edit_Dimension_chart_configuration
            (
                oDimension_chart_configuration
            );

            return i_Dimension_chart_configuration;
        }
        #endregion
        #region Edit_Kpi_chart_configuration
        public Kpi_chart_configuration Edit_Kpi_chart_configuration(Kpi_chart_configuration i_Kpi_chart_configuration)
        {
            DALC.Kpi_chart_configuration oKpi_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<DALC.Kpi_chart_configuration>(i_Kpi_chart_configuration);

            i_Kpi_chart_configuration.KPI_CHART_CONFIGURATION_ID = _MongoDb.Edit_Kpi_chart_configuration
            (
                oKpi_chart_configuration
            );

            return i_Kpi_chart_configuration;
        }
        #endregion
        #region Edit_Specialized_chart_configuration
        public Specialized_chart_configuration Edit_Specialized_chart_configuration(Specialized_chart_configuration i_Specialized_chart_configuration)
        {
            DALC.Specialized_chart_configuration oSpecialized_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<DALC.Specialized_chart_configuration>(i_Specialized_chart_configuration);

            i_Specialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID = _MongoDb.Edit_Specialized_chart_configuration
            (
                oSpecialized_chart_configuration
            );

            return i_Specialized_chart_configuration;
        }
        #endregion

        #region Delete_Dimension_chart_configuration
        public void Delete_Dimension_chart_configuration(Params_Delete_Dimension_chart_configuration i_Params_Delete_Dimension_chart_configuration)
        {
            try
            {
                _MongoDb.Delete_Dimension_chart_configuration_By_DIMENSION_CHART_CONFIGURATION_ID(i_Params_Delete_Dimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0055).Replace("%1", ex.Message));
            }
        }
        #endregion
        #region Delete_Kpi_chart_configuration
        public void Delete_Kpi_chart_configuration(Params_Delete_Kpi_chart_configuration i_Params_Delete_Kpi_chart_configuration)
        {
            try
            {
                _MongoDb.Delete_Kpi_chart_configuration_By_KPI_CHART_CONFIGURATION_ID(i_Params_Delete_Kpi_chart_configuration.KPI_CHART_CONFIGURATION_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0054).Replace("%1", ex.Message));
            }
        }
        #endregion
        #region Delete_Specialized_chart_configuration
        public void Delete_Specialized_chart_configuration(Params_Delete_Specialized_chart_configuration i_Params_Delete_Specialized_chart_configuration)
        {
            try
            {
                _MongoDb.Delete_Specialized_chart_configuration_By_SPECIALIZED_CHART_CONFIGURATION_ID(i_Params_Delete_Specialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0056).Replace("%1", ex.Message));
            }
        }
        #endregion
        #endregion
        #region GeoJson

        #region Get_District_geojson
        public List<string> Get_District_geojson()
        {
            List<string> oList_District_geojson = new List<string>();

            List<BsonDocument> oList_BsonDocument = _MongoDb.Get_District_geojson();
            if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
            {
                oList_BsonDocument.ForEach(oBsonDocument =>
                {
                    oList_District_geojson.Add(oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }));
                });
            }

            return oList_District_geojson;
        }
        #endregion
        #region Get_Area_geojson
        public List<string> Get_Area_geojson()
        {
            List<string> oList_Area_geojson = new List<string>();

            List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Area_geojson();
            if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
            {
                oList_BsonDocument.ForEach(oBsonDocument =>
                {
                    oList_Area_geojson.Add(oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }));
                });
            }

            return oList_Area_geojson;
        }
        #endregion
        #region Get_Site_geojson
        public List<string> Get_Site_geojson()
        {
            List<string> oList_Site_geojson = new List<string>();

            List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Site_geojson();
            if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
            {
                oList_BsonDocument.ForEach(oBsonDocument =>
                {
                    oList_Site_geojson.Add(oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }));
                });
            }

            return oList_Site_geojson;
        }
        #endregion
        #region Get_Ext_study_zone_geojson
        public List<string> Get_Ext_study_zone_geojson()
        {
            List<string> oList_Ext_study_zone_geojson = new List<string>();

            List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Ext_study_zone_geojson();
            if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
            {
                oList_BsonDocument.ForEach(oBsonDocument =>
                {
                    oList_Ext_study_zone_geojson.Add(oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }));
                });
            }

            return oList_Ext_study_zone_geojson;
        }
        #endregion

        #region Edit_District_geojson
        public string Edit_District_geojson(Params_Edit_District_geojson i_Params_Edit_District_geojson)
        {
            BsonDocument oBsonDocument = BsonDocument.Parse(i_Params_Edit_District_geojson.District_geojson);
            var x = oBsonDocument.ToString();

            oBsonDocument = _MongoDb.Edit_District_geojson
            (
                oBsonDocument
            );

            i_Params_Edit_District_geojson.District_geojson = oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson });

            return i_Params_Edit_District_geojson.District_geojson;
        }
        #endregion
        #region Edit_Area_geojson
        public string Edit_Area_geojson(Params_Edit_Area_geojson i_Params_Edit_Area_geojson)
        {
            BsonDocument oBsonDocument = BsonDocument.Parse(i_Params_Edit_Area_geojson.Area_geojson);

            oBsonDocument = _MongoDb.Edit_Area_geojson
            (
                oBsonDocument
            );

            i_Params_Edit_Area_geojson.Area_geojson = oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson });

            return i_Params_Edit_Area_geojson.Area_geojson;
        }
        #endregion
        #region Edit_Site_geojson
        public string Edit_Site_geojson(Params_Edit_Site_geojson i_Params_Edit_Site_geojson)
        {
            BsonDocument oBsonDocument = BsonDocument.Parse(i_Params_Edit_Site_geojson.Site_geojson);

            oBsonDocument = _MongoDb.Edit_Site_geojson
            (
                oBsonDocument
            );

            i_Params_Edit_Site_geojson.Site_geojson = oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson });

            return i_Params_Edit_Site_geojson.Site_geojson;
        }
        #endregion
        #region Edit_Ext_study_zone_geojson
        public string Edit_Ext_study_zone_geojson(Params_Edit_Ext_study_zone_geojson i_Params_Edit_Ext_study_zone_geojson)
        {
            BsonDocument oBsonDocument = BsonDocument.Parse(i_Params_Edit_Ext_study_zone_geojson.Ext_study_zone_geojson);

            oBsonDocument = _MongoDb.Edit_Ext_study_zone_geojson
            (
                oBsonDocument
            );

            i_Params_Edit_Ext_study_zone_geojson.Ext_study_zone_geojson = oBsonDocument.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson });

            return i_Params_Edit_Ext_study_zone_geojson.Ext_study_zone_geojson;
        }
        #endregion

        #region Delete_District_geojson_By_DISTRICT_ID
        public void Delete_District_geojson_By_DISTRICT_ID(Params_Delete_District_geojson_By_DISTRICT_ID i_Params_Delete_District_geojson_By_DISTRICT_ID)
        {
            try
            {
                _MongoDb.Delete_District_geojson_By_DISTRICT_ID(i_Params_Delete_District_geojson_By_DISTRICT_ID.DISTRICT_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0056).Replace("%1", ex.Message));
            }
        }
        #endregion
        #region Delete_Area_geojson_By_AREA_ID
        public void Delete_Area_geojson_By_AREA_ID(Params_Delete_Area_geojson_By_AREA_ID i_Params_Delete_Area_geojson_By_AREA_ID)
        {
            try
            {
                _MongoDb.Delete_Area_geojson_By_AREA_ID(i_Params_Delete_Area_geojson_By_AREA_ID.AREA_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0056).Replace("%1", ex.Message));
            }
        }
        #endregion
        #region Delete_Site_geojson_By_SITE_ID
        public void Delete_Site_geojson_By_SITE_ID(Params_Delete_Site_geojson_By_SITE_ID i_Params_Delete_Site_geojson_By_SITE_ID)
        {
            try
            {
                _MongoDb.Delete_Site_geojson_By_SITE_ID(i_Params_Delete_Site_geojson_By_SITE_ID.SITE_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0056).Replace("%1", ex.Message));
            }
        }
        #endregion
        #region Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
        public void Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID)
        {
            try
            {
                _MongoDb.Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.EXT_STUDY_ZONE_ID);
            }
            catch (MongoException ex)
            {
                throw new Exception(Get_Message_Content(Enum_BR_Codes.BR_0056).Replace("%1", ex.Message));
            }
        }
        #endregion

        #endregion
        #region Get_UI_Build_Version_List
        public Build_Version_List_With_Logs Get_UI_Build_Version_List()
        {
            Build_Version_List_With_Logs oBuild_Version_List_With_Logs = new Build_Version_List_With_Logs();
            Setup_category oApplication_Name_Setup_Category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Application Name",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup_category oBuild_Log_Type_Setup_Category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Build Log Type",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oApplication_Name_Setup = oApplication_Name_Setup_Category.List_Setup.Find(oSetup => oSetup.VALUE == "Districtnex UI");
            if (oApplication_Name_Setup != null)
            {
                List<Build_version> oList_Build_version = Get_Build_version_By_APPLICATION_NAME_SETUP_ID(new Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID()
                {
                    APPLICATION_NAME_SETUP_ID = oApplication_Name_Setup.SETUP_ID
                });
                oBuild_Version_List_With_Logs.LIST_BUILD_VERSION = oList_Build_version;
                oBuild_Version_List_With_Logs.BUILD_LOG_TYPE_SETUP_CATEGORY = oBuild_Log_Type_Setup_Category;
                return oBuild_Version_List_With_Logs;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Application Name"));
            }
        }
        #endregion
        #region Get_Admin_Build_Version_List
        public Build_Version_List_With_Logs Get_Admin_Build_Version_List()
        {
            Build_Version_List_With_Logs oBuild_Version_List_With_Logs = new Build_Version_List_With_Logs();
            Setup_category oApplication_Name_Setup_Category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Application Name",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup_category oBuild_Log_Type_Setup_Category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Build Log Type",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oApplication_Name_Setup = oApplication_Name_Setup_Category.List_Setup.Find(oSetup => oSetup.VALUE == "Districtnex Admin");
            if (oApplication_Name_Setup != null)
            {
                List<Build_version> oList_Build_version = Get_Build_version_By_APPLICATION_NAME_SETUP_ID(new Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID()
                {
                    APPLICATION_NAME_SETUP_ID = oApplication_Name_Setup.SETUP_ID
                });
                oBuild_Version_List_With_Logs.LIST_BUILD_VERSION = oList_Build_version;
                oBuild_Version_List_With_Logs.BUILD_LOG_TYPE_SETUP_CATEGORY = oBuild_Log_Type_Setup_Category;
                return oBuild_Version_List_With_Logs;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Application Name"));
            }
        }
        #endregion
        #region Custom_Edit_Build_version
        public Build_version Custom_Edit_Build_version(Params_Custom_Edit_Build_version i_Params_Custom_Edit_Build_version)
        {
            if (i_Params_Custom_Edit_Build_version.Build_version.IS_CURRENT)
            {
                List<Build_version> oList_Build_version = Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(new Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID()
                {
                    APPLICATION_NAME_SETUP_ID = i_Params_Custom_Edit_Build_version.Build_version.APPLICATION_NAME_SETUP_ID,
                    IS_CURRENT = true
                }).Select(oBuild_version =>
                {
                    oBuild_version.IS_CURRENT = false;
                    return oBuild_version;
                }).ToList();
                Edit_Build_version_List(new Params_Edit_Build_version_List()
                {
                    List_To_Edit = oList_Build_version
                });
            }
            Edit_Build_version(i_Params_Custom_Edit_Build_version.Build_version);
            return i_Params_Custom_Edit_Build_version.Build_version;
        }
        #endregion
    }
}