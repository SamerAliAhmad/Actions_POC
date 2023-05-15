import { NgModule } from '@angular/core';
import { ChartModule } from 'angular-highcharts';
import { SharedModule } from 'app/shared/shared.module';
import { ColorPickerModule } from 'ngx-color-picker';
import { MyOrganizationRoutingModule } from './my-organization-routing.module';
import { MyOrganizationComponent } from './my-organization.component';

@NgModule({
  declarations: [
    MyOrganizationComponent,
  ],
  imports: [
    ChartModule,
    SharedModule,
    ColorPickerModule,
    MyOrganizationRoutingModule,
  ],
  providers: [
  ]
})
export class MyOrganizationModule { }
