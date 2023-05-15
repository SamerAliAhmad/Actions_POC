import { DOCUMENT } from '@angular/common';
import { ChangeDetectionStrategy, Component, Inject, Input, OnInit, TemplateRef, ViewEncapsulation } from '@angular/core';

@Component({
    selector: 'smartr-fullscreen',
    templateUrl: './fullscreen.component.html',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    exportAs: 'smartrFullscreen'
})
export class SmartrFullscreenComponent implements OnInit {
    element;
    @Input() iconTpl: TemplateRef<any>;
    @Input() tooltip: string;
    isFullscreen: boolean = false;

    constructor(@Inject(DOCUMENT) private document) { }

    ngOnInit(): void {
        this.element = document.documentElement;
    }

    toggleFullscreen(): void {
        this.isFullscreen = this._getBrowserFullscreenElement() !== null;
        if (this.isFullscreen) {
            this._closeFullscreen();
        }
        else {
            this._openFullscreen();
        }
    }
    private _getBrowserFullscreenElement(): Element {
        if (typeof this.document.fullscreenElement !== 'undefined') {
            return this.document.fullscreenElement;
        }

        if (typeof this.document.mozFullScreenElement !== 'undefined') {
            return this.document.mozFullScreenElement;
        }

        if (typeof this.document.msFullscreenElement !== 'undefined') {
            return this.document.msFullscreenElement;
        }

        if (typeof this.document.webkitFullscreenElement !== 'undefined') {
            return this.document.webkitFullscreenElement;
        }

        throw new Error('Fullscreen mode is not supported by this browser');
    }
    private _openFullscreen(): void {
        this.isFullscreen = true;
        if (this.element.requestFullscreen) {
            this.element.requestFullscreen();
            return;
        }
        // Firefox
        if (this.element.mozRequestFullScreen) {
            this.element.mozRequestFullScreen();
            return;
        }
        // Chrome, Safari and Opera
        if (this.element.webkitRequestFullscreen) {
            this.element.webkitRequestFullscreen();
            return;
        }
        // IE/Edge
        if (this.element.msRequestFullscreen) {
            this.element.msRequestFullscreen();
            return;
        }
    }
    private _closeFullscreen(): void {
        this.isFullscreen = false;
        if (this.document.exitFullscreen) {
            this.document.exitFullscreen();
            return;
        }

        // Firefox
        if (this.document.mozCancelFullScreen) {
            this.document.mozCancelFullScreen();
            return;
        }

        // Chrome, Safari and Opera
        if (this.document.webkitExitFullscreen) {
            this.document.webkitExitFullscreen();
            return;
        }

        // IE/Edge
        else if (this.document.msExitFullscreen) {
            this.document.msExitFullscreen();
            return;
        }
    }
}
