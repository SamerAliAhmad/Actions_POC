using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        #region Get_Dimension_index_By_Where
        public List<Dimension_index> Get_Dimension_index_By_Where(Params_Get_Dimension_index_By_Where i_Params_Get_Dimension_index_By_Where)
        {
            List<Dimension_index> oList_Dimension_index = null;

            if (i_Params_Get_Dimension_index_By_Where.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            List<DALC.Dimension_index> oList_DBEntry = _MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: i_Params_Get_Dimension_index_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Dimension_index_By_Where.END_DATE,
                    LIST_DIMENSION_ID: i_Params_Get_Dimension_index_By_Where.LIST_DIMENSION_ID,
                    LIST_LEVEL_ID: i_Params_Get_Dimension_index_By_Where.LIST_LEVEL_ID,
                    LEVEL_SETUP_ID: i_Params_Get_Dimension_index_By_Where.LEVEL_SETUP_ID,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Dimension_index_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Dimension_index = new List<Dimension_index>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension_index oDimension_index = new Dimension_index();
                        Dimension_metadata oDimension_metadata = new Dimension_metadata();
                        Props.Copy_Prop_Values(oDBEntry, oDimension_index);
                        Props.Copy_Prop_Values(oDBEntry.DIMENSION_METADATA, oDimension_metadata);
                        oDimension_index.DIMENSION_METADATA = oDimension_metadata;
                        oList_Dimension_index.Add(oDimension_index);
                    }
                }
            }
            return oList_Dimension_index;
        }
        #endregion
        #region Insert_Dimension_index_List
        public void Insert_Dimension_index_List(Params_Insert_Dimension_index_List i_Params_Insert_Dimension_index_List)
        {
            if (i_Params_Insert_Dimension_index_List.LIST_DIMENSION_INDEX != null && i_Params_Insert_Dimension_index_List.LIST_DIMENSION_INDEX.Count > 0)
            {
                if (i_Params_Insert_Dimension_index_List.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }

                List<DALC.Dimension_index> oList_Dimension_index = new List<DALC.Dimension_index>();
                foreach (Dimension_index dimension_index in i_Params_Insert_Dimension_index_List.LIST_DIMENSION_INDEX)
                {
                    DALC.Dimension_metadata oDimension_metadata = new DALC.Dimension_metadata()
                    {
                        DIMENSION_ID = dimension_index.DIMENSION_METADATA.DIMENSION_ID,
                        LEVEL_ID = dimension_index.DIMENSION_METADATA.LEVEL_ID,
                        LEVEL_SETUP_ID = dimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                    };
                    DALC.Dimension_index oDimension_index = new DALC.Dimension_index()
                    {
                        RECORD_DATE = new DateTime(dimension_index.RECORD_DATE.Year, dimension_index.RECORD_DATE.Month, dimension_index.RECORD_DATE.Day, dimension_index.RECORD_DATE.Hour, dimension_index.RECORD_DATE.Minute, dimension_index.RECORD_DATE.Second, DateTimeKind.Utc),
                        DIMENSION_METADATA = oDimension_metadata,
                        VALUE = dimension_index.VALUE,
                    };

                    oList_Dimension_index.Add(oDimension_index);
                }
                _MongoDb.Insert_Dimension_index_List(
                    LIST_DIMENSION_INDEX: oList_Dimension_index,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Insert_Dimension_index_List.ENUM_TIMESPAN
                );
            }
        }
        #endregion
        #region Delete_Dimension_index_By_Where
        public void Delete_Dimension_index_By_Where(Params_Delete_Dimension_index_By_Where i_Params_Delete_Dimension_index_By_Where)
        {
            if (i_Params_Delete_Dimension_index_By_Where.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            _MongoDb.Delete_Dimension_index_By_Where(
                    LIST_DIMENSION_ID: i_Params_Delete_Dimension_index_By_Where.LIST_DIMENSION_ID,
                    LIST_LEVEL_ID: i_Params_Delete_Dimension_index_By_Where.LIST_LEVEL_ID,
                    LEVEL_SETUP_ID: i_Params_Delete_Dimension_index_By_Where.LEVEL_SETUP_ID,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Delete_Dimension_index_By_Where.ENUM_TIMESPAN
                );
        }
        #endregion
        #region Get_Latest_Dimension_index_By_Where
        public List<Dimension_index_By_Level> Get_Latest_Dimension_index_By_Where(Params_Get_Latest_Dimension_index_By_Where i_Params_Get_Latest_Dimension_index_By_Where)
        {
            List<Dimension_index_By_Level> oList_Dimension_index_By_Level = null;

            if (i_Params_Get_Latest_Dimension_index_By_Where.START_DATE != null && i_Params_Get_Latest_Dimension_index_By_Where.END_DATE != null &&
                i_Params_Get_Latest_Dimension_index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID != null && i_Params_Get_Latest_Dimension_index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID.Count > 0 &&
                i_Params_Get_Latest_Dimension_index_By_Where.LEVEL_SETUP_ID != null && i_Params_Get_Latest_Dimension_index_By_Where.ENUM_TIMESPAN != null)
            {
                if (i_Params_Get_Latest_Dimension_index_By_Where.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }

                List<int?> List_Dimension_ID = new List<int?>();

                foreach (Dimension_ID_By_Level_ID oDimension_ID_By_Level_ID in i_Params_Get_Latest_Dimension_index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID)
                {
                    List_Dimension_ID = List_Dimension_ID.Concat(oDimension_ID_By_Level_ID.LIST_DIMENSION_ID).ToList();
                }

                List_Dimension_ID = List_Dimension_ID.Distinct().ToList();

                List<DALC.Dimension_index> oList_DBEntry = _MongoDb.Get_Latest_Dimension_index_By_Where(
                    START_DATE: i_Params_Get_Latest_Dimension_index_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Latest_Dimension_index_By_Where.END_DATE,
                    LIST_DIMENSION_ID: List_Dimension_ID,
                    LIST_LEVEL_ID: i_Params_Get_Latest_Dimension_index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID.Select(oDimension_ID_By_Level_ID => oDimension_ID_By_Level_ID.LEVEL_ID).ToList(),
                    LEVEL_SETUP_ID: i_Params_Get_Latest_Dimension_index_By_Where.LEVEL_SETUP_ID,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Latest_Dimension_index_By_Where.ENUM_TIMESPAN
                );

                if (oList_DBEntry != null)
                {
                    oList_Dimension_index_By_Level = new List<Dimension_index_By_Level>();

                    if (oList_DBEntry.Count > 0)
                    {
                        List<Dimension_index> oList_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(oList_DBEntry);

                        var Grouped_Dimension_index = oList_Dimension_index.GroupBy(oDimension_index => oDimension_index.DIMENSION_METADATA.LEVEL_ID);

                        Dimension_index_By_Level oDimension_index_By_Level;

                        foreach (var oDimension_index_group in Grouped_Dimension_index)
                        {
                            oDimension_index_By_Level = new Dimension_index_By_Level();
                            oDimension_index_By_Level.LEVEL_ID = oDimension_index_group.Key;
                            oDimension_index_By_Level.LIST_DIMENSION_INDEX = oDimension_index_group.Select(oDimension_index => oDimension_index).ToList();
                            oList_Dimension_index_By_Level.Add(oDimension_index_By_Level);
                        }

                        foreach (Dimension_ID_By_Level_ID oDimension_ID_By_Level_ID in i_Params_Get_Latest_Dimension_index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID)
                        {
                            oList_Dimension_index_By_Level.Find(oDimension_index_By_Level => oDimension_index_By_Level.LEVEL_ID == oDimension_ID_By_Level_ID.LEVEL_ID).LIST_DIMENSION_INDEX
                                                          .RemoveAll(oDimension_index => !oDimension_ID_By_Level_ID.LIST_DIMENSION_ID.Contains(oDimension_index.DIMENSION_METADATA.DIMENSION_ID));


                        }
                    }
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Dimension_index_By_Level;
        }
        #endregion

        #region Generate_Dimension_Index_Daily
        public void Generate_Dimension_Index_Daily(Params_Generate_Dimension_Index_Daily i_Params_Generate_Dimension_Index_Daily)
        {
            DateTime CurrentDate = new DateTime(i_Params_Generate_Dimension_Index_Daily.YEAR, i_Params_Generate_Dimension_Index_Daily.MONTH, i_Params_Generate_Dimension_Index_Daily.DAY, 0, 0, 0).AddDays(-1);

            #region Declaration & Initialization

            List<Dimension_index> oList_Space_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Floor_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Entity_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Site_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Area_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_District_Dimension_index = new List<Dimension_index>();

            #endregion

            #region Get Levels

            List<Space> oList_Space = new List<Space>();
            List<Floor> oList_Floor = new List<Floor>();
            List<Entity> oList_Entity = new List<Entity>();
            List<Site> oList_Site = new List<Site>();
            List<Area> oList_Area = new List<Area>();
            List<District> oList_District = new List<District>();

            var get_space = Task.Run(() =>
            {
                oList_Space = Props.Copy_Prop_Values_From_Api_Response<List<Space>>(this._service_mesh.Get_Space_By_OWNER_ID(new Service_Mesh.Params_Get_Space_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_floor = Task.Run(() =>
            {
                oList_Floor = Props.Copy_Prop_Values_From_Api_Response<List<Floor>>(this._service_mesh.Get_Floor_By_OWNER_ID(new Service_Mesh.Params_Get_Floor_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_entity = Task.Run(() =>
            {
                oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_site = Task.Run(() =>
            {
                oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_area = Task.Run(() =>
            {
                oList_Area = Props.Copy_Prop_Values_From_Api_Response<List<Area>>(this._service_mesh.Get_Area_By_OWNER_ID(new Service_Mesh.Params_Get_Area_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_district = Task.Run(() =>
            {
                oList_District = Props.Copy_Prop_Values_From_Api_Response<List<District>>(this._service_mesh.Get_District_By_OWNER_ID(new Service_Mesh.Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });

            Task.WaitAll(get_space, get_floor, get_entity, get_site, get_area, get_district);

            var assign_space_to_floor = Task.Run(() =>
            {
                oList_Floor = oList_Floor.Select(oFloor =>
                {
                    oFloor.List_Space = oList_Space.Where(oSpace => oSpace.FLOOR_ID == oFloor.FLOOR_ID).ToList();
                    return oFloor;
                }).ToList();
            });

            var assign_floor_to_entity = Task.Run(() =>
            {
                oList_Entity = oList_Entity.Select(oEntity =>
                {
                    oEntity.List_Floor = oList_Floor.Where(oFloor => oFloor.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                    return oEntity;
                }).ToList();
            });

            var assign_entity_to_site = Task.Run(() =>
            {
                oList_Site = oList_Site.Select(oSite =>
                {
                    oSite.List_Entity = oList_Entity.Where(oEntity => oEntity.SITE_ID == oSite.SITE_ID).ToList();
                    return oSite;
                }).ToList();
            });

            var assign_site_to_area = Task.Run(() =>
            {
                oList_Area = oList_Area.Select(oArea =>
                {
                    oArea.List_Site = oList_Site.Where(oSite => oSite.AREA_ID == oArea.AREA_ID).ToList();
                    return oArea;
                }).ToList();
            });

            var assign_area_to_district = Task.Run(() =>
            {
                oList_District = oList_District.Select(oDistrict =>
                {
                    oDistrict.List_Area = oList_Area.Where(oArea => oArea.DISTRICT_ID == oDistrict.DISTRICT_ID).ToList();
                    return oDistrict;
                }).ToList();
            });

            Task.WaitAll();

            #endregion

            #region Get Level Setup

            List<Setup> oList_Setup = Props.Copy_Prop_Values_From_Api_Response<List<Setup>>(this._service_mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Data Level"
            }).i_Result.List_Setup);
            Setup oSpace_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Space");
            Setup oFloor_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Floor");
            Setup oEntity_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Entity");
            Setup oSite_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Site");
            Setup oArea_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Area");
            Setup oDistrict_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "District");

            #endregion

            #region Get Main Dimensions

            List<Dimension> oList_Dimension = i_Params_Generate_Dimension_Index_Daily.LIST_DIMENSION;

            #endregion

            #region Generate Space Dimension Data

            decimal MINIMUM_VALUE = 0;
            decimal MAXIMUM_VALUE = 100;

            oList_Dimension.ForEach(oDimension =>
            {
                oList_Space.ForEach(oSpace =>
                {
                    decimal randomValue = Tools.Get_Random_Decimal() * (MAXIMUM_VALUE - MINIMUM_VALUE) + MINIMUM_VALUE;
                    oList_Space_Dimension_index.Add(new Dimension_index()
                    {
                        VALUE = randomValue,
                        RECORD_DATE = CurrentDate,
                        DIMENSION_METADATA = new Dimension_metadata()
                        {
                            LEVEL_ID = (long)oSpace.SPACE_ID,
                            DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                            LEVEL_SETUP_ID = (long)oSpace_Setup.SETUP_ID,
                        },
                    });
                });
            });

            #endregion

            #region Compute Floor Dimension Data

            if (oList_Space_Dimension_index.Count > 0)
            {
                foreach (Dimension oDimension in oList_Dimension)
                {
                    foreach (Floor oFloor in oList_Floor)
                    {
                        List<Dimension_index> oList_Space_Dimension_index_To_Use = oList_Space_Dimension_index.Where(oDimension_index => oFloor.List_Space.Any(oSpace => oSpace.SPACE_ID == oDimension_index.DIMENSION_METADATA.LEVEL_ID) && oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                        if (oList_Space_Dimension_index_To_Use.Count > 0)
                        {
                            oList_Floor_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oFloor.FLOOR_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oFloor_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = oList_Space_Dimension_index_To_Use.Average(oDimension_index => oDimension_index.VALUE)
                            });
                        }
                        else
                        {
                            decimal randomValue = (decimal)(Tools.Get_Random_Decimal() * (MAXIMUM_VALUE - MINIMUM_VALUE) + MINIMUM_VALUE);
                            oList_Floor_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oFloor.FLOOR_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oFloor_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = randomValue
                            });
                        }
                    }
                }
            }

            #endregion

            #region Compute Entity Dimension Data

            if (oList_Floor_Dimension_index.Count > 0)
            {
                foreach (Dimension oDimension in oList_Dimension)
                {
                    foreach (Entity oEntity in oList_Entity)
                    {
                        List<Dimension_index> oList_Floor_Dimension_index_To_Use = oList_Floor_Dimension_index.Where(oDimension_index => oEntity.List_Floor.Any(oFloor => oFloor.FLOOR_ID == oDimension_index.DIMENSION_METADATA.LEVEL_ID) && oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                        if (oList_Floor_Dimension_index_To_Use.Count > 0)
                        {
                            oList_Entity_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oEntity.ENTITY_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oEntity_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = oList_Floor_Dimension_index_To_Use.Average(oDimension_index => oDimension_index.VALUE)
                            });
                        }
                        else
                        {
                            decimal randomValue = (decimal)(Tools.Get_Random_Decimal() * (MAXIMUM_VALUE - MINIMUM_VALUE) + MINIMUM_VALUE);
                            oList_Entity_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oEntity.ENTITY_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oEntity_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = randomValue
                            });
                        }
                    }
                }
            }

            #endregion

            #region Compute Site Dimension Data

            if (oList_Entity_Dimension_index.Count > 0)
            {
                foreach (Dimension oDimension in oList_Dimension)
                {
                    foreach (Site oSite in oList_Site)
                    {
                        List<Dimension_index> oList_Entity_Dimension_index_To_Use = oList_Entity_Dimension_index.Where(oDimension_index => oSite.List_Entity.Any(oEntity => oEntity.ENTITY_ID == oDimension_index.DIMENSION_METADATA.LEVEL_ID) && oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                        if (oList_Entity_Dimension_index_To_Use.Count > 0)
                        {
                            oList_Site_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oSite.SITE_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oSite_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = oList_Entity_Dimension_index_To_Use.Average(oDimension_index => oDimension_index.VALUE)
                            });
                        }
                        else
                        {
                            decimal randomValue = (decimal)(Tools.Get_Random_Decimal() * (MAXIMUM_VALUE - MINIMUM_VALUE) + MINIMUM_VALUE);
                            oList_Site_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oSite.SITE_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oSite_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = randomValue
                            });
                        }
                    }
                }
            }

            #endregion

            #region Compute Area Dimension Data

            if (oList_Site_Dimension_index.Count > 0)
            {
                foreach (Dimension oDimension in oList_Dimension)
                {
                    foreach (Area oArea in oList_Area)
                    {
                        List<Dimension_index> oList_Site_Dimension_index_To_Use = oList_Site_Dimension_index.Where(oDimension_index => oArea.List_Site.Any(oSite => oSite.SITE_ID == oDimension_index.DIMENSION_METADATA.LEVEL_ID) && oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                        if (oList_Site_Dimension_index_To_Use.Count > 0)
                        {
                            oList_Area_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oArea.AREA_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oArea_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = oList_Site_Dimension_index_To_Use.Average(oDimension_index => oDimension_index.VALUE)
                            });
                        }
                        else
                        {
                            decimal randomValue = (decimal)(Tools.Get_Random_Decimal() * (MAXIMUM_VALUE - MINIMUM_VALUE) + MINIMUM_VALUE);
                            oList_Area_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oArea.AREA_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oArea_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = randomValue
                            });
                        }
                    }
                }
            }

            #endregion

            #region Compute District Dimension Data

            if (oList_Area_Dimension_index.Count > 0)
            {
                foreach (Dimension oDimension in oList_Dimension)
                {
                    foreach (District oDistrict in oList_District)
                    {
                        List<Dimension_index> oList_Area_Dimension_index_To_Use = oList_Area_Dimension_index.Where(oDimension_index => oDistrict.List_Area.Any(oArea => oArea.AREA_ID == oDimension_index.DIMENSION_METADATA.LEVEL_ID) && oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                        if (oList_Area_Dimension_index_To_Use.Count > 0)
                        {
                            oList_District_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oDistrict.DISTRICT_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oDistrict_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = oList_Area_Dimension_index_To_Use.Average(oDimension_index => oDimension_index.VALUE)
                            });
                        }
                        else
                        {
                            decimal randomValue = (decimal)(Tools.Get_Random_Decimal() * (MAXIMUM_VALUE - MINIMUM_VALUE) + MINIMUM_VALUE);
                            oList_District_Dimension_index.Add(new Dimension_index()
                            {
                                DIMENSION_METADATA = new Dimension_metadata()
                                {
                                    LEVEL_ID = (long)oDistrict.DISTRICT_ID,
                                    DIMENSION_ID = (int)oDimension.DIMENSION_ID,
                                    LEVEL_SETUP_ID = (long)oDistrict_Setup.SETUP_ID
                                },
                                RECORD_DATE = CurrentDate,
                                VALUE = randomValue
                            });
                        }
                    }
                }
            }

            #endregion

            #region Send Data

            List<Dimension_index> oList_Dimension_index = new List<Dimension_index>();
            oList_Dimension_index = oList_Dimension_index.Concat(oList_Space_Dimension_index)
                                                         .Concat(oList_Floor_Dimension_index)
                                                         .Concat(oList_Entity_Dimension_index)
                                                         .Concat(oList_Site_Dimension_index)
                                                         .Concat(oList_Area_Dimension_index)
                                                         .Concat(oList_District_Dimension_index)
                                                         .ToList();

            if (oList_Dimension_index.Count > 0)
            {
                Edit_Dimension_index_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Dimension_index_List_By_RECORD_DATE()
                {
                    RECORD_DATE = CurrentDate,
                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                    LIST_DIMENSION_ID = i_Params_Generate_Dimension_Index_Daily.LIST_DIMENSION.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_DIMENSION_INDEX = oList_Dimension_index
                });
            }

            #endregion
        }
        #endregion
        #region Compute_Dimension_Index_Weekly
        public void Compute_Dimension_Index_Weekly(Params_Compute_Dimension_Index_Weekly i_Params_Compute_Dimension_Index_Weekly)
        {
            DateTime CurrentDate = new DateTime(i_Params_Compute_Dimension_Index_Weekly.YEAR, i_Params_Compute_Dimension_Index_Weekly.MONTH, i_Params_Compute_Dimension_Index_Weekly.DAY, 0, 0, 0);

            #region Declaration & Initialization

            List<Dimension_index> oList_Space_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Floor_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Entity_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Site_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Area_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_District_Dimension_index = new List<Dimension_index>();

            List<Dimension_index> oList_Space_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Floor_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Entity_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Site_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Area_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_District_Dimension_index_To_Save = new List<Dimension_index>();

            #endregion

            #region Get Level Setup

            List<Setup> oList_Setup = Props.Copy_Prop_Values_From_Api_Response<List<Setup>>(this._service_mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Data Level"
            }).i_Result.List_Setup);
            Setup oSpace_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Space");
            Setup oFloor_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Floor");
            Setup oEntity_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Entity");
            Setup oSite_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Site");
            Setup oArea_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Area");
            Setup oDistrict_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "District");

            #endregion

            #region Get Levels

            List<Space> oList_Space = new List<Space>();
            List<Floor> oList_Floor = new List<Floor>();
            List<Entity> oList_Entity = new List<Entity>();
            List<Site> oList_Site = new List<Site>();
            List<Area> oList_Area = new List<Area>();
            List<District> oList_District = new List<District>();

            var get_space = Task.Run(() =>
            {
                oList_Space = Props.Copy_Prop_Values_From_Api_Response<List<Space>>(this._service_mesh.Get_Space_By_OWNER_ID(new Service_Mesh.Params_Get_Space_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_floor = Task.Run(() =>
            {
                oList_Floor = Props.Copy_Prop_Values_From_Api_Response<List<Floor>>(this._service_mesh.Get_Floor_By_OWNER_ID(new Service_Mesh.Params_Get_Floor_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_entity = Task.Run(() =>
            {
                oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_site = Task.Run(() =>
            {
                oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_area = Task.Run(() =>
            {
                oList_Area = Props.Copy_Prop_Values_From_Api_Response<List<Area>>(this._service_mesh.Get_Area_By_OWNER_ID(new Service_Mesh.Params_Get_Area_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_district = Task.Run(() =>
            {
                oList_District = Props.Copy_Prop_Values_From_Api_Response<List<District>>(this._service_mesh.Get_District_By_OWNER_ID(new Service_Mesh.Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });

            Task.WaitAll(get_space, get_floor, get_entity, get_site, get_area, get_district);

            #endregion

            #region Get Main Dimensions

            List<Dimension> oList_Dimension = i_Params_Compute_Dimension_Index_Weekly.LIST_DIMENSION;

            #endregion

            #region Get Dimension Index

            var get_space_dimension_index = Task.Run(() =>
            {
                oList_Space_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddDays(-7),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Space.Select(oSpace => oSpace.SPACE_ID).ToList(),
                    LEVEL_SETUP_ID: oSpace_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_floor_dimension_index = Task.Run(() =>
            {
                oList_Floor_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddDays(-7),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Floor.Select(oFloor => oFloor.FLOOR_ID).ToList(),
                    LEVEL_SETUP_ID: oFloor_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_entity_dimension_index = Task.Run(() =>
            {
                oList_Entity_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddDays(-7),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList(),
                    LEVEL_SETUP_ID: oEntity_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_site_dimension_index = Task.Run(() =>
            {
                oList_Site_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddDays(-7),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Site.Select(oSite => oSite.SITE_ID).ToList(),
                    LEVEL_SETUP_ID: oSite_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_area_dimension_index = Task.Run(() =>
            {
                oList_Area_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddDays(-7),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Area.Select(oArea => oArea.AREA_ID).ToList(),
                    LEVEL_SETUP_ID: oArea_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_district_dimension_index = Task.Run(() =>
            {
                oList_District_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddDays(-7),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_District.Select(oDistrict => oDistrict.DISTRICT_ID).ToList(),
                    LEVEL_SETUP_ID: oDistrict_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            Task.WaitAll(get_space_dimension_index, get_floor_dimension_index, get_entity_dimension_index, get_site_dimension_index, get_area_dimension_index, get_district_dimension_index);

            #endregion

            #region Compute Dimension Data

            var compute_space = Task.Run(() =>
            {
                if (oList_Space_Dimension_index.Count > 0)
                {
                    oList_Space_Dimension_index_To_Save = oList_Space_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddDays(-7),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_floor = Task.Run(() =>
            {
                if (oList_Floor_Dimension_index.Count > 0)
                {
                    oList_Floor_Dimension_index_To_Save = oList_Floor_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddDays(-7),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_entity = Task.Run(() =>
            {
                if (oList_Entity_Dimension_index.Count > 0)
                {
                    oList_Entity_Dimension_index_To_Save = oList_Entity_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddDays(-7),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_site = Task.Run(() =>
            {
                if (oList_Site_Dimension_index.Count > 0)
                {
                    oList_Site_Dimension_index_To_Save = oList_Site_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddDays(-7),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_area = Task.Run(() =>
            {
                if (oList_Area_Dimension_index.Count > 0)
                {
                    oList_Area_Dimension_index_To_Save = oList_Area_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddDays(-7),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_district = Task.Run(() =>
            {
                if (oList_District_Dimension_index.Count > 0)
                {
                    oList_District_Dimension_index_To_Save = oList_District_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddDays(-7),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            Task.WaitAll(compute_space, compute_floor, compute_entity, compute_site, compute_area, compute_district);

            #endregion

            #region Send Data

            List<Dimension_index> oList_Dimension_index = new List<Dimension_index>();
            oList_Dimension_index.Add(new Dimension_index());
            if (oList_Space_Dimension_index_To_Save != null && oList_Space_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Space_Dimension_index_To_Save).ToList();
            }
            if (oList_Floor_Dimension_index_To_Save != null && oList_Floor_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Floor_Dimension_index_To_Save).ToList();
            }
            if (oList_Entity_Dimension_index_To_Save != null && oList_Entity_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Entity_Dimension_index_To_Save).ToList();
            }
            if (oList_Site_Dimension_index_To_Save != null && oList_Site_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Site_Dimension_index_To_Save).ToList();
            }
            if (oList_Area_Dimension_index_To_Save != null && oList_Area_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Area_Dimension_index_To_Save).ToList();
            }
            if (oList_District_Dimension_index_To_Save != null && oList_District_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_District_Dimension_index_To_Save).ToList();
            }
            oList_Dimension_index.RemoveAt(0);

            if (oList_Dimension_index.Count > 0)
            {
                Edit_Dimension_index_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Dimension_index_List_By_RECORD_DATE()
                {
                    RECORD_DATE = CurrentDate,
                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION,
                    LIST_DIMENSION_ID = i_Params_Compute_Dimension_Index_Weekly.LIST_DIMENSION.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_DIMENSION_INDEX = oList_Dimension_index
                });
            }

            #endregion
        }
        #endregion
        #region Compute_Dimension_Index_Monthly
        public void Compute_Dimension_Index_Monthly(Params_Compute_Dimension_Index_Monthly i_Params_Compute_Dimension_Index_Monthly)
        {
            DateTime CurrentDate = new DateTime(i_Params_Compute_Dimension_Index_Monthly.YEAR, i_Params_Compute_Dimension_Index_Monthly.MONTH, i_Params_Compute_Dimension_Index_Monthly.DAY, 0, 0, 0);

            #region Declaration & Initialization

            List<Dimension_index> oList_Space_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Floor_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Entity_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Site_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_Area_Dimension_index = new List<Dimension_index>();
            List<Dimension_index> oList_District_Dimension_index = new List<Dimension_index>();

            List<Dimension_index> oList_Space_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Floor_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Entity_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Site_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_Area_Dimension_index_To_Save = new List<Dimension_index>();
            List<Dimension_index> oList_District_Dimension_index_To_Save = new List<Dimension_index>();

            #endregion

            #region Get Level Setup

            List<Setup> oList_Setup = Props.Copy_Prop_Values_From_Api_Response<List<Setup>>(this._service_mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Data Level"
            }).i_Result.List_Setup);
            Setup oSpace_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Space");
            Setup oFloor_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Floor");
            Setup oEntity_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Entity");
            Setup oSite_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Site");
            Setup oArea_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "Area");
            Setup oDistrict_Setup = oList_Setup.Find(oSetup => oSetup.VALUE == "District");

            #endregion

            #region Get Levels

            List<Space> oList_Space = new List<Space>();
            List<Floor> oList_Floor = new List<Floor>();
            List<Entity> oList_Entity = new List<Entity>();
            List<Site> oList_Site = new List<Site>();
            List<Area> oList_Area = new List<Area>();
            List<District> oList_District = new List<District>();

            var get_space = Task.Run(() =>
            {
                oList_Space = Props.Copy_Prop_Values_From_Api_Response<List<Space>>(this._service_mesh.Get_Space_By_OWNER_ID(new Service_Mesh.Params_Get_Space_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_floor = Task.Run(() =>
            {
                oList_Floor = Props.Copy_Prop_Values_From_Api_Response<List<Floor>>(this._service_mesh.Get_Floor_By_OWNER_ID(new Service_Mesh.Params_Get_Floor_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_entity = Task.Run(() =>
            {
                oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_site = Task.Run(() =>
            {
                oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_area = Task.Run(() =>
            {
                oList_Area = Props.Copy_Prop_Values_From_Api_Response<List<Area>>(this._service_mesh.Get_Area_By_OWNER_ID(new Service_Mesh.Params_Get_Area_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });
            var get_district = Task.Run(() =>
            {
                oList_District = Props.Copy_Prop_Values_From_Api_Response<List<District>>(this._service_mesh.Get_District_By_OWNER_ID(new Service_Mesh.Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);
            });

            Task.WaitAll(get_space, get_floor, get_entity, get_site, get_area, get_district);

            #endregion

            #region Get Main Dimensions

            List<Dimension> oList_Dimension = i_Params_Compute_Dimension_Index_Monthly.LIST_DIMENSION;

            #endregion

            #region Get Dimension Index

            var get_space_dimension_index = Task.Run(() =>
            {
                oList_Space_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddMonths(-1),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Space.Select(oSpace => oSpace.SPACE_ID).ToList(),
                    LEVEL_SETUP_ID: oSpace_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_floor_dimension_index = Task.Run(() =>
            {
                oList_Floor_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddMonths(-1),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Floor.Select(oFloor => oFloor.FLOOR_ID).ToList(),
                    LEVEL_SETUP_ID: oFloor_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_entity_dimension_index = Task.Run(() =>
            {
                oList_Entity_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddMonths(-1),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList(),
                    LEVEL_SETUP_ID: oEntity_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_site_dimension_index = Task.Run(() =>
            {
                oList_Site_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddMonths(-1),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Site.Select(oSite => oSite.SITE_ID).ToList(),
                    LEVEL_SETUP_ID: oSite_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_area_dimension_index = Task.Run(() =>
            {
                oList_Area_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddMonths(-1),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_Area.Select(oArea => oArea.AREA_ID).ToList(),
                    LEVEL_SETUP_ID: oArea_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            var get_district_dimension_index = Task.Run(() =>
            {
                oList_District_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: CurrentDate.AddMonths(-1),
                    END_DATE: CurrentDate,
                    LIST_DIMENSION_ID: oList_Dimension.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_LEVEL_ID: oList_District.Select(oDistrict => oDistrict.DISTRICT_ID).ToList(),
                    LEVEL_SETUP_ID: oDistrict_Setup.SETUP_ID,
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION
                ));
            });

            Task.WaitAll(get_space_dimension_index, get_floor_dimension_index, get_entity_dimension_index, get_site_dimension_index, get_area_dimension_index, get_district_dimension_index);

            #endregion

            #region Compute Dimension Data

            var compute_space = Task.Run(() =>
            {
                if (oList_Space_Dimension_index.Count > 0)
                {
                    oList_Space_Dimension_index_To_Save = oList_Space_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddMonths(-1),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_floor = Task.Run(() =>
            {
                if (oList_Floor_Dimension_index.Count > 0)
                {
                    oList_Floor_Dimension_index_To_Save = oList_Floor_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddMonths(-1),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_entity = Task.Run(() =>
            {
                if (oList_Entity_Dimension_index.Count > 0)
                {
                    oList_Entity_Dimension_index_To_Save = oList_Entity_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddMonths(-1),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_site = Task.Run(() =>
            {
                if (oList_Site_Dimension_index.Count > 0)
                {
                    oList_Site_Dimension_index_To_Save = oList_Site_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddMonths(-1),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_area = Task.Run(() =>
            {
                if (oList_Area_Dimension_index.Count > 0)
                {
                    oList_Area_Dimension_index_To_Save = oList_Area_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddMonths(-1),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            var compute_district = Task.Run(() =>
            {
                if (oList_District_Dimension_index.Count > 0)
                {
                    oList_District_Dimension_index_To_Save = oList_District_Dimension_index
                                                        .GroupBy(oDimension_index => new
                                                        {
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_ID,
                                                            oDimension_index.DIMENSION_METADATA.DIMENSION_ID,
                                                            oDimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID,
                                                        })
                                                        .Select(group =>
                                                        {
                                                            var averageValue = group.Average(oDimension_index => oDimension_index.VALUE);

                                                            var dimensionMetadata = new Dimension_metadata()
                                                            {
                                                                LEVEL_ID = group.Key.LEVEL_ID,
                                                                LEVEL_SETUP_ID = group.Key.LEVEL_SETUP_ID,
                                                                DIMENSION_ID = group.Key.DIMENSION_ID,
                                                            };

                                                            return new Dimension_index()
                                                            {
                                                                DIMENSION_METADATA = dimensionMetadata,
                                                                RECORD_DATE = CurrentDate.AddMonths(-1),
                                                                VALUE = averageValue,
                                                            };
                                                        })
                                                        .ToList();
                }
            });

            Task.WaitAll(compute_space, compute_floor, compute_entity, compute_site, compute_area, compute_district);

            #endregion

            #region Send Data

            List<Dimension_index> oList_Dimension_index = new List<Dimension_index>();
            oList_Dimension_index.Add(new Dimension_index());
            if (oList_Space_Dimension_index_To_Save != null && oList_Space_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Space_Dimension_index_To_Save).ToList();
            }
            if (oList_Floor_Dimension_index_To_Save != null && oList_Floor_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Floor_Dimension_index_To_Save).ToList();
            }
            if (oList_Entity_Dimension_index_To_Save != null && oList_Entity_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Entity_Dimension_index_To_Save).ToList();
            }
            if (oList_Site_Dimension_index_To_Save != null && oList_Site_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Site_Dimension_index_To_Save).ToList();
            }
            if (oList_Area_Dimension_index_To_Save != null && oList_Area_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_Area_Dimension_index_To_Save).ToList();
            }
            if (oList_District_Dimension_index_To_Save != null && oList_District_Dimension_index_To_Save.Count > 0)
            {
                oList_Dimension_index = oList_Dimension_index.Concat(oList_District_Dimension_index_To_Save).ToList();
            }
            oList_Dimension_index.RemoveAt(0);

            if (oList_Dimension_index.Count > 0)
            {
                Edit_Dimension_index_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Dimension_index_List_By_RECORD_DATE()
                {
                    RECORD_DATE = CurrentDate,
                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION,
                    LIST_DIMENSION_ID = i_Params_Compute_Dimension_Index_Monthly.LIST_DIMENSION.Select(oDimension => oDimension.DIMENSION_ID).ToList(),
                    LIST_DIMENSION_INDEX = oList_Dimension_index
                });
            }

            #endregion
        }
        #endregion
        #region Edit_Dimension_index_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_Dimension_index_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_Dimension_index_List_By_RECORD_DATE i_Params_Edit_Dimension_index_List_By_RECORD_DATE)
        {
            List<Dimension_index> oList_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(this._MongoDb.Get_Dimension_index_By_Where(
                START_DATE: i_Params_Edit_Dimension_index_List_By_RECORD_DATE.RECORD_DATE,
                END_DATE: i_Params_Edit_Dimension_index_List_By_RECORD_DATE.RECORD_DATE.Value.AddSeconds(1),
                LIST_DIMENSION_ID: i_Params_Edit_Dimension_index_List_By_RECORD_DATE.LIST_DIMENSION_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_Dimension_index_List_By_RECORD_DATE.ENUM_TIMESPAN,
                LEVEL_SETUP_ID: null,
                LIST_LEVEL_ID: null
            ));

            if (oList_Dimension_index?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Dimension_index").Replace("%2", i_Params_Edit_Dimension_index_List_By_RECORD_DATE.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_Dimension_index_List(new Params_Insert_Dimension_index_List()
            {
                LIST_DIMENSION_INDEX = i_Params_Edit_Dimension_index_List_By_RECORD_DATE.LIST_DIMENSION_INDEX,
                ENUM_TIMESPAN = i_Params_Edit_Dimension_index_List_By_RECORD_DATE.ENUM_TIMESPAN
            });
        }
        #endregion
    }
}