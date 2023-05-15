import { Subject } from 'rxjs';
import { Location } from '@angular/common';
import { FormControl } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Video_ai_instance } from 'app/core/Services/proxy.service';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { VideoAiInstanceListService } from './video-ai-instance-list.service';
import { AddVideoAiInstanceModalComponent } from './add-video-ai-instance-modal/add-video-ai-instance-modal.component';

@Component({
    selector: 'video-ai-instance-list',
    templateUrl: './video-ai-instance-list.component.html',
    styleUrls: ['./video-ai-instance-list.component.scss']
})

export class VideoAiInstanceListComponent implements OnInit {

    instanceSearchFormControl: FormControl;
    oList_Video_ai_instance: Video_ai_instance[] = [];

    isContentLoaded = false;
    isInstanceListEmpty = false;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        public dialog: MatDialog,
        private Location: Location,
        private VideoAiInstanceListService: VideoAiInstanceListService,
    ) {
        this.instanceSearchFormControl = new FormControl();
    }

    ngOnInit(): void {
        this.VideoAiInstanceListService.onVideoAiInstancesChanged.pipe(takeUntil(this._unsubscribeAll))
            .subscribe(instances => {
                this.oList_Video_ai_instance = instances;
                this.isContentLoaded = true;
            });

        this.instanceSearchFormControl.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(300),
                distinctUntilChanged()
            )
            .subscribe((searchText) => {
                this.VideoAiInstanceListService.filterSearchVideoAiInstance(searchText);
            });

    }

    createInstance(): void {
        this.dialog.open(AddVideoAiInstanceModalComponent, {
            width: '800px',
        })
    }

    goBack(): void {
        this.Location.back();
    }


    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

}
