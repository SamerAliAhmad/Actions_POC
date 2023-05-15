import { cloneDeep } from 'lodash';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { Organization } from 'app/core/Services/proxy.service';
import { CommonService } from 'app/core/Services/common.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'user-quota',
    templateUrl: './user-quota.component.html',
    styleUrls: ['./user-quota.component.scss']
})
export class UserQuotaComponent implements OnInit {
    oOrganization: Organization;
    oOrganization_Original: Organization;

    currentTotalUsers = 0;
    totalAllowedUsers = 0;
    numberSuperAdmins = 0;
    currentNumberUsers = 0;
    currentNumberAdmins = 0;

    isLoading = false;
    isMyOrganization = false;

    constructor(
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization_Original = this.CmSvc.oOrganization;
        } else {
            this.oOrganization_Original = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        if (this.oOrganization_Original) {
            this.oOrganization = cloneDeep(this.oOrganization_Original);
        }

        this.currentNumberUsers = this.OrganizationManagementService.calculateNumberUsers(this.oOrganization);
        this.currentNumberAdmins = this.OrganizationManagementService.calculateNumberAdmins(this.oOrganization);
        this.currentTotalUsers = this.currentNumberAdmins + this.currentNumberUsers;
        this.numberSuperAdmins = this.OrganizationManagementService.calculateNumberSuperAdmins(this.oOrganization);
        this.calculateTotalAllowed();
    }

    resetOrganizationQuota(organizationQuotaForm: NgForm): void {
        this.oOrganization = cloneDeep(this.oOrganization_Original);
        this.calculateTotalAllowed();
        organizationQuotaForm.form.markAsPristine();
    }

    calculateTotalAllowed(): void {
        this.totalAllowedUsers = this.oOrganization.MAX_NUMBER_OF_ADMINS + this.oOrganization.MAX_NUMBER_OF_USERS;
    }

    checkUsersInvalid(): boolean {
        return this.currentNumberUsers > this.oOrganization.MAX_NUMBER_OF_USERS;
        return true;
    }

    checkAdminsInvalid(): boolean {
        return this.currentNumberAdmins > this.oOrganization.MAX_NUMBER_OF_ADMINS;
        return true;
    }

    checkTotalInvalid(): boolean {
        return this.currentTotalUsers > this.totalAllowedUsers;
    }

    editOrganizationQuota(organizationQuotaForm: NgForm): void {
        if (organizationQuotaForm.invalid) {
            this.CmSvc.ShowMessage("Some data is missing or wrong");
            return;
        }
        if (!this.checkAdminsInvalid() && !this.checkUsersInvalid() && !this.checkTotalInvalid()) {
            this.isLoading = true;
            this.OrganizationManagementService.Modify_Organization_Details(this.oOrganization).then(result => {
                if (result) {
                    this.oOrganization_Original = result;
                    this.oOrganization = cloneDeep(this.oOrganization_Original);
                }
                this.isLoading = false;
            });
        }
    }
}
