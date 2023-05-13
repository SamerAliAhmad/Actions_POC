import { Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges, ViewChild } from '@angular/core';
import { Space_asset_with_gltf } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Enum_Dimension_Status, Floor, Level_Dimension_with_Status, Space_asset, Wifi_signal } from 'app/core/Services/proxy.service';
import { ViewShareService } from 'app/modules/view-share/view-share.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import * as $ from 'jquery';
import { cloneDeep } from 'lodash';
import { SlickCarouselComponent } from 'ngx-slick-carousel';
import { Box3, DirectionalLight, HemisphereLight, Mesh, PerspectiveCamera, Scene, Vector3, WebGLRenderer } from 'three';
import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls';
import { GLTFLoader } from 'three/examples/jsm/loaders/GLTFLoader';
import { Raycaster, Vector2 } from 'three/src/Three';
import { MapService } from '../../map.service';

@Component({
    selector: 'floor-renderer',
    templateUrl: './floor-renderer.component.html',
    styleUrls: ['./floor-renderer.component.scss']
})
export class FloorRendererComponent implements OnInit, OnChanges, OnDestroy {

    @Input() isShareView = false;
    @Input() oFloor: Floor;
    @Input() oEntity: Entity;

    @Input() isChangingFloor: boolean;
    @Input() isShowExpansion: boolean = false;

    @Input() container_id = "floorContainer"

    @Input() oList_Wifi_signal: Wifi_signal[] = [];

    @Output() dragDisableEventEmitter = new EventEmitter();
    @Output() oOpenExpandedViewEventEmitter = new EventEmitter();

    @ViewChild('slickModal') slickModal: SlickCarouselComponent;

    iContainer1: HTMLElement;

    lastSlide = null;
    slideConfig = {
        "slidesToShow": 5,
        "slidesToScroll": 1,
        "focusOnSelect": true,
        "centerMode": true,
        "waitForAnimate": false,
        "infinite": false
    };
    oScene: Scene;
    oOrbit_Controls: OrbitControls;
    oGLTF_Loader = new GLTFLoader();
    oPerspective_Camera: PerspectiveCamera;
    oSpace_asset_hovered: Space_asset = null;
    oWifi_signal_hovered: Wifi_signal = null;
    oHemisphere_Light: HemisphereLight = new HemisphereLight();
    oDirectional_Light: DirectionalLight = new DirectionalLight();
    oRenderer = new WebGLRenderer({ antialias: true, alpha: true, preserveDrawingBuffer: true });

    oList_Space_asset: Space_asset[] = [];
    oList_Space_asset_with_gltf: Space_asset_with_gltf[] = [];
    oList_Level_Dimension_with_Status: Level_Dimension_with_Status[] = [];

    contentLoaded = false;

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        public TimezoneService: TimezoneService,
        private ViewShareService: ViewShareService,
    ) {
        this.oGLTF_Loader.setDRACOLoader(this.MapService.oDRACOLoader);
    }

    ngOnInit(): void {
        if (this.oEntity.List_Floor.length < 5) {
            this.slideConfig.slidesToShow = 3;
            if (this.oEntity.List_Floor.length < 3) {
                this.slideConfig.slidesToShow = 1;
            }
        }
        this.oFloor.List_Space.forEach(oSpace => {
            if (oSpace.List_Space_asset && oSpace.List_Space_asset.length > 0) {
                this.oList_Space_asset = ([].concat(...oSpace.List_Space_asset));
            }
        });
        this.oList_Space_asset = ([].concat(...this.oFloor.List_Space.map(space => space.List_Space_asset)) as Space_asset[])
        this.oDirectional_Light.intensity = 1;
        this.oDirectional_Light.position.set(0, 1, 0);
        this.oHemisphere_Light.groundColor.set(0x0f0e0d);
        this.oHemisphere_Light.intensity = 5;
        if (!this.isShareView) {
            this.oList_Level_Dimension_with_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension_With_Status => oLevel_Dimension_With_Status.DATA_LEVEL_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity") && oLevel_Dimension_With_Status.LEVEL_ID_LIST.includes(this.oEntity.ENTITY_ID));
        } else {
            this.oList_Level_Dimension_with_Status = this.ViewShareService.oEntity_share_view_data.List_Entity_Level_Dimension_with_Status;
        }
    }

    onClick(event) {
        event.preventDefault();
        var mouse = new Vector2(0, 0);
        mouse.x = (event.offsetX / this.oRenderer.domElement.clientWidth) * 2 - 1;
        mouse.y = -(event.offsetY / this.oRenderer.domElement.clientHeight) * 2 + 1;
        var raycaster = new Raycaster();
        raycaster.setFromCamera(mouse, this.oPerspective_Camera);

        var intersects = raycaster.intersectObjects(this.oScene.children);
        if (intersects && intersects.length > 0 && this.oList_Space_asset) {
            const oSpace_asset = this.oList_Space_asset.find(asset => asset.SPACE_ASSET_ID.toString() == intersects[0].object.name);
            if (oSpace_asset) {
                if (oSpace_asset.Asset.NAME == "Wifi Signal" && this.oList_Level_Dimension_with_Status.find(level_dimension_with_status => level_dimension_with_status.DIMENSION.NAME.toLowerCase().includes("living"))?.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.ENABLED) {
                    return;
                }
                this.MapService.oAsset_Changed_Subject.next(oSpace_asset)
            }
        } else {
        }
    }

    beforeChange(e) {
        this.lastSlide = e.nextSlide;
        if (this.isChangingFloor) {
            return;
        }
        if (this.lastSlide != this.oFloor.FLOOR_NUMBER - this.oEntity.List_Floor[0].FLOOR_NUMBER) {
            const floor = this.oEntity.List_Floor.filter(floor => floor.FLOOR_NUMBER == this.lastSlide + this.oEntity.List_Floor[0].FLOOR_NUMBER)[0]
            this.MapService.oFloor_Selected_Subject.next(floor);
        }
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

            if (intersects.length && Number(intersects[0].object.name)) {
                $('html,body').css('cursor', 'pointer');
                this.oSpace_asset_hovered = cloneDeep(this.oList_Space_asset.filter(asset => asset.SPACE_ASSET_ID.toString() == intersects[0].object.name)[0]);
                switch (this.oSpace_asset_hovered.Asset.Asset_type_setup.VALUE) {
                    case "Camera":
                        this.oSpace_asset_hovered.ASSET_ICON = "heroicons_outline:video-camera";
                        this.oSpace_asset_hovered.CUSTOM_NAME = this.oSpace_asset_hovered.List_Video_ai_asset[0] ? this.oSpace_asset_hovered.List_Video_ai_asset[0].FRIENDLY_NAME : 'CCTV Camera';
                        break;
                    case "Alert":
                        this.oSpace_asset_hovered.ASSET_ICON = "heroicons_outline:exclamation-circle";
                        switch (this.oSpace_asset_hovered.Asset.NAME) {
                            case "Low Alert":
                                this.oSpace_asset_hovered.CUSTOM_NAME = 'Access Control Alert';
                                break;
                            case "Medium Alert":
                                this.oSpace_asset_hovered.CUSTOM_NAME = 'Suspicious Activity';
                                this.oSpace_asset_hovered.ASSET_ICON = "mat_outline:security";
                                break;
                            case "High Alert":
                                this.oSpace_asset_hovered.CUSTOM_NAME = 'Fire Detected';
                                this.oSpace_asset_hovered.ASSET_ICON = "mat_outline:local_fire_department";
                                break;
                        }
                        break;
                    case "Wifi Signal":
                        if (this.oList_Wifi_signal) {
                            this.oWifi_signal_hovered = this.oList_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == this.oSpace_asset_hovered.SPACE_ASSET_ID);
                            this.oSpace_asset_hovered.ASSET_ICON = "mat_outline:signal_wifi_4_bar";
                            if (this.oWifi_signal_hovered) {
                                this.oSpace_asset_hovered.CUSTOM_NAME += " | RSSI: " + this.oWifi_signal_hovered.VALUE + "dBm"
                                if (this.oWifi_signal_hovered.VALUE < -80) {
                                    this.oSpace_asset_hovered.ASSET_ICON = "mat_outline:signal_wifi_statusbar_connected_no_internet_4";
                                } else if (this.oWifi_signal_hovered.VALUE < -65) {
                                    this.oSpace_asset_hovered.ASSET_ICON = "mat_outline:signal_wifi_0_bar";
                                }
                            }
                        }
                        break;
                }
            } else {
                $('html,body').css('cursor', 'default');
                this.oSpace_asset_hovered = null;
            }
        }
    }


    ngAfterViewInit() {
        this.iContainer1 = document.getElementById(this.container_id);
        this.iContainer1.appendChild(this.oRenderer.domElement);
        if (!this.isShareView) {
            this.iContainer1.addEventListener('click', e => { this.onClick(e) });
        }
        this.iContainer1.addEventListener('mousemove', e => { this.onHover(e) })
        this.renderFloor();
        let resizeObserver = new ResizeObserver(() => {
            if (this.oRenderer.domElement) {
                this.oRenderer.setSize(this.iContainer1.clientWidth, this.iContainer1.clientHeight);
                this.oRenderer.setPixelRatio(window.devicePixelRatio);
                this.oPerspective_Camera.aspect = this.iContainer1.offsetWidth / this.iContainer1.offsetHeight;
                this.oPerspective_Camera.updateProjectionMatrix()
                if (this.slickModal && this.slickModal.$instance) {
                    this.slickModal.$instance.slick('setPosition');
                    if (this.oFloor) {
                        this.slickModal.slickGoTo(this.oFloor.FLOOR_NUMBER);
                    }
                }
            }
        });
        resizeObserver.observe(this.iContainer1);
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (this.contentLoaded && changes['oFloor']) {
            this.oFloor.List_Space.forEach(oSpace => {
                if (oSpace.List_Space_asset && oSpace.List_Space_asset.length > 0) {
                    this.oList_Space_asset = ([].concat(...oSpace.List_Space_asset));
                }
            })
            this.oList_Space_asset = ([].concat(...this.oFloor.List_Space.map(space => space.List_Space_asset)) as Space_asset[])
            this.cleanScene();
            if (this.lastSlide != this.oFloor.FLOOR_NUMBER - this.oEntity.List_Floor[0].FLOOR_NUMBER) {
                this.slickModal.slickGoTo(this.oFloor.FLOOR_NUMBER - this.oEntity.List_Floor[0].FLOOR_NUMBER)
            }
            this.renderFloor();
        }
        if (this.contentLoaded && changes['oList_Wifi_signal'] && this.oList_Wifi_signal) {
            this.oList_Space_asset_with_gltf.forEach(space_asset_with_gltf => {
                if (space_asset_with_gltf.Space_asset.Asset.Asset_type_setup.VALUE == "Wifi Signal") {
                    let oWifi_signal = this.oList_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == space_asset_with_gltf.Space_asset.SPACE_ASSET_ID);
                    if (oWifi_signal) {
                        if (oWifi_signal.VALUE >= -65) {
                            space_asset_with_gltf.gltfData.scene.traverse(childGltf => {
                                if (childGltf instanceof Mesh) {
                                    childGltf.material.color.set(0x00FF00);
                                }
                            });
                        } else if (oWifi_signal.VALUE >= -80) {
                            space_asset_with_gltf.gltfData.scene.traverse(childGltf => {
                                if (childGltf instanceof Mesh) {
                                    childGltf.material.color.set(0xFFFF00);
                                }
                            });
                        } else {
                            space_asset_with_gltf.gltfData.scene.traverse(childGltf => {
                                if (childGltf instanceof Mesh) {
                                    childGltf.material.color.set(0xFF0000);
                                }
                            });
                        }
                    }
                }
            });
        }
    }
    cleanScene() {
        while (this.oScene.children.length > 0) {
            this.oScene.remove(this.oScene.children[0]);
        }
    }

    renderFloor() {
        try {
            this.oScene = new Scene();
            this.oRenderer.setClearColor(0x000000, 0);
            this.oPerspective_Camera = new PerspectiveCamera(
                35,
                this.iContainer1.offsetWidth / this.iContainer1.offsetHeight,
                0.01,
                1000
            );
            this.oPerspective_Camera.position.set(0, 1.3, 1.3);
            this.oOrbit_Controls = new OrbitControls(this.oPerspective_Camera, this.iContainer1);
            this.oDirectional_Light.position.set(10, 10, 10);
            this.oScene.add(this.oHemisphere_Light, this.oDirectional_Light);
            this.oRenderer.setSize(this.iContainer1.clientWidth, this.iContainer1.clientHeight);
            this.oRenderer.setPixelRatio(window.devicePixelRatio);
            this.oRenderer.useLegacyLights = false;

            this.oGLTF_Loader.load(this.oFloor.ADVANCED_GLTF_URL, (GLTF) => {
                let floorScene = new Scene();
                const box = new Box3().setFromObject(GLTF.scene);
                const center = box.getCenter(new Vector3());

                GLTF.scene.rotation.set(0, 0, 0);
                GLTF.scene.position.x -= center.x;
                GLTF.scene.position.y -= center.y;
                GLTF.scene.position.z -= center.z;
                const model = GLTF.scene;

                floorScene.add(model);
                if (this.oList_Space_asset && this.oList_Space_asset.length > 0) {
                    this.oList_Space_asset_with_gltf = [];
                    this.oList_Space_asset.forEach(oSpace_asset => {
                        if (oSpace_asset != null) {
                            this.oGLTF_Loader.load(oSpace_asset.Asset.GLTF_URL, (GLTF) => {
                                this.oList_Space_asset_with_gltf.push({
                                    gltfData: GLTF,
                                    Space_asset: oSpace_asset,
                                });
                                var assetGltf = GLTF.scene
                                assetGltf.position.set(oSpace_asset.POSITION_X, 10, oSpace_asset.POSITION_Z);
                                if (!oSpace_asset.Asset.Asset_type_setup) {
                                    oSpace_asset.Asset.Asset_type_setup = this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("asset type", oSpace_asset.Asset.ASSET_TYPE_SETUP_ID);
                                }
                                if (oSpace_asset.Asset.Asset_type_setup.VALUE == "Alert") {
                                    assetGltf.rotation.set(0, Math.PI / 2, 0);
                                }
                                assetGltf.scale.set(oSpace_asset.SCALE_MULTIPLIER, oSpace_asset.SCALE_MULTIPLIER, oSpace_asset.SCALE_MULTIPLIER)
                                assetGltf.children.forEach(child => {
                                    child.name = oSpace_asset.SPACE_ASSET_ID.toString();
                                });
                                if (this.oList_Wifi_signal && oSpace_asset.Asset.Asset_type_setup.VALUE == "Wifi Signal") {
                                    let oWifi_signal = this.oList_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID);
                                    if (oWifi_signal) {
                                        if (oWifi_signal.VALUE <= 65) {
                                            assetGltf.traverse(childGltf => {
                                                if (childGltf instanceof Mesh) {
                                                    childGltf.material.color.set(0x00FF00);
                                                }
                                            });
                                        } else if (oWifi_signal.VALUE <= 80) {
                                            assetGltf.traverse(childGltf => {
                                                if (childGltf instanceof Mesh) {
                                                    childGltf.material.color.set(0xFFFF00);
                                                }
                                            });
                                        } else {
                                            assetGltf.traverse(childGltf => {
                                                if (childGltf instanceof Mesh) {
                                                    childGltf.material.color.set(0xFF0000);
                                                }
                                            });
                                        }
                                    }
                                }
                                floorScene.add(assetGltf);
                            })
                        }
                    });
                }
                var bbox = new Box3().setFromObject(floorScene);
                var cent = bbox.getCenter(new Vector3());
                var size = bbox.getSize(new Vector3());

                floorScene.position.set(0, 0, 0);
                var maxAxis = Math.max(size.x, size.y, size.z);
                floorScene.scale.multiplyScalar(1.0 / maxAxis);
                bbox.setFromObject(floorScene);
                bbox.getCenter(cent);
                bbox.getSize(size);
                floorScene.position.copy(cent).multiplyScalar(-1);

                this.oScene.add(floorScene);
            })
            this.oRenderer.setAnimationLoop(() => {
                this.oRenderer.render(this.oScene, this.oPerspective_Camera);
            });
            this.contentLoaded = true;
            if (this.slickModal && this.slickModal.$instance) {
                this.slickModal.$instance.slick('setPosition');
            }
        } catch (e) {
            this.CmSvc.ShowMessage(e, 2000);
        }
    }

    expandFloorRenderer() {
        this.MapService.oOpen_Expanded_Floor_Renderer.next({ FLOOR: this.oFloor, isChangingFloor: this.isChangingFloor });
    }

    Dispose() {
        this.oRenderer.dispose();
        this.oRenderer.forceContextLoss();
        this.oRenderer.domElement = null;
    }
    ngOnDestroy(): void {
        setTimeout(() => {
            this.Dispose();
        }, 400);
    }
}
