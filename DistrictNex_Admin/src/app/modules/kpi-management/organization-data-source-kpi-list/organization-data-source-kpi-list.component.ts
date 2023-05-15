import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { KpiManagementService } from '../kpi-management.service';
import { Data_source, Kpi, Organization, Organization_data_source_kpi } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { OrganizationDataSourceKpiModalComponent } from '../organization-data-source-kpi-modal/organization-data-source-kpi-modal.component';

class Organization_Data_Source_Lists {
  ORGANIZATION_ID: number;
  LIST_ORGANIZATION_DATA_SOURCE_KPI: Organization_data_source_kpi[];
}

@Component({
  selector: 'organization-data-source-kpi-list',
  templateUrl: './organization-data-source-kpi-list.component.html',
  styleUrls: ['./organization-data-source-kpi-list.component.scss']
})
export class OrganizationDataSourceKpiListComponent implements OnInit {

  oSelected_Organization: Organization;

  oList_Kpi: Kpi[];
  oList_Data_source: Data_source[];
  oList_Organization: Organization[];
  oList_Organization_data_source_kpi: Organization_data_source_kpi[];
  oOrganization_Data_Source_Lists: Organization_Data_Source_Lists[] = [];
  constructor(
    public dialog: MatDialog,
    private KpiManagementService: KpiManagementService,
    private OrganizationManagementService: OrganizationManagementService,
  ) { }

  ngOnInit(): void {
    this.Get_Kpi_List();
    this.Get_Data_Source_List();
    this.Get_Organization_List().then(result => {
      if (result) {
        this.Get_Organization_Data_Source_Kpi_List();
      }
    });
  }

  Get_Organization_Data_Source_Kpi_List() {
    this.oList_Organization_data_source_kpi = [];
    let oOrganization_Data_Source_List = this.oOrganization_Data_Source_Lists.find(_Organization_Data_Source_List => _Organization_Data_Source_List.ORGANIZATION_ID == this.oSelected_Organization.ORGANIZATION_ID);
    if (oOrganization_Data_Source_List) {
      this.oList_Organization_data_source_kpi = oOrganization_Data_Source_List.LIST_ORGANIZATION_DATA_SOURCE_KPI;
    }
    else {
      this.KpiManagementService.Get_Organization_Data_Source_Kpi_List(this.oSelected_Organization.ORGANIZATION_ID).then(result => {
        if (result) {
          this.oOrganization_Data_Source_Lists.push({ ORGANIZATION_ID: this.oSelected_Organization.ORGANIZATION_ID, LIST_ORGANIZATION_DATA_SOURCE_KPI: result })
          this.oList_Organization_data_source_kpi = result;
        }
      })
    }

  }

  Get_Organization_List(): Promise<boolean> {
    return new Promise((resolve, reject) => {
      this.OrganizationManagementService.get_Organizations().then(result => {
        if (result) {
          this.oList_Organization = result;
          this.oSelected_Organization = result[0];
          resolve(true);
        }
        else {
          reject();
        }
      });
    })
  }



  Get_Kpi_List() {
    this.KpiManagementService.Get_Kpi_List().then(result => {
      if (result) {
        this.oList_Kpi = result;
      }
    })
  }

  Get_Data_Source_List() {
    this.KpiManagementService.Get_Data_Source_List().then(result => {
      if (result) {
        this.oList_Data_source = result;
      }
    })
  }


  Open_Organization_Data_source_kpi_details(i_Organization_data_source_kpi: Organization_data_source_kpi) {
    const dialogRef = this.dialog.open(OrganizationDataSourceKpiModalComponent, {
      width: '800px',
      data: {
        oOrganization_data_source_kpi: i_Organization_data_source_kpi,
        oList_Kpi: this.oList_Kpi,
        oList_Data_source: this.oList_Data_source,
        oList_Organization: this.oList_Organization
      }
    })
    dialogRef.afterClosed().subscribe(_ => {
      if (dialogRef.componentInstance.oOrganization_data_source_kpi != i_Organization_data_source_kpi && !dialogRef.componentInstance.isDeleted) {
        this.oList_Organization_data_source_kpi.splice(this.oList_Organization_data_source_kpi.indexOf(i_Organization_data_source_kpi), 1);
        this.oList_Organization_data_source_kpi.push(dialogRef.componentInstance.oOrganization_data_source_kpi);
        let oOrganization_Data_Source_List = this.oOrganization_Data_Source_Lists.find(_oOrg_data_source_list => _oOrg_data_source_list.ORGANIZATION_ID == this.oSelected_Organization.ORGANIZATION_ID);
        this.oOrganization_Data_Source_Lists[this.oOrganization_Data_Source_Lists.indexOf(oOrganization_Data_Source_List)].LIST_ORGANIZATION_DATA_SOURCE_KPI = this.oList_Organization_data_source_kpi;
      }
      if (dialogRef.componentInstance.isDeleted) {
        this.oList_Organization_data_source_kpi.splice(this.oList_Organization_data_source_kpi.findIndex(_data_source => _data_source == dialogRef.componentInstance.oOrganization_data_source_kpi), 1);
        let oOrganization_Data_Source_List = this.oOrganization_Data_Source_Lists.find(_oOrg_data_source_list => _oOrg_data_source_list.ORGANIZATION_ID == this.oSelected_Organization.ORGANIZATION_ID);
        this.oOrganization_Data_Source_Lists[this.oOrganization_Data_Source_Lists.indexOf(oOrganization_Data_Source_List)].LIST_ORGANIZATION_DATA_SOURCE_KPI = this.oList_Organization_data_source_kpi;
      }
    })
  }

  createOrganizationDataSourceKpi() {
    const dialogRef = this.dialog.open(OrganizationDataSourceKpiModalComponent, {
      width: '800px',
      data: {
        oOrganization_data_source_kpi: new Organization_data_source_kpi(),
        oList_Kpi: this.oList_Kpi,
        oList_Data_source: this.oList_Data_source,
        oList_Organization: this.oList_Organization
      }
    })
    dialogRef.afterClosed().subscribe(_ => {
      if (dialogRef.componentInstance.oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID > 0 && !this.oList_Organization_data_source_kpi.find(_Organization_data_source_kpi => _Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == dialogRef.componentInstance.oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)) {
        this.oList_Organization_data_source_kpi.push(dialogRef.componentInstance.oOrganization_data_source_kpi);
        let oOrganization_Data_Source_List = this.oOrganization_Data_Source_Lists.find(_oOrg_data_source_list => _oOrg_data_source_list.ORGANIZATION_ID == this.oSelected_Organization.ORGANIZATION_ID);
        this.oOrganization_Data_Source_Lists[this.oOrganization_Data_Source_Lists.indexOf(oOrganization_Data_Source_List)].LIST_ORGANIZATION_DATA_SOURCE_KPI = this.oList_Organization_data_source_kpi;
      }
    })
  }

}
