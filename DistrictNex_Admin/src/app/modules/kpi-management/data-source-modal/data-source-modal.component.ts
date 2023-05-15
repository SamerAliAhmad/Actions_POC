import { KpiManagementService } from '../kpi-management.service';
import { Data_source } from '../../../core/Services/proxy.service'
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Component, HostListener, Inject, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';

@Component({
  selector: 'data-source-modal',
  templateUrl: './data-source-modal.component.html',
  styleUrls: ['./data-source-modal.component.scss']
})

export class DataSourceModalComponent implements OnInit {
  dataSourceForm: FormGroup;

  isLoading = false;
  isDeleted = false;
  isCreating = false;
  isMobileView = false;

  oData_source: Data_source;

  constructor(
    private dialog: MatDialog,
    private _formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private KpiManagementService: KpiManagementService,
    private _smartrConfirmationService: SmartrConfirmationService,


  ) { }

  ngOnInit(): void {
    this.oData_source = this.data.oData_source;
    if (this.oData_source.DATA_SOURCE_ID == new Data_source().DATA_SOURCE_ID) {
      this.isCreating = true;
    }
    this.dataSourceForm = this.initializeForm();
  }

  initializeForm(): FormGroup {
    return this._formBuilder.group({
      NAME: [this.oData_source.NAME, [Validators.pattern('[ a-zA-Z0-9]*'), Validators.required]],
      API_URL: [this.oData_source.API_URL, [Validators.required]],
      MIN_DWELL_TIME_IN_MINUTES: [this.oData_source.MIN_DWELL_TIME_IN_MINUTES, Validators.required],
      MAX_DWELL_TIME_IN_MINUTES: [this.oData_source.MAX_DWELL_TIME_IN_MINUTES, Validators.required],
    }, {
      validator: [this.minMaxDwellTimeValidator]
    });
  }

  minMaxDwellTimeValidator(group: FormGroup): ValidationErrors | null {
    const minDwellTime = group.get('MIN_DWELL_TIME_IN_MINUTES').value;
    const maxDwellTime = group.get('MAX_DWELL_TIME_IN_MINUTES').value;

    if (minDwellTime != null && maxDwellTime != null && minDwellTime > maxDwellTime) {
      return { 'minMaxDwellTime': true };
    }

    return null;
  }

  Delete_Data_Source() {
    const dialogRef = this._smartrConfirmationService.open({
      title: 'Confirm Data Source Deletion',
      message: "Are you sure you want to delete this data source?",
      actions: {
        confirm: {
          show: true,
          label: 'Yes',
          color: 'warn',
        },
        cancel: {
          show: true,
          label: 'No',
        }
      }
    })
    dialogRef.afterClosed().subscribe((result) => {
      this.isDeleted = true;
      if (result === 'confirmed') {
        this.KpiManagementService.Delete_Data_Source(this.oData_source).then(_ => {
          this.dialog.closeAll();
        })
      }
    });

  }

  Edit_Data_Source() {
    this.isLoading = true;
    this.oData_source.NAME = this.dataSourceForm.get('NAME').value.trim();
    this.oData_source.API_URL = this.dataSourceForm.get('API_URL').value.trim();
    this.oData_source.MIN_DWELL_TIME_IN_MINUTES = this.dataSourceForm.get('MIN_DWELL_TIME_IN_MINUTES').value;
    this.oData_source.MAX_DWELL_TIME_IN_MINUTES = this.dataSourceForm.get('MAX_DWELL_TIME_IN_MINUTES').value;
    this.KpiManagementService.Edit_Data_Source(this.oData_source).then(result => {
      this.oData_source = result;
      this.dialog.closeAll();
      this.isLoading = false;
    })
  }

  Create_Data_Source() {
    this.isLoading = true;
    this.oData_source.DATA_SOURCE_ID = -1;
    this.oData_source.NAME = this.dataSourceForm.get('NAME').value.trim();
    this.oData_source.API_URL = this.dataSourceForm.get('API_URL').value.trim();
    this.oData_source.MIN_DWELL_TIME_IN_MINUTES = this.dataSourceForm.get('MIN_DWELL_TIME_IN_MINUTES').value;
    this.oData_source.MAX_DWELL_TIME_IN_MINUTES = this.dataSourceForm.get('MAX_DWELL_TIME_IN_MINUTES').value;
    this.KpiManagementService.Edit_Data_Source(this.oData_source).then(result => {
      this.oData_source = result;
      this.dialog.closeAll();
      this.isLoading = false;
    })
  }

  @HostListener('window:resize', ['$event'])
  onResize(event) {
    this.isMobileView = window.innerWidth < 600;
  }

}
