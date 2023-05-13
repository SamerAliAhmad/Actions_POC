import { NgModule } from '@angular/core';
import { MatIconReplacerDirective } from './matIconReplacer.directive';



@NgModule({
    declarations: [
        MatIconReplacerDirective,
    ],
    exports: [
        MatIconReplacerDirective,
    ]
})
export class MatIconReplacerModule { }
