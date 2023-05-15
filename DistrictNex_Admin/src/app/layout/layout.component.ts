import { DOCUMENT } from '@angular/common';
import { Component, Inject, OnDestroy, OnInit, ViewEncapsulation } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SmartrLoadingService } from 'app/shared/components/loading/loading.service';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { Navigation } from 'app/shared/navigation/navigation.types';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { AppConfig, Layout } from 'app/shared/services/config/config.constants';
import { SmartrConfigService } from 'app/shared/services/config/config.service';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { combineLatest, Subject } from 'rxjs';
import { map, takeUntil } from 'rxjs/operators';

@Component({
    selector: 'layout',
    templateUrl: './layout.component.html',
    styleUrls: ['./layout.component.scss'],
    encapsulation: ViewEncapsulation.None
})
export class LayoutComponent implements OnInit, OnDestroy {
    theme: string;
    layout: Layout;
    config: AppConfig;
    navigation: Navigation;
    isScreenSmall: boolean;
    scheme: 'dark' | 'light';
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _activatedRoute: ActivatedRoute,
        @Inject(DOCUMENT) private _document: any,
        private _smartrConfigService: SmartrConfigService,
        private SmartrLoadingService: SmartrLoadingService,
        private _smartrNavigationService: SmartrNavigationService,
        private _smartrMediaWatcherService: SmartrMediaWatcherService
    ) {
        this.SmartrLoadingService.setAutoMode(true);
    }
    ngOnInit(): void {
        combineLatest([
            this._smartrConfigService.config$,
            this._smartrMediaWatcherService.onMediaQueryChange$(['(prefers-color-scheme: dark)', '(prefers-color-scheme: light)'])
        ]).pipe(
            takeUntil(this._unsubscribeAll),
            map(([config, mql]) => {
                const options = {
                    scheme: config.scheme,
                    theme: config.theme
                };
                if (config.scheme === 'auto') {
                    options.scheme = mql.breakpoints['(prefers-color-scheme: dark)'] ? 'dark' : 'light';
                }
                return options;
            })
        ).subscribe((options) => {
            this.scheme = options.scheme;
            this.theme = options.theme;
            this._updateTheme();
        });
        this._smartrConfigService.config$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((config: AppConfig) => {
                this.config = config;
                this._updateLayout();
            });
        this._smartrMediaWatcherService.onMediaChange$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(({ matchingAliases }) => {
                this.isScreenSmall = !matchingAliases.includes('md');
            });
        this._smartrNavigationService._navigation
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((navigation: Navigation) => {
                this.navigation = navigation;
            });
    }
    toggleNavigation(name: string): void {
        const navigation = this._smartrNavigationService.getComponent<SmartrVerticalNavigationComponent>(name);
        if (navigation) {
            navigation.toggle();
        }
    }
    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
    private _updateLayout(): void {
        let route = this._activatedRoute;
        while (route.firstChild) {
            route = route.firstChild;
        }
        this.layout = this.config.layout;
        const layoutFromQueryParam = (route.snapshot.queryParamMap.get('layout') as Layout);
        if (layoutFromQueryParam) {
            this.layout = layoutFromQueryParam;
            if (this.config) {
                this.config.layout = layoutFromQueryParam;
            }
        }
        const paths = route.pathFromRoot;
        paths.forEach((path) => {
            if (path.routeConfig && path.routeConfig.data && path.routeConfig.data.layout) {
                // Set the layout
                this.layout = path.routeConfig.data.layout;
            }
        });
    }
    private _updateTheme(): void {
        this._document.body.classList.remove('light', 'dark');
        this._document.body.classList.add(this.scheme);
        this._document.body.classList.forEach((className: string) => {
            if (className.startsWith('theme-')) {
                this._document.body.classList.remove(className, className.split('-')[1]);
            }
        });
        this._document.body.classList.add(this.theme);
    }
}
