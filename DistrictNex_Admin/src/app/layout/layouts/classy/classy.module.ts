import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { RouterModule } from '@angular/router';
import { UserModule } from 'app/layout/common/user/user.module';
import { ClassyLayoutComponent } from 'app/layout/layouts/classy/classy.component';
import { SmartrFullscreenModule } from 'app/shared/components/fullscreen/fullscreen.module';
import { SmartrNavigationModule } from 'app/shared/navigation/navigation.module';
import { SharedModule } from 'app/shared/shared.module';

@NgModule({
    declarations: [
        ClassyLayoutComponent
    ],
    imports: [
        HttpClientModule,
        RouterModule,
        MatButtonModule,
        MatDividerModule,
        MatIconModule,
        MatMenuModule,
        SmartrFullscreenModule,
        SmartrNavigationModule,
        UserModule,
        SharedModule
    ],
    exports: [
        ClassyLayoutComponent
    ]
})
export class ClassyLayoutModule {
}
