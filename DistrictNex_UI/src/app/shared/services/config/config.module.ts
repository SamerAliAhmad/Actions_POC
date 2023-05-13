import { ModuleWithProviders, NgModule } from '@angular/core';
import { SMARTR_APP_CONFIG } from './config.constants';

@NgModule()
export class SmartrConfigModule {
    static forRoot(config: any): ModuleWithProviders<SmartrConfigModule> {
        return {
            ngModule: SmartrConfigModule,
            providers: [
                {
                    provide: SMARTR_APP_CONFIG,
                    useValue: config
                }
            ]
        };
    }
}
