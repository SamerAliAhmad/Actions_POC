import { Subject } from 'rxjs';
import { Router } from '@angular/router';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { CommonService } from 'app/core/Services/common.service';
import { Component, HostListener, Input, OnInit } from '@angular/core';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { VideoAiInstanceDetailsService } from '../video-ai-instance-details.service';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { AddVideoAiAssetModalComponent } from './add-video-ai-asset-modal/add-video-ai-asset-modal.component';
import { Surveillance_Camera_Content, Video_ai_asset, Video_ai_instance } from 'app/core/Services/proxy.service';

@Component({
    selector: 'video-ai-assets',
    templateUrl: './video-ai-assets.component.html',
    styleUrls: ['./video-ai-assets.component.scss']
})

export class VideoAiAssetsComponent implements OnInit {

    @Input() oVideo_ai_instance: Video_ai_instance;

    assetSearchFormControl: FormControl;
    oList_Video_ai_asset: Video_ai_asset[] = [];
    oList_Engine_asset: Surveillance_Camera_Content[] = [];

    isMobileView = false;
    isContentLoaded = false;
    isConfiguredWrong = false;

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private _smartrConfirmationService: SmartrConfirmationService,
        private VideoAiInstanceDetailsService: VideoAiInstanceDetailsService,
    ) {
        this.assetSearchFormControl = new FormControl();
    }

    ngOnInit(): void {
        this.isMobileView = window.innerWidth < 600;
        this.VideoAiInstanceDetailsService.getVideoAiAssets().then(result => {
            if (result) {
                this.isContentLoaded = true;
            } else {
                this.isConfiguredWrong = true;
            }
        })
        this.VideoAiInstanceDetailsService.onVideoAiAssetsChanged.pipe(takeUntil(this._unsubscribeAll))
            .subscribe(oVideo_ai_assets_with_engine_assets => {
                if (oVideo_ai_assets_with_engine_assets) {
                    this.oList_Video_ai_asset = oVideo_ai_assets_with_engine_assets.VIDEO_AI_ASSET_WITH_FLAG_LIST;
                    this.oList_Engine_asset = oVideo_ai_assets_with_engine_assets.ASSET_LIST.filter(engine_asset => !(this.oList_Video_ai_asset.map(x => x.VIDEO_AI_ASSET_ID_REF).includes(engine_asset.CameraId)));
                }
                this.isContentLoaded = true;

            });

        this.assetSearchFormControl.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(300),
                distinctUntilChanged()
            )
            .subscribe((searchText) => {
                this.VideoAiInstanceDetailsService.filterSearchVideoAiAssets(searchText);
            });

    }

    addAsset(): void {
        this.dialog.open(AddVideoAiAssetModalComponent, {
            width: '800px',
            data: {
                engine_assets: this.oList_Engine_asset,
                video_ai_instance_id: this.oVideo_ai_instance.VIDEO_AI_INSTANCE_ID
            }
        })
    }

    deleteVideoAiAsset(videoAiAssetID: number): void {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Delete',
            message: 'Are you sure you want to delete this asset?',
            actions: {
                confirm: {
                    show: true,
                    label: 'Yes',
                    color: 'warn',
                },
                cancel: {
                    show: true,
                    label: 'No',
                }
            }
        });
        dialogRef.afterClosed().subscribe((result) => {
            if (result === 'confirmed') {
                this.isContentLoaded = false;
                this.VideoAiInstanceDetailsService.deleteVideoAiAsset(videoAiAssetID).then(result => {
                    this.isContentLoaded = true;
                    if (result == true) {
                        this.CmSvc.ShowMessage('Asset Deleted');
                    }
                })
            }
        });
    }

    goToAssetDetails(videoAiAssetID: number) {
        this.router.navigateByUrl(`${this.router.url}/${videoAiAssetID}`)
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
