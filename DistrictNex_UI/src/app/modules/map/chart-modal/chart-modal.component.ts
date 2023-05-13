import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ChartConfiguration } from 'chart.js';

@Component({
    selector: 'chart-modal',
    templateUrl: './chart-modal.component.html',
    styleUrls: ['./chart-modal.component.scss']
})
export class ChartModalComponent {

    title: String;
    oChartConfiguration: ChartConfiguration;

    constructor(
        @Inject(MAT_DIALOG_DATA) private data: any,
    ) {
        this.title = this.data.title;
        this.oChartConfiguration = data.ChartConfiguration;
    }
}
