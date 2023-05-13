import { OverlayRef } from '@angular/cdk/overlay';
import { Component, DoCheck, Input, OnInit, TemplateRef, ViewChild, ViewContainerRef } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { ProgressSpinnerDialogService } from './progress-spinner-dialog.service';

@Component({
    selector: 'progress-spinner-dialog',
    templateUrl: './progress-spinner-dialog.component.html',
    styleUrls: ['./progress-spinner-dialog.component.scss']
})
export class ProgressSpinnerDialogComponent implements OnInit, DoCheck {
    @Input() diameter = 100;
    @Input() value?: number = 50;
    @Input() backdropEnabled = true;
    @Input() positionGloballyCenter = true;
    @Input() displayProgressSpinner = false;
    @Input() color?: ThemePalette = 'primary';
    @Input() mode?: ProgressSpinnerMode = 'indeterminate';

    @ViewChild('progressSpinnerRef') private progressSpinnerRef: TemplateRef<any>;

    private overlayRef: OverlayRef;
    private progressSpinnerOverlayConfig;

    constructor(private vcRef: ViewContainerRef, private progressSpinnerDialogService: ProgressSpinnerDialogService) { }

    ngOnInit(): void {
        // Config for Overlay Service
        this.progressSpinnerOverlayConfig = {
            hasBackdrop: this.backdropEnabled
        };
        if (this.positionGloballyCenter) {
            this.progressSpinnerOverlayConfig['positionStrategy'] = this.progressSpinnerDialogService.positionGloballyCenter();
        }
        // Create Overlay for progress spinner
        this.overlayRef = this.progressSpinnerDialogService.createOverlay(this.progressSpinnerOverlayConfig);
    }
    ngDoCheck(): void {
        // Based on status of displayProgressSpinner attach/detach overlay to progress spinner template
        if (this.displayProgressSpinner && !this.overlayRef.hasAttached()) {
            this.progressSpinnerDialogService.attachTemplatePortal(this.overlayRef, this.progressSpinnerRef, this.vcRef);
        } else if (!this.displayProgressSpinner && this.overlayRef.hasAttached()) {
            this.overlayRef.detach();
        }
    }
}

