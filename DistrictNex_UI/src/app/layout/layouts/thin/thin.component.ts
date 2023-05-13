import { ChangeDetectorRef, Component, OnDestroy, OnInit, ViewEncapsulation } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { MapService } from 'app/modules/map/map.service';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { Navigation } from 'app/shared/navigation/navigation.types';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'thin-layout',
    templateUrl: './thin.component.html',
    encapsulation: ViewEncapsulation.None
})
export class ThinLayoutComponent implements OnInit, OnDestroy {
    isScreenSmall: boolean;
    navigation: Navigation;
    private _unsubscribeAll = new Subject<void>();

    dark_logo = '';
    light_logo = '';
    companyName = '';
    unreadCount = 0;
    isShowAlerts = false;
    changeOnce = false;

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        private _changeDetectorRef: ChangeDetectorRef,
        private _smartrNavigationService: SmartrNavigationService,
        private _smartrMediaWatcherService: SmartrMediaWatcherService,
    ) {
        this.dark_logo = this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL;
        this.light_logo = this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL;
        this.companyName = this.CmSvc.oUser_Details.Organization.ORGANIZATION_NAME;
    }


    ngOnInit(): void {
        // Subscribe to navigation data
        this._smartrNavigationService._navigation
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((navigation: Navigation) => {
                this.navigation = navigation;
            });

        // Subscribe to media changes
        this._smartrMediaWatcherService.onMediaChange$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(({ matchingAliases }) => {

                // Check if the screen is small
                this.isScreenSmall = !matchingAliases.includes('md');
            });

        this.MapService.oUpdate_Alert_Count_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(result => {
            if (result == 0) {
                this.FetchUnreadCount();
            } else {
                this.unreadCount += result;
            }
        });

        this.CmSvc.oUpdateApplicationImagesSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.dark_logo = this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL;
            this.light_logo = this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL;
        });

        this.CmSvc.oToggle_Module_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(isSelectionComplete => {
            this.isShowAlerts = isSelectionComplete;
            this._changeDetectorRef.detectChanges();
        });
    }

    get currentYear(): number {
        return new Date().getFullYear();
    }

    FetchUnreadCount() {
        this.MapService.Get_Alerts_Count_For_Levels({
            ALERT_ID_LIST: null,
            USER_ID_LIST: [this.CmSvc.oUser_Details.USER_ID],
            IS_ACKNOWLEDGED: false,
            START_DATE: this.MapService.oStart_Date_Filter?.toISOString(),
            END_DATE: this.MapService.oEnd_Date_Filter?.toISOString(),
            DISTRICT_ID_LIST: this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.map(oDistrict => oDistrict.DISTRICT_ID),
            AREA_ID_LIST: this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.map(oArea => oArea.AREA_ID),
            SITE_ID_LIST: this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.map(oSite => oSite.SITE_ID),
            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: this.CmSvc.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.HAS_ALERTS).map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID),
        }).then(result => {
            this.unreadCount = result;
        });
    }

    isDark() {
        return this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-primary'));
    }

    changeImage(event) {
        if (!this.changeOnce) {
            if (this.isDark()) {
                event.target.src = this.CmSvc.oDefaultSettings.LIGHT_SQUARE_LOGO_URL;
            } else {
                event.target.src = this.CmSvc.oDefaultSettings.DARK_SQUARE_LOGO_URL;
            }
        } else {
            if (this.isDark()) {
                event.target.src = 'assets/images/logo/picacity/logo-white-square.png';
            } else {
                event.target.src = 'assets/images/logo/picacity/logo-black-square.png';
            }
        }
        this.changeOnce = true;
    }

    toggleAlertsDrawer() {
        this.CmSvc.oToggle_Alerts_Drawer_Subject.next();
    }

    /**
     * Toggle navigation
     *
     * @param name
     */
    toggleNavigation(name: string): void {
        // Get the navigation
        const navigation = this._smartrNavigationService.getComponent<SmartrVerticalNavigationComponent>(name);

        if (navigation) {
            // Toggle the opened status
            navigation.toggle();
        }
    }

    ngOnDestroy(): void {
        // Unsubscribe from all subscriptions
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
