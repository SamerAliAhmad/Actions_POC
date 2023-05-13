import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, CanLoad, Router, UrlTree } from '@angular/router';
import { AuthService } from 'app/core/auth/auth.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class NoAuthGuard implements CanActivate, CanActivateChild, CanLoad {

    constructor(
        private _router: Router,
        private _authService: AuthService
    ) {
    }

    canActivate(): Observable<boolean> | Promise<boolean> | boolean {
        return this._check();
    }

    canActivateChild(): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        return this._check();
    }

    canLoad(): Observable<boolean> | Promise<boolean> | boolean {
        return this._check();
    }

    private _check(): Promise<boolean> {
        // Check the authentication status
        return this._authService.check().then(authenticated => {
            if (authenticated) {
                // Redirect to the root
                this._router.navigate(['']);
                // Prevent the access
                return false;
            }
            // Allow the access
            return true;
        });
    }
}
