import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDrawer } from '@angular/material/sidenav';
import { CommonService } from 'app/core/Services/common.service';
import { Dimension, Report } from 'app/core/Services/proxy.service';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { ReportsService } from '../reports.service';

@Component({
    selector: 'report-manager',
    templateUrl: './report-manager.component.html',
    styleUrls: ['./report-manager.component.scss']
})
export class ReportManagerComponent implements OnInit {

    @ViewChild('matDrawer', { static: true }) matDrawer: MatDrawer;
    drawerMode: 'side' | 'over';
    fileData = '';
    dir_Files = [];
    dir_Folders = [];

    chosen_Report: Report;
    chosen_Dimension: Dimension;
    dimension_List: Dimension[] = [];

    isInWizard = false;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private reportsService: ReportsService,
        private SmartrSplashScreenService: SmartrSplashScreenService,
        private smartrMediaWatcherService: SmartrMediaWatcherService
    ) {
        this.SmartrSplashScreenService.hide();
        this.CmSvc.oToggle_Module_Subject.next(true);
    }
    ngOnInit(): void {
        this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.forEach(oLevel_Dimension_With_Status => {
            if (oLevel_Dimension_With_Status.LEVEL_ID_LIST.length > 0) {
                if (!this.dimension_List.find(_Dimension => _Dimension.DIMENSION_ID == oLevel_Dimension_With_Status.DIMENSION.DIMENSION_ID)) {
                    this.dimension_List.push(oLevel_Dimension_With_Status.DIMENSION);
                }
            }
        });

        this.smartrMediaWatcherService.onMediaQueryChange$('(min-width: 1440px)')
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((state) => {
                this.drawerMode = state.matches ? 'side' : 'over';
            });

    }

    Choose_Dimension(chosen_Dimension): void {
        this.chosen_Dimension = chosen_Dimension;
    }

    Choose_Report(chosen_Report: Report): void {
        if (this.chosen_Report && this.chosen_Report.REPORT_ID == chosen_Report.REPORT_ID) {
            this.closeDrawer();
            return;
        }
        this.chosen_Report = chosen_Report;
        this.matDrawer.open();
    }

    Open_Custom_Report_Dialog() {
        this.closeDrawer();
        this.chosen_Dimension = null;
        this.isInWizard = true;
    }

    Get_File_Color(extension): string {
        return this.reportsService.Get_File_Color(extension);
    }

    onHomeClick() {
        this.closeDrawer();
        this.chosen_Dimension = null;
    }

    onBackdropClicked(): void {
        this.closeDrawer();
    }

    closeDrawer() {
        this.chosen_Report = null;
        this.matDrawer.close();
    }

    getDisplayName(fileName: string): string {
        return fileName.replace(/_/g, ' ');
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
