import { Injectable } from '@angular/core';
import { SmartrDrawerComponent } from 'app/shared/navigation/vertical/components/drawer/drawer.component';

@Injectable({
    providedIn: 'root'
})
export class SmartrDrawerService {
    private _componentRegistry: Map<string, SmartrDrawerComponent> = new Map<string, SmartrDrawerComponent>();

    registerComponent(name: string, component: SmartrDrawerComponent): void {
        this._componentRegistry.set(name, component);
    }

    deregisterComponent(name: string): void {
        this._componentRegistry.delete(name);
    }

    getComponent(name: string): SmartrDrawerComponent | undefined {
        return this._componentRegistry.get(name);
    }
}
