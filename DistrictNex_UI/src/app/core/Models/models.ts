import { Area, District, Entity, Enum_Timespan, Kpi_chart_configuration, Organization_data_source_kpi, Setup, Site, Space_asset } from 'app/core/Services/proxy.service';
import { ChartConfiguration } from "chart.js/dist/types/index";
import { GLTF } from 'three/examples/jsm/loaders/GLTFLoader';
import { Enum_Dimension_Status, Level_Dimension_with_Status } from "../Services/proxy.service";
import { Action_Button } from './../Services/proxy.service';

export class Access_Control_Object {
    Level: Object;
    LEVEL_ID: number;
    DATA_LEVEL_SETUP_ID: number;
    List_ORGANIZATION_DATA_SOURCE_KPI_ID: number[];
    Selected_Organization_data_source_kpi: Organization_data_source_kpi;
    List_Filtered_Organization_data_source_kpi: Organization_data_source_kpi[];
    List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}

export class Dimension_data {
    CssClass: string = '';
    oList_Serie: any[] = [];
    INDEX_VALUE: number = null;
    INDEX_COLOR: string = '';
    LEVEL_DIMENSION_WITH_STATUS: Level_Dimension_with_Status = null;
    DISPLAY_ICON: number = null;
    ChartConfiguration: ChartConfiguration = null;
    Enum_Dimension_Status: Enum_Dimension_Status = null;
    DIMENSION_ICON: string = '';
}

export class Kpi_data {
    ChartConfiguration: ChartConfiguration = null;
    CHART_TITLE: string;
    CHART_SUBTITLE: string;
    List_Action_Button?: Action_Button[] = [];
    From_Date: string;
    To_Date: string;
    Setting_Toggle_Button: Action_Button;
    Kpi_chart_configuration: Kpi_chart_configuration;
    isDataAvailable: boolean;
    isButtonClickable: boolean = false;
}

export class Displayed_Category {
    name: string;
    value: string;
}

export class Preset_time {
    NAME: string;
    DAYS_BEHIND: number;
    ENUM_TIMESPAN_LIST: Enum_Timespan[];
}

export class Organization_data_source_kpi_with_Direction {
    Organization_data_source_kpi: Organization_data_source_kpi;
    Alert_operation_Setup: Setup;
}

export class Space_asset_with_gltf {
    Space_asset: Space_asset;
    gltfData: GLTF;
}

export class Kpi_data_With_Level {
    List_Kpi_data: Kpi_data[];
    Level: District | Area | Site | Entity;
}