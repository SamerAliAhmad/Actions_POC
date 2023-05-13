import { NgModule } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { LayoutComponent } from 'app/layout/layout.component';
import { EmptyLayoutModule } from 'app/layout/layouts/empty/empty.module';
import { ThinLayoutModule } from 'app/layout/layouts/thin/thin.module';
import { SmartrDrawerModule } from 'app/shared/navigation/vertical/components/drawer/drawer.module';
import { SharedModule } from 'app/shared/shared.module';

const layoutModules = [
    // Empty
    EmptyLayoutModule,
    ThinLayoutModule
];

@NgModule({
    declarations: [
        LayoutComponent
    ],
    imports: [
        MatIconModule,
        MatTooltipModule,
        SmartrDrawerModule,
        SharedModule,
        ...layoutModules
    ],
    exports: [
        LayoutComponent,
        ...layoutModules
    ]
})
export class LayoutModule {
}
