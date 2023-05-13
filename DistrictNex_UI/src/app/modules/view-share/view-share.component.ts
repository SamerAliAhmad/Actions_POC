import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Entity_share_view_data } from 'app/core/Services/proxy.service';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { Entity_Dialog_input } from '../map/map.service';
import { ViewShareService } from './view-share.service';

@Component({
    selector: 'view-share',
    templateUrl: './view-share.component.html',
    styleUrls: ['./view-share.component.scss']
})
export class ViewShareComponent implements OnInit {

    oEntity_Dialog_Input: Entity_Dialog_input;
    oEntity_share_view_data: Entity_share_view_data;

    oCurrent_Entity;
    oDimension_index_for_entity;
    isEntitySummaryDrawerVisible = false;

    constructor(
        private router: Router,
        private ActivatedRoute: ActivatedRoute,
        private ViewShareService: ViewShareService,
        private SmartrSplashScreenService: SmartrSplashScreenService,
    ) { }

    ngOnInit(): void {
        const UNIQUE_STRING = this.ActivatedRoute.snapshot.params.uniqueString;
        if (UNIQUE_STRING) {
            this.SmartrSplashScreenService.show();
            this.ViewShareService.Get_Entity_Share_Data(UNIQUE_STRING).then(result => {
                if (result) {
                    this.oEntity_share_view_data = result;
                    this.oEntity_Dialog_Input = {
                        ENTITY: this.oEntity_share_view_data.Entity,
                        oList_Dimension_data: [],
                        SITE: null,
                    };
                    this.oCurrent_Entity = result.Entity;
                    this.oDimension_index_for_entity = result.Entity_Dimension_index;
                    this.isEntitySummaryDrawerVisible = result.IS_ENTITY_SUMMARY_DRAWER_VISIBLE;
                } else {
                    this.router.navigateByUrl('');
                }
                this.SmartrSplashScreenService.hide();
            });
        } else {
            this.router.navigateByUrl('');
        }
    }
}
