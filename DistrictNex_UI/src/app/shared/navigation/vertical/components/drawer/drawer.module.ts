import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SmartrDrawerComponent } from 'app/shared/navigation/vertical/components/drawer/drawer.component';

@NgModule({
    declarations: [
        SmartrDrawerComponent
    ],
    imports: [
        CommonModule
    ],
    exports: [
        SmartrDrawerComponent
    ]
})
export class SmartrDrawerModule {
}
