import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { NonAdminOrganizationManagerGuard } from 'app/core/auth/guards/non-admin-organization.guard';
import { OrganizationManagerGuard } from 'app/core/auth/guards/organization-manager.guard';
import { DataSettingsComponent } from '../organization-management/organization-details-main/organization-details/data-settings/data-settings.component';
import { GeneralDetailsComponent } from '../organization-management/organization-details-main/organization-details/general-details/general-details.component';
import { OrganizationAccessControlComponent } from '../organization-management/organization-details-main/organization-details/organization-access-control/organization-access-control.component';
import { OrganizationImagesComponent } from '../organization-management/organization-details-main/organization-details/organization-images/organization-images.component';
import { OrganizationModuleAccessComponent } from '../organization-management/organization-details-main/organization-details/organization-module-access/organization-module-access.component';
import { ThemeSettingsComponent } from '../organization-management/organization-details-main/organization-details/theme-settings/theme-settings.component';
import { UserDetailsComponent } from '../organization-management/organization-details-main/organization-details/user-management/user-details/user-details.component';
import { UserManagementComponent } from '../organization-management/organization-details-main/organization-details/user-management/user-management.component';
import { UserQuotaComponent } from '../organization-management/organization-details-main/organization-details/user-quota/user-quota.component';
import { MyOrganizationComponent } from './my-organization.component';

export const MyOrganizationRoutes: Route[] = [
    {
        path: '',
        component: MyOrganizationComponent,
        children: [
            {
                canActivate: [OrganizationManagerGuard],
                path: 'general-details',
                component: GeneralDetailsComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                canActivate: [OrganizationManagerGuard, NonAdminOrganizationManagerGuard],
                path: 'access-control',
                component: OrganizationAccessControlComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                canActivate: [OrganizationManagerGuard, NonAdminOrganizationManagerGuard],
                path: 'module-access',
                component: OrganizationModuleAccessComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                canActivate: [OrganizationManagerGuard],
                path: 'user-quota',
                component: UserQuotaComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                path: 'theme-settings',
                component: ThemeSettingsComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                path: 'organization-images',
                component: OrganizationImagesComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                path: 'user-management',
                component: UserManagementComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                path: 'user-management/:userId',
                component: UserDetailsComponent,
                data: {
                    isMyOrganization: true,
                    isAbs: false,
                },
            },
            {
                canActivate: [OrganizationManagerGuard],
                path: 'data-settings',
                component: DataSettingsComponent,
                data: {
                    isMyOrganization: true,
                }
            },
            {
                path: '**',
                redirectTo: 'theme-settings',
            }
        ],
    },
    { path: '**', redirectTo: '' },
];

@NgModule({
    imports: [RouterModule.forChild(MyOrganizationRoutes)],
    exports: [RouterModule],
})
export class MyOrganizationRoutingModule { }
