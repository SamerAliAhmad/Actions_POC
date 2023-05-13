import { AfterViewInit, ChangeDetectorRef, Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Dimension, Entity, Entity_Incidents, Incident, Setup } from 'app/core/Services/proxy.service';
import { SignalrService } from 'app/core/Services/signalr.service';
import { MapService } from 'app/modules/map/map.service';
import { ViewShareService } from 'app/modules/view-share/view-share.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'building-alerts',
    templateUrl: './building-alerts.component.html',
    styleUrls: ['./building-alerts.component.scss']
})
export class BuildingAlertsComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {

    @Input() isShareView = false;
    @Input() oEntity: Entity;
    @Input() oChosen_Category_Setup: Setup;
    @Input() oEntity_Incidents: Entity_Incidents;

    pageIndex = 0;
    pageSize = 20;
    itemCount = 100;
    alertObjectType: string = "";
    displayedColumns = ['camera', 'created'];
    oIncident_DataSource: MatTableDataSource<Incident>;

    isFetchingIncidents = false;

    oSecurity_Dimension: Dimension;

    oList_Status_Setup: Setup[] = [];
    oList_Severity_Setup: Setup[] = [];
    oList_Security_Incident_Category_Setup: Setup[] = [];
    oList_Energy_Incident_Category_Setup: Setup[] = [];


    @ViewChild(MatSort) sort: MatSort;
    @ViewChild(MatPaginator) paginator: MatPaginator;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        private SignalrService: SignalrService,
        private ViewShareService: ViewShareService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        let oIncident_Setup_category = this.CmSvc.oList_Setup_category.find(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Security Incident Category Type");
        this.oList_Security_Incident_Category_Setup = oIncident_Setup_category.List_Setup.filter(setup => setup.VALUE == "Access Control" || setup.VALUE == "Suspicious Behavior" || setup.VALUE == "Fire Alarm" || setup.VALUE == "Blacklisted Person" || setup.VALUE == "Blacklisted Plate");
    }

    ngOnInit() {
        if (!this.isShareView) {
            this.SignalrService.dataSubject
                .pipe(takeUntil(this._unsubscribeAll))
                .subscribe(Message => {
                    if (Message == "Alerts Updated") {
                        this.isFetchingIncidents = true;
                        this.MapService.Get_Entity_Incidents(this.oEntity, this.pageIndex * this.pageSize, (this.pageIndex + 1) * this.pageSize, this.oList_Security_Incident_Category_Setup).then(() => {
                            this.isFetchingIncidents = false;
                        });
                    }
                });
            this.isFetchingIncidents = true;
            this.MapService.Get_Entity_Incidents(this.oEntity, this.pageIndex * this.pageSize, (this.pageIndex + 1) * this.pageSize, this.oList_Security_Incident_Category_Setup).then(() => {
                this.isFetchingIncidents = false;
            });
        } else {
            this.oChosen_Category_Setup = this.oList_Security_Incident_Category_Setup.find(oSetup => oSetup.SETUP_ID == this.ViewShareService.oEntity_share_view_data.INCIDENT_CATEGORY_SETUP_ID);
        }
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['oChosen_Category_Setup']) {
            if (this.paginator) {
                this.paginator.firstPage();
            }
            if (this.oIncident_DataSource) {
                this.updateData();
            }
        }
        if (changes['oEntity_Incidents']) {
            if (this.oIncident_DataSource) {
                this.updateData();
            }
            if (this.paginator) {
                this.paginator.firstPage();
            }
        }
    }

    ngAfterViewInit(): void {
        this.oIncident_DataSource = new MatTableDataSource();
        this.oIncident_DataSource.sort = this.sort;
        this.updateData();
    }

    changePage(paginatorEvent) {
        this.pageSize = paginatorEvent.pageSize;
        this.pageIndex = paginatorEvent.pageIndex;
        this.fetchIncidents();
    }

    fetchIncidents() {
        if (this.paginator) {
            this.isFetchingIncidents = true;
            this.MapService.Get_Entity_Incidents(this.oEntity, this.pageIndex * this.pageSize, (this.pageIndex + 1) * this.pageSize, this.oList_Security_Incident_Category_Setup).then(() => {
                this.updateData();
                this.isFetchingIncidents = false;
            });
        }
    }

    updateData() {
        if (!this.isShareView) {
            if (this.oChosen_Category_Setup) {
                switch (this.oChosen_Category_Setup.VALUE) {
                    case "Access Control":
                        this.oIncident_DataSource.data = this.oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.List_Incident;
                        this.itemCount = this.oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT.COUNT;
                        break;
                    case "Suspicious Behavior":
                        this.oIncident_DataSource.data = this.oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.List_Incident;
                        this.itemCount = this.oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT.COUNT;
                        break;
                    case "Fire Alarm":
                        this.oIncident_DataSource.data = this.oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.List_Incident;
                        this.itemCount = this.oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT.COUNT;
                        break;
                    case "Blacklisted Person":
                        this.oIncident_DataSource.data = this.oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT.List_Incident;
                        this.itemCount = this.oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT.COUNT;
                        break;
                    case "Blacklisted Plate":
                        this.oIncident_DataSource.data = this.oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT.List_Incident;
                        this.itemCount = this.oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT.COUNT;
                        break;
                    default:
                        this.oIncident_DataSource.data = [];
                        break;
                }
            }
        } else {
            this.oIncident_DataSource.data = this.ViewShareService.oEntity_share_view_data.List_Incident;
            this.itemCount = this.ViewShareService.oEntity_share_view_data.List_Incident.length;
            this._changeDetectorRef.detectChanges();
        }
    }

    getSeveritySetupValue(severitySetupId: number) {
        return this.oList_Severity_Setup.filter(setup => setup.SETUP_ID == severitySetupId)[0].VALUE;
    }

    getIncidentCategorySetupValue(incidentCategorySetupId: number) {
        return ([].concat(... this.CmSvc.oList_Setup_category.map(setup_category => setup_category.List_Setup)) as Setup[]).find(setup => setup.SETUP_ID == incidentCategorySetupId)?.VALUE;
    }

    SceneClicked(scene: Incident) {
        let oList_Selected_Search_Categories = [];
        let isLicensePlate = false;
        switch (this.oChosen_Category_Setup.VALUE) {
            case "Access Control":
                oList_Selected_Search_Categories = ['Nothing'];
                this.alertObjectType = "ACCESS CONTROL";
                break;
            case "Suspicious Behavior":
                oList_Selected_Search_Categories = ['Rifle', 'Handgun'];
                this.alertObjectType = "INTRUDER";
                break;
            case "Fire Alarm":
                oList_Selected_Search_Categories = ['Fire'];
                this.alertObjectType = "FIRE ALARM";
                break;
            case "Blacklisted Person":
                oList_Selected_Search_Categories = ['Person, Head'];
                this.alertObjectType = "FR";
                break;
            case "Blacklisted Plate":
                oList_Selected_Search_Categories = ['Bus'];
                this.alertObjectType = "LPR";
                isLicensePlate = true;
                break;
        }
        this.MapService.oOpen_Scene_Details_Subject.next(
            {
                sceneModalData: {
                    sceneId: scene.SCENE_ID,
                    camera: scene.CAMERA,
                    alertObjectType: this.alertObjectType,
                    instanceID: scene.VIDEO_AI_INSTANCE_ID,
                    incident: scene,
                    ENTITY_ID: this.oEntity.ENTITY_ID,
                    oList_Selected_Search_Categories: oList_Selected_Search_Categories,
                    isLicensePlate: isLicensePlate,
                }
            }
        )
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
