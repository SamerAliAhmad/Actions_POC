import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { KpiManagementRoutingModule } from './kpi-management-routing.module';
import { KpiManagementComponent } from './kpi-management.component';
import { ChartModule } from 'angular-highcharts';
import { SharedModule } from 'app/shared/shared.module';
import { ColorPickerModule } from 'ngx-color-picker';
import { DataSourceListComponent } from './data-source-list/data-source-list.component';
import { DataSourceModalComponent } from './data-source-modal/data-source-modal.component';
import { KpiListComponent } from './kpi-list/kpi-list.component';
import { KpiModalComponent } from './kpi-modal/kpi-modal.component';
import { OrganizationDataSourceKpiListComponent } from './organization-data-source-kpi-list/organization-data-source-kpi-list.component';
import { OrganizationDataSourceKpiModalComponent } from './organization-data-source-kpi-modal/organization-data-source-kpi-modal.component';


@NgModule({
  declarations: [
    KpiManagementComponent,
    DataSourceListComponent,
    DataSourceModalComponent,
    KpiListComponent,
    KpiModalComponent,
    OrganizationDataSourceKpiListComponent,
    OrganizationDataSourceKpiModalComponent
  ],
  imports: [
    CommonModule,
    ChartModule,
    SharedModule,
    ColorPickerModule,
    KpiManagementRoutingModule,
  ]
})
export class KpiManagementModule { }
