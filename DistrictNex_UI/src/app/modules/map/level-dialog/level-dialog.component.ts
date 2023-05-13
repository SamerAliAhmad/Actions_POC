import { ChangeDetectorRef, Component, EventEmitter, Inject, Output } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { BdcWalkService } from 'bdc-walkthrough';
import { cloneDeep } from 'lodash';
import { Dialog_input } from '../map.service';

@Component({
    selector: 'level-dialog',
    templateUrl: './level-dialog.component.html',
    styleUrls: ['./level-dialog.component.scss']
})
export class LevelDialogComponent {

    isChartsLoaded: boolean;

    minWidth: string;
    minHeight: string;
    oDialog_input: Dialog_input;

    @Output() PinClickEventEmitter = new EventEmitter<number>();

    constructor(
        private BdcWalkService: BdcWalkService,
        private _changeDetectorRef: ChangeDetectorRef,
        @Inject(MAT_DIALOG_DATA) public data: any = null,
    ) {
        this.oDialog_input = cloneDeep(this.data.input);
    }

    onChartsLoadedChange(isLoaded: boolean) {
        this.isChartsLoaded = isLoaded;
        this._changeDetectorRef.detectChanges();
    }

    Toggle_Modal_Pin() {
        this.BdcWalkService.setTaskCompleted("dialogPopup1", true);
        this.PinClickEventEmitter.emit(this.oDialog_input.level_id);
    }

}