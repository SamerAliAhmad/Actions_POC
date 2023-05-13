import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnDestroy, OnInit } from '@angular/core';
import { BooleanInput } from '@angular/cdk/coercion';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { SmartrNavigationItem } from 'app/shared/navigation/navigation.types';

@Component({
    selector: 'smartr-vertical-navigation-group-item',
    templateUrl: './group.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class SmartrVerticalNavigationGroupItemComponent implements OnInit, OnDestroy {
    /* eslint-disable @typescript-eslint/naming-convention */
    static ngAcceptInputType_autoCollapse: BooleanInput;
    /* eslint-enable @typescript-eslint/naming-convention */

    @Input() autoCollapse: boolean;
    @Input() item: SmartrNavigationItem;
    @Input() name: string;
    @Input() thin: boolean;
    private _smartrVerticalNavigationComponent: SmartrVerticalNavigationComponent;
    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _changeDetectorRef: ChangeDetectorRef,
        private _smartrNavigationService: SmartrNavigationService
    ) {
    }
    ngOnInit(): void {
        // Get the parent navigation component
        this._smartrVerticalNavigationComponent = this._smartrNavigationService.getComponent(this.name);

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
     * Track by function for ngFor loops
     *
     * @param index
     * @param item
     */
    trackByFn(index: number, item: any): any {
        return item.id || index;
    }
}
