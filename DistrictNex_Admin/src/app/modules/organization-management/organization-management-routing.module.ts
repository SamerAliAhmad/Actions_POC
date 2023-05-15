import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { OrganizationDetailsMainComponent } from './organization-details-main/organization-details-main.component';
import { OrganizationDetailsComponent } from './organization-details-main/organization-details/organization-details.component';
import { UserDetailsComponent } from './organization-details-main/organization-details/user-management/user-details/user-details.component';
import { OrganizationListComponent } from './organization-list/organization-list.component';
import { OrganizationManagementComponent } from './organization-management.component';

export const OrganizationManagementRoutes: Route[] = [
    {
        path: '',
        component: OrganizationManagementComponent,
        children: [
            {
                path: '',
                component: OrganizationListComponent,
            },
            {
                path: ':id',
                component: OrganizationDetailsMainComponent,
                children: [
                    {
                        path: '',
                        component: OrganizationDetailsComponent,
                    },
                    {
                        path: ':userId',
                        component: UserDetailsComponent,
                        data: {
                            isAbs: true,
                        },
                    },
                ]
            }
        ],
    },
    { path: '**', redirectTo: '' },
];

@NgModule({
    imports: [RouterModule.forChild(OrganizationManagementRoutes)],
    exports: [RouterModule],
})
export class OrganizationManagementRoutingModule { }
