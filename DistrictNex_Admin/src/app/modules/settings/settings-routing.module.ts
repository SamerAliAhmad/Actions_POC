import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { SettingsComponent } from './settings.component';

export const SettingsRoutes: Route[] = [
    {
        path: '',
        component: SettingsComponent,
    },
    { path: '**', redirectTo: '' },
];

@NgModule({
    imports: [RouterModule.forChild(SettingsRoutes)],
    exports: [RouterModule],
})
export class SettingsRoutingModule { }
