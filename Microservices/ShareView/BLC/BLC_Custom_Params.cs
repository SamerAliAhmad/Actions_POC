using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Upload_Share_File
    public class Params_Upload_Share_File
    {
        public long? USER_ID { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    #endregion
    #region Params_Send_Share_Link_By_Email 
    public class Params_Send_Share_Link_By_Email
    {
        public string SHARE_DATA_LINK { get; set; }
        public List<string> List_Email { get; set; }
    }
    #endregion
    #region Params_Delete_Entity_share_data
    public class Params_Delete_Entity_share_data
    {
        public string UNIQUE_STRING { get; set; }
    }
    #endregion
    #region Params_Edit_Entity_share_data
    public class Params_Edit_Entity_share_data
    {
        public Entity_share_data Entity_share_data { get; set; }
    }
    #endregion
    #region Params_Get_Entity_share_data_By_UNIQUE_STRING
    public class Params_Get_Entity_share_data_By_UNIQUE_STRING
    {
        public string UNIQUE_STRING { get; set; }
    }
    #endregion
    #region Params_Get_Entity_share_view_data
    public class Params_Get_Entity_share_view_data
    {
        public string UNIQUE_STRING { get; set; }
    }
    #endregion
}