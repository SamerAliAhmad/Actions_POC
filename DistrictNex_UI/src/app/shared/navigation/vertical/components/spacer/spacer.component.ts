import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnDestroy, OnInit } from '@angular/core';
import { SmartrNavigationService } from 'app/shared/navigation/navigation.service';
import { SmartrNavigationItem } from 'app/shared/navigation/navigation.types';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'smartr-vertical-navigation-spacer-item',
    templateUrl: './spacer.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class SmartrVerticalNavigationSpacerItemComponent implements OnInit, OnDestroy {
    @Input() item: SmartrNavigationItem;
    @Input() name: string;

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
}
