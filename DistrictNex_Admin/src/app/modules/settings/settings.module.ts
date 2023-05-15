import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { ColorPickerModule } from 'ngx-color-picker';
import { DefaultPictureModalComponent } from './default-picture-modal/default-picture-modal.component';
import { SettingsRoutingModule } from './settings-routing.module';
import { SettingsComponent } from './settings.component';

@NgModule({
  declarations: [
    SettingsComponent,
    DefaultPictureModalComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ColorPickerModule,
    SettingsRoutingModule,
  ]
})
export class SettingsModule { }
