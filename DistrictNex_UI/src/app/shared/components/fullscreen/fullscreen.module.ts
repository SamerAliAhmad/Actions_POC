import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { SmartrFullscreenComponent } from 'app/shared/components/fullscreen/fullscreen.component';
import { MatIconReplacerModule } from 'app/shared/directives/mat-icon-replacer.module';

@NgModule({
    declarations: [
        SmartrFullscreenComponent
    ],
    imports: [
        MatButtonModule,
        MatIconModule,
        MatTooltipModule,
        CommonModule,
        MatIconReplacerModule,
    ],
    exports: [
        SmartrFullscreenComponent
    ]
})
export class SmartrFullscreenModule {
}
