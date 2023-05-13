import { NgModule } from '@angular/core';
import { MAT_TABS_CONFIG } from '@angular/material/tabs';
import { SharedModule } from 'app/shared/shared.module';
import { environment } from 'environments/environment';
import { NgxMapboxGLModule } from 'ngx-mapbox-gl';
import { AlertsDrawerComponent } from './alerts-drawer/alerts-drawer.component';
import { BigSkeletonComponent } from './bottom-bar/big-skeleton/big-skeleton.component';
import { BottomBarComponent } from './bottom-bar/bottom-bar.component';
import { SmallSkeletonComponent } from './bottom-bar/small-skeleton/small-skeleton.component';
import { ChartModalComponent } from './chart-modal/chart-modal.component';
import { EntityDialogComponent } from './entity-dialog/entity-dialog.component';
import { EntityDimensionsComponent } from './entity-dimensions/entity-dimensions.component';
import { EventDetailsDialogComponent } from './event-details-dialog/event-details-dialog.component';
import { InfoModalComponent } from './info-modal/info-modal.component';
import { CorrelationMethodDetailsModalComponent } from './insights-drawer/correlation/correlation-method-details-modal/correlation-method-details-modal.component';
import { CorrelationComponent } from './insights-drawer/correlation/correlation.component';
import { InsightsDrawerComponent } from './insights-drawer/insights-drawer.component';
import { MultipleKpiComparisonComponent } from './insights-drawer/multiple-kpi-comparison/multiple-kpi-comparison.component';
import { SingleKpiComparisonComponent } from './insights-drawer/single-kpi-comparison/single-kpi-comparison.component';
import { WifiSignalInsightsComponent } from './insights-drawer/wifi-signal-insights/wifi-signal-insights.component';
import { IntersectionDrawerComponent } from './intersection-drawer/intersection-drawer.component';
import { LevelDialogComponent } from './level-dialog/level-dialog.component';
import { LevelKpiChartsComponent } from './level-kpi-charts/level-kpi-charts.component';
import { LevelKpiDrawerComponent } from './level-kpi-drawer/level-kpi-drawer.component';
import { MapRoutingModule } from './map-routing.module';
import { MapComponent } from './map.component';
import { TopLevelSelectorComponent } from './top-level-selector/top-level-selector.component';

@NgModule({
    declarations: [
        AlertsDrawerComponent,
        BigSkeletonComponent,
        BottomBarComponent,
        ChartModalComponent,
        CorrelationComponent,
        CorrelationMethodDetailsModalComponent,
        EntityDialogComponent,
        EntityDimensionsComponent,
        EventDetailsDialogComponent,
        InfoModalComponent,
        InsightsDrawerComponent,
        IntersectionDrawerComponent,
        LevelDialogComponent,
        LevelKpiChartsComponent,
        LevelKpiDrawerComponent,
        MapComponent,
        MultipleKpiComparisonComponent,
        SingleKpiComparisonComponent,
        SmallSkeletonComponent,
        TopLevelSelectorComponent,
        WifiSignalInsightsComponent,
    ],
    imports: [
        SharedModule,
        MapRoutingModule,
        NgxMapboxGLModule.withConfig({
            accessToken: environment.MapBox_Token,
        }),
    ],
    providers: [
        { provide: MAT_TABS_CONFIG, useValue: { animationDuration: '0ms' } }
    ]
})
export class MapModule { }
