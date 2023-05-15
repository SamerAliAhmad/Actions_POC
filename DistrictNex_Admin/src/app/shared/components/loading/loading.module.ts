import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { SmartrLoadingInterceptor } from './loading.interceptor';

@NgModule({
    providers: [
        {
            provide : HTTP_INTERCEPTORS,
            useClass: SmartrLoadingInterceptor,
            multi   : true
        }
    ]
})
export class SmartrLoadingModule
{
}
