import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MapService } from '../../map.service';

@Component({
    selector: 'scene-details',
    templateUrl: './scene-details.component.html',
    styleUrls: ['./scene-details.component.scss']
})
export class SceneDetailsComponent {

    @Input() sceneModalData: any;
    @Output() closeClickEventEmitter = new EventEmitter<void>();

    isShareView = false;
    selectedTab: number;

    constructor(
        private MapService: MapService,
    ) {
        this.isShareView = this.MapService.isShareView;
    }
}
