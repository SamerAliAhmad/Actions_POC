import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Correlation_method } from 'app/core/Services/proxy.service';

@Component({
    selector: 'correlation-method-details-modal',
    templateUrl: './correlation-method-details-modal.component.html',
    styleUrls: ['./correlation-method-details-modal.component.scss']
})
export class CorrelationMethodDetailsModalComponent {
    constructor(
        @Inject(MAT_DIALOG_DATA) public oCorrelation_method: Correlation_method,
    ) { }
}
