import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Organization_data_source_kpi } from './../../core/Services/proxy.service';
import { Data_source, Dimension, Kpi, Proxy } from 'app/core/Services/proxy.service';

@Injectable({
  providedIn: 'root'
})
export class KpiManagementService {

  oList_Dimension: Dimension[];

  constructor(
    private proxy: Proxy,
    private CmSvc: CommonService,
  ) { }

  Get_Data_Source_List(): Promise<Data_source[]> {
    return new Promise((resolve, reject) => {
      this.proxy.Get_Data_source_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
        if (result) {
          resolve(result);
        }
        else {
          reject();
        }
      })
    })
  }

  Get_Organization_Data_Source_Kpi_List(ORGANIZATION_ID: number): Promise<Organization_data_source_kpi[]> {
    return new Promise((resolve, reject) => {
      this.proxy.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv({ ORGANIZATION_ID: ORGANIZATION_ID }).subscribe(result => {
        if (result) {
          resolve(result);
        }
        else {
          reject();
        }
      })
    })
  }



  Edit_Data_Source(i_Data_source: Data_source): Promise<Data_source> {
    if (i_Data_source.MIN_DWELL_TIME_IN_MINUTES > i_Data_source.MAX_DWELL_TIME_IN_MINUTES) {
      let temp = i_Data_source.MIN_DWELL_TIME_IN_MINUTES;
      i_Data_source.MIN_DWELL_TIME_IN_MINUTES = i_Data_source.MAX_DWELL_TIME_IN_MINUTES;
      i_Data_source.MAX_DWELL_TIME_IN_MINUTES = temp;
    }
    return new Promise((resolve, reject) => {
      this.proxy.Edit_Data_source(i_Data_source).subscribe(result => {
        if (result) {
          resolve(result)
        }
        else {
          reject();
        }
      }
      )
    })
  }


  Edit_Organization_Data_Source_Kpi(i_Organization_data_source_kpi: Organization_data_source_kpi): Promise<Organization_data_source_kpi> {
    return new Promise((resolve, reject) => {
      this.proxy.Edit_Organization_data_source_kpi(i_Organization_data_source_kpi).subscribe(result => {
        if (result) {
          resolve(result)
        }
        else {
          reject();
        }
      }
      )
    })
  }

  Get_Kpi_List(): Promise<Kpi[]> {
    return new Promise((resolve, reject) => {
      this.proxy.Get_Kpi_By_OWNER_ID_Adv({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
        if (result) {
          resolve(result);
        }
        else {
          reject();
        }
      })
    })
  }

  Edit_Kpi(i_Kpi: Kpi): Promise<Kpi> {
    return new Promise((resolve, reject) => {
      this.proxy.Edit_Kpi(i_Kpi).subscribe(result => {
        if (result) {
          resolve(result);
        }
        else {
          reject();
        }
      })
    })
  }

  Delete_Kpi(i_Kpi: Kpi): Promise<boolean> {
    return new Promise((resolve, reject) => {
      this.proxy.Delete_Kpi(i_Kpi).subscribe(_ => {
        resolve(true);
      })
    })
  }

  Delete_Data_Source(i_Data_source: Data_source): Promise<boolean> {
    return new Promise((resolve, reject) => {
      this.proxy.Delete_Data_source(i_Data_source).subscribe(_ => {
        resolve(true)
      }
      )
    })
  }

  Delete_Organization_Data_Source_Kpi(i_Organization_data_source_kpi: Organization_data_source_kpi): Promise<boolean> {
    return new Promise((resolve, reject) => {
      this.proxy.Delete_Organization_data_source_kpi(i_Organization_data_source_kpi).subscribe(_ => {
        resolve(true)
      }
      )
    })
  }

  Get_Dimension_List(): Promise<Dimension[]> {
    return new Promise((resolve, reject) => {
      if (this.oList_Dimension && this.oList_Dimension.length > 0) {
        resolve(this.oList_Dimension)
      }
      else {
        this.proxy.Get_Dimension_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
          if (result) {
            this.oList_Dimension = result;
            resolve(result);
          }
          else {
            reject();
          }
        })
      }
    })
  }



}
