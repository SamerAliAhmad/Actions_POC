import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
    selector: 'qr-code-modal',
    templateUrl: './qr-code-modal.component.html',
    styleUrls: ['./qr-code-modal.component.scss']
})
export class QrCodeModalComponent {

    constructor(
        @Inject(MAT_DIALOG_DATA) public oLink: string,
    ) { }
}
