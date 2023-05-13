import { animate, keyframes, style, transition, trigger } from '@angular/animations';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { User_Details } from 'app/core/Services/proxy.service';
import { slideInLeft, slideInRight } from 'app/shared/animations/slide';
import mapboxgl from 'mapbox-gl';
import { MapService } from '../map/map.service';
import { Organization_Data, Top_Level_Data } from './../../core/Services/proxy.service';
import { SmartrSplashScreenService } from './../../shared/components/splash-screen/splash-screen.service';

@Component({
    selector: 'organization-selection',
    templateUrl: './organization-selection.component.html',
    styleUrls: ['./organization-selection.component.scss'],
    animations: [
        trigger('bubbleGrow', [
            transition(':enter', [
                animate('250ms ease-in-out', keyframes([
                    style({ transform: 'scale(0)' }),
                    style({ transform: 'scale(1.1)' }),
                    style({ transform: 'scale(1)' }),
                ]))
            ]),
            transition(':leave', [
                animate('250ms ease-in-out', keyframes([
                    style({ transform: 'scale(1)' }),
                    style({ transform: 'scale(1.1)' }),
                    style({ transform: 'scale(0)' })
                ]))
            ]),
        ]),
        trigger('labelAnimation', [
            transition(':enter', [
                style({ transform: 'translateY(-20px)', opacity: 0 }),
                animate('0.3s ease-in-out', style({ transform: 'translateY(0)', opacity: 1 })),
            ]),
            transition(':leave', [
                style({ transform: 'translateY(0)', opacity: 1 }),
                animate('0.3s ease-in-out', style({ transform: 'translateY(20px)', opacity: 0 })),
            ]),
        ]),
        slideInLeft,
        slideInRight
    ]
})



export class OrganizationSelectionComponent implements OnInit, OnDestroy {

    oMap: mapboxgl.Map;
    oUser_Details = new User_Details();


    isSpinEnabled = true;
    isInteractive = false;
    isDataRetrieved = false;
    isMapAccessible = true;
    isSelectionComplete = false;
    isOrganizationVisible = true;
    isTopLevelSelectorOpen = false;
    userInteracting: boolean = false;

    secondsPerRevolution = 120;
    iconRef = 'heroicons_outline:library';


    oList_Organization_Data: Organization_Data[] = [];
    oList_Organization_Top_level_Data: Top_Level_Data[] = [];

    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private MapService: MapService,
        private SmartrSplashScreenService: SmartrSplashScreenService
    ) {
        this.CmSvc.oToggle_Module_Subject.next(false);
        this.oUser_Details = this.CmSvc.oUser_Details;
        localStorage.removeItem('organization_id');
        localStorage.removeItem('top_level_id');
        this.oList_Organization_Data = this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data.map(organization_with_top_level => organization_with_top_level.ORGANIZATION_DATA);
    }

    ngOnInit(): void {
        this.init_map();
        if (!this.isSelectionComplete) {
            this.oMap.on('mousedown', () => {
                this.userInteracting = true;
            });
            this.oMap.on('mouseup', () => {
                this.userInteracting = false;
                this.spin_Map();
            });
            this.oMap.on('dragend', () => {
                this.userInteracting = false;
                this.spin_Map();
            });
            this.oMap.on('pitchend', () => {
                this.userInteracting = false;
                this.spin_Map();
            });
            this.oMap.on('rotateend', () => {
                this.userInteracting = false;
                this.spin_Map();
            });
            this.oMap.on('moveend', () => {
                this.spin_Map();
            });
            this.spin_Map();
        }

    }

    goBack() {
        this.isOrganizationVisible = true;
        localStorage.removeItem('organization_id');
        if (this.iconRef == 'heroicons_outline:arrow-left') {
            this.iconRef = 'heroicons_outline:library';
        }
    }

    spin_Map() {
        const maxSpinZoom = 5;
        const slowSpinZoom = 3;
        this.userInteracting;
        const spinEnabled = this.isSpinEnabled
        const zoom = this.oMap.getZoom();
        const center = this.oMap.getCenter();
        if (spinEnabled && !this.userInteracting && zoom < maxSpinZoom) {
            let distancePerSecond = (360 / this.secondsPerRevolution);
            if (zoom > slowSpinZoom) {
                const zoomDif =
                    (maxSpinZoom - zoom) / (maxSpinZoom - slowSpinZoom);
                distancePerSecond *= zoomDif;
            }
            center.lng -= distancePerSecond;
            this.oMap.easeTo({ center, duration: 1000, easing: (n) => n });
        }
    }

    init_map() {
        this.oMap = new mapboxgl.Map({
            container: 'loading-map',
            style: 'mapbox://styles/picacity/clduunc9x001k01qzemlan5eq',
            center: [-112.4194, 37.7749],
            zoom: 2,
            accessToken: 'pk.eyJ1IjoicGljYWNpdHkiLCJhIjoiY2w1dGdwbDZtMGcxNjNlcGs2dzRyZzgxNiJ9.MW-KRbD_RFfeSh_8tV1k1A',
        });
        this.oMap.on('load', () => {
            this.oMap.resize();
            this.SmartrSplashScreenService.hide();
        })
    }

    toggleInteractivity() {
        this.isInteractive = !this.isInteractive;
        this.oMap.boxZoom[this.isInteractive ? 'enable' : 'disable']();
        this.oMap.scrollZoom[this.isInteractive ? 'enable' : 'disable']();
        this.oMap.dragPan[this.isInteractive ? 'enable' : 'disable']();
        this.oMap.dragRotate[this.isInteractive ? 'enable' : 'disable']();
        this.oMap.keyboard[this.isInteractive ? 'enable' : 'disable']();
        this.oMap.doubleClickZoom[this.isInteractive ? 'enable' : 'disable']();
        this.oMap.touchZoomRotate[this.isInteractive ? 'enable' : 'disable']();
    }

    selectOrganization(organization_ID: number) {
        this.Get_Top_Levels_For_Selected_Organization(organization_ID);
        this.iconRef = 'heroicons_outline:arrow-left'
        localStorage.setItem('organization_id', JSON.stringify(organization_ID));
        this.CmSvc.saved_organization_id = organization_ID;
        this.isOrganizationVisible = false;
    }

    Get_Top_Levels_For_Selected_Organization(organization_ID: number) {
        this.oList_Organization_Top_level_Data = this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data.find(organization_with_top_level => organization_with_top_level.ORGANIZATION_DATA.ORGANIZATION_ID == organization_ID).LIST_TOP_LEVEL_DATA;
    }

    Go_To_Initial_Top_Level(top_level_ID: number) {
        this.isTopLevelSelectorOpen = false;
        localStorage.setItem('top_level_id', JSON.stringify(top_level_ID))
        this.CmSvc.saved_top_level_id = top_level_ID;
        this.secondsPerRevolution = 3;
        this.isSelectionComplete = true;
        this.CmSvc.oToggle_Module_Subject.next(this.isSelectionComplete);
        this.CmSvc.Set_Application_Theme();
        this.Get_Map_Data();
    }

    Get_Map_Data() {
        this.SmartrSplashScreenService.show();
        this.MapService.Get_Initial_Top_Level_Data().then(result => {
            if (result) {
                if (!this.CmSvc.chosen_route) {
                    this.CmSvc.chosen_route = 'map';
                    this.router.navigateByUrl(this.CmSvc.chosen_route);
                }
                else {
                    this.router.navigateByUrl(this.CmSvc.chosen_route);
                }
            }
        }).catch(_ => {
            if (this.CmSvc.oList_Accessible_districtnex_module.find(oModule => oModule.Districtnex_module.NAME.toLowerCase() == "video ai")) {
                this.router.navigateByUrl('/video-ai');
            }
            else if (this.CmSvc.oList_Accessible_districtnex_module.find(oModule => oModule.Districtnex_module.NAME.toLowerCase() == "reports")) {
                this.router.navigateByUrl('/reports');
            }
            else {
                this.router.navigateByUrl('/sign-out');
            }
        })
    }

    ngOnDestroy(): void {
        this.oMap.remove();
    }
}
