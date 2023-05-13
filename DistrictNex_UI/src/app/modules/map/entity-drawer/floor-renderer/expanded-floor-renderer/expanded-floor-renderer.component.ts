import { Component, EventEmitter, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { Entity, Floor, Wifi_signal } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'expanded-floor-renderer',
    templateUrl: './expanded-floor-renderer.component.html',
    styleUrls: ['./expanded-floor-renderer.component.scss']
})
export class ExpandedFloorRendererComponent implements OnInit, OnDestroy {

    @Input() oFloor: Floor;
    @Input() oEntity: Entity;

    @Input() isChangingFloor = false;

    @Output() closeClickEventEmitter = new EventEmitter<void>();

    isShareView = false;

    oList_Wifi_signal: Wifi_signal[] = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private MapService: MapService,
    ) {
        this.isShareView = this.MapService.isShareView;
    }

    ngOnInit() {
        if (!this.isShareView) {
            this.MapService.oChange_Floor_Renderer_Floor_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(floor => {
                this.oFloor = floor;
            });
            this.MapService.oLatest_Wifi_signals_Behavior_subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(result => {
                this.oList_Wifi_signal = result;
            });
        }
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
