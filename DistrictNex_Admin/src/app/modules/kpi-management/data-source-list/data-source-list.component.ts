import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { KpiManagementService } from '../kpi-management.service';
import { Data_source } from './../../../core/Services/proxy.service';
import { DataSourceModalComponent } from '../data-source-modal/data-source-modal.component';

@Component({
  selector: 'data-source-list',
  templateUrl: './data-source-list.component.html',
  styleUrls: ['./data-source-list.component.scss']
})
export class DataSourceListComponent implements OnInit {

  oList_Data_source: Data_source[];
  
  constructor(
    public dialog: MatDialog,
    private KpiManagementService: KpiManagementService
  ) { }

  ngOnInit(): void {
    this.Get_Data_Source_List();

  }

  Get_Data_Source_List() {
    this.KpiManagementService.Get_Data_Source_List().then(result => {
      if (result) {
        this.oList_Data_source = result;
      }
    })
  }

  Open_Data_source_details(i_Data_source: Data_source) {
    const dialogRef = this.dialog.open(DataSourceModalComponent, {
      width: '800px',
      data: {
        oData_source: i_Data_source,
      }
    })
    dialogRef.afterClosed().subscribe(_ => {
      if (dialogRef.componentInstance.oData_source != i_Data_source && !dialogRef.componentInstance.isDeleted) {
        this.oList_Data_source.splice(this.oList_Data_source.indexOf(i_Data_source), 1);
        this.oList_Data_source.push(dialogRef.componentInstance.oData_source);
      }
      if (dialogRef.componentInstance.isDeleted) {
        this.oList_Data_source.splice(this.oList_Data_source.findIndex(_data_source => _data_source == dialogRef.componentInstance.oData_source), 1)
      }
    })
  }

  createDataSource() {
    const dialogRef = this.dialog.open(DataSourceModalComponent, {
      width: '800px',
      data: {
        oData_source: new Data_source()
      }
    })
    dialogRef.afterClosed().subscribe(_ => {
      if (dialogRef.componentInstance.oData_source.DATA_SOURCE_ID > 0 && !this.oList_Data_source.find(_Data_source => _Data_source.DATA_SOURCE_ID == dialogRef.componentInstance.oData_source.DATA_SOURCE_ID)) {
        this.oList_Data_source.push(dialogRef.componentInstance.oData_source);
      }
    })
  }

}
