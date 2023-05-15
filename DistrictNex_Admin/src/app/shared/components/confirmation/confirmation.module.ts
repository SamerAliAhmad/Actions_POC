import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { SmartrConfirmationDialogComponent } from 'app/shared/components/confirmation/dialog/dialog.component';

@NgModule({
    declarations: [
        SmartrConfirmationDialogComponent
    ],
    imports: [
        CommonModule,
        MatIconModule,
        MatButtonModule,
        MatDialogModule
    ],
    providers: [
        SmartrConfirmationService
    ]
})
export class SmartrConfirmationModule { }
