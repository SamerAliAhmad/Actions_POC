import { Component, Input, OnInit } from '@angular/core';
import { MapService } from 'app/modules/map/map.service';
import { Best_And_Worst_Object, District } from 'app/core/Services/proxy.service';

@Component({
    selector: 'wifi-signal-insights',
    templateUrl: './wifi-signal-insights.component.html',
    styleUrls: ['./wifi-signal-insights.component.scss']
})
export class WifiSignalInsightsComponent implements OnInit {

    @Input() oDistrict: District;

    oBest_And_Worst_Wifi_signal: Best_And_Worst_Object;
    oBest_And_Worst_Wifi_signal_With_Alerts: Best_And_Worst_Object;

    constructor(
        private MapService: MapService,
    ) { }

    ngOnInit(): void {
        this.MapService.Get_Strongest_Wifi_signal(this.oDistrict.TOP_LEVEL_ID).then(result => {
            this.oBest_And_Worst_Wifi_signal = result;
        });
        this.MapService.Get_Most_Wifi_signal_Count_Per_Space_asset(this.oDistrict.TOP_LEVEL_ID).then(result => {
            this.oBest_And_Worst_Wifi_signal_With_Alerts = result;
        });
    }

}
