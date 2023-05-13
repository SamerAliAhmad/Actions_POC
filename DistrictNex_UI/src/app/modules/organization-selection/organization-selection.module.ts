import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { OrganizationSelectionComponent } from './organization-selection.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

const routes = [
  { path: '', component: OrganizationSelectionComponent }
];
@NgModule({
  declarations: [
    OrganizationSelectionComponent
  ],
  imports: [
    CommonModule,
    MatIconModule,
    MatButtonModule,
    RouterModule.forChild(routes)
  ]
})
export class OrganizationSelectionModule { }
