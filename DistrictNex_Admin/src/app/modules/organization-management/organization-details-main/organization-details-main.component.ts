import { Subject } from 'rxjs';
import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { filter, map, takeUntil } from 'rxjs/operators';
import { Path_object } from 'app/core/Models/Path_object';
import { Organization } from 'app/core/Services/proxy.service';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'organization-details-main',
    templateUrl: './organization-details-main.component.html',
    styleUrls: ['./organization-details-main.component.scss']
})
export class OrganizationDetailsMainComponent implements OnInit {

    pathArr: string[] = [];
    pathObject: Path_object[] = [];

    oOrganization: Organization;

    route = '';

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private Location: Location,
        private ActivatedRoute: ActivatedRoute,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        const routes = this.router.url.split('/');
        routes.shift();

        this.OrganizationManagementService.get_Organizations().then(result => {
            this.oOrganization = result.find(organization => organization.ORGANIZATION_ID == parseInt(routes[1]));
            this.fetchPath();
            if (!this.oOrganization) {
                this.router.navigateByUrl("/organization-management");
            }
        });

        this.OrganizationManagementService.refetchRouteSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.fetchPath();
        })

        this.router.events.pipe(takeUntil(this._unsubscribeAll),
            filter((event) => event instanceof NavigationEnd),
            map(() => this.ActivatedRoute),
            map((route) => {
                while (route.firstChild) { route = route.firstChild; }
                return route;
            })
        ).subscribe((event) => {
            this.fetchPath();
        });
    }

    fetchPath() {
        this.pathObject = [];
        this.pathArr = this.router.url.split('/');
        this.pathArr.shift();
        this.oOrganization = this.OrganizationManagementService.oList_Organization?.find(organization => organization.ORGANIZATION_ID == parseInt(this.pathArr[1]));
        this.pathObject.push({
            Path_Value: this.pathArr[0],
            Path_Name: 'Organizations',
        });
        if (this.pathArr.length >= 2) {
            this.pathObject.push({
                Path_Value: this.pathArr[1],
                Path_Name: this.oOrganization?.ORGANIZATION_NAME,
            })
        }
        if (this.pathArr.length >= 3 && this.oOrganization?.List_User != null && this.oOrganization?.List_User.length > 0) {
            const oUser = this.oOrganization?.List_User.find(user => user.USER_ID == parseInt(this.pathArr[2]));
            if (oUser) {
                this.pathObject.push({
                    Path_Value: this.pathArr[2],
                    Path_Name: oUser?.FIRST_NAME + ' ' + oUser?.LAST_NAME,
                });
            }
        }
    }

    goBack(): void {
        this.Location.back();
    }

    navigateBack(index) {
        let pathStr = '';
        for (let i = 0; i <= index; i++) {
            pathStr += '/' + this.pathObject[i].Path_Value;
        }
        this.router.navigateByUrl(pathStr);
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
