import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Entity } from 'app/core/Services/proxy.service';
import { MapService } from '../../map.service';

@Component({
    selector: 'video-ai-drawer',
    templateUrl: './video-ai-drawer.component.html',
    styleUrls: ['./video-ai-drawer.component.scss']
})
export class VideoAiDrawerComponent {
    @Input() oEntity: Entity;
    @Input() isVideoDataLoaded: boolean;

    @Output() closeClickEventEmitter = new EventEmitter<void>();

    isShareView = false;

    selectedTab: number;
    tabs = ['Scene Search', 'Video Monitoring', 'Vehicle Counting', 'People Counting', '', 'License Plate Recognition', 'Facial Recognition'];

    constructor(
        private MapService: MapService,
    ) {
        this.isShareView = this.MapService.isShareView;
    }
}
