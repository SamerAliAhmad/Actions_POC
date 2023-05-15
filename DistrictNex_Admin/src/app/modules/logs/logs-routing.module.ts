import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { LogsComponent } from './logs.component';

export const LogsRoutes: Route[] = [
    {
        path: '',
        component: LogsComponent,
    },
    { path: '**', redirectTo: '' },
];

@NgModule({
    imports: [RouterModule.forChild(LogsRoutes)],
    exports: [RouterModule],
})
export class LogsRoutingModule { }
