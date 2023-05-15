import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { finalize } from 'rxjs/operators';
import { SmartrLoadingService } from './loading.service';

@Injectable()
export class SmartrLoadingInterceptor implements HttpInterceptor {
    handleRequestsAutomatically: boolean;

    constructor(
        private _smartrLoadingService: SmartrLoadingService
    ) {
        // Subscribe to the auto
        this._smartrLoadingService.auto$
            .subscribe((value) => {
                this.handleRequestsAutomatically = value;
            });
    }

    /**
     * Intercept
     *
     * @param req
     * @param next
     */
    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // If the Auto mode is turned off, do nothing
        if (!this.handleRequestsAutomatically) {
            return next.handle(req);
        }

        // Set the loading status to true
        this._smartrLoadingService._setLoadingStatus(true, req.url);

        return next.handle(req).pipe(
            finalize(() => {
                // Set the status to false if there are any errors or the request is completed
                this._smartrLoadingService._setLoadingStatus(false, req.url);
            }));
    }
}
