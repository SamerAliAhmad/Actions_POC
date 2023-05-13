import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { CommonService } from './common.service';

@Injectable()
export class Proxy {
    constructor(private api: HttpClient, private CmSvc: CommonService) { }

    Get_Asset_By_ASSET_ID_List(i_Params_Get_Asset_By_ASSET_ID_List: Params_Get_Asset_By_ASSET_ID_List): Observable<Asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/AssetManagement/Get_Asset_By_ASSET_ID_List?ASSET_ID_LIST=' + i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Asset_By_ASSET_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Asset(i_Asset: Asset): Observable<Asset> {
        const url = this.CmSvc.APIUrl + '/Api/AssetManagement/Edit_Asset';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Asset>(url, JSON.stringify(i_Asset), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Asset;
            })
            );
    }
    Get_Asset_By_OWNER_ID(i_Params_Get_Asset_By_OWNER_ID: Params_Get_Asset_By_OWNER_ID): Observable<Asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/AssetManagement/Get_Asset_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Asset_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Asset_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Asset_By_ASSET_ID_Adv(i_Params_Get_Asset_By_ASSET_ID: Params_Get_Asset_By_ASSET_ID): Observable<Asset> {
        const url = this.CmSvc.APIUrl + '/Api/AssetManagement/Get_Asset_By_ASSET_ID_Adv?ASSET_ID=' + i_Params_Get_Asset_By_ASSET_ID.ASSET_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Asset_By_ASSET_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Asset_Data_List(i_Params_Get_Asset_Data_List: Params_Get_Asset_Data_List): Observable<Asset_Data> {
        const url = this.CmSvc.APIUrl + '/Api/AssetManagement/Get_Asset_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Asset_Data_List>(url, JSON.stringify(i_Params_Get_Asset_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Asset(i_Params_Delete_Asset: Params_Delete_Asset): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/AssetManagement/Delete_Asset';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Asset>(url, JSON.stringify(i_Params_Delete_Asset), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Data_source_By_OWNER_ID(i_Params_Get_Data_source_By_OWNER_ID: Params_Get_Data_source_By_OWNER_ID): Observable<Data_source[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Data_source_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Data_source_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Data_source_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Generate_Area_Dwell_Time(i_Params_Generate_Area_Dwell_Time: Params_Generate_Area_Dwell_Time): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Area_Dwell_Time';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Area_Dwell_Time>(url, JSON.stringify(i_Params_Generate_Area_Dwell_Time), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Job_List(i_Params_Edit_Job_List: Params_Edit_Job_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Edit_Job_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Job_List>(url, JSON.stringify(i_Params_Edit_Job_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_District_Dwell_Time(i_Params_Generate_District_Dwell_Time: Params_Generate_District_Dwell_Time): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_District_Dwell_Time';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_District_Dwell_Time>(url, JSON.stringify(i_Params_Generate_District_Dwell_Time), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Visitor_Data(i_Params_Get_Visitor_Data: Params_Get_Visitor_Data): Observable<Visitor_Data> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Visitor_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Visitor_Data>(url, JSON.stringify(i_Params_Get_Visitor_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Kpi_List(i_Params_Edit_Kpi_List: Params_Edit_Kpi_List): Observable<Params_Edit_Kpi_List> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Edit_Kpi_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Kpi_List>(url, JSON.stringify(i_Params_Edit_Kpi_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Kpi_List;
            })
            );
    }
    Insert_Entity_Kpi_Data_List(i_Params_Insert_Entity_Kpi_Data_List: Params_Insert_Entity_Kpi_Data_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Insert_Entity_Kpi_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_Entity_Kpi_Data_List>(url, JSON.stringify(i_Params_Insert_Entity_Kpi_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Data_source(i_Params_Delete_Data_source: Params_Delete_Data_source): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Data_source';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Data_source>(url, JSON.stringify(i_Params_Delete_Data_source), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_And_Fill_Bylaw_complaints_From_Api(i_Params_Get_And_Fill_Bylaw_complaints_From_Api: Params_Get_And_Fill_Bylaw_complaints_From_Api): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_And_Fill_Bylaw_complaints_From_Api';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_And_Fill_Bylaw_complaints_From_Api>(url, JSON.stringify(i_Params_Get_And_Fill_Bylaw_complaints_From_Api), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Or_Compute_District_Hourly_Data(i_Params_Generate_Or_Compute_District_Hourly_Data: Params_Generate_Or_Compute_District_Hourly_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Or_Compute_District_Hourly_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Or_Compute_District_Hourly_Data>(url, JSON.stringify(i_Params_Generate_Or_Compute_District_Hourly_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Or_Compute_Area_Hourly_Data(i_Params_Generate_Or_Compute_Area_Hourly_Data: Params_Generate_Or_Compute_Area_Hourly_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Or_Compute_Area_Hourly_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Or_Compute_Area_Hourly_Data>(url, JSON.stringify(i_Params_Generate_Or_Compute_Area_Hourly_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Or_Compute_Site_Hourly_Data(i_Params_Generate_Or_Compute_Site_Hourly_Data: Params_Generate_Or_Compute_Site_Hourly_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Or_Compute_Site_Hourly_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Or_Compute_Site_Hourly_Data>(url, JSON.stringify(i_Params_Generate_Or_Compute_Site_Hourly_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Extract_Kpi_Data_From_CSV(i_Params_Extract_Kpi_Data_From_CSV: Params_Extract_Kpi_Data_From_CSV): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Extract_Kpi_Data_From_CSV';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Extract_Kpi_Data_From_CSV>(url, JSON.stringify(i_Params_Extract_Kpi_Data_From_CSV), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Generate_Area_Demographic_Data(i_Params_Generate_Area_Demographic_Data: Params_Generate_Area_Demographic_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Area_Demographic_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Area_Demographic_Data>(url, JSON.stringify(i_Params_Generate_Area_Demographic_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Jobs_By_Where(i_Params_Get_Jobs_By_Where: Params_Get_Jobs_By_Where): Observable<Job[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Jobs_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Jobs_By_Where>(url, JSON.stringify(i_Params_Get_Jobs_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Generate_Or_Compute_Floor_Hourly_Data(i_Params_Generate_Or_Compute_Floor_Hourly_Data: Params_Generate_Or_Compute_Floor_Hourly_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Or_Compute_Floor_Hourly_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Or_Compute_Floor_Hourly_Data>(url, JSON.stringify(i_Params_Generate_Or_Compute_Floor_Hourly_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Space_Kpi_Data_By_Where(i_Params_Delete_Space_Kpi_Data_By_Where: Params_Delete_Space_Kpi_Data_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Space_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Space_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Delete_Space_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Site_Visitor_Data_And_Dwell_Time(i_Params_Generate_Site_Visitor_Data_And_Dwell_Time: Params_Generate_Site_Visitor_Data_And_Dwell_Time): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Site_Visitor_Data_And_Dwell_Time';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Site_Visitor_Data_And_Dwell_Time>(url, JSON.stringify(i_Params_Generate_Site_Visitor_Data_And_Dwell_Time), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Niche_categories_List(i_Params_Edit_Niche_categories_List: Params_Edit_Niche_categories_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Edit_Niche_categories_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Niche_categories_List>(url, JSON.stringify(i_Params_Edit_Niche_categories_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Niche_categories(i_Params_Delete_Niche_categories: Params_Delete_Niche_categories): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Niche_categories';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Niche_categories>(url, JSON.stringify(i_Params_Delete_Niche_categories), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Site_Kpi_Data_By_Where(i_Params_Delete_Site_Kpi_Data_By_Where: Params_Delete_Site_Kpi_Data_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Site_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Site_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Delete_Site_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Insert_Space_Kpi_Data_List(i_Params_Insert_Space_Kpi_Data_List: Params_Insert_Space_Kpi_Data_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Insert_Space_Kpi_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_Space_Kpi_Data_List>(url, JSON.stringify(i_Params_Insert_Space_Kpi_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Site_Demographic_Data(i_Params_Generate_Site_Demographic_Data: Params_Generate_Site_Demographic_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Site_Demographic_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Site_Demographic_Data>(url, JSON.stringify(i_Params_Generate_Site_Demographic_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Insert_Site_Kpi_Data_List(i_Params_Insert_Site_Kpi_Data_List: Params_Insert_Site_Kpi_Data_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Insert_Site_Kpi_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_Site_Kpi_Data_List>(url, JSON.stringify(i_Params_Insert_Site_Kpi_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Data_source(i_Data_source: Data_source): Observable<Data_source> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Edit_Data_source';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Data_source>(url, JSON.stringify(i_Data_source), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Data_source;
            })
            );
    }
    Delete_Entity_Kpi_Data_By_Where(i_Params_Delete_Entity_Kpi_Data_By_Where: Params_Delete_Entity_Kpi_Data_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Entity_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Entity_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Delete_Entity_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Demographic_Data(i_Params_Get_Demographic_Data: Params_Get_Demographic_Data): Observable<Demographic_Data> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Demographic_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Demographic_Data>(url, JSON.stringify(i_Params_Get_Demographic_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Generate_District_Hourly_Indexes(i_Params_Generate_District_Hourly_Indexes: Params_Generate_District_Hourly_Indexes): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_District_Hourly_Indexes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_District_Hourly_Indexes>(url, JSON.stringify(i_Params_Generate_District_Hourly_Indexes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Niche_categories_By_Where(i_Params_Get_Niche_categories_By_Where: Params_Get_Niche_categories_By_Where): Observable<Niche_categories[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Niche_categories_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Niche_categories_By_Where>(url, JSON.stringify(i_Params_Get_Niche_categories_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Area_Kpi_Data_By_Where(i_Delete_Area_Kpi_Data_By_Where: Delete_Area_Kpi_Data_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Area_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Area_Kpi_Data_By_Where>(url, JSON.stringify(i_Delete_Area_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Entity_Hourly_Indexes(i_Params_Generate_Entity_Hourly_Indexes: Params_Generate_Entity_Hourly_Indexes): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Entity_Hourly_Indexes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Entity_Hourly_Indexes>(url, JSON.stringify(i_Params_Generate_Entity_Hourly_Indexes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Worker_Data(i_Params_Generate_Worker_Data: Params_Generate_Worker_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Worker_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Worker_Data>(url, JSON.stringify(i_Params_Generate_Worker_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_District_Kpi_Data_By_Where(i_Params_Delete_District_Kpi_Data_By_Where: Params_Delete_District_Kpi_Data_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_District_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_District_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Delete_District_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Organization_data_source_kpi(i_Organization_data_source_kpi: Organization_data_source_kpi): Observable<Organization_data_source_kpi> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Edit_Organization_data_source_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_data_source_kpi>(url, JSON.stringify(i_Organization_data_source_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization_data_source_kpi;
            })
            );
    }
    Get_Telus_Auth_Token(): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Telus_Auth_Token';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Telus_Auth_Token>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_data_source_kpi_By_OWNER_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID: Params_Get_Organization_data_source_kpi_By_OWNER_ID): Observable<Organization_data_source_kpi[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Organization_data_source_kpi_By_OWNER_ID_Adv?OWNER_ID=' + i_Params_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Floor_Kpi_Data_By_Where(i_Params_Delete_Floor_Kpi_Data_By_Where: Params_Delete_Floor_Kpi_Data_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Floor_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Floor_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Delete_Floor_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Insert_Area_Kpi_Data_List(i_Params_Insert_Area_Kpi_Data_List: Params_Insert_Area_Kpi_Data_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Insert_Area_Kpi_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_Area_Kpi_Data_List>(url, JSON.stringify(i_Params_Insert_Area_Kpi_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Space_Hourly_Indexes(i_Params_Generate_Space_Hourly_Indexes: Params_Generate_Space_Hourly_Indexes): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Space_Hourly_Indexes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Space_Hourly_Indexes>(url, JSON.stringify(i_Params_Generate_Space_Hourly_Indexes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List: Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List>(url, JSON.stringify(i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Business_Count_And_Vacant_Business_Count(i_Params_Generate_Business_Count_And_Vacant_Business_Count: Params_Generate_Business_Count_And_Vacant_Business_Count): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Business_Count_And_Vacant_Business_Count';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Business_Count_And_Vacant_Business_Count>(url, JSON.stringify(i_Params_Generate_Business_Count_And_Vacant_Business_Count), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Insert_District_Kpi_Data_List(i_Params_Insert_District_Kpi_Data_List: Params_Insert_District_Kpi_Data_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Insert_District_Kpi_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_District_Kpi_Data_List>(url, JSON.stringify(i_Params_Insert_District_Kpi_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Organization_data_source_kpi(i_Params_Delete_Organization_data_source_kpi: Params_Delete_Organization_data_source_kpi): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Organization_data_source_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_data_source_kpi>(url, JSON.stringify(i_Params_Delete_Organization_data_source_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Generate_Site_Hourly_Indexes(i_Params_Generate_Site_Hourly_Indexes: Params_Generate_Site_Hourly_Indexes): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Site_Hourly_Indexes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Site_Hourly_Indexes>(url, JSON.stringify(i_Params_Generate_Site_Hourly_Indexes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Visitor_Activity_Data(i_Params_Get_Visitor_Activity_Data: Params_Get_Visitor_Activity_Data): Observable<Visitor_Activity> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Visitor_Activity_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Visitor_Activity_Data>(url, JSON.stringify(i_Params_Get_Visitor_Activity_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_And_Fill_Public_events_From_Api(i_Params_Get_And_Fill_Public_events_From_Api: Params_Get_And_Fill_Public_events_From_Api): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_And_Fill_Public_events_From_Api';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_And_Fill_Public_events_From_Api>(url, JSON.stringify(i_Params_Get_And_Fill_Public_events_From_Api), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Floor_Hourly_Indexes(i_Params_Generate_Floor_Hourly_Indexes: Params_Generate_Floor_Hourly_Indexes): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Floor_Hourly_Indexes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Floor_Hourly_Indexes>(url, JSON.stringify(i_Params_Generate_Floor_Hourly_Indexes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Area_Hourly_Indexes(i_Params_Generate_Area_Hourly_Indexes: Params_Generate_Area_Hourly_Indexes): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Area_Hourly_Indexes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Area_Hourly_Indexes>(url, JSON.stringify(i_Params_Generate_Area_Hourly_Indexes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Or_Compute_Entity_Hourly_Data(i_Params_Generate_Or_Compute_Entity_Hourly_Data: Params_Generate_Or_Compute_Entity_Hourly_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Or_Compute_Entity_Hourly_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Or_Compute_Entity_Hourly_Data>(url, JSON.stringify(i_Params_Generate_Or_Compute_Entity_Hourly_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Job(i_Params_Delete_Job: Params_Delete_Job): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Delete_Job';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Job>(url, JSON.stringify(i_Params_Delete_Job), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_And_Fill_Businesses_From_Api(): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_And_Fill_Businesses_From_Api';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_And_Fill_Businesses_From_Api>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_District_Demographic_Data(i_Params_Generate_District_Demographic_Data: Params_Generate_District_Demographic_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_District_Demographic_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_District_Demographic_Data>(url, JSON.stringify(i_Params_Generate_District_Demographic_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Insert_Floor_Kpi_Data_List(i_Params_Insert_Floor_Kpi_Data_List: Params_Insert_Floor_Kpi_Data_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Insert_Floor_Kpi_Data_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_Floor_Kpi_Data_List>(url, JSON.stringify(i_Params_Insert_Floor_Kpi_Data_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Generate_Visitor_Activity_Data(i_Params_Generate_Visitor_Activity_Data: Params_Generate_Visitor_Activity_Data): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Generate_Visitor_Activity_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Visitor_Activity_Data>(url, JSON.stringify(i_Params_Generate_Visitor_Activity_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Floor_By_ENTITY_ID_List(i_Params_Get_Floor_By_ENTITY_ID_List: Params_Get_Floor_By_ENTITY_ID_List): Observable<Floor[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIExtractionEngine/Get_Floor_By_ENTITY_ID_List?ENTITY_ID_LIST=' + i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Floor_By_ENTITY_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Entity_share_data(i_Params_Edit_Entity_share_data: Params_Edit_Entity_share_data): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Edit_Entity_share_data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_share_data>(url, JSON.stringify(i_Params_Edit_Entity_share_data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Share_file_By_USER_ID(i_Params_Get_Share_file_By_USER_ID: Params_Get_Share_file_By_USER_ID): Observable<Share_file[]> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Get_Share_file_By_USER_ID?USER_ID=' + i_Params_Get_Share_file_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Share_file_By_USER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Share_file_By_SHARE_FILE_ID(i_Params_Get_Share_file_By_SHARE_FILE_ID: Params_Get_Share_file_By_SHARE_FILE_ID): Observable<Share_file> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Get_Share_file_By_SHARE_FILE_ID?SHARE_FILE_ID=' + i_Params_Get_Share_file_By_SHARE_FILE_ID.SHARE_FILE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Share_file_By_SHARE_FILE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_share_view_data(i_Params_Get_Entity_share_view_data: Params_Get_Entity_share_view_data): Observable<Entity_share_view_data> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Get_Entity_share_view_data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_share_view_data>(url, JSON.stringify(i_Params_Get_Entity_share_view_data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Send_Share_Link_By_Email(i_Params_Send_Share_Link_By_Email: Params_Send_Share_Link_By_Email): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Send_Share_Link_By_Email';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Send_Share_Link_By_Email>(url, JSON.stringify(i_Params_Send_Share_Link_By_Email), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Share_file(i_Params_Delete_Share_file: Params_Delete_Share_file): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Delete_Share_file';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Share_file>(url, JSON.stringify(i_Params_Delete_Share_file), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Share_file(i_Share_file: Share_file): Observable<Share_file> {
        const url = this.CmSvc.APIUrl + '/Api/ShareView/Edit_Share_file';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Share_file>(url, JSON.stringify(i_Share_file), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Share_file;
            })
            );
    }
    Edit_Space(i_Space: Space): Observable<Space> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Edit_Space';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Space>(url, JSON.stringify(i_Space), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Space;
            })
            );
    }
    Get_Space_asset_By_SPACE_ID_List_Adv(i_Params_Get_Space_asset_By_SPACE_ID_List: Params_Get_Space_asset_By_SPACE_ID_List): Observable<Space_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID_List_Adv?SPACE_ID_LIST=' + i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_asset_By_SPACE_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Space_By_OWNER_ID(i_Params_Get_Space_By_OWNER_ID: Params_Get_Space_By_OWNER_ID): Observable<Space[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Space_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Space_asset(i_Space_asset: Space_asset): Observable<Space_asset> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Edit_Space_asset';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Space_asset>(url, JSON.stringify(i_Space_asset), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Space_asset;
            })
            );
    }
    Edit_Space_List(i_Params_Edit_Space_List: Params_Edit_Space_List): Observable<Params_Edit_Space_List> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Edit_Space_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Space_List>(url, JSON.stringify(i_Params_Edit_Space_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Space_List;
            })
            );
    }
    Get_Space_asset_By_SPACE_ID_Adv(i_Params_Get_Space_asset_By_SPACE_ID: Params_Get_Space_asset_By_SPACE_ID): Observable<Space_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID_Adv?SPACE_ID=' + i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_asset_By_SPACE_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Space_By_FLOOR_ID(i_Params_Get_Space_By_FLOOR_ID: Params_Get_Space_By_FLOOR_ID): Observable<Space[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_By_FLOOR_ID?FLOOR_ID=' + i_Params_Get_Space_By_FLOOR_ID.FLOOR_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_By_FLOOR_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Space_asset_By_SPACE_ID_List(i_Params_Get_Space_asset_By_SPACE_ID_List: Params_Get_Space_asset_By_SPACE_ID_List): Observable<Space_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID_List?SPACE_ID_LIST=' + i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_asset_By_SPACE_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List: Params_Get_Space_asset_By_SPACE_ASSET_ID_List): Observable<Space_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_asset_By_SPACE_ASSET_ID_List_Adv?SPACE_ASSET_ID_LIST=' + i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Space_asset_List(i_Params_Edit_Space_asset_List: Params_Edit_Space_asset_List): Observable<Params_Edit_Space_asset_List> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Edit_Space_asset_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Space_asset_List>(url, JSON.stringify(i_Params_Edit_Space_asset_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Space_asset_List;
            })
            );
    }
    Get_Space_asset_By_SPACE_ID(i_Params_Get_Space_asset_By_SPACE_ID: Params_Get_Space_asset_By_SPACE_ID): Observable<Space_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Space_asset_By_SPACE_ID?SPACE_ID=' + i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_asset_By_SPACE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Space_asset_By_SPACE_ID(i_Params_Delete_Space_asset_By_SPACE_ID: Params_Delete_Space_asset_By_SPACE_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Delete_Space_asset_By_SPACE_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Space_asset_By_SPACE_ID>(url, JSON.stringify(i_Params_Delete_Space_asset_By_SPACE_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Video_ai_asset_By_SPACE_ASSET_ID_List(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List: Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List): Observable<Video_ai_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/SpaceManagement/Get_Video_ai_asset_By_SPACE_ASSET_ID_List?SPACE_ASSET_ID_LIST=' + i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Report_Details(i_Params_Get_Report_Details: Params_Get_Report_Details): Observable<Report_Details> {
        const url = this.CmSvc.APIUrl + '/Api/Reporting/Get_Report_Details';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Report_Details>(url, JSON.stringify(i_Params_Get_Report_Details), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Send_Report_Email(i_Params_Send_Report_Email: Params_Send_Report_Email): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/Reporting/Send_Report_Email';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Send_Report_Email>(url, JSON.stringify(i_Params_Send_Report_Email), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_District_By_DISTRICT_ID_List(i_Params_Get_District_By_DISTRICT_ID_List: Params_Get_District_By_DISTRICT_ID_List): Observable<District[]> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Get_District_By_DISTRICT_ID_List?DISTRICT_ID_LIST=' + i_Params_Get_District_By_DISTRICT_ID_List.DISTRICT_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_District_By_DISTRICT_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_District_view(i_District_view: District_view): Observable<District_view> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Edit_District_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_view>(url, JSON.stringify(i_District_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.District_view;
            })
            );
    }
    Get_District_view_By_DISTRICT_ID(i_Params_Get_District_view_By_DISTRICT_ID: Params_Get_District_view_By_DISTRICT_ID): Observable<District_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Get_District_view_By_DISTRICT_ID?DISTRICT_ID=' + i_Params_Get_District_view_By_DISTRICT_ID.DISTRICT_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_District_view_By_DISTRICT_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_District_By_OWNER_ID(i_Params_Get_District_By_OWNER_ID: Params_Get_District_By_OWNER_ID): Observable<District[]> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Get_District_By_OWNER_ID?OWNER_ID=' + i_Params_Get_District_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_District_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_District_geojson_By_DISTRICT_ID_List(i_Params_Get_District_geojson_By_DISTRICT_ID_List: Params_Get_District_geojson_By_DISTRICT_ID_List): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Get_District_geojson_By_DISTRICT_ID_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_District_geojson_By_DISTRICT_ID_List>(url, JSON.stringify(i_Params_Get_District_geojson_By_DISTRICT_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_District_view(i_Params_Delete_District_view: Params_Delete_District_view): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Delete_District_view/' + i_Params_Delete_District_view.DISTRICT_VIEW_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_District_view>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_District(i_District: District): Observable<District> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Edit_District';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District>(url, JSON.stringify(i_District), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.District;
            })
            );
    }
    Edit_District_view_List(i_Params_Edit_District_view_List: Params_Edit_District_view_List): Observable<Params_Edit_District_view_List> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Edit_District_view_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_view_List>(url, JSON.stringify(i_Params_Edit_District_view_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_District_view_List;
            })
            );
    }
    Delete_District_view_By_DISTRICT_ID(i_Params_Delete_District_view_By_DISTRICT_ID: Params_Delete_District_view_By_DISTRICT_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Delete_District_view_By_DISTRICT_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_District_view_By_DISTRICT_ID>(url, JSON.stringify(i_Params_Delete_District_view_By_DISTRICT_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_District_view_By_DISTRICT_ID_List(i_Params_Get_District_view_By_DISTRICT_ID_List: Params_Get_District_view_By_DISTRICT_ID_List): Observable<District_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/DistrictManagement/Get_District_view_By_DISTRICT_ID_List?DISTRICT_ID_LIST=' + i_Params_Get_District_view_By_DISTRICT_ID_List.DISTRICT_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_District_view_By_DISTRICT_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Wifi_signals(i_Params_Get_Wifi_signals: Params_Get_Wifi_signals): Observable<Wifi_signal[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Wifi_signals';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Wifi_signals>(url, JSON.stringify(i_Params_Get_Wifi_signals), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_District_Kpi_Dialog_Data(i_Params_Get_District_Kpi_Dialog_Data: Params_Get_District_Kpi_Dialog_Data): Observable<District_Kpi_Dialog_Data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_District_Kpi_Dialog_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_District_Kpi_Dialog_Data>(url, JSON.stringify(i_Params_Get_District_Kpi_Dialog_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Area_Kpi_Data_Aggregate_Sum(i_Params_Get_Area_Kpi_Data_Aggregate_Sum: Params_Get_Area_Kpi_Data_Aggregate_Sum): Observable<Area_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Area_Kpi_Data_Aggregate_Sum';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Area_Kpi_Data_Aggregate_Sum>(url, JSON.stringify(i_Params_Get_Area_Kpi_Data_Aggregate_Sum), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_Kpi_Data_By_Where(i_Params_Get_Entity_Kpi_Data_By_Where: Params_Get_Entity_Kpi_Data_By_Where): Observable<Entity_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Entity_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Get_Entity_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Area_Kpi_Data_Hourly(i_Params_Compute_Area_Kpi_Data_Hourly: Params_Compute_Area_Kpi_Data_Hourly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Area_Kpi_Data_Hourly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Area_Kpi_Data_Hourly>(url, JSON.stringify(i_Params_Compute_Area_Kpi_Data_Hourly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Site_Kpi_Dialog_Data(i_Params_Get_Site_Kpi_Dialog_Data: Params_Get_Site_Kpi_Dialog_Data): Observable<Site_Kpi_Dialog_Data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Site_Kpi_Dialog_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Site_Kpi_Dialog_Data>(url, JSON.stringify(i_Params_Get_Site_Kpi_Dialog_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_Kpi_Data_By_Where(i_Params_Get_Site_Kpi_Data_By_Where: Params_Get_Site_Kpi_Data_By_Where): Observable<Site_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Site_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Site_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Get_Site_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Alert_List(i_Params_Edit_Alert_List: Params_Edit_Alert_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Edit_Alert_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Alert_List>(url, JSON.stringify(i_Params_Edit_Alert_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List): Observable<Organization_data_source_kpi[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv?ORGANIZATION_DATA_SOURCE_KPI_ID_LIST=' + i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_District_Kpi_Data_Monthly(i_Params_Compute_District_Kpi_Data_Monthly: Params_Compute_District_Kpi_Data_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_District_Kpi_Data_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_District_Kpi_Data_Monthly>(url, JSON.stringify(i_Params_Compute_District_Kpi_Data_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Bylaw_Complaint_List(i_Params_Get_Bylaw_Complaint_List: Params_Get_Bylaw_Complaint_List): Observable<Bylaw_Complaint[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Bylaw_Complaint_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Bylaw_Complaint_List>(url, JSON.stringify(i_Params_Get_Bylaw_Complaint_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Kpi(i_Params_Delete_Kpi: Params_Delete_Kpi): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Delete_Kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Kpi>(url, JSON.stringify(i_Params_Delete_Kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Delete_Wifi_signal(i_Params_Delete_Wifi_signal: Params_Delete_Wifi_signal): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Delete_Wifi_signal';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Wifi_signal>(url, JSON.stringify(i_Params_Delete_Wifi_signal), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Floor_Kpi_Data_Monthly(i_Params_Compute_Floor_Kpi_Data_Monthly: Params_Compute_Floor_Kpi_Data_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Floor_Kpi_Data_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Floor_Kpi_Data_Monthly>(url, JSON.stringify(i_Params_Compute_Floor_Kpi_Data_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Wifi_signal_alert_List(i_Params_Edit_Wifi_signal_alert_List: Params_Edit_Wifi_signal_alert_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Edit_Wifi_signal_alert_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Wifi_signal_alert_List>(url, JSON.stringify(i_Params_Edit_Wifi_signal_alert_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Alert(i_Params_Delete_Alert: Params_Delete_Alert): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Delete_Alert';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Alert>(url, JSON.stringify(i_Params_Delete_Alert), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_District_Kpi_Data_Weekly(i_Params_Compute_District_Kpi_Data_Weekly: Params_Compute_District_Kpi_Data_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_District_Kpi_Data_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_District_Kpi_Data_Weekly>(url, JSON.stringify(i_Params_Compute_District_Kpi_Data_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_District_Kpi_Data_Aggregate_Sum(i_Params_Get_District_Kpi_Data_Aggregate_Sum: Params_Get_District_Kpi_Data_Aggregate_Sum): Observable<District_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_District_Kpi_Data_Aggregate_Sum';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_District_Kpi_Data_Aggregate_Sum>(url, JSON.stringify(i_Params_Get_District_Kpi_Data_Aggregate_Sum), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Space_Kpi_Data_Monthly(i_Params_Compute_Space_Kpi_Data_Monthly: Params_Compute_Space_Kpi_Data_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Space_Kpi_Data_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Space_Kpi_Data_Monthly>(url, JSON.stringify(i_Params_Compute_Space_Kpi_Data_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Space_Kpi_Data_Daily(i_Params_Compute_Space_Kpi_Data_Daily: Params_Compute_Space_Kpi_Data_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Space_Kpi_Data_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Space_Kpi_Data_Daily>(url, JSON.stringify(i_Params_Compute_Space_Kpi_Data_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Update_Kpi_Data_Record(i_Params_Update_Kpi_Data_Record: Params_Update_Kpi_Data_Record): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Update_Kpi_Data_Record';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Update_Kpi_Data_Record>(url, JSON.stringify(i_Params_Update_Kpi_Data_Record), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Area_Kpi_Data_Daily(i_Params_Compute_Area_Kpi_Data_Daily: Params_Compute_Area_Kpi_Data_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Area_Kpi_Data_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Area_Kpi_Data_Daily>(url, JSON.stringify(i_Params_Compute_Area_Kpi_Data_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Latest_Wifi_signal_alerts(i_Params_Get_Latest_Wifi_signal_alerts: Params_Get_Latest_Wifi_signal_alerts): Observable<Wifi_signal_alert[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Latest_Wifi_signal_alerts';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Latest_Wifi_signal_alerts>(url, JSON.stringify(i_Params_Get_Latest_Wifi_signal_alerts), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Floor_Kpi_Data_Aggregate_Sum(i_Params_Get_Floor_Kpi_Data_Aggregate_Sum: Params_Get_Floor_Kpi_Data_Aggregate_Sum): Observable<Floor_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Floor_Kpi_Data_Aggregate_Sum';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Floor_Kpi_Data_Aggregate_Sum>(url, JSON.stringify(i_Params_Get_Floor_Kpi_Data_Aggregate_Sum), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Entity_Kpi_Data_Weekly(i_Params_Compute_Entity_Kpi_Data_Weekly: Params_Compute_Entity_Kpi_Data_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Entity_Kpi_Data_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Entity_Kpi_Data_Weekly>(url, JSON.stringify(i_Params_Compute_Entity_Kpi_Data_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID): Observable<Organization_data_source_kpi> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv?ORGANIZATION_DATA_SOURCE_KPI_ID=' + i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Area_Kpi_Data_Weekly(i_Params_Compute_Area_Kpi_Data_Weekly: Params_Compute_Area_Kpi_Data_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Area_Kpi_Data_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Area_Kpi_Data_Weekly>(url, JSON.stringify(i_Params_Compute_Area_Kpi_Data_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Business_Trendline(i_Params_Get_Business_Trendline: Params_Get_Business_Trendline): Observable<Kpi_Value_By_Date[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Business_Trendline';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Business_Trendline>(url, JSON.stringify(i_Params_Get_Business_Trendline), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID): Observable<Organization_data_source_kpi[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv?ORGANIZATION_ID=' + i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Wifi_signal_List(i_Params_Edit_Wifi_signal_List: Params_Edit_Wifi_signal_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Edit_Wifi_signal_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Wifi_signal_List>(url, JSON.stringify(i_Params_Edit_Wifi_signal_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Entity_Kpi_Data_Daily(i_Params_Compute_Entity_Kpi_Data_Daily: Params_Compute_Entity_Kpi_Data_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Entity_Kpi_Data_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Entity_Kpi_Data_Daily>(url, JSON.stringify(i_Params_Compute_Entity_Kpi_Data_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Floor_Kpi_Dialog_Data(i_Params_Get_Floor_Kpi_Dialog_Data: Params_Get_Floor_Kpi_Dialog_Data): Observable<Floor_Kpi_Dialog_Data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Floor_Kpi_Dialog_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Floor_Kpi_Dialog_Data>(url, JSON.stringify(i_Params_Get_Floor_Kpi_Dialog_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Latest_GeoData_By_KPI(i_Params_Get_Latest_GeoData_By_KPI: Params_Get_Latest_GeoData_By_KPI): Observable<GeoData> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Latest_GeoData_By_KPI';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Latest_GeoData_By_KPI>(url, JSON.stringify(i_Params_Get_Latest_GeoData_By_KPI), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Public_Event_List(i_Params_Get_Public_Event_List: Params_Get_Public_Event_List): Observable<Public_Event[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Public_Event_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Public_Event_List>(url, JSON.stringify(i_Params_Get_Public_Event_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_And_Save_Wifi_Signal_From_Api(): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_And_Save_Wifi_Signal_From_Api';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_And_Save_Wifi_Signal_From_Api>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Alerts_By_Where(i_Params_Get_Alerts_By_Where: Params_Get_Alerts_By_Where): Observable<Alert[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Alerts_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Alerts_By_Where>(url, JSON.stringify(i_Params_Get_Alerts_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Site_Kpi_Data_Hourly(i_Params_Compute_Site_Kpi_Data_Hourly: Params_Compute_Site_Kpi_Data_Hourly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Site_Kpi_Data_Hourly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Site_Kpi_Data_Hourly>(url, JSON.stringify(i_Params_Compute_Site_Kpi_Data_Hourly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Entity_Kpi_Data_Hourly(i_Params_Compute_Entity_Kpi_Data_Hourly: Params_Compute_Entity_Kpi_Data_Hourly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Entity_Kpi_Data_Hourly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Entity_Kpi_Data_Hourly>(url, JSON.stringify(i_Params_Compute_Entity_Kpi_Data_Hourly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Entity_Kpi_Data_Monthly(i_Params_Compute_Entity_Kpi_Data_Monthly: Params_Compute_Entity_Kpi_Data_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Entity_Kpi_Data_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Entity_Kpi_Data_Monthly>(url, JSON.stringify(i_Params_Compute_Entity_Kpi_Data_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_User_Data_Access(i_Params_Edit_User_Data_Access: Params_Edit_User_Data_Access): Observable<Params_Edit_User_Data_Access> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Edit_User_Data_Access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_Data_Access>(url, JSON.stringify(i_Params_Edit_User_Data_Access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_Data_Access(i_Params_Get_Organization_Data_Access: Params_Get_Organization_Data_Access): Observable<Organization_Data_Access> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Organization_Data_Access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Organization_Data_Access>(url, JSON.stringify(i_Params_Get_Organization_Data_Access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_Data_Access(i_Params_Get_User_Data_Access: Params_Get_User_Data_Access): Observable<User_Data_Access> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_User_Data_Access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_User_Data_Access>(url, JSON.stringify(i_Params_Get_User_Data_Access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Wifi_signal_alert(i_Params_Delete_Wifi_signal_alert: Params_Delete_Wifi_signal_alert): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Delete_Wifi_signal_alert';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Wifi_signal_alert>(url, JSON.stringify(i_Params_Delete_Wifi_signal_alert), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Area_Kpi_Dialog_Data(i_Params_Get_Area_Kpi_Dialog_Data: Params_Get_Area_Kpi_Dialog_Data): Observable<Area_Kpi_Dialog_Data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Area_Kpi_Dialog_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Area_Kpi_Dialog_Data>(url, JSON.stringify(i_Params_Get_Area_Kpi_Dialog_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Alerts_Count_For_Levels(i_Params_Get_Alerts_Count_For_Levels: Params_Get_Alerts_Count_For_Levels): Observable<number> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Alerts_Count_For_Levels';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Alerts_Count_For_Levels>(url, JSON.stringify(i_Params_Get_Alerts_Count_For_Levels), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Space_Kpi_Data_By_Where(i_Params_Get_Space_Kpi_Data_By_Where: Params_Get_Space_Kpi_Data_By_Where): Observable<Space_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Space_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Space_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Get_Space_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_Kpi_Data_Aggregate_Sum(i_Params_Get_Site_Kpi_Data_Aggregate_Sum: Params_Get_Site_Kpi_Data_Aggregate_Sum): Observable<Site_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Site_Kpi_Data_Aggregate_Sum';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Site_Kpi_Data_Aggregate_Sum>(url, JSON.stringify(i_Params_Get_Site_Kpi_Data_Aggregate_Sum), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Latest_Visitor_Count_By_Where(i_Params_Get_Latest_Visitor_Count_By_Where: Params_Get_Latest_Visitor_Count_By_Where): Observable<Visitor_Count_By_Level[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Latest_Visitor_Count_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Latest_Visitor_Count_By_Where>(url, JSON.stringify(i_Params_Get_Latest_Visitor_Count_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_Kpi_Data_Aggregate_Sum(i_Params_Get_Entity_Kpi_Data_Aggregate_Sum: Params_Get_Entity_Kpi_Data_Aggregate_Sum): Observable<Entity_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Entity_Kpi_Data_Aggregate_Sum';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_Kpi_Data_Aggregate_Sum>(url, JSON.stringify(i_Params_Get_Entity_Kpi_Data_Aggregate_Sum), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Floor_Kpi_Data_Hourly(i_Params_Compute_Floor_Kpi_Data_Hourly: Params_Compute_Floor_Kpi_Data_Hourly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Floor_Kpi_Data_Hourly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Floor_Kpi_Data_Hourly>(url, JSON.stringify(i_Params_Compute_Floor_Kpi_Data_Hourly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Wifi_signal_alerts(i_Params_Get_Wifi_signal_alerts: Params_Get_Wifi_signal_alerts): Observable<Wifi_signal_alert[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Wifi_signal_alerts';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Wifi_signal_alerts>(url, JSON.stringify(i_Params_Get_Wifi_signal_alerts), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_District_Kpi_Data_By_Where(i_Params_Get_District_Kpi_Data_By_Where: Params_Get_District_Kpi_Data_By_Where): Observable<District_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_District_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_District_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Get_District_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Kpi_By_OWNER_ID_Adv(i_Params_Get_Kpi_By_OWNER_ID: Params_Get_Kpi_By_OWNER_ID): Observable<Kpi[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Kpi_By_OWNER_ID_Adv?OWNER_ID=' + i_Params_Get_Kpi_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Kpi_By_OWNER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Floor_Kpi_Data_By_Where(i_Params_Get_Floor_Kpi_Data_By_Where: Params_Get_Floor_Kpi_Data_By_Where): Observable<Floor_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Floor_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Floor_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Get_Floor_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Floor_Kpi_Data_Weekly(i_Params_Compute_Floor_Kpi_Data_Weekly: Params_Compute_Floor_Kpi_Data_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Floor_Kpi_Data_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Floor_Kpi_Data_Weekly>(url, JSON.stringify(i_Params_Compute_Floor_Kpi_Data_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Update_Wifi_signal(i_Params_Update_Wifi_signal: Params_Update_Wifi_signal): Observable<Wifi_signal_data> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Update_Wifi_signal';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Update_Wifi_signal>(url, JSON.stringify(i_Params_Update_Wifi_signal), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_data_source_kpi_By_ORGANIZATION_ID(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID): Observable<Organization_data_source_kpi[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Organization_data_source_kpi_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Visitor_Origins(i_Params_Get_Visitor_Origins: Params_Get_Visitor_Origins): Observable<Visitor_Origins> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Visitor_Origins';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Visitor_Origins>(url, JSON.stringify(i_Params_Get_Visitor_Origins), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Site_Kpi_Data_Daily(i_Params_Compute_Site_Kpi_Data_Daily: Params_Compute_Site_Kpi_Data_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Site_Kpi_Data_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Site_Kpi_Data_Daily>(url, JSON.stringify(i_Params_Compute_Site_Kpi_Data_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_District_Kpi_Data_Daily(i_Params_Compute_District_Kpi_Data_Daily: Params_Compute_District_Kpi_Data_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_District_Kpi_Data_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_District_Kpi_Data_Daily>(url, JSON.stringify(i_Params_Compute_District_Kpi_Data_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Wifi_Signal_Space_Kpi_Data_Hourly(i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly: Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Wifi_Signal_Space_Kpi_Data_Hourly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly>(url, JSON.stringify(i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Latest_Wifi_signals(i_Params_Get_Latest_Wifi_signals: Params_Get_Latest_Wifi_signals): Observable<Wifi_signal[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Latest_Wifi_signals';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Latest_Wifi_signals>(url, JSON.stringify(i_Params_Get_Latest_Wifi_signals), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Alerts_By_Where_Count(i_Params_Get_Alerts_By_Where_Count: Params_Get_Alerts_By_Where_Count): Observable<number> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Alerts_By_Where_Count';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Alerts_By_Where_Count>(url, JSON.stringify(i_Params_Get_Alerts_By_Where_Count), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_Incidents(i_Params_Get_Entity_Incidents: Params_Get_Entity_Incidents): Observable<Entity_Incidents> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Entity_Incidents';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_Incidents>(url, JSON.stringify(i_Params_Get_Entity_Incidents), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Bylaw_Complaints_Trendline(i_Params_Get_Bylaw_Complaints_Trendline: Params_Get_Bylaw_Complaints_Trendline): Observable<Kpi_Value_By_Date[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Bylaw_Complaints_Trendline';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Bylaw_Complaints_Trendline>(url, JSON.stringify(i_Params_Get_Bylaw_Complaints_Trendline), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Alerts_For_Levels(i_Params_Get_Alerts_For_Levels: Params_Get_Alerts_For_Levels): Observable<Alert[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Alerts_For_Levels';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Alerts_For_Levels>(url, JSON.stringify(i_Params_Get_Alerts_For_Levels), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Space_Kpi_Data_Weekly(i_Params_Compute_Space_Kpi_Data_Weekly: Params_Compute_Space_Kpi_Data_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Space_Kpi_Data_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Space_Kpi_Data_Weekly>(url, JSON.stringify(i_Params_Compute_Space_Kpi_Data_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Area_Kpi_Data_By_Where(i_Params_Get_Area_Kpi_Data_By_Where: Params_Get_Area_Kpi_Data_By_Where): Observable<Area_kpi_data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Area_Kpi_Data_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Area_Kpi_Data_By_Where>(url, JSON.stringify(i_Params_Get_Area_Kpi_Data_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Site_Kpi_Data_Monthly(i_Params_Compute_Site_Kpi_Data_Monthly: Params_Compute_Site_Kpi_Data_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Site_Kpi_Data_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Site_Kpi_Data_Monthly>(url, JSON.stringify(i_Params_Compute_Site_Kpi_Data_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_District_Kpi_Data_Hourly(i_Params_Compute_District_Kpi_Data_Hourly: Params_Compute_District_Kpi_Data_Hourly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_District_Kpi_Data_Hourly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_District_Kpi_Data_Hourly>(url, JSON.stringify(i_Params_Compute_District_Kpi_Data_Hourly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Intersection_Kpi_Dialog_Data(i_Params_Get_Intersection_Kpi_Dialog_Data: Params_Get_Intersection_Kpi_Dialog_Data): Observable<Entity_Kpi_Dialog_Data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Intersection_Kpi_Dialog_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Intersection_Kpi_Dialog_Data>(url, JSON.stringify(i_Params_Get_Intersection_Kpi_Dialog_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Floor_Kpi_Data_Daily(i_Params_Compute_Floor_Kpi_Data_Daily: Params_Compute_Floor_Kpi_Data_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Floor_Kpi_Data_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Floor_Kpi_Data_Daily>(url, JSON.stringify(i_Params_Compute_Floor_Kpi_Data_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Strongest_Wifi_signal(i_Params_Get_Strongest_Wifi_signal: Params_Get_Strongest_Wifi_signal): Observable<Best_And_Worst_Object> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Strongest_Wifi_signal';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Strongest_Wifi_signal>(url, JSON.stringify(i_Params_Get_Strongest_Wifi_signal), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Area_Kpi_Data_Monthly(i_Params_Compute_Area_Kpi_Data_Monthly: Params_Compute_Area_Kpi_Data_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Area_Kpi_Data_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Area_Kpi_Data_Monthly>(url, JSON.stringify(i_Params_Compute_Area_Kpi_Data_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Business_List(i_Params_Get_Business_List: Params_Get_Business_List): Observable<Business[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Business_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Business_List>(url, JSON.stringify(i_Params_Get_Business_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_Data_Access(i_Params_Edit_Organization_Data_Access: Params_Edit_Organization_Data_Access): Observable<Params_Edit_Organization_Data_Access> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Edit_Organization_Data_Access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_Data_Access>(url, JSON.stringify(i_Params_Edit_Organization_Data_Access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Kpi(i_Kpi: Kpi): Observable<Kpi> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Edit_Kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Kpi>(url, JSON.stringify(i_Kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Kpi;
            })
            );
    }
    Get_Entity_Kpi_Dialog_Data(i_Params_Get_Entity_Kpi_Dialog_Data: Params_Get_Entity_Kpi_Dialog_Data): Observable<Entity_Kpi_Dialog_Data[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Entity_Kpi_Dialog_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_Kpi_Dialog_Data>(url, JSON.stringify(i_Params_Get_Entity_Kpi_Dialog_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID: Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID): Observable<Business[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID>(url, JSON.stringify(i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Site_Kpi_Data_Weekly(i_Params_Compute_Site_Kpi_Data_Weekly: Params_Compute_Site_Kpi_Data_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Compute_Site_Kpi_Data_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Site_Kpi_Data_Weekly>(url, JSON.stringify(i_Params_Compute_Site_Kpi_Data_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Most_Wifi_signal_Count_Per_Space_asset(i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset: Params_Get_Most_Wifi_signal_Count_Per_Space_asset): Observable<Best_And_Worst_Object> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Most_Wifi_signal_Count_Per_Space_asset';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Most_Wifi_signal_Count_Per_Space_asset>(url, JSON.stringify(i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Public_Events_Trendline(i_Params_Get_Public_Events_Trendline: Params_Get_Public_Events_Trendline): Observable<Kpi_Value_By_Date[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_Public_Events_Trendline';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Public_Events_Trendline>(url, JSON.stringify(i_Params_Get_Public_Events_Trendline), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_By_ORGANIZATION_ID_List_Adv(i_Params_Get_User_By_ORGANIZATION_ID_List: Params_Get_User_By_ORGANIZATION_ID_List): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_User_By_ORGANIZATION_ID_List_Adv?ORGANIZATION_ID_LIST=' + i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_ORGANIZATION_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_By_ORGANIZATION_ID_List(i_Params_Get_User_By_ORGANIZATION_ID_List: Params_Get_User_By_ORGANIZATION_ID_List): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/KPIManagement/Get_User_By_ORGANIZATION_ID_List?ORGANIZATION_ID_LIST=' + i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_ORGANIZATION_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Top_level(i_Top_level: Top_level): Observable<Top_level> {
        const url = this.CmSvc.APIUrl + '/Api/TopLevelManagement/Edit_Top_level';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Top_level>(url, JSON.stringify(i_Top_level), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Top_level;
            })
            );
    }
    Get_Top_level_By_TOP_LEVEL_ID_List(i_Params_Get_Top_level_By_TOP_LEVEL_ID_List: Params_Get_Top_level_By_TOP_LEVEL_ID_List): Observable<Top_level[]> {
        const url = this.CmSvc.APIUrl + '/Api/TopLevelManagement/Get_Top_level_By_TOP_LEVEL_ID_List?TOP_LEVEL_ID_LIST=' + i_Params_Get_Top_level_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Top_level_By_TOP_LEVEL_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Top_level_By_OWNER_ID(i_Params_Get_Top_level_By_OWNER_ID: Params_Get_Top_level_By_OWNER_ID): Observable<Top_level[]> {
        const url = this.CmSvc.APIUrl + '/Api/TopLevelManagement/Get_Top_level_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Top_level_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Top_level_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Entity_view(i_Entity_view: Entity_view): Observable<Entity_view> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Edit_Entity_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_view>(url, JSON.stringify(i_Entity_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Entity_view;
            })
            );
    }
    Get_Entity_view_By_ENTITY_ID(i_Params_Get_Entity_view_By_ENTITY_ID: Params_Get_Entity_view_By_ENTITY_ID): Observable<Entity_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_view_By_ENTITY_ID?ENTITY_ID=' + i_Params_Get_Entity_view_By_ENTITY_ID.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_view_By_ENTITY_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Entity_view(i_Params_Delete_Entity_view: Params_Delete_Entity_view): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Delete_Entity_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Entity_view>(url, JSON.stringify(i_Params_Delete_Entity_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Entity_By_SITE_ID(i_Params_Get_Entity_By_SITE_ID: Params_Get_Entity_By_SITE_ID): Observable<Entity[]> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_By_SITE_ID?SITE_ID=' + i_Params_Get_Entity_By_SITE_ID.SITE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_By_SITE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_By_ENTITY_ID_Adv(i_Params_Get_Entity_By_ENTITY_ID: Params_Get_Entity_By_ENTITY_ID): Observable<Entity> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_By_ENTITY_ID_Adv?ENTITY_ID=' + i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_By_ENTITY_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_By_ENTITY_ID(i_Params_Get_Entity_By_ENTITY_ID: Params_Get_Entity_By_ENTITY_ID): Observable<Entity> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_By_ENTITY_ID?ENTITY_ID=' + i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_By_ENTITY_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID(i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID: Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID): Observable<Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID>(url, JSON.stringify(i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_By_ENTITY_ID_List(i_Params_Get_Entity_By_ENTITY_ID_List: Params_Get_Entity_By_ENTITY_ID_List): Observable<Entity[]> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_By_ENTITY_ID_List?ENTITY_ID_LIST=' + i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_By_ENTITY_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Entity_By_OWNER_ID(i_Params_Get_Entity_By_OWNER_ID: Params_Get_Entity_By_OWNER_ID): Observable<Entity[]> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Entity_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Entity(i_Entity: Entity): Observable<Entity> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Edit_Entity';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity>(url, JSON.stringify(i_Entity), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Entity;
            })
            );
    }
    Edit_Entity_view_List(i_Params_Edit_Entity_view_List: Params_Edit_Entity_view_List): Observable<Params_Edit_Entity_view_List> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Edit_Entity_view_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_view_List>(url, JSON.stringify(i_Params_Edit_Entity_view_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Entity_view_List;
            })
            );
    }
    Delete_Entity_view_By_ENTITY_ID(i_Params_Delete_Entity_view_By_ENTITY_ID: Params_Delete_Entity_view_By_ENTITY_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Delete_Entity_view_By_ENTITY_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Entity_view_By_ENTITY_ID>(url, JSON.stringify(i_Params_Delete_Entity_view_By_ENTITY_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Entity_view_By_ENTITY_ID_List(i_Params_Get_Entity_view_By_ENTITY_ID_List: Params_Get_Entity_view_By_ENTITY_ID_List): Observable<Entity_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/EntityManagement/Get_Entity_view_By_ENTITY_ID_List?ENTITY_ID_LIST=' + i_Params_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Entity_view_By_ENTITY_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Region(i_Region: Region): Observable<Region> {
        const url = this.CmSvc.APIUrl + '/Api/RegionManagement/Edit_Region';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Region>(url, JSON.stringify(i_Region), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Region;
            })
            );
    }
    Get_Region_By_OWNER_ID(i_Params_Get_Region_By_OWNER_ID: Params_Get_Region_By_OWNER_ID): Observable<Region[]> {
        const url = this.CmSvc.APIUrl + '/Api/RegionManagement/Get_Region_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Region_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Region_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Region_view(i_Region_view: Region_view): Observable<Region_view> {
        const url = this.CmSvc.APIUrl + '/Api/RegionManagement/Edit_Region_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Region_view>(url, JSON.stringify(i_Region_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Region_view;
            })
            );
    }
    Delete_Region_view(i_Params_Delete_Region_view: Params_Delete_Region_view): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/RegionManagement/Delete_Region_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Region_view>(url, JSON.stringify(i_Params_Delete_Region_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Region_view_By_REGION_ID(i_Params_Get_Region_view_By_REGION_ID: Params_Get_Region_view_By_REGION_ID): Observable<Region_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/RegionManagement/Get_Region_view_By_REGION_ID?REGION_ID=' + i_Params_Get_Region_view_By_REGION_ID.REGION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Region_view_By_REGION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Floor_By_ENTITY_ID(i_Params_Get_Floor_By_ENTITY_ID: Params_Get_Floor_By_ENTITY_ID): Observable<Floor[]> {
        const url = this.CmSvc.APIUrl + '/Api/FloorManagement/Get_Floor_By_ENTITY_ID?ENTITY_ID=' + i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Floor_By_ENTITY_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Floor_By_ENTITY_ID_With_Space_Asset(i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset: Params_Get_Floor_By_ENTITY_ID_With_Space_Asset): Observable<Floor[]> {
        const url = this.CmSvc.APIUrl + '/Api/FloorManagement/Get_Floor_By_ENTITY_ID_With_Space_Asset?ENTITY_ID=' + i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Floor_By_ENTITY_ID_With_Space_Asset>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Floor_By_OWNER_ID(i_Params_Get_Floor_By_OWNER_ID: Params_Get_Floor_By_OWNER_ID): Observable<Floor[]> {
        const url = this.CmSvc.APIUrl + '/Api/FloorManagement/Get_Floor_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Floor_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Floor_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Floor(i_Floor: Floor): Observable<Floor> {
        const url = this.CmSvc.APIUrl + '/Api/FloorManagement/Edit_Floor';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Floor>(url, JSON.stringify(i_Floor), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Floor;
            })
            );
    }
    Get_Floor_By_ENTITY_ID_Adv(i_Params_Get_Floor_By_ENTITY_ID: Params_Get_Floor_By_ENTITY_ID): Observable<Floor[]> {
        const url = this.CmSvc.APIUrl + '/Api/FloorManagement/Get_Floor_By_ENTITY_ID_Adv?ENTITY_ID=' + i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Floor_By_ENTITY_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Logs_With_Filters(i_Params_Get_Logs_With_Filters: Params_Get_Logs_With_Filters): Observable<Log_With_Count> {
        const url = this.CmSvc.APIUrl + '/Api/PlatformLogging/Get_Logs_With_Filters';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Logs_With_Filters>(url, JSON.stringify(i_Params_Get_Logs_With_Filters), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Generate_Logs_Excel(i_Params_Generate_Logs_Excel: Params_Generate_Logs_Excel): Observable<Generate_Logs_Excel_Response> {
        const url = this.CmSvc.APIUrl + '/Api/PlatformLogging/Generate_Logs_Excel';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Logs_Excel>(url, JSON.stringify(i_Params_Generate_Logs_Excel), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Latest_Dimension_index_By_Where(i_Params_Get_Latest_Dimension_index_By_Where: Params_Get_Latest_Dimension_index_By_Where): Observable<Dimension_index_By_Level[]> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Get_Latest_Dimension_index_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Latest_Dimension_index_By_Where>(url, JSON.stringify(i_Params_Get_Latest_Dimension_index_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Dimension_By_DIMENSION_ORDER_List(i_Params_Get_Dimension_By_DIMENSION_ORDER_List: Params_Get_Dimension_By_DIMENSION_ORDER_List): Observable<Dimension[]> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Get_Dimension_By_DIMENSION_ORDER_List?DIMENSION_ORDER_LIST=' + i_Params_Get_Dimension_By_DIMENSION_ORDER_List.DIMENSION_ORDER_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Dimension_By_DIMENSION_ORDER_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Dimension_List(i_Params_Edit_Dimension_List: Params_Edit_Dimension_List): Observable<Params_Edit_Dimension_List> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Edit_Dimension_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Dimension_List>(url, JSON.stringify(i_Params_Edit_Dimension_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Dimension_List;
            })
            );
    }
    Get_Dimension_By_DIMENSION_ID_List(i_Params_Get_Dimension_By_DIMENSION_ID_List: Params_Get_Dimension_By_DIMENSION_ID_List): Observable<Dimension[]> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Get_Dimension_By_DIMENSION_ID_List?DIMENSION_ID_LIST=' + i_Params_Get_Dimension_By_DIMENSION_ID_List.DIMENSION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Dimension_By_DIMENSION_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Dimension_By_DIMENSION_ID(i_Params_Get_Dimension_By_DIMENSION_ID: Params_Get_Dimension_By_DIMENSION_ID): Observable<Dimension> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Get_Dimension_By_DIMENSION_ID?DIMENSION_ID=' + i_Params_Get_Dimension_By_DIMENSION_ID.DIMENSION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Dimension_By_DIMENSION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Compute_Dimension_Index_Monthly(i_Params_Compute_Dimension_Index_Monthly: Params_Compute_Dimension_Index_Monthly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Compute_Dimension_Index_Monthly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Dimension_Index_Monthly>(url, JSON.stringify(i_Params_Compute_Dimension_Index_Monthly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Insert_Dimension_index_List(i_Params_Insert_Dimension_index_List: Params_Insert_Dimension_index_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Insert_Dimension_index_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Insert_Dimension_index_List>(url, JSON.stringify(i_Params_Insert_Dimension_index_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Compute_Dimension_Index_Weekly(i_Params_Compute_Dimension_Index_Weekly: Params_Compute_Dimension_Index_Weekly): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Compute_Dimension_Index_Weekly';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Compute_Dimension_Index_Weekly>(url, JSON.stringify(i_Params_Compute_Dimension_Index_Weekly), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Dimension_By_OWNER_ID(i_Params_Get_Dimension_By_OWNER_ID: Params_Get_Dimension_By_OWNER_ID): Observable<Dimension[]> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Get_Dimension_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Dimension_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Dimension_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Dimension_index_By_Where(i_Params_Get_Dimension_index_By_Where: Params_Get_Dimension_index_By_Where): Observable<Dimension_index[]> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Get_Dimension_index_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Dimension_index_By_Where>(url, JSON.stringify(i_Params_Get_Dimension_index_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Generate_Dimension_Index_Daily(i_Params_Generate_Dimension_Index_Daily: Params_Generate_Dimension_Index_Daily): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Generate_Dimension_Index_Daily';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Generate_Dimension_Index_Daily>(url, JSON.stringify(i_Params_Generate_Dimension_Index_Daily), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Dimension_index_By_Where(i_Params_Delete_Dimension_index_By_Where: Params_Delete_Dimension_index_By_Where): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/DimensionManagement/Delete_Dimension_index_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Dimension_index_By_Where>(url, JSON.stringify(i_Params_Delete_Dimension_index_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Site_view(i_Site_view: Site_view): Observable<Site_view> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Edit_Site_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_view>(url, JSON.stringify(i_Site_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Site_view;
            })
            );
    }
    Get_Site_By_OWNER_ID_Adv(i_Params_Get_Site_By_OWNER_ID: Params_Get_Site_By_OWNER_ID): Observable<Site[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_By_OWNER_ID_Adv?OWNER_ID=' + i_Params_Get_Site_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_By_OWNER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Site(i_Site: Site): Observable<Site> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Edit_Site';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site>(url, JSON.stringify(i_Site), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Site;
            })
            );
    }
    Get_Site_By_SITE_ID_List_Adv(i_Params_Get_Site_By_SITE_ID_List: Params_Get_Site_By_SITE_ID_List): Observable<Site[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_By_SITE_ID_List_Adv?SITE_ID_LIST=' + i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_By_SITE_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_By_SITE_ID_List(i_Params_Get_Site_By_SITE_ID_List: Params_Get_Site_By_SITE_ID_List): Observable<Site[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_By_SITE_ID_List?SITE_ID_LIST=' + i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_By_SITE_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Ext_study_zone_By_OWNER_ID(i_Params_Get_Ext_study_zone_By_OWNER_ID: Params_Get_Ext_study_zone_By_OWNER_ID): Observable<Ext_study_zone[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Ext_study_zone_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Ext_study_zone_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Ext_study_zone_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Site_view(i_Params_Delete_Site_view: Params_Delete_Site_view): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Delete_Site_view/' + i_Params_Delete_Site_view.SITE_VIEW_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Site_view>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Site_By_SITE_ID(i_Params_Get_Site_By_SITE_ID: Params_Get_Site_By_SITE_ID): Observable<Site> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_By_SITE_ID?SITE_ID=' + i_Params_Get_Site_By_SITE_ID.SITE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_By_SITE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_By_OWNER_ID(i_Params_Get_Site_By_OWNER_ID: Params_Get_Site_By_OWNER_ID): Observable<Site[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Site_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_geojson_By_SITE_ID_List(i_Params_Get_Site_geojson_By_SITE_ID_List: Params_Get_Site_geojson_By_SITE_ID_List): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_geojson_By_SITE_ID_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Site_geojson_By_SITE_ID_List>(url, JSON.stringify(i_Params_Get_Site_geojson_By_SITE_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_view_By_SITE_ID(i_Params_Get_Site_view_By_SITE_ID: Params_Get_Site_view_By_SITE_ID): Observable<Site_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_view_By_SITE_ID?SITE_ID=' + i_Params_Get_Site_view_By_SITE_ID.SITE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_view_By_SITE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Ext_study_zone_List(i_Params_Edit_Ext_study_zone_List: Params_Edit_Ext_study_zone_List): Observable<Params_Edit_Ext_study_zone_List> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Edit_Ext_study_zone_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Ext_study_zone_List>(url, JSON.stringify(i_Params_Edit_Ext_study_zone_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Ext_study_zone_List;
            })
            );
    }
    Edit_Site_view_List(i_Params_Edit_Site_view_List: Params_Edit_Site_view_List): Observable<Params_Edit_Site_view_List> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Edit_Site_view_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_view_List>(url, JSON.stringify(i_Params_Edit_Site_view_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Site_view_List;
            })
            );
    }
    Delete_Site_view_By_SITE_ID(i_Params_Delete_Site_view_By_SITE_ID: Params_Delete_Site_view_By_SITE_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Delete_Site_view_By_SITE_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Site_view_By_SITE_ID>(url, JSON.stringify(i_Params_Delete_Site_view_By_SITE_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Site_view_By_SITE_ID_List(i_Params_Get_Site_view_By_SITE_ID_List: Params_Get_Site_view_By_SITE_ID_List): Observable<Site_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_view_By_SITE_ID_List?SITE_ID_LIST=' + i_Params_Get_Site_view_By_SITE_ID_List.SITE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_view_By_SITE_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_field_logo_By_SITE_ID_List(i_Params_Get_Site_field_logo_By_SITE_ID_List: Params_Get_Site_field_logo_By_SITE_ID_List): Observable<Site_field_logo[]> {
        const url = this.CmSvc.APIUrl + '/Api/SiteManagement/Get_Site_field_logo_By_SITE_ID_List?SITE_ID_LIST=' + i_Params_Get_Site_field_logo_By_SITE_ID_List.SITE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Site_field_logo_By_SITE_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Check_Organization_Deletion_Status(): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Check_Organization_Deletion_Status';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Check_Organization_Deletion_Status>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID: Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID): Observable<Organization_log_config[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID + '&LOG_TYPE_SETUP_ID=' + i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization(i_Organization: Organization): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization>(url, JSON.stringify(i_Organization), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization;
            })
            );
    }
    Get_Organization_image_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List: Params_Get_Organization_image_By_ORGANIZATION_ID_List): Observable<Organization_image[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_image_By_ORGANIZATION_ID_List_Adv?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Organization_theme(i_Params_Delete_Organization_theme: Params_Delete_Organization_theme): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_theme';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_theme>(url, JSON.stringify(i_Params_Delete_Organization_theme), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID: Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID): Observable<Organization_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv?DATA_LEVEL_SETUP_ID=' + i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List: Params_Get_Organization_theme_By_ORGANIZATION_ID_List): Observable<Organization_theme[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_theme_By_ORGANIZATION_ID_List_Adv?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_Custom(i_Params_Edit_Organization_Custom: Params_Edit_Organization_Custom): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_Custom';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_Custom>(url, JSON.stringify(i_Params_Edit_Organization_Custom), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Schedule_Organization_for_Delete(i_Params_Schedule_Organization_for_Delete: Params_Schedule_Organization_for_Delete): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Schedule_Organization_for_Delete';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Schedule_Organization_for_Delete>(url, JSON.stringify(i_Params_Schedule_Organization_for_Delete), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Modify_Data_Settings(i_Params_Modify_Data_Settings: Params_Modify_Data_Settings): Observable<Data_Settings> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Modify_Data_Settings';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Modify_Data_Settings>(url, JSON.stringify(i_Params_Modify_Data_Settings), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_color_scheme_By_ORGANIZATION_ID_List(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List: Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List): Observable<Organization_color_scheme[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_color_scheme_By_ORGANIZATION_ID_List?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Modify_Organization_Details(i_Params_Modify_Organization_Details: Params_Modify_Organization_Details): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Modify_Organization_Details';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Modify_Organization_Details>(url, JSON.stringify(i_Params_Modify_Organization_Details), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_color_scheme(i_Organization_color_scheme: Organization_color_scheme): Observable<Organization_color_scheme> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_color_scheme';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_color_scheme>(url, JSON.stringify(i_Organization_color_scheme), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization_color_scheme;
            })
            );
    }
    Get_Organization_relation_By_PARENT_ORGANIZATION_ID(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID: Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID): Observable<Organization_relation[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_relation_By_PARENT_ORGANIZATION_ID?PARENT_ORGANIZATION_ID=' + i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_By_ORGANIZATION_ID(i_Params_Get_Organization_By_ORGANIZATION_ID: Params_Get_Organization_By_ORGANIZATION_ID): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_theme_By_ORGANIZATION_ID(i_Params_Get_Organization_theme_By_ORGANIZATION_ID: Params_Get_Organization_theme_By_ORGANIZATION_ID): Observable<Organization_theme[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_theme_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_theme_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID: Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID): Observable<Organization_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID + '&DATA_LEVEL_SETUP_ID=' + i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_districtnex_module_List(i_Params_Edit_Organization_districtnex_module_List: Params_Edit_Organization_districtnex_module_List): Observable<Params_Edit_Organization_districtnex_module_List> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_districtnex_module_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_districtnex_module_List>(url, JSON.stringify(i_Params_Edit_Organization_districtnex_module_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Organization_districtnex_module_List;
            })
            );
    }
    Get_Organization_By_PARENT_ORGANIZATION_ID(i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID: Params_Get_Organization_By_PARENT_ORGANIZATION_ID): Observable<Organization[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_By_PARENT_ORGANIZATION_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Organization_By_PARENT_ORGANIZATION_ID>(url, JSON.stringify(i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_level_access_List(i_Params_Edit_Organization_level_access_List: Params_Edit_Organization_level_access_List): Observable<Params_Edit_Organization_level_access_List> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_level_access_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_level_access_List>(url, JSON.stringify(i_Params_Edit_Organization_level_access_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Organization_level_access_List;
            })
            );
    }
    Edit_Organization_theme(i_Organization_theme: Organization_theme): Observable<Organization_theme> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_theme';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_theme>(url, JSON.stringify(i_Organization_theme), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization_theme;
            })
            );
    }
    Delete_Organization_Picture(i_Params_Delete_Organization_Picture: Params_Delete_Organization_Picture): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_Picture';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_Picture>(url, JSON.stringify(i_Params_Delete_Organization_Picture), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_By_ORGANIZATION_ID_List(i_Params_Get_Organization_By_ORGANIZATION_ID_List: Params_Get_Organization_By_ORGANIZATION_ID_List): Observable<Organization[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_By_ORGANIZATION_ID_List?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_By_ORGANIZATION_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading: Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading>(url, JSON.stringify(i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_color_scheme_By_ORGANIZATION_ID(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID: Params_Get_Organization_color_scheme_By_ORGANIZATION_ID): Observable<Organization_color_scheme[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_color_scheme_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_color_scheme_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_By_OWNER_ID(i_Params_Get_Organization_By_OWNER_ID: Params_Get_Organization_By_OWNER_ID): Observable<Organization[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Organization_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_chart_color_List(i_Params_Edit_Organization_chart_color_List: Params_Edit_Organization_chart_color_List): Observable<Params_Edit_Organization_chart_color_List> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_chart_color_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_chart_color_List>(url, JSON.stringify(i_Params_Edit_Organization_chart_color_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Organization_chart_color_List;
            })
            );
    }
    Get_Organization_level_access_By_ORGANIZATION_ID(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID: Params_Get_Organization_level_access_By_ORGANIZATION_ID): Observable<Organization_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_level_access_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_level_access_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID: Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID): Observable<Organization_districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv?ORGANIZATION_ID=' + i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Restore_Organization(i_Params_Restore_Organization: Params_Restore_Organization): Observable<Organization> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Restore_Organization';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Restore_Organization>(url, JSON.stringify(i_Params_Restore_Organization), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID: Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID): Observable<Organization_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID?DATA_LEVEL_SETUP_ID=' + i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Organization_level_access(i_Params_Delete_Organization_level_access: Params_Delete_Organization_level_access): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_level_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_level_access>(url, JSON.stringify(i_Params_Delete_Organization_level_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Organization_districtnex_module_By_ORGANIZATION_ID(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID: Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID): Observable<Organization_districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_districtnex_module_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Organization_level_access(i_Organization_level_access: Organization_level_access): Observable<Organization_level_access> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_level_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_level_access>(url, JSON.stringify(i_Organization_level_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization_level_access;
            })
            );
    }
    Delete_Organization_level_access_By_ORGANIZATION_ID(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID: Params_Delete_Organization_level_access_By_ORGANIZATION_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_level_access_By_ORGANIZATION_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_level_access_By_ORGANIZATION_ID>(url, JSON.stringify(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Organization_districtnex_module(i_Organization_districtnex_module: Organization_districtnex_module): Observable<Organization_districtnex_module> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_districtnex_module';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_districtnex_module>(url, JSON.stringify(i_Organization_districtnex_module), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization_districtnex_module;
            })
            );
    }
    Delete_Organization_districtnex_module_By_ORGANIZATION_ID(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID: Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_districtnex_module_By_ORGANIZATION_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID>(url, JSON.stringify(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Organization_color_scheme_List(i_Params_Edit_Organization_color_scheme_List: Params_Edit_Organization_color_scheme_List): Observable<Params_Edit_Organization_color_scheme_List> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_color_scheme_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_color_scheme_List>(url, JSON.stringify(i_Params_Edit_Organization_color_scheme_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Organization_color_scheme_List;
            })
            );
    }
    Delete_Organization_color_scheme_By_ORGANIZATION_ID(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID: Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_color_scheme_By_ORGANIZATION_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID>(url, JSON.stringify(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Organization_log_config(i_Organization_log_config: Organization_log_config): Observable<Organization_log_config> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_log_config';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_log_config>(url, JSON.stringify(i_Organization_log_config), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Organization_log_config;
            })
            );
    }
    Edit_Organization_log_config_List(i_Params_Edit_Organization_log_config_List: Params_Edit_Organization_log_config_List): Observable<Params_Edit_Organization_log_config_List> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Edit_Organization_log_config_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Organization_log_config_List>(url, JSON.stringify(i_Params_Edit_Organization_log_config_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Organization_log_config_List;
            })
            );
    }
    Get_Organization_log_config_By_ORGANIZATION_ID(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID: Params_Get_Organization_log_config_By_ORGANIZATION_ID): Observable<Organization_log_config[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_log_config_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_log_config_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Organization_log_config_By_ORGANIZATION_ID(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID: Params_Delete_Organization_log_config_By_ORGANIZATION_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Delete_Organization_log_config_By_ORGANIZATION_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Organization_log_config_By_ORGANIZATION_ID>(url, JSON.stringify(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List: Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List): Observable<Organization_districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_image_By_ORGANIZATION_ID_List(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List: Params_Get_Organization_image_By_ORGANIZATION_ID_List): Observable<Organization_image[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_image_By_ORGANIZATION_ID_List?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_image_By_ORGANIZATION_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List: Params_Get_Organization_level_access_By_ORGANIZATION_ID_List): Observable<Organization_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List: Params_Get_Organization_log_config_By_ORGANIZATION_ID_List): Observable<Organization_log_config[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv?ORGANIZATION_ID_LIST=' + i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_theme_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_theme_By_ORGANIZATION_ID: Params_Get_Organization_theme_By_ORGANIZATION_ID): Observable<Organization_theme[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_theme_By_ORGANIZATION_ID_Adv?ORGANIZATION_ID=' + i_Params_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Organization_image_By_ORGANIZATION_ID(i_Params_Get_Organization_image_By_ORGANIZATION_ID: Params_Get_Organization_image_By_ORGANIZATION_ID): Observable<Organization_image[]> {
        const url = this.CmSvc.APIUrl + '/Api/OrganizationManagement/Get_Organization_image_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Organization_image_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Setup(i_Setup: Setup): Observable<Setup> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Setup';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Setup>(url, JSON.stringify(i_Setup), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Setup;
            })
            );
    }
    Get_Specialized_chart_configuration_By_MODULE(i_Params_Get_Specialized_chart_configuration_By_MODULE: Params_Get_Specialized_chart_configuration_By_MODULE): Observable<Specialized_chart_configuration[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Specialized_chart_configuration_By_MODULE?MODULE=' + i_Params_Get_Specialized_chart_configuration_By_MODULE.MODULE;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Specialized_chart_configuration_By_MODULE>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_District_geojson_By_DISTRICT_ID(i_Params_Delete_District_geojson_By_DISTRICT_ID: Params_Delete_District_geojson_By_DISTRICT_ID): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_District_geojson_By_DISTRICT_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_District_geojson_By_DISTRICT_ID>(url, JSON.stringify(i_Params_Delete_District_geojson_By_DISTRICT_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Dimension_chart_configuration(): Observable<Dimension_chart_configuration[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Dimension_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Dimension_chart_configuration>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Setup_category_List(i_Params_Edit_Setup_category_List: Params_Edit_Setup_category_List): Observable<Params_Edit_Setup_category_List> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Setup_category_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Setup_category_List>(url, JSON.stringify(i_Params_Edit_Setup_category_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Setup_category_List;
            })
            );
    }
    Get_Districtnex_module_By_OWNER_ID(i_Params_Get_Districtnex_module_By_OWNER_ID: Params_Get_Districtnex_module_By_OWNER_ID): Observable<Districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Districtnex_module_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Districtnex_module_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Districtnex_module_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Dimension_chart_configuration(i_Dimension_chart_configuration: Dimension_chart_configuration): Observable<Dimension_chart_configuration> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Dimension_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Dimension_chart_configuration>(url, JSON.stringify(i_Dimension_chart_configuration), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Setup_By_SETUP_ID_Adv(i_Params_Get_Setup_By_SETUP_ID: Params_Get_Setup_By_SETUP_ID): Observable<Setup> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Setup_By_SETUP_ID_Adv?SETUP_ID=' + i_Params_Get_Setup_By_SETUP_ID.SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Setup_By_SETUP_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Default_settings_By_OWNER_ID(i_Params_Get_Default_settings_By_OWNER_ID: Params_Get_Default_settings_By_OWNER_ID): Observable<Default_settings[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Default_settings_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Default_settings_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Default_settings_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Object_View(i_Params_Edit_Object_View: Params_Edit_Object_View): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Object_View';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Object_View>(url, JSON.stringify(i_Params_Edit_Object_View), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID: Params_Get_Setup_category_By_OWNER_ID): Observable<Setup_category[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Setup_category_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Setup_category_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Setup_category_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Site_geojson(): Observable<string[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Site_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Site_geojson>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_District_geojson(i_Params_Edit_District_geojson: Params_Edit_District_geojson): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_District_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_geojson>(url, JSON.stringify(i_Params_Edit_District_geojson), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Build_version(i_Params_Delete_Build_version: Params_Delete_Build_version): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Build_version';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Build_version>(url, JSON.stringify(i_Params_Delete_Build_version), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Ext_study_zone_geojson(i_Params_Edit_Ext_study_zone_geojson: Params_Edit_Ext_study_zone_geojson): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Ext_study_zone_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Ext_study_zone_geojson>(url, JSON.stringify(i_Params_Edit_Ext_study_zone_geojson), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Default_Settings_Picture(i_Params_Delete_Default_Settings_Picture: Params_Delete_Default_Settings_Picture): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Default_Settings_Picture/' + i_Params_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Default_Settings_Picture>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Specialized_chart_configuration(): Observable<Specialized_chart_configuration[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Specialized_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Specialized_chart_configuration>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Removed_extrusion_Custom_Old(i_Params_Edit_Removed_extrusion_Custom_Old: Params_Edit_Removed_extrusion_Custom_Old): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Removed_extrusion_Custom_Old';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Removed_extrusion_Custom_Old>(url, JSON.stringify(i_Params_Edit_Removed_extrusion_Custom_Old), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Area_geojson(): Observable<string[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Area_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Area_geojson>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Setup_category(i_Params_Delete_Setup_category: Params_Delete_Setup_category): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Setup_category/' + i_Params_Delete_Setup_category.SETUP_CATEGORY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Setup_category>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Build_version_By_OWNER_ID_Adv(i_Params_Get_Build_version_By_OWNER_ID: Params_Get_Build_version_By_OWNER_ID): Observable<Build_version[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Build_version_By_OWNER_ID_Adv?OWNER_ID=' + i_Params_Get_Build_version_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Build_version_By_OWNER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Build_version(i_Build_version: Build_version): Observable<Build_version> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Build_version';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Build_version>(url, JSON.stringify(i_Build_version), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Build_version;
            })
            );
    }
    Get_Default_chart_color_By_OWNER_ID_Adv(i_Params_Get_Default_chart_color_By_OWNER_ID: Params_Get_Default_chart_color_By_OWNER_ID): Observable<Default_chart_color[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Default_chart_color_By_OWNER_ID_Adv?OWNER_ID=' + i_Params_Get_Default_chart_color_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Default_chart_color_By_OWNER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Default_chart_color_List(i_Params_Edit_Default_chart_color_List: Params_Edit_Default_chart_color_List): Observable<Params_Edit_Default_chart_color_List> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Default_chart_color_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Default_chart_color_List>(url, JSON.stringify(i_Params_Edit_Default_chart_color_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Default_chart_color_List;
            })
            );
    }
    Get_District_geojson(): Observable<string[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_District_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_District_geojson>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Specialized_chart_configuration(i_Specialized_chart_configuration: Specialized_chart_configuration): Observable<Specialized_chart_configuration> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Specialized_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Specialized_chart_configuration>(url, JSON.stringify(i_Specialized_chart_configuration), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID: Params_Get_Setup_category_By_SETUP_CATEGORY_ID): Observable<Setup_category> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Setup_category_By_SETUP_CATEGORY_ID?SETUP_CATEGORY_ID=' + i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Setup_category_By_SETUP_CATEGORY_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID: Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID>(url, JSON.stringify(i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Setup_category(i_Setup_category: Setup_category): Observable<Setup_category> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Setup_category';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Setup_category>(url, JSON.stringify(i_Setup_category), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Setup_category;
            })
            );
    }
    Edit_Alert_settings_List(i_Params_Edit_Alert_settings_List: Params_Edit_Alert_settings_List): Observable<Params_Edit_Alert_settings_List> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Alert_settings_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Alert_settings_List>(url, JSON.stringify(i_Params_Edit_Alert_settings_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Alert_settings_List;
            })
            );
    }
    Delete_Dimension_chart_configuration(i_Params_Delete_Dimension_chart_configuration: Params_Delete_Dimension_chart_configuration): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Dimension_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Dimension_chart_configuration>(url, JSON.stringify(i_Params_Delete_Dimension_chart_configuration), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Initial_Districtnex_Admin_Settings(): Observable<Initial_Districtnex_Admin_Settings> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Initial_Districtnex_Admin_Settings';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Initial_Districtnex_Admin_Settings>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Site_geojson(i_Params_Edit_Site_geojson: Params_Edit_Site_geojson): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Site_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_geojson>(url, JSON.stringify(i_Params_Edit_Site_geojson), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Area_geojson_By_AREA_ID(i_Params_Delete_Area_geojson_By_AREA_ID: Params_Delete_Area_geojson_By_AREA_ID): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Area_geojson_By_AREA_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Area_geojson_By_AREA_ID>(url, JSON.stringify(i_Params_Delete_Area_geojson_By_AREA_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Default_settings(i_Default_settings: Default_settings): Observable<Default_settings> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Default_settings';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Default_settings>(url, JSON.stringify(i_Default_settings), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Default_settings;
            })
            );
    }
    Delete_Specialized_chart_configuration(i_Params_Delete_Specialized_chart_configuration: Params_Delete_Specialized_chart_configuration): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Specialized_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Specialized_chart_configuration>(url, JSON.stringify(i_Params_Delete_Specialized_chart_configuration), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Initial_Districtnex_UI_Settings(): Observable<Initial_Districtnex_UI_Settings> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Initial_Districtnex_UI_Settings';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Initial_Districtnex_UI_Settings>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Alert_settings_By_OWNER_ID_Adv(i_Params_Get_Alert_settings_By_OWNER_ID: Params_Get_Alert_settings_By_OWNER_ID): Observable<Alert_settings[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Alert_settings_By_OWNER_ID_Adv?OWNER_ID=' + i_Params_Get_Alert_settings_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Alert_settings_By_OWNER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Build_version_By_APPLICATION_NAME_SETUP_ID(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID: Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID): Observable<Build_version[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Build_version_By_APPLICATION_NAME_SETUP_ID?APPLICATION_NAME_SETUP_ID=' + i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Removed_extrusion_Custom(i_Params_Edit_Removed_extrusion_Custom: Params_Edit_Removed_extrusion_Custom): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Removed_extrusion_Custom';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Removed_extrusion_Custom>(url, JSON.stringify(i_Params_Edit_Removed_extrusion_Custom), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Clean_Removed_extrusions(): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Clean_Removed_extrusions';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Clean_Removed_extrusions>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Kpi_chart_configuration(i_Params_Delete_Kpi_chart_configuration: Params_Delete_Kpi_chart_configuration): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Kpi_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Kpi_chart_configuration>(url, JSON.stringify(i_Params_Delete_Kpi_chart_configuration), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_UI_Build_Version_List(): Observable<Build_Version_List_With_Logs> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_UI_Build_Version_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_UI_Build_Version_List>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Ext_study_zone_geojson(): Observable<string[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Ext_study_zone_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Ext_study_zone_geojson>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Custom_Edit_Build_version(i_Params_Custom_Edit_Build_version: Params_Custom_Edit_Build_version): Observable<Build_version> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Custom_Edit_Build_version';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Custom_Edit_Build_version>(url, JSON.stringify(i_Params_Custom_Edit_Build_version), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID: Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID): Observable<Setup_category> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID?SETUP_CATEGORY_NAME=' + i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME + '&OWNER_ID=' + i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Default_chart_color_By_OWNER_ID(i_Params_Get_Default_chart_color_By_OWNER_ID: Params_Get_Default_chart_color_By_OWNER_ID): Observable<Default_chart_color[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Default_chart_color_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Default_chart_color_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Default_chart_color_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Setup_By_OWNER_ID(i_Params_Get_Setup_By_OWNER_ID: Params_Get_Setup_By_OWNER_ID): Observable<Setup[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Setup_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Setup_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Setup_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Area_geojson(i_Params_Edit_Area_geojson: Params_Edit_Area_geojson): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Area_geojson';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_geojson>(url, JSON.stringify(i_Params_Edit_Area_geojson), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Site_geojson_By_SITE_ID(i_Params_Delete_Site_geojson_By_SITE_ID: Params_Delete_Site_geojson_By_SITE_ID): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Site_geojson_By_SITE_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Site_geojson_By_SITE_ID>(url, JSON.stringify(i_Params_Delete_Site_geojson_By_SITE_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Admin_Build_Version_List(): Observable<Build_Version_List_With_Logs> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Admin_Build_Version_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Admin_Build_Version_List>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Removed_extrusion_List(i_Params_Edit_Removed_extrusion_List: Params_Edit_Removed_extrusion_List): Observable<Params_Edit_Removed_extrusion_List> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Removed_extrusion_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Removed_extrusion_List>(url, JSON.stringify(i_Params_Edit_Removed_extrusion_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Removed_extrusion_List;
            })
            );
    }
    Edit_Kpi_chart_configuration(i_Kpi_chart_configuration: Kpi_chart_configuration): Observable<Kpi_chart_configuration> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Kpi_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Kpi_chart_configuration>(url, JSON.stringify(i_Kpi_chart_configuration), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Kpi_chart_configuration(): Observable<Kpi_chart_configuration[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Kpi_chart_configuration';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Kpi_chart_configuration>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Removed_extrusion_By_OWNER_ID(i_Params_Get_Removed_extrusion_By_OWNER_ID: Params_Get_Removed_extrusion_By_OWNER_ID): Observable<Removed_extrusion[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Removed_extrusion_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Removed_extrusion_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Removed_extrusion_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Setup(i_Params_Delete_Setup: Params_Delete_Setup): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Delete_Setup/' + i_Params_Delete_Setup.SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Setup>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Alert_settings_By_USER_ID_Adv(i_Params_Get_Alert_settings_By_USER_ID: Params_Get_Alert_settings_By_USER_ID): Observable<Alert_settings[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Alert_settings_By_USER_ID_Adv?USER_ID=' + i_Params_Get_Alert_settings_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Alert_settings_By_USER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Send_Support_Email(i_Params_Send_Support_Email: Params_Send_Support_Email): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Send_Support_Email';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Send_Support_Email>(url, JSON.stringify(i_Params_Send_Support_Email), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List: Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List): Observable<Districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List?DISTRICTNEX_MODULE_ID_LIST=' + i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Drop_Collection(i_Params_Drop_Collection: Params_Drop_Collection): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Drop_Collection';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Drop_Collection>(url, JSON.stringify(i_Params_Drop_Collection), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Build_version_List(i_Params_Edit_Build_version_List: Params_Edit_Build_version_List): Observable<Params_Edit_Build_version_List> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Edit_Build_version_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Build_version_List>(url, JSON.stringify(i_Params_Edit_Build_version_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Build_version_List;
            })
            );
    }
    Create_Time_series_Collection(i_Params_Create_Time_series_Collection: Params_Create_Time_series_Collection): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Create_Time_series_Collection';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Create_Time_series_Collection>(url, JSON.stringify(i_Params_Create_Time_series_Collection), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID: Params_Get_Setup_By_SETUP_ID): Observable<Setup> {
        const url = this.CmSvc.APIUrl + '/Api/SettingsManagement/Get_Setup_By_SETUP_ID?SETUP_ID=' + i_Params_Get_Setup_By_SETUP_ID.SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Setup_By_SETUP_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Correlation_method(i_Correlation_method: Correlation_method): Observable<Correlation_method> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Edit_Correlation_method';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Correlation_method>(url, JSON.stringify(i_Correlation_method), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Correlation_method;
            })
            );
    }
    Get_Correlation_method_By_OWNER_ID(i_Params_Get_Correlation_method_By_OWNER_ID: Params_Get_Correlation_method_By_OWNER_ID): Observable<Correlation_method[]> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Get_Correlation_method_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Correlation_method_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Correlation_method_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Correlation_method(i_Params_Delete_Correlation_method: Params_Delete_Correlation_method): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Delete_Correlation_method';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Correlation_method>(url, JSON.stringify(i_Params_Delete_Correlation_method), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Correlation(i_Params_Get_Correlation: Params_Get_Correlation): Observable<Kpi_Value_By_Date[]> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Get_Correlation';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Correlation>(url, JSON.stringify(i_Params_Get_Correlation), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Comparison_Data(i_Params_Get_Comparison_Data: Params_Get_Comparison_Data): Observable<Comparison_Data> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Get_Comparison_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Comparison_Data>(url, JSON.stringify(i_Params_Get_Comparison_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Multi_kpi_comparison(i_Params_Get_Multi_kpi_comparison: Params_Get_Multi_kpi_comparison): Observable<Kpi_Value_By_Direction[]> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Get_Multi_kpi_comparison';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Multi_kpi_comparison>(url, JSON.stringify(i_Params_Get_Multi_kpi_comparison), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Single_kpi_comparison(i_Params_Get_Single_kpi_comparison: Params_Get_Single_kpi_comparison): Observable<Kpi_Value_By_Date[]> {
        const url = this.CmSvc.APIUrl + '/Api/InsightsManagement/Get_Single_kpi_comparison';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Single_kpi_comparison>(url, JSON.stringify(i_Params_Get_Single_kpi_comparison), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Fetch_Scenes(i_Params_Fetch_Scenes: Params_Fetch_Scenes): Observable<Fetch_Scenes_Response> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_Scenes';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Fetch_Scenes>(url, JSON.stringify(i_Params_Fetch_Scenes), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Vehicle_Types(i_Params_Get_Vehicle_Types: Params_Get_Vehicle_Types): Observable<string[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Vehicle_Types?VIDEO_AI_INSTANCE_ID=' + i_Params_Get_Vehicle_Types.VIDEO_AI_INSTANCE_ID + '&ENTITY_ID=' + i_Params_Get_Vehicle_Types.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Vehicle_Types>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID: Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID): Observable<Video_ai_instance> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID?VIDEO_AI_INSTANCE_ID=' + i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID: Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID): Observable<Video_ai_instance[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID?VIDEO_AI_ENGINE_ID=' + i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Create_Video_ai_asset(i_Params_Create_Video_ai_asset: Params_Create_Video_ai_asset): Observable<Video_ai_asset> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Create_Video_ai_asset';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Create_Video_ai_asset>(url, JSON.stringify(i_Params_Create_Video_ai_asset), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Update_License_Plate_Recognition_Alerts(): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Update_License_Plate_Recognition_Alerts';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Update_License_Plate_Recognition_Alerts>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Change_Video_ai_instance_Password(i_Params_Change_Video_ai_instance_Password: Params_Change_Video_ai_instance_Password): Observable<Change_Video_ai_instance_Password_Response> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Change_Video_ai_instance_Password';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Change_Video_ai_instance_Password>(url, JSON.stringify(i_Params_Change_Video_ai_instance_Password), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Face_Target_Key_Search(i_Params_Face_Target_Key_Search: Params_Face_Target_Key_Search): Observable<Search_Face_Target_Key_Response_List> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Face_Target_Key_Search';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Face_Target_Key_Search>(url, JSON.stringify(i_Params_Face_Target_Key_Search), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Face_Search(i_Params_Face_Search: Params_Face_Search): Observable<Face_Key_Response_List> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Face_Search';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Face_Search>(url, JSON.stringify(i_Params_Face_Search), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Fetch_License_Plate_Categories(i_Params_Fetch_License_Plate_Categories: Params_Fetch_License_Plate_Categories): Observable<License_Plate_Category[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_License_Plate_Categories?VIDEO_AI_INSTANCE_ID=' + i_Params_Fetch_License_Plate_Categories.VIDEO_AI_INSTANCE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Fetch_License_Plate_Categories>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Fetch_Face_Targets(i_Params_Fetch_Face_Targets: Params_Fetch_Face_Targets): Observable<Fetch_Face_Targets_Response> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_Face_Targets?SIZE=' + i_Params_Fetch_Face_Targets.SIZE + '&PAGE=' + i_Params_Fetch_Face_Targets.PAGE + '&CATEGORY=' + i_Params_Fetch_Face_Targets.CATEGORY + '&TARGET_NAME=' + i_Params_Fetch_Face_Targets.TARGET_NAME;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Fetch_Face_Targets>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Fetch_Facial_Recognition(i_Params_Fetch_Facial_Recognition: Params_Fetch_Facial_Recognition): Observable<Fetch_Facial_Recognition_Reponse> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_Facial_Recognition';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Fetch_Facial_Recognition>(url, JSON.stringify(i_Params_Fetch_Facial_Recognition), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Video_ai_asset_Custom(i_Params_Delete_Video_ai_asset_Custom: Params_Delete_Video_ai_asset_Custom): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Delete_Video_ai_asset_Custom/' + i_Params_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Video_ai_asset_Custom>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Update_Facial_Recognition_Alerts(): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Update_Facial_Recognition_Alerts';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Update_Facial_Recognition_Alerts>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_engine_By_OWNER_ID(i_Params_Get_Video_ai_engine_By_OWNER_ID: Params_Get_Video_ai_engine_By_OWNER_ID): Observable<Video_ai_engine[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_engine_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Video_ai_engine_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_engine_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Fetch_License_Plate_Targets(i_Params_Fetch_License_Plate_Targets: Params_Fetch_License_Plate_Targets): Observable<Fetch_License_Plate_Targets_Response> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_License_Plate_Targets?SIZE=' + i_Params_Fetch_License_Plate_Targets.SIZE + '&PAGE=' + i_Params_Fetch_License_Plate_Targets.PAGE + '&CATEGORY=' + i_Params_Fetch_License_Plate_Targets.CATEGORY + '&PLATE_NUMBER=' + i_Params_Fetch_License_Plate_Targets.PLATE_NUMBER;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Fetch_License_Plate_Targets>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_asset_By_OWNER_ID(i_Params_Get_Video_ai_asset_By_OWNER_ID: Params_Get_Video_ai_asset_By_OWNER_ID): Observable<Video_ai_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Video_ai_asset_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_asset_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Stream_Data(i_Params_Get_Stream_Data: Params_Get_Stream_Data): Observable<Stream_Data> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Stream_Data?ENTITY_ID=' + i_Params_Get_Stream_Data.ENTITY_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Stream_Data>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Fetch_License_Plate_Recognition(i_Params_Fetch_License_Plate_Recognition: Params_Fetch_License_Plate_Recognition): Observable<Fetch_License_Plate_Recognition_Response> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_License_Plate_Recognition';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Fetch_License_Plate_Recognition>(url, JSON.stringify(i_Params_Fetch_License_Plate_Recognition), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Scene_Info(i_Params_Get_Scene_Info: Params_Get_Scene_Info): Observable<Scene_Info> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Scene_Info?VIDEO_AI_INSTANCE_ID=' + i_Params_Get_Scene_Info.VIDEO_AI_INSTANCE_ID + '&SCENE_ID=' + i_Params_Get_Scene_Info.SCENE_ID + '&OBJECT_TYPE=' + i_Params_Get_Scene_Info.OBJECT_TYPE;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Scene_Info>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Update_Alerts_Custom(): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Update_Alerts_Custom';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Update_Alerts_Custom>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Countings(i_Params_Get_Countings: Params_Get_Countings): Observable<Get_Countings_Response[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Countings';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Countings>(url, JSON.stringify(i_Params_Get_Countings), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Camera_Lines(i_Params_Get_Camera_Lines: Params_Get_Camera_Lines): Observable<Camera_Lines[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Camera_Lines';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Camera_Lines>(url, JSON.stringify(i_Params_Get_Camera_Lines), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Video_ai_asset(i_Video_ai_asset: Video_ai_asset): Observable<Video_ai_asset> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Edit_Video_ai_asset';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Video_ai_asset>(url, JSON.stringify(i_Video_ai_asset), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Video_ai_asset;
            })
            );
    }
    Get_Space_asset_Vaidio_camera(i_Params_Get_Space_asset_Vaidio_camera: Params_Get_Space_asset_Vaidio_camera): Observable<Video_ai_asset> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Space_asset_Vaidio_camera?SPACE_ASSET_ID=' + i_Params_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Space_asset_Vaidio_camera>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Update_Alerts(): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Update_Alerts';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Update_Alerts>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_License_Plate_Scene(i_Params_Get_License_Plate_Scene: Params_Get_License_Plate_Scene): Observable<Scene_Details> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_License_Plate_Scene?VIDEO_AI_INSTANCE_ID=' + i_Params_Get_License_Plate_Scene.VIDEO_AI_INSTANCE_ID + '&SCENE_ID=' + i_Params_Get_License_Plate_Scene.SCENE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_License_Plate_Scene>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_assets_with_engine_assets(i_Params_Get_Video_ai_assets_with_engine_assets: Params_Get_Video_ai_assets_with_engine_assets): Observable<Video_ai_assets_with_engine_assets> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_assets_with_engine_assets?VIDEO_AI_INSTANCE_ID=' + i_Params_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_assets_with_engine_assets>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List: Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List): Observable<Video_ai_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv?SPACE_ASSET_ID_LIST=' + i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List: Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List): Observable<Video_ai_asset[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List?VIDEO_AI_ASSET_ID_REF_LIST=' + i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.VIDEO_AI_ASSET_ID_REF_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Create_Video_ai_instance(i_Params_Create_Video_ai_instance: Params_Create_Video_ai_instance): Observable<Video_ai_instance> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Create_Video_ai_instance';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Create_Video_ai_instance>(url, JSON.stringify(i_Params_Create_Video_ai_instance), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Video_ai_engine(i_Params_Delete_Video_ai_engine: Params_Delete_Video_ai_engine): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Delete_Video_ai_engine/' + i_Params_Delete_Video_ai_engine.VIDEO_AI_ENGINE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Video_ai_engine>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Fetch_Face_Target_Categories(i_Params_Fetch_Face_Target_Categories: Params_Fetch_Face_Target_Categories): Observable<Face_Target_Response_Category[]> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Fetch_Face_Target_Categories?VIDEO_AI_INSTANCE_ID=' + i_Params_Fetch_Face_Target_Categories.VIDEO_AI_INSTANCE_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Fetch_Face_Target_Categories>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Vehicle_Countings(i_Params_Get_Vehicle_Countings: Params_Get_Vehicle_Countings): Observable<Vehicle_Counting> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Vehicle_Countings';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Vehicle_Countings>(url, JSON.stringify(i_Params_Get_Vehicle_Countings), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Video_ai_instance_custom(i_Params_Edit_Video_ai_instance_custom: Params_Edit_Video_ai_instance_custom): Observable<Video_ai_instance_with_connection_flag> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Edit_Video_ai_instance_custom';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Video_ai_instance_custom>(url, JSON.stringify(i_Params_Edit_Video_ai_instance_custom), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Send_Alerts_Email(i_Params_Send_Alerts_Email: Params_Send_Alerts_Email): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Send_Alerts_Email';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Send_Alerts_Email>(url, JSON.stringify(i_Params_Send_Alerts_Email), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID: Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID): Observable<Video_ai_asset> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv?VIDEO_AI_ASSET_ID=' + i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Video_ai_instance(i_Params_Delete_Video_ai_instance: Params_Delete_Video_ai_instance): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Delete_Video_ai_instance';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Video_ai_instance>(url, JSON.stringify(i_Params_Delete_Video_ai_instance), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Video_ai_instance(i_Video_ai_instance: Video_ai_instance): Observable<Video_ai_instance> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Edit_Video_ai_instance';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Video_ai_instance>(url, JSON.stringify(i_Video_ai_instance), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Video_ai_instance;
            })
            );
    }
    Edit_Video_ai_engine_List(i_Params_Edit_Video_ai_engine_List: Params_Edit_Video_ai_engine_List): Observable<Params_Edit_Video_ai_engine_List> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Edit_Video_ai_engine_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Video_ai_engine_List>(url, JSON.stringify(i_Params_Edit_Video_ai_engine_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Video_ai_engine_List;
            })
            );
    }
    Edit_Video_ai_engine(i_Video_ai_engine: Video_ai_engine): Observable<Video_ai_engine> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Edit_Video_ai_engine';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Video_ai_engine>(url, JSON.stringify(i_Video_ai_engine), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Video_ai_engine;
            })
            );
    }
    Get_Sites_and_Entities(): Observable<Sites_and_Entities> {
        const url = this.CmSvc.APIUrl + '/Api/VideoAIEngineManagement/Get_Sites_and_Entities';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Sites_and_Entities>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Object(i_Params_Delete_Object: Params_Delete_Object): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/FileManagement/Delete_Object/' + i_Params_Delete_Object.Object_Name;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Object>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Object_List(i_Params_Delete_Object_List: Params_Delete_Object_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/FileManagement/Delete_Object_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Object_List>(url, JSON.stringify(i_Params_Delete_Object_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Upload_Object(i_Params_Upload_Object: Params_Upload_Object): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/FileManagement/Upload_Object';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Upload_Object>(url, JSON.stringify(i_Params_Upload_Object), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Area_view_By_AREA_ID(i_Params_Get_Area_view_By_AREA_ID: Params_Get_Area_view_By_AREA_ID): Observable<Area_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Get_Area_view_By_AREA_ID?AREA_ID=' + i_Params_Get_Area_view_By_AREA_ID.AREA_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Area_view_By_AREA_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Area_view(i_Area_view: Area_view): Observable<Area_view> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Edit_Area_view';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_view>(url, JSON.stringify(i_Area_view), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Area_view;
            })
            );
    }
    Edit_Area(i_Area: Area): Observable<Area> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Edit_Area';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area>(url, JSON.stringify(i_Area), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Area;
            })
            );
    }
    Get_Area_geojson_By_AREA_ID_List(i_Params_Get_Area_geojson_By_AREA_ID_List: Params_Get_Area_geojson_By_AREA_ID_List): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Get_Area_geojson_By_AREA_ID_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Area_geojson_By_AREA_ID_List>(url, JSON.stringify(i_Params_Get_Area_geojson_By_AREA_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Area_By_OWNER_ID(i_Params_Get_Area_By_OWNER_ID: Params_Get_Area_By_OWNER_ID): Observable<Area[]> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Get_Area_By_OWNER_ID?OWNER_ID=' + i_Params_Get_Area_By_OWNER_ID.OWNER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Area_By_OWNER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Area_By_AREA_ID_List(i_Params_Get_Area_By_AREA_ID_List: Params_Get_Area_By_AREA_ID_List): Observable<Area[]> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Get_Area_By_AREA_ID_List?AREA_ID_LIST=' + i_Params_Get_Area_By_AREA_ID_List.AREA_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Area_By_AREA_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Area_view(i_Params_Delete_Area_view: Params_Delete_Area_view): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Delete_Area_view/' + i_Params_Delete_Area_view.AREA_VIEW_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.delete<Result_Delete_Area_view>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Area_view_List(i_Params_Edit_Area_view_List: Params_Edit_Area_view_List): Observable<Params_Edit_Area_view_List> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Edit_Area_view_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_view_List>(url, JSON.stringify(i_Params_Edit_Area_view_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Area_view_List;
            })
            );
    }
    Delete_Area_view_By_AREA_ID(i_Params_Delete_Area_view_By_AREA_ID: Params_Delete_Area_view_By_AREA_ID): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Delete_Area_view_By_AREA_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Area_view_By_AREA_ID>(url, JSON.stringify(i_Params_Delete_Area_view_By_AREA_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_Area_view_By_AREA_ID_List(i_Params_Get_Area_view_By_AREA_ID_List: Params_Get_Area_view_By_AREA_ID_List): Observable<Area_view[]> {
        const url = this.CmSvc.APIUrl + '/Api/AreaManagement/Get_Area_view_By_AREA_ID_List?AREA_ID_LIST=' + i_Params_Get_Area_view_By_AREA_ID_List.AREA_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Area_view_By_AREA_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Secret(i_Params_Get_Secret: Params_Get_Secret): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/CloudInterface/Get_Secret?Secret_Id=' + i_Params_Get_Secret.Secret_Id + '&Secret_Version=' + i_Params_Get_Secret.Secret_Version;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Secret>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Primary_Authentication(i_Params_Primary_Authentication: Params_Primary_Authentication): Observable<Primary_Authentication_Response> {
        const url = this.CmSvc.APIUrl + '/Api/UserAuthentication/Primary_Authentication';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Primary_Authentication>(url, JSON.stringify(i_Params_Primary_Authentication), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    OTP_Verification(i_Params_OTP_Verification: Params_OTP_Verification): Observable<User_Details> {
        const url = this.CmSvc.APIUrl + '/Api/UserAuthentication/OTP_Verification';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_OTP_Verification>(url, JSON.stringify(i_Params_OTP_Verification), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Send_Otp(i_Params_Send_Otp: Params_Send_Otp): Observable<Send_Otp_Response> {
        const url = this.CmSvc.APIUrl + '/Api/UserAuthentication/Send_Otp';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Send_Otp>(url, JSON.stringify(i_Params_Send_Otp), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Verify_Otp(i_Params_Verify_Otp: Params_Verify_Otp): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/UserAuthentication/Verify_Otp';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Verify_Otp>(url, JSON.stringify(i_Params_Verify_Otp), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Change_User_Forgotten_Password(i_Params_Change_User_Forgotten_Password: Params_Change_User_Forgotten_Password): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/UserAuthentication/Change_User_Forgotten_Password';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Change_User_Forgotten_Password>(url, JSON.stringify(i_Params_Change_User_Forgotten_Password), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Create_User(i_Params_Create_User: Params_Create_User): Observable<User> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Create_User';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Create_User>(url, JSON.stringify(i_Params_Create_User), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Change_User_Password(i_Params_Change_User_Password: Params_Change_User_Password): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Change_User_Password';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Change_User_Password>(url, JSON.stringify(i_Params_Change_User_Password), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Area_kpi(i_Area_kpi: Area_kpi): Observable<Area_kpi> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Area_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_kpi>(url, JSON.stringify(i_Area_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Area_kpi;
            })
            );
    }
    Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List: Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List): Observable<User_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List?ORGANIZATION_LEVEL_ACCESS_ID_LIST=' + i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_User_Walkthrough(i_Params_Edit_User_Walkthrough: Params_Edit_User_Walkthrough): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_User_Walkthrough';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_Walkthrough>(url, JSON.stringify(i_Params_Edit_User_Walkthrough), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Schedule_User_for_Delete(i_Params_Schedule_User_for_Delete: Params_Schedule_User_for_Delete): Observable<User> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Schedule_User_for_Delete';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Schedule_User_for_Delete>(url, JSON.stringify(i_Params_Schedule_User_for_Delete), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_Accessible_Level_List(i_Params_Get_User_Accessible_Level_List: Params_Get_User_Accessible_Level_List): Observable<User_Accessible_Level_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_Accessible_Level_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_User_Accessible_Level_List>(url, JSON.stringify(i_Params_Get_User_Accessible_Level_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_District_kpi_user_access_List(i_Params_Edit_District_kpi_user_access_List: Params_Edit_District_kpi_user_access_List): Observable<Params_Edit_District_kpi_user_access_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_District_kpi_user_access_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_kpi_user_access_List>(url, JSON.stringify(i_Params_Edit_District_kpi_user_access_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_District_kpi_user_access_List;
            })
            );
    }
    Delete_Area_kpi(i_Params_Delete_Area_kpi: Params_Delete_Area_kpi): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Delete_Area_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Area_kpi>(url, JSON.stringify(i_Params_Delete_Area_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_User_level_access_By_USER_ID_List(i_Params_Get_User_level_access_By_USER_ID_List: Params_Get_User_level_access_By_USER_ID_List): Observable<User_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_level_access_By_USER_ID_List?USER_ID_LIST=' + i_Params_Get_User_level_access_By_USER_ID_List.USER_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_level_access_By_USER_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_User_level_access(i_Params_Delete_User_level_access: Params_Delete_User_level_access): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Delete_User_level_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_User_level_access>(url, JSON.stringify(i_Params_Delete_User_level_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Entity_kpi_List(i_Params_Edit_Entity_kpi_List: Params_Edit_Entity_kpi_List): Observable<Params_Edit_Entity_kpi_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Entity_kpi_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_kpi_List>(url, JSON.stringify(i_Params_Edit_Entity_kpi_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Entity_kpi_List;
            })
            );
    }
    Get_User_By_ORGANIZATION_ID_Adv(i_Params_Get_User_By_ORGANIZATION_ID: Params_Get_User_By_ORGANIZATION_ID): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_ORGANIZATION_ID_Adv?ORGANIZATION_ID=' + i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_ORGANIZATION_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_User_Details(i_Params_Edit_User_Details: Params_Edit_User_Details): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_User_Details';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_Details>(url, JSON.stringify(i_Params_Edit_User_Details), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_District_kpi_List(i_Params_Edit_District_kpi_List: Params_Edit_District_kpi_List): Observable<Params_Edit_District_kpi_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_District_kpi_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_kpi_List>(url, JSON.stringify(i_Params_Edit_District_kpi_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_District_kpi_List;
            })
            );
    }
    Edit_Entity_kpi(i_Entity_kpi: Entity_kpi): Observable<Entity_kpi> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Entity_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_kpi>(url, JSON.stringify(i_Entity_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Entity_kpi;
            })
            );
    }
    Get_User_Accessible_Data_With_Level_List(i_Params_Get_User_Accessible_Data_With_Level_List: Params_Get_User_Accessible_Data_With_Level_List): Observable<User_Accessible_Data_With_Level_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_Accessible_Data_With_Level_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_User_Accessible_Data_With_Level_List>(url, JSON.stringify(i_Params_Get_User_Accessible_Data_With_Level_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_districtnex_module_By_USER_ID_List(i_Params_Get_User_districtnex_module_By_USER_ID_List: Params_Get_User_districtnex_module_By_USER_ID_List): Observable<User_districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_districtnex_module_By_USER_ID_List?USER_ID_LIST=' + i_Params_Get_User_districtnex_module_By_USER_ID_List.USER_ID_LIST?.toString();
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_districtnex_module_By_USER_ID_List>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List: Params_Get_User_By_USER_ID_List): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_USER_ID_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_User_By_USER_ID_List>(url, JSON.stringify(i_Params_Get_User_By_USER_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_districtnex_module_By_USER_ID(i_Params_Get_User_districtnex_module_By_USER_ID: Params_Get_User_districtnex_module_By_USER_ID): Observable<User_districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_districtnex_module_By_USER_ID?USER_ID=' + i_Params_Get_User_districtnex_module_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_districtnex_module_By_USER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID: Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID): Observable<User_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID?USER_ID=' + i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.USER_ID + '&DATA_LEVEL_SETUP_ID=' + i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_By_ORGANIZATION_ID(i_Params_Get_User_By_ORGANIZATION_ID: Params_Get_User_By_ORGANIZATION_ID): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_ORGANIZATION_ID?ORGANIZATION_ID=' + i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_ORGANIZATION_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Entity_kpi_user_access_List(i_Params_Edit_Entity_kpi_user_access_List: Params_Edit_Entity_kpi_user_access_List): Observable<Params_Edit_Entity_kpi_user_access_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Entity_kpi_user_access_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_kpi_user_access_List>(url, JSON.stringify(i_Params_Edit_Entity_kpi_user_access_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Entity_kpi_user_access_List;
            })
            );
    }
    Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List: Params_Get_User_By_USER_ID_List): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_USER_ID_List_Adv';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_User_By_USER_ID_List_Adv>(url, JSON.stringify(i_Params_Get_User_By_USER_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Site_kpi_user_access(i_Site_kpi_user_access: Site_kpi_user_access): Observable<Site_kpi_user_access> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Site_kpi_user_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_kpi_user_access>(url, JSON.stringify(i_Site_kpi_user_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Site_kpi_user_access;
            })
            );
    }
    Edit_Entity_kpi_user_access(i_Entity_kpi_user_access: Entity_kpi_user_access): Observable<Entity_kpi_user_access> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Entity_kpi_user_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Entity_kpi_user_access>(url, JSON.stringify(i_Entity_kpi_user_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Entity_kpi_user_access;
            })
            );
    }
    Edit_Area_kpi_List(i_Params_Edit_Area_kpi_List: Params_Edit_Area_kpi_List): Observable<Params_Edit_Area_kpi_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Area_kpi_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_kpi_List>(url, JSON.stringify(i_Params_Edit_Area_kpi_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Area_kpi_List;
            })
            );
    }
    Delete_Site_kpi(i_Params_Delete_Site_kpi: Params_Delete_Site_kpi): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Delete_Site_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Site_kpi>(url, JSON.stringify(i_Params_Delete_Site_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_User_level_access_List(i_Params_Edit_User_level_access_List: Params_Edit_User_level_access_List): Observable<Params_Edit_User_level_access_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_User_level_access_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_level_access_List>(url, JSON.stringify(i_Params_Edit_User_level_access_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_User_level_access_List;
            })
            );
    }
    Delete_Entity_kpi(i_Params_Delete_Entity_kpi: Params_Delete_Entity_kpi): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Delete_Entity_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Entity_kpi>(url, JSON.stringify(i_Params_Delete_Entity_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Get_User_Accessible_Data(i_Params_Get_User_Accessible_Data: Params_Get_User_Accessible_Data): Observable<User_Accessible_Data> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_Accessible_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_User_Accessible_Data>(url, JSON.stringify(i_Params_Get_User_Accessible_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_User_districtnex_module_List(i_Params_Edit_User_districtnex_module_List: Params_Edit_User_districtnex_module_List): Observable<Params_Edit_User_districtnex_module_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_User_districtnex_module_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_districtnex_module_List>(url, JSON.stringify(i_Params_Edit_User_districtnex_module_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_User_districtnex_module_List;
            })
            );
    }
    Edit_Site_kpi_user_access_List(i_Params_Edit_Site_kpi_user_access_List: Params_Edit_Site_kpi_user_access_List): Observable<Params_Edit_Site_kpi_user_access_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Site_kpi_user_access_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_kpi_user_access_List>(url, JSON.stringify(i_Params_Edit_Site_kpi_user_access_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Site_kpi_user_access_List;
            })
            );
    }
    Get_Initial_Data(i_Params_Get_Initial_Data: Params_Get_Initial_Data): Observable<Initial_Data> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_Initial_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Initial_Data>(url, JSON.stringify(i_Params_Get_Initial_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_District_kpi(i_District_kpi: District_kpi): Observable<District_kpi> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_District_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_kpi>(url, JSON.stringify(i_District_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.District_kpi;
            })
            );
    }
    Change_Password(i_Params_Change_Password: Params_Change_Password): Observable<boolean> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Change_Password';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Change_Password>(url, JSON.stringify(i_Params_Change_Password), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_District_kpi(i_Params_Delete_District_kpi: Params_Delete_District_kpi): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Delete_District_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_District_kpi>(url, JSON.stringify(i_Params_Delete_District_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Site_kpi_List(i_Params_Edit_Site_kpi_List: Params_Edit_Site_kpi_List): Observable<Params_Edit_Site_kpi_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Site_kpi_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_kpi_List>(url, JSON.stringify(i_Params_Edit_Site_kpi_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Site_kpi_List;
            })
            );
    }
    Get_Entity_Intersection_List(i_Params_Get_Entity_Intersection_List: Params_Get_Entity_Intersection_List): Observable<Entity[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_Entity_Intersection_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Entity_Intersection_List>(url, JSON.stringify(i_Params_Get_Entity_Intersection_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Check_User_Deletion_Status(): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Check_User_Deletion_Status';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Check_User_Deletion_Status>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_User_By_IS_RECEIVE_EMAIL(i_Params_Get_User_By_IS_RECEIVE_EMAIL: Params_Get_User_By_IS_RECEIVE_EMAIL): Observable<User[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_IS_RECEIVE_EMAIL?IS_RECEIVE_EMAIL=' + i_Params_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_IS_RECEIVE_EMAIL>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID: Params_Get_User_By_USER_ID): Observable<User> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_USER_ID?USER_ID=' + i_Params_Get_User_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_USER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_level_access_By_USER_ID(i_Params_Get_User_level_access_By_USER_ID: Params_Get_User_level_access_By_USER_ID): Observable<User_level_access[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_level_access_By_USER_ID?USER_ID=' + i_Params_Get_User_level_access_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_level_access_By_USER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Level_Data(i_Params_Get_Level_Data: Params_Get_Level_Data): Observable<Level_Data> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_Level_Data';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Level_Data>(url, JSON.stringify(i_Params_Get_Level_Data), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Restore_User(i_Params_Restore_User: Params_Restore_User): Observable<User> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Restore_User';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Restore_User>(url, JSON.stringify(i_Params_Restore_User), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_districtnex_module_By_USER_ID_Adv(i_Params_Get_User_districtnex_module_By_USER_ID: Params_Get_User_districtnex_module_By_USER_ID): Observable<User_districtnex_module[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_districtnex_module_By_USER_ID_Adv?USER_ID=' + i_Params_Get_User_districtnex_module_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_districtnex_module_By_USER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_User_theme(i_User_theme: User_theme): Observable<User_theme> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_User_theme';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_theme>(url, JSON.stringify(i_User_theme), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.User_theme;
            })
            );
    }
    Edit_User_List(i_Params_Edit_User_List: Params_Edit_User_List): Observable<Params_Edit_User_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_User_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_User_List>(url, JSON.stringify(i_Params_Edit_User_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_User_List;
            })
            );
    }
    Get_Admin_Data(i_Params_Get_Admin_Data: Params_Get_Admin_Data): Observable<Admin_Data> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_Admin_Data?USER_ID=' + i_Params_Get_Admin_Data.USER_ID + '&IS_GET_IMAGES_FROM_Cloud=' + i_Params_Get_Admin_Data.IS_GET_IMAGES_FROM_Cloud;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_Admin_Data>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID: Params_Get_User_By_USER_ID): Observable<User> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_By_USER_ID_Adv?USER_ID=' + i_Params_Get_User_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_By_USER_ID_Adv>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_User_theme_By_USER_ID(i_Params_Get_User_theme_By_USER_ID: Params_Get_User_theme_By_USER_ID): Observable<User_theme[]> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_User_theme_By_USER_ID?USER_ID=' + i_Params_Get_User_theme_By_USER_ID.USER_ID;
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.get<Result_Get_User_theme_By_USER_ID>(url, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Site_kpi(i_Site_kpi: Site_kpi): Observable<Site_kpi> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Site_kpi';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Site_kpi>(url, JSON.stringify(i_Site_kpi), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Site_kpi;
            })
            );
    }
    Edit_Area_kpi_user_access_List(i_Params_Edit_Area_kpi_user_access_List: Params_Edit_Area_kpi_user_access_List): Observable<Params_Edit_Area_kpi_user_access_List> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Area_kpi_user_access_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_kpi_user_access_List>(url, JSON.stringify(i_Params_Edit_Area_kpi_user_access_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Params_Edit_Area_kpi_user_access_List;
            })
            );
    }
    Delete_User_theme(i_Params_Delete_User_theme: Params_Delete_User_theme): Observable<string> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Delete_User_theme';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_User_theme>(url, JSON.stringify(i_Params_Delete_User_theme), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Exception_Message;
            })
            );
    }
    Edit_Area_kpi_user_access(i_Area_kpi_user_access: Area_kpi_user_access): Observable<Area_kpi_user_access> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_Area_kpi_user_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Area_kpi_user_access>(url, JSON.stringify(i_Area_kpi_user_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.Area_kpi_user_access;
            })
            );
    }
    Edit_District_kpi_user_access(i_District_kpi_user_access: District_kpi_user_access): Observable<District_kpi_user_access> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Edit_District_kpi_user_access';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_District_kpi_user_access>(url, JSON.stringify(i_District_kpi_user_access), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.District_kpi_user_access;
            })
            );
    }
    Modify_User_Details(i_Params_Modify_User_Details: Params_Modify_User_Details): Observable<User> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Modify_User_Details';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Modify_User_Details>(url, JSON.stringify(i_Params_Modify_User_Details), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Dimension_Index_With_Simple_Upper_Level(i_Params_Get_Dimension_Index_With_Simple_Upper_Level: Params_Get_Dimension_Index_With_Simple_Upper_Level): Observable<Dimension_Index_With_Simple_Upper_Level> {
        const url = this.CmSvc.APIUrl + '/Api/UserManagement/Get_Dimension_Index_With_Simple_Upper_Level';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Dimension_Index_With_Simple_Upper_Level>(url, JSON.stringify(i_Params_Get_Dimension_Index_With_Simple_Upper_Level), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Incidents_By_Where_Sorted_With_Pagination(i_Params_Get_Incidents_By_Where_Sorted_With_Pagination: Params_Get_Incidents_By_Where_Sorted_With_Pagination): Observable<Incident_With_Count> {
        const url = this.CmSvc.APIUrl + '/Api/SecurityDimension/Get_Incidents_By_Where_Sorted_With_Pagination';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Incidents_By_Where_Sorted_With_Pagination>(url, JSON.stringify(i_Params_Get_Incidents_By_Where_Sorted_With_Pagination), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Edit_Incident_List(i_Params_Edit_Incident_List: Params_Edit_Incident_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SecurityDimension/Edit_Incident_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Incident_List>(url, JSON.stringify(i_Params_Edit_Incident_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Incident(): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/SecurityDimension/Delete_Incident';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Incident>(url, {}, options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Get_Incidents_By_Where_Count(i_Params_Get_Incidents_By_Where_Count: Params_Get_Incidents_By_Where_Count): Observable<number> {
        const url = this.CmSvc.APIUrl + '/Api/SecurityDimension/Get_Incidents_By_Where_Count';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Incidents_By_Where_Count>(url, JSON.stringify(i_Params_Get_Incidents_By_Where_Count), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Incidents_By_Where(i_Params_Get_Incidents_By_Where: Params_Get_Incidents_By_Where): Observable<Incident[]> {
        const url = this.CmSvc.APIUrl + '/Api/SecurityDimension/Get_Incidents_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Incidents_By_Where>(url, JSON.stringify(i_Params_Get_Incidents_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Method_run_By_METHOD_RUN_ID(i_Params_Get_Method_run_By_METHOD_RUN_ID: Params_Get_Method_run_By_METHOD_RUN_ID): Observable<Method_run> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Get_Method_run_By_METHOD_RUN_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Method_run_By_METHOD_RUN_ID>(url, JSON.stringify(i_Params_Get_Method_run_By_METHOD_RUN_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Method_run_By_METHOD_RUN_ID_List(i_Params_Get_Method_run_By_METHOD_RUN_ID_List: Params_Get_Method_run_By_METHOD_RUN_ID_List): Observable<Method_run[]> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Get_Method_run_By_METHOD_RUN_ID_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Method_run_By_METHOD_RUN_ID_List>(url, JSON.stringify(i_Params_Get_Method_run_By_METHOD_RUN_ID_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Method_run_By_OWNER_ID(i_Params_Get_Method_run_By_OWNER_ID: Params_Get_Method_run_By_OWNER_ID): Observable<Method_run[]> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Get_Method_run_By_OWNER_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Method_run_By_OWNER_ID>(url, JSON.stringify(i_Params_Get_Method_run_By_OWNER_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Method_run_By_OWNER_ID_IS_DELETED(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED: Params_Get_Method_run_By_OWNER_ID_IS_DELETED): Observable<Method_run[]> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Get_Method_run_By_OWNER_ID_IS_DELETED';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Method_run_By_OWNER_ID_IS_DELETED>(url, JSON.stringify(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Get_Method_run_By_Where(i_Params_Get_Method_run_By_Where: Params_Get_Method_run_By_Where): Observable<Method_run[]> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Get_Method_run_By_Where';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Get_Method_run_By_Where>(url, JSON.stringify(i_Params_Get_Method_run_By_Where), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
                return response.i_Result;
            })
            );
    }
    Delete_Method_run(i_Params_Delete_Method_run: Params_Delete_Method_run): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Delete_Method_run';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Method_run>(url, JSON.stringify(i_Params_Delete_Method_run), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Method_run_By_OWNER_ID(i_Params_Delete_Method_run_By_OWNER_ID: Params_Delete_Method_run_By_OWNER_ID): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Delete_Method_run_By_OWNER_ID';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Method_run_By_OWNER_ID>(url, JSON.stringify(i_Params_Delete_Method_run_By_OWNER_ID), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Delete_Method_run_By_OWNER_ID_IS_DELETED(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED: Params_Delete_Method_run_By_OWNER_ID_IS_DELETED): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Delete_Method_run_By_OWNER_ID_IS_DELETED';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Delete_Method_run_By_OWNER_ID_IS_DELETED>(url, JSON.stringify(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Method_run(i_Method_run: Method_run): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Edit_Method_run';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Method_run>(url, JSON.stringify(i_Method_run), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
    Edit_Method_run_List(i_Params_Edit_Method_run_List: Params_Edit_Method_run_List): Observable<void> {
        const url = this.CmSvc.APIUrl + '/Api/MethodMonitoring/Edit_Method_run_List';
        const headers = new HttpHeaders({ 'Content-Type': 'application/json', 'Ticket': this.CmSvc.Ticket });
        const options = { headers: headers };
        return this.api.post<Result_Edit_Method_run_List>(url, JSON.stringify(i_Params_Edit_Method_run_List), options)
            .pipe(map(response => {
                this.CmSvc.Handle_Stack_Trace(response.Stack_Trace);
                this.CmSvc.Handle_Exception(response.Exception_Message);
            })
            );
    }
}
export enum Enum_Timespan {
    X_HOURLY_COLLECTION,
    X_DAILY_COLLECTION,
    X_WEEKLY_COLLECTION,
    X_MONTHLY_COLLECTION,
    X_QUARTERLY_COLLECTION
}
export enum Enum_Dimension_Status {
    ENABLED,
    DISABLED,
    HIDDEN
}
export class Accessible_Level_ID_List_By_Top_Level {
    TOP_LEVEL_ID?: number;
    DISTRICT_ID_LIST: number[];
    AREA_ID_LIST: number[];
    SITE_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
}
export class Accessible_Level_List_By_Top_Level {
    TOP_LEVEL: Top_level;
    DISTRICT_LIST: District[];
    AREA_LIST: Area[];
    SITE_LIST: Site[];
    ENTITY_LIST: Entity[];
    INTERSECTION_LIST: Entity[];
}
export class Action_Button {
    ICON: string;
    FUNCTIONALITY: string;
    TOOLTIP: string;
}
export class Admin_Data {
    NUMBER_OF_USERS: number;
    List_Site: Site[];
    List_Entity: Entity[];
    Organization: Organization;
    List_Dimension: Dimension[];
    List_Setup_category: Setup_category[];
    List_Districtnex_module: Districtnex_module[];
}
export class Alert {
    ALERT_ID: string;
    RECORD_DATE?: string;
    ALERT_VALUE?: number;
    VALUE_PASSED?: number;
    VALUE_TYPE_SETUP_ID?: number;
    OPERATION_TYPE_SETUP_ID?: number;
    USER_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    LEVEL_SETUP_ID?: number;
    LEVEL_ID?: number;
    IS_ACKNOWLEDGED?: boolean;
    Object: Object;
}
export class Alert_settings {
    ALERT_SETTINGS_ID?: number;
    USER_ID?: number;
    KPI_ID?: number;
    VALUE?: number;
    VALUE_TYPE_SETUP_ID?: number;
    OPERATION_SETUP_ID?: number;
    IS_ACTIVE: boolean;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Kpi: Kpi;
    Operation_setup: Setup;
    Value_type_setup: Setup;
    User: User;
}
export class Area {
    List_Site: Site[];
    AREA_ID?: number;
    DISTRICT_ID?: number;
    REGION_ID?: number;
    TOP_LEVEL_ID?: number;
    NAME: string;
    LOCATION: string;
    AREA?: number;
    UNIT: string;
    SCALE?: number;
    ROTATIONX?: number;
    ROTATIONY?: number;
    ROTATIONZ?: number;
    GLTF_LATITUDE?: number;
    GLTF_LONGITUDE?: number;
    CENTER_LATITUDE?: number;
    CENTER_LONGITUDE?: number;
    RADIUS_IN_METERS?: number;
    IMAGE_URL: string;
    LOGO_URL: string;
    SOLID_GLTF_URL: string;
    AREA_COLOR: string;
    BORDER_COLOR: string;
    STUDY_ZONE_NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    District: District;
    Region: Region;
    Top_level: Top_level;
    List_Area_view: Area_view[];
}
export class Area_kpi {
    AREA_KPI_ID?: number;
    AREA_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Area: Area;
    Organization_data_source_kpi: Organization_data_source_kpi;
}
export class Area_kpi_data {
    RECORD_DATE: string;
    AREA_METADATA: Area_metadata;
    VALUE: number;
    VALUE_PER_SQM?: number;
    VALUE_NAME: string;
}
export class Area_Kpi_Dialog_Data {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    KPI_ID?: number;
    TITLE: string;
    KPI_DATA: Data_point;
}
export class Area_kpi_user_access {
    AREA_KPI_USER_ACCESS_ID?: number;
    USER_ID?: number;
    AREA_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Area: Area;
    Organization_data_source_kpi: Organization_data_source_kpi;
    User: User;
}
export class Area_metadata {
    AREA_ID: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID: number;
    CATEGORY: string;
}
export class Area_view {
    AREA_VIEW_ID?: number;
    AREA_ID?: number;
    VIEW_TYPE_SETUP_ID?: number;
    PITCH?: number;
    BEARING?: number;
    ZOOM?: number;
    LATITUDE?: number;
    LONGITUDE?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Area: Area;
    View_type_setup: Setup;
}
export class Asset {
    ASSET_ID?: number;
    ASSET_TYPE_SETUP_ID?: number;
    NAME: string;
    GLTF_URL: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Asset_type_setup: Setup;
}
export class Asset_Data {
    SPACE_ASSET_SECURITY_INCIDENT_LIST: Incident[];
    SPACE_ASSET_ENERGY_INCIDENT_LIST: Incident[];
}
export class Asset_definition {
    LEVEL_ID?: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: number[];
}
export class Best_And_Worst_Object {
    Best_Performance_object: Performance_object;
    Worst_Performance_object: Performance_object;
}
export class Brand_Api_Response {
    BrandId: number;
    Name: string;
    Enabled: boolean;
}
export class Bucket {
    TIMEFRAME_BUCKET?: string;
    COUNT?: number;
    LIST_OUTPUT: Output[];
}
export class Build_version {
    BUILD_VERSION_ID?: number;
    BUILD_NUMBER: string;
    APPLICATION_NAME_SETUP_ID?: number;
    IS_CURRENT: boolean;
    BUILD_DATE: string;
    COMMENTS: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Application_name_setup: Setup;
    List_Build_version_log: Build_version_log[];
}
export class Build_Version_List_With_Logs {
    LIST_BUILD_VERSION: Build_version[];
    BUILD_LOG_TYPE_SETUP_CATEGORY: Setup_category;
}
export class Build_version_log {
    BUILD_VERSION_LOG_ID?: number;
    BUILD_VERSION_ID?: number;
    BUILD_LOG_TYPE_SETUP_ID?: number;
    DESCRIPTION: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Build_version: Build_version;
    Build_log_type_setup: Setup;
}
export class Business {
    BUSINESS_ID: string;
    ICON: string;
    ICON_BACKGROUND_COLOR: string;
    ICON_MASK_BASE_URI: string;
    NAME: string;
    PLACE_ID: string;
    REFERENCE: string;
    SCOPE: string;
    LIST_BUSINESS_CATEGORY: string[];
    BUSINESS_NICHE: string;
    VICINITY: string;
    BUSINESS_STATUS: string;
    RATING?: number;
    USER_RATINGS_TOTAL?: number;
    OPEN_NOW?: boolean;
    PRICE_LEVEL?: number;
    COMPOUND_CODE: string;
    GLOBAL_CODE: string;
    LEVEL_ID?: number;
    LEVEL_SETUP_ID?: number;
    Location: Location;
}
export class Bylaw_Complaint {
    BYLAW_COMPLAINT_ID: string;
    ROW_ID: string;
    YEAR: string;
    MONTH: string;
    COMPLAINT_CATEGORY: string;
    TYPE_OF_COMPLAINT: string;
    DATE_CREATED?: string;
    WAS_CANNABIS_INVOLVED: string;
    OFFICER_INITIATED: string;
    INFRACTION_STATUS: string;
    NEIGHBOURHOOD_ID: string;
    NEIGHBOURHOOD: string;
    FULL_NAME_OF_STREET: string;
    COUNT: string;
    LEVEL_ID?: number;
    LEVEL_SETUP_ID?: number;
    Location: Location;
}
export class Camera_Lines {
    Camera: Surveillance_Camera_Content;
    LineSets: Get_Line_Sets_Response[];
}
export class Change_Video_ai_instance_Password_Response {
    SUCCESSFUL_PASSWORD_CHANGE: boolean;
    IS_FORCE_CONNECTION: boolean;
    RESPONSE_MESSAGE: string;
}
export class Characteristic {
    PERCENTAGE?: number;
    CHARACTERISTIC: string;
}
export class Comparison_Data {
    LIST_DISTRICT_KPI_DATA_DWELL_TIME: District_kpi_data[];
    LIST_DISTRICT_KPI_DATA_NUMBER_OF_VISITORS: District_kpi_data[];
    LIST_DISTRICT_BUSINESS_COUNT: Business[];
    LIST_AREA_KPI_DATA_DWELL_TIME: Area_kpi_data[];
    LIST_AREA_KPI_DATA_NUMBER_OF_VISITORS: Area_kpi_data[];
    LIST_AREA_BUSINESS_COUNT: Business[];
    LIST_SITE_KPI_DATA_DWELL_TIME: Site_kpi_data[];
    LIST_SITE_KPI_DATA_NUMBER_OF_VISITORS: Site_kpi_data[];
    LIST_SITE_BUSINESS_COUNT: Business[];
}
export class Contour {
    X: number;
    Y: number;
}
export class Correlation_method {
    CORRELATION_METHOD_ID?: number;
    NAME: string;
    DESCRIPTION: string;
    EQUATION_URL: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
}
export class Data {
    NAME: string;
    TYPE: string;
    VALUE: string;
}
export class Data_point {
    LIST_LABEL: string[];
    LIST_DATASET: Dataset[];
}
export class Data_Settings {
    DATA_RETENTION_PERIOD?: number;
    TICKET_DURATION_IN_MINUTES?: number;
    Params_Edit_Organization_log_config_List: Params_Edit_Organization_log_config_List;
}
export class Data_source {
    DATA_SOURCE_ID?: number;
    NAME: string;
    API_URL: string;
    MIN_DWELL_TIME_IN_MINUTES?: number;
    MAX_DWELL_TIME_IN_MINUTES?: number;
    DATA_SOURCE_AUTHENTICATION_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Data_source_authentication: Data_source_authentication;
}
export class Data_source_authentication {
    DATA_SOURCE_AUTHENTICATION_ID?: number;
    AUTH_ENDPOINT: string;
    AUTH_TYPE_SETUP_ID?: number;
    USERNAME: string;
    PASSWORD: string;
    API_KEY: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
}
export class Dataset {
    LABEL: string;
    LIST_POINT: number[];
    DATA_LEVEL_SETUP_ID?: number;
}
export class Default_chart_color {
    DEFAULT_CHART_COLOR_ID?: number;
    DEFAULT_SETTINGS_ID?: number;
    COLOR: string;
    DATA_LEVEL_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Default_settings: Default_settings;
    Data_level_setup: Setup;
}
export class Default_settings {
    DARK_RECTANGLE_LOGO_URL: string;
    DARK_SQUARE_LOGO_URL: string;
    LIGHT_RECTANGLE_LOGO_URL: string;
    LIGHT_SQUARE_LOGO_URL: string;
    ORGANIZATION_FAVICON_URL: string;
    DEFAULT_SETTINGS_ID?: number;
    PLATFORM_PRIMARY: string;
    PLATFORM_BUTTON: string;
    DATA_RETENTION_PERIOD?: number;
    TICKET_DURATION_IN_MINUTES?: number;
    OTP_TTL_IN_SECONDS?: number;
    MAPBOX_GL_TOKEN: string;
    GOOGLE_MAP_API_TOKEN: string;
    TELUS_REQUEST_ID: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    List_Default_chart_color: Default_chart_color[];
    List_Default_settings_image: Default_settings_image[];
}
export class Default_settings_image {
    IMAGE_GCP_URL: string;
    DEFAULT_SETTINGS_IMAGE_ID?: number;
    DEFAULT_SETTINGS_ID?: number;
    IMAGE_NAME: string;
    IMAGE_EXTENSION: string;
    IMAGE_TYPE_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Default_settings: Default_settings;
    Image_type_setup: Setup;
}
export class Delete_Area_Kpi_Data_By_Where {
    AREA_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Demographic_Data {
    TIME_BUCKET_SIZE?: number;
    END_TIME?: string;
    REQUEST_ID: string;
    START_TIME?: string;
    LIST_STUDY_ZONE: Study_zone[];
    STATUS: string;
}
export class Dimension {
    DIMENSION_ID?: number;
    NAME: string;
    DIMENSION_ICON: string;
    DIMENSION_ORDER?: number;
    ICON_URL: string;
    LATEST_DATA_CREATION_DATE: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    List_Kpi: Kpi[];
    List_Report: Report[];
}
export class Dimension_chart_configuration {
    DIMENSION_CHART_CONFIGURATION_ID: string;
    DIMENSION_ID?: number;
    POSITION_SETUP_ID?: number;
    CHART_ORDER?: number;
    LIST_SETTING: Setting[];
}
export class Dimension_ID_By_Level_ID {
    LEVEL_ID?: number;
    LIST_DIMENSION_ID: number[];
}
export class Dimension_index {
    RECORD_DATE: string;
    DIMENSION_METADATA: Dimension_metadata;
    VALUE: number;
}
export class Dimension_index_By_Level {
    LEVEL_ID?: number;
    LIST_DIMENSION_INDEX: Dimension_index[];
}
export class Dimension_Index_With_Simple_Upper_Level {
    FATHER_UPPER_LEVEL: Upper_Level;
    GRANDFATHER_UPPER_LEVEL: Upper_Level;
    LIST_UPPER_LEVEL_DIMENSION_INDEX: Dimension_index[];
    LIST_SELECTED_LEVEL_DIMENSION_INDEX: Dimension_index[];
}
export class Dimension_metadata {
    DIMENSION_ID: number;
    LEVEL_ID: number;
    LEVEL_SETUP_ID: number;
}
export class District {
    List_Area: Area[];
    DISTRICT_ID?: number;
    REGION_ID?: number;
    TOP_LEVEL_ID?: number;
    NAME: string;
    LOCATION: string;
    AREA?: number;
    UNIT: string;
    SCALE?: number;
    ROTATIONX?: number;
    ROTATIONY?: number;
    ROTATIONZ?: number;
    GLTF_LATITUDE?: number;
    GLTF_LONGITUDE?: number;
    CENTER_LATITUDE?: number;
    CENTER_LONGITUDE?: number;
    RADIUS_IN_METERS?: number;
    IMAGE_URL: string;
    LOGO_URL: string;
    SOLID_GLTF_URL: string;
    AREA_COLOR: string;
    BORDER_COLOR: string;
    STUDY_ZONE_NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Region: Region;
    Top_level: Top_level;
    List_District_view: District_view[];
}
export class District_kpi {
    DISTRICT_KPI_ID?: number;
    DISTRICT_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    District: District;
    Organization_data_source_kpi: Organization_data_source_kpi;
}
export class District_kpi_data {
    RECORD_DATE: string;
    DISTRICT_METADATA: District_metadata;
    VALUE: number;
    VALUE_PER_SQM?: number;
    VALUE_NAME: string;
}
export class District_Kpi_Dialog_Data {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    KPI_ID?: number;
    TITLE: string;
    KPI_DATA: Data_point;
}
export class District_kpi_user_access {
    DISTRICT_KPI_USER_ACCESS_ID?: number;
    USER_ID?: number;
    DISTRICT_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    District: District;
    Organization_data_source_kpi: Organization_data_source_kpi;
    User: User;
}
export class District_metadata {
    DISTRICT_ID: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID: number;
    CATEGORY: string;
}
export class District_view {
    DISTRICT_VIEW_ID?: number;
    DISTRICT_ID?: number;
    VIEW_TYPE_SETUP_ID?: number;
    PITCH?: number;
    BEARING?: number;
    ZOOM?: number;
    LATITUDE?: number;
    LONGITUDE?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    District: District;
    View_type_setup: Setup;
}
export class Districtnex_module {
    DISTRICTNEX_MODULE_ID?: number;
    NAME: string;
    DISPLAY_ORDER?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
}
export class EngineConfig {
    PluginConfig: PluginConfig;
    EngineModelConfigList: EngineModelConfigList[];
}
export class EngineModelConfigList {
    Type: string;
    Confidence: number;
    MinObjSize: number;
    MaxObjSize: number;
    Enabled: boolean;
}
export class EngineProfile {
    CreateDate: string;
    UpdateDate: string;
    EngineProfileId: number;
    Name: string;
    EngineConfig: EngineConfig;
    IsDefault: boolean;
    Description: Object;
    EngineModelId: number[];
    AinvrId: number;
}
export class Entity {
    ENTITY_ID?: number;
    SITE_ID?: number;
    AREA_ID?: number;
    DISTRICT_ID?: number;
    REGION_ID?: number;
    TOP_LEVEL_ID?: number;
    ENTITY_TYPE_SETUP_ID?: number;
    NAME: string;
    NUMBER_OF_FLOORS?: number;
    GLA?: number;
    GLA_UNIT: string;
    AREA?: number;
    UNIT: string;
    SCALE?: number;
    ROTATIONX?: number;
    ROTATIONY?: number;
    ROTATIONZ?: number;
    GLTF_LATITUDE?: number;
    GLTF_LONGITUDE?: number;
    CENTER_LATITUDE?: number;
    CENTER_LONGITUDE?: number;
    RADIUS_IN_METERS?: number;
    IMAGE_URL: string;
    SOLID_GLTF_URL: string;
    POPUL_ALT_X?: number;
    POPUP_ALT_Y?: number;
    POPUP_ALT_Z?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Area: Area;
    District: District;
    Region: Region;
    Site: Site;
    Top_level: Top_level;
    Entity_type_setup: Setup;
    List_Floor: Floor[];
    List_Entity_view: Entity_view[];
}
export class Entity_Data_point {
    SEVERITY_TYPE_SETUP_ID?: number;
    INCIDENT_CATEGORY_SETUP_ID?: number;
    LIST_LABEL: string[];
    LIST_DATASET: Dataset[];
}
export class Entity_Incidents {
    LIST_FIRE_ALARM_INCIDENT_WITH_COUNT: Incident_With_Count;
    LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT: Incident_With_Count;
    LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT: Incident_With_Count;
    LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT: Incident_With_Count;
    LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT: Incident_With_Count;
    LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT: Incident_With_Count;
}
export class Entity_kpi {
    ENTITY_KPI_ID?: number;
    ENTITY_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Entity: Entity;
    Organization_data_source_kpi: Organization_data_source_kpi;
}
export class Entity_kpi_data {
    RECORD_DATE: string;
    ENTITY_METADATA: Entity_metadata;
    VALUE: number;
    VALUE_PER_SQM?: number;
    VALUE_NAME: string;
}
export class Entity_Kpi_Dialog_Data {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    KPI_ID?: number;
    TITLE: string;
    LIST_KPI_DATA: Entity_Data_point[];
}
export class Entity_kpi_user_access {
    ENTITY_KPI_USER_ACCESS_ID?: number;
    USER_ID?: number;
    ENTITY_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Entity: Entity;
    Organization_data_source_kpi: Organization_data_source_kpi;
    User: User;
}
export class Entity_metadata {
    ENTITY_ID: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID: number;
    CATEGORY: string;
}
export class Entity_share_data {
    ENTITY_SHARE_DATA_ID: string;
    SHARING_USER_NAME: string;
    ORGANIZATION_ID?: number;
    UNIQUE_STRING: string;
    FILTER_START_DATE?: string;
    FILTER_END_DATE?: string;
    ENUM_TIMESPAN: Enum_Timespan;
    ENTITY_ID?: number;
    FLOOR_ID?: number;
    IS_CAMERA_ONE_ON?: boolean;
    IS_CAMERA_TWO_ON?: boolean;
    IS_CAMERA_THREE_ON?: boolean;
    LIST_FLOOR_ASSET_WIFI_SIGNAL: Wifi_signal[];
    LIST_FLOOR_CHART_WIFI_SIGNAL: Wifi_signal[];
    LIST_SUMMARY_WIFI_SIGNAL: Wifi_signal[];
    LIST_SUMMARY_SPACE_ASSET_ID: number[];
    LIST_WIFI_SIGNAL_ALERT_ID: string[];
    DIMENSION_ID?: number;
    IS_ALERT: boolean;
    INCIDENT_CATEGORY_SETUP_ID?: number;
    LIST_INCIDENT_ID: string[];
    LIST_FLOOR_DIMENSION_INDEX: Dimension_index_By_Level[];
    ENTITY_DIMENSION_INDEX: Dimension_index_By_Level;
    LIST_ENTITY_LEVEL_DIMENSION_WITH_STATUS: Level_Dimension_with_Status[];
    IS_ENTITY_SUMMARY_DRAWER_VISIBLE?: boolean;
}
export class Entity_share_view_data {
    SHARING_USER_NAME: string;
    FILTER_START_DATE?: string;
    FILTER_END_DATE?: string;
    ENUM_TIMESPAN: Enum_Timespan;
    Entity: Entity;
    FLOOR_ID?: number;
    IS_CAMERA_ONE_ON?: boolean;
    IS_CAMERA_TWO_ON?: boolean;
    IS_CAMERA_THREE_ON?: boolean;
    List_Floor_asset_Wifi_signal: Wifi_signal[];
    List_Floor_chart_Wifi_signal: Wifi_signal[];
    List_Summary_Wifi_signal: Wifi_signal[];
    List_Summary_Space_asset: Space_asset[];
    List_Wifi_signal_alert: Wifi_signal_alert[];
    DIMENSION_ID?: number;
    IS_ALERT: boolean;
    INCIDENT_CATEGORY_SETUP_ID?: number;
    List_Incident: Incident[];
    List_Floor_kpi_data: Floor_Kpi_Dialog_Data[];
    List_Entity_kpi_data: Entity_Kpi_Dialog_Data[];
    List_Floor_Dimension_index: Dimension_index_By_Level[];
    List_Kpi_chart_configuration: Kpi_chart_configuration[];
    Entity_Dimension_index: Dimension_index_By_Level;
    List_Dimension_chart_configuration: Dimension_chart_configuration[];
    List_Setup_category: Setup_category[];
    List_Entity_Level_Dimension_with_Status: Level_Dimension_with_Status[];
    IS_ENTITY_SUMMARY_DRAWER_VISIBLE?: boolean;
}
export class Entity_view {
    ENTITY_VIEW_ID?: number;
    ENTITY_ID?: number;
    VIEW_TYPE_SETUP_ID?: number;
    PITCH?: number;
    BEARING?: number;
    ZOOM?: number;
    LATITUDE?: number;
    LONGITUDE?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Entity: Entity;
    View_type_setup: Setup;
}
export class Ext_study_zone {
    EXT_STUDY_ZONE_ID?: number;
    NAME: string;
    LATITUDE?: number;
    LONGITUDE?: number;
    AREA_COLOR: string;
    BORDER_COLOR: string;
    STUDY_ZONE_NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
}
export class Ext_study_zone_With_Count {
    EXT_STUDY_ZONE: Ext_study_zone;
    COUNT?: number;
}
export class Face_Key_Response {
    FaceKeyId: number;
    SceneId: number;
    CameraId: number;
    Datetime: string;
    File: string;
    Position: string;
    Confidence: number;
    FootageId?: number;
    Age: number;
    AgeGroup: string;
    Gender: string;
}
export class Face_Key_Response_List {
    FACET_KEY_RESPONSE_LIST: Face_Key_Response[];
    TOTAL_ELEMENTS: number;
}
export class Face_Target_Key_Response {
    CreateDate: string;
    UpdateDate: string;
    FaceTargetKeyId: string;
    File: string;
    Feature: number[];
    Similarity: number;
    AinvrId: number;
}
export class Face_Target_Response_Category {
    AinvrId: number;
    CreateDate: string;
    FaceCategoryId: string;
    Name: string;
    UpdateDate: string;
}
export class Fetch_Face_Target_Response_Content {
    CreateDate: string;
    UpdateDate: string;
    FaceTargetId: string;
    Category: Face_Target_Response_Category;
    Name: string;
    Gender: string;
    BirthYear?: number;
    DriverLicenseNumber: string;
    Description: string;
    Keys: Face_Target_Key_Response[];
    Deleted: boolean;
    AinvrId: number;
}
export class Fetch_Face_Targets_Response {
    TotalElements: number;
    TotalPages: number;
    First: boolean;
    Sort: Sort;
    NumberOfElements: number;
    Last: boolean;
    Pageable: Pageable;
    Size: number;
    Content: Fetch_Face_Target_Response_Content[];
    Number: number;
    Empty: boolean;
}
export class Fetch_Facial_Recognition_Reponse {
    TotalElements: number;
    TotalPages: number;
    First: boolean;
    Sort: Sort;
    NumberOfElements: number;
    Last: boolean;
    Pageable: Pageable;
    Size: number;
    Content: Fetch_Facial_Recognition_Response_Content[];
    Number: number;
    Empty: boolean;
}
export class Fetch_Facial_Recognition_Response_Content {
    FaceMatchId: number;
    isVpn: boolean;
    isLoaded: boolean;
    Datetime: string;
    FaceKey: Face_Key_Response;
    FaceTarget: Fetch_Face_Target_Response_Content;
    FaceTargetKey: Face_Target_Key_Response;
    Similarity: number;
    AinvrId: number;
}
export class Fetch_License_Plate_Recognition_Response {
    List_Fetch_License_Plate_Recognition_Response_Content: Fetch_License_Plate_Recognition_Response_Content[];
    TotalElements: number;
}
export class Fetch_License_Plate_Recognition_Response_Content {
    isVpn: boolean;
    isLoaded: boolean;
    LicensePlateId: number;
    CameraId: number;
    FootageId?: number;
    Target: Fetch_License_Plate_Targets_Response_Content;
    SceneId: number;
    Datetime: string;
    Type: string;
    Characters: string;
    Confidence: number;
    X: number;
    Y: number;
    W: number;
    H: number;
    File: string;
    Property: string;
    Make: string;
    Model: string;
    VehicleType: string;
    Country: string;
    State: string;
    Modified: boolean;
    AinvrId: number;
}
export class Fetch_License_Plate_Targets_Response {
    Content: Fetch_License_Plate_Targets_Response_Content[];
    Pageable: Pageable;
    Last: boolean;
    TotalPages: number;
    TotalElements: number;
    Sort: Sort;
    Size: number;
    Number: number;
    First: boolean;
    NumberOfElements: number;
    Empty: boolean;
}
export class Fetch_License_Plate_Targets_Response_Content {
    CreateDate: string;
    UpdateDate: string;
    LicensePlateTargetId: string;
    Category: License_Plate_Category;
    PlateNumber: string;
    Description: string;
    VehicleOwner: string;
    Address: string;
    RegistrationDate: string;
    AinvrId: number;
}
export class Fetch_Scenes_Api_Response {
    Content: Fetch_Scenes_Response_Content[];
    Pageable: Pageable;
    Last: boolean;
    TotalPages: number;
    TotalElements: number;
    NumberOfElements: number;
    First: boolean;
    Sort: Sort;
    Size: number;
    Number: number;
    Empty: boolean;
}
export class Fetch_Scenes_Response {
    Fetch_Scenes_Api_Response: Fetch_Scenes_Api_Response;
    IS_ERROR: boolean;
    ERROR_MESSAGE: string;
}
export class Fetch_Scenes_Response_Content {
    SceneId: number;
    isLoaded: boolean;
    isVpn: boolean;
    Datetime: string;
    CameraId: number;
    FootageId: Object;
    File: string;
    Source: string;
    CameraName: string;
    Description: Object;
    Latitude: Object;
    Longitude: Object;
    FloorPlanId: Object;
    FloorPlanX: Object;
    FloorPlanY: Object;
    FloorPlanAngle: Object;
    Thumbnail: string;
    AinvrId: number;
}
export class Floor {
    FLOOR_ID?: number;
    ENTITY_ID?: number;
    FLOOR_NUMBER?: number;
    SHELL_GLTF_URL: string;
    CLIPPED_GLTF_URL: string;
    ADVANCED_GLTF_URL: string;
    AREA?: number;
    UNIT: string;
    NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Entity: Entity;
    List_Space: Space[];
}
export class Floor_Data_point {
    SEVERITY_TYPE_SETUP_ID?: number;
    INCIDENT_CATEGORY_SETUP_ID?: number;
    LIST_LABEL: string[];
    LIST_DATASET: Dataset[];
}
export class Floor_kpi_data {
    RECORD_DATE: string;
    FLOOR_METADATA: Floor_metadata;
    VALUE: number;
    VALUE_PER_SQM?: number;
    VALUE_NAME: string;
}
export class Floor_Kpi_Dialog_Data {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    KPI_ID?: number;
    TITLE: string;
    LIST_KPI_DATA: Floor_Data_point[];
    WIFI_SIGNAL_LIST: Wifi_signal[];
    WIFI_SIGNAL_ALERT_LIST: Wifi_signal_alert[];
}
export class Floor_metadata {
    FLOOR_ID: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID: number;
    CATEGORY: string;
}
export class Generate_Logs_Excel_Response {
    EXCEL_URL: string;
    REPORT_NAME: string;
}
export class Geo_Location {
    LATITUDE?: number;
    LONGITUDE?: number;
}
export class GeoData {
    GEODATA_ID: string;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    LEVEL_ID?: number;
    LEVEL_SETUP_ID?: number;
    Location: Location;
    DATE_START?: string;
    DATE_END?: string;
    DATA_LIST: Data[];
}
export class Get_Countings_Response {
    MEASURE: string;
    DATETIME: string;
    TYPE: string;
    OBJECTIN: number;
    OBJECTOUT: number;
    OCCUPANCY: number;
}
export class Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result {
    LIST_ENTITY: Entity[];
}
export class Get_Line_Sets_Response {
    CreateDate: string;
    UpdateDate: string;
    LineSetId: number;
    CameraId: number;
    Name: string;
    Type: string;
    Line1: string;
    Line2: string;
    AiNvrId: number;
}
export class Incident {
    INCIDENT_ID: string;
    SPACE_ASSET_ID?: number;
    SPACE_ID?: number;
    FLOOR_ID?: number;
    ENTITY_ID?: number;
    SITE_ID?: number;
    SEVERITY_SETUP_ID?: number;
    DIMENSION_ORDER?: number;
    CREATED_TIME?: string;
    ASSIGNED_TIME?: string;
    CLOSED_TIME?: string;
    Geo_Location: Geo_Location;
    Sustainability_Incident: Sustainability_Incident;
    Security_Incident: Security_Incident;
    Mobility_Incident: Mobility_Incident;
    Living_Incident: Living_Incident;
    GEO_LOCATION: Geo_Location;
    SCENE_ID?: number;
    VIDEO_AI_INSTANCE_ID?: number;
    CAMERA: Surveillance_Camera_Content;
    BLACKLISTED_PERSON_NAME: string;
    BLACKLISTED_LICENSE_PLATE: string;
    BLACKLISTED_LICENSE_FILE_URL: string;
    SUSTAINABILITY_INCIDENT: Sustainability_Incident;
    SECURITY_INCIDENT: Security_Incident;
    MOBILITY_INCIDENT: Mobility_Incident;
    LIVING_INCIDENT: Living_Incident;
}
export class Incident_With_Count {
    COUNT: number;
    List_Incident: Incident[];
}
export class Initial_Data {
    LIST_DIMENSION_CHART_CONFIGURATION: Dimension_chart_configuration[];
    LIST_KPI_CHART_CONFIGURATION: Kpi_chart_configuration[];
    LIST_SPECIALIZED_CHART_CONFIGURATION: Specialized_chart_configuration[];
    LIST_SETUP_CATEGORY: Setup_category[];
    LIST_USER_DISTRICT_NEX_MODULE: User_districtnex_module[];
    LIST_ORGANIZATION_COLOR_SCHEME: Organization_color_scheme[];
    LIST_NICHE_CATEGORIES: Niche_categories[];
    USER_THEME: User_theme;
    LIST_ORGANIZATION_DATA_WITH_ACCESSIBLE_TOP_LEVEL_DATA: Organization_Data_with_Accessible_Top_Level_Data[];
}
export class Initial_Districtnex_Admin_Settings {
    BUILD_NUMBER: string;
    Default_settings: Default_settings;
}
export class Initial_Districtnex_UI_Settings {
    BUILD_NUMBER: string;
    Default_settings: Default_settings;
}
export class Job {
    JOB_ID: string;
    JOB_REQUEST_ID: string;
    REQUEST_SETUP_ID?: number;
    DWELL_TIME_BUCKET?: number;
    SITE_ID_LIST: number[];
    MIN_DWELL_TIME?: number;
    MAX_DWELL_TIME?: number;
    IS_EXCLUDE_NON_WORKERS?: boolean;
    START_DATE?: string;
    END_DATE?: string;
}
export class Kpi {
    KPI_ID?: number;
    DIMENSION_ID?: number;
    SETUP_CATEGORY_ID?: number;
    NAME: string;
    UNIT: string;
    KPI_TYPE_SETUP_ID?: number;
    HAS_CORRELATION: boolean;
    IS_TRENDLINE: boolean;
    IS_DECIMAL_VALUE: boolean;
    HAS_SQM: boolean;
    IS_BY_SEVERITY: boolean;
    IS_ADDITIVE_DATA: boolean;
    MINIMUM_VALUE?: number;
    MAXIMUM_VALUE?: number;
    LATEST_DATA_CREATION_DATE: string;
    IS_AUTO_GENERATE: boolean;
    MIN_DATA_LEVEL_SETUP_ID?: number;
    MAX_DATA_LEVEL_SETUP_ID?: number;
    IS_EXTERNAL: boolean;
    HAS_ALERTS: boolean;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Dimension: Dimension;
    Kpi_type_setup: Setup;
    Max_data_level_setup: Setup;
    Min_data_level_setup: Setup;
    Setup_category: Setup_category;
}
export class Kpi_chart_configuration {
    KPI_CHART_CONFIGURATION_ID: string;
    KPI_ID?: number;
    POSITION_SETUP_ID?: number;
    CHART_ORDER?: number;
    LIST_SETTING: Setting[];
    LIST_ACTION_BUTTON: Action_Button[];
}
export class Kpi_Dialog_Data_By_Area {
    AREA_ID?: number;
    LIST_AREA_KPI_DIALOG_DATA: Area_Kpi_Dialog_Data[];
}
export class Kpi_Dialog_Data_By_District {
    DISTRICT_ID?: number;
    LIST_DISTRICT_KPI_DIALOG_DATA: District_Kpi_Dialog_Data[];
}
export class Kpi_Dialog_Data_By_Entity {
    ENTITY_ID?: number;
    LIST_ENTITY_KPI_DIALOG_DATA: Entity_Kpi_Dialog_Data[];
}
export class Kpi_Dialog_Data_By_Site {
    SITE_ID?: number;
    LIST_SITE_KPI_DIALOG_DATA: Site_Kpi_Dialog_Data[];
}
export class Kpi_Value_By_Date {
    RECORD_DATE?: string;
    VALUE?: number;
}
export class Kpi_Value_By_Direction {
    DIRECTION: string;
    LABEL: string;
    LIST_KPI_VALUE_BY_DATE: Kpi_Value_By_Date[];
}
export class Level_Data {
    GEOJSON_SRC: string;
    DATA_LEVEL_SETUP_ID?: number;
    UPPER_LEVEL: Upper_Level;
    LIST_DIMENSION_INDEX: Dimension_index[];
}
export class Level_Dimension_with_Status {
    LEVEL_ID_LIST: number[];
    DATA_LEVEL_SETUP_ID?: number;
    DIMENSION: Dimension;
    ENUM_DIMENSION_STATUS: Enum_Dimension_Status;
}
export class License_Plate_Category {
    CreateDate: string;
    UpdateDate: string;
    LicensePlateCategoryId: string;
    Name: string;
    AinvrId: number;
}
export class Living_Incident {
    CATEGORY_SETUP_ID?: number;
}
export class Location {
    type: string;
    coordinates: number[];
}
export class Log {
    User: User;
    Site: Site;
    Entity: Entity;
    Video_ai_asset: Video_ai_asset;
    LOG_ID: string;
    USER_ID?: number;
    LOG_TYPE_SETUP_ID?: number;
    ACCESS_TYPE_SETUP_ID?: number;
    ENTITY_ID?: number;
    SITE_ID?: number;
    MESSAGE: string;
    ENTRY_DATE?: string;
    ORGANIZATION_ID?: number;
    VIDEO_AI_ASSET_ID?: number;
}
export class Log_With_Count {
    COUNT: number;
    List_Log: Log[];
}
export class Metadata {
    Colors: string[];
}
export class Method_run {
    METHOD_RUN_ID?: number;
    METHOD_NAME: string;
    RUN_DATE: string;
    RUN_HOUR?: number;
    RUN_MINUTE?: number;
    RUN_SECOND?: number;
    EXECUTION_TIME?: number;
    IS_CACHED: boolean;
    METHOD_PARAMS: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    OWNER_ID?: number;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
}
export class Mobility_Incident {
    CATEGORY_SETUP_ID?: number;
}
export class Niche_categories {
    NICHE_CATEGORIES_ID: string;
    BUSINESS_NICHE: string;
    CATEGORY_LIST: string[];
    NICHE_COLOR: string;
}
export class Nvr {
    CreateDate: string;
    UpdateDate: string;
    NvrId: string;
    Brand: Brand_Api_Response;
    Name: string;
    Ip: string;
    Port: number;
    Account: string;
    Password: string;
    AinvrId: number;
}
export class Organization {
    ORGANIZATION_ID?: number;
    ORGANIZATION_NAME: string;
    ORGANIZATION_EMAIL: string;
    ORGANIZATION_PHONE_NUMBER: string;
    ORGANIZATION_ADDRESS: string;
    DATA_RETENTION_PERIOD?: number;
    TICKET_DURATION_IN_MINUTES?: number;
    ORGANIZATION_TYPE_SETUP_ID?: number;
    DATE_DELETED: string;
    MAX_NUMBER_OF_ADMINS?: number;
    MAX_NUMBER_OF_USERS?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_ACTIVE: boolean;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Organization_type_setup: Setup;
    List_User: User[];
    List_Organization_theme: Organization_theme[];
    List_Organization_color_scheme: Organization_color_scheme[];
    List_Organization_districtnex_module: Organization_districtnex_module[];
    List_Organization_image: Organization_image[];
    List_Organization_level_access: Organization_level_access[];
    List_Organization_log_config: Organization_log_config[];
    DARK_RECTANGLE_LOGO_URL: string;
    DARK_SQUARE_LOGO_URL: string;
    LIGHT_RECTANGLE_LOGO_URL: string;
    LIGHT_SQUARE_LOGO_URL: string;
    ORGANIZATION_FAVICON_URL: string;
}
export class Organization_chart_color {
    ORGANIZATION_CHART_COLOR_ID?: number;
    ORGANIZATION_COLOR_SCHEME_ID?: number;
    COLOR: string;
    DATA_LEVEL_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Organization_color_scheme: Organization_color_scheme;
    Data_level_setup: Setup;
}
export class Organization_color_scheme {
    ORGANIZATION_COLOR_SCHEME_ID?: number;
    ORGANIZATION_ID?: number;
    PLATFORM_PRIMARY: string;
    PLATFORM_BUTTON: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Organization: Organization;
    List_Organization_chart_color: Organization_chart_color[];
}
export class Organization_Data {
    ORGANIZATION_ID?: number;
    ORGANIZATION_NAME: string;
    DARK_RECTANGLE_LOGO_URL: string;
    DARK_SQUARE_LOGO_URL: string;
    LIGHT_RECTANGLE_LOGO_URL: string;
    LIGHT_SQUARE_LOGO_URL: string;
    ORGANIZATION_FAVICON_URL: string;
    LIST_ORGANIZATION_COLOR_SCHEME: Organization_color_scheme[];
    LIST_ORGANIZATION_THEME: Organization_theme[];
}
export class Organization_Data_Access {
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
    LIST_DISTRICT_KPI: District_kpi[];
    LIST_AREA_KPI: Area_kpi[];
    LIST_SITE_KPI: Site_kpi[];
    LIST_ENTITY_KPI: Entity_kpi[];
    LIST_DISTRICT: District[];
    LIST_AREA: Area[];
    LIST_SITE: Site[];
    LIST_ENTITY: Entity[];
}
export class Organization_data_source_kpi {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    DATA_SOURCE_ID?: number;
    KPI_ID?: number;
    ORGANIZATION_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Data_source: Data_source;
    Kpi: Kpi;
    Organization: Organization;
}
export class Organization_data_source_kpi_By_Level {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    LEVEL_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
}
export class Organization_data_source_kpi_ID_By_Level_ID {
    LEVEL_ID?: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE: Organization_data_source_kpi_Simple[];
}
export class Organization_data_source_kpi_List_By_Top_Level {
    LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT: Organization_data_source_kpi_ID_By_Level_ID[];
    LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA: Organization_data_source_kpi_ID_By_Level_ID[];
    LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE: Organization_data_source_kpi_ID_By_Level_ID[];
    LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY: Organization_data_source_kpi_ID_By_Level_ID[];
}
export class Organization_data_source_kpi_Simple {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    KPI_ID?: number;
}
export class Organization_Data_with_Accessible_Top_Level_Data {
    ORGANIZATION_DATA: Organization_Data;
    LIST_TOP_LEVEL_DATA: Top_Level_Data[];
}
export class Organization_districtnex_module {
    ORGANIZATION_DISTRICTNEX_MODULE_ID?: number;
    ORGANIZATION_ID?: number;
    DISTRICTNEX_MODULE_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Districtnex_module: Districtnex_module;
    Organization: Organization;
}
export class Organization_image {
    IMAGE_GCP_URL: string;
    ORGANIZATION_IMAGE_ID?: number;
    ORGANIZATION_ID?: number;
    IMAGE_NAME: string;
    IMAGE_EXTENSION: string;
    IMAGE_TYPE_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Organization: Organization;
    Image_type_setup: Setup;
}
export class Organization_level_access {
    ORGANIZATION_LEVEL_ACCESS_ID?: number;
    ORGANIZATION_ID?: number;
    LEVEL_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Organization: Organization;
    Data_level_setup: Setup;
}
export class Organization_log_config {
    ORGANIZATION_LOG_CONFIG_ID?: number;
    ORGANIZATION_ID?: number;
    LOG_TYPE_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Organization: Organization;
    Log_type_setup: Setup;
}
export class Organization_relation {
    ORGANIZATION_RELATION_ID?: number;
    PARENT_ORGANIZATION_ID?: number;
    CHILD_ORGANIZATION_ID?: number;
    USER_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    User: User;
}
export class Organization_theme {
    ORGANIZATION_THEME_ID?: number;
    ORGANIZATION_ID?: number;
    THEME_NAME: string;
    THEME_CLASS: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Organization: Organization;
}
export class Output {
    COUNT?: number;
    OUTPUT_GEOID: string;
    REQUEST_ID: string;
}
export class Pageable {
    Sort: Sort;
    PageNumber: number;
    PageSize: number;
    Offset: number;
    Unpaged: boolean;
    Paged: boolean;
}
export class Performance_object {
    Entity: Entity;
    Floor: Floor;
    Space: Space;
    Space_asset: Space_asset;
    value?: number;
}
export class PluginConfig {
    MotionDetectSize: number;
    MotionDetectParam: number;
    FaceRecognitionSimilarityThreshold: number;
    FaceRecognitionMinSize: number;
    EnableFrontalFaceDetection: boolean;
    LicensePlateConfidenceThreshold: number;
    LicensePlateMinSize: number;
    MakeModelConfidenceThreshold: number;
    MakeModelMinSize: number;
    AgeGenderMinSize: number;
    EnableAgeGenderQualityDetection: boolean;
}
export class Primary_Authentication_Response {
    EMAIL: string;
    USER_ID?: number;
    TTL_IN_SECONDS?: number;
}
export class Public_Event {
    PUBLIC_EVENT_ID: string;
    TITLE: string;
    DATE_AND_TIME: string;
    START_TIME?: string;
    END_TIME?: string;
    CITY_OR_TOWN: string;
    NEIGHBOURHOOD_ID: string;
    NEIGHBOURHOOD: string;
    WHERE: string;
    COST: string;
    EVENT_CATEGORY: string;
    EVENT_TYPE: string;
    EVENT_URL: string;
    EVENT_VENUE: string;
    EVENT_EXTERNAL_ID: string;
    WHERE_TO_PURCHASE_TICKETS: string;
    TICKETS_PHONE: string;
    CATEGORY_CALENDAR: string;
    WEB_LINK: string;
    PUBLIC_ENGAGEMENT_CATEGORY: string;
    SHORT_DESCRIPTION: string;
    PROJECT_NAME: string;
    ADDITIONAL_INFORMATION: string;
    NOTES_1: string;
    NOTES_2: string;
    LEVEL_ID?: number;
    LEVEL_SETUP_ID?: number;
    Location: Location;
}
export class Region {
    REGION_ID?: number;
    TOP_LEVEL_ID?: number;
    NAME: string;
    LOCATION: string;
    AREA?: number;
    UNIT: string;
    IMAGE_URL: string;
    LOGO_URL: string;
    AREA_COLOR: string;
    BORDER_COLOR: string;
    STUDY_ZONE_NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Top_level: Top_level;
}
export class Region_view {
    REGION_VIEW_ID?: number;
    REGION_ID?: number;
    VIEW_TYPE_SETUP_ID?: number;
    PITCH?: number;
    BEARING?: number;
    ZOOM?: number;
    LATITUDE?: number;
    LONGITUDE?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Region: Region;
    View_type_setup: Setup;
}
export class Removed_extrusion {
    REMOVED_EXTRUSION_ID?: number;
    EXTRUSION_IDENTIFIER: string;
    LEVEL_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Data_level_setup: Setup;
}
export class Report {
    REPORT_ID?: number;
    DIMENSION_ID?: number;
    FILE_NAME: string;
    FILE_EXTENSION: string;
    FILE_SIZE: string;
    IDENTIFIER_TOKEN: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Dimension: Dimension;
}
export class Report_Details {
    LIST_KPI_DIALOG_DATA_BY_DISTRICT: Kpi_Dialog_Data_By_District[];
    LIST_KPI_DIALOG_DATA_BY_AREA: Kpi_Dialog_Data_By_Area[];
    LIST_KPI_DIALOG_DATA_BY_SITE: Kpi_Dialog_Data_By_Site[];
    LIST_KPI_DIALOG_DATA_BY_ENTITY: Kpi_Dialog_Data_By_Entity[];
}
export class RoiContour {
    Contour: Contour[];
}
export class Scene_Details {
    SceneId: number;
    CameraId: number;
    FootageId: Object;
    Source: string;
    Datetime: string;
    File: string;
    FrameIndex: number;
    Camera: Surveillance_Camera_Content;
    Latitude: Object;
    Longitude: Object;
    HashtagId: Object[];
    Hashtags: Object[];
    AinvrId: number;
}
export class Scene_Info {
    SCENE_DETAILS: Scene_Details;
    SCENE_OBJECT_LIST: Scene_Object[];
}
export class Scene_Object {
    SceneObjectId: number;
    ObjectType: string;
    CameraId: number;
    Datetime: string;
    X: number;
    Y: number;
    W: number;
    H: number;
    Confidence: number;
    Metadata: Metadata;
    AinvrId: number;
}
export class Schedule {
    Weekdays: Object[];
    Forever: boolean;
}
export class Search_Face_Target_Key_Response {
    FaceTarget: Fetch_Face_Target_Response_Content;
    FaceTargetKey: Face_Target_Key_Response;
}
export class Search_Face_Target_Key_Response_List {
    SEARCH_FACE_TARGET_KEY_RESPONSE_LIST: Search_Face_Target_Key_Response[];
    TOTAL_ELEMENTS: number;
}
export class Security_Incident {
    CATEGORY_SETUP_ID?: number;
}
export class Send_Otp_Response {
    EMAIL: string;
    USER_ID?: number;
    TTL_IN_SECONDS?: number;
}
export class Setting {
    CHART_SETTINGS: string;
    SERIES_SETTINGS: string;
    ICON: string;
}
export class Setup {
    SETUP_ID?: number;
    SETUP_CATEGORY_ID?: number;
    IS_SYSTEM: boolean;
    IS_DELETEABLE: boolean;
    IS_UPDATEABLE: boolean;
    IS_DELETED: boolean;
    IS_VISIBLE: boolean;
    DISPLAY_ORDER?: number;
    VALUE: string;
    DESCRIPTION: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    OWNER_ID?: number;
    Setup_category: Setup_category;
}
export class Setup_category {
    SETUP_CATEGORY_ID?: number;
    SETUP_CATEGORY_NAME: string;
    DESCRIPTION: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    List_Setup: Setup[];
}
export class Share_file {
    SHARE_FILE_ID?: number;
    USER_ID?: number;
    FILE_NAME: string;
    FILE_EXTENSION: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    User: User;
}
export class Site {
    List_Entity: Entity[];
    SITE_ID?: number;
    AREA_ID?: number;
    DISTRICT_ID?: number;
    REGION_ID?: number;
    TOP_LEVEL_ID?: number;
    NAME: string;
    LOCATION: string;
    AREA?: number;
    UNIT: string;
    SCALE?: number;
    ROTATIONX?: number;
    ROTATIONY?: number;
    ROTATIONZ?: number;
    GLTF_LATITUDE?: number;
    GLTF_LONGITUDE?: number;
    CENTER_LATITUDE?: number;
    CENTER_LONGITUDE?: number;
    RADIUS_IN_METERS?: number;
    IMAGE_URL: string;
    LOGO_URL: string;
    SOLID_GLTF_URL: string;
    AREA_COLOR: string;
    BORDER_COLOR: string;
    STUDY_ZONE_NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Area: Area;
    District: District;
    Region: Region;
    Top_level: Top_level;
    List_Site_view: Site_view[];
    List_Site_field_logo: Site_field_logo[];
}
export class Site_field_logo {
    SITE_FIELD_LOGO_ID?: number;
    SITE_ID?: number;
    LONGITUDE?: number;
    LATITUDE?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Site: Site;
}
export class Site_kpi {
    SITE_KPI_ID?: number;
    SITE_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Organization_data_source_kpi: Organization_data_source_kpi;
    Site: Site;
}
export class Site_kpi_data {
    RECORD_DATE: string;
    SITE_METADATA: Site_metadata;
    VALUE: number;
    VALUE_PER_SQM?: number;
    VALUE_NAME: string;
}
export class Site_Kpi_Dialog_Data {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    KPI_ID?: number;
    TITLE: string;
    KPI_DATA: Data_point;
}
export class Site_kpi_user_access {
    SITE_KPI_USER_ACCESS_ID?: number;
    USER_ID?: number;
    SITE_ID?: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Organization_data_source_kpi: Organization_data_source_kpi;
    Site: Site;
    User: User;
}
export class Site_metadata {
    SITE_ID: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID: number;
    CATEGORY: string;
}
export class Site_view {
    SITE_VIEW_ID?: number;
    SITE_ID?: number;
    VIEW_TYPE_SETUP_ID?: number;
    PITCH?: number;
    BEARING?: number;
    ZOOM?: number;
    LATITUDE?: number;
    LONGITUDE?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Site: Site;
    View_type_setup: Setup;
}
export class Sites_and_Entities {
    SITES: Site[];
    ENTITIES: Entity[];
}
export class Sort {
    Unsorted: boolean;
    Sorted: boolean;
    Empty: boolean;
}
export class Space {
    List_Space_asset: Space_asset[];
    SPACE_ID?: number;
    FLOOR_ID?: number;
    NAME: string;
    AREA?: number;
    UNIT: string;
    OCCUPANT_LOAD_FACTOR?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Floor: Floor;
    HAS_VIDEO_AI_ASSETS: boolean;
}
export class Space_asset {
    SPACE_ASSET_ID?: number;
    SPACE_ID?: number;
    ASSET_ID?: number;
    EXTERNAL_ID: string;
    IS_MERAKI_WIFI_SIGNAL: boolean;
    CUSTOM_NAME: string;
    POSITION_X?: number;
    POSITION_Y?: number;
    POSITION_Z?: number;
    SCALE_MULTIPLIER?: number;
    ROTATE_X?: number;
    ROTATE_Y?: number;
    ROTATE_Z?: number;
    ASSET_ICON: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Asset: Asset;
    Space: Space;
    List_Video_ai_asset: Video_ai_asset[];
    List_Space_asset_energy_incident: Incident[];
    List_Space_asset_security_incident: Incident[];
}
export class Space_kpi_data {
    RECORD_DATE: string;
    SPACE_METADATA: Space_metadata;
    VALUE: number;
    VALUE_PER_SQM?: number;
    VALUE_NAME: string;
}
export class Space_metadata {
    SPACE_ID: number;
    FLOOR_ID: number;
    ORGANIZATION_DATA_SOURCE_KPI_ID: number;
    CATEGORY: string;
}
export class Specialized_chart_configuration {
    SPECIALIZED_CHART_CONFIGURATION_ID: string;
    MODULE: string;
    NAME: string;
    TYPE: string;
    CHART_SETTINGS: string;
    SERIES_SETTINGS: string;
}
export class Stream_Data {
    List_Search_type: string[];
    List_Video_ai_asset: Video_ai_asset[];
}
export class Study_zone {
    List_Bucket: Bucket[];
    INPUT_GEOID: string;
    LIST_TOPIC: Topic[];
}
export class Surveillance_Camera_Content {
    CreateDate: string;
    UpdateDate: string;
    CameraId: number;
    Nvr: Object;
    NvrChannel: Object;
    Name: string;
    Ip: Object;
    Port: Object;
    Account: Object;
    Password: Object;
    Description: Object;
    StreamUrl: string;
    RoiContour: RoiContour[];
    Manufacturer: Object;
    Model: Object;
    Resolution: string;
    FrameRate?: number;
    Plugins: Object[];
    AinvrId: number;
    Protocol: string;
    EngineProfileId?: number;
    EngineProfile: EngineProfile;
    Status: string;
    Latitude: Object;
    Longitude: Object;
    GpuId: Object;
    HwDecode: Object;
    CscState: string;
    LocationType: string;
    FloorPlanId: Object;
    FloorPlanX: Object;
    FloorPlanY: Object;
    FloorPlanAngle: Object;
    EngineModels: string[];
    Resource?: number;
    Schedule: Schedule;
    CameraType: string;
    FpsType: string;
    Loop: number;
    ExternalMeta: string;
    AuthenticatedUrl: string;
}
export class Sustainability_Incident {
    CATEGORY_SETUP_ID?: number;
}
export class Top_level {
    TOP_LEVEL_ID?: number;
    NAME: string;
    LOCATION: string;
    AREA?: number;
    IMAGE_URL: string;
    LOGO_URL: string;
    AREA_COLOR: string;
    BORDER_COLOR: string;
    STUDY_ZONE_NAME: string;
    LOW_THRESHOLD?: number;
    HIGH_THRESHOLD?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
}
export class Top_Level_Data {
    TOP_LEVEL_ID?: number;
    TOP_LEVEL_NAME: string;
    IMAGE_URL: string;
    LOGO_URL: string;
}
export class Topic {
    TOPIC: string;
    LIST_CHARACTERISTIC: Characteristic[];
}
export class Upper_Level {
    LEVEL_ID?: number;
    NAME: string;
    LOCATION: string;
    LOGO_URL: string;
    IMAGE_URL: string;
    LONGITUDE?: number;
    LATITUDE?: number;
}
export class User {
    USER_ID?: number;
    ORGANIZATION_ID?: number;
    USER_TYPE_SETUP_ID?: number;
    OWNER_ID?: number;
    FIRST_NAME: string;
    LAST_NAME: string;
    USERNAME: string;
    PASSWORD: string;
    EMAIL: string;
    PHONE_NUMBER: string;
    IMAGE_URL: string;
    IS_ACTIVE: boolean;
    IS_DELETED: boolean;
    IS_RECEIVE_EMAIL: boolean;
    DATA_RETENTION_PERIOD?: number;
    USER_DISTRICTNEX_WALKTHROUGH: string;
    USER_ADMIN_WALKTHROUGH: string;
    DATE_DELETED: string;
    ENTRY_DATE: string;
    ENTRY_USER_ID?: number;
    LAST_UPDATE: string;
    Organization: Organization;
    User_type_setup: Setup;
    List_User_districtnex_module: User_districtnex_module[];
    List_User_level_access: User_level_access[];
}
export class User_Accessible_Data {
    ORGANIZATION: Organization;
    LIST_ORGANIZATION_AREA_ID: number[];
    LIST_ORGANIZATION_SITE_ID: number[];
    LIST_ORGANIZATION_REGION_ID: number[];
    LIST_ORGANIZATION_ENTITY_ID: number[];
    LIST_ORGANIZATION_DISTRICT_ID: number[];
    LIST_ORGANIZATION_TOP_LEVEL_ID: number[];
    LIST_USER_AREA_ID: number[];
    LIST_USER_SITE_ID: number[];
    LIST_USER_REGION_ID: number[];
    LIST_USER_ENTITY_ID: number[];
    LIST_USER_DISTRICT_ID: number[];
    LIST_USER_TOP_LEVEL_ID: number[];
    LIST_REMOVED_EXTRUSIONS: Removed_extrusion[];
    LIST_USER_DISTRICTNEX_MODULE: User_districtnex_module[];
}
export class User_Accessible_Data_With_Level_List {
    USER_ACCESSIBLE_DATA: User_Accessible_Data;
    USER_ACCESSIBLE_LEVEL_LIST: User_Accessible_Level_List;
}
export class User_Accessible_Level_List {
    GEOJSON_SRC: string;
    DATA_LEVEL_SETUP_ID?: number;
    UPPER_LEVEL: Upper_Level;
    LIST_DIMENSION_INDEX: Dimension_index[];
    LIST_LEVEL_DIMENSION_WITH_STATUS: Level_Dimension_with_Status[];
    ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL: Organization_data_source_kpi_List_By_Top_Level;
    ORGANIZATION_DATA_SOURCE_KPI_LIST: Organization_data_source_kpi[];
    ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL: Accessible_Level_List_By_Top_Level;
    LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL: Accessible_Level_ID_List_By_Top_Level[];
}
export class User_Data_Access {
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
    LIST_DISTRICT_KPI_USER_ACCESS: District_kpi_user_access[];
    LIST_AREA_KPI_USER_ACCESS: Area_kpi_user_access[];
    LIST_SITE_KPI_USER_ACCESS: Site_kpi_user_access[];
    LIST_ENTITY_KPI_USER_ACCESS: Entity_kpi_user_access[];
    LIST_DISTRICT: District[];
    LIST_AREA: Area[];
    LIST_SITE: Site[];
    LIST_ENTITY: Entity[];
}
export class User_Details {
    USER_ID?: number;
    ORGANIZATION_ID?: number;
    USER_TYPE_SETUP_ID?: number;
    OWNER_ID?: number;
    FIRST_NAME: string;
    LAST_NAME: string;
    USERNAME: string;
    EMAIL: string;
    PHONE_NUMBER: string;
    IMAGE_URL: string;
    USER_DISTRICTNEX_WALKTHROUGH: string;
    USER_ADMIN_WALKTHROUGH: string;
    IS_RECEIVE_EMAIL: boolean;
    Organization: Organization;
    User_type_setup: Setup;
    TICKET: string;
}
export class User_districtnex_module {
    USER_DISTRICTNEX_MODULE_ID?: number;
    USER_ID?: number;
    DISTRICTNEX_MODULE_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Districtnex_module: Districtnex_module;
    User: User;
}
export class User_level_access {
    USER_LEVEL_ACCESS_ID?: number;
    ORGANIZATION_LEVEL_ACCESS_ID?: number;
    USER_ID?: number;
    LEVEL_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Organization_level_access: Organization_level_access;
    Data_level_setup: Setup;
    User: User;
}
export class User_theme {
    USER_THEME_ID?: number;
    USER_ID?: number;
    ORGANIZATION_THEME_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Organization_theme: Organization_theme;
    User: User;
}
export class Vehicle_Counting {
    GET_COUNTINGS_RESPONSE_LIST: Get_Countings_Response[];
    VEHICLE_COUNTING_TABLE_DATA_LIST: Vehicle_Counting_Table_Data[];
}
export class Vehicle_Counting_Table_Data {
    TIME: string;
    TOTAL_IN: number;
    TOTAL_OUT: number;
    TOTAL_OCCUPANCY: number;
    BICYCLE_IN: number;
    BICYCLE_OCCUPANCY: number;
    BICYCLE_OUT: number;
    BUS_IN: number;
    BUS_OCCUPANCY: number;
    BUS_OUT: number;
    CAR_IN: number;
    CAR_OCCUPANCY: number;
    CAR_OUT: number;
    MOTORBIKE_IN: number;
    MOTORBIKE_OCCUPANCY: number;
    MOTORBIKE_OUT: number;
    TRUCK_IN: number;
    TRUCK_OCCUPANCY: number;
    TRUCK_OUT: number;
}
export class Video_ai_asset {
    VIDEO_AI_ASSET_ID?: number;
    VIDEO_AI_INSTANCE_ID?: number;
    SPACE_ASSET_ID?: number;
    FRIENDLY_NAME: string;
    VIDEO_AI_ASSET_ID_REF?: number;
    FUNCTIONAL_NAME: string;
    RESOLUTION_X?: number;
    RESOLUTION_Y?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Space_asset: Space_asset;
    Video_ai_instance: Video_ai_instance;
    List_Video_ai_asset_entity: Video_ai_asset_entity[];
    IS_ERROR: boolean;
    Surveillance_Camera_Content: Surveillance_Camera_Content;
}
export class Video_ai_asset_entity {
    VIDEO_AI_ASSET_ENTITY_ID?: number;
    VIDEO_AI_ASSET_ID?: number;
    ENTITY_ID?: number;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    DESCRIPTION: string;
    Entity: Entity;
    Video_ai_asset: Video_ai_asset;
}
export class Video_ai_assets_with_engine_assets {
    VIDEO_AI_ASSET_WITH_FLAG_LIST: Video_ai_asset[];
    ASSET_LIST: Surveillance_Camera_Content[];
}
export class Video_ai_engine {
    VIDEO_AI_ENGINE_ID?: number;
    ENGINE_NAME: string;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    List_Video_ai_instance: Video_ai_instance[];
}
export class Video_ai_instance {
    VIDEO_AI_INSTANCE_ID?: number;
    VIDEO_AI_ENGINE_ID?: number;
    FRIENDLY_NAME: string;
    FUNCTIONAL_NAME: string;
    CONNECTION_URL: string;
    CONNECTION_TYPE_SETUP_ID?: number;
    USERNAME: string;
    PASSWORD: string;
    IS_LPR: boolean;
    ENTRY_USER_ID?: number;
    ENTRY_DATE: string;
    LAST_UPDATE: string;
    IS_DELETED: boolean;
    OWNER_ID?: number;
    Video_ai_engine: Video_ai_engine;
    Connection_type_setup: Setup;
}
export class Video_ai_instance_with_connection_flag {
    oVideo_ai_instance: Video_ai_instance;
    IS_FORCE_CONNECTION: boolean;
    RESPONSE_MESSAGE: string;
}
export class Visitor_Activity {
    TIME_BUCKET_SIZE?: number;
    END_TIME?: string;
    REQUEST_ID: string;
    START_TIME?: string;
    LIST_STUDY_ZONE: Study_zone[];
    STATUS: string;
}
export class Visitor_Count_By_Level {
    LEVEL_ID?: number;
    VISITOR_COUNT?: number;
}
export class Visitor_Data {
    TIME_BUCKET_SIZE?: number;
    END_TIME?: string;
    REQUEST_ID: string;
    START_TIME?: string;
    LIST_STUDY_ZONE: Study_zone[];
    STATUS: string;
}
export class Visitor_Origins {
    LIST_EXT_STUDY_ZONE_WITH_COUNT: Ext_study_zone_With_Count[];
    GEOJSON: string;
}
export class Wifi_signal {
    RECORD_DATE?: string;
    VALUE?: number;
    VALUE_NAME: string;
    WIFI_SIGNAL_METADATA: Wifi_signal_Metadata;
}
export class Wifi_signal_alert {
    WIFI_SIGNAL_ALERT_ID: string;
    ALERT_VALUE?: number;
    RESOLVE_VALUE?: number;
    START_DATE?: string;
    END_DATE?: string;
    IS_RESOLVED?: boolean;
    SPACE_ASSET_ID?: number;
    SPACE_ID?: number;
    FLOOR_ID?: number;
}
export class Wifi_signal_data {
    WIFI_SIGNAL_LIST: Wifi_signal[];
    WIFI_SIGNAL_ALERT_LIST: Wifi_signal_alert[];
}
export class Wifi_signal_Metadata {
    SPACE_ASSET_ID?: number;
    SPACE_ID?: number;
    FLOOR_ID?: number;
}
export class Params_Get_Asset_By_ASSET_ID_List {
    ASSET_ID_LIST: number[];
}
export class Params_Get_Asset_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Asset_By_ASSET_ID {
    ASSET_ID?: number;
}
export class Params_Get_Asset_Data_List {
    SPACE_ASSET_ID_LIST: number[];
}
export class Params_Delete_Asset {
    ASSET_ID?: number;
}
export class Params_Get_Data_source_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Generate_Area_Dwell_Time {
    YEAR: number;
    MONTH: number;
    DAY: number;
}
export class Params_Edit_Job_List {
    List_Job: Job[];
}
export class Params_Generate_District_Dwell_Time {
    YEAR: number;
    MONTH: number;
    DAY: number;
}
export class Params_Get_Visitor_Data {
    AUTH_TOKEN: string;
    END_DATE?: string;
    START_DATE?: string;
    SITE_LIST: Site[];
    DWELL_BUCKET_TIME?: number;
    IS_EXCLUDE_NON_WORKERS?: boolean;
    MIN_DWELL_TIME_IN_MINUTES?: number;
    MAX_DWELL_TIME_IN_MINUTES?: number;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Edit_Kpi_List {
    List_To_Edit: Kpi[];
    List_Failed_Edit: Kpi[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Insert_Entity_Kpi_Data_List {
    ENTITY_KPI_DATA_LIST: Entity_kpi_data[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Delete_Data_source {
    DATA_SOURCE_ID?: number;
}
export class Params_Get_And_Fill_Bylaw_complaints_From_Api {
    DATE_CREATED_START_DATE?: string;
}
export class Params_Generate_Or_Compute_District_Hourly_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Generate_Or_Compute_Area_Hourly_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Generate_Or_Compute_Site_Hourly_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Extract_Kpi_Data_From_CSV {
    ORGANIZATION_ID?: number;
    FILE_NAME: string;
    LEVEL_SETUP_ID?: number;
}
export class Params_Generate_Area_Demographic_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
}
export class Params_Get_Jobs_By_Where {
    END_DATE?: string;
    START_DATE?: string;
    JOB_REQUEST_ID: string;
    SITE_ID_LIST: number[];
    JOB_ID_LIST: string[];
    IS_EXCLUDE_NON_WORKERS?: boolean;
    MIN_DWELL_TIME_LIST: number[];
    MAX_DWELL_TIME_LIST: number[];
    DWELL_TIME_BUCKET_LIST: number[];
    REQUEST_SETUP_ID_LIST: number[];
}
export class Params_Generate_Or_Compute_Floor_Hourly_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Delete_Space_Kpi_Data_By_Where {
    SPACE_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Generate_Site_Visitor_Data_And_Dwell_Time {
    START_TIME: string;
    List_Site: Site[];
    Visitor_Data: Visitor_Data;
    Dwell_Time_1: Visitor_Data;
    Dwell_Time_2: Visitor_Data;
    Dwell_Time_3: Visitor_Data;
    Dwell_Time_4: Visitor_Data;
}
export class Params_Edit_Niche_categories_List {
    List_Niche_categories: Niche_categories[];
}
export class Params_Delete_Niche_categories {
    BUSINESS_NICHE_LIST: string[];
    NICHE_CATEGORIES_ID_LIST: string[];
}
export class Params_Delete_Site_Kpi_Data_By_Where {
    SITE_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Insert_Space_Kpi_Data_List {
    SPACE_KPI_DATA_LIST: Space_kpi_data[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Generate_Site_Demographic_Data {
    START_TIME: string;
    List_Site: Site[];
    Demographic_Data: Demographic_Data;
}
export class Params_Insert_Site_Kpi_Data_List {
    SITE_KPI_DATA_LIST: Site_kpi_data[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Delete_Entity_Kpi_Data_By_Where {
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Get_Demographic_Data {
    AUTH_TOKEN: string;
    END_DATE?: string;
    START_DATE?: string;
    SITE_LIST: Site[];
    MIN_DWELL_TIME_IN_MINUTES?: number;
    MAX_DWELL_TIME_IN_MINUTES?: number;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Generate_District_Hourly_Indexes {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Niche_categories_By_Where {
    BUSINESS_NICHE_LIST: string[];
    NICHE_CATEGORIES_ID_LIST: string[];
}
export class Params_Generate_Entity_Hourly_Indexes {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Generate_Worker_Data {
    START_TIME: string;
    List_Site: Site[];
    Visitor_Data: Visitor_Data;
}
export class Params_Delete_District_Kpi_Data_By_Where {
    DISTRICT_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Get_Organization_data_source_kpi_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Delete_Floor_Kpi_Data_By_Where {
    FLOOR_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Insert_Area_Kpi_Data_List {
    AREA_KPI_DATA_LIST: Area_kpi_data[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Generate_Space_Hourly_Indexes {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List {
    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: number[];
}
export class Params_Generate_Business_Count_And_Vacant_Business_Count {
    YEAR: number;
    MONTH: number;
    DAY: number;
}
export class Params_Insert_District_Kpi_Data_List {
    DISTRICT_KPI_DATA_LIST: District_kpi_data[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Delete_Organization_data_source_kpi {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
}
export class Params_Generate_Site_Hourly_Indexes {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Visitor_Activity_Data {
    AUTH_TOKEN: string;
    END_DATE?: string;
    START_DATE?: string;
    SITE_LIST: Site[];
    DWELL_BUCKET_TIME?: number;
    MIN_DWELL_TIME_IN_MINUTES?: number;
    MAX_DWELL_TIME_IN_MINUTES?: number;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_And_Fill_Public_events_From_Api {
    DATE_CREATED_START_DATE?: string;
}
export class Params_Generate_Floor_Hourly_Indexes {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Generate_Area_Hourly_Indexes {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Generate_Or_Compute_Entity_Hourly_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Delete_Job {
    END_DATE?: string;
    START_DATE?: string;
    JOB_REQUEST_ID: string;
    SITE_ID_LIST: number[];
    JOB_ID_LIST: string[];
    IS_EXCLUDE_NON_WORKERS?: boolean;
    MIN_DWELL_TIME_LIST: number[];
    MAX_DWELL_TIME_LIST: number[];
    DWELL_TIME_BUCKET_LIST: number[];
    REQUEST_SETUP_ID_LIST: number[];
}
export class Params_Generate_District_Demographic_Data {
    YEAR: number;
    MONTH: number;
    DAY: number;
}
export class Params_Insert_Floor_Kpi_Data_List {
    FLOOR_KPI_DATA_LIST: Floor_kpi_data[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Generate_Visitor_Activity_Data {
    START_TIME: string;
    List_Site: Site[];
    Visitor_Activity: Visitor_Activity;
}
export class Params_Get_Floor_By_ENTITY_ID_List {
    ENTITY_ID_LIST: number[];
}
export class Params_Edit_Entity_share_data {
    Entity_share_data: Entity_share_data;
}
export class Params_Get_Share_file_By_USER_ID {
    USER_ID?: number;
}
export class Params_Get_Share_file_By_SHARE_FILE_ID {
    SHARE_FILE_ID?: number;
}
export class Params_Get_Entity_share_view_data {
    UNIQUE_STRING: string;
}
export class Params_Send_Share_Link_By_Email {
    SHARE_DATA_LINK: string;
    List_Email: string[];
}
export class Params_Delete_Share_file {
    SHARE_FILE_ID?: number;
}
export class Params_Get_Space_asset_By_SPACE_ID_List {
    SPACE_ID_LIST: number[];
}
export class Params_Get_Space_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_Space_List {
    List_To_Edit: Space[];
    List_Failed_Edit: Space[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Space_asset_By_SPACE_ID {
    SPACE_ID?: number;
}
export class Params_Get_Space_By_FLOOR_ID {
    FLOOR_ID?: number;
}
export class Params_Get_Space_asset_By_SPACE_ASSET_ID_List {
    SPACE_ASSET_ID_LIST: number[];
}
export class Params_Edit_Space_asset_List {
    List_To_Edit: Space_asset[];
    List_Failed_Edit: Space_asset[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Space_asset_By_SPACE_ID {
    SPACE_ID?: number;
}
export class Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List {
    SPACE_ASSET_ID_LIST: number[];
}
export class Params_Get_Report_Details {
    END_DATE?: string;
    START_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
    LIST_DISTRICT_ASSET_DEFINITION: Asset_definition[];
    LIST_AREA_ASSET_DEFINITION: Asset_definition[];
    LIST_SITE_ASSET_DEFINITION: Asset_definition[];
    LIST_ENTITY_ASSET_DEFINITION: Asset_definition[];
}
export class Params_Send_Report_Email {
    REPORT_ID: number;
    TO_EMAIL: string;
}
export class Params_Get_District_By_DISTRICT_ID_List {
    DISTRICT_ID_LIST: number[];
}
export class Params_Get_District_view_By_DISTRICT_ID {
    DISTRICT_ID?: number;
}
export class Params_Get_District_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_District_geojson_By_DISTRICT_ID_List {
    DISTRICT_ID_LIST: number[];
}
export class Params_Delete_District_view {
    DISTRICT_VIEW_ID?: number;
}
export class Params_Edit_District_view_List {
    List_To_Edit: District_view[];
    List_Failed_Edit: District_view[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_District_view_By_DISTRICT_ID {
    DISTRICT_ID?: number;
}
export class Params_Get_District_view_By_DISTRICT_ID_List {
    DISTRICT_ID_LIST: number[];
}
export class Params_Get_Wifi_signals {
    START_DATE?: string;
    END_DATE?: string;
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID?: number;
}
export class Params_Get_District_Kpi_Dialog_Data {
    DISTRICT_ID?: number;
    LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    DIMENSION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Area_Kpi_Data_Aggregate_Sum {
    AREA_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Entity_Kpi_Data_By_Where {
    ENTITY_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Area_Kpi_Data_Hourly {
    DAY: number;
    YEAR: number;
    HOUR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Get_Site_Kpi_Dialog_Data {
    DISTRICT_ID?: number;
    AREA_ID?: number;
    SITE_ID?: number;
    LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    DIMENSION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Site_Kpi_Data_By_Where {
    SITE_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Edit_Alert_List {
    List_Alert: Alert[];
}
export class Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List {
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
}
export class Params_Compute_District_Kpi_Data_Monthly {
    MONTH: number;
    YEAR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Bylaw_Complaint_List {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    START_DATE?: string;
}
export class Params_Delete_Kpi {
    KPI_ID?: number;
}
export class Params_Delete_Wifi_signal {
    FLOOR_ID?: number;
    SPACE_ID_LIST: number[];
    SPACE_ASSET_ID_LIST: number[];
}
export class Params_Compute_Floor_Kpi_Data_Monthly {
    MONTH: number;
    YEAR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Edit_Wifi_signal_alert_List {
    List_Wifi_signal_alert: Wifi_signal_alert[];
}
export class Params_Delete_Alert {
    END_DATE?: string;
    START_DATE?: string;
    USER_ID_LIST: number[];
    ALERT_ID_LIST: string[];
    ARE_UNACKNOWLEDGEMENTS_CREATED?: boolean;
    IS_ACKNOWLEDGED?: boolean;
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    LEVEL_SETUP_ID?: number;
}
export class Params_Compute_District_Kpi_Data_Weekly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_District_Kpi_Data_Aggregate_Sum {
    DISTRICT_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Space_Kpi_Data_Monthly {
    MONTH: number;
    YEAR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Compute_Space_Kpi_Data_Daily {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Update_Kpi_Data_Record {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    RECORD_DATE?: string;
}
export class Params_Compute_Area_Kpi_Data_Daily {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Latest_Wifi_signal_alerts {
    NUMBER_OF_POINTS?: number;
    FLOOR_ID?: number;
    SPACE_ID_LIST: number[];
    SPACE_ASSET_ID_LIST: number[];
}
export class Params_Get_Floor_Kpi_Data_Aggregate_Sum {
    FLOOR_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Entity_Kpi_Data_Weekly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
}
export class Params_Compute_Area_Kpi_Data_Weekly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Business_Trendline {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Edit_Wifi_signal_List {
    List_Wifi_signal: Wifi_signal[];
}
export class Params_Compute_Entity_Kpi_Data_Daily {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Floor_Kpi_Dialog_Data {
    FLOOR_ID?: number;
    SITE_ID?: number;
    LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    DIMENSION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Latest_GeoData_By_KPI {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
}
export class Params_Get_Public_Event_List {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    START_DATE?: string;
}
export class Params_Get_Alerts_By_Where {
    END_DATE?: string;
    START_DATE?: string;
    USER_ID_LIST: number[];
    ALERT_ID_LIST: string[];
    IS_ACKNOWLEDGED?: boolean;
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    LEVEL_SETUP_ID?: number;
    LEVEL_ID_LIST: number[];
}
export class Params_Compute_Site_Kpi_Data_Hourly {
    DAY: number;
    YEAR: number;
    HOUR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Compute_Entity_Kpi_Data_Hourly {
    DAY: number;
    YEAR: number;
    HOUR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Compute_Entity_Kpi_Data_Monthly {
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Edit_User_Data_Access {
    List_To_Edit_District_kpi_user_access: District_kpi_user_access[];
    List_To_Delete_District_kpi_user_access: District_kpi_user_access[];
    List_To_Edit_Area_kpi_user_access: Area_kpi_user_access[];
    List_To_Delete_Area_kpi_user_access: Area_kpi_user_access[];
    List_To_Edit_Site_kpi_user_access: Site_kpi_user_access[];
    List_To_Delete_Site_kpi_user_access: Site_kpi_user_access[];
    List_To_Edit_Entity_kpi_user_access: Entity_kpi_user_access[];
    List_To_Delete_Entity_kpi_user_access: Entity_kpi_user_access[];
    Selected_Level_Setup: Setup;
}
export class Params_Get_Organization_Data_Access {
    ORGANIZATION_ID?: number;
}
export class Params_Get_User_Data_Access {
    USER_ID?: number;
    ORGANIZATION_ID?: number;
}
export class Params_Delete_Wifi_signal_alert {
    WIFI_SIGNAL_ALERT_ID_LIST: string[];
    FLOOR_ID?: number;
    SPACE_ID_LIST: number[];
    SPACE_ASSET_ID_LIST: number[];
    IS_RESOLVED?: boolean;
}
export class Params_Get_Area_Kpi_Dialog_Data {
    DISTRICT_ID?: number;
    AREA_ID?: number;
    LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    DIMENSION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Alerts_Count_For_Levels {
    END_DATE?: string;
    START_DATE?: string;
    USER_ID_LIST: number[];
    ALERT_ID_LIST: string[];
    IS_ACKNOWLEDGED?: boolean;
    DISTRICT_ID_LIST: number[];
    AREA_ID_LIST: number[];
    SITE_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
}
export class Params_Get_Space_Kpi_Data_By_Where {
    START_DATE?: string;
    END_DATE?: string;
    SPACE_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Get_Site_Kpi_Data_Aggregate_Sum {
    SITE_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Latest_Visitor_Count_By_Where {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Entity_Kpi_Data_Aggregate_Sum {
    ENTITY_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Floor_Kpi_Data_Hourly {
    YEAR: number;
    MONTH: number;
    DAY: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Wifi_signal_alerts {
    START_DATE?: string;
    END_DATE?: string;
    WIFI_SIGNAL_ALERT_ID_LIST: string[];
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID?: number;
    IS_RESOLVED?: boolean;
}
export class Params_Get_District_Kpi_Data_By_Where {
    DISTRICT_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Kpi_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Floor_Kpi_Data_By_Where {
    FLOOR_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Floor_Kpi_Data_Weekly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Update_Wifi_signal {
    FLOOR_ID?: number;
}
export class Params_Get_Visitor_Origins {
    LEVEL_ID?: number;
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Site_Kpi_Data_Daily {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Compute_District_Kpi_Data_Daily {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    HOUR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Latest_Wifi_signals {
    NUMBER_OF_POINTS?: number;
    FLOOR_ID?: number;
    SPACE_ID_LIST: number[];
    SPACE_ASSET_ID_LIST: number[];
}
export class Params_Get_Alerts_By_Where_Count {
    END_DATE?: string;
    START_DATE?: string;
    USER_ID_LIST: number[];
    ALERT_ID_LIST: string[];
    IS_ACKNOWLEDGED?: boolean;
    LEVEL_SETUP_ID?: number;
    LEVEL_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
}
export class Params_Get_Entity_Incidents {
    END_ROW?: number;
    START_ROW?: number;
    ENTITY_ID?: number;
    END_DATE: string;
    START_DATE: string;
    CATEGORY_SETUP_LIST: Setup[];
}
export class Params_Get_Bylaw_Complaints_Trendline {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Alerts_For_Levels {
    END_DATE?: string;
    START_DATE?: string;
    USER_ID_LIST: number[];
    ALERT_ID_LIST: string[];
    IS_ACKNOWLEDGED?: boolean;
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    DISTRICT_ID_LIST: number[];
    AREA_ID_LIST: number[];
    SITE_ID_LIST: number[];
}
export class Params_Compute_Space_Kpi_Data_Weekly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Area_Kpi_Data_By_Where {
    AREA_ID_LIST: number[];
    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Site_Kpi_Data_Monthly {
    MONTH: number;
    YEAR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Compute_District_Kpi_Data_Hourly {
    DAY: number;
    YEAR: number;
    HOUR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Intersection_Kpi_Dialog_Data {
    ENTITY_ID?: number;
    LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    DIMENSION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Compute_Floor_Kpi_Data_Daily {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Strongest_Wifi_signal {
    START_DATE?: string;
    END_DATE?: string;
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID_LIST: number[];
    TOP_LEVEL_ID?: number;
}
export class Params_Compute_Area_Kpi_Data_Monthly {
    MONTH: number;
    YEAR: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Business_List {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
}
export class Params_Edit_Organization_Data_Access {
    List_To_Edit_District_kpi: District_kpi[];
    List_To_Delete_District_kpi: District_kpi[];
    List_To_Edit_Area_kpi: Area_kpi[];
    List_To_Delete_Area_kpi: Area_kpi[];
    List_To_Edit_Site_kpi: Site_kpi[];
    List_To_Delete_Site_kpi: Site_kpi[];
    List_To_Edit_Entity_kpi: Entity_kpi[];
    List_To_Delete_Entity_kpi: Entity_kpi[];
    Selected_Level_Setup: Setup;
}
export class Params_Get_Entity_Kpi_Dialog_Data {
    ENTITY_ID?: number;
    LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID: number[];
    DIMENSION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
}
export class Params_Compute_Site_Kpi_Data_Weekly {
    DAY: number;
    YEAR: number;
    MONTH: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}
export class Params_Get_Most_Wifi_signal_Count_Per_Space_asset {
    START_DATE?: string;
    END_DATE?: string;
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID_LIST: number[];
    TOP_LEVEL_ID?: number;
}
export class Params_Get_Public_Events_Trendline {
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_User_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Get_Top_level_By_TOP_LEVEL_ID_List {
    TOP_LEVEL_ID_LIST: number[];
}
export class Params_Get_Top_level_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Entity_view_By_ENTITY_ID {
    ENTITY_ID?: number;
}
export class Params_Delete_Entity_view {
    ENTITY_VIEW_ID?: number;
}
export class Params_Get_Entity_By_SITE_ID {
    SITE_ID?: number;
}
export class Params_Get_Entity_By_ENTITY_ID {
    ENTITY_ID?: number;
}
export class Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID {
    ENTITY_ID_LIST: number[];
    TOP_LEVEL_ID?: number;
}
export class Params_Get_Entity_By_ENTITY_ID_List {
    ENTITY_ID_LIST: number[];
}
export class Params_Get_Entity_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_Entity_view_List {
    List_To_Edit: Entity_view[];
    List_Failed_Edit: Entity_view[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Entity_view_By_ENTITY_ID {
    ENTITY_ID?: number;
}
export class Params_Get_Entity_view_By_ENTITY_ID_List {
    ENTITY_ID_LIST: number[];
}
export class Params_Get_Region_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Delete_Region_view {
    REGION_VIEW_ID?: number;
}
export class Params_Get_Region_view_By_REGION_ID {
    REGION_ID?: number;
}
export class Params_Get_Floor_By_ENTITY_ID {
    ENTITY_ID?: number;
}
export class Params_Get_Floor_By_ENTITY_ID_With_Space_Asset {
    ENTITY_ID?: number;
}
export class Params_Get_Floor_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Logs_With_Filters {
    END_ROW?: number;
    START_ROW?: number;
    END_DATE?: string;
    START_DATE?: string;
    USER_ID_LIST: number[];
    SITE_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
    ORGANIZATION_ID_LIST: number[];
    VIDEO_AI_ASSET_ID_LIST: number[];
    LOG_TYPE_SETUP_ID_LIST: number[];
    ACCESS_TYPE_SETUP_ID_LIST: number[];
}
export class Params_Generate_Logs_Excel {
    END_ROW?: number;
    START_ROW?: number;
    END_DATE?: string;
    START_DATE?: string;
    SITE_ID_LIST: number[];
    USER_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
    ORGANIZATION_ID_LIST: number[];
    VIDEO_AI_ASSET_ID_LIST: number[];
    LOG_TYPE_SETUP_ID_LIST: number[];
    ACCESS_TYPE_SETUP_ID_LIST: number[];
}
export class Params_Get_Latest_Dimension_index_By_Where {
    START_DATE?: string;
    END_DATE?: string;
    LIST_DIMENSION_ID_BY_LEVEL_ID: Dimension_ID_By_Level_ID[];
    LEVEL_SETUP_ID?: number;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Dimension_By_DIMENSION_ORDER_List {
    DIMENSION_ORDER_LIST: number[];
}
export class Params_Edit_Dimension_List {
    List_To_Edit: Dimension[];
    List_Failed_Edit: Dimension[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Dimension_By_DIMENSION_ID_List {
    DIMENSION_ID_LIST: number[];
}
export class Params_Get_Dimension_By_DIMENSION_ID {
    DIMENSION_ID?: number;
}
export class Params_Compute_Dimension_Index_Monthly {
    DAY: number;
    MONTH: number;
    YEAR: number;
    LIST_DIMENSION: Dimension[];
}
export class Params_Insert_Dimension_index_List {
    LIST_DIMENSION_INDEX: Dimension_index[];
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Compute_Dimension_Index_Weekly {
    DAY: number;
    MONTH: number;
    YEAR: number;
    LIST_DIMENSION: Dimension[];
}
export class Params_Get_Dimension_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Dimension_index_By_Where {
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN: Enum_Timespan;
    LIST_DIMENSION_ID: number[];
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
}
export class Params_Generate_Dimension_Index_Daily {
    DAY: number;
    MONTH: number;
    YEAR: number;
    LIST_DIMENSION: Dimension[];
}
export class Params_Delete_Dimension_index_By_Where {
    LIST_DIMENSION_ID: number[];
    LIST_LEVEL_ID: number[];
    LEVEL_SETUP_ID?: number;
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Get_Site_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Site_By_SITE_ID_List {
    SITE_ID_LIST: number[];
}
export class Params_Get_Ext_study_zone_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Delete_Site_view {
    SITE_VIEW_ID?: number;
}
export class Params_Get_Site_By_SITE_ID {
    SITE_ID?: number;
}
export class Params_Get_Site_geojson_By_SITE_ID_List {
    SITE_ID_LIST: number[];
}
export class Params_Get_Site_view_By_SITE_ID {
    SITE_ID?: number;
}
export class Params_Edit_Ext_study_zone_List {
    List_To_Edit: Ext_study_zone[];
    List_Failed_Edit: Ext_study_zone[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Edit_Site_view_List {
    List_To_Edit: Site_view[];
    List_Failed_Edit: Site_view[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Site_view_By_SITE_ID {
    SITE_ID?: number;
}
export class Params_Get_Site_view_By_SITE_ID_List {
    SITE_ID_LIST: number[];
}
export class Params_Get_Site_field_logo_By_SITE_ID_List {
    SITE_ID_LIST: number[];
}
export class Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID {
    ORGANIZATION_ID?: number;
    LOG_TYPE_SETUP_ID?: number;
}
export class Params_Get_Organization_image_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Delete_Organization_theme {
    ORGANIZATION_THEME_ID?: number;
}
export class Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID {
    DATA_LEVEL_SETUP_ID?: number;
}
export class Params_Get_Organization_theme_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Edit_Organization_Custom {
    ORGANIZATION: Organization;
}
export class Params_Schedule_Organization_for_Delete {
    ORGANIZATION_ID?: number;
}
export class Params_Modify_Data_Settings {
    ORGANIZATION_ID?: number;
    DATA_RETENTION_PERIOD?: number;
    TICKET_DURATION_IN_MINUTES?: number;
    Params_Edit_Organization_log_config_List: Params_Edit_Organization_log_config_List;
}
export class Params_Edit_Organization_log_config_List {
    List_To_Edit: Organization_log_config[];
    List_Failed_Edit: Organization_log_config[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Modify_Organization_Details {
    ORGANZATION_ID?: number;
    ORGANIZATION_NAME: string;
    ORGANIZATION_PHONE_NUMBER: string;
    ORGANIZATION_EMAIL: string;
    ORGANIZATION_ADDRESS: string;
    MAX_NUMBER_OF_ADMINS?: number;
    MAX_NUMBER_OF_USERS?: number;
}
export class Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID {
    PARENT_ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_theme_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID {
    ORGANIZATION_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
}
export class Params_Edit_Organization_districtnex_module_List {
    List_To_Edit: Organization_districtnex_module[];
    List_Failed_Edit: Organization_districtnex_module[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Organization_By_PARENT_ORGANIZATION_ID {
    PARENT_ORGANIZATION_ID?: number;
}
export class Params_Edit_Organization_level_access_List {
    List_To_Edit: Organization_level_access[];
    List_Failed_Edit: Organization_level_access[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Organization_Picture {
    ORGANIZATION_ID?: number;
    IMAGE_TYPE_SETUP_ID?: number;
}
export class Params_Get_Organization_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading {
    ORGANIZATION_ID?: number;
    LIST_EAGER_LOADED_DATA: string[];
}
export class Params_Get_Organization_color_scheme_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_Organization_chart_color_List {
    List_To_Edit: Organization_chart_color[];
    List_Failed_Edit: Organization_chart_color[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Organization_level_access_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Restore_Organization {
    ORGANIZATION_ID?: number;
}
export class Params_Delete_Organization_level_access {
    ORGANIZATION_LEVEL_ACCESS_ID?: number;
}
export class Params_Delete_Organization_level_access_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Edit_Organization_color_scheme_List {
    List_To_Edit: Organization_color_scheme[];
    List_Failed_Edit: Organization_color_scheme[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_log_config_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Delete_Organization_log_config_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Get_Organization_level_access_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Get_Organization_log_config_By_ORGANIZATION_ID_List {
    ORGANIZATION_ID_LIST: number[];
}
export class Params_Get_Organization_image_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Get_Specialized_chart_configuration_By_MODULE {
    MODULE: string;
}
export class Params_Delete_District_geojson_By_DISTRICT_ID {
    DISTRICT_ID?: number;
}
export class Params_Edit_Setup_category_List {
    List_To_Edit: Setup_category[];
    List_Failed_Edit: Setup_category[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Districtnex_module_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Setup_By_SETUP_ID {
    SETUP_ID?: number;
}
export class Params_Get_Default_settings_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_Object_View {
    DISTRICT_ID?: number;
    AREA_ID?: number;
    SITE_ID?: number;
    ENTITY_ID?: number;
    VIEW_TYPE_SETUP_ID?: number;
    PITCH: number;
    BEARING: number;
    ZOOM: number;
    LONGITUDE: number;
    LATITUDE: number;
}
export class Params_Get_Setup_category_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_District_geojson {
    District_geojson: string;
}
export class Params_Delete_Build_version {
    BUILD_VERSION_ID?: number;
}
export class Params_Edit_Ext_study_zone_geojson {
    Ext_study_zone_geojson: string;
}
export class Params_Delete_Default_Settings_Picture {
    IMAGE_TYPE_SETUP_ID?: number;
}
export class Params_Edit_Removed_extrusion_Custom_Old {
    ID: string;
    DATA_LEVEL_SETUP_ID?: number;
    LEVEL_ID?: number;
}
export class Params_Delete_Setup_category {
    SETUP_CATEGORY_ID?: number;
}
export class Params_Get_Build_version_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Default_chart_color_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_Default_chart_color_List {
    List_To_Edit: Default_chart_color[];
    List_Failed_Edit: Default_chart_color[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Setup_category_By_SETUP_CATEGORY_ID {
    SETUP_CATEGORY_ID?: number;
}
export class Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID {
    EXT_STUDY_ZONE_ID?: number;
}
export class Params_Edit_Alert_settings_List {
    List_To_Edit: Alert_settings[];
    List_Failed_Edit: Alert_settings[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Dimension_chart_configuration {
    DIMENSION_CHART_CONFIGURATION_ID: string;
}
export class Params_Edit_Site_geojson {
    Site_geojson: string;
}
export class Params_Delete_Area_geojson_By_AREA_ID {
    AREA_ID?: number;
}
export class Params_Delete_Specialized_chart_configuration {
    SPECIALIZED_CHART_CONFIGURATION_ID: string;
}
export class Params_Get_Alert_settings_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID {
    APPLICATION_NAME_SETUP_ID?: number;
}
export class Params_Edit_Removed_extrusion_Custom {
    List_Removed_extrusion: Removed_extrusion[];
}
export class Params_Delete_Kpi_chart_configuration {
    KPI_CHART_CONFIGURATION_ID: string;
}
export class Params_Custom_Edit_Build_version {
    Build_version: Build_version;
}
export class Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID {
    SETUP_CATEGORY_NAME: string;
    OWNER_ID?: number;
}
export class Params_Get_Setup_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Edit_Area_geojson {
    Area_geojson: string;
}
export class Params_Delete_Site_geojson_By_SITE_ID {
    SITE_ID?: number;
}
export class Params_Edit_Removed_extrusion_List {
    List_To_Edit: Removed_extrusion[];
    List_Failed_Edit: Removed_extrusion[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Removed_extrusion_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Delete_Setup {
    SETUP_ID?: number;
}
export class Params_Get_Alert_settings_By_USER_ID {
    USER_ID?: number;
}
export class Params_Send_Support_Email {
    TITLE: string;
    MESSAGE: string;
    List_Email: string[];
}
export class Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List {
    DISTRICTNEX_MODULE_ID_LIST: number[];
}
export class Params_Drop_Collection {
    COLLECTION_NAME: string;
}
export class Params_Edit_Build_version_List {
    List_To_Edit: Build_version[];
    List_Failed_Edit: Build_version[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Create_Time_series_Collection {
    TIME_SERIES_COLLECTION_NAME: string;
}
export class Params_Get_Correlation_method_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Delete_Correlation_method {
    CORRELATION_METHOD_ID?: number;
}
export class Params_Get_Correlation {
    RESOLUTION?: number;
    END_DATE?: string;
    START_DATE?: string;
    ORGANIZATION_ID?: number;
    CORRELATION_METHOD_ID?: number;
    ENUM_TIMESPAN?: Enum_Timespan;
    First_Organization_data_source_kpi_By_Level: Organization_data_source_kpi_By_Level;
    Second_Organization_data_source_kpi_By_Level: Organization_data_source_kpi_By_Level;
}
export class Params_Get_Comparison_Data {
    DISTRICT_ID_LIST: number[];
    AREA_ID_LIST: number[];
    SITE_ID_LIST: number[];
    END_DATE?: string;
    START_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Multi_kpi_comparison {
    LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL: Organization_data_source_kpi_By_Level[];
    ORGANIZATION_ID?: number;
    END_DATE?: string;
    START_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Single_kpi_comparison {
    ORGANIZATION_DATA_SOURCE_KPI_ID?: number;
    LEVEL_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
    ORGANIZATION_ID?: number;
    END_DATE?: string;
    START_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Fetch_Scenes {
    SIZE?: number;
    PAGE?: number;
    START_DATE: string;
    END_DATE: string;
    QUERY: string;
    List_Video_ai_asset: Video_ai_asset[];
}
export class Params_Get_Vehicle_Types {
    VIDEO_AI_INSTANCE_ID?: number;
    ENTITY_ID?: number;
}
export class Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID {
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID {
    VIDEO_AI_ENGINE_ID?: number;
}
export class Params_Create_Video_ai_asset {
    VIDEO_AI_INSTANCE_ID?: number;
    FRIENDLY_NAME: string;
    FUNCTIONAL_NAME: string;
    SPACE_ASSET_ID?: number;
    ENTITY_ID?: number;
    VIDEO_AI_ASSET_ID_REF?: number;
    RESOLUTION_X?: number;
    RESOLUTION_Y?: number;
}
export class Params_Change_Video_ai_instance_Password {
    VIDEO_AI_INSTANCE_ID?: number;
    NEW_PASSWORD: string;
    FORCE_CONNECTION: boolean;
}
export class Params_Face_Target_Key_Search {
    PAGE?: number;
    SIZE?: number;
    DESCRIPTOR: string;
    SCORES: number;
    LIMIT?: number;
}
export class Params_Face_Search {
    PAGE?: number;
    SIZE?: number;
    DESCRIPTOR: string;
    SCORES: number;
    LIMIT?: number;
    START_DATE: string;
    END_DATE: string;
    List_Video_ai_asset: Video_ai_asset[];
}
export class Params_Fetch_License_Plate_Categories {
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Fetch_Face_Targets {
    SIZE?: number;
    PAGE?: number;
    CATEGORY: string;
    TARGET_NAME: string;
}
export class Params_Fetch_Facial_Recognition {
    SIZE?: number;
    PAGE?: number;
    START_DATE: string;
    END_DATE: string;
    TARGET_NAME: string;
    SCORES: number;
    CATEGORIES: string;
    HAS_MASK?: boolean;
    AGE: string;
    GENDER: string;
    EMOTION: string;
    List_Video_ai_asset: Video_ai_asset[];
}
export class Params_Delete_Video_ai_asset_Custom {
    VIDEO_AI_ASSET_ID?: number;
}
export class Params_Get_Video_ai_engine_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Fetch_License_Plate_Targets {
    SIZE?: number;
    PAGE?: number;
    CATEGORY: string;
    PLATE_NUMBER: string;
}
export class Params_Get_Video_ai_asset_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Stream_Data {
    ENTITY_ID?: number;
}
export class Params_Fetch_License_Plate_Recognition {
    SIZE?: number;
    PAGE?: number;
    END_DATE: string;
    START_DATE: string;
    VEHICLE_TYPE: string;
    PLATE_NUMBER: string;
    List_Video_ai_asset: Video_ai_asset[];
}
export class Params_Get_Scene_Info {
    VIDEO_AI_INSTANCE_ID?: number;
    SCENE_ID?: number;
    OBJECT_TYPE: string;
}
export class Params_Get_Countings {
    VIDEO_AI_INSTANCE_ID?: number;
    TYPES: string[];
    MEASURE: string;
    START_DATE: string;
    END_DATE: string;
    LINESET_ID_LIST: number[];
}
export class Params_Get_Camera_Lines {
    TYPES: string[];
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Get_Space_asset_Vaidio_camera {
    SPACE_ASSET_ID?: number;
}
export class Params_Get_License_Plate_Scene {
    VIDEO_AI_INSTANCE_ID?: number;
    SCENE_ID?: number;
}
export class Params_Get_Video_ai_assets_with_engine_assets {
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List {
    VIDEO_AI_ASSET_ID_REF_LIST: number[];
}
export class Params_Create_Video_ai_instance {
    VIDEO_AI_ENGINE_ID?: number;
    FRIENDLY_NAME: string;
    FUNCTIONAL_NAME: string;
    USERNAME: string;
    PASSWORD: string;
    CONNECTION_URL: string;
    CONNECTION_TYPE_SETUP_ID?: number;
    FORCE_CONNECTION: boolean;
    IS_LPR: boolean;
}
export class Params_Delete_Video_ai_engine {
    VIDEO_AI_ENGINE_ID?: number;
}
export class Params_Fetch_Face_Target_Categories {
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Get_Vehicle_Countings {
    TYPES: string[];
    MEASURE: string;
    START_DATE: string;
    END_DATE: string;
    LINESET_ID_LIST: number[];
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Edit_Video_ai_instance_custom {
    Video_ai_instance: Video_ai_instance;
    FORCE_CONNECTION: boolean;
}
export class Params_Send_Alerts_Email {
    Scene: Scene_Details;
    Incident: Incident;
    TO_EMAIL: string;
}
export class Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID {
    VIDEO_AI_ASSET_ID?: number;
}
export class Params_Delete_Video_ai_instance {
    VIDEO_AI_INSTANCE_ID?: number;
}
export class Params_Edit_Video_ai_engine_List {
    List_To_Edit: Video_ai_engine[];
    List_Failed_Edit: Video_ai_engine[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Object {
    Object_Name: string;
}
export class Params_Delete_Object_List {
    List_Object_Name: string[];
}
export class Params_Upload_Object {
    Data: number[];
    Object_Name: string;
}
export class Params_Get_Area_view_By_AREA_ID {
    AREA_ID?: number;
}
export class Params_Get_Area_geojson_By_AREA_ID_List {
    AREA_ID_LIST: number[];
}
export class Params_Get_Area_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Area_By_AREA_ID_List {
    AREA_ID_LIST: number[];
}
export class Params_Delete_Area_view {
    AREA_VIEW_ID?: number;
}
export class Params_Edit_Area_view_List {
    List_To_Edit: Area_view[];
    List_Failed_Edit: Area_view[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Area_view_By_AREA_ID {
    AREA_ID?: number;
}
export class Params_Get_Area_view_By_AREA_ID_List {
    AREA_ID_LIST: number[];
}
export class Params_Get_Secret {
    Secret_Id: string;
    Secret_Version: string;
}
export class Params_Primary_Authentication {
    USERNAME: string;
    PASSWORD: string;
    IS_ADMIN?: boolean;
}
export class Params_OTP_Verification {
    USERNAME: string;
    USER_ID?: number;
    OTP: string;
}
export class Params_Send_Otp {
    USERNAME: string;
    USER: User;
    IS_FORGOT_PASSWORD: boolean;
}
export class Params_Verify_Otp {
    USER_ID?: number;
    OTP: string;
}
export class Params_Change_User_Forgotten_Password {
    USERNAME: string;
    NEW_PASSWORD: string;
    OTP: string;
}
export class Params_Create_User {
    USER: User;
    ORGANIZATION_ID?: number;
}
export class Params_Change_User_Password {
    USER_ID?: number;
    NEW_PASSWORD: string;
}
export class Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List {
    ORGANIZATION_LEVEL_ACCESS_ID_LIST: number[];
}
export class Params_Edit_User_Walkthrough {
    IS_ADMIN_UI: boolean;
    USER_WALKTHROUGH: string;
}
export class Params_Schedule_User_for_Delete {
    USER_ID?: number;
}
export class Params_Get_User_Accessible_Level_List {
    LIST_ORGANIZATION_TOP_LEVEL_ID: number[];
    LIST_ORGANIZATION_DISTRICT_ID: number[];
    LIST_ORGANIZATION_AREA_ID: number[];
    LIST_ORGANIZATION_SITE_ID: number[];
    LIST_ORGANIZATION_ENTITY_ID: number[];
    LIST_USER_TOP_LEVEL_ID: number[];
    LIST_USER_DISTRICT_ID: number[];
    LIST_USER_AREA_ID: number[];
    LIST_USER_SITE_ID: number[];
    LIST_USER_ENTITY_ID: number[];
    DATA_LEVEL_SETUP_ID?: number;
    TOP_LEVEL_ID?: number;
    SELECTED_LEVEL_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Edit_District_kpi_user_access_List {
    List_To_Edit: District_kpi_user_access[];
    List_Failed_Edit: District_kpi_user_access[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Area_kpi {
    AREA_KPI_ID?: number;
}
export class Params_Get_User_level_access_By_USER_ID_List {
    USER_ID_LIST: number[];
}
export class Params_Delete_User_level_access {
    USER_LEVEL_ACCESS_ID?: number;
}
export class Params_Edit_Entity_kpi_List {
    List_To_Edit: Entity_kpi[];
    List_Failed_Edit: Entity_kpi[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_User_By_ORGANIZATION_ID {
    ORGANIZATION_ID?: number;
}
export class Params_Edit_User_Details {
    USER_ID?: number;
    PHONE_NUMBER: string;
    IS_RECEIVE_EMAIL: boolean;
}
export class Params_Edit_District_kpi_List {
    List_To_Edit: District_kpi[];
    List_Failed_Edit: District_kpi[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_User_Accessible_Data_With_Level_List {
    CHOSEN_ORGANIZATION_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
    TOP_LEVEL_ID?: number;
    SELECTED_LEVEL_ID?: number;
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN: Enum_Timespan;
}
export class Params_Get_User_districtnex_module_By_USER_ID_List {
    USER_ID_LIST: number[];
}
export class Params_Get_User_By_USER_ID_List {
    USER_ID_LIST: number[];
}
export class Params_Get_User_districtnex_module_By_USER_ID {
    USER_ID?: number;
}
export class Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID {
    USER_ID?: number;
    DATA_LEVEL_SETUP_ID?: number;
}
export class Params_Edit_Entity_kpi_user_access_List {
    List_To_Edit: Entity_kpi_user_access[];
    List_Failed_Edit: Entity_kpi_user_access[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Edit_Area_kpi_List {
    List_To_Edit: Area_kpi[];
    List_Failed_Edit: Area_kpi[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Site_kpi {
    SITE_KPI_ID?: number;
}
export class Params_Edit_User_level_access_List {
    List_To_Edit: User_level_access[];
    List_Failed_Edit: User_level_access[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_Entity_kpi {
    ENTITY_KPI_ID?: number;
}
export class Params_Get_User_Accessible_Data {
    CHOSEN_ORGANIZATION_ID?: number;
}
export class Params_Edit_User_districtnex_module_List {
    List_To_Edit: User_districtnex_module[];
    List_Failed_Edit: User_districtnex_module[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Edit_Site_kpi_user_access_List {
    List_To_Edit: Site_kpi_user_access[];
    List_Failed_Edit: Site_kpi_user_access[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Initial_Data {
    USER_ID?: number;
    ORGANIZATION_ID?: number;
}
export class Params_Change_Password {
    USER_ID?: number;
    OLD_PASSWORD: string;
    NEW_PASSWORD: string;
}
export class Params_Delete_District_kpi {
    DISTRICT_KPI_ID?: number;
}
export class Params_Edit_Site_kpi_List {
    List_To_Edit: Site_kpi[];
    List_Failed_Edit: Site_kpi[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Entity_Intersection_List {
    ORGANIZATION_ID?: number;
}
export class Params_Get_User_By_IS_RECEIVE_EMAIL {
    IS_RECEIVE_EMAIL: boolean;
}
export class Params_Get_User_By_USER_ID {
    USER_ID?: number;
}
export class Params_Get_User_level_access_By_USER_ID {
    USER_ID?: number;
}
export class Params_Get_Level_Data {
    UPPER_LEVEL_ID?: number;
    SELECTED_DATA_LEVEL_SETUP_ID?: number;
    LIST_SELECTED_LEVEL_ID: number[];
    LIST_DIMENSION_ID: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Restore_User {
    USER_ID?: number;
}
export class Params_Edit_User_List {
    List_To_Edit: User[];
    List_Failed_Edit: User[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Get_Admin_Data {
    USER_ID?: number;
    IS_GET_IMAGES_FROM_Cloud?: boolean;
}
export class Params_Get_User_theme_By_USER_ID {
    USER_ID?: number;
}
export class Params_Edit_Area_kpi_user_access_List {
    List_To_Edit: Area_kpi_user_access[];
    List_Failed_Edit: Area_kpi_user_access[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Params_Delete_User_theme {
    USER_THEME_ID?: number;
}
export class Params_Modify_User_Details {
    User: User;
}
export class Params_Get_Dimension_Index_With_Simple_Upper_Level {
    UPPER_LEVEL_ID?: number;
    SELECTED_DATA_LEVEL_SETUP_ID?: number;
    SELECTED_LEVEL_ID?: number;
    LIST_SELECTED_DIMENSION_ID: number[];
    LIST_UPPER_DIMENSION_ID: number[];
    START_DATE?: string;
    END_DATE?: string;
    ENUM_TIMESPAN?: Enum_Timespan;
}
export class Params_Get_Incidents_By_Where_Sorted_With_Pagination {
    INCIDENT_ID_LIST: string[];
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
    SITE_ID_LIST: number[];
    DIMENSION_ORDER_LIST: number[];
    INCIDENT_CATEGORY_SETUP_ID_LIST: number[];
    CREATED_TIME_START?: string;
    CREATED_TIME_END?: string;
    ASSIGNED_TIME_START?: string;
    ASSIGNED_TIME_END?: string;
    CLOSED_TIME_START?: string;
    CLOSED_TIME_END?: string;
    START_ROW?: number;
    END_ROW?: number;
}
export class Params_Edit_Incident_List {
    INCIDENT_LIST: Incident[];
}
export class Params_Get_Incidents_By_Where_Count {
    INCIDENT_ID_LIST: string[];
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
    SITE_ID_LIST: number[];
    DIMENSION_ORDER_LIST: number[];
    SEVERITY_SETUP_ID_LIST: number[];
    INCIDENT_CATEGORY_SETUP_ID_LIST: number[];
    CREATED_TIME_START?: string;
    CREATED_TIME_END?: string;
    ASSIGNED_TIME_START?: string;
    ASSIGNED_TIME_END?: string;
    CLOSED_TIME_START?: string;
    CLOSED_TIME_END?: string;
}
export class Params_Get_Incidents_By_Where {
    INCIDENT_ID_LIST: string[];
    SPACE_ASSET_ID_LIST: number[];
    SPACE_ID_LIST: number[];
    FLOOR_ID_LIST: number[];
    ENTITY_ID_LIST: number[];
    SITE_ID_LIST: number[];
    DIMENSION_ORDER_LIST: number[];
    SEVERITY_SETUP_ID_LIST: number[];
    INCIDENT_CATEGORY_SETUP_ID_LIST: number[];
    CREATED_TIME_START?: string;
    CREATED_TIME_END?: string;
    ASSIGNED_TIME_START?: string;
    ASSIGNED_TIME_END?: string;
    CLOSED_TIME_START?: string;
    CLOSED_TIME_END?: string;
}
export class Params_Get_Method_run_By_METHOD_RUN_ID {
    METHOD_RUN_ID?: number;
}
export class Params_Get_Method_run_By_METHOD_RUN_ID_List {
    METHOD_RUN_ID_LIST: number[];
}
export class Params_Get_Method_run_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Get_Method_run_By_OWNER_ID_IS_DELETED {
    OWNER_ID?: number;
    IS_DELETED: boolean;
}
export class Params_Get_Method_run_By_Where {
    OWNER_ID?: number;
    METHOD_NAME: string;
    METHOD_PARAMS: string;
    OFFSET?: number;
    FETCH_NEXT?: number;
    TOTAL_COUNT?: number;
}
export class Params_Delete_Method_run {
    METHOD_RUN_ID?: number;
}
export class Params_Delete_Method_run_By_OWNER_ID {
    OWNER_ID?: number;
}
export class Params_Delete_Method_run_By_OWNER_ID_IS_DELETED {
    OWNER_ID?: number;
    IS_DELETED: boolean;
}
export class Params_Edit_Method_run_List {
    List_To_Edit: Method_run[];
    List_Failed_Edit: Method_run[];
    List_To_Delete: number[];
    List_Failed_Delete: number[];
}
export class Action_Result {
    Stack_Trace: string;
    Exception_Message: string;
}
export class Result_Get_Asset_By_ASSET_ID_List extends Action_Result {
    i_Result: Asset[];
    Params_Get_Asset_By_ASSET_ID_List: Params_Get_Asset_By_ASSET_ID_List;
}
export class Result_Edit_Asset extends Action_Result {
    Asset: Asset;
}
export class Result_Get_Asset_By_OWNER_ID extends Action_Result {
    i_Result: Asset[];
    Params_Get_Asset_By_OWNER_ID: Params_Get_Asset_By_OWNER_ID;
}
export class Result_Get_Asset_By_ASSET_ID_Adv extends Action_Result {
    i_Result: Asset;
    Params_Get_Asset_By_ASSET_ID: Params_Get_Asset_By_ASSET_ID;
}
export class Result_Get_Asset_Data_List extends Action_Result {
    i_Result: Asset_Data;
    Params_Get_Asset_Data_List: Params_Get_Asset_Data_List;
}
export class Result_Delete_Asset extends Action_Result {
    Params_Delete_Asset: Params_Delete_Asset;
}
export class Result_Get_Data_source_By_OWNER_ID extends Action_Result {
    i_Result: Data_source[];
    Params_Get_Data_source_By_OWNER_ID: Params_Get_Data_source_By_OWNER_ID;
}
export class Result_Generate_Area_Dwell_Time extends Action_Result {
    Params_Generate_Area_Dwell_Time: Params_Generate_Area_Dwell_Time;
}
export class Result_Edit_Job_List extends Action_Result {
    Params_Edit_Job_List: Params_Edit_Job_List;
}
export class Result_Generate_District_Dwell_Time extends Action_Result {
    Params_Generate_District_Dwell_Time: Params_Generate_District_Dwell_Time;
}
export class Result_Get_Visitor_Data extends Action_Result {
    i_Result: Visitor_Data;
    Params_Get_Visitor_Data: Params_Get_Visitor_Data;
}
export class Result_Edit_Kpi_List extends Action_Result {
    Params_Edit_Kpi_List: Params_Edit_Kpi_List;
}
export class Result_Insert_Entity_Kpi_Data_List extends Action_Result {
    Params_Insert_Entity_Kpi_Data_List: Params_Insert_Entity_Kpi_Data_List;
}
export class Result_Delete_Data_source extends Action_Result {
    Params_Delete_Data_source: Params_Delete_Data_source;
}
export class Result_Get_And_Fill_Bylaw_complaints_From_Api extends Action_Result {
    Params_Get_And_Fill_Bylaw_complaints_From_Api: Params_Get_And_Fill_Bylaw_complaints_From_Api;
}
export class Result_Generate_Or_Compute_District_Hourly_Data extends Action_Result {
    Params_Generate_Or_Compute_District_Hourly_Data: Params_Generate_Or_Compute_District_Hourly_Data;
}
export class Result_Generate_Or_Compute_Area_Hourly_Data extends Action_Result {
    Params_Generate_Or_Compute_Area_Hourly_Data: Params_Generate_Or_Compute_Area_Hourly_Data;
}
export class Result_Generate_Or_Compute_Site_Hourly_Data extends Action_Result {
    Params_Generate_Or_Compute_Site_Hourly_Data: Params_Generate_Or_Compute_Site_Hourly_Data;
}
export class Result_Extract_Kpi_Data_From_CSV extends Action_Result {
    i_Result: string;
    Params_Extract_Kpi_Data_From_CSV: Params_Extract_Kpi_Data_From_CSV;
}
export class Result_Generate_Area_Demographic_Data extends Action_Result {
    Params_Generate_Area_Demographic_Data: Params_Generate_Area_Demographic_Data;
}
export class Result_Get_Jobs_By_Where extends Action_Result {
    i_Result: Job[];
    Params_Get_Jobs_By_Where: Params_Get_Jobs_By_Where;
}
export class Result_Generate_Or_Compute_Floor_Hourly_Data extends Action_Result {
    Params_Generate_Or_Compute_Floor_Hourly_Data: Params_Generate_Or_Compute_Floor_Hourly_Data;
}
export class Result_Delete_Space_Kpi_Data_By_Where extends Action_Result {
    Params_Delete_Space_Kpi_Data_By_Where: Params_Delete_Space_Kpi_Data_By_Where;
}
export class Result_Generate_Site_Visitor_Data_And_Dwell_Time extends Action_Result {
    Params_Generate_Site_Visitor_Data_And_Dwell_Time: Params_Generate_Site_Visitor_Data_And_Dwell_Time;
}
export class Result_Edit_Niche_categories_List extends Action_Result {
    Params_Edit_Niche_categories_List: Params_Edit_Niche_categories_List;
}
export class Result_Delete_Niche_categories extends Action_Result {
    Params_Delete_Niche_categories: Params_Delete_Niche_categories;
}
export class Result_Delete_Site_Kpi_Data_By_Where extends Action_Result {
    Params_Delete_Site_Kpi_Data_By_Where: Params_Delete_Site_Kpi_Data_By_Where;
}
export class Result_Insert_Space_Kpi_Data_List extends Action_Result {
    Params_Insert_Space_Kpi_Data_List: Params_Insert_Space_Kpi_Data_List;
}
export class Result_Generate_Site_Demographic_Data extends Action_Result {
    Params_Generate_Site_Demographic_Data: Params_Generate_Site_Demographic_Data;
}
export class Result_Insert_Site_Kpi_Data_List extends Action_Result {
    Params_Insert_Site_Kpi_Data_List: Params_Insert_Site_Kpi_Data_List;
}
export class Result_Edit_Data_source extends Action_Result {
    Data_source: Data_source;
}
export class Result_Delete_Entity_Kpi_Data_By_Where extends Action_Result {
    Params_Delete_Entity_Kpi_Data_By_Where: Params_Delete_Entity_Kpi_Data_By_Where;
}
export class Result_Get_Demographic_Data extends Action_Result {
    i_Result: Demographic_Data;
    Params_Get_Demographic_Data: Params_Get_Demographic_Data;
}
export class Result_Generate_District_Hourly_Indexes extends Action_Result {
    Params_Generate_District_Hourly_Indexes: Params_Generate_District_Hourly_Indexes;
}
export class Result_Get_Niche_categories_By_Where extends Action_Result {
    i_Result: Niche_categories[];
    Params_Get_Niche_categories_By_Where: Params_Get_Niche_categories_By_Where;
}
export class Result_Delete_Area_Kpi_Data_By_Where extends Action_Result {
    Delete_Area_Kpi_Data_By_Where: Delete_Area_Kpi_Data_By_Where;
}
export class Result_Generate_Entity_Hourly_Indexes extends Action_Result {
    Params_Generate_Entity_Hourly_Indexes: Params_Generate_Entity_Hourly_Indexes;
}
export class Result_Generate_Worker_Data extends Action_Result {
    Params_Generate_Worker_Data: Params_Generate_Worker_Data;
}
export class Result_Delete_District_Kpi_Data_By_Where extends Action_Result {
    Params_Delete_District_Kpi_Data_By_Where: Params_Delete_District_Kpi_Data_By_Where;
}
export class Result_Edit_Organization_data_source_kpi extends Action_Result {
    Organization_data_source_kpi: Organization_data_source_kpi;
}
export class Result_Get_Telus_Auth_Token extends Action_Result {
    i_Result: string;
}
export class Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv extends Action_Result {
    i_Result: Organization_data_source_kpi[];
    Params_Get_Organization_data_source_kpi_By_OWNER_ID: Params_Get_Organization_data_source_kpi_By_OWNER_ID;
}
export class Result_Delete_Floor_Kpi_Data_By_Where extends Action_Result {
    Params_Delete_Floor_Kpi_Data_By_Where: Params_Delete_Floor_Kpi_Data_By_Where;
}
export class Result_Insert_Area_Kpi_Data_List extends Action_Result {
    Params_Insert_Area_Kpi_Data_List: Params_Insert_Area_Kpi_Data_List;
}
export class Result_Generate_Space_Hourly_Indexes extends Action_Result {
    Params_Generate_Space_Hourly_Indexes: Params_Generate_Space_Hourly_Indexes;
}
export class Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List extends Action_Result {
    Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List: Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
}
export class Result_Generate_Business_Count_And_Vacant_Business_Count extends Action_Result {
    Params_Generate_Business_Count_And_Vacant_Business_Count: Params_Generate_Business_Count_And_Vacant_Business_Count;
}
export class Result_Insert_District_Kpi_Data_List extends Action_Result {
    Params_Insert_District_Kpi_Data_List: Params_Insert_District_Kpi_Data_List;
}
export class Result_Delete_Organization_data_source_kpi extends Action_Result {
    Params_Delete_Organization_data_source_kpi: Params_Delete_Organization_data_source_kpi;
}
export class Result_Generate_Site_Hourly_Indexes extends Action_Result {
    Params_Generate_Site_Hourly_Indexes: Params_Generate_Site_Hourly_Indexes;
}
export class Result_Get_Visitor_Activity_Data extends Action_Result {
    i_Result: Visitor_Activity;
    Params_Get_Visitor_Activity_Data: Params_Get_Visitor_Activity_Data;
}
export class Result_Get_And_Fill_Public_events_From_Api extends Action_Result {
    Params_Get_And_Fill_Public_events_From_Api: Params_Get_And_Fill_Public_events_From_Api;
}
export class Result_Generate_Floor_Hourly_Indexes extends Action_Result {
    Params_Generate_Floor_Hourly_Indexes: Params_Generate_Floor_Hourly_Indexes;
}
export class Result_Generate_Area_Hourly_Indexes extends Action_Result {
    Params_Generate_Area_Hourly_Indexes: Params_Generate_Area_Hourly_Indexes;
}
export class Result_Generate_Or_Compute_Entity_Hourly_Data extends Action_Result {
    Params_Generate_Or_Compute_Entity_Hourly_Data: Params_Generate_Or_Compute_Entity_Hourly_Data;
}
export class Result_Delete_Job extends Action_Result {
    Params_Delete_Job: Params_Delete_Job;
}
export class Result_Get_And_Fill_Businesses_From_Api extends Action_Result {
}
export class Result_Generate_District_Demographic_Data extends Action_Result {
    Params_Generate_District_Demographic_Data: Params_Generate_District_Demographic_Data;
}
export class Result_Insert_Floor_Kpi_Data_List extends Action_Result {
    Params_Insert_Floor_Kpi_Data_List: Params_Insert_Floor_Kpi_Data_List;
}
export class Result_Generate_Visitor_Activity_Data extends Action_Result {
    Params_Generate_Visitor_Activity_Data: Params_Generate_Visitor_Activity_Data;
}
export class Result_Get_Floor_By_ENTITY_ID_List extends Action_Result {
    i_Result: Floor[];
    Params_Get_Floor_By_ENTITY_ID_List: Params_Get_Floor_By_ENTITY_ID_List;
}
export class Result_Edit_Entity_share_data extends Action_Result {
    i_Result: string;
    Params_Edit_Entity_share_data: Params_Edit_Entity_share_data;
}
export class Result_Get_Share_file_By_USER_ID extends Action_Result {
    i_Result: Share_file[];
    Params_Get_Share_file_By_USER_ID: Params_Get_Share_file_By_USER_ID;
}
export class Result_Get_Share_file_By_SHARE_FILE_ID extends Action_Result {
    i_Result: Share_file;
    Params_Get_Share_file_By_SHARE_FILE_ID: Params_Get_Share_file_By_SHARE_FILE_ID;
}
export class Result_Get_Entity_share_view_data extends Action_Result {
    i_Result: Entity_share_view_data;
    Params_Get_Entity_share_view_data: Params_Get_Entity_share_view_data;
}
export class Result_Send_Share_Link_By_Email extends Action_Result {
    i_Result: boolean;
    Params_Send_Share_Link_By_Email: Params_Send_Share_Link_By_Email;
}
export class Result_Delete_Share_file extends Action_Result {
    Params_Delete_Share_file: Params_Delete_Share_file;
}
export class Result_Edit_Share_file extends Action_Result {
    Share_file: Share_file;
}
export class Result_Edit_Space extends Action_Result {
    Space: Space;
}
export class Result_Get_Space_asset_By_SPACE_ID_List_Adv extends Action_Result {
    i_Result: Space_asset[];
    Params_Get_Space_asset_By_SPACE_ID_List: Params_Get_Space_asset_By_SPACE_ID_List;
}
export class Result_Get_Space_By_OWNER_ID extends Action_Result {
    i_Result: Space[];
    Params_Get_Space_By_OWNER_ID: Params_Get_Space_By_OWNER_ID;
}
export class Result_Edit_Space_asset extends Action_Result {
    Space_asset: Space_asset;
}
export class Result_Edit_Space_List extends Action_Result {
    Params_Edit_Space_List: Params_Edit_Space_List;
}
export class Result_Get_Space_asset_By_SPACE_ID_Adv extends Action_Result {
    i_Result: Space_asset[];
    Params_Get_Space_asset_By_SPACE_ID: Params_Get_Space_asset_By_SPACE_ID;
}
export class Result_Get_Space_By_FLOOR_ID extends Action_Result {
    i_Result: Space[];
    Params_Get_Space_By_FLOOR_ID: Params_Get_Space_By_FLOOR_ID;
}
export class Result_Get_Space_asset_By_SPACE_ID_List extends Action_Result {
    i_Result: Space_asset[];
    Params_Get_Space_asset_By_SPACE_ID_List: Params_Get_Space_asset_By_SPACE_ID_List;
}
export class Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv extends Action_Result {
    i_Result: Space_asset[];
    Params_Get_Space_asset_By_SPACE_ASSET_ID_List: Params_Get_Space_asset_By_SPACE_ASSET_ID_List;
}
export class Result_Edit_Space_asset_List extends Action_Result {
    Params_Edit_Space_asset_List: Params_Edit_Space_asset_List;
}
export class Result_Get_Space_asset_By_SPACE_ID extends Action_Result {
    i_Result: Space_asset[];
    Params_Get_Space_asset_By_SPACE_ID: Params_Get_Space_asset_By_SPACE_ID;
}
export class Result_Delete_Space_asset_By_SPACE_ID extends Action_Result {
    Params_Delete_Space_asset_By_SPACE_ID: Params_Delete_Space_asset_By_SPACE_ID;
}
export class Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List extends Action_Result {
    i_Result: Video_ai_asset[];
    Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List: Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
}
export class Result_Get_Report_Details extends Action_Result {
    i_Result: Report_Details;
    Params_Get_Report_Details: Params_Get_Report_Details;
}
export class Result_Send_Report_Email extends Action_Result {
    i_Result: boolean;
    Params_Send_Report_Email: Params_Send_Report_Email;
}
export class Result_Get_District_By_DISTRICT_ID_List extends Action_Result {
    i_Result: District[];
    Params_Get_District_By_DISTRICT_ID_List: Params_Get_District_By_DISTRICT_ID_List;
}
export class Result_Edit_District_view extends Action_Result {
    District_view: District_view;
}
export class Result_Get_District_view_By_DISTRICT_ID extends Action_Result {
    i_Result: District_view[];
    Params_Get_District_view_By_DISTRICT_ID: Params_Get_District_view_By_DISTRICT_ID;
}
export class Result_Get_District_By_OWNER_ID extends Action_Result {
    i_Result: District[];
    Params_Get_District_By_OWNER_ID: Params_Get_District_By_OWNER_ID;
}
export class Result_Get_District_geojson_By_DISTRICT_ID_List extends Action_Result {
    i_Result: string;
    Params_Get_District_geojson_By_DISTRICT_ID_List: Params_Get_District_geojson_By_DISTRICT_ID_List;
}
export class Result_Delete_District_view extends Action_Result {
    Params_Delete_District_view: Params_Delete_District_view;
}
export class Result_Edit_District extends Action_Result {
    District: District;
}
export class Result_Edit_District_view_List extends Action_Result {
    Params_Edit_District_view_List: Params_Edit_District_view_List;
}
export class Result_Delete_District_view_By_DISTRICT_ID extends Action_Result {
    Params_Delete_District_view_By_DISTRICT_ID: Params_Delete_District_view_By_DISTRICT_ID;
}
export class Result_Get_District_view_By_DISTRICT_ID_List extends Action_Result {
    i_Result: District_view[];
    Params_Get_District_view_By_DISTRICT_ID_List: Params_Get_District_view_By_DISTRICT_ID_List;
}
export class Result_Get_Wifi_signals extends Action_Result {
    i_Result: Wifi_signal[];
    Params_Get_Wifi_signals: Params_Get_Wifi_signals;
}
export class Result_Get_District_Kpi_Dialog_Data extends Action_Result {
    i_Result: District_Kpi_Dialog_Data[];
    Params_Get_District_Kpi_Dialog_Data: Params_Get_District_Kpi_Dialog_Data;
}
export class Result_Get_Area_Kpi_Data_Aggregate_Sum extends Action_Result {
    i_Result: Area_kpi_data[];
    Params_Get_Area_Kpi_Data_Aggregate_Sum: Params_Get_Area_Kpi_Data_Aggregate_Sum;
}
export class Result_Get_Entity_Kpi_Data_By_Where extends Action_Result {
    i_Result: Entity_kpi_data[];
    Params_Get_Entity_Kpi_Data_By_Where: Params_Get_Entity_Kpi_Data_By_Where;
}
export class Result_Compute_Area_Kpi_Data_Hourly extends Action_Result {
    Params_Compute_Area_Kpi_Data_Hourly: Params_Compute_Area_Kpi_Data_Hourly;
}
export class Result_Get_Site_Kpi_Dialog_Data extends Action_Result {
    i_Result: Site_Kpi_Dialog_Data[];
    Params_Get_Site_Kpi_Dialog_Data: Params_Get_Site_Kpi_Dialog_Data;
}
export class Result_Get_Site_Kpi_Data_By_Where extends Action_Result {
    i_Result: Site_kpi_data[];
    Params_Get_Site_Kpi_Data_By_Where: Params_Get_Site_Kpi_Data_By_Where;
}
export class Result_Edit_Alert_List extends Action_Result {
    Params_Edit_Alert_List: Params_Edit_Alert_List;
}
export class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv extends Action_Result {
    i_Result: Organization_data_source_kpi[];
    Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
}
export class Result_Compute_District_Kpi_Data_Monthly extends Action_Result {
    Params_Compute_District_Kpi_Data_Monthly: Params_Compute_District_Kpi_Data_Monthly;
}
export class Result_Get_Bylaw_Complaint_List extends Action_Result {
    i_Result: Bylaw_Complaint[];
    Params_Get_Bylaw_Complaint_List: Params_Get_Bylaw_Complaint_List;
}
export class Result_Delete_Kpi extends Action_Result {
    Params_Delete_Kpi: Params_Delete_Kpi;
}
export class Result_Delete_Wifi_signal extends Action_Result {
    Params_Delete_Wifi_signal: Params_Delete_Wifi_signal;
}
export class Result_Compute_Floor_Kpi_Data_Monthly extends Action_Result {
    Params_Compute_Floor_Kpi_Data_Monthly: Params_Compute_Floor_Kpi_Data_Monthly;
}
export class Result_Edit_Wifi_signal_alert_List extends Action_Result {
    Params_Edit_Wifi_signal_alert_List: Params_Edit_Wifi_signal_alert_List;
}
export class Result_Delete_Alert extends Action_Result {
    Params_Delete_Alert: Params_Delete_Alert;
}
export class Result_Compute_District_Kpi_Data_Weekly extends Action_Result {
    Params_Compute_District_Kpi_Data_Weekly: Params_Compute_District_Kpi_Data_Weekly;
}
export class Result_Get_District_Kpi_Data_Aggregate_Sum extends Action_Result {
    i_Result: District_kpi_data[];
    Params_Get_District_Kpi_Data_Aggregate_Sum: Params_Get_District_Kpi_Data_Aggregate_Sum;
}
export class Result_Compute_Space_Kpi_Data_Monthly extends Action_Result {
    Params_Compute_Space_Kpi_Data_Monthly: Params_Compute_Space_Kpi_Data_Monthly;
}
export class Result_Compute_Space_Kpi_Data_Daily extends Action_Result {
    Params_Compute_Space_Kpi_Data_Daily: Params_Compute_Space_Kpi_Data_Daily;
}
export class Result_Update_Kpi_Data_Record extends Action_Result {
    Params_Update_Kpi_Data_Record: Params_Update_Kpi_Data_Record;
}
export class Result_Compute_Area_Kpi_Data_Daily extends Action_Result {
    Params_Compute_Area_Kpi_Data_Daily: Params_Compute_Area_Kpi_Data_Daily;
}
export class Result_Get_Latest_Wifi_signal_alerts extends Action_Result {
    i_Result: Wifi_signal_alert[];
    Params_Get_Latest_Wifi_signal_alerts: Params_Get_Latest_Wifi_signal_alerts;
}
export class Result_Get_Floor_Kpi_Data_Aggregate_Sum extends Action_Result {
    i_Result: Floor_kpi_data[];
    Params_Get_Floor_Kpi_Data_Aggregate_Sum: Params_Get_Floor_Kpi_Data_Aggregate_Sum;
}
export class Result_Compute_Entity_Kpi_Data_Weekly extends Action_Result {
    Params_Compute_Entity_Kpi_Data_Weekly: Params_Compute_Entity_Kpi_Data_Weekly;
}
export class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv extends Action_Result {
    i_Result: Organization_data_source_kpi;
    Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID;
}
export class Result_Compute_Area_Kpi_Data_Weekly extends Action_Result {
    Params_Compute_Area_Kpi_Data_Weekly: Params_Compute_Area_Kpi_Data_Weekly;
}
export class Result_Get_Business_Trendline extends Action_Result {
    i_Result: Kpi_Value_By_Date[];
    Params_Get_Business_Trendline: Params_Get_Business_Trendline;
}
export class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv extends Action_Result {
    i_Result: Organization_data_source_kpi[];
    Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
}
export class Result_Edit_Wifi_signal_List extends Action_Result {
    Params_Edit_Wifi_signal_List: Params_Edit_Wifi_signal_List;
}
export class Result_Compute_Entity_Kpi_Data_Daily extends Action_Result {
    Params_Compute_Entity_Kpi_Data_Daily: Params_Compute_Entity_Kpi_Data_Daily;
}
export class Result_Get_Floor_Kpi_Dialog_Data extends Action_Result {
    i_Result: Floor_Kpi_Dialog_Data[];
    Params_Get_Floor_Kpi_Dialog_Data: Params_Get_Floor_Kpi_Dialog_Data;
}
export class Result_Get_Latest_GeoData_By_KPI extends Action_Result {
    i_Result: GeoData;
    Params_Get_Latest_GeoData_By_KPI: Params_Get_Latest_GeoData_By_KPI;
}
export class Result_Get_Public_Event_List extends Action_Result {
    i_Result: Public_Event[];
    Params_Get_Public_Event_List: Params_Get_Public_Event_List;
}
export class Result_Get_And_Save_Wifi_Signal_From_Api extends Action_Result {
}
export class Result_Get_Alerts_By_Where extends Action_Result {
    i_Result: Alert[];
    Params_Get_Alerts_By_Where: Params_Get_Alerts_By_Where;
}
export class Result_Compute_Site_Kpi_Data_Hourly extends Action_Result {
    Params_Compute_Site_Kpi_Data_Hourly: Params_Compute_Site_Kpi_Data_Hourly;
}
export class Result_Compute_Entity_Kpi_Data_Hourly extends Action_Result {
    Params_Compute_Entity_Kpi_Data_Hourly: Params_Compute_Entity_Kpi_Data_Hourly;
}
export class Result_Compute_Entity_Kpi_Data_Monthly extends Action_Result {
    Params_Compute_Entity_Kpi_Data_Monthly: Params_Compute_Entity_Kpi_Data_Monthly;
}
export class Result_Edit_User_Data_Access extends Action_Result {
    i_Result: Params_Edit_User_Data_Access;
    Params_Edit_User_Data_Access: Params_Edit_User_Data_Access;
}
export class Result_Get_Organization_Data_Access extends Action_Result {
    i_Result: Organization_Data_Access;
    Params_Get_Organization_Data_Access: Params_Get_Organization_Data_Access;
}
export class Result_Get_User_Data_Access extends Action_Result {
    i_Result: User_Data_Access;
    Params_Get_User_Data_Access: Params_Get_User_Data_Access;
}
export class Result_Delete_Wifi_signal_alert extends Action_Result {
    Params_Delete_Wifi_signal_alert: Params_Delete_Wifi_signal_alert;
}
export class Result_Get_Area_Kpi_Dialog_Data extends Action_Result {
    i_Result: Area_Kpi_Dialog_Data[];
    Params_Get_Area_Kpi_Dialog_Data: Params_Get_Area_Kpi_Dialog_Data;
}
export class Result_Get_Alerts_Count_For_Levels extends Action_Result {
    i_Result: number;
    Params_Get_Alerts_Count_For_Levels: Params_Get_Alerts_Count_For_Levels;
}
export class Result_Get_Space_Kpi_Data_By_Where extends Action_Result {
    i_Result: Space_kpi_data[];
    Params_Get_Space_Kpi_Data_By_Where: Params_Get_Space_Kpi_Data_By_Where;
}
export class Result_Get_Site_Kpi_Data_Aggregate_Sum extends Action_Result {
    i_Result: Site_kpi_data[];
    Params_Get_Site_Kpi_Data_Aggregate_Sum: Params_Get_Site_Kpi_Data_Aggregate_Sum;
}
export class Result_Get_Latest_Visitor_Count_By_Where extends Action_Result {
    i_Result: Visitor_Count_By_Level[];
    Params_Get_Latest_Visitor_Count_By_Where: Params_Get_Latest_Visitor_Count_By_Where;
}
export class Result_Get_Entity_Kpi_Data_Aggregate_Sum extends Action_Result {
    i_Result: Entity_kpi_data[];
    Params_Get_Entity_Kpi_Data_Aggregate_Sum: Params_Get_Entity_Kpi_Data_Aggregate_Sum;
}
export class Result_Compute_Floor_Kpi_Data_Hourly extends Action_Result {
    Params_Compute_Floor_Kpi_Data_Hourly: Params_Compute_Floor_Kpi_Data_Hourly;
}
export class Result_Get_Wifi_signal_alerts extends Action_Result {
    i_Result: Wifi_signal_alert[];
    Params_Get_Wifi_signal_alerts: Params_Get_Wifi_signal_alerts;
}
export class Result_Get_District_Kpi_Data_By_Where extends Action_Result {
    i_Result: District_kpi_data[];
    Params_Get_District_Kpi_Data_By_Where: Params_Get_District_Kpi_Data_By_Where;
}
export class Result_Get_Kpi_By_OWNER_ID_Adv extends Action_Result {
    i_Result: Kpi[];
    Params_Get_Kpi_By_OWNER_ID: Params_Get_Kpi_By_OWNER_ID;
}
export class Result_Get_Floor_Kpi_Data_By_Where extends Action_Result {
    i_Result: Floor_kpi_data[];
    Params_Get_Floor_Kpi_Data_By_Where: Params_Get_Floor_Kpi_Data_By_Where;
}
export class Result_Compute_Floor_Kpi_Data_Weekly extends Action_Result {
    Params_Compute_Floor_Kpi_Data_Weekly: Params_Compute_Floor_Kpi_Data_Weekly;
}
export class Result_Update_Wifi_signal extends Action_Result {
    i_Result: Wifi_signal_data;
    Params_Update_Wifi_signal: Params_Update_Wifi_signal;
}
export class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_data_source_kpi[];
    Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID: Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
}
export class Result_Get_Visitor_Origins extends Action_Result {
    i_Result: Visitor_Origins;
    Params_Get_Visitor_Origins: Params_Get_Visitor_Origins;
}
export class Result_Compute_Site_Kpi_Data_Daily extends Action_Result {
    Params_Compute_Site_Kpi_Data_Daily: Params_Compute_Site_Kpi_Data_Daily;
}
export class Result_Compute_District_Kpi_Data_Daily extends Action_Result {
    Params_Compute_District_Kpi_Data_Daily: Params_Compute_District_Kpi_Data_Daily;
}
export class Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly extends Action_Result {
    Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly: Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly;
}
export class Result_Get_Latest_Wifi_signals extends Action_Result {
    i_Result: Wifi_signal[];
    Params_Get_Latest_Wifi_signals: Params_Get_Latest_Wifi_signals;
}
export class Result_Get_Alerts_By_Where_Count extends Action_Result {
    i_Result: number;
    Params_Get_Alerts_By_Where_Count: Params_Get_Alerts_By_Where_Count;
}
export class Result_Get_Entity_Incidents extends Action_Result {
    i_Result: Entity_Incidents;
    Params_Get_Entity_Incidents: Params_Get_Entity_Incidents;
}
export class Result_Get_Bylaw_Complaints_Trendline extends Action_Result {
    i_Result: Kpi_Value_By_Date[];
    Params_Get_Bylaw_Complaints_Trendline: Params_Get_Bylaw_Complaints_Trendline;
}
export class Result_Get_Alerts_For_Levels extends Action_Result {
    i_Result: Alert[];
    Params_Get_Alerts_For_Levels: Params_Get_Alerts_For_Levels;
}
export class Result_Compute_Space_Kpi_Data_Weekly extends Action_Result {
    Params_Compute_Space_Kpi_Data_Weekly: Params_Compute_Space_Kpi_Data_Weekly;
}
export class Result_Get_Area_Kpi_Data_By_Where extends Action_Result {
    i_Result: Area_kpi_data[];
    Params_Get_Area_Kpi_Data_By_Where: Params_Get_Area_Kpi_Data_By_Where;
}
export class Result_Compute_Site_Kpi_Data_Monthly extends Action_Result {
    Params_Compute_Site_Kpi_Data_Monthly: Params_Compute_Site_Kpi_Data_Monthly;
}
export class Result_Compute_District_Kpi_Data_Hourly extends Action_Result {
    Params_Compute_District_Kpi_Data_Hourly: Params_Compute_District_Kpi_Data_Hourly;
}
export class Result_Get_Intersection_Kpi_Dialog_Data extends Action_Result {
    i_Result: Entity_Kpi_Dialog_Data[];
    Params_Get_Intersection_Kpi_Dialog_Data: Params_Get_Intersection_Kpi_Dialog_Data;
}
export class Result_Compute_Floor_Kpi_Data_Daily extends Action_Result {
    Params_Compute_Floor_Kpi_Data_Daily: Params_Compute_Floor_Kpi_Data_Daily;
}
export class Result_Get_Strongest_Wifi_signal extends Action_Result {
    i_Result: Best_And_Worst_Object;
    Params_Get_Strongest_Wifi_signal: Params_Get_Strongest_Wifi_signal;
}
export class Result_Compute_Area_Kpi_Data_Monthly extends Action_Result {
    Params_Compute_Area_Kpi_Data_Monthly: Params_Compute_Area_Kpi_Data_Monthly;
}
export class Result_Get_Business_List extends Action_Result {
    i_Result: Business[];
    Params_Get_Business_List: Params_Get_Business_List;
}
export class Result_Edit_Organization_Data_Access extends Action_Result {
    i_Result: Params_Edit_Organization_Data_Access;
    Params_Edit_Organization_Data_Access: Params_Edit_Organization_Data_Access;
}
export class Result_Edit_Kpi extends Action_Result {
    Kpi: Kpi;
}
export class Result_Get_Entity_Kpi_Dialog_Data extends Action_Result {
    i_Result: Entity_Kpi_Dialog_Data[];
    Params_Get_Entity_Kpi_Dialog_Data: Params_Get_Entity_Kpi_Dialog_Data;
}
export class Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID extends Action_Result {
    i_Result: Business[];
    Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID: Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID;
}
export class Result_Compute_Site_Kpi_Data_Weekly extends Action_Result {
    Params_Compute_Site_Kpi_Data_Weekly: Params_Compute_Site_Kpi_Data_Weekly;
}
export class Result_Get_Most_Wifi_signal_Count_Per_Space_asset extends Action_Result {
    i_Result: Best_And_Worst_Object;
    Params_Get_Most_Wifi_signal_Count_Per_Space_asset: Params_Get_Most_Wifi_signal_Count_Per_Space_asset;
}
export class Result_Get_Public_Events_Trendline extends Action_Result {
    i_Result: Kpi_Value_By_Date[];
    Params_Get_Public_Events_Trendline: Params_Get_Public_Events_Trendline;
}
export class Result_Get_User_By_ORGANIZATION_ID_List_Adv extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_ORGANIZATION_ID_List: Params_Get_User_By_ORGANIZATION_ID_List;
}
export class Result_Get_User_By_ORGANIZATION_ID_List extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_ORGANIZATION_ID_List: Params_Get_User_By_ORGANIZATION_ID_List;
}
export class Result_Edit_Top_level extends Action_Result {
    Top_level: Top_level;
}
export class Result_Get_Top_level_By_TOP_LEVEL_ID_List extends Action_Result {
    i_Result: Top_level[];
    Params_Get_Top_level_By_TOP_LEVEL_ID_List: Params_Get_Top_level_By_TOP_LEVEL_ID_List;
}
export class Result_Get_Top_level_By_OWNER_ID extends Action_Result {
    i_Result: Top_level[];
    Params_Get_Top_level_By_OWNER_ID: Params_Get_Top_level_By_OWNER_ID;
}
export class Result_Edit_Entity_view extends Action_Result {
    Entity_view: Entity_view;
}
export class Result_Get_Entity_view_By_ENTITY_ID extends Action_Result {
    i_Result: Entity_view[];
    Params_Get_Entity_view_By_ENTITY_ID: Params_Get_Entity_view_By_ENTITY_ID;
}
export class Result_Delete_Entity_view extends Action_Result {
    Params_Delete_Entity_view: Params_Delete_Entity_view;
}
export class Result_Get_Entity_By_SITE_ID extends Action_Result {
    i_Result: Entity[];
    Params_Get_Entity_By_SITE_ID: Params_Get_Entity_By_SITE_ID;
}
export class Result_Get_Entity_By_ENTITY_ID_Adv extends Action_Result {
    i_Result: Entity;
    Params_Get_Entity_By_ENTITY_ID: Params_Get_Entity_By_ENTITY_ID;
}
export class Result_Get_Entity_By_ENTITY_ID extends Action_Result {
    i_Result: Entity;
    Params_Get_Entity_By_ENTITY_ID: Params_Get_Entity_By_ENTITY_ID;
}
export class Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID extends Action_Result {
    i_Result: Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result;
    Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID: Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID;
}
export class Result_Get_Entity_By_ENTITY_ID_List extends Action_Result {
    i_Result: Entity[];
    Params_Get_Entity_By_ENTITY_ID_List: Params_Get_Entity_By_ENTITY_ID_List;
}
export class Result_Get_Entity_By_OWNER_ID extends Action_Result {
    i_Result: Entity[];
    Params_Get_Entity_By_OWNER_ID: Params_Get_Entity_By_OWNER_ID;
}
export class Result_Edit_Entity extends Action_Result {
    Entity: Entity;
}
export class Result_Edit_Entity_view_List extends Action_Result {
    Params_Edit_Entity_view_List: Params_Edit_Entity_view_List;
}
export class Result_Delete_Entity_view_By_ENTITY_ID extends Action_Result {
    Params_Delete_Entity_view_By_ENTITY_ID: Params_Delete_Entity_view_By_ENTITY_ID;
}
export class Result_Get_Entity_view_By_ENTITY_ID_List extends Action_Result {
    i_Result: Entity_view[];
    Params_Get_Entity_view_By_ENTITY_ID_List: Params_Get_Entity_view_By_ENTITY_ID_List;
}
export class Result_Edit_Region extends Action_Result {
    Region: Region;
}
export class Result_Get_Region_By_OWNER_ID extends Action_Result {
    i_Result: Region[];
    Params_Get_Region_By_OWNER_ID: Params_Get_Region_By_OWNER_ID;
}
export class Result_Edit_Region_view extends Action_Result {
    Region_view: Region_view;
}
export class Result_Delete_Region_view extends Action_Result {
    Params_Delete_Region_view: Params_Delete_Region_view;
}
export class Result_Get_Region_view_By_REGION_ID extends Action_Result {
    i_Result: Region_view[];
    Params_Get_Region_view_By_REGION_ID: Params_Get_Region_view_By_REGION_ID;
}
export class Result_Get_Floor_By_ENTITY_ID extends Action_Result {
    i_Result: Floor[];
    Params_Get_Floor_By_ENTITY_ID: Params_Get_Floor_By_ENTITY_ID;
}
export class Result_Get_Floor_By_ENTITY_ID_With_Space_Asset extends Action_Result {
    i_Result: Floor[];
    Params_Get_Floor_By_ENTITY_ID_With_Space_Asset: Params_Get_Floor_By_ENTITY_ID_With_Space_Asset;
}
export class Result_Get_Floor_By_OWNER_ID extends Action_Result {
    i_Result: Floor[];
    Params_Get_Floor_By_OWNER_ID: Params_Get_Floor_By_OWNER_ID;
}
export class Result_Edit_Floor extends Action_Result {
    Floor: Floor;
}
export class Result_Get_Floor_By_ENTITY_ID_Adv extends Action_Result {
    i_Result: Floor[];
    Params_Get_Floor_By_ENTITY_ID: Params_Get_Floor_By_ENTITY_ID;
}
export class Result_Get_Logs_With_Filters extends Action_Result {
    i_Result: Log_With_Count;
    Params_Get_Logs_With_Filters: Params_Get_Logs_With_Filters;
}
export class Result_Generate_Logs_Excel extends Action_Result {
    i_Result: Generate_Logs_Excel_Response;
    Params_Generate_Logs_Excel: Params_Generate_Logs_Excel;
}
export class Result_Get_Latest_Dimension_index_By_Where extends Action_Result {
    i_Result: Dimension_index_By_Level[];
    Params_Get_Latest_Dimension_index_By_Where: Params_Get_Latest_Dimension_index_By_Where;
}
export class Result_Get_Dimension_By_DIMENSION_ORDER_List extends Action_Result {
    i_Result: Dimension[];
    Params_Get_Dimension_By_DIMENSION_ORDER_List: Params_Get_Dimension_By_DIMENSION_ORDER_List;
}
export class Result_Edit_Dimension_List extends Action_Result {
    Params_Edit_Dimension_List: Params_Edit_Dimension_List;
}
export class Result_Get_Dimension_By_DIMENSION_ID_List extends Action_Result {
    i_Result: Dimension[];
    Params_Get_Dimension_By_DIMENSION_ID_List: Params_Get_Dimension_By_DIMENSION_ID_List;
}
export class Result_Get_Dimension_By_DIMENSION_ID extends Action_Result {
    i_Result: Dimension;
    Params_Get_Dimension_By_DIMENSION_ID: Params_Get_Dimension_By_DIMENSION_ID;
}
export class Result_Compute_Dimension_Index_Monthly extends Action_Result {
    Params_Compute_Dimension_Index_Monthly: Params_Compute_Dimension_Index_Monthly;
}
export class Result_Insert_Dimension_index_List extends Action_Result {
    Params_Insert_Dimension_index_List: Params_Insert_Dimension_index_List;
}
export class Result_Compute_Dimension_Index_Weekly extends Action_Result {
    Params_Compute_Dimension_Index_Weekly: Params_Compute_Dimension_Index_Weekly;
}
export class Result_Get_Dimension_By_OWNER_ID extends Action_Result {
    i_Result: Dimension[];
    Params_Get_Dimension_By_OWNER_ID: Params_Get_Dimension_By_OWNER_ID;
}
export class Result_Get_Dimension_index_By_Where extends Action_Result {
    i_Result: Dimension_index[];
    Params_Get_Dimension_index_By_Where: Params_Get_Dimension_index_By_Where;
}
export class Result_Generate_Dimension_Index_Daily extends Action_Result {
    Params_Generate_Dimension_Index_Daily: Params_Generate_Dimension_Index_Daily;
}
export class Result_Delete_Dimension_index_By_Where extends Action_Result {
    Params_Delete_Dimension_index_By_Where: Params_Delete_Dimension_index_By_Where;
}
export class Result_Edit_Site_view extends Action_Result {
    Site_view: Site_view;
}
export class Result_Get_Site_By_OWNER_ID_Adv extends Action_Result {
    i_Result: Site[];
    Params_Get_Site_By_OWNER_ID: Params_Get_Site_By_OWNER_ID;
}
export class Result_Edit_Site extends Action_Result {
    Site: Site;
}
export class Result_Get_Site_By_SITE_ID_List_Adv extends Action_Result {
    i_Result: Site[];
    Params_Get_Site_By_SITE_ID_List: Params_Get_Site_By_SITE_ID_List;
}
export class Result_Get_Site_By_SITE_ID_List extends Action_Result {
    i_Result: Site[];
    Params_Get_Site_By_SITE_ID_List: Params_Get_Site_By_SITE_ID_List;
}
export class Result_Get_Ext_study_zone_By_OWNER_ID extends Action_Result {
    i_Result: Ext_study_zone[];
    Params_Get_Ext_study_zone_By_OWNER_ID: Params_Get_Ext_study_zone_By_OWNER_ID;
}
export class Result_Delete_Site_view extends Action_Result {
    Params_Delete_Site_view: Params_Delete_Site_view;
}
export class Result_Get_Site_By_SITE_ID extends Action_Result {
    i_Result: Site;
    Params_Get_Site_By_SITE_ID: Params_Get_Site_By_SITE_ID;
}
export class Result_Get_Site_By_OWNER_ID extends Action_Result {
    i_Result: Site[];
    Params_Get_Site_By_OWNER_ID: Params_Get_Site_By_OWNER_ID;
}
export class Result_Get_Site_geojson_By_SITE_ID_List extends Action_Result {
    i_Result: string;
    Params_Get_Site_geojson_By_SITE_ID_List: Params_Get_Site_geojson_By_SITE_ID_List;
}
export class Result_Get_Site_view_By_SITE_ID extends Action_Result {
    i_Result: Site_view[];
    Params_Get_Site_view_By_SITE_ID: Params_Get_Site_view_By_SITE_ID;
}
export class Result_Edit_Ext_study_zone_List extends Action_Result {
    Params_Edit_Ext_study_zone_List: Params_Edit_Ext_study_zone_List;
}
export class Result_Edit_Site_view_List extends Action_Result {
    Params_Edit_Site_view_List: Params_Edit_Site_view_List;
}
export class Result_Delete_Site_view_By_SITE_ID extends Action_Result {
    Params_Delete_Site_view_By_SITE_ID: Params_Delete_Site_view_By_SITE_ID;
}
export class Result_Get_Site_view_By_SITE_ID_List extends Action_Result {
    i_Result: Site_view[];
    Params_Get_Site_view_By_SITE_ID_List: Params_Get_Site_view_By_SITE_ID_List;
}
export class Result_Get_Site_field_logo_By_SITE_ID_List extends Action_Result {
    i_Result: Site_field_logo[];
    Params_Get_Site_field_logo_By_SITE_ID_List: Params_Get_Site_field_logo_By_SITE_ID_List;
}
export class Result_Check_Organization_Deletion_Status extends Action_Result {
}
export class Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID extends Action_Result {
    i_Result: Organization_log_config[];
    Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID: Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID;
}
export class Result_Edit_Organization extends Action_Result {
    Organization: Organization;
}
export class Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv extends Action_Result {
    i_Result: Organization_image[];
    Params_Get_Organization_image_By_ORGANIZATION_ID_List: Params_Get_Organization_image_By_ORGANIZATION_ID_List;
}
export class Result_Delete_Organization_theme extends Action_Result {
    Params_Delete_Organization_theme: Params_Delete_Organization_theme;
}
export class Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv extends Action_Result {
    i_Result: Organization_level_access[];
    Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID: Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
}
export class Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv extends Action_Result {
    i_Result: Organization_theme[];
    Params_Get_Organization_theme_By_ORGANIZATION_ID_List: Params_Get_Organization_theme_By_ORGANIZATION_ID_List;
}
export class Result_Edit_Organization_Custom extends Action_Result {
    i_Result: Organization;
    Params_Edit_Organization_Custom: Params_Edit_Organization_Custom;
}
export class Result_Schedule_Organization_for_Delete extends Action_Result {
    i_Result: Organization;
    Params_Schedule_Organization_for_Delete: Params_Schedule_Organization_for_Delete;
}
export class Result_Modify_Data_Settings extends Action_Result {
    i_Result: Data_Settings;
    Params_Modify_Data_Settings: Params_Modify_Data_Settings;
}
export class Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List extends Action_Result {
    i_Result: Organization_color_scheme[];
    Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List: Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List;
}
export class Result_Modify_Organization_Details extends Action_Result {
    i_Result: Organization;
    Params_Modify_Organization_Details: Params_Modify_Organization_Details;
}
export class Result_Edit_Organization_color_scheme extends Action_Result {
    Organization_color_scheme: Organization_color_scheme;
}
export class Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_relation[];
    Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID: Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID;
}
export class Result_Get_Organization_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization;
    Params_Get_Organization_By_ORGANIZATION_ID: Params_Get_Organization_By_ORGANIZATION_ID;
}
export class Result_Get_Organization_theme_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_theme[];
    Params_Get_Organization_theme_By_ORGANIZATION_ID: Params_Get_Organization_theme_By_ORGANIZATION_ID;
}
export class Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID extends Action_Result {
    i_Result: Organization_level_access[];
    Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID: Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID;
}
export class Result_Edit_Organization_districtnex_module_List extends Action_Result {
    Params_Edit_Organization_districtnex_module_List: Params_Edit_Organization_districtnex_module_List;
}
export class Result_Get_Organization_By_PARENT_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization[];
    Params_Get_Organization_By_PARENT_ORGANIZATION_ID: Params_Get_Organization_By_PARENT_ORGANIZATION_ID;
}
export class Result_Edit_Organization_level_access_List extends Action_Result {
    Params_Edit_Organization_level_access_List: Params_Edit_Organization_level_access_List;
}
export class Result_Edit_Organization_theme extends Action_Result {
    Organization_theme: Organization_theme;
}
export class Result_Delete_Organization_Picture extends Action_Result {
    i_Result: boolean;
    Params_Delete_Organization_Picture: Params_Delete_Organization_Picture;
}
export class Result_Get_Organization_By_ORGANIZATION_ID_List extends Action_Result {
    i_Result: Organization[];
    Params_Get_Organization_By_ORGANIZATION_ID_List: Params_Get_Organization_By_ORGANIZATION_ID_List;
}
export class Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading extends Action_Result {
    i_Result: Organization;
    Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading: Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading;
}
export class Result_Get_Organization_color_scheme_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_color_scheme[];
    Params_Get_Organization_color_scheme_By_ORGANIZATION_ID: Params_Get_Organization_color_scheme_By_ORGANIZATION_ID;
}
export class Result_Get_Organization_By_OWNER_ID extends Action_Result {
    i_Result: Organization[];
    Params_Get_Organization_By_OWNER_ID: Params_Get_Organization_By_OWNER_ID;
}
export class Result_Edit_Organization_chart_color_List extends Action_Result {
    Params_Edit_Organization_chart_color_List: Params_Edit_Organization_chart_color_List;
}
export class Result_Get_Organization_level_access_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_level_access[];
    Params_Get_Organization_level_access_By_ORGANIZATION_ID: Params_Get_Organization_level_access_By_ORGANIZATION_ID;
}
export class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv extends Action_Result {
    i_Result: Organization_districtnex_module[];
    Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID: Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
}
export class Result_Restore_Organization extends Action_Result {
    i_Result: Organization;
    Params_Restore_Organization: Params_Restore_Organization;
}
export class Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID extends Action_Result {
    i_Result: Organization_level_access[];
    Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID: Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
}
export class Result_Delete_Organization_level_access extends Action_Result {
    Params_Delete_Organization_level_access: Params_Delete_Organization_level_access;
}
export class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_districtnex_module[];
    Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID: Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
}
export class Result_Edit_Organization_level_access extends Action_Result {
    Organization_level_access: Organization_level_access;
}
export class Result_Delete_Organization_level_access_By_ORGANIZATION_ID extends Action_Result {
    Params_Delete_Organization_level_access_By_ORGANIZATION_ID: Params_Delete_Organization_level_access_By_ORGANIZATION_ID;
}
export class Result_Edit_Organization_districtnex_module extends Action_Result {
    Organization_districtnex_module: Organization_districtnex_module;
}
export class Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID extends Action_Result {
    Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID: Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID;
}
export class Result_Edit_Organization_color_scheme_List extends Action_Result {
    Params_Edit_Organization_color_scheme_List: Params_Edit_Organization_color_scheme_List;
}
export class Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID extends Action_Result {
    Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID: Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID;
}
export class Result_Edit_Organization_log_config extends Action_Result {
    Organization_log_config: Organization_log_config;
}
export class Result_Edit_Organization_log_config_List extends Action_Result {
    Params_Edit_Organization_log_config_List: Params_Edit_Organization_log_config_List;
}
export class Result_Get_Organization_log_config_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_log_config[];
    Params_Get_Organization_log_config_By_ORGANIZATION_ID: Params_Get_Organization_log_config_By_ORGANIZATION_ID;
}
export class Result_Delete_Organization_log_config_By_ORGANIZATION_ID extends Action_Result {
    Params_Delete_Organization_log_config_By_ORGANIZATION_ID: Params_Delete_Organization_log_config_By_ORGANIZATION_ID;
}
export class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv extends Action_Result {
    i_Result: Organization_districtnex_module[];
    Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List: Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List;
}
export class Result_Get_Organization_image_By_ORGANIZATION_ID_List extends Action_Result {
    i_Result: Organization_image[];
    Params_Get_Organization_image_By_ORGANIZATION_ID_List: Params_Get_Organization_image_By_ORGANIZATION_ID_List;
}
export class Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv extends Action_Result {
    i_Result: Organization_level_access[];
    Params_Get_Organization_level_access_By_ORGANIZATION_ID_List: Params_Get_Organization_level_access_By_ORGANIZATION_ID_List;
}
export class Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv extends Action_Result {
    i_Result: Organization_log_config[];
    Params_Get_Organization_log_config_By_ORGANIZATION_ID_List: Params_Get_Organization_log_config_By_ORGANIZATION_ID_List;
}
export class Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv extends Action_Result {
    i_Result: Organization_theme[];
    Params_Get_Organization_theme_By_ORGANIZATION_ID: Params_Get_Organization_theme_By_ORGANIZATION_ID;
}
export class Result_Get_Organization_image_By_ORGANIZATION_ID extends Action_Result {
    i_Result: Organization_image[];
    Params_Get_Organization_image_By_ORGANIZATION_ID: Params_Get_Organization_image_By_ORGANIZATION_ID;
}
export class Result_Edit_Setup extends Action_Result {
    Setup: Setup;
}
export class Result_Get_Specialized_chart_configuration_By_MODULE extends Action_Result {
    i_Result: Specialized_chart_configuration[];
    Params_Get_Specialized_chart_configuration_By_MODULE: Params_Get_Specialized_chart_configuration_By_MODULE;
}
export class Result_Delete_District_geojson_By_DISTRICT_ID extends Action_Result {
    Params_Delete_District_geojson_By_DISTRICT_ID: Params_Delete_District_geojson_By_DISTRICT_ID;
}
export class Result_Get_Dimension_chart_configuration extends Action_Result {
    i_Result: Dimension_chart_configuration[];
}
export class Result_Edit_Setup_category_List extends Action_Result {
    Params_Edit_Setup_category_List: Params_Edit_Setup_category_List;
}
export class Result_Get_Districtnex_module_By_OWNER_ID extends Action_Result {
    i_Result: Districtnex_module[];
    Params_Get_Districtnex_module_By_OWNER_ID: Params_Get_Districtnex_module_By_OWNER_ID;
}
export class Result_Edit_Dimension_chart_configuration extends Action_Result {
    i_Result: Dimension_chart_configuration;
    Dimension_chart_configuration: Dimension_chart_configuration;
}
export class Result_Get_Setup_By_SETUP_ID_Adv extends Action_Result {
    i_Result: Setup;
    Params_Get_Setup_By_SETUP_ID: Params_Get_Setup_By_SETUP_ID;
}
export class Result_Get_Default_settings_By_OWNER_ID extends Action_Result {
    i_Result: Default_settings[];
    Params_Get_Default_settings_By_OWNER_ID: Params_Get_Default_settings_By_OWNER_ID;
}
export class Result_Edit_Object_View extends Action_Result {
    Params_Edit_Object_View: Params_Edit_Object_View;
}
export class Result_Get_Setup_category_By_OWNER_ID extends Action_Result {
    i_Result: Setup_category[];
    Params_Get_Setup_category_By_OWNER_ID: Params_Get_Setup_category_By_OWNER_ID;
}
export class Result_Get_Site_geojson extends Action_Result {
    i_Result: string[];
}
export class Result_Edit_District_geojson extends Action_Result {
    i_Result: string;
    Params_Edit_District_geojson: Params_Edit_District_geojson;
}
export class Result_Delete_Build_version extends Action_Result {
    Params_Delete_Build_version: Params_Delete_Build_version;
}
export class Result_Edit_Ext_study_zone_geojson extends Action_Result {
    i_Result: string;
    Params_Edit_Ext_study_zone_geojson: Params_Edit_Ext_study_zone_geojson;
}
export class Result_Delete_Default_Settings_Picture extends Action_Result {
    i_Result: boolean;
    Params_Delete_Default_Settings_Picture: Params_Delete_Default_Settings_Picture;
}
export class Result_Get_Specialized_chart_configuration extends Action_Result {
    i_Result: Specialized_chart_configuration[];
}
export class Result_Edit_Removed_extrusion_Custom_Old extends Action_Result {
    Params_Edit_Removed_extrusion_Custom_Old: Params_Edit_Removed_extrusion_Custom_Old;
}
export class Result_Get_Area_geojson extends Action_Result {
    i_Result: string[];
}
export class Result_Delete_Setup_category extends Action_Result {
    Params_Delete_Setup_category: Params_Delete_Setup_category;
}
export class Result_Get_Build_version_By_OWNER_ID_Adv extends Action_Result {
    i_Result: Build_version[];
    Params_Get_Build_version_By_OWNER_ID: Params_Get_Build_version_By_OWNER_ID;
}
export class Result_Edit_Build_version extends Action_Result {
    Build_version: Build_version;
}
export class Result_Get_Default_chart_color_By_OWNER_ID_Adv extends Action_Result {
    i_Result: Default_chart_color[];
    Params_Get_Default_chart_color_By_OWNER_ID: Params_Get_Default_chart_color_By_OWNER_ID;
}
export class Result_Edit_Default_chart_color_List extends Action_Result {
    Params_Edit_Default_chart_color_List: Params_Edit_Default_chart_color_List;
}
export class Result_Get_District_geojson extends Action_Result {
    i_Result: string[];
}
export class Result_Edit_Specialized_chart_configuration extends Action_Result {
    i_Result: Specialized_chart_configuration;
    Specialized_chart_configuration: Specialized_chart_configuration;
}
export class Result_Get_Setup_category_By_SETUP_CATEGORY_ID extends Action_Result {
    i_Result: Setup_category;
    Params_Get_Setup_category_By_SETUP_CATEGORY_ID: Params_Get_Setup_category_By_SETUP_CATEGORY_ID;
}
export class Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID extends Action_Result {
    Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID: Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID;
}
export class Result_Edit_Setup_category extends Action_Result {
    Setup_category: Setup_category;
}
export class Result_Edit_Alert_settings_List extends Action_Result {
    Params_Edit_Alert_settings_List: Params_Edit_Alert_settings_List;
}
export class Result_Delete_Dimension_chart_configuration extends Action_Result {
    Params_Delete_Dimension_chart_configuration: Params_Delete_Dimension_chart_configuration;
}
export class Result_Get_Initial_Districtnex_Admin_Settings extends Action_Result {
    i_Result: Initial_Districtnex_Admin_Settings;
}
export class Result_Edit_Site_geojson extends Action_Result {
    i_Result: string;
    Params_Edit_Site_geojson: Params_Edit_Site_geojson;
}
export class Result_Delete_Area_geojson_By_AREA_ID extends Action_Result {
    Params_Delete_Area_geojson_By_AREA_ID: Params_Delete_Area_geojson_By_AREA_ID;
}
export class Result_Edit_Default_settings extends Action_Result {
    Default_settings: Default_settings;
}
export class Result_Delete_Specialized_chart_configuration extends Action_Result {
    Params_Delete_Specialized_chart_configuration: Params_Delete_Specialized_chart_configuration;
}
export class Result_Get_Initial_Districtnex_UI_Settings extends Action_Result {
    i_Result: Initial_Districtnex_UI_Settings;
}
export class Result_Get_Alert_settings_By_OWNER_ID_Adv extends Action_Result {
    i_Result: Alert_settings[];
    Params_Get_Alert_settings_By_OWNER_ID: Params_Get_Alert_settings_By_OWNER_ID;
}
export class Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID extends Action_Result {
    i_Result: Build_version[];
    Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID: Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID;
}
export class Result_Edit_Removed_extrusion_Custom extends Action_Result {
    Params_Edit_Removed_extrusion_Custom: Params_Edit_Removed_extrusion_Custom;
}
export class Result_Clean_Removed_extrusions extends Action_Result {
}
export class Result_Delete_Kpi_chart_configuration extends Action_Result {
    Params_Delete_Kpi_chart_configuration: Params_Delete_Kpi_chart_configuration;
}
export class Result_Get_UI_Build_Version_List extends Action_Result {
    i_Result: Build_Version_List_With_Logs;
}
export class Result_Get_Ext_study_zone_geojson extends Action_Result {
    i_Result: string[];
}
export class Result_Custom_Edit_Build_version extends Action_Result {
    i_Result: Build_version;
    Params_Custom_Edit_Build_version: Params_Custom_Edit_Build_version;
}
export class Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID extends Action_Result {
    i_Result: Setup_category;
    Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID: Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID;
}
export class Result_Get_Default_chart_color_By_OWNER_ID extends Action_Result {
    i_Result: Default_chart_color[];
    Params_Get_Default_chart_color_By_OWNER_ID: Params_Get_Default_chart_color_By_OWNER_ID;
}
export class Result_Get_Setup_By_OWNER_ID extends Action_Result {
    i_Result: Setup[];
    Params_Get_Setup_By_OWNER_ID: Params_Get_Setup_By_OWNER_ID;
}
export class Result_Edit_Area_geojson extends Action_Result {
    i_Result: string;
    Params_Edit_Area_geojson: Params_Edit_Area_geojson;
}
export class Result_Delete_Site_geojson_By_SITE_ID extends Action_Result {
    Params_Delete_Site_geojson_By_SITE_ID: Params_Delete_Site_geojson_By_SITE_ID;
}
export class Result_Get_Admin_Build_Version_List extends Action_Result {
    i_Result: Build_Version_List_With_Logs;
}
export class Result_Edit_Removed_extrusion_List extends Action_Result {
    Params_Edit_Removed_extrusion_List: Params_Edit_Removed_extrusion_List;
}
export class Result_Edit_Kpi_chart_configuration extends Action_Result {
    i_Result: Kpi_chart_configuration;
    Kpi_chart_configuration: Kpi_chart_configuration;
}
export class Result_Get_Kpi_chart_configuration extends Action_Result {
    i_Result: Kpi_chart_configuration[];
}
export class Result_Get_Removed_extrusion_By_OWNER_ID extends Action_Result {
    i_Result: Removed_extrusion[];
    Params_Get_Removed_extrusion_By_OWNER_ID: Params_Get_Removed_extrusion_By_OWNER_ID;
}
export class Result_Delete_Setup extends Action_Result {
    Params_Delete_Setup: Params_Delete_Setup;
}
export class Result_Get_Alert_settings_By_USER_ID_Adv extends Action_Result {
    i_Result: Alert_settings[];
    Params_Get_Alert_settings_By_USER_ID: Params_Get_Alert_settings_By_USER_ID;
}
export class Result_Send_Support_Email extends Action_Result {
    Params_Send_Support_Email: Params_Send_Support_Email;
}
export class Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List extends Action_Result {
    i_Result: Districtnex_module[];
    Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List: Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List;
}
export class Result_Drop_Collection extends Action_Result {
    Params_Drop_Collection: Params_Drop_Collection;
}
export class Result_Edit_Build_version_List extends Action_Result {
    Params_Edit_Build_version_List: Params_Edit_Build_version_List;
}
export class Result_Create_Time_series_Collection extends Action_Result {
    Params_Create_Time_series_Collection: Params_Create_Time_series_Collection;
}
export class Result_Get_Setup_By_SETUP_ID extends Action_Result {
    i_Result: Setup;
    Params_Get_Setup_By_SETUP_ID: Params_Get_Setup_By_SETUP_ID;
}
export class Result_Edit_Correlation_method extends Action_Result {
    Correlation_method: Correlation_method;
}
export class Result_Get_Correlation_method_By_OWNER_ID extends Action_Result {
    i_Result: Correlation_method[];
    Params_Get_Correlation_method_By_OWNER_ID: Params_Get_Correlation_method_By_OWNER_ID;
}
export class Result_Delete_Correlation_method extends Action_Result {
    Params_Delete_Correlation_method: Params_Delete_Correlation_method;
}
export class Result_Get_Correlation extends Action_Result {
    i_Result: Kpi_Value_By_Date[];
    Params_Get_Correlation: Params_Get_Correlation;
}
export class Result_Get_Comparison_Data extends Action_Result {
    i_Result: Comparison_Data;
    Params_Get_Comparison_Data: Params_Get_Comparison_Data;
}
export class Result_Get_Multi_kpi_comparison extends Action_Result {
    i_Result: Kpi_Value_By_Direction[];
    Params_Get_Multi_kpi_comparison: Params_Get_Multi_kpi_comparison;
}
export class Result_Get_Single_kpi_comparison extends Action_Result {
    i_Result: Kpi_Value_By_Date[];
    Params_Get_Single_kpi_comparison: Params_Get_Single_kpi_comparison;
}
export class Result_Fetch_Scenes extends Action_Result {
    i_Result: Fetch_Scenes_Response;
    Params_Fetch_Scenes: Params_Fetch_Scenes;
}
export class Result_Get_Vehicle_Types extends Action_Result {
    i_Result: string[];
    Params_Get_Vehicle_Types: Params_Get_Vehicle_Types;
}
export class Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID extends Action_Result {
    i_Result: Video_ai_instance;
    Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID: Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID;
}
export class Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID extends Action_Result {
    i_Result: Video_ai_instance[];
    Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID: Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID;
}
export class Result_Create_Video_ai_asset extends Action_Result {
    i_Result: Video_ai_asset;
    Params_Create_Video_ai_asset: Params_Create_Video_ai_asset;
}
export class Result_Update_License_Plate_Recognition_Alerts extends Action_Result {
    i_Result: boolean;
}
export class Result_Change_Video_ai_instance_Password extends Action_Result {
    i_Result: Change_Video_ai_instance_Password_Response;
    Params_Change_Video_ai_instance_Password: Params_Change_Video_ai_instance_Password;
}
export class Result_Face_Target_Key_Search extends Action_Result {
    i_Result: Search_Face_Target_Key_Response_List;
    Params_Face_Target_Key_Search: Params_Face_Target_Key_Search;
}
export class Result_Face_Search extends Action_Result {
    i_Result: Face_Key_Response_List;
    Params_Face_Search: Params_Face_Search;
}
export class Result_Fetch_License_Plate_Categories extends Action_Result {
    i_Result: License_Plate_Category[];
    Params_Fetch_License_Plate_Categories: Params_Fetch_License_Plate_Categories;
}
export class Result_Fetch_Face_Targets extends Action_Result {
    i_Result: Fetch_Face_Targets_Response;
    Params_Fetch_Face_Targets: Params_Fetch_Face_Targets;
}
export class Result_Fetch_Facial_Recognition extends Action_Result {
    i_Result: Fetch_Facial_Recognition_Reponse;
    Params_Fetch_Facial_Recognition: Params_Fetch_Facial_Recognition;
}
export class Result_Delete_Video_ai_asset_Custom extends Action_Result {
    i_Result: boolean;
    Params_Delete_Video_ai_asset_Custom: Params_Delete_Video_ai_asset_Custom;
}
export class Result_Update_Facial_Recognition_Alerts extends Action_Result {
    i_Result: boolean;
}
export class Result_Get_Video_ai_engine_By_OWNER_ID extends Action_Result {
    i_Result: Video_ai_engine[];
    Params_Get_Video_ai_engine_By_OWNER_ID: Params_Get_Video_ai_engine_By_OWNER_ID;
}
export class Result_Fetch_License_Plate_Targets extends Action_Result {
    i_Result: Fetch_License_Plate_Targets_Response;
    Params_Fetch_License_Plate_Targets: Params_Fetch_License_Plate_Targets;
}
export class Result_Get_Video_ai_asset_By_OWNER_ID extends Action_Result {
    i_Result: Video_ai_asset[];
    Params_Get_Video_ai_asset_By_OWNER_ID: Params_Get_Video_ai_asset_By_OWNER_ID;
}
export class Result_Get_Stream_Data extends Action_Result {
    i_Result: Stream_Data;
    Params_Get_Stream_Data: Params_Get_Stream_Data;
}
export class Result_Fetch_License_Plate_Recognition extends Action_Result {
    i_Result: Fetch_License_Plate_Recognition_Response;
    Params_Fetch_License_Plate_Recognition: Params_Fetch_License_Plate_Recognition;
}
export class Result_Get_Scene_Info extends Action_Result {
    i_Result: Scene_Info;
    Params_Get_Scene_Info: Params_Get_Scene_Info;
}
export class Result_Update_Alerts_Custom extends Action_Result {
    i_Result: boolean;
}
export class Result_Get_Countings extends Action_Result {
    i_Result: Get_Countings_Response[];
    Params_Get_Countings: Params_Get_Countings;
}
export class Result_Get_Camera_Lines extends Action_Result {
    i_Result: Camera_Lines[];
    Params_Get_Camera_Lines: Params_Get_Camera_Lines;
}
export class Result_Edit_Video_ai_asset extends Action_Result {
    Video_ai_asset: Video_ai_asset;
}
export class Result_Get_Space_asset_Vaidio_camera extends Action_Result {
    i_Result: Video_ai_asset;
    Params_Get_Space_asset_Vaidio_camera: Params_Get_Space_asset_Vaidio_camera;
}
export class Result_Update_Alerts extends Action_Result {
    i_Result: boolean;
}
export class Result_Get_License_Plate_Scene extends Action_Result {
    i_Result: Scene_Details;
    Params_Get_License_Plate_Scene: Params_Get_License_Plate_Scene;
}
export class Result_Get_Video_ai_assets_with_engine_assets extends Action_Result {
    i_Result: Video_ai_assets_with_engine_assets;
    Params_Get_Video_ai_assets_with_engine_assets: Params_Get_Video_ai_assets_with_engine_assets;
}
export class Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv extends Action_Result {
    i_Result: Video_ai_asset[];
    Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List: Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
}
export class Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List extends Action_Result {
    i_Result: Video_ai_asset[];
    Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List: Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List;
}
export class Result_Create_Video_ai_instance extends Action_Result {
    i_Result: Video_ai_instance;
    Params_Create_Video_ai_instance: Params_Create_Video_ai_instance;
}
export class Result_Delete_Video_ai_engine extends Action_Result {
    Params_Delete_Video_ai_engine: Params_Delete_Video_ai_engine;
}
export class Result_Fetch_Face_Target_Categories extends Action_Result {
    i_Result: Face_Target_Response_Category[];
    Params_Fetch_Face_Target_Categories: Params_Fetch_Face_Target_Categories;
}
export class Result_Get_Vehicle_Countings extends Action_Result {
    i_Result: Vehicle_Counting;
    Params_Get_Vehicle_Countings: Params_Get_Vehicle_Countings;
}
export class Result_Edit_Video_ai_instance_custom extends Action_Result {
    i_Result: Video_ai_instance_with_connection_flag;
    Params_Edit_Video_ai_instance_custom: Params_Edit_Video_ai_instance_custom;
}
export class Result_Send_Alerts_Email extends Action_Result {
    i_Result: boolean;
    Params_Send_Alerts_Email: Params_Send_Alerts_Email;
}
export class Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv extends Action_Result {
    i_Result: Video_ai_asset;
    Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID: Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID;
}
export class Result_Delete_Video_ai_instance extends Action_Result {
    Params_Delete_Video_ai_instance: Params_Delete_Video_ai_instance;
}
export class Result_Edit_Video_ai_instance extends Action_Result {
    Video_ai_instance: Video_ai_instance;
}
export class Result_Edit_Video_ai_engine_List extends Action_Result {
    Params_Edit_Video_ai_engine_List: Params_Edit_Video_ai_engine_List;
}
export class Result_Edit_Video_ai_engine extends Action_Result {
    Video_ai_engine: Video_ai_engine;
}
export class Result_Get_Sites_and_Entities extends Action_Result {
    i_Result: Sites_and_Entities;
}
export class Result_Delete_Object extends Action_Result {
    Params_Delete_Object: Params_Delete_Object;
}
export class Result_Delete_Object_List extends Action_Result {
    Params_Delete_Object_List: Params_Delete_Object_List;
}
export class Result_Upload_Object extends Action_Result {
    Params_Upload_Object: Params_Upload_Object;
}
export class Result_Get_Area_view_By_AREA_ID extends Action_Result {
    i_Result: Area_view[];
    Params_Get_Area_view_By_AREA_ID: Params_Get_Area_view_By_AREA_ID;
}
export class Result_Edit_Area_view extends Action_Result {
    Area_view: Area_view;
}
export class Result_Edit_Area extends Action_Result {
    Area: Area;
}
export class Result_Get_Area_geojson_By_AREA_ID_List extends Action_Result {
    i_Result: string;
    Params_Get_Area_geojson_By_AREA_ID_List: Params_Get_Area_geojson_By_AREA_ID_List;
}
export class Result_Get_Area_By_OWNER_ID extends Action_Result {
    i_Result: Area[];
    Params_Get_Area_By_OWNER_ID: Params_Get_Area_By_OWNER_ID;
}
export class Result_Get_Area_By_AREA_ID_List extends Action_Result {
    i_Result: Area[];
    Params_Get_Area_By_AREA_ID_List: Params_Get_Area_By_AREA_ID_List;
}
export class Result_Delete_Area_view extends Action_Result {
    Params_Delete_Area_view: Params_Delete_Area_view;
}
export class Result_Edit_Area_view_List extends Action_Result {
    Params_Edit_Area_view_List: Params_Edit_Area_view_List;
}
export class Result_Delete_Area_view_By_AREA_ID extends Action_Result {
    Params_Delete_Area_view_By_AREA_ID: Params_Delete_Area_view_By_AREA_ID;
}
export class Result_Get_Area_view_By_AREA_ID_List extends Action_Result {
    i_Result: Area_view[];
    Params_Get_Area_view_By_AREA_ID_List: Params_Get_Area_view_By_AREA_ID_List;
}
export class Result_Get_Secret extends Action_Result {
    i_Result: string;
    Params_Get_Secret: Params_Get_Secret;
}
export class Result_Primary_Authentication extends Action_Result {
    i_Result: Primary_Authentication_Response;
    Params_Primary_Authentication: Params_Primary_Authentication;
}
export class Result_OTP_Verification extends Action_Result {
    i_Result: User_Details;
    Params_OTP_Verification: Params_OTP_Verification;
}
export class Result_Send_Otp extends Action_Result {
    i_Result: Send_Otp_Response;
    Params_Send_Otp: Params_Send_Otp;
}
export class Result_Verify_Otp extends Action_Result {
    i_Result: boolean;
    Params_Verify_Otp: Params_Verify_Otp;
}
export class Result_Change_User_Forgotten_Password extends Action_Result {
    i_Result: boolean;
    Params_Change_User_Forgotten_Password: Params_Change_User_Forgotten_Password;
}
export class Result_Create_User extends Action_Result {
    i_Result: User;
    Params_Create_User: Params_Create_User;
}
export class Result_Change_User_Password extends Action_Result {
    i_Result: boolean;
    Params_Change_User_Password: Params_Change_User_Password;
}
export class Result_Edit_Area_kpi extends Action_Result {
    Area_kpi: Area_kpi;
}
export class Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List extends Action_Result {
    i_Result: User_level_access[];
    Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List: Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List;
}
export class Result_Edit_User_Walkthrough extends Action_Result {
    Params_Edit_User_Walkthrough: Params_Edit_User_Walkthrough;
}
export class Result_Schedule_User_for_Delete extends Action_Result {
    i_Result: User;
    Params_Schedule_User_for_Delete: Params_Schedule_User_for_Delete;
}
export class Result_Get_User_Accessible_Level_List extends Action_Result {
    i_Result: User_Accessible_Level_List;
    Params_Get_User_Accessible_Level_List: Params_Get_User_Accessible_Level_List;
}
export class Result_Edit_District_kpi_user_access_List extends Action_Result {
    Params_Edit_District_kpi_user_access_List: Params_Edit_District_kpi_user_access_List;
}
export class Result_Delete_Area_kpi extends Action_Result {
    Params_Delete_Area_kpi: Params_Delete_Area_kpi;
}
export class Result_Get_User_level_access_By_USER_ID_List extends Action_Result {
    i_Result: User_level_access[];
    Params_Get_User_level_access_By_USER_ID_List: Params_Get_User_level_access_By_USER_ID_List;
}
export class Result_Delete_User_level_access extends Action_Result {
    Params_Delete_User_level_access: Params_Delete_User_level_access;
}
export class Result_Edit_Entity_kpi_List extends Action_Result {
    Params_Edit_Entity_kpi_List: Params_Edit_Entity_kpi_List;
}
export class Result_Get_User_By_ORGANIZATION_ID_Adv extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_ORGANIZATION_ID: Params_Get_User_By_ORGANIZATION_ID;
}
export class Result_Edit_User_Details extends Action_Result {
    i_Result: boolean;
    Params_Edit_User_Details: Params_Edit_User_Details;
}
export class Result_Edit_District_kpi_List extends Action_Result {
    Params_Edit_District_kpi_List: Params_Edit_District_kpi_List;
}
export class Result_Edit_Entity_kpi extends Action_Result {
    Entity_kpi: Entity_kpi;
}
export class Result_Get_User_Accessible_Data_With_Level_List extends Action_Result {
    i_Result: User_Accessible_Data_With_Level_List;
    Params_Get_User_Accessible_Data_With_Level_List: Params_Get_User_Accessible_Data_With_Level_List;
}
export class Result_Get_User_districtnex_module_By_USER_ID_List extends Action_Result {
    i_Result: User_districtnex_module[];
    Params_Get_User_districtnex_module_By_USER_ID_List: Params_Get_User_districtnex_module_By_USER_ID_List;
}
export class Result_Get_User_By_USER_ID_List extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_USER_ID_List: Params_Get_User_By_USER_ID_List;
}
export class Result_Get_User_districtnex_module_By_USER_ID extends Action_Result {
    i_Result: User_districtnex_module[];
    Params_Get_User_districtnex_module_By_USER_ID: Params_Get_User_districtnex_module_By_USER_ID;
}
export class Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID extends Action_Result {
    i_Result: User_level_access[];
    Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID: Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID;
}
export class Result_Get_User_By_ORGANIZATION_ID extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_ORGANIZATION_ID: Params_Get_User_By_ORGANIZATION_ID;
}
export class Result_Edit_Entity_kpi_user_access_List extends Action_Result {
    Params_Edit_Entity_kpi_user_access_List: Params_Edit_Entity_kpi_user_access_List;
}
export class Result_Get_User_By_USER_ID_List_Adv extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_USER_ID_List: Params_Get_User_By_USER_ID_List;
}
export class Result_Edit_Site_kpi_user_access extends Action_Result {
    Site_kpi_user_access: Site_kpi_user_access;
}
export class Result_Edit_Entity_kpi_user_access extends Action_Result {
    Entity_kpi_user_access: Entity_kpi_user_access;
}
export class Result_Edit_Area_kpi_List extends Action_Result {
    Params_Edit_Area_kpi_List: Params_Edit_Area_kpi_List;
}
export class Result_Delete_Site_kpi extends Action_Result {
    Params_Delete_Site_kpi: Params_Delete_Site_kpi;
}
export class Result_Edit_User_level_access_List extends Action_Result {
    Params_Edit_User_level_access_List: Params_Edit_User_level_access_List;
}
export class Result_Delete_Entity_kpi extends Action_Result {
    Params_Delete_Entity_kpi: Params_Delete_Entity_kpi;
}
export class Result_Get_User_Accessible_Data extends Action_Result {
    i_Result: User_Accessible_Data;
    Params_Get_User_Accessible_Data: Params_Get_User_Accessible_Data;
}
export class Result_Edit_User_districtnex_module_List extends Action_Result {
    Params_Edit_User_districtnex_module_List: Params_Edit_User_districtnex_module_List;
}
export class Result_Edit_Site_kpi_user_access_List extends Action_Result {
    Params_Edit_Site_kpi_user_access_List: Params_Edit_Site_kpi_user_access_List;
}
export class Result_Get_Initial_Data extends Action_Result {
    i_Result: Initial_Data;
    Params_Get_Initial_Data: Params_Get_Initial_Data;
}
export class Result_Edit_District_kpi extends Action_Result {
    District_kpi: District_kpi;
}
export class Result_Change_Password extends Action_Result {
    i_Result: boolean;
    Params_Change_Password: Params_Change_Password;
}
export class Result_Delete_District_kpi extends Action_Result {
    Params_Delete_District_kpi: Params_Delete_District_kpi;
}
export class Result_Edit_Site_kpi_List extends Action_Result {
    Params_Edit_Site_kpi_List: Params_Edit_Site_kpi_List;
}
export class Result_Get_Entity_Intersection_List extends Action_Result {
    i_Result: Entity[];
    Params_Get_Entity_Intersection_List: Params_Get_Entity_Intersection_List;
}
export class Result_Check_User_Deletion_Status extends Action_Result {
}
export class Result_Get_User_By_IS_RECEIVE_EMAIL extends Action_Result {
    i_Result: User[];
    Params_Get_User_By_IS_RECEIVE_EMAIL: Params_Get_User_By_IS_RECEIVE_EMAIL;
}
export class Result_Get_User_By_USER_ID extends Action_Result {
    i_Result: User;
    Params_Get_User_By_USER_ID: Params_Get_User_By_USER_ID;
}
export class Result_Get_User_level_access_By_USER_ID extends Action_Result {
    i_Result: User_level_access[];
    Params_Get_User_level_access_By_USER_ID: Params_Get_User_level_access_By_USER_ID;
}
export class Result_Get_Level_Data extends Action_Result {
    i_Result: Level_Data;
    Params_Get_Level_Data: Params_Get_Level_Data;
}
export class Result_Restore_User extends Action_Result {
    i_Result: User;
    Params_Restore_User: Params_Restore_User;
}
export class Result_Get_User_districtnex_module_By_USER_ID_Adv extends Action_Result {
    i_Result: User_districtnex_module[];
    Params_Get_User_districtnex_module_By_USER_ID: Params_Get_User_districtnex_module_By_USER_ID;
}
export class Result_Edit_User_theme extends Action_Result {
    User_theme: User_theme;
}
export class Result_Edit_User_List extends Action_Result {
    Params_Edit_User_List: Params_Edit_User_List;
}
export class Result_Get_Admin_Data extends Action_Result {
    i_Result: Admin_Data;
    Params_Get_Admin_Data: Params_Get_Admin_Data;
}
export class Result_Get_User_By_USER_ID_Adv extends Action_Result {
    i_Result: User;
    Params_Get_User_By_USER_ID: Params_Get_User_By_USER_ID;
}
export class Result_Get_User_theme_By_USER_ID extends Action_Result {
    i_Result: User_theme[];
    Params_Get_User_theme_By_USER_ID: Params_Get_User_theme_By_USER_ID;
}
export class Result_Edit_Site_kpi extends Action_Result {
    Site_kpi: Site_kpi;
}
export class Result_Edit_Area_kpi_user_access_List extends Action_Result {
    Params_Edit_Area_kpi_user_access_List: Params_Edit_Area_kpi_user_access_List;
}
export class Result_Delete_User_theme extends Action_Result {
    Params_Delete_User_theme: Params_Delete_User_theme;
}
export class Result_Edit_Area_kpi_user_access extends Action_Result {
    Area_kpi_user_access: Area_kpi_user_access;
}
export class Result_Edit_District_kpi_user_access extends Action_Result {
    District_kpi_user_access: District_kpi_user_access;
}
export class Result_Modify_User_Details extends Action_Result {
    i_Result: User;
    Params_Modify_User_Details: Params_Modify_User_Details;
}
export class Result_Get_Dimension_Index_With_Simple_Upper_Level extends Action_Result {
    i_Result: Dimension_Index_With_Simple_Upper_Level;
    Params_Get_Dimension_Index_With_Simple_Upper_Level: Params_Get_Dimension_Index_With_Simple_Upper_Level;
}
export class Result_Get_Incidents_By_Where_Sorted_With_Pagination extends Action_Result {
    i_Result: Incident_With_Count;
    Params_Get_Incidents_By_Where_Sorted_With_Pagination: Params_Get_Incidents_By_Where_Sorted_With_Pagination;
}
export class Result_Edit_Incident_List extends Action_Result {
    Params_Edit_Incident_List: Params_Edit_Incident_List;
}
export class Result_Delete_Incident extends Action_Result {
}
export class Result_Get_Incidents_By_Where_Count extends Action_Result {
    i_Result: number;
    Params_Get_Incidents_By_Where_Count: Params_Get_Incidents_By_Where_Count;
}
export class Result_Get_Incidents_By_Where extends Action_Result {
    i_Result: Incident[];
    Params_Get_Incidents_By_Where: Params_Get_Incidents_By_Where;
}
export class Result_Get_Method_run_By_METHOD_RUN_ID extends Action_Result {
    i_Result: Method_run;
    Params_Get_Method_run_By_METHOD_RUN_ID: Params_Get_Method_run_By_METHOD_RUN_ID;
}
export class Result_Get_Method_run_By_METHOD_RUN_ID_List extends Action_Result {
    i_Result: Method_run[];
    Params_Get_Method_run_By_METHOD_RUN_ID_List: Params_Get_Method_run_By_METHOD_RUN_ID_List;
}
export class Result_Get_Method_run_By_OWNER_ID extends Action_Result {
    i_Result: Method_run[];
    Params_Get_Method_run_By_OWNER_ID: Params_Get_Method_run_By_OWNER_ID;
}
export class Result_Get_Method_run_By_OWNER_ID_IS_DELETED extends Action_Result {
    i_Result: Method_run[];
    Params_Get_Method_run_By_OWNER_ID_IS_DELETED: Params_Get_Method_run_By_OWNER_ID_IS_DELETED;
}
export class Result_Get_Method_run_By_Where extends Action_Result {
    i_Result: Method_run[];
    Params_Get_Method_run_By_Where: Params_Get_Method_run_By_Where;
}
export class Result_Delete_Method_run extends Action_Result {
    Params_Delete_Method_run: Params_Delete_Method_run;
}
export class Result_Delete_Method_run_By_OWNER_ID extends Action_Result {
    Params_Delete_Method_run_By_OWNER_ID: Params_Delete_Method_run_By_OWNER_ID;
}
export class Result_Delete_Method_run_By_OWNER_ID_IS_DELETED extends Action_Result {
    Params_Delete_Method_run_By_OWNER_ID_IS_DELETED: Params_Delete_Method_run_By_OWNER_ID_IS_DELETED;
}
export class Result_Edit_Method_run extends Action_Result {
    Method_run: Method_run;
}
export class Result_Edit_Method_run_List extends Action_Result {
    Params_Edit_Method_run_List: Params_Edit_Method_run_List;
}
