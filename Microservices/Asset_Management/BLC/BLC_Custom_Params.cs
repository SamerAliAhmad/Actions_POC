using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Asset_Data
    public class Params_Get_Asset_Data
    {
        public long? SPACE_ASSET_ID { get; set; }
    }
    #endregion
    #region Params_Get_Asset_Data_List
    public class Params_Get_Asset_Data_List
    {
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    #endregion
    
}