import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { BuildHistoryRoutingModule } from './build-history-routing.module';
import { BuildHistoryComponent } from './build-history.component';


@NgModule({
    declarations: [
        BuildHistoryComponent
    ],
    imports: [
        CommonModule,
        SharedModule,
        BuildHistoryRoutingModule,
    ]
})
export class BuildHistoryModule { }
