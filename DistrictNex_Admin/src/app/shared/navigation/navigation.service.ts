import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Navigation, SmartrNavigationItem } from 'app/shared/navigation/navigation.types';
import { cloneDeep } from 'lodash';
import { BehaviorSubject } from 'rxjs';
import { organizationAdminNavigation, superAdminNavigation } from './navigation.entries';

@Injectable({
    providedIn: 'root'
})
export class SmartrNavigationService {
    _navigation: BehaviorSubject<Navigation> = new BehaviorSubject<Navigation>(null);
    private _componentRegistry: Map<string, any> = new Map<string, any>();
    private _navigationStore: Map<string, SmartrNavigationItem[]> = new Map<string, any>();
    private readonly _superAdminNavigation: SmartrNavigationItem[] = superAdminNavigation;
    private readonly _organizationAdminNavigation: SmartrNavigationItem[] = organizationAdminNavigation;

    constructor(
        private CmSvc: CommonService,
    ) {
    }
    get(): Promise<any> {
        return new Promise((resolve, reject) => {
            if (this.CmSvc.oUser_Details && this.CmSvc.oUser_Details.User_type_setup && this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin") {
                // Fill compact navigation children using the default navigation
                const navItems = cloneDeep(this._superAdminNavigation);
                if (this.CmSvc.oUser_Details.Organization.Organization_type_setup.VALUE == "Super Organization") {
                    navItems[navItems.findIndex(item => item.id == 'my-organization')].children = navItems[navItems.findIndex(item => item.id == 'my-organization')].children.filter(child => child.id != 'access-control' && child.id != 'module-access');
                }
                else {
                    navItems.splice(navItems.findIndex(item => item.id == 'kpi-management'), 1);
                }
                const nav = {
                    default: navItems,
                };
                this._navigation.next(nav);
                resolve(nav);
            }
            if (this.CmSvc.oUser_Details.User_type_setup.VALUE == "Organization Admin") {

                const nav = {
                    default: cloneDeep(this._organizationAdminNavigation),
                };
                this._navigation.next(nav);
                resolve(nav);
            }
            reject();
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
}
