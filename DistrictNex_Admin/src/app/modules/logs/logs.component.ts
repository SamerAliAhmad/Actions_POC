import { AfterViewInit, ChangeDetectorRef, Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ThemePalette } from '@angular/material/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Log, Organization, Setup, Site, User, Video_ai_asset } from 'app/core/Services/proxy.service';
import { LogFiltersComponent } from 'app/shared/components/organization-management/log-filters/log-filters.component';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { OrganizationManagementService } from '../organization-management/organization-management.service';
import { LogsService } from './logs.service';
declare var require: any
const FileSaver = require('file-saver');

@Component({
    selector: 'logs',
    templateUrl: './logs.component.html',
    styleUrls: ['./logs.component.scss']
})
export class LogsComponent implements OnInit, AfterViewInit {

    totalCount = 0;

    value = 50;
    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';

    loading = false;
    isFetching = false;
    mobileView = false;
    contentLoaded = true;
    downloadingReport = false;

    customerNameSearchInput: FormControl = new FormControl('');
    employeeNameSearchInput: FormControl = new FormControl('');

    pageIndex = 0;
    pageSize = 20;
    displayedColumns: string[] = ['logTime', 'logDate', 'message', 'logType', 'logAccess'];
    dataSource = new MatTableDataSource<Log>();

    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort, { static: true }) sort: MatSort;

    oList_Organization: Organization[] = [];
    oList_Chosen_Organization: Organization[] = [];
    oList_Site: Site[] = [];
    oList_Chosen_Site: Site[] = [];
    oList_Entity: Entity[] = [];
    oList_Chosen_Entity: Entity[] = [];
    oList_Chosen_User: User[] = [];
    oList_Log_Type: Setup[] = [];
    oList_Chosen_Log_Type: Setup[] = [];
    oList_Access_Type: Setup[] = [];
    oList_Chosen_Access_Type: Setup[] = [];
    oList_Video_ai_asset: Video_ai_asset[] = [];
    oList_Chosen_Video_ai_asset: Video_ai_asset[] = [];
    endDate;
    startDate;

    private _unsubscribeAll = new Subject<void>();

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.mobileView = window.innerWidth < 600;
    }
    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private LogsService: LogsService,
        private _changeDetectorRef: ChangeDetectorRef,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Access_Type = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Access Type")[0].List_Setup.sort((a, b) => a.VALUE.localeCompare(b.VALUE));
        this.oList_Log_Type = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Log Type")[0].List_Setup.sort((a, b) => a.VALUE.localeCompare(b.VALUE));
    }

    ngOnInit(): void {
        this.mobileView = window.innerWidth < 600;
        this.LogsService.getLogsWithFilters();

        if (this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin") {
            this.OrganizationManagementService.get_Organizations().then(organizations => {
                this.oList_Organization = organizations.concat(this.CmSvc.oOrganization);
            });
        }
        this.oList_Site = this.CmSvc.oList_Site;
        this.oList_Entity = this.CmSvc.oList_Entity;
        this.LogsService.Get_Video_ai_assets().then(result => {
            this.oList_Video_ai_asset = result;
        });
    }

    ngAfterViewInit(): void {
        this.contentLoaded = false;
        this._changeDetectorRef.detectChanges();
        this.LogsService.onLogsChanged.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            if (data) {
                this.loading = false;
                this.contentLoaded = true;
                this.totalCount = data.COUNT;
                this.dataSource.data = data.List_Log;
                this._changeDetectorRef.detectChanges();
                this.dataSource.sort = this.sort;
            }
        });
    }

    refreshLogs(): void {
        if (!this.loading) {
            this.loading = true;
            this.searchForLogs();
        }
        else {
            this.CmSvc.ShowMessage('Refreshing, please wait...')
        }
    }

    openFiltersModal() {
        const dialogRef = this.dialog.open(LogFiltersComponent, {
            width: '700px',
            hasBackdrop: true,
            disableClose: false,
            autoFocus: false,
            panelClass: 'custom-dialog-container',
            data: {
                accessTypes: this.oList_Access_Type,
                chosenAccessTypes: this.oList_Chosen_Access_Type,
                logTypes: this.oList_Log_Type,
                chosenLogTypes: this.oList_Chosen_Log_Type,
                organizations: this.oList_Organization,
                chosenOrganizations: this.oList_Chosen_Organization,
                sites: this.oList_Site,
                chosenSites: this.oList_Chosen_Site,
                entities: this.oList_Entity,
                chosenEntities: this.oList_Chosen_Entity,
                startDate: this.startDate,
                endDate: this.endDate,
                videoAiAssets: this.oList_Video_ai_asset,
                chosenVideoAiAssets: this.oList_Chosen_Video_ai_asset,
            }
        });
        dialogRef.afterClosed().subscribe(result => {
            if (result == true) {
                this.oList_Chosen_Access_Type = dialogRef.componentInstance.oList_Access_Type.filter(accessType => accessType.CHECKED).map(accessType => accessType.ACCESS_TYPE);
                this.oList_Chosen_Log_Type = dialogRef.componentInstance.oList_Log_Type.filter(logType => logType.CHECKED).map(logType => logType.LOG_TYPE);
                this.oList_Chosen_Organization = dialogRef.componentInstance.oList_Organization.filter(organization => organization.CHECKED).map(organization => organization.ORGANIZATION);
                this.oList_Chosen_Site = dialogRef.componentInstance.oList_Site.filter(site => site.CHECKED).map(site => site.SITE);
                this.oList_Chosen_Entity = dialogRef.componentInstance.oList_Entity.filter(entity => entity.CHECKED).map(entity => entity.ENTITY);
                this.oList_Chosen_Video_ai_asset = dialogRef.componentInstance.oList_Video_ai_asset.filter(video_ai_asset => video_ai_asset.CHECKED).map(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET);
                this.startDate = dialogRef.componentInstance.dataRange.value.startDate;
                this.endDate = dialogRef.componentInstance.dataRange.value.endDate;
                this.pageIndex = 0;
                this.searchForLogs();
            }
        });
    }

    searchForLogs() {
        this.isFetching = true;
        this.LogsService.getLogsWithFilters(this.oList_Chosen_Organization,
            this.oList_Chosen_User,
            this.oList_Chosen_Log_Type,
            this.oList_Chosen_Access_Type,
            this.oList_Chosen_Site,
            this.oList_Chosen_Entity,
            this.startDate,
            this.endDate,
            this.pageIndex * this.pageSize,
            (this.pageIndex + 1) * this.pageSize,
            this.oList_Chosen_Video_ai_asset)
            .then(() => {
                this.loading = false;
                this.isFetching = false;
            });
    }

    changePage(paginatorEvent) {
        this.pageSize = paginatorEvent.pageSize;
        this.pageIndex = paginatorEvent.pageIndex;
        this.searchForLogs();
    }

    getLogTypeValue(i_Log: Log) {
        return this.oList_Log_Type.find(logType => logType.SETUP_ID == i_Log.LOG_TYPE_SETUP_ID).VALUE;
    }

    getAccessTypeValue(i_Log: Log) {
        return this.oList_Access_Type.find(accessType => accessType.SETUP_ID == i_Log.ACCESS_TYPE_SETUP_ID).VALUE;
    }

    generateLogExcel(): void {
        if (!this.downloadingReport) {
            this.downloadingReport = true;
            this.LogsService.generateLogsExcel(
                this.oList_Chosen_Organization,
                this.oList_Chosen_User,
                this.oList_Chosen_Log_Type,
                this.oList_Chosen_Access_Type,
                this.oList_Chosen_Site,
                this.oList_Chosen_Entity,
                this.startDate, this.endDate,
                null, null,
                this.oList_Chosen_Video_ai_asset
            ).then(result => {
                if (result) {
                    FileSaver.saveAs(result.EXCEL_URL, result.REPORT_NAME);
                }
                this.downloadingReport = false;
            })
        }
    }

    removeDateChoice() {
        this.startDate = null;
        this.endDate = null;
        this.pageIndex = 0;
        this.searchForLogs();
    }

    removeLogTypChoice(i_Log_type_setup: Setup) {
        this.oList_Chosen_Log_Type.splice(this.oList_Chosen_Log_Type.indexOf(i_Log_type_setup));
        this.pageIndex = 0;
        this.searchForLogs();
    }

    removeAccessTypChoice(i_Access_type_setup: Setup) {
        this.oList_Chosen_Access_Type.splice(this.oList_Chosen_Access_Type.indexOf(i_Access_type_setup));
        this.pageIndex = 0;
        this.searchForLogs();
    }

    ngOnDestroy() {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
