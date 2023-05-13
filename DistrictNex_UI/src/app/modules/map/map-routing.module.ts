import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { MapComponent } from './map.component';
import { MapService } from './map.service';

export const Routes: Route[] = [
    {
        path: '',
        component: MapComponent,
        resolve: {
            data: MapService,
        }
    },
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forChild(Routes)],
    exports: [RouterModule]
})
export class MapRoutingModule { }
