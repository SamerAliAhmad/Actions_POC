using System;
using RestSharp;
using System.Linq;
using SmartrTools;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace BLC
{
    public partial class BLC
    {
        #region Utils

        #region Get_Timezone
        public string Get_Timezone(string timeInfo)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var olsonWindowsTimes = new Dictionary<string, string>()
                {
                    { "Africa/Bangui", "W. Central Africa Standard Time" },
                    { "Africa/Cairo", "Egypt Standard Time" },
                    { "Africa/Casablanca", "Morocco Standard Time" },
                    { "Africa/Harare", "South Africa Standard Time" },
                    { "Africa/Johannesburg", "South Africa Standard Time" },
                    { "Africa/Lagos", "W. Central Africa Standard Time" },
                    { "Africa/Monrovia", "Greenwich Standard Time" },
                    { "Africa/Nairobi", "E. Africa Standard Time" },
                    { "Africa/Windhoek", "Namibia Standard Time" },
                    { "America/Anchorage", "Alaskan Standard Time" },
                    { "America/Argentina/San_Juan", "Argentina Standard Time" },
                    { "America/Asuncion", "Paraguay Standard Time" },
                    { "America/Bahia", "Bahia Standard Time" },
                    { "America/Bogota", "SA Pacific Standard Time" },
                    { "America/Buenos_Aires", "Argentina Standard Time" },
                    { "America/Caracas", "Venezuela Standard Time" },
                    { "America/Cayenne", "SA Eastern Standard Time" },
                    { "America/Chicago", "Central Standard Time" },
                    { "America/Chihuahua", "Mountain Standard Time (Mexico)" },
                    { "America/Cuiaba", "Central Brazilian Standard Time" },
                    { "America/Denver", "Mountain Standard Time" },
                    { "America/Fortaleza", "SA Eastern Standard Time" },
                    { "America/Godthab", "Greenland Standard Time" },
                    { "America/Guatemala", "Central America Standard Time" },
                    { "America/Halifax", "Atlantic Standard Time" },
                    { "America/Indianapolis", "US Eastern Standard Time" },
                    { "America/Indiana/Indianapolis", "US Eastern Standard Time" },
                    { "America/La_Paz", "SA Western Standard Time" },
                    { "America/Los_Angeles", "Pacific Standard Time" },
                    { "America/Mexico_City", "Mexico Standard Time" },
                    { "America/Montevideo", "Montevideo Standard Time" },
                    { "America/New_York", "Eastern Standard Time" },
                    { "America/Noronha", "UTC-02" },
                    { "America/Phoenix", "US Mountain Standard Time" },
                    { "America/Regina", "Canada Central Standard Time" },
                    { "America/Santa_Isabel", "Pacific Standard Time (Mexico)" },
                    { "America/Santiago", "Pacific SA Standard Time" },
                    { "America/Sao_Paulo", "E. South America Standard Time" },
                    { "America/St_Johns", "Newfoundland Standard Time" },
                    { "America/Tijuana", "Pacific Standard Time" },
                    { "Antarctica/McMurdo", "New Zealand Standard Time" },
                    { "Atlantic/South_Georgia", "UTC-02" },
                    { "Asia/Almaty", "Central Asia Standard Time" },
                    { "Asia/Amman", "Jordan Standard Time" },
                    { "Asia/Baghdad", "Arabic Standard Time" },
                    { "Asia/Baku", "Azerbaijan Standard Time" },
                    { "Asia/Bangkok", "SE Asia Standard Time" },
                    { "Asia/Beirut", "Middle East Standard Time" },
                    { "Asia/Calcutta", "India Standard Time" },
                    { "Asia/Colombo", "Sri Lanka Standard Time" },
                    { "Asia/Damascus", "Syria Standard Time" },
                    { "Asia/Dhaka", "Bangladesh Standard Time" },
                    { "Asia/Dubai", "Arabian Standard Time" },
                    { "Asia/Irkutsk", "North Asia East Standard Time" },
                    { "Asia/Jerusalem", "Israel Standard Time" },
                    { "Asia/Kabul", "Afghanistan Standard Time" },
                    { "Asia/Kamchatka", "Kamchatka Standard Time" },
                    { "Asia/Karachi", "Pakistan Standard Time" },
                    { "Asia/Katmandu", "Nepal Standard Time" },
                    { "Asia/Kolkata", "India Standard Time" },
                    { "Asia/Krasnoyarsk", "North Asia Standard Time" },
                    { "Asia/Kuala_Lumpur", "Singapore Standard Time" },
                    { "Asia/Kuwait", "Arab Standard Time" },
                    { "Asia/Magadan", "Magadan Standard Time" },
                    { "Asia/Muscat", "Arabian Standard Time" },
                    { "Asia/Novosibirsk", "N. Central Asia Standard Time" },
                    { "Asia/Oral", "West Asia Standard Time" },
                    { "Asia/Rangoon", "Myanmar Standard Time" },
                    { "Asia/Riyadh", "Arab Standard Time" },
                    { "Asia/Seoul", "Korea Standard Time" },
                    { "Asia/Shanghai", "China Standard Time" },
                    { "Asia/Singapore", "Singapore Standard Time" },
                    { "Asia/Taipei", "Taipei Standard Time" },
                    { "Asia/Tashkent", "West Asia Standard Time" },
                    { "Asia/Tbilisi", "Georgian Standard Time" },
                    { "Asia/Tehran", "Iran Standard Time" },
                    { "Asia/Tokyo", "Tokyo Standard Time" },
                    { "Asia/Ulaanbaatar", "Ulaanbaatar Standard Time" },
                    { "Asia/Vladivostok", "Vladivostok Standard Time" },
                    { "Asia/Yakutsk", "Yakutsk Standard Time" },
                    { "Asia/Yekaterinburg", "Ekaterinburg Standard Time" },
                    { "Asia/Yerevan", "Armenian Standard Time" },
                    { "Atlantic/Azores", "Azores Standard Time" },
                    { "Atlantic/Cape_Verde", "Cape Verde Standard Time" },
                    { "Atlantic/Reykjavik", "Greenwich Standard Time" },
                    { "Australia/Adelaide", "Cen. Australia Standard Time" },
                    { "Australia/Brisbane", "E. Australia Standard Time" },
                    { "Australia/Darwin", "AUS Central Standard Time" },
                    { "Australia/Hobart", "Tasmania Standard Time" },
                    { "Australia/Perth", "W. Australia Standard Time" },
                    { "Australia/Sydney", "AUS Eastern Standard Time" },
                    { "Etc/GMT", "UTC" },
                    { "Etc/GMT+11", "UTC-11" },
                    { "Etc/GMT+12", "Dateline Standard Time" },
                    { "Etc/GMT+2", "UTC-02" },
                    { "Etc/GMT-12", "UTC+12" },
                    { "Europe/Amsterdam", "W. Europe Standard Time" },
                    { "Europe/Athens", "GTB Standard Time" },
                    { "Europe/Belgrade", "Central Europe Standard Time" },
                    { "Europe/Berlin", "W. Europe Standard Time" },
                    { "Europe/Brussels", "Romance Standard Time" },
                    { "Europe/Budapest", "Central Europe Standard Time" },
                    { "Europe/Dublin", "GMT Standard Time" },
                    { "Europe/Helsinki", "FLE Standard Time" },
                    { "Europe/Istanbul", "GTB Standard Time" },
                    { "Europe/Kiev", "FLE Standard Time" },
                    { "Europe/London", "GMT Standard Time" },
                    { "Europe/Minsk", "E. Europe Standard Time" },
                    { "Europe/Moscow", "Russian Standard Time" },
                    { "Europe/Paris", "Romance Standard Time" },
                    { "Europe/Sarajevo", "Central European Standard Time" },
                    { "Europe/Warsaw", "Central European Standard Time" },
                    { "Indian/Mauritius", "Mauritius Standard Time" },
                    { "Pacific/Apia", "Samoa Standard Time" },
                    { "Pacific/Auckland", "New Zealand Standard Time" },
                    { "Pacific/Fiji", "Fiji Standard Time" },
                    { "Pacific/Guadalcanal", "Central Pacific Standard Time" },
                    { "Pacific/Guam", "West Pacific Standard Time" },
                    { "Pacific/Honolulu", "Hawaiian Standard Time" },
                    { "Pacific/Pago_Pago", "UTC-11" },
                    { "Pacific/Port_Moresby", "West Pacific Standard Time" },
                    { "Pacific/Tongatapu", "Tonga Standard Time" }
                };
                if (olsonWindowsTimes.Any(timezone => timezone.Key == timeInfo))
                {
                    timeInfo = olsonWindowsTimes.FirstOrDefault(x => x.Key == timeInfo).Value;
                }
            }

            return timeInfo;
        }

        #endregion

        #region Get_Timezone_Date
        public DateTime Get_Timezone_Date(DateTime Input_Date)
        {
            if (Input_Date.Kind == DateTimeKind.Utc)
            {
                var countryTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Get_Timezone("Asia/Shanghai"));
                var utcOffset = new DateTimeOffset(Input_Date, TimeSpan.Zero);
                return utcOffset.ToOffset(countryTimeZone.GetUtcOffset(utcOffset)).DateTime;
            }
            else
            {
                return Input_Date;
            }
        }

        #endregion
        public bool isDark(string color)
        {
            var c = color.Remove(0, 1);      // strip #
            var rgb = int.Parse(c, System.Globalization.NumberStyles.HexNumber);   // convert rrggbb to decimal
            var r = (rgb >> 16) & 0xff;  // extract red
            var g = (rgb >> 8) & 0xff;  // extract green
            var b = (rgb >> 0) & 0xff;  // extract blue

            var luma = 0.2126 * r + 0.7152 * g + 0.0722 * b; // per ITU-R BT.709

            if (luma < 138)
            {
                return true;
            }
            return false;
        }
        #endregion

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
        #region Fetch_Scenes
        public Fetch_Scenes_Response Fetch_Scenes(Params_Fetch_Scenes i_Params_Fetch_Scenes)
        {
            Fetch_Scenes_Response oFetch_Scenes_Response = new Fetch_Scenes_Response();
            var oList_Camera_Grouped_By_Instance = i_Params_Fetch_Scenes.List_Video_ai_asset.GroupBy(video_ai_instance => video_ai_instance.VIDEO_AI_INSTANCE_ID);
            List<Video_ai_instance> oList_Video_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List()
            {
                VIDEO_AI_INSTANCE_ID_LIST = oList_Camera_Grouped_By_Instance.Select(camera_group => camera_group.Key).Distinct()
            });
            List<Fetch_Scenes_Api_Response> oList_Fetch_Scenes_Api_Response = new List<Fetch_Scenes_Api_Response>();
            Parallel.ForEach(oList_Camera_Grouped_By_Instance, camera_group =>
            {
                Video_ai_instance oVideo_ai_instance = oList_Video_ai_instance.Find(video_ai_instance => video_ai_instance.VIDEO_AI_INSTANCE_ID == camera_group.Key);
                var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                {
                    Video_ai_instance = oVideo_ai_instance,
                });
                // if (!Validate_Query(new Params_Validate_Query()
                // {
                //     X_AUTH_TOKEN = xAuthToken,
                //     QUERY = i_Params_Fetch_Scenes.QUERY,
                //     Video_ai_instance = oVideo_ai_instance,
                // }))
                // {
                //     oFetch_Scenes_Response.IS_ERROR = true;
                //     oFetch_Scenes_Response.ERROR_MESSAGE = "Query is not valid";
                // };

                string url = $"{oVideo_ai_instance.CONNECTION_URL}/scenes";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddQueryParameter("start", DateTime.Parse(i_Params_Fetch_Scenes.START_DATE).ToString("yyyy-MM-dd HH:mm:ss"));
                request.AddQueryParameter("end", DateTime.Parse(i_Params_Fetch_Scenes.END_DATE).ToString("yyyy-MM-dd HH:mm:ss"));
                request.AddQueryParameter("size", i_Params_Fetch_Scenes.SIZE.ToString());
                request.AddQueryParameter("page", i_Params_Fetch_Scenes.PAGE.ToString());
                request.AddQueryParameter("query", i_Params_Fetch_Scenes.QUERY);
                request.AddQueryParameter("cameraIds", String.Join(",", camera_group.Select(camera => camera.VIDEO_AI_ASSET_ID_REF)));
                request.AddHeader("x-auth-token", xAuthToken);
                request.AddParameter("Content-Type", "text/plain");
                RestResponse response = client.Execute(request);
                oList_Fetch_Scenes_Api_Response.Add(Fetch_Scenes_Api_Response.FromJson(response.Content));
            });
            try
            {
                oFetch_Scenes_Response.Fetch_Scenes_Api_Response = new Fetch_Scenes_Api_Response()
                {
                    TotalElements = oList_Fetch_Scenes_Api_Response.Sum(fetch_scene_api_response => fetch_scene_api_response.TotalElements),
                    Content = oList_Fetch_Scenes_Api_Response.SelectMany(fetch_scene_api_response => fetch_scene_api_response.Content).ToArray(),
                };

                oFetch_Scenes_Response.Fetch_Scenes_Api_Response.Content = oFetch_Scenes_Response.Fetch_Scenes_Api_Response.Content.Select(scene =>
                {
                    scene.isLoaded = false;
                    scene.isVpn = oList_Video_ai_instance.Find(video_ai_instance => i_Params_Fetch_Scenes.List_Video_ai_asset.Find(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == scene.CameraId).VIDEO_AI_INSTANCE_ID == video_ai_instance.VIDEO_AI_INSTANCE_ID).Connection_type_setup.VALUE == "VPN";
                    return scene;
                }).ToArray();
                return oFetch_Scenes_Response;
            }
            catch
            {
                return new Fetch_Scenes_Response();
            }
        }
        #endregion
        #region Fetch_Facial_Recognition
        public Fetch_Facial_Recognition_Reponse Fetch_Facial_Recognition(Params_Fetch_Facial_Recognition i_Params_Fetch_Facial_Recognition)
        {
            string filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "FR_Main.json";
            string json = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(filePath).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                }
            }

            Fetch_Facial_Recognition_Reponse oFetch_Facial_Recognition_Reponse = JsonConvert.DeserializeObject<Fetch_Facial_Recognition_Reponse>(json);

            if (i_Params_Fetch_Facial_Recognition.GENDER != null &&
                i_Params_Fetch_Facial_Recognition.GENDER != "")
            {
                oFetch_Facial_Recognition_Reponse.Content = oFetch_Facial_Recognition_Reponse.Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => oList_Fetch_License_Plate_Recognition_Response_Content.FaceTarget.Gender == i_Params_Fetch_Facial_Recognition.GENDER).ToArray();
            }
            if (i_Params_Fetch_Facial_Recognition.AGE != null &&
                i_Params_Fetch_Facial_Recognition.AGE != "")
            {
                oFetch_Facial_Recognition_Reponse.Content = oFetch_Facial_Recognition_Reponse.Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => oList_Fetch_License_Plate_Recognition_Response_Content.FaceKey.AgeGroup.ToString() == i_Params_Fetch_Facial_Recognition.AGE).ToArray();
            }
            if (i_Params_Fetch_Facial_Recognition.TARGET_NAME != null &&
                i_Params_Fetch_Facial_Recognition.TARGET_NAME != "")
            {
                oFetch_Facial_Recognition_Reponse.Content = oFetch_Facial_Recognition_Reponse.Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => oList_Fetch_License_Plate_Recognition_Response_Content.FaceTarget.Name.ToLower().Contains(i_Params_Fetch_Facial_Recognition.TARGET_NAME.ToLower())).ToArray();
            }
            if (i_Params_Fetch_Facial_Recognition.CATEGORIES != null &&
                i_Params_Fetch_Facial_Recognition.CATEGORIES != "")
            {
                oFetch_Facial_Recognition_Reponse.Content = oFetch_Facial_Recognition_Reponse.Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => i_Params_Fetch_Facial_Recognition.CATEGORIES.Contains(oList_Fetch_License_Plate_Recognition_Response_Content.FaceTarget.Category.Name)).ToArray();
            }

            oFetch_Facial_Recognition_Reponse.Content = oFetch_Facial_Recognition_Reponse.Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => oList_Fetch_License_Plate_Recognition_Response_Content.Similarity >= i_Params_Fetch_Facial_Recognition.SCORES).ToArray();

            return oFetch_Facial_Recognition_Reponse;
        }
        #endregion
        #region Fetch_Face_Targets
        public Fetch_Face_Targets_Response Fetch_Face_Targets(Params_Fetch_Face_Targets i_Params_Fetch_Face_Targets)
        {
            string filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "FR_List.json";
            string json = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(filePath).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                }
            }

            Fetch_Face_Targets_Response pFetch_Face_Targets_Response = JsonConvert.DeserializeObject<Fetch_Face_Targets_Response>(json);

            if (i_Params_Fetch_Face_Targets.CATEGORY != null &&
                i_Params_Fetch_Face_Targets.CATEGORY != "")
            {
                pFetch_Face_Targets_Response.Content = pFetch_Face_Targets_Response.Content.Where(oContent => oContent.Category.Name == i_Params_Fetch_Face_Targets.CATEGORY).ToArray();
            }
            if (i_Params_Fetch_Face_Targets.TARGET_NAME != null &&
                i_Params_Fetch_Face_Targets.TARGET_NAME != "")
            {
                pFetch_Face_Targets_Response.Content = pFetch_Face_Targets_Response.Content.Where(oContent => oContent.Name.ToLower().Contains(i_Params_Fetch_Face_Targets.TARGET_NAME)).ToArray();
            }

            return pFetch_Face_Targets_Response;
        }
        #endregion
        #region Fetch_License_Plate_Recognition
        public Fetch_License_Plate_Recognition_Response Fetch_License_Plate_Recognition(Params_Fetch_License_Plate_Recognition i_Params_Fetch_License_Plate_Recognition)
        {
            string filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "LPR_Main.json";
            string json = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(filePath).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                }
            }

            Fetch_License_Plate_Recognition_Response oFetch_License_Plate_Recognition_Response = JsonConvert.DeserializeObject<Fetch_License_Plate_Recognition_Response>(json);

            if (i_Params_Fetch_License_Plate_Recognition.VEHICLE_TYPE != null &&
                i_Params_Fetch_License_Plate_Recognition.VEHICLE_TYPE != "")
            {
                oFetch_License_Plate_Recognition_Response.List_Fetch_License_Plate_Recognition_Response_Content = oFetch_License_Plate_Recognition_Response.List_Fetch_License_Plate_Recognition_Response_Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => oList_Fetch_License_Plate_Recognition_Response_Content.Type == i_Params_Fetch_License_Plate_Recognition.VEHICLE_TYPE).ToArray();
            }
            if (i_Params_Fetch_License_Plate_Recognition.PLATE_NUMBER != null &&
                i_Params_Fetch_License_Plate_Recognition.PLATE_NUMBER != "")
            {
                oFetch_License_Plate_Recognition_Response.List_Fetch_License_Plate_Recognition_Response_Content = oFetch_License_Plate_Recognition_Response.List_Fetch_License_Plate_Recognition_Response_Content.Where(oList_Fetch_License_Plate_Recognition_Response_Content => oList_Fetch_License_Plate_Recognition_Response_Content.Characters.ToLower().Contains(i_Params_Fetch_License_Plate_Recognition.PLATE_NUMBER.ToLower())).ToArray();
            }

            return oFetch_License_Plate_Recognition_Response;
        }
        #endregion
        #region Fetch_License_Plate_Targets
        public Fetch_License_Plate_Targets_Response Fetch_License_Plate_Targets(Params_Fetch_License_Plate_Targets i_Params_Fetch_License_Plate_Targets)
        {
            string filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "LPR_List.json";
            string json = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(filePath).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                }
            }

            Fetch_License_Plate_Targets_Response oFetch_License_Plate_Targets_Response = JsonConvert.DeserializeObject<Fetch_License_Plate_Targets_Response>(json);

            if (i_Params_Fetch_License_Plate_Targets.CATEGORY != null &&
                i_Params_Fetch_License_Plate_Targets.CATEGORY != "")
            {
                oFetch_License_Plate_Targets_Response.Content = oFetch_License_Plate_Targets_Response.Content.Where(oContent => oContent.Category.Name == i_Params_Fetch_License_Plate_Targets.CATEGORY).ToArray();
            }
            if (i_Params_Fetch_License_Plate_Targets.PLATE_NUMBER != null &&
                i_Params_Fetch_License_Plate_Targets.PLATE_NUMBER != "")
            {
                oFetch_License_Plate_Targets_Response.Content = oFetch_License_Plate_Targets_Response.Content.Where(oContent => oContent.PlateNumber.ToLower().Contains(i_Params_Fetch_License_Plate_Targets.PLATE_NUMBER)).ToArray();
            }

            return oFetch_License_Plate_Targets_Response;
        }
        #endregion
        #region Fetch_License_Plate_Categories
        public List<License_Plate_Category> Fetch_License_Plate_Categories(Params_Fetch_License_Plate_Categories i_Params_Fetch_License_Plate_Categories)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Fetch_License_Plate_Categories.VIDEO_AI_INSTANCE_ID
            });
            #endregion

            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance,
            });

            string url = $"{oVideo_ai_instance.CONNECTION_URL}/lpr/categories";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");
            RestResponse response = client.Execute(request);

            List<License_Plate_Category> oList_License_Plate_Category = JsonConvert.DeserializeObject<List<License_Plate_Category>>(response.Content);
            return oList_License_Plate_Category;
        }
        #endregion
        #region Fetch_Face_Target_Categories
        public List<Face_Target_Response_Category> Fetch_Face_Target_Categories(Params_Fetch_Face_Target_Categories i_Params_Fetch_Face_Target_Categories)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Fetch_Face_Target_Categories.VIDEO_AI_INSTANCE_ID
            });
            #endregion

            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance,
            });

            string url = $"{oVideo_ai_instance.CONNECTION_URL}/face/categories";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");
            RestResponse response = client.Execute(request);

            List<Face_Target_Response_Category> oList_Face_Target_Category = JsonConvert.DeserializeObject<List<Face_Target_Response_Category>>(response.Content);
            return oList_Face_Target_Category;
        }
        #endregion
        #region Get_Countings
        public List<Get_Countings_Response> Get_Countings(Params_Get_Countings i_Params_Get_Countings)
        {
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Countings.VIDEO_AI_INSTANCE_ID
            });

            List<Get_Countings_Response> oGet_Countings_Response = new List<Get_Countings_Response>();
            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance
            });
            string url = $"{oVideo_ai_instance.CONNECTION_URL}/countings";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);

            request.AddQueryParameter("start", DateTime.Parse(i_Params_Get_Countings.START_DATE).ToString("yyyy-MM-dd HH:mm:ss"));
            request.AddQueryParameter("end", DateTime.Parse(i_Params_Get_Countings.END_DATE).ToString("yyyy-MM-dd HH:mm:ss"));
            request.AddQueryParameter("lineSetIds", String.Join(",", i_Params_Get_Countings.LINESET_ID_LIST));
            request.AddQueryParameter("types", String.Join(",", i_Params_Get_Countings.TYPES));
            request.AddQueryParameter("measure", i_Params_Get_Countings.MEASURE.ToString());
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");

            RestResponse response = client.Execute(request);

            return oGet_Countings_Response = JsonConvert.DeserializeObject<List<Get_Countings_Response>>(response.Content).OrderBy(counting => counting.DATETIME).ToList();
        }
        #endregion
        #region Get Line Sets
        public List<Get_Line_Sets_Response> Get_Line_Sets(Params_Get_Line_Sets i_Params_Get_Line_Sets)
        {
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Line_Sets.VIDEO_AI_INSTANCE_ID
            });

            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance
            });
            if (i_Params_Get_Line_Sets.ENTITY_ID != null)
            {
                List<Video_ai_asset_entity> oList_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(new Params_Get_Video_ai_asset_entity_By_ENTITY_ID()
                {
                    ENTITY_ID = i_Params_Get_Line_Sets.ENTITY_ID
                });
                List<Get_Line_Sets_Response> oGet_Line_Sets_Response = new List<Get_Line_Sets_Response>();
                Parallel.ForEach(oList_Video_ai_asset_entity, video_ai_asset_entity =>
                {
                    string url = $"{oVideo_ai_instance.CONNECTION_URL}/lineSets";
                    var client = new RestClient(url);
                    var request = new RestRequest(url, Method.Get);
                    request.AddHeader("x-auth-token", xAuthToken);
                    request.AddParameter("Content-Type", "text/plain");
                    request.AddQueryParameter("types", i_Params_Get_Line_Sets.TYPES?.ToString());
                    RestResponse response = client.Execute(request);
                    oGet_Line_Sets_Response.AddRange(JsonConvert.DeserializeObject<List<Get_Line_Sets_Response>>(response.Content));
                });
                return oGet_Line_Sets_Response;
            }
            else
            {
                string url = $"{oVideo_ai_instance.CONNECTION_URL}/lineSets";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddHeader("x-auth-token", xAuthToken);
                request.AddParameter("Content-Type", "text/plain");
                request.AddQueryParameter("types", i_Params_Get_Line_Sets.TYPES?.ToString());
                RestResponse response = client.Execute(request);

                List<Get_Line_Sets_Response> oGet_Line_Sets_Response = JsonConvert.DeserializeObject<List<Get_Line_Sets_Response>>(response.Content);

                return oGet_Line_Sets_Response;
            }
        }
        #endregion
        #region Get_Scene_Info
        public Scene_Info Get_Scene_Info(Params_Get_Scene_Info i_Params_Get_Scene_Info)
        {
            Scene_Info oScene_Info = new Scene_Info();
            string filePath = "";
            string json = "";
            HttpClient client;
            HttpResponseMessage response;
            switch (i_Params_Get_Scene_Info.OBJECT_TYPE)
            {
                case "LPR":
                    filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "LPR_Alerts.json";
                    json = "";
                    client = new HttpClient();
                    response = client.GetAsync(filePath).Result;
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                    oScene_Info = JsonConvert.DeserializeObject<Scene_Info>(json);
                    break;
                case "FR":
                    filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "FR_Alerts.json";
                    json = "";
                    client = new HttpClient();
                    response = client.GetAsync(filePath).Result;
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                    oScene_Info = JsonConvert.DeserializeObject<Scene_Info>(json);
                    break;
                case "FIRE ALARM":
                    filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "FIRE_ALARM.json";
                    json = "";
                    client = new HttpClient();
                    response = client.GetAsync(filePath).Result;
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                    oScene_Info = JsonConvert.DeserializeObject<Scene_Info>(json);
                    break;
                case "INTRUDER":
                    filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "INTRUDER.json";
                    json = "";
                    client = new HttpClient();
                    response = client.GetAsync(filePath).Result;
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                    oScene_Info = JsonConvert.DeserializeObject<Scene_Info>(json);
                    break;
                case "ACCESS CONTROL":
                    filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "ACCESS_CONTROL.json";
                    json = "";
                    client = new HttpClient();
                    response = client.GetAsync(filePath).Result;
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                    oScene_Info = JsonConvert.DeserializeObject<Scene_Info>(json);
                    break;
                default:
                    #region Get Video Ai Instance
                    Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
                    {
                        VIDEO_AI_INSTANCE_ID = i_Params_Get_Scene_Info.VIDEO_AI_INSTANCE_ID
                    });
                    #endregion

                    var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                    {
                        Video_ai_instance = oVideo_ai_instance
                    });
                    oScene_Info.SCENE_OBJECT_LIST = Get_Scene_Objects(new Params_Get_Scene_Objects()
                    {
                        VIDEO_AI_INSTANCE_ID = i_Params_Get_Scene_Info.VIDEO_AI_INSTANCE_ID,
                        SCENE_ID = i_Params_Get_Scene_Info.SCENE_ID,
                        X_AUTH_TOKEN = xAuthToken
                    });

                    string url = $"{oVideo_ai_instance.CONNECTION_URL}/scenes/{i_Params_Get_Scene_Info.SCENE_ID}";
                    var oRest_client = new RestClient(url);
                    var oRest_Request = new RestRequest(url, Method.Get);
                    oRest_Request.AddHeader("x-auth-token", xAuthToken);
                    RestResponse oRest_Response = oRest_client.Execute(oRest_Request);
                    oScene_Info.SCENE_DETAILS = Scene_Details.FromJson(oRest_Response.Content);
                    break;
            }
            return oScene_Info;
        }
        #endregion
        #region Get_License_Plate_Scene
        public Scene_Details Get_License_Plate_Scene(Params_Get_License_Plate_Scene i_Params_Get_License_Plate_Scene)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_License_Plate_Scene.VIDEO_AI_INSTANCE_ID
            });
            #endregion

            Scene_Details oScene_Details = new Scene_Details();
            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance
            });

            string url = $"{oVideo_ai_instance.CONNECTION_URL}/scenes/{i_Params_Get_License_Plate_Scene.SCENE_ID}";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("x-auth-token", xAuthToken);
            RestResponse response = client.Execute(request);
            oScene_Details = Scene_Details.FromJson(response.Content);

            oScene_Details.Camera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID
            {
                ID = (int)oScene_Details.CameraId,
                VIDEO_AI_INSTANCE_ID = i_Params_Get_License_Plate_Scene.VIDEO_AI_INSTANCE_ID
            });

            return oScene_Details;
        }
        #endregion
        #region Validate_Query
        public bool Validate_Query(Params_Validate_Query i_Params_Validate_Query)
        {
            if (i_Params_Validate_Query.Video_ai_instance != null)
            {
                string url = $"{i_Params_Validate_Query.Video_ai_instance.CONNECTION_URL}/query/validate";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddQueryParameter("query", i_Params_Validate_Query.QUERY);
                request.AddHeader("x-auth-token", i_Params_Validate_Query.X_AUTH_TOKEN);
                request.AddParameter("Content-Type", "text/plain");
                RestResponse response = client.Execute(request);
                return Query_Validator.FromJson(response.Content).Success;
            }
            else
            {
                string url = $"{i_Params_Validate_Query.Video_ai_instance.CONNECTION_URL}/query/validate";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddQueryParameter("query", i_Params_Validate_Query.QUERY);
                request.AddHeader("x-auth-token", i_Params_Validate_Query.X_AUTH_TOKEN);
                request.AddParameter("Content-Type", "text/plain");
                RestResponse response = client.Execute(request);
                return Query_Validator.FromJson(response.Content).Success;
            }
        }
        #endregion
        #region Get_Stream_Data
        public Stream_Data Get_Stream_Data(Params_Get_Stream_Data i_Params_Get_Stream_Data)
        {
            try
            {
                return new Stream_Data()
                {
                    List_Video_ai_asset = Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(new Params_Get_Video_ai_asset_entity_By_ENTITY_ID()
                    {
                        ENTITY_ID = i_Params_Get_Stream_Data.ENTITY_ID,
                    }).Select(video_ai_asset_entity => video_ai_asset_entity.Video_ai_asset).ToList(),
                    List_Search_type = Get_Video_ai_search_category_By_OWNER_ID(new Params_Get_Video_ai_search_category_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).Select(video_ai_search_category => video_ai_search_category.CATEGORY_NAME).ToList(),
                };
            }
            catch
            {
                return null;
            }
        }
        #endregion
        #region Get Camera Lines
        public List<Camera_Lines> Get_Camera_Lines(Params_Get_Camera_Lines i_Params_Get_Camera_Lines)
        {
            List<Camera_Lines> oList_Camera_Lines = new List<Camera_Lines>();

            List<Get_Line_Sets_Response> oLineSets = new List<Get_Line_Sets_Response>();
            oLineSets = Get_Line_Sets(new Params_Get_Line_Sets
            {
                TYPES = i_Params_Get_Camera_Lines.TYPES,
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Camera_Lines.VIDEO_AI_INSTANCE_ID,
            });

            var Line_Sets_By_Camera_ID = oLineSets.GroupBy(line => line.CameraId);
            foreach (var group in Line_Sets_By_Camera_ID)
            {
                Surveillance_Camera_Content oCamera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID
                {
                    ID = group.Key,
                    VIDEO_AI_INSTANCE_ID = i_Params_Get_Camera_Lines.VIDEO_AI_INSTANCE_ID
                });
                List<Get_Line_Sets_Response> oList_Line_Sets = new List<Get_Line_Sets_Response>();
                foreach (var lineset in group)
                {
                    oList_Line_Sets.Add(lineset);
                }
                oList_Camera_Lines.Add(new Camera_Lines()
                {
                    Camera = oCamera,
                    LineSets = oList_Line_Sets
                });
            }

            return oList_Camera_Lines;
        }
        #endregion
        #region Get_Scene_Objects
        public List<Scene_Object> Get_Scene_Objects(Params_Get_Scene_Objects i_Params_Get_Scene_Objects)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Scene_Objects.VIDEO_AI_INSTANCE_ID
            });
            #endregion
            string xAuthToken;
            if (i_Params_Get_Scene_Objects.X_AUTH_TOKEN == null || i_Params_Get_Scene_Objects.X_AUTH_TOKEN == "")
            {
                xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                {
                    Video_ai_instance = oVideo_ai_instance
                });
            }
            else
            {
                xAuthToken = i_Params_Get_Scene_Objects.X_AUTH_TOKEN;
            }
            string url = $"{oVideo_ai_instance.CONNECTION_URL}/scenes/{i_Params_Get_Scene_Objects.SCENE_ID}/objects";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("x-auth-token", xAuthToken);
            RestResponse response = client.Execute(request);
            return Scene_Object.FromJson(response.Content).ToList();
        }
        #endregion
        #region Get_Vehicle_Types
        public List<string> Get_Vehicle_Types(Params_Get_Vehicle_Types i_Params_Get_Vehicle_Types)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Vehicle_Types.VIDEO_AI_INSTANCE_ID
            });
            #endregion
            Get_Vehicle_Types_Response oGet_Vehicle_Types_Reponse = new Get_Vehicle_Types_Response();
            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance
            });

            if (i_Params_Get_Vehicle_Types.ENTITY_ID != null)
            {
                List<Video_ai_asset_entity> oList_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(new Params_Get_Video_ai_asset_entity_By_ENTITY_ID()
                {
                    ENTITY_ID = i_Params_Get_Vehicle_Types.ENTITY_ID
                });
                List<string> List_Vehicle_Types = new List<string>();
                Parallel.ForEach(oList_Video_ai_asset_entity, video_ai_asset_entity =>
                {
                    string url = $"{oVideo_ai_instance.CONNECTION_URL}/engine-objects";
                    var client = new RestClient(url);
                    var request = new RestRequest(url, Method.Get);
                    request.AddHeader("x-auth-token", xAuthToken);
                    request.AddParameter("Content-Type", "text/plain");
                    RestResponse response = client.Execute(request);

                    oGet_Vehicle_Types_Reponse = JsonConvert.DeserializeObject<Get_Vehicle_Types_Response>(response.Content);
                    List_Vehicle_Types.AddRange(oGet_Vehicle_Types_Reponse.Content.Find(oEngine_Object_Content => oEngine_Object_Content.Engine == "VehicleCountingEngine").EngineObject.ToList());
                });

                return List_Vehicle_Types;
            }
            else
            {
                string url = $"{oVideo_ai_instance.CONNECTION_URL}/engine-objects";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddHeader("x-auth-token", xAuthToken);
                request.AddParameter("Content-Type", "text/plain");
                RestResponse response = client.Execute(request);

                oGet_Vehicle_Types_Reponse = JsonConvert.DeserializeObject<Get_Vehicle_Types_Response>(response.Content);
                List<string> List_Vehicle_Types = oGet_Vehicle_Types_Reponse.Content.Find(oEngine_Object_Content => oEngine_Object_Content.Engine == "VehicleCountingEngine").EngineObject.ToList();

                return List_Vehicle_Types;
            }
        }
        #endregion
        #region Get_Vaidio_Auth_Token
        public string Get_Vaidio_Auth_Token(Params_Get_Vaidio_Auth_Token i_Params_Get_Vaidio_Auth_Token)
        {
            string Password_PlainText = Crypto.Decrypt(i_Params_Get_Vaidio_Auth_Token.Video_ai_instance.PASSWORD);
            var Password_Element = Password_PlainText
                                    .Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries)
                                    .Where(element => element.Contains("PASSWORD")).FirstOrDefault();

            var Password_Value = Password_Element.Split(new string[] { ":" }, StringSplitOptions.None)[1];

            if (i_Params_Get_Vaidio_Auth_Token.Video_ai_instance != null)
            {
                string url = $"{i_Params_Get_Vaidio_Auth_Token.Video_ai_instance.CONNECTION_URL}/auth";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(new
                {
                    username = i_Params_Get_Vaidio_Auth_Token.Video_ai_instance.USERNAME,
                    password = Password_Value,
                });
                RestResponse response = client.Execute(request);
                if (response.StatusCode == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
                }
                try
                {
                    string token = X_Auth_Token_Response.FromJson(response.Content).Token;
                    if (token == null || token == "")
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0038)); // Invalid Credentials or Connection Url
                    }
                    return token;
                }
                catch
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0038)); // Invalid Credentials or Connection Url
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0039)); // Cannot Access Video AI
            }
        }
        #endregion
        #region Get_Vehicle_Countings
        public Vehicle_Counting Get_Vehicle_Countings(Params_Get_Vehicle_Countings i_Params_Get_Vehicle_Countings)
        {
            Vehicle_Counting oVehicle_Counting = new Vehicle_Counting();
            oVehicle_Counting.GET_COUNTINGS_RESPONSE_LIST = Get_Countings(new Params_Get_Countings()
            {
                TYPES = i_Params_Get_Vehicle_Countings.TYPES,
                MEASURE = i_Params_Get_Vehicle_Countings.MEASURE,
                END_DATE = i_Params_Get_Vehicle_Countings.END_DATE,
                START_DATE = i_Params_Get_Vehicle_Countings.START_DATE,
                LINESET_ID_LIST = i_Params_Get_Vehicle_Countings.LINESET_ID_LIST,
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Vehicle_Countings.VIDEO_AI_INSTANCE_ID
            });
            oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST = new List<Vehicle_Counting_Table_Data>();
            foreach (Get_Countings_Response oGet_Countings_Response in oVehicle_Counting.GET_COUNTINGS_RESPONSE_LIST)
            {
                Vehicle_Counting_Table_Data oVehicle_Counting_Table_Data;
                if (oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST.Any(data => data.TIME == oGet_Countings_Response.DATETIME))
                {
                    oVehicle_Counting_Table_Data = oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST.First(data => data.TIME == oGet_Countings_Response.DATETIME);
                    oVehicle_Counting_Table_Data.TOTAL_IN += oGet_Countings_Response.OBJECTIN;
                    oVehicle_Counting_Table_Data.TOTAL_OUT += oGet_Countings_Response.OBJECTOUT;
                    oVehicle_Counting_Table_Data.TOTAL_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                    switch (oGet_Countings_Response.TYPE)
                    {
                        case "car":
                            oVehicle_Counting_Table_Data.CAR_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.CAR_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.CAR_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "truck":
                            oVehicle_Counting_Table_Data.TRUCK_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.TRUCK_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.TRUCK_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "bus":
                            oVehicle_Counting_Table_Data.BUS_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.BUS_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.BUS_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "motorbike":
                            oVehicle_Counting_Table_Data.MOTORBIKE_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.MOTORBIKE_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.MOTORBIKE_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "bicycle":
                            oVehicle_Counting_Table_Data.BICYCLE_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.BICYCLE_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.BICYCLE_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                    }
                }
                else
                {
                    oVehicle_Counting_Table_Data = new Vehicle_Counting_Table_Data()
                    {
                        TIME = oGet_Countings_Response.DATETIME,
                        TOTAL_IN = oGet_Countings_Response.OBJECTIN,
                        TOTAL_OUT = oGet_Countings_Response.OBJECTOUT,
                        TOTAL_OCCUPANCY = oGet_Countings_Response.OCCUPANCY,
                        CAR_IN = 0,
                        CAR_OUT = 0,
                        CAR_OCCUPANCY = 0,
                        TRUCK_IN = 0,
                        TRUCK_OUT = 0,
                        TRUCK_OCCUPANCY = 0,
                        BUS_IN = 0,
                        BUS_OUT = 0,
                        BUS_OCCUPANCY = 0,
                        MOTORBIKE_IN = 0,
                        MOTORBIKE_OUT = 0,
                        MOTORBIKE_OCCUPANCY = 0,
                        BICYCLE_IN = 0,
                        BICYCLE_OUT = 0,
                        BICYCLE_OCCUPANCY = 0,
                    };
                    switch (oGet_Countings_Response.TYPE)
                    {
                        case "car":
                            oVehicle_Counting_Table_Data.CAR_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.CAR_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.CAR_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "truck":
                            oVehicle_Counting_Table_Data.TRUCK_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.TRUCK_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.TRUCK_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "bus":
                            oVehicle_Counting_Table_Data.BUS_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.BUS_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.BUS_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "motorbike":
                            oVehicle_Counting_Table_Data.MOTORBIKE_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.MOTORBIKE_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.MOTORBIKE_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                        case "bicycle":
                            oVehicle_Counting_Table_Data.BICYCLE_IN += oGet_Countings_Response.OBJECTIN;
                            oVehicle_Counting_Table_Data.BICYCLE_OUT += oGet_Countings_Response.OBJECTOUT;
                            oVehicle_Counting_Table_Data.BICYCLE_OCCUPANCY += oGet_Countings_Response.OCCUPANCY;
                            break;
                    }
                    oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST.Add(oVehicle_Counting_Table_Data);
                }
            }
            oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST = oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST.OrderBy(data => data.TIME).ToList();
            return oVehicle_Counting;
        }
        #endregion
        #region Get Camera By Camera ID
        public Surveillance_Camera_Content Get_Camera_By_Camera_ID(Params_Get_Camera_By_Camera_ID i_Params_Get_Camera_By_Camera_ID)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_Camera_By_Camera_ID.VIDEO_AI_INSTANCE_ID
            });
            #endregion

            #region Initialization & Declaration
            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance
            });
            string url = $"{oVideo_ai_instance.CONNECTION_URL}/cameras/{i_Params_Get_Camera_By_Camera_ID.ID}";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            #endregion

            #region Params and Headers
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");
            #endregion

            #region Response
            RestResponse response = client.Execute(request);
            Surveillance_Camera_Content oCamera = JsonConvert.DeserializeObject<Surveillance_Camera_Content>(response.Content);
            #endregion

            #region Return
            return oCamera;
            #endregion
        }
        #endregion
        #region Get_All_Cameras
        public List<Surveillance_Camera_Content> Get_All_Cameras(Params_Get_All_Cameras i_Params_Get_All_Cameras)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
            {
                VIDEO_AI_INSTANCE_ID = i_Params_Get_All_Cameras.VIDEO_AI_INSTANCE_ID
            });
            #endregion

            #region Initialization & Declaration
            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance
            });
            string url = $"{oVideo_ai_instance.CONNECTION_URL}/cameras";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            #endregion

            #region Params and Headers
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");
            #endregion

            #region Response
            RestResponse response = client.Execute(request);
            Surveillance_Camera oCamera_List = JsonConvert.DeserializeObject<Surveillance_Camera>(response.Content);
            List<Surveillance_Camera_Content> oList_Surveillance_Camera_Content = new List<Surveillance_Camera_Content>();
            foreach (Surveillance_Camera_Content oSurveillance_Camera_Content in oCamera_List.Content)
            {
                oList_Surveillance_Camera_Content.Add(oSurveillance_Camera_Content);
            }
            #endregion

            #region Return
            return oList_Surveillance_Camera_Content;
            #endregion
        }
        #endregion
        #region Get_Video_ai_assets_with_engine_assets
        public Video_ai_assets_with_engine_assets Get_Video_ai_assets_with_engine_assets(Params_Get_Video_ai_assets_with_engine_assets i_Params_Get_Video_ai_assets_with_engine_assets)
        {
            if (i_Params_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID != null &&
                i_Params_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID > 0)
            {
                Video_ai_assets_with_engine_assets oVideo_ai_assets_with_engine_assets = new Video_ai_assets_with_engine_assets()
                {
                    ASSET_LIST = new List<Surveillance_Camera_Content>(),
                    VIDEO_AI_ASSET_WITH_FLAG_LIST = new List<Video_ai_asset>()
                };
                List<Video_ai_asset> oList_Video_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
                {
                    VIDEO_AI_INSTANCE_ID = i_Params_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID
                });
                List<Surveillance_Camera_Content> oCamera_List = Get_All_Cameras(new Params_Get_All_Cameras
                {
                    VIDEO_AI_INSTANCE_ID = i_Params_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID,
                });

                List<string> oCameraNames = oCamera_List.GroupBy(x => x.Name).Select(x => x.Key).ToList();
                List<string> oList_Video_asset_functional_name = oList_Video_ai_asset.GroupBy(x => x.FUNCTIONAL_NAME).Select(x => x.Key).ToList();

                foreach (Video_ai_asset oVideo_ai_asset in oList_Video_ai_asset)
                {
                    if (oCameraNames.Contains(oVideo_ai_asset.FUNCTIONAL_NAME))
                    {
                        oVideo_ai_asset.IS_ERROR = false;
                    }
                    else
                    {
                        oVideo_ai_asset.IS_ERROR = true;
                    }
                }

                oVideo_ai_assets_with_engine_assets.ASSET_LIST = oCamera_List;
                oVideo_ai_assets_with_engine_assets.VIDEO_AI_ASSET_WITH_FLAG_LIST = oList_Video_ai_asset.Where(x => !x.IS_DELETED).ToList();

                return oVideo_ai_assets_with_engine_assets;

            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); //Invalid Input
            }
        }
        #endregion
        #region Delete_Video_ai_asset_Custom
        public bool Delete_Video_ai_asset_Custom(Params_Delete_Video_ai_asset_Custom i_Params_Delete_Video_ai_asset_Custom)
        {
            if (i_Params_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID != null &&
                i_Params_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID > 0)
            {
                Video_ai_asset oVideo_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
                {
                    VIDEO_AI_ASSET_ID = i_Params_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID
                });

                if (oVideo_ai_asset != null)
                {
                    oVideo_ai_asset.IS_DELETED = true;
                    Edit_Video_ai_asset(oVideo_ai_asset);
                    return true;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video ai asset").Replace("%2", i_Params_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID.ToString()));
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); //Invalid Input
            }
        }
        #endregion
        #region Get_Sites_and_Entities
        public Sites_and_Entities Get_Sites_and_Entities()
        {
            Sites_and_Entities oSites_and_Entities = new Sites_and_Entities()
            {
                SITES = new List<Site>(),
                ENTITIES = new List<Entity>()
            };
            var get_sites = Task.Run(() =>
            {
                oSites_and_Entities.SITES = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(
                    this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result
                );
            });
            var get_entities = Task.Run(() =>
            {
                oSites_and_Entities.ENTITIES = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
                    this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result
                );
            });
            Task.WaitAll(get_sites, get_entities);

            return oSites_and_Entities;
        }
        #endregion
        #region Create_Video_ai_instance
        public Video_ai_instance Create_Video_ai_instance(Params_Create_Video_ai_instance i_Params_Create_Video_ai_instance)
        {
            if (
                i_Params_Create_Video_ai_instance.VIDEO_AI_ENGINE_ID != null &&
                i_Params_Create_Video_ai_instance.VIDEO_AI_ENGINE_ID > 0 &&
                i_Params_Create_Video_ai_instance.CONNECTION_TYPE_SETUP_ID > 0 &&
                i_Params_Create_Video_ai_instance.CONNECTION_TYPE_SETUP_ID != null &&
                i_Params_Create_Video_ai_instance.USERNAME.Trim() != "" &&
                i_Params_Create_Video_ai_instance.PASSWORD.Trim() != "" &&
                i_Params_Create_Video_ai_instance.FRIENDLY_NAME.Trim() != "" &&
                i_Params_Create_Video_ai_instance.CONNECTION_URL.Trim() != "" &&
                i_Params_Create_Video_ai_instance.FUNCTIONAL_NAME.Trim() != ""
            )
            {
                string encrypted_password = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]PASSWORD:{0}[~!@]" + Tools.Get_Unique_String(), i_Params_Create_Video_ai_instance.PASSWORD));


                Video_ai_instance oVideo_ai_instance = new Video_ai_instance()
                {
                    VIDEO_AI_INSTANCE_ID = -1,
                    USERNAME = i_Params_Create_Video_ai_instance.USERNAME,
                    PASSWORD = encrypted_password,
                    VIDEO_AI_ENGINE_ID = i_Params_Create_Video_ai_instance.VIDEO_AI_ENGINE_ID,
                    CONNECTION_URL = i_Params_Create_Video_ai_instance.CONNECTION_URL,
                    CONNECTION_TYPE_SETUP_ID = i_Params_Create_Video_ai_instance.CONNECTION_TYPE_SETUP_ID,
                    FRIENDLY_NAME = i_Params_Create_Video_ai_instance.FRIENDLY_NAME,
                    FUNCTIONAL_NAME = i_Params_Create_Video_ai_instance.FUNCTIONAL_NAME,
                    IS_LPR = i_Params_Create_Video_ai_instance.IS_LPR
                };

                if (!i_Params_Create_Video_ai_instance.FORCE_CONNECTION)
                {
                    try
                    {
                        var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                        {
                            Video_ai_instance = oVideo_ai_instance
                        });
                    }
                    catch
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0038)); // Invalid Credentials or Connection Url
                    }
                }

                Edit_Video_ai_instance(oVideo_ai_instance);
                oVideo_ai_instance.PASSWORD = "";

                return oVideo_ai_instance;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); //Invalid Input
            }
        }
        #endregion
        #region Edit_Video_ai_instance_custom
        public Video_ai_instance_with_connection_flag Edit_Video_ai_instance_custom(Params_Edit_Video_ai_instance_custom i_Params_Edit_Video_ai_instance_custom)
        {
            if (i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.VIDEO_AI_INSTANCE_ID > 0 &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.VIDEO_AI_INSTANCE_ID != null &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.VIDEO_AI_ENGINE_ID > 0 &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.VIDEO_AI_ENGINE_ID != null &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.CONNECTION_TYPE_SETUP_ID > 0 &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.CONNECTION_TYPE_SETUP_ID != null &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.USERNAME.Trim() != "" &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.FRIENDLY_NAME.Trim() != "" &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.CONNECTION_URL.Trim() != "" &&
                i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.FUNCTIONAL_NAME.Trim() != "")
            {
                Video_ai_instance_with_connection_flag oVideo_ai_instance_with_connection_flag = new Video_ai_instance_with_connection_flag()
                {
                    oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
                    {
                        VIDEO_AI_INSTANCE_ID = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.VIDEO_AI_INSTANCE_ID
                    }),
                    RESPONSE_MESSAGE = "",
                    IS_FORCE_CONNECTION = false
                };

                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.USERNAME = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.USERNAME;
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.VIDEO_AI_ENGINE_ID = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.VIDEO_AI_ENGINE_ID;
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.CONNECTION_URL = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.CONNECTION_URL;
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.CONNECTION_TYPE_SETUP_ID;
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.FRIENDLY_NAME = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.FRIENDLY_NAME;
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.FUNCTIONAL_NAME = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.FUNCTIONAL_NAME;
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.IS_LPR = i_Params_Edit_Video_ai_instance_custom.Video_ai_instance.IS_LPR;

                if (!i_Params_Edit_Video_ai_instance_custom.FORCE_CONNECTION)
                {
                    try
                    {
                        Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                        {
                            Video_ai_instance = oVideo_ai_instance_with_connection_flag.oVideo_ai_instance
                        });
                    }
                    catch
                    {
                        oVideo_ai_instance_with_connection_flag.IS_FORCE_CONNECTION = true;
                        oVideo_ai_instance_with_connection_flag.RESPONSE_MESSAGE = "Invalid Credentials or Connection Url";
                        oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.PASSWORD = "";
                        return oVideo_ai_instance_with_connection_flag;
                    }
                }

                Edit_Video_ai_instance(oVideo_ai_instance_with_connection_flag.oVideo_ai_instance);
                oVideo_ai_instance_with_connection_flag.oVideo_ai_instance.PASSWORD = "";

                return oVideo_ai_instance_with_connection_flag;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); //Invalid Input
            }
        }
        #endregion
        #region Create_Video_ai_asset
        public Video_ai_asset Create_Video_ai_asset(Params_Create_Video_ai_asset i_Params_Create_Video_ai_asset)
        {
            if (
                i_Params_Create_Video_ai_asset.VIDEO_AI_INSTANCE_ID != null &&
                i_Params_Create_Video_ai_asset.VIDEO_AI_INSTANCE_ID > 0 &&
                i_Params_Create_Video_ai_asset.SPACE_ASSET_ID != null &&
                i_Params_Create_Video_ai_asset.SPACE_ASSET_ID > 0 &&
                i_Params_Create_Video_ai_asset.ENTITY_ID != null &&
                i_Params_Create_Video_ai_asset.ENTITY_ID > 0 &&
                i_Params_Create_Video_ai_asset.FRIENDLY_NAME.Trim() != "" &&
                i_Params_Create_Video_ai_asset.FUNCTIONAL_NAME.Trim() != ""
            )
            {
                Video_ai_asset oVideo_ai_asset = new Video_ai_asset()
                {
                    VIDEO_AI_INSTANCE_ID = i_Params_Create_Video_ai_asset.VIDEO_AI_INSTANCE_ID,
                    SPACE_ASSET_ID = i_Params_Create_Video_ai_asset.SPACE_ASSET_ID,
                    FRIENDLY_NAME = i_Params_Create_Video_ai_asset.FRIENDLY_NAME,
                    FUNCTIONAL_NAME = i_Params_Create_Video_ai_asset.FUNCTIONAL_NAME,
                    VIDEO_AI_ASSET_ID_REF = i_Params_Create_Video_ai_asset.VIDEO_AI_ASSET_ID_REF,
                    VIDEO_AI_ASSET_ID = -1,
                    List_Video_ai_asset_entity = new List<Video_ai_asset_entity>(),
                    RESOLUTION_X = i_Params_Create_Video_ai_asset.RESOLUTION_X,
                    RESOLUTION_Y = i_Params_Create_Video_ai_asset.RESOLUTION_Y
                };
                Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity()
                {
                    VIDEO_AI_ASSET_ENTITY_ID = -1,
                    ENTITY_ID = i_Params_Create_Video_ai_asset.ENTITY_ID
                };
                oVideo_ai_asset.List_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);

                Edit_Video_ai_asset(oVideo_ai_asset);
                return oVideo_ai_asset;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); //Invalid Input
            }
        }
        #endregion
        #region Change_Video_ai_instance_Password
        public Change_Video_ai_instance_Password_Response Change_Video_ai_instance_Password(Params_Change_Video_ai_instance_Password i_Params_Change_Video_ai_instance_Password)
        {
            if (i_Params_Change_Video_ai_instance_Password.NEW_PASSWORD != null &&
                i_Params_Change_Video_ai_instance_Password.NEW_PASSWORD.Trim() != "" &&
                i_Params_Change_Video_ai_instance_Password.VIDEO_AI_INSTANCE_ID != null &&
                i_Params_Change_Video_ai_instance_Password.VIDEO_AI_INSTANCE_ID > 0)
            {
                #region Get Video Ai Instance
                Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
                {
                    VIDEO_AI_INSTANCE_ID = i_Params_Change_Video_ai_instance_Password.VIDEO_AI_INSTANCE_ID
                });
                #endregion

                string encrypted_password = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]PASSWORD:{0}[~!@]" + Tools.Get_Unique_String(), i_Params_Change_Video_ai_instance_Password.NEW_PASSWORD));
                oVideo_ai_instance.PASSWORD = encrypted_password;
                if (!i_Params_Change_Video_ai_instance_Password.FORCE_CONNECTION)
                {
                    try
                    {
                        Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                        {
                            Video_ai_instance = oVideo_ai_instance
                        });
                    }
                    catch
                    {
                        return new Change_Video_ai_instance_Password_Response()
                        {
                            IS_FORCE_CONNECTION = true,
                            RESPONSE_MESSAGE = "Password for instance is incorrect",
                            SUCCESSFUL_PASSWORD_CHANGE = false,
                        };
                    }
                }
                Edit_Video_ai_instance(oVideo_ai_instance);
                return new Change_Video_ai_instance_Password_Response()
                {
                    SUCCESSFUL_PASSWORD_CHANGE = true,
                    IS_FORCE_CONNECTION = false,
                    RESPONSE_MESSAGE = "Success",
                };
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Space_asset_Vaidio_camera
        public Video_ai_asset Get_Space_asset_Vaidio_camera(Params_Get_Space_asset_Vaidio_camera i_Params_Get_Space_asset_Vaidio_camera)
        {
            if (i_Params_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID != null &&
                i_Params_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID > 0)
            {
                Video_ai_asset oVideo_ai_asset = Get_Video_ai_asset_By_SPACE_ASSET_ID(new Params_Get_Video_ai_asset_By_SPACE_ASSET_ID
                {
                    SPACE_ASSET_ID = i_Params_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID
                }).FirstOrDefault();

                if (oVideo_ai_asset != null && oVideo_ai_asset != default)
                {
                    oVideo_ai_asset.Surveillance_Camera_Content = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID
                    {
                        ID = (int)oVideo_ai_asset.VIDEO_AI_ASSET_ID_REF,
                        VIDEO_AI_INSTANCE_ID = oVideo_ai_asset.VIDEO_AI_INSTANCE_ID
                    });

                    Task.Run(() =>
                    {
                        User oUser = new User();
                        Setup_category oLog_Type_Setup_category = new Setup_category();
                        Setup_category oAccess_Type_Setup_category = new Setup_category();
                        var get_log_type = Task.Run(() =>
                        {
                            oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Log Type",
                                OWNER_ID = oBLC_Initializer.Owner_ID
                            });
                        });
                        var get_access_type = Task.Run(() =>
                        {
                            oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Access Type",
                                OWNER_ID = oBLC_Initializer.Owner_ID
                            });
                        });
                        var get_user = Task.Run(() =>
                        {
                            oUser = Props.Copy_Prop_Values_From_Api_Response<User>(
                                this._service_mesh.Get_User_By_USER_ID(new Service_Mesh.Params_Get_User_By_USER_ID()
                                {
                                    USER_ID = this.oBLC_Initializer.User_ID
                                }).i_Result
                            );
                        });
                        Task.WaitAll(get_access_type, get_log_type, get_user);
                    });

                    if (oVideo_ai_asset?.Surveillance_Camera_Content != null)
                    {
                        return oVideo_ai_asset;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Vaidio camera").Replace("%2", oVideo_ai_asset.VIDEO_AI_ASSET_ID_REF.ToString()));
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0040).Replace("%2", i_Params_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID.ToString())); // Video ai asset with Space asset ID %2 not found
                }

            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Detect_Face_In_Image
        public Detect_Face_Response Detect_Face_In_Image(Params_Detect_Face_In_Image i_Params_Detect_Face_In_Image)
        {
            if (
                i_Params_Detect_Face_In_Image.List_Uploaded_File != null &&
                i_Params_Detect_Face_In_Image.List_Uploaded_File.Count > 0
            )
            {
                #region Get Video Ai Instance
                Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_OWNER_ID(new Params_Get_Video_ai_instance_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).Where(instance => instance.IS_LPR).FirstOrDefault();
                #endregion

                var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
                {
                    Video_ai_instance = oVideo_ai_instance
                });

                byte[] data;

                using (var oMemoryStream = new MemoryStream())
                {
                    i_Params_Detect_Face_In_Image.List_Uploaded_File.First().CopyTo(oMemoryStream);
                    data = oMemoryStream.ToArray();
                }

                string url = $"{oVideo_ai_instance.CONNECTION_URL}/face";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("x-auth-token", xAuthToken);
                request.AddFile("file", data, "file");
                RestResponse response = client.Execute(request);
                Detect_Face_Api_Response oDetect_Face_Api_Response = JsonConvert.DeserializeObject<List<Detect_Face_Api_Response>>(response.Content).First();
                Detect_Face_Response oDetect_Face_Response = Props.Copy_Prop_Values_From_Api_Response<Detect_Face_Response>(oDetect_Face_Api_Response);

                return oDetect_Face_Response;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Face_Search
        public Face_Key_Response_List Face_Search(Params_Face_Search i_Params_Face_Search)
        {
            string filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "FR_Search.json";
            string json = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(filePath).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                }
            }

            Face_Key_Response_List oFace_Key_Response_List = JsonConvert.DeserializeObject<Face_Key_Response_List>(json);

            return oFace_Key_Response_List;
        }
        #endregion
        #region Face_Target_Key_Search
        public Search_Face_Target_Key_Response_List Face_Target_Key_Search(Params_Face_Target_Key_Search i_Params_Face_Target_Key_Search)
        {
            string filePath = ConfigurationManager.AppSettings["JSON_PATH"] + "FR_Search_List.json";
            string json = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(filePath).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    }
                }
            }

            Search_Face_Target_Key_Response_List oSearch_Face_Target_Key_Response_List = JsonConvert.DeserializeObject<Search_Face_Target_Key_Response_List>(json);

            return oSearch_Face_Target_Key_Response_List;
        }
        #endregion
        #region Fetch_Alerts
        public Fetch_Alerts_Response Fetch_Alerts(Params_Fetch_Alerts i_Params_Fetch_Alerts)
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_OWNER_ID(new Params_Get_Video_ai_instance_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            }).Where(instance => !instance.IS_LPR).FirstOrDefault();
            #endregion

            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance,
            });

            string url = $"{oVideo_ai_instance.CONNECTION_URL}/alerts";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddQueryParameter("size", i_Params_Fetch_Alerts.SIZE.ToString());
            request.AddQueryParameter("page", i_Params_Fetch_Alerts.PAGE.ToString());
            request.AddQueryParameter("alertRuleIds", i_Params_Fetch_Alerts.ALERT_RULES);
            request.AddParameter("start", i_Params_Fetch_Alerts.START_DATE);
            request.AddParameter("end", i_Params_Fetch_Alerts.END_DATE);
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");
            RestResponse response = client.Execute(request);
            Fetch_Alerts_Api_Response oFetch_Alerts_Api_Response = Fetch_Alerts_Api_Response.FromJson(response.Content);

            return Props.Copy_Prop_Values_From_Api_Response<Fetch_Alerts_Response>(oFetch_Alerts_Api_Response);
        }
        #endregion
        #region Fetch_Alert_Rules
        public List<Alert_Rule_Response> Fetch_Alert_Rules()
        {
            #region Get Video Ai Instance
            Video_ai_instance oVideo_ai_instance = Get_Video_ai_instance_By_OWNER_ID(new Params_Get_Video_ai_instance_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            }).Where(instance => !instance.IS_LPR).FirstOrDefault();
            #endregion

            var xAuthToken = Get_Vaidio_Auth_Token(new Params_Get_Vaidio_Auth_Token()
            {
                Video_ai_instance = oVideo_ai_instance,
            });

            string url = $"{oVideo_ai_instance.CONNECTION_URL}/alertRules";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddQueryParameter("size", "20");
            request.AddHeader("x-auth-token", xAuthToken);
            request.AddParameter("Content-Type", "text/plain");
            RestResponse response = client.Execute(request);
            List<Alert_Rule_Api_Response> oList_Alert_Rule_Api_Response = JsonConvert.DeserializeObject<Fetch_Alert_Rules_Api_Response>(response.Content).Content.ToList();

            return Props.Copy_Prop_Values_From_Api_Response<List<Alert_Rule_Response>>(oList_Alert_Rule_Api_Response);
        }
        #endregion
        #region Update_Alerts
        public bool Update_Alerts()
        {
            List<Alert_Rule_Response> oList_Alert_Rule_Response = Fetch_Alert_Rules();

            Params_Fetch_Alerts oParams_Fetch_Alerts = new Params_Fetch_Alerts()
            {
                START_DATE = Get_Timezone_Date(DateTime.UtcNow.AddHours(-24)).ToString("yyyy-MM-dd HH:mm:ss"),
                END_DATE = Get_Timezone_Date(DateTime.UtcNow).ToString("yyyy-MM-dd HH:mm:ss"),
                ALERT_RULES = string.Join(",", oList_Alert_Rule_Response.Select(alert => alert.AlertRuleId).ToList()),
                SIZE = 1
            };

            List<Entity> oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
               this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
               {
                   OWNER_ID = this.oBLC_Initializer.Owner_ID
               }).i_Result
            );

            Setup oSetup_Access_control = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Security Incident Category Type"
            }).List_Setup.Find(setup => setup.VALUE == "Access Control");

            Fetch_Alerts_Response oFetch_Alerts_Response = Fetch_Alerts(oParams_Fetch_Alerts);

            List<Video_ai_asset> oList_Video_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
            {
                VIDEO_AI_ASSET_ID_REF_LIST = new List<int?>() { 4 },
            });

            #region Save Alerts in Database
            List<Service_Mesh.Incident> oList_Incident = new List<Service_Mesh.Incident>();

            Video_ai_asset oVideo_ai_asset = oList_Video_ai_asset.FirstOrDefault(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 4);
            int video_ai_instance_id;
            video_ai_instance_id = (int)oVideo_ai_asset.VIDEO_AI_INSTANCE_ID;
            Service_Mesh.Incident oIncident = new Service_Mesh.Incident();
            oList_Entity.ForEach(entity =>
            {
                oIncident = new Service_Mesh.Incident()
                {
                    Security_Incident = new Service_Mesh.Security_Incident()
                    {
                        CATEGORY_SETUP_ID = oSetup_Access_control.SETUP_ID
                    },
                    CREATED_TIME = DateTime.Now,
                    ENTITY_ID = Tools.Get_Random_Number(1, 9, new int?[] { 5, 6, 7 }),
                    DIMENSION_ORDER = 2,
                    SCENE_ID = 19803613,
                    CAMERA = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Surveillance_Camera_Content>(Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                    {
                        ID = (int)4,
                        VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                    })),
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                };
                oList_Incident.Add(oIncident);
            });

            Scene_Info oScene_Info = Get_Scene_Info(new Params_Get_Scene_Info()
            {
                SCENE_ID = (int?)oIncident.SCENE_ID,
                VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                OBJECT_TYPE = "ACCESS CONTROL"
            });
            if (oScene_Info.SCENE_DETAILS.Camera == null)
            {
                oScene_Info.SCENE_DETAILS.Camera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                {
                    ID = (int)oScene_Info.SCENE_DETAILS.CameraId,
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                });
            }

            Send_Alerts_To_All_Emails(new Params_Send_Alerts_To_All_Emails()
            {
                Incident = Props.Copy_Prop_Values_From_Api_Response<Incident>(oIncident),
                Scene = oScene_Info.SCENE_DETAILS,
            });

            this._service_mesh.Edit_Incident_List(new Service_Mesh.Params_Edit_Incident_List()
            {
                INCIDENT_LIST = oList_Incident
            });

            return true;
            #endregion

        }
        #endregion
        #region Update_Alerts_Custom
        public bool Update_Alerts_Custom()
        {
            List<Video_ai_asset> oList_Video_ai_asset = Get_Video_ai_asset_By_OWNER_ID(new Params_Get_Video_ai_asset_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });

            List<Entity> oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
                this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result
            );

            Setup_category oSetup_category_Incident_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Security Incident Category Type"
            });

            Params_Fetch_Scenes oParams_Fetch_Fire_Alarm_Scenes = new Params_Fetch_Scenes()
            {
                START_DATE = Get_Timezone_Date(DateTime.UtcNow.AddHours(-24)).ToString("yyyy-MM-dd HH:mm:ss"),
                END_DATE = Get_Timezone_Date(DateTime.UtcNow).ToString("yyyy-MM-dd HH:mm:ss"),
                List_Video_ai_asset = oList_Video_ai_asset.Where(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 8).ToList(),
                SIZE = 1,
                PAGE = 0,
                QUERY = "Fire",
            };
            Fetch_Scenes_Response oFetch_Fire_Alarm_Scenes_Response = Fetch_Scenes(oParams_Fetch_Fire_Alarm_Scenes);
            #region Save Alerts in Database
            List<Service_Mesh.Incident> oList_Incident = new List<Service_Mesh.Incident>();
            Video_ai_asset oVideo_ai_asset = oList_Video_ai_asset.FirstOrDefault(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 8);
            int video_ai_instance_id;
            video_ai_instance_id = (int)oVideo_ai_asset.VIDEO_AI_INSTANCE_ID;
            Service_Mesh.Incident oIncident = new Service_Mesh.Incident();
            oList_Entity.ForEach(entity =>
            {
                oIncident = new Service_Mesh.Incident()
                {
                    Security_Incident = new Service_Mesh.Security_Incident()
                    {
                        CATEGORY_SETUP_ID = oSetup_category_Incident_category.List_Setup.Find(setup => setup.VALUE == "Fire Alarm").SETUP_ID
                    },
                    CREATED_TIME = DateTime.Now,
                    ENTITY_ID = entity.ENTITY_ID,
                    DIMENSION_ORDER = 2,
                    SCENE_ID = 152989097,
                    CAMERA = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Surveillance_Camera_Content>(Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                    {
                        ID = (int)8,
                        VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                    })),
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                };
                oList_Incident.Add(oIncident);
            });

            Scene_Info oScene_Info = Get_Scene_Info(new Params_Get_Scene_Info()
            {
                SCENE_ID = (int?)oIncident.SCENE_ID,
                VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                OBJECT_TYPE = "FIRE ALARM"
            });
            if (oScene_Info.SCENE_DETAILS.Camera == null)
            {
                oScene_Info.SCENE_DETAILS.Camera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                {
                    ID = (int)oScene_Info.SCENE_DETAILS.CameraId,
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                });
            }

            Send_Alerts_To_All_Emails(new Params_Send_Alerts_To_All_Emails()
            {
                Incident = Props.Copy_Prop_Values_From_Api_Response<Incident>(oIncident),
                Scene = oScene_Info.SCENE_DETAILS,
            });
            this._service_mesh.Edit_Incident_List(new Service_Mesh.Params_Edit_Incident_List()
            {
                INCIDENT_LIST = oList_Incident
            });

            #endregion
            Fetch_Scenes_Response oFetch_Suspicious_Behavior_Scenes_Response = Fetch_Scenes(new Params_Fetch_Scenes()
            {
                START_DATE = Get_Timezone_Date(DateTime.UtcNow.AddHours(-24)).ToString("yyyy-MM-dd HH:mm:ss"),
                END_DATE = Get_Timezone_Date(DateTime.UtcNow).ToString("yyyy-MM-dd HH:mm:ss"),
                List_Video_ai_asset = oList_Video_ai_asset.Where(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 10).ToList(),
                SIZE = 1,
                QUERY = "Rifle or Handgun",
            });
            #region Save Alerts in Database
            oList_Incident = new List<Service_Mesh.Incident>();
            oVideo_ai_asset = oList_Video_ai_asset.FirstOrDefault(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 10);
            video_ai_instance_id = (int)oVideo_ai_asset.VIDEO_AI_INSTANCE_ID;
            oIncident = new Service_Mesh.Incident();
            oList_Entity.ForEach(entity =>
            {
                oIncident = new Service_Mesh.Incident()
                {
                    Security_Incident = new Service_Mesh.Security_Incident()
                    {
                        CATEGORY_SETUP_ID = oSetup_category_Incident_category.List_Setup.Find(setup => setup.VALUE == "Suspicious Behavior").SETUP_ID
                    },
                    CREATED_TIME = DateTime.Now,
                    ENTITY_ID = entity.ENTITY_ID,
                    DIMENSION_ORDER = 2,
                    SCENE_ID = 152989960,
                    CAMERA = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Surveillance_Camera_Content>(Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                    {
                        ID = (int)10,
                        VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                    })),
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                };
                oList_Incident.Add(oIncident);
            });

            oScene_Info = Get_Scene_Info(new Params_Get_Scene_Info()
            {
                SCENE_ID = (int?)oIncident.SCENE_ID,
                VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                OBJECT_TYPE = "INTRUDER"
            });
            if (oScene_Info.SCENE_DETAILS.Camera == null)
            {
                oScene_Info.SCENE_DETAILS.Camera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                {
                    ID = (int)oScene_Info.SCENE_DETAILS.CameraId,
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                });
            }

            Send_Alerts_To_All_Emails(new Params_Send_Alerts_To_All_Emails()
            {
                Incident = Props.Copy_Prop_Values_From_Api_Response<Incident>(oIncident),
                Scene = oScene_Info.SCENE_DETAILS,
            });
            this._service_mesh.Edit_Incident_List(new Service_Mesh.Params_Edit_Incident_List()
            {
                INCIDENT_LIST = oList_Incident
            });

            #endregion
            return true;
        }
        #endregion
        #region Facial_Recognition_Alerts
        public bool Update_Facial_Recognition_Alerts()
        {
            List<Video_ai_asset> oList_Video_ai_asset = Get_Video_ai_asset_By_OWNER_ID(new Params_Get_Video_ai_asset_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });

            List<Entity> oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
                this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result
            );

            Setup oSetup_Blacklisted_person = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Security Incident Category Type"
            }).List_Setup.Find(setup => setup.VALUE == "Blacklisted Person");

            Fetch_Facial_Recognition_Reponse oFetch_Facial_Recognition_Reponse = Fetch_Facial_Recognition(new Params_Fetch_Facial_Recognition()
            {
                START_DATE = Get_Timezone_Date(DateTime.UtcNow.AddHours(-24)).ToString("yyyy-MM-dd HH:mm:ss"),
                END_DATE = Get_Timezone_Date(DateTime.UtcNow).ToString("yyyy-MM-dd HH:mm:ss"),
                List_Video_ai_asset = oList_Video_ai_asset.Where(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 2).ToList(),
                SIZE = 1,
                PAGE = 0,
                TARGET_NAME = "Sophia"
            });
            #region Save Alerts in Database
            List<Service_Mesh.Incident> oList_Incident = new List<Service_Mesh.Incident>();
            Video_ai_asset oVideo_ai_asset = oList_Video_ai_asset.FirstOrDefault(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 1);
            int video_ai_instance_id;
            video_ai_instance_id = (int)oVideo_ai_asset.VIDEO_AI_INSTANCE_ID;
            Service_Mesh.Incident oIncident = new Service_Mesh.Incident();
            oList_Entity.ForEach(entity =>
            {
                oIncident = new Service_Mesh.Incident()
                {
                    Security_Incident = new Service_Mesh.Security_Incident()
                    {
                        CATEGORY_SETUP_ID = oSetup_Blacklisted_person.SETUP_ID
                    },
                    CREATED_TIME = DateTime.Now,
                    ENTITY_ID = entity.ENTITY_ID,
                    DIMENSION_ORDER = 2,
                    SCENE_ID = 166818932,
                    CAMERA = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Surveillance_Camera_Content>(Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                    {
                        ID = (int)1,
                        VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                    })),
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                    BLACKLISTED_PERSON_NAME = "Sophia"
                };
                oList_Incident.Add(oIncident);
            });

            Scene_Info oScene_Info = Get_Scene_Info(new Params_Get_Scene_Info()
            {
                SCENE_ID = (int?)oIncident.SCENE_ID,
                VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                OBJECT_TYPE = "FR"
            });
            if (oScene_Info.SCENE_DETAILS.Camera == null)
            {
                oScene_Info.SCENE_DETAILS.Camera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                {
                    ID = (int)oScene_Info.SCENE_DETAILS.CameraId,
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                });
            }

            Send_Alerts_To_All_Emails(new Params_Send_Alerts_To_All_Emails()
            {
                Incident = Props.Copy_Prop_Values_From_Api_Response<Incident>(oIncident),
                Scene = oScene_Info.SCENE_DETAILS,
            });
            this._service_mesh.Edit_Incident_List(new Service_Mesh.Params_Edit_Incident_List()
            {
                INCIDENT_LIST = oList_Incident
            });

            #endregion
            return true;
        }
        #endregion
        #region License_Plate_Recognition_Alerts
        public bool Update_License_Plate_Recognition_Alerts()
        {
            List<Video_ai_asset> oList_Video_ai_asset = Get_Video_ai_asset_By_OWNER_ID(new Params_Get_Video_ai_asset_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });

            List<Entity> oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
                this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result
            );

            Setup oSetup_Blacklisted_plate = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Security Incident Category Type"
            }).List_Setup.Find(setup => setup.VALUE == "Blacklisted Plate");

            Fetch_License_Plate_Recognition_Response oFetch_License_Plate_Recognition_Response = Fetch_License_Plate_Recognition(new Params_Fetch_License_Plate_Recognition()
            {
                List_Video_ai_asset = oList_Video_ai_asset.Where(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 13).ToList(),
                VEHICLE_TYPE = "Bus",
                PAGE = 0,
                SIZE = 1
            });
            #region Save Alerts in Database
            List<Service_Mesh.Incident> oList_Incident = new List<Service_Mesh.Incident>();
            Fetch_License_Plate_Recognition_Response_Content oFetch_License_Plate_Recognition_Response_Content = oFetch_License_Plate_Recognition_Response.List_Fetch_License_Plate_Recognition_Response_Content.FirstOrDefault();
            Video_ai_asset oVideo_ai_asset = oList_Video_ai_asset.FirstOrDefault(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == 13);
            int video_ai_instance_id;
            video_ai_instance_id = (int)oVideo_ai_asset.VIDEO_AI_INSTANCE_ID;
            Service_Mesh.Incident oIncident = new Service_Mesh.Incident();
            oList_Entity.ForEach(entity =>
            {
                oIncident = new Service_Mesh.Incident()
                {
                    Security_Incident = new Service_Mesh.Security_Incident()
                    {
                        CATEGORY_SETUP_ID = oSetup_Blacklisted_plate.SETUP_ID
                    },
                    CREATED_TIME = DateTime.Now,
                    ENTITY_ID = entity.ENTITY_ID,
                    DIMENSION_ORDER = 2,
                    SCENE_ID = 152930365,
                    CAMERA = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Surveillance_Camera_Content>(Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                    {
                        ID = (int)13,
                        VIDEO_AI_INSTANCE_ID = video_ai_instance_id
                    })),
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                    BLACKLISTED_LICENSE_PLATE = "PO7AUF",
                    BLACKLISTED_LICENSE_FILE_URL = ConfigurationManager.AppSettings["IMAGE_PATH"] + "License_Plate.png",
                };
                oList_Incident.Add(oIncident);
            });

            Scene_Info oScene_Info = Get_Scene_Info(new Params_Get_Scene_Info()
            {
                SCENE_ID = (int?)oIncident.SCENE_ID,
                VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                OBJECT_TYPE = "LPR"
            });
            if (oScene_Info.SCENE_DETAILS.Camera == null)
            {
                oScene_Info.SCENE_DETAILS.Camera = Get_Camera_By_Camera_ID(new Params_Get_Camera_By_Camera_ID()
                {
                    ID = (int)oScene_Info.SCENE_DETAILS.CameraId,
                    VIDEO_AI_INSTANCE_ID = video_ai_instance_id,
                });
            }

            Send_Alerts_To_All_Emails(new Params_Send_Alerts_To_All_Emails()
            {
                Incident = Props.Copy_Prop_Values_From_Api_Response<Incident>(oIncident),
                Scene = oScene_Info.SCENE_DETAILS,
            });

            this._service_mesh.Edit_Incident_List(new Service_Mesh.Params_Edit_Incident_List()
            {
                INCIDENT_LIST = oList_Incident
            });

            #endregion
            return true;
        }
        #endregion
        #region Send_Alerts_To_All_Emails
        public bool Send_Alerts_To_All_Emails(Params_Send_Alerts_To_All_Emails i_Params_Send_Alerts_To_All_Emails)
        {
            if (i_Params_Send_Alerts_To_All_Emails.Scene != null)
            {
                List<User> oList_User = Props.Copy_Prop_Values_From_Api_Response<List<User>>(
                    this._service_mesh.Get_User_By_IS_RECEIVE_EMAIL(new Service_Mesh.Params_Get_User_By_IS_RECEIVE_EMAIL()
                    {
                        IS_RECEIVE_EMAIL = true
                    }).i_Result
                );

                if (oList_User.Count == 0)
                {
                    return true;
                }

                List<Setup> oList_setup = this.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Security Incident Category Type",
                    OWNER_ID = oBLC_Initializer.Owner_ID
                }).List_Setup;

                List<Organization> oList_Organization = Props.Copy_Prop_Values_From_Api_Response<List<Organization>>(
                    this._service_mesh.Get_Organization_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = oList_User.Select(user => user.ORGANIZATION_ID).Distinct()
                    }).i_Result
                );

                Default_settings oDefault_settings = Props.Copy_Prop_Values_From_Api_Response<Default_settings>(
                    this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result.FirstOrDefault()
                );

                Setup oSetup = oList_setup.Find(setup => setup.SETUP_ID == i_Params_Send_Alerts_To_All_Emails.Incident.Security_Incident.CATEGORY_SETUP_ID);

                foreach (Organization oOrganization in oList_Organization)
                {
                    Task.Run(() =>
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Access Control":
                                i_Params_Send_Alerts_To_All_Emails.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Access_Control.png";
                                break;
                            case "Suspicious Behavior":
                                i_Params_Send_Alerts_To_All_Emails.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Intruder.png";
                                break;
                            case "Fire Alarm":
                                i_Params_Send_Alerts_To_All_Emails.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Fire_Alarm.png";
                                break;
                            case "Blacklisted Person":
                                i_Params_Send_Alerts_To_All_Emails.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Blacklisted_Person.png";
                                break;
                            case "Blacklisted Plate":
                                i_Params_Send_Alerts_To_All_Emails.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Blacklisted_Plate.png";
                                break;
                        }
                        #region Setup Mail & Send
                        #region Get SMTP Credentials
                        string smtp_email = "";
                        string smtp_password = "";
                        var get_smtp_email = Task.Run(() =>
                        {
                            smtp_email = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                            {
                                Secret_Id = ConfigurationManager.AppSettings["SMTP_EMAIL"]
                            }).i_Result;
                        });
                        var get_smtp_password = Task.Run(() =>
                        {
                            smtp_password = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                            {
                                Secret_Id = ConfigurationManager.AppSettings["SMTP_PASSWORD"]
                            }).i_Result;
                        });
                        Task.WaitAll(get_smtp_email, get_smtp_password);
                        #endregion
                        #region Create & Send Email
                        #region Properties & Initialization
                        string logo_link;
                        if (isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY))
                        {
                            logo_link = oOrganization.LIGHT_RECTANGLE_LOGO_URL;
                        }
                        else
                        {
                            logo_link = oOrganization.DARK_RECTANGLE_LOGO_URL;
                        }
                        if (logo_link == null)
                        {
                            logo_link = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? oDefault_settings.LIGHT_RECTANGLE_LOGO_URL : oDefault_settings.DARK_SQUARE_LOGO_URL;
                        }
                        string email_title = $"{oList_setup.Where(setup => setup.SETUP_ID == i_Params_Send_Alerts_To_All_Emails.Incident.Security_Incident.CATEGORY_SETUP_ID).First().VALUE} Alert";
                        string highlight_font_color = "#000000";
                        string company_name = oOrganization.ORGANIZATION_NAME + " DistrictNex";
                        string background_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY;
                        string border_bottom_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                        string fine_print_color = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? "white" : oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                        #endregion
                        #region Get HTML Template
                        string body = string.Empty;
                        using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["ALERTS_TEMPLATE"]))
                        {
                            body = reader.ReadToEnd();
                        }
                        #endregion
                        #region Insert Data
                        body = body.Replace("{LogoLink}", logo_link);
                        body = body.Replace("{SmallTitle}", email_title);
                        body = body.Replace("{FinePrintColor}", fine_print_color);
                        body = body.Replace("{BackgroundColor}", background_color);
                        body = body.Replace("{BottomBorderColor}", border_bottom_color);
                        body = body.Replace("{HighlightFontColor}", highlight_font_color);
                        body = body.Replace("{EventName}", oList_setup.Where(setup => setup.SETUP_ID == i_Params_Send_Alerts_To_All_Emails.Incident.Security_Incident.CATEGORY_SETUP_ID).First().VALUE);
                        string setup_value = oList_setup.Where(setup => setup.SETUP_ID == i_Params_Send_Alerts_To_All_Emails.Incident.Security_Incident.CATEGORY_SETUP_ID).First().VALUE;
                        if (setup_value == "Blacklisted Person")
                        {
                            body = body.Replace("{Seperator}", " -");
                            body = body.Replace("{ObjectName}", i_Params_Send_Alerts_To_All_Emails.Incident.BLACKLISTED_PERSON_NAME);
                        }
                        else if (setup_value == "Blacklisted Plate")
                        {
                            body = body.Replace("{Seperator}", " -");
                            body = body.Replace("{ObjectName}", i_Params_Send_Alerts_To_All_Emails.Incident.BLACKLISTED_LICENSE_PLATE);
                        }
                        else
                        {
                            body = body.Replace("{Seperator}", "");
                            body = body.Replace("{ObjectName}", "");
                        }
                        body = body.Replace("{CameraName}", i_Params_Send_Alerts_To_All_Emails.Scene.Camera?.Name ?? "-");
                        body = body.Replace("{EventDateTime}", i_Params_Send_Alerts_To_All_Emails.Scene.Datetime.DateTime.ToString("dd-MM-yyyy HH:mm:ss"));
                        body = body.Replace("{EventImageURL}", i_Params_Send_Alerts_To_All_Emails.Scene.File);
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
                                Body = body,
                                IsBodyHtml = true,
                                Priority = MailPriority.Normal,
                                Subject = $"{company_name} Alert",
                                BodyEncoding = System.Text.Encoding.UTF8,
                                SubjectEncoding = System.Text.Encoding.UTF8,
                                From = new MailAddress(smtp_email, company_name),
                                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                            };
                            #region Recipients
                            List<User> oList_Current_User = oList_User.Where(user => user.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                            oList_User.Where(user => oList_Current_User.Any(user => user.USER_ID == user.USER_ID)).ToList().ForEach(user =>
                            {
                                message.To.Add(user.EMAIL);
                            });
                            #endregion
                            try
                            {
                                client.Send(message);
                            }
                            catch (Exception)
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0030)); // An Error has Occured! Contact Support.
                            }
                        }
                        #endregion
                        #endregion
                    });
                }
                return true;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Send_Alerts_Email
        public bool Send_Alerts_Email(Params_Send_Alerts_Email i_Params_Send_Alerts_Email)
        {
            if (
                i_Params_Send_Alerts_Email.Scene != null &&
                i_Params_Send_Alerts_Email.TO_EMAIL != null &&
                i_Params_Send_Alerts_Email.TO_EMAIL.Trim() != ""
            )
            {
                List<Setup> oList_setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Security Incident Category Type",
                    OWNER_ID = oBLC_Initializer.Owner_ID
                }).List_Setup;

                User oUser = Props.Copy_Prop_Values_From_Api_Response<User>(
                    this._service_mesh.Get_User_By_USER_ID_Adv(new Service_Mesh.Params_Get_User_By_USER_ID()
                    {
                        USER_ID = oBLC_Initializer.User_ID,
                    }).i_Result
                );

                Setup oSetup = oList_setup.Find(setup => setup.SETUP_ID == i_Params_Send_Alerts_Email.Incident.Security_Incident.CATEGORY_SETUP_ID);

                Task.Run(() =>
                {
                    switch (oSetup.VALUE)
                    {
                        case "Access Control":
                            i_Params_Send_Alerts_Email.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Access_Control.png";
                            break;
                        case "Suspicious Behavior":
                            i_Params_Send_Alerts_Email.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Intruder.png";
                            break;
                        case "Fire Alarm":
                            i_Params_Send_Alerts_Email.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Fire_Alarm.png";
                            break;
                        case "Blacklisted Person":
                            i_Params_Send_Alerts_Email.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Blacklisted_Person.png";
                            break;
                        case "Blacklisted Plate":
                            i_Params_Send_Alerts_Email.Scene.File = ConfigurationManager.AppSettings["IMAGE_PATH"] + "Blacklisted_Plate.png";
                            break;
                    }
                    #region Setup Mail & Send
                    #region Get SMTP Credentials
                    string smtp_email = "";
                    string smtp_password = "";
                    Organization oOrganization = new Organization();
                    Default_settings oDefault_settings = new Default_settings();
                    var get_default_settings = Task.Run(() =>
                    {
                        oDefault_settings = Props.Copy_Prop_Values_From_Api_Response<Default_settings>(
                            this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                            {
                                OWNER_ID = this.oBLC_Initializer.Owner_ID
                            }).i_Result.FirstOrDefault()
                        );
                    });
                    var get_organization = Task.Run(() =>
                    {
                        oOrganization = Props.Copy_Prop_Values_From_Api_Response<Organization>(
                            this._service_mesh.Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading()
                            {
                                ORGANIZATION_ID = oUser.ORGANIZATION_ID,
                                LIST_EAGER_LOADED_DATA = new List<string>() { "Organization_color_scheme", "Organization_image" },
                            }).i_Result
                        );
                    });
                    Task.WaitAll(get_default_settings, get_organization);
                    var get_smtp_email = Task.Run(() =>
                    {
                        smtp_email = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                        {
                            Secret_Id = ConfigurationManager.AppSettings["SMTP_EMAIL"]
                        }).i_Result;
                    });
                    var get_smtp_password = Task.Run(() =>
                    {
                        smtp_password = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                        {
                            Secret_Id = ConfigurationManager.AppSettings["SMTP_PASSWORD"]
                        }).i_Result;
                    });
                    Task.WaitAll(get_smtp_email, get_smtp_password);
                    #endregion
                    #region Create & Send Email
                    #region Properties & Initialization
                    string logo_link;
                    if (isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY))
                    {
                        logo_link = oOrganization.LIGHT_RECTANGLE_LOGO_URL;
                    }
                    else
                    {
                        logo_link = oOrganization.DARK_RECTANGLE_LOGO_URL;
                    }
                    if (logo_link == null)
                    {
                        logo_link = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? oDefault_settings.LIGHT_RECTANGLE_LOGO_URL : oDefault_settings.DARK_SQUARE_LOGO_URL;
                    }
                    string email_title = $"{oList_setup.Where(setup => setup.SETUP_ID == i_Params_Send_Alerts_Email.Incident.Security_Incident.CATEGORY_SETUP_ID).First().VALUE} Alert";
                    string highlight_font_color = "#000000";
                    string company_name = oOrganization.ORGANIZATION_NAME + " DistrictNex";
                    string background_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY;
                    string border_bottom_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                    string fine_print_color = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? "white" : oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                    #endregion
                    #region Get HTML Template
                    string body = string.Empty;
                    using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["ALERTS_TEMPLATE"]))
                    {
                        body = reader.ReadToEnd();
                    }
                    #endregion
                    #region Insert Data
                    body = body.Replace("{LogoLink}", logo_link);
                    body = body.Replace("{SmallTitle}", email_title);
                    body = body.Replace("{FinePrintColor}", fine_print_color);
                    body = body.Replace("{BackgroundColor}", background_color);
                    body = body.Replace("{BottomBorderColor}", border_bottom_color);
                    body = body.Replace("{HighlightFontColor}", highlight_font_color);
                    body = body.Replace("{EventName}", oList_setup.Where(setup => setup.SETUP_ID == i_Params_Send_Alerts_Email.Incident.Security_Incident.CATEGORY_SETUP_ID).First().VALUE);
                    string setup_value = oList_setup.Where(setup => setup.SETUP_ID == i_Params_Send_Alerts_Email.Incident.Security_Incident.CATEGORY_SETUP_ID).First().VALUE;
                    if (setup_value == "Blacklisted Person")
                    {
                        body = body.Replace("{Seperator}", " -");
                        body = body.Replace("{ObjectName}", i_Params_Send_Alerts_Email.Incident.BLACKLISTED_PERSON_NAME);
                    }
                    else if (setup_value == "Blacklisted Plate")
                    {
                        body = body.Replace("{Seperator}", " -");
                        body = body.Replace("{ObjectName}", i_Params_Send_Alerts_Email.Incident.BLACKLISTED_LICENSE_PLATE);
                    }
                    else
                    {
                        body = body.Replace("{Seperator}", "");
                        body = body.Replace("{ObjectName}", "");
                    }
                    body = body.Replace("{CameraName}", i_Params_Send_Alerts_Email.Scene.Camera?.Name ?? "-");
                    body = body.Replace("{EventDateTime}", i_Params_Send_Alerts_Email.Scene.Datetime.DateTime.ToString("dd-MM-yyyy HH:mm:ss"));
                    body = body.Replace("{EventImageURL}", i_Params_Send_Alerts_Email.Scene.File);
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
                            Body = body,
                            IsBodyHtml = true,
                            Priority = MailPriority.Normal,
                            Subject = $"{company_name} Alert",
                            BodyEncoding = System.Text.Encoding.UTF8,
                            SubjectEncoding = System.Text.Encoding.UTF8,
                            From = new MailAddress(smtp_email, company_name),
                            DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                        };
                        #region Recipients
                        message.To.Add(i_Params_Send_Alerts_Email.TO_EMAIL);
                        #endregion
                        try
                        {
                            client.Send(message);
                        }
                        catch (Exception)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0030)); // An Error has Occured! Contact Support.
                        }
                    }
                    #endregion
                    #endregion
                });
                return true;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
    }
}
