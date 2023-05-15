import { Route } from '@angular/router';
import { InitialDataResolver } from 'app/app.resolvers';
import { LayoutComponent } from 'app/layout/layout.component';
import { AuthGuard } from './core/auth/guards/auth.guard';
import { NoAuthGuard } from './core/auth/guards/noAuth.guard';
import { OrganizationManagerGuard } from './core/auth/guards/organization-manager.guard';

export const appRoutes: Route[] = [
    {
        path: '',
        pathMatch: 'full',
        redirectTo: 'home'
    },
    {
        path: 'signed-in-redirect',
        pathMatch: 'full',
        redirectTo: 'home'
    },
    {
        path: '',
        canActivate: [NoAuthGuard],
        canActivateChild: [NoAuthGuard],
        component: LayoutComponent,
        data: {
            layout: 'empty'
        },
        children: [
            {
                path: 'sign-in',
                loadChildren: () => import('app/modules/auth/sign-in/sign-in.module').then(m => m.AuthSignInModule)
            },
        ]
    },
    // Auth routes for authenticated users
    {
        path: '',
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        component: LayoutComponent,
        data: {
            layout: 'empty'
        },
        children: [
            { path: 'sign-out', loadChildren: () => import('app/modules/auth/sign-out/sign-out.module').then(m => m.AuthSignOutModule) },
        ]
    },
    {
        path: '',
        component: LayoutComponent,
        data: {
            layout: 'empty'
        },
        children: [
            {
                path: 'invalid',
                loadChildren: () => import('app/modules/not-found/not-found.module').then(m => m.NotFoundModule)
            },
            {
                path: 'build-history',
                loadChildren: () => import('app/modules/build-history/build-history.module').then(m => m.BuildHistoryModule),
            },
        ]
    },
    {
        path: '',
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        component: LayoutComponent,
        resolve: {
            initialData: InitialDataResolver,
        },
        children: [
            {
                path: '',
                redirectTo: 'home',
                pathMatch: 'full'
            },
            {
                canActivate: [OrganizationManagerGuard],
                path: 'home',
                loadChildren: () => import('app/modules/home/home.module').then(m => m.HomeModule)
            },
            {
                canActivate: [OrganizationManagerGuard],
                path: 'organization-management',
                loadChildren: () => import('app/modules/organization-management/organization-management.module').then(m => m.OrganizationManagementModule)
            },
            {
                path: 'my-organization',
                loadChildren: () => import('app/modules/my-organization/my-organization.module').then(m => m.MyOrganizationModule),
            },
            {
                path: 'video-ai-management',
                loadChildren: () => import('app/modules/video-ai-management/video-ai-management.module').then(m => m.VideoAiManagementModule),
            },
            {
                path: 'kpi-management',
                loadChildren: () => import('app/modules/kpi-management/kpi-management.module').then(m => m.KpiManagementModule),
            },
            {
                path: 'logs',
                loadChildren: () => import('app/modules/logs/logs.module').then(m => m.LogsModule)
            },
            {
                path: 'default-settings',
                loadChildren: () => import('app/modules/settings/settings.module').then(m => m.SettingsModule)
            },
            {
                path: 'profile',
                loadChildren: () => import('app/modules/profile/profile.module').then(m => m.ProfileModule)
            },
            {
                path: '**',
                redirectTo: 'home'
            }
        ]
    },
    {
        path: '**',
        redirectTo: ''
    }
];
