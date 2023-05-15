import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataSettingsComponent } from 'app/modules/organization-management/organization-details-main/organization-details/data-settings/data-settings.component';
import { GeneralDetailsComponent } from 'app/modules/organization-management/organization-details-main/organization-details/general-details/general-details.component';
import { OrganizationImagesComponent } from 'app/modules/organization-management/organization-details-main/organization-details/organization-images/organization-images.component';
import { ThemeSettingsComponent } from 'app/modules/organization-management/organization-details-main/organization-details/theme-settings/theme-settings.component';
import { CreateUserModalComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/create-user-modal/create-user-modal.component';
import { UserAccessControlComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-access-control/user-access-control.component';
import { UserActivityComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-activity/user-activity.component';
import { UserDataAccessModalComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-data-access/user-data-access-modal/user-data-access-modal.component';
import { UserDataAccessComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-data-access/user-data-access.component';
import { UserDetailsComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-details.component';
import { UserInfoComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-info/user-info.component';
import { UserModuleAccessComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-details/user-module-access/user-module-access.component';
import { UserManagementComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-management/user-management.component';
import { UserQuotaComponent } from 'app/modules/organization-management/organization-details-main/organization-details/user-quota/user-quota.component';
import { BdcWalkModule } from 'bdc-walkthrough';
import { ColorPickerModule } from 'ngx-color-picker';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { NgxMatSelectSearchModule } from 'ngx-mat-select-search';
import { MaterialModule } from '../core/Material/material.module';
import { SmartrCardComponent } from './components/card/card.component';
import { SmartrLoadingBarModule } from './components/loading-bar/loading-bar.module';
import { ChangePasswordModalComponent } from './components/organization-management/change-password-modal/change-password-modal.component';
import { LogFiltersComponent } from './components/organization-management/log-filters/log-filters.component';
import { PasswordStrengthMeterComponent } from './components/password-strength-meter/password-strength-meter.component';
import { PasswordStrengthMeterService } from './components/password-strength-meter/password-strength-meter.service';
import { ProgressSpinnerDialogComponent } from './components/progress-spinner-dialog/progress-spinner-dialog.component';
import { ProgressSpinnerDialogService } from './components/progress-spinner-dialog/progress-spinner-dialog.service';
import { DecimalsOnlyDirective } from './directives/decimals-only.directive';
import { MatTableResponsiveDirective } from './directives/mat-table-response.directive';
import { NumbersOnlyInputDirective } from './directives/numbersOnlyInput.directive';
import { SmartrScrollbarModule } from './directives/scrollbar/scrollbar.module';
import { SmartrNavigationModule } from './navigation/navigation.module';
import { ArrayFilterPipe } from './pipes/array-filter.pipe';
import { PaginationPipe } from './pipes/pagination.pipe';
import { ColoringService } from './services/coloring.service';
import { SmartrMediaWatcherService } from './services/media-watcher.service';
import { SmartrUtilsService } from './services/utils.service';

@NgModule({
    declarations: [
        PaginationPipe,
        ArrayFilterPipe,
        UserInfoComponent,
        UserQuotaComponent,
        SmartrCardComponent,
        LogFiltersComponent,
        UserDetailsComponent,
        DataSettingsComponent,
        UserActivityComponent,
        DecimalsOnlyDirective,
        ThemeSettingsComponent,
        UserManagementComponent,
        GeneralDetailsComponent,
        CreateUserModalComponent,
        NumbersOnlyInputDirective,
        UserModuleAccessComponent,
        UserAccessControlComponent,
        UserDataAccessComponent,
        UserDataAccessModalComponent,
        OrganizationImagesComponent,
        MatTableResponsiveDirective,
        ChangePasswordModalComponent,
        PasswordStrengthMeterComponent,
        ProgressSpinnerDialogComponent,
    ],
    imports: [
        FormsModule,
        CommonModule,
        BdcWalkModule,
        MaterialModule,
        ColorPickerModule,
        NgxDropzoneModule,
        ReactiveFormsModule,
        SmartrScrollbarModule,
        SmartrLoadingBarModule,
        SmartrNavigationModule,
        NgxMatSelectSearchModule,
    ],
    exports: [
        FormsModule,
        CommonModule,
        BdcWalkModule,
        MaterialModule,
        PaginationPipe,
        ArrayFilterPipe,
        NgxDropzoneModule,
        UserInfoComponent,
        UserQuotaComponent,
        LogFiltersComponent,
        SmartrCardComponent,
        ReactiveFormsModule,
        UserDetailsComponent,
        DataSettingsComponent,
        UserActivityComponent,
        SmartrScrollbarModule,
        DecimalsOnlyDirective,
        SmartrNavigationModule,
        ThemeSettingsComponent,
        SmartrLoadingBarModule,
        UserManagementComponent,
        GeneralDetailsComponent,
        CreateUserModalComponent,
        NgxMatSelectSearchModule,
        NumbersOnlyInputDirective,
        UserModuleAccessComponent,
        UserAccessControlComponent,
        OrganizationImagesComponent,
        MatTableResponsiveDirective,
        PasswordStrengthMeterComponent,
        ProgressSpinnerDialogComponent,
    ],
    providers: [
        ColoringService,
        SmartrUtilsService,
        ArrayFilterPipe,
        SmartrMediaWatcherService,
        ProgressSpinnerDialogService,
        PasswordStrengthMeterService,
    ]
})
export class SharedModule {
}
