import { KpiManagementService } from '../kpi-management.service';
import { CommonService } from 'app/core/Services/common.service';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Dimension, Kpi, Setup } from 'app/core/Services/proxy.service';
import { Component, Inject, OnInit, HostListener } from '@angular/core';
import { FormBuilder, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';

@Component({
    selector: 'kpi-modal',
    templateUrl: './kpi-modal.component.html',
    styleUrls: ['./kpi-modal.component.scss']
})
export class KpiModalComponent implements OnInit {

    oKpi: Kpi;
    oList_Dimension: Dimension[] = [];
    kpiForm: FormGroup;

    isLoading = false;
    isDeleted = false;
    isCreating = false;
    isMobileView = false;

    oList_Kpi_Setup: Setup[] = [];
    oList_Data_level_Setup: Setup[] = [];

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private KpiManagementService: KpiManagementService,
        private _smartrConfirmationService: SmartrConfirmationService,
    ) { }

    ngOnInit(): void {
        this.oKpi = this.data.oKpi;
        if (this.oKpi.KPI_ID == new Kpi().KPI_ID) {
            this.isCreating = true;
        }
        this.oList_Dimension = this.data.oList_Dimension;
        this.oList_Kpi_Setup = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("Kpi Type").List_Setup;
        this.oList_Data_level_Setup = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("Data Level").List_Setup;
        this.kpiForm = this.initializeForm();
    }


    initializeForm(): FormGroup {
        return this._formBuilder.group({
            DIMENSION_ID: [this.oKpi.DIMENSION_ID, Validators.required],
            NAME: [this.oKpi.NAME, Validators.required],
            UNIT: [this.oKpi.UNIT, Validators.required],
            KPI_TYPE_SETUP_ID: [this.oKpi.KPI_TYPE_SETUP_ID, Validators.required],
            HAS_CORRELATION: [this.oKpi.HAS_CORRELATION ?? false,],
            IS_TRENDLINE: [this.oKpi.IS_TRENDLINE ?? false,],
            IS_DECIMAL_VALUE: [this.oKpi.IS_DECIMAL_VALUE ?? false,],
            HAS_SQM: [this.oKpi.HAS_SQM ?? false,],
            IS_BY_SEVERITY: [this.oKpi.IS_BY_SEVERITY ?? false,],
            IS_ADDITIVE_DATA: [this.oKpi.IS_ADDITIVE_DATA ?? false,],
            MINIMUM_VALUE: [this.oKpi.MINIMUM_VALUE, Validators.required],
            MAXIMUM_VALUE: [this.oKpi.MAXIMUM_VALUE, Validators.required],
            IS_AUTO_GENERATE: [this.oKpi.IS_AUTO_GENERATE ?? false,],
            MIN_DATA_LEVEL_SETUP_ID: [this.oKpi.MIN_DATA_LEVEL_SETUP_ID, Validators.required],
            MAX_DATA_LEVEL_SETUP_ID: [this.oKpi.MAX_DATA_LEVEL_SETUP_ID, Validators.required],
            IS_EXTERNAL: [this.oKpi.IS_EXTERNAL ?? false,],
            HAS_ALERTS: [this.oKpi.HAS_ALERTS ?? false,],
        }, {
            validator: [this.minMaxValueTimeValidator]
        });

    }
    minMaxValueTimeValidator(group: FormGroup): ValidationErrors | null {
        const minValue = group.get('MINIMUM_VALUE').value;
        const maxValue = group.get('MAXIMUM_VALUE').value;

        if (minValue != null && maxValue != null && minValue > maxValue) {
            return { 'minMaxValueTimeValidator': true };
        }

        return null;
    }

    Delete_Kpi() {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm KPI Deletion',
            message: "Are you sure you want to delete this KPI?",
            actions: {
                confirm: {
                    show: true,
                    label: 'Yes',
                    color: 'warn',
                },
                cancel: {
                    show: true,
                    label: 'No',
                }
            }
        })
        dialogRef.afterClosed().subscribe((result) => {
            this.isDeleted = true;
            if (result === 'confirmed') {
                this.KpiManagementService.Delete_Kpi(this.oKpi).then(_ => {
                    this.dialog.closeAll();
                })
            }
        });
    }

    Edit_Kpi() {
        this.isLoading = true;
        this.oKpi.NAME = this.kpiForm.get('NAME').value
        this.oKpi.DIMENSION_ID = this.kpiForm.get('DIMENSION_ID').value
        this.oKpi.UNIT = this.kpiForm.get('UNIT').value
        this.oKpi.KPI_TYPE_SETUP_ID = this.kpiForm.get('KPI_TYPE_SETUP_ID').value
        this.oKpi.HAS_CORRELATION = this.kpiForm.get('HAS_CORRELATION').value
        this.oKpi.IS_TRENDLINE = this.kpiForm.get('IS_TRENDLINE').value
        this.oKpi.IS_DECIMAL_VALUE = this.kpiForm.get('IS_DECIMAL_VALUE').value
        this.oKpi.HAS_SQM = this.kpiForm.get('HAS_SQM').value
        this.oKpi.IS_BY_SEVERITY = this.kpiForm.get('IS_BY_SEVERITY').value
        this.oKpi.IS_ADDITIVE_DATA = this.kpiForm.get('IS_ADDITIVE_DATA').value
        this.oKpi.MINIMUM_VALUE = this.kpiForm.get('MINIMUM_VALUE').value
        this.oKpi.MAXIMUM_VALUE = this.kpiForm.get('MAXIMUM_VALUE').value
        this.oKpi.IS_AUTO_GENERATE = this.kpiForm.get('IS_AUTO_GENERATE').value
        this.oKpi.MIN_DATA_LEVEL_SETUP_ID = this.kpiForm.get('MIN_DATA_LEVEL_SETUP_ID').value
        this.oKpi.MAX_DATA_LEVEL_SETUP_ID = this.kpiForm.get('MAX_DATA_LEVEL_SETUP_ID').value
        this.oKpi.IS_EXTERNAL = this.kpiForm.get('IS_EXTERNAL').value
        this.oKpi.HAS_ALERTS = this.kpiForm.get('HAS_ALERTS').value
        this.KpiManagementService.Edit_Kpi(this.oKpi).then(result => {
            this.oKpi = result;
            this.dialog.closeAll();
            this.isLoading = false;
        })
    }

    Create_Kpi() {
        this.isLoading = true;
        this.oKpi.KPI_ID = -1;
        this.oKpi.SETUP_CATEGORY_ID = null;
        this.oKpi.LATEST_DATA_CREATION_DATE = new Date().toISOString();
        this.Edit_Kpi();
    }

    @HostListener('window:resize', ['$event'])
    onResize(event) {
        this.isMobileView = window.innerWidth < 600;
    }
}
