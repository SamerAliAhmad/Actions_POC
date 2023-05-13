import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
    selector: 'energy-insights-panel',
    templateUrl: './energy-insights-panel.component.html',
    styleUrls: ['./energy-insights-panel.component.scss']
})
export class EnergyInsightsPanelComponent {

    @Input() isShareView = false;
    @Output() closeClickEventEmitter = new EventEmitter<void>();

}
