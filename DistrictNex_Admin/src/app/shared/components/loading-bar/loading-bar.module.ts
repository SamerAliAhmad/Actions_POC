import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { SmartrLoadingBarComponent } from './loading-bar.component';

@NgModule({
    declarations: [
        SmartrLoadingBarComponent,
    ],
    imports     : [
        CommonModule,
        MatProgressBarModule
    ],
    exports     : [
        SmartrLoadingBarComponent
    ]
})
export class SmartrLoadingBarModule
{
}
