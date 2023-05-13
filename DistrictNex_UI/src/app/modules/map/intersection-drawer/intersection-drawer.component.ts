import { ChangeDetectorRef, Component, EventEmitter, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { polygonColors } from 'app/core/Models/constants';
import { CommonService } from 'app/core/Services/common.service';
import { Dimension, Dimension_ID_By_Level_ID, Dimension_index_By_Level, Entity, Enum_Dimension_Status, Params_Get_Latest_Dimension_index_By_Where, Site } from 'app/core/Services/proxy.service';
import { VideoAIService } from 'app/modules/video-ai/video-ai.service';
import { Map, Popup } from 'mapbox-gl';
import { Subject, takeUntil } from 'rxjs';
import { MapService } from '../map.service';

@Component({
    selector: 'intersection-drawer',
    templateUrl: './intersection-drawer.component.html',
    styleUrls: ['./intersection-drawer.component.scss']
})
export class IntersectionDrawerComponent implements OnInit, OnDestroy {

    private _unsubscribeAll = new Subject<void>();
    private resizeMapSubject = new Subject<void>();

    @Input() oEntity: Entity;
    @Input() oList_intersection: Entity[] = [];
    @Output() entityClickedEventEmitter = new EventEmitter<Entity>();
    @Output() closeIntersectionPanelEventEmitter = new EventEmitter<Entity>();

    isVideoDataLoaded = false;
    isAssetDataLoading = false;
    isSecurityDimentionAllowed = false;
    isEntityDimensionIndexFetched = false;
    isSustainabilityDimensionAllowed = false;

    zoom;
    pitch;
    center;
    bearing;
    title = '';
    oSite: Site;
    selectedTab: number;
    filterIsSiteSelected;
    oDimension: Dimension;
    entitySummaryTabIndex = 0;
    mapStyle = 'mapbox://styles/mapbox/outdoors-v11';

    oDimension_index_for_entity: Dimension_index_By_Level;
    tabs = ['Scene Search', 'Video Monitoring', 'Vehicle Counting', 'People Counting', '', 'License Plate Recognition', 'Facial Recognition'];


    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        private VideoAIService: VideoAIService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.filterIsSiteSelected = true;
    }

    ngOnInit(): void {
        this.oSite = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.find(oSite => oSite.SITE_ID == this.oEntity.SITE_ID);
        this.oList_intersection = this.oList_intersection.filter(oIntersection => oIntersection.SITE_ID == this.oEntity.SITE_ID);

        if (this.oList_intersection.length > 0) {
            this.center = [(Math.max(...this.oList_intersection.map(entity => entity.GLTF_LONGITUDE)) + Math.min(...this.oList_intersection.map(entity => entity.GLTF_LONGITUDE))) / 2, (Math.max(...this.oList_intersection.map(entity => entity.GLTF_LATITUDE)) + Math.min(...this.oList_intersection.map(entity => entity.GLTF_LATITUDE))) / 2];
        } else {
            this.center = [this.oSite.CENTER_LONGITUDE, this.oSite.CENTER_LATITUDE];
        }
        this.zoom = 14;
        this.pitch = 0;
        this.bearing = 0;
        this.Get_Entity_Latest_Dimension_Index_By_Where();
        this._changeDetectorRef.detectChanges();
    }

    ngAfterViewInit(): void {
        this.VideoAIService.resolve(null, null, false, 1).then(() => {
            this.isVideoDataLoaded = true;
            this._changeDetectorRef.detectChanges();
            const container = document.getElementById('intersection-map-container');
            let resizeObserver = new ResizeObserver(() => {
                this.resizeMapSubject.next();
            });
            resizeObserver.observe(container);
        });
    }

    Get_Entity_Latest_Dimension_Index_By_Where() {
        this.isEntityDimensionIndexFetched = false;
        let oParams_Get_Latest_Dimension_Index_By_Where = new Params_Get_Latest_Dimension_index_By_Where();
        oParams_Get_Latest_Dimension_Index_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        oParams_Get_Latest_Dimension_Index_By_Where.LEVEL_SETUP_ID = data_level_setup_id;
        oParams_Get_Latest_Dimension_Index_By_Where.START_DATE = this.MapService.oStart_Date_Filter.toISOString();
        oParams_Get_Latest_Dimension_Index_By_Where.END_DATE = this.MapService.oEnd_Date_Filter.toISOString();
        let entity_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension => oLevel_Dimension.DATA_LEVEL_SETUP_ID == entity_level_setup_id && oLevel_Dimension.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_Dimension.LEVEL_ID_LIST.includes(this.oEntity.ENTITY_ID));
        let oDimension_id_by_level_id = new Dimension_ID_By_Level_ID();
        oDimension_id_by_level_id.LEVEL_ID = this.oEntity.ENTITY_ID;
        oDimension_id_by_level_id.LIST_DIMENSION_ID = oList_Level_Dimension_With_Status.map(oLevel_Dimension => {
            return oLevel_Dimension.DIMENSION.DIMENSION_ID;
        });
        oParams_Get_Latest_Dimension_Index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID = [oDimension_id_by_level_id];
        this.MapService.Get_Latest_Dimension_index_By_Where(oParams_Get_Latest_Dimension_Index_By_Where).then(result => {
            this.oDimension_index_for_entity = result[0];
            if (!this.oDimension_index_for_entity) {
                this.oDimension_index_for_entity = new Dimension_index_By_Level();
                this.oDimension_index_for_entity.LIST_DIMENSION_INDEX = [];
            }
            this.isEntityDimensionIndexFetched = true;
        })
    }

    onLoad(map: Map) {
        this.resizeMapSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            map.resize();
        });

        const polygons = [];
        this.oList_intersection.forEach(entity => {
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
                },
                "geometry": {
                    "coordinates": [this.MapService.createGeoJSONCircle([entity.GLTF_LONGITUDE, entity.GLTF_LATITUDE], Math.random() / 30)],
                    "type": "Polygon"
                },
                "id": entity.ENTITY_ID
            })
        });
        map.addSource('floorplan', {
            'type': 'geojson',
            'data': JSON.parse(JSON.stringify({
                features: polygons,
                type: "FeatureCollection"
            }))
        });
        map.addLayer({
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
                'visibility': 'visible',
            }
        });
        map.on('click', 'intersection_entity', (e) => {
            const coordinates = [e.features[0].properties.centerX, e.features[0].properties.centerY];
            const description = e.features[0].properties.description;
            new Popup({ offset: 25 })
                .setLngLat([coordinates[0], coordinates[1]])
                .setHTML(description)
                .addTo(map);
            if (this.oEntity.ENTITY_ID != e.features[0].id) {
                this.oEntity = this.oList_intersection.find(oIntersection => oIntersection.ENTITY_ID == e.features[0].id);
                this.Get_Entity_Latest_Dimension_Index_By_Where();
            }
        });
    }

    changeTab(index) {
        this.entitySummaryTabIndex = index;
    }
    Close_Drawer() {
        this.closeIntersectionPanelEventEmitter.emit();
    }
    getShareLink() {
    }

    changeKpiDimension(i_Dimension: Dimension) {
        this.oDimension = i_Dimension;
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
