import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Navigation, SmartrNavigationItem } from 'app/shared/navigation/navigation.types';
import { cloneDeep } from 'lodash';
import { BehaviorSubject, Subject, takeUntil } from 'rxjs';
import { defaultNavigation } from './navigation.entries';

@Injectable({
    providedIn: 'root'
})
export class SmartrNavigationService {
    _navigation: BehaviorSubject<Navigation> = new BehaviorSubject<Navigation>(null);
    private _componentRegistry: Map<string, any> = new Map<string, any>();
    private _navigationStore: Map<string, SmartrNavigationItem[]> = new Map<string, any>();
    private readonly _defaultNavigation: SmartrNavigationItem[] = defaultNavigation;
    isSelectionComplete = false;
    private _unsubscribeAll = new Subject<void>();
    constructor(
        private CmSvc: CommonService,
    ) {
        this.CmSvc.oToggle_Module_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(isSelectionComplete => {
            this.isSelectionComplete = isSelectionComplete;
            this.get();
        });
    }

    get(): Promise<any> {
        return new Promise(resolve => {
            const defaultNavigation = cloneDeep(this._defaultNavigation);
            if (this.CmSvc.oList_Accessible_districtnex_module && this.CmSvc.oList_Accessible_districtnex_module.length > 0) {
                if (!this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "map")) {
                    defaultNavigation.splice(defaultNavigation.findIndex(navItem => navItem.id == 'map'), 1);
                }
                if (!this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "reports")) {
                    defaultNavigation.splice(defaultNavigation.findIndex(navItem => navItem.id == 'reports'), 1);
                }
                if (!this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "video ai")) {
                    defaultNavigation.splice(defaultNavigation.findIndex(navItem => navItem.id == 'video-ai'), 1);
                }
                if (!this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "insights")) {
                    defaultNavigation.splice(defaultNavigation.findIndex(navItem => navItem.id == 'insights-panel'), 1);
                }
            }
            defaultNavigation.forEach(navItem => {
                navItem.disabled = !this.isSelectionComplete;
            })
            const nav = {
                default: cloneDeep(defaultNavigation),
            };
            this._navigation.next(nav);
            resolve(nav);
        });
    }
    registerComponent(name: string, component: any): void {
        this._componentRegistry.set(name, component);
    }
    deregisterComponent(name: string): void {
        this._componentRegistry.delete(name);
    }
    getComponent<T>(name: string): T {
        return this._componentRegistry.get(name);
    }
    storeNavigation(key: string, navigation: SmartrNavigationItem[]): void {
        // Add to the store
        this._navigationStore.set(key, navigation);
    }
    getNavigation(key: string): SmartrNavigationItem[] {
        return this._navigationStore.get(key) ?? [];
    }
    deleteNavigation(key: string): void {
        // Check if the navigation exists
        if (!this._navigationStore.has(key)) {
            // console.warn(`Navigation with the key '${key}' does not exist in the store.`);
        }

        // Delete from the storage
        this._navigationStore.delete(key);
    }
    getFlatNavigation(navigation: SmartrNavigationItem[], flatNavigation: SmartrNavigationItem[] = []): SmartrNavigationItem[] {
        for (const item of navigation) {
            if (item.type === 'basic') {
                flatNavigation.push(item);
                continue;
            }

            if (item.type === 'aside' || item.type === 'collapsable' || item.type === 'group') {
                if (item.children) {
                    this.getFlatNavigation(item.children, flatNavigation);
                }
            }
        }

        return flatNavigation;
    }
    getItem(id: string, navigation: SmartrNavigationItem[]): SmartrNavigationItem | null {
        for (const item of navigation) {
            if (item.id === id) {
                return item;
            }

            if (item.children) {
                const childItem = this.getItem(id, item.children);

                if (childItem) {
                    return childItem;
                }
            }
        }

        return null;
    }
    getItemParent(
        id: string,
        navigation: SmartrNavigationItem[],
        parent: SmartrNavigationItem[] | SmartrNavigationItem
    ): SmartrNavigationItem[] | SmartrNavigationItem | null {
        for (const item of navigation) {
            if (item.id === id) {
                return parent;
            }

            if (item.children) {
                const childItem = this.getItemParent(id, item.children, item);

                if (childItem) {
                    return childItem;
                }
            }
        }

        return null;
    }

    ngOnDestroy() {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
