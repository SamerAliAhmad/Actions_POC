import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { GeneratedReportComponent } from './generated-report/generated-report.component';
import { DetailsComponent } from './report-manager/details/details.component';
import { ReportManagerComponent } from './report-manager/report-manager.component';
import { ReportWizardComponent } from './report-wizard/report-wizard.component';
import { ReportsRoutingModule } from './reports-routing.module';
import { ReportsComponent } from './reports.component';
import { ReportsService } from './reports.service';

@NgModule({
    declarations: [
        ReportsComponent,
        DetailsComponent,
        ReportWizardComponent,
        ReportManagerComponent,
        GeneratedReportComponent,
    ],
    imports: [
        CommonModule,
        SharedModule,
        ReportsRoutingModule,
    ],
    providers: [
        ReportsService,
    ]
})
export class ReportsModule { }
