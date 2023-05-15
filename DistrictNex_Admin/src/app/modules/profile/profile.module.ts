import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProfileComponent } from './profile.component';
import { SharedModule } from 'app/shared/shared.module';
import { ProfileRoutingModule } from './profile-routing.module';
import { ProfileService } from './profile.service';


@NgModule({
  declarations: [
    ProfileComponent,
  ],
  imports: [
    CommonModule,
    SharedModule,
    ProfileRoutingModule,
  ],
  providers: [
    ProfileService
  ]
})
export class ProfileModule { }
