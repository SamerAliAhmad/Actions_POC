import { Component, HostListener, OnDestroy, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Fetch_License_Plate_Targets_Response_Content, License_Plate_Category } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { VideoAIService } from './../../video-ai.service';

@Component({
    selector: 'license-plate-list',
    templateUrl: './license-plate-list.component.html',
    styleUrls: ['./license-plate-list.component.scss']
})
export class LicensePlateListComponent implements OnInit, OnDestroy {

    isSearching = false;
    isNoLicensePlates = false;

    dataSource = new MatTableDataSource<Fetch_License_Plate_Targets_Response_Content>();
    displayedColumns: string[] = ['License Plate', 'Category', 'Vehicle Owner', 'Registration Date', 'Description'];

    pageIndex = 0;
    pageSize = 20;
    licensePlateListCount = 0;

    oSelected_License_Plate_Category: string;
    licensePlateNumberSearchInput: FormControl;
    oList_License_Plate_Categories: License_Plate_Category[] = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
    ) {
        this.licensePlateNumberSearchInput = new FormControl('');
        this.oList_License_Plate_Categories = this.CmSvc.oList_License_Plate_Categories;

        if (localStorage.getItem('licensePlateListSelectedCategory' + this.CmSvc.oUser_Details.USER_ID)) {
            try {
                this.oSelected_License_Plate_Category = JSON.parse(localStorage.getItem('licensePlateListSelectedCategory' + this.CmSvc.oUser_Details.USER_ID));
            } catch {
                this.oSelected_License_Plate_Category = null;
            }
        }
        if (localStorage.getItem('licensePlateNumberSearch' + this.CmSvc.oUser_Details.USER_ID)) {
            try {
                this.licensePlateNumberSearchInput.setValue(JSON.parse(localStorage.getItem('licensePlateNumberSearch' + this.CmSvc.oUser_Details.USER_ID)));
            } catch {
                this.licensePlateNumberSearchInput.setValue('');
            }
        }
    }

    ngOnInit(): void {
        this.VideoAIService.licensePlateTargetsBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(licensePlateList => {
            if (licensePlateList) {
                this.dataSource.data = licensePlateList.Content?.map(licensePlate => {
                    licensePlate.CreateDate = licensePlate.CreateDate.split('.')[0].replace('T', ' ');
                    return licensePlate;
                });
                this.licensePlateListCount = licensePlateList.TotalElements;
                this.isNoLicensePlates = false;
                if (this.licensePlateListCount == 0) {
                    this.isNoLicensePlates = true;
                }
            } else {
                this.licensePlateListCount = 0;
                this.isNoLicensePlates = true;
            }
        });

        this.searchLicensePlateTargets();

        this.licensePlateNumberSearchInput.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(1000),
                distinctUntilChanged()
            )
            .subscribe(licensePlateNumber => {
                this.searchLicensePlateTargets();
            });
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('licensePlateListSelectedCategory' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oSelected_License_Plate_Category));
        localStorage.setItem('licensePlateNumberSearch' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.licensePlateNumberSearchInput.value));
        return true;
    }

    setPage(event: PageEvent) {
        this.pageSize = event.pageSize;
        this.pageIndex = event.pageIndex;
        this.searchLicensePlateTargets();
    }

    searchLicensePlateTargets() {
        this.isSearching = true;
        this.isNoLicensePlates = false;
        this.VideoAIService.fetchLicensePlateTargets(this.licensePlateNumberSearchInput.value, this.oSelected_License_Plate_Category, this.pageSize, this.pageIndex).then(() => {
            this.isSearching = false;
        });
    }

    searchLicensePlateTargetsOnEnter(event: KeyboardEvent) {
        if (event.key == 'Enter') {
            this.searchLicensePlateTargets();
        }
    }

    chooseLicensePlateCategory(chosenLicensePlateCateogory): void {
        this.oSelected_License_Plate_Category = chosenLicensePlateCateogory.value;
        this.searchLicensePlateTargets();
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
