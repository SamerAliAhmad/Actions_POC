import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home.component';

export const Routes: Route[] = [
    {
        path: '',
        component: HomeComponent,
        children: [
            {
                path: '',
                component: DashboardComponent,
            },
        ]
    },
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forChild(Routes)],
    exports: [RouterModule]
})
export class HomeRoutingModule { }
