import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Params_Create_Video_ai_instance, Proxy, Video_ai_instance } from 'app/core/Services/proxy.service';
import FuzzySearch from 'fuzzy-search';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class VideoAiInstanceListService {
    id: number;
    route = '';

    videoAiInstanceList: Video_ai_instance[] = [];
    onVideoAiInstancesChanged: BehaviorSubject<Video_ai_instance[]>;

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
    ) {
        this.onVideoAiInstancesChanged = new BehaviorSubject([]);
    }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return new Promise<void>((resolve, reject) => {
            this.id = route.params.videoAiEngineId;
            Promise.all([
            ]).then(
                () => {
                    this.getVideoAiInstances()
                    resolve();
                },
                reject
            );
        });
    }

    getVideoAiInstances(): Promise<Video_ai_instance[]> {
        return new Promise((resolve) => {
            this.proxy.Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID({ VIDEO_AI_ENGINE_ID: this.id }).subscribe(result => {
                this.videoAiInstanceList = result;
                this.onVideoAiInstancesChanged.next(result);
                resolve(result);
            })
        })
    }

    filterSearchVideoAiInstance(videoAiInstanceName: string): void {
        let resultList = this.videoAiInstanceList;
        if (videoAiInstanceName && videoAiInstanceName.trim() != '') {
            const searcher = new FuzzySearch(resultList, ['FRIENDLY_NAME']);
            resultList = searcher.search(videoAiInstanceName);
        }
        this.onVideoAiInstancesChanged.next(resultList);
    }

    createVideoAiInstance(oVideo_ai_instance: Video_ai_instance): Promise<Video_ai_instance> {
        return new Promise((resolve) => {
            let oParams_Create_Video_ai_instance: Params_Create_Video_ai_instance = new Params_Create_Video_ai_instance();
            oParams_Create_Video_ai_instance.VIDEO_AI_ENGINE_ID = this.id;
            oParams_Create_Video_ai_instance.CONNECTION_URL = oVideo_ai_instance.CONNECTION_URL;
            oParams_Create_Video_ai_instance.FRIENDLY_NAME = oVideo_ai_instance.FRIENDLY_NAME;
            oParams_Create_Video_ai_instance.FUNCTIONAL_NAME = oVideo_ai_instance.FUNCTIONAL_NAME;
            oParams_Create_Video_ai_instance.USERNAME = oVideo_ai_instance.USERNAME;
            oParams_Create_Video_ai_instance.PASSWORD = oVideo_ai_instance.PASSWORD;
            oParams_Create_Video_ai_instance.CONNECTION_TYPE_SETUP_ID = oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID;
            oParams_Create_Video_ai_instance.IS_LPR = oVideo_ai_instance.IS_LPR;
            this.proxy.Create_Video_ai_instance(oParams_Create_Video_ai_instance).subscribe(result => {
                this.videoAiInstanceList.unshift(result);
                this.onVideoAiInstancesChanged.next(this.videoAiInstanceList);
                this.CmSvc.Handle_Success();
                resolve(result);
            });
        });
    }

    ngOnDestroy(): void {

    }
}
