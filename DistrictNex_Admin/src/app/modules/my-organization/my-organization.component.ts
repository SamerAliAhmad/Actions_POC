import { Subject } from 'rxjs';
import { Location } from '@angular/common';
import { filter, map, takeUntil } from 'rxjs/operators';
import { Path_object } from 'app/core/Models/Path_object';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Organization } from 'app/core/Services/proxy.service';
import { CommonService } from 'app/core/Services/common.service';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { OrganizationManagementService } from '../organization-management/organization-management.service';

@Component({
    selector: 'my-organization',
    templateUrl: './my-organization.component.html',
    styleUrls: ['./my-organization.component.scss']
})
export class MyOrganizationComponent implements OnInit, OnDestroy {

    pathArr: string[] = [];
    pathObject: Path_object[] = [];

    route = '';

    oOrganization_Details: Organization;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private Location: Location,
        private CmSvc: CommonService,
        private activatedRoute: ActivatedRoute,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.oOrganization_Details = this.CmSvc.oOrganization;
        this.fetchPath();

        this.OrganizationManagementService.refetchRouteSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.fetchPath();
        });

        this.router.events
            .pipe(takeUntil(this._unsubscribeAll),
                filter((event) => event instanceof NavigationEnd),
                map(() => this.activatedRoute),
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
        this.pathObject.push({
            Path_Value: this.pathArr[0] + '/' + this.pathArr[1],
            Path_Name: this.pathArr[1].replace('-', ' '),
        });
        if (this.pathArr.length >= 3 && this.oOrganization_Details.List_User && this.oOrganization_Details.List_User.length > 0) {
            const oUser = this.oOrganization_Details.List_User.find(user => user.USER_ID == parseInt(this.pathArr[2]));
            this.pathObject.push({
                Path_Value: this.pathArr[2],
                Path_Name: oUser.FIRST_NAME + ' ' + oUser.LAST_NAME,
            });
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
