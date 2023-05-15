import { Injectable } from '@angular/core';
import { Observable, Subject, Subscription } from 'rxjs';
import { CommonService } from 'app/core/Services/common.service';
import { Proxy, Video_ai_asset } from 'app/core/Services/proxy.service';
import { ActivatedRouteSnapshot, Router, RouterStateSnapshot } from '@angular/router';

@Injectable({
    providedIn: 'root'
})
export class VideoAiAssetDetailsService {

    id: number;
    route = '';

    onAssetDetailsChanged: Subject<Video_ai_asset>;

    Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Subscription = new Subscription();

    oVideo_ai_asset: Video_ai_asset = new Video_ai_asset();

    constructor(
        private proxy: Proxy,
        private router: Router,
        private CmSvc: CommonService,
    ) {
        this.onAssetDetailsChanged = new Subject();
    }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return new Promise<void>((resolve, reject) => {
            this.id = route.params.videoAiAssetId;
            Promise.all([
            ]).then(
                () => {
                    this.getAssetDetails();
                    resolve();
                },
                reject
            );
        });
    }

    getAssetDetails(): Promise<Video_ai_asset> {
        return new Promise((resolve, reject) => {
            if (!isNaN(this.id) && !isNaN(this.id - 0)) {

                this.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Subscription =
                    this.proxy.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv({ VIDEO_AI_ASSET_ID: this.id })
                        .subscribe(result_asset => {
                            if (result_asset != null) {
                                this.oVideo_ai_asset = result_asset;
                                this.onAssetDetailsChanged.next(result_asset);
                                resolve(result_asset);
                            } else {
                                this.onAssetDetailsChanged.next(null);
                                this.router.navigateByUrl("/video-ai-management");
                                resolve(null);
                            }
                        });
            }
            else {
                this.onAssetDetailsChanged.next(null);
                this.router.navigateByUrl("/video-ai-management");
                resolve(null);
            }
        });
    }

    editVideoAiAsset(i_Video_ai_asset: Video_ai_asset): Promise<any> {
        return new Promise((resolve, reject) => {
            return new Promise((resolve) => {
                this.proxy.Edit_Video_ai_asset(i_Video_ai_asset).subscribe(result => {
                    this.onAssetDetailsChanged.next(result);
                    this.CmSvc.Handle_Success();
                    resolve(result);
                });
            });
        });
    }
}
