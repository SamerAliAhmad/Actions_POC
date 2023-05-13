import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UserModule } from 'app/layout/common/user/user.module';
import { ThinLayoutComponent } from 'app/layout/layouts/thin/thin.component';
import { SmartrFullscreenModule } from 'app/shared/components/fullscreen/fullscreen.module';
import { SmartrNavigationModule } from 'app/shared/navigation/navigation.module';
import { SharedModule } from 'app/shared/shared.module';

@NgModule({
    declarations: [
        ThinLayoutComponent
    ],
    imports: [
        UserModule,
        RouterModule,
        SharedModule,
        HttpClientModule,
        SmartrFullscreenModule,
        SmartrNavigationModule,
    ],
    exports: [
        ThinLayoutComponent
    ]
})
export class ThinLayoutModule {
}
