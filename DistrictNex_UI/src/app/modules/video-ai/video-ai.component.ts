import { Subject } from 'rxjs';
import { MatDrawer } from '@angular/material/sidenav';
import { LogsService } from 'app/core/Services/logs.service';
import { CommonService } from 'app/core/Services/common.service';
import { Component, HostListener, ViewChild, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';

@Component({
    selector: 'video-ai',
    templateUrl: './video-ai.component.html',
    styleUrls: ['./video-ai.component.scss']
})
export class VideoAIComponent implements OnInit, OnDestroy {
    isFeatureOn: boolean = true;
    isDrawerOpen: boolean = true;
    isSaveClicked: boolean = false;
    areChangesMade: boolean = false;
    previousChangeValue: boolean = false;
    relatedEntitiesLoaded: boolean = false;

    oList_All_Table: string[] = [];
    oList_All_Methods: string[] = [];
    oList_Get_Methods: string[] = [];
    AllDatabaseTables: string[] = [];

    drawerMode: 'over' | 'side' = 'side';
    selectedPanel: string = 'scene-search';

    @ViewChild('drawer') drawer: MatDrawer;

    private _unsubscribeAll = new Subject<void>();

    panels: any[] = [
        {
            id: 'scene-search',
            icon: 'mat_outline:image_search',
            title: 'Scene Search',
        },
        {
            id: 'video-monitoring',
            icon: 'mat_outline:video_camera_back',
            title: 'Video Monitoring',
        },
        {
            id: 'vehicle-counting',
            icon: 'mat_outline:directions_car',
            title: 'Vehicle Counting',
        },
        {
            id: 'people-counting',
            icon: 'mat_outline:directions_walk',
            title: 'People Counting',
        },
        {
            id: 'license-plate-recognition',
            icon: 'mat_outline:directions_car',
            title: 'License Plate Recognition',
        },
        {
            id: 'facial-recognition',
            icon: 'mat_outline:face',
            title: 'Facial Recognition',
        },
    ];

    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private SmartrSplashScreen: SmartrSplashScreenService,
        private LogsService: LogsService,
    ) {
        this.isFeatureOn = this.CmSvc.oStream_Data != null;
    }

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
        if (localStorage.getItem('VideoAiPanel')) {
            if (this.selectedPanel !== localStorage.getItem('VideoAiPanel')) {
                this.goToPanelfromLoc(localStorage.getItem('VideoAiPanel'));
            }
        }
        this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Security Camera Module",
            this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Security Camera Module").SETUP_ID,
            this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID);
    }

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isDrawerOpen = window.innerWidth > 600;
    }

    goToPanelfromLoc(i_Panel: string): void {
        if (this.panels.some(panel => panel.id === i_Panel)) {
            this.selectedPanel = i_Panel;
            localStorage.setItem('VideoAiPanel', i_Panel);
        } else {
            this.selectedPanel = 'scene-search';
            localStorage.setItem('VideoAiPanel', 'scene-search');
        }
    }

    goToPanel(panel: string): void {
        this.selectedPanel = panel;
        localStorage.setItem('VideoAiPanel', panel);
        if (this.drawerMode === 'over') {
            this.drawer.close();
        }
        this.areChangesMade = false;
    }

    getPanelInfo(id: string): any {
        return this.panels.find(panel => panel.id === id);
    }

    ngOnDestroy(): void {
        this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Exited Security Camera Module",
            this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Security Camera Module").SETUP_ID,
            this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID);
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}

