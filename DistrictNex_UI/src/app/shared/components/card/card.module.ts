import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SmartrCardComponent } from './card.component';

@NgModule({
    declarations: [
        SmartrCardComponent
    ],
    imports: [
        CommonModule
    ],
    exports: [
        SmartrCardComponent
    ]
})
export class SmartrCardModule {
}
