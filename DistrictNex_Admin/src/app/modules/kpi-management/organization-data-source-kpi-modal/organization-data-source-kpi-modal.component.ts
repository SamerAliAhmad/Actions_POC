import { KpiManagementService } from '../kpi-management.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Component, HostListener, Inject, OnInit } from '@angular/core';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { Data_source, Kpi, Organization, Organization_data_source_kpi } from './../../../core/Services/proxy.service';

@Component({
  selector: 'organization-data-source-kpi-modal',
  templateUrl: './organization-data-source-kpi-modal.component.html',
  styleUrls: ['./organization-data-source-kpi-modal.component.scss']
})
export class OrganizationDataSourceKpiModalComponent implements OnInit {

  isLoading = false;
  isDeleted = false;
  isCreating = false;
  isMobileView = false;

  oList_Kpi: Kpi[];
  oList_Data_source: Data_source[];
  oList_Organization: Organization[];

  organizationDataSourceKpiForm: FormGroup;

  oOrganization_data_source_kpi: Organization_data_source_kpi;

  constructor(
    private dialog: MatDialog,
    private _formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private KpiManagementService: KpiManagementService,
    private _smartrConfirmationService: SmartrConfirmationService,
  ) { }

  ngOnInit(): void {
    this.oOrganization_data_source_kpi = this.data.oOrganization_data_source_kpi;
    this.oList_Kpi = this.data.oList_Kpi
    this.oList_Data_source = this.data.oList_Data_source
    this.oList_Organization = this.data.oList_Organization

    if (this.oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == new Organization_data_source_kpi().ORGANIZATION_DATA_SOURCE_KPI_ID) {
      this.isCreating = true;
    }
    this.organizationDataSourceKpiForm = this.initializeForm();
  }

  initializeForm(): FormGroup {
    return this._formBuilder.group({
      DATA_SOURCE_ID: [this.oOrganization_data_source_kpi.DATA_SOURCE_ID, Validators.required],
      KPI_ID: [this.oOrganization_data_source_kpi.KPI_ID, [Validators.required]],
      ORGANIZATION_ID: [this.oOrganization_data_source_kpi.ORGANIZATION_ID, Validators.required],
    });
  }

  Delete_Organiztion_Data_Source_Kpi() {
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
        this.KpiManagementService.Delete_Organization_Data_Source_Kpi(this.oOrganization_data_source_kpi).then(_ => {
          this.dialog.closeAll();
        })
      }
    });

  }

  Edit_Organization_Data_Source_Kpi() {
    this.isLoading = true;
    this.oOrganization_data_source_kpi.DATA_SOURCE_ID = this.organizationDataSourceKpiForm.get('DATA_SOURCE_ID').value;
    this.oOrganization_data_source_kpi.KPI_ID = this.organizationDataSourceKpiForm.get('KPI_ID').value;
    this.oOrganization_data_source_kpi.Kpi = this.oList_Kpi.find(oKpi => oKpi.KPI_ID == this.oOrganization_data_source_kpi.KPI_ID);
    this.oOrganization_data_source_kpi.ORGANIZATION_ID = this.organizationDataSourceKpiForm.get('ORGANIZATION_ID').value;
    this.KpiManagementService.Edit_Organization_Data_Source_Kpi(this.oOrganization_data_source_kpi).then(result => {
      this.oOrganization_data_source_kpi = result;
      this.dialog.closeAll();
      this.isLoading = false;
    })
  }

  Create_Organization_Data_Source_Kpi() {
    this.isLoading = true;
    this.oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = -1;
    this.Edit_Organization_Data_Source_Kpi();
  }

  @HostListener('window:resize', ['$event'])
  onResize(event) {
    this.isMobileView = window.innerWidth < 600;
  }
}
