import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Params_Upload_Default_Settings_Picture, ProxyExt } from 'app/core/Services/proxyExt.service';
import { Default_chart_color, Default_settings, Params_Delete_Default_Settings_Picture, Params_Edit_Default_chart_color_List, Proxy } from 'app/core/Services/proxy.service';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  oList_Chart_Default_Color: Default_chart_color[];

  constructor(
    private proxy: Proxy,
    private proxyExt: ProxyExt,
    private CmSvc: CommonService,
  ) { }

  EditDefaultSettings(defaultSettings: Default_settings): Promise<Default_settings> {
    return new Promise((resolve, reject) => {
      this.proxy.Edit_Default_settings(defaultSettings).subscribe(result => {
        if (result) {
          this.CmSvc.ShowMessage("Success!");
          this.CmSvc.defaultSettings = result
        }
        resolve(result);
      })
    })
  }

  Get_Default_Chart_Color_List(): Promise<Default_chart_color[]> {
    return new Promise((resolve, reject) => {
      if (this.oList_Chart_Default_Color && this.oList_Chart_Default_Color.length > 0) {
        resolve(this.oList_Chart_Default_Color);
      }
      else {
        this.proxy.Get_Default_chart_color_By_OWNER_ID_Adv({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
          if (result) {
            this.oList_Chart_Default_Color = result;
            resolve(result);
          }
          else {
            reject();
          }
        })
      }
    })
  }

  Edit_Default_Chart_Color_List(i_List_Default_chart_color: Default_chart_color[]): Promise<Params_Edit_Default_chart_color_List> {
    return new Promise((resolve, reject) => {
      this.proxy.Edit_Default_chart_color_List({ List_To_Edit: i_List_Default_chart_color, List_Failed_Delete: [], List_Failed_Edit: [], List_To_Delete: [] }).subscribe(result => {
        if (result) {
          resolve(result);
        }
        else {
          reject();
        }
      })
    })
  }

  uploadFile(file: File, i_Params_Upload_Default_Settings_Picture: Params_Upload_Default_Settings_Picture): Promise<any> {
    return new Promise((resolve, reject) => {
      i_Params_Upload_Default_Settings_Picture.FormData = new FormData();
      i_Params_Upload_Default_Settings_Picture.FormData.append('file', file);
      this.proxyExt.Upload_Default_Settings_Picture(i_Params_Upload_Default_Settings_Picture).subscribe(response => {
        if (response.body.i_Result != null) {
          resolve(response.body.i_Result);
        } else {
          resolve(false);
        }
      }, reject);
    });
  }

  deleteFile(i_Params_Delete_Default_Settings_Picture: Params_Delete_Default_Settings_Picture, imageTypeSetupValue): Promise<any> {
    return new Promise((resolve, reject) => {
      this.proxy.Delete_Default_Settings_Picture(i_Params_Delete_Default_Settings_Picture).subscribe(response => {
        if (response == true) {
          switch (imageTypeSetupValue) {
            case 'Dark_Square_Logo':
              this.CmSvc.defaultSettings.DARK_SQUARE_LOGO_URL = '';
              break;
            case 'Dark_Rect_Logo':
              this.CmSvc.defaultSettings.DARK_RECTANGLE_LOGO_URL = '';
              break;
            case 'Light_Square_Logo':
              this.CmSvc.defaultSettings.LIGHT_SQUARE_LOGO_URL = '';
              break;
            case 'Light_Rect_Logo':
              this.CmSvc.defaultSettings.LIGHT_RECTANGLE_LOGO_URL = '';
              break;
            case 'Favicon':
              this.CmSvc.defaultSettings.ORGANIZATION_FAVICON_URL = '';
              break;
          }
          resolve(response);
        } else {
          resolve(false);
        }
      }, reject);
    });
  }

}
