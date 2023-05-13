import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AuthUtils } from 'app/core/auth/auth.utils';
import { BdcWalkService } from 'bdc-walkthrough';
import { HmacSHA256 } from 'crypto-js';
import Base64 from 'crypto-js/enc-base64';
import Utf8 from 'crypto-js/enc-utf8';
import { Observable, of, Subject, takeUntil } from 'rxjs';
import { CommonService } from '../Services/common.service';
import { LogsService } from '../Services/logs.service';
import { Primary_Authentication_Response, Proxy, Send_Otp_Response } from '../Services/proxy.service';

@Injectable()
export class AuthService {
    private _secret;
    private tempUserId: number;
    private tempUsername: string;
    private _authenticated: boolean = false;
    private _unsubscribeAll = new Subject<void>();
    constructor(
        private proxy: Proxy,
        private router: Router,
        private CmSvc: CommonService,
        private _httpClient: HttpClient,
        private LogsService: LogsService,
        private BdcWalkService: BdcWalkService,

    ) {
        this._secret = 'YOUR_VERY_CONFIDENTIAL_SECRET_FOR_SIGNING_JWT_TOKENS!!!';
        this.CmSvc.oSignOutSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.router.navigate(['/sign-out']);
        });
    }
    set accessToken(token: string) {
        localStorage.setItem('accessToken', token);
    }

    get accessToken(): string {
        return localStorage.getItem('accessToken') ?? '';
    }
    Send_Otp(EMAIL: string, IS_FORGOT_PASSWORD = false): Promise<Send_Otp_Response> {
        return new Promise((resolve, reject) => {
            this.proxy.Send_Otp({
                USERNAME: EMAIL,
                USER: null,
                IS_FORGOT_PASSWORD: IS_FORGOT_PASSWORD,
            }).subscribe(result => {
                if (result) {
                    this.tempUserId = result.USER_ID;
                    this.tempUsername = EMAIL;
                    resolve(result);
                } else {
                    reject();
                }
            })
        });
    }
    Primary_Authentication(email: string, password: string, is_unlock = false): Promise<Primary_Authentication_Response> {
        return new Promise((resolve, reject) => {
            if (this._authenticated && !is_unlock) {
                resolve(undefined);
            }
            this.proxy.Primary_Authentication({
                USERNAME: email,
                PASSWORD: password,
                IS_ADMIN: false,
            }).subscribe(result => {
                if (result) {
                    this.tempUserId = result.USER_ID;
                    this.tempUsername = email;
                    resolve(result);
                } else {
                    reject();
                }
            })
        })
    }
    Verify_Otp(OTP: string) {
        return new Promise(resolve => {
            this.proxy.Verify_Otp({
                OTP: OTP,
                USER_ID: this.tempUserId,
            }).subscribe(result => {
                resolve(result);
            })
        })
    }
    Login_OTP_Verification(OTP: string) {
        return new Promise(resolve => {
            this.proxy.OTP_Verification({
                OTP: OTP,
                USER_ID: this.tempUserId,
                USERNAME: this.tempUsername,
            }).subscribe(result => {
                if (result) {
                    // Set the authenticated flag to true
                    this._authenticated = true;
                    this.accessToken = this._generateJWTToken();
                    // Store the user on the user service
                    this.BdcWalkService.reset();
                    if (this.CmSvc.oUser_Details?.USER_DISTRICTNEX_WALKTHROUGH) {
                        const oListKeyValue = this.CmSvc.oUser_Details?.USER_DISTRICTNEX_WALKTHROUGH?.split(',').filter(keyValue => !keyValue.includes("\"version\""));
                        oListKeyValue.forEach(keyValue => {
                            const taskName = keyValue.slice(
                                keyValue.indexOf('\"') + 1,
                                keyValue.lastIndexOf('\"'),
                            );
                            this.BdcWalkService.setTaskCompleted(taskName, true);
                        });
                    }
                    this.CmSvc.oUser_Details = result;
                    this.CmSvc.Ticket = result.TICKET;
                    localStorage.setItem("userDetails", JSON.stringify(result));
                    resolve(true);
                    // Return a new observable with the response
                } else {
                    resolve(false);
                }
            }, () => resolve(false))
        })
    }
    changeForgottenPassword(username: string, OTP: string, newPassword: string): Promise<boolean> {
        return new Promise(resolve => {
            this.proxy.Change_User_Forgotten_Password({
                USERNAME: username,
                NEW_PASSWORD: newPassword,
                OTP: OTP,
            }).subscribe(result => {
                resolve(result);
            });
        });
    }
    signInUsingToken(): Promise<boolean> {
        return new Promise(resolve => {
            if (this._verifyJWTToken(this.accessToken)) {
                try {
                    this.CmSvc.oUser_Details = JSON.parse(localStorage.getItem("userDetails"));
                    if (this.CmSvc.oUser_Details?.USER_DISTRICTNEX_WALKTHROUGH) {
                        const oListKeyValue = this.CmSvc.oUser_Details?.USER_DISTRICTNEX_WALKTHROUGH.split(',').filter(keyValue => !keyValue.includes("\"version\""));
                        oListKeyValue.forEach(keyValue => {
                            const taskName = keyValue.slice(
                                keyValue.indexOf('\"') + 1,
                                keyValue.lastIndexOf('\"'),
                            );
                            this.BdcWalkService.setTaskCompleted(taskName, true);
                        });
                    }
                    if (this.CmSvc.oUser_Details && this.CmSvc.oUser_Details.TICKET) {
                        this.CmSvc.Ticket = this.CmSvc.oUser_Details.TICKET;
                        // Store the access token in the local storage
                        this.accessToken = this._generateJWTToken();
                        // Set the authenticated flag to true
                        this._authenticated = true;
                        resolve(true);
                    }
                    else {
                        this.signOut();
                        resolve(false);
                    }
                } catch {
                    this.signOut();
                    resolve(false);
                }
            } else {
                resolve(false);
            }
        });
    }
    signOut(): Observable<any> {
        // Remove the access token from the local storage
        const data = [];
        data.push({ name: 'dnexPrimaryColor', value: localStorage.getItem('dnexPrimaryColor') });
        data.push({ name: 'dnex_favi_ico_url', value: localStorage.getItem('dnex_favi_ico_url') });
        data.push({ name: 'dnexSecondaryColor', value: localStorage.getItem('dnexSecondaryColor') });
        data.push({ name: 'dnex_light_logo_url', value: localStorage.getItem('dnex_light_logo_url') });
        data.push({ name: 'dnex_light_logo_square_url', value: localStorage.getItem('dnex_light_logo_square_url') });
        data.push({ name: 'dnex_dark_logo_square_url', value: localStorage.getItem('dnex_dark_logo_square_url') });
        data.push({ name: 'dnex_dark_logo_url', value: localStorage.getItem('dnex_dark_logo_url') });
        data.push({ name: 'entityId', value: localStorage.getItem('entityId') });
        data.push({ name: 'siteId', value: localStorage.getItem('siteId') });
        data.push({ name: 'areaId', value: localStorage.getItem('areaId') });
        data.push({ name: 'districtId', value: localStorage.getItem('districtId') });
        data.push({ name: 'selected timezone', value: localStorage.getItem('selected timezone') });
        localStorage.clear();
        data.forEach(datum => {
            if (datum.value != null) {
                localStorage.setItem(datum.name, datum.value);
            }
        });
        this.CmSvc.oUser_Accessible_Data = null;
        this.CmSvc.oUser_Accessible_Level_List = null;
        this.CmSvc.oList_Accessible_districtnex_module = [];
        this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data = [];
        this.CmSvc.oSignedOutSubject.next();
        this.CmSvc.oToggle_Module_Subject.next(false);
        if (this.LogsService.oList_Log_Type_Setup && this.LogsService.oList_Access_Type_Setup) {
            this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Signed Out",
                this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Sign In-Out").SETUP_ID,
                this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID);
        }
        this._authenticated = false;

        // Return the observable
        return of(true);
    }
    unlockSession(credentials: { email: string; password: string }): Observable<any> {
        return this._httpClient.post('api/auth/unlock-session', credentials);
    }
    check(): Promise<boolean> {
        return new Promise(resolve => {
            // Check if the user is logged in
            if (this._authenticated) {
                resolve(true);
            }

            // Check the access token availability
            if (!this.accessToken) {
                resolve(false);
            }

            // Check the access token expire date
            if (AuthUtils.isTokenExpired(this.accessToken)) {
                resolve(false);
            }

            // If the access token exists and it didn't expire, sign in using it
            this.signInUsingToken().then(authenticated => {
                resolve(authenticated);
            });
        });
    }
    private _generateJWTToken(): string {
        // Define token header
        const header = {
            alg: 'HS256',
            typ: 'JWT'
        };

        // Calculate the issued at and expiration dates
        const date = new Date();
        const iat = Math.floor(date.getTime() / 1000);
        const exp = Math.floor((date.setDate(date.getDate() + 7)) / 1000);

        // Define token payload
        const payload = {
            iat: iat,
            iss: 'Smartr',
            exp: exp
        };

        // Stringify and encode the header
        const stringifiedHeader = Utf8.parse(JSON.stringify(header));
        const encodedHeader = this._base64url(stringifiedHeader);

        // Stringify and encode the payload
        const stringifiedPayload = Utf8.parse(JSON.stringify(payload));
        const encodedPayload = this._base64url(stringifiedPayload);

        // Sign the encoded header
        let signature: any = encodedHeader + '.' + encodedPayload;
        signature = HmacSHA256(signature, this._secret);
        signature = this._base64url(signature);

        // Build and return the token
        return encodedHeader + '.' + encodedPayload + '.' + signature;
    }
    private _base64url(source: any): string {
        // Encode in classical base64
        let encodedSource = Base64.stringify(source);

        // Remove padding equal characters
        encodedSource = encodedSource.replace(/=+$/, '');

        // Replace characters according to base64url specifications
        encodedSource = encodedSource.replace(/\+/g, '-');
        encodedSource = encodedSource.replace(/\//g, '_');

        // Return the base64 encoded string
        return encodedSource;
    }
    private _verifyJWTToken(token: string): boolean {
        // Split the token into parts
        const parts = token.split('.');
        const header = parts[0];
        const payload = parts[1];
        const signature = parts[2];

        // Re-sign and encode the header and payload using the secret
        const signatureCheck = this._base64url(HmacSHA256(header + '.' + payload, this._secret));

        // Verify that the resulting signature is valid
        return (signature === signatureCheck);
    }
}
