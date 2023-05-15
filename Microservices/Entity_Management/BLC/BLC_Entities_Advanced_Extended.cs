using System.Collections.Generic;

namespace BLC
{
    #region Setup_category
    public partial class Setup_category
    {
        #region Advanced Properties
        public List<Setup> List_Setup { get; set; }
        #endregion
    }
    #endregion
    #region Entity
    public partial class Entity
    {
        #region Advanced Properties
        public List<Floor> List_Floor { get; set; }
        public List<Entity_view> List_Entity_view { get; set; }
        #endregion
    }
    #endregion
    #region Space_asset
    public partial class Space_asset
    {
        #region Advanced Properties
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
        #endregion
    }
    #endregion
    #region Area
    public partial class Area
    {
        #region Advanced Properties
        public List<Area_view> List_Area_view { get; set; }
        #endregion
    }
    #endregion
    #region Site
    public partial class Site
    {
        #region Advanced Properties
        public List<Site_view> List_Site_view { get; set; }
        public List<Site_field_logo> List_Site_field_logo { get; set; }
        #endregion
    }
    #endregion
    #region Ext_study_zone
    public partial class Ext_study_zone
    {
        #region Advanced Properties
        #endregion
    }
    #endregion
    #region District
    public partial class District
    {
        #region Advanced Properties
        public List<District_view> List_District_view { get; set; }
        #endregion
    }
    #endregion
    #region Dimension
    public partial class Dimension
    {
        #region Advanced Properties
        public List<Kpi> List_Kpi { get; set; }
        public List<Report> List_Report { get; set; }
        #endregion
    }
    #endregion
    #region Organization_color_scheme
    public partial class Organization_color_scheme
    {
        #region Advanced Properties
        public List<Organization_chart_color> List_Organization_chart_color { get; set; }
        #endregion
    }
    #endregion
    #region Organization
    public partial class Organization
    {
        #region Advanced Properties
        public List<User> List_User { get; set; }
        public List<Organization_theme> List_Organization_theme { get; set; }
        public List<Organization_color_scheme> List_Organization_color_scheme { get; set; }
        public List<Organization_districtnex_module> List_Organization_districtnex_module { get; set; }
        public List<Organization_image> List_Organization_image { get; set; }
        public List<Organization_level_access> List_Organization_level_access { get; set; }
        public List<Organization_log_config> List_Organization_log_config { get; set; }
        #endregion
    }
    #endregion
    #region Floor
    public partial class Floor
    {
        #region Advanced Properties
        public List<Space> List_Space { get; set; }
        #endregion
    }
    #endregion
    #region User
    public partial class User
    {
        #region Advanced Properties
        public List<User_districtnex_module> List_User_districtnex_module { get; set; }
        public List<User_level_access> List_User_level_access { get; set; }
        #endregion
    }
    #endregion
    #region Default_settings
    public partial class Default_settings
    {
        #region Advanced Properties
        public List<Default_chart_color> List_Default_chart_color { get; set; }
        public List<Default_settings_image> List_Default_settings_image { get; set; }
        #endregion
    }
    #endregion
    #region Video_ai_engine
    public partial class Video_ai_engine
    {
        #region Advanced Properties
        public List<Video_ai_instance> List_Video_ai_instance { get; set; }
        #endregion
    }
    #endregion
    #region Build_version
    public partial class Build_version
    {
        #region Advanced Properties
        public List<Build_version_log> List_Build_version_log { get; set; }
        #endregion
    }
    #endregion
}