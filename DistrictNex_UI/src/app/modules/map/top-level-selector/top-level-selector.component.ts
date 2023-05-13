import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Top_Level_Data } from 'app/core/Services/proxy.service';
import { MapService } from '../map.service';

@Component({
    selector: 'top-level-selector',
    templateUrl: './top-level-selector.component.html',
    styleUrls: ['./top-level-selector.component.scss']
})
export class TopLevelSelectorComponent implements OnInit {

    oList_Top_level_Data: Top_Level_Data[];

    @Output() closeTopLevelEventEmitter = new EventEmitter<void>();

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
    ) { }

    ngOnInit(): void {
        let organization_id = this.CmSvc.saved_organization_id;
        let oList_Accessible_Top_Levels = this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data.find(oData => oData.ORGANIZATION_DATA.ORGANIZATION_ID == organization_id).LIST_TOP_LEVEL_DATA;
        if (this.CmSvc.oUser_Details.USER_TYPE_SETUP_ID != this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("user type", "organization user")) {
            this.oList_Top_level_Data = oList_Accessible_Top_Levels.filter(oTop_Level => this.CmSvc.oUser_Accessible_Data.LIST_ORGANIZATION_TOP_LEVEL_ID.includes(oTop_Level.TOP_LEVEL_ID));
        }
        else {
            this.oList_Top_level_Data = oList_Accessible_Top_Levels.filter(oTop_Level => this.CmSvc.oUser_Accessible_Data.LIST_USER_TOP_LEVEL_ID.includes(oTop_Level.TOP_LEVEL_ID));
        }
    }

    selectTopLevel(i_Top_level_Data: Top_Level_Data) {
        if (i_Top_level_Data.TOP_LEVEL_ID != Number.parseInt(localStorage.getItem('top_level_id'))) {
            this.MapService.oTop_Level_Changed_Subject.next(i_Top_level_Data);
        }
        else {
            this.MapService.oOpen_Top_level_Selector_Subject.next(false);
        }
    }
}
