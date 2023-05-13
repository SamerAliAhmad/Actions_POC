import { Router } from '@angular/router';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { LogsService } from 'app/core/Services/logs.service';
import { CommonService } from 'app/core/Services/common.service';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';

@Component({
    selector: 'reports',
    templateUrl: './reports.component.html',
    styleUrls: ['./reports.component.scss']
})
export class ReportsComponent implements OnInit, OnDestroy {
    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private LogsService: LogsService,
        private SmartrSplashScreen: SmartrSplashScreenService
    ) { }
    ngOnInit() {
        this.CmSvc.oToggle_Change_Organization_Subject.subscribe(_ => {
            this.SmartrSplashScreen.show();
            this.CmSvc.saved_organization_id = null;
            this.CmSvc.saved_top_level_id = null;
            this.CmSvc.oUser_Accessible_Level_List = null;
            localStorage.removeItem('top_level_id')
            localStorage.removeItem('organization_id')
            this.router.navigateByUrl('/organization-selection');
        })
        this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Report Module",
            this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Report Module").SETUP_ID,
            this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID);
    }
    ngOnDestroy(): void {
        this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Exited Report Module",
            this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Report Module").SETUP_ID,
            this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID);
    }
}
