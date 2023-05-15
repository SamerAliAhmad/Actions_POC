import { NgModule } from '@angular/core';
import { SmartrScrollbarDirective } from './scrollbar.directive';

@NgModule({
    declarations: [
        SmartrScrollbarDirective
    ],
    exports: [
        SmartrScrollbarDirective
    ]
})
export class SmartrScrollbarModule {
}
