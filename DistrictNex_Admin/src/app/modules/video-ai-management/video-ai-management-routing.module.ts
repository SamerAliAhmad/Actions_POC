import { VideoAiAssetDetailsService } from './video-ai-asset-details/video-ai-asset-details.service';
import { VideoAiAssetDetailsComponent } from './video-ai-asset-details/video-ai-asset-details.component';
import { VideoAiInstanceDetailsService } from './video-ai-instance-details/video-ai-instance-details.service';
import { VideoAiInstanceDetailsComponent } from './video-ai-instance-details/video-ai-instance-details.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VideoAiEngineListComponent } from './video-ai-engine-list/video-ai-engine-list.component';
import { VideoAiInstanceListComponent } from './video-ai-instance-list/video-ai-instance-list.component';
import { VideoAiInstanceListService } from './video-ai-instance-list/video-ai-instance-list.service';
import { VideoAiManagementComponent } from './video-ai-management.component';

const routes: Routes = [
  {
    path: '',
    component: VideoAiManagementComponent,
    children: [
      {
        path: '',
        component: VideoAiEngineListComponent,
      },
      {
        path: ':videoAiEngineId',
        component: VideoAiInstanceListComponent,
        resolve: {
          videoInstanceList: VideoAiInstanceListService
        }
      },
      {
        path: ':videoAiEngineId/:videoAiInstanceId',
        component: VideoAiInstanceDetailsComponent,
        resolve: {
          videoInstanceDetails: VideoAiInstanceDetailsService
        }
      },
      {
        path: ':videoAiEngineId/:videoAiInstanceId/:videoAiAssetId',
        component: VideoAiAssetDetailsComponent,
        resolve: {
          videoAiAssetDetails: VideoAiAssetDetailsService
        }
      }
    ]
  },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VideoAiManagementRoutingModule { }
