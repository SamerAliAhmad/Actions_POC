import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { GeneratedReportComponent } from './generated-report/generated-report.component';
import { ReportManagerComponent } from './report-manager/report-manager.component';
import { ReportsComponent } from './reports.component';

export const Routes: Route[] = [
    {
        path: '',
        component: ReportsComponent,
        children: [
            {
                path: '',
                component: ReportManagerComponent,
            },
            {
                path: 'generated-report',
                component: GeneratedReportComponent,
            },
            {
                path: 'download/:token',
                component: ReportManagerComponent,
            },
            {
                path: 'view/:token',
                component: ReportManagerComponent,
            }
        ]
    },
    { path: '**', redirectTo: 'invalid' }
];

@NgModule({
    imports: [RouterModule.forChild(Routes)],
    exports: [RouterModule]
})
export class ReportsRoutingModule { }
