import { Component, OnDestroy, OnInit, ViewEncapsulation } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { User_Details } from 'app/core/Services/proxy.service';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { Navigation } from 'app/shared/navigation/navigation.types';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { SmartrMediaWatcherService } from 'app/shared/services/media-watcher.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'classy-layout',
    templateUrl: './classy.component.html',
    encapsulation: ViewEncapsulation.None
})
export class ClassyLayoutComponent implements OnInit, OnDestroy {
    isScreenSmall: boolean;
    navigation: Navigation;
    User_Details: User_Details;
    private _unsubscribeAll = new Subject<void>();

    dark_logo = '';
    light_logo = '';
    changeOnce = false;

    constructor(
        private CmSvc: CommonService,
        private _smartrMediaWatcherService: SmartrMediaWatcherService,
        private _smartrNavigationService: SmartrNavigationService,
    ) {
        this.dark_logo = this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL;
        this.light_logo = this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL;
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Accessors
    // -----------------------------------------------------------------------------------------------------

    /**
     * Getter for current year
     */
    get currentYear(): number {
        return new Date().getFullYear();
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Lifecycle hooks
    // -----------------------------------------------------------------------------------------------------

    /**
     * On init
     */
    ngOnInit(): void {
        this.CmSvc.onDisplayImageChanged.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.dark_logo = this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL;
            this.light_logo = this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL;
        });

        // Subscribe to navigation data
        this._smartrNavigationService._navigation
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((navigation: Navigation) => {
                this.navigation = navigation;
            });

        this.User_Details = this.CmSvc.oUser_Details;

        // Subscribe to media changes
        this._smartrMediaWatcherService.onMediaChange$
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe(({ matchingAliases }) => {

                // Check if the screen is small
                this.isScreenSmall = !matchingAliases.includes('md');
            });
    }

    isDark() {
        return this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-primary'));
    }

    changeImage(event) {
        if (!this.changeOnce) {
            if (this.isDark()) {
                event.target.src = this.CmSvc.defaultSettings.LIGHT_RECTANGLE_LOGO_URL;
            } else {
                event.target.src = this.CmSvc.defaultSettings.DARK_RECTANGLE_LOGO_URL;
            }
        } else {
            if (this.isDark()) {
                event.target.src = 'assets/images/logo/picacity/logo-white-rect.png';
            } else {
                event.target.src = 'assets/images/logo/picacity/logo-black-rect.png';
            }
        }
        this.changeOnce = true;
    }

    /**
     * On destroy
     */
    ngOnDestroy(): void {
        // Unsubscribe from all subscriptions
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Public methods
    // -----------------------------------------------------------------------------------------------------

    /**
     * Toggle navigation
     *
     * @param name
     */
    toggleNavigation(name: string): void {
        // Get the navigation
        const navigation = this._smartrNavigationService.getComponent<SmartrVerticalNavigationComponent>(name);

        if (navigation) {
            // Toggle the opened status
            navigation.toggle();
        }
    }
}
