import { Injectable } from '@angular/core';
import { SmartrDrawerComponent } from 'app/shared/navigation/vertical/components/drawer/drawer.component';

@Injectable({
    providedIn: 'root'
})
export class SmartrDrawerService {
    private _componentRegistry: Map<string, SmartrDrawerComponent> = new Map<string, SmartrDrawerComponent>();

    /**
     * Register drawer component
     *
     * @param name
     * @param component
     */
    registerComponent(name: string, component: SmartrDrawerComponent): void {
        this._componentRegistry.set(name, component);
    }

    /**
     * Deregister drawer component
     *
     * @param name
     */
    deregisterComponent(name: string): void {
        this._componentRegistry.delete(name);
    }

    /**
     * Get drawer component from the registry
     *
     * @param name
     */
    getComponent(name: string): SmartrDrawerComponent | undefined {
        return this._componentRegistry.get(name);
    }
}
