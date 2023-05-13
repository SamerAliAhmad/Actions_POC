import { animate, keyframes, style, transition, trigger } from '@angular/animations';
import { DatePipe, DecimalPipe } from '@angular/common';
import { ChangeDetectorRef, Component, HostListener, NgZone, OnDestroy, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ArcLayer } from '@deck.gl/layers';
import { MapboxLayer } from '@deck.gl/mapbox';
import { Enum_Map_view, openDistrictInsightSubject, polygonColors } from 'app/core/Models/constants';
import { Dimension_data, Preset_time } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Bylaw_Complaint, Dimension_ID_By_Level_ID, Dimension_index_By_Level, District, Entity, Enum_Dimension_Status, Enum_Timespan, Ext_study_zone, Ext_study_zone_With_Count, Floor, Niche_categories, Organization_Data, Params_Get_Business_List, Params_Get_Bylaw_Complaint_List, Params_Get_Latest_Dimension_index_By_Where, Params_Get_Latest_Visitor_Count_By_Where, Params_Get_Public_Event_List, Params_Get_User_Accessible_Data_With_Level_List, Params_Get_User_Accessible_Level_List, Params_Get_Visitor_Origins, Public_Event, Removed_extrusion, Site, Top_Level_Data, Top_level, Visitor_Count_By_Level } from 'app/core/Services/proxy.service';
import { slideInLeft, slideInRight } from 'app/shared/animations/slide';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { BdcWalkService } from 'bdc-walkthrough';
import { html, render } from 'lit-html';
import { cloneDeep, round } from 'lodash';
import { AnyLayer, FlyToOptions, GeoJSONSource, LngLatLike, Map, MercatorCoordinate, Popup } from 'mapbox-gl';
import { Subject, takeUntil } from 'rxjs';
import { DirectionalLight, HemisphereLight, Matrix4, PerspectiveCamera, Scene, Vector3 } from 'three';
import { GLTFLoader } from 'three/examples/jsm/loaders/GLTFLoader';
import { CSS2DObject, CSS2DRenderer } from 'three/examples/jsm/renderers/CSS2DRenderer';
import { MathUtils, Raycaster, Vector2 } from 'three/src/Three';
import { WebGLRenderer } from 'three/src/renderers/WebGLRenderer';
import { VideoAIService } from '../video-ai/video-ai.service';
import { EntityDialogComponent } from './entity-dialog/entity-dialog.component';
import { EventDetailsDialogComponent } from './event-details-dialog/event-details-dialog.component';
import { InfoModalComponent } from './info-modal/info-modal.component';
import { LevelDialogComponent } from './level-dialog/level-dialog.component';
import { Dialog_input, Entity_Dialog_input, MapService } from './map.service';

class View_Details {
    PITCH: number;
    BEARING: number;
    ZOOM: number;
    LATITUDE: number;
    LONGITUDE: number;
}

class Level_Open_Dialog {
    LEVEL_TYPE: string;
    OPEN_DIALOGS: number = 0;
}

class External_study_zone_details {
    LEVEL_ID: number;
    GeoJSON: string;
    List_Ext_Study_Zone_With_Count: Ext_study_zone_With_Count[];
    coordinates: [longitude: number, latitude: number];
    data_level_setup_id: number;
    preset_time: Preset_time;
    enum_timespan: Enum_Timespan;
}

class Level_Kpi_Drawer {
    view_type: string;
    level_id: number;
}

class Visitor_Heatmap_Details {
    view_type: string;
    level_id: number;
    upper_level_id: number
}
class Business_Heatmap_Details {
    view_type: string;
    level_id: number;
    upper_level_id: number
}
class Business_Pins_Details {
    view_type: string;
    level_id: number;
    upper_level_id: number
}

@Component({
    selector: 'map',
    templateUrl: './map.component.html',
    styleUrls: ['./map.component.scss'],
    animations: [
        trigger('bubbleGrow', [
            transition(':enter', [
                animate('250ms ease-in-out', keyframes([
                    style({ transform: 'scale(0)' }),
                    style({ transform: 'scale(1.1)' }),
                    style({ transform: 'scale(1)' }),
                ]))
            ]),
            transition(':leave', [
                animate('250ms ease-in-out', keyframes([
                    style({ transform: 'scale(1)' }),
                    style({ transform: 'scale(1.1)' }),
                    style({ transform: 'scale(0)' })
                ]))
            ]),
        ]),
        trigger('labelAnimation', [
            transition(':enter', [
                style({ transform: 'translateY(-20px)', opacity: 0 }),
                animate('0.3s ease-in-out', style({ transform: 'translateY(0)', opacity: 1 })),
            ]),
            transition(':leave', [
                style({ transform: 'translateY(0)', opacity: 1 }),
                animate('0.3s ease-in-out', style({ transform: 'translateY(20px)', opacity: 0 })),
            ]),
        ]),
        slideInLeft,
        slideInRight,
        trigger('slideUp', [
            transition(':enter', [
                style({ transform: 'translateY(100%)' }),
                animate('300ms ease-out', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('300ms ease-out', style({ transform: 'translateY(100%)' }))
            ])
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
export class MapComponent implements OnInit, OnDestroy {

    iconWidth = 50;
    drawerWidth = 0;
    iconHeight = 50;
    chart_index = 0;
    hovered_Id = null;
    previous_filter_value = 0;
    secondsPerRevolution = 120;
    object_data_timeout_time = 200;

    CssClass;
    view_type: string;
    layer_name: string;
    hovered_Name: string;
    popupLogoUrl: string;
    GeoJSON_Source: string;
    iconRef = 'heroicons_outline:library';
    mapStyle = 'mapbox://styles/picacity/clduunc9x001k01qzemlan5eq';

    visitor_count: number;
    business_count: number;
    Data_Level_Setup_ID: number;
    max_number_of_visitors: number;
    max_number_of_businesses: number;

    level_location;
    Enum_Dimension_Status;
    oChosen_Dimension;
    oClicked_Level_Location;

    map: Map;
    oFloor: Floor;
    oCurrent_Area: Area;
    oCurrent_Site: Site;
    arc_layer: MapboxLayer;
    oCurrent_Entity: Entity;
    oScene_Modal_Details: any;
    oCurrent_District: District;
    oDialog_input: Dialog_input;
    oIntersection_Entity: Entity;
    oEnum_Map_view: Enum_Map_view;
    oCurrent_Top_level: Top_level;
    Enum_Map_view = Enum_Map_view;
    oEnd_Date_Filter: Date = null;
    oStart_Date_Filter: Date = null;
    oSelected_Preset_time: Preset_time;

    raycaster = new Raycaster();
    oCSS2DRenderer = new CSS2DRenderer();
    oParams_Get_User_Accessible_Data_With_LEVEL_LIST = new Params_Get_User_Accessible_Data_With_Level_List();

    oEntity_Dialog_Input: Entity_Dialog_input;
    oCurrent_Level_Kpi_Drawer_Level: Level_Kpi_Drawer;
    oDimension_index_for_entity: Dimension_index_By_Level;
    oEnum_Timespan_Filter: Enum_Timespan = Enum_Timespan.X_DAILY_COLLECTION;

    oToggled_Business_Pins_Details: Business_Pins_Details = { level_id: 0, view_type: '', upper_level_id: 0 };
    oToggled_Visitor_Heatmap_Details: Visitor_Heatmap_Details = { level_id: 0, view_type: '', upper_level_id: 0 };
    oToggled_Business_Heatmap_Details: Business_Heatmap_Details = { level_id: 0, view_type: '', upper_level_id: 0 };
    oView_Details: View_Details = { BEARING: -35.3881217667400850, PITCH: 41.2969558314925800, ZOOM: 14.3356711860891260, LATITUDE: 53.5391145752355700, LONGITUDE: -113.4953116236690700 };

    isIndexValuesLoaded: boolean;
    isOrganizationVisible: boolean;

    isDark = false;
    isSignedIn = false;
    changeOnce = false;
    isMapLoaded = false;
    isSpinEnabled = true;
    isInteractive = true;
    isChartsLoaded = false;
    isBordersVisible = true;
    isChangingFloor = false;
    isVideoDataLoaded = false;
    isUserInteracting = false;
    isFilterPanelOpen = false;
    isMapTransitioning = false;
    isBottomBarVisible = false;
    isAlertsDrawerOpen = false;
    isEntityDrawerOpen = false;
    isMarkerDialogOpen = false;
    isSiteClickEventOn = false;
    isAreaClickEventOn = false;
    isSelectionComplete = false;
    isVisitorDataFetched = false;
    isInsightsDrawerOpen = false;
    isSwitchStyleDisabled = false;
    isGlobalFilterVisible = false;
    isBusinessPinsVisible = false;
    isPublicEventsVisible = false;
    isSceneDetailsVisible = false;
    isVideoAIDrawerVisible = false;
    isTopLevelSelectorOpen = false;
    isIntersectionsVisible = false;
    isVisitorOriginsVisible = false;
    isLevelDialogDrawerOpen = false;
    isVisitorHeatmapVisible = false;
    isByLawComplaintVisible = false;
    isIntersectionDrawerOpen = false;
    isEnergyInsightPanelOpen = false;
    isBusinessHeatmapVisible = false;
    isDefaultBuildingsVisible = true;
    isPersistFilterPanelOpen = false;
    isEntitySummaryDrawerVisible = false;
    isExpandedFloorRendererVisible = false;

    oList_Kpi_data;
    oList_Site_Kpi_Data;
    oList_Area_Kpi_Data;
    oList_Action_Button;
    oList_Dimension_data;
    oList_Dimension_index;
    oList_Kpi_chart_configuration;
    oList_Level_Dimension_With_Status;

    oList_Area: Area[] = [];
    oList_Site: Site[] = [];
    oList_Popup: Popup[] = [];
    oList_Entity: Entity[] = [];
    oList_District: District[] = [];
    oList_Intersection: Entity[] = [];
    oList_Entity_Drawer: Entity[] = [];
    oList_get_object_data_timeout = [];
    oList_Preset_time: Preset_time[] = [];
    oList_Dialog_Input: Dialog_input[] = [];
    oList_Enum_Timespan: Enum_Timespan[];
    oList_Niche_categories: Niche_categories[] = [];
    oList_External_Study_zone: Ext_study_zone[] = [];
    oList_Level_Open_Dialog: Level_Open_Dialog[] = [];
    oList_Organization_Data: Organization_Data[] = [];
    oList_Removed_Extrusions: Removed_extrusion[] = [];
    oList_Entity_Dialog_input: Entity_Dialog_input[] = [];
    oList_Organization_Top_level_Data: Top_Level_Data[] = [];

    infoModaldialogRef: MatDialogRef<InfoModalComponent, any>;

    oPopup = new Popup({
        closeButton: false,
        closeOnClick: false,
        className: 'go-front'
    });
    oList_Image: {
        imageId: string,
        imageData: any,
        imageOptions: any,
    }[] = [];
    oHover_Popup = new Popup({
        closeButton: false,
        closeOnClick: false,
        className: 'go-front'
    });
    oExternal_Study_Zone_Details: External_study_zone_details = {
        GeoJSON: '',
        LEVEL_ID: null,
        List_Ext_Study_Zone_With_Count: null,
        coordinates: [null, null],
        data_level_setup_id: null,
        preset_time: null,
        enum_timespan: null,
    };
    oList_Scene_with_CSS2DObject: {
        Scene: Scene,
        CSS2Object: CSS2DObject;
    }[] = [];
    oList_Entity_Gltf_Scene: {
        Scene: Scene,
        Entity: Entity,
        Camera: PerspectiveCamera,
    }[] = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private NgZone: NgZone,
        private dialog: MatDialog,
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        private DecimalPipe: DecimalPipe,
        private BdcWalkService: BdcWalkService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
        private SmartrSplashScreenService: SmartrSplashScreenService,
    ) {
        this.SmartrSplashScreenService.show();
        this.oList_Preset_time = this.CmSvc.oList_Preset_time;
        this.oList_Niche_categories = this.CmSvc.oList_Niche_categories;
        this.oSelected_Preset_time = this.CmSvc.oList_Preset_time[0];
        this.oEnd_Date_Filter = new Date();
        this.oEnd_Date_Filter.setDate(this.oEnd_Date_Filter.getDate() - 1);
        this.oStart_Date_Filter = new Date();
        this.oStart_Date_Filter.setDate(this.oStart_Date_Filter.getDate() - this.oSelected_Preset_time.DAYS_BEHIND - 1);
        this.oEnum_Timespan_Filter = this.oSelected_Preset_time.ENUM_TIMESPAN_LIST[0];
        this.MapService.oEnd_Date_Filter = cloneDeep(this.oEnd_Date_Filter);
        this.MapService.oStart_Date_Filter = cloneDeep(this.oStart_Date_Filter);
        this.oStart_Date_Filter.setDate(this.oStart_Date_Filter.getDate() + 1);
        this.MapService.oEnum_Timespan_Filter = this.oEnum_Timespan_Filter;
        this.oList_Enum_Timespan = [...new Set([].concat(...this.CmSvc.oList_Preset_time.map(preset_time => preset_time.ENUM_TIMESPAN_LIST)))];
        this.isDark = this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-button'));
        if (this.CmSvc.oUser_Details.USER_TYPE_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("user type", "super admin")) {
            this.oList_Organization_Data = this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data.map(organization_with_top_level => organization_with_top_level.ORGANIZATION_DATA);
        }
        else {
            this.isSelectionComplete = true;
            this.CmSvc.oToggle_Module_Subject.next(this.isSelectionComplete);
        }
        let organization_ID = localStorage.getItem('organization_id');
        this.isOrganizationVisible = !(this.CmSvc.CheckString(organization_ID));
        if (!this.isOrganizationVisible) {
            this.Get_Top_Levels_For_Selected_Organization(Number.parseInt(organization_ID));
            this.iconRef = 'heroicons_outline:arrow-left';
        }
        let top_level_id, organization_id;
        organization_id = localStorage.getItem('organization_id');
        if (this.CmSvc.CheckString(organization_id)) {
            this.CmSvc.saved_organization_id = Number.parseInt(organization_id);
        }
        top_level_id = localStorage.getItem('top_level_id');
        if (this.CmSvc.CheckString(top_level_id)) {
            this.CmSvc.saved_top_level_id = Number.parseInt(top_level_id);
            this.CmSvc.Set_Application_Theme();
        }
        if (!this.CmSvc.CheckString(top_level_id) && !this.CmSvc.CheckString(organization_id)) {
            if (this.CmSvc.oUser_Details.USER_TYPE_SETUP_ID != this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("user type", "super admin")) {
                top_level_id = this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data[0].LIST_TOP_LEVEL_DATA[0].TOP_LEVEL_ID;
                organization_id = this.CmSvc.oUser_Details.ORGANIZATION_ID;
                localStorage.setItem('organization_id', organization_id);
                localStorage.setItem('top_level_id', top_level_id);
                this.CmSvc.saved_top_level_id = top_level_id;
                this.CmSvc.saved_organization_id = organization_id;
                this.CmSvc.Set_Application_Theme();
            }
        }
        if (top_level_id && organization_id) {
            this.isSelectionComplete = true;
            this.CmSvc.oToggle_Module_Subject.next(this.isSelectionComplete);
        }
        Object.values(Enum_Map_view).forEach((value) => {
            if (typeof value === 'string') {
                let oLevel_Open_Dialog = new Level_Open_Dialog();
                oLevel_Open_Dialog.LEVEL_TYPE = value;
                this.oList_Level_Open_Dialog.push(oLevel_Open_Dialog);
            }
        });
    }

    @HostListener('window:resize', ['$event'])
    getScreenSize(event?) {
        if (this.map) {
            this.map.resize();
            this.oCSS2DRenderer?.setSize(this.map.getCanvas().clientWidth, this.map.getCanvas().clientHeight);
        }
        let map_width = document.getElementById('map').offsetWidth;
        if (this.isAlertsDrawerOpen) {
            this.drawerWidth = map_width * 50 / 100;
        }
        if (this.isInsightsDrawerOpen) {
            this.drawerWidth = map_width * 80 / 100;
        }
        if (this.isLevelDialogDrawerOpen) {
            this.drawerWidth = map_width * 40 / 100;
        }
    }

    Set_Default_Current_Values() {
        let site_ID, area_ID, district_ID, entity_ID;
        site_ID = localStorage.getItem('site_id');
        if (this.CmSvc.CheckString(site_ID) && this.oList_Site && this.oList_Site.length > 0) {
            this.oCurrent_Site = this.oList_Site.find(oSite => oSite.SITE_ID == Number.parseInt(site_ID));
        }
        if (!this.oCurrent_Site && this.oList_Site && this.oList_Site.length > 0) {
            this.oCurrent_Site = this.oList_Site[0];
            localStorage.setItem('site_id', JSON.stringify(this.oCurrent_Site.SITE_ID))
        }
        area_ID = localStorage.getItem('area_id');
        if (this.CmSvc.CheckString(area_ID) && this.oList_Area && this.oList_Area.length > 0) {
            this.oCurrent_Area = this.oList_Area.find(oArea => oArea.AREA_ID == Number.parseInt(area_ID));
        }
        if (!this.oCurrent_Area && this.oList_Area && this.oList_Area.length > 0) {
            this.oCurrent_Area = this.oList_Area[0];
            localStorage.setItem('area_id', JSON.stringify(this.oCurrent_Area.AREA_ID))
        }
        district_ID = localStorage.getItem('district_id');
        if (this.CmSvc.CheckString(district_ID) && this.oList_District && this.oList_District.length > 0) {
            this.oCurrent_District = this.oList_District.find(oDistrict => oDistrict.DISTRICT_ID == Number.parseInt(district_ID));
        }
        if (!this.oCurrent_District && this.oList_District && this.oList_District.length > 0) {
            this.oCurrent_District = this.oList_District[0];
            localStorage.setItem('district_id', JSON.stringify(this.oCurrent_District.DISTRICT_ID))
        }
        entity_ID = localStorage.getItem('entity_id');
        if (this.CmSvc.CheckString(entity_ID) && this.oList_Entity && this.oList_Entity.length > 0) {
            this.oCurrent_Entity = this.oList_Entity.find(oEntity => oEntity.ENTITY_ID == Number.parseInt(entity_ID));
        }
        if (!this.oCurrent_Entity && this.oList_Entity && this.oList_Entity.length > 0) {
            this.oCurrent_Entity = this.oList_Entity[0];
            localStorage.setItem('entity_id', JSON.stringify(this.oCurrent_Entity.ENTITY_ID))
        }
    }

    Check_View_Type(): Promise<string> {
        return new Promise(resolve => {
            let view_type_setup_id = Number.parseInt(localStorage.getItem('view_type_setup_id'));
            if (view_type_setup_id) {
                this.view_type = this.CmSvc.Get_Data_Level_Setup_From_Setup_Category_List_By_SETUP_ID(view_type_setup_id).VALUE.toLowerCase();
                if (this.view_type == "entity") {
                    this.oEnum_Map_view = Enum_Map_view.entity;
                }
                if (this.view_type == "site") {
                    this.oEnum_Map_view = Enum_Map_view.site;
                }
                if (this.view_type == "area") {
                    this.oEnum_Map_view = Enum_Map_view.area;
                }
                if (this.view_type == "district") {
                    this.oEnum_Map_view = Enum_Map_view.district;
                }
                this.layer_name = `${this.view_type}_fill`;
            }
            resolve(this.view_type);
        })
    }

    Add_Primary_Source() {
        this[`add_${this.CmSvc.ToTitleCase(this.view_type)}_Source`]();
    }

    Add_Primary_Layers() {
        this[`add_${this.CmSvc.ToTitleCase(this.view_type)}_Border`]();
        this[`add_${this.CmSvc.ToTitleCase(this.view_type)}_Fill`]();
        if (this.oEnum_Map_view != Enum_Map_view.district && this.oEnum_Map_view != Enum_Map_view.entity) {
            if (!this[`is${this.CmSvc.ToTitleCase(this.view_type)}ClickEventOn`]) {
                this.Add_Level_Click_Event();
            }
        }
        this.Add_Intersections_Click_Event();
        this.Reset_Public_Events_Click_Event();
    }

    Add_Intersections_Click_Event() {
        this.map.on('click', 'intersection_entity', (e) => {
            this.oList_get_object_data_timeout.forEach(get_object_data_timeout => {
                clearTimeout(get_object_data_timeout);
            });
            let features = e.features;
            this.oList_get_object_data_timeout.push(setTimeout(() => {
                this.oIntersection_Entity = this.oList_Intersection.find(entity => entity.ENTITY_ID == features[0].id);
                this.isIntersectionDrawerOpen = true;
            }, this.object_data_timeout_time));
        });

        this.map.on('click', 'entity-bottom-extrusion', (e) => {
            this.oList_get_object_data_timeout.forEach(get_object_data_timeout => {
                clearTimeout(get_object_data_timeout);
            });
            this.oList_get_object_data_timeout.push(setTimeout(() => {
            }, this.object_data_timeout_time));
        })

        this.map.on('mousemove', 'entity-bottom-extrusion', (e) => {
            this.map.getCanvas().style.cursor = 'pointer';
            const coordinates = e.lngLat;
            const description = e.features[0].properties.description;
            while (Math.abs(e.lngLat.lng - coordinates[0]) > 180) {
                coordinates[0] += e.lngLat.lng > coordinates[0] ? 360 : -360;
            }
            this.oPopup.setLngLat(coordinates).setHTML(description).addTo(this.map);
        });

        this.map.on('mouseleave', 'entity-bottom-extrusion', () => {
            this.map.getCanvas().style.cursor = '';
            this.oPopup.remove();
        });
    }

    Reset_Public_Events_Click_Event() {
        this.map.off('click', 'public_events', this.Public_Event_Click_Event);
        this.map.on('click', 'public_events', this.Public_Event_Click_Event);
    }

    Public_Event_Click_Event = (e) => {
        this.oList_get_object_data_timeout.forEach(get_object_data_timeout => {
            clearTimeout(get_object_data_timeout);
        });
        this.oList_get_object_data_timeout.push(setTimeout(() => {
        }, this.object_data_timeout_time));
        this.dialog.open(EventDetailsDialogComponent, {
            width: '500px',
            autoFocus: false,
            hasBackdrop: false,
            disableClose: false,
            panelClass: 'dialog-container-no-padding',
            data: JSON.parse(e.features[0].properties.object)
        });
    }

    Add_Level_Click_Event() {
        this[`is${this.CmSvc.ToTitleCase(this.view_type)}ClickEventOn`] = true;
        this.map.on('click', this.view_type + '_fill', (event) => {
            const feature = event.features[0];
            const featureId = feature.id;
            this.oList_get_object_data_timeout.push(setTimeout(() => {
                let oLevel_Open_Dialog = this.oList_Level_Open_Dialog.find(_Level_Open_Dialog => _Level_Open_Dialog.LEVEL_TYPE == this.view_type);
                if (oLevel_Open_Dialog.OPEN_DIALOGS < 2) {
                    this[`oCurrent_${this.CmSvc.ToTitleCase(this.view_type)}`] = this[`oList_${this.CmSvc.ToTitleCase(this.view_type)}`].find(level_location => level_location[`${this.view_type.toUpperCase()}_ID`] == featureId);
                    this.oClicked_Level_Location = this[`oCurrent_${this.CmSvc.ToTitleCase(this.view_type)}`];
                    localStorage.setItem(this.view_type + '_id', this.oClicked_Level_Location[`${this.view_type.toUpperCase()}_ID`])
                    this.Open_Level_Kpi_Dialog(false);
                } else {
                    this.CmSvc.ShowMessage("Cannot open more than 2 of the same dialog type.", 1000);
                }
            }, this.object_data_timeout_time));
        });
    }

    Unpin_Modal(event: boolean) {
        this.drawerWidth = 0;
        this.isLevelDialogDrawerOpen = false;
        this.Open_Level_Kpi_Dialog(event);
    }

    Get_Entity_Intersection_List() {
        this.MapService.Get_Entity_Intersection_List().then(result => {
            if (result) {
                this.oList_Intersection = result;
                this.Add_Intersection_Layer();
            }
        })
    }

    Open_Level_Kpi_Dialog(isFromDrawer: boolean) {
        let oLevel_Open_Dialog = this.oList_Level_Open_Dialog.find(_Level_Open_Dialog => _Level_Open_Dialog.LEVEL_TYPE == this.view_type);
        if (!isFromDrawer) {
            this.oDialog_input = this.oList_Dialog_Input.find(oDialog_input => oDialog_input.level_id == this[`oCurrent_${this.CmSvc.ToTitleCase(this.view_type)}`][`${this.view_type.toUpperCase()}_ID`]);
        }
        else {
            this.oDialog_input = this.oList_Dialog_Input.find(oDialog_input => oDialog_input.level_id == this.oCurrent_Level_Kpi_Drawer_Level.level_id);
            this.oCurrent_Level_Kpi_Drawer_Level = null;
        }
        if (!this.oDialog_input) {
            this.oDialog_input = {
                properties: {
                    level_location: this.oClicked_Level_Location,
                    oEnum_Map_View: this.oEnum_Map_view,
                    Enum_Dimension_Status: this.Enum_Dimension_Status,
                    isIndexValuesLoaded: this.isIndexValuesLoaded,
                    chart_index: this.chart_index,
                    Current_view_type: this.view_type,
                    Data_Level_Setup_ID: this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.view_type),
                    oChosen_Dimension: this.oChosen_Dimension,
                    oList_Kpi_data: this.oList_Kpi_data,
                    oList_Dimension_data: this.oList_Dimension_data,
                    oList_Dimension_index: this.oList_Dimension_index,
                    oList_Site_Kpi_Data: this.oList_Site_Kpi_Data,
                    oList_Area_Kpi_Data: this.oList_Area_Kpi_Data,
                    oList_Kpi_chart_configuration: this.oList_Kpi_chart_configuration,
                    oList_Level_Dimension_With_Status: this.oList_Level_Dimension_With_Status,
                    oList_Action_Button: this.oList_Action_Button,
                    oClicked_Level_Location: this.oClicked_Level_Location,
                    upper_level_name: '',
                    grandfather_level_name: '',
                    grandfather_level_id: null
                },
                level_id: this[`oCurrent_${this.CmSvc.ToTitleCase(this.view_type)}`][`${this.view_type.toUpperCase()}_ID`],
            }
        }
        let num_open_dialogs = this.oList_Level_Open_Dialog.find(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.view_type).OPEN_DIALOGS;
        const dialogRef = this.dialog.open(LevelDialogComponent, {
            width: '600px',
            height: '700px',
            panelClass: 'pinned',
            position: {
                right: (num_open_dialogs == 1) ? '200px' : '120px',
                bottom: (num_open_dialogs == 1) ? '80px' : ''
            },
            hasBackdrop: false,
            disableClose: true,
            autoFocus: false,
            data: {
                minWidth: '600px',
                minHeight: '720px',
                view_type: this.view_type,
                oEnum_Map_view: this.oEnum_Map_view,
                input: this.oDialog_input
            }
        });
        if (!isFromDrawer) {
            this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oLevel_Open_Dialog)].OPEN_DIALOGS++;
        }
        dialogRef.afterClosed().subscribe(_ => {
            if (this.isLevelDialogDrawerOpen == false ||
                (this.oCurrent_Level_Kpi_Drawer_Level && dialogRef.componentInstance.oDialog_input.level_id != this.oCurrent_Level_Kpi_Drawer_Level.level_id
                    && Enum_Map_view[dialogRef.componentInstance.oDialog_input.properties.oEnum_Map_View] == this.view_type) ||
                (this.oCurrent_Level_Kpi_Drawer_Level && dialogRef.componentInstance.oDialog_input.level_id == this.oCurrent_Level_Kpi_Drawer_Level.level_id
                    && Enum_Map_view[dialogRef.componentInstance.oDialog_input.properties.oEnum_Map_View] == this.view_type &&
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oLevel_Open_Dialog)].OPEN_DIALOGS == 2)
            ) {
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oLevel_Open_Dialog)].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oLevel_Open_Dialog)].OPEN_DIALOGS--;
                }
                this.oDialog_input = null
                this.oList_Popup.forEach(popup => {
                    popup.remove();
                });
                this.oList_Popup = [];
                this.remove_Layer('arc');
                this.remove_Layer('visitor_heatmap');
                this.remove_Layer('ext_study_zone_fill');
                this.remove_Layer('ext_study_zone_border');
                this.remove_Layer('business_heatmap');
                this.remove_Layer('business_pins');
                this.remove_Layer('business_count');
                this.remove_Layer('businesses_clusters');
                if (this.map.getLayer(this.view_type + '_fill')) {
                    this.map.setPaintProperty(this.view_type + '_fill', 'fill-color', ['get', 'AREA_COLOR']);
                }
                this.oList_Popup.forEach(popup => {
                    popup.remove();
                });
                this.isVisitorHeatmapVisible = false;
                this.isBusinessHeatmapVisible = false;
                this.isBusinessPinsVisible = false;
                this.isVisitorOriginsVisible = false;
                this.MapService.oToggle_Action_Button_Subject.next(null);
            }
            else if (this.isLevelDialogDrawerOpen) {
                this.oCurrent_Level_Kpi_Drawer_Level = new Level_Kpi_Drawer();
                this.oCurrent_Level_Kpi_Drawer_Level.level_id = this[`oCurrent_${this.CmSvc.ToTitleCase(this.view_type)}`][`${this.view_type.toUpperCase()}_ID`];
                this.oCurrent_Level_Kpi_Drawer_Level.view_type = this.view_type;
            }
        });
        dialogRef.componentInstance.PinClickEventEmitter.subscribe(level_id => {
            this.isLevelDialogDrawerOpen = false;
            setTimeout(() => {
                let oDialog_input = this.oList_Dialog_Input.find(oDialog_input => oDialog_input.level_id == level_id && oDialog_input.properties.Current_view_type.toLowerCase() == this.view_type);
                if (!oDialog_input) {
                    oDialog_input = {
                        level_id: this[`oCurrent_${this.CmSvc.ToTitleCase(this.view_type)}`][`${this.view_type.toUpperCase()}_ID`],
                        properties: dialogRef.componentInstance.oDialog_input.properties
                    }
                    this.oList_Dialog_Input.push(oDialog_input)
                }
                this.oDialog_input = oDialog_input;
                dialogRef.close();
                this.isLevelDialogDrawerOpen = true;
                this.isEntityDrawerOpen = false;
                localStorage.removeItem('pinned_entity_dialog');

                this.isInsightsDrawerOpen = false;
                this.isEnergyInsightPanelOpen = false;
                this.isExpandedFloorRendererVisible = false;
                this.isSceneDetailsVisible = false;
                this.isVideoAIDrawerVisible = false;
                this.isEntitySummaryDrawerVisible = false;
                this.isAlertsDrawerOpen = false;
                this.drawerWidth = document.getElementById('map').offsetWidth * 40 / 100;
            }, 200);

        })
    }

    getHeight() {
        if (document.getElementById('map') && document.getElementById('bottom-bar')) {
            return document.getElementById('map').offsetHeight - document.getElementById('bottom-bar').offsetHeight + 2;
        }
    }

    ngOnInit() {
        this.init_Map();

        openDistrictInsightSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isInsightsDrawerOpen = !this.isInsightsDrawerOpen;
            if (this.isInsightsDrawerOpen) {
                let map_width = document.getElementById('map').offsetWidth;
                this.drawerWidth = map_width * 80 / 100;
                if (this.isLevelDialogDrawerOpen) {
                    this.isLevelDialogDrawerOpen = false;
                    if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                        this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                    }
                }
                this.isEntityDrawerOpen = false;

                localStorage.removeItem('pinned_entity_dialog');

                this.isEnergyInsightPanelOpen = false;
                this.isExpandedFloorRendererVisible = false;
                this.isSceneDetailsVisible = false;
                this.isVideoAIDrawerVisible = false;
                this.isEntitySummaryDrawerVisible = false;
                this.isAlertsDrawerOpen = false;
            }
            else {
                this.drawerWidth = 0;
            }
        });

        this.CmSvc.oToggle_Alerts_Drawer_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isAlertsDrawerOpen = !this.isAlertsDrawerOpen;
            if (this.isAlertsDrawerOpen) {
                let map_width = document.getElementById('map').offsetWidth;
                this.drawerWidth = map_width * 50 / 100;
                if (this.isLevelDialogDrawerOpen) {
                    this.isLevelDialogDrawerOpen = false;
                    if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                        this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                    }
                }
                this.isEntityDrawerOpen = false;

                localStorage.removeItem('pinned_entity_dialog');

                this.isInsightsDrawerOpen = false;
                this.isEnergyInsightPanelOpen = false;
                this.isExpandedFloorRendererVisible = false;
                this.isSceneDetailsVisible = false;
                this.isVideoAIDrawerVisible = false;
                this.isEntitySummaryDrawerVisible = false;

            }
            else {
                this.drawerWidth = 0;
            }
        });

        this.Check_Map_Spin();
    }

    Check_Map_Spin() {
        if (!this.isSelectionComplete) {
            this.map.on('mousedown', () => {
                this.isUserInteracting = true;
            });
            this.map.on('mouseup', () => {
                this.isUserInteracting = false;
            });
            this.map.on('dragend', () => {
                this.isUserInteracting = false;
            });
            this.map.on('pitchend', () => {
                this.isUserInteracting = false;
            });
            this.map.on('rotateend', () => {
                this.isUserInteracting = false;
            });
            this.map.on('moveend', () => {
                this.isUserInteracting = false;
            });
            setInterval(() => {
                this.spin_Map();
            }, 1000 / 10);
        }
    }

    goBack() {
        this.isOrganizationVisible = true;
        localStorage.removeItem('organization_id');
        if (this.iconRef == 'heroicons_outline:arrow-left') {
            this.iconRef = 'heroicons_outline:library';
        }
    }

    Get_Map_Data() {
        this.MapService.Get_Initial_Top_Level_Data().then(result => {
            if (result) {
                this.isSpinEnabled = false;
                this.CmSvc.oToggle_Module_Subject.next(!this.isSpinEnabled);
                this.Enable_Map_Activity();
                this.oCurrent_Top_level = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL;
                this.oList_District = this.CmSvc.oList_Accessible_District;
                this.oList_Area = this.CmSvc.oList_Accessible_Area;
                this.oList_Site = this.CmSvc.oList_Accessible_Site;
                this.oList_Entity = this.CmSvc.oList_Accessible_Entity;
                this.GeoJSON_Source = result.GEOJSON_SRC;
                this.CmSvc.GeoJSON_Source = result.GEOJSON_SRC;
                this.oList_Removed_Extrusions = this.CmSvc.oUser_Accessible_Data.LIST_REMOVED_EXTRUSIONS;
                this.Set_Default_Current_Values();
                this.Check_View_Type().then(result => {
                    if (result) {
                        this.isBottomBarVisible = true;
                        this.isGlobalFilterVisible = true;
                        this._changeDetectorRef.detectChanges();
                    }
                });
                this.MapService.oRecenter_Map_Subject.next(false);
                this.Add_Primary_Source();
                this.Add_Primary_Layers();
                this.Get_Entity_Intersection_List();
                this.MapService.oApply_Filter_Subject.next();
                this.SmartrSplashScreenService.hide();
                this.Highlight_Hovered_Layer()
                this.Add_3d_Model(this[`oList_${this.CmSvc.ToTitleCase(this.view_type)}`], this.map).then(() => {
                    this.Set_Layer_Priority();
                });
                this.MapService.isDefaultBuildingsVisible$.subscribe(value => {
                    this.isDefaultBuildingsVisible = value;
                    this.toggleDefaultBuildingsVisibility();
                });
                this.MapService.isBordersVisible$.subscribe(value => {
                    this.isBordersVisible = value;
                    this.toggleBordersVisibility();
                });
                let pinned_entity_dialog = localStorage.getItem('pinned_entity_dialog');
                if (this.CmSvc.CheckString(pinned_entity_dialog)) {
                    pinned_entity_dialog = JSON.parse(pinned_entity_dialog);
                    let oEntity = this.oList_Entity.find(_Entity => _Entity.ENTITY_ID == pinned_entity_dialog[`entity_ID`])
                    if (oEntity) {
                        let oSite = this.oList_Site.find(oSite => oSite.SITE_ID == oEntity.SITE_ID);
                        this.oEntity_Dialog_Input = this.oList_Entity_Dialog_input.find(oEntity_Dialog_input => oEntity_Dialog_input.ENTITY.ENTITY_ID == this.oCurrent_Entity.ENTITY_ID);
                        if (!this.oEntity_Dialog_Input) {
                            this.oEntity_Dialog_Input = { ENTITY: oEntity, SITE: oSite, oList_Dimension_data: [] };
                            this.oList_Entity_Dialog_input.push(this.oEntity_Dialog_Input);
                        }
                        this.isEntityDrawerOpen = true;
                    }
                }
            }
        }).catch(_ => {
            if (this.CmSvc.oList_Accessible_districtnex_module.find(oModule => oModule.Districtnex_module.NAME.toLowerCase() == "video ai")) {
                this.router.navigateByUrl('/video-ai');
            }
            else if (this.CmSvc.oList_Accessible_districtnex_module.find(oModule => oModule.Districtnex_module.NAME.toLowerCase() == "reports")) {
                this.router.navigateByUrl('/reports');
            }
            else {
                this.router.navigateByUrl('/sign-out');
            }
        });
    }

    spin_Map() {
        const maxSpinZoom = 5;
        const slowSpinZoom = 3;
        const spinEnabled = this.isSpinEnabled;
        const zoom = this.map.getZoom();
        const center = this.map.getCenter();

        if (spinEnabled && !this.isUserInteracting && zoom < maxSpinZoom) {
            let distancePerSecond = (360 / this.secondsPerRevolution);

            if (zoom > slowSpinZoom) {
                const zoomDif = (maxSpinZoom - zoom) / (maxSpinZoom - slowSpinZoom);
                distancePerSecond *= zoomDif;
            }

            center.lng -= distancePerSecond;

            this.map.easeTo({
                center,
                duration: 1000,
                easing: n => n
            });
        }
    }

    selectOrganization(organization_ID: number) {
        this.oParams_Get_User_Accessible_Data_With_LEVEL_LIST.CHOSEN_ORGANIZATION_ID = organization_ID;
        let top_level_id = localStorage.getItem('top_level_id');
        if (this.CmSvc.CheckString(top_level_id)) {
            this.oParams_Get_User_Accessible_Data_With_LEVEL_LIST.TOP_LEVEL_ID = Number.parseInt(top_level_id);
        }
        this.Get_Top_Levels_For_Selected_Organization(organization_ID);
        this.iconRef = 'heroicons_outline:arrow-left'
        localStorage.setItem('organization_id', JSON.stringify(organization_ID));
        this.CmSvc.saved_organization_id = organization_ID;
        this.isOrganizationVisible = false;
    }

    Get_Top_Levels_For_Selected_Organization(organization_ID: number) {
        this.oList_Organization_Top_level_Data = this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data.find(organization_with_top_level => organization_with_top_level.ORGANIZATION_DATA.ORGANIZATION_ID == organization_ID).LIST_TOP_LEVEL_DATA;
    }

    Go_To_Initial_Top_Level(top_level_ID: number) {
        this.isTopLevelSelectorOpen = false;
        this.oParams_Get_User_Accessible_Data_With_LEVEL_LIST.TOP_LEVEL_ID = top_level_ID;
        let view_type_setup_id = localStorage.getItem('view_type_setup_id');
        if (this.CmSvc.CheckString(view_type_setup_id)) {
            this.oParams_Get_User_Accessible_Data_With_LEVEL_LIST.DATA_LEVEL_SETUP_ID = Number.parseInt(view_type_setup_id);
        }
        localStorage.setItem('top_level_id', JSON.stringify(top_level_ID))
        this.CmSvc.saved_top_level_id = top_level_ID;
        this.isSelectionComplete = true;
        this.CmSvc.Set_Application_Theme();
        this.Get_Map_Data();
    }

    Change_Top_Level(top_level_ID: number) {
        this.SmartrSplashScreenService.show();
        this.map.zoomTo(3);
        this.isTopLevelSelectorOpen = false;
        let oParams_Get_User_Accessible_Level_List = new Params_Get_User_Accessible_Level_List();
        oParams_Get_User_Accessible_Level_List.TOP_LEVEL_ID = top_level_ID;
        localStorage.setItem('top_level_id', JSON.stringify(top_level_ID));
        oParams_Get_User_Accessible_Level_List.LIST_USER_AREA_ID = this.CmSvc.oUser_Accessible_Data.LIST_USER_AREA_ID;
        oParams_Get_User_Accessible_Level_List.LIST_USER_DISTRICT_ID = this.CmSvc.oUser_Accessible_Data.LIST_USER_DISTRICT_ID;
        oParams_Get_User_Accessible_Level_List.LIST_USER_ENTITY_ID = this.CmSvc.oUser_Accessible_Data.LIST_USER_ENTITY_ID;
        oParams_Get_User_Accessible_Level_List.LIST_USER_SITE_ID = this.CmSvc.oUser_Accessible_Data.LIST_USER_SITE_ID;
        oParams_Get_User_Accessible_Level_List.LIST_USER_TOP_LEVEL_ID = this.CmSvc.oUser_Accessible_Data.LIST_USER_TOP_LEVEL_ID;
        oParams_Get_User_Accessible_Level_List.LIST_ORGANIZATION_AREA_ID = this.CmSvc.oUser_Accessible_Data.LIST_ORGANIZATION_AREA_ID;
        oParams_Get_User_Accessible_Level_List.LIST_ORGANIZATION_DISTRICT_ID = this.CmSvc.oUser_Accessible_Data.LIST_ORGANIZATION_DISTRICT_ID;
        oParams_Get_User_Accessible_Level_List.LIST_ORGANIZATION_ENTITY_ID = this.CmSvc.oUser_Accessible_Data.LIST_ORGANIZATION_ENTITY_ID;
        oParams_Get_User_Accessible_Level_List.LIST_ORGANIZATION_SITE_ID = this.CmSvc.oUser_Accessible_Data.LIST_ORGANIZATION_SITE_ID;
        oParams_Get_User_Accessible_Level_List.LIST_ORGANIZATION_TOP_LEVEL_ID = this.CmSvc.oUser_Accessible_Data.LIST_ORGANIZATION_TOP_LEVEL_ID;
        let view_type_setup_id = localStorage.getItem('view_type_setup_id');
        if (this.CmSvc.CheckString(view_type_setup_id)) {
            oParams_Get_User_Accessible_Level_List.DATA_LEVEL_SETUP_ID = Number.parseInt(view_type_setup_id);
        }
        let selected_view_type = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("data level").List_Setup.find(oSetup => oSetup.SETUP_ID == Number.parseInt(view_type_setup_id)).VALUE;
        let selected_level_id = Number.parseInt(localStorage.getItem(selected_view_type + '_id'));
        oParams_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID = selected_level_id;
        oParams_Get_User_Accessible_Level_List.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        oParams_Get_User_Accessible_Level_List.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
        oParams_Get_User_Accessible_Level_List.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
        this.MapService.Get_New_Top_Level_Data(oParams_Get_User_Accessible_Level_List).then(result => {
            if (result) {
                this.oCurrent_Top_level = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL;
                this.oList_District = this.CmSvc.oList_Accessible_District;
                this.oList_Area = this.CmSvc.oList_Accessible_Area;
                this.oList_Site = this.CmSvc.oList_Accessible_Site;
                this.oList_Entity = this.CmSvc.oList_Accessible_Entity;
                this.GeoJSON_Source = result.GEOJSON_SRC;
                this.CmSvc.GeoJSON_Source = result.GEOJSON_SRC;
                this.oList_Removed_Extrusions = this.CmSvc.oUser_Accessible_Data.LIST_REMOVED_EXTRUSIONS;
                this.Get_Entity_Intersection_List();
                this.Set_Default_Current_Values();
                this.Check_View_Type().then(result => {
                    if (result) {
                        this.MapService.oChange_Map_View_Subject.next(this.oEnum_Map_view);
                        this.isBottomBarVisible = true;
                        this.isGlobalFilterVisible = true;
                        this.MapService.oRecenter_Map_Subject.next(false);
                        this.SmartrSplashScreenService.hide();
                        this._changeDetectorRef.detectChanges();
                    }
                });
            }
        });
    }

    Remove_All_Current_Layers(): Promise<boolean> {
        return new Promise(resolve => {
            this.remove_Layer(`${Enum_Map_view[this.oEnum_Map_view]}_border`);
            this.remove_Layer(`${Enum_Map_view[this.oEnum_Map_view]}_fill`);
            this.map.removeSource(Enum_Map_view[this.oEnum_Map_view]);
            if (this[`oList_${this.CmSvc.ToTitleCase(Enum_Map_view[this.oEnum_Map_view])}`]) {
                this[`oList_${this.CmSvc.ToTitleCase(Enum_Map_view[this.oEnum_Map_view])}`].forEach(oLevel_Location => {
                    this.remove_Layer(`3d-${this.view_type}-${oLevel_Location[`${this.view_type.toUpperCase()}_ID`]}-buildings`)
                });
            }
            this.remove_Layer('intersection_entity');
            this.remove_Layer('entity-bottom-extrusion');
            this.remove_Layer('visitor_heatmap');
            this.remove_Layer('arc');
            this.remove_Layer('ext_study_zone_fill');
            this.remove_Layer('ext_study_zone_border');
            this.remove_Layer('business_count');
            this.remove_Layer('business_pins');
            this.remove_Layer('businesses_clusters');
            this.remove_Layer('business_heatmap');
            this.remove_Layer('bylawComplaintsxSymbols');
            this.remove_Layer('public_events');
            if (this.map.getSource('floorplan')) {
                this.map.removeSource('floorplan');
            }
            if (this.map.getSource('visitor_heatmap_source')) {
                this.map.removeSource('visitor_heatmap_source');
            }
            if (this.map.getSource('ext_study_zone')) {
                this.map.removeSource('ext_study_zone');
            }
            if (this.map.getSource('business_cluster')) {
                this.map.removeSource('business_cluster');
            }
            if (this.map.getSource('business')) {
                this.map.removeSource('business');
            }
            if (this.map.getSource('bylawComplaints')) {
                this.map.removeSource('bylawComplaints');
            }
            if (this.map.getSource('public_Events')) {
                this.map.removeSource('public_Events');
            }
            this.oList_Popup.forEach(oPopup => {
                oPopup.remove();
            })
            this.remove_Layer('public_events');
            this.isLevelDialogDrawerOpen = false;
            this.isEntityDrawerOpen = false;

            localStorage.removeItem('pinned_entity_dialog');

            this.isEnergyInsightPanelOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isSceneDetailsVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isInsightsDrawerOpen = false;
            this.isIntersectionDrawerOpen = false;
            this.isAlertsDrawerOpen = false;
            this.oList_Level_Open_Dialog.forEach(oLevel_Open_dialog => oLevel_Open_dialog.OPEN_DIALOGS = 0);
            this.drawerWidth = 0;
            this.dialog.closeAll();
            resolve(true);
        })
    }

    Enable_Map_Activity() {
        this.map.boxZoom.enable();
        this.map.scrollZoom.enable();
        this.map.dragPan.enable();
        this.map.dragRotate.enable();
        this.map.keyboard.enable();
        this.map.doubleClickZoom.enable();
        this.map.touchZoomRotate.enable();
    }

    Disable_Map_Activity() {
        this.map.boxZoom.disable();
        this.map.scrollZoom.disable();
        this.map.dragPan.disable();
        this.map.dragRotate.disable();
        this.map.keyboard.disable();
        this.map.doubleClickZoom.disable();
        this.map.touchZoomRotate.disable();
    }

    Highlight_Hovered_Layer() {
        this.map.on('mousemove', this.layer_name, (e) => {
            if (e.features.length > 0) {
                if (this.hovered_Id !== null) {
                    this.map.setFeatureState(
                        { source: this.view_type, id: this.hovered_Id },
                        { hover: false }
                    );
                }
                this.hovered_Id = e.features[0].id;
                this.hovered_Name = e.features[0].properties.name;
                this.map.setFeatureState(
                    { source: this.view_type, id: this.hovered_Id },
                    { hover: true }
                );
                if (this.isVisitorHeatmapVisible) {
                    let oList_level_location: any[];
                    if (this.oEnum_Map_view == Enum_Map_view.area) {
                        oList_level_location = this.oList_Area.filter(_Area => _Area.DISTRICT_ID == this.oToggled_Visitor_Heatmap_Details.upper_level_id);
                    }
                    if (this.oEnum_Map_view == Enum_Map_view.site) {
                        oList_level_location = this.oList_Site.filter(_Site => _Site.AREA_ID == this.oToggled_Visitor_Heatmap_Details.upper_level_id);
                    }
                    if (oList_level_location.some(level_location => level_location[`${this.view_type.toUpperCase()}_ID`] == e.features[0].id)) {
                        const coordinates = e.lngLat;
                        const description = e.features[0].properties.description;

                        while (Math.abs(e.lngLat.lng - coordinates[0]) > 180) {
                            coordinates[0] += e.lngLat.lng > coordinates[0] ? 360 : -360;
                        }
                        this.oHover_Popup.setLngLat(coordinates).setHTML(description).addTo(this.map);
                    }
                }
            }
        });
        this.map.on('mouseleave', this.layer_name, () => {
            if (this.hovered_Id !== null) {
                this.map.setFeatureState(
                    { source: this.view_type, id: this.hovered_Id },
                    { hover: false }
                );
            }
            this.oHover_Popup.remove();
            this.hovered_Id = null;
        });
    }

    Set_Map_Feature_State(map: Map, Source: string, ID: number, isSelected: boolean) {
        map.setFeatureState(
            { source: Source, id: ID },
            { selected: isSelected }
        );
    }

    getFiltersHeight() {
        const mapElement = document.getElementById('map');
        const bottomBarElement = document.getElementById('bottom-bar');
        let value = 800;
        if (this.isFilterPanelOpen && mapElement && bottomBarElement) {
            value = document.getElementById('map').offsetHeight - document.getElementById('bottom-bar').offsetHeight - 32;
        }
        if (value != this.previous_filter_value) {
            this.previous_filter_value = value;
            setTimeout(() => {
                this._changeDetectorRef.detectChanges();
            }, 0);
        }
        return value;
    }

    toggleFilterPanelPin() {
        this.isPersistFilterPanelOpen = !this.isPersistFilterPanelOpen;
    }

    fetchData(isResetTimespan = false) {
        this.oEnd_Date_Filter = new Date();
        this.oEnd_Date_Filter.setDate(this.oEnd_Date_Filter.getDate() - 1);
        this.oStart_Date_Filter = new Date();
        this.oStart_Date_Filter.setDate(this.oStart_Date_Filter.getDate() - this.oSelected_Preset_time.DAYS_BEHIND - 1);
        if (isResetTimespan) {
            this.oEnum_Timespan_Filter = this.oSelected_Preset_time.ENUM_TIMESPAN_LIST[0];
        }
        this.MapService.oEnd_Date_Filter = cloneDeep(this.oEnd_Date_Filter);
        this.MapService.oStart_Date_Filter = cloneDeep(this.oStart_Date_Filter);
        this.oStart_Date_Filter.setDate(this.oStart_Date_Filter.getDate() + 1);
        this.MapService.oEnum_Timespan_Filter = this.oEnum_Timespan_Filter;
        this.MapService.oApply_Filter_Subject.next();
        this.MapService.oUpdate_Alert_Count_Subject.next(0);
    }

    Close_All_Drawers(): Promise<boolean> {
        return new Promise(resolve => {
            this.isEntityDrawerOpen = false;

            localStorage.removeItem('pinned_entity_dialog');

            this.isEnergyInsightPanelOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isSceneDetailsVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isInsightsDrawerOpen = false;
            this.isIntersectionDrawerOpen = false;
            this.isAlertsDrawerOpen = false;
            this.drawerWidth = 0;
            resolve(true);
        })
    }

    Add_Visitor_Origin_Layer(GeoJSON_Data: string, oList_Ext_study_zone_With_Count: Ext_study_zone_With_Count[], coordinates) {
        this.oList_External_Study_zone = oList_Ext_study_zone_With_Count.map(oExt_Study_Zone_With_Count => oExt_Study_Zone_With_Count.EXT_STUDY_ZONE);
        let Arcs = [];
        let visitor_count_list: number[] = oList_Ext_study_zone_With_Count.map(oExt_Study_Zone_With_Count => oExt_Study_Zone_With_Count.COUNT);
        const max_visitors: number = Math.max(...visitor_count_list);
        const min_visitors: number = Math.min(...visitor_count_list);
        this.oList_External_Study_zone.forEach(oExternal_Study_zone => {
            let visitor_count = oList_Ext_study_zone_With_Count.find(oExt_study_Zone_With_Count => oExt_study_Zone_With_Count.EXT_STUDY_ZONE.EXT_STUDY_ZONE_ID == oExternal_Study_zone.EXT_STUDY_ZONE_ID).COUNT;
            let entry = {
                start: coordinates,
                end: [oExternal_Study_zone.LONGITUDE, oExternal_Study_zone.LATITUDE],
                width: 9 * (visitor_count - min_visitors) / (max_visitors - min_visitors) + 2,
                color: '#FF0000'
            }
            Arcs.push(entry)
        })
        let ext_study_zone_source = this.map.getSource('ext_study_zone') as GeoJSONSource;
        if (!ext_study_zone_source) {
            this.map.addSource('ext_study_zone', {
                type: 'geojson',
                data: JSON.parse(GeoJSON_Data)
            })
        }
        else if (GeoJSON_Data) {
            ext_study_zone_source.setData(JSON.parse(GeoJSON_Data))
        }
        if (!this.map.getLayer('ext_study_zone_border')) {
            this.map.addLayer({
                'id': 'ext_study_zone_border',
                'type': 'line',
                'source': 'ext_study_zone',
                'layout': {
                    'line-join': 'round',
                    'line-cap': 'round',
                    'visibility': this.isVisitorOriginsVisible ? 'visible' : 'none',
                },
                'paint': {
                    'line-color': ['get', 'BORDER_COLOR'],
                    'line-width': 4,
                    'line-opacity': 0.8
                },
            });
        }
        if (!this.map.getLayer('ext_study_zone_fill')) {
            this.map.addLayer({
                "id": 'ext_study_zone_fill',
                "source": 'ext_study_zone',
                "type": "fill",
                'paint': {
                    'fill-color': ['get', "AREA_COLOR"],
                    'fill-opacity': [
                        'case',
                        ['boolean', ['feature-state', 'hover'], false],
                        0.8,
                        ['boolean', ['feature-state', 'selected'], false],
                        0.8,
                        0.4
                    ]
                },
                layout: {
                    visibility: this.isVisitorOriginsVisible ? 'visible' : 'none'
                }
            });
        }
        this.remove_Layer('arc');
        let arcsData = [];
        this.arc_layer = new MapboxLayer({
            type: ArcLayer,
            id: 'arc',
            data: arcsData,
            pickable: false,
            visible: this.isVisitorOriginsVisible,
            getHeight: 0.15,
            color: '#00FF00',
            getWidth: arc => arc.width,
            getSourcePosition: arc => arc.start,
            getTargetPosition: arc => arc.end,

        });
        arcsData = Arcs
        this.arc_layer.setProps({
            data: Arcs,
        });
        this.map.addLayer(this.arc_layer);
        this.oList_Popup.forEach(popup => {
            popup.remove();
        });
        this.oList_Popup = [];
        oList_Ext_study_zone_With_Count.forEach(oExt_study_zone_With_Count => {
            let oPopup = new Popup({
                closeButton: false,
                closeOnClick: false,
                className: 'go-front'
            });
            let description = `
            <div class="flex flex-col flex-auto">
                <div class="flex flex-row border-b pb-1">
                    <img src="assets/images/site.svg" style="width:20px;height:20px;"\>
                    <div class="ml-1">
                        <div class="text-s font-semibold leading-tight text-smallTextColor">${oExt_study_zone_With_Count.EXT_STUDY_ZONE.NAME}</div>
                    </div>
                </div>
                <div class="flex text-md leading-none tracking-tight justify-center items-center mt-2 p-1">Number of Visitors: ${this.DecimalPipe.transform(oExt_study_zone_With_Count.COUNT)}</div>
            </div>
            `;
            oPopup.setLngLat([oExt_study_zone_With_Count.EXT_STUDY_ZONE.LONGITUDE, oExt_study_zone_With_Count.EXT_STUDY_ZONE.LATITUDE]).setHTML(description).addTo(this.map);
            this.oList_Popup.push(oPopup);
        })
    }

    Get_View_Type_Setup_By_SETUP_ID(SETUP_ID: number) {
        return this.MapService.Get_View_Type_Setup_From_Setup_Category_List_By_SETUP_ID(SETUP_ID);
    }

    Set_Layer_Priority() {
        // Move the border and fill layers below the default 3D buildings layer
        if (this.map.getLayer('default_3d_buildings')) {
            if (this.map.getLayer(this.view_type + '_fill')) {
                this.map.moveLayer(this.view_type + '_fill', "default_3d_buildings");
            }
            if (this.map.getLayer(this.view_type + '_border')) {
                this.map.moveLayer(this.view_type + '_border', "default_3d_buildings");
            }
            this[`oList_${this.CmSvc.ToTitleCase(this.view_type)}`].filter(level_location => level_location.SOLID_GLTF_URL).forEach(level_location => {
                if (this.map.getLayer(`3d-${this.view_type}-${level_location[`${this.view_type.toUpperCase()}_ID`]}-buildings`)) {
                    this.map.moveLayer(`3d-${this.view_type}-${level_location[`${this.view_type.toUpperCase()}_ID`]}-buildings`, 'default_3d_buildings');
                }
            });
            // Move each custom GLTF layer above the default 3D buildings layer
            this.map.getStyle().layers.forEach((layer) => {
                if (layer.id.startsWith("3d-")) {
                    this.map.moveLayer(layer.id, "default_3d_buildings");
                }
            });
        }
    }

    add_District_Source() {
        if (!this.map.getSource('district')) {
            this.map.addSource('district', {
                type: 'geojson',
                data: JSON.parse(this.GeoJSON_Source)
            });
        }
    }

    add_District_Border() {
        if (!this.map.getLayer('district_border')) {
            this.map.addLayer({
                'id': 'district_border',
                'type': 'line',
                'source': 'district',
                'layout': {
                    'line-join': 'round',
                    'line-cap': 'round',
                    'visibility': 'visible',
                },
                'paint': {
                    'line-color': ['get', 'BORDER_COLOR'],
                    'line-width': 4,
                    'line-opacity': 0.8
                },
            });
        }
    }

    add_District_Fill() {
        if (!this.map.getLayer('district_fill')) {
            this.map.addLayer({
                "id": "district_fill",
                "source": "district",
                "type": "fill",
                'paint': {
                    'fill-color': ['get', "AREA_COLOR"],
                    'fill-opacity': [
                        'case',
                        ['boolean', ['feature-state', 'hover'], false],
                        0.8,
                        0.4
                    ]
                }
            });
        }
    }

    add_Area_Source() {
        if (!this.map.getSource('area')) {
            this.map.addSource('area', {
                type: 'geojson',
                data: JSON.parse(this.GeoJSON_Source)
            });
        }
    }

    add_Area_Border() {
        if (!this.map.getLayer('area_border')) {
            this.map.addLayer({
                'id': 'area_border',
                'type': 'line',
                'source': 'area',
                'layout': {
                    'line-join': 'round',
                    'line-cap': 'round',
                    'visibility': 'visible',
                },
                'paint': {
                    'line-color': ['get', 'BORDER_COLOR'],
                    'line-width': 4,
                    'line-opacity': 0.8
                },
            });
        }
    }

    add_Area_Fill() {
        if (!this.map.getLayer('area_fill')) {
            this.map.addLayer({
                "id": "area_fill",
                "source": "area",
                "type": "fill",
                'paint': {
                    'fill-color': ['get', "AREA_COLOR"],
                    'fill-opacity': [
                        'case',
                        ['boolean', ['feature-state', 'hover'], false],
                        0.8,
                        0.4
                    ]
                }
            });
        }

    }

    add_Site_Source() {
        if (!this.map.getSource('site')) {
            this.map.addSource('site', {
                type: 'geojson',
                data: JSON.parse(this.GeoJSON_Source)
            });
        }
    }

    add_Site_Border() {
        if (!this.map.getLayer('site_border')) {
            this.map.addLayer({
                'id': 'site_border',
                'type': 'line',
                'source': 'site',
                'layout': {
                    'line-join': 'round',
                    'line-cap': 'round',
                    'visibility': 'visible',
                },
                'paint': {
                    'line-color': ['get', 'BORDER_COLOR'],
                    'line-width': 4,
                    'line-opacity': 0.8
                },
            });
        }
    }

    add_Site_Fill() {
        if (!this.map.getLayer('site_fill')) {
            this.map.addLayer({
                'id': 'site_fill',
                'type': 'fill',
                'source': 'site',
                'layout': {},
                'paint': {
                    'fill-color': ['get', "AREA_COLOR"],
                    'fill-opacity': [
                        'case',
                        ['boolean', ['feature-state', 'hover'], false],
                        1,
                        0.5
                    ]
                }
            });
        }
    }

    add_Entity_Source() {
        if (!this.map.getSource('entity')) {
            this.map.addSource('entity', {
                type: 'geojson',
                data: JSON.parse(this.GeoJSON_Source)
            });
        }
    }

    add_Entity_Border() {
        if (!this.map.getLayer('entity_border')) {
            this.map.addLayer({
                'id': 'entity_border',
                'type': 'line',
                'source': 'entity',
                'layout': {
                    'line-join': 'round',
                    'line-cap': 'round',
                    'visibility': 'visible',
                },
                'paint': {
                    'line-color': ['get', 'BORDER_COLOR'],
                    'line-width': 4,
                    'line-opacity': 0.8
                },
            });
        }
    }

    add_Entity_Fill() {
        if (!this.map.getLayer('entity_fill')) {
            this.map.addLayer({
                'id': 'entity_fill',
                'type': 'fill',
                'source': 'entity',
                'layout': {},
                'paint': {
                    'fill-color': ['get', "AREA_COLOR"],
                    'fill-opacity': [
                        'case',
                        ['boolean', ['feature-state', 'hover'], false],
                        1,
                        0.5
                    ]
                }
            });
        }
    }

    remove_Layer(layer_name: string) {
        if (this.map.getLayer(layer_name)) {
            this.map.removeLayer(layer_name);
        }
    }

    isEnumCollectionDisabled(i_Enum_Timespan: Enum_Timespan) {
        return !this.oSelected_Preset_time.ENUM_TIMESPAN_LIST.includes(i_Enum_Timespan);
    }

    getEnumCollectionValue(i_Enum_Timespan: Enum_Timespan) {
        switch (i_Enum_Timespan) {
            case Enum_Timespan.X_HOURLY_COLLECTION:
                return "Hourly";
            case Enum_Timespan.X_DAILY_COLLECTION:
                return "Daily";
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                return "Weekly";
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                return "Monthly";
            case Enum_Timespan.X_QUARTERLY_COLLECTION:
                return "Quarterly";
        }
    }

    resizeTextureToPowerOfTwo(texture) {
        const image = texture.image;
        const canvas = document.createElement("canvas");
        const ctx = canvas.getContext("2d");

        const width = MathUtils.ceilPowerOfTwo(image.width);
        const height = MathUtils.ceilPowerOfTwo(image.height);

        canvas.width = width;
        canvas.height = height;

        ctx.drawImage(image, 0, 0, width, height);

        const resizedTexture = texture.clone();
        resizedTexture.image = canvas;
        resizedTexture.needsUpdate = true;

        return resizedTexture;
    }


    resizeTexturesInGLTF(gltf) {
        gltf.scene.traverse((node) => {
            if (node.isMesh) {
                const materials = Array.isArray(node.material) ? node.material : [node.material];

                materials.forEach((material) => {
                    if (material.map) {
                        const resizedTexture = this.resizeTextureToPowerOfTwo(material.map);
                        material.map = resizedTexture;
                    }
                });
            }
        });
    }

    Add_3d_Model(oList_Level_Locations, map: Map): Promise<void> {
        return new Promise(resolve => {
            this.oList_Scene_with_CSS2DObject.forEach(scene_with_css2dobject => {
                scene_with_css2dobject.Scene.remove(scene_with_css2dobject.CSS2Object);
            });
            this.oList_Scene_with_CSS2DObject = [];
            const renderer = new WebGLRenderer({ canvas: map.getCanvas(), context: map.getCanvas().getContext("webgl") });
            renderer.autoClear = false;
            renderer.useLegacyLights = false;
            renderer.autoClearColor = false;
            const mapCanvas = map.getCanvas();
            const rendererCanvas = renderer.domElement;
            // Set the position of the renderer canvas to 'absolute',
            // and position it on top of the map canvas
            rendererCanvas.style.position = 'absolute';
            rendererCanvas.style.top = mapCanvas.offsetTop + 'px';
            rendererCanvas.style.left = mapCanvas.offsetLeft + 'px';
            // Set the z-index of the map canvas to 1, and the z-index
            // of the renderer canvas to 2, to ensure that the renderer
            // canvas is on top of the map canvas
            mapCanvas.style.zIndex = '1';
            rendererCanvas.style.zIndex = '2';
            const loader = new GLTFLoader();
            loader.setDRACOLoader(this.MapService.oDRACOLoader);
            this.oList_Entity_Gltf_Scene = [];

            if (this.oEnum_Map_view == Enum_Map_view.entity && this.oList_Entity && this.oList_Entity.length > 0) {
                this.Get_Latest_Dimension_Index_By_Where().then(result => {
                    oList_Level_Locations.filter(level_location => level_location.SOLID_GLTF_URL).forEach(level_location => {
                        const camera = new PerspectiveCamera(28, window.innerWidth / window.innerHeight, 0.1, 1e6);
                        const scene = new Scene();
                        const level_scene: AnyLayer = {
                            id: `3d-${this.view_type}-${level_location[`${this.view_type.toUpperCase()}_ID`]}-buildings`,
                            type: 'custom',
                            renderingMode: '3d',
                            onAdd: (map, gl) => {
                                const oDirectional_Light = new DirectionalLight();
                                const oHemisphere_Light = new HemisphereLight();
                                oDirectional_Light.intensity = 1;
                                oDirectional_Light.position.set(10, 10, 10);
                                oHemisphere_Light.groundColor.set(0x0f0e0d);
                                oHemisphere_Light.intensity = 5;
                                scene.add(oDirectional_Light);
                                scene.add(oHemisphere_Light);
                                loader.load(
                                    level_location.SOLID_GLTF_URL,
                                    (gltf) => {
                                        scene.add(gltf.scene);
                                        this.resizeTexturesInGLTF(gltf);
                                        if (this.oEnum_Map_view == Enum_Map_view.entity) {
                                            let oList_Dimension_index_by_level: Dimension_index_By_Level[];
                                            oList_Dimension_index_by_level = result
                                            let oDimension_index = oList_Dimension_index_by_level.find(oDimension_index_by_level => oDimension_index_by_level.LEVEL_ID == level_location.ENTITY_ID);
                                            let divToolTipBig = this.drawBigTooltip(level_location, oDimension_index);
                                            let popupAltBig = new CSS2DObject(divToolTipBig);
                                            popupAltBig.position.set(level_location.POPUL_ALT_X, level_location.POPUP_ALT_Y, level_location.POPUP_ALT_Z);
                                            scene.add(popupAltBig);
                                            this.oList_Scene_with_CSS2DObject.push({
                                                Scene: scene,
                                                CSS2Object: popupAltBig,
                                            });
                                            this.oList_Entity_Gltf_Scene.push({
                                                Camera: camera,
                                                Entity: level_location,
                                                Scene: scene,
                                            });
                                        }
                                    }
                                );
                            },
                            render: (gl, matrix) => {
                                const modelOrigin: LngLatLike = [level_location.GLTF_LONGITUDE, level_location.GLTF_LATITUDE] as LngLatLike;
                                const modelRotate = [level_location.ROTATIONX, level_location.ROTATIONY, level_location.ROTATIONZ];
                                const modelAsMercatorCoordinate = MercatorCoordinate.fromLngLat(modelOrigin, 0);
                                const modelTransform = {
                                    translateX: modelAsMercatorCoordinate.x,
                                    translateY: modelAsMercatorCoordinate.y,
                                    translateZ: modelAsMercatorCoordinate.z,
                                    rotateX: modelRotate[0],
                                    rotateY: modelRotate[1],
                                    rotateZ: modelRotate[2],
                                    scale: level_location.SCALE
                                };
                                const rotationX = new Matrix4().makeRotationAxis(new Vector3(1, 0, 0), modelTransform.rotateX);
                                const rotationY = new Matrix4().makeRotationAxis(new Vector3(0, 1, 0), modelTransform.rotateY);
                                const rotationZ = new Matrix4().makeRotationAxis(new Vector3(0, 0, 1), modelTransform.rotateZ);

                                const m = new Matrix4().fromArray(matrix);
                                const l = new Matrix4().makeTranslation(modelTransform.translateX, modelTransform.translateY, modelTransform.translateZ)
                                    .scale(new Vector3(modelTransform.scale, -modelTransform.scale, modelTransform.scale))
                                    .multiply(rotationX)
                                    .multiply(rotationY)
                                    .multiply(rotationZ);
                                camera.projectionMatrix = m.multiply(l);
                                renderer.resetState();
                                renderer.render(scene, camera);
                                if (this.oEnum_Map_view == Enum_Map_view.entity) {
                                    this.oCSS2DRenderer.render(scene, camera);
                                }
                                map.triggerRepaint();
                            },
                        };
                        map.addLayer(level_scene);
                        this.map = map;
                    });
                    this.Edit_Extruded_Buildings();
                    resolve();
                });
            }
            else {
                oList_Level_Locations.filter(level_location => level_location.SOLID_GLTF_URL).forEach(level_location => {
                    const camera = new PerspectiveCamera(28, window.innerWidth / window.innerHeight, 0.1, 1e6);
                    const scene = new Scene();
                    const level_scene: AnyLayer = {
                        id: `3d-${this.view_type}-${level_location[`${this.view_type.toUpperCase()}_ID`]}-buildings`,
                        type: 'custom',
                        renderingMode: '3d',
                        onAdd: (map, gl) => {
                            const oDirectional_Light = new DirectionalLight();
                            const oHemisphere_Light = new HemisphereLight();
                            oDirectional_Light.intensity = 1;
                            oDirectional_Light.position.set(10, 10, 10);
                            oHemisphere_Light.groundColor.set(0x0f0e0d);
                            oHemisphere_Light.intensity = 5;
                            scene.add(oDirectional_Light);
                            scene.add(oHemisphere_Light);
                            loader.load(
                                level_location.SOLID_GLTF_URL,
                                (gltf) => {
                                    scene.add(gltf.scene);
                                    this.resizeTexturesInGLTF(gltf);
                                }
                            );
                        },
                        render: (gl, matrix) => {
                            const modelOrigin: LngLatLike = [level_location.GLTF_LONGITUDE, level_location.GLTF_LATITUDE] as LngLatLike;
                            const modelRotate = [level_location.ROTATIONX, level_location.ROTATIONY, level_location.ROTATIONZ];
                            const modelAsMercatorCoordinate = MercatorCoordinate.fromLngLat(modelOrigin, 0);
                            const modelTransform = {
                                translateX: modelAsMercatorCoordinate.x,
                                translateY: modelAsMercatorCoordinate.y,
                                translateZ: modelAsMercatorCoordinate.z,
                                rotateX: modelRotate[0],
                                rotateY: modelRotate[1],
                                rotateZ: modelRotate[2],
                                scale: level_location.SCALE
                            };
                            const rotationX = new Matrix4().makeRotationAxis(new Vector3(1, 0, 0), modelTransform.rotateX);
                            const rotationY = new Matrix4().makeRotationAxis(new Vector3(0, 1, 0), modelTransform.rotateY);
                            const rotationZ = new Matrix4().makeRotationAxis(new Vector3(0, 0, 1), modelTransform.rotateZ);

                            const m = new Matrix4().fromArray(matrix);
                            const l = new Matrix4().makeTranslation(modelTransform.translateX, modelTransform.translateY, modelTransform.translateZ)
                                .scale(new Vector3(modelTransform.scale, -modelTransform.scale, modelTransform.scale))
                                .multiply(rotationX)
                                .multiply(rotationY)
                                .multiply(rotationZ);
                            camera.projectionMatrix = m.multiply(l);
                            renderer.resetState();
                            renderer.render(scene, camera);
                            if (this.oEnum_Map_view == Enum_Map_view.entity) {
                                this.oCSS2DRenderer.render(scene, camera);
                            }
                            map.triggerRepaint();
                        },
                    };
                    map.addLayer(level_scene);
                    this.map = map;
                });
                this.Edit_Extruded_Buildings();
                resolve();
            }
        })
    }

    drawBigTooltip = (entity: Entity, i_List_dimension_index: Dimension_index_By_Level) => {
        let divToolTip;
        let level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "entity");
        let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension => oLevel_Dimension.DATA_LEVEL_SETUP_ID == level_setup_id && oLevel_Dimension.LEVEL_ID_LIST.includes(entity.ENTITY_ID));
        const oList_Dimension_data = oList_Level_Dimension_With_Status.map(_level_dimension_with_status => {
            const oDimension_data = new Dimension_data();
            oDimension_data.LEVEL_DIMENSION_WITH_STATUS = _level_dimension_with_status;
            oDimension_data.Enum_Dimension_Status = _level_dimension_with_status.ENUM_DIMENSION_STATUS;
            oDimension_data.DIMENSION_ICON = _level_dimension_with_status.DIMENSION.ICON_URL;
            let oDimension_index = i_List_dimension_index?.LIST_DIMENSION_INDEX.find(_Dimension_index => _Dimension_index.DIMENSION_METADATA.DIMENSION_ID == _level_dimension_with_status.DIMENSION.DIMENSION_ID);
            if (oDimension_index) {
                oDimension_data.INDEX_VALUE = Math.round(oDimension_index.VALUE);
                oDimension_data.INDEX_COLOR = oDimension_data.INDEX_VALUE > (this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.HIGH_THRESHOLD ?? 66) ? 'bg-highIndexColor' : oDimension_data.INDEX_VALUE > (this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.LOW_THRESHOLD ?? 33) ? 'bg-averageIndexColor' : 'bg-lowIndexColor';
            } else {
                oDimension_data.INDEX_VALUE = 0;
                oDimension_data.INDEX_COLOR = 'bg-neutralIndexColor';
            }
            return oDimension_data;
        }).sort((a, b) => a.Enum_Dimension_Status - b.Enum_Dimension_Status);
        divToolTip = document.createElement('div');
        const myTemplate = (_) => html`
            <div class="mapboxgl-popup-content flex flex-col gap-1" style="background-color: transparent; box-shadow: none;">
                <div class="grid grid-cols-2 gap-1">
                ${oList_Dimension_data.map((dimension_data, i) =>
            html`<div style="cursor:pointer; position:relative; align-items:center; border-radius:5px; width: 50px; height:22px; background-color:white; border:1px solid black;"
                    class="flex flex-row ${[dimension_data.Enum_Dimension_Status == Enum_Dimension_Status.ENABLED ? 'cursor-pointer' : '',
                dimension_data.Enum_Dimension_Status == Enum_Dimension_Status.DISABLED ? 'opacity-60' : '',
                dimension_data.Enum_Dimension_Status != Enum_Dimension_Status.ENABLED ? 'cursor-auto' : '',
                dimension_data.Enum_Dimension_Status == Enum_Dimension_Status.HIDDEN ? 'bg-gray-600' : ''].join(' ')}">
                    <img src=${dimension_data.DIMENSION_ICON} style="width:15px;height:15px; margin-left:2px"\>    
                    <strong id="${entity.ENTITY_ID}_${dimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID}" class="ml-auto building-index-popup" style="margin-right:15px; color:black;">${dimension_data.Enum_Dimension_Status == Enum_Dimension_Status.HIDDEN ? "-" :
                    dimension_data.INDEX_VALUE}</strong>
                        ${dimension_data.Enum_Dimension_Status == Enum_Dimension_Status.HIDDEN ? '' : html`<div id="${entity.ENTITY_ID}_${dimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID}" class="building-index-color-popup" style="width:10px; background-color:${dimension_data.INDEX_VALUE > this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.HIGH_THRESHOLD ? '#22C55E' : dimension_data.INDEX_VALUE > this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.LOW_THRESHOLD ? '#F59E0B' : '#EF4444'}; height:22px; position:absolute; right:-1px; border:1px solid black; border-top-right-radius:5px; border-bottom-right-radius:5px;"></div>`}
                    </div>
                    `
        )}
                </div>
            </div>
            `;
        render(myTemplate('World'), divToolTip);
        divToolTip.id = 'metricsSmall' + entity.ENTITY_ID
        return divToolTip;
    }

    Open_Entity_Dialog(i_Entity: Entity, i_Site?: Site, isFromDrawer: boolean = false) {
        let oLevel_open_dialog: Level_Open_Dialog = this.oList_Level_Open_Dialog.find(_Level_Open_Dialog => _Level_Open_Dialog.LEVEL_TYPE == this.view_type);
        let level_dialog_index = this.oList_Level_Open_Dialog.indexOf(oLevel_open_dialog);
        this.oEntity_Dialog_Input = this.oList_Entity_Dialog_input.find(oEntity_Dialog_input => oEntity_Dialog_input.ENTITY.ENTITY_ID == this.oCurrent_Entity.ENTITY_ID);
        if (!this.oEntity_Dialog_Input) {
            this.oEntity_Dialog_Input = { ENTITY: i_Entity, SITE: i_Site, oList_Dimension_data: [] };
            this.oList_Entity_Dialog_input.push(this.oEntity_Dialog_Input)
        }
        this.BdcWalkService.setTaskCompleted('mapPopup1', true);
        const dialogRef = this.dialog.open(EntityDialogComponent, {
            width: '800px',
            height: '760px',
            panelClass: 'pinned',
            hasBackdrop: false,
            disableClose: true,
            autoFocus: false,
            data: {
                minWidth: '800px',
                minHeight: '720px',
                view_type: this.view_type,
                oEnum_Map_view: this.oEnum_Map_view,
                input: this.oEntity_Dialog_Input,
                upper_level: this.MapService.oUpper_Level
            }
        });
        if (!isFromDrawer) {
            this.oList_Level_Open_Dialog[level_dialog_index].OPEN_DIALOGS++;
        }
        dialogRef.componentInstance.oEntityDrawerPinEventEmitter.subscribe(result => {
            this.isEntityDrawerOpen = result;
            if (this.isEntityDrawerOpen) {
                localStorage.setItem('pinned_entity_dialog', JSON.stringify({ entity_ID: this.oCurrent_Entity.ENTITY_ID }));
                if (this.isLevelDialogDrawerOpen) {
                    this.isLevelDialogDrawerOpen = false;
                    if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                        this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                    }
                }
                this.oCurrent_Level_Kpi_Drawer_Level = new Level_Kpi_Drawer();
                this.oCurrent_Level_Kpi_Drawer_Level.view_type = this.view_type;
                this.oCurrent_Level_Kpi_Drawer_Level.level_id = this.oCurrent_Entity.ENTITY_ID;
                this.dialog.closeAll();
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == "entity")].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == "entity")].OPEN_DIALOGS--;
                }
                this.isInsightsDrawerOpen = false;
                this.isEnergyInsightPanelOpen = false;
                this.isExpandedFloorRendererVisible = false;
                this.isSceneDetailsVisible = false;
                this.isVideoAIDrawerVisible = false;
                this.isEntitySummaryDrawerVisible = false;
                this.isAlertsDrawerOpen = false;
            }

        });
        dialogRef.afterClosed().subscribe(_ => {
            if (!this.isEntityDrawerOpen) {
                if (this.oList_Level_Open_Dialog[level_dialog_index].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[level_dialog_index].OPEN_DIALOGS--;
                }
            }
        })
    }

    Get_Latest_Dimension_Index_By_Where(): Promise<Dimension_index_By_Level[]> {
        return new Promise(resolve => {
            let oParams_Get_Latest_Dimension_Index_By_Where = new Params_Get_Latest_Dimension_index_By_Where();
            oParams_Get_Latest_Dimension_Index_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
            let level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "entity");
            oParams_Get_Latest_Dimension_Index_By_Where.LEVEL_SETUP_ID = level_setup_id;
            oParams_Get_Latest_Dimension_Index_By_Where.START_DATE = this.oStart_Date_Filter.toISOString();
            oParams_Get_Latest_Dimension_Index_By_Where.END_DATE = this.oEnd_Date_Filter.toISOString();
            let oList_Dimension_id_by_level_id: Dimension_ID_By_Level_ID[] = [];
            oList_Dimension_id_by_level_id = this.oList_Entity.map(oEntity => {
                let oDimension_id_by_level_id = new Dimension_ID_By_Level_ID();
                let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(level_dimension => level_dimension.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && level_dimension.DATA_LEVEL_SETUP_ID == level_setup_id && level_dimension.LEVEL_ID_LIST.includes(oEntity.ENTITY_ID));
                oDimension_id_by_level_id.LEVEL_ID = oEntity.ENTITY_ID;
                oDimension_id_by_level_id.LIST_DIMENSION_ID = oList_Level_Dimension_With_Status.map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
                return oDimension_id_by_level_id;
            })
            oParams_Get_Latest_Dimension_Index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID = oList_Dimension_id_by_level_id;
            this.MapService.Get_Latest_Dimension_index_By_Where(oParams_Get_Latest_Dimension_Index_By_Where).then(result => {
                resolve(result);
            })
        })
    }

    Edit_Extruded_Buildings() {
        let filtered_removed_extrusions = this.oList_Removed_Extrusions.filter(removed_extrusion => removed_extrusion.Data_level_setup.VALUE.toLowerCase().includes(this.view_type.toLowerCase()) && this[`oList_${this.CmSvc.ToTitleCase(this.view_type)}`].some(level => level[`${this.view_type.toUpperCase()}_ID`] == removed_extrusion.LEVEL_ID));
        let isRemovedExtrusionsAvailable = filtered_removed_extrusions.length > 0;
        let list_filtered_removed_extrusions_id = filtered_removed_extrusions.map((removed_extrusion) => ['!=', ['id'], Number(removed_extrusion.EXTRUSION_IDENTIFIER)]);
        if (this.map.getLayer('default_3d_buildings')) {
            this.map.setFilter('default_3d_buildings', !isRemovedExtrusionsAvailable ? ['all'] : ['all', ...list_filtered_removed_extrusions_id]);
        }
    }

    Add_Default_Buildings() {
        if (!this.map.getLayer('default_3d_buildings')) {
            this.map.addLayer({
                id: "default_3d_buildings",
                source: "composite",
                type: "fill-extrusion",
                "source-layer": "building",
                layout: {
                    visibility: this.isDefaultBuildingsVisible ? 'visible' : 'none'
                },
                paint: {
                    'fill-extrusion-color': '#aaa',
                    'fill-extrusion-height': [
                        'interpolate',
                        ['linear'],
                        ['zoom'],
                        15,
                        0,
                        15.05,
                        ['get', 'height']
                    ],
                    'fill-extrusion-base': [
                        'interpolate',
                        ['linear'],
                        ['zoom'],
                        15,
                        0,
                        15.05,
                        ['get', 'min_height']
                    ],
                    'fill-extrusion-opacity': 0.6,
                },
            });
        }

    }

    toggleDefaultBuildingsVisibility() {
        if (this.map.getLayer('default_3d_buildings')) {
            if (this.isDefaultBuildingsVisible) {
                this.map.setLayoutProperty('default_3d_buildings', 'visibility', 'visible');
            }
            else {
                this.map.setLayoutProperty('default_3d_buildings', 'visibility', 'none');
            }
        }
    }

    toggleBordersVisibility() {
        let layer_name = this.view_type + "_border"
        if (this.map.getLayer(layer_name)) {
            if (this.isBordersVisible) {
                this.map.setLayoutProperty(layer_name, 'visibility', 'visible');
            }
            else {
                this.map.setLayoutProperty(layer_name, 'visibility', 'none');
            }
        }
    }


    closeOpenPanels() {
        this.Close_Entity_Drawer(null);
        this.Close_Insights_Drawer();
        this.Close_Alerts_Drawer();
        this.isEntityDrawerOpen = false;

        localStorage.removeItem('pinned_entity_dialog');

        this.isEnergyInsightPanelOpen = false;
        this.isExpandedFloorRendererVisible = false;
        this.isVideoAIDrawerVisible = false;
        this.isEntitySummaryDrawerVisible = false;

    }
    Close_Drawer(event: string) {
        this.remove_Layer('arc');
        this.remove_Layer('ext_study_zone_fill');
        this.remove_Layer('ext_study_zone_border');
        this.remove_Layer('visitor_heatmap');
        this.remove_Layer('business_heatmap');
        this.remove_Layer('business_pins');
        this.remove_Layer('business_count');
        this.remove_Layer('businesses_clusters');
        if (this.map.getLayer(this.view_type + '_fill')) {
            this.map.setPaintProperty(this.view_type + '_fill', 'fill-color', ['get', 'AREA_COLOR']);
        }
        this.oList_Popup.forEach(popup => {
            popup.remove();
        });
        this.isVisitorHeatmapVisible = false;
        this.isBusinessHeatmapVisible = false;
        this.isBusinessPinsVisible = false;
        this.isVisitorOriginsVisible = false;
        this.MapService.oToggle_Action_Button_Subject.next(null);
        this.drawerWidth = 0;
        this.isLevelDialogDrawerOpen = false;
        let oOpen_Dialog = this.oList_Level_Open_Dialog.find(oOpen_Dialog => oOpen_Dialog.LEVEL_TYPE.toLowerCase() == event.toLowerCase());
        if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oOpen_Dialog)].OPEN_DIALOGS > 0) {
            this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oOpen_Dialog)].OPEN_DIALOGS--;
        }
    }

    Close_Entity_Drawer(event) {
        this.drawerWidth = 0;
        this.isEntityDrawerOpen = false;
        let oOpen_Dialog = this.oList_Level_Open_Dialog.find(oOpen_Dialog => oOpen_Dialog.LEVEL_TYPE.toLowerCase() == "entity");
        if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oOpen_Dialog)].OPEN_DIALOGS > 0) {
            this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.indexOf(oOpen_Dialog)].OPEN_DIALOGS--;
        }
        localStorage.removeItem('pinned_entity_dialog');
    }

    Close_Insights_Drawer() {
        this.drawerWidth = 0;
        this.isInsightsDrawerOpen = false;
    }

    Close_Alerts_Drawer() {
        this.drawerWidth = 0;
        this.isAlertsDrawerOpen = false;
    }

    Unpin_Entity_Drawer(entity_id: number) {
        this.drawerWidth = 0;
        this.isEntityDrawerOpen = false;
        localStorage.removeItem('pinned_entity_dialog');
        let oEntity = this.oList_Entity.find(_Entity => _Entity.ENTITY_ID == entity_id);
        if (oEntity) {
            let oSite = this.oList_Site.find(_Site => _Site.SITE_ID == oEntity.SITE_ID);
            this.Open_Entity_Dialog(oEntity, oSite, true);
        }
    }

    Get_Business_List(level_id: number): Promise<boolean> {
        let Grouped_levels = [];
        let list_id: number[];
        switch (this.oEnum_Map_view) {
            case Enum_Map_view.area:
                let oArea = this.oList_Area.find(_Area => _Area.AREA_ID == level_id);
                Grouped_levels = this.oList_Area.filter(_Area => _Area.DISTRICT_ID == oArea.DISTRICT_ID);
                list_id = Grouped_levels.map(oArea => oArea.AREA_ID);
                break;
            case Enum_Map_view.site:
                let oSite = this.oList_Site.find(_Site => _Site.SITE_ID == level_id);
                Grouped_levels = this.oList_Site.filter(_Site => _Site.AREA_ID == oSite.AREA_ID);
                list_id = Grouped_levels.map(oSite => oSite.SITE_ID);
                break;
        }
        return new Promise(resolve => {
            let oParams_Get_Business_List = new Params_Get_Business_List();
            oParams_Get_Business_List.LEVEL_SETUP_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.view_type);
            oParams_Get_Business_List.LIST_LEVEL_ID = list_id;
            oParams_Get_Business_List.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
            this.MapService.Get_Business_List(oParams_Get_Business_List).then(result => {
                if (result) {
                    this.MapService.oList_Business = result;
                    resolve(true);
                }
            })
        })
    }

    Zoom_Out(): Promise<boolean> {
        return new Promise(resolve => {
            this.map.flyTo({
                center: [-90, 40],
                zoom: 2,
                pitch: 0,
                bearing: 0,
                speed: 5,
            });
            this.map.once('zoomend', () => {
                this.spin_Map();
                resolve(true);
            })
        })
    }

    changeImage() {
        if (!this.changeOnce) {
            this.popupLogoUrl = this.CmSvc.oDefaultSettings.DARK_SQUARE_LOGO_URL;
        } else {
            this.popupLogoUrl = 'assets/images/logo/picacity/logo-black-square.png';
        }
        this.changeOnce = true;
    }

    skipTutorial() {
        this.BdcWalkService.setTaskCompleted('introModal', true);
        this.BdcWalkService.setTaskCompleted('mapPopup1', true);
        this.BdcWalkService.setTaskCompleted('dialogPopup1', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup1', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup2', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup3', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup4', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup5', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup1', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup2', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup3', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup4', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup5', true);
        this.BdcWalkService.setTaskCompleted('reportPopup1', true);
        this.BdcWalkService.setTaskCompleted('reportPopup2', true);
        this.BdcWalkService.setTaskCompleted('reportPopup3', true);
        this.BdcWalkService.setTaskCompleted('videoPopup1', true);
        this.BdcWalkService.setTaskCompleted('videoPopup2', true);
        this.BdcWalkService.setTaskCompleted('levelSwitchPopup', true);
        this.BdcWalkService.setTaskCompleted('hoverPopup', true);
    }

    init_Map() {
        this.map = new Map({
            container: 'map',
            style: 'mapbox://styles/picacity/clduunc9x001k01qzemlan5eq',
            center: [-112.4194, 37.7749],
            zoom: 2,
            antialias: true,
            accessToken: 'pk.eyJ1IjoicGljYWNpdHkiLCJhIjoiY2w1dGdwbDZtMGcxNjNlcGs2dzRyZzgxNiJ9.MW-KRbD_RFfeSh_8tV1k1A',
            preserveDrawingBuffer: true,
        });
        this.map.on('load', () => {
            this.map.resize();
            setTimeout(() => {
                if (!this.isSelectionComplete) {
                    this.SmartrSplashScreenService.hide();
                }
            }, 300);
            this.isMapLoaded = true;
            this.Add_Default_Buildings();
            this.CmSvc.set_Map(this.map);
            this.MapService.oTop_Level_Changed_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(oTop_Level_Data => {
                this.Remove_All_Current_Layers().then(result => {
                    if (result) {
                        this.Change_Top_Level(oTop_Level_Data.TOP_LEVEL_ID);
                    }
                })
                this.dialog.closeAll();
                this.oList_Level_Open_Dialog.forEach(oLevel_open_dialog => {
                    oLevel_open_dialog.OPEN_DIALOGS = 0;
                });
            });
            if (this.isSelectionComplete) {
                this.MapService.oUpdate_Alert_Count_Subject.next(0);
                this.Get_Map_Data();
            } else {
                this.Disable_Map_Activity();
            }
            this.MapService.oOpen_Top_level_Selector_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe((result) => {
                this.isTopLevelSelectorOpen = result;
            });
            this.map.on('mousemove', 'bylawComplaintsxSymbols', (e) => {
                this.map.getCanvas().style.cursor = 'pointer';
                const coordinates = e.lngLat;
                const description = e.features[0].properties.description;
                while (Math.abs(e.lngLat.lng - coordinates[0]) > 180) {
                    coordinates[0] += e.lngLat.lng > coordinates[0] ? 360 : -360;
                }
                this.oPopup.setLngLat(coordinates).setHTML(description).addTo(this.map);
            });
            this.map.on('mouseleave', 'bylawComplaintsxSymbols', () => {
                this.map.getCanvas().style.cursor = '';
                this.oPopup.remove();
            });
            this.MapService.oToggle_Map_Style_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
                if (this.mapStyle == 'mapbox://styles/picacity/clduunc9x001k01qzemlan5eq') {
                    this.switchMapStyle('mapbox://styles/mapbox/satellite-streets-v12');
                    this.mapStyle = 'mapbox://styles/mapbox/satellite-streets-v12';
                }
                else {
                    this.switchMapStyle('mapbox://styles/picacity/clduunc9x001k01qzemlan5eq');
                    this.mapStyle = 'mapbox://styles/picacity/clduunc9x001k01qzemlan5eq';
                }
            });
            this.MapService.oChange_Map_View_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(result => {
                this.remove_Layer(`${Enum_Map_view[this.oEnum_Map_view]}_border`);
                this.remove_Layer(`${Enum_Map_view[this.oEnum_Map_view]}_fill`);
                this.remove_Layer('visitor_heatmap');
                this.remove_Layer('business_heatmap');
                this.remove_Layer('business_cluster');
                this.remove_Layer('business_count');
                this.remove_Layer('business_pins');
                this.isVisitorHeatmapVisible = false;
                this.isBusinessHeatmapVisible = false;
                this.isBusinessPinsVisible = false;
                this[`oList_${this.CmSvc.ToTitleCase(Enum_Map_view[this.oEnum_Map_view])}`].forEach(oLevel_Location => {
                    this.remove_Layer(`3d-${this.view_type}-${oLevel_Location[`${this.view_type.toUpperCase()}_ID`]}-buildings`)
                });
                this.oEnum_Map_view = result;
                this.view_type = Enum_Map_view[result]
                switch (this.view_type) {
                    case "area":
                        this.oCurrent_Area = this.oList_Area.find(oArea => oArea.AREA_ID == this.oCurrent_Site?.AREA_ID);
                        if (!this.oCurrent_Area) {
                            this.oCurrent_Area = this.oList_Area[0];
                        }
                        break;
                    case "site":
                        this.oCurrent_Site = this.oList_Site.find(oSite => oSite.SITE_ID == this.oCurrent_Entity?.SITE_ID);
                        if (!this.oCurrent_Site) {
                            this.oCurrent_Site = this.oList_Site[0];
                        }
                        break;
                }
                let view_type_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.view_type);
                localStorage.setItem('view_type_setup_id', JSON.stringify(view_type_setup_id));
                this.GeoJSON_Source = this.CmSvc.GeoJSON_Source;
                let layer_source = this.map.getSource(`${Enum_Map_view[result]}`);
                if (layer_source) {
                    (layer_source as GeoJSONSource).setData(JSON.parse(this.GeoJSON_Source))
                }
                else {
                    this.Add_Primary_Source();
                }
                this.Add_Primary_Layers();
                this.layer_name = this.view_type + "_fill"
                this.Highlight_Hovered_Layer();
                this.Add_3d_Model(this[`oList_${this.CmSvc.ToTitleCase(this.view_type)}`], this.map).then(_ => {
                    this.Set_Layer_Priority()
                });
                this.MapService.oRecenter_Map_Subject.next(false);
                this._changeDetectorRef.detectChanges();
            });
            this.map.on('style.load', (e) => {
                this.oList_Popup.forEach(oPopup => {
                    oPopup.remove();
                });
                this.Add_Primary_Source();
                this.Add_Primary_Layers();
                this.Add_Default_Buildings();
                this.Add_Intersection_Layer();
                this.Add_3d_Model(this[`oList_${this.CmSvc.ToTitleCase(this.view_type)}`], this.map).then(() => {
                    this.Set_Layer_Priority();
                });
                if (this.isPublicEventsVisible) {
                    this.isPublicEventsVisible = false;
                    this.remove_Layer('public_events');
                    this.MapService.oToggle_Public_event_Subject.next();
                }
                if (this.isBusinessHeatmapVisible) {
                    this.isBusinessHeatmapVisible = false;
                    this.MapService.oToggle_Business_Heatmap_Subject.next(this.oToggled_Business_Heatmap_Details);
                }
                if (this.isBusinessPinsVisible) {
                    this.isBusinessPinsVisible = false;
                    this.MapService.oToggle_Business_Pins_Subject.next(this.oToggled_Business_Pins_Details);
                }
                if (this.isVisitorOriginsVisible) {
                    this.isVisitorOriginsVisible = false;
                    this.oExternal_Study_Zone_Details.LEVEL_ID = null;
                    this.oExternal_Study_Zone_Details.preset_time = this.oSelected_Preset_time;
                    this.oExternal_Study_Zone_Details.enum_timespan = this.oEnum_Timespan_Filter;
                    this.Add_Visitor_Origin_Layer(this.oExternal_Study_Zone_Details.GeoJSON, this.oExternal_Study_Zone_Details.List_Ext_Study_Zone_With_Count, this.oExternal_Study_Zone_Details.coordinates)
                    this.MapService.oToggle_Visitor_Origins_Subject.next({ level_id: this.oExternal_Study_Zone_Details.LEVEL_ID, coordinates: this.oExternal_Study_Zone_Details.coordinates, data_level_setup_id: this.oExternal_Study_Zone_Details.data_level_setup_id });
                }
                if (this.isVisitorHeatmapVisible) {
                    this.isVisitorHeatmapVisible = false;
                    this.MapService.oToggle_Visitor_Heatmap_Subject.next({ level_id: this.oToggled_Visitor_Heatmap_Details.level_id, upper_level_id: this.oToggled_Visitor_Heatmap_Details.level_id, view_type: this.oToggled_Visitor_Heatmap_Details.view_type });
                }
                if (this.isByLawComplaintVisible) {
                    this.isByLawComplaintVisible = false;
                    this.remove_Layer('bylawComplaintsxSymbols');
                    this.MapService.oToggle_ByLaw_Complaint_Subject.next();
                }
                this.Highlight_Hovered_Layer();
                this.isSwitchStyleDisabled = false;
            });
            this.oCSS2DRenderer.setSize(this.map.getCanvas().clientWidth, this.map.getCanvas().clientHeight);
            this.oCSS2DRenderer.domElement.style.position = 'absolute';
            this.oCSS2DRenderer.domElement.id = 'toolTip';
            this.oCSS2DRenderer.domElement.style.top = '0';
            this.oCSS2DRenderer.domElement.style.zIndex = '10';
            this.map.getCanvasContainer().appendChild(this.oCSS2DRenderer.domElement);
            this.map.on('click', (e) => {
                if (this.oEnum_Map_view == Enum_Map_view.entity) {
                    this.oList_get_object_data_timeout.push(setTimeout(() => {
                        for (let entity_gltf_scene of this.oList_Entity_Gltf_Scene) {
                            var mouse = new Vector2();
                            mouse.x = (e.point.x / (this.map as any).transform.width) * 2 - 1;
                            mouse.y = 1 - (e.point.y / (this.map as any).transform.height) * 2;
                            const camInverseProjection = new Matrix4().copy(entity_gltf_scene.Camera.projectionMatrix).invert();
                            const cameraPosition = new Vector3().applyMatrix4(camInverseProjection);
                            const mousePosition = new Vector3(mouse.x, mouse.y, 1).applyMatrix4(camInverseProjection);
                            const viewDirection = mousePosition.clone().sub(cameraPosition).normalize();
                            this.raycaster.set(cameraPosition, viewDirection);
                            var intersects = this.raycaster.intersectObjects(entity_gltf_scene.Scene.children, true);
                            if (intersects.length) {
                                if (this.oList_Entity.some(oEntity => oEntity.ENTITY_ID == entity_gltf_scene.Entity.ENTITY_ID)) {
                                    this.oCurrent_Entity = entity_gltf_scene.Entity;
                                    this.oCurrent_Site = this.oList_Site.find(site => site.SITE_ID == entity_gltf_scene.Entity.SITE_ID);
                                    let oLevel_Open_Dialog = this.oList_Level_Open_Dialog.find(_Level_Open_Dialog => _Level_Open_Dialog.LEVEL_TYPE == this.view_type);
                                    if (oLevel_Open_Dialog.OPEN_DIALOGS < 2) {
                                        let entityFlyAnimationDuration = 0;
                                        if (round(this.map.getCenter().lng, 10) != round(entity_gltf_scene.Entity.List_Entity_view[0].LONGITUDE, 10)
                                            || round(this.map.getCenter().lat, 10) != round(entity_gltf_scene.Entity.List_Entity_view[0].LATITUDE, 10)
                                            || round(this.map.getZoom(), 10) != round(entity_gltf_scene.Entity.List_Entity_view[0].ZOOM, 10)
                                            || round(this.map.getBearing(), 10) != round(entity_gltf_scene.Entity.List_Entity_view[0].BEARING, 10)
                                            || round(this.map.getPitch(), 10) != round(entity_gltf_scene.Entity.List_Entity_view[0].PITCH, 10)) {
                                            entityFlyAnimationDuration = 1500;
                                            const entityFlyAnimation: FlyToOptions = {
                                                duration: entityFlyAnimationDuration,
                                                animate: true,
                                                center: [entity_gltf_scene.Entity.List_Entity_view[0].LONGITUDE, entity_gltf_scene.Entity.List_Entity_view[0].LATITUDE],
                                                essential: true,
                                                bearing: entity_gltf_scene.Entity.List_Entity_view[0].BEARING,
                                                pitch: entity_gltf_scene.Entity.List_Entity_view[0].PITCH,
                                                zoom: entity_gltf_scene.Entity.List_Entity_view[0].ZOOM,
                                            }
                                            this.map.flyTo(entityFlyAnimation);
                                        }
                                        localStorage.setItem('entity_id', JSON.stringify(entity_gltf_scene.Entity.ENTITY_ID))
                                        this.Open_Entity_Dialog(entity_gltf_scene.Entity, this.oCurrent_Site, false);
                                    }
                                    else {
                                        this.CmSvc.ShowMessage("Cannot open more than 2 of the same dialog type.", 1000);
                                    }
                                    e.preventDefault();
                                    break;
                                }
                            }
                        }
                    }, this.object_data_timeout_time));
                }
            });
            this.map.on('zoom', () => {
                let elementsSmall = []
                this.oList_Entity?.forEach(entity => {
                    var element = document.getElementById('metricsSmall' + entity.ENTITY_ID);
                    if (element != null) {
                        elementsSmall.push(element);
                    }
                });
                if (this.map.getZoom() < 13) {
                    if (elementsSmall.length > 0) {
                        elementsSmall.forEach(element => element.style.visibility = 'hidden');
                    }
                } else {
                    if (elementsSmall.length > 0) {
                        elementsSmall.forEach(element => element.style.visibility = 'visible');
                    }
                }
            });
        });
        this.CmSvc.oToggle_Change_Organization_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            this.Remove_All_Current_Layers();
            this.dialog.closeAll();
            this.Disable_Map_Activity();
            this.Zoom_Out().then(result => {
                if (result) {
                    this.isTopLevelSelectorOpen = false;
                    this.isVisitorHeatmapVisible = false;
                    this.isLevelDialogDrawerOpen = false;
                    this.isEntityDrawerOpen = false;

                    localStorage.removeItem('pinned_entity_dialog');

                    this.isEnergyInsightPanelOpen = false;
                    this.isExpandedFloorRendererVisible = false;
                    this.isSceneDetailsVisible = false;
                    this.isVideoAIDrawerVisible = false;
                    this.isEntitySummaryDrawerVisible = false;
                    this.isOrganizationVisible = true;
                    this.isSelectionComplete = false;
                    this.isSpinEnabled = true;
                    this.CmSvc.oToggle_Module_Subject.next(!this.isSpinEnabled);
                    this.isBottomBarVisible = false;
                    this.isGlobalFilterVisible = false;
                    this.oList_Area = [];
                    this.oList_Intersection = [];
                    this.oList_District = [];
                    this.oList_Site = [];
                    this.oList_Dialog_Input = [];
                    this.oList_Level_Open_Dialog = [];
                    Object.values(Enum_Map_view).forEach((value) => {
                        if (typeof value === 'string') {
                            let oLevel_Open_Dialog = new Level_Open_Dialog();
                            oLevel_Open_Dialog.LEVEL_TYPE = value;
                            this.oList_Level_Open_Dialog.push(oLevel_Open_Dialog);
                        }
                    });
                    this.oList_Entity = [];
                    this.CmSvc.oUser_Accessible_Level_List = null;
                    this.CmSvc.oUser_Accessible_Data = null;
                    this.secondsPerRevolution = 120;
                    localStorage.removeItem('top_level_id');
                    localStorage.removeItem('organization_id');
                    if (this.iconRef == 'heroicons_outline:arrow-left') {
                        this.iconRef = 'heroicons_outline:library';
                    }
                    this.isSpinEnabled = true;
                    this.Check_Map_Spin()
                }
            })
        })
        this.MapService.oLocation_Changed_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            if (data.level_location) {
                this.Set_Map_Feature_State(this.map, this.view_type, data.level_location[`${this.view_type.toUpperCase()}_ID`], false);
                this[`oCurrent_${this.CmSvc.toTitleCase(this.view_type)}`] = data.level_location;
                this.Set_Map_Feature_State(this.map, this.view_type, this[`oCurrent_${this.CmSvc.toTitleCase(this.view_type)}`][`${this.view_type.toUpperCase()}_ID`], true);
            }
            this.MapService.oRecenter_Map_Subject.next(true);
            if (this.isByLawComplaintVisible) {
                this.isByLawComplaintVisible = false;
                this.remove_Layer('bylawComplaintsxSymbols');
                this.MapService.oToggle_ByLaw_Complaint_Subject.next();
            }
            if (this.isPublicEventsVisible) {
                this.isPublicEventsVisible = false;
                this.remove_Layer('public_events');
                this.MapService.oToggle_Public_event_Subject.next();
            }
        });
        this.MapService.oToggle_Business_Heatmap_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            if (this.oToggled_Business_Heatmap_Details.upper_level_id == data.upper_level_id && data.view_type == this.oToggled_Business_Heatmap_Details.view_type) {
                this.isBusinessHeatmapVisible = !this.isBusinessHeatmapVisible;
            }
            else {
                this.isBusinessHeatmapVisible = true;
                this.oToggled_Business_Heatmap_Details.level_id = data.level_id;
                this.oToggled_Business_Heatmap_Details.upper_level_id = data.upper_level_id;
                this.oToggled_Business_Heatmap_Details.view_type = data.view_type;
            }
            if (this.isBusinessHeatmapVisible) {
                this.Get_Business_List(data.level_id).then(result => {
                    if (result) {
                        this.Add_Business_Heatmap_Source().then(result => {
                            if (result) {
                                if (!this.map.getLayer('business_heatmap')) {
                                    this.map.addLayer({
                                        id: "business_heatmap",
                                        type: "heatmap",
                                        source: "business",
                                        'paint': {
                                            'heatmap-weight': 1,
                                            'heatmap-intensity': 1,
                                            'heatmap-color': [
                                                'interpolate',
                                                ['linear'],
                                                ['heatmap-density'],
                                                0,
                                                'rgba(0,255,0,0)',
                                                0.2,
                                                'green',
                                                0.6,
                                                'yellow',
                                                1,
                                                'red'
                                            ],
                                            'heatmap-radius': 20,
                                            'heatmap-opacity': 1
                                        }
                                    });
                                } else {
                                    this.map.setLayoutProperty('business_heatmap', 'visibility', 'visible');
                                }
                            }
                        });
                    }
                })
            }
            else {
                if (this.map.getLayer('business_heatmap')) {
                    this.map.setLayoutProperty('business_heatmap', 'visibility', 'none');
                }
            }
        });
        this.MapService.oRecenter_Map_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(isFocused => {
            let Site_Main_View = this.oCurrent_Site?.List_Site_view?.find(site_view => this.Get_View_Type_Setup_By_SETUP_ID(site_view.VIEW_TYPE_SETUP_ID).VALUE == ("Main View"));
            let Area_Main_View = this.oCurrent_Area?.List_Area_view?.find(area_view => this.Get_View_Type_Setup_By_SETUP_ID(area_view.VIEW_TYPE_SETUP_ID).VALUE == ("Main View"));
            let District_Main_View = this.oCurrent_District?.List_District_view?.find(district_view => this.Get_View_Type_Setup_By_SETUP_ID(district_view.VIEW_TYPE_SETUP_ID).VALUE == ("Main View"));
            if (!this.isMapTransitioning) {
                let recenterAnimation: FlyToOptions = {};
                switch (this.oEnum_Map_view) {
                    case Enum_Map_view.entity:
                        if (!isFocused && this.oCurrent_Site && this.oCurrent_Entity.SITE_ID == this.oCurrent_Site.SITE_ID) {
                            recenterAnimation.center = [Site_Main_View.LONGITUDE, Site_Main_View.LATITUDE];
                            recenterAnimation.zoom = Site_Main_View.ZOOM;
                            recenterAnimation.pitch = Site_Main_View.PITCH;
                            recenterAnimation.bearing = Site_Main_View.BEARING;
                        } else {
                            recenterAnimation.center = [this.oCurrent_Entity.List_Entity_view[0].LONGITUDE, this.oCurrent_Entity.List_Entity_view[0].LATITUDE];
                            recenterAnimation.zoom = this.oCurrent_Entity.List_Entity_view[0].ZOOM;
                            recenterAnimation.pitch = this.oCurrent_Entity.List_Entity_view[0].PITCH;
                            recenterAnimation.bearing = this.oCurrent_Entity.List_Entity_view[0].BEARING;
                        }
                        break;
                    case Enum_Map_view.site:
                        let oArea = this.oList_Area.find(_Area => _Area.AREA_ID == this.oCurrent_Site.AREA_ID);
                        if (oArea) {
                            Area_Main_View = oArea.List_Area_view?.find(area_view => this.Get_View_Type_Setup_By_SETUP_ID(area_view.VIEW_TYPE_SETUP_ID).VALUE == ("Main View"));
                        }
                        if (!isFocused && this.oCurrent_Site && oArea) {
                            recenterAnimation.center = [Area_Main_View.LONGITUDE, Area_Main_View.LATITUDE];
                            recenterAnimation.zoom = Area_Main_View.ZOOM;
                            recenterAnimation.pitch = Area_Main_View.PITCH;
                            recenterAnimation.bearing = Area_Main_View.BEARING;
                        }
                        else if (Site_Main_View) {
                            recenterAnimation.center = [Site_Main_View.LONGITUDE, Site_Main_View.LATITUDE];
                            recenterAnimation.zoom = Site_Main_View.ZOOM;
                            recenterAnimation.pitch = Site_Main_View.PITCH;
                            recenterAnimation.bearing = Site_Main_View.BEARING;
                        }
                        break;
                    case Enum_Map_view.area:
                        if (!isFocused && this.oCurrent_District && this.oCurrent_Area.DISTRICT_ID == this.oCurrent_District.DISTRICT_ID) {
                            recenterAnimation.center = [District_Main_View.LONGITUDE, District_Main_View.LATITUDE];
                            recenterAnimation.zoom = District_Main_View.ZOOM;
                            recenterAnimation.pitch = District_Main_View.PITCH;
                            recenterAnimation.bearing = District_Main_View.BEARING;
                        } else {
                            recenterAnimation.center = [Area_Main_View.LONGITUDE, Area_Main_View.LATITUDE];
                            recenterAnimation.zoom = Area_Main_View.ZOOM;
                            recenterAnimation.pitch = Area_Main_View.PITCH;
                            recenterAnimation.bearing = Area_Main_View.BEARING;
                        }
                        break;
                    case Enum_Map_view.district:
                        recenterAnimation.center = [District_Main_View.LONGITUDE, District_Main_View.LATITUDE];
                        recenterAnimation.zoom = District_Main_View.ZOOM;
                        recenterAnimation.pitch = District_Main_View.PITCH;
                        recenterAnimation.bearing = District_Main_View.BEARING;
                        break;
                }
                this._changeDetectorRef.detectChanges();
                if (recenterAnimation) {
                    recenterAnimation.duration = 1000;
                    this.map.flyTo(recenterAnimation);
                }
            }
            if (this.isMapTransitioning) {
                this.CmSvc.ShowMessage('Transitioning, Please Wait.', 2000);
            }

        });
        this.MapService.oToggle_Business_Pins_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            this.map.loadImage('assets/images/map-business.png', (error, image) => {
                if (error) throw error;
                if (!this.map.hasImage('map-business')) {
                    this.map.addImage('map-business', image, { sdf: true });
                }
            })
            if (this.oToggled_Business_Pins_Details.upper_level_id == data.upper_level_id && this.oToggled_Business_Pins_Details.view_type == data.view_type) {
                this.isBusinessPinsVisible = !this.isBusinessPinsVisible;
            }
            else {
                this.isBusinessPinsVisible = true;
                this.oToggled_Business_Pins_Details.level_id = data.level_id
                this.oToggled_Business_Pins_Details.view_type = data.view_type
                this.oToggled_Business_Pins_Details.upper_level_id = data.upper_level_id;
            }
            if (this.isBusinessPinsVisible) {
                this.Get_Business_List(this.oToggled_Business_Pins_Details.level_id).then(result => {
                    if (result) {
                        this.Add_Business_Pins_Source().then(result => {
                            if (result) {
                                if (!this.map.getLayer('business_pins')) {
                                    this.map.addLayer({
                                        "id": "business_pins",
                                        "source": "business_cluster",
                                        "type": "symbol",
                                        layout: {
                                            "icon-image": 'map-business',
                                            'icon-size': 0.15,
                                            'text-field': ['get', 'name'],
                                            'text-size': 12,
                                            'text-anchor': 'top',
                                            'text-offset': [0, 1.5],
                                        },
                                        paint: {
                                            'icon-color': ['get', 'pinColor'],
                                            'icon-opacity': [
                                                'interpolate',
                                                ['linear'],
                                                ['zoom'],
                                                15,
                                                0,
                                                16,
                                                1
                                            ],
                                            'text-opacity': [
                                                'interpolate',
                                                ['linear'],
                                                ['zoom'],
                                                15,
                                                0,
                                                16,
                                                1
                                            ]
                                        },
                                    });
                                }
                                else {
                                    this.map.setLayoutProperty('business_pins', 'visibility', 'visible');
                                }
                                if (!this.map.getLayer('businesses_clusters')) {
                                    this.map.addLayer({
                                        id: 'businesses_clusters',
                                        type: 'circle',
                                        source: 'business_cluster',
                                        filter: ['has', 'point_count'],
                                        paint: {
                                            'circle-color': 'white',
                                            'circle-radius': [
                                                'step',
                                                ['get', 'point_count'],
                                                20,
                                                100,
                                                30,
                                                850,
                                                40
                                            ],
                                            'circle-opacity': [
                                                'interpolate',
                                                ['linear'],
                                                ['zoom'],
                                                15,
                                                1,
                                                16,
                                                0
                                            ],
                                            'circle-stroke-color': 'black',
                                            'circle-stroke-width': 2
                                        },
                                    });
                                }
                                else {
                                    this.map.setLayoutProperty('businesses_clusters', 'visibility', 'visible');
                                }
                                if (!this.map.getLayer('business_count')) {
                                    this.map.addLayer({
                                        id: 'business_count',
                                        type: 'symbol',
                                        source: 'business_cluster',
                                        filter: ['has', 'point_count'],
                                        layout: {
                                            'text-field': ['get', 'point_count_abbreviated'],
                                            'text-font': ['DIN Offc Pro Medium', 'Arial Unicode MS Bold'],
                                            'text-size': 12,
                                        },
                                        paint: {
                                            'text-opacity': [
                                                'interpolate',
                                                ['linear'],
                                                ['zoom'],
                                                15,
                                                1,
                                                16,
                                                0
                                            ]
                                        }
                                    });
                                }
                                else {
                                    this.map.setLayoutProperty('business_count', 'visibility', 'visible');
                                }
                            }
                        });
                    }
                });

            }
            else {
                this.map.setLayoutProperty('business_pins', 'visibility', 'none');
                this.map.setLayoutProperty('businesses_clusters', 'visibility', 'none');
                this.map.setLayoutProperty('business_count', 'visibility', 'none');

            }
        });
        this.MapService.oOpen_Entity_Summary_Drawer_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(oDimension_index_for_entity => {
            this.oDimension_index_for_entity = oDimension_index_for_entity;
            this.isEntitySummaryDrawerVisible = true;
            if (this.isLevelDialogDrawerOpen) {
                this.isLevelDialogDrawerOpen = false;
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                }
            }

            this.isInsightsDrawerOpen = false;
            this.isEnergyInsightPanelOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isSceneDetailsVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isAlertsDrawerOpen = false;
        });
        this.MapService.oToggle_Visitor_Origins_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            if (this.oExternal_Study_Zone_Details.LEVEL_ID != data.level_id || this.oExternal_Study_Zone_Details.preset_time != this.oSelected_Preset_time || this.oExternal_Study_Zone_Details.enum_timespan != this.oEnum_Timespan_Filter) {
                this.isVisitorOriginsVisible = true;
                this.oExternal_Study_Zone_Details.LEVEL_ID = data.level_id;
                this.oExternal_Study_Zone_Details.coordinates = data.coordinates;
                this.oExternal_Study_Zone_Details.data_level_setup_id = data.data_level_setup_id;
                this.oExternal_Study_Zone_Details.preset_time = this.oSelected_Preset_time;
                this.oExternal_Study_Zone_Details.enum_timespan = this.oEnum_Timespan_Filter;
                let oParams_Get_Visitor_Origins = new Params_Get_Visitor_Origins();
                oParams_Get_Visitor_Origins.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
                oParams_Get_Visitor_Origins.LEVEL_SETUP_ID = data.data_level_setup_id;
                oParams_Get_Visitor_Origins.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
                oParams_Get_Visitor_Origins.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
                oParams_Get_Visitor_Origins.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
                oParams_Get_Visitor_Origins.LEVEL_ID = data.level_id;
                this.MapService.Get_Visitor_Origins(oParams_Get_Visitor_Origins).then(result => {
                    this.oExternal_Study_Zone_Details.GeoJSON = result.GEOJSON;
                    this.oExternal_Study_Zone_Details.List_Ext_Study_Zone_With_Count = result.LIST_EXT_STUDY_ZONE_WITH_COUNT;
                    this.Add_Visitor_Origin_Layer(result.GEOJSON, result.LIST_EXT_STUDY_ZONE_WITH_COUNT, data.coordinates);
                });
            } else {
                this.isVisitorOriginsVisible = !this.isVisitorOriginsVisible;
                if (this.isVisitorOriginsVisible) {
                    this.oList_Popup.forEach(popup => {
                        popup.remove();
                    });
                    this.oList_Popup = [];
                    this.oExternal_Study_Zone_Details.List_Ext_Study_Zone_With_Count.forEach(oExt_study_zone_With_Count => {
                        let oPopup = new Popup({
                            closeButton: false,
                            closeOnClick: false,
                            className: 'go-front'
                        });
                        let description = `
                        <div class="flex flex-col flex-auto">
                            <div class="flex flex-row border-b pb-1">
                                <img src="assets/images/site.svg" style="width:20px;height:20px;"\>
                                <div class="ml-1">
                                    <div class="text-s font-semibold leading-tight text-smallTextColor">${oExt_study_zone_With_Count.EXT_STUDY_ZONE.NAME}</div>
                                </div>
                            </div>
                            <div class="flex text-md leading-none tracking-tight justify-center items-center mt-2 p-1">Number of Visitors: ${oExt_study_zone_With_Count?.COUNT != null ? this.DecimalPipe.transform(oExt_study_zone_With_Count.COUNT) : '...'}</div>
                        </div>
                        `;
                        oPopup.setLngLat([oExt_study_zone_With_Count.EXT_STUDY_ZONE.LONGITUDE, oExt_study_zone_With_Count.EXT_STUDY_ZONE.LATITUDE]).setHTML(description).addTo(this.map);
                        this.oList_Popup.push(oPopup);
                    });
                    if (this.map.getLayer('arc')) {
                        this.map.setLayoutProperty('arc', 'visibility', 'visible');
                    }
                    if (this.map.getLayer('ext_study_zone_fill')) {
                        this.map.setLayoutProperty('ext_study_zone_fill', 'visibility', 'visible');
                    }
                    if (this.map.getLayer('ext_study_zone_border')) {
                        this.map.setLayoutProperty('ext_study_zone_border', 'visibility', 'visible');
                    }
                }
            }
            if (!this.isVisitorOriginsVisible) {
                if (this.map.getLayer('arc')) {
                    this.map.setLayoutProperty('arc', 'visibility', 'none');
                }
                if (this.map.getLayer('ext_study_zone_fill')) {
                    this.map.setLayoutProperty('ext_study_zone_fill', 'visibility', 'none');
                }
                if (this.map.getLayer('ext_study_zone_border')) {
                    this.map.setLayoutProperty('ext_study_zone_border', 'visibility', 'none');
                }
                this.oList_Popup.forEach(popup => {
                    popup.remove();
                });
            }
        });
        this.MapService.oOpen_Scene_Details_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_Scene_Modal_Details => {
            this.oScene_Modal_Details = _Scene_Modal_Details.sceneModalData;
            this.isSceneDetailsVisible = true;
            if (this.isLevelDialogDrawerOpen) {
                this.isLevelDialogDrawerOpen = false;
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                }
            }

            this.isInsightsDrawerOpen = false;
            this.isEnergyInsightPanelOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isAlertsDrawerOpen = false;
        });
        this.MapService.oToggle_ByLaw_Complaint_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            this.isByLawComplaintVisible = !this.isByLawComplaintVisible;
            this.map.loadImage('assets/images/map-alert.png', (error, image) => {
                if (error) throw error;
                if (!this.map.hasImage('map-alert')) {
                    this.setImage('map-alert', image);
                }
            })
            if (this.isByLawComplaintVisible) {
                this.Get_ByLawComplaint_List().then(oList_ByLaw_Complaint => {
                    if (oList_ByLaw_Complaint && oList_ByLaw_Complaint.length > 0) {
                        if (!this.map.getSource('bylawComplaints')) {
                            this.map.addSource('bylawComplaints', {
                                type: 'geojson',
                                data: {
                                    type: "FeatureCollection",
                                    features: oList_ByLaw_Complaint.map(bylaw_complaint => {
                                        return {
                                            type: 'Feature',
                                            properties: {
                                                extrude: false,
                                                type: 'public',
                                                underground: true,
                                                NeighbourhoodColor: '#e0b25c',
                                                borderColor: '#2C2E30',
                                                name: bylaw_complaint.COMPLAINT_CATEGORY,
                                                object: JSON.stringify(bylaw_complaint),
                                                'description': `
                                        <div class="flex flex-col flex-auto">
                                            <div class="flex flex-row border-b pb-1">
                                                <div class="text-s font-semibold leading-tight text-smallTextColor">Bylaw Complaint</div>
                                            </div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Category: ${bylaw_complaint.COMPLAINT_CATEGORY}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Type of Complaint: ${bylaw_complaint.TYPE_OF_COMPLAINT}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Date Created: ${this.DatePipe.transform(bylaw_complaint.DATE_CREATED, null, this.TimezoneService.oCurrent_Timezone_Offset)}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Neighbourhood: ${bylaw_complaint.NEIGHBOURHOOD}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Full Name of Street: ${bylaw_complaint.FULL_NAME_OF_STREET}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Infraction Status: ${bylaw_complaint.INFRACTION_STATUS}</div>
                                        </div>
                                            `,
                                            },
                                            geometry: {
                                                type: 'Point',
                                                coordinates: [bylaw_complaint.Location.coordinates[0], bylaw_complaint.Location.coordinates[1]]
                                            },
                                            id: bylaw_complaint.COMPLAINT_CATEGORY,
                                        };
                                    }),
                                },
                            });
                        }
                        else {
                            let ByLaw_Complaint_Source = this.map.getSource('bylawComplaints') as GeoJSONSource;
                            ByLaw_Complaint_Source.setData({
                                type: "FeatureCollection",
                                features: oList_ByLaw_Complaint.map(bylaw_complaint => {
                                    return {
                                        type: 'Feature',
                                        properties: {
                                            extrude: false,
                                            type: 'public',
                                            underground: true,
                                            NeighbourhoodColor: '#e0b25c',
                                            borderColor: '#2C2E30',
                                            name: bylaw_complaint.COMPLAINT_CATEGORY,
                                            object: JSON.stringify(bylaw_complaint),
                                            'description': `
                                        <div class="flex flex-col flex-auto">
                                            <div class="flex flex-row border-b pb-1">
                                                <div class="text-s font-semibold leading-tight text-smallTextColor">Bylaw Complaint</div>
                                            </div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Category: ${bylaw_complaint.COMPLAINT_CATEGORY}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Type of Complaint: ${bylaw_complaint.TYPE_OF_COMPLAINT}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Date Created: ${this.DatePipe.transform(bylaw_complaint.DATE_CREATED, null, this.TimezoneService.oCurrent_Timezone_Offset)}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Neighbourhood: ${bylaw_complaint.NEIGHBOURHOOD}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Full Name of Street: ${bylaw_complaint.FULL_NAME_OF_STREET}</div>
                                            <div class="flex text-md leading-none tracking-tight mt-2 p-1">Infraction Status: ${bylaw_complaint.INFRACTION_STATUS}</div>
                                        </div>
                                            `,
                                        },
                                        geometry: {
                                            type: 'Point',
                                            coordinates: [bylaw_complaint.Location.coordinates[0], bylaw_complaint.Location.coordinates[1]]
                                        },
                                        id: bylaw_complaint.COMPLAINT_CATEGORY,
                                    };
                                }),
                            })
                        }
                        if (!this.map.getLayer('bylawComplaintsxSymbols')) {
                            this.map.addLayer({
                                "id": "bylawComplaintsxSymbols",
                                "source": "bylawComplaints",
                                "type": "symbol",
                                layout: {
                                    "icon-image": 'map-alert',
                                    'icon-size': 0.075,
                                    'text-field': ['get', 'name'],
                                    'text-size': 12,
                                    'text-anchor': 'top',
                                    'text-offset': [0, 1.5],
                                    visibility: this.isByLawComplaintVisible ? 'visible' : 'none',
                                }
                            });
                        }
                        else {
                            if (this.map.getLayer('bylawComplaintsxSymbols')) {
                                this.map.setLayoutProperty('bylawComplaintsxSymbols', 'visibility', 'visible');
                            }
                        }
                    }
                    else {
                        this.CmSvc.ShowMessage("No ByLaw Complaints Found.", 1000)
                    }
                })
            }
            else {
                if (this.map.getLayer('bylawComplaintsxSymbols')) {
                    this.map.setLayoutProperty('bylawComplaintsxSymbols', 'visibility', 'none');
                }
            }

        })
        this.MapService.oToggle_Public_event_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            this.isPublicEventsVisible = !this.isPublicEventsVisible;
            this.map.loadImage('assets/images/map-event-sdf.png', (error, image) => {
                if (error) throw error;
                if (!this.map.hasImage('map-event')) {
                    this.setImage('map-event', image, { sdf: true });
                }
            })
            if (this.isPublicEventsVisible) {
                this.Get_Public_Event_List().then(oList_Public_Event => {
                    if (oList_Public_Event && oList_Public_Event.length > 0) {
                        if (!this.map.getSource('publicEvents')) {
                            this.map.addSource('publicEvents', {
                                type: 'geojson',
                                data: {
                                    type: "FeatureCollection",
                                    features: oList_Public_Event.map(public_event => {
                                        return {
                                            type: 'Feature',
                                            properties: {
                                                extrude: false,
                                                type: 'public',
                                                underground: true,
                                                NeighbourhoodColor: '#e0b25c',
                                                borderColor: '#2C2E30',
                                                iconColor: new Date(public_event.END_TIME) >= new Date() ? 'black' : 'gray',
                                                iconOpacity: new Date(public_event.END_TIME) >= new Date() ? 1 : 0.8,
                                                name: public_event.TITLE,
                                                object: JSON.stringify(public_event),
                                                'description': `
                                        <div class="flex flex-col flex-auto">
                                            <div class="flex flex-row border-b pb-1">
                                                <div class="text-s font-semibold leading-tight text-smallTextColor">Public Event</div>
                                            </div>
                                            ${public_event.TITLE ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>Title: &nbsp; </strong> ${public_event.TITLE}</div>` : ''}
                                            ${public_event.DATE_AND_TIME ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>Date And Time: &nbsp; </strong> ${public_event.DATE_AND_TIME}</div>` : ''}
                                            ${public_event.START_TIME ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>Start Time: &nbsp; </strong> ${public_event.START_TIME}</div>` : ''}
                                            ${public_event.END_TIME ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>End Time: &nbsp; </strong> ${public_event.END_TIME}</div>` : ''}
                                        </div>
                                            `,
                                            },
                                            geometry: {
                                                type: 'Point',
                                                coordinates: [public_event.Location.coordinates[0], public_event.Location.coordinates[1]]
                                            },
                                            id: public_event.PUBLIC_EVENT_ID,
                                        };
                                    }),
                                },
                            });
                        }
                        else {
                            let public_events_source = this.map.getSource("publicEvents") as GeoJSONSource;
                            public_events_source.setData({
                                type: "FeatureCollection",
                                features: oList_Public_Event.map(public_event => {
                                    return {
                                        type: 'Feature',
                                        properties: {
                                            extrude: false,
                                            type: 'public',
                                            underground: true,
                                            NeighbourhoodColor: '#e0b25c',
                                            borderColor: '#2C2E30',
                                            iconColor: new Date(public_event.END_TIME) >= new Date() ? 'black' : 'gray',
                                            iconOpacity: new Date(public_event.END_TIME) >= new Date() ? 1 : 0.8,
                                            name: public_event.TITLE,
                                            object: JSON.stringify(public_event),
                                            'description': `
                                        <div class="flex flex-col flex-auto">
                                            <div class="flex flex-row border-b pb-1">
                                                <div class="text-s font-semibold leading-tight text-smallTextColor">Public Event</div>
                                            </div>
                                            ${public_event.TITLE ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>Title: &nbsp; </strong> ${public_event.TITLE}</div>` : ''}
                                            ${public_event.DATE_AND_TIME ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>Date And Time: &nbsp; </strong> ${public_event.DATE_AND_TIME}</div>` : ''}
                                            ${public_event.START_TIME ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>Start Time: &nbsp; </strong> ${public_event.START_TIME}</div>` : ''}
                                            ${public_event.END_TIME ? `<div class="flex text-md leading-none  mt-2 p-1"><strong>End Time: &nbsp; </strong> ${public_event.END_TIME}</div>` : ''}
                                        </div>
                                            `,
                                        },
                                        geometry: {
                                            type: 'Point',
                                            coordinates: [public_event.Location.coordinates[0], public_event.Location.coordinates[1]]
                                        },
                                        id: public_event.PUBLIC_EVENT_ID,
                                    };
                                }),
                            })
                        }
                        if (!this.map.getLayer('public_events')) {
                            this.map.addLayer({
                                "id": "public_events",
                                "source": "publicEvents",
                                "type": "symbol",
                                layout: {
                                    "icon-image": 'map-event',
                                    'icon-size': 0.2,
                                    'text-field': ['get', 'name'],
                                    'text-size': 12,
                                    'text-anchor': 'top',
                                    'text-offset': [0, 1.5],
                                    visibility: this.isPublicEventsVisible ? 'visible' : 'none',
                                },
                                paint: {
                                    "icon-color": ['get', 'iconColor'],
                                    "icon-opacity": ['get', 'iconOpacity'],
                                }
                            });
                        }
                        else {
                            this.map.setLayoutProperty('public_events', 'visibility', 'visible')
                        }
                    }
                    else {
                        this.CmSvc.ShowMessage("No Public Events Found.", 1000)
                    }
                })
            }
            else {
                if (this.map.getLayer('public_events')) {
                    this.map.setLayoutProperty('public_events', 'visibility', 'none');
                }
            }
        })
        this.map.on('mousemove', 'public_events', (e) => {
            this.map.getCanvas().style.cursor = 'pointer';
            const coordinates = e.lngLat;
            const description = e.features[0].properties.description;
            while (Math.abs(e.lngLat.lng - coordinates[0]) > 180) {
                coordinates[0] += e.lngLat.lng > coordinates[0] ? 360 : -360;
            }
            this.oPopup.setLngLat(coordinates).setHTML(description).addTo(this.map);
        });
        this.map.on('mouseleave', 'public_events', () => {
            this.map.getCanvas().style.cursor = '';
            this.oPopup.remove();
        });
        this.MapService.oApply_Filter_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            if (this.isVisitorOriginsVisible) {
                let oParams_Get_Visitor_Origins = new Params_Get_Visitor_Origins();
                oParams_Get_Visitor_Origins.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
                oParams_Get_Visitor_Origins.LEVEL_SETUP_ID = this.oDialog_input.properties.Data_Level_Setup_ID;
                oParams_Get_Visitor_Origins.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
                oParams_Get_Visitor_Origins.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
                oParams_Get_Visitor_Origins.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
                oParams_Get_Visitor_Origins.LEVEL_ID = this.oExternal_Study_Zone_Details.LEVEL_ID;
                this.remove_Layer('arc');
                this.remove_Layer('ext_study_zone_border');
                this.remove_Layer('ext_study_zone_fill');
                this.oExternal_Study_Zone_Details.preset_time = this.oSelected_Preset_time;
                this.oExternal_Study_Zone_Details.enum_timespan = this.oEnum_Timespan_Filter;
                this.MapService.Get_Visitor_Origins(oParams_Get_Visitor_Origins).then(result => {
                    this.oExternal_Study_Zone_Details.GeoJSON = result.GEOJSON;
                    this.oExternal_Study_Zone_Details.List_Ext_Study_Zone_With_Count = result.LIST_EXT_STUDY_ZONE_WITH_COUNT;
                    this.Add_Visitor_Origin_Layer(result.GEOJSON, result.LIST_EXT_STUDY_ZONE_WITH_COUNT, this.oExternal_Study_Zone_Details.coordinates);
                });
            }
            if (this.isVisitorHeatmapVisible) {
                this.isVisitorHeatmapVisible = false;
                this.MapService.oToggle_Visitor_Heatmap_Subject.next({ level_id: this.oToggled_Visitor_Heatmap_Details.level_id, upper_level_id: this.oToggled_Visitor_Heatmap_Details.level_id, view_type: this.oToggled_Visitor_Heatmap_Details.view_type });
            }
            if (this.isPublicEventsVisible) {
                this.isPublicEventsVisible = false;
                this.remove_Layer('public_events');
                this.MapService.oToggle_Public_event_Subject.next();
            }
            if (this.isBusinessHeatmapVisible) {
                this.isBusinessHeatmapVisible = false;
                this.MapService.oToggle_Business_Heatmap_Subject.next(this.oToggled_Business_Heatmap_Details);
            }
            if (this.isBusinessPinsVisible) {
                this.isBusinessPinsVisible = false;
                this.MapService.oToggle_Business_Pins_Subject.next(this.oToggled_Business_Pins_Details);
            }
            if (this.isByLawComplaintVisible) {
                this.isByLawComplaintVisible = false;
                this.remove_Layer('bylawComplaintsxSymbols');
                this.MapService.oToggle_ByLaw_Complaint_Subject.next();
            }
            if (this.oEnum_Map_view == Enum_Map_view.entity && this.oList_Entity && this.oList_Entity.length > 0) {
                this.Get_Latest_Dimension_Index_By_Where().then(result => {
                    let divs = document.getElementsByClassName('building-index-popup');
                    for (let i = 0; i < divs.length; i++) {
                        let div = divs.item(i);
                        let [buildingId, dimensionId] = div.id.split('_');
                        let value = result.find(oDimension_index_By_Level => oDimension_index_By_Level.LEVEL_ID.toString() == buildingId)?.LIST_DIMENSION_INDEX?.find(dimension_index => dimension_index.DIMENSION_METADATA.DIMENSION_ID.toString() == dimensionId)?.VALUE ?? '-';
                        if (value != '-') {
                            divs.item(i).innerHTML = Math.round(value as number).toString();
                        }
                        else {
                            divs.item(i).innerHTML = value;
                        }
                    }
                    divs = document.getElementsByClassName('building-index-color-popup');
                    for (let i = 0; i < divs.length; i++) {
                        let div = divs.item(i);
                        let [buildingId, dimensionId] = div.id.split('_');
                        let value = result.find(oDimension_index_By_Level => oDimension_index_By_Level.LEVEL_ID.toString() == buildingId)?.LIST_DIMENSION_INDEX?.find(dimension_index => dimension_index.DIMENSION_METADATA.DIMENSION_ID.toString() == dimensionId).VALUE ?? 0;
                        (divs.item(i) as HTMLElement).style.backgroundColor = value > this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.HIGH_THRESHOLD ? '#22C55E' : value > this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.LOW_THRESHOLD ? '#F59E0B' : '#EF4444';
                    }
                });
            }
        })
        this.MapService.oToggle_Intersection_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            this.isIntersectionsVisible = !this.isIntersectionsVisible;
            if (this.map.getLayer('entity-bottom-extrusion')) {
                this.map.setLayoutProperty('entity-bottom-extrusion', 'visibility', this.isIntersectionsVisible ? 'visible' : 'none');
            }
            if (this.map.getLayer('intersection_entity')) {
                this.map.setLayoutProperty('intersection_entity', 'visibility', this.isIntersectionsVisible ? 'visible' : 'none');
            }
        })
        this.MapService.oToggle_Visitor_Heatmap_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            if (this.oToggled_Visitor_Heatmap_Details.upper_level_id == data.upper_level_id && this.oToggled_Visitor_Heatmap_Details.view_type == data.view_type) {
                this.isVisitorHeatmapVisible = !this.isVisitorHeatmapVisible;
            }
            else {
                this.oToggled_Visitor_Heatmap_Details.upper_level_id = data.upper_level_id;
                this.oToggled_Visitor_Heatmap_Details.view_type = data.view_type;
                this.oToggled_Visitor_Heatmap_Details.level_id = data.level_id;
                this.isVisitorHeatmapVisible = true;
            }
            if (this.isVisitorHeatmapVisible) {
                this.Get_Latest_Visitor_Count_By_Where(data.level_id).then(oList_Visitor_Count_By_Level => {
                    this.isVisitorDataFetched = true;
                    if (oList_Visitor_Count_By_Level && oList_Visitor_Count_By_Level.length > 0) {

                        let max_visitors = oList_Visitor_Count_By_Level.reduce((acc, curr) => {
                            return curr.VISITOR_COUNT > acc ? curr.VISITOR_COUNT : acc;
                        }, 0);
                        this.max_number_of_visitors = max_visitors;
                        if (!this.map.getSource('visitor_heatmap_source')) {
                            this.map.addSource('visitor_heatmap_source', {
                                type: 'geojson',
                                data: {
                                    type: "FeatureCollection",
                                    features: oList_Visitor_Count_By_Level.map(Visitor_Count_By_Level => {
                                        let level_location;
                                        switch (this.oEnum_Map_view) {
                                            case Enum_Map_view.area:
                                                level_location = this.oList_Area.find(oArea => oArea.AREA_ID == Visitor_Count_By_Level.LEVEL_ID);
                                                break;
                                            case Enum_Map_view.site:
                                                level_location = this.oList_Site.find(oSite => oSite.SITE_ID == Visitor_Count_By_Level.LEVEL_ID);
                                                break;
                                        }
                                        return {
                                            type: "Feature",
                                            geometry: {
                                                type: "Point",
                                                coordinates: [level_location.CENTER_LONGITUDE, level_location.CENTER_LATITUDE],
                                            },
                                            properties: {
                                                id: level_location[`${this.view_type.toUpperCase}_ID`],
                                                value: Visitor_Count_By_Level.VISITOR_COUNT,
                                            }
                                        }
                                    })
                                }
                            });
                        } else {
                            let visitor_heatmap_source = this.map.getSource('visitor_heatmap_source') as GeoJSONSource;
                            visitor_heatmap_source.setData({
                                type: "FeatureCollection",
                                features: oList_Visitor_Count_By_Level.map(oVisitor_Count_By_Level => {
                                    let level_location;
                                    switch (this.oEnum_Map_view) {
                                        case Enum_Map_view.area:
                                            level_location = this.oList_Area.find(oArea => oArea.AREA_ID == oVisitor_Count_By_Level.LEVEL_ID);
                                            break;
                                        case Enum_Map_view.site:
                                            level_location = this.oList_Site.find(oSite => oSite.SITE_ID == oVisitor_Count_By_Level.LEVEL_ID);
                                            break;
                                    }
                                    return {
                                        type: "Feature",
                                        geometry: {
                                            type: "Point",
                                            coordinates: [level_location.CENTER_LONGITUDE, level_location.CENTER_LATITUDE],
                                        },
                                        properties: {
                                            id: level_location[`${this.view_type.toUpperCase}_ID`],
                                            value: oVisitor_Count_By_Level.VISITOR_COUNT,
                                        }
                                    }
                                })

                            })
                        }
                        if (!this.map.getLayer('visitor_heatmap')) {
                            this.map.addLayer({
                                id: "visitor_heatmap",
                                type: "heatmap",
                                source: "visitor_heatmap_source",
                                'paint': {
                                    'heatmap-weight': [
                                        'interpolate',
                                        ['linear'],
                                        ['get', 'value'],
                                        0,
                                        0,
                                        max_visitors ?? 1,
                                        1
                                    ],
                                    'heatmap-intensity': 3,
                                    'heatmap-color': [
                                        'interpolate',
                                        ['linear'],
                                        ['heatmap-density'],
                                        0,
                                        'rgba(0,255,0,0)',
                                        0.2,
                                        'green',
                                        0.6,
                                        'yellow',
                                        1,
                                        'red'
                                    ],
                                    'heatmap-radius': [
                                        'interpolate',
                                        ['linear'],
                                        ['zoom'],
                                        12,
                                        10,
                                        15,
                                        50
                                    ],
                                    // Transition from heatmap to circle layer by zoom level
                                    'heatmap-opacity': [
                                        'interpolate',
                                        ['linear'],
                                        ['zoom'],
                                        15,
                                        1,
                                        16,
                                        0
                                    ]
                                }
                            });
                        } else {
                            this.map.setLayoutProperty('visitor_heatmap', 'visibility', 'visible');
                            this.map.setPaintProperty('visitor_heatmap', 'heatmap-weight', [
                                'interpolate',
                                ['linear'],
                                ['get', 'value'],
                                0,
                                0,
                                max_visitors ?? 1,
                                1
                            ])
                        }
                        let layer_source = this.map.getSource(this.view_type) as GeoJSONSource;
                        layer_source.setData({
                            type: "FeatureCollection",
                            features: layer_source[`_options`][`data`][`features`].map(feature => {
                                let oVisitor_Count_By_Level = oList_Visitor_Count_By_Level.find(oVisitor_Count_By_Level => oVisitor_Count_By_Level.LEVEL_ID == Number.parseInt(feature.id));
                                let visitor_count = 0;

                                if (oVisitor_Count_By_Level) {
                                    visitor_count = oVisitor_Count_By_Level.VISITOR_COUNT;
                                }
                                feature.properties.value = visitor_count;
                                feature.properties.description = ` <div class="flex flex-col flex-auto">
                                <div class="flex flex-row border-b pb-1">
                                    <img src="assets/images/site.svg" style="width:20px;height:20px;"\>
                                    <div class="ml-1">
                                        <div class="text-s font-semibold leading-tight text-smallTextColor">Site Visitor Details</div>
                                    </div>
                                </div>
                                <div class="flex text-md leading-none tracking-tight justify-center items-center mt-2 p-1">Number of Visitors: ${this.DecimalPipe.transform(visitor_count)}</div>
                            </div>`
                                return feature;
                            })
                        })
                        let list_id: number[];
                        switch (this.view_type) {
                            case "area":
                                list_id = this.oList_Area.filter(oArea => oArea.DISTRICT_ID == this.oCurrent_Area.DISTRICT_ID).map(oArea => oArea.AREA_ID);
                                break;
                            case "site":
                                list_id = this.oList_Site.filter(oSite => oSite.AREA_ID == this.oCurrent_Site.AREA_ID).map(oSite => oSite.SITE_ID);
                                break;
                        }

                        this.map.setPaintProperty(this.view_type + '_fill', 'fill-color', [
                            'interpolate',
                            ['linear'],
                            ['zoom'],
                            15,
                            ['get', 'AREA_COLOR'],
                            16,
                            [
                                'case',
                                ['in', ['get', 'id'], ['literal', list_id]],
                                [
                                    'interpolate',
                                    ['linear'],
                                    ['get', 'value'],
                                    0,
                                    'green',
                                    max_visitors / 2,
                                    'yellow',
                                    max_visitors,
                                    'red',
                                ],
                                ['get', 'AREA_COLOR'],
                            ]
                        ]);
                    } else {
                        this.CmSvc.ShowMessage("No visitors for " + this.oClicked_Level_Location.NAME, 1000)
                    }
                })
            } else {
                if (this.map.getLayer('visitor_heatmap')) {
                    this.map.setLayoutProperty('visitor_heatmap', 'visibility', 'none');
                }
                if (this.map.getLayer(this.view_type + '_fill')) {
                    this.map.setPaintProperty(this.view_type + '_fill', 'fill-color', ['get', 'AREA_COLOR']);
                }
            }
        });
        this.MapService.oOpen_Energy_Insights_Panel_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            this.isEnergyInsightPanelOpen = true;
            if (this.isLevelDialogDrawerOpen) {
                this.isLevelDialogDrawerOpen = false;
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                }
            }
            this.isEntityDrawerOpen = false;

            localStorage.removeItem('pinned_entity_dialog');

            this.isInsightsDrawerOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isSceneDetailsVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isAlertsDrawerOpen = false;
        });
        this.MapService.oOpen_Video_AI_Drawer_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            this.VideoAIService.resolve(null, null, false, this.oCurrent_Entity.ENTITY_ID).then(() => {
                this.isVideoDataLoaded = true;
            });
            this.isVideoAIDrawerVisible = true;
            if (this.isLevelDialogDrawerOpen) {
                this.isLevelDialogDrawerOpen = false;
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                }
            }

            this.isInsightsDrawerOpen = false;
            this.isEnergyInsightPanelOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isSceneDetailsVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isAlertsDrawerOpen = false;
        });
        this.MapService.oOpen_Expanded_Floor_Renderer.pipe(takeUntil(this._unsubscribeAll)).subscribe(result => {
            this.oFloor = result.FLOOR;
            this.isChangingFloor = result.isChangingFloor;
            this.isExpandedFloorRendererVisible = true;
            if (this.isLevelDialogDrawerOpen) {
                this.isLevelDialogDrawerOpen = false;
                if (this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS > 0) {
                    this.oList_Level_Open_Dialog[this.oList_Level_Open_Dialog.findIndex(oLevel_Open_Dialog => oLevel_Open_Dialog.LEVEL_TYPE == this.oCurrent_Level_Kpi_Drawer_Level.view_type)].OPEN_DIALOGS--;
                }
            }

            this.isInsightsDrawerOpen = false;
            this.isEnergyInsightPanelOpen = false;
            this.isSceneDetailsVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isAlertsDrawerOpen = false;
        });
        this.CmSvc.oResetBdcWalkthroughSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isLevelDialogDrawerOpen = false;
            this.isEntityDrawerOpen = false;

            localStorage.removeItem('pinned_entity_dialog');

            this.isEnergyInsightPanelOpen = false;
            this.isExpandedFloorRendererVisible = false;
            this.isSceneDetailsVisible = false;
            this.isVideoAIDrawerVisible = false;
            this.isEntitySummaryDrawerVisible = false;
            this.isInsightsDrawerOpen = false;
            this.isIntersectionDrawerOpen = false;
            this.isAlertsDrawerOpen = false;
            this.drawerWidth = 0;
        });
    }

    Get_Latest_Visitor_Count_By_Where(level_id: number): Promise<Visitor_Count_By_Level[]> {
        return new Promise((resolve, reject) => {
            let list_area_ids, list_site_ids: number[];
            let oParams_Get_Latest_Visitor_Count_By_Where = new Params_Get_Latest_Visitor_Count_By_Where();
            oParams_Get_Latest_Visitor_Count_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
            oParams_Get_Latest_Visitor_Count_By_Where.LEVEL_SETUP_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", Enum_Map_view[this.oEnum_Map_view]);
            switch (this.oEnum_Map_view) {
                case Enum_Map_view.area:
                    let oArea = this.oList_Area.find(_Area => _Area.AREA_ID == level_id);
                    list_area_ids = this.oList_Area.filter(_Area => _Area.DISTRICT_ID == oArea.DISTRICT_ID).map(oArea => oArea.AREA_ID);
                    oParams_Get_Latest_Visitor_Count_By_Where.LIST_LEVEL_ID = list_area_ids;
                    break;
                case Enum_Map_view.site:
                    let oSite = this.oList_Site.find(_Site => _Site.SITE_ID == level_id)
                    list_site_ids = this.oList_Site.filter(_Site => _Site.AREA_ID == oSite.AREA_ID).map(oSite => oSite.SITE_ID);
                    oParams_Get_Latest_Visitor_Count_By_Where.LIST_LEVEL_ID = list_site_ids;
                    break;
            }
            oParams_Get_Latest_Visitor_Count_By_Where.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
            this.MapService.Get_Latest_Visitor_Count_By_Where(oParams_Get_Latest_Visitor_Count_By_Where).then(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Add_Business_Heatmap_Source(): Promise<boolean> {
        return new Promise(resolve => {
            if (!this.map.getSource('business')) {
                this.map.addSource('business', {
                    type: 'geojson',
                    data: {
                        type: "FeatureCollection",
                        features: this.MapService.oList_Business.map(business => {
                            return {
                                type: 'Feature',
                                properties: {
                                    extrude: false,
                                    type: 'public',
                                    underground: true,
                                    NeighbourhoodColor: '#e0b25c',
                                    borderColor: '#2C2E30',
                                    name: business.NAME,
                                    imageIcon: business.BUSINESS_STATUS == "OPERATIONAL" ? 'map-business' : 'map-business',
                                    categories: business.LIST_BUSINESS_CATEGORY,
                                    pinColor: this.oList_Niche_categories.find(niche_categories => niche_categories.BUSINESS_NICHE.toLowerCase() == business.BUSINESS_NICHE.toLowerCase())?.NICHE_COLOR ?? '#8746c9',
                                    object: JSON.stringify(business),
                                },
                                geometry: {
                                    type: 'Point',
                                    coordinates: [business.Location.coordinates[0], business.Location.coordinates[1]]
                                },
                                id: business.BUSINESS_ID,
                            };
                        }),
                    },
                });
            }
            else {
                let businesses_source = this.map.getSource('business') as GeoJSONSource;
                businesses_source.setData({
                    type: "FeatureCollection",
                    features: this.MapService.oList_Business.map(business => {
                        return {
                            type: 'Feature',
                            properties: {
                                extrude: false,
                                type: 'public',
                                underground: true,
                                NeighbourhoodColor: '#e0b25c',
                                borderColor: '#2C2E30',
                                name: business.NAME,
                                imageIcon: business.BUSINESS_STATUS == "OPERATIONAL" ? 'map-business' : 'map-business',
                                categories: business.LIST_BUSINESS_CATEGORY,
                                pinColor: this.oList_Niche_categories.find(niche_categories => niche_categories.BUSINESS_NICHE.toLowerCase() == business.BUSINESS_NICHE.toLowerCase())?.NICHE_COLOR ?? '#8746c9',
                                object: JSON.stringify(business),
                            },
                            geometry: {
                                type: 'Point',
                                coordinates: [business.Location.coordinates[0], business.Location.coordinates[1]]
                            },
                            id: business.BUSINESS_ID,
                        };
                    }),
                });
            }
            resolve(true);
        })
    }

    Add_Business_Pins_Source(): Promise<boolean> {
        return new Promise(resolve => {
            if (!this.map.getSource('business_cluster')) {
                this.map.addSource('business_cluster', {
                    type: 'geojson',
                    data: {
                        type: "FeatureCollection",
                        features: this.MapService.oList_Business.map(business => {
                            return {
                                type: 'Feature',
                                properties: {
                                    extrude: false,
                                    type: 'public',
                                    underground: true,
                                    NeighbourhoodColor: '#e0b25c',
                                    borderColor: '#2C2E30',
                                    name: business.NAME,
                                    imageIcon: business.BUSINESS_STATUS == "OPERATIONAL" ? 'map-business' : 'map-business',
                                    categories: business.LIST_BUSINESS_CATEGORY,
                                    pinColor: this.oList_Niche_categories.find(niche_categories => niche_categories.BUSINESS_NICHE.toLowerCase() == business.BUSINESS_NICHE.toLowerCase())?.NICHE_COLOR ?? '#8746c9',
                                    object: JSON.stringify(business),
                                },
                                geometry: {
                                    type: 'Point',
                                    coordinates: [business.Location.coordinates[0], business.Location.coordinates[1]]
                                },
                                id: business.BUSINESS_ID,
                            };
                        }),
                    },
                    cluster: true,
                    clusterMaxZoom: 15, // Max zoom to cluster points on
                    clusterRadius: 100 // Radius of each cluster when clustering points (defaults to 50)
                });
            }
            else {
                let business_cluster_source = this.map.getSource('business_cluster') as GeoJSONSource;
                business_cluster_source.setData({
                    type: "FeatureCollection",
                    features: this.MapService.oList_Business.map(business => {
                        return {
                            type: 'Feature',
                            properties: {
                                extrude: false,
                                type: 'public',
                                underground: true,
                                NeighbourhoodColor: '#e0b25c',
                                borderColor: '#2C2E30',
                                name: business.NAME,
                                imageIcon: business.BUSINESS_STATUS == "OPERATIONAL" ? 'map-business' : 'map-business',
                                categories: business.LIST_BUSINESS_CATEGORY,
                                pinColor: this.oList_Niche_categories.find(niche_categories => niche_categories.BUSINESS_NICHE.toLowerCase() == business.BUSINESS_NICHE.toLowerCase())?.NICHE_COLOR ?? '#8746c9',
                                object: JSON.stringify(business),
                            },
                            geometry: {
                                type: 'Point',
                                coordinates: [business.Location.coordinates[0], business.Location.coordinates[1]]
                            },
                            id: business.BUSINESS_ID,
                        };
                    }),
                })
            }
            resolve(true);
        })
    }

    setImage(i_Image_Id, i_Image_Data, i_Image_Options = {}) {
        if (!this.map.hasImage(i_Image_Id)) {
            this.map.addImage(i_Image_Id, i_Image_Data, i_Image_Options);
        }
        const imageId = this.oList_Image.findIndex(oImage => oImage.imageId == i_Image_Id);
        if (imageId == -1) {
            this.oList_Image.push({
                imageData: i_Image_Data,
                imageId: i_Image_Id,
                imageOptions: i_Image_Options,
            });
        } else {
            this.oList_Image.find(oImage => oImage.imageId == i_Image_Id).imageData = i_Image_Data;
        }
    }

    Get_ByLawComplaint_List(): Promise<Bylaw_Complaint[]> {
        return new Promise(resolve => {
            let oParams_Get_ByLaw_Complaint_List = new Params_Get_Bylaw_Complaint_List();
            oParams_Get_ByLaw_Complaint_List.LEVEL_SETUP_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.view_type);
            let Grouped_levels = [];
            let list_id: number[];
            switch (this.oEnum_Map_view) {
                case Enum_Map_view.area:
                    Grouped_levels = this.oList_Area.filter(oArea => oArea.DISTRICT_ID == this.oCurrent_Area.DISTRICT_ID);
                    list_id = Grouped_levels.map(oArea => oArea.AREA_ID);
                    break;
                case Enum_Map_view.site:
                    Grouped_levels = this.oList_Site.filter(oSite => oSite.AREA_ID == this.oCurrent_Site.AREA_ID);
                    list_id = Grouped_levels.map(oSite => oSite.SITE_ID);
                    break;

                case Enum_Map_view.district:
                    list_id = this.oList_District.map(oDistrict => oDistrict.DISTRICT_ID);
                    break;
                case Enum_Map_view.entity:
                    Grouped_levels = this.oList_Entity.filter(oEntity => oEntity.SITE_ID == this.oCurrent_Entity.SITE_ID);
                    list_id = Grouped_levels.map(oEntity => oEntity.ENTITY_ID);
                    break;
            }
            oParams_Get_ByLaw_Complaint_List.LIST_LEVEL_ID = list_id;
            oParams_Get_ByLaw_Complaint_List.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
            oParams_Get_ByLaw_Complaint_List.START_DATE = this.oStart_Date_Filter.toISOString();
            this.MapService.Get_ByLaw_Complaint_List(oParams_Get_ByLaw_Complaint_List).then(result => {
                resolve(result);
            })
        })
    }

    Get_Public_Event_List(): Promise<Public_Event[]> {
        return new Promise(resolve => {
            let oParams_Get_Public_Event_List = new Params_Get_Public_Event_List();
            oParams_Get_Public_Event_List.LEVEL_SETUP_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.view_type);
            let Grouped_levels = [];
            let list_id: number[];
            switch (this.oEnum_Map_view) {
                case Enum_Map_view.area:
                    Grouped_levels = this.oList_Area.filter(oArea => oArea.DISTRICT_ID == this.oCurrent_Area.DISTRICT_ID);
                    list_id = Grouped_levels.map(oArea => oArea.AREA_ID);
                    break;
                case Enum_Map_view.site:
                    Grouped_levels = this.oList_Site.filter(oSite => oSite.AREA_ID == this.oCurrent_Site.AREA_ID);
                    list_id = Grouped_levels.map(oSite => oSite.SITE_ID);
                    break;

                case Enum_Map_view.district:
                    list_id = this.oList_District.map(oDistrict => oDistrict.DISTRICT_ID);
                    break;
                case Enum_Map_view.entity:
                    Grouped_levels = this.oList_Entity.filter(oEntity => oEntity.SITE_ID == this.oCurrent_Entity.SITE_ID);
                    list_id = Grouped_levels.map(oEntity => oEntity.ENTITY_ID);
                    break;
            }
            oParams_Get_Public_Event_List.LIST_LEVEL_ID = list_id;
            oParams_Get_Public_Event_List.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
            oParams_Get_Public_Event_List.START_DATE = this.oStart_Date_Filter.toISOString();
            this.MapService.Get_Public_Event_List(oParams_Get_Public_Event_List).then(result => {
                resolve(result);
            })
        })
    }

    Add_Intersection_Layer() {
        const polygons = [];
        this.oList_Intersection.forEach(entity => {
            polygons.push({
                "type": "Feature",
                "properties": {
                    "level": 1,
                    "name": entity.NAME,
                    "height": 20,
                    "color": polygonColors[entity.ENTITY_ID % polygonColors.length],
                    'description': `
                                        <div class="flex flex-col flex-auto">
                                            <div class="flex flex-row border-b pb-1">
                                                <img src="assets/images/tiles/Mobility.webp" style="width:20px;height:20px;"\>
                                                <div class="ml-1">
                                                    <div class="text-s font-semibold leading-tight text-smallTextColor">Intersection Details</div>
                                                </div>
                                            </div>
                                            <div class="flex text-md leading-none tracking-tight justify-center items-center mt-2 p-1">We can place any information here</div>
                                        </div>
                                        `,
                    'centerX': entity.GLTF_LONGITUDE,
                    'centerY': entity.GLTF_LATITUDE,
                    'top_level_id': entity.TOP_LEVEL_ID,
                },
                "geometry": {
                    "coordinates": [this.MapService.createGeoJSONCircle([entity.GLTF_LONGITUDE, entity.GLTF_LATITUDE], Math.random() / 30)],
                    "type": "Polygon"
                },
                "id": entity.ENTITY_ID
            })
        });
        if (!this.map.getSource('floorplan')) {
            this.map.addSource('floorplan', {
                'type': 'geojson',
                'data': JSON.parse(JSON.stringify({
                    features: polygons.filter(polygon => polygon.properties.top_level_id == this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.TOP_LEVEL_ID),
                    type: "FeatureCollection"
                }))
            });
        }
        if (!this.map.getLayer('intersection_entity')) {
            this.map.addLayer({
                'id': 'intersection_entity',
                'type': 'fill-extrusion',
                'source': 'floorplan',
                'paint': {
                    'fill-extrusion-color': ['get', 'color'],
                    'fill-extrusion-height': ['get', 'height'],
                    'fill-extrusion-base': 0,
                    'fill-extrusion-opacity': 0.8,
                },
                'layout': {
                    'visibility': this.isIntersectionsVisible ? 'visible' : 'none',
                }
            });
        }
        else {
            this.map.setLayoutProperty('intersection_entity', 'visibility', 'visible');
        }
    }

    switchMapStyle(styleUrl: string) {
        if (this.isVisitorOriginsVisible) {
            this.remove_Layer('arc');
        }
        this.isSwitchStyleDisabled = true;
        this.map.setStyle(styleUrl);
    }

    onMarkerClick() {
        this.NgZone.run(() => {
            if (!this.isMarkerDialogOpen) {
                this.MapService.oMarker_Opened_Subject.next(true);
                this.infoModaldialogRef = this.dialog.open(InfoModalComponent, {
                    width: '300px',
                    autoFocus: false,
                    hasBackdrop: false,
                    disableClose: true,
                    position: { right: '3rem' },
                    data: {
                        site: this.oCurrent_Site,
                    }
                });
                this.infoModaldialogRef.afterClosed().subscribe(() => {
                    this.MapService.oMarker_Opened_Subject.next(false);
                })
            } else {
                this.infoModaldialogRef.close();
                this.MapService.oMarker_Opened_Subject.next(false)
            }
        });
    }

    ngOnDestroy(): void {
        this.dialog.closeAll();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
