import { KpiManagementComponent } from './kpi-management.component';
import { NgModule } from '@angular/core';
import { RouterModule, Route } from '@angular/router';

export const routes: Route[] = [
  {
    path: '',
    component: KpiManagementComponent,
    children: [
      {
        path: '',
        component: KpiManagementComponent,
      },
    ],
  },
  { path: '**', redirectTo: '' },
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class KpiManagementRoutingModule { }
