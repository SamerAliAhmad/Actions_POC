namespace BLC
{
    #region Kpi
    public partial class Kpi
    {
        #region Advanced Properties
        public Dimension Dimension { get; set; }
        public Setup Kpi_type_setup { get; set; }
        public Setup Max_data_level_setup { get; set; }
        public Setup Min_data_level_setup { get; set; }
        public Setup_category Setup_category { get; set; }
        #endregion
    }
    #endregion
    #region Build_version_log
    public partial class Build_version_log
    {
        #region Advanced Properties
        public Build_version Build_version { get; set; }
        public Setup Build_log_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Video_ai_search_category
    public partial class Video_ai_search_category
    {
        #region Advanced Properties
        public Video_ai_engine Video_ai_engine { get; set; }
        #endregion
    }
    #endregion
    #region Site_view
    public partial class Site_view
    {
        #region Advanced Properties
        public Site Site { get; set; }
        public Setup View_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Removed_extrusion
    public partial class Removed_extrusion
    {
        #region Advanced Properties
        public Setup Data_level_setup { get; set; }
        #endregion
    }
    #endregion
    #region Asset
    public partial class Asset
    {
        #region Advanced Properties
        public Setup Asset_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Entity_view
    public partial class Entity_view
    {
        #region Advanced Properties
        public Entity Entity { get; set; }
        public Setup View_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Data_source_kpi_request
    public partial class Data_source_kpi_request
    {
        #region Advanced Properties
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        #endregion
    }
    #endregion
    #region Organization_theme
    public partial class Organization_theme
    {
        #region Advanced Properties
        public Organization Organization { get; set; }
        #endregion
    }
    #endregion
    #region Video_ai_asset_entity
    public partial class Video_ai_asset_entity
    {
        #region Advanced Properties
        public Entity Entity { get; set; }
        public Video_ai_asset Video_ai_asset { get; set; }
        #endregion
    }
    #endregion
    #region Area_kpi_user_access
    public partial class Area_kpi_user_access
    {
        #region Advanced Properties
        public Area Area { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Alert_settings
    public partial class Alert_settings
    {
        #region Advanced Properties
        public Kpi Kpi { get; set; }
        public Setup Operation_setup { get; set; }
        public Setup Value_type_setup { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Site_kpi_user_access
    public partial class Site_kpi_user_access
    {
        #region Advanced Properties
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public Site Site { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Default_settings_image
    public partial class Default_settings_image
    {
        #region Advanced Properties
        public Default_settings Default_settings { get; set; }
        public Setup Image_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Organization
    public partial class Organization
    {
        #region Advanced Properties
        public Setup Organization_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Organization_level_access
    public partial class Organization_level_access
    {
        #region Advanced Properties
        public Organization Organization { get; set; }
        public Setup Data_level_setup { get; set; }
        #endregion
    }
    #endregion
    #region Entity_kpi
    public partial class Entity_kpi
    {
        #region Advanced Properties
        public Entity Entity { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        #endregion
    }
    #endregion
    #region Entity
    public partial class Entity
    {
        #region Advanced Properties
        public Area Area { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Site Site { get; set; }
        public Top_level Top_level { get; set; }
        public Setup Entity_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region District_kpi
    public partial class District_kpi
    {
        #region Advanced Properties
        public District District { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        #endregion
    }
    #endregion
    #region Organization_log_config
    public partial class Organization_log_config
    {
        #region Advanced Properties
        public Organization Organization { get; set; }
        public Setup Log_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region User_level_access
    public partial class User_level_access
    {
        #region Advanced Properties
        public Organization_level_access Organization_level_access { get; set; }
        public Setup Data_level_setup { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region User_districtnex_module
    public partial class User_districtnex_module
    {
        #region Advanced Properties
        public Districtnex_module Districtnex_module { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Entity_kpi_user_access
    public partial class Entity_kpi_user_access
    {
        #region Advanced Properties
        public Entity Entity { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Organization_color_scheme
    public partial class Organization_color_scheme
    {
        #region Advanced Properties
        public Organization Organization { get; set; }
        #endregion
    }
    #endregion
    #region District_view
    public partial class District_view
    {
        #region Advanced Properties
        public District District { get; set; }
        public Setup View_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Area
    public partial class Area
    {
        #region Advanced Properties
        public District District { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
        #endregion
    }
    #endregion
    #region Area_view
    public partial class Area_view
    {
        #region Advanced Properties
        public Area Area { get; set; }
        public Setup View_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Site_kpi
    public partial class Site_kpi
    {
        #region Advanced Properties
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public Site Site { get; set; }
        #endregion
    }
    #endregion
    #region Organization_image
    public partial class Organization_image
    {
        #region Advanced Properties
        public Organization Organization { get; set; }
        public Setup Image_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Organization_relation
    public partial class Organization_relation
    {
        #region Advanced Properties
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Setup
    public partial class Setup
    {
        #region Advanced Properties
        public Setup_category Setup_category { get; set; }
        #endregion
    }
    #endregion
    #region Area_kpi
    public partial class Area_kpi
    {
        #region Advanced Properties
        public Area Area { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        #endregion
    }
    #endregion
    #region Site_field_logo
    public partial class Site_field_logo
    {
        #region Advanced Properties
        public Site Site { get; set; }
        #endregion
    }
    #endregion
    #region Region
    public partial class Region
    {
        #region Advanced Properties
        public Top_level Top_level { get; set; }
        #endregion
    }
    #endregion
    #region Space_asset
    public partial class Space_asset
    {
        #region Advanced Properties
        public Asset Asset { get; set; }
        public Space Space { get; set; }
        #endregion
    }
    #endregion
    #region Data_source
    public partial class Data_source
    {
        #region Advanced Properties
        public Data_source_authentication Data_source_authentication { get; set; }
        #endregion
    }
    #endregion
    #region District
    public partial class District
    {
        #region Advanced Properties
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
        #endregion
    }
    #endregion
    #region Organization_data_source_kpi
    public partial class Organization_data_source_kpi
    {
        #region Advanced Properties
        public Data_source Data_source { get; set; }
        public Kpi Kpi { get; set; }
        public Organization Organization { get; set; }
        #endregion
    }
    #endregion
    #region Floor
    public partial class Floor
    {
        #region Advanced Properties
        public Entity Entity { get; set; }
        #endregion
    }
    #endregion
    #region Share_file
    public partial class Share_file
    {
        #region Advanced Properties
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region District_kpi_user_access
    public partial class District_kpi_user_access
    {
        #region Advanced Properties
        public District District { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region User
    public partial class User
    {
        #region Advanced Properties
        public Organization Organization { get; set; }
        public Setup User_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Space
    public partial class Space
    {
        #region Advanced Properties
        public Floor Floor { get; set; }
        #endregion
    }
    #endregion
    #region Build_version
    public partial class Build_version
    {
        #region Advanced Properties
        public Setup Application_name_setup { get; set; }
        #endregion
    }
    #endregion
    #region Report
    public partial class Report
    {
        #region Advanced Properties
        public Dimension Dimension { get; set; }
        #endregion
    }
    #endregion
    #region Site
    public partial class Site
    {
        #region Advanced Properties
        public Area Area { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
        #endregion
    }
    #endregion
    #region User_theme
    public partial class User_theme
    {
        #region Advanced Properties
        public Organization_theme Organization_theme { get; set; }
        public User User { get; set; }
        #endregion
    }
    #endregion
    #region Organization_chart_color
    public partial class Organization_chart_color
    {
        #region Advanced Properties
        public Organization_color_scheme Organization_color_scheme { get; set; }
        public Setup Data_level_setup { get; set; }
        #endregion
    }
    #endregion
    #region Default_chart_color
    public partial class Default_chart_color
    {
        #region Advanced Properties
        public Default_settings Default_settings { get; set; }
        public Setup Data_level_setup { get; set; }
        #endregion
    }
    #endregion
    #region Video_ai_instance
    public partial class Video_ai_instance
    {
        #region Advanced Properties
        public Video_ai_engine Video_ai_engine { get; set; }
        public Setup Connection_type_setup { get; set; }
        #endregion
    }
    #endregion
    #region Video_ai_asset
    public partial class Video_ai_asset
    {
        #region Advanced Properties
        public Space_asset Space_asset { get; set; }
        public Video_ai_instance Video_ai_instance { get; set; }
        #endregion
    }
    #endregion
    #region Organization_districtnex_module
    public partial class Organization_districtnex_module
    {
        #region Advanced Properties
        public Districtnex_module Districtnex_module { get; set; }
        public Organization Organization { get; set; }
        #endregion
    }
    #endregion
    #region Region_view
    public partial class Region_view
    {
        #region Advanced Properties
        public Region Region { get; set; }
        public Setup View_type_setup { get; set; }
        #endregion
    }
    #endregion
}