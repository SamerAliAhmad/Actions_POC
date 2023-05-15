import { Overlay, OverlayRef } from '@angular/cdk/overlay';
import { TemplatePortal } from '@angular/cdk/portal';
import { Component, ElementRef, OnDestroy, OnInit, Renderer2, TemplateRef, ViewChild, ViewContainerRef } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Organization, Setup, User } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import FuzzySearch from 'fuzzy-search';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { CreateUserModalComponent } from './create-user-modal/create-user-modal.component';

@Component({
    selector: 'user-management',
    templateUrl: './user-management.component.html',
    styleUrls: ['./user-management.component.scss']
})
export class UserManagementComponent implements OnInit, OnDestroy {

    @ViewChild('tagsPanel') private _tagsPanel: TemplateRef<any>;
    @ViewChild('tagsPanelOrigin') private _tagsPanelOrigin: ElementRef;

    oOrganization: Organization;
    userSearchInput: FormControl;

    oList_User_to_display: User[] = [];
    oList_User_Type_Setup_List: Setup[];
    oList_Chosen_User_Type_Setup: Setup[] = [];

    isUserListEmpty = false;
    isMyOrganization = false;

    oSuper_Admin_User_Type_Setup: Setup;
    oOrganization_Admin_User_Type_Setup: Setup;


    private _tagsPanelOverlayRef: OverlayRef;
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private dialog: MatDialog,
        private _overlay: Overlay,
        private CmSvc: CommonService,
        private _renderer2: Renderer2,
        private ActivatedRoute: ActivatedRoute,
        private _viewContainerRef: ViewContainerRef,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.userSearchInput = new FormControl('');
        if (this.CmSvc.oUser_Details.User_type_setup.VALUE == 'Super Admin') {
            this.oList_User_Type_Setup_List = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup;
        }
        else {
            this.oList_User_Type_Setup_List = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup.filter(userType => userType.VALUE != 'Super Admin');
        }
        this.oOrganization_Admin_User_Type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup.filter(userType => userType.VALUE == 'Organization Admin')[0];
        this.oSuper_Admin_User_Type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup.filter(userType => userType.VALUE == 'Super Admin')[0];
    }

    ngOnInit(): void {
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        if (this.CmSvc.oUser_Details.User_type_setup.VALUE == 'Super Admin') {
            this.oList_User_to_display = this.oOrganization.List_User.sort((a, b) => a.FIRST_NAME.localeCompare(b.FIRST_NAME));
        } else {
            this.oList_User_to_display = this.oOrganization.List_User.sort((a, b) => a.FIRST_NAME.localeCompare(b.FIRST_NAME)).filter(user => this.getType(user) != 'super admin');
        }

        this.userSearchInput.valueChanges.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.filterSearchEmployees();
        });
    }

    createUser(): void {
        const allowedTotal = this.oOrganization.MAX_NUMBER_OF_ADMINS + this.oOrganization.MAX_NUMBER_OF_USERS;
        if (this.oOrganization.List_User &&
            this.oOrganization.List_User.length < allowedTotal) {
            this.dialog.open(CreateUserModalComponent, {
                width: '800px',
                maxHeight: '700px',
                data: this.oOrganization,
            })
        }
        else {
            this.CmSvc.ShowMessage('The organization\'s maximum quota of ' + allowedTotal + ' users has been reached', 3000);
        }
    }

    filterSearchEmployees(): void {
        let resultList = this.oOrganization.List_User;

        if (this.oList_Chosen_User_Type_Setup && this.oList_Chosen_User_Type_Setup.length > 0) {
            resultList = this.oOrganization.List_User.filter(user => {
                return this.oList_Chosen_User_Type_Setup.some(type => type.SETUP_ID === user.USER_TYPE_SETUP_ID)
            });
        }
        if (this.userSearchInput.value && this.userSearchInput.value.trim() != '') {
            const searcher = new FuzzySearch(resultList, ['FIRST_NAME', 'LAST_NAME']);
            resultList = searcher.search(this.userSearchInput.value);
        }
        this.oList_User_to_display = resultList.sort((a, b) => a.FIRST_NAME.localeCompare(b.FIRST_NAME));
    }

    openTagsPanel(): void {
        // Create the overlay
        this._tagsPanelOverlayRef = this._overlay.create({
            backdropClass: '',
            hasBackdrop: true,
            scrollStrategy: this._overlay.scrollStrategies.block(),
            positionStrategy: this._overlay.position()
                .flexibleConnectedTo(this._tagsPanelOrigin.nativeElement)
                .withFlexibleDimensions()
                .withViewportMargin(64)
                .withLockedPosition()
                .withPositions([
                    {
                        originX: 'start',
                        originY: 'bottom',
                        overlayX: 'start',
                        overlayY: 'top'
                    }
                ])
        });

        // Subscribe to the attachments observable
        this._tagsPanelOverlayRef.attachments().subscribe(() => {

            // Add a class to the origin
            this._renderer2.addClass(this._tagsPanelOrigin.nativeElement, 'panel-opened');

            // Focus to the search input once the overlay has been attached
            this._tagsPanelOverlayRef.overlayElement.querySelector('input').focus();
        });

        // Create a portal from the template
        const templatePortal = new TemplatePortal(this._tagsPanel, this._viewContainerRef);

        // Attach the portal to the overlay
        this._tagsPanelOverlayRef.attach(templatePortal);

        // Subscribe to the backdrop click
        this._tagsPanelOverlayRef.backdropClick().subscribe(() => {

            // Remove the class from the origin
            this._renderer2.removeClass(this._tagsPanelOrigin.nativeElement, 'panel-opened');

            // If overlay exists and attached...
            if (this._tagsPanelOverlayRef && this._tagsPanelOverlayRef.hasAttached()) {
                // Detach it
                this._tagsPanelOverlayRef.detach();
            }

            // If template portal exists and attached...
            if (templatePortal && templatePortal.isAttached) {
                // Detach it
                templatePortal.detach();
            }
        });
    }

    toggleUserTypeChoice(chosenUserType): void {
        if (this.oList_Chosen_User_Type_Setup.includes(chosenUserType)) {
            this.removeUserTypeChoice(chosenUserType);
        }
        else {
            this.addUserTypeChoice(chosenUserType);
        }
    }

    addUserTypeChoice(chosenUserType): void {
        this.oList_Chosen_User_Type_Setup.unshift(chosenUserType);
        this.filterSearchEmployees();
    }

    removeUserTypeChoice(chosenUserType): void {
        this.oList_Chosen_User_Type_Setup.splice(this.oList_Chosen_User_Type_Setup.indexOf(chosenUserType), 1);
        this.filterSearchEmployees();
    }

    clearUserFilter(): void {
        this.oList_Chosen_User_Type_Setup = [];
        this.filterSearchEmployees();
    }

    getType(user: User): string {
        if (user.USER_TYPE_SETUP_ID == this.oOrganization_Admin_User_Type_Setup.SETUP_ID) {
            return 'org admin'
        }
        else if (user.USER_TYPE_SETUP_ID == this.oSuper_Admin_User_Type_Setup.SETUP_ID) {
            return 'super admin'
        }
        else {
            return 'user'
        }
    }

    goToUser(userId: number) {
        this.router.navigateByUrl(this.router.url + '/' + userId);
    }

    getDeleteDate(i_User: User): string {
        if (i_User.DATE_DELETED && i_User.DATA_RETENTION_PERIOD != null) {
            const deleteDay = new Date(i_User.DATE_DELETED)
            deleteDay.setDate(deleteDay.getDate() + i_User.DATA_RETENTION_PERIOD)
            return deleteDay.toDateString();
        }
        else {
            return '';
        }
    }

    getOrgDeleteDate() {
        if (this.oOrganization.DATE_DELETED && this.oOrganization.DATA_RETENTION_PERIOD != null) {
            const deleteDay = new Date(this.oOrganization.DATE_DELETED)
            deleteDay.setDate(deleteDay.getDate() + this.oOrganization.DATA_RETENTION_PERIOD)
            return deleteDay.toDateString();
        }
        else {
            return '';
        }
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
