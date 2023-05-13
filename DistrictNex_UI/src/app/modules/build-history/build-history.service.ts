import { Injectable } from '@angular/core';
import { Build_Version_List_With_Logs, Build_version, Proxy, Setup_category } from 'app/core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class BuildHistoryService {

    oList_Build_version: Build_version[];
    oBuild_Log_Type_Setup_Category: Setup_category;

    constructor(
        private proxy: Proxy,
    ) { }

    Get_Build_Version_List(): Promise<Build_Version_List_With_Logs> {
        return new Promise(resolve => {
            if (this.oList_Build_version && this.oBuild_Log_Type_Setup_Category) {
                let oBuild_Version_List_With_Logs = new Build_Version_List_With_Logs();
                oBuild_Version_List_With_Logs.BUILD_LOG_TYPE_SETUP_CATEGORY = this.oBuild_Log_Type_Setup_Category;
                oBuild_Version_List_With_Logs.LIST_BUILD_VERSION = this.oList_Build_version;
                resolve(oBuild_Version_List_With_Logs);
            }
            else {
                this.proxy.Get_UI_Build_Version_List().subscribe(result => {
                    this.oList_Build_version = result.LIST_BUILD_VERSION;
                    this.oBuild_Log_Type_Setup_Category = result.BUILD_LOG_TYPE_SETUP_CATEGORY;
                    resolve(result)
                })
            }
        })
    }

    resolve() {
        return new Promise(resolve => {
            this.Get_Build_Version_List().then(result => {
                resolve(result)
            })
        })
    }
}
