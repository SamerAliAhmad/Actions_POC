import { Location } from '@angular/common';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDrawer } from '@angular/material/sidenav';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Organization, User } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { Subject, Subscription } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'user-details',
    templateUrl: './user-details.component.html',
    styleUrls: ['./user-details.component.scss'],
    host: {
        class: 'h-full'
    }
})
export class UserDetailsComponent implements OnInit {
    isDrawerOpened: boolean = true;
    drawerMode: 'over' | 'side' = 'side';
    @ViewChild('drawer') drawer: MatDrawer;

    oUser: User;
    oOrganization: Organization;

    panelList = [
        {
            id: 1,
            name: 'User Info',
        },
        {
            id: 2,
            name: 'User Level Access',
        },
        {
            id: 5,
            name: 'User Data Access'
        },
        {
            id: 4,
            name: 'User Module Access',
        },
        {
            id: 3,
            name: 'User Activity'
        },
    ];
    selectedPanel = this.panelList[0];

    isAbs = false;
    isMyOrganization = false;
    routeSubscription: Subscription;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private Location: Location,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrMediaWatcherService: SmartrMediaWatcherService,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.routeSubscription = this.ActivatedRoute.data.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => this.isAbs = data.isAbs);

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

        if (localStorage.getItem('UserDetailPanel')) {
            if (this.selectedPanel.id !== parseInt(localStorage.getItem('UserDetailPanel'))) {
                this.goToPanelfromLoc(parseInt(localStorage.getItem('UserDetailPanel')));
            }
        }

        const routes = this.router.url.split('/');
        routes.shift();

        const oOrganization_Promise = new Promise<void>(resolve => {
            this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
            if (this.isMyOrganization) {
                this.oOrganization = this.CmSvc.oOrganization;
                resolve();
            } else {
                this.OrganizationManagementService.get_Organization_Details(parseInt(routes[1])).then(result => {
                    if (result) {
                        this.oOrganization = result;
                        resolve();
                    } else {
                        this.router.navigateByUrl("/organization-management");
                    }
                });
            }
        })
        oOrganization_Promise.then(() => {
            this.OrganizationManagementService.get_User_Details(this.oOrganization, this.ActivatedRoute.snapshot.params.userId).then(result => {
                this.oUser = result;
            });
        });
    }

    goToPanelfromLoc(id): void {
        if (this.panelList.some(x => x.id === id)) {
            this.selectedPanel = this.panelList.filter(x => x.id == id)[0];
        } else {
            this.selectedPanel = this.panelList[0];
        }
        if (this.drawerMode === 'over' && this.oUser) {
            this.drawer.close();
        }
        localStorage.setItem('UserDetailPanel', this.selectedPanel.id.toString());
    }

    getClass() {
        return "text-primary cursor-pointer";
    }

    goBack(): void {
        this.Location.back();
    }

    ngOnDestroy(): void {
        this.OrganizationManagementService.oList_User_District = null;
        this.OrganizationManagementService.oList_User_Area = null;
        this.OrganizationManagementService.oList_User_Site = null;
        this.OrganizationManagementService.oList_User_Entity = null;
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
        this.routeSubscription.unsubscribe();
    }
}
