import { Options } from '@angular-slider/ngx-slider';
import { Clipboard } from '@angular/cdk/clipboard';
import { Overlay, OverlayRef } from '@angular/cdk/overlay';
import { TemplatePortal } from '@angular/cdk/portal';
import { ChangeDetectorRef, Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges, TemplateRef, ViewChild, ViewContainerRef } from '@angular/core';
import { MatButton } from '@angular/material/button';
import { ThemePalette } from '@angular/material/core';
import { MatDialog } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { CommonService } from 'app/core/Services/common.service';
import { LogsService } from 'app/core/Services/logs.service';
import { Entity, Wifi_signal, Wifi_signal_alert } from 'app/core/Services/proxy.service';
import { ViewShareService } from 'app/modules/view-share/view-share.service';
import { QrCodeModalComponent } from 'app/shared/components/qr-code-modal/qr-code-modal.component';
import { ShareEmailModalComponent } from 'app/shared/components/share-email-modal/share-email-modal.component';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { toPng } from 'html-to-image';
import jsPDF from 'jspdf';
import { Subject, takeUntil } from 'rxjs';
import { Setup, Space_asset, Video_ai_asset } from '../../../../core/Services/proxy.service';
import { MapService } from '../../map.service';

@Component({
    selector: 'floor-summary',
    templateUrl: './floor-summary.component.html',
    styleUrls: ['./floor-summary.component.scss']
})
export class FloorSummaryComponent implements OnInit, OnChanges, OnDestroy {

    @Input() isShareView = false;
    @Input() oEntity: Entity;
    @Input() oSpace_asset: Space_asset;

    @Input() isLoading = false;
    @Input() isShowHeatmap = false;
    @Input() isShowSliderAndIcon = false;

    @Input() oList_Original_wifi_signal: Wifi_signal[];
    @Input() oList_Original_Wifi_signal_alert: Wifi_signal_alert[] = [];

    @Output() Update_Size_Event_Emitter = new EventEmitter<any>();
    @Output() Toggle_Slider_Event_Emitter = new EventEmitter<boolean>();
    @Output() Gather_Share_data_Event_Emitter = new EventEmitter<void>();
    @Output() Toggle_Show_Heatmap_Event_Emitter = new EventEmitter<void>();

    @ViewChild('shortcutsOrigin') private _shortcutsOrigin: MatButton;
    @ViewChild('shortcutsPanel') private _shortcutsPanel: TemplateRef<any>;

    options: Options = {
        hidePointerLabels: true,
        hideLimitLabels: true,
        floor: 0,
        ceil: 10,
        vertical: true
    };

    action = 0;
    icon: string;
    oLink: string;
    sliderValue = 1;

    isCamera1on = false;
    isCamera2on = false;
    isCamera3on = false;
    isShowCamera = true;
    isShowSlider = false;
    isShowInsights = true;
    displayProgressSpinner = false;
    isStartingAssetsLoaded = false;

    oList_Selected_emails: string[] = [];
    oVaidioCameras: Video_ai_asset[] = [];
    oList_Wifi_signal: Wifi_signal[] = [];
    oList_Incident_Category_Setup: Setup[];
    oList_Selected_Assets: Space_asset[] = [];
    oList_Wifi_signal_Space_asset: Space_asset[] = [];
    oList_Wifi_signal_alert: Wifi_signal_alert[] = [];

    value = 50;
    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';

    private _overlayRef: OverlayRef;
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _overlay: Overlay,
        private dialog: MatDialog,
        private Clipboard: Clipboard,
        private CmSvc: CommonService,
        private MapService: MapService,
        private LogsService: LogsService,
        public TimezoneService: TimezoneService,
        private ViewShareService: ViewShareService,
        private _viewContainerRef: ViewContainerRef,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        let oIncident_type_Setup_Category = this.CmSvc.oList_Setup_category.find(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Security Incident Category Type");
        this.oList_Incident_Category_Setup = oIncident_type_Setup_Category.List_Setup.filter(setup => setup.VALUE == "Access Control" || setup.VALUE == "Suspicious Behavior" || setup.VALUE == "Fire Alarm" || setup.VALUE == "Blacklisted Person" || setup.VALUE == "Blacklisted Plate");
    }

    ngOnInit(): void {
        this.MapService.oEntity_share_data_Link_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(result => {
            this.displayProgressSpinner = false;
            if (result) {
                this.oLink = result;
                switch (this.action) {
                    case 0:
                        this.dialog.open(QrCodeModalComponent, {
                            data: this.oLink,
                        });
                        break;
                    case 1:
                        this.dialog.open(ShareEmailModalComponent, {
                            width: '500px',
                            data: this.oLink,
                        });
                        break;
                    case 2:
                        const isLinkCopied = this.Clipboard.copy(this.oLink);
                        if (isLinkCopied) {
                            this.CmSvc.ShowMessage("Link is copied to clipboard");
                        } else {
                            this.CmSvc.ShowMessage("Link has been generated");
                        }
                        break;
                }
            }
        });
        if (this.isShareView) {
            this.ViewShareService.oEntity_share_view_data.List_Summary_Space_asset.forEach(oSpace_asset => {
                this.isCamera1on = this.ViewShareService.oEntity_share_view_data.IS_CAMERA_ONE_ON;
                this.isCamera2on = this.ViewShareService.oEntity_share_view_data.IS_CAMERA_TWO_ON;
                this.isCamera3on = this.ViewShareService.oEntity_share_view_data.IS_CAMERA_THREE_ON;
                oSpace_asset.Asset.Asset_type_setup = this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("asset type", oSpace_asset.Asset.ASSET_TYPE_SETUP_ID);
                switch (oSpace_asset.Asset.Asset_type_setup.VALUE) {
                    case "Alert":
                        oSpace_asset.ASSET_ICON = "heroicons_outline:exclamation-circle";
                        if (!this.oList_Selected_Assets.some(asset => asset.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID)) {
                            this.oList_Selected_Assets.unshift(oSpace_asset);
                        }
                        break;
                    case "Wifi Signal":
                        let oWifi_signal_alert = this.ViewShareService.oEntity_share_view_data.List_Wifi_signal_alert.find(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID);
                        if (oWifi_signal_alert) {
                            if (!this.oList_Wifi_signal_alert.some(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID == oWifi_signal_alert.SPACE_ASSET_ID)) {
                                this.oList_Wifi_signal_Space_asset.push(oSpace_asset);
                                this.oList_Wifi_signal_alert.push(oWifi_signal_alert);
                                const oWifi_signal = this.ViewShareService.oEntity_share_view_data.List_Summary_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID);
                                if (oWifi_signal) {
                                    this.oList_Wifi_signal.push(oWifi_signal);
                                }
                            }
                        } else {
                            if (!this.oList_Wifi_signal_alert.some(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID)) {
                                oWifi_signal_alert = new Wifi_signal_alert();
                                oWifi_signal_alert.ALERT_VALUE = null;
                                oWifi_signal_alert.SPACE_ASSET_ID = oSpace_asset.SPACE_ASSET_ID;
                                oWifi_signal_alert.IS_RESOLVED = true;
                                this.oList_Wifi_signal_Space_asset.push(oSpace_asset);
                                this.oList_Wifi_signal_alert.push(oWifi_signal_alert);
                                const oWifi_signal = this.ViewShareService.oEntity_share_view_data.List_Summary_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID);
                                if (oWifi_signal) {
                                    this.oList_Wifi_signal.push(oWifi_signal);
                                }
                            }
                        }
                        break;
                }
            });
        }
    }

    Open_Scene_Details(i_Space_asset: Space_asset) {
        if (this.isShareView) {
            return;
        }
        this.isLoading = true;
        let oList_Selected_Search_Categories = []
        let alertObjectType = "ACCESS CONTROL";
        switch (i_Space_asset.Asset.NAME) {
            case "Medium Alert":
                oList_Selected_Search_Categories = ['Rifle', 'Handgun'];
                alertObjectType = "INTRUDER";
                break;
            case "High Alert":
                oList_Selected_Search_Categories = ['Fire'];
                alertObjectType = "FIRE ALARM";
                break;
        }
        this.MapService.Get_Entity_Incidents(this.oEntity, null, null, this.oList_Incident_Category_Setup).then(incidents => {
            this.isLoading = false;
            if (i_Space_asset.Asset.NAME == "Low Alert") {
                this.MapService.oOpen_Scene_Details_Subject.next({
                    sceneModalData: {
                        sceneId: incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident[0].SCENE_ID,
                        camera: incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident[0].CAMERA,
                        alertObjectType: alertObjectType,
                        instanceID: incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident[0].VIDEO_AI_INSTANCE_ID,
                        incident: incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident[0],
                        ENTITY_ID: this.oEntity.ENTITY_ID,
                        oList_Selected_Search_Categories: oList_Selected_Search_Categories,
                        isLicensePlate: false,
                    }
                });
            }
            if (i_Space_asset.Asset.NAME == "Medium Alert") {
                this.MapService.oOpen_Scene_Details_Subject.next({
                    sceneModalData: {
                        sceneId: incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident[0].SCENE_ID,
                        camera: incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident[0].CAMERA,
                        alertObjectType: alertObjectType,
                        instanceID: incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident[0].VIDEO_AI_INSTANCE_ID,
                        incident: incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident[0],
                        ENTITY_ID: this.oEntity.ENTITY_ID,
                        oList_Selected_Search_Categories: oList_Selected_Search_Categories,
                        isLicensePlate: false,
                    }
                });
            }
            if (i_Space_asset.Asset.NAME == "High Alert") {
                this.MapService.oOpen_Scene_Details_Subject.next({
                    sceneModalData: {
                        sceneId: incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident[0].SCENE_ID,
                        camera: incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident[0].CAMERA,
                        alertObjectType: alertObjectType,
                        instanceID: incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident[0].VIDEO_AI_INSTANCE_ID,
                        incident: incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident[0],
                        ENTITY_ID: this.oEntity.ENTITY_ID,
                        oList_Selected_Search_Categories: oList_Selected_Search_Categories,
                        isLicensePlate: false,
                    }
                });
            }
        });
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (this.isShareView) {
            return;
        }
        if (changes['oSpace_asset'] && this.oSpace_asset && !this.oList_Selected_Assets.some(space_asset => space_asset.SPACE_ASSET_ID == this.oSpace_asset.SPACE_ASSET_ID)) {
            switch (this.oSpace_asset.Asset.Asset_type_setup.VALUE) {
                case "Camera":
                    if (!this.isShowCamera) {
                        break;
                    }
                    this.oSpace_asset.ASSET_ICON = "heroicons_outline:video-camera";
                    switch ((this.oSpace_asset.CUSTOM_NAME.match(/(\d+)/)[0].toString().split('').map(Number).reduce((a, b) => a + b, 0) % 3) + 1) {
                        case 1:
                            if (this.isCamera1on) {
                                this.isLoading = false;
                            } else {
                                this.oVaidioCameras[0] = this.oSpace_asset.List_Video_ai_asset[0];
                                this.isCamera1on = true;
                                this.isLoading = false;
                                if (this.oVaidioCameras[0]) {
                                    this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Camera " + this.oVaidioCameras[0].FRIENDLY_NAME,
                                        this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Security Camera Module").SETUP_ID,
                                        this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID,
                                        null, null, this.oSpace_asset.List_Video_ai_asset[0]?.VIDEO_AI_ASSET_ID);
                                }
                            }
                            break;
                        case 2:
                            if (this.isCamera2on) {
                                this.isLoading = false;
                            } else {
                                this.oVaidioCameras[1] = this.oSpace_asset.List_Video_ai_asset[0];
                                this.isCamera2on = true;
                                this.isLoading = false;
                                if (this.oVaidioCameras[1]) {
                                    this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Camera " + this.oVaidioCameras[1].FRIENDLY_NAME,
                                        this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Security Camera Module").SETUP_ID,
                                        this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID,
                                        null, null, this.oSpace_asset.List_Video_ai_asset[0]?.VIDEO_AI_ASSET_ID);
                                }
                            }
                            break;
                        case 3:
                            if (this.isCamera3on) {
                                this.isLoading = false;
                            } else {
                                this.oVaidioCameras[2] = this.oSpace_asset.List_Video_ai_asset[0];
                                this.isCamera3on = true;
                                this.isLoading = false;
                                if (this.oVaidioCameras[2]) {
                                    this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Accessed Camera " + this.oVaidioCameras[2].FRIENDLY_NAME,
                                        this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Security Camera Module").SETUP_ID,
                                        this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID,
                                        null, null, this.oSpace_asset.List_Video_ai_asset[0]?.VIDEO_AI_ASSET_ID);
                                }
                            }
                            break;
                    }
                    break;
                case "Alert":
                    this.oSpace_asset.ASSET_ICON = "heroicons_outline:exclamation-circle";
                    if (!this.oList_Selected_Assets.some(asset => asset.SPACE_ASSET_ID == this.oSpace_asset.SPACE_ASSET_ID)) {
                        this.oList_Selected_Assets.unshift(this.oSpace_asset);
                    }
                    break;
                case "Wifi Signal":
                    let oWifi_signal_alert = this.oList_Original_Wifi_signal_alert.find(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID == this.oSpace_asset.SPACE_ASSET_ID);
                    if (oWifi_signal_alert) {
                        if (!this.oList_Wifi_signal_alert.some(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID == oWifi_signal_alert.SPACE_ASSET_ID)) {
                            this.oList_Wifi_signal_Space_asset.push(this.oSpace_asset);
                            this.oList_Wifi_signal_alert.push(oWifi_signal_alert);
                            const oWifi_signal = this.oList_Original_wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == this.oSpace_asset.SPACE_ASSET_ID);
                            if (oWifi_signal) {
                                this.oList_Wifi_signal.push(oWifi_signal);
                            }
                        }
                    } else {
                        if (!this.oList_Wifi_signal_alert.some(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID == this.oSpace_asset.SPACE_ASSET_ID)) {
                            oWifi_signal_alert = new Wifi_signal_alert();
                            oWifi_signal_alert.ALERT_VALUE = null;
                            oWifi_signal_alert.SPACE_ASSET_ID = this.oSpace_asset.SPACE_ASSET_ID;
                            oWifi_signal_alert.IS_RESOLVED = true;
                            this.oList_Wifi_signal_Space_asset.push(this.oSpace_asset);
                            this.oList_Wifi_signal_alert.push(oWifi_signal_alert);
                            const oWifi_signal = this.oList_Original_wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == this.oSpace_asset.SPACE_ASSET_ID);
                            if (oWifi_signal) {
                                this.oList_Wifi_signal.push(oWifi_signal);
                            }
                        }
                    }
                    break;
            }
        }
        if (changes['isShowSliderAndIcon'] && this.isShowSliderAndIcon == false) {
            this.isShowSlider = false;
            this.sliderValue = 1;
            this.Update_Size_Event_Emitter.emit(1);
        }
    }

    removeCamera(index) {
        if (this.oVaidioCameras[index - 1]) {
            this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Exited Camera " + this.oVaidioCameras[index - 1].FRIENDLY_NAME,
                this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Security Camera Module").SETUP_ID,
                this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID,
                null, null, this.oVaidioCameras[index - 1].VIDEO_AI_ASSET_ID);
        }
        switch (index) {
            case 1:
                this.oVaidioCameras[0] = null;
                this.isCamera1on = false;
                break;
            case 2:
                this.oVaidioCameras[1] = null;
                this.isCamera2on = false;
                break;
            case 3:
                this.oVaidioCameras[2] = null;
                this.isCamera3on = false;
                break;
        }
    }

    removeAsset(floorAsset: Space_asset) {
        this.oList_Selected_Assets.splice(this.oList_Selected_Assets.indexOf(floorAsset), 1);
    }

    removeWifiSignalAlert(i_Wifi_signal_alert: Wifi_signal_alert) {
        this.oList_Wifi_signal_Space_asset.splice(this.oList_Wifi_signal_Space_asset.findIndex(wifi_signal_space_asset => wifi_signal_space_asset.SPACE_ASSET_ID == i_Wifi_signal_alert.SPACE_ASSET_ID), 1);
        this.oList_Wifi_signal.splice(this.oList_Wifi_signal.findIndex(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == i_Wifi_signal_alert.SPACE_ASSET_ID), 1);
        this.oList_Wifi_signal_alert.splice(this.oList_Wifi_signal_alert.indexOf(i_Wifi_signal_alert), 1);
    }

    getSpaceAssetName(i_Wifi_signal_alert: Wifi_signal_alert) {
        return this.oList_Wifi_signal_Space_asset.find(space_asset => space_asset.SPACE_ASSET_ID == i_Wifi_signal_alert.SPACE_ASSET_ID)?.CUSTOM_NAME;
    }

    getWifiSignalValue(i_Wifi_signal_alert: Wifi_signal_alert) {
        return this.oList_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == i_Wifi_signal_alert.SPACE_ASSET_ID)?.VALUE;
    }

    getWifiSignalRecordDate(i_Wifi_signal_alert: Wifi_signal_alert) {
        return this.oList_Wifi_signal.find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == i_Wifi_signal_alert.SPACE_ASSET_ID)?.RECORD_DATE;
    }

    openVideoPanel() {
        this.MapService.oOpen_Video_AI_Drawer_Subject.next();
    }

    openInsights() {
        this.MapService.oOpen_Energy_Insights_Panel_Subject.next();
    }

    openPanel(): void {
        if (!this._shortcutsPanel || !this._shortcutsOrigin) {
            return;
        }

        if (!this._overlayRef) {
            this._createOverlay();
        }
        this._overlayRef.attach(new TemplatePortal(this._shortcutsPanel, this._viewContainerRef));
    }

    closePanel(): void {
        this._overlayRef.detach();
    }

    toggleSliderView() {
        this.isShowSlider = !this.isShowSlider;
        this.sliderValue = 0;
        this.Toggle_Slider_Event_Emitter.emit(!this.isShowSlider);
        this.Update_Size_Event_Emitter.emit(1);
    }

    printPdf() {
        this.displayProgressSpinner = true;
        this._overlayRef.detach();
        this._changeDetectorRef.detectChanges();
        const oList_Page_to_print = document.getElementsByClassName('page-to-print');
        const oList_Promise: Promise<string>[] = [];
        const filter = (node: HTMLElement) => {
            const exclusionClasses = ['remove-on-pdf'];
            return !exclusionClasses.some((classname) => node.classList?.contains(classname));
        }
        for (let i = 0; i < oList_Page_to_print.length; i++) {
            oList_Promise.push(new Promise<string>((resolve, reject) => {
                toPng((oList_Page_to_print[i] as HTMLElement), {
                    width: oList_Page_to_print[i].scrollWidth,
                    height: oList_Page_to_print[i].scrollHeight,
                    filter: filter,
                }).then(dataUrl => {
                    var img = new Image();
                    img.onload = () => {
                        var canvas = document.createElement('canvas');
                        canvas.width = img.width;
                        canvas.height = img.height;
                        canvas.getContext('2d').drawImage(img, 0, 0);
                        resolve(canvas.toDataURL());
                    };
                    img.onerror = reject;
                    img.src = dataUrl;
                });
            }));
        }
        Promise.all(oList_Promise).then(oList_Data_url => {
            var doc = new jsPDF('l', 'pt', 'a4', true);
            oList_Data_url.forEach((data_url, i) => {
                var imgProps = doc.getImageProperties(data_url);
                var pdfWidth = doc.internal.pageSize.getWidth() - 20;
                var pdfHeight = (imgProps.height * pdfWidth) / imgProps.width;
                doc.addImage(data_url, 'PNG', 10, 10, pdfWidth, pdfHeight, undefined, 'FAST');
                if ((oList_Data_url.length - 1) != i) {
                    doc.addPage();
                }
            });
            doc.save("Entity Drawer.pdf");
            this.displayProgressSpinner = false;
        }).catch(function (error) {
            this.CmSvc.ShowMessage('Failed to generate PDF');
            this.displayProgressSpinner = false;
        });
    }

    generateQr() {
        this.displayProgressSpinner = true;
        this.action = 0;
        this.Gather_Share_data_Event_Emitter.emit();
    }

    shareByEmail() {
        this.displayProgressSpinner = true;
        this.action = 1;
        this.Gather_Share_data_Event_Emitter.emit();
    }

    generateWebLink() {
        this.displayProgressSpinner = true;
        this.action = 2;
        this.Gather_Share_data_Event_Emitter.emit();
    }

    private _createOverlay(): void {
        this._overlayRef = this._overlay.create({
            hasBackdrop: true,
            backdropClass: 'smartr-backdrop-on-mobile',
            scrollStrategy: this._overlay.scrollStrategies.block(),
            positionStrategy: this._overlay.position()
                .flexibleConnectedTo(this._shortcutsOrigin._elementRef.nativeElement)
                .withLockedPosition(true)
                .withPush(true)
                .withPositions([
                    {
                        originX: 'start',
                        originY: 'bottom',
                        overlayX: 'start',
                        overlayY: 'top'
                    },
                    {
                        originX: 'start',
                        originY: 'top',
                        overlayX: 'start',
                        overlayY: 'bottom'
                    },
                    {
                        originX: 'end',
                        originY: 'bottom',
                        overlayX: 'end',
                        overlayY: 'top'
                    },
                    {
                        originX: 'end',
                        originY: 'top',
                        overlayX: 'end',
                        overlayY: 'bottom'
                    }
                ])
        });

        this._overlayRef.backdropClick().subscribe(() => {
            this._overlayRef.detach();
        });
    }

    onSliderValueChange() {
        this.Update_Size_Event_Emitter.emit(this.sliderValue)
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
