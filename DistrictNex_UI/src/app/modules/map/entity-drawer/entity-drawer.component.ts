import { animate, state, style, transition, trigger } from '@angular/animations';
import { ChangeDetectorRef, Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges, ViewChild } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { LogsService } from 'app/core/Services/logs.service';
import { Dimension, Dimension_ID_By_Level_ID, Dimension_index_By_Level, Entity, Enum_Dimension_Status, Floor, Floor_Kpi_Dialog_Data, Params_Get_Floor_By_ENTITY_ID, Params_Get_Floor_Kpi_Dialog_Data, Params_Get_Latest_Dimension_index_By_Where, Space_asset, Wifi_signal, Wifi_signal_alert } from 'app/core/Services/proxy.service';
import { SignalrService } from 'app/core/Services/signalr.service';
import { MapService } from 'app/modules/map/map.service';
import { ViewShareService } from 'app/modules/view-share/view-share.service';
import { cloneDeep } from 'lodash';
import { Subject, takeUntil } from 'rxjs';
import { Box3, Vector3 } from 'three';
import { Entity_Dialog_input } from './../map.service';
import { BuildingRendererComponent } from './building-renderer/building-renderer.component';
import { BuildingSummaryComponent } from './building-summary/building-summary.component';
import { FloorRendererComponent } from './floor-renderer/floor-renderer.component';
import { FloorSummaryComponent } from './floor-summary/floor-summary.component';

@Component({
    selector: 'entity-drawer',
    templateUrl: './entity-drawer.component.html',
    styleUrls: ['./entity-drawer.component.scss'],
    animations: [
        trigger('closeOpenBuildingSelector', [
            state('true', style({ width: '14%' })),
            state('false', style({ width: '*' })),
            transition('false <=> true', animate(400))
        ]),
        trigger('slideInOut', [
            transition(':enter', [
                style({ transform: 'translateX(100%)' }),
                animate('400ms ease-in', style({ transform: 'translateX(0%)' }))
            ]),
            transition(':leave', [
                animate('400ms ease-in', style({ transform: 'translateX(100%)' }))
            ])
        ])
    ]
})
export class EntityDrawerComponent implements OnInit, OnChanges, OnDestroy {

    @Input() isShareView = false;
    @Input() isEntitySummaryDrawerVisible = false;
    @Input() oEntity_Dialog_input: Entity_Dialog_input;

    @Output() CloseDrawerEventEmitter = new EventEmitter<void>();
    @Output() changeEntityEventEmitter = new EventEmitter<Entity>();
    @Output() UnpinEntityModalEventEmitter = new EventEmitter<number>();
    @Output() buildingSelectorChangeEventEmitter = new EventEmitter<void>();

    @ViewChild(FloorSummaryComponent) oFloorSummaryComponent: FloorSummaryComponent;
    @ViewChild(FloorRendererComponent) oFloorRendererComponent: FloorRendererComponent;
    @ViewChild(BuildingSummaryComponent) oBuildingSummaryComponent: BuildingSummaryComponent;
    @ViewChild(BuildingRendererComponent) oBuildingRendererComponent: BuildingRendererComponent;

    oSpace_asset: Space_asset;

    oLink: string;
    oFloor: Floor;
    oList_Floor: Floor[] = [];
    oList_Dimension_index_for_floors: Dimension_index_By_Level[] = [];
    oDimension_index_for_entity: Dimension_index_By_Level;
    oList_Wifi_signal: Wifi_signal[];
    oList_Wifi_signal_alert: Wifi_signal_alert[];
    oList_Wifi_signal_Space_asset: Space_asset[];
    oList_Floor_Kpi_Data: Floor_Kpi_Dialog_Data[] = [];

    oDimension: Dimension;

    isShowHeatmap = false;
    isChartsLoaded = false;
    isChangingFloor = false;
    isFillShareData = false;
    isAssetDataLoading = false;
    isShowBuildingSelector = true;
    isFloorChartDataLoaded = false;
    isFloorDimensionIndexFetched = false;
    isEntityDimensionIndexFetched = false;
    isExpandedFloorRendererVisible = false;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        private LogsService: LogsService,
        private SignalrService: SignalrService,
        private ViewShareService: ViewShareService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) { }

    ngOnInit() {
        if (this.isShareView) {
            this.isShowBuildingSelector = false;
        }

        if (!this.isShareView) {
            this.Get_Floor_By_ENTITY_ID().then(result => {
                if (result) {
                    this.Get_Floor_Latest_Dimension_Index_By_Where();
                    this.Get_Entity_Latest_Dimension_Index_By_Where();
                    this.isFloorChartDataLoaded = true;
                }
            });

            this.MapService.oFloor_Selected_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(floor => {
                this.changeFloor(floor);
            });

            this.SignalrService.Receive("Receive_data");
            this.SignalrService.dataSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(Message => {
                if (this.oFloor && Message == "Wifi Signals Updated") {
                    this.MapService.Update_Wifi_signal(this.oFloor).then(result => {
                        let space_asset = this.oSpace_asset;
                        this.oList_Wifi_signal = result.WIFI_SIGNAL_LIST;
                        this.oList_Wifi_signal_alert = result.WIFI_SIGNAL_ALERT_LIST;
                        this.oSpace_asset = null;
                        this._changeDetectorRef.detectChanges();
                        this.oSpace_asset = space_asset;
                        this._changeDetectorRef.detectChanges();
                        this.oSpace_asset = null;
                    });
                }
            });

            this.MapService.oAsset_Changed_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(space_asset => {
                this.changeAsset(space_asset);
            });
        } else {
            this.oList_Dimension_index_for_floors = this.ViewShareService.oEntity_share_view_data.List_Floor_Dimension_index;
            this.oDimension_index_for_entity = this.ViewShareService.oEntity_share_view_data.Entity_Dimension_index;
            this.oFloor = this.ViewShareService.oEntity_share_view_data.Entity.List_Floor.find(oFloor => oFloor.FLOOR_ID == this.ViewShareService.oEntity_share_view_data.FLOOR_ID);
            this.oList_Floor = this.oEntity_Dialog_input.ENTITY.List_Floor;
            this.oList_Wifi_signal = this.ViewShareService.oEntity_share_view_data.List_Floor_asset_Wifi_signal;
            this.isFloorChartDataLoaded = true;
            this.isFloorDimensionIndexFetched = true;
            this.isEntityDimensionIndexFetched = true;
            this.MapService.oChange_Floor_Renderer_Floor_Subject.next(this.oFloor);
            if (this.ViewShareService.oEntity_share_view_data.List_Floor_kpi_data) {
                this.updateWifiSignals(this.ViewShareService.oEntity_share_view_data.List_Floor_kpi_data);
            }
        }
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (!this.isShareView && changes["oEntity_Dialog_input"] && this.oEntity_Dialog_input.ENTITY && this.oEntity_Dialog_input.ENTITY.List_Floor && this.oEntity_Dialog_input.ENTITY.List_Floor.length > 0) {
            this.SignalrService.Receive("Receive_data");
            if (this.oFloor && this.oFloor != this.oEntity_Dialog_input.ENTITY.List_Floor[0]) {
                this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Exited Floor: " + this.oFloor.NAME + " In " + this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.find(entity => entity.ENTITY_ID == this.oFloor.ENTITY_ID).NAME,
                    this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Floor").SETUP_ID,
                    this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID,
                    null, this.oFloor.ENTITY_ID);
            }
            this.oFloor = this.oEntity_Dialog_input.ENTITY.List_Floor[0];
            this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Floor: " + this.oFloor.NAME + " In " + this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.find(entity => entity.ENTITY_ID == this.oFloor.ENTITY_ID).NAME,
                this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Floor").SETUP_ID,
                this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID,
                null, this.oFloor.ENTITY_ID);
            this.oEntity_Dialog_input.ENTITY.List_Floor = this.oEntity_Dialog_input.ENTITY.List_Floor.sort((a, b) => a.FLOOR_NUMBER - b.FLOOR_NUMBER);
            this.isFloorChartDataLoaded = true;
            this.MapService.oChange_Floor_Renderer_Floor_Subject.next(this.oFloor);
            if (this.oDimension) {
                this.Get_Floor_Kpi_Dialog_Data();
            }
        }
    }

    updateWifiSignals(i_List_Floor_Kpi_Dialog_Data: Floor_Kpi_Dialog_Data[]) {
        this.oList_Wifi_signal = i_List_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_LIST;
        this.oList_Wifi_signal_alert = i_List_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_ALERT_LIST;
        this.oList_Wifi_signal_Space_asset = [].concat(...this.oFloor.List_Space.map(space => space.List_Space_asset)).filter(space_asset => space_asset != null && space_asset.Asset.NAME == "Wifi Signal");
    }

    changeDimension(event: Dimension) {
        this.oDimension = event;
        this.Get_Floor_Kpi_Dialog_Data();
    }

    Get_Floor_Kpi_Dialog_Data() {
        if (this.isShareView) {
            return;
        }
        let oParams_Get_Floor_Kpi_Dialog_Data = new Params_Get_Floor_Kpi_Dialog_Data();
        var setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Building info");
        var oList_KPI_chart_configuration_Building_Info = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
        if (oList_KPI_chart_configuration_Building_Info) {
            var List_Entity_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.find(oOrganization_Data_Source_Kpi_ID => oOrganization_Data_Source_Kpi_ID.LEVEL_ID == this.oEntity_Dialog_input.ENTITY.ENTITY_ID)?.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
            List_Entity_Organization_data_source_kpi = List_Entity_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Building_Info.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
            oParams_Get_Floor_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = List_Entity_Organization_data_source_kpi.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
        }
        oParams_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID = this.oDimension.DIMENSION_ID;
        let site_id = this.oEntity_Dialog_input.ENTITY.SITE_ID;
        let oSite = this.CmSvc.oList_Accessible_Site.find(oSite => oSite.SITE_ID == site_id);
        if (oSite) {
            oParams_Get_Floor_Kpi_Dialog_Data.SITE_ID = oSite.SITE_ID;
        }
        oParams_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        oParams_Get_Floor_Kpi_Dialog_Data.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
        oParams_Get_Floor_Kpi_Dialog_Data.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
        oParams_Get_Floor_Kpi_Dialog_Data.FLOOR_ID = this.oFloor.FLOOR_ID;
        this.MapService.Get_Floor_Kpi_Dialog_Data(oParams_Get_Floor_Kpi_Dialog_Data).then(result => {
            if (result) {
                this.oList_Floor_Kpi_Data = result;
                if (result.length > 0) {
                    this.oList_Wifi_signal = result[0].WIFI_SIGNAL_LIST;
                    if (result[0].WIFI_SIGNAL_ALERT_LIST && result[0].WIFI_SIGNAL_ALERT_LIST.length > 0) {
                        this.oList_Wifi_signal_alert = result[0].WIFI_SIGNAL_ALERT_LIST;
                    }
                }
                else {
                    this.oList_Wifi_signal_alert = [];

                }
                this.oList_Wifi_signal_Space_asset = [].concat(...this.oFloor.List_Space.map(space => space.List_Space_asset)).filter(space_asset => space_asset != null && space_asset.Asset.NAME == "Wifi Signal");
            } else {
                this.oList_Wifi_signal = [];
                this.oList_Wifi_signal_alert = [];
                this.oList_Wifi_signal_Space_asset = [];
            }
        })
    }


    updateFloorSpaces(value: number) {
        if (this.oBuildingRendererComponent?.oScene) {
            this.oBuildingRendererComponent?.oList_Floor_With_GLTF.forEach(floorWithGltf => {
                var floorGltf = floorWithGltf.gltfData.scene;
                const orginialFloor = this.oBuildingRendererComponent.oOriginal_YPosition_For_All_Floors.find(originalPosition => originalPosition.floor == floorWithGltf.floor);
                floorGltf.position.set(0, orginialFloor.yPosition * value, 0);
            });
            if (this.oBuildingRendererComponent.oScene.children.find(child => child.name == "Main Scene")) {
                var bbox = new Box3().setFromObject(this.oBuildingRendererComponent.oScene.children.find(child => child.name == "Main Scene"));
                var size = bbox.getSize(new Vector3());
                this.oBuildingRendererComponent.oScene.children.find(child => child.name == "Main Scene").position.setY(-size.y / 2);
            }
        }
    }

    showOrHideAlerts(isShow: boolean) {
        if (isShow) {
            this.oBuildingRendererComponent.oList_Alert_With_GLTF.forEach(alertWithGltf => {
                this.oBuildingRendererComponent.oScene.children.find(child => child.name == "Main Scene").add(alertWithGltf.gltfData.scene);
            });
        } else {
            this.oBuildingRendererComponent.oList_Alert_With_GLTF.forEach(alertWithGltf => {
                this.oBuildingRendererComponent.oScene.children.find(child => child.name == "Main Scene").remove(alertWithGltf.gltfData.scene);
            });
        }
    }

    Close_Drawer() {
        this.CloseDrawerEventEmitter.emit();
    }

    toggleBuildingSelector() {
        this.isShowBuildingSelector = !this.isShowBuildingSelector;
        this.buildingSelectorChangeEventEmitter.emit();
    }

    changeEntity(i_Entity: Entity) {
        this.isFloorChartDataLoaded = false;
        this.oEntity_Dialog_input.ENTITY = i_Entity;
        this.Get_Floor_By_ENTITY_ID().then(result => {
            if (result) {
                this.Get_Floor_Latest_Dimension_Index_By_Where();
                this.Get_Entity_Latest_Dimension_Index_By_Where();
                this.isFloorChartDataLoaded = true;
            }
        });
        this.changeEntityEventEmitter.emit(i_Entity);
    }

    Get_Floor_By_ENTITY_ID(): Promise<boolean> {
        return new Promise(resolve => {
            let oParams_Get_Floor_By_ENTITY_ID = new Params_Get_Floor_By_ENTITY_ID();
            oParams_Get_Floor_By_ENTITY_ID.ENTITY_ID = this.oEntity_Dialog_input.ENTITY.ENTITY_ID;
            this.MapService.Get_Floor_By_ENTITY_ID_With_Space_Asset(oParams_Get_Floor_By_ENTITY_ID).then(result => {
                this.oList_Floor = result;
                this.oFloor = this.oList_Floor[0];
                this.oEntity_Dialog_input.ENTITY.List_Floor = result;
                if (this.oDimension) {
                    this.Get_Floor_Kpi_Dialog_Data();
                }
                resolve(true);
            });
        })
    }

    Get_Floor_Latest_Dimension_Index_By_Where() {
        let oParams_Get_Latest_Dimension_Index_By_Where = new Params_Get_Latest_Dimension_index_By_Where();
        oParams_Get_Latest_Dimension_Index_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "floor");
        oParams_Get_Latest_Dimension_Index_By_Where.LEVEL_SETUP_ID = data_level_setup_id;
        oParams_Get_Latest_Dimension_Index_By_Where.START_DATE = this.MapService.oStart_Date_Filter.toISOString();
        oParams_Get_Latest_Dimension_Index_By_Where.END_DATE = this.MapService.oEnd_Date_Filter.toISOString();
        let entity_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension => oLevel_Dimension.DATA_LEVEL_SETUP_ID == entity_level_setup_id && oLevel_Dimension.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_Dimension.LEVEL_ID_LIST.includes(this.oEntity_Dialog_input.ENTITY.ENTITY_ID));
        oParams_Get_Latest_Dimension_Index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID = this.oEntity_Dialog_input.ENTITY.List_Floor.map(oFloor => {
            let oDimension_id_by_level_id = new Dimension_ID_By_Level_ID();
            oDimension_id_by_level_id.LEVEL_ID = oFloor.FLOOR_ID;
            oDimension_id_by_level_id.LIST_DIMENSION_ID = oList_Level_Dimension_With_Status.map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
            return oDimension_id_by_level_id;
        })
        this.MapService.Get_Latest_Dimension_index_By_Where(oParams_Get_Latest_Dimension_Index_By_Where).then(result => {
            this.oList_Dimension_index_for_floors = result;
            this.isFloorDimensionIndexFetched = true;
        });
    }

    Get_Entity_Latest_Dimension_Index_By_Where() {
        let oParams_Get_Latest_Dimension_Index_By_Where = new Params_Get_Latest_Dimension_index_By_Where();
        oParams_Get_Latest_Dimension_Index_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        oParams_Get_Latest_Dimension_Index_By_Where.LEVEL_SETUP_ID = data_level_setup_id;
        oParams_Get_Latest_Dimension_Index_By_Where.START_DATE = this.MapService.oStart_Date_Filter.toISOString();
        oParams_Get_Latest_Dimension_Index_By_Where.END_DATE = this.MapService.oEnd_Date_Filter.toISOString();
        let entity_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension => oLevel_Dimension.DATA_LEVEL_SETUP_ID == entity_level_setup_id && oLevel_Dimension.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_Dimension.LEVEL_ID_LIST.includes(this.oEntity_Dialog_input.ENTITY.ENTITY_ID));
        let oDimension_id_by_level_id = new Dimension_ID_By_Level_ID();
        oDimension_id_by_level_id.LEVEL_ID = this.oEntity_Dialog_input.ENTITY.ENTITY_ID;
        oDimension_id_by_level_id.LIST_DIMENSION_ID = oList_Level_Dimension_With_Status.map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
        oParams_Get_Latest_Dimension_Index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID = [oDimension_id_by_level_id];
        this.MapService.Get_Latest_Dimension_index_By_Where(oParams_Get_Latest_Dimension_Index_By_Where).then(result => {
            this.oDimension_index_for_entity = result[0] ?? {
                LEVEL_ID: this.oEntity_Dialog_input.ENTITY.ENTITY_ID,
                LIST_DIMENSION_INDEX: [],
            };
            this.isEntityDimensionIndexFetched = true;
        });
    }

    changeFloor(i_Floor: Floor) {
        if (this.oFloor.FLOOR_ID != i_Floor.FLOOR_ID) {
            if (this.oFloor) {
                this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Exited Floor: " + this.oFloor.NAME + " In " + this.oEntity_Dialog_input.ENTITY.NAME,
                    this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Floor").SETUP_ID,
                    this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID,
                    null, this.oFloor.ENTITY_ID);
            }
            this.isChangingFloor = true;
            this.oSpace_asset = null;
            this.oFloor = i_Floor;
            this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Floor: " + i_Floor.NAME + " In " + this.oEntity_Dialog_input.ENTITY.NAME,
                this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Floor").SETUP_ID,
                this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID,
                null, i_Floor.ENTITY_ID);
            this.isChangingFloor = false;

            this.MapService.oChange_Floor_Renderer_Floor_Subject.next(this.oFloor);
            if (this.oDimension) {
                this.Get_Floor_Latest_Dimension_Index_By_Where();
                this.Get_Floor_Kpi_Dialog_Data();
            }
        }
    }

    changeAsset(i_Space_asset: Space_asset) {
        if (i_Space_asset && !this.oFloorSummaryComponent.oList_Selected_Assets.some(space_asset => space_asset.SPACE_ASSET_ID == i_Space_asset.SPACE_ASSET_ID)) {
            this.oSpace_asset = i_Space_asset;
            this._changeDetectorRef.detectChanges();
            this.oSpace_asset = null;
        } else {
            this.oSpace_asset = null;
        }
    }

    Open_Expanded_View() {
        this.isExpandedFloorRendererVisible = true;
    }

    Unpin_Modal() {
        this.UnpinEntityModalEventEmitter.emit(this.oEntity_Dialog_input.ENTITY.ENTITY_ID);
    }

    gatherShareData() {
        const oPrevious_Entity_share_data = cloneDeep(this.MapService.oEntity_share_data);
        this.MapService.oEntity_share_data.SHARING_USER_NAME = this.CmSvc.oUser_Details.FIRST_NAME + ' ' + this.CmSvc.oUser_Details.LAST_NAME;
        this.MapService.oEntity_share_data.DIMENSION_ID = this.oDimension.DIMENSION_ID;
        this.MapService.oEntity_share_data.ENTITY_ID = this.oEntity_Dialog_input.ENTITY.ENTITY_ID;
        this.MapService.oEntity_share_data.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        this.MapService.oEntity_share_data.FILTER_END_DATE = this.MapService.oEnd_Date_Filter.toISOString();
        this.MapService.oEntity_share_data.FILTER_START_DATE = this.MapService.oStart_Date_Filter.toISOString();
        this.MapService.oEntity_share_data.FLOOR_ID = this.oFloor.FLOOR_ID;
        this.MapService.oEntity_share_data.INCIDENT_CATEGORY_SETUP_ID = this.oBuildingSummaryComponent.oChosen_Alerts_Setup.SETUP_ID;
        this.MapService.oEntity_share_data.IS_ALERT = this.oBuildingSummaryComponent.tabIndex == 1;
        this.MapService.oEntity_share_data.IS_CAMERA_ONE_ON = this.oFloorSummaryComponent.isCamera1on;
        this.MapService.oEntity_share_data.IS_CAMERA_TWO_ON = this.oFloorSummaryComponent.isCamera2on;
        this.MapService.oEntity_share_data.IS_CAMERA_THREE_ON = this.oFloorSummaryComponent.isCamera3on;
        this.MapService.oEntity_share_data.LIST_FLOOR_ASSET_WIFI_SIGNAL = this.oFloorRendererComponent.oList_Wifi_signal;
        this.MapService.oEntity_share_data.LIST_FLOOR_CHART_WIFI_SIGNAL = this.oBuildingSummaryComponent.oList_Wifi_signal;
        if (this.MapService.oEntity_share_data.IS_ALERT) {
            switch (this.oBuildingSummaryComponent.oChosen_Alerts_Setup.VALUE) {
                case "Access Control":
                    this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                    break;
                case "Suspicious Behavior":
                    this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                    break;
                case "Fire Alarm":
                    this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                    break;
                case "Blacklisted Person":
                    this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                    break;
                case "Blacklisted Plate":
                    this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                    break;
                default:
                    this.MapService.oEntity_share_data.LIST_INCIDENT_ID = [];
                    break;
            }
        }
        this.MapService.oEntity_share_data.LIST_SUMMARY_SPACE_ASSET_ID = this.oFloorSummaryComponent.oList_Selected_Assets.map(space_asset => space_asset.SPACE_ASSET_ID).concat(this.oFloorSummaryComponent.oList_Wifi_signal_Space_asset.map(space_asset => space_asset.SPACE_ASSET_ID));
        this.MapService.oEntity_share_data.LIST_SUMMARY_WIFI_SIGNAL = this.oFloorSummaryComponent.oList_Wifi_signal;
        this.MapService.oEntity_share_data.LIST_WIFI_SIGNAL_ALERT_ID = this.oFloorSummaryComponent.oList_Wifi_signal_alert.map(wifi_signal_alert => wifi_signal_alert.WIFI_SIGNAL_ALERT_ID);
        this.MapService.oEntity_share_data.LIST_FLOOR_DIMENSION_INDEX = this.oList_Dimension_index_for_floors;
        this.MapService.oEntity_share_data.ENTITY_DIMENSION_INDEX = this.oDimension_index_for_entity;
        this.MapService.oEntity_share_data.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
        this.MapService.oEntity_share_data.IS_ENTITY_SUMMARY_DRAWER_VISIBLE = this.isEntitySummaryDrawerVisible;
        this.MapService.oFill_Data_From_Building_Summary_Drawer_Subject.next();
        let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        this.MapService.oEntity_share_data.LIST_ENTITY_LEVEL_DIMENSION_WITH_STATUS = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension => oLevel_Dimension.DATA_LEVEL_SETUP_ID == data_level_setup_id && oLevel_Dimension.LEVEL_ID_LIST.includes(this.oEntity_Dialog_input.ENTITY.ENTITY_ID));
        if (this.CmSvc.Are_Objects_Equal(oPrevious_Entity_share_data, this.MapService.oEntity_share_data)) {
            this.MapService.oEntity_share_data_Link_Subject.next(this.oLink);
        } else {
            this.MapService.Edit_Entity_share_data().then(result => {
                if (result) {
                    this.oLink = result;
                    this.MapService.oEntity_share_data_Link_Subject.next(this.oLink);
                } else {
                    this.MapService.oEntity_share_data_Link_Subject.next(null);
                }
            });
        }
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
