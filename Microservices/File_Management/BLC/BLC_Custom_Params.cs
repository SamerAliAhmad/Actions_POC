using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Delete_Object
    public class Params_Delete_Object
    {
        public string Object_Name { get; set; }
    }
    public class Params_Delete_Object_List
    {
        public IEnumerable<string> List_Object_Name { get; set; }
    }
    #endregion
    #region Params_Upload_Object
    public class Params_Upload_Object
    {
        public byte[] Data { get; set; }
        public string Object_Name { get; set; }
    }
    #endregion
    #region Params_Upload_Asset
    public class Params_Upload_Asset
    {
        public string Asset_Relative_Path { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    #endregion
}