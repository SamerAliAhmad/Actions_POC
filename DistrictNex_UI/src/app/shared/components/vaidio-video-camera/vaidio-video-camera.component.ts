import { ChangeDetectorRef, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Surveillance_Camera_Content } from 'app/core/Services/proxy.service';
import videojs, { VideoJsPlayer } from 'video.js';

@Component({
    selector: 'vaidio-video-camera',
    templateUrl: './vaidio-video-camera.component.html',
    styleUrls: ['./vaidio-video-camera.component.scss']
})
export class VaidioVideoCameraComponent implements OnInit {
    @Input() url: string;
    @Input() isUrl: boolean = false;
    @Input() isShowX: boolean = true;
    @Input() camera: Surveillance_Camera_Content;
    @Output() removeCameraEventEmitter = new EventEmitter<number>();

    isRefreshCameras = false;
    AreCamerasLoaded = false;
    player: VideoJsPlayer;
    NumberOfRefreshAllowed = 5;

    constructor(
        private _changeDetectorRef: ChangeDetectorRef,
    ) { }

    ngOnInit(): void {
        this.openCameras();
    }

    openCameras() {
        this._changeDetectorRef.detectChanges();
        const config = {
            autoplay: true,
            controls: true,
            fluid: true,
            sources: [
                {
                    src: this.isUrl ? this.url : this.camera.AuthenticatedUrl,
                    type: 'video/mp4'
                }
            ]
        };

        this.player = videojs(document.getElementById(`stream-${this.camera?.CameraId ?? 1}`), config);
        this.player.on('error', () => this.refreshCameras());
    }
    removeCamera() {
        this.removeCameraEventEmitter.emit(this.isUrl ? null : this.camera.CameraId);
    }
    refreshCameras() {
        if (this.NumberOfRefreshAllowed <= 0) {
            this.removeCameraEventEmitter.emit(this.isUrl ? null : this.camera.CameraId);
            console.clear();
            return;
        }
        this.NumberOfRefreshAllowed--;
        this.player.dispose();
        this.isRefreshCameras = true;
        this._changeDetectorRef.detectChanges();
        this.isRefreshCameras = false;
        this.openCameras();
    }
    takeSnapshot(id) {
        const frame = this.captureFrame(`stream-${id ?? 1}_html5_api`, 'png');

        const image = document.createElement('a');
        document.body.appendChild(image);
        image.href = window.URL.createObjectURL(new window.Blob([frame.image]));
        image.download = `camera-snapshot-${id ?? 1}-${Date.now()}.png`;
        image.click();
        image.remove();
    }
    captureFrame(video, format) {
        if (typeof video === 'string') {
            video = document.getElementById(video)
        }

        if (video == null || video.nodeName !== 'VIDEO') {
            throw new TypeError('First argument must be a <video> element or selector')
        }

        if (format == null) {
            format = 'png'
        }

        if (format !== 'png' && format !== 'jpeg' && format !== 'webp') {
            throw new TypeError('Second argument must be one of "png", "jpeg", or "webp"')
        }

        const canvas = document.createElement('canvas')
        const width = canvas.width = video.videoWidth
        const height = canvas.height = video.videoHeight

        canvas.getContext('2d').drawImage(video, 0, 0)

        const dataUri = canvas.toDataURL('image/' + format)
        const data = dataUri.split(',')[1]
        return {
            image: this.dataURItoBlob(data),
            width,
            height
        }
    }
    dataURItoBlob(dataURI) {
        const byteString = window.atob(dataURI);
        const arrayBuffer = new ArrayBuffer(byteString.length);
        const int8Array = new Uint8Array(arrayBuffer);
        for (let i = 0; i < byteString.length; i++) {
            int8Array[i] = byteString.charCodeAt(i);
        }
        const blob = new Blob([int8Array], { type: 'image/png' });
        return blob;
    }
    ngOnDestroy() {
        if (this.player) {
            this.player.dispose();
        }
    }
}
