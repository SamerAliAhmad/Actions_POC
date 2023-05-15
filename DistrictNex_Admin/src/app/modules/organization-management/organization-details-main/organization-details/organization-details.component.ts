import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { Location } from '@angular/common';
import { MatDrawer } from '@angular/material/sidenav';
import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Organization } from 'app/core/Services/proxy.service';
import { CommonService } from 'app/core/Services/common.service';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'organization-details',
    templateUrl: './organization-details.component.html',
    styleUrls: ['./organization-details.component.scss']
})

export class OrganizationDetailsComponent implements OnInit {

    isDrawerOpened: boolean = true;
    drawerMode: 'over' | 'side' = 'side';
    @ViewChild('drawer') drawer: MatDrawer;

    Super_Organization_Setup_ID: number;

    oOrganization: Organization;

    panelList = [
        {
            id: 1,
            name: 'General Details',
        },
        {
            id: 2,
            name: 'Organization Level Access',
        },
        {
            id: 9,
            name: 'Organization Data Access',
        },
        {
            id: 8,
            name: 'Organization Module Access',
        },
        {
            id: 3,
            name: 'User Quota'
        },
        {
            id: 4,
            name: 'User Management',
        },
        {
            id: 5,
            name: 'Theme Settings'
        },
        {
            id: 6,
            name: 'Organization Images',
        },
        {
            id: 7,
            name: 'Data Settings'
        },
    ];
    selectedPanel = this.panelList[0];
    saveClickSubject = new Subject<void>();
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private Location: Location,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrMediaWatcherService: SmartrMediaWatcherService,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.Super_Organization_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Organization Type", "Super Organization");
    }

    ngOnInit(): void {
        this._smartrMediaWatcherService.onMediaChange$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(({ matchingAliases }) => {
                if (matchingAliases.includes('lg')) {
                    this.drawerMode = 'side';
                    this.isDrawerOpened = true;
                }
                else {
                    this.drawerMode = 'over';
                    this.isDrawerOpened = false;
                }
            });

        this.OrganizationManagementService.get_Organization_Details(this.ActivatedRoute.snapshot.params.id).then(result => {
            if (result) {
                this.oOrganization = result;
                if (this.oOrganization.ORGANIZATION_TYPE_SETUP_ID == this.Super_Organization_Setup_ID) {
                    this.panelList.splice(this.panelList.findIndex(panel => panel.id == 2), 1);
                }
                if (localStorage.getItem('OrgDetailPanel')) {
                    if (this.selectedPanel.id !== parseInt(localStorage.getItem('OrgDetailPanel'))) {
                        this.goToPanelfromLoc(parseInt(localStorage.getItem('OrgDetailPanel')));
                    }
                }
            } else {
                this.router.navigateByUrl("/organization-management");
            }
        });
    }

    goToPanelfromLoc(id): void {
        if (this.panelList.some(x => x.id === id)) {
            this.selectedPanel = this.panelList.filter(x => x.id == id)[0];
        } else {
            this.selectedPanel = this.panelList[0];
        }
        if (this.drawer && this.drawerMode === 'over' && this.oOrganization) {
            this.drawer.close();
        }
        localStorage.setItem('OrgDetailPanel', this.selectedPanel.id.toString());
    }

    goBack(): void {
        this.Location.back();
    }

    save() {
        this.saveClickSubject.next();
    }

    ngOnDestroy(): void {
        this.saveClickSubject.unsubscribe();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
