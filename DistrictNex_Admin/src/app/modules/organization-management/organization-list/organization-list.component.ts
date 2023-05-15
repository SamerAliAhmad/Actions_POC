import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Organization } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from '../organization-management.service';
import { OrganizationModalComponent } from '../organization-modal/organization-modal.component';

@Component({
    selector: 'organization-list',
    templateUrl: './organization-list.component.html',
    styleUrls: ['./organization-list.component.scss']
})
export class OrganizationListComponent implements OnInit {

    oList_Organization: Organization[];

    constructor(
        public dialog: MatDialog,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.OrganizationManagementService.get_Organizations().then(result => {
            this.oList_Organization = result;
        });
    }

    createOrganization(): void {
        this.dialog.open(OrganizationModalComponent, {
            width: '850px',
            height: '700px',
            minHeight: '700px'
        })
    }

    getOrgDeleteDate(i_Organization: Organization) {
        if (i_Organization.DATE_DELETED && i_Organization.DATA_RETENTION_PERIOD != null) {
            const deleteDay = new Date(i_Organization.DATE_DELETED)
            deleteDay.setDate(deleteDay.getDate() + i_Organization.DATA_RETENTION_PERIOD)
            return deleteDay.toDateString();
        }
        else {
            return '';
        }
    }
}
