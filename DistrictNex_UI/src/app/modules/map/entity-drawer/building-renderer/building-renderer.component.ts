import { AfterViewInit, ChangeDetectorRef, Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Dimension, Dimension_index_By_Level, Entity, Enum_Dimension_Status, Floor, Setup } from 'app/core/Services/proxy.service';
import { ViewShareService } from 'app/modules/view-share/view-share.service';
import { BdcWalkService } from 'bdc-walkthrough';
import * as $ from 'jquery';
import { cloneDeep } from 'lodash';
import { Box3, Color, DirectionalLight, HemisphereLight, Mesh, PerspectiveCamera, Raycaster, Scene, Vector3, WebGLRenderer } from 'three';
import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls.js';
import { GLTF, GLTFLoader } from 'three/examples/jsm/loaders/GLTFLoader';
import { Object3D, Vector2 } from 'three/src/Three';
import { Dimension_data } from '../../../../core/Models/models';
import { MapService } from '../../map.service';

class Floor_With_GLTF {
    floor: Floor;
    gltfData: GLTF;
}

class originalMaterialColor {
    materialName: string;
    materialColor: Color;
    FLOOR_ID?: number;
}

class originalYPositionForFloor {
    floor: Floor;
    yPosition: number;
    ySize: number;
    yCenter: number;
}

class originalYPositionForAlert {
    floorNumber: number;
    vectorPosition: Vector3;
}

@Component({
    selector: 'building-renderer',
    templateUrl: './building-renderer.component.html',
    styleUrls: ['./building-renderer.component.scss']
})
export class BuildingRendererComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {

    @Input() isShareView = false;
    @Input() oFloor: Floor;
    @Input() oEntity: Entity;
    @Input() oDimension: Dimension;

    @Input() isShowHeatmap = false;
    @Input() isChangingFloor = false;

    @Input() oList_Floor: Floor[] = [];
    @Input() oList_Alert_With_GLTF = []
    @Input() oList_Dimension_index_for_floors: Dimension_index_By_Level[];
    @Input() oDimension_index_for_entity: Dimension_index_By_Level;

    @Output() buildingViewChangeEventEmitter = new EventEmitter<void>();

    isAlert = false;
    isMouseDown = false;
    isRendererIdle = false;
    isContentLoaded = false;
    isPreventClick = false;


    alertId = 1;
    minSize = 99999999;
    perspective = null;

    low_threshhold: number;
    high_threshhold: number;

    assetHovered: string = null;

    oDrone_View_Type_Setup: Setup;
    oFacade_View_Type_Setup: Setup;
    oSolid_Render_Type_Setup: Setup;
    oShell_Render_Type_Setup: Setup;
    oDefault_View_Type_Setup: Setup;
    oChosen_Render_Type_Setup: Setup;
    oFloor_Stack_Render_Type_Setup: Setup;

    oScene: Scene;
    iContainer1: HTMLElement;
    oOrbit_Controls: OrbitControls;
    oGLTF_Loader = new GLTFLoader();
    oSelected_Floor: Floor_With_GLTF;
    Enum_Dimension_Status = Enum_Dimension_Status;
    oPerspective_Camera: PerspectiveCamera;
    oHemisphere_Light: HemisphereLight = new HemisphereLight();
    oDirectional_Light: DirectionalLight = new DirectionalLight();
    oRenderer: WebGLRenderer = new WebGLRenderer({ antialias: true, alpha: true, preserveDrawingBuffer: true });

    oList_View_Type_Setup: Setup[];
    oList_Render_Type_Setup: Setup[];
    oList_Dimension_data: Dimension_data[];
    oList_Floor_With_GLTF: Floor_With_GLTF[];
    oOriginal_Material_For_All_Floors: originalMaterialColor[];
    oOriginal_Material_For_Selected_Floor: originalMaterialColor[];
    oOriginal_YPosition_For_All_Floors: originalYPositionForFloor[];
    oOriginal_YPosition_For_All_Alerts: originalYPositionForAlert[];

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        private BdcWalkService: BdcWalkService,
        private ViewShareService: ViewShareService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.oGLTF_Loader.setDRACOLoader(this.MapService.oDRACOLoader);
        let oList_GLTF_Render_Setup: Setup[] = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("gltf view type").List_Setup;
        let oList_GLTF_View_Setup: Setup[] = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("gltf camera view type").List_Setup;
        this.oDrone_View_Type_Setup = oList_GLTF_View_Setup.find(oSetup => oSetup.VALUE.toLowerCase() == "drone");
        this.oFacade_View_Type_Setup = oList_GLTF_View_Setup.find(oSetup => oSetup.VALUE.toLowerCase() == "facade");
        this.oDefault_View_Type_Setup = oList_GLTF_View_Setup.find(oSetup => oSetup.VALUE.toLowerCase() == "default");
        this.oSolid_Render_Type_Setup = oList_GLTF_Render_Setup.find(oSetup => oSetup.VALUE.toLowerCase() == "solid");
        this.oShell_Render_Type_Setup = oList_GLTF_Render_Setup.find(oSetup => oSetup.VALUE.toLowerCase() == "shell");
        this.oFloor_Stack_Render_Type_Setup = oList_GLTF_Render_Setup.find(oSetup => oSetup.VALUE.toLowerCase() == "floor stack");
        this.oChosen_Render_Type_Setup = this.oShell_Render_Type_Setup;
        this.high_threshhold = this.CmSvc.oUser_Accessible_Level_List?.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.HIGH_THRESHOLD ?? 66;
        this.low_threshhold = this.CmSvc.oUser_Accessible_Level_List?.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.LOW_THRESHOLD ?? 33;
    }

    ngOnInit() {
        this.oDirectional_Light.intensity = 1;
        this.oDirectional_Light.position.set(0, 1, 0);
        this.oHemisphere_Light.groundColor.set(0x0f0e0d);
        this.oHemisphere_Light.intensity = 5;
        this.updateIndexes();
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (this.isShareView) {
            return;
        }
        if (this.isContentLoaded && changes['oFloor'] && (this.oChosen_Render_Type_Setup.VALUE == "Floor Stack" || this.oChosen_Render_Type_Setup.VALUE == "Shell") && (!this.oSelected_Floor || this.oSelected_Floor.floor.FLOOR_ID != this.oFloor.FLOOR_ID)) {
            if (this.oSelected_Floor) {
                var parent = this.findParent(this.oSelected_Floor.gltfData.scene);
                if (parent) {
                    this.rePaintMesh(parent);
                }
                this.oSelected_Floor = null;
            }
            this.oOriginal_Material_For_Selected_Floor = [];
            this.oSelected_Floor = this.oList_Floor_With_GLTF.find(floor => floor.floor.FLOOR_ID == this.oFloor.FLOOR_ID);
            if (this.oSelected_Floor) {
                var parent = this.findParent(this.oSelected_Floor.gltfData.scene);
                this.paintMesh(parent);
            }
        }
        if (this.isContentLoaded && (changes['oDimension'] || changes['isShowHeatmap']) && this.oList_Floor_With_GLTF) {
            if (this.isShowHeatmap) {
                this.oList_Floor_With_GLTF.forEach(floorWithGltf => {
                    floorWithGltf.gltfData.scene.traverse(object3d => {
                        if (object3d instanceof Mesh) {
                            let oList_Floor_Dimension_index = this.oList_Dimension_index_for_floors.find(oDimension_index => oDimension_index.LEVEL_ID == floorWithGltf.floor.FLOOR_ID);
                            let indexValue = oList_Floor_Dimension_index?.LIST_DIMENSION_INDEX?.find(oDimension_index => oDimension_index.DIMENSION_METADATA.DIMENSION_ID == this.oDimension.DIMENSION_ID).VALUE;
                            object3d.material.color = indexValue > (this.high_threshhold ?? 66) ? new Color('#22C55E') : indexValue > (this.low_threshhold ?? 33) ? new Color('#F59E0B') : new Color('#EF4444');
                        }
                    });
                });
                if (this.oSelected_Floor) {
                    var parent = this.findParent(this.oSelected_Floor.gltfData.scene);
                    this.paintMesh(parent);
                }
            } else {
                if (this.oOriginal_Material_For_All_Floors) {
                    this.oList_Floor_With_GLTF.forEach(floorWithGltf => {
                        floorWithGltf.gltfData.scene.traverse(object3d => {
                            if (object3d instanceof Mesh) {
                                object3d.material.color.set(this.oOriginal_Material_For_All_Floors.filter(originalMesh => originalMesh.materialName == object3d.material.name && floorWithGltf.floor.FLOOR_ID == originalMesh.FLOOR_ID)[0].materialColor);
                            }
                        });
                    });
                }
                if (this.oSelected_Floor) {
                    var parent = this.findParent(this.oSelected_Floor.gltfData.scene);
                    this.paintMesh(parent);
                }
            }
        }
    }

    paintMesh(i_Object3d: Object3D) {
        i_Object3d.traverse(object3d => {
            if (object3d instanceof Mesh) {
                if (!this.oOriginal_Material_For_Selected_Floor.some(material => material.materialName == object3d.material.name)) {
                    this.oOriginal_Material_For_Selected_Floor.push({
                        materialName: object3d.material.name,
                        materialColor: new Color(object3d.material.color)
                    });
                }
                if (this.isShowHeatmap) {
                    object3d.material.color.set(0xf2f3f5);
                } else {
                    object3d.material.color.set(0xc97e18);
                }
            }
        });
    }


    rePaintMesh(i_Object3d: Object3D) {
        i_Object3d.traverse(object3d => {
            if (object3d instanceof Mesh) {
                object3d.material.color.set(this.oOriginal_Material_For_Selected_Floor.find(originalMesh => originalMesh.materialName == object3d.material.name).materialColor);
            }
        });
    }

    setPerspective() {
        switch (this.perspective) {
            case 0:
                this.oPerspective_Camera.position.set(-1.6, 1.1, 2);
                this.oOrbit_Controls.dispose();
                this.oOrbit_Controls = new OrbitControls(this.oPerspective_Camera, this.iContainer1);
                break;
            case 1:
                this.oPerspective_Camera.position.set(0, 0, 2.25);
                this.oOrbit_Controls.dispose();
                this.oOrbit_Controls = new OrbitControls(this.oPerspective_Camera, this.iContainer1);
                break;
            case 2:
                this.oPerspective_Camera.position.set(0, 1.1, 2);
                this.oOrbit_Controls.dispose();
                this.oOrbit_Controls = new OrbitControls(this.oPerspective_Camera, this.iContainer1);
                break;
        }
        setTimeout(() => {
            this.perspective = undefined;
        }, 100);
    }

    ngAfterViewInit() {
        this.iContainer1 = document.getElementById('rendering-container');
        this.iContainer1.appendChild(this.oRenderer.domElement);
        if (!this.isShareView) {
            this.iContainer1.addEventListener('mousedown', e => { this.isMouseDown = true; });
            this.iContainer1.addEventListener('click', e => {
                if (!this.isPreventClick) {
                    this.onClick(e)
                }
                this.isPreventClick = false;
            });
            this.iContainer1.addEventListener('mouseup', e => { this.isMouseDown = false });
        }
        this.iContainer1.addEventListener('mousemove', e => {
            if (this.isMouseDown) {
                this.isPreventClick = true;
            }
            this.onHover(e)
        });
        this.oList_Floor = this.oList_Floor.sort((a, b) => a.FLOOR_NUMBER - b.FLOOR_NUMBER);
        this.renderFloors();
        this._changeDetectorRef.detectChanges();
        let resizeObserver = new ResizeObserver(() => {
            if (this.oRenderer.domElement) {
                this.oRenderer.setSize(this.iContainer1.clientWidth, this.iContainer1.clientHeight);
                this.oRenderer.setPixelRatio(window.devicePixelRatio);
                this.oPerspective_Camera.aspect = this.iContainer1.offsetWidth / this.iContainer1.offsetHeight;
                this.oPerspective_Camera.updateProjectionMatrix()
            }
        });
        resizeObserver.observe(this.iContainer1);
    }

    onHover(event) {
        if (this.oRenderer.domElement) {
            event.preventDefault();

            var mouse = new Vector2(0, 0);
            mouse.x = (event.offsetX / this.oRenderer.domElement.clientWidth) * 2 - 1;
            mouse.y = -(event.offsetY / this.oRenderer.domElement.clientHeight) * 2 + 1;
            var raycaster = new Raycaster();
            raycaster.setFromCamera(mouse, this.oPerspective_Camera);

            var intersects = raycaster.intersectObjects(this.oScene.children);

            if (intersects.length && (this.oChosen_Render_Type_Setup.VALUE == "Floor Stack" || this.oChosen_Render_Type_Setup.VALUE == "Shell")) {
                $('html,body').css('cursor', 'pointer');
                let hoveredObject = this.findParent(intersects[0].object.parent);
                if (hoveredObject) {
                    this.assetHovered = Number(hoveredObject.name) ? this.oList_Floor_With_GLTF.filter(floor => floor.floor.FLOOR_ID.toString() == hoveredObject.name)[0].floor.NAME : hoveredObject.name;
                } else {
                    this.assetHovered = intersects[0].object.parent.name;
                }
                this.isAlert = this.assetHovered.includes('Alert');
            } else {
                $('html,body').css('cursor', 'default');
                this.assetHovered = null;
                this.isAlert = false;
            }
        }
    }

    findParent(object3d: Object3D) {
        let parent = object3d;
        while (!this.oList_Floor_With_GLTF.filter(floorWithGltf => floorWithGltf.floor.FLOOR_ID.toString() == parent.name)[0]) {
            parent = parent.parent;
            if (!parent) {
                return null;
            }
        }
        return parent;
    }

    updateIndexes() {
        if (!this.isShareView) {
            let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
            let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension => oLevel_Dimension.DATA_LEVEL_SETUP_ID == data_level_setup_id && oLevel_Dimension.LEVEL_ID_LIST.includes(this.oEntity.ENTITY_ID));
            this.oList_Dimension_data = oList_Level_Dimension_With_Status.map(_level_dimension_with_status => {
                const oDimension_data = new Dimension_data();
                oDimension_data.LEVEL_DIMENSION_WITH_STATUS = _level_dimension_with_status;
                oDimension_data.Enum_Dimension_Status = _level_dimension_with_status.ENUM_DIMENSION_STATUS;
                let oDimension_index = this.oDimension_index_for_entity.LIST_DIMENSION_INDEX.find(_Dimension_index => _Dimension_index.DIMENSION_METADATA.DIMENSION_ID == _level_dimension_with_status.DIMENSION.DIMENSION_ID);
                if (oDimension_index) {
                    oDimension_data.INDEX_VALUE = Math.round(oDimension_index.VALUE);
                    oDimension_data.INDEX_COLOR = oDimension_data.INDEX_VALUE > (this.CmSvc.oUser_Accessible_Level_List?.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL?.TOP_LEVEL.HIGH_THRESHOLD ?? 66) ? 'bg-highIndexColor' : oDimension_data.INDEX_VALUE > (this.CmSvc.oUser_Accessible_Level_List?.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL?.TOP_LEVEL.LOW_THRESHOLD ?? 33) ? 'bg-averageIndexColor' : 'bg-lowIndexColor';
                } else {
                    oDimension_data.INDEX_VALUE = 0;
                    oDimension_data.INDEX_COLOR = 'bg-neutralIndexColor';
                }
                return oDimension_data;
            }).sort((a, b) => a.Enum_Dimension_Status - b.Enum_Dimension_Status);
        } else {
            this.oList_Dimension_data = this.ViewShareService.oEntity_share_view_data.List_Entity_Level_Dimension_with_Status.map(_level_dimension_with_status => {
                const oDimension_data = new Dimension_data();
                oDimension_data.LEVEL_DIMENSION_WITH_STATUS = _level_dimension_with_status;
                oDimension_data.Enum_Dimension_Status = _level_dimension_with_status.ENUM_DIMENSION_STATUS;
                let oDimension_index = this.ViewShareService.oEntity_share_view_data.Entity_Dimension_index.LIST_DIMENSION_INDEX.find(_Dimension_index => _Dimension_index.DIMENSION_METADATA.DIMENSION_ID == _level_dimension_with_status.DIMENSION.DIMENSION_ID);
                if (oDimension_index) {
                    oDimension_data.INDEX_VALUE = Math.round(oDimension_index.VALUE);
                    oDimension_data.INDEX_COLOR = oDimension_data.INDEX_VALUE > (this.CmSvc.oUser_Accessible_Level_List?.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL?.TOP_LEVEL.HIGH_THRESHOLD ?? 66) ? 'bg-highIndexColor' : oDimension_data.INDEX_VALUE > (this.CmSvc.oUser_Accessible_Level_List?.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL?.TOP_LEVEL.LOW_THRESHOLD ?? 33) ? 'bg-averageIndexColor' : 'bg-lowIndexColor';
                } else {
                    oDimension_data.INDEX_VALUE = 0;
                    oDimension_data.INDEX_COLOR = 'bg-neutralIndexColor';
                }
                return oDimension_data;
            }).sort((a, b) => a.Enum_Dimension_Status - b.Enum_Dimension_Status);
        }
    }

    renderFloors() {
        try {
            this.oScene = new Scene();
            this.oRenderer.setClearColor(0x000000, 0);
            this.oPerspective_Camera = new PerspectiveCamera(
                35,
                this.iContainer1.offsetWidth / this.iContainer1.offsetHeight,
                0.01,
                1000

            );
            this.oPerspective_Camera.position.set(
                -1.6, 1.1, 2
            );
            this.oOrbit_Controls = new OrbitControls(this.oPerspective_Camera, this.iContainer1);
            this.oDirectional_Light.position.set(10, 10, 10);
            this.oScene.add(this.oHemisphere_Light, this.oDirectional_Light);
            this.oRenderer.setSize(this.iContainer1.clientWidth, this.iContainer1.clientHeight);
            this.oRenderer.setPixelRatio(window.devicePixelRatio);
            this.oRenderer.useLegacyLights = false;
            this.oList_Floor_With_GLTF = [];
            this.oList_Alert_With_GLTF = [];
            if (this.oList_Floor && this.oChosen_Render_Type_Setup.VALUE == "Floor Stack" || this.oChosen_Render_Type_Setup.VALUE == "Shell") {
                let sceneFloor = new Scene();
                sceneFloor.name = "Main Scene";
                const promises: Promise<any>[] = [];
                this.oList_Floor.forEach(floor => {
                    promises.push(new Promise<void>(resolve => {
                        this.oGLTF_Loader.load(this.oChosen_Render_Type_Setup.VALUE == "Shell" ? floor.SHELL_GLTF_URL : floor.CLIPPED_GLTF_URL, (GLTF) => {
                            this.oList_Floor_With_GLTF.push({
                                floor: floor,
                                gltfData: GLTF
                            });
                            resolve();
                        })
                    }));
                })
                Promise.all(promises).then(() => {
                    this.oOriginal_Material_For_All_Floors = [];
                    this.oOriginal_YPosition_For_All_Floors = [];
                    this.oOriginal_YPosition_For_All_Alerts = [];
                    this.oList_Floor_With_GLTF = this.oList_Floor_With_GLTF.sort((a, b) => a.floor.FLOOR_NUMBER < b.floor.FLOOR_NUMBER ? -1 : a.floor.FLOOR_NUMBER > b.floor.FLOOR_NUMBER ? 1 : 0)
                    this.oList_Floor_With_GLTF.forEach(floorWithGltf => {
                        var floorGltf = floorWithGltf.gltfData.scene;
                        var bbox = new Box3().setFromObject(floorGltf);
                        var size = bbox.getSize(new Vector3());
                        this.minSize = size.y * 2 < this.minSize ? size.y * 2 : this.minSize;
                    });

                    this.oList_Floor_With_GLTF.forEach((floorWithGltf, i) => {
                        var floorGltf = floorWithGltf.gltfData.scene;

                        floorGltf.traverse(object3d => {
                            if (object3d instanceof Mesh) {
                                this.oOriginal_Material_For_All_Floors.push({
                                    materialName: object3d.material.name,
                                    materialColor: new Color(object3d.material.color),
                                    FLOOR_ID: floorWithGltf.floor.FLOOR_ID,
                                });
                                if ((this.oChosen_Render_Type_Setup.VALUE == "Floor Stack" || this.oChosen_Render_Type_Setup.VALUE == "Shell") && this.isShowHeatmap) {
                                    const indexValue = this.oList_Dimension_index_for_floors.find(oDimension_index_By_Level => oDimension_index_By_Level.LEVEL_ID == floorWithGltf.floor.FLOOR_ID).LIST_DIMENSION_INDEX.find(oDimension_index => oDimension_index.DIMENSION_METADATA.DIMENSION_ID == this.oDimension.DIMENSION_ID).VALUE;
                                    object3d.material.color = indexValue > (this.high_threshhold ?? 66) ? new Color('#22C55E') : indexValue > (this.low_threshhold ?? 33) ? new Color('#F59E0B') : new Color('#EF4444');
                                }
                            }
                        })

                        if (this.oChosen_Render_Type_Setup.VALUE == "Floor Stack") {
                            floorGltf.position.set(0, 0 + this.minSize * i, 0);
                        }
                        floorGltf.scale.set(
                            1, 1, 1
                        );

                        var bbox = new Box3().setFromObject(floorGltf);
                        var cent = bbox.getCenter(new Vector3());
                        var size = bbox.getSize(new Vector3());

                        this.oOriginal_YPosition_For_All_Floors.push({
                            floor: floorWithGltf.floor,
                            yPosition: floorGltf.position.y,
                            ySize: size.y,
                            yCenter: cent.y,
                        });
                        if (floorWithGltf.gltfData.scene.children[0] instanceof Mesh) {
                            floorWithGltf.gltfData.scene.children[0].material.color.set(0x807566);
                        }
                        floorGltf.name = floorWithGltf.floor.FLOOR_ID.toString();
                        if (floorWithGltf.floor.FLOOR_ID == 52 || floorWithGltf.floor.FLOOR_ID == 4 || floorWithGltf.floor.FLOOR_ID == 12 || floorWithGltf.floor.FLOOR_ID == 35 || floorWithGltf.floor.FLOOR_ID == 25 || floorWithGltf.floor.FLOOR_ID == 60 || floorWithGltf.floor.FLOOR_ID == 75 || floorWithGltf.floor.FLOOR_ID == 93 || floorWithGltf.floor.FLOOR_ID == 100) {
                            this.oGLTF_Loader.load(`${this.CmSvc.Asset_Endpoint}/GLTF/OVERLAY ICONS/Generic asset MEP red.glb`, (gltf) => {
                                this.oList_Alert_With_GLTF.push({
                                    floorNumber: floorWithGltf.floor.FLOOR_NUMBER,
                                    gltfData: gltf,
                                });
                                var camGltf = gltf.scene;
                                camGltf.name = "Alert " + this.alertId++ + " On " + floorWithGltf.floor.NAME;
                                camGltf.scale.set(size.x / 2.2, size.x / 2.2, size.x / 2.2);
                                camGltf.position.set(-size.x * 1.2 / 2 + cent.x, cent.y - size.y / 2, 0);
                                this.oOriginal_YPosition_For_All_Alerts.push({
                                    floorNumber: floorWithGltf.floor.FLOOR_NUMBER,
                                    vectorPosition: cloneDeep(camGltf.position),
                                });
                                sceneFloor.add(camGltf);
                            });
                        }

                        sceneFloor.add(floorGltf)
                    });

                    var bbox = new Box3().setFromObject(sceneFloor);
                    var cent = bbox.getCenter(new Vector3());
                    var size = bbox.getSize(new Vector3());
                    sceneFloor.position.set(0, 0, 0);
                    var maxAxis = Math.max(size.x, size.y, size.z);
                    sceneFloor.scale.multiplyScalar(1.0 / maxAxis);
                    bbox.setFromObject(sceneFloor);
                    bbox.getCenter(cent);
                    bbox.getSize(size);
                    sceneFloor.position.copy(cent).multiplyScalar(-1);

                    this.oScene.add(sceneFloor);
                    this.isRendererIdle = true;
                }).catch();
            } else {
                this.oGLTF_Loader.load(this.oEntity.SOLID_GLTF_URL, GLTF => {
                    if (this.oChosen_Render_Type_Setup.VALUE == "Solid") {
                        GLTF.scene.position.set(0, 0, 0);
                        GLTF.scene.scale.set(
                            1, 1, 1
                        )
                        var currentGltf = GLTF.scene;
                        currentGltf.name = this.oEntity.NAME;
                        var bbox = new Box3().setFromObject(currentGltf);
                        var cent = bbox.getCenter(new Vector3());
                        var size = bbox.getSize(new Vector3());

                        currentGltf.position.set(0, 0, 0);
                        var maxAxis = Math.max(size.x, size.y, size.z);
                        currentGltf.scale.multiplyScalar(1.0 / maxAxis);
                        bbox.setFromObject(currentGltf);
                        bbox.getCenter(cent);
                        bbox.getSize(size);
                        currentGltf.position.copy(cent).multiplyScalar(-1);

                        this.oScene.add(currentGltf);
                        this.isRendererIdle = true;
                    }
                })
            }

            this.oRenderer.setAnimationLoop(() => {
                this.oRenderer.render(this.oScene, this.oPerspective_Camera);
            });
            this.isContentLoaded = true;
        } catch (e) {
        }
    }

    setRenderType() {
        if (this.isRendererIdle) {
            this.isRendererIdle = false;
            this.cleanScene();
            this.iContainer1 = document.getElementById('rendering-container');
            this.buildingViewChangeEventEmitter.emit();
            this.renderFloors();
        } else {
            this.CmSvc.ShowMessage("Please wait for the current entity to render");
        }
    }

    cleanScene() {
        if (this.oScene) {
            while (this.oScene.children.length > 0) {
                this.oScene.remove(this.oScene.children[0]);
            }
        }
    }

    Dispose() {
        this.oRenderer.dispose();
        this.oRenderer.forceContextLoss();
        this.oRenderer.domElement = null;
    }

    dimensionClicked() {
        if (!this.isShareView) {
            this.MapService.oOpen_Entity_Summary_Drawer_Subject.next(this.oDimension_index_for_entity);
        }
    }

    onClick(event) {
        event.preventDefault();
        if ((this.oChosen_Render_Type_Setup.VALUE != "Floor Stack" && this.oChosen_Render_Type_Setup.VALUE != "Shell") || this.isChangingFloor) {
            return;
        }
        var mouse = new Vector2(0, 0);
        mouse.x = (event.offsetX / this.oRenderer.domElement.clientWidth) * 2 - 1;
        mouse.y = -(event.offsetY / this.oRenderer.domElement.clientHeight) * 2 + 1;
        var raycaster = new Raycaster();
        raycaster.setFromCamera(mouse, this.oPerspective_Camera);
        var intersects = raycaster.intersectObjects(this.oScene.children);
        if (this.oSelected_Floor) {
            var parent = this.findParent(this.oSelected_Floor.gltfData.scene);
            if (parent) {
                this.rePaintMesh(parent);
            }
            this.oSelected_Floor = null;
        }
        if (intersects.length) {
            this.oOriginal_Material_For_Selected_Floor = [];
            var parent = this.findParent(intersects[0].object);
            if (parent) {
                this.oSelected_Floor = this.oList_Floor_With_GLTF.filter(floor => floor.floor.FLOOR_ID.toString() == parent.name)[0];
                parent = this.findParent(this.oSelected_Floor.gltfData.scene);
                this.paintMesh(parent);
                this.MapService.oFloor_Selected_Subject.next(this.oSelected_Floor.floor);
                this.BdcWalkService.setTaskCompleted('drawerPopup3', true);
            }
        }
    }
    completeExtraPopup3() {
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup3', true);
    }

    ngOnDestroy(): void {
        setTimeout(() => {
            this.Dispose();
        }, 400);
    }
}
