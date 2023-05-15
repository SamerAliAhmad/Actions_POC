import { NgModule } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { LayoutComponent } from 'app/layout/layout.component';
import { EmptyLayoutModule } from 'app/layout/layouts/empty/empty.module';
import { SmartrLoadingModule } from 'app/shared/components/loading/loading.module';
import { SmartrDrawerModule } from 'app/shared/navigation/vertical/components/drawer/drawer.module';
import { SharedModule } from 'app/shared/shared.module';
import { ClassyLayoutModule } from './layouts/classy/classy.module';

const layoutModules = [
    EmptyLayoutModule,
    ClassyLayoutModule
];

@NgModule({
    declarations: [
        LayoutComponent
    ],
    imports: [
        SharedModule,
        MatIconModule,
        MatTooltipModule,
        SmartrDrawerModule,
        SmartrLoadingModule,
        ...layoutModules
    ],
    exports: [
        LayoutComponent,
        ...layoutModules
    ]
})
export class LayoutModule {
}
