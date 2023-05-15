using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Create_User
    public class Params_Create_User
    {
        public User USER { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Restore_User
    public class Params_Restore_User
    {
        public long? USER_ID { get; set; }
    }
    #endregion
    #region Params_Get_Admin_Data
    public class Params_Get_Admin_Data
    {
        public int? USER_ID { get; set; }
        public bool? IS_GET_IMAGES_FROM_Cloud { get; set; }
    }
    #endregion
    #region Params_Change_Password
    public class Params_Change_Password
    {
        public long? USER_ID { get; set; }
        public string OLD_PASSWORD { get; set; }
        public string NEW_PASSWORD { get; set; }
    }
    #endregion
    #region Params_Edit_User_Details
    public class Params_Edit_User_Details
    {
        public int? USER_ID { get; set; }
        public string PHONE_NUMBER { get; set; }
        public bool IS_RECEIVE_EMAIL { get; set; }
    }
    #endregion
    #region Params_Send_Support_Email
    public class Params_Send_Support_Email
    {
        public string TITLE { get; set; }
        public string MESSAGE { get; set; }
    }
    #endregion
    #region Params_Modify_User_Details
    public class Params_Modify_User_Details
    {
        public User User { get; set; }
    }
    #endregion
    #region Params_Check_User_Districtnex_Module_Access
    public class Params_Check_User_Districtnex_Module_Access
    {
        public User User { get; set; }
        public List<int?> DISTRICTNEX_MODULE_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Check_User_level_access
    public class Params_Check_User_level_access
    {
        public long? USER_ID { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> DISTRICTNEX_MODULE_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Check_User_Role
    public class Params_Check_User_Role
    {
        public long? USER_ID { get; set; }
        public string CURRENT_USER_TYPE_SETUP_VALUE { get; set; }
    }
    #endregion
    #region Params_Edit_User_Walkthrough
    public class Params_Edit_User_Walkthrough
    {
        public bool IS_ADMIN_UI { get; set; }
        public string USER_WALKTHROUGH { get; set; }
    }
    #endregion
    #region Params_Permanently_Delete_User
    public class Params_Permanently_Delete_User
    {
        public long? USER_ID { get; set; }
    }
    #endregion
    #region Params_Check_Organization_Quota
    public class Params_Check_Organization_Quota
    {
        public int? ORGANIZATION_ID { get; set; }
        public string USER_TYPE_VALUE { get; set; }
    }
    #endregion
    #region Params_Schedule_User_for_Delete
    public class Params_Schedule_User_for_Delete
    {
        public long? USER_ID { get; set; }
    }
    #endregion
    #region Params_Get_User_With_User_level_access
    public class Params_Get_User_With_User_level_access
    {
        public long? USER_ID { get; set; }
    }
    #endregion
    #region Params_Change_User_Password
    public class Params_Change_User_Password
    {
        public long? USER_ID { get; set; }
        public string NEW_PASSWORD { get; set; }
    }
    #endregion
    #region Params_Get_User_Accessible_Data
    public class Params_Get_User_Accessible_Data
    {
        public int? CHOSEN_ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_User_Accessible_Data_With_Level_List
    public class Params_Get_User_Accessible_Data_With_Level_List
    {
        public int? CHOSEN_ORGANIZATION_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public long? SELECTED_LEVEL_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_User_Accessible_Level_List
    public class Params_Get_User_Accessible_Level_List
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
    #endregion
    #region Params_Get_Level_Data
    public class Params_Get_Level_Data
    {
        public long? UPPER_LEVEL_ID { get; set; }
        public int? SELECTED_DATA_LEVEL_SETUP_ID { get; set; }
        public List<long?> LIST_SELECTED_LEVEL_ID { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Dimension_Index_With_Simple_Upper_Level
    public class Params_Get_Dimension_Index_With_Simple_Upper_Level
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
    #endregion
    #region Params_Get_Entity_Intersection_List
    public class Params_Get_Entity_Intersection_List
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_Initial_Data
    public class Params_Get_Initial_Data
    {
        public int? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_List_Organization_with_Accessible_Top_Levels

    public class Params_Get_List_Organization_with_Accessible_Top_Levels
    {
        public User USER { get; set; }
    }

    #endregion

    #region Dimension Management
    #region Params_Get_Dimension_index_By_Where
    public class Params_Get_Dimension_index_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Insert_Dimension_index_List
    public class Params_Insert_Dimension_index_List
    {
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Delete_Dimension_index_By_Where
    public class Params_Delete_Dimension_index_By_Where
    {
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #endregion
    #region GeoJson
    #region Params_Get_District_geojson_By_DISTRICT_ID_List
    public class Params_Get_District_geojson_By_DISTRICT_ID_List
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
    }
    #endregion

    #region Params_Get_Area_geojson_By_AREA_ID_List
    public class Params_Get_Area_geojson_By_AREA_ID_List
    {
        public List<long?> AREA_ID_LIST { get; set; }
    }
    #endregion

    #region Params_Get_Site_geojson_By_SITE_ID_List
    public class Params_Get_Site_geojson_By_SITE_ID_List
    {
        public List<long?> SITE_ID_LIST { get; set; }
    }
    #endregion
    #endregion
}