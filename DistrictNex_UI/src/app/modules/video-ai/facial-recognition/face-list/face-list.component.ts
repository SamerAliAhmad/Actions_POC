import { Subject } from 'rxjs';
import { FormControl } from '@angular/forms';
import { PageEvent } from '@angular/material/paginator';
import { VideoAIService } from './../../video-ai.service';
import { SafeResourceUrl } from '@angular/platform-browser';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Component, HostListener, OnInit, OnDestroy } from '@angular/core';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { Face_Target_Response_Category, Fetch_Face_Target_Response_Content } from './../../../../core/Services/proxy.service';

@Component({
    selector: 'face-list',
    templateUrl: './face-list.component.html',
    styleUrls: ['./face-list.component.scss']
})
export class FaceListComponent implements OnInit, OnDestroy {

    isSearching: boolean = false;
    isNoLicensePlates: boolean = false;

    dataSource = new MatTableDataSource<Fetch_Face_Target_Response_Content>();
    displayedColumns: string[] = ['Face Image', 'Name', 'List', 'Birth Year', 'Gender', 'Description'];

    pageIndex = 0;
    pageSize = 10;
    faceListCount = 0;

    oSelected_Face_Target_List: string;
    targetNameSearchInput: FormControl;
    oList_Face_Target_Lists: Face_Target_Response_Category[] = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private VideoAIService: VideoAIService,
    ) {
        this.targetNameSearchInput = new FormControl('');
        this.oList_Face_Target_Lists = this.CmSvc.oList_Face_Target_List;

        if (localStorage.getItem('faceListSelectedCategory' + this.CmSvc.oUser_Details.USER_ID)) {
            try {
                this.oSelected_Face_Target_List = JSON.parse(localStorage.getItem('faceListSelectedCategory' + this.CmSvc.oUser_Details.USER_ID));
            } catch {
                this.oSelected_Face_Target_List = null;
            }
        }
        if (localStorage.getItem('targetNameSearch' + this.CmSvc.oUser_Details.USER_ID)) {
            try {
                this.targetNameSearchInput.setValue(JSON.parse(localStorage.getItem('targetNameSearch' + this.CmSvc.oUser_Details.USER_ID)));
            } catch {
                this.targetNameSearchInput.setValue('');
            }
        }
    }

    ngOnInit(): void {
        this.VideoAIService.faceTargetsBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(faceList => {
            if (faceList) {
                this.dataSource.data = faceList.Content?.map(face => {
                    face.CreateDate = face.CreateDate.split('.')[0].replace('T', ' ');
                    return face;
                });
                this.faceListCount = faceList.TotalElements;
                this.isNoLicensePlates = false;
                if (this.faceListCount == 0) {
                    this.isNoLicensePlates = true;
                }
            } else {
                this.faceListCount = 0;
                this.isNoLicensePlates = true;
            }
        });
        this.searchFaceTargets();

        this.targetNameSearchInput.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(1000),
                distinctUntilChanged()
            )
            .subscribe(targetName => {
                this.searchFaceTargets();
            });
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('faceListSelectedCategory' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oSelected_Face_Target_List));
        localStorage.setItem('targetNameSearch' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.targetNameSearchInput.value));
        return true;
    }

    setPage(event: PageEvent) {
        this.pageSize = event.pageSize;
        this.pageIndex = event.pageIndex;
        this.searchFaceTargets();
    }

    searchFaceTargets() {
        this.isSearching = true;
        this.isNoLicensePlates = false;
        this.VideoAIService.fetchFaceTargets(this.targetNameSearchInput.value, this.oSelected_Face_Target_List, this.pageSize, this.pageIndex).then(() => {
            this.isSearching = false;
        });
    }

    searchFaceTargetsOnEnter(event: KeyboardEvent) {
        if (event.key == 'Enter') {
            this.searchFaceTargets();
        }
    }

    chooseFaceList(chosenFaceList): void {
        this.oSelected_Face_Target_List = chosenFaceList.value;
        this.searchFaceTargets();
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
