import { Subject } from 'rxjs';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Component, HostListener, OnInit } from '@angular/core';
import { Video_ai_engine } from 'app/core/Services/proxy.service';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { VideoAiEngineListService } from '../video-ai-engine-list/video-ai-engine-list.service';
import { AddVideoAiEngineModalComponent } from './add-video-ai-engine-modal/add-video-ai-engine-modal.component';

@Component({
    selector: 'video-ai-engine-list',
    templateUrl: './video-ai-engine-list.component.html',
    styleUrls: ['./video-ai-engine-list.component.scss']
})
export class VideoAiEngineListComponent implements OnInit {

    private _unsubscribeAll = new Subject<void>();

    isMobileView = false;
    isThereChange = false;
    isContentLoaded = false;
    isEngineListEmpty = false;

    oList_Video_ai_engine: Video_ai_engine[];
    bulkVideoAiEngineIndexesSelect: number[] = [];

    engineSearchFormControl: FormControl;

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }

    constructor(
        private dialog: MatDialog,
        private VideoAiEngineListService: VideoAiEngineListService,
    ) {
        this.engineSearchFormControl = new FormControl();
    }

    ngOnInit(): void {
        this.VideoAiEngineListService.getVideoAiEngines().then(engines => {
            if (engines) {
                this.isContentLoaded = true;
            }
        });
        this.VideoAiEngineListService.onVideoAiEnginesChanged.pipe(takeUntil(this._unsubscribeAll))
            .subscribe(engines => {
                this.oList_Video_ai_engine = engines;
                this.isContentLoaded = true;
            });

        this.engineSearchFormControl.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(300),
                distinctUntilChanged()
            )
            .subscribe((searchText) => {
                this.VideoAiEngineListService.filterSearchVideoAiEngine(searchText);
            });

    }

    createVideoAiEngine(): void {
        const dialogRef = this.dialog.open(AddVideoAiEngineModalComponent, {
            width: '800px',
        });
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

}
