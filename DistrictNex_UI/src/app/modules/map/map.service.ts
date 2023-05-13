import { Injectable } from '@angular/core';
import { Enum_Map_view } from 'app/core/Models/constants';
import { Dimension_data } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Action_Button, Alert, Alert_settings, Area, Area_Kpi_Dialog_Data, Best_And_Worst_Object, Business, Bylaw_Complaint, Comparison_Data, Correlation_method, Dimension, Dimension_Index_With_Simple_Upper_Level, Dimension_index, Dimension_index_By_Level, Entity, Entity_Incidents, Entity_Kpi_Dialog_Data, Entity_share_data, Enum_Dimension_Status, Enum_Timespan, Floor, Floor_Kpi_Dialog_Data, Incident, Kpi_Value_By_Date, Kpi_Value_By_Direction, Level_Data, Organization_data_source_kpi, Params_Edit_Alert_settings_List, Params_Edit_Object_View, Params_Edit_Removed_extrusion_Custom, Params_Get_Alerts_Count_For_Levels, Params_Get_Alerts_For_Levels, Params_Get_Area_Kpi_Dialog_Data, Params_Get_Business_List, Params_Get_Bylaw_Complaint_List, Params_Get_Comparison_Data, Params_Get_Correlation, Params_Get_Dimension_Index_With_Simple_Upper_Level, Params_Get_Dimension_index_By_Where, Params_Get_Entity_Incidents, Params_Get_Entity_Kpi_Dialog_Data, Params_Get_Floor_By_ENTITY_ID_With_Space_Asset, Params_Get_Floor_Kpi_Dialog_Data, Params_Get_Incidents_By_Where, Params_Get_Intersection_Kpi_Dialog_Data, Params_Get_Latest_Dimension_index_By_Where, Params_Get_Latest_Visitor_Count_By_Where, Params_Get_Level_Data, Params_Get_Multi_kpi_comparison, Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List, Params_Get_Public_Event_List, Params_Get_Single_kpi_comparison, Params_Get_Site_Kpi_Dialog_Data, Params_Get_User_Accessible_Data_With_Level_List, Params_Get_User_Accessible_Level_List, Params_Get_Visitor_Origins, Params_Send_Share_Link_By_Email, Proxy, Public_Event, Setup, Setup_category, Site, Site_Kpi_Dialog_Data, Space, Space_asset, Top_Level_Data, Upper_Level, User_Accessible_Data, User_Accessible_Level_List, Visitor_Count_By_Level, Visitor_Origins, Wifi_signal, Wifi_signal_alert, Wifi_signal_data } from 'app/core/Services/proxy.service';
import { Params_Upload_Share_File, ProxyExt } from 'app/core/Services/proxyExt.service';
import { cloneDeep } from 'lodash';
import { Map } from 'mapbox-gl';
import { BehaviorSubject, ReplaySubject, Subject } from 'rxjs';
import { DRACOLoader } from 'three/examples/jsm/loaders/DRACOLoader';

export class Entity_Dialog_input {
    SITE: Site;
    ENTITY: Entity;
    oList_Dimension_data: Dimension_data[];
}

export class Dialog_input {
    level_id: number;
    properties: {
        level_location,
        chart_index,
        Data_Level_Setup_ID,
        oList_Kpi_data,
        oList_Dimension_data,
        oList_Dimension_index,
        oList_Kpi_chart_configuration,
        oList_Level_Dimension_With_Status,
        oList_Action_Button,
        oClicked_Level_Location,
        upper_level_name: string,
        Current_view_type: string,
        isIndexValuesLoaded: boolean,
        grandfather_level_id: number,
        oChosen_Dimension: Dimension,
        oEnum_Map_View: Enum_Map_view,
        grandfather_level_name: string,
        Enum_Dimension_Status: Enum_Dimension_Status,
        oList_Site_Kpi_Data: Site_Kpi_Dialog_Data[],
        oList_Area_Kpi_Data: Area_Kpi_Dialog_Data[],
    };
}

@Injectable({
    providedIn: 'root'
})
export class MapService {

    oMap: Map;
    mapContainer: HTMLElement;
    oUpper_Level: Upper_Level;
    oEnd_Date_Filter: Date = null;
    oStart_Date_Filter: Date = null;
    oApp_Resolver_Data: User_Accessible_Data;
    oList_Correlation_method: Correlation_method[];
    oEnum_Timespan_Filter: Enum_Timespan = Enum_Timespan.X_DAILY_COLLECTION;

    dialogNumber: number = 0;
    max_Number_Of_Entities: number = 2;


    oList_Business: Business[];

    oData_level_Setup_Category: Setup_category;

    oUpdate_Alert_Count_Subject = new Subject<number>();
    oArea_Changed_Subject = new Subject<Area>();
    oSite_Changed_Subject = new Subject<Site>();
    oApply_Filter_Subject = new Subject<void>();
    oToggle_Border_Subject = new Subject<void>();
    oToggle_Business_Subject = new Subject<void>();
    oFloor_Selected_Subject = new Subject<Floor>();
    oEntity_Changed_Subject = new Subject<Entity>();
    oToggle_Public_event_Subject = new Subject<void>();
    oAsset_Changed_Subject = new Subject<Space_asset>();
    oOpen_Video_AI_Drawer_Subject = new Subject<void>();
    oMarker_Opened_Subject: Subject<any> = new Subject();
    oToggle_ByLaw_Complaint_Subject = new Subject<void>();
    oChange_Map_View_Subject = new Subject<Enum_Map_view>();
    oEntity_share_data_Link_Subject = new Subject<string>();
    oToggle_Map_Style_Subject: Subject<void> = new Subject();
    oOpen_Energy_Insights_Panel_Subject = new Subject<void>();
    oToggle_Correlation_Heatmap_Subject = new Subject<void>();
    oOpen_Top_level_Selector_Subject = new Subject<boolean>();
    oData_From_Filter_Loaded_Subject = new Subject<boolean>();
    oToggle_Intersection_Subject: Subject<any> = new Subject();
    oTop_Level_Changed_Subject = new Subject<Top_Level_Data>();
    oShow_Hide_Mobility_Subject: Subject<boolean> = new Subject();
    oShow_Hide_Entities_Subject: Subject<boolean> = new Subject();
    oRecenter_Map_Subject: Subject<boolean> = new Subject<boolean>();
    oChange_Floor_Renderer_Floor_Subject = new ReplaySubject<Floor>(1);
    oEntity_Incidents_Subject: Subject<Entity_Incidents> = new Subject();
    oFill_Data_From_Building_Summary_Drawer_Subject = new Subject<void>();
    oOpen_Scene_Details_Subject = new Subject<{ sceneModalData?: any }>();
    oOpen_Entity_Summary_Drawer_Subject = new Subject<Dimension_index_By_Level>();
    oLatest_Wifi_signals_Behavior_subject = new BehaviorSubject<Wifi_signal[]>([]);
    oOpen_Expanded_Floor_Renderer = new Subject<{ FLOOR: Floor, isChangingFloor: boolean }>();
    oToggle_Business_Pins_Subject = new Subject<{ level_id: number, upper_level_id: number, view_type: string }>();
    oToggle_Visitor_Heatmap_Subject = new Subject<{ level_id: number, upper_level_id: number, view_type: string }>();
    oToggle_Business_Heatmap_Subject = new Subject<{ level_id: number, upper_level_id: number, view_type: string }>();
    oLocation_Changed_Subject = new Subject<{ level_location: any, List_Upper_Level_Dimension_index: Dimension_index[] }>();
    oToggle_Visitor_Origins_Subject = new Subject<{ level_id: number, coordinates: [longitude: number, latitude: number], data_level_setup_id: number }>();
    oToggle_Action_Button_Subject = new Subject<{ level_id: number, upper_level_id: number, view_type: string, Action_Button: Action_Button }>();

    oLast_Alert_Response: {
        List_Alert: Alert[];
        Params_Get_Alerts_For_Levels: Params_Get_Alerts_For_Levels;
    };
    oLast_Organization_data_source_kpi_Response: {
        List_Organization_data_source_kpi: Organization_data_source_kpi[];
        Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List[];
    }

    isShareView = false;
    oEntity_share_data = new Entity_share_data();

    private isDefaultBuildingsVisibleSubject = new BehaviorSubject<boolean>(true);
    public isDefaultBuildingsVisible$ = this.isDefaultBuildingsVisibleSubject.asObservable();

    private isBordersVisibleSubject = new BehaviorSubject<boolean>(true);
    public isBordersVisible$ = this.isBordersVisibleSubject.asObservable();

    private _DRACOLoader: DRACOLoader;
    get oDRACOLoader(): DRACOLoader {
        if (this._DRACOLoader) {
            return this._DRACOLoader;
        }
        this._DRACOLoader = new DRACOLoader();
        this._DRACOLoader.setDecoderPath("https://www.gstatic.com/draco/v1/decoders/");
        return this._DRACOLoader;
    }

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private proxy: Proxy,
        private proxyExt: ProxyExt,
        private CmSvc: CommonService,
    ) {
    }

    resolve(): Promise<void> {
        return;
    }

    Get_Correlation_method_By_OWNER_ID(): Promise<Correlation_method[]> {
        return new Promise((resolve, reject) => {
            if (this.oList_Correlation_method) {
                resolve(this.oList_Correlation_method);
            }
            else {
                this.proxy.Get_Correlation_method_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    if (result) {
                        this.oList_Correlation_method = result;
                        resolve(this.oList_Correlation_method);
                    }
                    else {
                        reject();
                    }
                })
            }
        })
    }

    Get_Entity_Kpi_Dialog_Data(i_Params_Get_Entity_Kpi_Dialog_Data: Params_Get_Entity_Kpi_Dialog_Data): Promise<Entity_Kpi_Dialog_Data[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Entity_Kpi_Dialog_Data(i_Params_Get_Entity_Kpi_Dialog_Data).subscribe(result => {
                if (result) {
                    resolve(result)
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Entity_Intersection_List(): Promise<Entity[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Entity_Intersection_List({ ORGANIZATION_ID: this.CmSvc.saved_organization_id }).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_ByLaw_Complaint_List(i_Params_Get_ByLaw_Complaint_List: Params_Get_Bylaw_Complaint_List): Promise<Bylaw_Complaint[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Bylaw_Complaint_List(i_Params_Get_ByLaw_Complaint_List).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Intersection_Kpi_Dialog_Data(i_Params_Get_Intersection_Kpi_Dialog_Data: Params_Get_Intersection_Kpi_Dialog_Data): Promise<Entity_Kpi_Dialog_Data[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Intersection_Kpi_Dialog_Data(i_Params_Get_Intersection_Kpi_Dialog_Data).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Public_Event_List(i_Params_Get_Public_Events: Params_Get_Public_Event_List): Promise<Public_Event[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Public_Event_List(i_Params_Get_Public_Events).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Floor_Kpi_Dialog_Data(i_Params_Get_Floor_Kpi_Dialog_Data: Params_Get_Floor_Kpi_Dialog_Data): Promise<Floor_Kpi_Dialog_Data[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Floor_Kpi_Dialog_Data(i_Params_Get_Floor_Kpi_Dialog_Data).subscribe(result => {
                if (result) {
                    this.oLatest_Wifi_signals_Behavior_subject.next([].concat(...result.map(oFloor_Kpi_Dialog_Data => oFloor_Kpi_Dialog_Data.WIFI_SIGNAL_LIST)));
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Latest_Visitor_Count_By_Where(i_Params_Get_Latest_Visitor_Count_By_Where: Params_Get_Latest_Visitor_Count_By_Where): Promise<Visitor_Count_By_Level[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Latest_Visitor_Count_By_Where(i_Params_Get_Latest_Visitor_Count_By_Where).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }


    Get_Entity_Incidents(i_Entity: Entity, startRow = 0, endRow = 20, listCategorySetup: Setup[] = []): Promise<Entity_Incidents> {
        return new Promise(resolve => {
            const oParams_Get_Entity_Incidents = new Params_Get_Entity_Incidents();
            oParams_Get_Entity_Incidents.ENTITY_ID = i_Entity.ENTITY_ID;
            oParams_Get_Entity_Incidents.END_DATE = this.oEnd_Date_Filter?.toISOString();
            oParams_Get_Entity_Incidents.START_DATE = this.oStart_Date_Filter?.toISOString();
            oParams_Get_Entity_Incidents.CATEGORY_SETUP_LIST = listCategorySetup;
            oParams_Get_Entity_Incidents.START_ROW = startRow;
            oParams_Get_Entity_Incidents.END_ROW = endRow;

            this.proxy.Get_Entity_Incidents(oParams_Get_Entity_Incidents).subscribe(result => {
                this.oEntity_Incidents_Subject.next(result);
                resolve(result);
            })
        })
    }

    Get_Floor_By_ENTITY_ID_With_Space_Asset(i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset: Params_Get_Floor_By_ENTITY_ID_With_Space_Asset): Promise<Floor[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Floor_By_ENTITY_ID_With_Space_Asset(i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_dimension_index_with_simple_upper_level(i_Params_Dimension_Index_With_Simple_Upper_Level: Params_Get_Dimension_Index_With_Simple_Upper_Level): Promise<Dimension_Index_With_Simple_Upper_Level> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Dimension_Index_With_Simple_Upper_Level(i_Params_Dimension_Index_With_Simple_Upper_Level).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Level_Data(UPPER_LEVEL_ID: number, SELECTED_DATA_LEVEL_SETUP_ID: number, LIST_SELECTED_LEVEL_ID: number[], LIST_DIMENSION_ID: number[]): Promise<Level_Data> {
        let oParams_Get_Level_Data = new Params_Get_Level_Data();
        oParams_Get_Level_Data.UPPER_LEVEL_ID = UPPER_LEVEL_ID;
        oParams_Get_Level_Data.SELECTED_DATA_LEVEL_SETUP_ID = SELECTED_DATA_LEVEL_SETUP_ID;
        oParams_Get_Level_Data.LIST_SELECTED_LEVEL_ID = LIST_SELECTED_LEVEL_ID;
        oParams_Get_Level_Data.LIST_DIMENSION_ID = LIST_DIMENSION_ID;
        oParams_Get_Level_Data.START_DATE = this.oStart_Date_Filter?.toISOString();
        oParams_Get_Level_Data.END_DATE = this.oEnd_Date_Filter?.toISOString();
        oParams_Get_Level_Data.ENUM_TIMESPAN = this.oEnum_Timespan_Filter;
        return new Promise<Level_Data>((resolve, reject) => {
            this.proxy.Get_Level_Data(oParams_Get_Level_Data).subscribe(result => {
                if (result) {
                    this.CmSvc.GeoJSON_Source = result.GEOJSON_SRC;
                    this.oUpper_Level = result.UPPER_LEVEL;
                    resolve(result)
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Business_List(i_Params_Get_Business_List: Params_Get_Business_List): Promise<Business[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Business_List(i_Params_Get_Business_List).subscribe(result => {
                if (result) {
                    this.oList_Business = result;
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Dimension_index_By_Where(i_Params_Get_Dimension_index_By_Where: Params_Get_Dimension_index_By_Where): Promise<Dimension_index[]> {
        return new Promise(resolve => {
            this.proxy.Get_Dimension_index_By_Where(i_Params_Get_Dimension_index_By_Where).subscribe(result => {
                if (result) {
                    resolve(result)
                }
            })
        })
    }

    toggleDefaultBuildingsVisibility() {
        this.isDefaultBuildingsVisibleSubject.next(!this.isDefaultBuildingsVisibleSubject.value);
    }

    toggleBordersVisibility() {
        this.isBordersVisibleSubject.next(!this.isBordersVisibleSubject.value);
    }

    set_Map(i_Map: Map) {
        this.oMap = cloneDeep(i_Map);
    }

    Edit_Removed_extrusion_Custom(i_Params_Edit_Removed_extrusion_Custom: Params_Edit_Removed_extrusion_Custom): Promise<void> {
        return new Promise(resolve => {
            this.proxy.Edit_Removed_extrusion_Custom(i_Params_Edit_Removed_extrusion_Custom).subscribe(() => {
                resolve();
            });
        });
    }

    Edit_Object_View(i_Params_Edit_Object_View: Params_Edit_Object_View) {
        this.proxy.Edit_Object_View(i_Params_Edit_Object_View).subscribe();
    }

    Get_Asset_Data_List(i_Space_asset: Space_asset): Promise<void> {
        return new Promise(resolve => {
            this.proxy.Get_Asset_Data_List({ SPACE_ASSET_ID_LIST: [i_Space_asset.SPACE_ASSET_ID] }).subscribe(result => {
                i_Space_asset.List_Space_asset_energy_incident = result.SPACE_ASSET_ENERGY_INCIDENT_LIST;
                i_Space_asset.List_Space_asset_security_incident = result.SPACE_ASSET_SECURITY_INCIDENT_LIST;
                resolve();
            })
        })
    }

    Get_Floor_Security_Incidents(entity: Entity): Promise<Incident[]> {
        return new Promise(resolve => {
            const oParams_Get_Incidents_By_Where = new Params_Get_Incidents_By_Where();
            oParams_Get_Incidents_By_Where.FLOOR_ID_LIST = entity.List_Floor.map(floor => floor.FLOOR_ID);
            oParams_Get_Incidents_By_Where.DIMENSION_ORDER_LIST = [2];

            this.proxy.Get_Incidents_By_Where(oParams_Get_Incidents_By_Where)
                .subscribe(result => {
                    resolve(result);
                })
        })
    }

    Get_Floor_Energy_Incidents(entity: Entity): Promise<Incident[]> {
        return new Promise(resolve => {
            const oParams_Get_Incidents_By_Where = new Params_Get_Incidents_By_Where();
            oParams_Get_Incidents_By_Where.FLOOR_ID_LIST = entity.List_Floor.map(floor => floor.FLOOR_ID);
            oParams_Get_Incidents_By_Where.DIMENSION_ORDER_LIST = [1];

            this.proxy.Get_Incidents_By_Where(oParams_Get_Incidents_By_Where)
                .subscribe(result => {
                    resolve(result);
                })
        })
    }

    Get_Comparison_Data(i_Params_Get_Comparison_Data: Params_Get_Comparison_Data): Promise<Comparison_Data> {
        return new Promise(resolve => {
            this.proxy.Get_Comparison_Data(i_Params_Get_Comparison_Data).subscribe(result => {
                resolve(result);
            });
        });
    }


    Get_New_Top_Level_Data(i_Params_Get_User_Accessible_Level_List: Params_Get_User_Accessible_Level_List): Promise<User_Accessible_Level_List> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_User_Accessible_Level_List(i_Params_Get_User_Accessible_Level_List).subscribe(result => {
                if (result) {
                    this.CmSvc.oUser_Accessible_Level_List = result;
                    this.CmSvc.oList_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST
                    this.CmSvc.GeoJSON_Source = result.GEOJSON_SRC;
                    let view_type_setup_id;
                    if (result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST?.length && result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST?.length > 0) {
                        this.CmSvc.oList_Accessible_District = result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST;
                        if (!this.Check_Local_View_Type_Setup_ID()) {
                            view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "district").SETUP_ID
                            this.Set_View_Type_Setup_ID(view_type_setup_id);
                        }
                    }
                    if (result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST?.length && result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST?.length > 0) {
                        this.CmSvc.oList_Accessible_Area = result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST;
                        if (!this.Check_Local_View_Type_Setup_ID()) {
                            view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "area").SETUP_ID
                            this.Set_View_Type_Setup_ID(view_type_setup_id);
                        }
                    }
                    if (result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST?.length && result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST?.length > 0) {
                        this.CmSvc.oList_Accessible_Site = result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST;
                        if (!this.Check_Local_View_Type_Setup_ID()) {
                            view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "site").SETUP_ID
                            this.Set_View_Type_Setup_ID(view_type_setup_id);
                        }
                    }
                    if (result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST?.length && result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST?.length > 0) {
                        this.CmSvc.oList_Accessible_Entity = result.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST;
                        if (!this.Check_Local_View_Type_Setup_ID()) {
                            view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "entity").SETUP_ID
                            this.Set_View_Type_Setup_ID(view_type_setup_id);
                        }
                    }
                    this.CmSvc.oList_Dimension_Index = result.LIST_DIMENSION_INDEX;
                    this.oUpper_Level = result.UPPER_LEVEL;
                    this.CmSvc.oList_Dimension_Index = result.LIST_DIMENSION_INDEX;
                    this.CmSvc.GeoJSON_Source = result.GEOJSON_SRC;
                    this.oUpdate_Alert_Count_Subject.next(0);
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Initial_Top_Level_Data(): Promise<User_Accessible_Level_List> {
        this.oData_level_Setup_Category = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("Data Level");
        this.oEnd_Date_Filter = new Date();
        this.oStart_Date_Filter = new Date();
        this.oEnd_Date_Filter.setDate(this.oEnd_Date_Filter.getDate() - 1);
        this.oStart_Date_Filter.setDate(this.oStart_Date_Filter.getDate() - this.CmSvc.oList_Preset_time[0].DAYS_BEHIND - 1);
        this.oEnum_Timespan_Filter = this.CmSvc.oList_Preset_time[0].ENUM_TIMESPAN_LIST[0];
        return new Promise((resolve, reject) => {
            if (this.CmSvc.oUser_Accessible_Level_List) {
                resolve(this.CmSvc.oUser_Accessible_Level_List)
            }
            else {
                let oParams_Get_User_Accessible_Data_With_LEVEL_LIST = new Params_Get_User_Accessible_Data_With_Level_List();
                oParams_Get_User_Accessible_Data_With_LEVEL_LIST.CHOSEN_ORGANIZATION_ID = this.CmSvc.saved_organization_id;
                let view_type_setup_id = localStorage.getItem('view_type_setup_id');
                let view_type;
                if (this.CmSvc.CheckString(view_type_setup_id)) {
                    oParams_Get_User_Accessible_Data_With_LEVEL_LIST.DATA_LEVEL_SETUP_ID = Number.parseInt(view_type_setup_id);
                    view_type = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("data level").List_Setup.find(oSetup => oSetup.SETUP_ID == Number.parseInt(view_type_setup_id)).VALUE;
                }
                if (view_type) {
                    let selected_level_id = Number.parseInt(localStorage.getItem(`${view_type.toLowerCase()}_id`));
                    oParams_Get_User_Accessible_Data_With_LEVEL_LIST.SELECTED_LEVEL_ID = selected_level_id;
                }
                oParams_Get_User_Accessible_Data_With_LEVEL_LIST.TOP_LEVEL_ID = this.CmSvc.saved_top_level_id;
                oParams_Get_User_Accessible_Data_With_LEVEL_LIST.START_DATE = this.oStart_Date_Filter?.toISOString();
                oParams_Get_User_Accessible_Data_With_LEVEL_LIST.END_DATE = this.oEnd_Date_Filter?.toISOString();
                oParams_Get_User_Accessible_Data_With_LEVEL_LIST.ENUM_TIMESPAN = this.oEnum_Timespan_Filter;
                this.proxy.Get_User_Accessible_Data_With_Level_List(oParams_Get_User_Accessible_Data_With_LEVEL_LIST).subscribe(result => {
                    if (result) {
                        this.CmSvc.oUser_Accessible_Data = result.USER_ACCESSIBLE_DATA;
                        let view_type_setup_id;
                        if (result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST?.length && result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST?.length > 0) {
                            this.CmSvc.oList_Accessible_District = result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST;
                            if (!this.Check_Local_View_Type_Setup_ID()) {
                                view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "district").SETUP_ID
                                this.Set_View_Type_Setup_ID(view_type_setup_id);
                            }
                        }
                        if (result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST?.length && result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST?.length > 0) {
                            this.CmSvc.oList_Accessible_Area = result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST;
                            if (!this.Check_Local_View_Type_Setup_ID()) {
                                view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "area").SETUP_ID
                                this.Set_View_Type_Setup_ID(view_type_setup_id);
                            }
                        }
                        if (result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST?.length && result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST?.length > 0) {
                            this.CmSvc.oList_Accessible_Site = result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST;
                            if (!this.Check_Local_View_Type_Setup_ID()) {
                                view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "site").SETUP_ID
                                this.Set_View_Type_Setup_ID(view_type_setup_id);
                            }
                        }
                        if (result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST?.length && result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST?.length > 0) {
                            this.CmSvc.oList_Accessible_Entity = result.USER_ACCESSIBLE_LEVEL_LIST.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST;
                            if (!this.Check_Local_View_Type_Setup_ID()) {
                                view_type_setup_id = this.oData_level_Setup_Category.List_Setup.find(setup => setup.VALUE.toLowerCase() == "entity").SETUP_ID
                                this.Set_View_Type_Setup_ID(view_type_setup_id);
                            }
                        }

                        this.CmSvc.oList_Dimension_Index = result.USER_ACCESSIBLE_LEVEL_LIST.LIST_DIMENSION_INDEX;
                        this.CmSvc.GeoJSON_Source = result.USER_ACCESSIBLE_LEVEL_LIST.GEOJSON_SRC;
                        this.CmSvc.oUser_Accessible_Level_List = result.USER_ACCESSIBLE_LEVEL_LIST;
                        this.CmSvc.oList_Organization_data_source_kpi = result.USER_ACCESSIBLE_LEVEL_LIST.ORGANIZATION_DATA_SOURCE_KPI_LIST;
                        this.oUpdate_Alert_Count_Subject.next(0);
                        resolve(result.USER_ACCESSIBLE_LEVEL_LIST);
                        this.oUpper_Level = result.USER_ACCESSIBLE_LEVEL_LIST.UPPER_LEVEL;
                    }
                    else {
                        reject();
                    }
                })
            }

        })
    }

    Check_Local_View_Type_Setup_ID() {
        return this.CmSvc.CheckString(localStorage.getItem('view_type_setup_id'));
    }

    Set_View_Type_Setup_ID(view_type_setup_id) {
        localStorage.setItem('view_type_setup_id', view_type_setup_id)
    }

    Get_Site_Kpi_Data(i_Params_Get_Site_Kpi_Data: Params_Get_Site_Kpi_Dialog_Data): Promise<Site_Kpi_Dialog_Data[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Site_Kpi_Dialog_Data(i_Params_Get_Site_Kpi_Data).subscribe(result => {
                if (result) {
                    this.CmSvc.oList_Site_Kpi_Data = result;
                    resolve(result);
                }
                else {
                    reject();
                }
            });
        })
    }

    Get_Visitor_Origins(i_Params_Get_Visitor_Origins: Params_Get_Visitor_Origins): Promise<Visitor_Origins> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Visitor_Origins(i_Params_Get_Visitor_Origins).subscribe(result => {
                if (result) {
                    resolve(result)
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Area_Kpi_Data(i_Params_Get_Area_Kpi_Data: Params_Get_Area_Kpi_Dialog_Data): Promise<Area_Kpi_Dialog_Data[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Area_Kpi_Dialog_Data(i_Params_Get_Area_Kpi_Data).subscribe(result => {
                if (result) {
                    this.CmSvc.oList_Area_Kpi_Data = result;
                    resolve(result);
                }
                else {
                    reject();
                }
            });
        })
    }

    Get_Space_asset_By_SPACE_ID_List_Adv(i_List_Space: Space[]): Promise<Space_asset[]> {
        return new Promise(resolve => {
            this.proxy.Get_Space_asset_By_SPACE_ID_List({
                SPACE_ID_LIST: i_List_Space.map(space => space.SPACE_ID),
            }).subscribe(result => {
                if (result) {
                    result.forEach(space_asset => {
                        space_asset.Asset.Asset_type_setup = this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Asset type", space_asset.Asset.ASSET_TYPE_SETUP_ID);
                    });
                    i_List_Space.forEach(space => {
                        space.List_Space_asset = result.filter(space_asset => space_asset.SPACE_ID == space.SPACE_ID);
                    });
                }
                resolve(result);
            })
        })
    }

    Get_Latest_Dimension_index_By_Where(i_Params_Get_Latest_Dimension_index_By_Where: Params_Get_Latest_Dimension_index_By_Where): Promise<Dimension_index_By_Level[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Latest_Dimension_index_By_Where(i_Params_Get_Latest_Dimension_index_By_Where).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Get_Correlation(i_Params_Get_Correlation: Params_Get_Correlation): Promise<Kpi_Value_By_Date[]> {
        return new Promise(resolve => {
            this.proxy.Get_Correlation(i_Params_Get_Correlation).subscribe({
                next: result => {
                    resolve(result);
                },
                error: () => resolve(null)
            });
        });
    }

    Get_Single_kpi_comparison(i_Params_Get_Single_kpi_comparison: Params_Get_Single_kpi_comparison): Promise<Kpi_Value_By_Date[]> {
        return new Promise(resolve => {
            this.proxy.Get_Single_kpi_comparison(i_Params_Get_Single_kpi_comparison).subscribe({
                next: result => {
                    resolve(result);
                },
                error: () => resolve(null)
            });
        });
    }

    Get_Multi_Kpi_Comparison(i_Params_Get_Multi_Kpi_Comparison: Params_Get_Multi_kpi_comparison): Promise<Kpi_Value_By_Direction[]> {
        return new Promise(resolve => {
            this.proxy.Get_Multi_kpi_comparison(i_Params_Get_Multi_Kpi_Comparison).subscribe({
                next: result => {
                    resolve(result);
                },
                error: () => resolve(null)
            })
        })
    }

    Get_Alert_settings(): Promise<Alert_settings[]> {
        return new Promise(resolve => {
            if (this.CmSvc.oList_Alert_settings) {
                let oList_Alert_settings = cloneDeep(this.CmSvc.oList_Alert_settings);
                var oList_Organization_data_source_kpi_with_alerts = this.CmSvc.oList_Organization_data_source_kpi.filter(oORGANIZATION_DATA_SOURCE_KPI_ID => oORGANIZATION_DATA_SOURCE_KPI_ID.Kpi.HAS_ALERTS);

                const oList_Kpi_With_Alerts = oList_Organization_data_source_kpi_with_alerts.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi);
                const oList_Alert_operation_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Operation").List_Setup;
                const oList_Alert_value_type_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Value Type").List_Setup.filter(setup => setup.VALUE == "Tolerance");
                oList_Kpi_With_Alerts.forEach(kpi => {
                    oList_Alert_operation_Setup.forEach(operation_setup => {
                        oList_Alert_value_type_Setup.forEach(value_type_setup => {
                            if (!oList_Alert_settings.some(alert_settings => alert_settings.KPI_ID == kpi.KPI_ID && alert_settings.OPERATION_SETUP_ID == operation_setup.SETUP_ID && alert_settings.VALUE_TYPE_SETUP_ID == value_type_setup.SETUP_ID)) {
                                if (kpi.NAME == "Bylaw Complaints" && operation_setup.SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Alert Operation", "Drop")) {
                                    return;
                                }
                                const oAlert_settings = new Alert_settings();
                                oAlert_settings.ALERT_SETTINGS_ID = -1;
                                oAlert_settings.IS_ACTIVE = false;
                                oAlert_settings.KPI_ID = kpi.KPI_ID;
                                oAlert_settings.OPERATION_SETUP_ID = operation_setup.SETUP_ID;
                                oAlert_settings.VALUE_TYPE_SETUP_ID = value_type_setup.SETUP_ID;
                                oAlert_settings.USER_ID = this.CmSvc.oUser_Details.USER_ID;
                                oAlert_settings.VALUE = 0;
                                oAlert_settings.Kpi = kpi;
                                oAlert_settings.Operation_setup = operation_setup;
                                oAlert_settings.Value_type_setup = value_type_setup;
                                oList_Alert_settings.push(oAlert_settings);
                            }
                        });
                    });
                });
                resolve(oList_Alert_settings.filter(oAlert_settings => oList_Organization_data_source_kpi_with_alerts.some(oOrganization_data_source_kpi => oOrganization_data_source_kpi.KPI_ID == oAlert_settings.KPI_ID)));
            } else {
                this.proxy.Get_Alert_settings_By_USER_ID_Adv({
                    USER_ID: this.CmSvc.oUser_Details.USER_ID
                }).subscribe(result => {
                    this.CmSvc.oList_Alert_settings = result;
                    let oList_Alert_settings = cloneDeep(this.CmSvc.oList_Alert_settings);
                    var oList_Organization_data_source_kpi_with_alerts = this.CmSvc.oList_Organization_data_source_kpi.filter(oORGANIZATION_DATA_SOURCE_KPI_ID => oORGANIZATION_DATA_SOURCE_KPI_ID.Kpi.HAS_ALERTS);

                    const oList_Kpi_With_Alerts = oList_Organization_data_source_kpi_with_alerts.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi);
                    const oList_Alert_operation_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Operation").List_Setup;
                    const oList_Alert_value_type_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Value Type").List_Setup.filter(setup => setup.VALUE == "Tolerance");
                    oList_Kpi_With_Alerts.forEach(kpi => {
                        oList_Alert_operation_Setup.forEach(operation_setup => {
                            oList_Alert_value_type_Setup.forEach(value_type_setup => {
                                if (!oList_Alert_settings.some(alert_settings => alert_settings.KPI_ID == kpi.KPI_ID && alert_settings.OPERATION_SETUP_ID == operation_setup.SETUP_ID && alert_settings.VALUE_TYPE_SETUP_ID == value_type_setup.SETUP_ID)) {
                                    if (kpi.NAME == "Bylaw Complaints" && operation_setup.SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Alert Operation", "Drop")) {
                                        return;
                                    }
                                    const oAlert_settings = new Alert_settings();
                                    oAlert_settings.ALERT_SETTINGS_ID = -1;
                                    oAlert_settings.IS_ACTIVE = false;
                                    oAlert_settings.KPI_ID = kpi.KPI_ID;
                                    oAlert_settings.OPERATION_SETUP_ID = operation_setup.SETUP_ID;
                                    oAlert_settings.VALUE_TYPE_SETUP_ID = value_type_setup.SETUP_ID;
                                    oAlert_settings.USER_ID = this.CmSvc.oUser_Details.USER_ID;
                                    oAlert_settings.VALUE = 0;
                                    oAlert_settings.Kpi = kpi;
                                    oAlert_settings.Operation_setup = operation_setup;
                                    oAlert_settings.Value_type_setup = value_type_setup;
                                    oList_Alert_settings.push(oAlert_settings);
                                }
                            });
                        });
                    });
                    resolve(oList_Alert_settings.filter(oAlert_settings => oList_Organization_data_source_kpi_with_alerts.some(oOrganization_data_source_kpi => oOrganization_data_source_kpi.KPI_ID == oAlert_settings.KPI_ID)));
                });
            }
        })
    }

    Get_Alerts_For_Levels(i_Params_Get_Alerts_For_Levels: Params_Get_Alerts_For_Levels): Promise<Alert[]> {
        return new Promise(resolve => {
            if (this.oLast_Alert_Response && this.CmSvc.Are_Objects_Equal(this.oLast_Alert_Response?.Params_Get_Alerts_For_Levels, i_Params_Get_Alerts_For_Levels)) {
                resolve(this.oLast_Alert_Response.List_Alert);
            } else {
                this.proxy.Get_Alerts_For_Levels(i_Params_Get_Alerts_For_Levels).subscribe(result => {
                    result.forEach(alert => {
                        switch (alert.LEVEL_SETUP_ID) {
                            case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "district"):
                                alert.Object = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.find(district => district.DISTRICT_ID == alert.LEVEL_ID);
                                break;
                            case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "area"):
                                alert.Object = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.find(site => site.AREA_ID == alert.LEVEL_ID);
                                break;
                            case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "site"):
                                alert.Object = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.find(site => site.SITE_ID == alert.LEVEL_ID);
                                break;
                        }
                    });
                    this.oLast_Alert_Response = {
                        List_Alert: result,
                        Params_Get_Alerts_For_Levels: i_Params_Get_Alerts_For_Levels
                    };
                    resolve(result);
                });
            }
        });
    }

    Edit_Alert_settings_List(i_Params_Edit_Alert_settings_List: Params_Edit_Alert_settings_List): Promise<Params_Edit_Alert_settings_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Alert_settings_List(i_Params_Edit_Alert_settings_List).subscribe(result => {
                if (result) {
                    result.List_To_Delete.forEach(alert_settings_id => {
                        this.CmSvc.oList_Alert_settings.splice(this.CmSvc.oList_Alert_settings.findIndex(alert_settings => alert_settings.ALERT_SETTINGS_ID == alert_settings_id), 1);
                    });
                    this.CmSvc.oList_Alert_settings = this.CmSvc.oList_Alert_settings.filter(alert_settings => alert_settings.ALERT_SETTINGS_ID != -1);
                    result.List_To_Edit.forEach(alert_settings => {
                        const index = this.CmSvc.oList_Alert_settings.findIndex(oOrganization_districtnex_module => oOrganization_districtnex_module.ALERT_SETTINGS_ID == alert_settings.ALERT_SETTINGS_ID);
                        if (index == -1) {
                            this.CmSvc.oList_Alert_settings.push(alert_settings);
                        } else {
                            this.CmSvc.oList_Alert_settings[index] = alert_settings;
                        }
                    });

                    var oList_Organization_data_source_kpi_with_alerts = this.CmSvc.oList_Organization_data_source_kpi.filter(oORGANIZATION_DATA_SOURCE_KPI_ID => oORGANIZATION_DATA_SOURCE_KPI_ID.Kpi.HAS_ALERTS);
                    const oList_Kpi_With_Alerts = oList_Organization_data_source_kpi_with_alerts.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi);

                    const oList_Alert_operation_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Operation").List_Setup;
                    const oList_Alert_value_type_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Value Type").List_Setup.filter(setup => setup.VALUE == "Tolerance");
                    oList_Kpi_With_Alerts.forEach(kpi => {
                        oList_Alert_operation_Setup.forEach(operation_setup => {
                            oList_Alert_value_type_Setup.forEach(value_type_setup => {
                                if (kpi.NAME == "Bylaw Complaints" && operation_setup.SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Alert Operation", "Drop")) {
                                    return;
                                }
                                if (!this.CmSvc.oList_Alert_settings.some(alert_settings => alert_settings.KPI_ID == kpi.KPI_ID && alert_settings.OPERATION_SETUP_ID == operation_setup.SETUP_ID && alert_settings.VALUE_TYPE_SETUP_ID == value_type_setup.SETUP_ID)) {
                                    const oAlert_settings = new Alert_settings();
                                    oAlert_settings.ALERT_SETTINGS_ID = -1;
                                    oAlert_settings.IS_ACTIVE = false;
                                    oAlert_settings.KPI_ID = kpi.KPI_ID;
                                    oAlert_settings.OPERATION_SETUP_ID = operation_setup.SETUP_ID;
                                    oAlert_settings.VALUE_TYPE_SETUP_ID = value_type_setup.SETUP_ID;
                                    oAlert_settings.USER_ID = this.CmSvc.oUser_Details.USER_ID;
                                    oAlert_settings.VALUE = 0;
                                    oAlert_settings.Kpi = kpi;
                                    oAlert_settings.Operation_setup = operation_setup;
                                    oAlert_settings.Value_type_setup = value_type_setup;
                                    this.CmSvc.oList_Alert_settings.push(oAlert_settings);
                                }
                            });
                        });
                    });

                    this.CmSvc.Handle_Success();
                }
                resolve(result);
            });
        });
    }

    Acknowledge_Alert(i_Alert: Alert): Promise<void> {
        return new Promise(resolve => {
            i_Alert.IS_ACKNOWLEDGED = true;
            this.proxy.Edit_Alert_List({ List_Alert: [i_Alert] }).subscribe(() => {
                resolve();
            });
        });
    }

    Acknowledge_Alert_List(i_List_Alert: Alert[]): Promise<void> {
        return new Promise(resolve => {
            i_List_Alert.forEach(alert => {
                alert.IS_ACKNOWLEDGED = true;
            });
            this.proxy.Edit_Alert_List({ List_Alert: i_List_Alert }).subscribe(() => {
                resolve();
            });
        });
    }

    Get_Alerts_Count_For_Levels(i_Params_Get_Alerts_Count_For_Levels: Params_Get_Alerts_Count_For_Levels): Promise<number> {
        return new Promise(resolve => {
            this.proxy.Get_Alerts_Count_For_Levels(i_Params_Get_Alerts_Count_For_Levels).subscribe(result => {
                resolve(result);
            });
        });
    }

    Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List): Promise<Organization_data_source_kpi[]> {
        return new Promise(resolve => {
            if (this.oLast_Organization_data_source_kpi_Response && this.CmSvc.Are_Objects_Equal(this.oLast_Organization_data_source_kpi_Response?.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List, i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)) {
                resolve(this.oLast_Organization_data_source_kpi_Response.List_Organization_data_source_kpi);
            } else {
                this.proxy.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List).subscribe(result => {
                    resolve(result);
                });
            }
        });
    }

    Get_Latest_Wifi_signals(i_Floor: Floor): Promise<Wifi_signal[]> {
        return new Promise(resolve => {
            this.proxy.Get_Latest_Wifi_signals({
                SPACE_ID_LIST: null,
                FLOOR_ID: i_Floor.FLOOR_ID,
                NUMBER_OF_POINTS: 7,
                SPACE_ASSET_ID_LIST: null,
            }).subscribe(result => {
                this.oLatest_Wifi_signals_Behavior_subject.next(result);
                resolve(result);
            });
        });
    }

    Get_Latest_Wifi_signal_alerts(i_Floor: Floor, SPACE_ASSET_ID_LIST: number[] = null, NUMBER_OF_POINTS = 1): Promise<Wifi_signal_alert[]> {
        return new Promise(resolve => {
            this.proxy.Get_Latest_Wifi_signal_alerts({
                SPACE_ID_LIST: null,
                FLOOR_ID: i_Floor?.FLOOR_ID,
                NUMBER_OF_POINTS: NUMBER_OF_POINTS,
                SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST,
            }).subscribe(result => {
                resolve(result);
            });
        });
    }

    Update_Wifi_signal(i_Floor: Floor): Promise<Wifi_signal_data> {
        return new Promise(resolve => {
            this.proxy.Update_Wifi_signal({
                FLOOR_ID: i_Floor.FLOOR_ID,
            }).subscribe(result => {
                this.oLatest_Wifi_signals_Behavior_subject.next(result.WIFI_SIGNAL_LIST);
                resolve(result);
            });
        });
    }

    Get_Strongest_Wifi_signal(i_Top_level_id: number): Promise<Best_And_Worst_Object> {
        return new Promise(resolve => {
            this.proxy.Get_Strongest_Wifi_signal({
                TOP_LEVEL_ID: i_Top_level_id,
                START_DATE: this.oStart_Date_Filter?.toISOString(),
                END_DATE: null,
                FLOOR_ID_LIST: null,
                SPACE_ASSET_ID_LIST: null,
                SPACE_ID_LIST: null
            }).subscribe(result => {
                resolve(result);
            });
        })
    }

    Get_Most_Wifi_signal_Count_Per_Space_asset(i_Top_level_id: number): Promise<Best_And_Worst_Object> {
        return new Promise(resolve => {
            this.proxy.Get_Most_Wifi_signal_Count_Per_Space_asset({
                TOP_LEVEL_ID: i_Top_level_id,
                START_DATE: this.oStart_Date_Filter?.toISOString(),
                END_DATE: null,
                FLOOR_ID_LIST: null,
                SPACE_ASSET_ID_LIST: null,
                SPACE_ID_LIST: null
            }).subscribe(result => {
                resolve(result);
            });
        })
    }

    Upload_Share_File(i_Params_Upload_Share_File: Params_Upload_Share_File): Promise<string> {
        return new Promise(resolve => {
            this.proxyExt.Upload_Share_File(i_Params_Upload_Share_File).subscribe(response => {
                resolve(response?.body?.i_Result);
            });
        });
    }

    Send_Share_Link_By_Email(i_Params_Send_Share_Link_By_Email: Params_Send_Share_Link_By_Email): Promise<void> {
        return new Promise(resolve => {
            this.proxy.Send_Share_Link_By_Email(i_Params_Send_Share_Link_By_Email).subscribe(() => {
                resolve();
            });
        });
    }

    Edit_Entity_share_data(): Promise<string> {
        return new Promise(resolve => {
            this.proxy.Edit_Entity_share_data({
                Entity_share_data: this.oEntity_share_data
            }).subscribe(result => {
                resolve(result);
            });
        });
    }

    createGeoJSONCircle(center, radiusInKm, points = null) {
        if (!points) points = 64;

        var coords = {
            latitude: center[1],
            longitude: center[0]
        };

        var km = radiusInKm;

        var ret = [];
        var distanceX = km / (111.320 * Math.cos(coords.latitude * Math.PI / 180));
        var distanceY = km / 110.574;

        var theta, x, y;
        for (var i = 0; i < points; i++) {
            theta = (i / points) * (2 * Math.PI);
            x = distanceX * Math.cos(theta);
            y = distanceY * Math.sin(theta);

            ret.push([coords.longitude + x, coords.latitude + y]);
        }
        ret.push(ret[0]);

        return ret;
    };

    toggleCorrelationHeatmap() {
        this.oToggle_Correlation_Heatmap_Subject.next();
    }

    Set_View_Type(type: string = "district", id: number) {
        localStorage.setItem('view_type', type);
        localStorage.setItem('object_id', id.toString());
    }

    Get_View() {
        return localStorage.getItem('view_type');
    }

    Get_View_Type(): string[] {
        return [localStorage.getItem('view_type'), localStorage.getItem('object_id')];
    }

    Get_View_Type_Setup_From_Setup_Category_List_By_SETUP_ID(ID: number): Setup {
        return this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("View Type").List_Setup.find(setup => setup.SETUP_ID == ID);
    }

    ngOnDestroy() {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
        this.oApply_Filter_Subject.unsubscribe();
        this.oRecenter_Map_Subject.unsubscribe();
        this.oSite_Changed_Subject.unsubscribe();
        this.oArea_Changed_Subject.unsubscribe();
        this.oMarker_Opened_Subject.unsubscribe();
        this.oToggle_Border_Subject.unsubscribe();
        this.oAsset_Changed_Subject.unsubscribe();
        this.oFloor_Selected_Subject.unsubscribe();
        this.oEntity_Changed_Subject.unsubscribe();
        this.oToggle_Business_Subject.unsubscribe();
        this.oChange_Map_View_Subject.unsubscribe();
        this.oEntity_Incidents_Subject.unsubscribe();
        this.oShow_Hide_Mobility_Subject.unsubscribe();
        this.oShow_Hide_Entities_Subject.unsubscribe();
        this.oToggle_Public_event_Subject.unsubscribe();
        this.oToggle_Intersection_Subject.unsubscribe();
        this.oData_From_Filter_Loaded_Subject.unsubscribe();
        if (this._DRACOLoader) {
            this._DRACOLoader.dispose();
        }
    }
}
