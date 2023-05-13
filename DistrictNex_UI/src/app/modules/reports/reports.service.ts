import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Dimension, Enum_Timespan, Params_Get_Report_Details, Proxy, Report_Details } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';

@Injectable({
    providedIn: 'root'
})
export class ReportsService {
    oReport_Details: Report_Details;
    oParams_Get_Report_Details: Params_Get_Report_Details;

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
        public TimezoneService: TimezoneService,
    ) { }

    Get_Dimension_By_OWNER_ID(): Promise<Dimension[]> {
        return new Promise((resolve, reject) => {
            if (this.CmSvc.oList_Dimension) {
                resolve(this.CmSvc.oList_Dimension);
            }
            else {
                this.proxy.Get_Dimension_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    if (result) {
                        this.CmSvc.oList_Dimension = result;
                        resolve(this.CmSvc.oList_Dimension);
                    }
                    else {
                        reject();
                    }
                })
            }
        })
    }

    Get_File_Color(extension): string {
        switch (extension) {
            case '.pdf':
                return 'bg-red-600';
            case 'folder':
                return 'bg-teal-700';
            default:
                return 'bg-red-600';
        }
    }

    Get_Report_Details(i_Params_Get_Report_Details: Params_Get_Report_Details): Promise<Report_Details> {
        return new Promise(resolve => {
            if (i_Params_Get_Report_Details.ENUM_TIMESPAN == null) {
                i_Params_Get_Report_Details.ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION;
            }

            if (i_Params_Get_Report_Details.START_DATE == null) {
                let endDate = new Date();
                let startDate = new Date();
                switch (i_Params_Get_Report_Details.ENUM_TIMESPAN) {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        startDate.setDate(startDate.getDate() - 1);
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        startDate.setMonth(startDate.getMonth() - 1);
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        startDate.setFullYear(startDate.getFullYear() - 1);
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        startDate.setFullYear(startDate.getFullYear() - 12);
                        break;
                }
                i_Params_Get_Report_Details.START_DATE = startDate.toUTCString();
                i_Params_Get_Report_Details.END_DATE = endDate.toUTCString();
            }

            if (i_Params_Get_Report_Details.START_DATE) {
                i_Params_Get_Report_Details.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(i_Params_Get_Report_Details.START_DATE).toISOString();
            }
            if (i_Params_Get_Report_Details.END_DATE) {
                i_Params_Get_Report_Details.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(i_Params_Get_Report_Details.END_DATE).toISOString();
            }
            this.oParams_Get_Report_Details = i_Params_Get_Report_Details;
            this.proxy.Get_Report_Details(i_Params_Get_Report_Details).subscribe(result => {
                this.oReport_Details = result;
                resolve(result);
            });
        })
    }

    Send_Email(reportId: number, email: string): Promise<boolean> {
        return new Promise(resolve => {
            this.proxy.Send_Report_Email({
                REPORT_ID: reportId,
                TO_EMAIL: email,
            }).subscribe(result => {
                if (result) {
                    this.CmSvc.ShowMessage("Email will be sent shortly");
                    resolve(true);
                } else {
                    this.CmSvc.ShowMessage("An error has occured, please try again");
                    resolve(false);
                }
            });
        });
    }

    Is_Report_Valid(Report_Url: string) {
        if (Report_Url == null || Report_Url.length == 0) {
            this.CmSvc.ShowMessage("This Report is Invalid at This Moment. Kindly Try Again Later.");
            return false;
        }
        return true;
    }
}
