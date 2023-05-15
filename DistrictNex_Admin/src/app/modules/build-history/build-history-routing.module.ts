import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuildHistoryComponent } from './build-history.component';
import { BuildHistoryService } from './build-history.service';

const routes: Routes = [
    {
        path: '',
        component: BuildHistoryComponent,
        resolve: {
            buildHistoryData: BuildHistoryService,
        },
    },
    {
        path: '**',
        redirectTo: '',
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class BuildHistoryRoutingModule { }
