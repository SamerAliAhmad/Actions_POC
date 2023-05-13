import { ChangeDetectorRef, Component, EventEmitter, Inject, Output } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Upper_Level } from 'app/core/Services/proxy.service';
import { BdcWalkService } from 'bdc-walkthrough';
import { Entity_Dialog_input } from '../map.service';

@Component({
    selector: 'entity-dialog',
    templateUrl: './entity-dialog.component.html',
    styleUrls: ['./entity-dialog.component.scss']
})
export class EntityDialogComponent {

    @Output() oEntityDrawerPinEventEmitter = new EventEmitter<boolean>();

    isChartsLoaded = false;

    oUpper_Level: Upper_Level;
    oEntity_Dialog: Entity_Dialog_input;

    constructor(
        private _changeDetectorRef: ChangeDetectorRef,
        private BdcWalkService: BdcWalkService,
        @Inject(MAT_DIALOG_DATA) public data: any = null,

    ) {
        this.oEntity_Dialog = this.data.input
        this.oUpper_Level = this.data.upper_level
    }

    Toggle_Modal_Pin() {
        this.BdcWalkService.setTaskCompleted("dialogPopup1", true);
        this.oEntityDrawerPinEventEmitter.emit(true);
    }

    updateChartsLoaded(event: boolean) {
        this.isChartsLoaded = event;
        this._changeDetectorRef.detectChanges();
    }

}
