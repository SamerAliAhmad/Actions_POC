import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CommonService } from './common.service';
import { Action_Result } from './proxy.service';

@Injectable()
export class ProxyExt {
    constructor(private api: HttpClient, private CmSvc: CommonService) { }

    Upload_Share_File(i_Params_Upload_Share_File: Params_Upload_Share_File): Observable<HttpResponse<any>> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Upload_Share_File';

        const headers = new HttpHeaders(
            {
                'ticket': this.CmSvc.Ticket,
                'Accept': 'application/json',
                'userID': String(i_Params_Upload_Share_File.USER_ID),
            });
        return this.api.post(url, i_Params_Upload_Share_File.FormData, { headers, observe: 'response' });
    }

    Detect_Face_In_Image(i_Params_Detect_Face_In_Image: Params_Detect_Face_In_Image): Observable<HttpResponse<any>> {
        const url = this.CmSvc.APIUrl + '/api/VideoAIEngineManagement/Detect_Face_In_Image';

        const headers = new HttpHeaders(
            {
                'ticket': this.CmSvc.Ticket,
            });
        return this.api.post(url, i_Params_Detect_Face_In_Image.FormData, { headers, observe: 'response' });
    }

    Create_Log(i_Params_Create_Log: Params_Create_Log): void {
        const url = this.CmSvc.APIUrl + '/Api/PlatformLogging/Create_Log';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        this.api.post<void>(url, JSON.stringify(i_Params_Create_Log), options).subscribe()
    }
}
export class Result_Upload_Share_File extends Action_Result {
    i_Result: string;
}
export class Params_Upload_Share_File {
    FormData: FormData;
    USER_ID: number;
}
export class Result_Detect_Face_In_Image extends Action_Result {
    i_Result: string;
}
export class Params_Detect_Face_In_Image {
    FormData: FormData;
}
export class Detect_Face_Response {
    Position: Position_Response;
    Descriptor: string;
    Confidence: number;
    Path: string;
    Age: number;
    AgeGroup: string;
    Gender: string;
}
export class Position_Response {
    X: number;
    Y: number;
    W: number;
    H: number;
}
export class Params_Create_Log {
    SITE_ID?: number;
    USER_ID?: number;
    ENTITY_ID?: number;
    MESSAGE: string;
    VIDEO_AI_ASSET_ID?: number;
    LOG_TYPE_SETUP_ID?: number;
    ACCESS_TYPE_SETUP_ID?: number;
}