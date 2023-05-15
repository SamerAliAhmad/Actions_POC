import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { AuthInterceptor } from 'app/core/auth/auth.interceptor';
import { AuthService } from 'app/core/auth/auth.service';
import { AdminOrganizationGuard } from './guards/admin-organization.guard';
import { NoAuthGuard } from './guards/noAuth.guard';
import { OrganizationManagerGuard } from './guards/organization-manager.guard';

@NgModule({
    imports: [
        HttpClientModule
    ],
    providers: [
        AuthService,
        NoAuthGuard,
        AdminOrganizationGuard,
        OrganizationManagerGuard,
        {
            provide: HTTP_INTERCEPTORS,
            useClass: AuthInterceptor,
            multi: true
        }
    ]
})
export class AuthModule {
}
