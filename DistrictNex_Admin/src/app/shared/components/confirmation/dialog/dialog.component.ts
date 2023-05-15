import { Component, Inject, ViewEncapsulation } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SmartrConfirmationConfig } from 'app/shared/components/confirmation/confirmation.types';

@Component({
    selector: 'smartr-confirmation-dialog',
    templateUrl: './dialog.component.html',
    styles: [
        /* language=SCSS */
        `
            .smartr-confirmation-dialog-panel {
                @screen md {
                    @apply w-128;
                }

                .mat-dialog-container {
                    padding: 0 !important;
                }
            }
        `
    ],
    encapsulation: ViewEncapsulation.None
})
export class SmartrConfirmationDialogComponent {
    constructor(
        @Inject(MAT_DIALOG_DATA) public data: SmartrConfirmationConfig,
        public matDialogRef: MatDialogRef<SmartrConfirmationDialogComponent>
    ) {
    }
}
