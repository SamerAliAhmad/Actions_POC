import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { GoogleMapsModule } from '@angular/google-maps';
import { SharedModule } from 'app/shared/shared.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';

@NgModule({
    declarations: [
        HomeComponent,
        DashboardComponent,
    ],
    imports: [
        CommonModule,
        SharedModule,
        GoogleMapsModule,
        HomeRoutingModule,
    ],
})
export class HomeModule { }
