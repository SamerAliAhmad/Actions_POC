import { ChangeDetectorRef, Component, EventEmitter, Input, OnChanges, Output } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { CommonService } from 'app/core/Services/common.service';
import { Report } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ReportsService } from '../../reports.service';
const FileSaver = require('file-saver');

@Component({
    selector: 'file-manager-details',
    templateUrl: './details.component.html',
    styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnChanges {
    @Input() currentReport: Report;

    @Output() closeDrawerClickEventEmitter = new EventEmitter();

    reportUrl;
    reportName;
    reportExtension;
    reportPreviewUrl;
    reportDisplayName;
    emailFormControl: FormControl;

    emailSending = false;
    downloadingReport = false;

    displayEmailEntry = false;

    constructor(
        private CmSvc: CommonService,
        private reportsService: ReportsService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.emailFormControl = new FormControl(this.CmSvc.oUser_Details.EMAIL, [Validators.required, Validators.email]);
    }
    Is_Report_Valid() {
        if (this.reportUrl == null || this.reportUrl.length == 0) {
            this.CmSvc.ShowMessage("This Report is Invalid at This Moment. Kindly Try Again Later.");
            return false;
        }
        return true;
    }
    ngOnChanges() {
        if (this.currentReport != undefined && this.currentReport.IDENTIFIER_TOKEN) {
            this.reportExtension = this.currentReport.FILE_EXTENSION.replace('.', '');
            this.reportDisplayName = this.getDisplayName(this.currentReport.FILE_NAME);
            this.reportName = `${this.currentReport.FILE_NAME}.${this.currentReport.FILE_EXTENSION}`;

            this.reportUrl = this.CmSvc.Asset_Endpoint + '/Static_Reports/' + this.reportName;
            this.reportPreviewUrl = this.CmSvc.Asset_Endpoint + '/Static_Reports/' + this.reportName;
        }
        this._changeDetectorRef.detectChanges();
    }
    toggleEmailSend(): void {
        if (this.Is_Report_Valid()) {
            this.displayEmailEntry = !this.displayEmailEntry;
        }
    }
    onClose() {
        this.closeDrawerClickEventEmitter.emit();
    }
    Get_File_Color(extension): string {
        return this.reportsService.Get_File_Color(extension);
    }
    getDisplayName(fileName: string): string {
        return fileName.replace(/_/g, ' ');
    }
    sendEmail() {
        if (!this.emailSending && this.Is_Report_Valid()) {
            this.emailSending = true;
            this.reportsService.Send_Email(this.currentReport.REPORT_ID, this.emailFormControl.value).then(result => {
                if (result) {
                    this.toggleEmailSend();
                }
                this.emailSending = false;
            });
        }
    }
    preview() {
        if (this.Is_Report_Valid()) {
            window.open(this.reportPreviewUrl, "_blank");
        }
    }
    downloadReport(): void {
        if (!this.downloadingReport && this.Is_Report_Valid()) {
            this.downloadingReport = true;
            fetch(this.reportPreviewUrl)
                .then(res => res.blob())
                .then((blob) => {
                    FileSaver.saveAs(blob, this.reportName);
                    this.downloadingReport = false;
                })
        }
    }
}
