using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Service_Mesh
{
    public partial class Proxy
    {
        public Action_Result Upload_Share_File(Params_Upload_Share_File i_Params_Upload_Share_File)
        {
            return Upload_Share_File_Async(i_Params_Upload_Share_File).Result;
        }
        public async Task<Action_Result> Upload_Share_File_Async(Params_Upload_Share_File i_Params_Upload_Share_File)
        {
            return await Call_WebApi<Action_Result>("/Api/ShareView/Upload_Share_File", true, "POST", JsonConvert.SerializeObject(i_Params_Upload_Share_File));
        }

        public Action_Result Upload_Organization_Picture(Params_Upload_Organization_Picture i_Params_Upload_Organization_Picture)
        {
            return Upload_Organization_Picture_Async(i_Params_Upload_Organization_Picture).Result;
        }
        public async Task<Action_Result> Upload_Organization_Picture_Async(Params_Upload_Organization_Picture i_Params_Upload_Organization_Picture)
        {
            return await Call_WebApi<Action_Result>("/Api/OrganizationManagement/Upload_Organization_Picture", true, "POST", JsonConvert.SerializeObject(i_Params_Upload_Organization_Picture));
        }
        public Action_Result Upload_Default_Settings_Picture(Params_Upload_Default_Settings_Picture i_Params_Upload_Default_Settings_Picture)
        {
            return Upload_Default_Settings_Picture_Async(i_Params_Upload_Default_Settings_Picture).Result;
        }
        public async Task<Action_Result> Upload_Default_Settings_Picture_Async(Params_Upload_Default_Settings_Picture i_Params_Upload_Default_Settings_Picture)
        {
            return await Call_WebApi<Action_Result>("/Api/SettingsManagement/Upload_Default_Settings_Picture", true, "POST", JsonConvert.SerializeObject(i_Params_Upload_Default_Settings_Picture));
        }
        public Action_Result Upload_Asset(Params_Upload_Asset i_Params_Upload_Asset)
        {
            return Upload_Asset_Async(i_Params_Upload_Asset).Result;
        }
        public async Task<Action_Result> Upload_Asset_Async(Params_Upload_Asset i_Params_Upload_Asset)
        {
            return await Call_WebApi<Action_Result>("/Api/FileManagement/Upload_Asset", true, "POST", JsonConvert.SerializeObject(i_Params_Upload_Asset));
        }
        public Action_Result Detect_Face_In_Image(Params_Detect_Face_In_Image i_Params_Detect_Face_In_Image)
        {
            return Detect_Face_In_Image_Async(i_Params_Detect_Face_In_Image).Result;
        }
        public async Task<Action_Result> Detect_Face_In_Image_Async(Params_Detect_Face_In_Image i_Params_Detect_Face_In_Image)
        {
            return await Call_WebApi<Action_Result>("/Api/VideoAIEngineManagement/Detect_Face_In_Image", true, "POST", JsonConvert.SerializeObject(i_Params_Detect_Face_In_Image));
        }
        public Result_Create_Log Create_Log(Params_Create_Log i_Params_Create_Log)
        {
            return Create_Log_Async(i_Params_Create_Log).Result;
        }
        public async Task<Result_Create_Log> Create_Log_Async(Params_Create_Log i_Params_Create_Log)
        {
            return await Call_WebApi<Result_Create_Log>("/Api/PlatformLogging/Create_Log", true, "POST", JsonConvert.SerializeObject(i_Params_Create_Log));
        }
        public Result_Process_Spearman_Correlation Process_Spearman_Correlation(Params_Process_Spearman_Correlation i_Params_Process_Spearman_Correlation)
        {
            return Process_Spearman_Correlation_Async(i_Params_Process_Spearman_Correlation).Result;
        }
        public async Task<Result_Process_Spearman_Correlation> Process_Spearman_Correlation_Async(Params_Process_Spearman_Correlation i_Params_Process_Spearman_Correlation)
        {
            return await Call_WebApi<Result_Process_Spearman_Correlation>("/Api/CorrelationCalculation/Process_Spearman_Correlation", true, "POST", JsonConvert.SerializeObject(i_Params_Process_Spearman_Correlation));
        }
        public Result_Process_Pearson_Correlation Process_Pearson_Correlation(Params_Process_Pearson_Correlation i_Params_Process_Pearson_Correlation)
        {
            return Process_Pearson_Correlation_Async(i_Params_Process_Pearson_Correlation).Result;
        }
        public async Task<Result_Process_Pearson_Correlation> Process_Pearson_Correlation_Async(Params_Process_Pearson_Correlation i_Params_Process_Pearson_Correlation)
        {
            return await Call_WebApi<Result_Process_Pearson_Correlation>("/Api/CorrelationCalculation/Process_Pearson_Correlation", true, "POST", JsonConvert.SerializeObject(i_Params_Process_Pearson_Correlation));
        }
        public Result_Process_Kendall_Correlation Process_Kendall_Correlation(Params_Process_Kendall_Correlation i_Params_Process_Kendall_Correlation)
        {
            return Process_Kendall_Correlation_Async(i_Params_Process_Kendall_Correlation).Result;
        }
        public async Task<Result_Process_Kendall_Correlation> Process_Kendall_Correlation_Async(Params_Process_Kendall_Correlation i_Params_Process_Kendall_Correlation)
        {
            return await Call_WebApi<Result_Process_Kendall_Correlation>("/Api/CorrelationCalculation/Process_Kendall_Correlation", true, "POST", JsonConvert.SerializeObject(i_Params_Process_Kendall_Correlation));
        }
    }
    public partial class Params_Upload_Share_File
    {
        public long? USER_ID { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    public partial class Params_Upload_Organization_Picture
    {
        public int? ORGANIZATION_ID { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    public partial class Params_Upload_Asset
    {
        public string Asset_Relative_Path { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    public class Params_Upload_Default_Settings_Picture
    {
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    public class Params_Detect_Face_In_Image
    {
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    public partial class Params_Create_Log
    {
        public int? SITE_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public string MESSAGE { get; set; }
        public int? VIDEO_AI_ASSET_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ACCESS_TYPE_SETUP_ID { get; set; }
    }
    public partial class Params_Process_Spearman_Correlation
    {
        public List<decimal?> X { get; set; }
        public List<decimal?> Y { get; set; }
        public int? R { get; set; }
    }
    public partial class Params_Process_Pearson_Correlation
    {
        public List<decimal?> X { get; set; }
        public List<decimal?> Y { get; set; }
        public int? R { get; set; }
    }
    public partial class Params_Process_Kendall_Correlation
    {
        public List<decimal?> X { get; set; }
        public List<decimal?> Y { get; set; }
        public int? R { get; set; }
    }
    public class Result_Create_Log : Action_Result
    {
        public Params_Create_Log Params_Create_Log { get; set; }
    }
    public class Result_Process_Spearman_Correlation : Action_Result
    {
        public List<decimal?> i_Result { get; set; }
        public Params_Create_Log Params_Create_Log { get; set; }
    }
    public class Result_Process_Pearson_Correlation : Action_Result
    {
        public List<decimal?> i_Result { get; set; }
        public Params_Create_Log Params_Create_Log { get; set; }
    }
    public class Result_Process_Kendall_Correlation : Action_Result
    {
        public List<decimal?> i_Result { get; set; }
        public Params_Create_Log Params_Create_Log { get; set; }
    }
}