import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Entity, Organization, Setup, Site, Video_ai_asset } from 'app/core/Services/proxy.service';
import { Subject } from 'rxjs';

class Log_Type_With_Check {
    LOG_TYPE: Setup;
    CHECKED: boolean;
}

class Access_Type_With_Check {
    ACCESS_TYPE: Setup;
    CHECKED: boolean;
}

class Organization_With_Check {
    ORGANIZATION: Organization;
    CHECKED: boolean;
}

class Site_With_Check {
    SITE: Site;
    CHECKED: boolean;
}

class Entity_With_Check {
    ENTITY: Entity;
    CHECKED: boolean;
}

class Video_ai_asset_With_Check {
    VIDEO_AI_ASSET: Video_ai_asset;
    CHECKED: boolean;
}

@Component({
    selector: 'log-filters',
    templateUrl: './log-filters.component.html',
    styleUrls: ['./log-filters.component.scss']
})
export class LogFiltersComponent implements OnInit {
    dataRange = new FormGroup({
        startDate: new FormControl(),
        endDate: new FormControl(),
    });

    oList_Log_Type: Log_Type_With_Check[];
    oList_Access_Type: Access_Type_With_Check[];
    oList_Organization: Organization_With_Check[];
    oList_Site: Site_With_Check[];
    oList_Entity: Entity_With_Check[];
    oList_Video_ai_asset: Video_ai_asset_With_Check[];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: any,
        private dialogRef: MatDialogRef<LogFiltersComponent>
    ) {
        this.oList_Log_Type = [];
        this.oList_Access_Type = [];
        this.oList_Organization = [];
        this.oList_Site = [];
        this.oList_Entity = [];
        this.oList_Video_ai_asset = [];
        if (data) {
            if (data.accessTypes && data.accessTypes.length > 0) {
                data.accessTypes.forEach(accessType => {
                    this.oList_Access_Type.push({
                        ACCESS_TYPE: accessType,
                        CHECKED: data.chosenAccessTypes.map(oAccessType => oAccessType.SETUP_ID).includes(accessType.SETUP_ID),
                    });
                });
            }
            if (data.logTypes && data.logTypes.length > 0) {
                data.logTypes.forEach(logType => {
                    this.oList_Log_Type.push({
                        LOG_TYPE: logType,
                        CHECKED: data.chosenLogTypes.map(oLogType => oLogType.SETUP_ID).includes(logType.SETUP_ID),
                    });
                });
            }
            if (data.organizations && data.organizations.length > 0) {
                data.organizations.forEach(organization => {
                    this.oList_Organization.push({
                        ORGANIZATION: organization,
                        CHECKED: data.chosenOrganizations.map(oOrganization => oOrganization.ORGANIZATION_ID).includes(organization.ORGANIZATION_ID),
                    })
                })
            }
            if (data.sites && data.sites.length > 0) {
                data.sites.forEach(site => {
                    this.oList_Site.push({
                        SITE: site,
                        CHECKED: data.chosenSites.map(oSite => oSite.SITE_ID).includes(site.SITE_ID),
                    })
                })
            }
            if (data.entities && data.entities.length > 0) {
                data.entities.forEach(entity => {
                    this.oList_Entity.push({
                        ENTITY: entity,
                        CHECKED: data.chosenEntities.map(oEntity => oEntity.ENTITY_ID).includes(entity.ENTITY_ID),
                    })
                })
            }
            if (data.videoAiAssets && data.videoAiAssets.length > 0) {
                data.videoAiAssets.forEach(video_ai_asset => {
                    this.oList_Video_ai_asset.push({
                        VIDEO_AI_ASSET: video_ai_asset,
                        CHECKED: data.chosenVideoAiAssets.map(oVideo_ai_asset => oVideo_ai_asset.VIDEO_AI_ASSET_ID).includes(video_ai_asset.VIDEO_AI_ASSET_ID),
                    })
                })
            }
            if (data.startDate) {
                this.dataRange.controls.startDate.setValue(data.startDate);
            }
            if (data.endDate) {
                this.dataRange.controls.endDate.setValue(data.endDate);
            }
        }
    }

    ngOnInit(): void { }

    getHalf(list): number {
        return Math.round(list.length / 2);
    }

    applyFilter(): void {
        this.dialogRef.close(true);
    }

    clearDate(): void {
        this.dataRange.controls.startDate.setValue(null);
        this.dataRange.controls.endDate.setValue(null);
    }

    clearFilter(): void {
        this.oList_Log_Type = [];
        this.oList_Access_Type = [];
        this.oList_Organization = [];
        this.oList_Site = [];
        this.oList_Entity = [];
        this.oList_Video_ai_asset = [];
        if (this.data) {
            if (this.data.accessTypes && this.data.accessTypes.length > 0) {
                this.data.accessTypes.forEach(accessType => {
                    this.oList_Access_Type.push({
                        ACCESS_TYPE: accessType,
                        CHECKED: false,
                    });
                });
            }
            if (this.data.logTypes && this.data.logTypes.length > 0) {
                this.data.logTypes.forEach(logType => {
                    this.oList_Log_Type.push({
                        LOG_TYPE: logType,
                        CHECKED: false,
                    });
                });
            }
            if (this.data.organizations && this.data.organizations.length > 0) {
                this.data.organizations.forEach(organization => {
                    this.oList_Organization.push({
                        ORGANIZATION: organization,
                        CHECKED: false,
                    })
                })
            }
            if (this.data.sites && this.data.sites.length > 0) {
                this.data.sites.forEach(site => {
                    this.oList_Site.push({
                        SITE: site,
                        CHECKED: false,
                    })
                })
            }
            if (this.data.entities && this.data.entities.length > 0) {
                this.data.entities.forEach(entity => {
                    this.oList_Entity.push({
                        ENTITY: entity,
                        CHECKED: false,
                    })
                })
            }
            if (this.data.videoAiAssets && this.data.videoAiAssets.length > 0) {
                this.data.videoAiAssets.forEach(video_ai_asset => {
                    this.oList_Video_ai_asset.push({
                        VIDEO_AI_ASSET: video_ai_asset,
                        CHECKED: false,
                    })
                })
            }
            this.clearDate();
        }
    }

    ngOnDestroy(): void {
        // Unsubscribe from all subscriptions
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
