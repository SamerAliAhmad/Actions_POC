import { NotFoundComponent } from './not-found.component';
import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';

export const Routes: Route[] = [
    {
        path: '',
        component: NotFoundComponent
    },
    { path: '**', redirectTo: '' }
  ];

@NgModule({
  imports: [RouterModule.forChild(Routes)],
  exports: [RouterModule]
})
export class NotFoundRoutingModule { }
