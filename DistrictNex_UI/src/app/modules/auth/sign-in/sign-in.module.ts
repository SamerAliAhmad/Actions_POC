import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthSignInComponent } from 'app/modules/auth/sign-in/sign-in.component';
import { authSignInRoutes } from 'app/modules/auth/sign-in/sign-in.routing';
import { SharedModule } from 'app/shared/shared.module';

@NgModule({
    declarations: [
        AuthSignInComponent
    ],
    imports: [
        SharedModule,
        RouterModule.forChild(authSignInRoutes),
    ],
})
export class AuthSignInModule {
}
