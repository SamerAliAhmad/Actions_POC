import { Component, EventEmitter, Input, OnDestroy, OnInit, Output, ViewChild } from '@angular/core';
import { Dimension_index_By_Level, Entity } from 'app/core/Services/proxy.service';
import { Subject, takeUntil } from 'rxjs';
import { BuildingSummaryComponent } from '../entity-drawer/building-summary/building-summary.component';
import { MapService } from '../map.service';

@Component({
    selector: 'entity-summary-drawer',
    templateUrl: './entity-summary-drawer.component.html',
    styleUrls: ['./entity-summary-drawer.component.scss']
})
export class EntitySummaryDrawerComponent implements OnInit, OnDestroy {

    @Input() oEntity: Entity;
    @Input() isShareView = false;
    @Input() oDimension_index_for_entity: Dimension_index_By_Level;

    @Output() closeClickEventEmitter = new EventEmitter<void>();

    @ViewChild(BuildingSummaryComponent) oBuildingSummaryComponent: BuildingSummaryComponent;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private MapService: MapService,
    ) { }

    ngOnInit(): void {
        this.MapService.oFill_Data_From_Building_Summary_Drawer_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.MapService.oEntity_share_data.INCIDENT_CATEGORY_SETUP_ID = this.oBuildingSummaryComponent.oChosen_Alerts_Setup.SETUP_ID;
            this.MapService.oEntity_share_data.IS_ALERT = this.oBuildingSummaryComponent.tabIndex == 1;
            this.MapService.oEntity_share_data.LIST_FLOOR_CHART_WIFI_SIGNAL = this.oBuildingSummaryComponent.oList_Wifi_signal;
            this.MapService.oEntity_share_data.DIMENSION_ID = this.oDimension_index_for_entity.LIST_DIMENSION_INDEX[0]?.DIMENSION_METADATA.DIMENSION_ID;
            if (this.MapService.oEntity_share_data.IS_ALERT) {
                switch (this.oBuildingSummaryComponent.oChosen_Alerts_Setup.VALUE) {
                    case "Access Control":
                        this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                        break;
                    case "Suspicious Behavior":
                        this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                        break;
                    case "Fire Alarm":
                        this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                        break;
                    case "Blacklisted Person":
                        this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                        break;
                    case "Blacklisted Plate":
                        this.MapService.oEntity_share_data.LIST_INCIDENT_ID = this.oBuildingSummaryComponent.oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT.List_Incident.map(incident => incident.INCIDENT_ID);
                        break;
                    default:
                        this.MapService.oEntity_share_data.LIST_INCIDENT_ID = [];
                        break;
                }
            }
        });
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
