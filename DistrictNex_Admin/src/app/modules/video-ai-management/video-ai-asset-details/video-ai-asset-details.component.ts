import { Location } from '@angular/common';
import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { MatDrawer } from '@angular/material/sidenav';
import { Event, Navigation, NavigationEnd, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Video_ai_asset } from 'app/core/Services/proxy.service';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { VideoAiAssetDetailsService } from './video-ai-asset-details.service';

@Component({
    selector: 'video-ai-asset-details',
    templateUrl: './video-ai-asset-details.component.html',
    styleUrls: ['./video-ai-asset-details.component.scss']
})
export class VideoAiAssetDetailsComponent implements OnInit {

    isMobileView = false;
    isDrawerOpened: boolean = true;

    drawerMode: 'over' | 'side' = 'side';
    @ViewChild('drawer') drawer: MatDrawer;

    navigation: Navigation;

    route = '';
    oVideoAiAsset: Video_ai_asset;

    panels = [
        {
            id: 1,
            name: "General Details",
            icon: 'mat_outline:article',
        },
    ];
    selectedPanel = this.panels[0];
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private Location: Location,
        private CmSvc: CommonService,
        private VideoAiAssetDetailsService: VideoAiAssetDetailsService,
        private _smartrMediaWatcherService: SmartrMediaWatcherService,
    ) { }

    ngOnInit(): void {
        this.isMobileView = window.innerWidth < 600;
        this.route = this.VideoAiAssetDetailsService.route;
        this._smartrMediaWatcherService.onMediaChange$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(({ matchingAliases }) => {
                if (matchingAliases.includes('md')) {
                    this.drawerMode = 'side';
                    this.isDrawerOpened = true;
                }
                else {
                    this.drawerMode = 'over';
                    this.isDrawerOpened = false;
                }
            });

        this.VideoAiAssetDetailsService.getAssetDetails().then(asset => {
            if (asset) {
                this.oVideoAiAsset = asset;
            }
        });
        this.router.events
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((event: Event) => {
                if (event instanceof NavigationEnd) {
                    this.route = this.CmSvc.getRoute(event.url);
                }
            });

        if (localStorage.getItem('VideoAiAssetPanel')) {
            this.goToPanelfromLoc(parseInt(localStorage.getItem('VideoAiAssetPanel')));
        }
    }

    goToPanelfromLoc(id: number): void {
        if (this.panels.some(x => x.id === id)) {
            this.selectedPanel = this.panels.filter(x => x.id == id)[0];
            localStorage.setItem('VideoAiAssetPanel', this.selectedPanel.id.toString());
        } else {
            this.selectedPanel = this.panels[0];
            localStorage.setItem('VideoAiAssetPanel', this.selectedPanel.id.toString());
        }
    }
    goToPanel(id): void {
        this.selectedPanel = this.panels.filter(x => x.id == id)[0];
        localStorage.setItem('VideoAiAssetPanel', this.selectedPanel.id.toString());
        if (this.drawerMode === 'over') {
            this.drawer.close();
        }
    }
    getPanelInfo(id: number): any {
        return this.panels.find(panel => panel.id === id);
    }
    goBack(isBlock = false): void {
        if (!isBlock) {
            this.Location.back();
        }
    }
    getClass() {
        if (this.route == '') {
            return '';
        }
        return "text-primary cursor-pointer";
    }

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
