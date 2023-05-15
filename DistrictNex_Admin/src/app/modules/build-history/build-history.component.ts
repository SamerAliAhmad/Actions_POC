import { Location } from '@angular/common';
import { Component } from '@angular/core';
import { Build_version, Setup_category } from 'app/core/Services/proxy.service';
import { cloneDeep } from 'lodash';
import { BuildHistoryService } from './build-history.service';

class Build_Version_With_Log_List {
    BUILD_VERSION: string;
    BUILD_DATE: string;
    LOG_LIST: Custom_Log_List[] = [];
}

class Custom_Log_List {
    Type: string;
    Description: string[];
}

@Component({
    selector: 'build-history',
    templateUrl: './build-history.component.html',
    styleUrls: ['./build-history.component.scss']
})
export class BuildHistoryComponent {

    oList_Build_version: Build_version[];
    oList_Build_Version_With_Log_List: Build_Version_With_Log_List[] = [];

    oBuild_Log_Type_Setup_Category: Setup_category;

    constructor(
        private Location: Location,
        private BuildHistoryService: BuildHistoryService
    ) {
        let oList_Custom_Log_List: Custom_Log_List[] = [];

        this.oList_Build_version = this.BuildHistoryService.oList_Build_version;
        this.oBuild_Log_Type_Setup_Category = this.BuildHistoryService.oBuild_Log_Type_Setup_Category;
        this.oBuild_Log_Type_Setup_Category.List_Setup.forEach(oSetup => {
            oList_Custom_Log_List.push({ Type: oSetup.VALUE, Description: [] });
        });
        this.oList_Build_version.forEach(oBuild_version => {
            let oBuild_Version_With_Log_List = new Build_Version_With_Log_List();
            oBuild_Version_With_Log_List.BUILD_DATE = oBuild_version.BUILD_DATE;
            oBuild_Version_With_Log_List.BUILD_VERSION = oBuild_version.BUILD_NUMBER;
            oBuild_Version_With_Log_List.LOG_LIST = cloneDeep(oList_Custom_Log_List);
            oBuild_version.List_Build_version_log.forEach(oBuild_version_log => {
                oBuild_version_log.Build_log_type_setup = this.oBuild_Log_Type_Setup_Category.List_Setup.find(oSetup => oSetup.SETUP_ID == oBuild_version_log.BUILD_LOG_TYPE_SETUP_ID);
                oBuild_Version_With_Log_List.LOG_LIST.find(oLog => oLog.Type == oBuild_version_log.Build_log_type_setup.VALUE).Description.push(oBuild_version_log.DESCRIPTION);
            });
            this.oList_Build_Version_With_Log_List.push(oBuild_Version_With_Log_List);
        });
        this.oList_Build_Version_With_Log_List.sort((a, b) => {
            return b.BUILD_VERSION.localeCompare(a.BUILD_VERSION)
        });
    }

    Go_Back() {
        this.Location.back();
    }

    Add_Divider(i_Build_Version_With_Log_List: Build_Version_With_Log_List) {
        return i_Build_Version_With_Log_List.LOG_LIST.some(log => log.Description.length > 0);
    }
}
