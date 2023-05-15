import { ReplaySubject } from 'rxjs';
import FuzzySearch from 'fuzzy-search';
import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Proxy, Video_ai_engine } from 'app/core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class VideoAiEngineListService {

    oList_Video_ai_engine: Video_ai_engine[];
    onVideoAiEnginesChanged: ReplaySubject<Video_ai_engine[]>;

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService
    ) {
        this.onVideoAiEnginesChanged = new ReplaySubject(1);
    }

    getVideoAiEngines(): Promise<Video_ai_engine[]> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Video_ai_engine_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                this.oList_Video_ai_engine = result;
                this.onVideoAiEnginesChanged.next(result);
                resolve(result);
            }, reject)
        })
    }

    filterSearchVideoAiEngine(videoAiEngineName: string): void {
        let resultList = this.oList_Video_ai_engine;
        if (videoAiEngineName && videoAiEngineName.trim() != '') {
            const searcher = new FuzzySearch(resultList, ['ENGINE_NAME']);
            resultList = searcher.search(videoAiEngineName);
        }
        this.onVideoAiEnginesChanged.next(resultList);
    }

    createVideoAiEngine(i_Video_ai_engine: Video_ai_engine): Promise<Video_ai_engine> {
        return new Promise((resolve) => {
            this.proxy.Edit_Video_ai_engine(i_Video_ai_engine).subscribe(result => {
                this.oList_Video_ai_engine.unshift(result);
                this.onVideoAiEnginesChanged.next(this.oList_Video_ai_engine);
                this.CmSvc.Handle_Success();
                resolve(result);
            });
        });
    }
}
