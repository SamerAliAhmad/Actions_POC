import { Injectable } from '@angular/core';
import { Setup } from './proxy.service';
import { Params_Create_Log, ProxyExt } from './proxyExt.service';

@Injectable()
export class LogsService {

    oList_Log_Type_Setup: Setup[];
    oList_Access_Type_Setup: Setup[];

    constructor(
        private proxyExt: ProxyExt,
    ) {
    }

    Record_Logs(message: string, Log_Type_Setup_ID: number, Access_Type_Setup_ID: number, Site_ID: number = null, Entity_ID: number = null, Video_ai_asset_ID: number = null) {
        let oParams_Create_Log = new Params_Create_Log();
        oParams_Create_Log.LOG_TYPE_SETUP_ID = Log_Type_Setup_ID;
        oParams_Create_Log.ACCESS_TYPE_SETUP_ID = Access_Type_Setup_ID;
        oParams_Create_Log.MESSAGE = message;
        oParams_Create_Log.SITE_ID = Site_ID;
        oParams_Create_Log.ENTITY_ID = Entity_ID;
        oParams_Create_Log.VIDEO_AI_ASSET_ID = Video_ai_asset_ID;
        this.proxyExt.Create_Log(oParams_Create_Log);
    }
}
