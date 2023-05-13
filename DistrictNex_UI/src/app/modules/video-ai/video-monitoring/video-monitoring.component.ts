import { cloneDeep } from 'lodash';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { LogsService } from 'app/core/Services/logs.service';
import { CommonService } from 'app/core/Services/common.service';
import { Video_ai_asset } from 'app/core/Services/proxy.service';

@Component({
    selector: 'video-monitoring',
    templateUrl: './video-monitoring.component.html',
    styleUrls: ['./video-monitoring.component.scss']
})
export class VideoMonitoringComponent implements OnInit, OnDestroy {
    showVideo = false;
    isShowStream = true;
    oVaidioCameras: Video_ai_asset[];

    isRefreshCameras = false;
    AreCamerasLoaded = false;

    constructor(
        private CmSvc: CommonService,
        private LogsService: LogsService,
    ) {
        this.oVaidioCameras = cloneDeep(this.CmSvc.oStream_Data.List_Video_ai_asset);
    }

    ngOnInit(): void {
        this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Video Monitoring Panel",
            this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Video Monitoring Panel").SETUP_ID,
            this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID);
    }

    removeCamera(cameraId) {
        this.oVaidioCameras.splice(this.oVaidioCameras.findIndex(camera => camera.VIDEO_AI_INSTANCE_ID == cameraId), 1);
    }

    removeCameraStream() {
        this.isShowStream = false;
    }

    ngOnDestroy(): void {
        this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Exited Video Monitoring Panel",
            this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Video Monitoring Panel").SETUP_ID,
            this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID);
    }
}
