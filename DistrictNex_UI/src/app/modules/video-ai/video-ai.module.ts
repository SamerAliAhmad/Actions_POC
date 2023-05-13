import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VideoAIService } from './video-ai.service';
import { SharedModule } from 'app/shared/shared.module';
import { VideoAIComponent } from './video-ai.component';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { VideoAIRoutingModule } from './video-ai-routing.module';
import { LicensePlateModalComponent } from './license-plate-recognition/license-plate-modal/license-plate-modal.component';
import { UploadPictureModalComponent } from './facial-recognition/face-search/upload-picture-modal/upload-picture-modal.component';
import { AdvancedSearchInstructionsComponent } from './scene-search/advanced-search-instructions/advanced-search-instructions.component';
import { FacialRecognitionFiltersComponent } from './facial-recognition/facial-recognition-search/facial-recognition-filters/facial-recognition-filters.component';

@NgModule({
    declarations: [
        VideoAIComponent,
        AdvancedSearchInstructionsComponent,
        LicensePlateModalComponent,
        FacialRecognitionFiltersComponent,
        UploadPictureModalComponent
    ],
    imports: [
        CommonModule,
        SharedModule,
        VideoAIRoutingModule,
    ],
    providers: [
        VideoAIService,
        { provide: MAT_DATE_LOCALE, useValue: 'en-CA' },
    ]
})
export class VideoAIModule { }
