import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Observable } from 'rxjs';
import { AuthService } from '../auth.service';

@Injectable({
  providedIn: 'root'
})
export class SuperAdminGuard implements CanActivate {

  constructor(
    private _router: Router,
    private Cmsvc: CommonService,
    private _authService: AuthService,
  ) {
  }

  /**
   * Can activate
   *
   * @param route
   * @param state
   */
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    if (this.Cmsvc?.oUser_Details?.User_type_setup?.VALUE.toLowerCase() != "super admin") {
      this._router.navigateByUrl('/map');
      return false;
    }
    else {
      return true;
    }

  }

}
