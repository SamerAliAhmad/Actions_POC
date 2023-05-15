import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnDestroy, OnInit } from '@angular/core';
import { IsActiveMatchOptions } from '@angular/router';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { SmartrNavigationItem } from 'app/shared/navigation/navigation.types';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { SmartrUtilsService } from 'app/shared/services/utils.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'smartr-vertical-navigation-basic-item',
    templateUrl: './basic.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class SmartrVerticalNavigationBasicItemComponent implements OnInit, OnDestroy {
    @Input() item: SmartrNavigationItem;
    @Input() name: string;

    isActiveMatchOptions: IsActiveMatchOptions;
    private _smartrVerticalNavigationComponent: SmartrVerticalNavigationComponent;
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _changeDetectorRef: ChangeDetectorRef,
        private _smartrNavigationService: SmartrNavigationService,
        private _smartrUtilsService: SmartrUtilsService
    ) {
        // Set the equivalent of {exact: false} as default for active match options.
        // We are not assigning the item.isActiveMatchOptions directly to the
        // [routerLinkActiveOptions] because if it's "undefined" initially, the router
        // will throw an error and stop working.
        this.isActiveMatchOptions = this._smartrUtilsService.subsetMatchOptions;
    }
    ngOnInit(): void {
        // Set the "isActiveMatchOptions" either from item's
        // "isActiveMatchOptions" or the equivalent form of
        // item's "exactMatch" option

        this.isActiveMatchOptions =
            this.item.isActiveMatchOptions ?? this.item.exactMatch
                ? this._smartrUtilsService.exactMatchOptions
                : this._smartrUtilsService.subsetMatchOptions;

        // Get the parent navigation component
        this._smartrVerticalNavigationComponent = this._smartrNavigationService.getComponent(this.name);

        // Mark for check
        this._changeDetectorRef.markForCheck();

        // Subscribe to onRefreshed on the navigation component
        this._smartrVerticalNavigationComponent.onRefreshed.pipe(
            takeUntil(this._unsubscribeAll)
        ).subscribe(() => {

            // Mark for check
            this._changeDetectorRef.markForCheck();
        });
    }

    ngOnDestroy(): void {
        // Unsubscribe from all subscriptions
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
