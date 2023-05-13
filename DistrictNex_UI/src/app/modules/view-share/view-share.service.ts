import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Entity_share_view_data, Proxy } from 'app/core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class ViewShareService {

    oEntity_share_view_data: Entity_share_view_data;
    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
    ) { }

    Get_Entity_Share_Data(UNIQUE_STRING: string): Promise<Entity_share_view_data> {
        return new Promise(resolve => {
            this.proxy.Get_Entity_share_view_data({ UNIQUE_STRING: UNIQUE_STRING }).subscribe(result => {
                this.CmSvc.oList_Setup_category = result.List_Setup_category;
                this.CmSvc.oList_Kpi_chart_configuration = result.List_Kpi_chart_configuration;
                this.oEntity_share_view_data = result;
                resolve(result);
            });
        });
    }
}
