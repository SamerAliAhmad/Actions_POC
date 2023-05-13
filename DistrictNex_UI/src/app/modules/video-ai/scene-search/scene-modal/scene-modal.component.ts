import { ChangeDetectorRef, Component, EventEmitter, HostListener, Injector, Input, OnInit, Output, ViewChild } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SafeResourceUrl } from '@angular/platform-browser';
import { Displayed_Category } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Scene_Info, Scene_Object, Video_ai_asset } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { cloneDeep } from 'lodash';
import { CarouselComponent, OwlOptions } from 'ngx-owl-carousel-o';
import { VideoAIService } from '../../video-ai.service';

@Component({
    selector: 'scene-modal',
    templateUrl: './scene-modal.component.html',
    styleUrls: ['./scene-modal.component.scss']
})
export class SceneModalComponent implements OnInit {
    @Input() isShareView = false;
    @Input() data: any;
    @Input() isFromComponent = false;
    @Output() goBackEventEmitter = new EventEmitter<void>();
    @Output() goForwardEventEmitter = new EventEmitter<void>();
    @ViewChild('owlCar') owlCarousel: CarouselComponent;

    oSceneId: number;
    oScene: Scene_Info;
    oCameraName: string;
    oCamera: Video_ai_asset;
    sceneFile: SafeResourceUrl;
    loopZoom = 3;
    imageWidth = 0;
    cameraWidth = 0;
    imageHeight = 0;
    cameraHeight = 0;

    isBoxOn = false;
    isLoopOn = false;
    isImageLoaded = false;
    isAdvancedSearch: boolean = false;

    searchBoxValue: string = '';
    mainDataContainerHeight = 400;
    realSceneObjects: Scene_Object[];
    realSelectedObject: Scene_Object;
    selectedObject: Scene_Object = null;
    oList_Selected_Search_Categories: any[] = [];
    oList_Search_Categories: Displayed_Category[] = [];

    emailSending = false;
    displayEmailEntry = false;
    oList_Email: string[] = [];
    emailFormControl: FormControl;

    Asset_Endpoint: string;

    customOptions: OwlOptions = {
        loop: true,
        mouseDrag: true,
        touchDrag: true,
        pullDrag: true,
        dots: false,
        navSpeed: 700,
        items: 5,
        center: true,
        nav: true,
        navText: [
            '<i class="fa fa-angle-left" aria-hidden="true"></i>',
            '<i class="fa fa-angle-right" aria-hidden="true"></i>'
        ],
    }

    constructor(
        private Injector: Injector,
        private CmSvc: CommonService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.Asset_Endpoint = this.CmSvc.Asset_Endpoint;
        this.emailFormControl = new FormControl('', [Validators.required, Validators.email]);
    }

    ngOnInit(): void {
        this.VideoAIService.getStreamData(1).then(() => {
            this.isBoxOn = true;
            if (!this.isFromComponent) {
                this.data = this.Injector.get(MAT_DIALOG_DATA);
                this.oCameraName = this.data.cameraName;
                this.isBoxOn = false;
                this.oCamera = this.data.camera;
            }
            else {
                this.oCamera = this.CmSvc.oStream_Data.List_Video_ai_asset.find(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == this.data.camera.CameraId)
                this.oCameraName = this.data.camera.Name;
            }
            this.cameraWidth = this.oCamera.RESOLUTION_X;
            this.cameraHeight = this.oCamera.RESOLUTION_Y;
            this.oList_Search_Categories = this.data.oList_Search_Categories;
            this.oList_Selected_Search_Categories = this.data.oList_Selected_Search_Categories;
            this.searchBoxValue = this.data.searchBoxValue;
            this.isAdvancedSearch = this.data.isAdvancedSearch;

            this.oSceneId = this.data.sceneId;
            if (!this.isFromComponent) {
                this.VideoAIService.getSceneInfo(this.data.sceneId, this.data.camera.VIDEO_AI_INSTANCE_ID, null).then(scene => {
                    const oChosenObjects = scene.SCENE_OBJECT_LIST.filter(sceneObject => this.isAdvancedSearch ? this.searchBoxValue.toLowerCase().includes(sceneObject.ObjectType.toLowerCase()) : this.oList_Selected_Search_Categories.some(searchCategory => searchCategory.value.toLowerCase() == sceneObject.ObjectType.toLowerCase()));
                    if (oChosenObjects.length > 0) {
                        scene.SCENE_OBJECT_LIST = oChosenObjects;
                    }
                    this.oScene = scene;
                    this.sceneFile = this.Sanitize(this.oScene.SCENE_DETAILS.File);
                    this.realSceneObjects = cloneDeep(scene.SCENE_OBJECT_LIST);
                })
            } else {
                this.VideoAIService.getSceneInfo(this.data.sceneId, this.data.instanceID, this.data.alertObjectType).then(scene => {
                    if (this.oList_Selected_Search_Categories[0] == "Nothing") {
                        scene.SCENE_OBJECT_LIST = [];
                    }
                    if (scene.SCENE_OBJECT_LIST?.length > 0 && this.oList_Selected_Search_Categories && this.oList_Selected_Search_Categories?.length > 0) {
                        const chosenObjectList = scene.SCENE_OBJECT_LIST.filter(sceneObject => this.oList_Selected_Search_Categories.some(searchCategory => searchCategory.toLowerCase() == sceneObject.ObjectType.toLowerCase()));
                        chosenObjectList.forEach(chosenObject => {
                            const splicedObject = scene.SCENE_OBJECT_LIST.splice(scene.SCENE_OBJECT_LIST.indexOf(chosenObject), 1)[0];
                            scene.SCENE_OBJECT_LIST.unshift(splicedObject);
                        });
                    }
                    this.oScene = scene;
                    this.sceneFile = this.Sanitize(this.oScene.SCENE_DETAILS.File);
                    this.realSceneObjects = cloneDeep(scene.SCENE_OBJECT_LIST);
                })
            }
        })
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    changeScene(sceneId: number, Video_Ai_Instance_Id: number) {
        this.isImageLoaded = false;
        this.oScene = null;
        this.oSceneId = sceneId;
        this.VideoAIService.getSceneInfo(sceneId, Video_Ai_Instance_Id, null).then(scene => {
            const oChosenObjects = scene.SCENE_OBJECT_LIST.filter(sceneObject => this.isAdvancedSearch ? this.searchBoxValue.toLowerCase().includes(sceneObject.ObjectType.toLowerCase()) : this.oList_Selected_Search_Categories.some(searchCategory => searchCategory.value.toLowerCase() == sceneObject.ObjectType.toLowerCase()));
            if (oChosenObjects.length > 0) {
                scene.SCENE_OBJECT_LIST = oChosenObjects;
            }
            this.oScene = scene;
            this.sceneFile = this.Sanitize(this.oScene.SCENE_DETAILS.File);
            this.realSceneObjects = cloneDeep(scene.SCENE_OBJECT_LIST);
        })
    }

    imageLoaded() {
        this.isImageLoaded = true;
        let img = document.getElementById("myimage");
        this.imageWidth = img.offsetWidth;
        this.imageHeight = img.offsetHeight;
        this.mainDataContainerHeight = document.getElementById("main-data-container").offsetHeight;
        this.oScene.SCENE_OBJECT_LIST = this.oScene.SCENE_OBJECT_LIST.map(object => {
            object.W = object.W * img.offsetWidth / this.cameraWidth;
            object.H = object.H * img.offsetHeight / this.cameraHeight;
            object.X = object.X * img.offsetWidth / this.cameraWidth;
            object.Y = object.Y * img.offsetHeight / this.cameraHeight;
            return object;
        });
        this.selectObject(this.oScene.SCENE_OBJECT_LIST[0], 0);
    }

    @HostListener("wheel", ["$event"])
    public onScroll(event: WheelEvent) {
        if (this.isLoopOn) {
            if (event.deltaY < 0 && this.loopZoom < 8) {
                this.loopZoom += 0.1;
                this.loopZoom = Math.round(this.loopZoom * 100) / 100;
                let pos = this.getCursorPosFromWheel(event);
                this.fixMagnification(pos.x, pos.y);
            }
            if (event.deltaY > 0 && this.loopZoom > 0.5) {
                this.loopZoom -= 0.1;
                this.loopZoom = Math.round(this.loopZoom * 100) / 100;
                let pos = this.getCursorPosFromWheel(event);
                this.fixMagnification(pos.x, pos.y);
            }
        }
    }

    isDark() {
        return this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-button'));
    }

    goBack() {
        this.goBackEventEmitter.emit();
    }

    goForward() {
        this.goForwardEventEmitter.emit();
    }

    getObjectScale(object: Scene_Object) {
        return Math.min(96 / object.W, 96 / object.H);
    }

    selectObject(object: Scene_Object, index: number) {
        this.selectedObject = object;
        this.realSelectedObject = this.realSceneObjects.filter(oObject => oObject.SceneObjectId == object.SceneObjectId)[0];
        if (this.owlCarousel) {
            this.owlCarousel.to(index.toString());
        }
    }

    getCursorPosFromWheel(event: WheelEvent) {
        let img = document.getElementById("myimage");
        var a,
            x = 0,
            y = 0;
        /*get the x and y positions of the image:*/
        a = img.getBoundingClientRect();
        /*calculate the cursor's x and y coordinates, relative to the image:*/
        x = event.pageX - a.left;
        y = event.pageY - a.top;
        /*consider any page scrolling:*/
        x = x - window.pageXOffset;
        y = y - window.pageYOffset;
        return { x: x, y: y };
    }

    toggleLoop() {
        this.isLoopOn = !this.isLoopOn;
        this._changeDetectorRef.detectChanges();
        if (this.isLoopOn) {
            this.magnify();
        }
    }

    toggleBoxes() {
        this.isBoxOn = !this.isBoxOn;
    }

    toggleEmailSend(): void {
        this.displayEmailEntry = !this.displayEmailEntry;
    }

    fixMagnification(xPos = null, yPos = null) {
        var img, glass, w, h, bw;
        img = document.getElementById("myimage");
        /*create magnifier glass:*/
        glass = document.getElementById("magnifier");
        /*set background properties for the magnifier glass:*/
        glass.style.backgroundSize = img.offsetWidth * this.loopZoom + "px " + img.offsetHeight * this.loopZoom + "px";
        bw = 3;
        w = 50;
        h = 50;
        let loopZoom = this.loopZoom;

        var x, y;
        if (xPos && yPos) {
            x = xPos;
            y = yPos;
            if (x > img.offsetWidth || x < 0 || y > img.offsetHeight || y < 0) {
                glass.style.display = 'none';
            } else {
                glass.style.display = 'block';
            }
            /*set the position of the magnifier glass:*/
            glass.style.left = x - w + "px";
            glass.style.top = y - h + "px";
            /*display what the magnifier glass "sees":*/
            if ((x * loopZoom - w + bw) >= 0 && (y * loopZoom - h + bw) >= 0) {
                glass.style.backgroundPosition = "-" + (x * loopZoom - w + bw) + "px -" + (y * loopZoom - h + bw) + "px";
            } else if ((x * loopZoom - w + bw) <= 0 && (y * loopZoom - h + bw) <= 0) {
                glass.style.backgroundPosition = (-(x * loopZoom - w + bw)) + "px " + (-(y * loopZoom - h + bw)) + "px";
            } else if ((x * loopZoom - w + bw) <= 0) {
                glass.style.backgroundPosition = (-(x * loopZoom - w + bw)) + "px -" + (y * loopZoom - h + bw) + "px";
            } else if ((y * loopZoom - h + bw) <= 0) {
                glass.style.backgroundPosition = "-" + (x * loopZoom - w + bw) + "px " + (-(y * loopZoom - h + bw)) + "px";
            }
        }
    }

    magnify() {
        var img, glass, w, h, bw;
        img = document.getElementById("myimage");
        /*create magnifier glass:*/
        glass = document.getElementById("magnifier");
        /*set background properties for the magnifier glass:*/
        glass.style.backgroundSize = img.offsetWidth * this.loopZoom + "px " + img.offsetHeight * this.loopZoom + "px";
        bw = 3;
        w = 50;
        h = 50;
        /*execute a function when someone moves the magnifier glass over the image:*/
        glass.addEventListener("mousemove", (e) => moveMagnifier(e, this.loopZoom));
        img.addEventListener("mousemove", (e) => moveMagnifier(e, this.loopZoom));
        /*and also for touch screens:*/
        glass.addEventListener("touchmove", (e) => moveMagnifier(e, this.loopZoom));
        img.addEventListener("touchmove", (e) => moveMagnifier(e, this.loopZoom));
        function moveMagnifier(e, zoom) {
            var pos, x, y;
            /*prevent any other actions that may occur when moving over the image*/
            e.preventDefault();
            /*get the cursor's x and y positions:*/
            pos = getCursorPos(e);
            x = pos.x;
            y = pos.y;
            if (x > img.offsetWidth || x < 0 || y > img.offsetHeight || y < 0) {
                glass.style.display = 'none';
            } else {
                glass.style.display = 'block';
            }
            /*set the position of the magnifier glass:*/
            glass.style.left = x - w + "px";
            glass.style.top = y - h + "px";
            /*display what the magnifier glass "sees":*/
            if ((x * zoom - w + bw) >= 0 && (y * zoom - h + bw) >= 0) {
                glass.style.backgroundPosition = "-" + (x * zoom - w + bw) + "px -" + (y * zoom - h + bw) + "px";
            } else if ((x * zoom - w + bw) <= 0 && (y * zoom - h + bw) <= 0) {
                glass.style.backgroundPosition = (-(x * zoom - w + bw)) + "px " + (-(y * zoom - h + bw)) + "px";
            } else if ((x * zoom - w + bw) <= 0) {
                glass.style.backgroundPosition = (-(x * zoom - w + bw)) + "px -" + (y * zoom - h + bw) + "px";
            } else if ((y * zoom - h + bw) <= 0) {
                glass.style.backgroundPosition = "-" + (x * zoom - w + bw) + "px " + (-(y * zoom - h + bw)) + "px";
            }
        }
        function getCursorPos(e) {
            var a,
                x = 0,
                y = 0;
            e = e || window.event;
            /*get the x and y positions of the image:*/
            a = img.getBoundingClientRect();
            /*calculate the cursor's x and y coordinates, relative to the image:*/
            x = e.pageX - a.left;
            y = e.pageY - a.top;
            /*consider any page scrolling:*/
            x = x - window.pageXOffset;
            y = y - window.pageYOffset;
            return { x: x, y: y };
        }
    }

    sendEmail() {
        if (this.oList_Email.length == 0) {
            this.CmSvc.ShowMessage("You must add at least 1 email");
            return;
        }
        this.emailSending = true;
        if (this.data?.camera) {
            this.oScene.SCENE_DETAILS.Camera = this.data.camera;
        }
        this.VideoAIService.Send_Alerts_Email(this.oScene.SCENE_DETAILS, this.data.incident, this.oList_Email.join(",")).then(result => {
            if (result) {
                this.toggleEmailSend();
                this.CmSvc.ShowMessage("Email Sent!");
                this.oList_Email = [];
                this.emailFormControl.patchValue(null);
                this.emailFormControl.reset();
            }
            this.emailSending = false;
        });
    }

    addEmailToList() {
        if (this.emailFormControl.valid) {
            this.oList_Email.push(this.emailFormControl.value);
            this.emailFormControl.patchValue(null);
            this.emailFormControl.reset();
        }
        else {
            this.CmSvc.ShowMessage("Invalid Email")
        }
    }

    removeEmail(email: string) {
        this.oList_Email.splice(this.oList_Email.indexOf(email), 1);
    }
}
