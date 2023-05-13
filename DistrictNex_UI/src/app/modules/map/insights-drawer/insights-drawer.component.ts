import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { District, Entity } from 'app/core/Services/proxy.service';

@Component({
    selector: 'insights-drawer',
    templateUrl: './insights-drawer.component.html',
    styleUrls: ['./insights-drawer.component.scss']
})
export class InsightsDrawerComponent implements OnInit {

    @Input() oDistrict: District;

    @Output() closeClickEventEmitter = new EventEmitter<void>();

    isIFrameLoading = false;
    isShowShareButton = false;

    chosenTab = 13;
    chosenEnergyTab = 1;

    oList_Entity: Entity[];

    constructor(
        private CmSvc: CommonService,
    ) { }

    ngOnInit(): void {
        this.oList_Entity = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.filter(entity => entity.DISTRICT_ID == this.oDistrict?.DISTRICT_ID);
    }

    tabChanged() {
        localStorage.setItem('insightsTab', this.chosenTab.toString());
        if (this.chosenTab == 1 || this.chosenTab == 3) {
            this.isIFrameLoading = true;
        } else {
            this.isIFrameLoading = false;
        }
    }

    getPdfName() {
        switch (this.chosenTab) {
            case 13:
                return "Correlation";
            case 12:
                return "Single Kpi Compare";
            case 5:
                return "Multiple Kpi Compare";
        }
    }

    toggleShareButton(value: boolean) {
        this.isShowShareButton = value;
    }
}
