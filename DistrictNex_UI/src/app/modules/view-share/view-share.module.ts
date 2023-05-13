import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { ViewShareRoutingModule } from './view-share-routing.module';
import { ViewShareComponent } from './view-share.component';
import { ViewShareService } from './view-share.service';

@NgModule({
    declarations: [
        ViewShareComponent,
    ],
    imports: [
        CommonModule,
        SharedModule,
        ViewShareRoutingModule,
    ],
    providers: [
        ViewShareService,
    ]
})
export class ViewShareModule { }
