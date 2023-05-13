import { NgxMatDatetimePickerModule, NgxMatNativeDateModule, NgxMatTimepickerModule } from '@angular-material-components/datetime-picker';
import { NgxSliderModule } from '@angular-slider/ngx-slider';
import { CommonModule, DatePipe, DecimalPipe } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { MAT_TOOLTIP_DEFAULT_OPTIONS, MatTooltipDefaultOptions } from '@angular/material/tooltip';
import { QRCodeModule } from 'angularx-qrcode';
import { BuildingAlertsSkeletonComponent } from 'app/modules/map/entity-drawer/building-alerts/building-alerts-skeleton/building-alerts-skeleton.component';
import { BuildingAlertsComponent } from 'app/modules/map/entity-drawer/building-alerts/building-alerts.component';
import { BuildingRendererComponent } from 'app/modules/map/entity-drawer/building-renderer/building-renderer.component';
import { BuildingSelectorComponent } from 'app/modules/map/entity-drawer/building-selector/building-selector.component';
import { BuildingSummarySkeletonComponent } from 'app/modules/map/entity-drawer/building-summary/building-summary-skeleton/building-summary-skeleton.component';
import { BuildingSummaryComponent } from 'app/modules/map/entity-drawer/building-summary/building-summary.component';
import { EnergyInsightsPanelComponent } from 'app/modules/map/entity-drawer/energy-insights-panel/energy-insights-panel.component';
import { EntityDrawerComponent } from 'app/modules/map/entity-drawer/entity-drawer.component';
import { ExpandedFloorRendererComponent } from 'app/modules/map/entity-drawer/floor-renderer/expanded-floor-renderer/expanded-floor-renderer.component';
import { FloorRendererComponent } from 'app/modules/map/entity-drawer/floor-renderer/floor-renderer.component';
import { FloorSummaryComponent } from 'app/modules/map/entity-drawer/floor-summary/floor-summary.component';
import { SceneDetailsComponent } from 'app/modules/map/entity-drawer/scene-details/scene-details.component';
import { VideoAiDrawerComponent } from 'app/modules/map/entity-drawer/video-ai-drawer/video-ai-drawer.component';
import { VideoAiSkeletonComponent } from 'app/modules/map/entity-drawer/video-ai-drawer/video-ai-skeleton/video-ai-skeleton.component';
import { EntitySummaryDrawerComponent } from 'app/modules/map/entity-summary-drawer/entity-summary-drawer.component';
import { FaceListComponent } from 'app/modules/video-ai/facial-recognition/face-list/face-list.component';
import { FaceSearchComponent } from 'app/modules/video-ai/facial-recognition/face-search/face-search.component';
import { FacialRecognitionSearchComponent } from 'app/modules/video-ai/facial-recognition/facial-recognition-search/facial-recognition-search.component';
import { FacialRecognitionComponent } from 'app/modules/video-ai/facial-recognition/facial-recognition.component';
import { LicensePlateListComponent } from 'app/modules/video-ai/license-plate-recognition/license-plate-list/license-plate-list.component';
import { LicensePlateRecognitionComponent } from 'app/modules/video-ai/license-plate-recognition/license-plate-recognition.component';
import { LicensePlateSearchComponent } from 'app/modules/video-ai/license-plate-recognition/license-plate-search/license-plate-search.component';
import { PeopleCountingComponent } from 'app/modules/video-ai/people-counting/people-counting.component';
import { SceneModalComponent } from 'app/modules/video-ai/scene-search/scene-modal/scene-modal.component';
import { SceneSearchComponent } from 'app/modules/video-ai/scene-search/scene-search.component';
import { VehicleCountingComponent } from 'app/modules/video-ai/vehicle-counting/vehicle-counting.component';
import { VideoMonitoringComponent } from 'app/modules/video-ai/video-monitoring/video-monitoring.component';
import { BdcWalkModule } from 'bdc-walkthrough';
import { Chart } from 'chart.js';
import 'chartjs-adapter-moment';
import { TreemapController, TreemapElement } from 'chartjs-chart-treemap';
import Annotation from 'chartjs-plugin-annotation';
import { NgChartsModule } from 'ng2-charts';
import { DragScrollModule } from 'ngx-drag-scroll';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { NgxMatSelectSearchModule } from 'ngx-mat-select-search';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { MaterialModule } from '../core/Material/material.module';
import { SmartrCardModule } from './components/card/card.module';
import { SmartrConfirmationModule } from './components/confirmation/confirmation.module';
import { PasswordStrengthMeterComponent } from './components/password-strength-meter/password-strength-meter.component';
import { PasswordStrengthMeterService } from './components/password-strength-meter/password-strength-meter.service';
import { ProgressSpinnerDialogComponent } from './components/progress-spinner-dialog/progress-spinner-dialog.component';
import { ProgressSpinnerDialogService } from './components/progress-spinner-dialog/progress-spinner-dialog.service';
import { QrCodeModalComponent } from './components/qr-code-modal/qr-code-modal.component';
import { ShareButtonComponent } from './components/share-button/share-button.component';
import { ShareEmailModalComponent } from './components/share-email-modal/share-email-modal.component';
import { VaidioVideoCameraComponent } from './components/vaidio-video-camera/vaidio-video-camera.component';
import { AddFlatButtonClassDirective } from './directives/addFlatButtonClass.directive';
import { AddStrokedButtonClassDirective } from './directives/addStrokedButtonClass.directive';
import { SmartrDraggableDialogDirective } from './directives/draggableDialog.directive';
import { MatIconReplacerModule } from './directives/mat-icon-replacer.module';
import { NumbersOnlyInputDirective } from './directives/numbersOnlyInput.directive';
import { SmartrScrollbarModule } from './directives/scrollbar/scrollbar.module';
import { SmartrNavigationModule } from './navigation/navigation.module';
import { ArrayFilterPipe } from './pipes/array-filter.pipe';
import { ColoringService } from './services/coloring.service';
import { SmartrMediaWatcherService } from './services/media-watcher.service';
import { SmartrUtilsService } from './services/utils.service';


Chart.register(TreemapController, TreemapElement, Annotation);

export const oMatTooltipDefaultOptions: MatTooltipDefaultOptions = {
    showDelay: 0,
    hideDelay: 0,
    touchGestures: 'auto',
    touchendHideDelay: 0,
    disableTooltipInteractivity: true,
}

@NgModule({
    declarations: [
        ArrayFilterPipe,
        FaceListComponent,
        FaceSearchComponent,
        SceneModalComponent,
        SceneSearchComponent,
        QrCodeModalComponent,
        ShareButtonComponent,
        SceneDetailsComponent,
        FloorSummaryComponent,
        EntityDrawerComponent,
        SceneDetailsComponent,
        FloorRendererComponent,
        VideoAiDrawerComponent,
        BuildingAlertsComponent,
        PeopleCountingComponent,
        VehicleCountingComponent,
        VideoAiSkeletonComponent,
        BuildingSummaryComponent,
        ShareEmailModalComponent,
        VideoMonitoringComponent,
        VideoAiSkeletonComponent,
        NumbersOnlyInputDirective,
        BuildingSelectorComponent,
        BuildingRendererComponent,
        LicensePlateListComponent,
        VaidioVideoCameraComponent,
        FacialRecognitionComponent,
        LicensePlateSearchComponent,
        AddFlatButtonClassDirective,
        EntitySummaryDrawerComponent,
        EnergyInsightsPanelComponent,
        PasswordStrengthMeterComponent,
        ProgressSpinnerDialogComponent,
        SmartrDraggableDialogDirective,
        ExpandedFloorRendererComponent,
        AddStrokedButtonClassDirective,
        BuildingAlertsSkeletonComponent,
        BuildingSummarySkeletonComponent,
        FacialRecognitionSearchComponent,
        LicensePlateRecognitionComponent,
    ],
    imports: [
        FormsModule,
        CommonModule,
        QRCodeModule,
        BdcWalkModule,
        NgChartsModule,
        CarouselModule,
        MaterialModule,
        NgxSliderModule,
        SmartrCardModule,
        DragScrollModule,
        NgxDropzoneModule,
        SlickCarouselModule,
        ReactiveFormsModule,
        InfiniteScrollModule,
        MatIconReplacerModule,
        SmartrScrollbarModule,
        NgxMatTimepickerModule,
        NgxMatNativeDateModule,
        SmartrNavigationModule,
        NgxMatSelectSearchModule,
        NgxMatDatetimePickerModule,
    ],
    exports: [
        FormsModule,
        DecimalPipe,
        QRCodeModule,
        CommonModule,
        BdcWalkModule,
        NgChartsModule,
        CarouselModule,
        MaterialModule,
        NgxSliderModule,
        ArrayFilterPipe,
        SmartrCardModule,
        DragScrollModule,
        FaceListComponent,
        NgxDropzoneModule,
        SceneModalComponent,
        FaceSearchComponent,
        ReactiveFormsModule,
        SlickCarouselModule,
        ShareButtonComponent,
        SceneSearchComponent,
        InfiniteScrollModule,
        MatIconReplacerModule,
        SceneDetailsComponent,
        FloorSummaryComponent,
        SmartrScrollbarModule,
        EntityDrawerComponent,
        SceneDetailsComponent,
        VideoAiDrawerComponent,
        FloorRendererComponent,
        SmartrNavigationModule,
        NgxMatTimepickerModule,
        NgxMatNativeDateModule,
        BuildingAlertsComponent,
        PeopleCountingComponent,
        VideoMonitoringComponent,
        VideoAiSkeletonComponent,
        VehicleCountingComponent,
        SmartrConfirmationModule,
        NgxMatSelectSearchModule,
        BuildingSummaryComponent,
        BuildingSelectorComponent,
        NumbersOnlyInputDirective,
        BuildingRendererComponent,
        LicensePlateListComponent,
        NgxMatDatetimePickerModule,
        VaidioVideoCameraComponent,
        FacialRecognitionComponent,
        LicensePlateSearchComponent,
        AddFlatButtonClassDirective,
        EntitySummaryDrawerComponent,
        EnergyInsightsPanelComponent,
        PasswordStrengthMeterComponent,
        ExpandedFloorRendererComponent,
        ProgressSpinnerDialogComponent,
        SmartrDraggableDialogDirective,
        AddStrokedButtonClassDirective,
        BuildingAlertsSkeletonComponent,
        BuildingSummarySkeletonComponent,
        FacialRecognitionSearchComponent,
        LicensePlateRecognitionComponent,
    ],
    providers: [
        DatePipe,
        DecimalPipe,
        ColoringService,
        ArrayFilterPipe,
        SmartrUtilsService,
        SmartrMediaWatcherService,
        ProgressSpinnerDialogService,
        PasswordStrengthMeterService,
        { provide: MAT_DATE_LOCALE, useValue: 'en-CA' },
        { provide: MAT_TOOLTIP_DEFAULT_OPTIONS, useValue: oMatTooltipDefaultOptions },
    ]
})
export class SharedModule {
}
