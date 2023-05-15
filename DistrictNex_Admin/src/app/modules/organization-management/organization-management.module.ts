import { NgModule } from '@angular/core';
import { ChartModule, HIGHCHARTS_MODULES } from 'angular-highcharts';
import { UploadPictureModalComponent } from 'app/shared/components/organization-management/upload-picture-modal/upload-picture-modal.component';
import { SharedModule } from 'app/shared/shared.module';
import more from 'highcharts/highcharts-more.src';
import solidGauge from 'highcharts/modules/solid-gauge.src';
import { ColorPickerModule } from 'ngx-color-picker';
import { OrganizationDetailsMainComponent } from './organization-details-main/organization-details-main.component';
import { OrganizationAccessControlComponent } from './organization-details-main/organization-details/organization-access-control/organization-access-control.component';
import { OrganizationDetailsComponent } from './organization-details-main/organization-details/organization-details.component';
import { OrganizationModuleAccessComponent } from './organization-details-main/organization-details/organization-module-access/organization-module-access.component';
import { OrganizationListComponent } from './organization-list/organization-list.component';
import { OrganizationManagementRoutingModule } from './organization-management-routing.module';
import { OrganizationManagementComponent } from './organization-management.component';
import { OrganizationModalComponent } from './organization-modal/organization-modal.component';
import { OrganizationDataAccessComponent } from './organization-details-main/organization-details/organization-data-access/organization-data-access.component';
import { OrganizationDataAccessModalComponent } from './organization-details-main/organization-details/organization-data-access/organization-data-access-modal/organization-data-access-modal.component';

export function highchartsModules() {
    // apply Highcharts Modules to this array
    return [more, solidGauge];
}

@NgModule({
    declarations: [
        OrganizationListComponent,
        OrganizationModalComponent,
        UploadPictureModalComponent,
        OrganizationDetailsComponent,
        OrganizationManagementComponent,
        OrganizationDetailsMainComponent,
        OrganizationAccessControlComponent,
        OrganizationModuleAccessComponent,
        OrganizationDataAccessComponent,
        OrganizationDataAccessModalComponent,
    ],
    imports: [
        ChartModule,
        SharedModule,
        ColorPickerModule,
        OrganizationManagementRoutingModule,
    ],
    providers: [
        { provide: HIGHCHARTS_MODULES, useFactory: highchartsModules },
    ]
})
export class OrganizationManagementModule { }
