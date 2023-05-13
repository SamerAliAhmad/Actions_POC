import { Route } from '@angular/router';
import { InitialDataResolver } from 'app/app.resolvers';
import { LayoutComponent } from 'app/layout/layout.component';
import { AuthGuard } from './core/auth/guards/auth.guard';
import { NoAuthGuard } from './core/auth/guards/noAuth.guard';
import { SuperAdminGuard } from './core/auth/guards/super-admin.guard';
import { UserDistrictnexDimensionGuard } from './core/auth/guards/user-districtnex-dimension.guard';

export const appRoutes: Route[] = [
    {
        path: '',
        pathMatch: 'full',
        redirectTo: 'map'
    },
    // After the user signs in, the sign in page will redirect the user to the 'signed-in-redirect'
    // path. Below is another redirection for that path to redirect the user to the desired
    // location. This is a small convenience to keep all main routes together here on this file.
    { path: 'signed-in-redirect', pathMatch: 'full', redirectTo: 'map' },
    // Auth routes for guests
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
            {
                path: 'sign-out',
                loadChildren: () => import('app/modules/auth/sign-out/sign-out.module').then(m => m.AuthSignOutModule)
            },
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
            {
                path: 'entity-share-view',
                loadChildren: () => import('app/modules/view-share/view-share.module').then(m => m.ViewShareModule),
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
                path: 'map',
                loadChildren: () => import('app/modules/map/map.module').then(m => m.MapModule),
                canActivate: [UserDistrictnexDimensionGuard],
            },
            {
                path: 'profile',
                loadChildren: () => import('app/modules/profile/profile.module').then(m => m.ProfileModule),
            },
            {
                path: 'reports',
                loadChildren: () => import('app/modules/reports/reports.module').then(m => m.ReportsModule),
                canActivate: [UserDistrictnexDimensionGuard],
            },
            {
                path: 'video-ai',
                loadChildren: () => import('app/modules/video-ai/video-ai.module').then(m => m.VideoAIModule),
                canActivate: [UserDistrictnexDimensionGuard],
            },
            {
                path: 'organization-selection',
                loadChildren: () => import('app/modules/organization-selection/organization-selection.module').then(m => m.OrganizationSelectionModule),
                canActivate: [SuperAdminGuard],
            },
            {
                path: '**',
                redirectTo: 'map'
            }
        ]
    },
    {
        path: '**',
        redirectTo: ''
    }
];
