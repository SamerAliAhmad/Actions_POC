import { Location } from '@angular/common';
import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { MatDrawer } from '@angular/material/sidenav';
import { Event, Navigation, NavigationEnd, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Video_ai_instance } from 'app/core/Services/proxy.service';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { VideoAiInstanceDetailsService } from './video-ai-instance-details.service';

@Component({
    selector: 'video-ai-instance-details',
    templateUrl: './video-ai-instance-details.component.html',
    styleUrls: ['./video-ai-instance-details.component.scss']
})

export class VideoAiInstanceDetailsComponent implements OnInit {

    value = 50;
    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';

    isMobileView = false;
    isDrawerOpen: boolean = true;
    isConnectionUrlValid: boolean;
    isProgressSpinnerVisible = false;

    drawerMode: 'over' | 'side' = 'side';
    @ViewChild('drawer') drawer: MatDrawer;

    navigation: Navigation;

    route = '';
    oVideoAiInstance: Video_ai_instance;
    panels = [
        {
            id: 1,
            name: "General Details",
            icon: 'mat_outline:article',
        },
        {
            id: 2,
            name: "Assets",
            icon: 'heroicons_outline:video-camera',
        },
    ];
    selectedPanel = this.panels[0];
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private router: Router,
        private Location: Location,
        private CmSvc: CommonService,
        private _smartrMediaWatcherService: SmartrMediaWatcherService,
        private VideoAiInstanceDetailsService: VideoAiInstanceDetailsService,
    ) { }

    ngOnInit(): void {
        this.isMobileView = window.innerWidth < 600;
        this.route = this.VideoAiInstanceDetailsService.route;
        this._smartrMediaWatcherService.onMediaChange$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(({ matchingAliases }) => {
                if (matchingAliases.includes('md')) {
                    this.drawerMode = 'side';
                    this.isDrawerOpen = true;
                }
                else {
                    this.drawerMode = 'over';
                    this.isDrawerOpen = false;
                }
            });

        this.VideoAiInstanceDetailsService.onInstanceDetailsChanged
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(instance => {
                if (instance) {
                    this.oVideoAiInstance = instance;
                }
            });
        this.router.events
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((event: Event) => {
                if (event instanceof NavigationEnd) {
                    this.route = this.CmSvc.getRoute(event.url);
                }
            });

        if (localStorage.getItem('VideoAiInstancePanel')) {
            this.goToPanelfromLoc(parseInt(localStorage.getItem('VideoAiInstancePanel')));
        }
    }

    goToPanelfromLoc(id: number): void {
        if (this.panels.some(x => x.id === id)) {
            this.selectedPanel = this.panels.filter(x => x.id == id)[0];
            localStorage.setItem('VideoAiInstancePanel', this.selectedPanel.id.toString());
        } else {
            this.selectedPanel = this.panels[0];
            localStorage.setItem('VideoAiInstancePanel', this.selectedPanel.id.toString());
        }
    }
    goToPanel(id): void {
        this.selectedPanel = this.panels.filter(x => x.id == id)[0];
        localStorage.setItem('VideoAiInstancePanel', this.selectedPanel.id.toString());
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
