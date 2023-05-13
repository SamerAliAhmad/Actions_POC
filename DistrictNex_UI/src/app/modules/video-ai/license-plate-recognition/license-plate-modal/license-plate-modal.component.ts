import { ChangeDetectorRef, Component, HostListener, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SafeResourceUrl } from '@angular/platform-browser';
import { CommonService } from 'app/core/Services/common.service';
import { Fetch_License_Plate_Recognition_Response_Content, Scene_Details, Scene_Object, Video_ai_asset } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { VideoAIService } from '../../video-ai.service';

@Component({
    selector: 'license-plate-modal',
    templateUrl: './license-plate-modal.component.html',
    styleUrls: ['./license-plate-modal.component.scss']
})
export class LicensePlateModalComponent implements OnInit {

    loopZoom = 3;
    imageWidth = 0;
    cameraWidth = 0;
    imageHeight = 0;
    cameraHeight = 0;
    mainDataContainerHeight = 400;

    isBoxOn = true;
    isLoopOn = false;
    isImageLoaded = false;

    oSceneId: number;
    oScene: Scene_Details;
    oCamera: Video_ai_asset;
    sceneFile: SafeResourceUrl;
    licensePlate: Fetch_License_Plate_Recognition_Response_Content;

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
        @Inject(MAT_DIALOG_DATA) public data: any,
        private CmSvc: CommonService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.oCamera = data.camera;
        this.licensePlate = data.licensePlate;
        this.cameraWidth = this.oCamera.RESOLUTION_X;
        this.cameraHeight = this.oCamera.RESOLUTION_Y;
    }

    ngOnInit(): void {
        this.oSceneId = this.data.licensePlate.SceneId;
        this.VideoAIService.getLicensePlateScene(this.data.licensePlate.SceneId, this.data.camera.VIDEO_AI_INSTANCE_ID).then(scene_details => {
            this.oScene = scene_details;
            this.sceneFile = this.Sanitize(this.oScene.File);
        })
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    imageLoaded() {
        this.isImageLoaded = true;
        let img = document.getElementById("myimage");
        this.imageWidth = img.offsetWidth;
        this.imageHeight = img.offsetHeight;
        this.mainDataContainerHeight = document.getElementById("main-data-container").offsetHeight;
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

    getObjectScale(object: Scene_Object) {
        return Math.min(96 / object.W, 96 / object.H);
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

}
