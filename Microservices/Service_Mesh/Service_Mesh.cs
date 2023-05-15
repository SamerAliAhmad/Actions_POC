using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace Service_Mesh
{
    public partial class Proxy
    {
        public string Ticket { get; set; }
        public string BaseURL { get; set; }
        public string Stack_Trace { get; set; }
        public string Exception_Message { get; set; }

        private async Task<T> Call_WebApi<T>(string i_MethodName, bool Is_Ticket_In_Header, string HttpVerb, string i_Params = "")
        {
            string url = string.Empty;
            T oReturn_Value = default(T);
            this.BaseURL = this.BaseURL.TrimEnd('/');

            HttpClient oHttpClient = new HttpClient();
            oHttpClient.BaseAddress = new Uri(this.BaseURL);
            oHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (Is_Ticket_In_Header)
            {
                oHttpClient.DefaultRequestHeaders.Add("Ticket", this.Ticket);
                if (HttpVerb == "GET" || HttpVerb == "DELETE")
                {
                    url = $"{this.BaseURL}{i_MethodName}{i_Params}";
                }
                else
                {
                    url = $"{this.BaseURL}{i_MethodName}";
                }
            }
            else
            {
                if (HttpVerb == "GET")
                {
                    i_Params = i_Params.Length > 0 ? $"&{i_Params}" : i_Params;
                    url = $"{this.BaseURL}{i_MethodName}?Ticket={this.Ticket}{i_Params}";
                }
                else if (HttpVerb == "DELETE")
                {
                    url = $"{this.BaseURL}{i_MethodName}{i_Params}?Ticket={this.Ticket}";
                }
                else
                {
                    url = $"{this.BaseURL}{i_MethodName}?Ticket={this.Ticket}";
                }
            }

            StringContent oParams = new StringContent(i_Params, Encoding.UTF8, "application/json");
            HttpResponseMessage response = new HttpResponseMessage();

            switch (HttpVerb)
            {
                case "DELETE":
                    response = await oHttpClient.DeleteAsync(url);
                    break;
                case "GET":
                    response = await oHttpClient.GetAsync(url);
                    break;
                case "PATCH":
                    response = await oHttpClient.PatchAsync(url, (HttpContent)oParams);
                    break;
                case "POST":
                    response = await oHttpClient.PostAsync(url, (HttpContent)oParams);
                    break;
                case "PUT":
                    response = await oHttpClient.PutAsync(url, (HttpContent)oParams);
                    break;
            }
            string responseBody = string.Empty;

            int successCodeValue = (int)response.StatusCode;
            if (successCodeValue >= 200 && successCodeValue <= 299)
            {
                responseBody = await response.Content.ReadAsStringAsync();
                oReturn_Value = JsonConvert.DeserializeObject<T>(responseBody);
                responseBody = null;

                this.Stack_Trace = typeof(T).GetProperty("Stack_Trace").GetValue(oReturn_Value).ToString();
                this.Exception_Message = typeof(T).GetProperty("Exception_Message").GetValue(oReturn_Value).ToString();
                if (this.Exception_Message != "")
                {
                    throw new Exception(this.Exception_Message);
                }
                return oReturn_Value;
            }
            throw new Exception("Error Processing Your Request! Please Try Again!");
        }
        public Result_Get_Asset_By_ASSET_ID_List Get_Asset_By_ASSET_ID_List(Params_Get_Asset_By_ASSET_ID_List i_Params_Get_Asset_By_ASSET_ID_List)
        {
            return Get_Asset_By_ASSET_ID_List_Async(i_Params_Get_Asset_By_ASSET_ID_List).Result;
        }
        public async Task<Result_Get_Asset_By_ASSET_ID_List> Get_Asset_By_ASSET_ID_List_Async(Params_Get_Asset_By_ASSET_ID_List i_Params_Get_Asset_By_ASSET_ID_List)
        {
            return await Call_WebApi<Result_Get_Asset_By_ASSET_ID_List>("/Api/AssetManagement/Get_Asset_By_ASSET_ID_List", true, "GET", $"?ASSET_ID_LIST={(i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST))}");
        }
        public Result_Edit_Asset Edit_Asset(Asset i_Asset)
        {
            return Edit_Asset_Async(i_Asset).Result;
        }
        public async Task<Result_Edit_Asset> Edit_Asset_Async(Asset i_Asset)
        {
            return await Call_WebApi<Result_Edit_Asset>("/Api/AssetManagement/Edit_Asset", true, "POST", JsonConvert.SerializeObject(i_Asset));
        }
        public Result_Get_Asset_By_OWNER_ID Get_Asset_By_OWNER_ID(Params_Get_Asset_By_OWNER_ID i_Params_Get_Asset_By_OWNER_ID)
        {
            return Get_Asset_By_OWNER_ID_Async(i_Params_Get_Asset_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Asset_By_OWNER_ID> Get_Asset_By_OWNER_ID_Async(Params_Get_Asset_By_OWNER_ID i_Params_Get_Asset_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Asset_By_OWNER_ID>("/Api/AssetManagement/Get_Asset_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Asset_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Asset_By_ASSET_ID_Adv Get_Asset_By_ASSET_ID_Adv(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID)
        {
            return Get_Asset_By_ASSET_ID_Adv_Async(i_Params_Get_Asset_By_ASSET_ID).Result;
        }
        public async Task<Result_Get_Asset_By_ASSET_ID_Adv> Get_Asset_By_ASSET_ID_Adv_Async(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID)
        {
            return await Call_WebApi<Result_Get_Asset_By_ASSET_ID_Adv>("/Api/AssetManagement/Get_Asset_By_ASSET_ID_Adv", true, "GET", $"?ASSET_ID={i_Params_Get_Asset_By_ASSET_ID.ASSET_ID}");
        }
        public Result_Get_Asset_Data_List Get_Asset_Data_List(Params_Get_Asset_Data_List i_Params_Get_Asset_Data_List)
        {
            return Get_Asset_Data_List_Async(i_Params_Get_Asset_Data_List).Result;
        }
        public async Task<Result_Get_Asset_Data_List> Get_Asset_Data_List_Async(Params_Get_Asset_Data_List i_Params_Get_Asset_Data_List)
        {
            return await Call_WebApi<Result_Get_Asset_Data_List>("/Api/AssetManagement/Get_Asset_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Asset_Data_List));
        }
        public Result_Delete_Asset Delete_Asset(Params_Delete_Asset i_Params_Delete_Asset)
        {
            return Delete_Asset_Async(i_Params_Delete_Asset).Result;
        }
        public async Task<Result_Delete_Asset> Delete_Asset_Async(Params_Delete_Asset i_Params_Delete_Asset)
        {
            return await Call_WebApi<Result_Delete_Asset>("/Api/AssetManagement/Delete_Asset", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Asset));
        }
        public Result_Get_Data_source_By_OWNER_ID Get_Data_source_By_OWNER_ID(Params_Get_Data_source_By_OWNER_ID i_Params_Get_Data_source_By_OWNER_ID)
        {
            return Get_Data_source_By_OWNER_ID_Async(i_Params_Get_Data_source_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Data_source_By_OWNER_ID> Get_Data_source_By_OWNER_ID_Async(Params_Get_Data_source_By_OWNER_ID i_Params_Get_Data_source_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Data_source_By_OWNER_ID>("/Api/KPIExtractionEngine/Get_Data_source_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Data_source_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Generate_Area_Dwell_Time Generate_Area_Dwell_Time(Params_Generate_Area_Dwell_Time i_Params_Generate_Area_Dwell_Time)
        {
            return Generate_Area_Dwell_Time_Async(i_Params_Generate_Area_Dwell_Time).Result;
        }
        public async Task<Result_Generate_Area_Dwell_Time> Generate_Area_Dwell_Time_Async(Params_Generate_Area_Dwell_Time i_Params_Generate_Area_Dwell_Time)
        {
            return await Call_WebApi<Result_Generate_Area_Dwell_Time>("/Api/KPIExtractionEngine/Generate_Area_Dwell_Time", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Area_Dwell_Time));
        }
        public Result_Edit_Job_List Edit_Job_List(Params_Edit_Job_List i_Params_Edit_Job_List)
        {
            return Edit_Job_List_Async(i_Params_Edit_Job_List).Result;
        }
        public async Task<Result_Edit_Job_List> Edit_Job_List_Async(Params_Edit_Job_List i_Params_Edit_Job_List)
        {
            return await Call_WebApi<Result_Edit_Job_List>("/Api/KPIExtractionEngine/Edit_Job_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Job_List));
        }
        public Result_Generate_District_Dwell_Time Generate_District_Dwell_Time(Params_Generate_District_Dwell_Time i_Params_Generate_District_Dwell_Time)
        {
            return Generate_District_Dwell_Time_Async(i_Params_Generate_District_Dwell_Time).Result;
        }
        public async Task<Result_Generate_District_Dwell_Time> Generate_District_Dwell_Time_Async(Params_Generate_District_Dwell_Time i_Params_Generate_District_Dwell_Time)
        {
            return await Call_WebApi<Result_Generate_District_Dwell_Time>("/Api/KPIExtractionEngine/Generate_District_Dwell_Time", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_District_Dwell_Time));
        }
        public Result_Get_Visitor_Data Get_Visitor_Data(Params_Get_Visitor_Data i_Params_Get_Visitor_Data)
        {
            return Get_Visitor_Data_Async(i_Params_Get_Visitor_Data).Result;
        }
        public async Task<Result_Get_Visitor_Data> Get_Visitor_Data_Async(Params_Get_Visitor_Data i_Params_Get_Visitor_Data)
        {
            return await Call_WebApi<Result_Get_Visitor_Data>("/Api/KPIExtractionEngine/Get_Visitor_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Visitor_Data));
        }
        public Result_Edit_Kpi_List Edit_Kpi_List(Params_Edit_Kpi_List i_Params_Edit_Kpi_List)
        {
            return Edit_Kpi_List_Async(i_Params_Edit_Kpi_List).Result;
        }
        public async Task<Result_Edit_Kpi_List> Edit_Kpi_List_Async(Params_Edit_Kpi_List i_Params_Edit_Kpi_List)
        {
            return await Call_WebApi<Result_Edit_Kpi_List>("/Api/KPIExtractionEngine/Edit_Kpi_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Kpi_List));
        }
        public Result_Insert_Entity_Kpi_Data_List Insert_Entity_Kpi_Data_List(Params_Insert_Entity_Kpi_Data_List i_Params_Insert_Entity_Kpi_Data_List)
        {
            return Insert_Entity_Kpi_Data_List_Async(i_Params_Insert_Entity_Kpi_Data_List).Result;
        }
        public async Task<Result_Insert_Entity_Kpi_Data_List> Insert_Entity_Kpi_Data_List_Async(Params_Insert_Entity_Kpi_Data_List i_Params_Insert_Entity_Kpi_Data_List)
        {
            return await Call_WebApi<Result_Insert_Entity_Kpi_Data_List>("/Api/KPIExtractionEngine/Insert_Entity_Kpi_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_Entity_Kpi_Data_List));
        }
        public Result_Delete_Data_source Delete_Data_source(Params_Delete_Data_source i_Params_Delete_Data_source)
        {
            return Delete_Data_source_Async(i_Params_Delete_Data_source).Result;
        }
        public async Task<Result_Delete_Data_source> Delete_Data_source_Async(Params_Delete_Data_source i_Params_Delete_Data_source)
        {
            return await Call_WebApi<Result_Delete_Data_source>("/Api/KPIExtractionEngine/Delete_Data_source", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Data_source));
        }
        public Result_Get_And_Fill_Bylaw_complaints_From_Api Get_And_Fill_Bylaw_complaints_From_Api(Params_Get_And_Fill_Bylaw_complaints_From_Api i_Params_Get_And_Fill_Bylaw_complaints_From_Api)
        {
            return Get_And_Fill_Bylaw_complaints_From_Api_Async(i_Params_Get_And_Fill_Bylaw_complaints_From_Api).Result;
        }
        public async Task<Result_Get_And_Fill_Bylaw_complaints_From_Api> Get_And_Fill_Bylaw_complaints_From_Api_Async(Params_Get_And_Fill_Bylaw_complaints_From_Api i_Params_Get_And_Fill_Bylaw_complaints_From_Api)
        {
            return await Call_WebApi<Result_Get_And_Fill_Bylaw_complaints_From_Api>("/Api/KPIExtractionEngine/Get_And_Fill_Bylaw_complaints_From_Api", true, "POST", JsonConvert.SerializeObject(i_Params_Get_And_Fill_Bylaw_complaints_From_Api));
        }
        public Result_Generate_Or_Compute_District_Hourly_Data Generate_Or_Compute_District_Hourly_Data(Params_Generate_Or_Compute_District_Hourly_Data i_Params_Generate_Or_Compute_District_Hourly_Data)
        {
            return Generate_Or_Compute_District_Hourly_Data_Async(i_Params_Generate_Or_Compute_District_Hourly_Data).Result;
        }
        public async Task<Result_Generate_Or_Compute_District_Hourly_Data> Generate_Or_Compute_District_Hourly_Data_Async(Params_Generate_Or_Compute_District_Hourly_Data i_Params_Generate_Or_Compute_District_Hourly_Data)
        {
            return await Call_WebApi<Result_Generate_Or_Compute_District_Hourly_Data>("/Api/KPIExtractionEngine/Generate_Or_Compute_District_Hourly_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Or_Compute_District_Hourly_Data));
        }
        public Result_Generate_Or_Compute_Area_Hourly_Data Generate_Or_Compute_Area_Hourly_Data(Params_Generate_Or_Compute_Area_Hourly_Data i_Params_Generate_Or_Compute_Area_Hourly_Data)
        {
            return Generate_Or_Compute_Area_Hourly_Data_Async(i_Params_Generate_Or_Compute_Area_Hourly_Data).Result;
        }
        public async Task<Result_Generate_Or_Compute_Area_Hourly_Data> Generate_Or_Compute_Area_Hourly_Data_Async(Params_Generate_Or_Compute_Area_Hourly_Data i_Params_Generate_Or_Compute_Area_Hourly_Data)
        {
            return await Call_WebApi<Result_Generate_Or_Compute_Area_Hourly_Data>("/Api/KPIExtractionEngine/Generate_Or_Compute_Area_Hourly_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Or_Compute_Area_Hourly_Data));
        }
        public Result_Generate_Or_Compute_Site_Hourly_Data Generate_Or_Compute_Site_Hourly_Data(Params_Generate_Or_Compute_Site_Hourly_Data i_Params_Generate_Or_Compute_Site_Hourly_Data)
        {
            return Generate_Or_Compute_Site_Hourly_Data_Async(i_Params_Generate_Or_Compute_Site_Hourly_Data).Result;
        }
        public async Task<Result_Generate_Or_Compute_Site_Hourly_Data> Generate_Or_Compute_Site_Hourly_Data_Async(Params_Generate_Or_Compute_Site_Hourly_Data i_Params_Generate_Or_Compute_Site_Hourly_Data)
        {
            return await Call_WebApi<Result_Generate_Or_Compute_Site_Hourly_Data>("/Api/KPIExtractionEngine/Generate_Or_Compute_Site_Hourly_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Or_Compute_Site_Hourly_Data));
        }
        public Result_Extract_Kpi_Data_From_CSV Extract_Kpi_Data_From_CSV(Params_Extract_Kpi_Data_From_CSV i_Params_Extract_Kpi_Data_From_CSV)
        {
            return Extract_Kpi_Data_From_CSV_Async(i_Params_Extract_Kpi_Data_From_CSV).Result;
        }
        public async Task<Result_Extract_Kpi_Data_From_CSV> Extract_Kpi_Data_From_CSV_Async(Params_Extract_Kpi_Data_From_CSV i_Params_Extract_Kpi_Data_From_CSV)
        {
            return await Call_WebApi<Result_Extract_Kpi_Data_From_CSV>("/Api/KPIExtractionEngine/Extract_Kpi_Data_From_CSV", true, "POST", JsonConvert.SerializeObject(i_Params_Extract_Kpi_Data_From_CSV));
        }
        public Result_Generate_Area_Demographic_Data Generate_Area_Demographic_Data(Params_Generate_Area_Demographic_Data i_Params_Generate_Area_Demographic_Data)
        {
            return Generate_Area_Demographic_Data_Async(i_Params_Generate_Area_Demographic_Data).Result;
        }
        public async Task<Result_Generate_Area_Demographic_Data> Generate_Area_Demographic_Data_Async(Params_Generate_Area_Demographic_Data i_Params_Generate_Area_Demographic_Data)
        {
            return await Call_WebApi<Result_Generate_Area_Demographic_Data>("/Api/KPIExtractionEngine/Generate_Area_Demographic_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Area_Demographic_Data));
        }
        public Result_Get_Jobs_By_Where Get_Jobs_By_Where(Params_Get_Jobs_By_Where i_Params_Get_Jobs_By_Where)
        {
            return Get_Jobs_By_Where_Async(i_Params_Get_Jobs_By_Where).Result;
        }
        public async Task<Result_Get_Jobs_By_Where> Get_Jobs_By_Where_Async(Params_Get_Jobs_By_Where i_Params_Get_Jobs_By_Where)
        {
            return await Call_WebApi<Result_Get_Jobs_By_Where>("/Api/KPIExtractionEngine/Get_Jobs_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Jobs_By_Where));
        }
        public Result_Generate_Or_Compute_Floor_Hourly_Data Generate_Or_Compute_Floor_Hourly_Data(Params_Generate_Or_Compute_Floor_Hourly_Data i_Params_Generate_Or_Compute_Floor_Hourly_Data)
        {
            return Generate_Or_Compute_Floor_Hourly_Data_Async(i_Params_Generate_Or_Compute_Floor_Hourly_Data).Result;
        }
        public async Task<Result_Generate_Or_Compute_Floor_Hourly_Data> Generate_Or_Compute_Floor_Hourly_Data_Async(Params_Generate_Or_Compute_Floor_Hourly_Data i_Params_Generate_Or_Compute_Floor_Hourly_Data)
        {
            return await Call_WebApi<Result_Generate_Or_Compute_Floor_Hourly_Data>("/Api/KPIExtractionEngine/Generate_Or_Compute_Floor_Hourly_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Or_Compute_Floor_Hourly_Data));
        }
        public Result_Delete_Space_Kpi_Data_By_Where Delete_Space_Kpi_Data_By_Where(Params_Delete_Space_Kpi_Data_By_Where i_Params_Delete_Space_Kpi_Data_By_Where)
        {
            return Delete_Space_Kpi_Data_By_Where_Async(i_Params_Delete_Space_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Delete_Space_Kpi_Data_By_Where> Delete_Space_Kpi_Data_By_Where_Async(Params_Delete_Space_Kpi_Data_By_Where i_Params_Delete_Space_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Delete_Space_Kpi_Data_By_Where>("/Api/KPIExtractionEngine/Delete_Space_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Space_Kpi_Data_By_Where));
        }
        public Result_Generate_Site_Visitor_Data_And_Dwell_Time Generate_Site_Visitor_Data_And_Dwell_Time(Params_Generate_Site_Visitor_Data_And_Dwell_Time i_Params_Generate_Site_Visitor_Data_And_Dwell_Time)
        {
            return Generate_Site_Visitor_Data_And_Dwell_Time_Async(i_Params_Generate_Site_Visitor_Data_And_Dwell_Time).Result;
        }
        public async Task<Result_Generate_Site_Visitor_Data_And_Dwell_Time> Generate_Site_Visitor_Data_And_Dwell_Time_Async(Params_Generate_Site_Visitor_Data_And_Dwell_Time i_Params_Generate_Site_Visitor_Data_And_Dwell_Time)
        {
            return await Call_WebApi<Result_Generate_Site_Visitor_Data_And_Dwell_Time>("/Api/KPIExtractionEngine/Generate_Site_Visitor_Data_And_Dwell_Time", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Site_Visitor_Data_And_Dwell_Time));
        }
        public Result_Edit_Niche_categories_List Edit_Niche_categories_List(Params_Edit_Niche_categories_List i_Params_Edit_Niche_categories_List)
        {
            return Edit_Niche_categories_List_Async(i_Params_Edit_Niche_categories_List).Result;
        }
        public async Task<Result_Edit_Niche_categories_List> Edit_Niche_categories_List_Async(Params_Edit_Niche_categories_List i_Params_Edit_Niche_categories_List)
        {
            return await Call_WebApi<Result_Edit_Niche_categories_List>("/Api/KPIExtractionEngine/Edit_Niche_categories_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Niche_categories_List));
        }
        public Result_Delete_Niche_categories Delete_Niche_categories(Params_Delete_Niche_categories i_Params_Delete_Niche_categories)
        {
            return Delete_Niche_categories_Async(i_Params_Delete_Niche_categories).Result;
        }
        public async Task<Result_Delete_Niche_categories> Delete_Niche_categories_Async(Params_Delete_Niche_categories i_Params_Delete_Niche_categories)
        {
            return await Call_WebApi<Result_Delete_Niche_categories>("/Api/KPIExtractionEngine/Delete_Niche_categories", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Niche_categories));
        }
        public Result_Delete_Site_Kpi_Data_By_Where Delete_Site_Kpi_Data_By_Where(Params_Delete_Site_Kpi_Data_By_Where i_Params_Delete_Site_Kpi_Data_By_Where)
        {
            return Delete_Site_Kpi_Data_By_Where_Async(i_Params_Delete_Site_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Delete_Site_Kpi_Data_By_Where> Delete_Site_Kpi_Data_By_Where_Async(Params_Delete_Site_Kpi_Data_By_Where i_Params_Delete_Site_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Delete_Site_Kpi_Data_By_Where>("/Api/KPIExtractionEngine/Delete_Site_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Site_Kpi_Data_By_Where));
        }
        public Result_Insert_Space_Kpi_Data_List Insert_Space_Kpi_Data_List(Params_Insert_Space_Kpi_Data_List i_Params_Insert_Space_Kpi_Data_List)
        {
            return Insert_Space_Kpi_Data_List_Async(i_Params_Insert_Space_Kpi_Data_List).Result;
        }
        public async Task<Result_Insert_Space_Kpi_Data_List> Insert_Space_Kpi_Data_List_Async(Params_Insert_Space_Kpi_Data_List i_Params_Insert_Space_Kpi_Data_List)
        {
            return await Call_WebApi<Result_Insert_Space_Kpi_Data_List>("/Api/KPIExtractionEngine/Insert_Space_Kpi_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_Space_Kpi_Data_List));
        }
        public Result_Generate_Site_Demographic_Data Generate_Site_Demographic_Data(Params_Generate_Site_Demographic_Data i_Params_Generate_Site_Demographic_Data)
        {
            return Generate_Site_Demographic_Data_Async(i_Params_Generate_Site_Demographic_Data).Result;
        }
        public async Task<Result_Generate_Site_Demographic_Data> Generate_Site_Demographic_Data_Async(Params_Generate_Site_Demographic_Data i_Params_Generate_Site_Demographic_Data)
        {
            return await Call_WebApi<Result_Generate_Site_Demographic_Data>("/Api/KPIExtractionEngine/Generate_Site_Demographic_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Site_Demographic_Data));
        }
        public Result_Insert_Site_Kpi_Data_List Insert_Site_Kpi_Data_List(Params_Insert_Site_Kpi_Data_List i_Params_Insert_Site_Kpi_Data_List)
        {
            return Insert_Site_Kpi_Data_List_Async(i_Params_Insert_Site_Kpi_Data_List).Result;
        }
        public async Task<Result_Insert_Site_Kpi_Data_List> Insert_Site_Kpi_Data_List_Async(Params_Insert_Site_Kpi_Data_List i_Params_Insert_Site_Kpi_Data_List)
        {
            return await Call_WebApi<Result_Insert_Site_Kpi_Data_List>("/Api/KPIExtractionEngine/Insert_Site_Kpi_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_Site_Kpi_Data_List));
        }
        public Result_Edit_Data_source Edit_Data_source(Data_source i_Data_source)
        {
            return Edit_Data_source_Async(i_Data_source).Result;
        }
        public async Task<Result_Edit_Data_source> Edit_Data_source_Async(Data_source i_Data_source)
        {
            return await Call_WebApi<Result_Edit_Data_source>("/Api/KPIExtractionEngine/Edit_Data_source", true, "POST", JsonConvert.SerializeObject(i_Data_source));
        }
        public Result_Delete_Entity_Kpi_Data_By_Where Delete_Entity_Kpi_Data_By_Where(Params_Delete_Entity_Kpi_Data_By_Where i_Params_Delete_Entity_Kpi_Data_By_Where)
        {
            return Delete_Entity_Kpi_Data_By_Where_Async(i_Params_Delete_Entity_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Delete_Entity_Kpi_Data_By_Where> Delete_Entity_Kpi_Data_By_Where_Async(Params_Delete_Entity_Kpi_Data_By_Where i_Params_Delete_Entity_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Delete_Entity_Kpi_Data_By_Where>("/Api/KPIExtractionEngine/Delete_Entity_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Entity_Kpi_Data_By_Where));
        }
        public Result_Get_Demographic_Data Get_Demographic_Data(Params_Get_Demographic_Data i_Params_Get_Demographic_Data)
        {
            return Get_Demographic_Data_Async(i_Params_Get_Demographic_Data).Result;
        }
        public async Task<Result_Get_Demographic_Data> Get_Demographic_Data_Async(Params_Get_Demographic_Data i_Params_Get_Demographic_Data)
        {
            return await Call_WebApi<Result_Get_Demographic_Data>("/Api/KPIExtractionEngine/Get_Demographic_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Demographic_Data));
        }
        public Result_Generate_District_Hourly_Indexes Generate_District_Hourly_Indexes(Params_Generate_District_Hourly_Indexes i_Params_Generate_District_Hourly_Indexes)
        {
            return Generate_District_Hourly_Indexes_Async(i_Params_Generate_District_Hourly_Indexes).Result;
        }
        public async Task<Result_Generate_District_Hourly_Indexes> Generate_District_Hourly_Indexes_Async(Params_Generate_District_Hourly_Indexes i_Params_Generate_District_Hourly_Indexes)
        {
            return await Call_WebApi<Result_Generate_District_Hourly_Indexes>("/Api/KPIExtractionEngine/Generate_District_Hourly_Indexes", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_District_Hourly_Indexes));
        }
        public Result_Get_Niche_categories_By_Where Get_Niche_categories_By_Where(Params_Get_Niche_categories_By_Where i_Params_Get_Niche_categories_By_Where)
        {
            return Get_Niche_categories_By_Where_Async(i_Params_Get_Niche_categories_By_Where).Result;
        }
        public async Task<Result_Get_Niche_categories_By_Where> Get_Niche_categories_By_Where_Async(Params_Get_Niche_categories_By_Where i_Params_Get_Niche_categories_By_Where)
        {
            return await Call_WebApi<Result_Get_Niche_categories_By_Where>("/Api/KPIExtractionEngine/Get_Niche_categories_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Niche_categories_By_Where));
        }
        public Result_Delete_Area_Kpi_Data_By_Where Delete_Area_Kpi_Data_By_Where(Delete_Area_Kpi_Data_By_Where i_Delete_Area_Kpi_Data_By_Where)
        {
            return Delete_Area_Kpi_Data_By_Where_Async(i_Delete_Area_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Delete_Area_Kpi_Data_By_Where> Delete_Area_Kpi_Data_By_Where_Async(Delete_Area_Kpi_Data_By_Where i_Delete_Area_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Delete_Area_Kpi_Data_By_Where>("/Api/KPIExtractionEngine/Delete_Area_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Delete_Area_Kpi_Data_By_Where));
        }
        public Result_Generate_Entity_Hourly_Indexes Generate_Entity_Hourly_Indexes(Params_Generate_Entity_Hourly_Indexes i_Params_Generate_Entity_Hourly_Indexes)
        {
            return Generate_Entity_Hourly_Indexes_Async(i_Params_Generate_Entity_Hourly_Indexes).Result;
        }
        public async Task<Result_Generate_Entity_Hourly_Indexes> Generate_Entity_Hourly_Indexes_Async(Params_Generate_Entity_Hourly_Indexes i_Params_Generate_Entity_Hourly_Indexes)
        {
            return await Call_WebApi<Result_Generate_Entity_Hourly_Indexes>("/Api/KPIExtractionEngine/Generate_Entity_Hourly_Indexes", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Entity_Hourly_Indexes));
        }
        public Result_Generate_Worker_Data Generate_Worker_Data(Params_Generate_Worker_Data i_Params_Generate_Worker_Data)
        {
            return Generate_Worker_Data_Async(i_Params_Generate_Worker_Data).Result;
        }
        public async Task<Result_Generate_Worker_Data> Generate_Worker_Data_Async(Params_Generate_Worker_Data i_Params_Generate_Worker_Data)
        {
            return await Call_WebApi<Result_Generate_Worker_Data>("/Api/KPIExtractionEngine/Generate_Worker_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Worker_Data));
        }
        public Result_Delete_District_Kpi_Data_By_Where Delete_District_Kpi_Data_By_Where(Params_Delete_District_Kpi_Data_By_Where i_Params_Delete_District_Kpi_Data_By_Where)
        {
            return Delete_District_Kpi_Data_By_Where_Async(i_Params_Delete_District_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Delete_District_Kpi_Data_By_Where> Delete_District_Kpi_Data_By_Where_Async(Params_Delete_District_Kpi_Data_By_Where i_Params_Delete_District_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Delete_District_Kpi_Data_By_Where>("/Api/KPIExtractionEngine/Delete_District_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_District_Kpi_Data_By_Where));
        }
        public Result_Edit_Organization_data_source_kpi Edit_Organization_data_source_kpi(Organization_data_source_kpi i_Organization_data_source_kpi)
        {
            return Edit_Organization_data_source_kpi_Async(i_Organization_data_source_kpi).Result;
        }
        public async Task<Result_Edit_Organization_data_source_kpi> Edit_Organization_data_source_kpi_Async(Organization_data_source_kpi i_Organization_data_source_kpi)
        {
            return await Call_WebApi<Result_Edit_Organization_data_source_kpi>("/Api/KPIExtractionEngine/Edit_Organization_data_source_kpi", true, "POST", JsonConvert.SerializeObject(i_Organization_data_source_kpi));
        }
        public Result_Get_Telus_Auth_Token Get_Telus_Auth_Token()
        {
            return Get_Telus_Auth_Token_Async().Result;
        }
        public async Task<Result_Get_Telus_Auth_Token> Get_Telus_Auth_Token_Async()
        {
            return await Call_WebApi<Result_Get_Telus_Auth_Token>("/Api/KPIExtractionEngine/Get_Telus_Auth_Token", true, "POST");
        }
        public Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv Get_Organization_data_source_kpi_By_OWNER_ID_Adv(Params_Get_Organization_data_source_kpi_By_OWNER_ID i_Params_Get_Organization_data_source_kpi_By_OWNER_ID)
        {
            return Get_Organization_data_source_kpi_By_OWNER_ID_Adv_Async(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv> Get_Organization_data_source_kpi_By_OWNER_ID_Adv_Async(Params_Get_Organization_data_source_kpi_By_OWNER_ID i_Params_Get_Organization_data_source_kpi_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv>("/Api/KPIExtractionEngine/Get_Organization_data_source_kpi_By_OWNER_ID_Adv", true, "GET", $"?OWNER_ID={i_Params_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Delete_Floor_Kpi_Data_By_Where Delete_Floor_Kpi_Data_By_Where(Params_Delete_Floor_Kpi_Data_By_Where i_Params_Delete_Floor_Kpi_Data_By_Where)
        {
            return Delete_Floor_Kpi_Data_By_Where_Async(i_Params_Delete_Floor_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Delete_Floor_Kpi_Data_By_Where> Delete_Floor_Kpi_Data_By_Where_Async(Params_Delete_Floor_Kpi_Data_By_Where i_Params_Delete_Floor_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Delete_Floor_Kpi_Data_By_Where>("/Api/KPIExtractionEngine/Delete_Floor_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Floor_Kpi_Data_By_Where));
        }
        public Result_Insert_Area_Kpi_Data_List Insert_Area_Kpi_Data_List(Params_Insert_Area_Kpi_Data_List i_Params_Insert_Area_Kpi_Data_List)
        {
            return Insert_Area_Kpi_Data_List_Async(i_Params_Insert_Area_Kpi_Data_List).Result;
        }
        public async Task<Result_Insert_Area_Kpi_Data_List> Insert_Area_Kpi_Data_List_Async(Params_Insert_Area_Kpi_Data_List i_Params_Insert_Area_Kpi_Data_List)
        {
            return await Call_WebApi<Result_Insert_Area_Kpi_Data_List>("/Api/KPIExtractionEngine/Insert_Area_Kpi_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_Area_Kpi_Data_List));
        }
        public Result_Generate_Space_Hourly_Indexes Generate_Space_Hourly_Indexes(Params_Generate_Space_Hourly_Indexes i_Params_Generate_Space_Hourly_Indexes)
        {
            return Generate_Space_Hourly_Indexes_Async(i_Params_Generate_Space_Hourly_Indexes).Result;
        }
        public async Task<Result_Generate_Space_Hourly_Indexes> Generate_Space_Hourly_Indexes_Async(Params_Generate_Space_Hourly_Indexes i_Params_Generate_Space_Hourly_Indexes)
        {
            return await Call_WebApi<Result_Generate_Space_Hourly_Indexes>("/Api/KPIExtractionEngine/Generate_Space_Hourly_Indexes", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Space_Hourly_Indexes));
        }
        public Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            return Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Async(i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List).Result;
        }
        public async Task<Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List> Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Async(Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            return await Call_WebApi<Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List>("/Api/KPIExtractionEngine/Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List));
        }
        public Result_Generate_Business_Count_And_Vacant_Business_Count Generate_Business_Count_And_Vacant_Business_Count(Params_Generate_Business_Count_And_Vacant_Business_Count i_Params_Generate_Business_Count_And_Vacant_Business_Count)
        {
            return Generate_Business_Count_And_Vacant_Business_Count_Async(i_Params_Generate_Business_Count_And_Vacant_Business_Count).Result;
        }
        public async Task<Result_Generate_Business_Count_And_Vacant_Business_Count> Generate_Business_Count_And_Vacant_Business_Count_Async(Params_Generate_Business_Count_And_Vacant_Business_Count i_Params_Generate_Business_Count_And_Vacant_Business_Count)
        {
            return await Call_WebApi<Result_Generate_Business_Count_And_Vacant_Business_Count>("/Api/KPIExtractionEngine/Generate_Business_Count_And_Vacant_Business_Count", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Business_Count_And_Vacant_Business_Count));
        }
        public Result_Insert_District_Kpi_Data_List Insert_District_Kpi_Data_List(Params_Insert_District_Kpi_Data_List i_Params_Insert_District_Kpi_Data_List)
        {
            return Insert_District_Kpi_Data_List_Async(i_Params_Insert_District_Kpi_Data_List).Result;
        }
        public async Task<Result_Insert_District_Kpi_Data_List> Insert_District_Kpi_Data_List_Async(Params_Insert_District_Kpi_Data_List i_Params_Insert_District_Kpi_Data_List)
        {
            return await Call_WebApi<Result_Insert_District_Kpi_Data_List>("/Api/KPIExtractionEngine/Insert_District_Kpi_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_District_Kpi_Data_List));
        }
        public Result_Delete_Organization_data_source_kpi Delete_Organization_data_source_kpi(Params_Delete_Organization_data_source_kpi i_Params_Delete_Organization_data_source_kpi)
        {
            return Delete_Organization_data_source_kpi_Async(i_Params_Delete_Organization_data_source_kpi).Result;
        }
        public async Task<Result_Delete_Organization_data_source_kpi> Delete_Organization_data_source_kpi_Async(Params_Delete_Organization_data_source_kpi i_Params_Delete_Organization_data_source_kpi)
        {
            return await Call_WebApi<Result_Delete_Organization_data_source_kpi>("/Api/KPIExtractionEngine/Delete_Organization_data_source_kpi", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi));
        }
        public Result_Generate_Site_Hourly_Indexes Generate_Site_Hourly_Indexes(Params_Generate_Site_Hourly_Indexes i_Params_Generate_Site_Hourly_Indexes)
        {
            return Generate_Site_Hourly_Indexes_Async(i_Params_Generate_Site_Hourly_Indexes).Result;
        }
        public async Task<Result_Generate_Site_Hourly_Indexes> Generate_Site_Hourly_Indexes_Async(Params_Generate_Site_Hourly_Indexes i_Params_Generate_Site_Hourly_Indexes)
        {
            return await Call_WebApi<Result_Generate_Site_Hourly_Indexes>("/Api/KPIExtractionEngine/Generate_Site_Hourly_Indexes", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Site_Hourly_Indexes));
        }
        public Result_Get_Visitor_Activity_Data Get_Visitor_Activity_Data(Params_Get_Visitor_Activity_Data i_Params_Get_Visitor_Activity_Data)
        {
            return Get_Visitor_Activity_Data_Async(i_Params_Get_Visitor_Activity_Data).Result;
        }
        public async Task<Result_Get_Visitor_Activity_Data> Get_Visitor_Activity_Data_Async(Params_Get_Visitor_Activity_Data i_Params_Get_Visitor_Activity_Data)
        {
            return await Call_WebApi<Result_Get_Visitor_Activity_Data>("/Api/KPIExtractionEngine/Get_Visitor_Activity_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Visitor_Activity_Data));
        }
        public Result_Get_And_Fill_Public_events_From_Api Get_And_Fill_Public_events_From_Api(Params_Get_And_Fill_Public_events_From_Api i_Params_Get_And_Fill_Public_events_From_Api)
        {
            return Get_And_Fill_Public_events_From_Api_Async(i_Params_Get_And_Fill_Public_events_From_Api).Result;
        }
        public async Task<Result_Get_And_Fill_Public_events_From_Api> Get_And_Fill_Public_events_From_Api_Async(Params_Get_And_Fill_Public_events_From_Api i_Params_Get_And_Fill_Public_events_From_Api)
        {
            return await Call_WebApi<Result_Get_And_Fill_Public_events_From_Api>("/Api/KPIExtractionEngine/Get_And_Fill_Public_events_From_Api", true, "POST", JsonConvert.SerializeObject(i_Params_Get_And_Fill_Public_events_From_Api));
        }
        public Result_Generate_Floor_Hourly_Indexes Generate_Floor_Hourly_Indexes(Params_Generate_Floor_Hourly_Indexes i_Params_Generate_Floor_Hourly_Indexes)
        {
            return Generate_Floor_Hourly_Indexes_Async(i_Params_Generate_Floor_Hourly_Indexes).Result;
        }
        public async Task<Result_Generate_Floor_Hourly_Indexes> Generate_Floor_Hourly_Indexes_Async(Params_Generate_Floor_Hourly_Indexes i_Params_Generate_Floor_Hourly_Indexes)
        {
            return await Call_WebApi<Result_Generate_Floor_Hourly_Indexes>("/Api/KPIExtractionEngine/Generate_Floor_Hourly_Indexes", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Floor_Hourly_Indexes));
        }
        public Result_Generate_Area_Hourly_Indexes Generate_Area_Hourly_Indexes(Params_Generate_Area_Hourly_Indexes i_Params_Generate_Area_Hourly_Indexes)
        {
            return Generate_Area_Hourly_Indexes_Async(i_Params_Generate_Area_Hourly_Indexes).Result;
        }
        public async Task<Result_Generate_Area_Hourly_Indexes> Generate_Area_Hourly_Indexes_Async(Params_Generate_Area_Hourly_Indexes i_Params_Generate_Area_Hourly_Indexes)
        {
            return await Call_WebApi<Result_Generate_Area_Hourly_Indexes>("/Api/KPIExtractionEngine/Generate_Area_Hourly_Indexes", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Area_Hourly_Indexes));
        }
        public Result_Generate_Or_Compute_Entity_Hourly_Data Generate_Or_Compute_Entity_Hourly_Data(Params_Generate_Or_Compute_Entity_Hourly_Data i_Params_Generate_Or_Compute_Entity_Hourly_Data)
        {
            return Generate_Or_Compute_Entity_Hourly_Data_Async(i_Params_Generate_Or_Compute_Entity_Hourly_Data).Result;
        }
        public async Task<Result_Generate_Or_Compute_Entity_Hourly_Data> Generate_Or_Compute_Entity_Hourly_Data_Async(Params_Generate_Or_Compute_Entity_Hourly_Data i_Params_Generate_Or_Compute_Entity_Hourly_Data)
        {
            return await Call_WebApi<Result_Generate_Or_Compute_Entity_Hourly_Data>("/Api/KPIExtractionEngine/Generate_Or_Compute_Entity_Hourly_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Or_Compute_Entity_Hourly_Data));
        }
        public Result_Delete_Job Delete_Job(Params_Delete_Job i_Params_Delete_Job)
        {
            return Delete_Job_Async(i_Params_Delete_Job).Result;
        }
        public async Task<Result_Delete_Job> Delete_Job_Async(Params_Delete_Job i_Params_Delete_Job)
        {
            return await Call_WebApi<Result_Delete_Job>("/Api/KPIExtractionEngine/Delete_Job", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Job));
        }
        public Result_Get_And_Fill_Businesses_From_Api Get_And_Fill_Businesses_From_Api()
        {
            return Get_And_Fill_Businesses_From_Api_Async().Result;
        }
        public async Task<Result_Get_And_Fill_Businesses_From_Api> Get_And_Fill_Businesses_From_Api_Async()
        {
            return await Call_WebApi<Result_Get_And_Fill_Businesses_From_Api>("/Api/KPIExtractionEngine/Get_And_Fill_Businesses_From_Api", true, "POST");
        }
        public Result_Generate_District_Demographic_Data Generate_District_Demographic_Data(Params_Generate_District_Demographic_Data i_Params_Generate_District_Demographic_Data)
        {
            return Generate_District_Demographic_Data_Async(i_Params_Generate_District_Demographic_Data).Result;
        }
        public async Task<Result_Generate_District_Demographic_Data> Generate_District_Demographic_Data_Async(Params_Generate_District_Demographic_Data i_Params_Generate_District_Demographic_Data)
        {
            return await Call_WebApi<Result_Generate_District_Demographic_Data>("/Api/KPIExtractionEngine/Generate_District_Demographic_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_District_Demographic_Data));
        }
        public Result_Insert_Floor_Kpi_Data_List Insert_Floor_Kpi_Data_List(Params_Insert_Floor_Kpi_Data_List i_Params_Insert_Floor_Kpi_Data_List)
        {
            return Insert_Floor_Kpi_Data_List_Async(i_Params_Insert_Floor_Kpi_Data_List).Result;
        }
        public async Task<Result_Insert_Floor_Kpi_Data_List> Insert_Floor_Kpi_Data_List_Async(Params_Insert_Floor_Kpi_Data_List i_Params_Insert_Floor_Kpi_Data_List)
        {
            return await Call_WebApi<Result_Insert_Floor_Kpi_Data_List>("/Api/KPIExtractionEngine/Insert_Floor_Kpi_Data_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_Floor_Kpi_Data_List));
        }
        public Result_Generate_Visitor_Activity_Data Generate_Visitor_Activity_Data(Params_Generate_Visitor_Activity_Data i_Params_Generate_Visitor_Activity_Data)
        {
            return Generate_Visitor_Activity_Data_Async(i_Params_Generate_Visitor_Activity_Data).Result;
        }
        public async Task<Result_Generate_Visitor_Activity_Data> Generate_Visitor_Activity_Data_Async(Params_Generate_Visitor_Activity_Data i_Params_Generate_Visitor_Activity_Data)
        {
            return await Call_WebApi<Result_Generate_Visitor_Activity_Data>("/Api/KPIExtractionEngine/Generate_Visitor_Activity_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Visitor_Activity_Data));
        }
        public Result_Get_Floor_By_ENTITY_ID_List Get_Floor_By_ENTITY_ID_List(Params_Get_Floor_By_ENTITY_ID_List i_Params_Get_Floor_By_ENTITY_ID_List)
        {
            return Get_Floor_By_ENTITY_ID_List_Async(i_Params_Get_Floor_By_ENTITY_ID_List).Result;
        }
        public async Task<Result_Get_Floor_By_ENTITY_ID_List> Get_Floor_By_ENTITY_ID_List_Async(Params_Get_Floor_By_ENTITY_ID_List i_Params_Get_Floor_By_ENTITY_ID_List)
        {
            return await Call_WebApi<Result_Get_Floor_By_ENTITY_ID_List>("/Api/KPIExtractionEngine/Get_Floor_By_ENTITY_ID_List", true, "GET", $"?ENTITY_ID_LIST={(i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST))}");
        }
        public Result_Edit_Entity_share_data Edit_Entity_share_data(Params_Edit_Entity_share_data i_Params_Edit_Entity_share_data)
        {
            return Edit_Entity_share_data_Async(i_Params_Edit_Entity_share_data).Result;
        }
        public async Task<Result_Edit_Entity_share_data> Edit_Entity_share_data_Async(Params_Edit_Entity_share_data i_Params_Edit_Entity_share_data)
        {
            return await Call_WebApi<Result_Edit_Entity_share_data>("/Api/ShareView/Edit_Entity_share_data", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Entity_share_data));
        }
        public Result_Get_Share_file_By_USER_ID Get_Share_file_By_USER_ID(Params_Get_Share_file_By_USER_ID i_Params_Get_Share_file_By_USER_ID)
        {
            return Get_Share_file_By_USER_ID_Async(i_Params_Get_Share_file_By_USER_ID).Result;
        }
        public async Task<Result_Get_Share_file_By_USER_ID> Get_Share_file_By_USER_ID_Async(Params_Get_Share_file_By_USER_ID i_Params_Get_Share_file_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_Share_file_By_USER_ID>("/Api/ShareView/Get_Share_file_By_USER_ID", true, "GET", $"?USER_ID={i_Params_Get_Share_file_By_USER_ID.USER_ID}");
        }
        public Result_Get_Share_file_By_SHARE_FILE_ID Get_Share_file_By_SHARE_FILE_ID(Params_Get_Share_file_By_SHARE_FILE_ID i_Params_Get_Share_file_By_SHARE_FILE_ID)
        {
            return Get_Share_file_By_SHARE_FILE_ID_Async(i_Params_Get_Share_file_By_SHARE_FILE_ID).Result;
        }
        public async Task<Result_Get_Share_file_By_SHARE_FILE_ID> Get_Share_file_By_SHARE_FILE_ID_Async(Params_Get_Share_file_By_SHARE_FILE_ID i_Params_Get_Share_file_By_SHARE_FILE_ID)
        {
            return await Call_WebApi<Result_Get_Share_file_By_SHARE_FILE_ID>("/Api/ShareView/Get_Share_file_By_SHARE_FILE_ID", true, "GET", $"?SHARE_FILE_ID={i_Params_Get_Share_file_By_SHARE_FILE_ID.SHARE_FILE_ID}");
        }
        public Result_Get_Entity_share_view_data Get_Entity_share_view_data(Params_Get_Entity_share_view_data i_Params_Get_Entity_share_view_data)
        {
            return Get_Entity_share_view_data_Async(i_Params_Get_Entity_share_view_data).Result;
        }
        public async Task<Result_Get_Entity_share_view_data> Get_Entity_share_view_data_Async(Params_Get_Entity_share_view_data i_Params_Get_Entity_share_view_data)
        {
            return await Call_WebApi<Result_Get_Entity_share_view_data>("/Api/ShareView/Get_Entity_share_view_data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_share_view_data));
        }
        public Result_Send_Share_Link_By_Email Send_Share_Link_By_Email(Params_Send_Share_Link_By_Email i_Params_Send_Share_Link_By_Email)
        {
            return Send_Share_Link_By_Email_Async(i_Params_Send_Share_Link_By_Email).Result;
        }
        public async Task<Result_Send_Share_Link_By_Email> Send_Share_Link_By_Email_Async(Params_Send_Share_Link_By_Email i_Params_Send_Share_Link_By_Email)
        {
            return await Call_WebApi<Result_Send_Share_Link_By_Email>("/Api/ShareView/Send_Share_Link_By_Email", true, "POST", JsonConvert.SerializeObject(i_Params_Send_Share_Link_By_Email));
        }
        public Result_Delete_Share_file Delete_Share_file(Params_Delete_Share_file i_Params_Delete_Share_file)
        {
            return Delete_Share_file_Async(i_Params_Delete_Share_file).Result;
        }
        public async Task<Result_Delete_Share_file> Delete_Share_file_Async(Params_Delete_Share_file i_Params_Delete_Share_file)
        {
            return await Call_WebApi<Result_Delete_Share_file>("/Api/ShareView/Delete_Share_file", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Share_file));
        }
        public Result_Edit_Share_file Edit_Share_file(Share_file i_Share_file)
        {
            return Edit_Share_file_Async(i_Share_file).Result;
        }
        public async Task<Result_Edit_Share_file> Edit_Share_file_Async(Share_file i_Share_file)
        {
            return await Call_WebApi<Result_Edit_Share_file>("/Api/ShareView/Edit_Share_file", true, "POST", JsonConvert.SerializeObject(i_Share_file));
        }
        public Result_Edit_Space Edit_Space(Space i_Space)
        {
            return Edit_Space_Async(i_Space).Result;
        }
        public async Task<Result_Edit_Space> Edit_Space_Async(Space i_Space)
        {
            return await Call_WebApi<Result_Edit_Space>("/Api/SpaceManagement/Edit_Space", true, "POST", JsonConvert.SerializeObject(i_Space));
        }
        public Result_Get_Space_asset_By_SPACE_ID_List_Adv Get_Space_asset_By_SPACE_ID_List_Adv(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            return Get_Space_asset_By_SPACE_ID_List_Adv_Async(i_Params_Get_Space_asset_By_SPACE_ID_List).Result;
        }
        public async Task<Result_Get_Space_asset_By_SPACE_ID_List_Adv> Get_Space_asset_By_SPACE_ID_List_Adv_Async(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            return await Call_WebApi<Result_Get_Space_asset_By_SPACE_ID_List_Adv>("/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID_List_Adv", true, "GET", $"?SPACE_ID_LIST={(i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST))}");
        }
        public Result_Get_Space_By_OWNER_ID Get_Space_By_OWNER_ID(Params_Get_Space_By_OWNER_ID i_Params_Get_Space_By_OWNER_ID)
        {
            return Get_Space_By_OWNER_ID_Async(i_Params_Get_Space_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Space_By_OWNER_ID> Get_Space_By_OWNER_ID_Async(Params_Get_Space_By_OWNER_ID i_Params_Get_Space_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Space_By_OWNER_ID>("/Api/SpaceManagement/Get_Space_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Space_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Space_asset Edit_Space_asset(Space_asset i_Space_asset)
        {
            return Edit_Space_asset_Async(i_Space_asset).Result;
        }
        public async Task<Result_Edit_Space_asset> Edit_Space_asset_Async(Space_asset i_Space_asset)
        {
            return await Call_WebApi<Result_Edit_Space_asset>("/Api/SpaceManagement/Edit_Space_asset", true, "POST", JsonConvert.SerializeObject(i_Space_asset));
        }
        public Result_Edit_Space_List Edit_Space_List(Params_Edit_Space_List i_Params_Edit_Space_List)
        {
            return Edit_Space_List_Async(i_Params_Edit_Space_List).Result;
        }
        public async Task<Result_Edit_Space_List> Edit_Space_List_Async(Params_Edit_Space_List i_Params_Edit_Space_List)
        {
            return await Call_WebApi<Result_Edit_Space_List>("/Api/SpaceManagement/Edit_Space_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Space_List));
        }
        public Result_Get_Space_asset_By_SPACE_ID_Adv Get_Space_asset_By_SPACE_ID_Adv(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            return Get_Space_asset_By_SPACE_ID_Adv_Async(i_Params_Get_Space_asset_By_SPACE_ID).Result;
        }
        public async Task<Result_Get_Space_asset_By_SPACE_ID_Adv> Get_Space_asset_By_SPACE_ID_Adv_Async(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            return await Call_WebApi<Result_Get_Space_asset_By_SPACE_ID_Adv>("/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID_Adv", true, "GET", $"?SPACE_ID={i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID}");
        }
        public Result_Get_Space_By_FLOOR_ID Get_Space_By_FLOOR_ID(Params_Get_Space_By_FLOOR_ID i_Params_Get_Space_By_FLOOR_ID)
        {
            return Get_Space_By_FLOOR_ID_Async(i_Params_Get_Space_By_FLOOR_ID).Result;
        }
        public async Task<Result_Get_Space_By_FLOOR_ID> Get_Space_By_FLOOR_ID_Async(Params_Get_Space_By_FLOOR_ID i_Params_Get_Space_By_FLOOR_ID)
        {
            return await Call_WebApi<Result_Get_Space_By_FLOOR_ID>("/Api/SpaceManagement/Get_Space_By_FLOOR_ID", true, "GET", $"?FLOOR_ID={i_Params_Get_Space_By_FLOOR_ID.FLOOR_ID}");
        }
        public Result_Get_Space_asset_By_SPACE_ID_List Get_Space_asset_By_SPACE_ID_List(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            return Get_Space_asset_By_SPACE_ID_List_Async(i_Params_Get_Space_asset_By_SPACE_ID_List).Result;
        }
        public async Task<Result_Get_Space_asset_By_SPACE_ID_List> Get_Space_asset_By_SPACE_ID_List_Async(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            return await Call_WebApi<Result_Get_Space_asset_By_SPACE_ID_List>("/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID_List", true, "GET", $"?SPACE_ID_LIST={(i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST))}");
        }
        public Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(Params_Get_Space_asset_By_SPACE_ASSET_ID_List i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List)
        {
            return Get_Space_asset_By_SPACE_ASSET_ID_List_Adv_Async(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List).Result;
        }
        public async Task<Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv> Get_Space_asset_By_SPACE_ASSET_ID_List_Adv_Async(Params_Get_Space_asset_By_SPACE_ASSET_ID_List i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List)
        {
            return await Call_WebApi<Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv>("/Api/SpaceManagement/Get_Space_asset_By_SPACE_ASSET_ID_List_Adv", true, "GET", $"?SPACE_ASSET_ID_LIST={(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST))}");
        }
        public Result_Edit_Space_asset_List Edit_Space_asset_List(Params_Edit_Space_asset_List i_Params_Edit_Space_asset_List)
        {
            return Edit_Space_asset_List_Async(i_Params_Edit_Space_asset_List).Result;
        }
        public async Task<Result_Edit_Space_asset_List> Edit_Space_asset_List_Async(Params_Edit_Space_asset_List i_Params_Edit_Space_asset_List)
        {
            return await Call_WebApi<Result_Edit_Space_asset_List>("/Api/SpaceManagement/Edit_Space_asset_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Space_asset_List));
        }
        public Result_Get_Space_asset_By_SPACE_ID Get_Space_asset_By_SPACE_ID(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            return Get_Space_asset_By_SPACE_ID_Async(i_Params_Get_Space_asset_By_SPACE_ID).Result;
        }
        public async Task<Result_Get_Space_asset_By_SPACE_ID> Get_Space_asset_By_SPACE_ID_Async(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            return await Call_WebApi<Result_Get_Space_asset_By_SPACE_ID>("/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID", true, "GET", $"?SPACE_ID={i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID}");
        }
        public Result_Delete_Space_asset_By_SPACE_ID Delete_Space_asset_By_SPACE_ID(Params_Delete_Space_asset_By_SPACE_ID i_Params_Delete_Space_asset_By_SPACE_ID)
        {
            return Delete_Space_asset_By_SPACE_ID_Async(i_Params_Delete_Space_asset_By_SPACE_ID).Result;
        }
        public async Task<Result_Delete_Space_asset_By_SPACE_ID> Delete_Space_asset_By_SPACE_ID_Async(Params_Delete_Space_asset_By_SPACE_ID i_Params_Delete_Space_asset_By_SPACE_ID)
        {
            return await Call_WebApi<Result_Delete_Space_asset_By_SPACE_ID>("/Api/SpaceManagement/Delete_Space_asset_By_SPACE_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_SPACE_ID));
        }
        public Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List Get_Video_ai_asset_By_SPACE_ASSET_ID_List(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List)
        {
            return Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Async(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List).Result;
        }
        public async Task<Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List> Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Async(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List)
        {
            return await Call_WebApi<Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List>("/Api/SpaceManagement/Get_Video_ai_asset_By_SPACE_ASSET_ID_List", true, "GET", $"?SPACE_ASSET_ID_LIST={(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST))}");
        }
        public Result_Get_Report_Details Get_Report_Details(Params_Get_Report_Details i_Params_Get_Report_Details)
        {
            return Get_Report_Details_Async(i_Params_Get_Report_Details).Result;
        }
        public async Task<Result_Get_Report_Details> Get_Report_Details_Async(Params_Get_Report_Details i_Params_Get_Report_Details)
        {
            return await Call_WebApi<Result_Get_Report_Details>("/Api/Reporting/Get_Report_Details", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Report_Details));
        }
        public Result_Send_Report_Email Send_Report_Email(Params_Send_Report_Email i_Params_Send_Report_Email)
        {
            return Send_Report_Email_Async(i_Params_Send_Report_Email).Result;
        }
        public async Task<Result_Send_Report_Email> Send_Report_Email_Async(Params_Send_Report_Email i_Params_Send_Report_Email)
        {
            return await Call_WebApi<Result_Send_Report_Email>("/Api/Reporting/Send_Report_Email", true, "POST", JsonConvert.SerializeObject(i_Params_Send_Report_Email));
        }
        public Result_Get_District_By_DISTRICT_ID_List Get_District_By_DISTRICT_ID_List(Params_Get_District_By_DISTRICT_ID_List i_Params_Get_District_By_DISTRICT_ID_List)
        {
            return Get_District_By_DISTRICT_ID_List_Async(i_Params_Get_District_By_DISTRICT_ID_List).Result;
        }
        public async Task<Result_Get_District_By_DISTRICT_ID_List> Get_District_By_DISTRICT_ID_List_Async(Params_Get_District_By_DISTRICT_ID_List i_Params_Get_District_By_DISTRICT_ID_List)
        {
            return await Call_WebApi<Result_Get_District_By_DISTRICT_ID_List>("/Api/DistrictManagement/Get_District_By_DISTRICT_ID_List", true, "GET", $"?DISTRICT_ID_LIST={(i_Params_Get_District_By_DISTRICT_ID_List.DISTRICT_ID_LIST == null ? "" : string.Join(",", i_Params_Get_District_By_DISTRICT_ID_List.DISTRICT_ID_LIST))}");
        }
        public Result_Edit_District_view Edit_District_view(District_view i_District_view)
        {
            return Edit_District_view_Async(i_District_view).Result;
        }
        public async Task<Result_Edit_District_view> Edit_District_view_Async(District_view i_District_view)
        {
            return await Call_WebApi<Result_Edit_District_view>("/Api/DistrictManagement/Edit_District_view", true, "POST", JsonConvert.SerializeObject(i_District_view));
        }
        public Result_Get_District_view_By_DISTRICT_ID Get_District_view_By_DISTRICT_ID(Params_Get_District_view_By_DISTRICT_ID i_Params_Get_District_view_By_DISTRICT_ID)
        {
            return Get_District_view_By_DISTRICT_ID_Async(i_Params_Get_District_view_By_DISTRICT_ID).Result;
        }
        public async Task<Result_Get_District_view_By_DISTRICT_ID> Get_District_view_By_DISTRICT_ID_Async(Params_Get_District_view_By_DISTRICT_ID i_Params_Get_District_view_By_DISTRICT_ID)
        {
            return await Call_WebApi<Result_Get_District_view_By_DISTRICT_ID>("/Api/DistrictManagement/Get_District_view_By_DISTRICT_ID", true, "GET", $"?DISTRICT_ID={i_Params_Get_District_view_By_DISTRICT_ID.DISTRICT_ID}");
        }
        public Result_Get_District_By_OWNER_ID Get_District_By_OWNER_ID(Params_Get_District_By_OWNER_ID i_Params_Get_District_By_OWNER_ID)
        {
            return Get_District_By_OWNER_ID_Async(i_Params_Get_District_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_District_By_OWNER_ID> Get_District_By_OWNER_ID_Async(Params_Get_District_By_OWNER_ID i_Params_Get_District_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_District_By_OWNER_ID>("/Api/DistrictManagement/Get_District_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_District_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_District_geojson_By_DISTRICT_ID_List Get_District_geojson_By_DISTRICT_ID_List(Params_Get_District_geojson_By_DISTRICT_ID_List i_Params_Get_District_geojson_By_DISTRICT_ID_List)
        {
            return Get_District_geojson_By_DISTRICT_ID_List_Async(i_Params_Get_District_geojson_By_DISTRICT_ID_List).Result;
        }
        public async Task<Result_Get_District_geojson_By_DISTRICT_ID_List> Get_District_geojson_By_DISTRICT_ID_List_Async(Params_Get_District_geojson_By_DISTRICT_ID_List i_Params_Get_District_geojson_By_DISTRICT_ID_List)
        {
            return await Call_WebApi<Result_Get_District_geojson_By_DISTRICT_ID_List>("/Api/DistrictManagement/Get_District_geojson_By_DISTRICT_ID_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_District_geojson_By_DISTRICT_ID_List));
        }
        public Result_Delete_District_view Delete_District_view(Params_Delete_District_view i_Params_Delete_District_view)
        {
            return Delete_District_view_Async(i_Params_Delete_District_view).Result;
        }
        public async Task<Result_Delete_District_view> Delete_District_view_Async(Params_Delete_District_view i_Params_Delete_District_view)
        {
            return await Call_WebApi<Result_Delete_District_view>("/Api/DistrictManagement/Delete_District_view", true, "DELETE", "/" + i_Params_Delete_District_view.DISTRICT_VIEW_ID);
        }
        public Result_Edit_District Edit_District(District i_District)
        {
            return Edit_District_Async(i_District).Result;
        }
        public async Task<Result_Edit_District> Edit_District_Async(District i_District)
        {
            return await Call_WebApi<Result_Edit_District>("/Api/DistrictManagement/Edit_District", true, "POST", JsonConvert.SerializeObject(i_District));
        }
        public Result_Edit_District_view_List Edit_District_view_List(Params_Edit_District_view_List i_Params_Edit_District_view_List)
        {
            return Edit_District_view_List_Async(i_Params_Edit_District_view_List).Result;
        }
        public async Task<Result_Edit_District_view_List> Edit_District_view_List_Async(Params_Edit_District_view_List i_Params_Edit_District_view_List)
        {
            return await Call_WebApi<Result_Edit_District_view_List>("/Api/DistrictManagement/Edit_District_view_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_District_view_List));
        }
        public Result_Delete_District_view_By_DISTRICT_ID Delete_District_view_By_DISTRICT_ID(Params_Delete_District_view_By_DISTRICT_ID i_Params_Delete_District_view_By_DISTRICT_ID)
        {
            return Delete_District_view_By_DISTRICT_ID_Async(i_Params_Delete_District_view_By_DISTRICT_ID).Result;
        }
        public async Task<Result_Delete_District_view_By_DISTRICT_ID> Delete_District_view_By_DISTRICT_ID_Async(Params_Delete_District_view_By_DISTRICT_ID i_Params_Delete_District_view_By_DISTRICT_ID)
        {
            return await Call_WebApi<Result_Delete_District_view_By_DISTRICT_ID>("/Api/DistrictManagement/Delete_District_view_By_DISTRICT_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_District_view_By_DISTRICT_ID));
        }
        public Result_Get_District_view_By_DISTRICT_ID_List Get_District_view_By_DISTRICT_ID_List(Params_Get_District_view_By_DISTRICT_ID_List i_Params_Get_District_view_By_DISTRICT_ID_List)
        {
            return Get_District_view_By_DISTRICT_ID_List_Async(i_Params_Get_District_view_By_DISTRICT_ID_List).Result;
        }
        public async Task<Result_Get_District_view_By_DISTRICT_ID_List> Get_District_view_By_DISTRICT_ID_List_Async(Params_Get_District_view_By_DISTRICT_ID_List i_Params_Get_District_view_By_DISTRICT_ID_List)
        {
            return await Call_WebApi<Result_Get_District_view_By_DISTRICT_ID_List>("/Api/DistrictManagement/Get_District_view_By_DISTRICT_ID_List", true, "GET", $"?DISTRICT_ID_LIST={(i_Params_Get_District_view_By_DISTRICT_ID_List.DISTRICT_ID_LIST == null ? "" : string.Join(",", i_Params_Get_District_view_By_DISTRICT_ID_List.DISTRICT_ID_LIST))}");
        }
        public Result_Get_Wifi_signals Get_Wifi_signals(Params_Get_Wifi_signals i_Params_Get_Wifi_signals)
        {
            return Get_Wifi_signals_Async(i_Params_Get_Wifi_signals).Result;
        }
        public async Task<Result_Get_Wifi_signals> Get_Wifi_signals_Async(Params_Get_Wifi_signals i_Params_Get_Wifi_signals)
        {
            return await Call_WebApi<Result_Get_Wifi_signals>("/Api/KPIManagement/Get_Wifi_signals", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Wifi_signals));
        }
        public Result_Get_District_Kpi_Dialog_Data Get_District_Kpi_Dialog_Data(Params_Get_District_Kpi_Dialog_Data i_Params_Get_District_Kpi_Dialog_Data)
        {
            return Get_District_Kpi_Dialog_Data_Async(i_Params_Get_District_Kpi_Dialog_Data).Result;
        }
        public async Task<Result_Get_District_Kpi_Dialog_Data> Get_District_Kpi_Dialog_Data_Async(Params_Get_District_Kpi_Dialog_Data i_Params_Get_District_Kpi_Dialog_Data)
        {
            return await Call_WebApi<Result_Get_District_Kpi_Dialog_Data>("/Api/KPIManagement/Get_District_Kpi_Dialog_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_District_Kpi_Dialog_Data));
        }
        public Result_Get_Area_Kpi_Data_Aggregate_Sum Get_Area_Kpi_Data_Aggregate_Sum(Params_Get_Area_Kpi_Data_Aggregate_Sum i_Params_Get_Area_Kpi_Data_Aggregate_Sum)
        {
            return Get_Area_Kpi_Data_Aggregate_Sum_Async(i_Params_Get_Area_Kpi_Data_Aggregate_Sum).Result;
        }
        public async Task<Result_Get_Area_Kpi_Data_Aggregate_Sum> Get_Area_Kpi_Data_Aggregate_Sum_Async(Params_Get_Area_Kpi_Data_Aggregate_Sum i_Params_Get_Area_Kpi_Data_Aggregate_Sum)
        {
            return await Call_WebApi<Result_Get_Area_Kpi_Data_Aggregate_Sum>("/Api/KPIManagement/Get_Area_Kpi_Data_Aggregate_Sum", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Area_Kpi_Data_Aggregate_Sum));
        }
        public Result_Get_Entity_Kpi_Data_By_Where Get_Entity_Kpi_Data_By_Where(Params_Get_Entity_Kpi_Data_By_Where i_Params_Get_Entity_Kpi_Data_By_Where)
        {
            return Get_Entity_Kpi_Data_By_Where_Async(i_Params_Get_Entity_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Get_Entity_Kpi_Data_By_Where> Get_Entity_Kpi_Data_By_Where_Async(Params_Get_Entity_Kpi_Data_By_Where i_Params_Get_Entity_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Get_Entity_Kpi_Data_By_Where>("/Api/KPIManagement/Get_Entity_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_Kpi_Data_By_Where));
        }
        public Result_Compute_Area_Kpi_Data_Hourly Compute_Area_Kpi_Data_Hourly(Params_Compute_Area_Kpi_Data_Hourly i_Params_Compute_Area_Kpi_Data_Hourly)
        {
            return Compute_Area_Kpi_Data_Hourly_Async(i_Params_Compute_Area_Kpi_Data_Hourly).Result;
        }
        public async Task<Result_Compute_Area_Kpi_Data_Hourly> Compute_Area_Kpi_Data_Hourly_Async(Params_Compute_Area_Kpi_Data_Hourly i_Params_Compute_Area_Kpi_Data_Hourly)
        {
            return await Call_WebApi<Result_Compute_Area_Kpi_Data_Hourly>("/Api/KPIManagement/Compute_Area_Kpi_Data_Hourly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Area_Kpi_Data_Hourly));
        }
        public Result_Get_Site_Kpi_Dialog_Data Get_Site_Kpi_Dialog_Data(Params_Get_Site_Kpi_Dialog_Data i_Params_Get_Site_Kpi_Dialog_Data)
        {
            return Get_Site_Kpi_Dialog_Data_Async(i_Params_Get_Site_Kpi_Dialog_Data).Result;
        }
        public async Task<Result_Get_Site_Kpi_Dialog_Data> Get_Site_Kpi_Dialog_Data_Async(Params_Get_Site_Kpi_Dialog_Data i_Params_Get_Site_Kpi_Dialog_Data)
        {
            return await Call_WebApi<Result_Get_Site_Kpi_Dialog_Data>("/Api/KPIManagement/Get_Site_Kpi_Dialog_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Site_Kpi_Dialog_Data));
        }
        public Result_Get_Site_Kpi_Data_By_Where Get_Site_Kpi_Data_By_Where(Params_Get_Site_Kpi_Data_By_Where i_Params_Get_Site_Kpi_Data_By_Where)
        {
            return Get_Site_Kpi_Data_By_Where_Async(i_Params_Get_Site_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Get_Site_Kpi_Data_By_Where> Get_Site_Kpi_Data_By_Where_Async(Params_Get_Site_Kpi_Data_By_Where i_Params_Get_Site_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Get_Site_Kpi_Data_By_Where>("/Api/KPIManagement/Get_Site_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Site_Kpi_Data_By_Where));
        }
        public Result_Edit_Alert_List Edit_Alert_List(Params_Edit_Alert_List i_Params_Edit_Alert_List)
        {
            return Edit_Alert_List_Async(i_Params_Edit_Alert_List).Result;
        }
        public async Task<Result_Edit_Alert_List> Edit_Alert_List_Async(Params_Edit_Alert_List i_Params_Edit_Alert_List)
        {
            return await Call_WebApi<Result_Edit_Alert_List>("/Api/KPIManagement/Edit_Alert_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Alert_List));
        }
        public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            return Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv_Async(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List).Result;
        }
        public async Task<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv_Async(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv>("/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", true, "GET", $"?ORGANIZATION_DATA_SOURCE_KPI_ID_LIST={(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST))}");
        }
        public Result_Compute_District_Kpi_Data_Monthly Compute_District_Kpi_Data_Monthly(Params_Compute_District_Kpi_Data_Monthly i_Params_Compute_District_Kpi_Data_Monthly)
        {
            return Compute_District_Kpi_Data_Monthly_Async(i_Params_Compute_District_Kpi_Data_Monthly).Result;
        }
        public async Task<Result_Compute_District_Kpi_Data_Monthly> Compute_District_Kpi_Data_Monthly_Async(Params_Compute_District_Kpi_Data_Monthly i_Params_Compute_District_Kpi_Data_Monthly)
        {
            return await Call_WebApi<Result_Compute_District_Kpi_Data_Monthly>("/Api/KPIManagement/Compute_District_Kpi_Data_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_District_Kpi_Data_Monthly));
        }
        public Result_Get_Bylaw_Complaint_List Get_Bylaw_Complaint_List(Params_Get_Bylaw_Complaint_List i_Params_Get_Bylaw_Complaint_List)
        {
            return Get_Bylaw_Complaint_List_Async(i_Params_Get_Bylaw_Complaint_List).Result;
        }
        public async Task<Result_Get_Bylaw_Complaint_List> Get_Bylaw_Complaint_List_Async(Params_Get_Bylaw_Complaint_List i_Params_Get_Bylaw_Complaint_List)
        {
            return await Call_WebApi<Result_Get_Bylaw_Complaint_List>("/Api/KPIManagement/Get_Bylaw_Complaint_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Bylaw_Complaint_List));
        }
        public Result_Delete_Kpi Delete_Kpi(Params_Delete_Kpi i_Params_Delete_Kpi)
        {
            return Delete_Kpi_Async(i_Params_Delete_Kpi).Result;
        }
        public async Task<Result_Delete_Kpi> Delete_Kpi_Async(Params_Delete_Kpi i_Params_Delete_Kpi)
        {
            return await Call_WebApi<Result_Delete_Kpi>("/Api/KPIManagement/Delete_Kpi", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Kpi));
        }
        public Result_Delete_Wifi_signal Delete_Wifi_signal(Params_Delete_Wifi_signal i_Params_Delete_Wifi_signal)
        {
            return Delete_Wifi_signal_Async(i_Params_Delete_Wifi_signal).Result;
        }
        public async Task<Result_Delete_Wifi_signal> Delete_Wifi_signal_Async(Params_Delete_Wifi_signal i_Params_Delete_Wifi_signal)
        {
            return await Call_WebApi<Result_Delete_Wifi_signal>("/Api/KPIManagement/Delete_Wifi_signal", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Wifi_signal));
        }
        public Result_Compute_Floor_Kpi_Data_Monthly Compute_Floor_Kpi_Data_Monthly(Params_Compute_Floor_Kpi_Data_Monthly i_Params_Compute_Floor_Kpi_Data_Monthly)
        {
            return Compute_Floor_Kpi_Data_Monthly_Async(i_Params_Compute_Floor_Kpi_Data_Monthly).Result;
        }
        public async Task<Result_Compute_Floor_Kpi_Data_Monthly> Compute_Floor_Kpi_Data_Monthly_Async(Params_Compute_Floor_Kpi_Data_Monthly i_Params_Compute_Floor_Kpi_Data_Monthly)
        {
            return await Call_WebApi<Result_Compute_Floor_Kpi_Data_Monthly>("/Api/KPIManagement/Compute_Floor_Kpi_Data_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Floor_Kpi_Data_Monthly));
        }
        public Result_Edit_Wifi_signal_alert_List Edit_Wifi_signal_alert_List(Params_Edit_Wifi_signal_alert_List i_Params_Edit_Wifi_signal_alert_List)
        {
            return Edit_Wifi_signal_alert_List_Async(i_Params_Edit_Wifi_signal_alert_List).Result;
        }
        public async Task<Result_Edit_Wifi_signal_alert_List> Edit_Wifi_signal_alert_List_Async(Params_Edit_Wifi_signal_alert_List i_Params_Edit_Wifi_signal_alert_List)
        {
            return await Call_WebApi<Result_Edit_Wifi_signal_alert_List>("/Api/KPIManagement/Edit_Wifi_signal_alert_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Wifi_signal_alert_List));
        }
        public Result_Delete_Alert Delete_Alert(Params_Delete_Alert i_Params_Delete_Alert)
        {
            return Delete_Alert_Async(i_Params_Delete_Alert).Result;
        }
        public async Task<Result_Delete_Alert> Delete_Alert_Async(Params_Delete_Alert i_Params_Delete_Alert)
        {
            return await Call_WebApi<Result_Delete_Alert>("/Api/KPIManagement/Delete_Alert", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Alert));
        }
        public Result_Compute_District_Kpi_Data_Weekly Compute_District_Kpi_Data_Weekly(Params_Compute_District_Kpi_Data_Weekly i_Params_Compute_District_Kpi_Data_Weekly)
        {
            return Compute_District_Kpi_Data_Weekly_Async(i_Params_Compute_District_Kpi_Data_Weekly).Result;
        }
        public async Task<Result_Compute_District_Kpi_Data_Weekly> Compute_District_Kpi_Data_Weekly_Async(Params_Compute_District_Kpi_Data_Weekly i_Params_Compute_District_Kpi_Data_Weekly)
        {
            return await Call_WebApi<Result_Compute_District_Kpi_Data_Weekly>("/Api/KPIManagement/Compute_District_Kpi_Data_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_District_Kpi_Data_Weekly));
        }
        public Result_Get_District_Kpi_Data_Aggregate_Sum Get_District_Kpi_Data_Aggregate_Sum(Params_Get_District_Kpi_Data_Aggregate_Sum i_Params_Get_District_Kpi_Data_Aggregate_Sum)
        {
            return Get_District_Kpi_Data_Aggregate_Sum_Async(i_Params_Get_District_Kpi_Data_Aggregate_Sum).Result;
        }
        public async Task<Result_Get_District_Kpi_Data_Aggregate_Sum> Get_District_Kpi_Data_Aggregate_Sum_Async(Params_Get_District_Kpi_Data_Aggregate_Sum i_Params_Get_District_Kpi_Data_Aggregate_Sum)
        {
            return await Call_WebApi<Result_Get_District_Kpi_Data_Aggregate_Sum>("/Api/KPIManagement/Get_District_Kpi_Data_Aggregate_Sum", true, "POST", JsonConvert.SerializeObject(i_Params_Get_District_Kpi_Data_Aggregate_Sum));
        }
        public Result_Get_Latest_Organization_data_source_kpi_By_Where Get_Latest_Organization_data_source_kpi_By_Where(Params_Get_Latest_Organization_data_source_kpi_By_Where i_Params_Get_Latest_Organization_data_source_kpi_By_Where)
        {
            return Get_Latest_Organization_data_source_kpi_By_Where_Async(i_Params_Get_Latest_Organization_data_source_kpi_By_Where).Result;
        }
        public async Task<Result_Get_Latest_Organization_data_source_kpi_By_Where> Get_Latest_Organization_data_source_kpi_By_Where_Async(Params_Get_Latest_Organization_data_source_kpi_By_Where i_Params_Get_Latest_Organization_data_source_kpi_By_Where)
        {
            return await Call_WebApi<Result_Get_Latest_Organization_data_source_kpi_By_Where>("/Api/KPIManagement/Get_Latest_Organization_data_source_kpi_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Latest_Organization_data_source_kpi_By_Where));
        }
        public Result_Compute_Space_Kpi_Data_Monthly Compute_Space_Kpi_Data_Monthly(Params_Compute_Space_Kpi_Data_Monthly i_Params_Compute_Space_Kpi_Data_Monthly)
        {
            return Compute_Space_Kpi_Data_Monthly_Async(i_Params_Compute_Space_Kpi_Data_Monthly).Result;
        }
        public async Task<Result_Compute_Space_Kpi_Data_Monthly> Compute_Space_Kpi_Data_Monthly_Async(Params_Compute_Space_Kpi_Data_Monthly i_Params_Compute_Space_Kpi_Data_Monthly)
        {
            return await Call_WebApi<Result_Compute_Space_Kpi_Data_Monthly>("/Api/KPIManagement/Compute_Space_Kpi_Data_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Space_Kpi_Data_Monthly));
        }
        public Result_Compute_Space_Kpi_Data_Daily Compute_Space_Kpi_Data_Daily(Params_Compute_Space_Kpi_Data_Daily i_Params_Compute_Space_Kpi_Data_Daily)
        {
            return Compute_Space_Kpi_Data_Daily_Async(i_Params_Compute_Space_Kpi_Data_Daily).Result;
        }
        public async Task<Result_Compute_Space_Kpi_Data_Daily> Compute_Space_Kpi_Data_Daily_Async(Params_Compute_Space_Kpi_Data_Daily i_Params_Compute_Space_Kpi_Data_Daily)
        {
            return await Call_WebApi<Result_Compute_Space_Kpi_Data_Daily>("/Api/KPIManagement/Compute_Space_Kpi_Data_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Space_Kpi_Data_Daily));
        }
        public Result_Update_Kpi_Data_Record Update_Kpi_Data_Record(Params_Update_Kpi_Data_Record i_Params_Update_Kpi_Data_Record)
        {
            return Update_Kpi_Data_Record_Async(i_Params_Update_Kpi_Data_Record).Result;
        }
        public async Task<Result_Update_Kpi_Data_Record> Update_Kpi_Data_Record_Async(Params_Update_Kpi_Data_Record i_Params_Update_Kpi_Data_Record)
        {
            return await Call_WebApi<Result_Update_Kpi_Data_Record>("/Api/KPIManagement/Update_Kpi_Data_Record", true, "POST", JsonConvert.SerializeObject(i_Params_Update_Kpi_Data_Record));
        }
        public Result_Compute_Area_Kpi_Data_Daily Compute_Area_Kpi_Data_Daily(Params_Compute_Area_Kpi_Data_Daily i_Params_Compute_Area_Kpi_Data_Daily)
        {
            return Compute_Area_Kpi_Data_Daily_Async(i_Params_Compute_Area_Kpi_Data_Daily).Result;
        }
        public async Task<Result_Compute_Area_Kpi_Data_Daily> Compute_Area_Kpi_Data_Daily_Async(Params_Compute_Area_Kpi_Data_Daily i_Params_Compute_Area_Kpi_Data_Daily)
        {
            return await Call_WebApi<Result_Compute_Area_Kpi_Data_Daily>("/Api/KPIManagement/Compute_Area_Kpi_Data_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Area_Kpi_Data_Daily));
        }
        public Result_Get_Latest_Wifi_signal_alerts Get_Latest_Wifi_signal_alerts(Params_Get_Latest_Wifi_signal_alerts i_Params_Get_Latest_Wifi_signal_alerts)
        {
            return Get_Latest_Wifi_signal_alerts_Async(i_Params_Get_Latest_Wifi_signal_alerts).Result;
        }
        public async Task<Result_Get_Latest_Wifi_signal_alerts> Get_Latest_Wifi_signal_alerts_Async(Params_Get_Latest_Wifi_signal_alerts i_Params_Get_Latest_Wifi_signal_alerts)
        {
            return await Call_WebApi<Result_Get_Latest_Wifi_signal_alerts>("/Api/KPIManagement/Get_Latest_Wifi_signal_alerts", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Latest_Wifi_signal_alerts));
        }
        public Result_Get_Floor_Kpi_Data_Aggregate_Sum Get_Floor_Kpi_Data_Aggregate_Sum(Params_Get_Floor_Kpi_Data_Aggregate_Sum i_Params_Get_Floor_Kpi_Data_Aggregate_Sum)
        {
            return Get_Floor_Kpi_Data_Aggregate_Sum_Async(i_Params_Get_Floor_Kpi_Data_Aggregate_Sum).Result;
        }
        public async Task<Result_Get_Floor_Kpi_Data_Aggregate_Sum> Get_Floor_Kpi_Data_Aggregate_Sum_Async(Params_Get_Floor_Kpi_Data_Aggregate_Sum i_Params_Get_Floor_Kpi_Data_Aggregate_Sum)
        {
            return await Call_WebApi<Result_Get_Floor_Kpi_Data_Aggregate_Sum>("/Api/KPIManagement/Get_Floor_Kpi_Data_Aggregate_Sum", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Floor_Kpi_Data_Aggregate_Sum));
        }
        public Result_Compute_Entity_Kpi_Data_Weekly Compute_Entity_Kpi_Data_Weekly(Params_Compute_Entity_Kpi_Data_Weekly i_Params_Compute_Entity_Kpi_Data_Weekly)
        {
            return Compute_Entity_Kpi_Data_Weekly_Async(i_Params_Compute_Entity_Kpi_Data_Weekly).Result;
        }
        public async Task<Result_Compute_Entity_Kpi_Data_Weekly> Compute_Entity_Kpi_Data_Weekly_Async(Params_Compute_Entity_Kpi_Data_Weekly i_Params_Compute_Entity_Kpi_Data_Weekly)
        {
            return await Call_WebApi<Result_Compute_Entity_Kpi_Data_Weekly>("/Api/KPIManagement/Compute_Entity_Kpi_Data_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Entity_Kpi_Data_Weekly));
        }
        public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            return Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv_Async(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID).Result;
        }
        public async Task<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv_Async(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            return await Call_WebApi<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv>("/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", true, "GET", $"?ORGANIZATION_DATA_SOURCE_KPI_ID={i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID}");
        }
        public Result_Compute_Area_Kpi_Data_Weekly Compute_Area_Kpi_Data_Weekly(Params_Compute_Area_Kpi_Data_Weekly i_Params_Compute_Area_Kpi_Data_Weekly)
        {
            return Compute_Area_Kpi_Data_Weekly_Async(i_Params_Compute_Area_Kpi_Data_Weekly).Result;
        }
        public async Task<Result_Compute_Area_Kpi_Data_Weekly> Compute_Area_Kpi_Data_Weekly_Async(Params_Compute_Area_Kpi_Data_Weekly i_Params_Compute_Area_Kpi_Data_Weekly)
        {
            return await Call_WebApi<Result_Compute_Area_Kpi_Data_Weekly>("/Api/KPIManagement/Compute_Area_Kpi_Data_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Area_Kpi_Data_Weekly));
        }
        public Result_Get_Business_Trendline Get_Business_Trendline(Params_Get_Business_Trendline i_Params_Get_Business_Trendline)
        {
            return Get_Business_Trendline_Async(i_Params_Get_Business_Trendline).Result;
        }
        public async Task<Result_Get_Business_Trendline> Get_Business_Trendline_Async(Params_Get_Business_Trendline i_Params_Get_Business_Trendline)
        {
            return await Call_WebApi<Result_Get_Business_Trendline>("/Api/KPIManagement/Get_Business_Trendline", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Business_Trendline));
        }
        public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            return Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv_Async(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv_Async(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv>("/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Edit_Wifi_signal_List Edit_Wifi_signal_List(Params_Edit_Wifi_signal_List i_Params_Edit_Wifi_signal_List)
        {
            return Edit_Wifi_signal_List_Async(i_Params_Edit_Wifi_signal_List).Result;
        }
        public async Task<Result_Edit_Wifi_signal_List> Edit_Wifi_signal_List_Async(Params_Edit_Wifi_signal_List i_Params_Edit_Wifi_signal_List)
        {
            return await Call_WebApi<Result_Edit_Wifi_signal_List>("/Api/KPIManagement/Edit_Wifi_signal_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Wifi_signal_List));
        }
        public Result_Compute_Entity_Kpi_Data_Daily Compute_Entity_Kpi_Data_Daily(Params_Compute_Entity_Kpi_Data_Daily i_Params_Compute_Entity_Kpi_Data_Daily)
        {
            return Compute_Entity_Kpi_Data_Daily_Async(i_Params_Compute_Entity_Kpi_Data_Daily).Result;
        }
        public async Task<Result_Compute_Entity_Kpi_Data_Daily> Compute_Entity_Kpi_Data_Daily_Async(Params_Compute_Entity_Kpi_Data_Daily i_Params_Compute_Entity_Kpi_Data_Daily)
        {
            return await Call_WebApi<Result_Compute_Entity_Kpi_Data_Daily>("/Api/KPIManagement/Compute_Entity_Kpi_Data_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Entity_Kpi_Data_Daily));
        }
        public Result_Get_Floor_Kpi_Dialog_Data Get_Floor_Kpi_Dialog_Data(Params_Get_Floor_Kpi_Dialog_Data i_Params_Get_Floor_Kpi_Dialog_Data)
        {
            return Get_Floor_Kpi_Dialog_Data_Async(i_Params_Get_Floor_Kpi_Dialog_Data).Result;
        }
        public async Task<Result_Get_Floor_Kpi_Dialog_Data> Get_Floor_Kpi_Dialog_Data_Async(Params_Get_Floor_Kpi_Dialog_Data i_Params_Get_Floor_Kpi_Dialog_Data)
        {
            return await Call_WebApi<Result_Get_Floor_Kpi_Dialog_Data>("/Api/KPIManagement/Get_Floor_Kpi_Dialog_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Floor_Kpi_Dialog_Data));
        }
        public Result_Get_Latest_GeoData_By_KPI Get_Latest_GeoData_By_KPI(Params_Get_Latest_GeoData_By_KPI i_Params_Get_Latest_GeoData_By_KPI)
        {
            return Get_Latest_GeoData_By_KPI_Async(i_Params_Get_Latest_GeoData_By_KPI).Result;
        }
        public async Task<Result_Get_Latest_GeoData_By_KPI> Get_Latest_GeoData_By_KPI_Async(Params_Get_Latest_GeoData_By_KPI i_Params_Get_Latest_GeoData_By_KPI)
        {
            return await Call_WebApi<Result_Get_Latest_GeoData_By_KPI>("/Api/KPIManagement/Get_Latest_GeoData_By_KPI", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Latest_GeoData_By_KPI));
        }
        public Result_Get_Public_Event_List Get_Public_Event_List(Params_Get_Public_Event_List i_Params_Get_Public_Event_List)
        {
            return Get_Public_Event_List_Async(i_Params_Get_Public_Event_List).Result;
        }
        public async Task<Result_Get_Public_Event_List> Get_Public_Event_List_Async(Params_Get_Public_Event_List i_Params_Get_Public_Event_List)
        {
            return await Call_WebApi<Result_Get_Public_Event_List>("/Api/KPIManagement/Get_Public_Event_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Public_Event_List));
        }
        public Result_Get_And_Save_Wifi_Signal_From_Api Get_And_Save_Wifi_Signal_From_Api()
        {
            return Get_And_Save_Wifi_Signal_From_Api_Async().Result;
        }
        public async Task<Result_Get_And_Save_Wifi_Signal_From_Api> Get_And_Save_Wifi_Signal_From_Api_Async()
        {
            return await Call_WebApi<Result_Get_And_Save_Wifi_Signal_From_Api>("/Api/KPIManagement/Get_And_Save_Wifi_Signal_From_Api", true, "POST");
        }
        public Result_Get_Alerts_By_Where Get_Alerts_By_Where(Params_Get_Alerts_By_Where i_Params_Get_Alerts_By_Where)
        {
            return Get_Alerts_By_Where_Async(i_Params_Get_Alerts_By_Where).Result;
        }
        public async Task<Result_Get_Alerts_By_Where> Get_Alerts_By_Where_Async(Params_Get_Alerts_By_Where i_Params_Get_Alerts_By_Where)
        {
            return await Call_WebApi<Result_Get_Alerts_By_Where>("/Api/KPIManagement/Get_Alerts_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Alerts_By_Where));
        }
        public Result_Compute_Site_Kpi_Data_Hourly Compute_Site_Kpi_Data_Hourly(Params_Compute_Site_Kpi_Data_Hourly i_Params_Compute_Site_Kpi_Data_Hourly)
        {
            return Compute_Site_Kpi_Data_Hourly_Async(i_Params_Compute_Site_Kpi_Data_Hourly).Result;
        }
        public async Task<Result_Compute_Site_Kpi_Data_Hourly> Compute_Site_Kpi_Data_Hourly_Async(Params_Compute_Site_Kpi_Data_Hourly i_Params_Compute_Site_Kpi_Data_Hourly)
        {
            return await Call_WebApi<Result_Compute_Site_Kpi_Data_Hourly>("/Api/KPIManagement/Compute_Site_Kpi_Data_Hourly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Site_Kpi_Data_Hourly));
        }
        public Result_Compute_Entity_Kpi_Data_Hourly Compute_Entity_Kpi_Data_Hourly(Params_Compute_Entity_Kpi_Data_Hourly i_Params_Compute_Entity_Kpi_Data_Hourly)
        {
            return Compute_Entity_Kpi_Data_Hourly_Async(i_Params_Compute_Entity_Kpi_Data_Hourly).Result;
        }
        public async Task<Result_Compute_Entity_Kpi_Data_Hourly> Compute_Entity_Kpi_Data_Hourly_Async(Params_Compute_Entity_Kpi_Data_Hourly i_Params_Compute_Entity_Kpi_Data_Hourly)
        {
            return await Call_WebApi<Result_Compute_Entity_Kpi_Data_Hourly>("/Api/KPIManagement/Compute_Entity_Kpi_Data_Hourly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Entity_Kpi_Data_Hourly));
        }
        public Result_Compute_Entity_Kpi_Data_Monthly Compute_Entity_Kpi_Data_Monthly(Params_Compute_Entity_Kpi_Data_Monthly i_Params_Compute_Entity_Kpi_Data_Monthly)
        {
            return Compute_Entity_Kpi_Data_Monthly_Async(i_Params_Compute_Entity_Kpi_Data_Monthly).Result;
        }
        public async Task<Result_Compute_Entity_Kpi_Data_Monthly> Compute_Entity_Kpi_Data_Monthly_Async(Params_Compute_Entity_Kpi_Data_Monthly i_Params_Compute_Entity_Kpi_Data_Monthly)
        {
            return await Call_WebApi<Result_Compute_Entity_Kpi_Data_Monthly>("/Api/KPIManagement/Compute_Entity_Kpi_Data_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Entity_Kpi_Data_Monthly));
        }
        public Result_Edit_User_Data_Access Edit_User_Data_Access(Params_Edit_User_Data_Access i_Params_Edit_User_Data_Access)
        {
            return Edit_User_Data_Access_Async(i_Params_Edit_User_Data_Access).Result;
        }
        public async Task<Result_Edit_User_Data_Access> Edit_User_Data_Access_Async(Params_Edit_User_Data_Access i_Params_Edit_User_Data_Access)
        {
            return await Call_WebApi<Result_Edit_User_Data_Access>("/Api/KPIManagement/Edit_User_Data_Access", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_User_Data_Access));
        }
        public Result_Get_Organization_Data_Access Get_Organization_Data_Access(Params_Get_Organization_Data_Access i_Params_Get_Organization_Data_Access)
        {
            return Get_Organization_Data_Access_Async(i_Params_Get_Organization_Data_Access).Result;
        }
        public async Task<Result_Get_Organization_Data_Access> Get_Organization_Data_Access_Async(Params_Get_Organization_Data_Access i_Params_Get_Organization_Data_Access)
        {
            return await Call_WebApi<Result_Get_Organization_Data_Access>("/Api/KPIManagement/Get_Organization_Data_Access", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Organization_Data_Access));
        }
        public Result_Get_User_Data_Access Get_User_Data_Access(Params_Get_User_Data_Access i_Params_Get_User_Data_Access)
        {
            return Get_User_Data_Access_Async(i_Params_Get_User_Data_Access).Result;
        }
        public async Task<Result_Get_User_Data_Access> Get_User_Data_Access_Async(Params_Get_User_Data_Access i_Params_Get_User_Data_Access)
        {
            return await Call_WebApi<Result_Get_User_Data_Access>("/Api/KPIManagement/Get_User_Data_Access", true, "POST", JsonConvert.SerializeObject(i_Params_Get_User_Data_Access));
        }
        public Result_Delete_Wifi_signal_alert Delete_Wifi_signal_alert(Params_Delete_Wifi_signal_alert i_Params_Delete_Wifi_signal_alert)
        {
            return Delete_Wifi_signal_alert_Async(i_Params_Delete_Wifi_signal_alert).Result;
        }
        public async Task<Result_Delete_Wifi_signal_alert> Delete_Wifi_signal_alert_Async(Params_Delete_Wifi_signal_alert i_Params_Delete_Wifi_signal_alert)
        {
            return await Call_WebApi<Result_Delete_Wifi_signal_alert>("/Api/KPIManagement/Delete_Wifi_signal_alert", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Wifi_signal_alert));
        }
        public Result_Get_Area_Kpi_Dialog_Data Get_Area_Kpi_Dialog_Data(Params_Get_Area_Kpi_Dialog_Data i_Params_Get_Area_Kpi_Dialog_Data)
        {
            return Get_Area_Kpi_Dialog_Data_Async(i_Params_Get_Area_Kpi_Dialog_Data).Result;
        }
        public async Task<Result_Get_Area_Kpi_Dialog_Data> Get_Area_Kpi_Dialog_Data_Async(Params_Get_Area_Kpi_Dialog_Data i_Params_Get_Area_Kpi_Dialog_Data)
        {
            return await Call_WebApi<Result_Get_Area_Kpi_Dialog_Data>("/Api/KPIManagement/Get_Area_Kpi_Dialog_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Area_Kpi_Dialog_Data));
        }
        public Result_Get_Alerts_Count_For_Levels Get_Alerts_Count_For_Levels(Params_Get_Alerts_Count_For_Levels i_Params_Get_Alerts_Count_For_Levels)
        {
            return Get_Alerts_Count_For_Levels_Async(i_Params_Get_Alerts_Count_For_Levels).Result;
        }
        public async Task<Result_Get_Alerts_Count_For_Levels> Get_Alerts_Count_For_Levels_Async(Params_Get_Alerts_Count_For_Levels i_Params_Get_Alerts_Count_For_Levels)
        {
            return await Call_WebApi<Result_Get_Alerts_Count_For_Levels>("/Api/KPIManagement/Get_Alerts_Count_For_Levels", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Alerts_Count_For_Levels));
        }
        public Result_Get_Space_Kpi_Data_By_Where Get_Space_Kpi_Data_By_Where(Params_Get_Space_Kpi_Data_By_Where i_Params_Get_Space_Kpi_Data_By_Where)
        {
            return Get_Space_Kpi_Data_By_Where_Async(i_Params_Get_Space_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Get_Space_Kpi_Data_By_Where> Get_Space_Kpi_Data_By_Where_Async(Params_Get_Space_Kpi_Data_By_Where i_Params_Get_Space_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Get_Space_Kpi_Data_By_Where>("/Api/KPIManagement/Get_Space_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Space_Kpi_Data_By_Where));
        }
        public Result_Get_Site_Kpi_Data_Aggregate_Sum Get_Site_Kpi_Data_Aggregate_Sum(Params_Get_Site_Kpi_Data_Aggregate_Sum i_Params_Get_Site_Kpi_Data_Aggregate_Sum)
        {
            return Get_Site_Kpi_Data_Aggregate_Sum_Async(i_Params_Get_Site_Kpi_Data_Aggregate_Sum).Result;
        }
        public async Task<Result_Get_Site_Kpi_Data_Aggregate_Sum> Get_Site_Kpi_Data_Aggregate_Sum_Async(Params_Get_Site_Kpi_Data_Aggregate_Sum i_Params_Get_Site_Kpi_Data_Aggregate_Sum)
        {
            return await Call_WebApi<Result_Get_Site_Kpi_Data_Aggregate_Sum>("/Api/KPIManagement/Get_Site_Kpi_Data_Aggregate_Sum", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Site_Kpi_Data_Aggregate_Sum));
        }
        public Result_Get_Latest_Visitor_Count_By_Where Get_Latest_Visitor_Count_By_Where(Params_Get_Latest_Visitor_Count_By_Where i_Params_Get_Latest_Visitor_Count_By_Where)
        {
            return Get_Latest_Visitor_Count_By_Where_Async(i_Params_Get_Latest_Visitor_Count_By_Where).Result;
        }
        public async Task<Result_Get_Latest_Visitor_Count_By_Where> Get_Latest_Visitor_Count_By_Where_Async(Params_Get_Latest_Visitor_Count_By_Where i_Params_Get_Latest_Visitor_Count_By_Where)
        {
            return await Call_WebApi<Result_Get_Latest_Visitor_Count_By_Where>("/Api/KPIManagement/Get_Latest_Visitor_Count_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Latest_Visitor_Count_By_Where));
        }
        public Result_Get_Entity_Kpi_Data_Aggregate_Sum Get_Entity_Kpi_Data_Aggregate_Sum(Params_Get_Entity_Kpi_Data_Aggregate_Sum i_Params_Get_Entity_Kpi_Data_Aggregate_Sum)
        {
            return Get_Entity_Kpi_Data_Aggregate_Sum_Async(i_Params_Get_Entity_Kpi_Data_Aggregate_Sum).Result;
        }
        public async Task<Result_Get_Entity_Kpi_Data_Aggregate_Sum> Get_Entity_Kpi_Data_Aggregate_Sum_Async(Params_Get_Entity_Kpi_Data_Aggregate_Sum i_Params_Get_Entity_Kpi_Data_Aggregate_Sum)
        {
            return await Call_WebApi<Result_Get_Entity_Kpi_Data_Aggregate_Sum>("/Api/KPIManagement/Get_Entity_Kpi_Data_Aggregate_Sum", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_Kpi_Data_Aggregate_Sum));
        }
        public Result_Compute_Floor_Kpi_Data_Hourly Compute_Floor_Kpi_Data_Hourly(Params_Compute_Floor_Kpi_Data_Hourly i_Params_Compute_Floor_Kpi_Data_Hourly)
        {
            return Compute_Floor_Kpi_Data_Hourly_Async(i_Params_Compute_Floor_Kpi_Data_Hourly).Result;
        }
        public async Task<Result_Compute_Floor_Kpi_Data_Hourly> Compute_Floor_Kpi_Data_Hourly_Async(Params_Compute_Floor_Kpi_Data_Hourly i_Params_Compute_Floor_Kpi_Data_Hourly)
        {
            return await Call_WebApi<Result_Compute_Floor_Kpi_Data_Hourly>("/Api/KPIManagement/Compute_Floor_Kpi_Data_Hourly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Floor_Kpi_Data_Hourly));
        }
        public Result_Get_Wifi_signal_alerts Get_Wifi_signal_alerts(Params_Get_Wifi_signal_alerts i_Params_Get_Wifi_signal_alerts)
        {
            return Get_Wifi_signal_alerts_Async(i_Params_Get_Wifi_signal_alerts).Result;
        }
        public async Task<Result_Get_Wifi_signal_alerts> Get_Wifi_signal_alerts_Async(Params_Get_Wifi_signal_alerts i_Params_Get_Wifi_signal_alerts)
        {
            return await Call_WebApi<Result_Get_Wifi_signal_alerts>("/Api/KPIManagement/Get_Wifi_signal_alerts", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Wifi_signal_alerts));
        }
        public Result_Get_District_Kpi_Data_By_Where Get_District_Kpi_Data_By_Where(Params_Get_District_Kpi_Data_By_Where i_Params_Get_District_Kpi_Data_By_Where)
        {
            return Get_District_Kpi_Data_By_Where_Async(i_Params_Get_District_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Get_District_Kpi_Data_By_Where> Get_District_Kpi_Data_By_Where_Async(Params_Get_District_Kpi_Data_By_Where i_Params_Get_District_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Get_District_Kpi_Data_By_Where>("/Api/KPIManagement/Get_District_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_District_Kpi_Data_By_Where));
        }
        public Result_Get_Kpi_By_OWNER_ID_Adv Get_Kpi_By_OWNER_ID_Adv(Params_Get_Kpi_By_OWNER_ID i_Params_Get_Kpi_By_OWNER_ID)
        {
            return Get_Kpi_By_OWNER_ID_Adv_Async(i_Params_Get_Kpi_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Kpi_By_OWNER_ID_Adv> Get_Kpi_By_OWNER_ID_Adv_Async(Params_Get_Kpi_By_OWNER_ID i_Params_Get_Kpi_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Kpi_By_OWNER_ID_Adv>("/Api/KPIManagement/Get_Kpi_By_OWNER_ID_Adv", true, "GET", $"?OWNER_ID={i_Params_Get_Kpi_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Floor_Kpi_Data_By_Where Get_Floor_Kpi_Data_By_Where(Params_Get_Floor_Kpi_Data_By_Where i_Params_Get_Floor_Kpi_Data_By_Where)
        {
            return Get_Floor_Kpi_Data_By_Where_Async(i_Params_Get_Floor_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Get_Floor_Kpi_Data_By_Where> Get_Floor_Kpi_Data_By_Where_Async(Params_Get_Floor_Kpi_Data_By_Where i_Params_Get_Floor_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Get_Floor_Kpi_Data_By_Where>("/Api/KPIManagement/Get_Floor_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Floor_Kpi_Data_By_Where));
        }
        public Result_Compute_Floor_Kpi_Data_Weekly Compute_Floor_Kpi_Data_Weekly(Params_Compute_Floor_Kpi_Data_Weekly i_Params_Compute_Floor_Kpi_Data_Weekly)
        {
            return Compute_Floor_Kpi_Data_Weekly_Async(i_Params_Compute_Floor_Kpi_Data_Weekly).Result;
        }
        public async Task<Result_Compute_Floor_Kpi_Data_Weekly> Compute_Floor_Kpi_Data_Weekly_Async(Params_Compute_Floor_Kpi_Data_Weekly i_Params_Compute_Floor_Kpi_Data_Weekly)
        {
            return await Call_WebApi<Result_Compute_Floor_Kpi_Data_Weekly>("/Api/KPIManagement/Compute_Floor_Kpi_Data_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Floor_Kpi_Data_Weekly));
        }
        public Result_Update_Wifi_signal Update_Wifi_signal(Params_Update_Wifi_signal i_Params_Update_Wifi_signal)
        {
            return Update_Wifi_signal_Async(i_Params_Update_Wifi_signal).Result;
        }
        public async Task<Result_Update_Wifi_signal> Update_Wifi_signal_Async(Params_Update_Wifi_signal i_Params_Update_Wifi_signal)
        {
            return await Call_WebApi<Result_Update_Wifi_signal>("/Api/KPIManagement/Update_Wifi_signal", true, "POST", JsonConvert.SerializeObject(i_Params_Update_Wifi_signal));
        }
        public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID Get_Organization_data_source_kpi_By_ORGANIZATION_ID(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            return Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Async(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID>("/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Get_Visitor_Origins Get_Visitor_Origins(Params_Get_Visitor_Origins i_Params_Get_Visitor_Origins)
        {
            return Get_Visitor_Origins_Async(i_Params_Get_Visitor_Origins).Result;
        }
        public async Task<Result_Get_Visitor_Origins> Get_Visitor_Origins_Async(Params_Get_Visitor_Origins i_Params_Get_Visitor_Origins)
        {
            return await Call_WebApi<Result_Get_Visitor_Origins>("/Api/KPIManagement/Get_Visitor_Origins", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Visitor_Origins));
        }
        public Result_Compute_Site_Kpi_Data_Daily Compute_Site_Kpi_Data_Daily(Params_Compute_Site_Kpi_Data_Daily i_Params_Compute_Site_Kpi_Data_Daily)
        {
            return Compute_Site_Kpi_Data_Daily_Async(i_Params_Compute_Site_Kpi_Data_Daily).Result;
        }
        public async Task<Result_Compute_Site_Kpi_Data_Daily> Compute_Site_Kpi_Data_Daily_Async(Params_Compute_Site_Kpi_Data_Daily i_Params_Compute_Site_Kpi_Data_Daily)
        {
            return await Call_WebApi<Result_Compute_Site_Kpi_Data_Daily>("/Api/KPIManagement/Compute_Site_Kpi_Data_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Site_Kpi_Data_Daily));
        }
        public Result_Compute_District_Kpi_Data_Daily Compute_District_Kpi_Data_Daily(Params_Compute_District_Kpi_Data_Daily i_Params_Compute_District_Kpi_Data_Daily)
        {
            return Compute_District_Kpi_Data_Daily_Async(i_Params_Compute_District_Kpi_Data_Daily).Result;
        }
        public async Task<Result_Compute_District_Kpi_Data_Daily> Compute_District_Kpi_Data_Daily_Async(Params_Compute_District_Kpi_Data_Daily i_Params_Compute_District_Kpi_Data_Daily)
        {
            return await Call_WebApi<Result_Compute_District_Kpi_Data_Daily>("/Api/KPIManagement/Compute_District_Kpi_Data_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_District_Kpi_Data_Daily));
        }
        public Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly Compute_Wifi_Signal_Space_Kpi_Data_Hourly(Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly)
        {
            return Compute_Wifi_Signal_Space_Kpi_Data_Hourly_Async(i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly).Result;
        }
        public async Task<Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly> Compute_Wifi_Signal_Space_Kpi_Data_Hourly_Async(Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly)
        {
            return await Call_WebApi<Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly>("/Api/KPIManagement/Compute_Wifi_Signal_Space_Kpi_Data_Hourly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly));
        }
        public Result_Get_Latest_Wifi_signals Get_Latest_Wifi_signals(Params_Get_Latest_Wifi_signals i_Params_Get_Latest_Wifi_signals)
        {
            return Get_Latest_Wifi_signals_Async(i_Params_Get_Latest_Wifi_signals).Result;
        }
        public async Task<Result_Get_Latest_Wifi_signals> Get_Latest_Wifi_signals_Async(Params_Get_Latest_Wifi_signals i_Params_Get_Latest_Wifi_signals)
        {
            return await Call_WebApi<Result_Get_Latest_Wifi_signals>("/Api/KPIManagement/Get_Latest_Wifi_signals", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Latest_Wifi_signals));
        }
        public Result_Get_Alerts_By_Where_Count Get_Alerts_By_Where_Count(Params_Get_Alerts_By_Where_Count i_Params_Get_Alerts_By_Where_Count)
        {
            return Get_Alerts_By_Where_Count_Async(i_Params_Get_Alerts_By_Where_Count).Result;
        }
        public async Task<Result_Get_Alerts_By_Where_Count> Get_Alerts_By_Where_Count_Async(Params_Get_Alerts_By_Where_Count i_Params_Get_Alerts_By_Where_Count)
        {
            return await Call_WebApi<Result_Get_Alerts_By_Where_Count>("/Api/KPIManagement/Get_Alerts_By_Where_Count", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Alerts_By_Where_Count));
        }
        public Result_Get_Entity_Incidents Get_Entity_Incidents(Params_Get_Entity_Incidents i_Params_Get_Entity_Incidents)
        {
            return Get_Entity_Incidents_Async(i_Params_Get_Entity_Incidents).Result;
        }
        public async Task<Result_Get_Entity_Incidents> Get_Entity_Incidents_Async(Params_Get_Entity_Incidents i_Params_Get_Entity_Incidents)
        {
            return await Call_WebApi<Result_Get_Entity_Incidents>("/Api/KPIManagement/Get_Entity_Incidents", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_Incidents));
        }
        public Result_Get_Bylaw_Complaints_Trendline Get_Bylaw_Complaints_Trendline(Params_Get_Bylaw_Complaints_Trendline i_Params_Get_Bylaw_Complaints_Trendline)
        {
            return Get_Bylaw_Complaints_Trendline_Async(i_Params_Get_Bylaw_Complaints_Trendline).Result;
        }
        public async Task<Result_Get_Bylaw_Complaints_Trendline> Get_Bylaw_Complaints_Trendline_Async(Params_Get_Bylaw_Complaints_Trendline i_Params_Get_Bylaw_Complaints_Trendline)
        {
            return await Call_WebApi<Result_Get_Bylaw_Complaints_Trendline>("/Api/KPIManagement/Get_Bylaw_Complaints_Trendline", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Bylaw_Complaints_Trendline));
        }
        public Result_Get_Alerts_For_Levels Get_Alerts_For_Levels(Params_Get_Alerts_For_Levels i_Params_Get_Alerts_For_Levels)
        {
            return Get_Alerts_For_Levels_Async(i_Params_Get_Alerts_For_Levels).Result;
        }
        public async Task<Result_Get_Alerts_For_Levels> Get_Alerts_For_Levels_Async(Params_Get_Alerts_For_Levels i_Params_Get_Alerts_For_Levels)
        {
            return await Call_WebApi<Result_Get_Alerts_For_Levels>("/Api/KPIManagement/Get_Alerts_For_Levels", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Alerts_For_Levels));
        }
        public Result_Compute_Space_Kpi_Data_Weekly Compute_Space_Kpi_Data_Weekly(Params_Compute_Space_Kpi_Data_Weekly i_Params_Compute_Space_Kpi_Data_Weekly)
        {
            return Compute_Space_Kpi_Data_Weekly_Async(i_Params_Compute_Space_Kpi_Data_Weekly).Result;
        }
        public async Task<Result_Compute_Space_Kpi_Data_Weekly> Compute_Space_Kpi_Data_Weekly_Async(Params_Compute_Space_Kpi_Data_Weekly i_Params_Compute_Space_Kpi_Data_Weekly)
        {
            return await Call_WebApi<Result_Compute_Space_Kpi_Data_Weekly>("/Api/KPIManagement/Compute_Space_Kpi_Data_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Space_Kpi_Data_Weekly));
        }
        public Result_Get_Area_Kpi_Data_By_Where Get_Area_Kpi_Data_By_Where(Params_Get_Area_Kpi_Data_By_Where i_Params_Get_Area_Kpi_Data_By_Where)
        {
            return Get_Area_Kpi_Data_By_Where_Async(i_Params_Get_Area_Kpi_Data_By_Where).Result;
        }
        public async Task<Result_Get_Area_Kpi_Data_By_Where> Get_Area_Kpi_Data_By_Where_Async(Params_Get_Area_Kpi_Data_By_Where i_Params_Get_Area_Kpi_Data_By_Where)
        {
            return await Call_WebApi<Result_Get_Area_Kpi_Data_By_Where>("/Api/KPIManagement/Get_Area_Kpi_Data_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Area_Kpi_Data_By_Where));
        }
        public Result_Compute_Site_Kpi_Data_Monthly Compute_Site_Kpi_Data_Monthly(Params_Compute_Site_Kpi_Data_Monthly i_Params_Compute_Site_Kpi_Data_Monthly)
        {
            return Compute_Site_Kpi_Data_Monthly_Async(i_Params_Compute_Site_Kpi_Data_Monthly).Result;
        }
        public async Task<Result_Compute_Site_Kpi_Data_Monthly> Compute_Site_Kpi_Data_Monthly_Async(Params_Compute_Site_Kpi_Data_Monthly i_Params_Compute_Site_Kpi_Data_Monthly)
        {
            return await Call_WebApi<Result_Compute_Site_Kpi_Data_Monthly>("/Api/KPIManagement/Compute_Site_Kpi_Data_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Site_Kpi_Data_Monthly));
        }
        public Result_Compute_District_Kpi_Data_Hourly Compute_District_Kpi_Data_Hourly(Params_Compute_District_Kpi_Data_Hourly i_Params_Compute_District_Kpi_Data_Hourly)
        {
            return Compute_District_Kpi_Data_Hourly_Async(i_Params_Compute_District_Kpi_Data_Hourly).Result;
        }
        public async Task<Result_Compute_District_Kpi_Data_Hourly> Compute_District_Kpi_Data_Hourly_Async(Params_Compute_District_Kpi_Data_Hourly i_Params_Compute_District_Kpi_Data_Hourly)
        {
            return await Call_WebApi<Result_Compute_District_Kpi_Data_Hourly>("/Api/KPIManagement/Compute_District_Kpi_Data_Hourly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_District_Kpi_Data_Hourly));
        }
        public Result_Get_Intersection_Kpi_Dialog_Data Get_Intersection_Kpi_Dialog_Data(Params_Get_Intersection_Kpi_Dialog_Data i_Params_Get_Intersection_Kpi_Dialog_Data)
        {
            return Get_Intersection_Kpi_Dialog_Data_Async(i_Params_Get_Intersection_Kpi_Dialog_Data).Result;
        }
        public async Task<Result_Get_Intersection_Kpi_Dialog_Data> Get_Intersection_Kpi_Dialog_Data_Async(Params_Get_Intersection_Kpi_Dialog_Data i_Params_Get_Intersection_Kpi_Dialog_Data)
        {
            return await Call_WebApi<Result_Get_Intersection_Kpi_Dialog_Data>("/Api/KPIManagement/Get_Intersection_Kpi_Dialog_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Intersection_Kpi_Dialog_Data));
        }
        public Result_Compute_Floor_Kpi_Data_Daily Compute_Floor_Kpi_Data_Daily(Params_Compute_Floor_Kpi_Data_Daily i_Params_Compute_Floor_Kpi_Data_Daily)
        {
            return Compute_Floor_Kpi_Data_Daily_Async(i_Params_Compute_Floor_Kpi_Data_Daily).Result;
        }
        public async Task<Result_Compute_Floor_Kpi_Data_Daily> Compute_Floor_Kpi_Data_Daily_Async(Params_Compute_Floor_Kpi_Data_Daily i_Params_Compute_Floor_Kpi_Data_Daily)
        {
            return await Call_WebApi<Result_Compute_Floor_Kpi_Data_Daily>("/Api/KPIManagement/Compute_Floor_Kpi_Data_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Floor_Kpi_Data_Daily));
        }
        public Result_Get_Strongest_Wifi_signal Get_Strongest_Wifi_signal(Params_Get_Strongest_Wifi_signal i_Params_Get_Strongest_Wifi_signal)
        {
            return Get_Strongest_Wifi_signal_Async(i_Params_Get_Strongest_Wifi_signal).Result;
        }
        public async Task<Result_Get_Strongest_Wifi_signal> Get_Strongest_Wifi_signal_Async(Params_Get_Strongest_Wifi_signal i_Params_Get_Strongest_Wifi_signal)
        {
            return await Call_WebApi<Result_Get_Strongest_Wifi_signal>("/Api/KPIManagement/Get_Strongest_Wifi_signal", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Strongest_Wifi_signal));
        }
        public Result_Compute_Area_Kpi_Data_Monthly Compute_Area_Kpi_Data_Monthly(Params_Compute_Area_Kpi_Data_Monthly i_Params_Compute_Area_Kpi_Data_Monthly)
        {
            return Compute_Area_Kpi_Data_Monthly_Async(i_Params_Compute_Area_Kpi_Data_Monthly).Result;
        }
        public async Task<Result_Compute_Area_Kpi_Data_Monthly> Compute_Area_Kpi_Data_Monthly_Async(Params_Compute_Area_Kpi_Data_Monthly i_Params_Compute_Area_Kpi_Data_Monthly)
        {
            return await Call_WebApi<Result_Compute_Area_Kpi_Data_Monthly>("/Api/KPIManagement/Compute_Area_Kpi_Data_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Area_Kpi_Data_Monthly));
        }
        public Result_Get_Business_List Get_Business_List(Params_Get_Business_List i_Params_Get_Business_List)
        {
            return Get_Business_List_Async(i_Params_Get_Business_List).Result;
        }
        public async Task<Result_Get_Business_List> Get_Business_List_Async(Params_Get_Business_List i_Params_Get_Business_List)
        {
            return await Call_WebApi<Result_Get_Business_List>("/Api/KPIManagement/Get_Business_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Business_List));
        }
        public Result_Edit_Organization_Data_Access Edit_Organization_Data_Access(Params_Edit_Organization_Data_Access i_Params_Edit_Organization_Data_Access)
        {
            return Edit_Organization_Data_Access_Async(i_Params_Edit_Organization_Data_Access).Result;
        }
        public async Task<Result_Edit_Organization_Data_Access> Edit_Organization_Data_Access_Async(Params_Edit_Organization_Data_Access i_Params_Edit_Organization_Data_Access)
        {
            return await Call_WebApi<Result_Edit_Organization_Data_Access>("/Api/KPIManagement/Edit_Organization_Data_Access", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_Data_Access));
        }
        public Result_Edit_Kpi Edit_Kpi(Kpi i_Kpi)
        {
            return Edit_Kpi_Async(i_Kpi).Result;
        }
        public async Task<Result_Edit_Kpi> Edit_Kpi_Async(Kpi i_Kpi)
        {
            return await Call_WebApi<Result_Edit_Kpi>("/Api/KPIManagement/Edit_Kpi", true, "POST", JsonConvert.SerializeObject(i_Kpi));
        }
        public Result_Get_Entity_Kpi_Dialog_Data Get_Entity_Kpi_Dialog_Data(Params_Get_Entity_Kpi_Dialog_Data i_Params_Get_Entity_Kpi_Dialog_Data)
        {
            return Get_Entity_Kpi_Dialog_Data_Async(i_Params_Get_Entity_Kpi_Dialog_Data).Result;
        }
        public async Task<Result_Get_Entity_Kpi_Dialog_Data> Get_Entity_Kpi_Dialog_Data_Async(Params_Get_Entity_Kpi_Dialog_Data i_Params_Get_Entity_Kpi_Dialog_Data)
        {
            return await Call_WebApi<Result_Get_Entity_Kpi_Dialog_Data>("/Api/KPIManagement/Get_Entity_Kpi_Dialog_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_Kpi_Dialog_Data));
        }
        public Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID)
        {
            return Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID_Async(i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID).Result;
        }
        public async Task<Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID> Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID_Async(Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID>("/Api/KPIManagement/Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID));
        }
        public Result_Compute_Site_Kpi_Data_Weekly Compute_Site_Kpi_Data_Weekly(Params_Compute_Site_Kpi_Data_Weekly i_Params_Compute_Site_Kpi_Data_Weekly)
        {
            return Compute_Site_Kpi_Data_Weekly_Async(i_Params_Compute_Site_Kpi_Data_Weekly).Result;
        }
        public async Task<Result_Compute_Site_Kpi_Data_Weekly> Compute_Site_Kpi_Data_Weekly_Async(Params_Compute_Site_Kpi_Data_Weekly i_Params_Compute_Site_Kpi_Data_Weekly)
        {
            return await Call_WebApi<Result_Compute_Site_Kpi_Data_Weekly>("/Api/KPIManagement/Compute_Site_Kpi_Data_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Site_Kpi_Data_Weekly));
        }
        public Result_Get_Most_Wifi_signal_Count_Per_Space_asset Get_Most_Wifi_signal_Count_Per_Space_asset(Params_Get_Most_Wifi_signal_Count_Per_Space_asset i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset)
        {
            return Get_Most_Wifi_signal_Count_Per_Space_asset_Async(i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset).Result;
        }
        public async Task<Result_Get_Most_Wifi_signal_Count_Per_Space_asset> Get_Most_Wifi_signal_Count_Per_Space_asset_Async(Params_Get_Most_Wifi_signal_Count_Per_Space_asset i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset)
        {
            return await Call_WebApi<Result_Get_Most_Wifi_signal_Count_Per_Space_asset>("/Api/KPIManagement/Get_Most_Wifi_signal_Count_Per_Space_asset", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset));
        }
        public Result_Get_Public_Events_Trendline Get_Public_Events_Trendline(Params_Get_Public_Events_Trendline i_Params_Get_Public_Events_Trendline)
        {
            return Get_Public_Events_Trendline_Async(i_Params_Get_Public_Events_Trendline).Result;
        }
        public async Task<Result_Get_Public_Events_Trendline> Get_Public_Events_Trendline_Async(Params_Get_Public_Events_Trendline i_Params_Get_Public_Events_Trendline)
        {
            return await Call_WebApi<Result_Get_Public_Events_Trendline>("/Api/KPIManagement/Get_Public_Events_Trendline", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Public_Events_Trendline));
        }
        public Result_Get_User_By_ORGANIZATION_ID_List_Adv Get_User_By_ORGANIZATION_ID_List_Adv(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            return Get_User_By_ORGANIZATION_ID_List_Adv_Async(i_Params_Get_User_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_User_By_ORGANIZATION_ID_List_Adv> Get_User_By_ORGANIZATION_ID_List_Adv_Async(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_User_By_ORGANIZATION_ID_List_Adv>("/Api/KPIManagement/Get_User_By_ORGANIZATION_ID_List_Adv", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Get_User_By_ORGANIZATION_ID_List Get_User_By_ORGANIZATION_ID_List(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            return Get_User_By_ORGANIZATION_ID_List_Async(i_Params_Get_User_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_User_By_ORGANIZATION_ID_List> Get_User_By_ORGANIZATION_ID_List_Async(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_User_By_ORGANIZATION_ID_List>("/Api/KPIManagement/Get_User_By_ORGANIZATION_ID_List", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Edit_Top_level Edit_Top_level(Top_level i_Top_level)
        {
            return Edit_Top_level_Async(i_Top_level).Result;
        }
        public async Task<Result_Edit_Top_level> Edit_Top_level_Async(Top_level i_Top_level)
        {
            return await Call_WebApi<Result_Edit_Top_level>("/Api/TopLevelManagement/Edit_Top_level", true, "POST", JsonConvert.SerializeObject(i_Top_level));
        }
        public Result_Get_Top_level_By_TOP_LEVEL_ID_List Get_Top_level_By_TOP_LEVEL_ID_List(Params_Get_Top_level_By_TOP_LEVEL_ID_List i_Params_Get_Top_level_By_TOP_LEVEL_ID_List)
        {
            return Get_Top_level_By_TOP_LEVEL_ID_List_Async(i_Params_Get_Top_level_By_TOP_LEVEL_ID_List).Result;
        }
        public async Task<Result_Get_Top_level_By_TOP_LEVEL_ID_List> Get_Top_level_By_TOP_LEVEL_ID_List_Async(Params_Get_Top_level_By_TOP_LEVEL_ID_List i_Params_Get_Top_level_By_TOP_LEVEL_ID_List)
        {
            return await Call_WebApi<Result_Get_Top_level_By_TOP_LEVEL_ID_List>("/Api/TopLevelManagement/Get_Top_level_By_TOP_LEVEL_ID_List", true, "GET", $"?TOP_LEVEL_ID_LIST={(i_Params_Get_Top_level_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Top_level_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST))}");
        }
        public Result_Get_Top_level_By_OWNER_ID Get_Top_level_By_OWNER_ID(Params_Get_Top_level_By_OWNER_ID i_Params_Get_Top_level_By_OWNER_ID)
        {
            return Get_Top_level_By_OWNER_ID_Async(i_Params_Get_Top_level_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Top_level_By_OWNER_ID> Get_Top_level_By_OWNER_ID_Async(Params_Get_Top_level_By_OWNER_ID i_Params_Get_Top_level_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Top_level_By_OWNER_ID>("/Api/TopLevelManagement/Get_Top_level_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Top_level_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Entity_view Edit_Entity_view(Entity_view i_Entity_view)
        {
            return Edit_Entity_view_Async(i_Entity_view).Result;
        }
        public async Task<Result_Edit_Entity_view> Edit_Entity_view_Async(Entity_view i_Entity_view)
        {
            return await Call_WebApi<Result_Edit_Entity_view>("/Api/EntityManagement/Edit_Entity_view", true, "POST", JsonConvert.SerializeObject(i_Entity_view));
        }
        public Result_Get_Entity_view_By_ENTITY_ID Get_Entity_view_By_ENTITY_ID(Params_Get_Entity_view_By_ENTITY_ID i_Params_Get_Entity_view_By_ENTITY_ID)
        {
            return Get_Entity_view_By_ENTITY_ID_Async(i_Params_Get_Entity_view_By_ENTITY_ID).Result;
        }
        public async Task<Result_Get_Entity_view_By_ENTITY_ID> Get_Entity_view_By_ENTITY_ID_Async(Params_Get_Entity_view_By_ENTITY_ID i_Params_Get_Entity_view_By_ENTITY_ID)
        {
            return await Call_WebApi<Result_Get_Entity_view_By_ENTITY_ID>("/Api/EntityManagement/Get_Entity_view_By_ENTITY_ID", true, "GET", $"?ENTITY_ID={i_Params_Get_Entity_view_By_ENTITY_ID.ENTITY_ID}");
        }
        public Result_Delete_Entity_view Delete_Entity_view(Params_Delete_Entity_view i_Params_Delete_Entity_view)
        {
            return Delete_Entity_view_Async(i_Params_Delete_Entity_view).Result;
        }
        public async Task<Result_Delete_Entity_view> Delete_Entity_view_Async(Params_Delete_Entity_view i_Params_Delete_Entity_view)
        {
            return await Call_WebApi<Result_Delete_Entity_view>("/Api/EntityManagement/Delete_Entity_view", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Entity_view));
        }
        public Result_Get_Entity_By_SITE_ID Get_Entity_By_SITE_ID(Params_Get_Entity_By_SITE_ID i_Params_Get_Entity_By_SITE_ID)
        {
            return Get_Entity_By_SITE_ID_Async(i_Params_Get_Entity_By_SITE_ID).Result;
        }
        public async Task<Result_Get_Entity_By_SITE_ID> Get_Entity_By_SITE_ID_Async(Params_Get_Entity_By_SITE_ID i_Params_Get_Entity_By_SITE_ID)
        {
            return await Call_WebApi<Result_Get_Entity_By_SITE_ID>("/Api/EntityManagement/Get_Entity_By_SITE_ID", true, "GET", $"?SITE_ID={i_Params_Get_Entity_By_SITE_ID.SITE_ID}");
        }
        public Result_Get_Entity_By_ENTITY_ID_Adv Get_Entity_By_ENTITY_ID_Adv(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            return Get_Entity_By_ENTITY_ID_Adv_Async(i_Params_Get_Entity_By_ENTITY_ID).Result;
        }
        public async Task<Result_Get_Entity_By_ENTITY_ID_Adv> Get_Entity_By_ENTITY_ID_Adv_Async(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            return await Call_WebApi<Result_Get_Entity_By_ENTITY_ID_Adv>("/Api/EntityManagement/Get_Entity_By_ENTITY_ID_Adv", true, "GET", $"?ENTITY_ID={i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID}");
        }
        public Result_Get_Entity_By_ENTITY_ID Get_Entity_By_ENTITY_ID(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            return Get_Entity_By_ENTITY_ID_Async(i_Params_Get_Entity_By_ENTITY_ID).Result;
        }
        public async Task<Result_Get_Entity_By_ENTITY_ID> Get_Entity_By_ENTITY_ID_Async(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            return await Call_WebApi<Result_Get_Entity_By_ENTITY_ID>("/Api/EntityManagement/Get_Entity_By_ENTITY_ID", true, "GET", $"?ENTITY_ID={i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID}");
        }
        public Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID(Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID)
        {
            return Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Async(i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID).Result;
        }
        public async Task<Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID> Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Async(Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID)
        {
            return await Call_WebApi<Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID>("/Api/EntityManagement/Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID));
        }
        public Result_Get_Entity_By_ENTITY_ID_List Get_Entity_By_ENTITY_ID_List(Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            return Get_Entity_By_ENTITY_ID_List_Async(i_Params_Get_Entity_By_ENTITY_ID_List).Result;
        }
        public async Task<Result_Get_Entity_By_ENTITY_ID_List> Get_Entity_By_ENTITY_ID_List_Async(Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            return await Call_WebApi<Result_Get_Entity_By_ENTITY_ID_List>("/Api/EntityManagement/Get_Entity_By_ENTITY_ID_List", true, "GET", $"?ENTITY_ID_LIST={(i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST))}");
        }
        public Result_Get_Entity_By_OWNER_ID Get_Entity_By_OWNER_ID(Params_Get_Entity_By_OWNER_ID i_Params_Get_Entity_By_OWNER_ID)
        {
            return Get_Entity_By_OWNER_ID_Async(i_Params_Get_Entity_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Entity_By_OWNER_ID> Get_Entity_By_OWNER_ID_Async(Params_Get_Entity_By_OWNER_ID i_Params_Get_Entity_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Entity_By_OWNER_ID>("/Api/EntityManagement/Get_Entity_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Entity_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Entity Edit_Entity(Entity i_Entity)
        {
            return Edit_Entity_Async(i_Entity).Result;
        }
        public async Task<Result_Edit_Entity> Edit_Entity_Async(Entity i_Entity)
        {
            return await Call_WebApi<Result_Edit_Entity>("/Api/EntityManagement/Edit_Entity", true, "POST", JsonConvert.SerializeObject(i_Entity));
        }
        public Result_Edit_Entity_view_List Edit_Entity_view_List(Params_Edit_Entity_view_List i_Params_Edit_Entity_view_List)
        {
            return Edit_Entity_view_List_Async(i_Params_Edit_Entity_view_List).Result;
        }
        public async Task<Result_Edit_Entity_view_List> Edit_Entity_view_List_Async(Params_Edit_Entity_view_List i_Params_Edit_Entity_view_List)
        {
            return await Call_WebApi<Result_Edit_Entity_view_List>("/Api/EntityManagement/Edit_Entity_view_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Entity_view_List));
        }
        public Result_Delete_Entity_view_By_ENTITY_ID Delete_Entity_view_By_ENTITY_ID(Params_Delete_Entity_view_By_ENTITY_ID i_Params_Delete_Entity_view_By_ENTITY_ID)
        {
            return Delete_Entity_view_By_ENTITY_ID_Async(i_Params_Delete_Entity_view_By_ENTITY_ID).Result;
        }
        public async Task<Result_Delete_Entity_view_By_ENTITY_ID> Delete_Entity_view_By_ENTITY_ID_Async(Params_Delete_Entity_view_By_ENTITY_ID i_Params_Delete_Entity_view_By_ENTITY_ID)
        {
            return await Call_WebApi<Result_Delete_Entity_view_By_ENTITY_ID>("/Api/EntityManagement/Delete_Entity_view_By_ENTITY_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Entity_view_By_ENTITY_ID));
        }
        public Result_Get_Entity_view_By_ENTITY_ID_List Get_Entity_view_By_ENTITY_ID_List(Params_Get_Entity_view_By_ENTITY_ID_List i_Params_Get_Entity_view_By_ENTITY_ID_List)
        {
            return Get_Entity_view_By_ENTITY_ID_List_Async(i_Params_Get_Entity_view_By_ENTITY_ID_List).Result;
        }
        public async Task<Result_Get_Entity_view_By_ENTITY_ID_List> Get_Entity_view_By_ENTITY_ID_List_Async(Params_Get_Entity_view_By_ENTITY_ID_List i_Params_Get_Entity_view_By_ENTITY_ID_List)
        {
            return await Call_WebApi<Result_Get_Entity_view_By_ENTITY_ID_List>("/Api/EntityManagement/Get_Entity_view_By_ENTITY_ID_List", true, "GET", $"?ENTITY_ID_LIST={(i_Params_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST))}");
        }
        public Result_Edit_Region Edit_Region(Region i_Region)
        {
            return Edit_Region_Async(i_Region).Result;
        }
        public async Task<Result_Edit_Region> Edit_Region_Async(Region i_Region)
        {
            return await Call_WebApi<Result_Edit_Region>("/Api/RegionManagement/Edit_Region", true, "POST", JsonConvert.SerializeObject(i_Region));
        }
        public Result_Get_Region_By_OWNER_ID Get_Region_By_OWNER_ID(Params_Get_Region_By_OWNER_ID i_Params_Get_Region_By_OWNER_ID)
        {
            return Get_Region_By_OWNER_ID_Async(i_Params_Get_Region_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Region_By_OWNER_ID> Get_Region_By_OWNER_ID_Async(Params_Get_Region_By_OWNER_ID i_Params_Get_Region_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Region_By_OWNER_ID>("/Api/RegionManagement/Get_Region_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Region_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Region_view Edit_Region_view(Region_view i_Region_view)
        {
            return Edit_Region_view_Async(i_Region_view).Result;
        }
        public async Task<Result_Edit_Region_view> Edit_Region_view_Async(Region_view i_Region_view)
        {
            return await Call_WebApi<Result_Edit_Region_view>("/Api/RegionManagement/Edit_Region_view", true, "POST", JsonConvert.SerializeObject(i_Region_view));
        }
        public Result_Delete_Region_view Delete_Region_view(Params_Delete_Region_view i_Params_Delete_Region_view)
        {
            return Delete_Region_view_Async(i_Params_Delete_Region_view).Result;
        }
        public async Task<Result_Delete_Region_view> Delete_Region_view_Async(Params_Delete_Region_view i_Params_Delete_Region_view)
        {
            return await Call_WebApi<Result_Delete_Region_view>("/Api/RegionManagement/Delete_Region_view", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Region_view));
        }
        public Result_Get_Region_view_By_REGION_ID Get_Region_view_By_REGION_ID(Params_Get_Region_view_By_REGION_ID i_Params_Get_Region_view_By_REGION_ID)
        {
            return Get_Region_view_By_REGION_ID_Async(i_Params_Get_Region_view_By_REGION_ID).Result;
        }
        public async Task<Result_Get_Region_view_By_REGION_ID> Get_Region_view_By_REGION_ID_Async(Params_Get_Region_view_By_REGION_ID i_Params_Get_Region_view_By_REGION_ID)
        {
            return await Call_WebApi<Result_Get_Region_view_By_REGION_ID>("/Api/RegionManagement/Get_Region_view_By_REGION_ID", true, "GET", $"?REGION_ID={i_Params_Get_Region_view_By_REGION_ID.REGION_ID}");
        }
        public Result_Get_Floor_By_ENTITY_ID Get_Floor_By_ENTITY_ID(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            return Get_Floor_By_ENTITY_ID_Async(i_Params_Get_Floor_By_ENTITY_ID).Result;
        }
        public async Task<Result_Get_Floor_By_ENTITY_ID> Get_Floor_By_ENTITY_ID_Async(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            return await Call_WebApi<Result_Get_Floor_By_ENTITY_ID>("/Api/FloorManagement/Get_Floor_By_ENTITY_ID", true, "GET", $"?ENTITY_ID={i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID}");
        }
        public Result_Get_Floor_By_ENTITY_ID_With_Space_Asset Get_Floor_By_ENTITY_ID_With_Space_Asset(Params_Get_Floor_By_ENTITY_ID_With_Space_Asset i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset)
        {
            return Get_Floor_By_ENTITY_ID_With_Space_Asset_Async(i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset).Result;
        }
        public async Task<Result_Get_Floor_By_ENTITY_ID_With_Space_Asset> Get_Floor_By_ENTITY_ID_With_Space_Asset_Async(Params_Get_Floor_By_ENTITY_ID_With_Space_Asset i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset)
        {
            return await Call_WebApi<Result_Get_Floor_By_ENTITY_ID_With_Space_Asset>("/Api/FloorManagement/Get_Floor_By_ENTITY_ID_With_Space_Asset", true, "GET", $"?ENTITY_ID={i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset.ENTITY_ID}");
        }
        public Result_Get_Floor_By_OWNER_ID Get_Floor_By_OWNER_ID(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            return Get_Floor_By_OWNER_ID_Async(i_Params_Get_Floor_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Floor_By_OWNER_ID> Get_Floor_By_OWNER_ID_Async(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Floor_By_OWNER_ID>("/Api/FloorManagement/Get_Floor_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Floor_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Floor Edit_Floor(Floor i_Floor)
        {
            return Edit_Floor_Async(i_Floor).Result;
        }
        public async Task<Result_Edit_Floor> Edit_Floor_Async(Floor i_Floor)
        {
            return await Call_WebApi<Result_Edit_Floor>("/Api/FloorManagement/Edit_Floor", true, "POST", JsonConvert.SerializeObject(i_Floor));
        }
        public Result_Get_Floor_By_ENTITY_ID_Adv Get_Floor_By_ENTITY_ID_Adv(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            return Get_Floor_By_ENTITY_ID_Adv_Async(i_Params_Get_Floor_By_ENTITY_ID).Result;
        }
        public async Task<Result_Get_Floor_By_ENTITY_ID_Adv> Get_Floor_By_ENTITY_ID_Adv_Async(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            return await Call_WebApi<Result_Get_Floor_By_ENTITY_ID_Adv>("/Api/FloorManagement/Get_Floor_By_ENTITY_ID_Adv", true, "GET", $"?ENTITY_ID={i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID}");
        }
        public Result_Get_Logs_With_Filters Get_Logs_With_Filters(Params_Get_Logs_With_Filters i_Params_Get_Logs_With_Filters)
        {
            return Get_Logs_With_Filters_Async(i_Params_Get_Logs_With_Filters).Result;
        }
        public async Task<Result_Get_Logs_With_Filters> Get_Logs_With_Filters_Async(Params_Get_Logs_With_Filters i_Params_Get_Logs_With_Filters)
        {
            return await Call_WebApi<Result_Get_Logs_With_Filters>("/Api/PlatformLogging/Get_Logs_With_Filters", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Logs_With_Filters));
        }
        public Result_Generate_Logs_Excel Generate_Logs_Excel(Params_Generate_Logs_Excel i_Params_Generate_Logs_Excel)
        {
            return Generate_Logs_Excel_Async(i_Params_Generate_Logs_Excel).Result;
        }
        public async Task<Result_Generate_Logs_Excel> Generate_Logs_Excel_Async(Params_Generate_Logs_Excel i_Params_Generate_Logs_Excel)
        {
            return await Call_WebApi<Result_Generate_Logs_Excel>("/Api/PlatformLogging/Generate_Logs_Excel", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Logs_Excel));
        }
        public Result_Get_Latest_Dimension_index_By_Where Get_Latest_Dimension_index_By_Where(Params_Get_Latest_Dimension_index_By_Where i_Params_Get_Latest_Dimension_index_By_Where)
        {
            return Get_Latest_Dimension_index_By_Where_Async(i_Params_Get_Latest_Dimension_index_By_Where).Result;
        }
        public async Task<Result_Get_Latest_Dimension_index_By_Where> Get_Latest_Dimension_index_By_Where_Async(Params_Get_Latest_Dimension_index_By_Where i_Params_Get_Latest_Dimension_index_By_Where)
        {
            return await Call_WebApi<Result_Get_Latest_Dimension_index_By_Where>("/Api/DimensionManagement/Get_Latest_Dimension_index_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Latest_Dimension_index_By_Where));
        }
        public Result_Get_Dimension_By_DIMENSION_ORDER_List Get_Dimension_By_DIMENSION_ORDER_List(Params_Get_Dimension_By_DIMENSION_ORDER_List i_Params_Get_Dimension_By_DIMENSION_ORDER_List)
        {
            return Get_Dimension_By_DIMENSION_ORDER_List_Async(i_Params_Get_Dimension_By_DIMENSION_ORDER_List).Result;
        }
        public async Task<Result_Get_Dimension_By_DIMENSION_ORDER_List> Get_Dimension_By_DIMENSION_ORDER_List_Async(Params_Get_Dimension_By_DIMENSION_ORDER_List i_Params_Get_Dimension_By_DIMENSION_ORDER_List)
        {
            return await Call_WebApi<Result_Get_Dimension_By_DIMENSION_ORDER_List>("/Api/DimensionManagement/Get_Dimension_By_DIMENSION_ORDER_List", true, "GET", $"?DIMENSION_ORDER_LIST={(i_Params_Get_Dimension_By_DIMENSION_ORDER_List.DIMENSION_ORDER_LIST == null ? "" : string.Join(",", i_Params_Get_Dimension_By_DIMENSION_ORDER_List.DIMENSION_ORDER_LIST))}");
        }
        public Result_Edit_Dimension_List Edit_Dimension_List(Params_Edit_Dimension_List i_Params_Edit_Dimension_List)
        {
            return Edit_Dimension_List_Async(i_Params_Edit_Dimension_List).Result;
        }
        public async Task<Result_Edit_Dimension_List> Edit_Dimension_List_Async(Params_Edit_Dimension_List i_Params_Edit_Dimension_List)
        {
            return await Call_WebApi<Result_Edit_Dimension_List>("/Api/DimensionManagement/Edit_Dimension_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Dimension_List));
        }
        public Result_Get_Dimension_By_DIMENSION_ID_List Get_Dimension_By_DIMENSION_ID_List(Params_Get_Dimension_By_DIMENSION_ID_List i_Params_Get_Dimension_By_DIMENSION_ID_List)
        {
            return Get_Dimension_By_DIMENSION_ID_List_Async(i_Params_Get_Dimension_By_DIMENSION_ID_List).Result;
        }
        public async Task<Result_Get_Dimension_By_DIMENSION_ID_List> Get_Dimension_By_DIMENSION_ID_List_Async(Params_Get_Dimension_By_DIMENSION_ID_List i_Params_Get_Dimension_By_DIMENSION_ID_List)
        {
            return await Call_WebApi<Result_Get_Dimension_By_DIMENSION_ID_List>("/Api/DimensionManagement/Get_Dimension_By_DIMENSION_ID_List", true, "GET", $"?DIMENSION_ID_LIST={(i_Params_Get_Dimension_By_DIMENSION_ID_List.DIMENSION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Dimension_By_DIMENSION_ID_List.DIMENSION_ID_LIST))}");
        }
        public Result_Get_Dimension_By_DIMENSION_ID Get_Dimension_By_DIMENSION_ID(Params_Get_Dimension_By_DIMENSION_ID i_Params_Get_Dimension_By_DIMENSION_ID)
        {
            return Get_Dimension_By_DIMENSION_ID_Async(i_Params_Get_Dimension_By_DIMENSION_ID).Result;
        }
        public async Task<Result_Get_Dimension_By_DIMENSION_ID> Get_Dimension_By_DIMENSION_ID_Async(Params_Get_Dimension_By_DIMENSION_ID i_Params_Get_Dimension_By_DIMENSION_ID)
        {
            return await Call_WebApi<Result_Get_Dimension_By_DIMENSION_ID>("/Api/DimensionManagement/Get_Dimension_By_DIMENSION_ID", true, "GET", $"?DIMENSION_ID={i_Params_Get_Dimension_By_DIMENSION_ID.DIMENSION_ID}");
        }
        public Result_Compute_Dimension_Index_Monthly Compute_Dimension_Index_Monthly(Params_Compute_Dimension_Index_Monthly i_Params_Compute_Dimension_Index_Monthly)
        {
            return Compute_Dimension_Index_Monthly_Async(i_Params_Compute_Dimension_Index_Monthly).Result;
        }
        public async Task<Result_Compute_Dimension_Index_Monthly> Compute_Dimension_Index_Monthly_Async(Params_Compute_Dimension_Index_Monthly i_Params_Compute_Dimension_Index_Monthly)
        {
            return await Call_WebApi<Result_Compute_Dimension_Index_Monthly>("/Api/DimensionManagement/Compute_Dimension_Index_Monthly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Dimension_Index_Monthly));
        }
        public Result_Insert_Dimension_index_List Insert_Dimension_index_List(Params_Insert_Dimension_index_List i_Params_Insert_Dimension_index_List)
        {
            return Insert_Dimension_index_List_Async(i_Params_Insert_Dimension_index_List).Result;
        }
        public async Task<Result_Insert_Dimension_index_List> Insert_Dimension_index_List_Async(Params_Insert_Dimension_index_List i_Params_Insert_Dimension_index_List)
        {
            return await Call_WebApi<Result_Insert_Dimension_index_List>("/Api/DimensionManagement/Insert_Dimension_index_List", true, "POST", JsonConvert.SerializeObject(i_Params_Insert_Dimension_index_List));
        }
        public Result_Compute_Dimension_Index_Weekly Compute_Dimension_Index_Weekly(Params_Compute_Dimension_Index_Weekly i_Params_Compute_Dimension_Index_Weekly)
        {
            return Compute_Dimension_Index_Weekly_Async(i_Params_Compute_Dimension_Index_Weekly).Result;
        }
        public async Task<Result_Compute_Dimension_Index_Weekly> Compute_Dimension_Index_Weekly_Async(Params_Compute_Dimension_Index_Weekly i_Params_Compute_Dimension_Index_Weekly)
        {
            return await Call_WebApi<Result_Compute_Dimension_Index_Weekly>("/Api/DimensionManagement/Compute_Dimension_Index_Weekly", true, "POST", JsonConvert.SerializeObject(i_Params_Compute_Dimension_Index_Weekly));
        }
        public Result_Get_Dimension_By_OWNER_ID Get_Dimension_By_OWNER_ID(Params_Get_Dimension_By_OWNER_ID i_Params_Get_Dimension_By_OWNER_ID)
        {
            return Get_Dimension_By_OWNER_ID_Async(i_Params_Get_Dimension_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Dimension_By_OWNER_ID> Get_Dimension_By_OWNER_ID_Async(Params_Get_Dimension_By_OWNER_ID i_Params_Get_Dimension_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Dimension_By_OWNER_ID>("/Api/DimensionManagement/Get_Dimension_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Dimension_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Dimension_index_By_Where Get_Dimension_index_By_Where(Params_Get_Dimension_index_By_Where i_Params_Get_Dimension_index_By_Where)
        {
            return Get_Dimension_index_By_Where_Async(i_Params_Get_Dimension_index_By_Where).Result;
        }
        public async Task<Result_Get_Dimension_index_By_Where> Get_Dimension_index_By_Where_Async(Params_Get_Dimension_index_By_Where i_Params_Get_Dimension_index_By_Where)
        {
            return await Call_WebApi<Result_Get_Dimension_index_By_Where>("/Api/DimensionManagement/Get_Dimension_index_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Dimension_index_By_Where));
        }
        public Result_Generate_Dimension_Index_Daily Generate_Dimension_Index_Daily(Params_Generate_Dimension_Index_Daily i_Params_Generate_Dimension_Index_Daily)
        {
            return Generate_Dimension_Index_Daily_Async(i_Params_Generate_Dimension_Index_Daily).Result;
        }
        public async Task<Result_Generate_Dimension_Index_Daily> Generate_Dimension_Index_Daily_Async(Params_Generate_Dimension_Index_Daily i_Params_Generate_Dimension_Index_Daily)
        {
            return await Call_WebApi<Result_Generate_Dimension_Index_Daily>("/Api/DimensionManagement/Generate_Dimension_Index_Daily", true, "POST", JsonConvert.SerializeObject(i_Params_Generate_Dimension_Index_Daily));
        }
        public Result_Delete_Dimension_index_By_Where Delete_Dimension_index_By_Where(Params_Delete_Dimension_index_By_Where i_Params_Delete_Dimension_index_By_Where)
        {
            return Delete_Dimension_index_By_Where_Async(i_Params_Delete_Dimension_index_By_Where).Result;
        }
        public async Task<Result_Delete_Dimension_index_By_Where> Delete_Dimension_index_By_Where_Async(Params_Delete_Dimension_index_By_Where i_Params_Delete_Dimension_index_By_Where)
        {
            return await Call_WebApi<Result_Delete_Dimension_index_By_Where>("/Api/DimensionManagement/Delete_Dimension_index_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Dimension_index_By_Where));
        }
        public Result_Edit_Site_view Edit_Site_view(Site_view i_Site_view)
        {
            return Edit_Site_view_Async(i_Site_view).Result;
        }
        public async Task<Result_Edit_Site_view> Edit_Site_view_Async(Site_view i_Site_view)
        {
            return await Call_WebApi<Result_Edit_Site_view>("/Api/SiteManagement/Edit_Site_view", true, "POST", JsonConvert.SerializeObject(i_Site_view));
        }
        public Result_Get_Site_By_OWNER_ID_Adv Get_Site_By_OWNER_ID_Adv(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            return Get_Site_By_OWNER_ID_Adv_Async(i_Params_Get_Site_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Site_By_OWNER_ID_Adv> Get_Site_By_OWNER_ID_Adv_Async(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Site_By_OWNER_ID_Adv>("/Api/SiteManagement/Get_Site_By_OWNER_ID_Adv", true, "GET", $"?OWNER_ID={i_Params_Get_Site_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Site Edit_Site(Site i_Site)
        {
            return Edit_Site_Async(i_Site).Result;
        }
        public async Task<Result_Edit_Site> Edit_Site_Async(Site i_Site)
        {
            return await Call_WebApi<Result_Edit_Site>("/Api/SiteManagement/Edit_Site", true, "POST", JsonConvert.SerializeObject(i_Site));
        }
        public Result_Get_Site_By_SITE_ID_List_Adv Get_Site_By_SITE_ID_List_Adv(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            return Get_Site_By_SITE_ID_List_Adv_Async(i_Params_Get_Site_By_SITE_ID_List).Result;
        }
        public async Task<Result_Get_Site_By_SITE_ID_List_Adv> Get_Site_By_SITE_ID_List_Adv_Async(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            return await Call_WebApi<Result_Get_Site_By_SITE_ID_List_Adv>("/Api/SiteManagement/Get_Site_By_SITE_ID_List_Adv", true, "GET", $"?SITE_ID_LIST={(i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST))}");
        }
        public Result_Get_Site_By_SITE_ID_List Get_Site_By_SITE_ID_List(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            return Get_Site_By_SITE_ID_List_Async(i_Params_Get_Site_By_SITE_ID_List).Result;
        }
        public async Task<Result_Get_Site_By_SITE_ID_List> Get_Site_By_SITE_ID_List_Async(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            return await Call_WebApi<Result_Get_Site_By_SITE_ID_List>("/Api/SiteManagement/Get_Site_By_SITE_ID_List", true, "GET", $"?SITE_ID_LIST={(i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST))}");
        }
        public Result_Get_Ext_study_zone_By_OWNER_ID Get_Ext_study_zone_By_OWNER_ID(Params_Get_Ext_study_zone_By_OWNER_ID i_Params_Get_Ext_study_zone_By_OWNER_ID)
        {
            return Get_Ext_study_zone_By_OWNER_ID_Async(i_Params_Get_Ext_study_zone_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Ext_study_zone_By_OWNER_ID> Get_Ext_study_zone_By_OWNER_ID_Async(Params_Get_Ext_study_zone_By_OWNER_ID i_Params_Get_Ext_study_zone_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Ext_study_zone_By_OWNER_ID>("/Api/SiteManagement/Get_Ext_study_zone_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Ext_study_zone_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Delete_Site_view Delete_Site_view(Params_Delete_Site_view i_Params_Delete_Site_view)
        {
            return Delete_Site_view_Async(i_Params_Delete_Site_view).Result;
        }
        public async Task<Result_Delete_Site_view> Delete_Site_view_Async(Params_Delete_Site_view i_Params_Delete_Site_view)
        {
            return await Call_WebApi<Result_Delete_Site_view>("/Api/SiteManagement/Delete_Site_view", true, "DELETE", "/" + i_Params_Delete_Site_view.SITE_VIEW_ID);
        }
        public Result_Get_Site_By_SITE_ID Get_Site_By_SITE_ID(Params_Get_Site_By_SITE_ID i_Params_Get_Site_By_SITE_ID)
        {
            return Get_Site_By_SITE_ID_Async(i_Params_Get_Site_By_SITE_ID).Result;
        }
        public async Task<Result_Get_Site_By_SITE_ID> Get_Site_By_SITE_ID_Async(Params_Get_Site_By_SITE_ID i_Params_Get_Site_By_SITE_ID)
        {
            return await Call_WebApi<Result_Get_Site_By_SITE_ID>("/Api/SiteManagement/Get_Site_By_SITE_ID", true, "GET", $"?SITE_ID={i_Params_Get_Site_By_SITE_ID.SITE_ID}");
        }
        public Result_Get_Site_By_OWNER_ID Get_Site_By_OWNER_ID(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            return Get_Site_By_OWNER_ID_Async(i_Params_Get_Site_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Site_By_OWNER_ID> Get_Site_By_OWNER_ID_Async(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Site_By_OWNER_ID>("/Api/SiteManagement/Get_Site_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Site_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Site_geojson_By_SITE_ID_List Get_Site_geojson_By_SITE_ID_List(Params_Get_Site_geojson_By_SITE_ID_List i_Params_Get_Site_geojson_By_SITE_ID_List)
        {
            return Get_Site_geojson_By_SITE_ID_List_Async(i_Params_Get_Site_geojson_By_SITE_ID_List).Result;
        }
        public async Task<Result_Get_Site_geojson_By_SITE_ID_List> Get_Site_geojson_By_SITE_ID_List_Async(Params_Get_Site_geojson_By_SITE_ID_List i_Params_Get_Site_geojson_By_SITE_ID_List)
        {
            return await Call_WebApi<Result_Get_Site_geojson_By_SITE_ID_List>("/Api/SiteManagement/Get_Site_geojson_By_SITE_ID_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Site_geojson_By_SITE_ID_List));
        }
        public Result_Get_Site_view_By_SITE_ID Get_Site_view_By_SITE_ID(Params_Get_Site_view_By_SITE_ID i_Params_Get_Site_view_By_SITE_ID)
        {
            return Get_Site_view_By_SITE_ID_Async(i_Params_Get_Site_view_By_SITE_ID).Result;
        }
        public async Task<Result_Get_Site_view_By_SITE_ID> Get_Site_view_By_SITE_ID_Async(Params_Get_Site_view_By_SITE_ID i_Params_Get_Site_view_By_SITE_ID)
        {
            return await Call_WebApi<Result_Get_Site_view_By_SITE_ID>("/Api/SiteManagement/Get_Site_view_By_SITE_ID", true, "GET", $"?SITE_ID={i_Params_Get_Site_view_By_SITE_ID.SITE_ID}");
        }
        public Result_Edit_Ext_study_zone_List Edit_Ext_study_zone_List(Params_Edit_Ext_study_zone_List i_Params_Edit_Ext_study_zone_List)
        {
            return Edit_Ext_study_zone_List_Async(i_Params_Edit_Ext_study_zone_List).Result;
        }
        public async Task<Result_Edit_Ext_study_zone_List> Edit_Ext_study_zone_List_Async(Params_Edit_Ext_study_zone_List i_Params_Edit_Ext_study_zone_List)
        {
            return await Call_WebApi<Result_Edit_Ext_study_zone_List>("/Api/SiteManagement/Edit_Ext_study_zone_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Ext_study_zone_List));
        }
        public Result_Edit_Site_view_List Edit_Site_view_List(Params_Edit_Site_view_List i_Params_Edit_Site_view_List)
        {
            return Edit_Site_view_List_Async(i_Params_Edit_Site_view_List).Result;
        }
        public async Task<Result_Edit_Site_view_List> Edit_Site_view_List_Async(Params_Edit_Site_view_List i_Params_Edit_Site_view_List)
        {
            return await Call_WebApi<Result_Edit_Site_view_List>("/Api/SiteManagement/Edit_Site_view_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Site_view_List));
        }
        public Result_Delete_Site_view_By_SITE_ID Delete_Site_view_By_SITE_ID(Params_Delete_Site_view_By_SITE_ID i_Params_Delete_Site_view_By_SITE_ID)
        {
            return Delete_Site_view_By_SITE_ID_Async(i_Params_Delete_Site_view_By_SITE_ID).Result;
        }
        public async Task<Result_Delete_Site_view_By_SITE_ID> Delete_Site_view_By_SITE_ID_Async(Params_Delete_Site_view_By_SITE_ID i_Params_Delete_Site_view_By_SITE_ID)
        {
            return await Call_WebApi<Result_Delete_Site_view_By_SITE_ID>("/Api/SiteManagement/Delete_Site_view_By_SITE_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Site_view_By_SITE_ID));
        }
        public Result_Get_Site_view_By_SITE_ID_List Get_Site_view_By_SITE_ID_List(Params_Get_Site_view_By_SITE_ID_List i_Params_Get_Site_view_By_SITE_ID_List)
        {
            return Get_Site_view_By_SITE_ID_List_Async(i_Params_Get_Site_view_By_SITE_ID_List).Result;
        }
        public async Task<Result_Get_Site_view_By_SITE_ID_List> Get_Site_view_By_SITE_ID_List_Async(Params_Get_Site_view_By_SITE_ID_List i_Params_Get_Site_view_By_SITE_ID_List)
        {
            return await Call_WebApi<Result_Get_Site_view_By_SITE_ID_List>("/Api/SiteManagement/Get_Site_view_By_SITE_ID_List", true, "GET", $"?SITE_ID_LIST={(i_Params_Get_Site_view_By_SITE_ID_List.SITE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Site_view_By_SITE_ID_List.SITE_ID_LIST))}");
        }
        public Result_Get_Site_field_logo_By_SITE_ID_List Get_Site_field_logo_By_SITE_ID_List(Params_Get_Site_field_logo_By_SITE_ID_List i_Params_Get_Site_field_logo_By_SITE_ID_List)
        {
            return Get_Site_field_logo_By_SITE_ID_List_Async(i_Params_Get_Site_field_logo_By_SITE_ID_List).Result;
        }
        public async Task<Result_Get_Site_field_logo_By_SITE_ID_List> Get_Site_field_logo_By_SITE_ID_List_Async(Params_Get_Site_field_logo_By_SITE_ID_List i_Params_Get_Site_field_logo_By_SITE_ID_List)
        {
            return await Call_WebApi<Result_Get_Site_field_logo_By_SITE_ID_List>("/Api/SiteManagement/Get_Site_field_logo_By_SITE_ID_List", true, "GET", $"?SITE_ID_LIST={(i_Params_Get_Site_field_logo_By_SITE_ID_List.SITE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Site_field_logo_By_SITE_ID_List.SITE_ID_LIST))}");
        }
        public Result_Check_Organization_Deletion_Status Check_Organization_Deletion_Status()
        {
            return Check_Organization_Deletion_Status_Async().Result;
        }
        public async Task<Result_Check_Organization_Deletion_Status> Check_Organization_Deletion_Status_Async()
        {
            return await Call_WebApi<Result_Check_Organization_Deletion_Status>("/Api/OrganizationManagement/Check_Organization_Deletion_Status", true, "POST");
        }
        public Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID)
        {
            return Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Async(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID).Result;
        }
        public async Task<Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Async(Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID>("/Api/OrganizationManagement/Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID}&LOG_TYPE_SETUP_ID={i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID}");
        }
        public Result_Edit_Organization Edit_Organization(Organization i_Organization)
        {
            return Edit_Organization_Async(i_Organization).Result;
        }
        public async Task<Result_Edit_Organization> Edit_Organization_Async(Organization i_Organization)
        {
            return await Call_WebApi<Result_Edit_Organization>("/Api/OrganizationManagement/Edit_Organization", true, "POST", JsonConvert.SerializeObject(i_Organization));
        }
        public Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv Get_Organization_image_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_image_By_ORGANIZATION_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_image_By_ORGANIZATION_ID_List_Adv_Async(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv> Get_Organization_image_By_ORGANIZATION_ID_List_Adv_Async(Params_Get_Organization_image_By_ORGANIZATION_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv>("/Api/OrganizationManagement/Get_Organization_image_By_ORGANIZATION_ID_List_Adv", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Delete_Organization_theme Delete_Organization_theme(Params_Delete_Organization_theme i_Params_Delete_Organization_theme)
        {
            return Delete_Organization_theme_Async(i_Params_Delete_Organization_theme).Result;
        }
        public async Task<Result_Delete_Organization_theme> Delete_Organization_theme_Async(Params_Delete_Organization_theme i_Params_Delete_Organization_theme)
        {
            return await Call_WebApi<Result_Delete_Organization_theme>("/Api/OrganizationManagement/Delete_Organization_theme", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_theme));
        }
        public Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            return Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv_Async(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID).Result;
        }
        public async Task<Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv_Async(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv>("/Api/OrganizationManagement/Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv", true, "GET", $"?DATA_LEVEL_SETUP_ID={i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID}");
        }
        public Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_theme_By_ORGANIZATION_ID_List i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_theme_By_ORGANIZATION_ID_List_Adv_Async(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv> Get_Organization_theme_By_ORGANIZATION_ID_List_Adv_Async(Params_Get_Organization_theme_By_ORGANIZATION_ID_List i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv>("/Api/OrganizationManagement/Get_Organization_theme_By_ORGANIZATION_ID_List_Adv", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Edit_Organization_Custom Edit_Organization_Custom(Params_Edit_Organization_Custom i_Params_Edit_Organization_Custom)
        {
            return Edit_Organization_Custom_Async(i_Params_Edit_Organization_Custom).Result;
        }
        public async Task<Result_Edit_Organization_Custom> Edit_Organization_Custom_Async(Params_Edit_Organization_Custom i_Params_Edit_Organization_Custom)
        {
            return await Call_WebApi<Result_Edit_Organization_Custom>("/Api/OrganizationManagement/Edit_Organization_Custom", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_Custom));
        }
        public Result_Schedule_Organization_for_Delete Schedule_Organization_for_Delete(Params_Schedule_Organization_for_Delete i_Params_Schedule_Organization_for_Delete)
        {
            return Schedule_Organization_for_Delete_Async(i_Params_Schedule_Organization_for_Delete).Result;
        }
        public async Task<Result_Schedule_Organization_for_Delete> Schedule_Organization_for_Delete_Async(Params_Schedule_Organization_for_Delete i_Params_Schedule_Organization_for_Delete)
        {
            return await Call_WebApi<Result_Schedule_Organization_for_Delete>("/Api/OrganizationManagement/Schedule_Organization_for_Delete", true, "POST", JsonConvert.SerializeObject(i_Params_Schedule_Organization_for_Delete));
        }
        public Result_Modify_Data_Settings Modify_Data_Settings(Params_Modify_Data_Settings i_Params_Modify_Data_Settings)
        {
            return Modify_Data_Settings_Async(i_Params_Modify_Data_Settings).Result;
        }
        public async Task<Result_Modify_Data_Settings> Modify_Data_Settings_Async(Params_Modify_Data_Settings i_Params_Modify_Data_Settings)
        {
            return await Call_WebApi<Result_Modify_Data_Settings>("/Api/OrganizationManagement/Modify_Data_Settings", true, "POST", JsonConvert.SerializeObject(i_Params_Modify_Data_Settings));
        }
        public Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List Get_Organization_color_scheme_By_ORGANIZATION_ID_List(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Async(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List> Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Async(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List>("/Api/OrganizationManagement/Get_Organization_color_scheme_By_ORGANIZATION_ID_List", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Modify_Organization_Details Modify_Organization_Details(Params_Modify_Organization_Details i_Params_Modify_Organization_Details)
        {
            return Modify_Organization_Details_Async(i_Params_Modify_Organization_Details).Result;
        }
        public async Task<Result_Modify_Organization_Details> Modify_Organization_Details_Async(Params_Modify_Organization_Details i_Params_Modify_Organization_Details)
        {
            return await Call_WebApi<Result_Modify_Organization_Details>("/Api/OrganizationManagement/Modify_Organization_Details", true, "POST", JsonConvert.SerializeObject(i_Params_Modify_Organization_Details));
        }
        public Result_Edit_Organization_color_scheme Edit_Organization_color_scheme(Organization_color_scheme i_Organization_color_scheme)
        {
            return Edit_Organization_color_scheme_Async(i_Organization_color_scheme).Result;
        }
        public async Task<Result_Edit_Organization_color_scheme> Edit_Organization_color_scheme_Async(Organization_color_scheme i_Organization_color_scheme)
        {
            return await Call_WebApi<Result_Edit_Organization_color_scheme>("/Api/OrganizationManagement/Edit_Organization_color_scheme", true, "POST", JsonConvert.SerializeObject(i_Organization_color_scheme));
        }
        public Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID Get_Organization_relation_By_PARENT_ORGANIZATION_ID(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID)
        {
            return Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Async(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Async(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_relation_By_PARENT_ORGANIZATION_ID", true, "GET", $"?PARENT_ORGANIZATION_ID={i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID}");
        }
        public Result_Get_Organization_By_ORGANIZATION_ID Get_Organization_By_ORGANIZATION_ID(Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID)
        {
            return Get_Organization_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_By_ORGANIZATION_ID> Get_Organization_By_ORGANIZATION_ID_Async(Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Get_Organization_theme_By_ORGANIZATION_ID Get_Organization_theme_By_ORGANIZATION_ID(Params_Get_Organization_theme_By_ORGANIZATION_ID i_Params_Get_Organization_theme_By_ORGANIZATION_ID)
        {
            return Get_Organization_theme_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_theme_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_theme_By_ORGANIZATION_ID> Get_Organization_theme_By_ORGANIZATION_ID_Async(Params_Get_Organization_theme_By_ORGANIZATION_ID i_Params_Get_Organization_theme_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_theme_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_theme_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID)
        {
            return Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Async(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID).Result;
        }
        public async Task<Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Async(Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID>("/Api/OrganizationManagement/Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID}&DATA_LEVEL_SETUP_ID={i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID}");
        }
        public Result_Edit_Organization_districtnex_module_List Edit_Organization_districtnex_module_List(Params_Edit_Organization_districtnex_module_List i_Params_Edit_Organization_districtnex_module_List)
        {
            return Edit_Organization_districtnex_module_List_Async(i_Params_Edit_Organization_districtnex_module_List).Result;
        }
        public async Task<Result_Edit_Organization_districtnex_module_List> Edit_Organization_districtnex_module_List_Async(Params_Edit_Organization_districtnex_module_List i_Params_Edit_Organization_districtnex_module_List)
        {
            return await Call_WebApi<Result_Edit_Organization_districtnex_module_List>("/Api/OrganizationManagement/Edit_Organization_districtnex_module_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_districtnex_module_List));
        }
        public Result_Get_Organization_By_PARENT_ORGANIZATION_ID Get_Organization_By_PARENT_ORGANIZATION_ID(Params_Get_Organization_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID)
        {
            return Get_Organization_By_PARENT_ORGANIZATION_ID_Async(i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_By_PARENT_ORGANIZATION_ID> Get_Organization_By_PARENT_ORGANIZATION_ID_Async(Params_Get_Organization_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_By_PARENT_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_By_PARENT_ORGANIZATION_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID));
        }
        public Result_Edit_Organization_level_access_List Edit_Organization_level_access_List(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List)
        {
            return Edit_Organization_level_access_List_Async(i_Params_Edit_Organization_level_access_List).Result;
        }
        public async Task<Result_Edit_Organization_level_access_List> Edit_Organization_level_access_List_Async(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List)
        {
            return await Call_WebApi<Result_Edit_Organization_level_access_List>("/Api/OrganizationManagement/Edit_Organization_level_access_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_level_access_List));
        }
        public Result_Edit_Organization_theme Edit_Organization_theme(Organization_theme i_Organization_theme)
        {
            return Edit_Organization_theme_Async(i_Organization_theme).Result;
        }
        public async Task<Result_Edit_Organization_theme> Edit_Organization_theme_Async(Organization_theme i_Organization_theme)
        {
            return await Call_WebApi<Result_Edit_Organization_theme>("/Api/OrganizationManagement/Edit_Organization_theme", true, "POST", JsonConvert.SerializeObject(i_Organization_theme));
        }
        public Result_Delete_Organization_Picture Delete_Organization_Picture(Params_Delete_Organization_Picture i_Params_Delete_Organization_Picture)
        {
            return Delete_Organization_Picture_Async(i_Params_Delete_Organization_Picture).Result;
        }
        public async Task<Result_Delete_Organization_Picture> Delete_Organization_Picture_Async(Params_Delete_Organization_Picture i_Params_Delete_Organization_Picture)
        {
            return await Call_WebApi<Result_Delete_Organization_Picture>("/Api/OrganizationManagement/Delete_Organization_Picture", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_Picture));
        }
        public Result_Get_Organization_By_ORGANIZATION_ID_List Get_Organization_By_ORGANIZATION_ID_List(Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_By_ORGANIZATION_ID_List_Async(i_Params_Get_Organization_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_By_ORGANIZATION_ID_List> Get_Organization_By_ORGANIZATION_ID_List_Async(Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_By_ORGANIZATION_ID_List>("/Api/OrganizationManagement/Get_Organization_By_ORGANIZATION_ID_List", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading)
        {
            return Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading_Async(i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading).Result;
        }
        public async Task<Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading> Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading_Async(Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading)
        {
            return await Call_WebApi<Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading>("/Api/OrganizationManagement/Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading));
        }
        public Result_Get_Organization_color_scheme_By_ORGANIZATION_ID Get_Organization_color_scheme_By_ORGANIZATION_ID(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            return Get_Organization_color_scheme_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_color_scheme_By_ORGANIZATION_ID> Get_Organization_color_scheme_By_ORGANIZATION_ID_Async(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_color_scheme_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_color_scheme_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Get_Organization_By_OWNER_ID Get_Organization_By_OWNER_ID(Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            return Get_Organization_By_OWNER_ID_Async(i_Params_Get_Organization_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Organization_By_OWNER_ID> Get_Organization_By_OWNER_ID_Async(Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Organization_By_OWNER_ID>("/Api/OrganizationManagement/Get_Organization_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Organization_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Organization_chart_color_List Edit_Organization_chart_color_List(Params_Edit_Organization_chart_color_List i_Params_Edit_Organization_chart_color_List)
        {
            return Edit_Organization_chart_color_List_Async(i_Params_Edit_Organization_chart_color_List).Result;
        }
        public async Task<Result_Edit_Organization_chart_color_List> Edit_Organization_chart_color_List_Async(Params_Edit_Organization_chart_color_List i_Params_Edit_Organization_chart_color_List)
        {
            return await Call_WebApi<Result_Edit_Organization_chart_color_List>("/Api/OrganizationManagement/Edit_Organization_chart_color_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_chart_color_List));
        }
        public Result_Get_Organization_level_access_By_ORGANIZATION_ID Get_Organization_level_access_By_ORGANIZATION_ID(Params_Get_Organization_level_access_By_ORGANIZATION_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID)
        {
            return Get_Organization_level_access_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_level_access_By_ORGANIZATION_ID> Get_Organization_level_access_By_ORGANIZATION_ID_Async(Params_Get_Organization_level_access_By_ORGANIZATION_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_level_access_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_level_access_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            return Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv_Async(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv> Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv_Async(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv>("/Api/OrganizationManagement/Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Restore_Organization Restore_Organization(Params_Restore_Organization i_Params_Restore_Organization)
        {
            return Restore_Organization_Async(i_Params_Restore_Organization).Result;
        }
        public async Task<Result_Restore_Organization> Restore_Organization_Async(Params_Restore_Organization i_Params_Restore_Organization)
        {
            return await Call_WebApi<Result_Restore_Organization>("/Api/OrganizationManagement/Restore_Organization", true, "POST", JsonConvert.SerializeObject(i_Params_Restore_Organization));
        }
        public Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            return Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Async(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID).Result;
        }
        public async Task<Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Async(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID>("/Api/OrganizationManagement/Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID", true, "GET", $"?DATA_LEVEL_SETUP_ID={i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID}");
        }
        public Result_Delete_Organization_level_access Delete_Organization_level_access(Params_Delete_Organization_level_access i_Params_Delete_Organization_level_access)
        {
            return Delete_Organization_level_access_Async(i_Params_Delete_Organization_level_access).Result;
        }
        public async Task<Result_Delete_Organization_level_access> Delete_Organization_level_access_Async(Params_Delete_Organization_level_access i_Params_Delete_Organization_level_access)
        {
            return await Call_WebApi<Result_Delete_Organization_level_access>("/Api/OrganizationManagement/Delete_Organization_level_access", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access));
        }
        public Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID Get_Organization_districtnex_module_By_ORGANIZATION_ID(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            return Get_Organization_districtnex_module_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID> Get_Organization_districtnex_module_By_ORGANIZATION_ID_Async(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_districtnex_module_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Edit_Organization_level_access Edit_Organization_level_access(Organization_level_access i_Organization_level_access)
        {
            return Edit_Organization_level_access_Async(i_Organization_level_access).Result;
        }
        public async Task<Result_Edit_Organization_level_access> Edit_Organization_level_access_Async(Organization_level_access i_Organization_level_access)
        {
            return await Call_WebApi<Result_Edit_Organization_level_access>("/Api/OrganizationManagement/Edit_Organization_level_access", true, "POST", JsonConvert.SerializeObject(i_Organization_level_access));
        }
        public Result_Delete_Organization_level_access_By_ORGANIZATION_ID Delete_Organization_level_access_By_ORGANIZATION_ID(Params_Delete_Organization_level_access_By_ORGANIZATION_ID i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID)
        {
            return Delete_Organization_level_access_By_ORGANIZATION_ID_Async(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Delete_Organization_level_access_By_ORGANIZATION_ID> Delete_Organization_level_access_By_ORGANIZATION_ID_Async(Params_Delete_Organization_level_access_By_ORGANIZATION_ID i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Delete_Organization_level_access_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Delete_Organization_level_access_By_ORGANIZATION_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID));
        }
        public Result_Edit_Organization_districtnex_module Edit_Organization_districtnex_module(Organization_districtnex_module i_Organization_districtnex_module)
        {
            return Edit_Organization_districtnex_module_Async(i_Organization_districtnex_module).Result;
        }
        public async Task<Result_Edit_Organization_districtnex_module> Edit_Organization_districtnex_module_Async(Organization_districtnex_module i_Organization_districtnex_module)
        {
            return await Call_WebApi<Result_Edit_Organization_districtnex_module>("/Api/OrganizationManagement/Edit_Organization_districtnex_module", true, "POST", JsonConvert.SerializeObject(i_Organization_districtnex_module));
        }
        public Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID Delete_Organization_districtnex_module_By_ORGANIZATION_ID(Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            return Delete_Organization_districtnex_module_By_ORGANIZATION_ID_Async(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID> Delete_Organization_districtnex_module_By_ORGANIZATION_ID_Async(Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Delete_Organization_districtnex_module_By_ORGANIZATION_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID));
        }
        public Result_Edit_Organization_color_scheme_List Edit_Organization_color_scheme_List(Params_Edit_Organization_color_scheme_List i_Params_Edit_Organization_color_scheme_List)
        {
            return Edit_Organization_color_scheme_List_Async(i_Params_Edit_Organization_color_scheme_List).Result;
        }
        public async Task<Result_Edit_Organization_color_scheme_List> Edit_Organization_color_scheme_List_Async(Params_Edit_Organization_color_scheme_List i_Params_Edit_Organization_color_scheme_List)
        {
            return await Call_WebApi<Result_Edit_Organization_color_scheme_List>("/Api/OrganizationManagement/Edit_Organization_color_scheme_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_color_scheme_List));
        }
        public Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID Delete_Organization_color_scheme_By_ORGANIZATION_ID(Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            return Delete_Organization_color_scheme_By_ORGANIZATION_ID_Async(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID> Delete_Organization_color_scheme_By_ORGANIZATION_ID_Async(Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Delete_Organization_color_scheme_By_ORGANIZATION_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID));
        }
        public Result_Edit_Organization_log_config Edit_Organization_log_config(Organization_log_config i_Organization_log_config)
        {
            return Edit_Organization_log_config_Async(i_Organization_log_config).Result;
        }
        public async Task<Result_Edit_Organization_log_config> Edit_Organization_log_config_Async(Organization_log_config i_Organization_log_config)
        {
            return await Call_WebApi<Result_Edit_Organization_log_config>("/Api/OrganizationManagement/Edit_Organization_log_config", true, "POST", JsonConvert.SerializeObject(i_Organization_log_config));
        }
        public Result_Edit_Organization_log_config_List Edit_Organization_log_config_List(Params_Edit_Organization_log_config_List i_Params_Edit_Organization_log_config_List)
        {
            return Edit_Organization_log_config_List_Async(i_Params_Edit_Organization_log_config_List).Result;
        }
        public async Task<Result_Edit_Organization_log_config_List> Edit_Organization_log_config_List_Async(Params_Edit_Organization_log_config_List i_Params_Edit_Organization_log_config_List)
        {
            return await Call_WebApi<Result_Edit_Organization_log_config_List>("/Api/OrganizationManagement/Edit_Organization_log_config_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Organization_log_config_List));
        }
        public Result_Get_Organization_log_config_By_ORGANIZATION_ID Get_Organization_log_config_By_ORGANIZATION_ID(Params_Get_Organization_log_config_By_ORGANIZATION_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID)
        {
            return Get_Organization_log_config_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_log_config_By_ORGANIZATION_ID> Get_Organization_log_config_By_ORGANIZATION_ID_Async(Params_Get_Organization_log_config_By_ORGANIZATION_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_log_config_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_log_config_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Delete_Organization_log_config_By_ORGANIZATION_ID Delete_Organization_log_config_By_ORGANIZATION_ID(Params_Delete_Organization_log_config_By_ORGANIZATION_ID i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID)
        {
            return Delete_Organization_log_config_By_ORGANIZATION_ID_Async(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Delete_Organization_log_config_By_ORGANIZATION_ID> Delete_Organization_log_config_By_ORGANIZATION_ID_Async(Params_Delete_Organization_log_config_By_ORGANIZATION_ID i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Delete_Organization_log_config_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Delete_Organization_log_config_By_ORGANIZATION_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID));
        }
        public Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv_Async(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv_Async(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv>("/Api/OrganizationManagement/Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Get_Organization_image_By_ORGANIZATION_ID_List Get_Organization_image_By_ORGANIZATION_ID_List(Params_Get_Organization_image_By_ORGANIZATION_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_image_By_ORGANIZATION_ID_List_Async(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_image_By_ORGANIZATION_ID_List> Get_Organization_image_By_ORGANIZATION_ID_List_Async(Params_Get_Organization_image_By_ORGANIZATION_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_image_By_ORGANIZATION_ID_List>("/Api/OrganizationManagement/Get_Organization_image_By_ORGANIZATION_ID_List", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_level_access_By_ORGANIZATION_ID_List i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv_Async(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv> Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv_Async(Params_Get_Organization_level_access_By_ORGANIZATION_ID_List i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv>("/Api/OrganizationManagement/Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_log_config_By_ORGANIZATION_ID_List i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List)
        {
            return Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv_Async(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List).Result;
        }
        public async Task<Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv> Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv_Async(Params_Get_Organization_log_config_By_ORGANIZATION_ID_List i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List)
        {
            return await Call_WebApi<Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv>("/Api/OrganizationManagement/Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv", true, "GET", $"?ORGANIZATION_ID_LIST={(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST))}");
        }
        public Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv Get_Organization_theme_By_ORGANIZATION_ID_Adv(Params_Get_Organization_theme_By_ORGANIZATION_ID i_Params_Get_Organization_theme_By_ORGANIZATION_ID)
        {
            return Get_Organization_theme_By_ORGANIZATION_ID_Adv_Async(i_Params_Get_Organization_theme_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv> Get_Organization_theme_By_ORGANIZATION_ID_Adv_Async(Params_Get_Organization_theme_By_ORGANIZATION_ID i_Params_Get_Organization_theme_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv>("/Api/OrganizationManagement/Get_Organization_theme_By_ORGANIZATION_ID_Adv", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Get_Organization_image_By_ORGANIZATION_ID Get_Organization_image_By_ORGANIZATION_ID(Params_Get_Organization_image_By_ORGANIZATION_ID i_Params_Get_Organization_image_By_ORGANIZATION_ID)
        {
            return Get_Organization_image_By_ORGANIZATION_ID_Async(i_Params_Get_Organization_image_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_Organization_image_By_ORGANIZATION_ID> Get_Organization_image_By_ORGANIZATION_ID_Async(Params_Get_Organization_image_By_ORGANIZATION_ID i_Params_Get_Organization_image_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_Organization_image_By_ORGANIZATION_ID>("/Api/OrganizationManagement/Get_Organization_image_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Edit_Setup Edit_Setup(Setup i_Setup)
        {
            return Edit_Setup_Async(i_Setup).Result;
        }
        public async Task<Result_Edit_Setup> Edit_Setup_Async(Setup i_Setup)
        {
            return await Call_WebApi<Result_Edit_Setup>("/Api/SettingsManagement/Edit_Setup", true, "POST", JsonConvert.SerializeObject(i_Setup));
        }
        public Result_Get_Specialized_chart_configuration_By_MODULE Get_Specialized_chart_configuration_By_MODULE(Params_Get_Specialized_chart_configuration_By_MODULE i_Params_Get_Specialized_chart_configuration_By_MODULE)
        {
            return Get_Specialized_chart_configuration_By_MODULE_Async(i_Params_Get_Specialized_chart_configuration_By_MODULE).Result;
        }
        public async Task<Result_Get_Specialized_chart_configuration_By_MODULE> Get_Specialized_chart_configuration_By_MODULE_Async(Params_Get_Specialized_chart_configuration_By_MODULE i_Params_Get_Specialized_chart_configuration_By_MODULE)
        {
            return await Call_WebApi<Result_Get_Specialized_chart_configuration_By_MODULE>("/Api/SettingsManagement/Get_Specialized_chart_configuration_By_MODULE", true, "GET", $"?MODULE={i_Params_Get_Specialized_chart_configuration_By_MODULE.MODULE}");
        }
        public Result_Delete_District_geojson_By_DISTRICT_ID Delete_District_geojson_By_DISTRICT_ID(Params_Delete_District_geojson_By_DISTRICT_ID i_Params_Delete_District_geojson_By_DISTRICT_ID)
        {
            return Delete_District_geojson_By_DISTRICT_ID_Async(i_Params_Delete_District_geojson_By_DISTRICT_ID).Result;
        }
        public async Task<Result_Delete_District_geojson_By_DISTRICT_ID> Delete_District_geojson_By_DISTRICT_ID_Async(Params_Delete_District_geojson_By_DISTRICT_ID i_Params_Delete_District_geojson_By_DISTRICT_ID)
        {
            return await Call_WebApi<Result_Delete_District_geojson_By_DISTRICT_ID>("/Api/SettingsManagement/Delete_District_geojson_By_DISTRICT_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_District_geojson_By_DISTRICT_ID));
        }
        public Result_Get_Dimension_chart_configuration Get_Dimension_chart_configuration()
        {
            return Get_Dimension_chart_configuration_Async().Result;
        }
        public async Task<Result_Get_Dimension_chart_configuration> Get_Dimension_chart_configuration_Async()
        {
            return await Call_WebApi<Result_Get_Dimension_chart_configuration>("/Api/SettingsManagement/Get_Dimension_chart_configuration", true, "POST");
        }
        public Result_Edit_Setup_category_List Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
        {
            return Edit_Setup_category_List_Async(i_Params_Edit_Setup_category_List).Result;
        }
        public async Task<Result_Edit_Setup_category_List> Edit_Setup_category_List_Async(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
        {
            return await Call_WebApi<Result_Edit_Setup_category_List>("/Api/SettingsManagement/Edit_Setup_category_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Setup_category_List));
        }
        public Result_Get_Districtnex_module_By_OWNER_ID Get_Districtnex_module_By_OWNER_ID(Params_Get_Districtnex_module_By_OWNER_ID i_Params_Get_Districtnex_module_By_OWNER_ID)
        {
            return Get_Districtnex_module_By_OWNER_ID_Async(i_Params_Get_Districtnex_module_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Districtnex_module_By_OWNER_ID> Get_Districtnex_module_By_OWNER_ID_Async(Params_Get_Districtnex_module_By_OWNER_ID i_Params_Get_Districtnex_module_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Districtnex_module_By_OWNER_ID>("/Api/SettingsManagement/Get_Districtnex_module_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Districtnex_module_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Dimension_chart_configuration Edit_Dimension_chart_configuration(Dimension_chart_configuration i_Dimension_chart_configuration)
        {
            return Edit_Dimension_chart_configuration_Async(i_Dimension_chart_configuration).Result;
        }
        public async Task<Result_Edit_Dimension_chart_configuration> Edit_Dimension_chart_configuration_Async(Dimension_chart_configuration i_Dimension_chart_configuration)
        {
            return await Call_WebApi<Result_Edit_Dimension_chart_configuration>("/Api/SettingsManagement/Edit_Dimension_chart_configuration", true, "POST", JsonConvert.SerializeObject(i_Dimension_chart_configuration));
        }
        public Result_Get_Setup_By_SETUP_ID_Adv Get_Setup_By_SETUP_ID_Adv(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            return Get_Setup_By_SETUP_ID_Adv_Async(i_Params_Get_Setup_By_SETUP_ID).Result;
        }
        public async Task<Result_Get_Setup_By_SETUP_ID_Adv> Get_Setup_By_SETUP_ID_Adv_Async(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Setup_By_SETUP_ID_Adv>("/Api/SettingsManagement/Get_Setup_By_SETUP_ID_Adv", true, "GET", $"?SETUP_ID={i_Params_Get_Setup_By_SETUP_ID.SETUP_ID}");
        }
        public Result_Get_Default_settings_By_OWNER_ID Get_Default_settings_By_OWNER_ID(Params_Get_Default_settings_By_OWNER_ID i_Params_Get_Default_settings_By_OWNER_ID)
        {
            return Get_Default_settings_By_OWNER_ID_Async(i_Params_Get_Default_settings_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Default_settings_By_OWNER_ID> Get_Default_settings_By_OWNER_ID_Async(Params_Get_Default_settings_By_OWNER_ID i_Params_Get_Default_settings_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Default_settings_By_OWNER_ID>("/Api/SettingsManagement/Get_Default_settings_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Default_settings_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Object_View Edit_Object_View(Params_Edit_Object_View i_Params_Edit_Object_View)
        {
            return Edit_Object_View_Async(i_Params_Edit_Object_View).Result;
        }
        public async Task<Result_Edit_Object_View> Edit_Object_View_Async(Params_Edit_Object_View i_Params_Edit_Object_View)
        {
            return await Call_WebApi<Result_Edit_Object_View>("/Api/SettingsManagement/Edit_Object_View", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Object_View));
        }
        public Result_Get_Setup_category_By_OWNER_ID Get_Setup_category_By_OWNER_ID(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            return Get_Setup_category_By_OWNER_ID_Async(i_Params_Get_Setup_category_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Setup_category_By_OWNER_ID> Get_Setup_category_By_OWNER_ID_Async(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Setup_category_By_OWNER_ID>("/Api/SettingsManagement/Get_Setup_category_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Setup_category_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Site_geojson Get_Site_geojson()
        {
            return Get_Site_geojson_Async().Result;
        }
        public async Task<Result_Get_Site_geojson> Get_Site_geojson_Async()
        {
            return await Call_WebApi<Result_Get_Site_geojson>("/Api/SettingsManagement/Get_Site_geojson", true, "POST");
        }
        public Result_Edit_District_geojson Edit_District_geojson(Params_Edit_District_geojson i_Params_Edit_District_geojson)
        {
            return Edit_District_geojson_Async(i_Params_Edit_District_geojson).Result;
        }
        public async Task<Result_Edit_District_geojson> Edit_District_geojson_Async(Params_Edit_District_geojson i_Params_Edit_District_geojson)
        {
            return await Call_WebApi<Result_Edit_District_geojson>("/Api/SettingsManagement/Edit_District_geojson", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_District_geojson));
        }
        public Result_Delete_Build_version Delete_Build_version(Params_Delete_Build_version i_Params_Delete_Build_version)
        {
            return Delete_Build_version_Async(i_Params_Delete_Build_version).Result;
        }
        public async Task<Result_Delete_Build_version> Delete_Build_version_Async(Params_Delete_Build_version i_Params_Delete_Build_version)
        {
            return await Call_WebApi<Result_Delete_Build_version>("/Api/SettingsManagement/Delete_Build_version", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Build_version));
        }
        public Result_Edit_Ext_study_zone_geojson Edit_Ext_study_zone_geojson(Params_Edit_Ext_study_zone_geojson i_Params_Edit_Ext_study_zone_geojson)
        {
            return Edit_Ext_study_zone_geojson_Async(i_Params_Edit_Ext_study_zone_geojson).Result;
        }
        public async Task<Result_Edit_Ext_study_zone_geojson> Edit_Ext_study_zone_geojson_Async(Params_Edit_Ext_study_zone_geojson i_Params_Edit_Ext_study_zone_geojson)
        {
            return await Call_WebApi<Result_Edit_Ext_study_zone_geojson>("/Api/SettingsManagement/Edit_Ext_study_zone_geojson", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Ext_study_zone_geojson));
        }
        public Result_Delete_Default_Settings_Picture Delete_Default_Settings_Picture(Params_Delete_Default_Settings_Picture i_Params_Delete_Default_Settings_Picture)
        {
            return Delete_Default_Settings_Picture_Async(i_Params_Delete_Default_Settings_Picture).Result;
        }
        public async Task<Result_Delete_Default_Settings_Picture> Delete_Default_Settings_Picture_Async(Params_Delete_Default_Settings_Picture i_Params_Delete_Default_Settings_Picture)
        {
            return await Call_WebApi<Result_Delete_Default_Settings_Picture>("/Api/SettingsManagement/Delete_Default_Settings_Picture", true, "DELETE", "/" + i_Params_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID);
        }
        public Result_Get_Specialized_chart_configuration Get_Specialized_chart_configuration()
        {
            return Get_Specialized_chart_configuration_Async().Result;
        }
        public async Task<Result_Get_Specialized_chart_configuration> Get_Specialized_chart_configuration_Async()
        {
            return await Call_WebApi<Result_Get_Specialized_chart_configuration>("/Api/SettingsManagement/Get_Specialized_chart_configuration", true, "GET");
        }
        public Result_Edit_Removed_extrusion_Custom_Old Edit_Removed_extrusion_Custom_Old(Params_Edit_Removed_extrusion_Custom_Old i_Params_Edit_Removed_extrusion_Custom_Old)
        {
            return Edit_Removed_extrusion_Custom_Old_Async(i_Params_Edit_Removed_extrusion_Custom_Old).Result;
        }
        public async Task<Result_Edit_Removed_extrusion_Custom_Old> Edit_Removed_extrusion_Custom_Old_Async(Params_Edit_Removed_extrusion_Custom_Old i_Params_Edit_Removed_extrusion_Custom_Old)
        {
            return await Call_WebApi<Result_Edit_Removed_extrusion_Custom_Old>("/Api/SettingsManagement/Edit_Removed_extrusion_Custom_Old", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Removed_extrusion_Custom_Old));
        }
        public Result_Get_Area_geojson Get_Area_geojson()
        {
            return Get_Area_geojson_Async().Result;
        }
        public async Task<Result_Get_Area_geojson> Get_Area_geojson_Async()
        {
            return await Call_WebApi<Result_Get_Area_geojson>("/Api/SettingsManagement/Get_Area_geojson", true, "POST");
        }
        public Result_Delete_Setup_category Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
        {
            return Delete_Setup_category_Async(i_Params_Delete_Setup_category).Result;
        }
        public async Task<Result_Delete_Setup_category> Delete_Setup_category_Async(Params_Delete_Setup_category i_Params_Delete_Setup_category)
        {
            return await Call_WebApi<Result_Delete_Setup_category>("/Api/SettingsManagement/Delete_Setup_category", true, "DELETE", "/" + i_Params_Delete_Setup_category.SETUP_CATEGORY_ID);
        }
        public Result_Get_Build_version_By_OWNER_ID_Adv Get_Build_version_By_OWNER_ID_Adv(Params_Get_Build_version_By_OWNER_ID i_Params_Get_Build_version_By_OWNER_ID)
        {
            return Get_Build_version_By_OWNER_ID_Adv_Async(i_Params_Get_Build_version_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Build_version_By_OWNER_ID_Adv> Get_Build_version_By_OWNER_ID_Adv_Async(Params_Get_Build_version_By_OWNER_ID i_Params_Get_Build_version_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Build_version_By_OWNER_ID_Adv>("/Api/SettingsManagement/Get_Build_version_By_OWNER_ID_Adv", true, "GET", $"?OWNER_ID={i_Params_Get_Build_version_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Build_version Edit_Build_version(Build_version i_Build_version)
        {
            return Edit_Build_version_Async(i_Build_version).Result;
        }
        public async Task<Result_Edit_Build_version> Edit_Build_version_Async(Build_version i_Build_version)
        {
            return await Call_WebApi<Result_Edit_Build_version>("/Api/SettingsManagement/Edit_Build_version", true, "POST", JsonConvert.SerializeObject(i_Build_version));
        }
        public Result_Get_Default_chart_color_By_OWNER_ID_Adv Get_Default_chart_color_By_OWNER_ID_Adv(Params_Get_Default_chart_color_By_OWNER_ID i_Params_Get_Default_chart_color_By_OWNER_ID)
        {
            return Get_Default_chart_color_By_OWNER_ID_Adv_Async(i_Params_Get_Default_chart_color_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Default_chart_color_By_OWNER_ID_Adv> Get_Default_chart_color_By_OWNER_ID_Adv_Async(Params_Get_Default_chart_color_By_OWNER_ID i_Params_Get_Default_chart_color_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Default_chart_color_By_OWNER_ID_Adv>("/Api/SettingsManagement/Get_Default_chart_color_By_OWNER_ID_Adv", true, "GET", $"?OWNER_ID={i_Params_Get_Default_chart_color_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Default_chart_color_List Edit_Default_chart_color_List(Params_Edit_Default_chart_color_List i_Params_Edit_Default_chart_color_List)
        {
            return Edit_Default_chart_color_List_Async(i_Params_Edit_Default_chart_color_List).Result;
        }
        public async Task<Result_Edit_Default_chart_color_List> Edit_Default_chart_color_List_Async(Params_Edit_Default_chart_color_List i_Params_Edit_Default_chart_color_List)
        {
            return await Call_WebApi<Result_Edit_Default_chart_color_List>("/Api/SettingsManagement/Edit_Default_chart_color_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Default_chart_color_List));
        }
        public Result_Get_District_geojson Get_District_geojson()
        {
            return Get_District_geojson_Async().Result;
        }
        public async Task<Result_Get_District_geojson> Get_District_geojson_Async()
        {
            return await Call_WebApi<Result_Get_District_geojson>("/Api/SettingsManagement/Get_District_geojson", true, "POST");
        }
        public Result_Edit_Specialized_chart_configuration Edit_Specialized_chart_configuration(Specialized_chart_configuration i_Specialized_chart_configuration)
        {
            return Edit_Specialized_chart_configuration_Async(i_Specialized_chart_configuration).Result;
        }
        public async Task<Result_Edit_Specialized_chart_configuration> Edit_Specialized_chart_configuration_Async(Specialized_chart_configuration i_Specialized_chart_configuration)
        {
            return await Call_WebApi<Result_Edit_Specialized_chart_configuration>("/Api/SettingsManagement/Edit_Specialized_chart_configuration", true, "POST", JsonConvert.SerializeObject(i_Specialized_chart_configuration));
        }
        public Result_Get_Setup_category_By_SETUP_CATEGORY_ID Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
        {
            return Get_Setup_category_By_SETUP_CATEGORY_ID_Async(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID).Result;
        }
        public async Task<Result_Get_Setup_category_By_SETUP_CATEGORY_ID> Get_Setup_category_By_SETUP_CATEGORY_ID_Async(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
        {
            return await Call_WebApi<Result_Get_Setup_category_By_SETUP_CATEGORY_ID>("/Api/SettingsManagement/Get_Setup_category_By_SETUP_CATEGORY_ID", true, "GET", $"?SETUP_CATEGORY_ID={i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID}");
        }
        public Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID)
        {
            return Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_Async(i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID).Result;
        }
        public async Task<Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID> Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_Async(Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID)
        {
            return await Call_WebApi<Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID>("/Api/SettingsManagement/Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID));
        }
        public Result_Edit_Setup_category Edit_Setup_category(Setup_category i_Setup_category)
        {
            return Edit_Setup_category_Async(i_Setup_category).Result;
        }
        public async Task<Result_Edit_Setup_category> Edit_Setup_category_Async(Setup_category i_Setup_category)
        {
            return await Call_WebApi<Result_Edit_Setup_category>("/Api/SettingsManagement/Edit_Setup_category", true, "POST", JsonConvert.SerializeObject(i_Setup_category));
        }
        public Result_Edit_Alert_settings_List Edit_Alert_settings_List(Params_Edit_Alert_settings_List i_Params_Edit_Alert_settings_List)
        {
            return Edit_Alert_settings_List_Async(i_Params_Edit_Alert_settings_List).Result;
        }
        public async Task<Result_Edit_Alert_settings_List> Edit_Alert_settings_List_Async(Params_Edit_Alert_settings_List i_Params_Edit_Alert_settings_List)
        {
            return await Call_WebApi<Result_Edit_Alert_settings_List>("/Api/SettingsManagement/Edit_Alert_settings_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Alert_settings_List));
        }
        public Result_Delete_Dimension_chart_configuration Delete_Dimension_chart_configuration(Params_Delete_Dimension_chart_configuration i_Params_Delete_Dimension_chart_configuration)
        {
            return Delete_Dimension_chart_configuration_Async(i_Params_Delete_Dimension_chart_configuration).Result;
        }
        public async Task<Result_Delete_Dimension_chart_configuration> Delete_Dimension_chart_configuration_Async(Params_Delete_Dimension_chart_configuration i_Params_Delete_Dimension_chart_configuration)
        {
            return await Call_WebApi<Result_Delete_Dimension_chart_configuration>("/Api/SettingsManagement/Delete_Dimension_chart_configuration", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Dimension_chart_configuration));
        }
        public Result_Get_Initial_Districtnex_Admin_Settings Get_Initial_Districtnex_Admin_Settings()
        {
            return Get_Initial_Districtnex_Admin_Settings_Async().Result;
        }
        public async Task<Result_Get_Initial_Districtnex_Admin_Settings> Get_Initial_Districtnex_Admin_Settings_Async()
        {
            return await Call_WebApi<Result_Get_Initial_Districtnex_Admin_Settings>("/Api/SettingsManagement/Get_Initial_Districtnex_Admin_Settings", true, "GET");
        }
        public Result_Edit_Site_geojson Edit_Site_geojson(Params_Edit_Site_geojson i_Params_Edit_Site_geojson)
        {
            return Edit_Site_geojson_Async(i_Params_Edit_Site_geojson).Result;
        }
        public async Task<Result_Edit_Site_geojson> Edit_Site_geojson_Async(Params_Edit_Site_geojson i_Params_Edit_Site_geojson)
        {
            return await Call_WebApi<Result_Edit_Site_geojson>("/Api/SettingsManagement/Edit_Site_geojson", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Site_geojson));
        }
        public Result_Delete_Area_geojson_By_AREA_ID Delete_Area_geojson_By_AREA_ID(Params_Delete_Area_geojson_By_AREA_ID i_Params_Delete_Area_geojson_By_AREA_ID)
        {
            return Delete_Area_geojson_By_AREA_ID_Async(i_Params_Delete_Area_geojson_By_AREA_ID).Result;
        }
        public async Task<Result_Delete_Area_geojson_By_AREA_ID> Delete_Area_geojson_By_AREA_ID_Async(Params_Delete_Area_geojson_By_AREA_ID i_Params_Delete_Area_geojson_By_AREA_ID)
        {
            return await Call_WebApi<Result_Delete_Area_geojson_By_AREA_ID>("/Api/SettingsManagement/Delete_Area_geojson_By_AREA_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Area_geojson_By_AREA_ID));
        }
        public Result_Edit_Default_settings Edit_Default_settings(Default_settings i_Default_settings)
        {
            return Edit_Default_settings_Async(i_Default_settings).Result;
        }
        public async Task<Result_Edit_Default_settings> Edit_Default_settings_Async(Default_settings i_Default_settings)
        {
            return await Call_WebApi<Result_Edit_Default_settings>("/Api/SettingsManagement/Edit_Default_settings", true, "POST", JsonConvert.SerializeObject(i_Default_settings));
        }
        public Result_Delete_Specialized_chart_configuration Delete_Specialized_chart_configuration(Params_Delete_Specialized_chart_configuration i_Params_Delete_Specialized_chart_configuration)
        {
            return Delete_Specialized_chart_configuration_Async(i_Params_Delete_Specialized_chart_configuration).Result;
        }
        public async Task<Result_Delete_Specialized_chart_configuration> Delete_Specialized_chart_configuration_Async(Params_Delete_Specialized_chart_configuration i_Params_Delete_Specialized_chart_configuration)
        {
            return await Call_WebApi<Result_Delete_Specialized_chart_configuration>("/Api/SettingsManagement/Delete_Specialized_chart_configuration", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Specialized_chart_configuration));
        }
        public Result_Get_Initial_Districtnex_UI_Settings Get_Initial_Districtnex_UI_Settings()
        {
            return Get_Initial_Districtnex_UI_Settings_Async().Result;
        }
        public async Task<Result_Get_Initial_Districtnex_UI_Settings> Get_Initial_Districtnex_UI_Settings_Async()
        {
            return await Call_WebApi<Result_Get_Initial_Districtnex_UI_Settings>("/Api/SettingsManagement/Get_Initial_Districtnex_UI_Settings", true, "GET");
        }
        public Result_Get_Alert_settings_By_OWNER_ID_Adv Get_Alert_settings_By_OWNER_ID_Adv(Params_Get_Alert_settings_By_OWNER_ID i_Params_Get_Alert_settings_By_OWNER_ID)
        {
            return Get_Alert_settings_By_OWNER_ID_Adv_Async(i_Params_Get_Alert_settings_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Alert_settings_By_OWNER_ID_Adv> Get_Alert_settings_By_OWNER_ID_Adv_Async(Params_Get_Alert_settings_By_OWNER_ID i_Params_Get_Alert_settings_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Alert_settings_By_OWNER_ID_Adv>("/Api/SettingsManagement/Get_Alert_settings_By_OWNER_ID_Adv", true, "GET", $"?OWNER_ID={i_Params_Get_Alert_settings_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID Get_Build_version_By_APPLICATION_NAME_SETUP_ID(Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID)
        {
            return Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Async(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID).Result;
        }
        public async Task<Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Async(Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID>("/Api/SettingsManagement/Get_Build_version_By_APPLICATION_NAME_SETUP_ID", true, "GET", $"?APPLICATION_NAME_SETUP_ID={i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID}");
        }
        public Result_Edit_Removed_extrusion_Custom Edit_Removed_extrusion_Custom(Params_Edit_Removed_extrusion_Custom i_Params_Edit_Removed_extrusion_Custom)
        {
            return Edit_Removed_extrusion_Custom_Async(i_Params_Edit_Removed_extrusion_Custom).Result;
        }
        public async Task<Result_Edit_Removed_extrusion_Custom> Edit_Removed_extrusion_Custom_Async(Params_Edit_Removed_extrusion_Custom i_Params_Edit_Removed_extrusion_Custom)
        {
            return await Call_WebApi<Result_Edit_Removed_extrusion_Custom>("/Api/SettingsManagement/Edit_Removed_extrusion_Custom", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Removed_extrusion_Custom));
        }
        public Result_Clean_Removed_extrusions Clean_Removed_extrusions()
        {
            return Clean_Removed_extrusions_Async().Result;
        }
        public async Task<Result_Clean_Removed_extrusions> Clean_Removed_extrusions_Async()
        {
            return await Call_WebApi<Result_Clean_Removed_extrusions>("/Api/SettingsManagement/Clean_Removed_extrusions", true, "POST");
        }
        public Result_Delete_Kpi_chart_configuration Delete_Kpi_chart_configuration(Params_Delete_Kpi_chart_configuration i_Params_Delete_Kpi_chart_configuration)
        {
            return Delete_Kpi_chart_configuration_Async(i_Params_Delete_Kpi_chart_configuration).Result;
        }
        public async Task<Result_Delete_Kpi_chart_configuration> Delete_Kpi_chart_configuration_Async(Params_Delete_Kpi_chart_configuration i_Params_Delete_Kpi_chart_configuration)
        {
            return await Call_WebApi<Result_Delete_Kpi_chart_configuration>("/Api/SettingsManagement/Delete_Kpi_chart_configuration", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Kpi_chart_configuration));
        }
        public Result_Get_UI_Build_Version_List Get_UI_Build_Version_List()
        {
            return Get_UI_Build_Version_List_Async().Result;
        }
        public async Task<Result_Get_UI_Build_Version_List> Get_UI_Build_Version_List_Async()
        {
            return await Call_WebApi<Result_Get_UI_Build_Version_List>("/Api/SettingsManagement/Get_UI_Build_Version_List", true, "POST");
        }
        public Result_Get_Ext_study_zone_geojson Get_Ext_study_zone_geojson()
        {
            return Get_Ext_study_zone_geojson_Async().Result;
        }
        public async Task<Result_Get_Ext_study_zone_geojson> Get_Ext_study_zone_geojson_Async()
        {
            return await Call_WebApi<Result_Get_Ext_study_zone_geojson>("/Api/SettingsManagement/Get_Ext_study_zone_geojson", true, "POST");
        }
        public Result_Custom_Edit_Build_version Custom_Edit_Build_version(Params_Custom_Edit_Build_version i_Params_Custom_Edit_Build_version)
        {
            return Custom_Edit_Build_version_Async(i_Params_Custom_Edit_Build_version).Result;
        }
        public async Task<Result_Custom_Edit_Build_version> Custom_Edit_Build_version_Async(Params_Custom_Edit_Build_version i_Params_Custom_Edit_Build_version)
        {
            return await Call_WebApi<Result_Custom_Edit_Build_version>("/Api/SettingsManagement/Custom_Edit_Build_version", true, "POST", JsonConvert.SerializeObject(i_Params_Custom_Edit_Build_version));
        }
        public Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            return Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Async(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID).Result;
        }
        public async Task<Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID> Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Async(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID>("/Api/SettingsManagement/Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", true, "GET", $"?SETUP_CATEGORY_NAME={i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME}&OWNER_ID={i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Default_chart_color_By_OWNER_ID Get_Default_chart_color_By_OWNER_ID(Params_Get_Default_chart_color_By_OWNER_ID i_Params_Get_Default_chart_color_By_OWNER_ID)
        {
            return Get_Default_chart_color_By_OWNER_ID_Async(i_Params_Get_Default_chart_color_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Default_chart_color_By_OWNER_ID> Get_Default_chart_color_By_OWNER_ID_Async(Params_Get_Default_chart_color_By_OWNER_ID i_Params_Get_Default_chart_color_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Default_chart_color_By_OWNER_ID>("/Api/SettingsManagement/Get_Default_chart_color_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Default_chart_color_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Setup_By_OWNER_ID Get_Setup_By_OWNER_ID(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            return Get_Setup_By_OWNER_ID_Async(i_Params_Get_Setup_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Setup_By_OWNER_ID> Get_Setup_By_OWNER_ID_Async(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Setup_By_OWNER_ID>("/Api/SettingsManagement/Get_Setup_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Setup_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Edit_Area_geojson Edit_Area_geojson(Params_Edit_Area_geojson i_Params_Edit_Area_geojson)
        {
            return Edit_Area_geojson_Async(i_Params_Edit_Area_geojson).Result;
        }
        public async Task<Result_Edit_Area_geojson> Edit_Area_geojson_Async(Params_Edit_Area_geojson i_Params_Edit_Area_geojson)
        {
            return await Call_WebApi<Result_Edit_Area_geojson>("/Api/SettingsManagement/Edit_Area_geojson", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Area_geojson));
        }
        public Result_Delete_Site_geojson_By_SITE_ID Delete_Site_geojson_By_SITE_ID(Params_Delete_Site_geojson_By_SITE_ID i_Params_Delete_Site_geojson_By_SITE_ID)
        {
            return Delete_Site_geojson_By_SITE_ID_Async(i_Params_Delete_Site_geojson_By_SITE_ID).Result;
        }
        public async Task<Result_Delete_Site_geojson_By_SITE_ID> Delete_Site_geojson_By_SITE_ID_Async(Params_Delete_Site_geojson_By_SITE_ID i_Params_Delete_Site_geojson_By_SITE_ID)
        {
            return await Call_WebApi<Result_Delete_Site_geojson_By_SITE_ID>("/Api/SettingsManagement/Delete_Site_geojson_By_SITE_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Site_geojson_By_SITE_ID));
        }
        public Result_Get_Admin_Build_Version_List Get_Admin_Build_Version_List()
        {
            return Get_Admin_Build_Version_List_Async().Result;
        }
        public async Task<Result_Get_Admin_Build_Version_List> Get_Admin_Build_Version_List_Async()
        {
            return await Call_WebApi<Result_Get_Admin_Build_Version_List>("/Api/SettingsManagement/Get_Admin_Build_Version_List", true, "POST");
        }
        public Result_Edit_Removed_extrusion_List Edit_Removed_extrusion_List(Params_Edit_Removed_extrusion_List i_Params_Edit_Removed_extrusion_List)
        {
            return Edit_Removed_extrusion_List_Async(i_Params_Edit_Removed_extrusion_List).Result;
        }
        public async Task<Result_Edit_Removed_extrusion_List> Edit_Removed_extrusion_List_Async(Params_Edit_Removed_extrusion_List i_Params_Edit_Removed_extrusion_List)
        {
            return await Call_WebApi<Result_Edit_Removed_extrusion_List>("/Api/SettingsManagement/Edit_Removed_extrusion_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Removed_extrusion_List));
        }
        public Result_Edit_Kpi_chart_configuration Edit_Kpi_chart_configuration(Kpi_chart_configuration i_Kpi_chart_configuration)
        {
            return Edit_Kpi_chart_configuration_Async(i_Kpi_chart_configuration).Result;
        }
        public async Task<Result_Edit_Kpi_chart_configuration> Edit_Kpi_chart_configuration_Async(Kpi_chart_configuration i_Kpi_chart_configuration)
        {
            return await Call_WebApi<Result_Edit_Kpi_chart_configuration>("/Api/SettingsManagement/Edit_Kpi_chart_configuration", true, "POST", JsonConvert.SerializeObject(i_Kpi_chart_configuration));
        }
        public Result_Get_Kpi_chart_configuration Get_Kpi_chart_configuration()
        {
            return Get_Kpi_chart_configuration_Async().Result;
        }
        public async Task<Result_Get_Kpi_chart_configuration> Get_Kpi_chart_configuration_Async()
        {
            return await Call_WebApi<Result_Get_Kpi_chart_configuration>("/Api/SettingsManagement/Get_Kpi_chart_configuration", true, "POST");
        }
        public Result_Get_Removed_extrusion_By_OWNER_ID Get_Removed_extrusion_By_OWNER_ID(Params_Get_Removed_extrusion_By_OWNER_ID i_Params_Get_Removed_extrusion_By_OWNER_ID)
        {
            return Get_Removed_extrusion_By_OWNER_ID_Async(i_Params_Get_Removed_extrusion_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Removed_extrusion_By_OWNER_ID> Get_Removed_extrusion_By_OWNER_ID_Async(Params_Get_Removed_extrusion_By_OWNER_ID i_Params_Get_Removed_extrusion_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Removed_extrusion_By_OWNER_ID>("/Api/SettingsManagement/Get_Removed_extrusion_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Removed_extrusion_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Delete_Setup Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
        {
            return Delete_Setup_Async(i_Params_Delete_Setup).Result;
        }
        public async Task<Result_Delete_Setup> Delete_Setup_Async(Params_Delete_Setup i_Params_Delete_Setup)
        {
            return await Call_WebApi<Result_Delete_Setup>("/Api/SettingsManagement/Delete_Setup", true, "DELETE", "/" + i_Params_Delete_Setup.SETUP_ID);
        }
        public Result_Get_Alert_settings_By_USER_ID_Adv Get_Alert_settings_By_USER_ID_Adv(Params_Get_Alert_settings_By_USER_ID i_Params_Get_Alert_settings_By_USER_ID)
        {
            return Get_Alert_settings_By_USER_ID_Adv_Async(i_Params_Get_Alert_settings_By_USER_ID).Result;
        }
        public async Task<Result_Get_Alert_settings_By_USER_ID_Adv> Get_Alert_settings_By_USER_ID_Adv_Async(Params_Get_Alert_settings_By_USER_ID i_Params_Get_Alert_settings_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_Alert_settings_By_USER_ID_Adv>("/Api/SettingsManagement/Get_Alert_settings_By_USER_ID_Adv", true, "GET", $"?USER_ID={i_Params_Get_Alert_settings_By_USER_ID.USER_ID}");
        }
        public Result_Send_Support_Email Send_Support_Email(Params_Send_Support_Email i_Params_Send_Support_Email)
        {
            return Send_Support_Email_Async(i_Params_Send_Support_Email).Result;
        }
        public async Task<Result_Send_Support_Email> Send_Support_Email_Async(Params_Send_Support_Email i_Params_Send_Support_Email)
        {
            return await Call_WebApi<Result_Send_Support_Email>("/Api/SettingsManagement/Send_Support_Email", true, "POST", JsonConvert.SerializeObject(i_Params_Send_Support_Email));
        }
        public Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List)
        {
            return Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Async(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List).Result;
        }
        public async Task<Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List> Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Async(Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List)
        {
            return await Call_WebApi<Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List>("/Api/SettingsManagement/Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List", true, "GET", $"?DISTRICTNEX_MODULE_ID_LIST={(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST))}");
        }
        public Result_Drop_Collection Drop_Collection(Params_Drop_Collection i_Params_Drop_Collection)
        {
            return Drop_Collection_Async(i_Params_Drop_Collection).Result;
        }
        public async Task<Result_Drop_Collection> Drop_Collection_Async(Params_Drop_Collection i_Params_Drop_Collection)
        {
            return await Call_WebApi<Result_Drop_Collection>("/Api/SettingsManagement/Drop_Collection", true, "POST", JsonConvert.SerializeObject(i_Params_Drop_Collection));
        }
        public Result_Edit_Build_version_List Edit_Build_version_List(Params_Edit_Build_version_List i_Params_Edit_Build_version_List)
        {
            return Edit_Build_version_List_Async(i_Params_Edit_Build_version_List).Result;
        }
        public async Task<Result_Edit_Build_version_List> Edit_Build_version_List_Async(Params_Edit_Build_version_List i_Params_Edit_Build_version_List)
        {
            return await Call_WebApi<Result_Edit_Build_version_List>("/Api/SettingsManagement/Edit_Build_version_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Build_version_List));
        }
        public Result_Create_Time_series_Collection Create_Time_series_Collection(Params_Create_Time_series_Collection i_Params_Create_Time_series_Collection)
        {
            return Create_Time_series_Collection_Async(i_Params_Create_Time_series_Collection).Result;
        }
        public async Task<Result_Create_Time_series_Collection> Create_Time_series_Collection_Async(Params_Create_Time_series_Collection i_Params_Create_Time_series_Collection)
        {
            return await Call_WebApi<Result_Create_Time_series_Collection>("/Api/SettingsManagement/Create_Time_series_Collection", true, "POST", JsonConvert.SerializeObject(i_Params_Create_Time_series_Collection));
        }
        public Result_Get_Setup_By_SETUP_ID Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            return Get_Setup_By_SETUP_ID_Async(i_Params_Get_Setup_By_SETUP_ID).Result;
        }
        public async Task<Result_Get_Setup_By_SETUP_ID> Get_Setup_By_SETUP_ID_Async(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_Setup_By_SETUP_ID>("/Api/SettingsManagement/Get_Setup_By_SETUP_ID", true, "GET", $"?SETUP_ID={i_Params_Get_Setup_By_SETUP_ID.SETUP_ID}");
        }
        public Result_Edit_Correlation_method Edit_Correlation_method(Correlation_method i_Correlation_method)
        {
            return Edit_Correlation_method_Async(i_Correlation_method).Result;
        }
        public async Task<Result_Edit_Correlation_method> Edit_Correlation_method_Async(Correlation_method i_Correlation_method)
        {
            return await Call_WebApi<Result_Edit_Correlation_method>("/Api/InsightsManagement/Edit_Correlation_method", true, "POST", JsonConvert.SerializeObject(i_Correlation_method));
        }
        public Result_Get_Correlation_method_By_OWNER_ID Get_Correlation_method_By_OWNER_ID(Params_Get_Correlation_method_By_OWNER_ID i_Params_Get_Correlation_method_By_OWNER_ID)
        {
            return Get_Correlation_method_By_OWNER_ID_Async(i_Params_Get_Correlation_method_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Correlation_method_By_OWNER_ID> Get_Correlation_method_By_OWNER_ID_Async(Params_Get_Correlation_method_By_OWNER_ID i_Params_Get_Correlation_method_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Correlation_method_By_OWNER_ID>("/Api/InsightsManagement/Get_Correlation_method_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Correlation_method_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Delete_Correlation_method Delete_Correlation_method(Params_Delete_Correlation_method i_Params_Delete_Correlation_method)
        {
            return Delete_Correlation_method_Async(i_Params_Delete_Correlation_method).Result;
        }
        public async Task<Result_Delete_Correlation_method> Delete_Correlation_method_Async(Params_Delete_Correlation_method i_Params_Delete_Correlation_method)
        {
            return await Call_WebApi<Result_Delete_Correlation_method>("/Api/InsightsManagement/Delete_Correlation_method", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Correlation_method));
        }
        public Result_Get_Correlation Get_Correlation(Params_Get_Correlation i_Params_Get_Correlation)
        {
            return Get_Correlation_Async(i_Params_Get_Correlation).Result;
        }
        public async Task<Result_Get_Correlation> Get_Correlation_Async(Params_Get_Correlation i_Params_Get_Correlation)
        {
            return await Call_WebApi<Result_Get_Correlation>("/Api/InsightsManagement/Get_Correlation", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Correlation));
        }
        public Result_Get_Comparison_Data Get_Comparison_Data(Params_Get_Comparison_Data i_Params_Get_Comparison_Data)
        {
            return Get_Comparison_Data_Async(i_Params_Get_Comparison_Data).Result;
        }
        public async Task<Result_Get_Comparison_Data> Get_Comparison_Data_Async(Params_Get_Comparison_Data i_Params_Get_Comparison_Data)
        {
            return await Call_WebApi<Result_Get_Comparison_Data>("/Api/InsightsManagement/Get_Comparison_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Comparison_Data));
        }
        public Result_Get_Multi_kpi_comparison Get_Multi_kpi_comparison(Params_Get_Multi_kpi_comparison i_Params_Get_Multi_kpi_comparison)
        {
            return Get_Multi_kpi_comparison_Async(i_Params_Get_Multi_kpi_comparison).Result;
        }
        public async Task<Result_Get_Multi_kpi_comparison> Get_Multi_kpi_comparison_Async(Params_Get_Multi_kpi_comparison i_Params_Get_Multi_kpi_comparison)
        {
            return await Call_WebApi<Result_Get_Multi_kpi_comparison>("/Api/InsightsManagement/Get_Multi_kpi_comparison", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Multi_kpi_comparison));
        }
        public Result_Get_Single_kpi_comparison Get_Single_kpi_comparison(Params_Get_Single_kpi_comparison i_Params_Get_Single_kpi_comparison)
        {
            return Get_Single_kpi_comparison_Async(i_Params_Get_Single_kpi_comparison).Result;
        }
        public async Task<Result_Get_Single_kpi_comparison> Get_Single_kpi_comparison_Async(Params_Get_Single_kpi_comparison i_Params_Get_Single_kpi_comparison)
        {
            return await Call_WebApi<Result_Get_Single_kpi_comparison>("/Api/InsightsManagement/Get_Single_kpi_comparison", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Single_kpi_comparison));
        }
        public Result_Fetch_Scenes Fetch_Scenes(Params_Fetch_Scenes i_Params_Fetch_Scenes)
        {
            return Fetch_Scenes_Async(i_Params_Fetch_Scenes).Result;
        }
        public async Task<Result_Fetch_Scenes> Fetch_Scenes_Async(Params_Fetch_Scenes i_Params_Fetch_Scenes)
        {
            return await Call_WebApi<Result_Fetch_Scenes>("/Api/VideoAIEngineManagement/Fetch_Scenes", true, "POST", JsonConvert.SerializeObject(i_Params_Fetch_Scenes));
        }
        public Result_Get_Vehicle_Types Get_Vehicle_Types(Params_Get_Vehicle_Types i_Params_Get_Vehicle_Types)
        {
            return Get_Vehicle_Types_Async(i_Params_Get_Vehicle_Types).Result;
        }
        public async Task<Result_Get_Vehicle_Types> Get_Vehicle_Types_Async(Params_Get_Vehicle_Types i_Params_Get_Vehicle_Types)
        {
            return await Call_WebApi<Result_Get_Vehicle_Types>("/Api/VideoAIEngineManagement/Get_Vehicle_Types", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Get_Vehicle_Types.VIDEO_AI_INSTANCE_ID}&ENTITY_ID={i_Params_Get_Vehicle_Types.ENTITY_ID}");
        }
        public Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID)
        {
            return Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Async(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID).Result;
        }
        public async Task<Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Async(Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID)
        {
            return await Call_WebApi<Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID>("/Api/VideoAIEngineManagement/Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID}");
        }
        public Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID)
        {
            return Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Async(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID).Result;
        }
        public async Task<Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Async(Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID)
        {
            return await Call_WebApi<Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID>("/Api/VideoAIEngineManagement/Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID", true, "GET", $"?VIDEO_AI_ENGINE_ID={i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID}");
        }
        public Result_Create_Video_ai_asset Create_Video_ai_asset(Params_Create_Video_ai_asset i_Params_Create_Video_ai_asset)
        {
            return Create_Video_ai_asset_Async(i_Params_Create_Video_ai_asset).Result;
        }
        public async Task<Result_Create_Video_ai_asset> Create_Video_ai_asset_Async(Params_Create_Video_ai_asset i_Params_Create_Video_ai_asset)
        {
            return await Call_WebApi<Result_Create_Video_ai_asset>("/Api/VideoAIEngineManagement/Create_Video_ai_asset", true, "POST", JsonConvert.SerializeObject(i_Params_Create_Video_ai_asset));
        }
        public Result_Update_License_Plate_Recognition_Alerts Update_License_Plate_Recognition_Alerts()
        {
            return Update_License_Plate_Recognition_Alerts_Async().Result;
        }
        public async Task<Result_Update_License_Plate_Recognition_Alerts> Update_License_Plate_Recognition_Alerts_Async()
        {
            return await Call_WebApi<Result_Update_License_Plate_Recognition_Alerts>("/Api/VideoAIEngineManagement/Update_License_Plate_Recognition_Alerts", true, "POST");
        }
        public Result_Change_Video_ai_instance_Password Change_Video_ai_instance_Password(Params_Change_Video_ai_instance_Password i_Params_Change_Video_ai_instance_Password)
        {
            return Change_Video_ai_instance_Password_Async(i_Params_Change_Video_ai_instance_Password).Result;
        }
        public async Task<Result_Change_Video_ai_instance_Password> Change_Video_ai_instance_Password_Async(Params_Change_Video_ai_instance_Password i_Params_Change_Video_ai_instance_Password)
        {
            return await Call_WebApi<Result_Change_Video_ai_instance_Password>("/Api/VideoAIEngineManagement/Change_Video_ai_instance_Password", true, "POST", JsonConvert.SerializeObject(i_Params_Change_Video_ai_instance_Password));
        }
        public Result_Face_Target_Key_Search Face_Target_Key_Search(Params_Face_Target_Key_Search i_Params_Face_Target_Key_Search)
        {
            return Face_Target_Key_Search_Async(i_Params_Face_Target_Key_Search).Result;
        }
        public async Task<Result_Face_Target_Key_Search> Face_Target_Key_Search_Async(Params_Face_Target_Key_Search i_Params_Face_Target_Key_Search)
        {
            return await Call_WebApi<Result_Face_Target_Key_Search>("/Api/VideoAIEngineManagement/Face_Target_Key_Search", true, "POST", JsonConvert.SerializeObject(i_Params_Face_Target_Key_Search));
        }
        public Result_Face_Search Face_Search(Params_Face_Search i_Params_Face_Search)
        {
            return Face_Search_Async(i_Params_Face_Search).Result;
        }
        public async Task<Result_Face_Search> Face_Search_Async(Params_Face_Search i_Params_Face_Search)
        {
            return await Call_WebApi<Result_Face_Search>("/Api/VideoAIEngineManagement/Face_Search", true, "POST", JsonConvert.SerializeObject(i_Params_Face_Search));
        }
        public Result_Fetch_License_Plate_Categories Fetch_License_Plate_Categories(Params_Fetch_License_Plate_Categories i_Params_Fetch_License_Plate_Categories)
        {
            return Fetch_License_Plate_Categories_Async(i_Params_Fetch_License_Plate_Categories).Result;
        }
        public async Task<Result_Fetch_License_Plate_Categories> Fetch_License_Plate_Categories_Async(Params_Fetch_License_Plate_Categories i_Params_Fetch_License_Plate_Categories)
        {
            return await Call_WebApi<Result_Fetch_License_Plate_Categories>("/Api/VideoAIEngineManagement/Fetch_License_Plate_Categories", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Fetch_License_Plate_Categories.VIDEO_AI_INSTANCE_ID}");
        }
        public Result_Fetch_Face_Targets Fetch_Face_Targets(Params_Fetch_Face_Targets i_Params_Fetch_Face_Targets)
        {
            return Fetch_Face_Targets_Async(i_Params_Fetch_Face_Targets).Result;
        }
        public async Task<Result_Fetch_Face_Targets> Fetch_Face_Targets_Async(Params_Fetch_Face_Targets i_Params_Fetch_Face_Targets)
        {
            return await Call_WebApi<Result_Fetch_Face_Targets>("/Api/VideoAIEngineManagement/Fetch_Face_Targets", true, "GET", $"?SIZE={i_Params_Fetch_Face_Targets.SIZE}&PAGE={i_Params_Fetch_Face_Targets.PAGE}&CATEGORY={i_Params_Fetch_Face_Targets.CATEGORY}&TARGET_NAME={i_Params_Fetch_Face_Targets.TARGET_NAME}");
        }
        public Result_Fetch_Facial_Recognition Fetch_Facial_Recognition(Params_Fetch_Facial_Recognition i_Params_Fetch_Facial_Recognition)
        {
            return Fetch_Facial_Recognition_Async(i_Params_Fetch_Facial_Recognition).Result;
        }
        public async Task<Result_Fetch_Facial_Recognition> Fetch_Facial_Recognition_Async(Params_Fetch_Facial_Recognition i_Params_Fetch_Facial_Recognition)
        {
            return await Call_WebApi<Result_Fetch_Facial_Recognition>("/Api/VideoAIEngineManagement/Fetch_Facial_Recognition", true, "POST", JsonConvert.SerializeObject(i_Params_Fetch_Facial_Recognition));
        }
        public Result_Delete_Video_ai_asset_Custom Delete_Video_ai_asset_Custom(Params_Delete_Video_ai_asset_Custom i_Params_Delete_Video_ai_asset_Custom)
        {
            return Delete_Video_ai_asset_Custom_Async(i_Params_Delete_Video_ai_asset_Custom).Result;
        }
        public async Task<Result_Delete_Video_ai_asset_Custom> Delete_Video_ai_asset_Custom_Async(Params_Delete_Video_ai_asset_Custom i_Params_Delete_Video_ai_asset_Custom)
        {
            return await Call_WebApi<Result_Delete_Video_ai_asset_Custom>("/Api/VideoAIEngineManagement/Delete_Video_ai_asset_Custom", true, "DELETE", "/" + i_Params_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID);
        }
        public Result_Update_Facial_Recognition_Alerts Update_Facial_Recognition_Alerts()
        {
            return Update_Facial_Recognition_Alerts_Async().Result;
        }
        public async Task<Result_Update_Facial_Recognition_Alerts> Update_Facial_Recognition_Alerts_Async()
        {
            return await Call_WebApi<Result_Update_Facial_Recognition_Alerts>("/Api/VideoAIEngineManagement/Update_Facial_Recognition_Alerts", true, "POST");
        }
        public Result_Get_Video_ai_engine_By_OWNER_ID Get_Video_ai_engine_By_OWNER_ID(Params_Get_Video_ai_engine_By_OWNER_ID i_Params_Get_Video_ai_engine_By_OWNER_ID)
        {
            return Get_Video_ai_engine_By_OWNER_ID_Async(i_Params_Get_Video_ai_engine_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Video_ai_engine_By_OWNER_ID> Get_Video_ai_engine_By_OWNER_ID_Async(Params_Get_Video_ai_engine_By_OWNER_ID i_Params_Get_Video_ai_engine_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Video_ai_engine_By_OWNER_ID>("/Api/VideoAIEngineManagement/Get_Video_ai_engine_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Video_ai_engine_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Fetch_License_Plate_Targets Fetch_License_Plate_Targets(Params_Fetch_License_Plate_Targets i_Params_Fetch_License_Plate_Targets)
        {
            return Fetch_License_Plate_Targets_Async(i_Params_Fetch_License_Plate_Targets).Result;
        }
        public async Task<Result_Fetch_License_Plate_Targets> Fetch_License_Plate_Targets_Async(Params_Fetch_License_Plate_Targets i_Params_Fetch_License_Plate_Targets)
        {
            return await Call_WebApi<Result_Fetch_License_Plate_Targets>("/Api/VideoAIEngineManagement/Fetch_License_Plate_Targets", true, "GET", $"?SIZE={i_Params_Fetch_License_Plate_Targets.SIZE}&PAGE={i_Params_Fetch_License_Plate_Targets.PAGE}&CATEGORY={i_Params_Fetch_License_Plate_Targets.CATEGORY}&PLATE_NUMBER={i_Params_Fetch_License_Plate_Targets.PLATE_NUMBER}");
        }
        public Result_Get_Video_ai_asset_By_OWNER_ID Get_Video_ai_asset_By_OWNER_ID(Params_Get_Video_ai_asset_By_OWNER_ID i_Params_Get_Video_ai_asset_By_OWNER_ID)
        {
            return Get_Video_ai_asset_By_OWNER_ID_Async(i_Params_Get_Video_ai_asset_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Video_ai_asset_By_OWNER_ID> Get_Video_ai_asset_By_OWNER_ID_Async(Params_Get_Video_ai_asset_By_OWNER_ID i_Params_Get_Video_ai_asset_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Video_ai_asset_By_OWNER_ID>("/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Video_ai_asset_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Stream_Data Get_Stream_Data(Params_Get_Stream_Data i_Params_Get_Stream_Data)
        {
            return Get_Stream_Data_Async(i_Params_Get_Stream_Data).Result;
        }
        public async Task<Result_Get_Stream_Data> Get_Stream_Data_Async(Params_Get_Stream_Data i_Params_Get_Stream_Data)
        {
            return await Call_WebApi<Result_Get_Stream_Data>("/Api/VideoAIEngineManagement/Get_Stream_Data", true, "GET", $"?ENTITY_ID={i_Params_Get_Stream_Data.ENTITY_ID}");
        }
        public Result_Fetch_License_Plate_Recognition Fetch_License_Plate_Recognition(Params_Fetch_License_Plate_Recognition i_Params_Fetch_License_Plate_Recognition)
        {
            return Fetch_License_Plate_Recognition_Async(i_Params_Fetch_License_Plate_Recognition).Result;
        }
        public async Task<Result_Fetch_License_Plate_Recognition> Fetch_License_Plate_Recognition_Async(Params_Fetch_License_Plate_Recognition i_Params_Fetch_License_Plate_Recognition)
        {
            return await Call_WebApi<Result_Fetch_License_Plate_Recognition>("/Api/VideoAIEngineManagement/Fetch_License_Plate_Recognition", true, "POST", JsonConvert.SerializeObject(i_Params_Fetch_License_Plate_Recognition));
        }
        public Result_Get_Scene_Info Get_Scene_Info(Params_Get_Scene_Info i_Params_Get_Scene_Info)
        {
            return Get_Scene_Info_Async(i_Params_Get_Scene_Info).Result;
        }
        public async Task<Result_Get_Scene_Info> Get_Scene_Info_Async(Params_Get_Scene_Info i_Params_Get_Scene_Info)
        {
            return await Call_WebApi<Result_Get_Scene_Info>("/Api/VideoAIEngineManagement/Get_Scene_Info", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Get_Scene_Info.VIDEO_AI_INSTANCE_ID}&SCENE_ID={i_Params_Get_Scene_Info.SCENE_ID}&OBJECT_TYPE={i_Params_Get_Scene_Info.OBJECT_TYPE}");
        }
        public Result_Update_Alerts_Custom Update_Alerts_Custom()
        {
            return Update_Alerts_Custom_Async().Result;
        }
        public async Task<Result_Update_Alerts_Custom> Update_Alerts_Custom_Async()
        {
            return await Call_WebApi<Result_Update_Alerts_Custom>("/Api/VideoAIEngineManagement/Update_Alerts_Custom", true, "POST");
        }
        public Result_Get_Countings Get_Countings(Params_Get_Countings i_Params_Get_Countings)
        {
            return Get_Countings_Async(i_Params_Get_Countings).Result;
        }
        public async Task<Result_Get_Countings> Get_Countings_Async(Params_Get_Countings i_Params_Get_Countings)
        {
            return await Call_WebApi<Result_Get_Countings>("/Api/VideoAIEngineManagement/Get_Countings", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Countings));
        }
        public Result_Get_Camera_Lines Get_Camera_Lines(Params_Get_Camera_Lines i_Params_Get_Camera_Lines)
        {
            return Get_Camera_Lines_Async(i_Params_Get_Camera_Lines).Result;
        }
        public async Task<Result_Get_Camera_Lines> Get_Camera_Lines_Async(Params_Get_Camera_Lines i_Params_Get_Camera_Lines)
        {
            return await Call_WebApi<Result_Get_Camera_Lines>("/Api/VideoAIEngineManagement/Get_Camera_Lines", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Camera_Lines));
        }
        public Result_Edit_Video_ai_asset Edit_Video_ai_asset(Video_ai_asset i_Video_ai_asset)
        {
            return Edit_Video_ai_asset_Async(i_Video_ai_asset).Result;
        }
        public async Task<Result_Edit_Video_ai_asset> Edit_Video_ai_asset_Async(Video_ai_asset i_Video_ai_asset)
        {
            return await Call_WebApi<Result_Edit_Video_ai_asset>("/Api/VideoAIEngineManagement/Edit_Video_ai_asset", true, "POST", JsonConvert.SerializeObject(i_Video_ai_asset));
        }
        public Result_Get_Space_asset_Vaidio_camera Get_Space_asset_Vaidio_camera(Params_Get_Space_asset_Vaidio_camera i_Params_Get_Space_asset_Vaidio_camera)
        {
            return Get_Space_asset_Vaidio_camera_Async(i_Params_Get_Space_asset_Vaidio_camera).Result;
        }
        public async Task<Result_Get_Space_asset_Vaidio_camera> Get_Space_asset_Vaidio_camera_Async(Params_Get_Space_asset_Vaidio_camera i_Params_Get_Space_asset_Vaidio_camera)
        {
            return await Call_WebApi<Result_Get_Space_asset_Vaidio_camera>("/Api/VideoAIEngineManagement/Get_Space_asset_Vaidio_camera", true, "GET", $"?SPACE_ASSET_ID={i_Params_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID}");
        }
        public Result_Update_Alerts Update_Alerts()
        {
            return Update_Alerts_Async().Result;
        }
        public async Task<Result_Update_Alerts> Update_Alerts_Async()
        {
            return await Call_WebApi<Result_Update_Alerts>("/Api/VideoAIEngineManagement/Update_Alerts", true, "POST");
        }
        public Result_Get_License_Plate_Scene Get_License_Plate_Scene(Params_Get_License_Plate_Scene i_Params_Get_License_Plate_Scene)
        {
            return Get_License_Plate_Scene_Async(i_Params_Get_License_Plate_Scene).Result;
        }
        public async Task<Result_Get_License_Plate_Scene> Get_License_Plate_Scene_Async(Params_Get_License_Plate_Scene i_Params_Get_License_Plate_Scene)
        {
            return await Call_WebApi<Result_Get_License_Plate_Scene>("/Api/VideoAIEngineManagement/Get_License_Plate_Scene", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Get_License_Plate_Scene.VIDEO_AI_INSTANCE_ID}&SCENE_ID={i_Params_Get_License_Plate_Scene.SCENE_ID}");
        }
        public Result_Get_Video_ai_assets_with_engine_assets Get_Video_ai_assets_with_engine_assets(Params_Get_Video_ai_assets_with_engine_assets i_Params_Get_Video_ai_assets_with_engine_assets)
        {
            return Get_Video_ai_assets_with_engine_assets_Async(i_Params_Get_Video_ai_assets_with_engine_assets).Result;
        }
        public async Task<Result_Get_Video_ai_assets_with_engine_assets> Get_Video_ai_assets_with_engine_assets_Async(Params_Get_Video_ai_assets_with_engine_assets i_Params_Get_Video_ai_assets_with_engine_assets)
        {
            return await Call_WebApi<Result_Get_Video_ai_assets_with_engine_assets>("/Api/VideoAIEngineManagement/Get_Video_ai_assets_with_engine_assets", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID}");
        }
        public Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List)
        {
            return Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv_Async(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List).Result;
        }
        public async Task<Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv> Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv_Async(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List)
        {
            return await Call_WebApi<Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv>("/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv", true, "GET", $"?SPACE_ASSET_ID_LIST={(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST))}");
        }
        public Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List)
        {
            return Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Async(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List).Result;
        }
        public async Task<Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Async(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List)
        {
            return await Call_WebApi<Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List>("/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List", true, "GET", $"?VIDEO_AI_ASSET_ID_REF_LIST={(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.VIDEO_AI_ASSET_ID_REF_LIST == null ? "" : string.Join(",", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.VIDEO_AI_ASSET_ID_REF_LIST))}");
        }
        public Result_Create_Video_ai_instance Create_Video_ai_instance(Params_Create_Video_ai_instance i_Params_Create_Video_ai_instance)
        {
            return Create_Video_ai_instance_Async(i_Params_Create_Video_ai_instance).Result;
        }
        public async Task<Result_Create_Video_ai_instance> Create_Video_ai_instance_Async(Params_Create_Video_ai_instance i_Params_Create_Video_ai_instance)
        {
            return await Call_WebApi<Result_Create_Video_ai_instance>("/Api/VideoAIEngineManagement/Create_Video_ai_instance", true, "POST", JsonConvert.SerializeObject(i_Params_Create_Video_ai_instance));
        }
        public Result_Delete_Video_ai_engine Delete_Video_ai_engine(Params_Delete_Video_ai_engine i_Params_Delete_Video_ai_engine)
        {
            return Delete_Video_ai_engine_Async(i_Params_Delete_Video_ai_engine).Result;
        }
        public async Task<Result_Delete_Video_ai_engine> Delete_Video_ai_engine_Async(Params_Delete_Video_ai_engine i_Params_Delete_Video_ai_engine)
        {
            return await Call_WebApi<Result_Delete_Video_ai_engine>("/Api/VideoAIEngineManagement/Delete_Video_ai_engine", true, "DELETE", "/" + i_Params_Delete_Video_ai_engine.VIDEO_AI_ENGINE_ID);
        }
        public Result_Fetch_Face_Target_Categories Fetch_Face_Target_Categories(Params_Fetch_Face_Target_Categories i_Params_Fetch_Face_Target_Categories)
        {
            return Fetch_Face_Target_Categories_Async(i_Params_Fetch_Face_Target_Categories).Result;
        }
        public async Task<Result_Fetch_Face_Target_Categories> Fetch_Face_Target_Categories_Async(Params_Fetch_Face_Target_Categories i_Params_Fetch_Face_Target_Categories)
        {
            return await Call_WebApi<Result_Fetch_Face_Target_Categories>("/Api/VideoAIEngineManagement/Fetch_Face_Target_Categories", true, "GET", $"?VIDEO_AI_INSTANCE_ID={i_Params_Fetch_Face_Target_Categories.VIDEO_AI_INSTANCE_ID}");
        }
        public Result_Get_Vehicle_Countings Get_Vehicle_Countings(Params_Get_Vehicle_Countings i_Params_Get_Vehicle_Countings)
        {
            return Get_Vehicle_Countings_Async(i_Params_Get_Vehicle_Countings).Result;
        }
        public async Task<Result_Get_Vehicle_Countings> Get_Vehicle_Countings_Async(Params_Get_Vehicle_Countings i_Params_Get_Vehicle_Countings)
        {
            return await Call_WebApi<Result_Get_Vehicle_Countings>("/Api/VideoAIEngineManagement/Get_Vehicle_Countings", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Vehicle_Countings));
        }
        public Result_Edit_Video_ai_instance_custom Edit_Video_ai_instance_custom(Params_Edit_Video_ai_instance_custom i_Params_Edit_Video_ai_instance_custom)
        {
            return Edit_Video_ai_instance_custom_Async(i_Params_Edit_Video_ai_instance_custom).Result;
        }
        public async Task<Result_Edit_Video_ai_instance_custom> Edit_Video_ai_instance_custom_Async(Params_Edit_Video_ai_instance_custom i_Params_Edit_Video_ai_instance_custom)
        {
            return await Call_WebApi<Result_Edit_Video_ai_instance_custom>("/Api/VideoAIEngineManagement/Edit_Video_ai_instance_custom", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Video_ai_instance_custom));
        }
        public Result_Send_Alerts_Email Send_Alerts_Email(Params_Send_Alerts_Email i_Params_Send_Alerts_Email)
        {
            return Send_Alerts_Email_Async(i_Params_Send_Alerts_Email).Result;
        }
        public async Task<Result_Send_Alerts_Email> Send_Alerts_Email_Async(Params_Send_Alerts_Email i_Params_Send_Alerts_Email)
        {
            return await Call_WebApi<Result_Send_Alerts_Email>("/Api/VideoAIEngineManagement/Send_Alerts_Email", true, "POST", JsonConvert.SerializeObject(i_Params_Send_Alerts_Email));
        }
        public Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID)
        {
            return Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv_Async(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID).Result;
        }
        public async Task<Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv_Async(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID)
        {
            return await Call_WebApi<Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv>("/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv", true, "GET", $"?VIDEO_AI_ASSET_ID={i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID}");
        }
        public Result_Delete_Video_ai_instance Delete_Video_ai_instance(Params_Delete_Video_ai_instance i_Params_Delete_Video_ai_instance)
        {
            return Delete_Video_ai_instance_Async(i_Params_Delete_Video_ai_instance).Result;
        }
        public async Task<Result_Delete_Video_ai_instance> Delete_Video_ai_instance_Async(Params_Delete_Video_ai_instance i_Params_Delete_Video_ai_instance)
        {
            return await Call_WebApi<Result_Delete_Video_ai_instance>("/Api/VideoAIEngineManagement/Delete_Video_ai_instance", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Video_ai_instance));
        }
        public Result_Edit_Video_ai_instance Edit_Video_ai_instance(Video_ai_instance i_Video_ai_instance)
        {
            return Edit_Video_ai_instance_Async(i_Video_ai_instance).Result;
        }
        public async Task<Result_Edit_Video_ai_instance> Edit_Video_ai_instance_Async(Video_ai_instance i_Video_ai_instance)
        {
            return await Call_WebApi<Result_Edit_Video_ai_instance>("/Api/VideoAIEngineManagement/Edit_Video_ai_instance", true, "POST", JsonConvert.SerializeObject(i_Video_ai_instance));
        }
        public Result_Edit_Video_ai_engine_List Edit_Video_ai_engine_List(Params_Edit_Video_ai_engine_List i_Params_Edit_Video_ai_engine_List)
        {
            return Edit_Video_ai_engine_List_Async(i_Params_Edit_Video_ai_engine_List).Result;
        }
        public async Task<Result_Edit_Video_ai_engine_List> Edit_Video_ai_engine_List_Async(Params_Edit_Video_ai_engine_List i_Params_Edit_Video_ai_engine_List)
        {
            return await Call_WebApi<Result_Edit_Video_ai_engine_List>("/Api/VideoAIEngineManagement/Edit_Video_ai_engine_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Video_ai_engine_List));
        }
        public Result_Edit_Video_ai_engine Edit_Video_ai_engine(Video_ai_engine i_Video_ai_engine)
        {
            return Edit_Video_ai_engine_Async(i_Video_ai_engine).Result;
        }
        public async Task<Result_Edit_Video_ai_engine> Edit_Video_ai_engine_Async(Video_ai_engine i_Video_ai_engine)
        {
            return await Call_WebApi<Result_Edit_Video_ai_engine>("/Api/VideoAIEngineManagement/Edit_Video_ai_engine", true, "POST", JsonConvert.SerializeObject(i_Video_ai_engine));
        }
        public Result_Get_Sites_and_Entities Get_Sites_and_Entities()
        {
            return Get_Sites_and_Entities_Async().Result;
        }
        public async Task<Result_Get_Sites_and_Entities> Get_Sites_and_Entities_Async()
        {
            return await Call_WebApi<Result_Get_Sites_and_Entities>("/Api/VideoAIEngineManagement/Get_Sites_and_Entities", true, "GET");
        }
        public Result_Delete_Object Delete_Object(Params_Delete_Object i_Params_Delete_Object)
        {
            return Delete_Object_Async(i_Params_Delete_Object).Result;
        }
        public async Task<Result_Delete_Object> Delete_Object_Async(Params_Delete_Object i_Params_Delete_Object)
        {
            return await Call_WebApi<Result_Delete_Object>("/Api/FileManagement/Delete_Object", true, "DELETE", "/" + i_Params_Delete_Object.Object_Name);
        }
        public Result_Delete_Object_List Delete_Object_List(Params_Delete_Object_List i_Params_Delete_Object_List)
        {
            return Delete_Object_List_Async(i_Params_Delete_Object_List).Result;
        }
        public async Task<Result_Delete_Object_List> Delete_Object_List_Async(Params_Delete_Object_List i_Params_Delete_Object_List)
        {
            return await Call_WebApi<Result_Delete_Object_List>("/Api/FileManagement/Delete_Object_List", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Object_List));
        }
        public Result_Upload_Object Upload_Object(Params_Upload_Object i_Params_Upload_Object)
        {
            return Upload_Object_Async(i_Params_Upload_Object).Result;
        }
        public async Task<Result_Upload_Object> Upload_Object_Async(Params_Upload_Object i_Params_Upload_Object)
        {
            return await Call_WebApi<Result_Upload_Object>("/Api/FileManagement/Upload_Object", true, "POST", JsonConvert.SerializeObject(i_Params_Upload_Object));
        }
        public Result_Get_Area_view_By_AREA_ID Get_Area_view_By_AREA_ID(Params_Get_Area_view_By_AREA_ID i_Params_Get_Area_view_By_AREA_ID)
        {
            return Get_Area_view_By_AREA_ID_Async(i_Params_Get_Area_view_By_AREA_ID).Result;
        }
        public async Task<Result_Get_Area_view_By_AREA_ID> Get_Area_view_By_AREA_ID_Async(Params_Get_Area_view_By_AREA_ID i_Params_Get_Area_view_By_AREA_ID)
        {
            return await Call_WebApi<Result_Get_Area_view_By_AREA_ID>("/Api/AreaManagement/Get_Area_view_By_AREA_ID", true, "GET", $"?AREA_ID={i_Params_Get_Area_view_By_AREA_ID.AREA_ID}");
        }
        public Result_Edit_Area_view Edit_Area_view(Area_view i_Area_view)
        {
            return Edit_Area_view_Async(i_Area_view).Result;
        }
        public async Task<Result_Edit_Area_view> Edit_Area_view_Async(Area_view i_Area_view)
        {
            return await Call_WebApi<Result_Edit_Area_view>("/Api/AreaManagement/Edit_Area_view", true, "POST", JsonConvert.SerializeObject(i_Area_view));
        }
        public Result_Edit_Area Edit_Area(Area i_Area)
        {
            return Edit_Area_Async(i_Area).Result;
        }
        public async Task<Result_Edit_Area> Edit_Area_Async(Area i_Area)
        {
            return await Call_WebApi<Result_Edit_Area>("/Api/AreaManagement/Edit_Area", true, "POST", JsonConvert.SerializeObject(i_Area));
        }
        public Result_Get_Area_geojson_By_AREA_ID_List Get_Area_geojson_By_AREA_ID_List(Params_Get_Area_geojson_By_AREA_ID_List i_Params_Get_Area_geojson_By_AREA_ID_List)
        {
            return Get_Area_geojson_By_AREA_ID_List_Async(i_Params_Get_Area_geojson_By_AREA_ID_List).Result;
        }
        public async Task<Result_Get_Area_geojson_By_AREA_ID_List> Get_Area_geojson_By_AREA_ID_List_Async(Params_Get_Area_geojson_By_AREA_ID_List i_Params_Get_Area_geojson_By_AREA_ID_List)
        {
            return await Call_WebApi<Result_Get_Area_geojson_By_AREA_ID_List>("/Api/AreaManagement/Get_Area_geojson_By_AREA_ID_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Area_geojson_By_AREA_ID_List));
        }
        public Result_Get_Area_By_OWNER_ID Get_Area_By_OWNER_ID(Params_Get_Area_By_OWNER_ID i_Params_Get_Area_By_OWNER_ID)
        {
            return Get_Area_By_OWNER_ID_Async(i_Params_Get_Area_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Area_By_OWNER_ID> Get_Area_By_OWNER_ID_Async(Params_Get_Area_By_OWNER_ID i_Params_Get_Area_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Area_By_OWNER_ID>("/Api/AreaManagement/Get_Area_By_OWNER_ID", true, "GET", $"?OWNER_ID={i_Params_Get_Area_By_OWNER_ID.OWNER_ID}");
        }
        public Result_Get_Area_By_AREA_ID_List Get_Area_By_AREA_ID_List(Params_Get_Area_By_AREA_ID_List i_Params_Get_Area_By_AREA_ID_List)
        {
            return Get_Area_By_AREA_ID_List_Async(i_Params_Get_Area_By_AREA_ID_List).Result;
        }
        public async Task<Result_Get_Area_By_AREA_ID_List> Get_Area_By_AREA_ID_List_Async(Params_Get_Area_By_AREA_ID_List i_Params_Get_Area_By_AREA_ID_List)
        {
            return await Call_WebApi<Result_Get_Area_By_AREA_ID_List>("/Api/AreaManagement/Get_Area_By_AREA_ID_List", true, "GET", $"?AREA_ID_LIST={(i_Params_Get_Area_By_AREA_ID_List.AREA_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Area_By_AREA_ID_List.AREA_ID_LIST))}");
        }
        public Result_Delete_Area_view Delete_Area_view(Params_Delete_Area_view i_Params_Delete_Area_view)
        {
            return Delete_Area_view_Async(i_Params_Delete_Area_view).Result;
        }
        public async Task<Result_Delete_Area_view> Delete_Area_view_Async(Params_Delete_Area_view i_Params_Delete_Area_view)
        {
            return await Call_WebApi<Result_Delete_Area_view>("/Api/AreaManagement/Delete_Area_view", true, "DELETE", "/" + i_Params_Delete_Area_view.AREA_VIEW_ID);
        }
        public Result_Edit_Area_view_List Edit_Area_view_List(Params_Edit_Area_view_List i_Params_Edit_Area_view_List)
        {
            return Edit_Area_view_List_Async(i_Params_Edit_Area_view_List).Result;
        }
        public async Task<Result_Edit_Area_view_List> Edit_Area_view_List_Async(Params_Edit_Area_view_List i_Params_Edit_Area_view_List)
        {
            return await Call_WebApi<Result_Edit_Area_view_List>("/Api/AreaManagement/Edit_Area_view_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Area_view_List));
        }
        public Result_Delete_Area_view_By_AREA_ID Delete_Area_view_By_AREA_ID(Params_Delete_Area_view_By_AREA_ID i_Params_Delete_Area_view_By_AREA_ID)
        {
            return Delete_Area_view_By_AREA_ID_Async(i_Params_Delete_Area_view_By_AREA_ID).Result;
        }
        public async Task<Result_Delete_Area_view_By_AREA_ID> Delete_Area_view_By_AREA_ID_Async(Params_Delete_Area_view_By_AREA_ID i_Params_Delete_Area_view_By_AREA_ID)
        {
            return await Call_WebApi<Result_Delete_Area_view_By_AREA_ID>("/Api/AreaManagement/Delete_Area_view_By_AREA_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Area_view_By_AREA_ID));
        }
        public Result_Get_Area_view_By_AREA_ID_List Get_Area_view_By_AREA_ID_List(Params_Get_Area_view_By_AREA_ID_List i_Params_Get_Area_view_By_AREA_ID_List)
        {
            return Get_Area_view_By_AREA_ID_List_Async(i_Params_Get_Area_view_By_AREA_ID_List).Result;
        }
        public async Task<Result_Get_Area_view_By_AREA_ID_List> Get_Area_view_By_AREA_ID_List_Async(Params_Get_Area_view_By_AREA_ID_List i_Params_Get_Area_view_By_AREA_ID_List)
        {
            return await Call_WebApi<Result_Get_Area_view_By_AREA_ID_List>("/Api/AreaManagement/Get_Area_view_By_AREA_ID_List", true, "GET", $"?AREA_ID_LIST={(i_Params_Get_Area_view_By_AREA_ID_List.AREA_ID_LIST == null ? "" : string.Join(",", i_Params_Get_Area_view_By_AREA_ID_List.AREA_ID_LIST))}");
        }
        public Result_Get_Secret Get_Secret(Params_Get_Secret i_Params_Get_Secret)
        {
            return Get_Secret_Async(i_Params_Get_Secret).Result;
        }
        public async Task<Result_Get_Secret> Get_Secret_Async(Params_Get_Secret i_Params_Get_Secret)
        {
            return await Call_WebApi<Result_Get_Secret>("/Api/CloudInterface/Get_Secret", true, "GET", $"?Secret_Id={i_Params_Get_Secret.Secret_Id}&Secret_Version={i_Params_Get_Secret.Secret_Version}");
        }
        public Result_Primary_Authentication Primary_Authentication(Params_Primary_Authentication i_Params_Primary_Authentication)
        {
            return Primary_Authentication_Async(i_Params_Primary_Authentication).Result;
        }
        public async Task<Result_Primary_Authentication> Primary_Authentication_Async(Params_Primary_Authentication i_Params_Primary_Authentication)
        {
            return await Call_WebApi<Result_Primary_Authentication>("/Api/UserAuthentication/Primary_Authentication", true, "POST", JsonConvert.SerializeObject(i_Params_Primary_Authentication));
        }
        public Result_OTP_Verification OTP_Verification(Params_OTP_Verification i_Params_OTP_Verification)
        {
            return OTP_Verification_Async(i_Params_OTP_Verification).Result;
        }
        public async Task<Result_OTP_Verification> OTP_Verification_Async(Params_OTP_Verification i_Params_OTP_Verification)
        {
            return await Call_WebApi<Result_OTP_Verification>("/Api/UserAuthentication/OTP_Verification", true, "POST", JsonConvert.SerializeObject(i_Params_OTP_Verification));
        }
        public Result_Send_Otp Send_Otp(Params_Send_Otp i_Params_Send_Otp)
        {
            return Send_Otp_Async(i_Params_Send_Otp).Result;
        }
        public async Task<Result_Send_Otp> Send_Otp_Async(Params_Send_Otp i_Params_Send_Otp)
        {
            return await Call_WebApi<Result_Send_Otp>("/Api/UserAuthentication/Send_Otp", true, "POST", JsonConvert.SerializeObject(i_Params_Send_Otp));
        }
        public Result_Verify_Otp Verify_Otp(Params_Verify_Otp i_Params_Verify_Otp)
        {
            return Verify_Otp_Async(i_Params_Verify_Otp).Result;
        }
        public async Task<Result_Verify_Otp> Verify_Otp_Async(Params_Verify_Otp i_Params_Verify_Otp)
        {
            return await Call_WebApi<Result_Verify_Otp>("/Api/UserAuthentication/Verify_Otp", true, "POST", JsonConvert.SerializeObject(i_Params_Verify_Otp));
        }
        public Result_Change_User_Forgotten_Password Change_User_Forgotten_Password(Params_Change_User_Forgotten_Password i_Params_Change_User_Forgotten_Password)
        {
            return Change_User_Forgotten_Password_Async(i_Params_Change_User_Forgotten_Password).Result;
        }
        public async Task<Result_Change_User_Forgotten_Password> Change_User_Forgotten_Password_Async(Params_Change_User_Forgotten_Password i_Params_Change_User_Forgotten_Password)
        {
            return await Call_WebApi<Result_Change_User_Forgotten_Password>("/Api/UserAuthentication/Change_User_Forgotten_Password", true, "POST", JsonConvert.SerializeObject(i_Params_Change_User_Forgotten_Password));
        }
        public Result_Create_User Create_User(Params_Create_User i_Params_Create_User)
        {
            return Create_User_Async(i_Params_Create_User).Result;
        }
        public async Task<Result_Create_User> Create_User_Async(Params_Create_User i_Params_Create_User)
        {
            return await Call_WebApi<Result_Create_User>("/Api/UserManagement/Create_User", true, "POST", JsonConvert.SerializeObject(i_Params_Create_User));
        }
        public Result_Change_User_Password Change_User_Password(Params_Change_User_Password i_Params_Change_User_Password)
        {
            return Change_User_Password_Async(i_Params_Change_User_Password).Result;
        }
        public async Task<Result_Change_User_Password> Change_User_Password_Async(Params_Change_User_Password i_Params_Change_User_Password)
        {
            return await Call_WebApi<Result_Change_User_Password>("/Api/UserManagement/Change_User_Password", true, "POST", JsonConvert.SerializeObject(i_Params_Change_User_Password));
        }
        public Result_Edit_Area_kpi Edit_Area_kpi(Area_kpi i_Area_kpi)
        {
            return Edit_Area_kpi_Async(i_Area_kpi).Result;
        }
        public async Task<Result_Edit_Area_kpi> Edit_Area_kpi_Async(Area_kpi i_Area_kpi)
        {
            return await Call_WebApi<Result_Edit_Area_kpi>("/Api/UserManagement/Edit_Area_kpi", true, "POST", JsonConvert.SerializeObject(i_Area_kpi));
        }
        public Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List)
        {
            return Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Async(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List).Result;
        }
        public async Task<Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Async(Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List)
        {
            return await Call_WebApi<Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List>("/Api/UserManagement/Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List", true, "GET", $"?ORGANIZATION_LEVEL_ACCESS_ID_LIST={(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST == null ? "" : string.Join(",", i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST))}");
        }
        public Result_Edit_User_Walkthrough Edit_User_Walkthrough(Params_Edit_User_Walkthrough i_Params_Edit_User_Walkthrough)
        {
            return Edit_User_Walkthrough_Async(i_Params_Edit_User_Walkthrough).Result;
        }
        public async Task<Result_Edit_User_Walkthrough> Edit_User_Walkthrough_Async(Params_Edit_User_Walkthrough i_Params_Edit_User_Walkthrough)
        {
            return await Call_WebApi<Result_Edit_User_Walkthrough>("/Api/UserManagement/Edit_User_Walkthrough", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_User_Walkthrough));
        }
        public Result_Schedule_User_for_Delete Schedule_User_for_Delete(Params_Schedule_User_for_Delete i_Params_Schedule_User_for_Delete)
        {
            return Schedule_User_for_Delete_Async(i_Params_Schedule_User_for_Delete).Result;
        }
        public async Task<Result_Schedule_User_for_Delete> Schedule_User_for_Delete_Async(Params_Schedule_User_for_Delete i_Params_Schedule_User_for_Delete)
        {
            return await Call_WebApi<Result_Schedule_User_for_Delete>("/Api/UserManagement/Schedule_User_for_Delete", true, "POST", JsonConvert.SerializeObject(i_Params_Schedule_User_for_Delete));
        }
        public Result_Get_User_Accessible_Level_List Get_User_Accessible_Level_List(Params_Get_User_Accessible_Level_List i_Params_Get_User_Accessible_Level_List)
        {
            return Get_User_Accessible_Level_List_Async(i_Params_Get_User_Accessible_Level_List).Result;
        }
        public async Task<Result_Get_User_Accessible_Level_List> Get_User_Accessible_Level_List_Async(Params_Get_User_Accessible_Level_List i_Params_Get_User_Accessible_Level_List)
        {
            return await Call_WebApi<Result_Get_User_Accessible_Level_List>("/Api/UserManagement/Get_User_Accessible_Level_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_User_Accessible_Level_List));
        }
        public Result_Edit_District_kpi_user_access_List Edit_District_kpi_user_access_List(Params_Edit_District_kpi_user_access_List i_Params_Edit_District_kpi_user_access_List)
        {
            return Edit_District_kpi_user_access_List_Async(i_Params_Edit_District_kpi_user_access_List).Result;
        }
        public async Task<Result_Edit_District_kpi_user_access_List> Edit_District_kpi_user_access_List_Async(Params_Edit_District_kpi_user_access_List i_Params_Edit_District_kpi_user_access_List)
        {
            return await Call_WebApi<Result_Edit_District_kpi_user_access_List>("/Api/UserManagement/Edit_District_kpi_user_access_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_District_kpi_user_access_List));
        }
        public Result_Delete_Area_kpi Delete_Area_kpi(Params_Delete_Area_kpi i_Params_Delete_Area_kpi)
        {
            return Delete_Area_kpi_Async(i_Params_Delete_Area_kpi).Result;
        }
        public async Task<Result_Delete_Area_kpi> Delete_Area_kpi_Async(Params_Delete_Area_kpi i_Params_Delete_Area_kpi)
        {
            return await Call_WebApi<Result_Delete_Area_kpi>("/Api/UserManagement/Delete_Area_kpi", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Area_kpi));
        }
        public Result_Get_User_level_access_By_USER_ID_List Get_User_level_access_By_USER_ID_List(Params_Get_User_level_access_By_USER_ID_List i_Params_Get_User_level_access_By_USER_ID_List)
        {
            return Get_User_level_access_By_USER_ID_List_Async(i_Params_Get_User_level_access_By_USER_ID_List).Result;
        }
        public async Task<Result_Get_User_level_access_By_USER_ID_List> Get_User_level_access_By_USER_ID_List_Async(Params_Get_User_level_access_By_USER_ID_List i_Params_Get_User_level_access_By_USER_ID_List)
        {
            return await Call_WebApi<Result_Get_User_level_access_By_USER_ID_List>("/Api/UserManagement/Get_User_level_access_By_USER_ID_List", true, "GET", $"?USER_ID_LIST={(i_Params_Get_User_level_access_By_USER_ID_List.USER_ID_LIST == null ? "" : string.Join(",", i_Params_Get_User_level_access_By_USER_ID_List.USER_ID_LIST))}");
        }
        public Result_Delete_User_level_access Delete_User_level_access(Params_Delete_User_level_access i_Params_Delete_User_level_access)
        {
            return Delete_User_level_access_Async(i_Params_Delete_User_level_access).Result;
        }
        public async Task<Result_Delete_User_level_access> Delete_User_level_access_Async(Params_Delete_User_level_access i_Params_Delete_User_level_access)
        {
            return await Call_WebApi<Result_Delete_User_level_access>("/Api/UserManagement/Delete_User_level_access", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_User_level_access));
        }
        public Result_Edit_Entity_kpi_List Edit_Entity_kpi_List(Params_Edit_Entity_kpi_List i_Params_Edit_Entity_kpi_List)
        {
            return Edit_Entity_kpi_List_Async(i_Params_Edit_Entity_kpi_List).Result;
        }
        public async Task<Result_Edit_Entity_kpi_List> Edit_Entity_kpi_List_Async(Params_Edit_Entity_kpi_List i_Params_Edit_Entity_kpi_List)
        {
            return await Call_WebApi<Result_Edit_Entity_kpi_List>("/Api/UserManagement/Edit_Entity_kpi_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Entity_kpi_List));
        }
        public Result_Get_User_By_ORGANIZATION_ID_Adv Get_User_By_ORGANIZATION_ID_Adv(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            return Get_User_By_ORGANIZATION_ID_Adv_Async(i_Params_Get_User_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_User_By_ORGANIZATION_ID_Adv> Get_User_By_ORGANIZATION_ID_Adv_Async(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_User_By_ORGANIZATION_ID_Adv>("/Api/UserManagement/Get_User_By_ORGANIZATION_ID_Adv", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Edit_User_Details Edit_User_Details(Params_Edit_User_Details i_Params_Edit_User_Details)
        {
            return Edit_User_Details_Async(i_Params_Edit_User_Details).Result;
        }
        public async Task<Result_Edit_User_Details> Edit_User_Details_Async(Params_Edit_User_Details i_Params_Edit_User_Details)
        {
            return await Call_WebApi<Result_Edit_User_Details>("/Api/UserManagement/Edit_User_Details", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_User_Details));
        }
        public Result_Edit_District_kpi_List Edit_District_kpi_List(Params_Edit_District_kpi_List i_Params_Edit_District_kpi_List)
        {
            return Edit_District_kpi_List_Async(i_Params_Edit_District_kpi_List).Result;
        }
        public async Task<Result_Edit_District_kpi_List> Edit_District_kpi_List_Async(Params_Edit_District_kpi_List i_Params_Edit_District_kpi_List)
        {
            return await Call_WebApi<Result_Edit_District_kpi_List>("/Api/UserManagement/Edit_District_kpi_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_District_kpi_List));
        }
        public Result_Edit_Entity_kpi Edit_Entity_kpi(Entity_kpi i_Entity_kpi)
        {
            return Edit_Entity_kpi_Async(i_Entity_kpi).Result;
        }
        public async Task<Result_Edit_Entity_kpi> Edit_Entity_kpi_Async(Entity_kpi i_Entity_kpi)
        {
            return await Call_WebApi<Result_Edit_Entity_kpi>("/Api/UserManagement/Edit_Entity_kpi", true, "POST", JsonConvert.SerializeObject(i_Entity_kpi));
        }
        public Result_Get_User_Accessible_Data_With_Level_List Get_User_Accessible_Data_With_Level_List(Params_Get_User_Accessible_Data_With_Level_List i_Params_Get_User_Accessible_Data_With_Level_List)
        {
            return Get_User_Accessible_Data_With_Level_List_Async(i_Params_Get_User_Accessible_Data_With_Level_List).Result;
        }
        public async Task<Result_Get_User_Accessible_Data_With_Level_List> Get_User_Accessible_Data_With_Level_List_Async(Params_Get_User_Accessible_Data_With_Level_List i_Params_Get_User_Accessible_Data_With_Level_List)
        {
            return await Call_WebApi<Result_Get_User_Accessible_Data_With_Level_List>("/Api/UserManagement/Get_User_Accessible_Data_With_Level_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_User_Accessible_Data_With_Level_List));
        }
        public Result_Get_User_districtnex_module_By_USER_ID_List Get_User_districtnex_module_By_USER_ID_List(Params_Get_User_districtnex_module_By_USER_ID_List i_Params_Get_User_districtnex_module_By_USER_ID_List)
        {
            return Get_User_districtnex_module_By_USER_ID_List_Async(i_Params_Get_User_districtnex_module_By_USER_ID_List).Result;
        }
        public async Task<Result_Get_User_districtnex_module_By_USER_ID_List> Get_User_districtnex_module_By_USER_ID_List_Async(Params_Get_User_districtnex_module_By_USER_ID_List i_Params_Get_User_districtnex_module_By_USER_ID_List)
        {
            return await Call_WebApi<Result_Get_User_districtnex_module_By_USER_ID_List>("/Api/UserManagement/Get_User_districtnex_module_By_USER_ID_List", true, "GET", $"?USER_ID_LIST={(i_Params_Get_User_districtnex_module_By_USER_ID_List.USER_ID_LIST == null ? "" : string.Join(",", i_Params_Get_User_districtnex_module_By_USER_ID_List.USER_ID_LIST))}");
        }
        public Result_Get_User_By_USER_ID_List Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            return Get_User_By_USER_ID_List_Async(i_Params_Get_User_By_USER_ID_List).Result;
        }
        public async Task<Result_Get_User_By_USER_ID_List> Get_User_By_USER_ID_List_Async(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            return await Call_WebApi<Result_Get_User_By_USER_ID_List>("/Api/UserManagement/Get_User_By_USER_ID_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List));
        }
        public Result_Get_User_districtnex_module_By_USER_ID Get_User_districtnex_module_By_USER_ID(Params_Get_User_districtnex_module_By_USER_ID i_Params_Get_User_districtnex_module_By_USER_ID)
        {
            return Get_User_districtnex_module_By_USER_ID_Async(i_Params_Get_User_districtnex_module_By_USER_ID).Result;
        }
        public async Task<Result_Get_User_districtnex_module_By_USER_ID> Get_User_districtnex_module_By_USER_ID_Async(Params_Get_User_districtnex_module_By_USER_ID i_Params_Get_User_districtnex_module_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_User_districtnex_module_By_USER_ID>("/Api/UserManagement/Get_User_districtnex_module_By_USER_ID", true, "GET", $"?USER_ID={i_Params_Get_User_districtnex_module_By_USER_ID.USER_ID}");
        }
        public Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID)
        {
            return Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Async(i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID).Result;
        }
        public async Task<Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID> Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Async(Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID)
        {
            return await Call_WebApi<Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID>("/Api/UserManagement/Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID", true, "GET", $"?USER_ID={i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.USER_ID}&DATA_LEVEL_SETUP_ID={i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID}");
        }
        public Result_Get_User_By_ORGANIZATION_ID Get_User_By_ORGANIZATION_ID(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            return Get_User_By_ORGANIZATION_ID_Async(i_Params_Get_User_By_ORGANIZATION_ID).Result;
        }
        public async Task<Result_Get_User_By_ORGANIZATION_ID> Get_User_By_ORGANIZATION_ID_Async(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            return await Call_WebApi<Result_Get_User_By_ORGANIZATION_ID>("/Api/UserManagement/Get_User_By_ORGANIZATION_ID", true, "GET", $"?ORGANIZATION_ID={i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID}");
        }
        public Result_Edit_Entity_kpi_user_access_List Edit_Entity_kpi_user_access_List(Params_Edit_Entity_kpi_user_access_List i_Params_Edit_Entity_kpi_user_access_List)
        {
            return Edit_Entity_kpi_user_access_List_Async(i_Params_Edit_Entity_kpi_user_access_List).Result;
        }
        public async Task<Result_Edit_Entity_kpi_user_access_List> Edit_Entity_kpi_user_access_List_Async(Params_Edit_Entity_kpi_user_access_List i_Params_Edit_Entity_kpi_user_access_List)
        {
            return await Call_WebApi<Result_Edit_Entity_kpi_user_access_List>("/Api/UserManagement/Edit_Entity_kpi_user_access_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Entity_kpi_user_access_List));
        }
        public Result_Get_User_By_USER_ID_List_Adv Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            return Get_User_By_USER_ID_List_Adv_Async(i_Params_Get_User_By_USER_ID_List).Result;
        }
        public async Task<Result_Get_User_By_USER_ID_List_Adv> Get_User_By_USER_ID_List_Adv_Async(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            return await Call_WebApi<Result_Get_User_By_USER_ID_List_Adv>("/Api/UserManagement/Get_User_By_USER_ID_List_Adv", true, "POST", JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List));
        }
        public Result_Edit_Site_kpi_user_access Edit_Site_kpi_user_access(Site_kpi_user_access i_Site_kpi_user_access)
        {
            return Edit_Site_kpi_user_access_Async(i_Site_kpi_user_access).Result;
        }
        public async Task<Result_Edit_Site_kpi_user_access> Edit_Site_kpi_user_access_Async(Site_kpi_user_access i_Site_kpi_user_access)
        {
            return await Call_WebApi<Result_Edit_Site_kpi_user_access>("/Api/UserManagement/Edit_Site_kpi_user_access", true, "POST", JsonConvert.SerializeObject(i_Site_kpi_user_access));
        }
        public Result_Edit_Entity_kpi_user_access Edit_Entity_kpi_user_access(Entity_kpi_user_access i_Entity_kpi_user_access)
        {
            return Edit_Entity_kpi_user_access_Async(i_Entity_kpi_user_access).Result;
        }
        public async Task<Result_Edit_Entity_kpi_user_access> Edit_Entity_kpi_user_access_Async(Entity_kpi_user_access i_Entity_kpi_user_access)
        {
            return await Call_WebApi<Result_Edit_Entity_kpi_user_access>("/Api/UserManagement/Edit_Entity_kpi_user_access", true, "POST", JsonConvert.SerializeObject(i_Entity_kpi_user_access));
        }
        public Result_Edit_Area_kpi_List Edit_Area_kpi_List(Params_Edit_Area_kpi_List i_Params_Edit_Area_kpi_List)
        {
            return Edit_Area_kpi_List_Async(i_Params_Edit_Area_kpi_List).Result;
        }
        public async Task<Result_Edit_Area_kpi_List> Edit_Area_kpi_List_Async(Params_Edit_Area_kpi_List i_Params_Edit_Area_kpi_List)
        {
            return await Call_WebApi<Result_Edit_Area_kpi_List>("/Api/UserManagement/Edit_Area_kpi_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Area_kpi_List));
        }
        public Result_Delete_Site_kpi Delete_Site_kpi(Params_Delete_Site_kpi i_Params_Delete_Site_kpi)
        {
            return Delete_Site_kpi_Async(i_Params_Delete_Site_kpi).Result;
        }
        public async Task<Result_Delete_Site_kpi> Delete_Site_kpi_Async(Params_Delete_Site_kpi i_Params_Delete_Site_kpi)
        {
            return await Call_WebApi<Result_Delete_Site_kpi>("/Api/UserManagement/Delete_Site_kpi", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Site_kpi));
        }
        public Result_Edit_User_level_access_List Edit_User_level_access_List(Params_Edit_User_level_access_List i_Params_Edit_User_level_access_List)
        {
            return Edit_User_level_access_List_Async(i_Params_Edit_User_level_access_List).Result;
        }
        public async Task<Result_Edit_User_level_access_List> Edit_User_level_access_List_Async(Params_Edit_User_level_access_List i_Params_Edit_User_level_access_List)
        {
            return await Call_WebApi<Result_Edit_User_level_access_List>("/Api/UserManagement/Edit_User_level_access_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_User_level_access_List));
        }
        public Result_Delete_Entity_kpi Delete_Entity_kpi(Params_Delete_Entity_kpi i_Params_Delete_Entity_kpi)
        {
            return Delete_Entity_kpi_Async(i_Params_Delete_Entity_kpi).Result;
        }
        public async Task<Result_Delete_Entity_kpi> Delete_Entity_kpi_Async(Params_Delete_Entity_kpi i_Params_Delete_Entity_kpi)
        {
            return await Call_WebApi<Result_Delete_Entity_kpi>("/Api/UserManagement/Delete_Entity_kpi", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi));
        }
        public Result_Get_User_Accessible_Data Get_User_Accessible_Data(Params_Get_User_Accessible_Data i_Params_Get_User_Accessible_Data)
        {
            return Get_User_Accessible_Data_Async(i_Params_Get_User_Accessible_Data).Result;
        }
        public async Task<Result_Get_User_Accessible_Data> Get_User_Accessible_Data_Async(Params_Get_User_Accessible_Data i_Params_Get_User_Accessible_Data)
        {
            return await Call_WebApi<Result_Get_User_Accessible_Data>("/Api/UserManagement/Get_User_Accessible_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_User_Accessible_Data));
        }
        public Result_Edit_User_districtnex_module_List Edit_User_districtnex_module_List(Params_Edit_User_districtnex_module_List i_Params_Edit_User_districtnex_module_List)
        {
            return Edit_User_districtnex_module_List_Async(i_Params_Edit_User_districtnex_module_List).Result;
        }
        public async Task<Result_Edit_User_districtnex_module_List> Edit_User_districtnex_module_List_Async(Params_Edit_User_districtnex_module_List i_Params_Edit_User_districtnex_module_List)
        {
            return await Call_WebApi<Result_Edit_User_districtnex_module_List>("/Api/UserManagement/Edit_User_districtnex_module_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_User_districtnex_module_List));
        }
        public Result_Edit_Site_kpi_user_access_List Edit_Site_kpi_user_access_List(Params_Edit_Site_kpi_user_access_List i_Params_Edit_Site_kpi_user_access_List)
        {
            return Edit_Site_kpi_user_access_List_Async(i_Params_Edit_Site_kpi_user_access_List).Result;
        }
        public async Task<Result_Edit_Site_kpi_user_access_List> Edit_Site_kpi_user_access_List_Async(Params_Edit_Site_kpi_user_access_List i_Params_Edit_Site_kpi_user_access_List)
        {
            return await Call_WebApi<Result_Edit_Site_kpi_user_access_List>("/Api/UserManagement/Edit_Site_kpi_user_access_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Site_kpi_user_access_List));
        }
        public Result_Get_Initial_Data Get_Initial_Data(Params_Get_Initial_Data i_Params_Get_Initial_Data)
        {
            return Get_Initial_Data_Async(i_Params_Get_Initial_Data).Result;
        }
        public async Task<Result_Get_Initial_Data> Get_Initial_Data_Async(Params_Get_Initial_Data i_Params_Get_Initial_Data)
        {
            return await Call_WebApi<Result_Get_Initial_Data>("/Api/UserManagement/Get_Initial_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Initial_Data));
        }
        public Result_Edit_District_kpi Edit_District_kpi(District_kpi i_District_kpi)
        {
            return Edit_District_kpi_Async(i_District_kpi).Result;
        }
        public async Task<Result_Edit_District_kpi> Edit_District_kpi_Async(District_kpi i_District_kpi)
        {
            return await Call_WebApi<Result_Edit_District_kpi>("/Api/UserManagement/Edit_District_kpi", true, "POST", JsonConvert.SerializeObject(i_District_kpi));
        }
        public Result_Change_Password Change_Password(Params_Change_Password i_Params_Change_Password)
        {
            return Change_Password_Async(i_Params_Change_Password).Result;
        }
        public async Task<Result_Change_Password> Change_Password_Async(Params_Change_Password i_Params_Change_Password)
        {
            return await Call_WebApi<Result_Change_Password>("/Api/UserManagement/Change_Password", true, "POST", JsonConvert.SerializeObject(i_Params_Change_Password));
        }
        public Result_Delete_District_kpi Delete_District_kpi(Params_Delete_District_kpi i_Params_Delete_District_kpi)
        {
            return Delete_District_kpi_Async(i_Params_Delete_District_kpi).Result;
        }
        public async Task<Result_Delete_District_kpi> Delete_District_kpi_Async(Params_Delete_District_kpi i_Params_Delete_District_kpi)
        {
            return await Call_WebApi<Result_Delete_District_kpi>("/Api/UserManagement/Delete_District_kpi", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_District_kpi));
        }
        public Result_Edit_Site_kpi_List Edit_Site_kpi_List(Params_Edit_Site_kpi_List i_Params_Edit_Site_kpi_List)
        {
            return Edit_Site_kpi_List_Async(i_Params_Edit_Site_kpi_List).Result;
        }
        public async Task<Result_Edit_Site_kpi_List> Edit_Site_kpi_List_Async(Params_Edit_Site_kpi_List i_Params_Edit_Site_kpi_List)
        {
            return await Call_WebApi<Result_Edit_Site_kpi_List>("/Api/UserManagement/Edit_Site_kpi_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Site_kpi_List));
        }
        public Result_Get_Entity_Intersection_List Get_Entity_Intersection_List(Params_Get_Entity_Intersection_List i_Params_Get_Entity_Intersection_List)
        {
            return Get_Entity_Intersection_List_Async(i_Params_Get_Entity_Intersection_List).Result;
        }
        public async Task<Result_Get_Entity_Intersection_List> Get_Entity_Intersection_List_Async(Params_Get_Entity_Intersection_List i_Params_Get_Entity_Intersection_List)
        {
            return await Call_WebApi<Result_Get_Entity_Intersection_List>("/Api/UserManagement/Get_Entity_Intersection_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Entity_Intersection_List));
        }
        public Result_Check_User_Deletion_Status Check_User_Deletion_Status()
        {
            return Check_User_Deletion_Status_Async().Result;
        }
        public async Task<Result_Check_User_Deletion_Status> Check_User_Deletion_Status_Async()
        {
            return await Call_WebApi<Result_Check_User_Deletion_Status>("/Api/UserManagement/Check_User_Deletion_Status", true, "POST");
        }
        public Result_Get_User_By_IS_RECEIVE_EMAIL Get_User_By_IS_RECEIVE_EMAIL(Params_Get_User_By_IS_RECEIVE_EMAIL i_Params_Get_User_By_IS_RECEIVE_EMAIL)
        {
            return Get_User_By_IS_RECEIVE_EMAIL_Async(i_Params_Get_User_By_IS_RECEIVE_EMAIL).Result;
        }
        public async Task<Result_Get_User_By_IS_RECEIVE_EMAIL> Get_User_By_IS_RECEIVE_EMAIL_Async(Params_Get_User_By_IS_RECEIVE_EMAIL i_Params_Get_User_By_IS_RECEIVE_EMAIL)
        {
            return await Call_WebApi<Result_Get_User_By_IS_RECEIVE_EMAIL>("/Api/UserManagement/Get_User_By_IS_RECEIVE_EMAIL", true, "GET", $"?IS_RECEIVE_EMAIL={i_Params_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL}");
        }
        public Result_Get_User_By_USER_ID Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            return Get_User_By_USER_ID_Async(i_Params_Get_User_By_USER_ID).Result;
        }
        public async Task<Result_Get_User_By_USER_ID> Get_User_By_USER_ID_Async(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_User_By_USER_ID>("/Api/UserManagement/Get_User_By_USER_ID", true, "GET", $"?USER_ID={i_Params_Get_User_By_USER_ID.USER_ID}");
        }
        public Result_Get_User_level_access_By_USER_ID Get_User_level_access_By_USER_ID(Params_Get_User_level_access_By_USER_ID i_Params_Get_User_level_access_By_USER_ID)
        {
            return Get_User_level_access_By_USER_ID_Async(i_Params_Get_User_level_access_By_USER_ID).Result;
        }
        public async Task<Result_Get_User_level_access_By_USER_ID> Get_User_level_access_By_USER_ID_Async(Params_Get_User_level_access_By_USER_ID i_Params_Get_User_level_access_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_User_level_access_By_USER_ID>("/Api/UserManagement/Get_User_level_access_By_USER_ID", true, "GET", $"?USER_ID={i_Params_Get_User_level_access_By_USER_ID.USER_ID}");
        }
        public Result_Get_Level_Data Get_Level_Data(Params_Get_Level_Data i_Params_Get_Level_Data)
        {
            return Get_Level_Data_Async(i_Params_Get_Level_Data).Result;
        }
        public async Task<Result_Get_Level_Data> Get_Level_Data_Async(Params_Get_Level_Data i_Params_Get_Level_Data)
        {
            return await Call_WebApi<Result_Get_Level_Data>("/Api/UserManagement/Get_Level_Data", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Level_Data));
        }
        public Result_Restore_User Restore_User(Params_Restore_User i_Params_Restore_User)
        {
            return Restore_User_Async(i_Params_Restore_User).Result;
        }
        public async Task<Result_Restore_User> Restore_User_Async(Params_Restore_User i_Params_Restore_User)
        {
            return await Call_WebApi<Result_Restore_User>("/Api/UserManagement/Restore_User", true, "POST", JsonConvert.SerializeObject(i_Params_Restore_User));
        }
        public Result_Get_User_districtnex_module_By_USER_ID_Adv Get_User_districtnex_module_By_USER_ID_Adv(Params_Get_User_districtnex_module_By_USER_ID i_Params_Get_User_districtnex_module_By_USER_ID)
        {
            return Get_User_districtnex_module_By_USER_ID_Adv_Async(i_Params_Get_User_districtnex_module_By_USER_ID).Result;
        }
        public async Task<Result_Get_User_districtnex_module_By_USER_ID_Adv> Get_User_districtnex_module_By_USER_ID_Adv_Async(Params_Get_User_districtnex_module_By_USER_ID i_Params_Get_User_districtnex_module_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_User_districtnex_module_By_USER_ID_Adv>("/Api/UserManagement/Get_User_districtnex_module_By_USER_ID_Adv", true, "GET", $"?USER_ID={i_Params_Get_User_districtnex_module_By_USER_ID.USER_ID}");
        }
        public Result_Edit_User_theme Edit_User_theme(User_theme i_User_theme)
        {
            return Edit_User_theme_Async(i_User_theme).Result;
        }
        public async Task<Result_Edit_User_theme> Edit_User_theme_Async(User_theme i_User_theme)
        {
            return await Call_WebApi<Result_Edit_User_theme>("/Api/UserManagement/Edit_User_theme", true, "POST", JsonConvert.SerializeObject(i_User_theme));
        }
        public Result_Edit_User_List Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
        {
            return Edit_User_List_Async(i_Params_Edit_User_List).Result;
        }
        public async Task<Result_Edit_User_List> Edit_User_List_Async(Params_Edit_User_List i_Params_Edit_User_List)
        {
            return await Call_WebApi<Result_Edit_User_List>("/Api/UserManagement/Edit_User_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_User_List));
        }
        public Result_Get_Admin_Data Get_Admin_Data(Params_Get_Admin_Data i_Params_Get_Admin_Data)
        {
            return Get_Admin_Data_Async(i_Params_Get_Admin_Data).Result;
        }
        public async Task<Result_Get_Admin_Data> Get_Admin_Data_Async(Params_Get_Admin_Data i_Params_Get_Admin_Data)
        {
            return await Call_WebApi<Result_Get_Admin_Data>("/Api/UserManagement/Get_Admin_Data", true, "GET", $"?USER_ID={i_Params_Get_Admin_Data.USER_ID}&IS_GET_IMAGES_FROM_Cloud={i_Params_Get_Admin_Data.IS_GET_IMAGES_FROM_Cloud}");
        }
        public Result_Get_User_By_USER_ID_Adv Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            return Get_User_By_USER_ID_Adv_Async(i_Params_Get_User_By_USER_ID).Result;
        }
        public async Task<Result_Get_User_By_USER_ID_Adv> Get_User_By_USER_ID_Adv_Async(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_User_By_USER_ID_Adv>("/Api/UserManagement/Get_User_By_USER_ID_Adv", true, "GET", $"?USER_ID={i_Params_Get_User_By_USER_ID.USER_ID}");
        }
        public Result_Get_User_theme_By_USER_ID Get_User_theme_By_USER_ID(Params_Get_User_theme_By_USER_ID i_Params_Get_User_theme_By_USER_ID)
        {
            return Get_User_theme_By_USER_ID_Async(i_Params_Get_User_theme_By_USER_ID).Result;
        }
        public async Task<Result_Get_User_theme_By_USER_ID> Get_User_theme_By_USER_ID_Async(Params_Get_User_theme_By_USER_ID i_Params_Get_User_theme_By_USER_ID)
        {
            return await Call_WebApi<Result_Get_User_theme_By_USER_ID>("/Api/UserManagement/Get_User_theme_By_USER_ID", true, "GET", $"?USER_ID={i_Params_Get_User_theme_By_USER_ID.USER_ID}");
        }
        public Result_Edit_Site_kpi Edit_Site_kpi(Site_kpi i_Site_kpi)
        {
            return Edit_Site_kpi_Async(i_Site_kpi).Result;
        }
        public async Task<Result_Edit_Site_kpi> Edit_Site_kpi_Async(Site_kpi i_Site_kpi)
        {
            return await Call_WebApi<Result_Edit_Site_kpi>("/Api/UserManagement/Edit_Site_kpi", true, "POST", JsonConvert.SerializeObject(i_Site_kpi));
        }
        public Result_Edit_Area_kpi_user_access_List Edit_Area_kpi_user_access_List(Params_Edit_Area_kpi_user_access_List i_Params_Edit_Area_kpi_user_access_List)
        {
            return Edit_Area_kpi_user_access_List_Async(i_Params_Edit_Area_kpi_user_access_List).Result;
        }
        public async Task<Result_Edit_Area_kpi_user_access_List> Edit_Area_kpi_user_access_List_Async(Params_Edit_Area_kpi_user_access_List i_Params_Edit_Area_kpi_user_access_List)
        {
            return await Call_WebApi<Result_Edit_Area_kpi_user_access_List>("/Api/UserManagement/Edit_Area_kpi_user_access_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Area_kpi_user_access_List));
        }
        public Result_Delete_User_theme Delete_User_theme(Params_Delete_User_theme i_Params_Delete_User_theme)
        {
            return Delete_User_theme_Async(i_Params_Delete_User_theme).Result;
        }
        public async Task<Result_Delete_User_theme> Delete_User_theme_Async(Params_Delete_User_theme i_Params_Delete_User_theme)
        {
            return await Call_WebApi<Result_Delete_User_theme>("/Api/UserManagement/Delete_User_theme", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_User_theme));
        }
        public Result_Edit_Area_kpi_user_access Edit_Area_kpi_user_access(Area_kpi_user_access i_Area_kpi_user_access)
        {
            return Edit_Area_kpi_user_access_Async(i_Area_kpi_user_access).Result;
        }
        public async Task<Result_Edit_Area_kpi_user_access> Edit_Area_kpi_user_access_Async(Area_kpi_user_access i_Area_kpi_user_access)
        {
            return await Call_WebApi<Result_Edit_Area_kpi_user_access>("/Api/UserManagement/Edit_Area_kpi_user_access", true, "POST", JsonConvert.SerializeObject(i_Area_kpi_user_access));
        }
        public Result_Edit_District_kpi_user_access Edit_District_kpi_user_access(District_kpi_user_access i_District_kpi_user_access)
        {
            return Edit_District_kpi_user_access_Async(i_District_kpi_user_access).Result;
        }
        public async Task<Result_Edit_District_kpi_user_access> Edit_District_kpi_user_access_Async(District_kpi_user_access i_District_kpi_user_access)
        {
            return await Call_WebApi<Result_Edit_District_kpi_user_access>("/Api/UserManagement/Edit_District_kpi_user_access", true, "POST", JsonConvert.SerializeObject(i_District_kpi_user_access));
        }
        public Result_Modify_User_Details Modify_User_Details(Params_Modify_User_Details i_Params_Modify_User_Details)
        {
            return Modify_User_Details_Async(i_Params_Modify_User_Details).Result;
        }
        public async Task<Result_Modify_User_Details> Modify_User_Details_Async(Params_Modify_User_Details i_Params_Modify_User_Details)
        {
            return await Call_WebApi<Result_Modify_User_Details>("/Api/UserManagement/Modify_User_Details", true, "POST", JsonConvert.SerializeObject(i_Params_Modify_User_Details));
        }
        public Result_Get_Dimension_Index_With_Simple_Upper_Level Get_Dimension_Index_With_Simple_Upper_Level(Params_Get_Dimension_Index_With_Simple_Upper_Level i_Params_Get_Dimension_Index_With_Simple_Upper_Level)
        {
            return Get_Dimension_Index_With_Simple_Upper_Level_Async(i_Params_Get_Dimension_Index_With_Simple_Upper_Level).Result;
        }
        public async Task<Result_Get_Dimension_Index_With_Simple_Upper_Level> Get_Dimension_Index_With_Simple_Upper_Level_Async(Params_Get_Dimension_Index_With_Simple_Upper_Level i_Params_Get_Dimension_Index_With_Simple_Upper_Level)
        {
            return await Call_WebApi<Result_Get_Dimension_Index_With_Simple_Upper_Level>("/Api/UserManagement/Get_Dimension_Index_With_Simple_Upper_Level", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Dimension_Index_With_Simple_Upper_Level));
        }
        public Result_Get_Incidents_By_Where_Sorted_With_Pagination Get_Incidents_By_Where_Sorted_With_Pagination(Params_Get_Incidents_By_Where_Sorted_With_Pagination i_Params_Get_Incidents_By_Where_Sorted_With_Pagination)
        {
            return Get_Incidents_By_Where_Sorted_With_Pagination_Async(i_Params_Get_Incidents_By_Where_Sorted_With_Pagination).Result;
        }
        public async Task<Result_Get_Incidents_By_Where_Sorted_With_Pagination> Get_Incidents_By_Where_Sorted_With_Pagination_Async(Params_Get_Incidents_By_Where_Sorted_With_Pagination i_Params_Get_Incidents_By_Where_Sorted_With_Pagination)
        {
            return await Call_WebApi<Result_Get_Incidents_By_Where_Sorted_With_Pagination>("/Api/SecurityDimension/Get_Incidents_By_Where_Sorted_With_Pagination", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Incidents_By_Where_Sorted_With_Pagination));
        }
        public Result_Edit_Incident_List Edit_Incident_List(Params_Edit_Incident_List i_Params_Edit_Incident_List)
        {
            return Edit_Incident_List_Async(i_Params_Edit_Incident_List).Result;
        }
        public async Task<Result_Edit_Incident_List> Edit_Incident_List_Async(Params_Edit_Incident_List i_Params_Edit_Incident_List)
        {
            return await Call_WebApi<Result_Edit_Incident_List>("/Api/SecurityDimension/Edit_Incident_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Incident_List));
        }
        public Result_Delete_Incident Delete_Incident()
        {
            return Delete_Incident_Async().Result;
        }
        public async Task<Result_Delete_Incident> Delete_Incident_Async()
        {
            return await Call_WebApi<Result_Delete_Incident>("/Api/SecurityDimension/Delete_Incident", true, "POST");
        }
        public Result_Get_Incidents_By_Where_Count Get_Incidents_By_Where_Count(Params_Get_Incidents_By_Where_Count i_Params_Get_Incidents_By_Where_Count)
        {
            return Get_Incidents_By_Where_Count_Async(i_Params_Get_Incidents_By_Where_Count).Result;
        }
        public async Task<Result_Get_Incidents_By_Where_Count> Get_Incidents_By_Where_Count_Async(Params_Get_Incidents_By_Where_Count i_Params_Get_Incidents_By_Where_Count)
        {
            return await Call_WebApi<Result_Get_Incidents_By_Where_Count>("/Api/SecurityDimension/Get_Incidents_By_Where_Count", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Incidents_By_Where_Count));
        }
        public Result_Get_Incidents_By_Where Get_Incidents_By_Where(Params_Get_Incidents_By_Where i_Params_Get_Incidents_By_Where)
        {
            return Get_Incidents_By_Where_Async(i_Params_Get_Incidents_By_Where).Result;
        }
        public async Task<Result_Get_Incidents_By_Where> Get_Incidents_By_Where_Async(Params_Get_Incidents_By_Where i_Params_Get_Incidents_By_Where)
        {
            return await Call_WebApi<Result_Get_Incidents_By_Where>("/Api/SecurityDimension/Get_Incidents_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Incidents_By_Where));
        }
        public Result_Get_Method_run_By_METHOD_RUN_ID Get_Method_run_By_METHOD_RUN_ID(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
        {
            return Get_Method_run_By_METHOD_RUN_ID_Async(i_Params_Get_Method_run_By_METHOD_RUN_ID).Result;
        }
        public async Task<Result_Get_Method_run_By_METHOD_RUN_ID> Get_Method_run_By_METHOD_RUN_ID_Async(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
        {
            return await Call_WebApi<Result_Get_Method_run_By_METHOD_RUN_ID>("/Api/MethodMonitoring/Get_Method_run_By_METHOD_RUN_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID));
        }
        public Result_Get_Method_run_By_METHOD_RUN_ID_List Get_Method_run_By_METHOD_RUN_ID_List(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
        {
            return Get_Method_run_By_METHOD_RUN_ID_List_Async(i_Params_Get_Method_run_By_METHOD_RUN_ID_List).Result;
        }
        public async Task<Result_Get_Method_run_By_METHOD_RUN_ID_List> Get_Method_run_By_METHOD_RUN_ID_List_Async(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
        {
            return await Call_WebApi<Result_Get_Method_run_By_METHOD_RUN_ID_List>("/Api/MethodMonitoring/Get_Method_run_By_METHOD_RUN_ID_List", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID_List));
        }
        public Result_Get_Method_run_By_OWNER_ID Get_Method_run_By_OWNER_ID(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
        {
            return Get_Method_run_By_OWNER_ID_Async(i_Params_Get_Method_run_By_OWNER_ID).Result;
        }
        public async Task<Result_Get_Method_run_By_OWNER_ID> Get_Method_run_By_OWNER_ID_Async(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Get_Method_run_By_OWNER_ID>("/Api/MethodMonitoring/Get_Method_run_By_OWNER_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID));
        }
        public Result_Get_Method_run_By_OWNER_ID_IS_DELETED Get_Method_run_By_OWNER_ID_IS_DELETED(Params_Get_Method_run_By_OWNER_ID_IS_DELETED i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED)
        {
            return Get_Method_run_By_OWNER_ID_IS_DELETED_Async(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED).Result;
        }
        public async Task<Result_Get_Method_run_By_OWNER_ID_IS_DELETED> Get_Method_run_By_OWNER_ID_IS_DELETED_Async(Params_Get_Method_run_By_OWNER_ID_IS_DELETED i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED)
        {
            return await Call_WebApi<Result_Get_Method_run_By_OWNER_ID_IS_DELETED>("/Api/MethodMonitoring/Get_Method_run_By_OWNER_ID_IS_DELETED", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED));
        }
        public Result_Get_Method_run_By_Where Get_Method_run_By_Where(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
        {
            return Get_Method_run_By_Where_Async(i_Params_Get_Method_run_By_Where).Result;
        }
        public async Task<Result_Get_Method_run_By_Where> Get_Method_run_By_Where_Async(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
        {
            return await Call_WebApi<Result_Get_Method_run_By_Where>("/Api/MethodMonitoring/Get_Method_run_By_Where", true, "POST", JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where));
        }
        public Result_Delete_Method_run Delete_Method_run(Params_Delete_Method_run i_Params_Delete_Method_run)
        {
            return Delete_Method_run_Async(i_Params_Delete_Method_run).Result;
        }
        public async Task<Result_Delete_Method_run> Delete_Method_run_Async(Params_Delete_Method_run i_Params_Delete_Method_run)
        {
            return await Call_WebApi<Result_Delete_Method_run>("/Api/MethodMonitoring/Delete_Method_run", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Method_run));
        }
        public Result_Delete_Method_run_By_OWNER_ID Delete_Method_run_By_OWNER_ID(Params_Delete_Method_run_By_OWNER_ID i_Params_Delete_Method_run_By_OWNER_ID)
        {
            return Delete_Method_run_By_OWNER_ID_Async(i_Params_Delete_Method_run_By_OWNER_ID).Result;
        }
        public async Task<Result_Delete_Method_run_By_OWNER_ID> Delete_Method_run_By_OWNER_ID_Async(Params_Delete_Method_run_By_OWNER_ID i_Params_Delete_Method_run_By_OWNER_ID)
        {
            return await Call_WebApi<Result_Delete_Method_run_By_OWNER_ID>("/Api/MethodMonitoring/Delete_Method_run_By_OWNER_ID", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Method_run_By_OWNER_ID));
        }
        public Result_Delete_Method_run_By_OWNER_ID_IS_DELETED Delete_Method_run_By_OWNER_ID_IS_DELETED(Params_Delete_Method_run_By_OWNER_ID_IS_DELETED i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED)
        {
            return Delete_Method_run_By_OWNER_ID_IS_DELETED_Async(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED).Result;
        }
        public async Task<Result_Delete_Method_run_By_OWNER_ID_IS_DELETED> Delete_Method_run_By_OWNER_ID_IS_DELETED_Async(Params_Delete_Method_run_By_OWNER_ID_IS_DELETED i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED)
        {
            return await Call_WebApi<Result_Delete_Method_run_By_OWNER_ID_IS_DELETED>("/Api/MethodMonitoring/Delete_Method_run_By_OWNER_ID_IS_DELETED", true, "POST", JsonConvert.SerializeObject(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED));
        }
        public Result_Edit_Method_run Edit_Method_run(Method_run i_Method_run)
        {
            return Edit_Method_run_Async(i_Method_run).Result;
        }
        public async Task<Result_Edit_Method_run> Edit_Method_run_Async(Method_run i_Method_run)
        {
            return await Call_WebApi<Result_Edit_Method_run>("/Api/MethodMonitoring/Edit_Method_run", true, "POST", JsonConvert.SerializeObject(i_Method_run));
        }
        public Result_Edit_Method_run_List Edit_Method_run_List(Params_Edit_Method_run_List i_Params_Edit_Method_run_List)
        {
            return Edit_Method_run_List_Async(i_Params_Edit_Method_run_List).Result;
        }
        public async Task<Result_Edit_Method_run_List> Edit_Method_run_List_Async(Params_Edit_Method_run_List i_Params_Edit_Method_run_List)
        {
            return await Call_WebApi<Result_Edit_Method_run_List>("/Api/MethodMonitoring/Edit_Method_run_List", true, "POST", JsonConvert.SerializeObject(i_Params_Edit_Method_run_List));
        }
    }
    #region Action_Result
    public partial class Action_Result
    {
        #region Properties.
        public string Stack_Trace { get; set; }
        public string Exception_Message { get; set; }
        #endregion
        #region Constructor
        public Action_Result()
        {
            #region Body Section.
            this.Stack_Trace = string.Empty;
            this.Exception_Message = string.Empty;
            #endregion
        }
        #endregion
    }
    #endregion
    public enum Enum_Timespan
    {
        X_HOURLY_COLLECTION,
        X_DAILY_COLLECTION,
        X_WEEKLY_COLLECTION,
        X_MONTHLY_COLLECTION,
        X_QUARTERLY_COLLECTION
    }
    public enum Enum_Dimension_Status
    {
        ENABLED,
        DISABLED,
        HIDDEN
    }
    public partial class Accessible_Level_ID_List_By_Top_Level
    {
        public long? TOP_LEVEL_ID { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
    }
    public partial class Accessible_Level_List_By_Top_Level
    {
        public Top_level TOP_LEVEL { get; set; }
        public List<District> DISTRICT_LIST { get; set; }
        public List<Area> AREA_LIST { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public List<Entity> ENTITY_LIST { get; set; }
        public List<Entity> INTERSECTION_LIST { get; set; }
    }
    public partial class Action_Button
    {
        public string ICON { get; set; }
        public string FUNCTIONALITY { get; set; }
        public string TOOLTIP { get; set; }
    }
    public partial class Admin_Data
    {
        public int NUMBER_OF_USERS { get; set; }
        public List<Site> List_Site { get; set; }
        public List<Entity> List_Entity { get; set; }
        public Organization Organization { get; set; }
        public List<Dimension> List_Dimension { get; set; }
        public List<Setup_category> List_Setup_category { get; set; }
        public List<Districtnex_module> List_Districtnex_module { get; set; }
    }
    public partial class Alert
    {
        public string ALERT_ID { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public decimal? ALERT_VALUE { get; set; }
        public decimal? VALUE_PASSED { get; set; }
        public long? VALUE_TYPE_SETUP_ID { get; set; }
        public long? OPERATION_TYPE_SETUP_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public object Object { get; set; }
    }
    public partial class Alert_settings
    {
        public long? ALERT_SETTINGS_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? KPI_ID { get; set; }
        public decimal? VALUE { get; set; }
        public long? VALUE_TYPE_SETUP_ID { get; set; }
        public long? OPERATION_SETUP_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Kpi Kpi { get; set; }
        public Setup Operation_setup { get; set; }
        public Setup Value_type_setup { get; set; }
        public User User { get; set; }
    }
    public partial class Area
    {
        public List<Site> List_Site { get; set; }
        public long? AREA_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
        public List<Area_view> List_Area_view { get; set; }
    }
    public partial class Area_kpi
    {
        public long? AREA_KPI_ID { get; set; }
        public long? AREA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Area Area { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
    }
    public partial class Area_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Area_metadata AREA_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    public partial class Area_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    public partial class Area_kpi_user_access
    {
        public long? AREA_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? AREA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Area Area { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
    }
    public partial class Area_metadata
    {
        public long AREA_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    public partial class Area_view
    {
        public long? AREA_VIEW_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Area Area { get; set; }
        public Setup View_type_setup { get; set; }
    }
    public partial class Asset
    {
        public long? ASSET_ID { get; set; }
        public long? ASSET_TYPE_SETUP_ID { get; set; }
        public string NAME { get; set; }
        public string GLTF_URL { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Setup Asset_type_setup { get; set; }
    }
    public partial class Asset_Data
    {
        public List<Incident> SPACE_ASSET_SECURITY_INCIDENT_LIST { get; set; }
        public List<Incident> SPACE_ASSET_ENERGY_INCIDENT_LIST { get; set; }
    }
    public partial class Asset_definition
    {
        public long? LEVEL_ID { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    public partial class Best_And_Worst_Object
    {
        public Performance_object Best_Performance_object { get; set; }
        public Performance_object Worst_Performance_object { get; set; }
    }
    public partial class Brand_Api_Response
    {
        public long BrandId { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
    public partial class Bucket
    {
        public DateTime? TIMEFRAME_BUCKET { get; set; }
        public long? COUNT { get; set; }
        public List<Output> LIST_OUTPUT { get; set; }
    }
    public partial class Build_version
    {
        public int? BUILD_VERSION_ID { get; set; }
        public string BUILD_NUMBER { get; set; }
        public long? APPLICATION_NAME_SETUP_ID { get; set; }
        public bool IS_CURRENT { get; set; }
        public string BUILD_DATE { get; set; }
        public string COMMENTS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Setup Application_name_setup { get; set; }
        public List<Build_version_log> List_Build_version_log { get; set; }
    }
    public partial class Build_Version_List_With_Logs
    {
        public List<Build_version> LIST_BUILD_VERSION { get; set; }
        public Setup_category BUILD_LOG_TYPE_SETUP_CATEGORY { get; set; }
    }
    public partial class Build_version_log
    {
        public int? BUILD_VERSION_LOG_ID { get; set; }
        public int? BUILD_VERSION_ID { get; set; }
        public long? BUILD_LOG_TYPE_SETUP_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Build_version Build_version { get; set; }
        public Setup Build_log_type_setup { get; set; }
    }
    public partial class Business
    {
        public string BUSINESS_ID { get; set; }
        public string ICON { get; set; }
        public string ICON_BACKGROUND_COLOR { get; set; }
        public string ICON_MASK_BASE_URI { get; set; }
        public string NAME { get; set; }
        public string PLACE_ID { get; set; }
        public string REFERENCE { get; set; }
        public string SCOPE { get; set; }
        public List<string> LIST_BUSINESS_CATEGORY { get; set; }
        public string BUSINESS_NICHE { get; set; }
        public string VICINITY { get; set; }
        public string BUSINESS_STATUS { get; set; }
        public decimal? RATING { get; set; }
        public long? USER_RATINGS_TOTAL { get; set; }
        public bool? OPEN_NOW { get; set; }
        public long? PRICE_LEVEL { get; set; }
        public string COMPOUND_CODE { get; set; }
        public string GLOBAL_CODE { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    public partial class Bylaw_Complaint
    {
        public string BYLAW_COMPLAINT_ID { get; set; }
        public string ROW_ID { get; set; }
        public string YEAR { get; set; }
        public string MONTH { get; set; }
        public string COMPLAINT_CATEGORY { get; set; }
        public string TYPE_OF_COMPLAINT { get; set; }
        public DateTime? DATE_CREATED { get; set; }
        public string WAS_CANNABIS_INVOLVED { get; set; }
        public string OFFICER_INITIATED { get; set; }
        public string INFRACTION_STATUS { get; set; }
        public string NEIGHBOURHOOD_ID { get; set; }
        public string NEIGHBOURHOOD { get; set; }
        public string FULL_NAME_OF_STREET { get; set; }
        public string COUNT { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    public partial class Camera_Lines
    {
        public Surveillance_Camera_Content Camera { get; set; }
        public List<Get_Line_Sets_Response> LineSets { get; set; }
    }
    public partial class Change_Video_ai_instance_Password_Response
    {
        public bool SUCCESSFUL_PASSWORD_CHANGE { get; set; }
        public bool IS_FORCE_CONNECTION { get; set; }
        public string RESPONSE_MESSAGE { get; set; }
    }
    public partial class Characteristic
    {
        public decimal? PERCENTAGE { get; set; }
        public string CHARACTERISTIC { get; set; }
    }
    public partial class Comparison_Data
    {
        public List<District_kpi_data> LIST_DISTRICT_KPI_DATA_DWELL_TIME { get; set; }
        public List<District_kpi_data> LIST_DISTRICT_KPI_DATA_NUMBER_OF_VISITORS { get; set; }
        public List<Business> LIST_DISTRICT_BUSINESS_COUNT { get; set; }
        public List<Area_kpi_data> LIST_AREA_KPI_DATA_DWELL_TIME { get; set; }
        public List<Area_kpi_data> LIST_AREA_KPI_DATA_NUMBER_OF_VISITORS { get; set; }
        public List<Business> LIST_AREA_BUSINESS_COUNT { get; set; }
        public List<Site_kpi_data> LIST_SITE_KPI_DATA_DWELL_TIME { get; set; }
        public List<Site_kpi_data> LIST_SITE_KPI_DATA_NUMBER_OF_VISITORS { get; set; }
        public List<Business> LIST_SITE_BUSINESS_COUNT { get; set; }
    }
    public partial class Contour
    {
        public long X { get; set; }
        public long Y { get; set; }
    }
    public partial class Correlation_method
    {
        public int? CORRELATION_METHOD_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EQUATION_URL { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    public partial class Data
    {
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string VALUE { get; set; }
    }
    public partial class Data_point
    {
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    public partial class Data_Settings
    {
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public Params_Edit_Organization_log_config_List Params_Edit_Organization_log_config_List { get; set; }
    }
    public partial class Data_source
    {
        public int? DATA_SOURCE_ID { get; set; }
        public string NAME { get; set; }
        public string API_URL { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public int? DATA_SOURCE_AUTHENTICATION_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Data_source_authentication Data_source_authentication { get; set; }
    }
    public partial class Data_source_authentication
    {
        public int? DATA_SOURCE_AUTHENTICATION_ID { get; set; }
        public string AUTH_ENDPOINT { get; set; }
        public int? AUTH_TYPE_SETUP_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string API_KEY { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    public partial class Dataset
    {
        public string LABEL { get; set; }
        public List<decimal?> LIST_POINT { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Default_chart_color
    {
        public int? DEFAULT_CHART_COLOR_ID { get; set; }
        public int? DEFAULT_SETTINGS_ID { get; set; }
        public string COLOR { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Default_settings Default_settings { get; set; }
        public Setup Data_level_setup { get; set; }
    }
    public partial class Default_settings
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
        public int? DEFAULT_SETTINGS_ID { get; set; }
        public string PLATFORM_PRIMARY { get; set; }
        public string PLATFORM_BUTTON { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public int? OTP_TTL_IN_SECONDS { get; set; }
        public string MAPBOX_GL_TOKEN { get; set; }
        public string GOOGLE_MAP_API_TOKEN { get; set; }
        public string TELUS_REQUEST_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public List<Default_chart_color> List_Default_chart_color { get; set; }
        public List<Default_settings_image> List_Default_settings_image { get; set; }
    }
    public partial class Default_settings_image
    {
        public string IMAGE_GCP_URL { get; set; }
        public int? DEFAULT_SETTINGS_IMAGE_ID { get; set; }
        public int? DEFAULT_SETTINGS_ID { get; set; }
        public string IMAGE_NAME { get; set; }
        public string IMAGE_EXTENSION { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Default_settings Default_settings { get; set; }
        public Setup Image_type_setup { get; set; }
    }
    public partial class Delete_Area_Kpi_Data_By_Where
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Demographic_Data
    {
        public long? TIME_BUCKET_SIZE { get; set; }
        public DateTime? END_TIME { get; set; }
        public string REQUEST_ID { get; set; }
        public DateTime? START_TIME { get; set; }
        public List<Study_zone> LIST_STUDY_ZONE { get; set; }
        public string STATUS { get; set; }
    }
    public partial class Dimension
    {
        public int? DIMENSION_ID { get; set; }
        public string NAME { get; set; }
        public string DIMENSION_ICON { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        public string ICON_URL { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public List<Kpi> List_Kpi { get; set; }
        public List<Report> List_Report { get; set; }
    }
    public partial class Dimension_chart_configuration
    {
        public string DIMENSION_CHART_CONFIGURATION_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public long? POSITION_SETUP_ID { get; set; }
        public int? CHART_ORDER { get; set; }
        public List<Setting> LIST_SETTING { get; set; }
    }
    public partial class Dimension_ID_By_Level_ID
    {
        public long? LEVEL_ID { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
    }
    public partial class Dimension_index
    {
        public DateTime RECORD_DATE { get; set; }
        public Dimension_metadata DIMENSION_METADATA { get; set; }
        public decimal VALUE { get; set; }
    }
    public partial class Dimension_index_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
    }
    public partial class Dimension_Index_With_Simple_Upper_Level
    {
        public Upper_Level FATHER_UPPER_LEVEL { get; set; }
        public Upper_Level GRANDFATHER_UPPER_LEVEL { get; set; }
        public List<Dimension_index> LIST_UPPER_LEVEL_DIMENSION_INDEX { get; set; }
        public List<Dimension_index> LIST_SELECTED_LEVEL_DIMENSION_INDEX { get; set; }
    }
    public partial class Dimension_metadata
    {
        public int DIMENSION_ID { get; set; }
        public long LEVEL_ID { get; set; }
        public long LEVEL_SETUP_ID { get; set; }
    }
    public partial class District
    {
        public List<Area> List_Area { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
        public List<District_view> List_District_view { get; set; }
    }
    public partial class District_kpi
    {
        public long? DISTRICT_KPI_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public District District { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
    }
    public partial class District_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public District_metadata DISTRICT_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    public partial class District_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    public partial class District_kpi_user_access
    {
        public long? DISTRICT_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public District District { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
    }
    public partial class District_metadata
    {
        public long DISTRICT_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    public partial class District_view
    {
        public long? DISTRICT_VIEW_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public District District { get; set; }
        public Setup View_type_setup { get; set; }
    }
    public partial class Districtnex_module
    {
        public int? DISTRICTNEX_MODULE_ID { get; set; }
        public string NAME { get; set; }
        public int? DISPLAY_ORDER { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    public partial class EngineConfig
    {
        public PluginConfig PluginConfig { get; set; }
        public EngineModelConfigList[] EngineModelConfigList { get; set; }
    }
    public partial class EngineModelConfigList
    {
        public string Type { get; set; }
        public double Confidence { get; set; }
        public long MinObjSize { get; set; }
        public long MaxObjSize { get; set; }
        public bool Enabled { get; set; }
    }
    public partial class EngineProfile
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public long EngineProfileId { get; set; }
        public string Name { get; set; }
        public EngineConfig EngineConfig { get; set; }
        public bool IsDefault { get; set; }
        public object Description { get; set; }
        public long[] EngineModelId { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Entity
    {
        public long? ENTITY_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public long? ENTITY_TYPE_SETUP_ID { get; set; }
        public string NAME { get; set; }
        public int? NUMBER_OF_FLOORS { get; set; }
        public decimal? GLA { get; set; }
        public string GLA_UNIT { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public decimal? POPUL_ALT_X { get; set; }
        public decimal? POPUP_ALT_Y { get; set; }
        public decimal? POPUP_ALT_Z { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Area Area { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Site Site { get; set; }
        public Top_level Top_level { get; set; }
        public Setup Entity_type_setup { get; set; }
        public List<Floor> List_Floor { get; set; }
        public List<Entity_view> List_Entity_view { get; set; }
    }
    public partial class Entity_Data_point
    {
        public long? SEVERITY_TYPE_SETUP_ID { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    public partial class Entity_Incidents
    {
        public Incident_With_Count LIST_FIRE_ALARM_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT { get; set; }
    }
    public partial class Entity_kpi
    {
        public long? ENTITY_KPI_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Entity Entity { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
    }
    public partial class Entity_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Entity_metadata ENTITY_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    public partial class Entity_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Entity_Data_point> LIST_KPI_DATA { get; set; }
    }
    public partial class Entity_kpi_user_access
    {
        public long? ENTITY_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Entity Entity { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
    }
    public partial class Entity_metadata
    {
        public long ENTITY_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    public partial class Entity_share_data
    {
        public string ENTITY_SHARE_DATA_ID { get; set; }
        public string SHARING_USER_NAME { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string UNIQUE_STRING { get; set; }
        public DateTime? FILTER_START_DATE { get; set; }
        public DateTime? FILTER_END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_CAMERA_ONE_ON { get; set; }
        public bool? IS_CAMERA_TWO_ON { get; set; }
        public bool? IS_CAMERA_THREE_ON { get; set; }
        public List<Wifi_signal> LIST_FLOOR_ASSET_WIFI_SIGNAL { get; set; }
        public List<Wifi_signal> LIST_FLOOR_CHART_WIFI_SIGNAL { get; set; }
        public List<Wifi_signal> LIST_SUMMARY_WIFI_SIGNAL { get; set; }
        public List<long?> LIST_SUMMARY_SPACE_ASSET_ID { get; set; }
        public List<string> LIST_WIFI_SIGNAL_ALERT_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public bool IS_ALERT { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_INCIDENT_ID { get; set; }
        public List<Dimension_index_By_Level> LIST_FLOOR_DIMENSION_INDEX { get; set; }
        public Dimension_index_By_Level ENTITY_DIMENSION_INDEX { get; set; }
        public List<Level_Dimension_with_Status> LIST_ENTITY_LEVEL_DIMENSION_WITH_STATUS { get; set; }
        public bool? IS_ENTITY_SUMMARY_DRAWER_VISIBLE { get; set; }
    }
    public partial class Entity_share_view_data
    {
        public string SHARING_USER_NAME { get; set; }
        public DateTime? FILTER_START_DATE { get; set; }
        public DateTime? FILTER_END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public Entity Entity { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_CAMERA_ONE_ON { get; set; }
        public bool? IS_CAMERA_TWO_ON { get; set; }
        public bool? IS_CAMERA_THREE_ON { get; set; }
        public List<Wifi_signal> List_Floor_asset_Wifi_signal { get; set; }
        public List<Wifi_signal> List_Floor_chart_Wifi_signal { get; set; }
        public List<Wifi_signal> List_Summary_Wifi_signal { get; set; }
        public List<Space_asset> List_Summary_Space_asset { get; set; }
        public List<Wifi_signal_alert> List_Wifi_signal_alert { get; set; }
        public int? DIMENSION_ID { get; set; }
        public bool IS_ALERT { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<Incident> List_Incident { get; set; }
        public List<Floor_Kpi_Dialog_Data> List_Floor_kpi_data { get; set; }
        public List<Entity_Kpi_Dialog_Data> List_Entity_kpi_data { get; set; }
        public List<Dimension_index_By_Level> List_Floor_Dimension_index { get; set; }
        public List<Kpi_chart_configuration> List_Kpi_chart_configuration { get; set; }
        public Dimension_index_By_Level Entity_Dimension_index { get; set; }
        public List<Dimension_chart_configuration> List_Dimension_chart_configuration { get; set; }
        public List<Setup_category> List_Setup_category { get; set; }
        public List<Level_Dimension_with_Status> List_Entity_Level_Dimension_with_Status { get; set; }
        public bool? IS_ENTITY_SUMMARY_DRAWER_VISIBLE { get; set; }
    }
    public partial class Entity_view
    {
        public long? ENTITY_VIEW_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Entity Entity { get; set; }
        public Setup View_type_setup { get; set; }
    }
    public partial class Ext_study_zone
    {
        public int? EXT_STUDY_ZONE_ID { get; set; }
        public string NAME { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    public partial class Ext_study_zone_With_Count
    {
        public Ext_study_zone EXT_STUDY_ZONE { get; set; }
        public decimal? COUNT { get; set; }
    }
    public partial class Face_Key_Response
    {
        public long FaceKeyId { get; set; }
        public long SceneId { get; set; }
        public long CameraId { get; set; }
        public string Datetime { get; set; }
        public string File { get; set; }
        public string Position { get; set; }
        public double Confidence { get; set; }
        public long? FootageId { get; set; }
        public long Age { get; set; }
        public string AgeGroup { get; set; }
        public string Gender { get; set; }
    }
    public partial class Face_Key_Response_List
    {
        public List<Face_Key_Response> FACET_KEY_RESPONSE_LIST { get; set; }
        public int TOTAL_ELEMENTS { get; set; }
    }
    public partial class Face_Target_Key_Response
    {
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public string FaceTargetKeyId { get; set; }
        public string File { get; set; }
        public long[] Feature { get; set; }
        public double Similarity { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Face_Target_Response_Category
    {
        public long AinvrId { get; set; }
        public string CreateDate { get; set; }
        public string FaceCategoryId { get; set; }
        public string Name { get; set; }
        public string UpdateDate { get; set; }
    }
    public partial class Fetch_Face_Target_Response_Content
    {
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public string FaceTargetId { get; set; }
        public Face_Target_Response_Category Category { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long? BirthYear { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string Description { get; set; }
        public Face_Target_Key_Response[] Keys { get; set; }
        public bool Deleted { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Fetch_Face_Targets_Response
    {
        public long TotalElements { get; set; }
        public long TotalPages { get; set; }
        public bool First { get; set; }
        public Sort Sort { get; set; }
        public long NumberOfElements { get; set; }
        public bool Last { get; set; }
        public Pageable Pageable { get; set; }
        public long Size { get; set; }
        public Fetch_Face_Target_Response_Content[] Content { get; set; }
        public long Number { get; set; }
        public bool Empty { get; set; }
    }
    public partial class Fetch_Facial_Recognition_Reponse
    {
        public long TotalElements { get; set; }
        public long TotalPages { get; set; }
        public bool First { get; set; }
        public Sort Sort { get; set; }
        public long NumberOfElements { get; set; }
        public bool Last { get; set; }
        public Pageable Pageable { get; set; }
        public long Size { get; set; }
        public Fetch_Facial_Recognition_Response_Content[] Content { get; set; }
        public long Number { get; set; }
        public bool Empty { get; set; }
    }
    public partial class Fetch_Facial_Recognition_Response_Content
    {
        public long FaceMatchId { get; set; }
        public bool isVpn { get; set; }
        public bool isLoaded { get; set; }
        public string Datetime { get; set; }
        public Face_Key_Response FaceKey { get; set; }
        public Fetch_Face_Target_Response_Content FaceTarget { get; set; }
        public Face_Target_Key_Response FaceTargetKey { get; set; }
        public double Similarity { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Fetch_License_Plate_Recognition_Response
    {
        public Fetch_License_Plate_Recognition_Response_Content[] List_Fetch_License_Plate_Recognition_Response_Content { get; set; }
        public int TotalElements { get; set; }
    }
    public partial class Fetch_License_Plate_Recognition_Response_Content
    {
        public bool isVpn { get; set; }
        public bool isLoaded { get; set; }
        public long LicensePlateId { get; set; }
        public long CameraId { get; set; }
        public long? FootageId { get; set; }
        public Fetch_License_Plate_Targets_Response_Content Target { get; set; }
        public long SceneId { get; set; }
        public string Datetime { get; set; }
        public string Type { get; set; }
        public string Characters { get; set; }
        public double Confidence { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long W { get; set; }
        public long H { get; set; }
        public string File { get; set; }
        public string Property { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VehicleType { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public bool Modified { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Fetch_License_Plate_Targets_Response
    {
        public Fetch_License_Plate_Targets_Response_Content[] Content { get; set; }
        public Pageable Pageable { get; set; }
        public bool Last { get; set; }
        public long TotalPages { get; set; }
        public long TotalElements { get; set; }
        public Sort Sort { get; set; }
        public long Size { get; set; }
        public long Number { get; set; }
        public bool First { get; set; }
        public long NumberOfElements { get; set; }
        public bool Empty { get; set; }
    }
    public partial class Fetch_License_Plate_Targets_Response_Content
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string LicensePlateTargetId { get; set; }
        public License_Plate_Category Category { get; set; }
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public string VehicleOwner { get; set; }
        public string Address { get; set; }
        public string RegistrationDate { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Fetch_Scenes_Api_Response
    {
        public Fetch_Scenes_Response_Content[] Content { get; set; }
        public Pageable Pageable { get; set; }
        public bool Last { get; set; }
        public long TotalPages { get; set; }
        public long TotalElements { get; set; }
        public long NumberOfElements { get; set; }
        public bool First { get; set; }
        public Sort Sort { get; set; }
        public long Size { get; set; }
        public long Number { get; set; }
        public bool Empty { get; set; }
    }
    public partial class Fetch_Scenes_Response
    {
        public Fetch_Scenes_Api_Response Fetch_Scenes_Api_Response { get; set; }
        public bool IS_ERROR { get; set; }
        public string ERROR_MESSAGE { get; set; }
    }
    public partial class Fetch_Scenes_Response_Content
    {
        public long SceneId { get; set; }
        public bool isLoaded { get; set; }
        public bool isVpn { get; set; }
        public DateTimeOffset Datetime { get; set; }
        public long CameraId { get; set; }
        public object FootageId { get; set; }
        public string File { get; set; }
        public string Source { get; set; }
        public string CameraName { get; set; }
        public object Description { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public object FloorPlanId { get; set; }
        public object FloorPlanX { get; set; }
        public object FloorPlanY { get; set; }
        public object FloorPlanAngle { get; set; }
        public string Thumbnail { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Floor
    {
        public long? FLOOR_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public int? FLOOR_NUMBER { get; set; }
        public string SHELL_GLTF_URL { get; set; }
        public string CLIPPED_GLTF_URL { get; set; }
        public string ADVANCED_GLTF_URL { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public string NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Entity Entity { get; set; }
        public List<Space> List_Space { get; set; }
    }
    public partial class Floor_Data_point
    {
        public long? SEVERITY_TYPE_SETUP_ID { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    public partial class Floor_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Floor_metadata FLOOR_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    public partial class Floor_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Floor_Data_point> LIST_KPI_DATA { get; set; }
        public List<Wifi_signal> WIFI_SIGNAL_LIST { get; set; }
        public List<Wifi_signal_alert> WIFI_SIGNAL_ALERT_LIST { get; set; }
    }
    public partial class Floor_metadata
    {
        public long FLOOR_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    public partial class Generate_Logs_Excel_Response
    {
        public string EXCEL_URL { get; set; }
        public string REPORT_NAME { get; set; }
    }
    public partial class Geo_Location
    {
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
    }
    public partial class GeoData
    {
        public string GEODATA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
        public DateTime? DATE_START { get; set; }
        public DateTime? DATE_END { get; set; }
        public List<Data> DATA_LIST { get; set; }
    }
    public partial class Get_Countings_Response
    {
        public string MEASURE { get; set; }
        public string DATETIME { get; set; }
        public string TYPE { get; set; }
        public int OBJECTIN { get; set; }
        public int OBJECTOUT { get; set; }
        public int OCCUPANCY { get; set; }
    }
    public partial class Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result
    {
        public List<Entity> LIST_ENTITY { get; set; }
    }
    public partial class Get_Line_Sets_Response
    {
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public int LineSetId { get; set; }
        public int CameraId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public int AiNvrId { get; set; }
    }
    public partial class Incident
    {
        public string INCIDENT_ID { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? SEVERITY_SETUP_ID { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        public DateTime? CREATED_TIME { get; set; }
        public DateTime? ASSIGNED_TIME { get; set; }
        public DateTime? CLOSED_TIME { get; set; }
        public Geo_Location Geo_Location { get; set; }
        public Sustainability_Incident Sustainability_Incident { get; set; }
        public Security_Incident Security_Incident { get; set; }
        public Mobility_Incident Mobility_Incident { get; set; }
        public Living_Incident Living_Incident { get; set; }
        public Geo_Location GEO_LOCATION { get; set; }
        public long? SCENE_ID { get; set; }
        public long? VIDEO_AI_INSTANCE_ID { get; set; }
        public Surveillance_Camera_Content CAMERA { get; set; }
        public string BLACKLISTED_PERSON_NAME { get; set; }
        public string BLACKLISTED_LICENSE_PLATE { get; set; }
        public string BLACKLISTED_LICENSE_FILE_URL { get; set; }
        public Sustainability_Incident SUSTAINABILITY_INCIDENT { get; set; }
        public Security_Incident SECURITY_INCIDENT { get; set; }
        public Mobility_Incident MOBILITY_INCIDENT { get; set; }
        public Living_Incident LIVING_INCIDENT { get; set; }
    }
    public partial class Incident_With_Count
    {
        public long COUNT { get; set; }
        public List<Incident> List_Incident { get; set; }
    }
    public partial class Initial_Data
    {
        public List<Dimension_chart_configuration> LIST_DIMENSION_CHART_CONFIGURATION { get; set; }
        public List<Kpi_chart_configuration> LIST_KPI_CHART_CONFIGURATION { get; set; }
        public List<Specialized_chart_configuration> LIST_SPECIALIZED_CHART_CONFIGURATION { get; set; }
        public List<Setup_category> LIST_SETUP_CATEGORY { get; set; }
        public List<User_districtnex_module> LIST_USER_DISTRICT_NEX_MODULE { get; set; }
        public List<Organization_color_scheme> LIST_ORGANIZATION_COLOR_SCHEME { get; set; }
        public List<Niche_categories> LIST_NICHE_CATEGORIES { get; set; }
        public User_theme USER_THEME { get; set; }
        public List<Organization_Data_with_Accessible_Top_Level_Data> LIST_ORGANIZATION_DATA_WITH_ACCESSIBLE_TOP_LEVEL_DATA { get; set; }
    }
    public partial class Initial_Districtnex_Admin_Settings
    {
        public string BUILD_NUMBER { get; set; }
        public Default_settings Default_settings { get; set; }
    }
    public partial class Initial_Districtnex_UI_Settings
    {
        public string BUILD_NUMBER { get; set; }
        public Default_settings Default_settings { get; set; }
    }
    public partial class Job
    {
        public string JOB_ID { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public long? REQUEST_SETUP_ID { get; set; }
        public int? DWELL_TIME_BUCKET { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public int? MIN_DWELL_TIME { get; set; }
        public int? MAX_DWELL_TIME { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
    public partial class Kpi
    {
        public int? KPI_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public int? SETUP_CATEGORY_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
        public long? KPI_TYPE_SETUP_ID { get; set; }
        public bool HAS_CORRELATION { get; set; }
        public bool IS_TRENDLINE { get; set; }
        public bool IS_DECIMAL_VALUE { get; set; }
        public bool HAS_SQM { get; set; }
        public bool IS_BY_SEVERITY { get; set; }
        public bool IS_ADDITIVE_DATA { get; set; }
        public decimal? MINIMUM_VALUE { get; set; }
        public decimal? MAXIMUM_VALUE { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public bool IS_AUTO_GENERATE { get; set; }
        public long? MIN_DATA_LEVEL_SETUP_ID { get; set; }
        public long? MAX_DATA_LEVEL_SETUP_ID { get; set; }
        public bool IS_EXTERNAL { get; set; }
        public bool HAS_ALERTS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Dimension Dimension { get; set; }
        public Setup Kpi_type_setup { get; set; }
        public Setup Max_data_level_setup { get; set; }
        public Setup Min_data_level_setup { get; set; }
        public Setup_category Setup_category { get; set; }
    }
    public partial class Kpi_chart_configuration
    {
        public string KPI_CHART_CONFIGURATION_ID { get; set; }
        public int? KPI_ID { get; set; }
        public long? POSITION_SETUP_ID { get; set; }
        public int? CHART_ORDER { get; set; }
        public List<Setting> LIST_SETTING { get; set; }
        public List<Action_Button> LIST_ACTION_BUTTON { get; set; }
    }
    public partial class Kpi_Dialog_Data_By_Area
    {
        public long? AREA_ID { get; set; }
        public List<Area_Kpi_Dialog_Data> LIST_AREA_KPI_DIALOG_DATA { get; set; }
    }
    public partial class Kpi_Dialog_Data_By_District
    {
        public long? DISTRICT_ID { get; set; }
        public List<District_Kpi_Dialog_Data> LIST_DISTRICT_KPI_DIALOG_DATA { get; set; }
    }
    public partial class Kpi_Dialog_Data_By_Entity
    {
        public long? ENTITY_ID { get; set; }
        public List<Entity_Kpi_Dialog_Data> LIST_ENTITY_KPI_DIALOG_DATA { get; set; }
    }
    public partial class Kpi_Dialog_Data_By_Site
    {
        public long? SITE_ID { get; set; }
        public List<Site_Kpi_Dialog_Data> LIST_SITE_KPI_DIALOG_DATA { get; set; }
    }
    public partial class Kpi_Value_By_Date
    {
        public DateTime? RECORD_DATE { get; set; }
        public decimal? VALUE { get; set; }
    }
    public partial class Kpi_Value_By_Direction
    {
        public string DIRECTION { get; set; }
        public string LABEL { get; set; }
        public List<Kpi_Value_By_Date> LIST_KPI_VALUE_BY_DATE { get; set; }
    }
    public partial class Level_Data
    {
        public string GEOJSON_SRC { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Upper_Level UPPER_LEVEL { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
    }
    public partial class Level_Dimension_with_Status
    {
        public List<long?> LEVEL_ID_LIST { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Dimension DIMENSION { get; set; }
        public Enum_Dimension_Status ENUM_DIMENSION_STATUS { get; set; }
    }
    public partial class License_Plate_Category
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string LicensePlateCategoryId { get; set; }
        public string Name { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Living_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    public partial class Location
    {
        public string type { get; set; }
        public List<decimal?> coordinates { get; set; }
    }
    public partial class Log
    {
        public User User { get; set; }
        public Site Site { get; set; }
        public Entity Entity { get; set; }
        public Video_ai_asset Video_ai_asset { get; set; }
        public string LOG_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ACCESS_TYPE_SETUP_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? SITE_ID { get; set; }
        public string MESSAGE { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public int? VIDEO_AI_ASSET_ID { get; set; }
    }
    public partial class Log_With_Count
    {
        public long COUNT { get; set; }
        public List<Log> List_Log { get; set; }
    }
    public partial class Metadata
    {
        public string[] Colors { get; set; }
    }
    public partial class Method_run
    {
        public long? METHOD_RUN_ID { get; set; }
        public string METHOD_NAME { get; set; }
        public string RUN_DATE { get; set; }
        public int? RUN_HOUR { get; set; }
        public int? RUN_MINUTE { get; set; }
        public int? RUN_SECOND { get; set; }
        public int? EXECUTION_TIME { get; set; }
        public bool IS_CACHED { get; set; }
        public string METHOD_PARAMS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public int? OWNER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
    }
    public partial class Mobility_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    public partial class Niche_categories
    {
        public string NICHE_CATEGORIES_ID { get; set; }
        public string BUSINESS_NICHE { get; set; }
        public List<string> CATEGORY_LIST { get; set; }
        public string NICHE_COLOR { get; set; }
    }
    public partial class Nvr
    {
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public string NvrId { get; set; }
        public Brand_Api_Response Brand { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public long Port { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Organization
    {
        public int? ORGANIZATION_ID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string ORGANIZATION_EMAIL { get; set; }
        public string ORGANIZATION_PHONE_NUMBER { get; set; }
        public string ORGANIZATION_ADDRESS { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public long? ORGANIZATION_TYPE_SETUP_ID { get; set; }
        public string DATE_DELETED { get; set; }
        public int? MAX_NUMBER_OF_ADMINS { get; set; }
        public int? MAX_NUMBER_OF_USERS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Setup Organization_type_setup { get; set; }
        public List<User> List_User { get; set; }
        public List<Organization_theme> List_Organization_theme { get; set; }
        public List<Organization_color_scheme> List_Organization_color_scheme { get; set; }
        public List<Organization_districtnex_module> List_Organization_districtnex_module { get; set; }
        public List<Organization_image> List_Organization_image { get; set; }
        public List<Organization_level_access> List_Organization_level_access { get; set; }
        public List<Organization_log_config> List_Organization_log_config { get; set; }
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    public partial class Organization_chart_color
    {
        public int? ORGANIZATION_CHART_COLOR_ID { get; set; }
        public int? ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public string COLOR { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Organization_color_scheme Organization_color_scheme { get; set; }
        public Setup Data_level_setup { get; set; }
    }
    public partial class Organization_color_scheme
    {
        public int? ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string PLATFORM_PRIMARY { get; set; }
        public string PLATFORM_BUTTON { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Organization Organization { get; set; }
        public List<Organization_chart_color> List_Organization_chart_color { get; set; }
    }
    public partial class Organization_Data
    {
        public int? ORGANIZATION_ID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
        public List<Organization_color_scheme> LIST_ORGANIZATION_COLOR_SCHEME { get; set; }
        public List<Organization_theme> LIST_ORGANIZATION_THEME { get; set; }
    }
    public partial class Organization_Data_Access
    {
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
        public List<District_kpi> LIST_DISTRICT_KPI { get; set; }
        public List<Area_kpi> LIST_AREA_KPI { get; set; }
        public List<Site_kpi> LIST_SITE_KPI { get; set; }
        public List<Entity_kpi> LIST_ENTITY_KPI { get; set; }
        public List<District> LIST_DISTRICT { get; set; }
        public List<Area> LIST_AREA { get; set; }
        public List<Site> LIST_SITE { get; set; }
        public List<Entity> LIST_ENTITY { get; set; }
    }
    public partial class Organization_data_source_kpi
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? DATA_SOURCE_ID { get; set; }
        public int? KPI_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Data_source Data_source { get; set; }
        public Kpi Kpi { get; set; }
        public Organization Organization { get; set; }
    }
    public partial class Organization_data_source_kpi_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public decimal? VALUE { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Organization_data_source_kpi_ID_By_Level_ID
    {
        public long? LEVEL_ID { get; set; }
        public List<Organization_data_source_kpi_Simple> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE { get; set; }
    }
    public partial class Organization_data_source_kpi_List_By_Top_Level
    {
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT { get; set; }
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA { get; set; }
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE { get; set; }
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY { get; set; }
    }
    public partial class Organization_data_source_kpi_Simple
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
    }
    public partial class Organization_Data_with_Accessible_Top_Level_Data
    {
        public Organization_Data ORGANIZATION_DATA { get; set; }
        public List<Top_Level_Data> LIST_TOP_LEVEL_DATA { get; set; }
    }
    public partial class Organization_districtnex_module
    {
        public int? ORGANIZATION_DISTRICTNEX_MODULE_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public int? DISTRICTNEX_MODULE_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Districtnex_module Districtnex_module { get; set; }
        public Organization Organization { get; set; }
    }
    public partial class Organization_image
    {
        public string IMAGE_GCP_URL { get; set; }
        public int? ORGANIZATION_IMAGE_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string IMAGE_NAME { get; set; }
        public string IMAGE_EXTENSION { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Organization Organization { get; set; }
        public Setup Image_type_setup { get; set; }
    }
    public partial class Organization_level_access
    {
        public long? ORGANIZATION_LEVEL_ACCESS_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Organization Organization { get; set; }
        public Setup Data_level_setup { get; set; }
    }
    public partial class Organization_log_config
    {
        public long? ORGANIZATION_LOG_CONFIG_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Organization Organization { get; set; }
        public Setup Log_type_setup { get; set; }
    }
    public partial class Organization_relation
    {
        public int? ORGANIZATION_RELATION_ID { get; set; }
        public int? PARENT_ORGANIZATION_ID { get; set; }
        public int? CHILD_ORGANIZATION_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public User User { get; set; }
    }
    public partial class Organization_theme
    {
        public int? ORGANIZATION_THEME_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string THEME_NAME { get; set; }
        public string THEME_CLASS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Organization Organization { get; set; }
    }
    public partial class Output
    {
        public long? COUNT { get; set; }
        public string OUTPUT_GEOID { get; set; }
        public string REQUEST_ID { get; set; }
    }
    public partial class Pageable
    {
        public Sort Sort { get; set; }
        public long PageNumber { get; set; }
        public long PageSize { get; set; }
        public long Offset { get; set; }
        public bool Unpaged { get; set; }
        public bool Paged { get; set; }
    }
    public partial class Performance_object
    {
        public Entity Entity { get; set; }
        public Floor Floor { get; set; }
        public Space Space { get; set; }
        public Space_asset Space_asset { get; set; }
        public decimal? value { get; set; }
    }
    public partial class PluginConfig
    {
        public long MotionDetectSize { get; set; }
        public double MotionDetectParam { get; set; }
        public double FaceRecognitionSimilarityThreshold { get; set; }
        public long FaceRecognitionMinSize { get; set; }
        public bool EnableFrontalFaceDetection { get; set; }
        public double LicensePlateConfidenceThreshold { get; set; }
        public long LicensePlateMinSize { get; set; }
        public double MakeModelConfidenceThreshold { get; set; }
        public long MakeModelMinSize { get; set; }
        public long AgeGenderMinSize { get; set; }
        public bool EnableAgeGenderQualityDetection { get; set; }
    }
    public partial class Primary_Authentication_Response
    {
        public string EMAIL { get; set; }
        public long? USER_ID { get; set; }
        public int? TTL_IN_SECONDS { get; set; }
    }
    public partial class Public_Event
    {
        public string PUBLIC_EVENT_ID { get; set; }
        public string TITLE { get; set; }
        public string DATE_AND_TIME { get; set; }
        public DateTime? START_TIME { get; set; }
        public DateTime? END_TIME { get; set; }
        public string CITY_OR_TOWN { get; set; }
        public string NEIGHBOURHOOD_ID { get; set; }
        public string NEIGHBOURHOOD { get; set; }
        public string WHERE { get; set; }
        public string COST { get; set; }
        public string EVENT_CATEGORY { get; set; }
        public string EVENT_TYPE { get; set; }
        public string EVENT_URL { get; set; }
        public string EVENT_VENUE { get; set; }
        public string EVENT_EXTERNAL_ID { get; set; }
        public string WHERE_TO_PURCHASE_TICKETS { get; set; }
        public string TICKETS_PHONE { get; set; }
        public string CATEGORY_CALENDAR { get; set; }
        public string WEB_LINK { get; set; }
        public string PUBLIC_ENGAGEMENT_CATEGORY { get; set; }
        public string SHORT_DESCRIPTION { get; set; }
        public string PROJECT_NAME { get; set; }
        public string ADDITIONAL_INFORMATION { get; set; }
        public string NOTES_1 { get; set; }
        public string NOTES_2 { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    public partial class Region
    {
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Top_level Top_level { get; set; }
    }
    public partial class Region_view
    {
        public long? REGION_VIEW_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Region Region { get; set; }
        public Setup View_type_setup { get; set; }
    }
    public partial class Removed_extrusion
    {
        public int? REMOVED_EXTRUSION_ID { get; set; }
        public string EXTRUSION_IDENTIFIER { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Setup Data_level_setup { get; set; }
    }
    public partial class Report
    {
        public int? REPORT_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public string FILE_SIZE { get; set; }
        public string IDENTIFIER_TOKEN { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Dimension Dimension { get; set; }
    }
    public partial class Report_Details
    {
        public List<Kpi_Dialog_Data_By_District> LIST_KPI_DIALOG_DATA_BY_DISTRICT { get; set; }
        public List<Kpi_Dialog_Data_By_Area> LIST_KPI_DIALOG_DATA_BY_AREA { get; set; }
        public List<Kpi_Dialog_Data_By_Site> LIST_KPI_DIALOG_DATA_BY_SITE { get; set; }
        public List<Kpi_Dialog_Data_By_Entity> LIST_KPI_DIALOG_DATA_BY_ENTITY { get; set; }
    }
    public partial class RoiContour
    {
        public Contour[] Contour { get; set; }
    }
    public partial class Scene_Details
    {
        public long SceneId { get; set; }
        public long CameraId { get; set; }
        public object FootageId { get; set; }
        public string Source { get; set; }
        public DateTimeOffset Datetime { get; set; }
        public string File { get; set; }
        public long FrameIndex { get; set; }
        public Surveillance_Camera_Content Camera { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public object[] HashtagId { get; set; }
        public object[] Hashtags { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Scene_Info
    {
        public Scene_Details SCENE_DETAILS { get; set; }
        public List<Scene_Object> SCENE_OBJECT_LIST { get; set; }
    }
    public partial class Scene_Object
    {
        public long SceneObjectId { get; set; }
        public string ObjectType { get; set; }
        public long CameraId { get; set; }
        public DateTimeOffset Datetime { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long W { get; set; }
        public long H { get; set; }
        public double Confidence { get; set; }
        public Metadata Metadata { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class Schedule
    {
        public object[] Weekdays { get; set; }
        public bool Forever { get; set; }
    }
    public partial class Search_Face_Target_Key_Response
    {
        public Fetch_Face_Target_Response_Content FaceTarget { get; set; }
        public Face_Target_Key_Response FaceTargetKey { get; set; }
    }
    public partial class Search_Face_Target_Key_Response_List
    {
        public List<Search_Face_Target_Key_Response> SEARCH_FACE_TARGET_KEY_RESPONSE_LIST { get; set; }
        public int TOTAL_ELEMENTS { get; set; }
    }
    public partial class Security_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    public partial class Send_Otp_Response
    {
        public string EMAIL { get; set; }
        public long? USER_ID { get; set; }
        public int? TTL_IN_SECONDS { get; set; }
    }
    public partial class Setting
    {
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
        public string ICON { get; set; }
    }
    public partial class Setup
    {
        public long? SETUP_ID { get; set; }
        public int? SETUP_CATEGORY_ID { get; set; }
        public bool IS_SYSTEM { get; set; }
        public bool IS_DELETEABLE { get; set; }
        public bool IS_UPDATEABLE { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_VISIBLE { get; set; }
        public int? DISPLAY_ORDER { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public int? OWNER_ID { get; set; }
        public Setup_category Setup_category { get; set; }
    }
    public partial class Setup_category
    {
        public int? SETUP_CATEGORY_ID { get; set; }
        public string SETUP_CATEGORY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public List<Setup> List_Setup { get; set; }
    }
    public partial class Share_file
    {
        public int? SHARE_FILE_ID { get; set; }
        public long? USER_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public User User { get; set; }
    }
    public partial class Site
    {
        public List<Entity> List_Entity { get; set; }
        public long? SITE_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Area Area { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
        public List<Site_view> List_Site_view { get; set; }
        public List<Site_field_logo> List_Site_field_logo { get; set; }
    }
    public partial class Site_field_logo
    {
        public long? SITE_FIELD_LOGO_ID { get; set; }
        public long? SITE_ID { get; set; }
        public decimal? LONGITUDE { get; set; }
        public decimal? LATITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Site Site { get; set; }
    }
    public partial class Site_kpi
    {
        public long? SITE_KPI_ID { get; set; }
        public long? SITE_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public Site Site { get; set; }
    }
    public partial class Site_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Site_metadata SITE_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    public partial class Site_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    public partial class Site_kpi_user_access
    {
        public long? SITE_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? SITE_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public Site Site { get; set; }
        public User User { get; set; }
    }
    public partial class Site_metadata
    {
        public long SITE_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    public partial class Site_view
    {
        public long? SITE_VIEW_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Site Site { get; set; }
        public Setup View_type_setup { get; set; }
    }
    public partial class Sites_and_Entities
    {
        public List<Site> SITES { get; set; }
        public List<Entity> ENTITIES { get; set; }
    }
    public partial class Sort
    {
        public bool Unsorted { get; set; }
        public bool Sorted { get; set; }
        public bool Empty { get; set; }
    }
    public partial class Space
    {
        public List<Space_asset> List_Space_asset { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public string NAME { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public int? OCCUPANT_LOAD_FACTOR { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Floor Floor { get; set; }
        public bool HAS_VIDEO_AI_ASSETS { get; set; }
    }
    public partial class Space_asset
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? ASSET_ID { get; set; }
        public string EXTERNAL_ID { get; set; }
        public bool IS_MERAKI_WIFI_SIGNAL { get; set; }
        public string CUSTOM_NAME { get; set; }
        public decimal? POSITION_X { get; set; }
        public decimal? POSITION_Y { get; set; }
        public decimal? POSITION_Z { get; set; }
        public decimal? SCALE_MULTIPLIER { get; set; }
        public decimal? ROTATE_X { get; set; }
        public decimal? ROTATE_Y { get; set; }
        public decimal? ROTATE_Z { get; set; }
        public string ASSET_ICON { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Asset Asset { get; set; }
        public Space Space { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
        public List<Incident> List_Space_asset_energy_incident { get; set; }
        public List<Incident> List_Space_asset_security_incident { get; set; }
    }
    public partial class Space_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Space_metadata SPACE_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    public partial class Space_metadata
    {
        public long SPACE_ID { get; set; }
        public long FLOOR_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    public partial class Specialized_chart_configuration
    {
        public string SPECIALIZED_CHART_CONFIGURATION_ID { get; set; }
        public string MODULE { get; set; }
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
    }
    public partial class Stream_Data
    {
        public List<string> List_Search_type { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    public partial class Study_zone
    {
        public List<Bucket> List_Bucket { get; set; }
        public string INPUT_GEOID { get; set; }
        public List<Topic> LIST_TOPIC { get; set; }
    }
    public partial class Surveillance_Camera_Content
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public long CameraId { get; set; }
        public object Nvr { get; set; }
        public object NvrChannel { get; set; }
        public string Name { get; set; }
        public object Ip { get; set; }
        public object Port { get; set; }
        public object Account { get; set; }
        public object Password { get; set; }
        public object Description { get; set; }
        public string StreamUrl { get; set; }
        public RoiContour[] RoiContour { get; set; }
        public object Manufacturer { get; set; }
        public object Model { get; set; }
        public string Resolution { get; set; }
        public long? FrameRate { get; set; }
        public object[] Plugins { get; set; }
        public long AinvrId { get; set; }
        public string Protocol { get; set; }
        public long? EngineProfileId { get; set; }
        public EngineProfile EngineProfile { get; set; }
        public string Status { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public object GpuId { get; set; }
        public object HwDecode { get; set; }
        public string CscState { get; set; }
        public string LocationType { get; set; }
        public object FloorPlanId { get; set; }
        public object FloorPlanX { get; set; }
        public object FloorPlanY { get; set; }
        public object FloorPlanAngle { get; set; }
        public string[] EngineModels { get; set; }
        public long? Resource { get; set; }
        public Schedule Schedule { get; set; }
        public string CameraType { get; set; }
        public string FpsType { get; set; }
        public long Loop { get; set; }
        public string ExternalMeta { get; set; }
        public string AuthenticatedUrl { get; set; }
    }
    public partial class Sustainability_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    public partial class Top_level
    {
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public int? LOW_THRESHOLD { get; set; }
        public int? HIGH_THRESHOLD { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    public partial class Top_Level_Data
    {
        public long? TOP_LEVEL_ID { get; set; }
        public string TOP_LEVEL_NAME { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
    }
    public partial class Topic
    {
        public string TOPIC { get; set; }
        public List<Characteristic> LIST_CHARACTERISTIC { get; set; }
    }
    public partial class Upper_Level
    {
        public long? LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public string LOGO_URL { get; set; }
        public string IMAGE_URL { get; set; }
        public decimal? LONGITUDE { get; set; }
        public decimal? LATITUDE { get; set; }
    }
    public partial class User
    {
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? USER_TYPE_SETUP_ID { get; set; }
        public int? OWNER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string IMAGE_URL { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_RECEIVE_EMAIL { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public string USER_DISTRICTNEX_WALKTHROUGH { get; set; }
        public string USER_ADMIN_WALKTHROUGH { get; set; }
        public string DATE_DELETED { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
        public Organization Organization { get; set; }
        public Setup User_type_setup { get; set; }
        public List<User_districtnex_module> List_User_districtnex_module { get; set; }
        public List<User_level_access> List_User_level_access { get; set; }
    }
    public partial class User_Accessible_Data
    {
        public Organization ORGANIZATION { get; set; }
        public List<long?> LIST_ORGANIZATION_AREA_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_SITE_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_REGION_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_ENTITY_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_DISTRICT_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_TOP_LEVEL_ID { get; set; }
        public List<long?> LIST_USER_AREA_ID { get; set; }
        public List<long?> LIST_USER_SITE_ID { get; set; }
        public List<long?> LIST_USER_REGION_ID { get; set; }
        public List<long?> LIST_USER_ENTITY_ID { get; set; }
        public List<long?> LIST_USER_DISTRICT_ID { get; set; }
        public List<long?> LIST_USER_TOP_LEVEL_ID { get; set; }
        public List<Removed_extrusion> LIST_REMOVED_EXTRUSIONS { get; set; }
        public List<User_districtnex_module> LIST_USER_DISTRICTNEX_MODULE { get; set; }
    }
    public partial class User_Accessible_Data_With_Level_List
    {
        public User_Accessible_Data USER_ACCESSIBLE_DATA { get; set; }
        public User_Accessible_Level_List USER_ACCESSIBLE_LEVEL_LIST { get; set; }
    }
    public partial class User_Accessible_Level_List
    {
        public string GEOJSON_SRC { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Upper_Level UPPER_LEVEL { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
        public List<Level_Dimension_with_Status> LIST_LEVEL_DIMENSION_WITH_STATUS { get; set; }
        public Organization_data_source_kpi_List_By_Top_Level ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL { get; set; }
        public List<Organization_data_source_kpi> ORGANIZATION_DATA_SOURCE_KPI_LIST { get; set; }
        public Accessible_Level_List_By_Top_Level ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL { get; set; }
        public List<Accessible_Level_ID_List_By_Top_Level> LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL { get; set; }
    }
    public partial class User_Data_Access
    {
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
        public List<District_kpi_user_access> LIST_DISTRICT_KPI_USER_ACCESS { get; set; }
        public List<Area_kpi_user_access> LIST_AREA_KPI_USER_ACCESS { get; set; }
        public List<Site_kpi_user_access> LIST_SITE_KPI_USER_ACCESS { get; set; }
        public List<Entity_kpi_user_access> LIST_ENTITY_KPI_USER_ACCESS { get; set; }
        public List<District> LIST_DISTRICT { get; set; }
        public List<Area> LIST_AREA { get; set; }
        public List<Site> LIST_SITE { get; set; }
        public List<Entity> LIST_ENTITY { get; set; }
    }
    public partial class User_Details
    {
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? USER_TYPE_SETUP_ID { get; set; }
        public int? OWNER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USERNAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string IMAGE_URL { get; set; }
        public string USER_DISTRICTNEX_WALKTHROUGH { get; set; }
        public string USER_ADMIN_WALKTHROUGH { get; set; }
        public bool IS_RECEIVE_EMAIL { get; set; }
        public Organization Organization { get; set; }
        public Setup User_type_setup { get; set; }
        public string TICKET { get; set; }
    }
    public partial class User_districtnex_module
    {
        public long? USER_DISTRICTNEX_MODULE_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? DISTRICTNEX_MODULE_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Districtnex_module Districtnex_module { get; set; }
        public User User { get; set; }
    }
    public partial class User_level_access
    {
        public long? USER_LEVEL_ACCESS_ID { get; set; }
        public long? ORGANIZATION_LEVEL_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Organization_level_access Organization_level_access { get; set; }
        public Setup Data_level_setup { get; set; }
        public User User { get; set; }
    }
    public partial class User_theme
    {
        public int? USER_THEME_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_THEME_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Organization_theme Organization_theme { get; set; }
        public User User { get; set; }
    }
    public partial class Vehicle_Counting
    {
        public List<Get_Countings_Response> GET_COUNTINGS_RESPONSE_LIST { get; set; }
        public List<Vehicle_Counting_Table_Data> VEHICLE_COUNTING_TABLE_DATA_LIST { get; set; }
    }
    public partial class Vehicle_Counting_Table_Data
    {
        public string TIME { get; set; }
        public int TOTAL_IN { get; set; }
        public int TOTAL_OUT { get; set; }
        public int TOTAL_OCCUPANCY { get; set; }
        public int BICYCLE_IN { get; set; }
        public int BICYCLE_OCCUPANCY { get; set; }
        public int BICYCLE_OUT { get; set; }
        public int BUS_IN { get; set; }
        public int BUS_OCCUPANCY { get; set; }
        public int BUS_OUT { get; set; }
        public int CAR_IN { get; set; }
        public int CAR_OCCUPANCY { get; set; }
        public int CAR_OUT { get; set; }
        public int MOTORBIKE_IN { get; set; }
        public int MOTORBIKE_OCCUPANCY { get; set; }
        public int MOTORBIKE_OUT { get; set; }
        public int TRUCK_IN { get; set; }
        public int TRUCK_OCCUPANCY { get; set; }
        public int TRUCK_OUT { get; set; }
    }
    public partial class Video_ai_asset
    {
        public int? VIDEO_AI_ASSET_ID { get; set; }
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public int? VIDEO_AI_ASSET_ID_REF { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public int? RESOLUTION_X { get; set; }
        public int? RESOLUTION_Y { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Space_asset Space_asset { get; set; }
        public Video_ai_instance Video_ai_instance { get; set; }
        public List<Video_ai_asset_entity> List_Video_ai_asset_entity { get; set; }
        public bool IS_ERROR { get; set; }
        public Surveillance_Camera_Content Surveillance_Camera_Content { get; set; }
    }
    public partial class Video_ai_asset_entity
    {
        public int? VIDEO_AI_ASSET_ENTITY_ID { get; set; }
        public int? VIDEO_AI_ASSET_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Entity Entity { get; set; }
        public Video_ai_asset Video_ai_asset { get; set; }
    }
    public partial class Video_ai_assets_with_engine_assets
    {
        public List<Video_ai_asset> VIDEO_AI_ASSET_WITH_FLAG_LIST { get; set; }
        public List<Surveillance_Camera_Content> ASSET_LIST { get; set; }
    }
    public partial class Video_ai_engine
    {
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string ENGINE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public List<Video_ai_instance> List_Video_ai_instance { get; set; }
    }
    public partial class Video_ai_instance
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public string CONNECTION_URL { get; set; }
        public long? CONNECTION_TYPE_SETUP_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool IS_LPR { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Video_ai_engine Video_ai_engine { get; set; }
        public Setup Connection_type_setup { get; set; }
    }
    public partial class Video_ai_instance_with_connection_flag
    {
        public Video_ai_instance oVideo_ai_instance { get; set; }
        public bool IS_FORCE_CONNECTION { get; set; }
        public string RESPONSE_MESSAGE { get; set; }
    }
    public partial class Visitor_Activity
    {
        public long? TIME_BUCKET_SIZE { get; set; }
        public DateTime? END_TIME { get; set; }
        public string REQUEST_ID { get; set; }
        public DateTime? START_TIME { get; set; }
        public List<Study_zone> LIST_STUDY_ZONE { get; set; }
        public string STATUS { get; set; }
    }
    public partial class Visitor_Count_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public decimal? VISITOR_COUNT { get; set; }
    }
    public partial class Visitor_Data
    {
        public long? TIME_BUCKET_SIZE { get; set; }
        public DateTime? END_TIME { get; set; }
        public string REQUEST_ID { get; set; }
        public DateTime? START_TIME { get; set; }
        public List<Study_zone> LIST_STUDY_ZONE { get; set; }
        public string STATUS { get; set; }
    }
    public partial class Visitor_Origins
    {
        public List<Ext_study_zone_With_Count> LIST_EXT_STUDY_ZONE_WITH_COUNT { get; set; }
        public string GEOJSON { get; set; }
    }
    public partial class Wifi_signal
    {
        public DateTime? RECORD_DATE { get; set; }
        public decimal? VALUE { get; set; }
        public string VALUE_NAME { get; set; }
        public Wifi_signal_Metadata WIFI_SIGNAL_METADATA { get; set; }
    }
    public partial class Wifi_signal_alert
    {
        public string WIFI_SIGNAL_ALERT_ID { get; set; }
        public decimal? ALERT_VALUE { get; set; }
        public decimal? RESOLVE_VALUE { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public bool? IS_RESOLVED { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    public partial class Wifi_signal_data
    {
        public List<Wifi_signal> WIFI_SIGNAL_LIST { get; set; }
        public List<Wifi_signal_alert> WIFI_SIGNAL_ALERT_LIST { get; set; }
    }
    public partial class Wifi_signal_Metadata
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    public partial class Params_Get_Asset_By_ASSET_ID_List
    {
        public IEnumerable<long?> ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Get_Asset_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Asset_By_ASSET_ID
    {
        public long? ASSET_ID { get; set; }
    }
    public partial class Params_Get_Asset_Data_List
    {
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Delete_Asset
    {
        public long? ASSET_ID { get; set; }
    }
    public partial class Params_Get_Data_source_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Generate_Area_Dwell_Time
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    public partial class Params_Edit_Job_List
    {
        public List<Job> List_Job { get; set; }
    }
    public partial class Params_Generate_District_Dwell_Time
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    public partial class Params_Get_Visitor_Data
    {
        public string AUTH_TOKEN { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public int? DWELL_BUCKET_TIME { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Edit_Kpi_List
    {
        public List<Kpi> List_To_Edit { get; set; }
        public List<Kpi> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Insert_Entity_Kpi_Data_List
    {
        public List<Entity_kpi_data> ENTITY_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Delete_Data_source
    {
        public int? DATA_SOURCE_ID { get; set; }
    }
    public partial class Params_Get_And_Fill_Bylaw_complaints_From_Api
    {
        public DateTime? DATE_CREATED_START_DATE { get; set; }
    }
    public partial class Params_Generate_Or_Compute_District_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Generate_Or_Compute_Area_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Generate_Or_Compute_Site_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Extract_Kpi_Data_From_CSV
    {
        public int? ORGANIZATION_ID { get; set; }
        public string FILE_NAME { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Generate_Area_Demographic_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    public partial class Params_Get_Jobs_By_Where
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<string> JOB_ID_LIST { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public List<int?> MIN_DWELL_TIME_LIST { get; set; }
        public List<int?> MAX_DWELL_TIME_LIST { get; set; }
        public List<int?> DWELL_TIME_BUCKET_LIST { get; set; }
        public List<long?> REQUEST_SETUP_ID_LIST { get; set; }
    }
    public partial class Params_Generate_Or_Compute_Floor_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Delete_Space_Kpi_Data_By_Where
    {
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Generate_Site_Visitor_Data_And_Dwell_Time
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Visitor_Data Visitor_Data { get; set; }
        public Visitor_Data Dwell_Time_1 { get; set; }
        public Visitor_Data Dwell_Time_2 { get; set; }
        public Visitor_Data Dwell_Time_3 { get; set; }
        public Visitor_Data Dwell_Time_4 { get; set; }
    }
    public partial class Params_Edit_Niche_categories_List
    {
        public List<Niche_categories> List_Niche_categories { get; set; }
    }
    public partial class Params_Delete_Niche_categories
    {
        public List<string> BUSINESS_NICHE_LIST { get; set; }
        public List<string> NICHE_CATEGORIES_ID_LIST { get; set; }
    }
    public partial class Params_Delete_Site_Kpi_Data_By_Where
    {
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Insert_Space_Kpi_Data_List
    {
        public List<Space_kpi_data> SPACE_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Generate_Site_Demographic_Data
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Demographic_Data Demographic_Data { get; set; }
    }
    public partial class Params_Insert_Site_Kpi_Data_List
    {
        public List<Site_kpi_data> SITE_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Delete_Entity_Kpi_Data_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Demographic_Data
    {
        public string AUTH_TOKEN { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Generate_District_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Niche_categories_By_Where
    {
        public List<string> BUSINESS_NICHE_LIST { get; set; }
        public List<string> NICHE_CATEGORIES_ID_LIST { get; set; }
    }
    public partial class Params_Generate_Entity_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Generate_Worker_Data
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Visitor_Data Visitor_Data { get; set; }
    }
    public partial class Params_Delete_District_Kpi_Data_By_Where
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Organization_data_source_kpi_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Delete_Floor_Kpi_Data_By_Where
    {
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Insert_Area_Kpi_Data_List
    {
        public List<Area_kpi_data> AREA_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Generate_Space_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
    {
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    public partial class Params_Generate_Business_Count_And_Vacant_Business_Count
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    public partial class Params_Insert_District_Kpi_Data_List
    {
        public List<District_kpi_data> DISTRICT_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Delete_Organization_data_source_kpi
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    public partial class Params_Generate_Site_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Visitor_Activity_Data
    {
        public string AUTH_TOKEN { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public int? DWELL_BUCKET_TIME { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_And_Fill_Public_events_From_Api
    {
        public DateTime? DATE_CREATED_START_DATE { get; set; }
    }
    public partial class Params_Generate_Floor_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Generate_Area_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Generate_Or_Compute_Entity_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Delete_Job
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<string> JOB_ID_LIST { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public List<int?> MIN_DWELL_TIME_LIST { get; set; }
        public List<int?> MAX_DWELL_TIME_LIST { get; set; }
        public List<int?> DWELL_TIME_BUCKET_LIST { get; set; }
        public List<long?> REQUEST_SETUP_ID_LIST { get; set; }
    }
    public partial class Params_Generate_District_Demographic_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    public partial class Params_Insert_Floor_Kpi_Data_List
    {
        public List<Floor_kpi_data> FLOOR_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Generate_Visitor_Activity_Data
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Visitor_Activity Visitor_Activity { get; set; }
    }
    public partial class Params_Get_Floor_By_ENTITY_ID_List
    {
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
    }
    public partial class Params_Edit_Entity_share_data
    {
        public Entity_share_data Entity_share_data { get; set; }
    }
    public partial class Params_Get_Share_file_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Get_Share_file_By_SHARE_FILE_ID
    {
        public int? SHARE_FILE_ID { get; set; }
    }
    public partial class Params_Get_Entity_share_view_data
    {
        public string UNIQUE_STRING { get; set; }
    }
    public partial class Params_Send_Share_Link_By_Email
    {
        public string SHARE_DATA_LINK { get; set; }
        public List<string> List_Email { get; set; }
    }
    public partial class Params_Delete_Share_file
    {
        public int? SHARE_FILE_ID { get; set; }
    }
    public partial class Params_Get_Space_asset_By_SPACE_ID_List
    {
        public IEnumerable<long?> SPACE_ID_LIST { get; set; }
    }
    public partial class Params_Get_Space_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_Space_List
    {
        public List<Space> List_To_Edit { get; set; }
        public List<Space> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Space_asset_By_SPACE_ID
    {
        public long? SPACE_ID { get; set; }
    }
    public partial class Params_Get_Space_By_FLOOR_ID
    {
        public long? FLOOR_ID { get; set; }
    }
    public partial class Params_Get_Space_asset_By_SPACE_ASSET_ID_List
    {
        public IEnumerable<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Edit_Space_asset_List
    {
        public List<Space_asset> List_To_Edit { get; set; }
        public List<Space_asset> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Space_asset_By_SPACE_ID
    {
        public long? SPACE_ID { get; set; }
    }
    public partial class Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List
    {
        public IEnumerable<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Get_Report_Details
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
        public List<Asset_definition> LIST_DISTRICT_ASSET_DEFINITION { get; set; }
        public List<Asset_definition> LIST_AREA_ASSET_DEFINITION { get; set; }
        public List<Asset_definition> LIST_SITE_ASSET_DEFINITION { get; set; }
        public List<Asset_definition> LIST_ENTITY_ASSET_DEFINITION { get; set; }
    }
    public partial class Params_Send_Report_Email
    {
        public int REPORT_ID { get; set; }
        public string TO_EMAIL { get; set; }
    }
    public partial class Params_Get_District_By_DISTRICT_ID_List
    {
        public IEnumerable<long?> DISTRICT_ID_LIST { get; set; }
    }
    public partial class Params_Get_District_view_By_DISTRICT_ID
    {
        public long? DISTRICT_ID { get; set; }
    }
    public partial class Params_Get_District_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_District_geojson_By_DISTRICT_ID_List
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
    }
    public partial class Params_Delete_District_view
    {
        public long? DISTRICT_VIEW_ID { get; set; }
    }
    public partial class Params_Edit_District_view_List
    {
        public List<District_view> List_To_Edit { get; set; }
        public List<District_view> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_District_view_By_DISTRICT_ID
    {
        public long? DISTRICT_ID { get; set; }
    }
    public partial class Params_Get_District_view_By_DISTRICT_ID_List
    {
        public IEnumerable<long?> DISTRICT_ID_LIST { get; set; }
    }
    public partial class Params_Get_Wifi_signals
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    public partial class Params_Get_District_Kpi_Dialog_Data
    {
        public long? DISTRICT_ID { get; set; }
        public List<int?> LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Area_Kpi_Data_Aggregate_Sum
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Entity_Kpi_Data_By_Where
    {
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Area_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Site_Kpi_Dialog_Data
    {
        public long? DISTRICT_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? SITE_ID { get; set; }
        public List<int?> LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public List<int?> LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public List<int?> LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Site_Kpi_Data_By_Where
    {
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Edit_Alert_List
    {
        public List<Alert> List_Alert { get; set; }
    }
    public partial class Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
    }
    public partial class Params_Compute_District_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Bylaw_Complaint_List
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
    }
    public partial class Params_Delete_Kpi
    {
        public int? KPI_ID { get; set; }
    }
    public partial class Params_Delete_Wifi_signal
    {
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Compute_Floor_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Edit_Wifi_signal_alert_List
    {
        public List<Wifi_signal_alert> List_Wifi_signal_alert { get; set; }
    }
    public partial class Params_Delete_Alert
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? ARE_UNACKNOWLEDGEMENTS_CREATED { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Compute_District_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_District_Kpi_Data_Aggregate_Sum
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Latest_Organization_data_source_kpi_By_Where
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Space_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Compute_Space_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Update_Kpi_Data_Record
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public int? KPI_ID { get; set; }
        public bool IS_RANDOM { get; set; }
        public bool FORCE_INJECT { get; set; }
    }
    public partial class Params_Compute_Area_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Latest_Wifi_signal_alerts
    {
        public int? NUMBER_OF_POINTS { get; set; }
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Get_Floor_Kpi_Data_Aggregate_Sum
    {
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Entity_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    public partial class Params_Compute_Area_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Business_Trendline
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Edit_Wifi_signal_List
    {
        public List<Wifi_signal> List_Wifi_signal { get; set; }
    }
    public partial class Params_Compute_Entity_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Floor_Kpi_Dialog_Data
    {
        public long? FLOOR_ID { get; set; }
        public long? SITE_ID { get; set; }
        public List<int?> LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Latest_GeoData_By_KPI
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    public partial class Params_Get_Public_Event_List
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
    }
    public partial class Params_Get_Alerts_By_Where
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public List<long?> LEVEL_ID_LIST { get; set; }
    }
    public partial class Params_Compute_Site_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Compute_Entity_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Compute_Entity_Kpi_Data_Monthly
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Edit_User_Data_Access
    {
        public List<District_kpi_user_access> List_To_Edit_District_kpi_user_access { get; set; }
        public List<District_kpi_user_access> List_To_Delete_District_kpi_user_access { get; set; }
        public List<Area_kpi_user_access> List_To_Edit_Area_kpi_user_access { get; set; }
        public List<Area_kpi_user_access> List_To_Delete_Area_kpi_user_access { get; set; }
        public List<Site_kpi_user_access> List_To_Edit_Site_kpi_user_access { get; set; }
        public List<Site_kpi_user_access> List_To_Delete_Site_kpi_user_access { get; set; }
        public List<Entity_kpi_user_access> List_To_Edit_Entity_kpi_user_access { get; set; }
        public List<Entity_kpi_user_access> List_To_Delete_Entity_kpi_user_access { get; set; }
        public Setup Selected_Level_Setup { get; set; }
    }
    public partial class Params_Get_Organization_Data_Access
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_User_Data_Access
    {
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Delete_Wifi_signal_alert
    {
        public List<string> WIFI_SIGNAL_ALERT_ID_LIST { get; set; }
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public bool? IS_RESOLVED { get; set; }
    }
    public partial class Params_Get_Area_Kpi_Dialog_Data
    {
        public long? DISTRICT_ID { get; set; }
        public long? AREA_ID { get; set; }
        public List<int?> LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public List<int?> LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Alerts_Count_For_Levels
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
    }
    public partial class Params_Get_Space_Kpi_Data_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Site_Kpi_Data_Aggregate_Sum
    {
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Latest_Visitor_Count_By_Where
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Entity_Kpi_Data_Aggregate_Sum
    {
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Floor_Kpi_Data_Hourly
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Wifi_signal_alerts
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<string> WIFI_SIGNAL_ALERT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_RESOLVED { get; set; }
    }
    public partial class Params_Get_District_Kpi_Data_By_Where
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Kpi_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Floor_Kpi_Data_By_Where
    {
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Floor_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Update_Wifi_signal
    {
        public long? FLOOR_ID { get; set; }
    }
    public partial class Params_Get_Visitor_Origins
    {
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Site_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Compute_District_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Latest_Wifi_signals
    {
        public int? NUMBER_OF_POINTS { get; set; }
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    public partial class Params_Get_Alerts_By_Where_Count
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public List<long?> LEVEL_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
    }
    public partial class Params_Get_Entity_Incidents
    {
        public int? END_ROW { get; set; }
        public int? START_ROW { get; set; }
        public long? ENTITY_ID { get; set; }
        public string END_DATE { get; set; }
        public string START_DATE { get; set; }
        public List<Setup> CATEGORY_SETUP_LIST { get; set; }
    }
    public partial class Params_Get_Bylaw_Complaints_Trendline
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Alerts_For_Levels
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
    }
    public partial class Params_Compute_Space_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Area_Kpi_Data_By_Where
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Site_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Compute_District_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Intersection_Kpi_Dialog_Data
    {
        public long? ENTITY_ID { get; set; }
        public List<int?> LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Floor_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Strongest_Wifi_signal
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> FLOOR_ID_LIST { get; set; }
        public int? TOP_LEVEL_ID { get; set; }
    }
    public partial class Params_Compute_Area_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Business_List
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Edit_Organization_Data_Access
    {
        public List<District_kpi> List_To_Edit_District_kpi { get; set; }
        public List<District_kpi> List_To_Delete_District_kpi { get; set; }
        public List<Area_kpi> List_To_Edit_Area_kpi { get; set; }
        public List<Area_kpi> List_To_Delete_Area_kpi { get; set; }
        public List<Site_kpi> List_To_Edit_Site_kpi { get; set; }
        public List<Site_kpi> List_To_Delete_Site_kpi { get; set; }
        public List<Entity_kpi> List_To_Edit_Entity_kpi { get; set; }
        public List<Entity_kpi> List_To_Delete_Entity_kpi { get; set; }
        public Setup Selected_Level_Setup { get; set; }
    }
    public partial class Params_Get_Entity_Kpi_Dialog_Data
    {
        public long? ENTITY_ID { get; set; }
        public List<int?> LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Compute_Site_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    public partial class Params_Get_Most_Wifi_signal_Count_Per_Space_asset
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> FLOOR_ID_LIST { get; set; }
        public int? TOP_LEVEL_ID { get; set; }
    }
    public partial class Params_Get_Public_Events_Trendline
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_User_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Get_Top_level_By_TOP_LEVEL_ID_List
    {
        public IEnumerable<long?> TOP_LEVEL_ID_LIST { get; set; }
    }
    public partial class Params_Get_Top_level_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Entity_view_By_ENTITY_ID
    {
        public long? ENTITY_ID { get; set; }
    }
    public partial class Params_Delete_Entity_view
    {
        public long? ENTITY_VIEW_ID { get; set; }
    }
    public partial class Params_Get_Entity_By_SITE_ID
    {
        public long? SITE_ID { get; set; }
    }
    public partial class Params_Get_Entity_By_ENTITY_ID
    {
        public long? ENTITY_ID { get; set; }
    }
    public partial class Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID
    {
        public List<long?> ENTITY_ID_LIST { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
    }
    public partial class Params_Get_Entity_By_ENTITY_ID_List
    {
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
    }
    public partial class Params_Get_Entity_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_Entity_view_List
    {
        public List<Entity_view> List_To_Edit { get; set; }
        public List<Entity_view> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Entity_view_By_ENTITY_ID
    {
        public long? ENTITY_ID { get; set; }
    }
    public partial class Params_Get_Entity_view_By_ENTITY_ID_List
    {
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
    }
    public partial class Params_Get_Region_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Delete_Region_view
    {
        public long? REGION_VIEW_ID { get; set; }
    }
    public partial class Params_Get_Region_view_By_REGION_ID
    {
        public long? REGION_ID { get; set; }
    }
    public partial class Params_Get_Floor_By_ENTITY_ID
    {
        public long? ENTITY_ID { get; set; }
    }
    public partial class Params_Get_Floor_By_ENTITY_ID_With_Space_Asset
    {
        public long? ENTITY_ID { get; set; }
    }
    public partial class Params_Get_Floor_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Logs_With_Filters
    {
        public int? END_ROW { get; set; }
        public int? START_ROW { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_ID_LIST { get; set; }
        public List<int?> VIDEO_AI_ASSET_ID_LIST { get; set; }
        public List<long?> LOG_TYPE_SETUP_ID_LIST { get; set; }
        public List<long?> ACCESS_TYPE_SETUP_ID_LIST { get; set; }
    }
    public partial class Params_Generate_Logs_Excel
    {
        public int? END_ROW { get; set; }
        public int? START_ROW { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_ID_LIST { get; set; }
        public List<int?> VIDEO_AI_ASSET_ID_LIST { get; set; }
        public List<long?> LOG_TYPE_SETUP_ID_LIST { get; set; }
        public List<long?> ACCESS_TYPE_SETUP_ID_LIST { get; set; }
    }
    public partial class Params_Get_Latest_Dimension_index_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<Dimension_ID_By_Level_ID> LIST_DIMENSION_ID_BY_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Dimension_By_DIMENSION_ORDER_List
    {
        public IEnumerable<int?> DIMENSION_ORDER_LIST { get; set; }
    }
    public partial class Params_Edit_Dimension_List
    {
        public List<Dimension> List_To_Edit { get; set; }
        public List<Dimension> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Dimension_By_DIMENSION_ID_List
    {
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
    }
    public partial class Params_Get_Dimension_By_DIMENSION_ID
    {
        public int? DIMENSION_ID { get; set; }
    }
    public partial class Params_Compute_Dimension_Index_Monthly
    {
        public int DAY { get; set; }
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Dimension> LIST_DIMENSION { get; set; }
    }
    public partial class Params_Insert_Dimension_index_List
    {
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Compute_Dimension_Index_Weekly
    {
        public int DAY { get; set; }
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Dimension> LIST_DIMENSION { get; set; }
    }
    public partial class Params_Get_Dimension_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Dimension_index_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Generate_Dimension_Index_Daily
    {
        public int DAY { get; set; }
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Dimension> LIST_DIMENSION { get; set; }
    }
    public partial class Params_Delete_Dimension_index_By_Where
    {
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Site_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Site_By_SITE_ID_List
    {
        public IEnumerable<long?> SITE_ID_LIST { get; set; }
    }
    public partial class Params_Get_Ext_study_zone_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Delete_Site_view
    {
        public long? SITE_VIEW_ID { get; set; }
    }
    public partial class Params_Get_Site_By_SITE_ID
    {
        public long? SITE_ID { get; set; }
    }
    public partial class Params_Get_Site_geojson_By_SITE_ID_List
    {
        public List<long?> SITE_ID_LIST { get; set; }
    }
    public partial class Params_Get_Site_view_By_SITE_ID
    {
        public long? SITE_ID { get; set; }
    }
    public partial class Params_Edit_Ext_study_zone_List
    {
        public List<Ext_study_zone> List_To_Edit { get; set; }
        public List<Ext_study_zone> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Edit_Site_view_List
    {
        public List<Site_view> List_To_Edit { get; set; }
        public List<Site_view> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Site_view_By_SITE_ID
    {
        public long? SITE_ID { get; set; }
    }
    public partial class Params_Get_Site_view_By_SITE_ID_List
    {
        public IEnumerable<long?> SITE_ID_LIST { get; set; }
    }
    public partial class Params_Get_Site_field_logo_By_SITE_ID_List
    {
        public IEnumerable<long?> SITE_ID_LIST { get; set; }
    }
    public partial class Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
    {
        public int? ORGANIZATION_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
    }
    public partial class Params_Get_Organization_image_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Delete_Organization_theme
    {
        public int? ORGANIZATION_THEME_ID { get; set; }
    }
    public partial class Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
    {
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Get_Organization_theme_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Edit_Organization_Custom
    {
        public Organization ORGANIZATION { get; set; }
    }
    public partial class Params_Schedule_Organization_for_Delete
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Modify_Data_Settings
    {
        public int? ORGANIZATION_ID { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public Params_Edit_Organization_log_config_List Params_Edit_Organization_log_config_List { get; set; }
    }
    public partial class Params_Edit_Organization_log_config_List
    {
        public List<Organization_log_config> List_To_Edit { get; set; }
        public List<Organization_log_config> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Modify_Organization_Details
    {
        public int? ORGANZATION_ID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string ORGANIZATION_PHONE_NUMBER { get; set; }
        public string ORGANIZATION_EMAIL { get; set; }
        public string ORGANIZATION_ADDRESS { get; set; }
        public int? MAX_NUMBER_OF_ADMINS { get; set; }
        public int? MAX_NUMBER_OF_USERS { get; set; }
    }
    public partial class Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID
    {
        public int? PARENT_ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_theme_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
    {
        public int? ORGANIZATION_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Edit_Organization_districtnex_module_List
    {
        public List<Organization_districtnex_module> List_To_Edit { get; set; }
        public List<Organization_districtnex_module> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Organization_By_PARENT_ORGANIZATION_ID
    {
        public int? PARENT_ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Edit_Organization_level_access_List
    {
        public List<Organization_level_access> List_To_Edit { get; set; }
        public List<Organization_level_access> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Organization_Picture
    {
        public int? ORGANIZATION_ID { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
    }
    public partial class Params_Get_Organization_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
    {
        public int? ORGANIZATION_ID { get; set; }
        public List<string> LIST_EAGER_LOADED_DATA { get; set; }
    }
    public partial class Params_Get_Organization_color_scheme_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_Organization_chart_color_List
    {
        public List<Organization_chart_color> List_To_Edit { get; set; }
        public List<Organization_chart_color> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Organization_level_access_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Restore_Organization
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Delete_Organization_level_access
    {
        public long? ORGANIZATION_LEVEL_ACCESS_ID { get; set; }
    }
    public partial class Params_Delete_Organization_level_access_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Edit_Organization_color_scheme_List
    {
        public List<Organization_color_scheme> List_To_Edit { get; set; }
        public List<Organization_color_scheme> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_log_config_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Delete_Organization_log_config_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Get_Organization_level_access_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Get_Organization_log_config_By_ORGANIZATION_ID_List
    {
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
    }
    public partial class Params_Get_Organization_image_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_Specialized_chart_configuration_By_MODULE
    {
        public string MODULE { get; set; }
    }
    public partial class Params_Delete_District_geojson_By_DISTRICT_ID
    {
        public long? DISTRICT_ID { get; set; }
    }
    public partial class Params_Edit_Setup_category_List
    {
        public List<Setup_category> List_To_Edit { get; set; }
        public List<Setup_category> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Districtnex_module_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Setup_By_SETUP_ID
    {
        public long? SETUP_ID { get; set; }
    }
    public partial class Params_Get_Default_settings_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_Object_View
    {
        public int? DISTRICT_ID { get; set; }
        public int? AREA_ID { get; set; }
        public int? SITE_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal PITCH { get; set; }
        public decimal BEARING { get; set; }
        public decimal ZOOM { get; set; }
        public decimal LONGITUDE { get; set; }
        public decimal LATITUDE { get; set; }
    }
    public partial class Params_Get_Setup_category_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_District_geojson
    {
        public string District_geojson { get; set; }
    }
    public partial class Params_Delete_Build_version
    {
        public int? BUILD_VERSION_ID { get; set; }
    }
    public partial class Params_Edit_Ext_study_zone_geojson
    {
        public string Ext_study_zone_geojson { get; set; }
    }
    public partial class Params_Delete_Default_Settings_Picture
    {
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
    }
    public partial class Params_Edit_Removed_extrusion_Custom_Old
    {
        public string ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? LEVEL_ID { get; set; }
    }
    public partial class Params_Delete_Setup_category
    {
        public int? SETUP_CATEGORY_ID { get; set; }
    }
    public partial class Params_Get_Build_version_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Default_chart_color_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_Default_chart_color_List
    {
        public List<Default_chart_color> List_To_Edit { get; set; }
        public List<Default_chart_color> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID
    {
        public int? SETUP_CATEGORY_ID { get; set; }
    }
    public partial class Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
    {
        public int? EXT_STUDY_ZONE_ID { get; set; }
    }
    public partial class Params_Edit_Alert_settings_List
    {
        public List<Alert_settings> List_To_Edit { get; set; }
        public List<Alert_settings> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Dimension_chart_configuration
    {
        public string DIMENSION_CHART_CONFIGURATION_ID { get; set; }
    }
    public partial class Params_Edit_Site_geojson
    {
        public string Site_geojson { get; set; }
    }
    public partial class Params_Delete_Area_geojson_By_AREA_ID
    {
        public long? AREA_ID { get; set; }
    }
    public partial class Params_Delete_Specialized_chart_configuration
    {
        public string SPECIALIZED_CHART_CONFIGURATION_ID { get; set; }
    }
    public partial class Params_Get_Alert_settings_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID
    {
        public long? APPLICATION_NAME_SETUP_ID { get; set; }
    }
    public partial class Params_Edit_Removed_extrusion_Custom
    {
        public List<Removed_extrusion> List_Removed_extrusion { get; set; }
    }
    public partial class Params_Delete_Kpi_chart_configuration
    {
        public string KPI_CHART_CONFIGURATION_ID { get; set; }
    }
    public partial class Params_Custom_Edit_Build_version
    {
        public Build_version Build_version { get; set; }
    }
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    {
        public string SETUP_CATEGORY_NAME { get; set; }
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Setup_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Edit_Area_geojson
    {
        public string Area_geojson { get; set; }
    }
    public partial class Params_Delete_Site_geojson_By_SITE_ID
    {
        public long? SITE_ID { get; set; }
    }
    public partial class Params_Edit_Removed_extrusion_List
    {
        public List<Removed_extrusion> List_To_Edit { get; set; }
        public List<Removed_extrusion> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Removed_extrusion_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Delete_Setup
    {
        public long? SETUP_ID { get; set; }
    }
    public partial class Params_Get_Alert_settings_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Send_Support_Email
    {
        public string TITLE { get; set; }
        public string MESSAGE { get; set; }
        public List<string> List_Email { get; set; }
    }
    public partial class Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List
    {
        public IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST { get; set; }
    }
    public partial class Params_Drop_Collection
    {
        public string COLLECTION_NAME { get; set; }
    }
    public partial class Params_Edit_Build_version_List
    {
        public List<Build_version> List_To_Edit { get; set; }
        public List<Build_version> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Create_Time_series_Collection
    {
        public string TIME_SERIES_COLLECTION_NAME { get; set; }
    }
    public partial class Params_Get_Correlation_method_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Delete_Correlation_method
    {
        public int? CORRELATION_METHOD_ID { get; set; }
    }
    public partial class Params_Get_Correlation
    {
        public int? RESOLUTION { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public int? CORRELATION_METHOD_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
        public Organization_data_source_kpi_By_Level First_Organization_data_source_kpi_By_Level { get; set; }
        public Organization_data_source_kpi_By_Level Second_Organization_data_source_kpi_By_Level { get; set; }
    }
    public partial class Params_Get_Comparison_Data
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Multi_kpi_comparison
    {
        public List<Organization_data_source_kpi_By_Level> LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Single_kpi_comparison
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Fetch_Scenes
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string QUERY { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    public partial class Params_Get_Vehicle_Types
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? ENTITY_ID { get; set; }
    }
    public partial class Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
    {
        public int? VIDEO_AI_ENGINE_ID { get; set; }
    }
    public partial class Params_Create_Video_ai_asset
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public int? SPACE_ASSET_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public int? VIDEO_AI_ASSET_ID_REF { get; set; }
        public int? RESOLUTION_X { get; set; }
        public int? RESOLUTION_Y { get; set; }
    }
    public partial class Params_Change_Video_ai_instance_Password
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public string NEW_PASSWORD { get; set; }
        public bool FORCE_CONNECTION { get; set; }
    }
    public partial class Params_Face_Target_Key_Search
    {
        public int? PAGE { get; set; }
        public int? SIZE { get; set; }
        public string DESCRIPTOR { get; set; }
        public double SCORES { get; set; }
        public int? LIMIT { get; set; }
    }
    public partial class Params_Face_Search
    {
        public int? PAGE { get; set; }
        public int? SIZE { get; set; }
        public string DESCRIPTOR { get; set; }
        public double SCORES { get; set; }
        public int? LIMIT { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    public partial class Params_Fetch_License_Plate_Categories
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Fetch_Face_Targets
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string CATEGORY { get; set; }
        public string TARGET_NAME { get; set; }
    }
    public partial class Params_Fetch_Facial_Recognition
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string TARGET_NAME { get; set; }
        public double SCORES { get; set; }
        public string CATEGORIES { get; set; }
        public bool? HAS_MASK { get; set; }
        public string AGE { get; set; }
        public string GENDER { get; set; }
        public string EMOTION { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    public partial class Params_Delete_Video_ai_asset_Custom
    {
        public int? VIDEO_AI_ASSET_ID { get; set; }
    }
    public partial class Params_Get_Video_ai_engine_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Fetch_License_Plate_Targets
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string CATEGORY { get; set; }
        public string PLATE_NUMBER { get; set; }
    }
    public partial class Params_Get_Video_ai_asset_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Stream_Data
    {
        public int? ENTITY_ID { get; set; }
    }
    public partial class Params_Fetch_License_Plate_Recognition
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string END_DATE { get; set; }
        public string START_DATE { get; set; }
        public string VEHICLE_TYPE { get; set; }
        public string PLATE_NUMBER { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    public partial class Params_Get_Scene_Info
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? SCENE_ID { get; set; }
        public string OBJECT_TYPE { get; set; }
    }
    public partial class Params_Get_Countings
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public List<string> TYPES { get; set; }
        public string MEASURE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<int> LINESET_ID_LIST { get; set; }
    }
    public partial class Params_Get_Camera_Lines
    {
        public List<string> TYPES { get; set; }
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Get_Space_asset_Vaidio_camera
    {
        public int? SPACE_ASSET_ID { get; set; }
    }
    public partial class Params_Get_License_Plate_Scene
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? SCENE_ID { get; set; }
    }
    public partial class Params_Get_Video_ai_assets_with_engine_assets
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
    {
        public IEnumerable<int?> VIDEO_AI_ASSET_ID_REF_LIST { get; set; }
    }
    public partial class Params_Create_Video_ai_instance
    {
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string CONNECTION_URL { get; set; }
        public long? CONNECTION_TYPE_SETUP_ID { get; set; }
        public bool FORCE_CONNECTION { get; set; }
        public bool IS_LPR { get; set; }
    }
    public partial class Params_Delete_Video_ai_engine
    {
        public int? VIDEO_AI_ENGINE_ID { get; set; }
    }
    public partial class Params_Fetch_Face_Target_Categories
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Get_Vehicle_Countings
    {
        public List<string> TYPES { get; set; }
        public string MEASURE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<int> LINESET_ID_LIST { get; set; }
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Edit_Video_ai_instance_custom
    {
        public Video_ai_instance Video_ai_instance { get; set; }
        public bool FORCE_CONNECTION { get; set; }
    }
    public partial class Params_Send_Alerts_Email
    {
        public Scene_Details Scene { get; set; }
        public Incident Incident { get; set; }
        public string TO_EMAIL { get; set; }
    }
    public partial class Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
    {
        public int? VIDEO_AI_ASSET_ID { get; set; }
    }
    public partial class Params_Delete_Video_ai_instance
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Params_Edit_Video_ai_engine_List
    {
        public List<Video_ai_engine> List_To_Edit { get; set; }
        public List<Video_ai_engine> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Object
    {
        public string Object_Name { get; set; }
    }
    public partial class Params_Delete_Object_List
    {
        public IEnumerable<string> List_Object_Name { get; set; }
    }
    public partial class Params_Upload_Object
    {
        public byte[] Data { get; set; }
        public string Object_Name { get; set; }
    }
    public partial class Params_Get_Area_view_By_AREA_ID
    {
        public long? AREA_ID { get; set; }
    }
    public partial class Params_Get_Area_geojson_By_AREA_ID_List
    {
        public List<long?> AREA_ID_LIST { get; set; }
    }
    public partial class Params_Get_Area_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Area_By_AREA_ID_List
    {
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
    }
    public partial class Params_Delete_Area_view
    {
        public long? AREA_VIEW_ID { get; set; }
    }
    public partial class Params_Edit_Area_view_List
    {
        public List<Area_view> List_To_Edit { get; set; }
        public List<Area_view> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Area_view_By_AREA_ID
    {
        public long? AREA_ID { get; set; }
    }
    public partial class Params_Get_Area_view_By_AREA_ID_List
    {
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
    }
    public partial class Params_Get_Secret
    {
        public string Secret_Id { get; set; }
        public string Secret_Version { get; set; }
    }
    public partial class Params_Primary_Authentication
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool? IS_ADMIN { get; set; }
    }
    public partial class Params_OTP_Verification
    {
        public string USERNAME { get; set; }
        public long? USER_ID { get; set; }
        public string OTP { get; set; }
    }
    public partial class Params_Send_Otp
    {
        public string USERNAME { get; set; }
        public User USER { get; set; }
        public bool IS_FORGOT_PASSWORD { get; set; }
    }
    public partial class Params_Verify_Otp
    {
        public long? USER_ID { get; set; }
        public string OTP { get; set; }
    }
    public partial class Params_Change_User_Forgotten_Password
    {
        public string USERNAME { get; set; }
        public string NEW_PASSWORD { get; set; }
        public string OTP { get; set; }
    }
    public partial class Params_Create_User
    {
        public User USER { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Change_User_Password
    {
        public long? USER_ID { get; set; }
        public string NEW_PASSWORD { get; set; }
    }
    public partial class Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
    {
        public IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST { get; set; }
    }
    public partial class Params_Edit_User_Walkthrough
    {
        public bool IS_ADMIN_UI { get; set; }
        public string USER_WALKTHROUGH { get; set; }
    }
    public partial class Params_Schedule_User_for_Delete
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Get_User_Accessible_Level_List
    {
        public List<long?> LIST_ORGANIZATION_TOP_LEVEL_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_DISTRICT_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_AREA_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_SITE_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_ENTITY_ID { get; set; }
        public List<long?> LIST_USER_TOP_LEVEL_ID { get; set; }
        public List<long?> LIST_USER_DISTRICT_ID { get; set; }
        public List<long?> LIST_USER_AREA_ID { get; set; }
        public List<long?> LIST_USER_SITE_ID { get; set; }
        public List<long?> LIST_USER_ENTITY_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public long? SELECTED_LEVEL_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Edit_District_kpi_user_access_List
    {
        public List<District_kpi_user_access> List_To_Edit { get; set; }
        public List<District_kpi_user_access> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Area_kpi
    {
        public long? AREA_KPI_ID { get; set; }
    }
    public partial class Params_Get_User_level_access_By_USER_ID_List
    {
        public IEnumerable<long?> USER_ID_LIST { get; set; }
    }
    public partial class Params_Delete_User_level_access
    {
        public long? USER_LEVEL_ACCESS_ID { get; set; }
    }
    public partial class Params_Edit_Entity_kpi_List
    {
        public List<Entity_kpi> List_To_Edit { get; set; }
        public List<Entity_kpi> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_User_By_ORGANIZATION_ID
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Edit_User_Details
    {
        public int? USER_ID { get; set; }
        public string PHONE_NUMBER { get; set; }
        public bool IS_RECEIVE_EMAIL { get; set; }
    }
    public partial class Params_Edit_District_kpi_List
    {
        public List<District_kpi> List_To_Edit { get; set; }
        public List<District_kpi> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_User_Accessible_Data_With_Level_List
    {
        public int? CHOSEN_ORGANIZATION_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public long? SELECTED_LEVEL_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_User_districtnex_module_By_USER_ID_List
    {
        public IEnumerable<long?> USER_ID_LIST { get; set; }
    }
    public partial class Params_Get_User_By_USER_ID_List
    {
        public IEnumerable<long?> USER_ID_LIST { get; set; }
    }
    public partial class Params_Get_User_districtnex_module_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
    {
        public long? USER_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Params_Edit_Entity_kpi_user_access_List
    {
        public List<Entity_kpi_user_access> List_To_Edit { get; set; }
        public List<Entity_kpi_user_access> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Edit_Area_kpi_List
    {
        public List<Area_kpi> List_To_Edit { get; set; }
        public List<Area_kpi> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Site_kpi
    {
        public long? SITE_KPI_ID { get; set; }
    }
    public partial class Params_Edit_User_level_access_List
    {
        public List<User_level_access> List_To_Edit { get; set; }
        public List<User_level_access> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_Entity_kpi
    {
        public long? ENTITY_KPI_ID { get; set; }
    }
    public partial class Params_Get_User_Accessible_Data
    {
        public int? CHOSEN_ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Edit_User_districtnex_module_List
    {
        public List<User_districtnex_module> List_To_Edit { get; set; }
        public List<User_districtnex_module> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Edit_Site_kpi_user_access_List
    {
        public List<Site_kpi_user_access> List_To_Edit { get; set; }
        public List<Site_kpi_user_access> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Initial_Data
    {
        public int? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Change_Password
    {
        public long? USER_ID { get; set; }
        public string OLD_PASSWORD { get; set; }
        public string NEW_PASSWORD { get; set; }
    }
    public partial class Params_Delete_District_kpi
    {
        public long? DISTRICT_KPI_ID { get; set; }
    }
    public partial class Params_Edit_Site_kpi_List
    {
        public List<Site_kpi> List_To_Edit { get; set; }
        public List<Site_kpi> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Entity_Intersection_List
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    public partial class Params_Get_User_By_IS_RECEIVE_EMAIL
    {
        public bool IS_RECEIVE_EMAIL { get; set; }
    }
    public partial class Params_Get_User_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Get_User_level_access_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Get_Level_Data
    {
        public long? UPPER_LEVEL_ID { get; set; }
        public int? SELECTED_DATA_LEVEL_SETUP_ID { get; set; }
        public List<long?> LIST_SELECTED_LEVEL_ID { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Restore_User
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Edit_User_List
    {
        public List<User> List_To_Edit { get; set; }
        public List<User> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Get_Admin_Data
    {
        public int? USER_ID { get; set; }
        public bool? IS_GET_IMAGES_FROM_Cloud { get; set; }
    }
    public partial class Params_Get_User_theme_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    public partial class Params_Edit_Area_kpi_user_access_List
    {
        public List<Area_kpi_user_access> List_To_Edit { get; set; }
        public List<Area_kpi_user_access> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }
    public partial class Params_Delete_User_theme
    {
        public int? USER_THEME_ID { get; set; }
    }
    public partial class Params_Modify_User_Details
    {
        public User User { get; set; }
    }
    public partial class Params_Get_Dimension_Index_With_Simple_Upper_Level
    {
        public long? UPPER_LEVEL_ID { get; set; }
        public int? SELECTED_DATA_LEVEL_SETUP_ID { get; set; }
        public long? SELECTED_LEVEL_ID { get; set; }
        public List<int?> LIST_SELECTED_DIMENSION_ID { get; set; }
        public List<int?> LIST_UPPER_DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    public partial class Params_Get_Incidents_By_Where_Sorted_With_Pagination
    {
        public List<string> INCIDENT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
        public List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST { get; set; }
        public DateTime? CREATED_TIME_START { get; set; }
        public DateTime? CREATED_TIME_END { get; set; }
        public DateTime? ASSIGNED_TIME_START { get; set; }
        public DateTime? ASSIGNED_TIME_END { get; set; }
        public DateTime? CLOSED_TIME_START { get; set; }
        public DateTime? CLOSED_TIME_END { get; set; }
        public int? START_ROW { get; set; }
        public int? END_ROW { get; set; }
    }
    public partial class Params_Edit_Incident_List
    {
        public List<Incident> INCIDENT_LIST { get; set; }
    }
    public partial class Params_Get_Incidents_By_Where_Count
    {
        public List<string> INCIDENT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
        public List<long?> SEVERITY_SETUP_ID_LIST { get; set; }
        public List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST { get; set; }
        public DateTime? CREATED_TIME_START { get; set; }
        public DateTime? CREATED_TIME_END { get; set; }
        public DateTime? ASSIGNED_TIME_START { get; set; }
        public DateTime? ASSIGNED_TIME_END { get; set; }
        public DateTime? CLOSED_TIME_START { get; set; }
        public DateTime? CLOSED_TIME_END { get; set; }
    }
    public partial class Params_Get_Incidents_By_Where
    {
        public List<string> INCIDENT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
        public List<long?> SEVERITY_SETUP_ID_LIST { get; set; }
        public List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST { get; set; }
        public DateTime? CREATED_TIME_START { get; set; }
        public DateTime? CREATED_TIME_END { get; set; }
        public DateTime? ASSIGNED_TIME_START { get; set; }
        public DateTime? ASSIGNED_TIME_END { get; set; }
        public DateTime? CLOSED_TIME_START { get; set; }
        public DateTime? CLOSED_TIME_END { get; set; }
    }
    public partial class Params_Get_Method_run_By_METHOD_RUN_ID
    {
        public long? METHOD_RUN_ID { get; set; }
    }
    public partial class Params_Get_Method_run_By_METHOD_RUN_ID_List
    {
        public IEnumerable<long?> METHOD_RUN_ID_LIST { get; set; }
    }
    public partial class Params_Get_Method_run_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Get_Method_run_By_OWNER_ID_IS_DELETED
    {
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
    }
    public partial class Params_Get_Method_run_By_Where
    {
        public int? OWNER_ID { get; set; }
        public string METHOD_NAME { get; set; }
        public string METHOD_PARAMS { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
    }
    public partial class Params_Delete_Method_run
    {
        public long? METHOD_RUN_ID { get; set; }
    }
    public partial class Params_Delete_Method_run_By_OWNER_ID
    {
        public int? OWNER_ID { get; set; }
    }
    public partial class Params_Delete_Method_run_By_OWNER_ID_IS_DELETED
    {
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
    }
    public partial class Params_Edit_Method_run_List
    {
        public List<Method_run> List_To_Edit { get; set; }
        public List<Method_run> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
    }

    public partial class Result_Get_Asset_By_ASSET_ID_List : Action_Result
    {
        public List<Asset> i_Result { get; set; }
        public Params_Get_Asset_By_ASSET_ID_List Params_Get_Asset_By_ASSET_ID_List { get; set; }
    }
    public partial class Result_Edit_Asset : Action_Result
    {
        public Asset Asset { get; set; }
    }
    public partial class Result_Get_Asset_By_OWNER_ID : Action_Result
    {
        public List<Asset> i_Result { get; set; }
        public Params_Get_Asset_By_OWNER_ID Params_Get_Asset_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Asset_By_ASSET_ID_Adv : Action_Result
    {
        public Asset i_Result { get; set; }
        public Params_Get_Asset_By_ASSET_ID Params_Get_Asset_By_ASSET_ID { get; set; }
    }
    public partial class Result_Get_Asset_Data_List : Action_Result
    {
        public Asset_Data i_Result { get; set; }
        public Params_Get_Asset_Data_List Params_Get_Asset_Data_List { get; set; }
    }
    public partial class Result_Delete_Asset : Action_Result
    {
        public Params_Delete_Asset Params_Delete_Asset { get; set; }
    }
    public partial class Result_Get_Data_source_By_OWNER_ID : Action_Result
    {
        public List<Data_source> i_Result { get; set; }
        public Params_Get_Data_source_By_OWNER_ID Params_Get_Data_source_By_OWNER_ID { get; set; }
    }
    public partial class Result_Generate_Area_Dwell_Time : Action_Result
    {
        public Params_Generate_Area_Dwell_Time Params_Generate_Area_Dwell_Time { get; set; }
    }
    public partial class Result_Edit_Job_List : Action_Result
    {
        public Params_Edit_Job_List Params_Edit_Job_List { get; set; }
    }
    public partial class Result_Generate_District_Dwell_Time : Action_Result
    {
        public Params_Generate_District_Dwell_Time Params_Generate_District_Dwell_Time { get; set; }
    }
    public partial class Result_Get_Visitor_Data : Action_Result
    {
        public Visitor_Data i_Result { get; set; }
        public Params_Get_Visitor_Data Params_Get_Visitor_Data { get; set; }
    }
    public partial class Result_Edit_Kpi_List : Action_Result
    {
        public Params_Edit_Kpi_List Params_Edit_Kpi_List { get; set; }
    }
    public partial class Result_Insert_Entity_Kpi_Data_List : Action_Result
    {
        public Params_Insert_Entity_Kpi_Data_List Params_Insert_Entity_Kpi_Data_List { get; set; }
    }
    public partial class Result_Delete_Data_source : Action_Result
    {
        public Params_Delete_Data_source Params_Delete_Data_source { get; set; }
    }
    public partial class Result_Get_And_Fill_Bylaw_complaints_From_Api : Action_Result
    {
        public Params_Get_And_Fill_Bylaw_complaints_From_Api Params_Get_And_Fill_Bylaw_complaints_From_Api { get; set; }
    }
    public partial class Result_Generate_Or_Compute_District_Hourly_Data : Action_Result
    {
        public Params_Generate_Or_Compute_District_Hourly_Data Params_Generate_Or_Compute_District_Hourly_Data { get; set; }
    }
    public partial class Result_Generate_Or_Compute_Area_Hourly_Data : Action_Result
    {
        public Params_Generate_Or_Compute_Area_Hourly_Data Params_Generate_Or_Compute_Area_Hourly_Data { get; set; }
    }
    public partial class Result_Generate_Or_Compute_Site_Hourly_Data : Action_Result
    {
        public Params_Generate_Or_Compute_Site_Hourly_Data Params_Generate_Or_Compute_Site_Hourly_Data { get; set; }
    }
    public partial class Result_Extract_Kpi_Data_From_CSV : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Extract_Kpi_Data_From_CSV Params_Extract_Kpi_Data_From_CSV { get; set; }
    }
    public partial class Result_Generate_Area_Demographic_Data : Action_Result
    {
        public Params_Generate_Area_Demographic_Data Params_Generate_Area_Demographic_Data { get; set; }
    }
    public partial class Result_Get_Jobs_By_Where : Action_Result
    {
        public List<Job> i_Result { get; set; }
        public Params_Get_Jobs_By_Where Params_Get_Jobs_By_Where { get; set; }
    }
    public partial class Result_Generate_Or_Compute_Floor_Hourly_Data : Action_Result
    {
        public Params_Generate_Or_Compute_Floor_Hourly_Data Params_Generate_Or_Compute_Floor_Hourly_Data { get; set; }
    }
    public partial class Result_Delete_Space_Kpi_Data_By_Where : Action_Result
    {
        public Params_Delete_Space_Kpi_Data_By_Where Params_Delete_Space_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Generate_Site_Visitor_Data_And_Dwell_Time : Action_Result
    {
        public Params_Generate_Site_Visitor_Data_And_Dwell_Time Params_Generate_Site_Visitor_Data_And_Dwell_Time { get; set; }
    }
    public partial class Result_Edit_Niche_categories_List : Action_Result
    {
        public Params_Edit_Niche_categories_List Params_Edit_Niche_categories_List { get; set; }
    }
    public partial class Result_Delete_Niche_categories : Action_Result
    {
        public Params_Delete_Niche_categories Params_Delete_Niche_categories { get; set; }
    }
    public partial class Result_Delete_Site_Kpi_Data_By_Where : Action_Result
    {
        public Params_Delete_Site_Kpi_Data_By_Where Params_Delete_Site_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Insert_Space_Kpi_Data_List : Action_Result
    {
        public Params_Insert_Space_Kpi_Data_List Params_Insert_Space_Kpi_Data_List { get; set; }
    }
    public partial class Result_Generate_Site_Demographic_Data : Action_Result
    {
        public Params_Generate_Site_Demographic_Data Params_Generate_Site_Demographic_Data { get; set; }
    }
    public partial class Result_Insert_Site_Kpi_Data_List : Action_Result
    {
        public Params_Insert_Site_Kpi_Data_List Params_Insert_Site_Kpi_Data_List { get; set; }
    }
    public partial class Result_Edit_Data_source : Action_Result
    {
        public Data_source Data_source { get; set; }
    }
    public partial class Result_Delete_Entity_Kpi_Data_By_Where : Action_Result
    {
        public Params_Delete_Entity_Kpi_Data_By_Where Params_Delete_Entity_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Get_Demographic_Data : Action_Result
    {
        public Demographic_Data i_Result { get; set; }
        public Params_Get_Demographic_Data Params_Get_Demographic_Data { get; set; }
    }
    public partial class Result_Generate_District_Hourly_Indexes : Action_Result
    {
        public Params_Generate_District_Hourly_Indexes Params_Generate_District_Hourly_Indexes { get; set; }
    }
    public partial class Result_Get_Niche_categories_By_Where : Action_Result
    {
        public List<Niche_categories> i_Result { get; set; }
        public Params_Get_Niche_categories_By_Where Params_Get_Niche_categories_By_Where { get; set; }
    }
    public partial class Result_Delete_Area_Kpi_Data_By_Where : Action_Result
    {
        public Delete_Area_Kpi_Data_By_Where Delete_Area_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Generate_Entity_Hourly_Indexes : Action_Result
    {
        public Params_Generate_Entity_Hourly_Indexes Params_Generate_Entity_Hourly_Indexes { get; set; }
    }
    public partial class Result_Generate_Worker_Data : Action_Result
    {
        public Params_Generate_Worker_Data Params_Generate_Worker_Data { get; set; }
    }
    public partial class Result_Delete_District_Kpi_Data_By_Where : Action_Result
    {
        public Params_Delete_District_Kpi_Data_By_Where Params_Delete_District_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Edit_Organization_data_source_kpi : Action_Result
    {
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
    }
    public partial class Result_Get_Telus_Auth_Token : Action_Result
    {
        public string i_Result { get; set; }
    }
    public partial class Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv : Action_Result
    {
        public List<Organization_data_source_kpi> i_Result { get; set; }
        public Params_Get_Organization_data_source_kpi_By_OWNER_ID Params_Get_Organization_data_source_kpi_By_OWNER_ID { get; set; }
    }
    public partial class Result_Delete_Floor_Kpi_Data_By_Where : Action_Result
    {
        public Params_Delete_Floor_Kpi_Data_By_Where Params_Delete_Floor_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Insert_Area_Kpi_Data_List : Action_Result
    {
        public Params_Insert_Area_Kpi_Data_List Params_Insert_Area_Kpi_Data_List { get; set; }
    }
    public partial class Result_Generate_Space_Hourly_Indexes : Action_Result
    {
        public Params_Generate_Space_Hourly_Indexes Params_Generate_Space_Hourly_Indexes { get; set; }
    }
    public partial class Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List : Action_Result
    {
        public Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List { get; set; }
    }
    public partial class Result_Generate_Business_Count_And_Vacant_Business_Count : Action_Result
    {
        public Params_Generate_Business_Count_And_Vacant_Business_Count Params_Generate_Business_Count_And_Vacant_Business_Count { get; set; }
    }
    public partial class Result_Insert_District_Kpi_Data_List : Action_Result
    {
        public Params_Insert_District_Kpi_Data_List Params_Insert_District_Kpi_Data_List { get; set; }
    }
    public partial class Result_Delete_Organization_data_source_kpi : Action_Result
    {
        public Params_Delete_Organization_data_source_kpi Params_Delete_Organization_data_source_kpi { get; set; }
    }
    public partial class Result_Generate_Site_Hourly_Indexes : Action_Result
    {
        public Params_Generate_Site_Hourly_Indexes Params_Generate_Site_Hourly_Indexes { get; set; }
    }
    public partial class Result_Get_Visitor_Activity_Data : Action_Result
    {
        public Visitor_Activity i_Result { get; set; }
        public Params_Get_Visitor_Activity_Data Params_Get_Visitor_Activity_Data { get; set; }
    }
    public partial class Result_Get_And_Fill_Public_events_From_Api : Action_Result
    {
        public Params_Get_And_Fill_Public_events_From_Api Params_Get_And_Fill_Public_events_From_Api { get; set; }
    }
    public partial class Result_Generate_Floor_Hourly_Indexes : Action_Result
    {
        public Params_Generate_Floor_Hourly_Indexes Params_Generate_Floor_Hourly_Indexes { get; set; }
    }
    public partial class Result_Generate_Area_Hourly_Indexes : Action_Result
    {
        public Params_Generate_Area_Hourly_Indexes Params_Generate_Area_Hourly_Indexes { get; set; }
    }
    public partial class Result_Generate_Or_Compute_Entity_Hourly_Data : Action_Result
    {
        public Params_Generate_Or_Compute_Entity_Hourly_Data Params_Generate_Or_Compute_Entity_Hourly_Data { get; set; }
    }
    public partial class Result_Delete_Job : Action_Result
    {
        public Params_Delete_Job Params_Delete_Job { get; set; }
    }
    public partial class Result_Get_And_Fill_Businesses_From_Api : Action_Result
    {
    }
    public partial class Result_Generate_District_Demographic_Data : Action_Result
    {
        public Params_Generate_District_Demographic_Data Params_Generate_District_Demographic_Data { get; set; }
    }
    public partial class Result_Insert_Floor_Kpi_Data_List : Action_Result
    {
        public Params_Insert_Floor_Kpi_Data_List Params_Insert_Floor_Kpi_Data_List { get; set; }
    }
    public partial class Result_Generate_Visitor_Activity_Data : Action_Result
    {
        public Params_Generate_Visitor_Activity_Data Params_Generate_Visitor_Activity_Data { get; set; }
    }
    public partial class Result_Get_Floor_By_ENTITY_ID_List : Action_Result
    {
        public List<Floor> i_Result { get; set; }
        public Params_Get_Floor_By_ENTITY_ID_List Params_Get_Floor_By_ENTITY_ID_List { get; set; }
    }
    public partial class Result_Edit_Entity_share_data : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Edit_Entity_share_data Params_Edit_Entity_share_data { get; set; }
    }
    public partial class Result_Get_Share_file_By_USER_ID : Action_Result
    {
        public List<Share_file> i_Result { get; set; }
        public Params_Get_Share_file_By_USER_ID Params_Get_Share_file_By_USER_ID { get; set; }
    }
    public partial class Result_Get_Share_file_By_SHARE_FILE_ID : Action_Result
    {
        public Share_file i_Result { get; set; }
        public Params_Get_Share_file_By_SHARE_FILE_ID Params_Get_Share_file_By_SHARE_FILE_ID { get; set; }
    }
    public partial class Result_Get_Entity_share_view_data : Action_Result
    {
        public Entity_share_view_data i_Result { get; set; }
        public Params_Get_Entity_share_view_data Params_Get_Entity_share_view_data { get; set; }
    }
    public partial class Result_Send_Share_Link_By_Email : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Send_Share_Link_By_Email Params_Send_Share_Link_By_Email { get; set; }
    }
    public partial class Result_Delete_Share_file : Action_Result
    {
        public Params_Delete_Share_file Params_Delete_Share_file { get; set; }
    }
    public partial class Result_Edit_Share_file : Action_Result
    {
        public Share_file Share_file { get; set; }
    }
    public partial class Result_Edit_Space : Action_Result
    {
        public Space Space { get; set; }
    }
    public partial class Result_Get_Space_asset_By_SPACE_ID_List_Adv : Action_Result
    {
        public List<Space_asset> i_Result { get; set; }
        public Params_Get_Space_asset_By_SPACE_ID_List Params_Get_Space_asset_By_SPACE_ID_List { get; set; }
    }
    public partial class Result_Get_Space_By_OWNER_ID : Action_Result
    {
        public List<Space> i_Result { get; set; }
        public Params_Get_Space_By_OWNER_ID Params_Get_Space_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Space_asset : Action_Result
    {
        public Space_asset Space_asset { get; set; }
    }
    public partial class Result_Edit_Space_List : Action_Result
    {
        public Params_Edit_Space_List Params_Edit_Space_List { get; set; }
    }
    public partial class Result_Get_Space_asset_By_SPACE_ID_Adv : Action_Result
    {
        public List<Space_asset> i_Result { get; set; }
        public Params_Get_Space_asset_By_SPACE_ID Params_Get_Space_asset_By_SPACE_ID { get; set; }
    }
    public partial class Result_Get_Space_By_FLOOR_ID : Action_Result
    {
        public List<Space> i_Result { get; set; }
        public Params_Get_Space_By_FLOOR_ID Params_Get_Space_By_FLOOR_ID { get; set; }
    }
    public partial class Result_Get_Space_asset_By_SPACE_ID_List : Action_Result
    {
        public List<Space_asset> i_Result { get; set; }
        public Params_Get_Space_asset_By_SPACE_ID_List Params_Get_Space_asset_By_SPACE_ID_List { get; set; }
    }
    public partial class Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv : Action_Result
    {
        public List<Space_asset> i_Result { get; set; }
        public Params_Get_Space_asset_By_SPACE_ASSET_ID_List Params_Get_Space_asset_By_SPACE_ASSET_ID_List { get; set; }
    }
    public partial class Result_Edit_Space_asset_List : Action_Result
    {
        public Params_Edit_Space_asset_List Params_Edit_Space_asset_List { get; set; }
    }
    public partial class Result_Get_Space_asset_By_SPACE_ID : Action_Result
    {
        public List<Space_asset> i_Result { get; set; }
        public Params_Get_Space_asset_By_SPACE_ID Params_Get_Space_asset_By_SPACE_ID { get; set; }
    }
    public partial class Result_Delete_Space_asset_By_SPACE_ID : Action_Result
    {
        public Params_Delete_Space_asset_By_SPACE_ID Params_Delete_Space_asset_By_SPACE_ID { get; set; }
    }
    public partial class Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List : Action_Result
    {
        public List<Video_ai_asset> i_Result { get; set; }
        public Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List { get; set; }
    }
    public partial class Result_Get_Report_Details : Action_Result
    {
        public Report_Details i_Result { get; set; }
        public Params_Get_Report_Details Params_Get_Report_Details { get; set; }
    }
    public partial class Result_Send_Report_Email : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Send_Report_Email Params_Send_Report_Email { get; set; }
    }
    public partial class Result_Get_District_By_DISTRICT_ID_List : Action_Result
    {
        public List<District> i_Result { get; set; }
        public Params_Get_District_By_DISTRICT_ID_List Params_Get_District_By_DISTRICT_ID_List { get; set; }
    }
    public partial class Result_Edit_District_view : Action_Result
    {
        public District_view District_view { get; set; }
    }
    public partial class Result_Get_District_view_By_DISTRICT_ID : Action_Result
    {
        public List<District_view> i_Result { get; set; }
        public Params_Get_District_view_By_DISTRICT_ID Params_Get_District_view_By_DISTRICT_ID { get; set; }
    }
    public partial class Result_Get_District_By_OWNER_ID : Action_Result
    {
        public List<District> i_Result { get; set; }
        public Params_Get_District_By_OWNER_ID Params_Get_District_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_District_geojson_By_DISTRICT_ID_List : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Get_District_geojson_By_DISTRICT_ID_List Params_Get_District_geojson_By_DISTRICT_ID_List { get; set; }
    }
    public partial class Result_Delete_District_view : Action_Result
    {
        public Params_Delete_District_view Params_Delete_District_view { get; set; }
    }
    public partial class Result_Edit_District : Action_Result
    {
        public District District { get; set; }
    }
    public partial class Result_Edit_District_view_List : Action_Result
    {
        public Params_Edit_District_view_List Params_Edit_District_view_List { get; set; }
    }
    public partial class Result_Delete_District_view_By_DISTRICT_ID : Action_Result
    {
        public Params_Delete_District_view_By_DISTRICT_ID Params_Delete_District_view_By_DISTRICT_ID { get; set; }
    }
    public partial class Result_Get_District_view_By_DISTRICT_ID_List : Action_Result
    {
        public List<District_view> i_Result { get; set; }
        public Params_Get_District_view_By_DISTRICT_ID_List Params_Get_District_view_By_DISTRICT_ID_List { get; set; }
    }
    public partial class Result_Get_Wifi_signals : Action_Result
    {
        public List<Wifi_signal> i_Result { get; set; }
        public Params_Get_Wifi_signals Params_Get_Wifi_signals { get; set; }
    }
    public partial class Result_Get_District_Kpi_Dialog_Data : Action_Result
    {
        public List<District_Kpi_Dialog_Data> i_Result { get; set; }
        public Params_Get_District_Kpi_Dialog_Data Params_Get_District_Kpi_Dialog_Data { get; set; }
    }
    public partial class Result_Get_Area_Kpi_Data_Aggregate_Sum : Action_Result
    {
        public List<Area_kpi_data> i_Result { get; set; }
        public Params_Get_Area_Kpi_Data_Aggregate_Sum Params_Get_Area_Kpi_Data_Aggregate_Sum { get; set; }
    }
    public partial class Result_Get_Entity_Kpi_Data_By_Where : Action_Result
    {
        public List<Entity_kpi_data> i_Result { get; set; }
        public Params_Get_Entity_Kpi_Data_By_Where Params_Get_Entity_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Compute_Area_Kpi_Data_Hourly : Action_Result
    {
        public Params_Compute_Area_Kpi_Data_Hourly Params_Compute_Area_Kpi_Data_Hourly { get; set; }
    }
    public partial class Result_Get_Site_Kpi_Dialog_Data : Action_Result
    {
        public List<Site_Kpi_Dialog_Data> i_Result { get; set; }
        public Params_Get_Site_Kpi_Dialog_Data Params_Get_Site_Kpi_Dialog_Data { get; set; }
    }
    public partial class Result_Get_Site_Kpi_Data_By_Where : Action_Result
    {
        public List<Site_kpi_data> i_Result { get; set; }
        public Params_Get_Site_Kpi_Data_By_Where Params_Get_Site_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Edit_Alert_List : Action_Result
    {
        public Params_Edit_Alert_List Params_Edit_Alert_List { get; set; }
    }
    public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv : Action_Result
    {
        public List<Organization_data_source_kpi> i_Result { get; set; }
        public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List { get; set; }
    }
    public partial class Result_Compute_District_Kpi_Data_Monthly : Action_Result
    {
        public Params_Compute_District_Kpi_Data_Monthly Params_Compute_District_Kpi_Data_Monthly { get; set; }
    }
    public partial class Result_Get_Bylaw_Complaint_List : Action_Result
    {
        public List<Bylaw_Complaint> i_Result { get; set; }
        public Params_Get_Bylaw_Complaint_List Params_Get_Bylaw_Complaint_List { get; set; }
    }
    public partial class Result_Delete_Kpi : Action_Result
    {
        public Params_Delete_Kpi Params_Delete_Kpi { get; set; }
    }
    public partial class Result_Delete_Wifi_signal : Action_Result
    {
        public Params_Delete_Wifi_signal Params_Delete_Wifi_signal { get; set; }
    }
    public partial class Result_Compute_Floor_Kpi_Data_Monthly : Action_Result
    {
        public Params_Compute_Floor_Kpi_Data_Monthly Params_Compute_Floor_Kpi_Data_Monthly { get; set; }
    }
    public partial class Result_Edit_Wifi_signal_alert_List : Action_Result
    {
        public Params_Edit_Wifi_signal_alert_List Params_Edit_Wifi_signal_alert_List { get; set; }
    }
    public partial class Result_Delete_Alert : Action_Result
    {
        public Params_Delete_Alert Params_Delete_Alert { get; set; }
    }
    public partial class Result_Compute_District_Kpi_Data_Weekly : Action_Result
    {
        public Params_Compute_District_Kpi_Data_Weekly Params_Compute_District_Kpi_Data_Weekly { get; set; }
    }
    public partial class Result_Get_District_Kpi_Data_Aggregate_Sum : Action_Result
    {
        public List<District_kpi_data> i_Result { get; set; }
        public Params_Get_District_Kpi_Data_Aggregate_Sum Params_Get_District_Kpi_Data_Aggregate_Sum { get; set; }
    }
    public partial class Result_Get_Latest_Organization_data_source_kpi_By_Where : Action_Result
    {
        public List<Organization_data_source_kpi_By_Level> i_Result { get; set; }
        public Params_Get_Latest_Organization_data_source_kpi_By_Where Params_Get_Latest_Organization_data_source_kpi_By_Where { get; set; }
    }
    public partial class Result_Compute_Space_Kpi_Data_Monthly : Action_Result
    {
        public Params_Compute_Space_Kpi_Data_Monthly Params_Compute_Space_Kpi_Data_Monthly { get; set; }
    }
    public partial class Result_Compute_Space_Kpi_Data_Daily : Action_Result
    {
        public Params_Compute_Space_Kpi_Data_Daily Params_Compute_Space_Kpi_Data_Daily { get; set; }
    }
    public partial class Result_Update_Kpi_Data_Record : Action_Result
    {
        public Params_Update_Kpi_Data_Record Params_Update_Kpi_Data_Record { get; set; }
    }
    public partial class Result_Compute_Area_Kpi_Data_Daily : Action_Result
    {
        public Params_Compute_Area_Kpi_Data_Daily Params_Compute_Area_Kpi_Data_Daily { get; set; }
    }
    public partial class Result_Get_Latest_Wifi_signal_alerts : Action_Result
    {
        public List<Wifi_signal_alert> i_Result { get; set; }
        public Params_Get_Latest_Wifi_signal_alerts Params_Get_Latest_Wifi_signal_alerts { get; set; }
    }
    public partial class Result_Get_Floor_Kpi_Data_Aggregate_Sum : Action_Result
    {
        public List<Floor_kpi_data> i_Result { get; set; }
        public Params_Get_Floor_Kpi_Data_Aggregate_Sum Params_Get_Floor_Kpi_Data_Aggregate_Sum { get; set; }
    }
    public partial class Result_Compute_Entity_Kpi_Data_Weekly : Action_Result
    {
        public Params_Compute_Entity_Kpi_Data_Weekly Params_Compute_Entity_Kpi_Data_Weekly { get; set; }
    }
    public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv : Action_Result
    {
        public Organization_data_source_kpi i_Result { get; set; }
        public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    public partial class Result_Compute_Area_Kpi_Data_Weekly : Action_Result
    {
        public Params_Compute_Area_Kpi_Data_Weekly Params_Compute_Area_Kpi_Data_Weekly { get; set; }
    }
    public partial class Result_Get_Business_Trendline : Action_Result
    {
        public List<Kpi_Value_By_Date> i_Result { get; set; }
        public Params_Get_Business_Trendline Params_Get_Business_Trendline { get; set; }
    }
    public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv : Action_Result
    {
        public List<Organization_data_source_kpi> i_Result { get; set; }
        public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Wifi_signal_List : Action_Result
    {
        public Params_Edit_Wifi_signal_List Params_Edit_Wifi_signal_List { get; set; }
    }
    public partial class Result_Compute_Entity_Kpi_Data_Daily : Action_Result
    {
        public Params_Compute_Entity_Kpi_Data_Daily Params_Compute_Entity_Kpi_Data_Daily { get; set; }
    }
    public partial class Result_Get_Floor_Kpi_Dialog_Data : Action_Result
    {
        public List<Floor_Kpi_Dialog_Data> i_Result { get; set; }
        public Params_Get_Floor_Kpi_Dialog_Data Params_Get_Floor_Kpi_Dialog_Data { get; set; }
    }
    public partial class Result_Get_Latest_GeoData_By_KPI : Action_Result
    {
        public GeoData i_Result { get; set; }
        public Params_Get_Latest_GeoData_By_KPI Params_Get_Latest_GeoData_By_KPI { get; set; }
    }
    public partial class Result_Get_Public_Event_List : Action_Result
    {
        public List<Public_Event> i_Result { get; set; }
        public Params_Get_Public_Event_List Params_Get_Public_Event_List { get; set; }
    }
    public partial class Result_Get_And_Save_Wifi_Signal_From_Api : Action_Result
    {
    }
    public partial class Result_Get_Alerts_By_Where : Action_Result
    {
        public List<Alert> i_Result { get; set; }
        public Params_Get_Alerts_By_Where Params_Get_Alerts_By_Where { get; set; }
    }
    public partial class Result_Compute_Site_Kpi_Data_Hourly : Action_Result
    {
        public Params_Compute_Site_Kpi_Data_Hourly Params_Compute_Site_Kpi_Data_Hourly { get; set; }
    }
    public partial class Result_Compute_Entity_Kpi_Data_Hourly : Action_Result
    {
        public Params_Compute_Entity_Kpi_Data_Hourly Params_Compute_Entity_Kpi_Data_Hourly { get; set; }
    }
    public partial class Result_Compute_Entity_Kpi_Data_Monthly : Action_Result
    {
        public Params_Compute_Entity_Kpi_Data_Monthly Params_Compute_Entity_Kpi_Data_Monthly { get; set; }
    }
    public partial class Result_Edit_User_Data_Access : Action_Result
    {
        public Params_Edit_User_Data_Access i_Result { get; set; }
        public Params_Edit_User_Data_Access Params_Edit_User_Data_Access { get; set; }
    }
    public partial class Result_Get_Organization_Data_Access : Action_Result
    {
        public Organization_Data_Access i_Result { get; set; }
        public Params_Get_Organization_Data_Access Params_Get_Organization_Data_Access { get; set; }
    }
    public partial class Result_Get_User_Data_Access : Action_Result
    {
        public User_Data_Access i_Result { get; set; }
        public Params_Get_User_Data_Access Params_Get_User_Data_Access { get; set; }
    }
    public partial class Result_Delete_Wifi_signal_alert : Action_Result
    {
        public Params_Delete_Wifi_signal_alert Params_Delete_Wifi_signal_alert { get; set; }
    }
    public partial class Result_Get_Area_Kpi_Dialog_Data : Action_Result
    {
        public List<Area_Kpi_Dialog_Data> i_Result { get; set; }
        public Params_Get_Area_Kpi_Dialog_Data Params_Get_Area_Kpi_Dialog_Data { get; set; }
    }
    public partial class Result_Get_Alerts_Count_For_Levels : Action_Result
    {
        public long? i_Result { get; set; }
        public Params_Get_Alerts_Count_For_Levels Params_Get_Alerts_Count_For_Levels { get; set; }
    }
    public partial class Result_Get_Space_Kpi_Data_By_Where : Action_Result
    {
        public List<Space_kpi_data> i_Result { get; set; }
        public Params_Get_Space_Kpi_Data_By_Where Params_Get_Space_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Get_Site_Kpi_Data_Aggregate_Sum : Action_Result
    {
        public List<Site_kpi_data> i_Result { get; set; }
        public Params_Get_Site_Kpi_Data_Aggregate_Sum Params_Get_Site_Kpi_Data_Aggregate_Sum { get; set; }
    }
    public partial class Result_Get_Latest_Visitor_Count_By_Where : Action_Result
    {
        public List<Visitor_Count_By_Level> i_Result { get; set; }
        public Params_Get_Latest_Visitor_Count_By_Where Params_Get_Latest_Visitor_Count_By_Where { get; set; }
    }
    public partial class Result_Get_Entity_Kpi_Data_Aggregate_Sum : Action_Result
    {
        public List<Entity_kpi_data> i_Result { get; set; }
        public Params_Get_Entity_Kpi_Data_Aggregate_Sum Params_Get_Entity_Kpi_Data_Aggregate_Sum { get; set; }
    }
    public partial class Result_Compute_Floor_Kpi_Data_Hourly : Action_Result
    {
        public Params_Compute_Floor_Kpi_Data_Hourly Params_Compute_Floor_Kpi_Data_Hourly { get; set; }
    }
    public partial class Result_Get_Wifi_signal_alerts : Action_Result
    {
        public List<Wifi_signal_alert> i_Result { get; set; }
        public Params_Get_Wifi_signal_alerts Params_Get_Wifi_signal_alerts { get; set; }
    }
    public partial class Result_Get_District_Kpi_Data_By_Where : Action_Result
    {
        public List<District_kpi_data> i_Result { get; set; }
        public Params_Get_District_Kpi_Data_By_Where Params_Get_District_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Get_Kpi_By_OWNER_ID_Adv : Action_Result
    {
        public List<Kpi> i_Result { get; set; }
        public Params_Get_Kpi_By_OWNER_ID Params_Get_Kpi_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Floor_Kpi_Data_By_Where : Action_Result
    {
        public List<Floor_kpi_data> i_Result { get; set; }
        public Params_Get_Floor_Kpi_Data_By_Where Params_Get_Floor_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Compute_Floor_Kpi_Data_Weekly : Action_Result
    {
        public Params_Compute_Floor_Kpi_Data_Weekly Params_Compute_Floor_Kpi_Data_Weekly { get; set; }
    }
    public partial class Result_Update_Wifi_signal : Action_Result
    {
        public Wifi_signal_data i_Result { get; set; }
        public Params_Update_Wifi_signal Params_Update_Wifi_signal { get; set; }
    }
    public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_data_source_kpi> i_Result { get; set; }
        public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Visitor_Origins : Action_Result
    {
        public Visitor_Origins i_Result { get; set; }
        public Params_Get_Visitor_Origins Params_Get_Visitor_Origins { get; set; }
    }
    public partial class Result_Compute_Site_Kpi_Data_Daily : Action_Result
    {
        public Params_Compute_Site_Kpi_Data_Daily Params_Compute_Site_Kpi_Data_Daily { get; set; }
    }
    public partial class Result_Compute_District_Kpi_Data_Daily : Action_Result
    {
        public Params_Compute_District_Kpi_Data_Daily Params_Compute_District_Kpi_Data_Daily { get; set; }
    }
    public partial class Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly : Action_Result
    {
        public Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly { get; set; }
    }
    public partial class Result_Get_Latest_Wifi_signals : Action_Result
    {
        public List<Wifi_signal> i_Result { get; set; }
        public Params_Get_Latest_Wifi_signals Params_Get_Latest_Wifi_signals { get; set; }
    }
    public partial class Result_Get_Alerts_By_Where_Count : Action_Result
    {
        public long? i_Result { get; set; }
        public Params_Get_Alerts_By_Where_Count Params_Get_Alerts_By_Where_Count { get; set; }
    }
    public partial class Result_Get_Entity_Incidents : Action_Result
    {
        public Entity_Incidents i_Result { get; set; }
        public Params_Get_Entity_Incidents Params_Get_Entity_Incidents { get; set; }
    }
    public partial class Result_Get_Bylaw_Complaints_Trendline : Action_Result
    {
        public List<Kpi_Value_By_Date> i_Result { get; set; }
        public Params_Get_Bylaw_Complaints_Trendline Params_Get_Bylaw_Complaints_Trendline { get; set; }
    }
    public partial class Result_Get_Alerts_For_Levels : Action_Result
    {
        public List<Alert> i_Result { get; set; }
        public Params_Get_Alerts_For_Levels Params_Get_Alerts_For_Levels { get; set; }
    }
    public partial class Result_Compute_Space_Kpi_Data_Weekly : Action_Result
    {
        public Params_Compute_Space_Kpi_Data_Weekly Params_Compute_Space_Kpi_Data_Weekly { get; set; }
    }
    public partial class Result_Get_Area_Kpi_Data_By_Where : Action_Result
    {
        public List<Area_kpi_data> i_Result { get; set; }
        public Params_Get_Area_Kpi_Data_By_Where Params_Get_Area_Kpi_Data_By_Where { get; set; }
    }
    public partial class Result_Compute_Site_Kpi_Data_Monthly : Action_Result
    {
        public Params_Compute_Site_Kpi_Data_Monthly Params_Compute_Site_Kpi_Data_Monthly { get; set; }
    }
    public partial class Result_Compute_District_Kpi_Data_Hourly : Action_Result
    {
        public Params_Compute_District_Kpi_Data_Hourly Params_Compute_District_Kpi_Data_Hourly { get; set; }
    }
    public partial class Result_Get_Intersection_Kpi_Dialog_Data : Action_Result
    {
        public List<Entity_Kpi_Dialog_Data> i_Result { get; set; }
        public Params_Get_Intersection_Kpi_Dialog_Data Params_Get_Intersection_Kpi_Dialog_Data { get; set; }
    }
    public partial class Result_Compute_Floor_Kpi_Data_Daily : Action_Result
    {
        public Params_Compute_Floor_Kpi_Data_Daily Params_Compute_Floor_Kpi_Data_Daily { get; set; }
    }
    public partial class Result_Get_Strongest_Wifi_signal : Action_Result
    {
        public Best_And_Worst_Object i_Result { get; set; }
        public Params_Get_Strongest_Wifi_signal Params_Get_Strongest_Wifi_signal { get; set; }
    }
    public partial class Result_Compute_Area_Kpi_Data_Monthly : Action_Result
    {
        public Params_Compute_Area_Kpi_Data_Monthly Params_Compute_Area_Kpi_Data_Monthly { get; set; }
    }
    public partial class Result_Get_Business_List : Action_Result
    {
        public List<Business> i_Result { get; set; }
        public Params_Get_Business_List Params_Get_Business_List { get; set; }
    }
    public partial class Result_Edit_Organization_Data_Access : Action_Result
    {
        public Params_Edit_Organization_Data_Access i_Result { get; set; }
        public Params_Edit_Organization_Data_Access Params_Edit_Organization_Data_Access { get; set; }
    }
    public partial class Result_Edit_Kpi : Action_Result
    {
        public Kpi Kpi { get; set; }
    }
    public partial class Result_Get_Entity_Kpi_Dialog_Data : Action_Result
    {
        public List<Entity_Kpi_Dialog_Data> i_Result { get; set; }
        public Params_Get_Entity_Kpi_Dialog_Data Params_Get_Entity_Kpi_Dialog_Data { get; set; }
    }
    public partial class Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID : Action_Result
    {
        public List<Business> i_Result { get; set; }
        public Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Result_Compute_Site_Kpi_Data_Weekly : Action_Result
    {
        public Params_Compute_Site_Kpi_Data_Weekly Params_Compute_Site_Kpi_Data_Weekly { get; set; }
    }
    public partial class Result_Get_Most_Wifi_signal_Count_Per_Space_asset : Action_Result
    {
        public Best_And_Worst_Object i_Result { get; set; }
        public Params_Get_Most_Wifi_signal_Count_Per_Space_asset Params_Get_Most_Wifi_signal_Count_Per_Space_asset { get; set; }
    }
    public partial class Result_Get_Public_Events_Trendline : Action_Result
    {
        public List<Kpi_Value_By_Date> i_Result { get; set; }
        public Params_Get_Public_Events_Trendline Params_Get_Public_Events_Trendline { get; set; }
    }
    public partial class Result_Get_User_By_ORGANIZATION_ID_List_Adv : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_ORGANIZATION_ID_List Params_Get_User_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Get_User_By_ORGANIZATION_ID_List : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_ORGANIZATION_ID_List Params_Get_User_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Edit_Top_level : Action_Result
    {
        public Top_level Top_level { get; set; }
    }
    public partial class Result_Get_Top_level_By_TOP_LEVEL_ID_List : Action_Result
    {
        public List<Top_level> i_Result { get; set; }
        public Params_Get_Top_level_By_TOP_LEVEL_ID_List Params_Get_Top_level_By_TOP_LEVEL_ID_List { get; set; }
    }
    public partial class Result_Get_Top_level_By_OWNER_ID : Action_Result
    {
        public List<Top_level> i_Result { get; set; }
        public Params_Get_Top_level_By_OWNER_ID Params_Get_Top_level_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Entity_view : Action_Result
    {
        public Entity_view Entity_view { get; set; }
    }
    public partial class Result_Get_Entity_view_By_ENTITY_ID : Action_Result
    {
        public List<Entity_view> i_Result { get; set; }
        public Params_Get_Entity_view_By_ENTITY_ID Params_Get_Entity_view_By_ENTITY_ID { get; set; }
    }
    public partial class Result_Delete_Entity_view : Action_Result
    {
        public Params_Delete_Entity_view Params_Delete_Entity_view { get; set; }
    }
    public partial class Result_Get_Entity_By_SITE_ID : Action_Result
    {
        public List<Entity> i_Result { get; set; }
        public Params_Get_Entity_By_SITE_ID Params_Get_Entity_By_SITE_ID { get; set; }
    }
    public partial class Result_Get_Entity_By_ENTITY_ID_Adv : Action_Result
    {
        public Entity i_Result { get; set; }
        public Params_Get_Entity_By_ENTITY_ID Params_Get_Entity_By_ENTITY_ID { get; set; }
    }
    public partial class Result_Get_Entity_By_ENTITY_ID : Action_Result
    {
        public Entity i_Result { get; set; }
        public Params_Get_Entity_By_ENTITY_ID Params_Get_Entity_By_ENTITY_ID { get; set; }
    }
    public partial class Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID : Action_Result
    {
        public Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result i_Result { get; set; }
        public Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID { get; set; }
    }
    public partial class Result_Get_Entity_By_ENTITY_ID_List : Action_Result
    {
        public List<Entity> i_Result { get; set; }
        public Params_Get_Entity_By_ENTITY_ID_List Params_Get_Entity_By_ENTITY_ID_List { get; set; }
    }
    public partial class Result_Get_Entity_By_OWNER_ID : Action_Result
    {
        public List<Entity> i_Result { get; set; }
        public Params_Get_Entity_By_OWNER_ID Params_Get_Entity_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Entity : Action_Result
    {
        public Entity Entity { get; set; }
    }
    public partial class Result_Edit_Entity_view_List : Action_Result
    {
        public Params_Edit_Entity_view_List Params_Edit_Entity_view_List { get; set; }
    }
    public partial class Result_Delete_Entity_view_By_ENTITY_ID : Action_Result
    {
        public Params_Delete_Entity_view_By_ENTITY_ID Params_Delete_Entity_view_By_ENTITY_ID { get; set; }
    }
    public partial class Result_Get_Entity_view_By_ENTITY_ID_List : Action_Result
    {
        public List<Entity_view> i_Result { get; set; }
        public Params_Get_Entity_view_By_ENTITY_ID_List Params_Get_Entity_view_By_ENTITY_ID_List { get; set; }
    }
    public partial class Result_Edit_Region : Action_Result
    {
        public Region Region { get; set; }
    }
    public partial class Result_Get_Region_By_OWNER_ID : Action_Result
    {
        public List<Region> i_Result { get; set; }
        public Params_Get_Region_By_OWNER_ID Params_Get_Region_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Region_view : Action_Result
    {
        public Region_view Region_view { get; set; }
    }
    public partial class Result_Delete_Region_view : Action_Result
    {
        public Params_Delete_Region_view Params_Delete_Region_view { get; set; }
    }
    public partial class Result_Get_Region_view_By_REGION_ID : Action_Result
    {
        public List<Region_view> i_Result { get; set; }
        public Params_Get_Region_view_By_REGION_ID Params_Get_Region_view_By_REGION_ID { get; set; }
    }
    public partial class Result_Get_Floor_By_ENTITY_ID : Action_Result
    {
        public List<Floor> i_Result { get; set; }
        public Params_Get_Floor_By_ENTITY_ID Params_Get_Floor_By_ENTITY_ID { get; set; }
    }
    public partial class Result_Get_Floor_By_ENTITY_ID_With_Space_Asset : Action_Result
    {
        public List<Floor> i_Result { get; set; }
        public Params_Get_Floor_By_ENTITY_ID_With_Space_Asset Params_Get_Floor_By_ENTITY_ID_With_Space_Asset { get; set; }
    }
    public partial class Result_Get_Floor_By_OWNER_ID : Action_Result
    {
        public List<Floor> i_Result { get; set; }
        public Params_Get_Floor_By_OWNER_ID Params_Get_Floor_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Floor : Action_Result
    {
        public Floor Floor { get; set; }
    }
    public partial class Result_Get_Floor_By_ENTITY_ID_Adv : Action_Result
    {
        public List<Floor> i_Result { get; set; }
        public Params_Get_Floor_By_ENTITY_ID Params_Get_Floor_By_ENTITY_ID { get; set; }
    }
    public partial class Result_Get_Logs_With_Filters : Action_Result
    {
        public Log_With_Count i_Result { get; set; }
        public Params_Get_Logs_With_Filters Params_Get_Logs_With_Filters { get; set; }
    }
    public partial class Result_Generate_Logs_Excel : Action_Result
    {
        public Generate_Logs_Excel_Response i_Result { get; set; }
        public Params_Generate_Logs_Excel Params_Generate_Logs_Excel { get; set; }
    }
    public partial class Result_Get_Latest_Dimension_index_By_Where : Action_Result
    {
        public List<Dimension_index_By_Level> i_Result { get; set; }
        public Params_Get_Latest_Dimension_index_By_Where Params_Get_Latest_Dimension_index_By_Where { get; set; }
    }
    public partial class Result_Get_Dimension_By_DIMENSION_ORDER_List : Action_Result
    {
        public List<Dimension> i_Result { get; set; }
        public Params_Get_Dimension_By_DIMENSION_ORDER_List Params_Get_Dimension_By_DIMENSION_ORDER_List { get; set; }
    }
    public partial class Result_Edit_Dimension_List : Action_Result
    {
        public Params_Edit_Dimension_List Params_Edit_Dimension_List { get; set; }
    }
    public partial class Result_Get_Dimension_By_DIMENSION_ID_List : Action_Result
    {
        public List<Dimension> i_Result { get; set; }
        public Params_Get_Dimension_By_DIMENSION_ID_List Params_Get_Dimension_By_DIMENSION_ID_List { get; set; }
    }
    public partial class Result_Get_Dimension_By_DIMENSION_ID : Action_Result
    {
        public Dimension i_Result { get; set; }
        public Params_Get_Dimension_By_DIMENSION_ID Params_Get_Dimension_By_DIMENSION_ID { get; set; }
    }
    public partial class Result_Compute_Dimension_Index_Monthly : Action_Result
    {
        public Params_Compute_Dimension_Index_Monthly Params_Compute_Dimension_Index_Monthly { get; set; }
    }
    public partial class Result_Insert_Dimension_index_List : Action_Result
    {
        public Params_Insert_Dimension_index_List Params_Insert_Dimension_index_List { get; set; }
    }
    public partial class Result_Compute_Dimension_Index_Weekly : Action_Result
    {
        public Params_Compute_Dimension_Index_Weekly Params_Compute_Dimension_Index_Weekly { get; set; }
    }
    public partial class Result_Get_Dimension_By_OWNER_ID : Action_Result
    {
        public List<Dimension> i_Result { get; set; }
        public Params_Get_Dimension_By_OWNER_ID Params_Get_Dimension_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Dimension_index_By_Where : Action_Result
    {
        public List<Dimension_index> i_Result { get; set; }
        public Params_Get_Dimension_index_By_Where Params_Get_Dimension_index_By_Where { get; set; }
    }
    public partial class Result_Generate_Dimension_Index_Daily : Action_Result
    {
        public Params_Generate_Dimension_Index_Daily Params_Generate_Dimension_Index_Daily { get; set; }
    }
    public partial class Result_Delete_Dimension_index_By_Where : Action_Result
    {
        public Params_Delete_Dimension_index_By_Where Params_Delete_Dimension_index_By_Where { get; set; }
    }
    public partial class Result_Edit_Site_view : Action_Result
    {
        public Site_view Site_view { get; set; }
    }
    public partial class Result_Get_Site_By_OWNER_ID_Adv : Action_Result
    {
        public List<Site> i_Result { get; set; }
        public Params_Get_Site_By_OWNER_ID Params_Get_Site_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Site : Action_Result
    {
        public Site Site { get; set; }
    }
    public partial class Result_Get_Site_By_SITE_ID_List_Adv : Action_Result
    {
        public List<Site> i_Result { get; set; }
        public Params_Get_Site_By_SITE_ID_List Params_Get_Site_By_SITE_ID_List { get; set; }
    }
    public partial class Result_Get_Site_By_SITE_ID_List : Action_Result
    {
        public List<Site> i_Result { get; set; }
        public Params_Get_Site_By_SITE_ID_List Params_Get_Site_By_SITE_ID_List { get; set; }
    }
    public partial class Result_Get_Ext_study_zone_By_OWNER_ID : Action_Result
    {
        public List<Ext_study_zone> i_Result { get; set; }
        public Params_Get_Ext_study_zone_By_OWNER_ID Params_Get_Ext_study_zone_By_OWNER_ID { get; set; }
    }
    public partial class Result_Delete_Site_view : Action_Result
    {
        public Params_Delete_Site_view Params_Delete_Site_view { get; set; }
    }
    public partial class Result_Get_Site_By_SITE_ID : Action_Result
    {
        public Site i_Result { get; set; }
        public Params_Get_Site_By_SITE_ID Params_Get_Site_By_SITE_ID { get; set; }
    }
    public partial class Result_Get_Site_By_OWNER_ID : Action_Result
    {
        public List<Site> i_Result { get; set; }
        public Params_Get_Site_By_OWNER_ID Params_Get_Site_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Site_geojson_By_SITE_ID_List : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Get_Site_geojson_By_SITE_ID_List Params_Get_Site_geojson_By_SITE_ID_List { get; set; }
    }
    public partial class Result_Get_Site_view_By_SITE_ID : Action_Result
    {
        public List<Site_view> i_Result { get; set; }
        public Params_Get_Site_view_By_SITE_ID Params_Get_Site_view_By_SITE_ID { get; set; }
    }
    public partial class Result_Edit_Ext_study_zone_List : Action_Result
    {
        public Params_Edit_Ext_study_zone_List Params_Edit_Ext_study_zone_List { get; set; }
    }
    public partial class Result_Edit_Site_view_List : Action_Result
    {
        public Params_Edit_Site_view_List Params_Edit_Site_view_List { get; set; }
    }
    public partial class Result_Delete_Site_view_By_SITE_ID : Action_Result
    {
        public Params_Delete_Site_view_By_SITE_ID Params_Delete_Site_view_By_SITE_ID { get; set; }
    }
    public partial class Result_Get_Site_view_By_SITE_ID_List : Action_Result
    {
        public List<Site_view> i_Result { get; set; }
        public Params_Get_Site_view_By_SITE_ID_List Params_Get_Site_view_By_SITE_ID_List { get; set; }
    }
    public partial class Result_Get_Site_field_logo_By_SITE_ID_List : Action_Result
    {
        public List<Site_field_logo> i_Result { get; set; }
        public Params_Get_Site_field_logo_By_SITE_ID_List Params_Get_Site_field_logo_By_SITE_ID_List { get; set; }
    }
    public partial class Result_Check_Organization_Deletion_Status : Action_Result
    {
    }
    public partial class Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID : Action_Result
    {
        public List<Organization_log_config> i_Result { get; set; }
        public Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID { get; set; }
    }
    public partial class Result_Edit_Organization : Action_Result
    {
        public Organization Organization { get; set; }
    }
    public partial class Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv : Action_Result
    {
        public List<Organization_image> i_Result { get; set; }
        public Params_Get_Organization_image_By_ORGANIZATION_ID_List Params_Get_Organization_image_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Delete_Organization_theme : Action_Result
    {
        public Params_Delete_Organization_theme Params_Delete_Organization_theme { get; set; }
    }
    public partial class Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv : Action_Result
    {
        public List<Organization_level_access> i_Result { get; set; }
        public Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv : Action_Result
    {
        public List<Organization_theme> i_Result { get; set; }
        public Params_Get_Organization_theme_By_ORGANIZATION_ID_List Params_Get_Organization_theme_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Edit_Organization_Custom : Action_Result
    {
        public Organization i_Result { get; set; }
        public Params_Edit_Organization_Custom Params_Edit_Organization_Custom { get; set; }
    }
    public partial class Result_Schedule_Organization_for_Delete : Action_Result
    {
        public Organization i_Result { get; set; }
        public Params_Schedule_Organization_for_Delete Params_Schedule_Organization_for_Delete { get; set; }
    }
    public partial class Result_Modify_Data_Settings : Action_Result
    {
        public Data_Settings i_Result { get; set; }
        public Params_Modify_Data_Settings Params_Modify_Data_Settings { get; set; }
    }
    public partial class Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List : Action_Result
    {
        public List<Organization_color_scheme> i_Result { get; set; }
        public Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Modify_Organization_Details : Action_Result
    {
        public Organization i_Result { get; set; }
        public Params_Modify_Organization_Details Params_Modify_Organization_Details { get; set; }
    }
    public partial class Result_Edit_Organization_color_scheme : Action_Result
    {
        public Organization_color_scheme Organization_color_scheme { get; set; }
    }
    public partial class Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_relation> i_Result { get; set; }
        public Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_By_ORGANIZATION_ID : Action_Result
    {
        public Organization i_Result { get; set; }
        public Params_Get_Organization_By_ORGANIZATION_ID Params_Get_Organization_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_theme_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_theme> i_Result { get; set; }
        public Params_Get_Organization_theme_By_ORGANIZATION_ID Params_Get_Organization_theme_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID : Action_Result
    {
        public List<Organization_level_access> i_Result { get; set; }
        public Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Result_Edit_Organization_districtnex_module_List : Action_Result
    {
        public Params_Edit_Organization_districtnex_module_List Params_Edit_Organization_districtnex_module_List { get; set; }
    }
    public partial class Result_Get_Organization_By_PARENT_ORGANIZATION_ID : Action_Result
    {
        public List<Organization> i_Result { get; set; }
        public Params_Get_Organization_By_PARENT_ORGANIZATION_ID Params_Get_Organization_By_PARENT_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Organization_level_access_List : Action_Result
    {
        public Params_Edit_Organization_level_access_List Params_Edit_Organization_level_access_List { get; set; }
    }
    public partial class Result_Edit_Organization_theme : Action_Result
    {
        public Organization_theme Organization_theme { get; set; }
    }
    public partial class Result_Delete_Organization_Picture : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Delete_Organization_Picture Params_Delete_Organization_Picture { get; set; }
    }
    public partial class Result_Get_Organization_By_ORGANIZATION_ID_List : Action_Result
    {
        public List<Organization> i_Result { get; set; }
        public Params_Get_Organization_By_ORGANIZATION_ID_List Params_Get_Organization_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading : Action_Result
    {
        public Organization i_Result { get; set; }
        public Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading { get; set; }
    }
    public partial class Result_Get_Organization_color_scheme_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_color_scheme> i_Result { get; set; }
        public Params_Get_Organization_color_scheme_By_ORGANIZATION_ID Params_Get_Organization_color_scheme_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_By_OWNER_ID : Action_Result
    {
        public List<Organization> i_Result { get; set; }
        public Params_Get_Organization_By_OWNER_ID Params_Get_Organization_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Organization_chart_color_List : Action_Result
    {
        public Params_Edit_Organization_chart_color_List Params_Edit_Organization_chart_color_List { get; set; }
    }
    public partial class Result_Get_Organization_level_access_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_level_access> i_Result { get; set; }
        public Params_Get_Organization_level_access_By_ORGANIZATION_ID Params_Get_Organization_level_access_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv : Action_Result
    {
        public List<Organization_districtnex_module> i_Result { get; set; }
        public Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Restore_Organization : Action_Result
    {
        public Organization i_Result { get; set; }
        public Params_Restore_Organization Params_Restore_Organization { get; set; }
    }
    public partial class Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID : Action_Result
    {
        public List<Organization_level_access> i_Result { get; set; }
        public Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Result_Delete_Organization_level_access : Action_Result
    {
        public Params_Delete_Organization_level_access Params_Delete_Organization_level_access { get; set; }
    }
    public partial class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_districtnex_module> i_Result { get; set; }
        public Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Organization_level_access : Action_Result
    {
        public Organization_level_access Organization_level_access { get; set; }
    }
    public partial class Result_Delete_Organization_level_access_By_ORGANIZATION_ID : Action_Result
    {
        public Params_Delete_Organization_level_access_By_ORGANIZATION_ID Params_Delete_Organization_level_access_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Organization_districtnex_module : Action_Result
    {
        public Organization_districtnex_module Organization_districtnex_module { get; set; }
    }
    public partial class Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID : Action_Result
    {
        public Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Organization_color_scheme_List : Action_Result
    {
        public Params_Edit_Organization_color_scheme_List Params_Edit_Organization_color_scheme_List { get; set; }
    }
    public partial class Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID : Action_Result
    {
        public Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Organization_log_config : Action_Result
    {
        public Organization_log_config Organization_log_config { get; set; }
    }
    public partial class Result_Edit_Organization_log_config_List : Action_Result
    {
        public Params_Edit_Organization_log_config_List Params_Edit_Organization_log_config_List { get; set; }
    }
    public partial class Result_Get_Organization_log_config_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_log_config> i_Result { get; set; }
        public Params_Get_Organization_log_config_By_ORGANIZATION_ID Params_Get_Organization_log_config_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Delete_Organization_log_config_By_ORGANIZATION_ID : Action_Result
    {
        public Params_Delete_Organization_log_config_By_ORGANIZATION_ID Params_Delete_Organization_log_config_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv : Action_Result
    {
        public List<Organization_districtnex_module> i_Result { get; set; }
        public Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Get_Organization_image_By_ORGANIZATION_ID_List : Action_Result
    {
        public List<Organization_image> i_Result { get; set; }
        public Params_Get_Organization_image_By_ORGANIZATION_ID_List Params_Get_Organization_image_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv : Action_Result
    {
        public List<Organization_level_access> i_Result { get; set; }
        public Params_Get_Organization_level_access_By_ORGANIZATION_ID_List Params_Get_Organization_level_access_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv : Action_Result
    {
        public List<Organization_log_config> i_Result { get; set; }
        public Params_Get_Organization_log_config_By_ORGANIZATION_ID_List Params_Get_Organization_log_config_By_ORGANIZATION_ID_List { get; set; }
    }
    public partial class Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv : Action_Result
    {
        public List<Organization_theme> i_Result { get; set; }
        public Params_Get_Organization_theme_By_ORGANIZATION_ID Params_Get_Organization_theme_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Get_Organization_image_By_ORGANIZATION_ID : Action_Result
    {
        public List<Organization_image> i_Result { get; set; }
        public Params_Get_Organization_image_By_ORGANIZATION_ID Params_Get_Organization_image_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Setup : Action_Result
    {
        public Setup Setup { get; set; }
    }
    public partial class Result_Get_Specialized_chart_configuration_By_MODULE : Action_Result
    {
        public List<Specialized_chart_configuration> i_Result { get; set; }
        public Params_Get_Specialized_chart_configuration_By_MODULE Params_Get_Specialized_chart_configuration_By_MODULE { get; set; }
    }
    public partial class Result_Delete_District_geojson_By_DISTRICT_ID : Action_Result
    {
        public Params_Delete_District_geojson_By_DISTRICT_ID Params_Delete_District_geojson_By_DISTRICT_ID { get; set; }
    }
    public partial class Result_Get_Dimension_chart_configuration : Action_Result
    {
        public List<Dimension_chart_configuration> i_Result { get; set; }
    }
    public partial class Result_Edit_Setup_category_List : Action_Result
    {
        public Params_Edit_Setup_category_List Params_Edit_Setup_category_List { get; set; }
    }
    public partial class Result_Get_Districtnex_module_By_OWNER_ID : Action_Result
    {
        public List<Districtnex_module> i_Result { get; set; }
        public Params_Get_Districtnex_module_By_OWNER_ID Params_Get_Districtnex_module_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Dimension_chart_configuration : Action_Result
    {
        public Dimension_chart_configuration i_Result { get; set; }
        public Dimension_chart_configuration Dimension_chart_configuration { get; set; }
    }
    public partial class Result_Get_Setup_By_SETUP_ID_Adv : Action_Result
    {
        public Setup i_Result { get; set; }
        public Params_Get_Setup_By_SETUP_ID Params_Get_Setup_By_SETUP_ID { get; set; }
    }
    public partial class Result_Get_Default_settings_By_OWNER_ID : Action_Result
    {
        public List<Default_settings> i_Result { get; set; }
        public Params_Get_Default_settings_By_OWNER_ID Params_Get_Default_settings_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Object_View : Action_Result
    {
        public Params_Edit_Object_View Params_Edit_Object_View { get; set; }
    }
    public partial class Result_Get_Setup_category_By_OWNER_ID : Action_Result
    {
        public List<Setup_category> i_Result { get; set; }
        public Params_Get_Setup_category_By_OWNER_ID Params_Get_Setup_category_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Site_geojson : Action_Result
    {
        public List<string> i_Result { get; set; }
    }
    public partial class Result_Edit_District_geojson : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Edit_District_geojson Params_Edit_District_geojson { get; set; }
    }
    public partial class Result_Delete_Build_version : Action_Result
    {
        public Params_Delete_Build_version Params_Delete_Build_version { get; set; }
    }
    public partial class Result_Edit_Ext_study_zone_geojson : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Edit_Ext_study_zone_geojson Params_Edit_Ext_study_zone_geojson { get; set; }
    }
    public partial class Result_Delete_Default_Settings_Picture : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Delete_Default_Settings_Picture Params_Delete_Default_Settings_Picture { get; set; }
    }
    public partial class Result_Get_Specialized_chart_configuration : Action_Result
    {
        public List<Specialized_chart_configuration> i_Result { get; set; }
    }
    public partial class Result_Edit_Removed_extrusion_Custom_Old : Action_Result
    {
        public Params_Edit_Removed_extrusion_Custom_Old Params_Edit_Removed_extrusion_Custom_Old { get; set; }
    }
    public partial class Result_Get_Area_geojson : Action_Result
    {
        public List<string> i_Result { get; set; }
    }
    public partial class Result_Delete_Setup_category : Action_Result
    {
        public Params_Delete_Setup_category Params_Delete_Setup_category { get; set; }
    }
    public partial class Result_Get_Build_version_By_OWNER_ID_Adv : Action_Result
    {
        public List<Build_version> i_Result { get; set; }
        public Params_Get_Build_version_By_OWNER_ID Params_Get_Build_version_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Build_version : Action_Result
    {
        public Build_version Build_version { get; set; }
    }
    public partial class Result_Get_Default_chart_color_By_OWNER_ID_Adv : Action_Result
    {
        public List<Default_chart_color> i_Result { get; set; }
        public Params_Get_Default_chart_color_By_OWNER_ID Params_Get_Default_chart_color_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Default_chart_color_List : Action_Result
    {
        public Params_Edit_Default_chart_color_List Params_Edit_Default_chart_color_List { get; set; }
    }
    public partial class Result_Get_District_geojson : Action_Result
    {
        public List<string> i_Result { get; set; }
    }
    public partial class Result_Edit_Specialized_chart_configuration : Action_Result
    {
        public Specialized_chart_configuration i_Result { get; set; }
        public Specialized_chart_configuration Specialized_chart_configuration { get; set; }
    }
    public partial class Result_Get_Setup_category_By_SETUP_CATEGORY_ID : Action_Result
    {
        public Setup_category i_Result { get; set; }
        public Params_Get_Setup_category_By_SETUP_CATEGORY_ID Params_Get_Setup_category_By_SETUP_CATEGORY_ID { get; set; }
    }
    public partial class Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID : Action_Result
    {
        public Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID { get; set; }
    }
    public partial class Result_Edit_Setup_category : Action_Result
    {
        public Setup_category Setup_category { get; set; }
    }
    public partial class Result_Edit_Alert_settings_List : Action_Result
    {
        public Params_Edit_Alert_settings_List Params_Edit_Alert_settings_List { get; set; }
    }
    public partial class Result_Delete_Dimension_chart_configuration : Action_Result
    {
        public Params_Delete_Dimension_chart_configuration Params_Delete_Dimension_chart_configuration { get; set; }
    }
    public partial class Result_Get_Initial_Districtnex_Admin_Settings : Action_Result
    {
        public Initial_Districtnex_Admin_Settings i_Result { get; set; }
    }
    public partial class Result_Edit_Site_geojson : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Edit_Site_geojson Params_Edit_Site_geojson { get; set; }
    }
    public partial class Result_Delete_Area_geojson_By_AREA_ID : Action_Result
    {
        public Params_Delete_Area_geojson_By_AREA_ID Params_Delete_Area_geojson_By_AREA_ID { get; set; }
    }
    public partial class Result_Edit_Default_settings : Action_Result
    {
        public Default_settings Default_settings { get; set; }
    }
    public partial class Result_Delete_Specialized_chart_configuration : Action_Result
    {
        public Params_Delete_Specialized_chart_configuration Params_Delete_Specialized_chart_configuration { get; set; }
    }
    public partial class Result_Get_Initial_Districtnex_UI_Settings : Action_Result
    {
        public Initial_Districtnex_UI_Settings i_Result { get; set; }
    }
    public partial class Result_Get_Alert_settings_By_OWNER_ID_Adv : Action_Result
    {
        public List<Alert_settings> i_Result { get; set; }
        public Params_Get_Alert_settings_By_OWNER_ID Params_Get_Alert_settings_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID : Action_Result
    {
        public List<Build_version> i_Result { get; set; }
        public Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID { get; set; }
    }
    public partial class Result_Edit_Removed_extrusion_Custom : Action_Result
    {
        public Params_Edit_Removed_extrusion_Custom Params_Edit_Removed_extrusion_Custom { get; set; }
    }
    public partial class Result_Clean_Removed_extrusions : Action_Result
    {
    }
    public partial class Result_Delete_Kpi_chart_configuration : Action_Result
    {
        public Params_Delete_Kpi_chart_configuration Params_Delete_Kpi_chart_configuration { get; set; }
    }
    public partial class Result_Get_UI_Build_Version_List : Action_Result
    {
        public Build_Version_List_With_Logs i_Result { get; set; }
    }
    public partial class Result_Get_Ext_study_zone_geojson : Action_Result
    {
        public List<string> i_Result { get; set; }
    }
    public partial class Result_Custom_Edit_Build_version : Action_Result
    {
        public Build_version i_Result { get; set; }
        public Params_Custom_Edit_Build_version Params_Custom_Edit_Build_version { get; set; }
    }
    public partial class Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID : Action_Result
    {
        public Setup_category i_Result { get; set; }
        public Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Default_chart_color_By_OWNER_ID : Action_Result
    {
        public List<Default_chart_color> i_Result { get; set; }
        public Params_Get_Default_chart_color_By_OWNER_ID Params_Get_Default_chart_color_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Setup_By_OWNER_ID : Action_Result
    {
        public List<Setup> i_Result { get; set; }
        public Params_Get_Setup_By_OWNER_ID Params_Get_Setup_By_OWNER_ID { get; set; }
    }
    public partial class Result_Edit_Area_geojson : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Edit_Area_geojson Params_Edit_Area_geojson { get; set; }
    }
    public partial class Result_Delete_Site_geojson_By_SITE_ID : Action_Result
    {
        public Params_Delete_Site_geojson_By_SITE_ID Params_Delete_Site_geojson_By_SITE_ID { get; set; }
    }
    public partial class Result_Get_Admin_Build_Version_List : Action_Result
    {
        public Build_Version_List_With_Logs i_Result { get; set; }
    }
    public partial class Result_Edit_Removed_extrusion_List : Action_Result
    {
        public Params_Edit_Removed_extrusion_List Params_Edit_Removed_extrusion_List { get; set; }
    }
    public partial class Result_Edit_Kpi_chart_configuration : Action_Result
    {
        public Kpi_chart_configuration i_Result { get; set; }
        public Kpi_chart_configuration Kpi_chart_configuration { get; set; }
    }
    public partial class Result_Get_Kpi_chart_configuration : Action_Result
    {
        public List<Kpi_chart_configuration> i_Result { get; set; }
    }
    public partial class Result_Get_Removed_extrusion_By_OWNER_ID : Action_Result
    {
        public List<Removed_extrusion> i_Result { get; set; }
        public Params_Get_Removed_extrusion_By_OWNER_ID Params_Get_Removed_extrusion_By_OWNER_ID { get; set; }
    }
    public partial class Result_Delete_Setup : Action_Result
    {
        public Params_Delete_Setup Params_Delete_Setup { get; set; }
    }
    public partial class Result_Get_Alert_settings_By_USER_ID_Adv : Action_Result
    {
        public List<Alert_settings> i_Result { get; set; }
        public Params_Get_Alert_settings_By_USER_ID Params_Get_Alert_settings_By_USER_ID { get; set; }
    }
    public partial class Result_Send_Support_Email : Action_Result
    {
        public Params_Send_Support_Email Params_Send_Support_Email { get; set; }
    }
    public partial class Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List : Action_Result
    {
        public List<Districtnex_module> i_Result { get; set; }
        public Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List { get; set; }
    }
    public partial class Result_Drop_Collection : Action_Result
    {
        public Params_Drop_Collection Params_Drop_Collection { get; set; }
    }
    public partial class Result_Edit_Build_version_List : Action_Result
    {
        public Params_Edit_Build_version_List Params_Edit_Build_version_List { get; set; }
    }
    public partial class Result_Create_Time_series_Collection : Action_Result
    {
        public Params_Create_Time_series_Collection Params_Create_Time_series_Collection { get; set; }
    }
    public partial class Result_Get_Setup_By_SETUP_ID : Action_Result
    {
        public Setup i_Result { get; set; }
        public Params_Get_Setup_By_SETUP_ID Params_Get_Setup_By_SETUP_ID { get; set; }
    }
    public partial class Result_Edit_Correlation_method : Action_Result
    {
        public Correlation_method Correlation_method { get; set; }
    }
    public partial class Result_Get_Correlation_method_By_OWNER_ID : Action_Result
    {
        public List<Correlation_method> i_Result { get; set; }
        public Params_Get_Correlation_method_By_OWNER_ID Params_Get_Correlation_method_By_OWNER_ID { get; set; }
    }
    public partial class Result_Delete_Correlation_method : Action_Result
    {
        public Params_Delete_Correlation_method Params_Delete_Correlation_method { get; set; }
    }
    public partial class Result_Get_Correlation : Action_Result
    {
        public List<Kpi_Value_By_Date> i_Result { get; set; }
        public Params_Get_Correlation Params_Get_Correlation { get; set; }
    }
    public partial class Result_Get_Comparison_Data : Action_Result
    {
        public Comparison_Data i_Result { get; set; }
        public Params_Get_Comparison_Data Params_Get_Comparison_Data { get; set; }
    }
    public partial class Result_Get_Multi_kpi_comparison : Action_Result
    {
        public List<Kpi_Value_By_Direction> i_Result { get; set; }
        public Params_Get_Multi_kpi_comparison Params_Get_Multi_kpi_comparison { get; set; }
    }
    public partial class Result_Get_Single_kpi_comparison : Action_Result
    {
        public List<Kpi_Value_By_Date> i_Result { get; set; }
        public Params_Get_Single_kpi_comparison Params_Get_Single_kpi_comparison { get; set; }
    }
    public partial class Result_Fetch_Scenes : Action_Result
    {
        public Fetch_Scenes_Response i_Result { get; set; }
        public Params_Fetch_Scenes Params_Fetch_Scenes { get; set; }
    }
    public partial class Result_Get_Vehicle_Types : Action_Result
    {
        public List<string> i_Result { get; set; }
        public Params_Get_Vehicle_Types Params_Get_Vehicle_Types { get; set; }
    }
    public partial class Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID : Action_Result
    {
        public Video_ai_instance i_Result { get; set; }
        public Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID { get; set; }
    }
    public partial class Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID : Action_Result
    {
        public List<Video_ai_instance> i_Result { get; set; }
        public Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID { get; set; }
    }
    public partial class Result_Create_Video_ai_asset : Action_Result
    {
        public Video_ai_asset i_Result { get; set; }
        public Params_Create_Video_ai_asset Params_Create_Video_ai_asset { get; set; }
    }
    public partial class Result_Update_License_Plate_Recognition_Alerts : Action_Result
    {
        public bool i_Result { get; set; }
    }
    public partial class Result_Change_Video_ai_instance_Password : Action_Result
    {
        public Change_Video_ai_instance_Password_Response i_Result { get; set; }
        public Params_Change_Video_ai_instance_Password Params_Change_Video_ai_instance_Password { get; set; }
    }
    public partial class Result_Face_Target_Key_Search : Action_Result
    {
        public Search_Face_Target_Key_Response_List i_Result { get; set; }
        public Params_Face_Target_Key_Search Params_Face_Target_Key_Search { get; set; }
    }
    public partial class Result_Face_Search : Action_Result
    {
        public Face_Key_Response_List i_Result { get; set; }
        public Params_Face_Search Params_Face_Search { get; set; }
    }
    public partial class Result_Fetch_License_Plate_Categories : Action_Result
    {
        public List<License_Plate_Category> i_Result { get; set; }
        public Params_Fetch_License_Plate_Categories Params_Fetch_License_Plate_Categories { get; set; }
    }
    public partial class Result_Fetch_Face_Targets : Action_Result
    {
        public Fetch_Face_Targets_Response i_Result { get; set; }
        public Params_Fetch_Face_Targets Params_Fetch_Face_Targets { get; set; }
    }
    public partial class Result_Fetch_Facial_Recognition : Action_Result
    {
        public Fetch_Facial_Recognition_Reponse i_Result { get; set; }
        public Params_Fetch_Facial_Recognition Params_Fetch_Facial_Recognition { get; set; }
    }
    public partial class Result_Delete_Video_ai_asset_Custom : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Delete_Video_ai_asset_Custom Params_Delete_Video_ai_asset_Custom { get; set; }
    }
    public partial class Result_Update_Facial_Recognition_Alerts : Action_Result
    {
        public bool i_Result { get; set; }
    }
    public partial class Result_Get_Video_ai_engine_By_OWNER_ID : Action_Result
    {
        public List<Video_ai_engine> i_Result { get; set; }
        public Params_Get_Video_ai_engine_By_OWNER_ID Params_Get_Video_ai_engine_By_OWNER_ID { get; set; }
    }
    public partial class Result_Fetch_License_Plate_Targets : Action_Result
    {
        public Fetch_License_Plate_Targets_Response i_Result { get; set; }
        public Params_Fetch_License_Plate_Targets Params_Fetch_License_Plate_Targets { get; set; }
    }
    public partial class Result_Get_Video_ai_asset_By_OWNER_ID : Action_Result
    {
        public List<Video_ai_asset> i_Result { get; set; }
        public Params_Get_Video_ai_asset_By_OWNER_ID Params_Get_Video_ai_asset_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Stream_Data : Action_Result
    {
        public Stream_Data i_Result { get; set; }
        public Params_Get_Stream_Data Params_Get_Stream_Data { get; set; }
    }
    public partial class Result_Fetch_License_Plate_Recognition : Action_Result
    {
        public Fetch_License_Plate_Recognition_Response i_Result { get; set; }
        public Params_Fetch_License_Plate_Recognition Params_Fetch_License_Plate_Recognition { get; set; }
    }
    public partial class Result_Get_Scene_Info : Action_Result
    {
        public Scene_Info i_Result { get; set; }
        public Params_Get_Scene_Info Params_Get_Scene_Info { get; set; }
    }
    public partial class Result_Update_Alerts_Custom : Action_Result
    {
        public bool i_Result { get; set; }
    }
    public partial class Result_Get_Countings : Action_Result
    {
        public List<Get_Countings_Response> i_Result { get; set; }
        public Params_Get_Countings Params_Get_Countings { get; set; }
    }
    public partial class Result_Get_Camera_Lines : Action_Result
    {
        public List<Camera_Lines> i_Result { get; set; }
        public Params_Get_Camera_Lines Params_Get_Camera_Lines { get; set; }
    }
    public partial class Result_Edit_Video_ai_asset : Action_Result
    {
        public Video_ai_asset Video_ai_asset { get; set; }
    }
    public partial class Result_Get_Space_asset_Vaidio_camera : Action_Result
    {
        public Video_ai_asset i_Result { get; set; }
        public Params_Get_Space_asset_Vaidio_camera Params_Get_Space_asset_Vaidio_camera { get; set; }
    }
    public partial class Result_Update_Alerts : Action_Result
    {
        public bool i_Result { get; set; }
    }
    public partial class Result_Get_License_Plate_Scene : Action_Result
    {
        public Scene_Details i_Result { get; set; }
        public Params_Get_License_Plate_Scene Params_Get_License_Plate_Scene { get; set; }
    }
    public partial class Result_Get_Video_ai_assets_with_engine_assets : Action_Result
    {
        public Video_ai_assets_with_engine_assets i_Result { get; set; }
        public Params_Get_Video_ai_assets_with_engine_assets Params_Get_Video_ai_assets_with_engine_assets { get; set; }
    }
    public partial class Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv : Action_Result
    {
        public List<Video_ai_asset> i_Result { get; set; }
        public Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List { get; set; }
    }
    public partial class Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List : Action_Result
    {
        public List<Video_ai_asset> i_Result { get; set; }
        public Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List { get; set; }
    }
    public partial class Result_Create_Video_ai_instance : Action_Result
    {
        public Video_ai_instance i_Result { get; set; }
        public Params_Create_Video_ai_instance Params_Create_Video_ai_instance { get; set; }
    }
    public partial class Result_Delete_Video_ai_engine : Action_Result
    {
        public Params_Delete_Video_ai_engine Params_Delete_Video_ai_engine { get; set; }
    }
    public partial class Result_Fetch_Face_Target_Categories : Action_Result
    {
        public List<Face_Target_Response_Category> i_Result { get; set; }
        public Params_Fetch_Face_Target_Categories Params_Fetch_Face_Target_Categories { get; set; }
    }
    public partial class Result_Get_Vehicle_Countings : Action_Result
    {
        public Vehicle_Counting i_Result { get; set; }
        public Params_Get_Vehicle_Countings Params_Get_Vehicle_Countings { get; set; }
    }
    public partial class Result_Edit_Video_ai_instance_custom : Action_Result
    {
        public Video_ai_instance_with_connection_flag i_Result { get; set; }
        public Params_Edit_Video_ai_instance_custom Params_Edit_Video_ai_instance_custom { get; set; }
    }
    public partial class Result_Send_Alerts_Email : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Send_Alerts_Email Params_Send_Alerts_Email { get; set; }
    }
    public partial class Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv : Action_Result
    {
        public Video_ai_asset i_Result { get; set; }
        public Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID { get; set; }
    }
    public partial class Result_Delete_Video_ai_instance : Action_Result
    {
        public Params_Delete_Video_ai_instance Params_Delete_Video_ai_instance { get; set; }
    }
    public partial class Result_Edit_Video_ai_instance : Action_Result
    {
        public Video_ai_instance Video_ai_instance { get; set; }
    }
    public partial class Result_Edit_Video_ai_engine_List : Action_Result
    {
        public Params_Edit_Video_ai_engine_List Params_Edit_Video_ai_engine_List { get; set; }
    }
    public partial class Result_Edit_Video_ai_engine : Action_Result
    {
        public Video_ai_engine Video_ai_engine { get; set; }
    }
    public partial class Result_Get_Sites_and_Entities : Action_Result
    {
        public Sites_and_Entities i_Result { get; set; }
    }
    public partial class Result_Delete_Object : Action_Result
    {
        public Params_Delete_Object Params_Delete_Object { get; set; }
    }
    public partial class Result_Delete_Object_List : Action_Result
    {
        public Params_Delete_Object_List Params_Delete_Object_List { get; set; }
    }
    public partial class Result_Upload_Object : Action_Result
    {
        public Params_Upload_Object Params_Upload_Object { get; set; }
    }
    public partial class Result_Get_Area_view_By_AREA_ID : Action_Result
    {
        public List<Area_view> i_Result { get; set; }
        public Params_Get_Area_view_By_AREA_ID Params_Get_Area_view_By_AREA_ID { get; set; }
    }
    public partial class Result_Edit_Area_view : Action_Result
    {
        public Area_view Area_view { get; set; }
    }
    public partial class Result_Edit_Area : Action_Result
    {
        public Area Area { get; set; }
    }
    public partial class Result_Get_Area_geojson_By_AREA_ID_List : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Get_Area_geojson_By_AREA_ID_List Params_Get_Area_geojson_By_AREA_ID_List { get; set; }
    }
    public partial class Result_Get_Area_By_OWNER_ID : Action_Result
    {
        public List<Area> i_Result { get; set; }
        public Params_Get_Area_By_OWNER_ID Params_Get_Area_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Area_By_AREA_ID_List : Action_Result
    {
        public List<Area> i_Result { get; set; }
        public Params_Get_Area_By_AREA_ID_List Params_Get_Area_By_AREA_ID_List { get; set; }
    }
    public partial class Result_Delete_Area_view : Action_Result
    {
        public Params_Delete_Area_view Params_Delete_Area_view { get; set; }
    }
    public partial class Result_Edit_Area_view_List : Action_Result
    {
        public Params_Edit_Area_view_List Params_Edit_Area_view_List { get; set; }
    }
    public partial class Result_Delete_Area_view_By_AREA_ID : Action_Result
    {
        public Params_Delete_Area_view_By_AREA_ID Params_Delete_Area_view_By_AREA_ID { get; set; }
    }
    public partial class Result_Get_Area_view_By_AREA_ID_List : Action_Result
    {
        public List<Area_view> i_Result { get; set; }
        public Params_Get_Area_view_By_AREA_ID_List Params_Get_Area_view_By_AREA_ID_List { get; set; }
    }
    public partial class Result_Get_Secret : Action_Result
    {
        public string i_Result { get; set; }
        public Params_Get_Secret Params_Get_Secret { get; set; }
    }
    public partial class Result_Primary_Authentication : Action_Result
    {
        public Primary_Authentication_Response i_Result { get; set; }
        public Params_Primary_Authentication Params_Primary_Authentication { get; set; }
    }
    public partial class Result_OTP_Verification : Action_Result
    {
        public User_Details i_Result { get; set; }
        public Params_OTP_Verification Params_OTP_Verification { get; set; }
    }
    public partial class Result_Send_Otp : Action_Result
    {
        public Send_Otp_Response i_Result { get; set; }
        public Params_Send_Otp Params_Send_Otp { get; set; }
    }
    public partial class Result_Verify_Otp : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Verify_Otp Params_Verify_Otp { get; set; }
    }
    public partial class Result_Change_User_Forgotten_Password : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Change_User_Forgotten_Password Params_Change_User_Forgotten_Password { get; set; }
    }
    public partial class Result_Create_User : Action_Result
    {
        public User i_Result { get; set; }
        public Params_Create_User Params_Create_User { get; set; }
    }
    public partial class Result_Change_User_Password : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Change_User_Password Params_Change_User_Password { get; set; }
    }
    public partial class Result_Edit_Area_kpi : Action_Result
    {
        public Area_kpi Area_kpi { get; set; }
    }
    public partial class Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List : Action_Result
    {
        public List<User_level_access> i_Result { get; set; }
        public Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List { get; set; }
    }
    public partial class Result_Edit_User_Walkthrough : Action_Result
    {
        public Params_Edit_User_Walkthrough Params_Edit_User_Walkthrough { get; set; }
    }
    public partial class Result_Schedule_User_for_Delete : Action_Result
    {
        public User i_Result { get; set; }
        public Params_Schedule_User_for_Delete Params_Schedule_User_for_Delete { get; set; }
    }
    public partial class Result_Get_User_Accessible_Level_List : Action_Result
    {
        public User_Accessible_Level_List i_Result { get; set; }
        public Params_Get_User_Accessible_Level_List Params_Get_User_Accessible_Level_List { get; set; }
    }
    public partial class Result_Edit_District_kpi_user_access_List : Action_Result
    {
        public Params_Edit_District_kpi_user_access_List Params_Edit_District_kpi_user_access_List { get; set; }
    }
    public partial class Result_Delete_Area_kpi : Action_Result
    {
        public Params_Delete_Area_kpi Params_Delete_Area_kpi { get; set; }
    }
    public partial class Result_Get_User_level_access_By_USER_ID_List : Action_Result
    {
        public List<User_level_access> i_Result { get; set; }
        public Params_Get_User_level_access_By_USER_ID_List Params_Get_User_level_access_By_USER_ID_List { get; set; }
    }
    public partial class Result_Delete_User_level_access : Action_Result
    {
        public Params_Delete_User_level_access Params_Delete_User_level_access { get; set; }
    }
    public partial class Result_Edit_Entity_kpi_List : Action_Result
    {
        public Params_Edit_Entity_kpi_List Params_Edit_Entity_kpi_List { get; set; }
    }
    public partial class Result_Get_User_By_ORGANIZATION_ID_Adv : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_ORGANIZATION_ID Params_Get_User_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_User_Details : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Edit_User_Details Params_Edit_User_Details { get; set; }
    }
    public partial class Result_Edit_District_kpi_List : Action_Result
    {
        public Params_Edit_District_kpi_List Params_Edit_District_kpi_List { get; set; }
    }
    public partial class Result_Edit_Entity_kpi : Action_Result
    {
        public Entity_kpi Entity_kpi { get; set; }
    }
    public partial class Result_Get_User_Accessible_Data_With_Level_List : Action_Result
    {
        public User_Accessible_Data_With_Level_List i_Result { get; set; }
        public Params_Get_User_Accessible_Data_With_Level_List Params_Get_User_Accessible_Data_With_Level_List { get; set; }
    }
    public partial class Result_Get_User_districtnex_module_By_USER_ID_List : Action_Result
    {
        public List<User_districtnex_module> i_Result { get; set; }
        public Params_Get_User_districtnex_module_By_USER_ID_List Params_Get_User_districtnex_module_By_USER_ID_List { get; set; }
    }
    public partial class Result_Get_User_By_USER_ID_List : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_USER_ID_List Params_Get_User_By_USER_ID_List { get; set; }
    }
    public partial class Result_Get_User_districtnex_module_By_USER_ID : Action_Result
    {
        public List<User_districtnex_module> i_Result { get; set; }
        public Params_Get_User_districtnex_module_By_USER_ID Params_Get_User_districtnex_module_By_USER_ID { get; set; }
    }
    public partial class Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID : Action_Result
    {
        public List<User_level_access> i_Result { get; set; }
        public Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID { get; set; }
    }
    public partial class Result_Get_User_By_ORGANIZATION_ID : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_ORGANIZATION_ID Params_Get_User_By_ORGANIZATION_ID { get; set; }
    }
    public partial class Result_Edit_Entity_kpi_user_access_List : Action_Result
    {
        public Params_Edit_Entity_kpi_user_access_List Params_Edit_Entity_kpi_user_access_List { get; set; }
    }
    public partial class Result_Get_User_By_USER_ID_List_Adv : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_USER_ID_List Params_Get_User_By_USER_ID_List { get; set; }
    }
    public partial class Result_Edit_Site_kpi_user_access : Action_Result
    {
        public Site_kpi_user_access Site_kpi_user_access { get; set; }
    }
    public partial class Result_Edit_Entity_kpi_user_access : Action_Result
    {
        public Entity_kpi_user_access Entity_kpi_user_access { get; set; }
    }
    public partial class Result_Edit_Area_kpi_List : Action_Result
    {
        public Params_Edit_Area_kpi_List Params_Edit_Area_kpi_List { get; set; }
    }
    public partial class Result_Delete_Site_kpi : Action_Result
    {
        public Params_Delete_Site_kpi Params_Delete_Site_kpi { get; set; }
    }
    public partial class Result_Edit_User_level_access_List : Action_Result
    {
        public Params_Edit_User_level_access_List Params_Edit_User_level_access_List { get; set; }
    }
    public partial class Result_Delete_Entity_kpi : Action_Result
    {
        public Params_Delete_Entity_kpi Params_Delete_Entity_kpi { get; set; }
    }
    public partial class Result_Get_User_Accessible_Data : Action_Result
    {
        public User_Accessible_Data i_Result { get; set; }
        public Params_Get_User_Accessible_Data Params_Get_User_Accessible_Data { get; set; }
    }
    public partial class Result_Edit_User_districtnex_module_List : Action_Result
    {
        public Params_Edit_User_districtnex_module_List Params_Edit_User_districtnex_module_List { get; set; }
    }
    public partial class Result_Edit_Site_kpi_user_access_List : Action_Result
    {
        public Params_Edit_Site_kpi_user_access_List Params_Edit_Site_kpi_user_access_List { get; set; }
    }
    public partial class Result_Get_Initial_Data : Action_Result
    {
        public Initial_Data i_Result { get; set; }
        public Params_Get_Initial_Data Params_Get_Initial_Data { get; set; }
    }
    public partial class Result_Edit_District_kpi : Action_Result
    {
        public District_kpi District_kpi { get; set; }
    }
    public partial class Result_Change_Password : Action_Result
    {
        public bool i_Result { get; set; }
        public Params_Change_Password Params_Change_Password { get; set; }
    }
    public partial class Result_Delete_District_kpi : Action_Result
    {
        public Params_Delete_District_kpi Params_Delete_District_kpi { get; set; }
    }
    public partial class Result_Edit_Site_kpi_List : Action_Result
    {
        public Params_Edit_Site_kpi_List Params_Edit_Site_kpi_List { get; set; }
    }
    public partial class Result_Get_Entity_Intersection_List : Action_Result
    {
        public List<Entity> i_Result { get; set; }
        public Params_Get_Entity_Intersection_List Params_Get_Entity_Intersection_List { get; set; }
    }
    public partial class Result_Check_User_Deletion_Status : Action_Result
    {
    }
    public partial class Result_Get_User_By_IS_RECEIVE_EMAIL : Action_Result
    {
        public List<User> i_Result { get; set; }
        public Params_Get_User_By_IS_RECEIVE_EMAIL Params_Get_User_By_IS_RECEIVE_EMAIL { get; set; }
    }
    public partial class Result_Get_User_By_USER_ID : Action_Result
    {
        public User i_Result { get; set; }
        public Params_Get_User_By_USER_ID Params_Get_User_By_USER_ID { get; set; }
    }
    public partial class Result_Get_User_level_access_By_USER_ID : Action_Result
    {
        public List<User_level_access> i_Result { get; set; }
        public Params_Get_User_level_access_By_USER_ID Params_Get_User_level_access_By_USER_ID { get; set; }
    }
    public partial class Result_Get_Level_Data : Action_Result
    {
        public Level_Data i_Result { get; set; }
        public Params_Get_Level_Data Params_Get_Level_Data { get; set; }
    }
    public partial class Result_Restore_User : Action_Result
    {
        public User i_Result { get; set; }
        public Params_Restore_User Params_Restore_User { get; set; }
    }
    public partial class Result_Get_User_districtnex_module_By_USER_ID_Adv : Action_Result
    {
        public List<User_districtnex_module> i_Result { get; set; }
        public Params_Get_User_districtnex_module_By_USER_ID Params_Get_User_districtnex_module_By_USER_ID { get; set; }
    }
    public partial class Result_Edit_User_theme : Action_Result
    {
        public User_theme User_theme { get; set; }
    }
    public partial class Result_Edit_User_List : Action_Result
    {
        public Params_Edit_User_List Params_Edit_User_List { get; set; }
    }
    public partial class Result_Get_Admin_Data : Action_Result
    {
        public Admin_Data i_Result { get; set; }
        public Params_Get_Admin_Data Params_Get_Admin_Data { get; set; }
    }
    public partial class Result_Get_User_By_USER_ID_Adv : Action_Result
    {
        public User i_Result { get; set; }
        public Params_Get_User_By_USER_ID Params_Get_User_By_USER_ID { get; set; }
    }
    public partial class Result_Get_User_theme_By_USER_ID : Action_Result
    {
        public List<User_theme> i_Result { get; set; }
        public Params_Get_User_theme_By_USER_ID Params_Get_User_theme_By_USER_ID { get; set; }
    }
    public partial class Result_Edit_Site_kpi : Action_Result
    {
        public Site_kpi Site_kpi { get; set; }
    }
    public partial class Result_Edit_Area_kpi_user_access_List : Action_Result
    {
        public Params_Edit_Area_kpi_user_access_List Params_Edit_Area_kpi_user_access_List { get; set; }
    }
    public partial class Result_Delete_User_theme : Action_Result
    {
        public Params_Delete_User_theme Params_Delete_User_theme { get; set; }
    }
    public partial class Result_Edit_Area_kpi_user_access : Action_Result
    {
        public Area_kpi_user_access Area_kpi_user_access { get; set; }
    }
    public partial class Result_Edit_District_kpi_user_access : Action_Result
    {
        public District_kpi_user_access District_kpi_user_access { get; set; }
    }
    public partial class Result_Modify_User_Details : Action_Result
    {
        public User i_Result { get; set; }
        public Params_Modify_User_Details Params_Modify_User_Details { get; set; }
    }
    public partial class Result_Get_Dimension_Index_With_Simple_Upper_Level : Action_Result
    {
        public Dimension_Index_With_Simple_Upper_Level i_Result { get; set; }
        public Params_Get_Dimension_Index_With_Simple_Upper_Level Params_Get_Dimension_Index_With_Simple_Upper_Level { get; set; }
    }
    public partial class Result_Get_Incidents_By_Where_Sorted_With_Pagination : Action_Result
    {
        public Incident_With_Count i_Result { get; set; }
        public Params_Get_Incidents_By_Where_Sorted_With_Pagination Params_Get_Incidents_By_Where_Sorted_With_Pagination { get; set; }
    }
    public partial class Result_Edit_Incident_List : Action_Result
    {
        public Params_Edit_Incident_List Params_Edit_Incident_List { get; set; }
    }
    public partial class Result_Delete_Incident : Action_Result
    {
    }
    public partial class Result_Get_Incidents_By_Where_Count : Action_Result
    {
        public long i_Result { get; set; }
        public Params_Get_Incidents_By_Where_Count Params_Get_Incidents_By_Where_Count { get; set; }
    }
    public partial class Result_Get_Incidents_By_Where : Action_Result
    {
        public List<Incident> i_Result { get; set; }
        public Params_Get_Incidents_By_Where Params_Get_Incidents_By_Where { get; set; }
    }
    public partial class Result_Get_Method_run_By_METHOD_RUN_ID : Action_Result
    {
        public Method_run i_Result { get; set; }
        public Params_Get_Method_run_By_METHOD_RUN_ID Params_Get_Method_run_By_METHOD_RUN_ID { get; set; }
    }
    public partial class Result_Get_Method_run_By_METHOD_RUN_ID_List : Action_Result
    {
        public List<Method_run> i_Result { get; set; }
        public Params_Get_Method_run_By_METHOD_RUN_ID_List Params_Get_Method_run_By_METHOD_RUN_ID_List { get; set; }
    }
    public partial class Result_Get_Method_run_By_OWNER_ID : Action_Result
    {
        public List<Method_run> i_Result { get; set; }
        public Params_Get_Method_run_By_OWNER_ID Params_Get_Method_run_By_OWNER_ID { get; set; }
    }
    public partial class Result_Get_Method_run_By_OWNER_ID_IS_DELETED : Action_Result
    {
        public List<Method_run> i_Result { get; set; }
        public Params_Get_Method_run_By_OWNER_ID_IS_DELETED Params_Get_Method_run_By_OWNER_ID_IS_DELETED { get; set; }
    }
    public partial class Result_Get_Method_run_By_Where : Action_Result
    {
        public List<Method_run> i_Result { get; set; }
        public Params_Get_Method_run_By_Where Params_Get_Method_run_By_Where { get; set; }
    }
    public partial class Result_Delete_Method_run : Action_Result
    {
        public Params_Delete_Method_run Params_Delete_Method_run { get; set; }
    }
    public partial class Result_Delete_Method_run_By_OWNER_ID : Action_Result
    {
        public Params_Delete_Method_run_By_OWNER_ID Params_Delete_Method_run_By_OWNER_ID { get; set; }
    }
    public partial class Result_Delete_Method_run_By_OWNER_ID_IS_DELETED : Action_Result
    {
        public Params_Delete_Method_run_By_OWNER_ID_IS_DELETED Params_Delete_Method_run_By_OWNER_ID_IS_DELETED { get; set; }
    }
    public partial class Result_Edit_Method_run : Action_Result
    {
        public Method_run Method_run { get; set; }
    }
    public partial class Result_Edit_Method_run_List : Action_Result
    {
        public Params_Edit_Method_run_List Params_Edit_Method_run_List { get; set; }
    }
}