import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import {
    Entity,
    Generate_Logs_Excel_Response,
    Log_With_Count,
    Organization,
    Params_Generate_Logs_Excel,
    Params_Get_Logs_With_Filters,
    Proxy,
    Setup,
    Site,
    User,
    Video_ai_asset,
} from 'app/core/Services/proxy.service';
import { ReplaySubject } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class LogsService {

    onLogsChanged = new ReplaySubject<Log_With_Count>(1);
    oList_Video_ai_asset: Video_ai_asset[];

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
    ) { }

    getLogsWithFilters(
        iListOrganization: Organization[] = null,
        iListUser: User[] = null,
        iListLogType: Setup[] = null,
        iListAccessType: Setup[] = null,
        iListSite: Site[] = null,
        iListEntity: Entity[] = null,
        startDate: Date = null,
        endDate: Date = null,
        startRow: number = 0,
        endRow: number = 20,
        iListVideoAiAsset: Video_ai_asset[] = null,
    ): Promise<Log_With_Count> {
        return new Promise((resolve, reject) => {
            const oParams_Get_Logs_With_Filters = new Params_Get_Logs_With_Filters();
            if (this.CmSvc.oUser_Details.User_type_setup.VALUE != "Super Admin") {
                oParams_Get_Logs_With_Filters.ORGANIZATION_ID_LIST = [this.CmSvc.oOrganization.ORGANIZATION_ID];
            } else {
                if (iListOrganization) {
                    oParams_Get_Logs_With_Filters.ORGANIZATION_ID_LIST = iListOrganization.map(organization => organization.ORGANIZATION_ID);
                }
            }
            if (iListUser) {
                oParams_Get_Logs_With_Filters.USER_ID_LIST = iListUser.map(user => user.USER_ID);
            }
            if (iListAccessType) {
                oParams_Get_Logs_With_Filters.ACCESS_TYPE_SETUP_ID_LIST = iListAccessType.map(setup => setup.SETUP_ID);
            }
            if (iListLogType) {
                oParams_Get_Logs_With_Filters.LOG_TYPE_SETUP_ID_LIST = iListLogType.map(setup => setup.SETUP_ID);
            }
            if (iListSite) {
                oParams_Get_Logs_With_Filters.SITE_ID_LIST = iListSite.map(site => site.SITE_ID);
            }
            if (iListEntity) {
                oParams_Get_Logs_With_Filters.ENTITY_ID_LIST = iListEntity.map(entity => entity.ENTITY_ID);
            }
            if (iListVideoAiAsset) {
                oParams_Get_Logs_With_Filters.VIDEO_AI_ASSET_ID_LIST = iListVideoAiAsset.map(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID);
            }
            if (startDate) {
                oParams_Get_Logs_With_Filters.START_DATE = startDate.toUTCString();
            }
            if (endDate) {
                const oEndDate = new Date(endDate);
                oEndDate.setDate(oEndDate.getDate() + 1);
                oParams_Get_Logs_With_Filters.END_DATE = oEndDate.toUTCString();
            }
            if (startRow) {
                oParams_Get_Logs_With_Filters.START_ROW = startRow;
            }
            if (endRow) {
                oParams_Get_Logs_With_Filters.END_ROW = endRow;
            }
            this.proxy.Get_Logs_With_Filters(oParams_Get_Logs_With_Filters).subscribe(result => {
                if (result) {
                    this.onLogsChanged.next(result);
                }
                resolve(result);
            })
        })
    }

    generateLogsExcel(
        iListOrganization: Organization[] = null,
        iListUser: User[] = null,
        iListLogType: Setup[] = null,
        iListAccessType: Setup[] = null,
        iListSite: Site[] = null,
        iListEntity: Entity[] = null,
        startDate: Date = null,
        endDate: Date = null,
        startRow: number = 0,
        endRow: number = 10000,
        iListVideoAiAsset: Video_ai_asset[] = null,
    ): Promise<Generate_Logs_Excel_Response> {
        return new Promise((resolve, reject) => {
            const oParams_Generate_Logs_Excel = new Params_Generate_Logs_Excel();
            if (this.CmSvc.oUser_Details.User_type_setup.VALUE != "Super Admin") {
                oParams_Generate_Logs_Excel.ORGANIZATION_ID_LIST = [this.CmSvc.oOrganization.ORGANIZATION_ID];
            } else {
                if (iListOrganization) {
                    oParams_Generate_Logs_Excel.ORGANIZATION_ID_LIST = iListOrganization.map(organization => organization.ORGANIZATION_ID);
                }
            } if (iListUser) {
                oParams_Generate_Logs_Excel.USER_ID_LIST = iListUser.map(user => user.USER_ID);
            }
            if (iListAccessType) {
                oParams_Generate_Logs_Excel.ACCESS_TYPE_SETUP_ID_LIST = iListAccessType.map(setup => setup.SETUP_ID);
            }
            if (iListLogType) {
                oParams_Generate_Logs_Excel.LOG_TYPE_SETUP_ID_LIST = iListLogType.map(setup => setup.SETUP_ID);
            }
            if (iListSite) {
                oParams_Generate_Logs_Excel.SITE_ID_LIST = iListSite.map(site => site.SITE_ID);
            }
            if (iListEntity) {
                oParams_Generate_Logs_Excel.ENTITY_ID_LIST = iListEntity.map(entity => entity.ENTITY_ID);
            }
            if (iListVideoAiAsset) {
                oParams_Generate_Logs_Excel.VIDEO_AI_ASSET_ID_LIST = iListVideoAiAsset.map(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID);
            }
            if (startDate) {
                oParams_Generate_Logs_Excel.START_DATE = startDate.toDateString();
            }
            if (endDate) {
                oParams_Generate_Logs_Excel.END_DATE = endDate.toDateString();
            }
            if (startRow) {
                oParams_Generate_Logs_Excel.START_ROW = startRow;
            }
            if (endRow) {
                oParams_Generate_Logs_Excel.END_ROW = endRow;
            }
            this.proxy.Generate_Logs_Excel(oParams_Generate_Logs_Excel).subscribe(result => {
                resolve(result);
            })
        })
    }

    Get_Video_ai_assets(): Promise<Video_ai_asset[]> {
        return new Promise(resolve => {
            if (this.oList_Video_ai_asset) {
                resolve(this.oList_Video_ai_asset);
            } else {
                this.proxy.Get_Video_ai_asset_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.oList_Video_ai_asset = result;
                    resolve(this.oList_Video_ai_asset);
                });
            }
        });
    }

    ngOnDestroy() {
        this.onLogsChanged.unsubscribe();
    }
}
