import { Dialog_input } from '../map.service';
import { Component, EventEmitter, Input, Output, ChangeDetectorRef, OnInit } from '@angular/core';

@Component({
    selector: 'level-kpi-drawer',
    templateUrl: './level-kpi-drawer.component.html',
    styleUrls: ['./level-kpi-drawer.component.scss']
})
export class LevelKpiDrawerComponent implements OnInit {

    @Input() oDialog_input: Dialog_input;

    @Output() UnpinModalEventEmitter = new EventEmitter<boolean>();
    @Output() CloseDrawerEventEmitter = new EventEmitter<string>();

    _Dialog_input: Dialog_input;

    isChartsLoaded: boolean = false;

    constructor(
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
    }

    ngOnInit() {
        this._Dialog_input = this.oDialog_input;
    }

    onChartsLoadedChange(isLoaded: boolean) {
        this.isChartsLoaded = isLoaded;
        this._changeDetectorRef.detectChanges();
    }

    Close_Drawer() {
        this.CloseDrawerEventEmitter.emit(this._Dialog_input.properties.Current_view_type);
    }

    Unpin_Modal() {
        this.UnpinModalEventEmitter.emit(true);
    }
}
