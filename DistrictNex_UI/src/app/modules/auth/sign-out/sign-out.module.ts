import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthSignOutComponent } from 'app/modules/auth/sign-out/sign-out.component';
import { authSignOutRoutes } from 'app/modules/auth/sign-out/sign-out.routing';
import { SharedModule } from 'app/shared/shared.module';

@NgModule({
    declarations: [
        AuthSignOutComponent
    ],
    imports: [
        SharedModule,
        RouterModule.forChild(authSignOutRoutes),
    ]
})
export class AuthSignOutModule {
}
