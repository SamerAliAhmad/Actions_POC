import { Injectable } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { SmartrConfirmationConfig } from 'app/shared/components/confirmation/confirmation.types';
import { SmartrConfirmationDialogComponent } from 'app/shared/components/confirmation/dialog/dialog.component';
import { merge } from 'lodash-es';

@Injectable()
export class SmartrConfirmationService {
    private _defaultConfig: SmartrConfirmationConfig = {
        title: 'Confirm action',
        message: 'Are you sure you want to confirm this action?',
        icon: {
            show: true,
            name: 'heroicons_outline:exclamation',
            color: 'warn'
        },
        actions: {
            confirm: {
                show: true,
                label: 'Confirm',
                color: 'warn'
            },
            cancel: {
                show: true,
                label: 'Cancel'
            }
        },
        dismissible: false
    };

    constructor(private _matDialog: MatDialog) {
    }

    open(config: SmartrConfirmationConfig = {}): MatDialogRef<SmartrConfirmationDialogComponent> {
        // Merge the user config with the default config
        const userConfig = merge({}, this._defaultConfig, config);

        // Open the dialog
        return this._matDialog.open(SmartrConfirmationDialogComponent, {
            autoFocus: false,
            disableClose: !userConfig.dismissible,
            data: userConfig,
            panelClass: 'smartr-confirmation-dialog-panel'
        });
    }
}
