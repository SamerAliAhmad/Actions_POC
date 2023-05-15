import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { LogsRoutingModule } from './logs-routing.module';
import { LogsComponent } from './logs.component';
import { LogsService } from './logs.service';

@NgModule({
  declarations: [
    LogsComponent,
  ],
  imports: [
    CommonModule,
    SharedModule,
    LogsRoutingModule
  ],
  providers: [
    LogsService,
  ]
})
export class LogsModule { }
