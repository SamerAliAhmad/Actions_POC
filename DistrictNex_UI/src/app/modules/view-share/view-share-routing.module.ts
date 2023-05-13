import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewShareComponent } from './view-share.component';

const routes: Routes = [
    {
        path: ':uniqueString',
        component: ViewShareComponent,
    },
    {
        path: '**',
        redirectTo: '/map',
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ViewShareRoutingModule { }
