import { APP_INITIALIZER, Injector, NgModule } from '@angular/core';
import { MATERIAL_SANITY_CHECKS } from '@angular/material/core';
import { MAT_FORM_FIELD_DEFAULT_OPTIONS } from '@angular/material/form-field';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ExtraOptions, RouterModule } from '@angular/router';
import { AppComponent } from 'app/app.component';
import { appRoutes } from 'app/app.routing';
import { CoreModule } from 'app/core/core.module';
import { LayoutModule } from 'app/layout/layout.module';
import { InitialDataInitializer } from './app.initializer';
import { CommonService } from './core/Services/common.service';
import { LogsService } from './core/Services/logs.service';
import { Proxy } from './core/Services/proxy.service';
import { ProxyExt } from './core/Services/proxyExt.service';
import { MapService } from './modules/map/map.service';
import { SmartrSplashScreenModule } from './shared/components/splash-screen/splash-screen.module';
import { appConfig } from './shared/services/config/config.constants';
import { SmartrConfigModule } from './shared/services/config/config.module';
import { SharedModule } from './shared/shared.module';

export let AppInjector: Injector;

const routerConfig: ExtraOptions = {
    scrollPositionRestoration: 'enabled'
};

@NgModule({
    declarations: [
        AppComponent,
    ],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        SmartrSplashScreenModule,
        SmartrConfigModule.forRoot(appConfig),
        RouterModule.forRoot(appRoutes, routerConfig),
        CoreModule,
        LayoutModule,
        SharedModule,
    ],
    providers: [
        Proxy,
        ProxyExt,
        MapService,
        LogsService,
        CommonService,
        {
            // Disable 'theme' sanity check
            provide: MATERIAL_SANITY_CHECKS,
            useValue: {
                doctype: true,
                theme: false,
                version: true
            }
        },
        {
            // Use the 'fill' appearance on Angular Material form fields by default
            provide: MAT_FORM_FIELD_DEFAULT_OPTIONS,
            useValue: {
                appearance: 'fill'
            }
        },
        {
            provide: APP_INITIALIZER,
            useFactory: (InitialDataInitializer: InitialDataInitializer) => () => InitialDataInitializer.Get_Initial_Districtnex_Settings(),
            deps: [InitialDataInitializer],
            multi: true
        }
    ],
    bootstrap: [
        AppComponent
    ]
})
export class AppModule {
    constructor(private injector: Injector) {
        AppInjector = this.injector;
    }
}
