using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Org_All_Access
    public class Params_Get_Org_All_Access
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Modify_Data_Settings
    public class Params_Modify_Data_Settings
    {
        public int? ORGANIZATION_ID { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public Params_Edit_Organization_log_config_List Params_Edit_Organization_log_config_List { get; set; }
    }
    #endregion
    #region Params_Restore_Organization
    public class Params_Restore_Organization
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Modify_Organization_Details
    public class Params_Modify_Organization_Details
    {
        public int? ORGANZATION_ID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string ORGANIZATION_PHONE_NUMBER { get; set; }
        public string ORGANIZATION_EMAIL { get; set; }
        public string ORGANIZATION_ADDRESS { get; set; }
        public int? MAX_NUMBER_OF_ADMINS { get; set; }
        public int? MAX_NUMBER_OF_USERS { get; set; }
    }
    #endregion
    #region Params_Permanently_Delete_Organization
    public class Params_Permanently_Delete_Organization
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Schedule_Organization_for_Delete
    public class Params_Schedule_Organization_for_Delete
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_Organization_by_ORGANIZATION_ID_Custom
    public class Params_Get_Organization_by_ORGANIZATION_ID_Custom
    {
        public int? ORGANIZATION_ID { get; set; }
        public bool? IS_GET_IMAGES_FROM_GCP { get; set; }
    }
    #endregion
    #region Params_Upload_Organization_Picture
    public partial class Params_Upload_Organization_Picture
    {
        public int? ORGANIZATION_ID { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    #endregion
    #region Params_Delete_Organization_Picture
    public class Params_Delete_Organization_Picture
    {
        public int? ORGANIZATION_ID { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Get_Organization_Images_From_GCP
    public class Params_Get_Organization_Images_From_GCP
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Send_Support_Email
    public class Params_Send_Support_Email
    {
        public string TITLE { get; set; }
        public string MESSAGE { get; set; }
    }
    #endregion
    #region Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
    public class Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
    {
        public int? ORGANIZATION_ID { get; set; }
        public List<string> LIST_EAGER_LOADED_DATA { get; set; }
    }
    #endregion
    #region Params_Get_Organization_By_PARENT_ORGANIZATION_ID
    public partial class Params_Get_Organization_By_PARENT_ORGANIZATION_ID
    {
        public int? PARENT_ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Edit_Organization_Custom
    public partial class Params_Edit_Organization_Custom
    {
        public Organization ORGANIZATION { get; set; }
    }
    #endregion
}