import { BooleanInput } from '@angular/cdk/coercion';
import { ChangeDetectionStrategy, ChangeDetectorRef, Component, HostBinding, Input, OnDestroy, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { smartrAnimations } from 'app/shared/animations/animations';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { SmartrNavigationItem } from 'app/shared/navigation/navigation.types';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { Subject } from 'rxjs';
import { filter, takeUntil } from 'rxjs/operators';

@Component({
    selector: 'smartr-vertical-navigation-collapsable-item',
    templateUrl: './collapsable.component.html',
    animations: smartrAnimations,
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class SmartrVerticalNavigationCollapsableItemComponent implements OnInit, OnDestroy {
    /* eslint-disable @typescript-eslint/naming-convention */
    static ngAcceptInputType_autoCollapse: BooleanInput;
    /* eslint-enable @typescript-eslint/naming-convention */

    @Input() autoCollapse: boolean;
    @Input() item: SmartrNavigationItem;
    @Input() name: string;

    isCollapsed: boolean = true;
    isExpanded: boolean = false;
    private _smartrVerticalNavigationComponent: SmartrVerticalNavigationComponent;
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _changeDetectorRef: ChangeDetectorRef,
        private _router: Router,
        private _smartrNavigationService: SmartrNavigationService
    ) {
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Accessors
    // -----------------------------------------------------------------------------------------------------

    /**
     * Host binding for component classes
     */
    @HostBinding('class') get classList(): any {
        return {
            'smartr-vertical-navigation-item-collapsed': this.isCollapsed,
            'smartr-vertical-navigation-item-expanded': this.isExpanded
        };
    }
    ngOnInit(): void {
        // Get the parent navigation component
        this._smartrVerticalNavigationComponent = this._smartrNavigationService.getComponent(this.name);

        // If the item has a children that has a matching url with the current url, expand...
        if (this._hasActiveChild(this.item, this._router.url)) {
            this.expand();
        }
        // Otherwise...
        else {
            // If the autoCollapse is on, collapse...
            if (this.autoCollapse) {
                this.collapse();
            }
        }

        // Listen for the onCollapsableItemCollapsed from the service
        this._smartrVerticalNavigationComponent.onCollapsableItemCollapsed
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((collapsedItem) => {

                // Check if the collapsed item is null
                if (collapsedItem === null) {
                    return;
                }

                // Collapse if this is a children of the collapsed item
                if (this._isChildrenOf(collapsedItem, this.item)) {
                    this.collapse();
                }
            });

        // Listen for the onCollapsableItemExpanded from the service if the autoCollapse is on
        if (this.autoCollapse) {
            this._smartrVerticalNavigationComponent.onCollapsableItemExpanded
                .pipe(takeUntil(this._unsubscribeAll))
                .subscribe((expandedItem) => {

                    // Check if the expanded item is null
                    if (expandedItem === null) {
                        return;
                    }

                    // Check if this is a parent of the expanded item
                    if (this._isChildrenOf(this.item, expandedItem)) {
                        return;
                    }

                    // Check if this has a children with a matching url with the current active url
                    if (this._hasActiveChild(this.item, this._router.url)) {
                        return;
                    }

                    // Check if this is the expanded item
                    if (this.item === expandedItem) {
                        return;
                    }

                    // If none of the above conditions are matched, collapse this item
                    this.collapse();
                });
        }

        // Attach a listener to the NavigationEnd event
        this._router.events
            .pipe(
                filter((event): event is NavigationEnd => event instanceof NavigationEnd),
                takeUntil(this._unsubscribeAll)
            )
            .subscribe((event: NavigationEnd) => {

                // If the item has a children that has a matching url with the current url, expand...
                if (this._hasActiveChild(this.item, event.urlAfterRedirects)) {
                    this.expand();
                }
                // Otherwise...
                else {
                    // If the autoCollapse is on, collapse...
                    if (this.autoCollapse) {
                        this.collapse();
                    }
                }
            });

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

    /**
     * Collapse
     */
    collapse(): void {
        // Return if the item is disabled
        if (this.item.disabled) {
            return;
        }

        // Return if the item is already collapsed
        if (this.isCollapsed) {
            return;
        }

        // Collapse it
        this.isCollapsed = true;
        this.isExpanded = !this.isCollapsed;

        // Mark for check
        this._changeDetectorRef.markForCheck();

        // Execute the observable
        this._smartrVerticalNavigationComponent.onCollapsableItemCollapsed.next(this.item);
    }

    /**
     * Expand
     */
    expand(): void {
        // Return if the item is disabled
        if (this.item.disabled) {
            return;
        }

        // Return if the item is already expanded
        if (!this.isCollapsed) {
            return;
        }

        // Expand it
        this.isCollapsed = false;
        this.isExpanded = !this.isCollapsed;

        // Mark for check
        this._changeDetectorRef.markForCheck();

        // Execute the observable
        this._smartrVerticalNavigationComponent.onCollapsableItemExpanded.next(this.item);
    }

    /**
     * Toggle collapsable
     */
    toggleCollapsable(): void {
        // Toggle collapse/expand
        if (this.isCollapsed) {
            this.expand();
        }
        else {
            this.collapse();
        }
    }

    /**
     * Track by function for ngFor loops
     *
     * @param index
     * @param item
     */
    trackByFn(index: number, item: any): any {
        return item.id || index;
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Private methods
    // -----------------------------------------------------------------------------------------------------

    /**
     * Check if the given item has the given url
     * in one of its children
     *
     * @param item
     * @param currentUrl
     * @private
     */
    private _hasActiveChild(item: SmartrNavigationItem, currentUrl: string): boolean {
        const children = item.children;

        if (!children) {
            return false;
        }

        for (const child of children) {
            if (child.children) {
                if (this._hasActiveChild(child, currentUrl)) {
                    return true;
                }
            }

            // Check if the child has a link and is active
            if (child.link && this._router.isActive(child.link, child.exactMatch || false)) {
                return true;
            }
        }

        return false;
    }

    /**
     * Check if this is a children
     * of the given item
     *
     * @param parent
     * @param item
     * @private
     */
    private _isChildrenOf(parent: SmartrNavigationItem, item: SmartrNavigationItem): boolean {
        const children = parent.children;

        if (!children) {
            return false;
        }

        if (children.indexOf(item) > -1) {
            return true;
        }

        for (const child of children) {
            if (child.children) {
                if (this._isChildrenOf(child, item)) {
                    return true;
                }
            }
        }

        return false;
    }
}
