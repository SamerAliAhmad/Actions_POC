import { Subject } from 'rxjs';
import { FormControl } from '@angular/forms';
import { MatSort } from '@angular/material/sort';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { ChangeDetectorRef, Component, OnInit, ViewChild } from '@angular/core';
import { Log, Organization, Setup, User } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { LogFiltersComponent } from 'app/shared/components/organization-management/log-filters/log-filters.component';

@Component({
    selector: 'user-activity',
    templateUrl: './user-activity.component.html',
    styleUrls: ['./user-activity.component.scss']
})
export class UserActivityComponent implements OnInit {

    oUser: User;
    oOrganization: Organization;

    isContentLoaded = false;
    
    customerNameSearchInput: FormControl = new FormControl('');
    employeeNameSearchInput: FormControl = new FormControl('');
    
    pageIndex = 0;
    pageSize = 20;
    totalCount = 0;
    
    displayedColumns: string[] = ['logTime', 'logDate', 'message', 'logType', 'logAccess'];
    dataSource = new MatTableDataSource<Log>();
    
    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort, { static: true }) sort: MatSort;
    
    private _unsubscribeAll = new Subject<void>();
    
    oList_Log: Log[] = [];
    oList_Log_Type: Setup[] = [];
    oList_Access_Type: Setup[] = [];
    oList_Chosen_Log_Type: Setup[] = [];
    oList_Chosen_Access_Type: Setup[] = [];

    endDate;
    startDate;

    constructor(
        private router: Router,
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _changeDetectorRef: ChangeDetectorRef,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        const routes = this.router.url.split('/');
        routes.shift();

        const isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == parseInt(routes[1]));
        }
        this.OrganizationManagementService.get_User_Details(this.oOrganization, this.ActivatedRoute.snapshot.params.userId).then(result => {
            this.oUser = result;
            this.OrganizationManagementService.getLogsWithFilters(this.oUser.USER_ID).then(result => {
                if (result.List_Log.length > 0) {
                    this.totalCount = result.COUNT;
                    this.dataSource.data = result.List_Log;
                    this._changeDetectorRef.detectChanges();
                    this.dataSource.sort = this.sort;
                }
                this.isContentLoaded = true;
            });
        });

        this.customerNameSearchInput.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(300),
                distinctUntilChanged()
            )
            .subscribe(() => {
                this.searchForLogs();
            });

        this.oList_Access_Type = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Access Type")[0].List_Setup;
        this.oList_Log_Type = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Log Type")[0].List_Setup;
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
                startDate: this.startDate,
                endDate: this.endDate,
            }
        });
        dialogRef.afterClosed().subscribe(result => {
            if (result == true) {
                this.oList_Chosen_Access_Type = dialogRef.componentInstance.oList_Access_Type.filter(accessType => accessType.CHECKED).map(accessType => accessType.ACCESS_TYPE);
                this.oList_Chosen_Log_Type = dialogRef.componentInstance.oList_Log_Type.filter(logType => logType.CHECKED).map(logType => logType.LOG_TYPE);
                this.startDate = dialogRef.componentInstance.dataRange.value.startDate;
                this.endDate = dialogRef.componentInstance.dataRange.value.endDate;
                this.searchForLogs();
            }
        });
    }

    changePage(paginatorEvent) {
        this.pageSize = paginatorEvent.pageSize;
        this.pageIndex = paginatorEvent.pageIndex;
        this.searchForLogs();
    }

    searchForLogs() {
        this.OrganizationManagementService.getLogsWithFilters(this.oUser.USER_ID, this.oList_Chosen_Log_Type, this.oList_Chosen_Access_Type, this.startDate, this.endDate, this.pageIndex * this.pageSize, (this.pageIndex + 1) * this.pageSize).then(result => {
            this.totalCount = result.COUNT;
            this.dataSource.data = result.List_Log;
            this._changeDetectorRef.detectChanges();
            this.dataSource.sort = this.sort;
        });
    }

    getLogTypeValue(i_Log: Log) {
        return this.oList_Log_Type.find(logType => logType.SETUP_ID == i_Log.LOG_TYPE_SETUP_ID).VALUE;
    }

    getAccessTypeValue(i_Log: Log) {
        return this.oList_Access_Type.find(accessType => accessType.SETUP_ID == i_Log.ACCESS_TYPE_SETUP_ID).VALUE;
    }

    ngOnDestroy() {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
