import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { ProfileRoutingModule } from './profile-routing.module';
import { ProfileComponent } from './profile.component';


@NgModule({
  declarations: [
    ProfileComponent,
  ],
  imports: [
      CommonModule,
      SharedModule,
      ProfileRoutingModule,
  ]
})
export class ProfileModule { }
