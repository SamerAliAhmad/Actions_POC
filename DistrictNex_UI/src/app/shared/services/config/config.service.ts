import { Inject, Injectable } from '@angular/core';
import { merge } from 'lodash-es';
import { BehaviorSubject, Observable } from 'rxjs';
import { SMARTR_APP_CONFIG } from './config.constants';

@Injectable({
    providedIn: 'root'
})
export class SmartrConfigService {
    private _config: BehaviorSubject<any>;

    constructor(@Inject(SMARTR_APP_CONFIG) config: any) {
        // Private
        this._config = new BehaviorSubject(config);
    }
    /**
     * Setter & getter for config
     */
    set config(value: any) {
        // Merge the new config over to the current config
        const config = merge({}, this._config.getValue(), value);

        // Execute the observable
        this._config.next(config);
    }

    get config$(): Observable<any> {
        return this._config.asObservable();
    }
    /**
     * Resets the config to the default
     */
    reset(): void {
        // Set the config
        this._config.next(this.config);
    }
}