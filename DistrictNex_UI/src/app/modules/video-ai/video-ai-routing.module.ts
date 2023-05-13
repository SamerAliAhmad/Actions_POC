import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { VideoAIComponent } from './video-ai.component';
import { VideoAIService } from './video-ai.service';

export const Routes: Route[] = [
    {
        path: '',
        component: VideoAIComponent,
        resolve: {
            data: VideoAIService,
        }
    },
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forChild(Routes)],
    exports: [RouterModule]
})
export class VideoAIRoutingModule { }
