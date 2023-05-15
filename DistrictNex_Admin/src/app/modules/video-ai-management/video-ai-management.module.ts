import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { VideoAiAssetDetailsComponent } from './video-ai-asset-details/video-ai-asset-details.component';
import { VideoAiAssetGeneralDetailsComponent } from './video-ai-asset-details/video-ai-asset-general-details/video-ai-asset-general-details.component';
import { AddVideoAiEngineModalComponent } from './video-ai-engine-list/add-video-ai-engine-modal/add-video-ai-engine-modal.component';
import { VideoAiEngineListComponent } from './video-ai-engine-list/video-ai-engine-list.component';
import { AddVideoAiAssetModalComponent } from './video-ai-instance-details/video-ai-assets/add-video-ai-asset-modal/add-video-ai-asset-modal.component';
import { VideoAiAssetsComponent } from './video-ai-instance-details/video-ai-assets/video-ai-assets.component';
import { ChangeInstancePasswordModalComponent } from './video-ai-instance-details/video-ai-general-details/change-password-modal/change-password-modal.component';
import { VideoAiGeneralDetailsComponent } from './video-ai-instance-details/video-ai-general-details/video-ai-general-details.component';
import { VideoAiInstanceDetailsComponent } from './video-ai-instance-details/video-ai-instance-details.component';
import { AddVideoAiInstanceModalComponent } from './video-ai-instance-list/add-video-ai-instance-modal/add-video-ai-instance-modal.component';
import { VideoAiInstanceListComponent } from './video-ai-instance-list/video-ai-instance-list.component';
import { VideoAiManagementRoutingModule } from './video-ai-management-routing.module';
import { VideoAiManagementComponent } from './video-ai-management.component';


@NgModule({
    declarations: [
        VideoAiManagementComponent,
        VideoAiEngineListComponent,
        AddVideoAiEngineModalComponent,
        VideoAiInstanceListComponent,
        AddVideoAiInstanceModalComponent,
        VideoAiInstanceDetailsComponent,
        VideoAiAssetsComponent,
        VideoAiGeneralDetailsComponent,
        AddVideoAiAssetModalComponent,
        VideoAiAssetDetailsComponent,
        VideoAiAssetGeneralDetailsComponent,
        ChangeInstancePasswordModalComponent
    ],
    imports: [
        SharedModule,
        CommonModule,
        VideoAiManagementRoutingModule,
    ]
})
export class VideoAiManagementModule { }
