import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Dimension, Kpi } from 'app/core/Services/proxy.service';
import { KpiManagementService } from '../kpi-management.service';
import { KpiModalComponent } from '../kpi-modal/kpi-modal.component';

@Component({
    selector: 'kpi-list',
    templateUrl: './kpi-list.component.html',
    styleUrls: ['./kpi-list.component.scss']
})
export class KpiListComponent implements OnInit {

  oList_Kpi: Kpi[];
  oList_Dimension: Dimension[];

  constructor(
    public dialog: MatDialog,
    private KpiManagementService: KpiManagementService
  ) { }

    ngOnInit(): void {
        this.Get_Kpi_List();
        this.Get_Dimension_List();

    }

    Get_Kpi_List() {
        this.KpiManagementService.Get_Kpi_List().then(result => {
            if (result) {
                this.oList_Kpi = result;
            }
        })
    }

    Get_Dimension_List() {
        this.KpiManagementService.Get_Dimension_List().then(result => {
            this.oList_Dimension = result;
        })
    }

    Open_Kpi_Details(i_Kpi: Kpi) {
        const dialogRef = this.dialog.open(KpiModalComponent, {
            width: '800px',
            data: {
                oKpi: i_Kpi,
                oList_Dimension: this.oList_Dimension
            }
        })
        dialogRef.afterClosed().subscribe(_ => {
            if (dialogRef.componentInstance.oKpi != i_Kpi && !dialogRef.componentInstance.isDeleted) {
                this.oList_Kpi.splice(this.oList_Kpi.indexOf(i_Kpi), 1);
                this.oList_Kpi.push(dialogRef.componentInstance.oKpi);
            }
            if (dialogRef.componentInstance.isDeleted) {
                this.oList_Kpi.splice(this.oList_Kpi.findIndex(_Kpi => _Kpi == dialogRef.componentInstance.oKpi), 1)
            }
        })
    }

    createKpi() {
        const dialogRef = this.dialog.open(KpiModalComponent, {
            width: '800px',
            data: {
                oKpi: new Kpi(),
                oList_Dimension: this.oList_Dimension,
            }
        })
        dialogRef.afterClosed().subscribe(_ => {
            if (dialogRef.componentInstance.oKpi.KPI_ID > 0 && !this.oList_Kpi.find(_Kpi => _Kpi.KPI_ID == dialogRef.componentInstance.oKpi.KPI_ID)) {
                this.oList_Kpi.push(dialogRef.componentInstance.oKpi);
            }
        })
    }
}
