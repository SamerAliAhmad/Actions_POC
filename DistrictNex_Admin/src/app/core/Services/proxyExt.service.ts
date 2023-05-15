import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CommonService } from './common.service';
import { Action_Result } from './proxy.service';

@Injectable()
export class ProxyExt {
    constructor(private api: HttpClient, private CmSvc: CommonService) { }

    Upload_Organization_Picture(i_Params_Upload_Organization_Picture: Params_Upload_Organization_Picture): Observable<HttpResponse<any>> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Upload_Organization_Picture';

        const headers = new HttpHeaders(
            {
                'ticket': this.CmSvc.Ticket,
                'Accept': 'application/json',
                'organizationID': String(i_Params_Upload_Organization_Picture.ORGANIZATION_ID),
                'imageSetupID': String(i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID),
            });
        return this.api.post(url, i_Params_Upload_Organization_Picture.FormData, { headers, observe: 'response' });
    }

    Upload_Default_Settings_Picture(i_Params_Upload_Default_Settings_Picture: Params_Upload_Default_Settings_Picture): Observable<HttpResponse<any>> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Upload_Default_Settings_Picture';

        const headers = new HttpHeaders(
            {
                'ticket': this.CmSvc.Ticket,
                'Accept': 'application/json',
                'imageSetupID': String(i_Params_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID),
            });
        return this.api.post(url, i_Params_Upload_Default_Settings_Picture.FormData, { headers, observe: 'response' });
    }
}
export class Result_Upload_Organization_Picture extends Action_Result {
    i_Result: string;
}
export class Params_Upload_Organization_Picture {
    FormData: FormData;
    ORGANIZATION_ID: string;
    IMAGE_TYPE_SETUP_ID: string;
}
export class Result_Upload_Default_Settings_Picture extends Action_Result {
    i_Result: string;
}
export class Params_Upload_Default_Settings_Picture {
    FormData: FormData;
    IMAGE_TYPE_SETUP_ID: string;
}