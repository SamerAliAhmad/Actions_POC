import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { UserComponent } from 'app/layout/common/user/user.component';

@NgModule({
    declarations: [
        UserComponent
    ],
    imports: [
        SharedModule
    ],
    exports: [
        UserComponent
    ]
})
export class UserModule {
}
