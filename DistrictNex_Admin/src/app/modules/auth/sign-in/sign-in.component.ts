import { Clipboard } from '@angular/cdk/clipboard';
import { Component, OnDestroy, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'app/core/auth/auth.service';
import { CommonService } from 'app/core/Services/common.service';
import { environment } from 'environments/environment';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'auth-sign-in',
    templateUrl: './sign-in.component.html',
    encapsulation: ViewEncapsulation.None,
})
export class AuthSignInComponent implements OnInit, OnDestroy {
    @ViewChild('signInForm') signInForm: NgForm;

    AuthenticateRequest: {
        Email: '',
        idToken: ''
    };

    otpInterval;
    dark_logo = '';
    light_logo = '';
    Build_Number = '';

    loading = false;
    otpLoading = false;
    rememberMe = false;
    isOtpVerified = false;
    isPrimaryAuthDone = false;
    isForgottenPassword = false;

    waitForCache = 0;
    remainingOtpTime = 0;
    passwordStrength = 0;
    remainingOtpTimeMinutes = 0;
    remainingOtpTimeSeconds = 0;

    otp: string;
    username: string;
    password: string;
    otpEmail: string = '';
    newPassword: string = '';
    confirmPassword: string = '';

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _router: Router,
        private CmSvc: CommonService,
        private Clipboard: Clipboard,
        private _authService: AuthService,
        private _activatedRoute: ActivatedRoute,
    ) {
        this.Build_Number = environment.Build_Number;
        this.dark_logo = this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL;
        this.light_logo = this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL;
    }

    ngOnInit(): void {
        this.otpInterval = setInterval(() => {
            if (this.remainingOtpTime > 0) {
                this.remainingOtpTime--;
                this.remainingOtpTimeMinutes = Math.floor(this.remainingOtpTime / 60);
                this.remainingOtpTimeSeconds = this.remainingOtpTime % 60;
                if (this.waitForCache > 0) {
                    this.waitForCache--;
                }
            }
        }, 1000);
        // Create the form
        try {
            var userName: string = localStorage.getItem('username');
            if (this.CmSvc.CheckString(userName)) {
                this.username = userName;
                this.rememberMe = true;
            }
        } catch (error) {
            this.username = "";
            this.rememberMe = false;
        }
        this.CmSvc.signOutSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.loading = false;
            this.otpLoading = false;
            this.signInForm.form.enable();
        })
    }

    Primary_Authentication(): void {
        if (this.signInForm.invalid) {
            return;
        }
        this.signInForm.form.disable();
        this.otpLoading = true;
        if (this.isForgottenPassword) {
            this._authService.Send_Otp(this.username, true).then(result => {
                this.Setup_Data(result);
            })
        } else {
            this._authService.Primary_Authentication(this.username, this.password).then(result => {
                this.Setup_Data(result);
            }).catch(_ => {
                this.otpLoading = false;
                this.signInForm.form.enable();
            });
        }
    }

    Setup_Data(result) {
        if (result) {
            this.isPrimaryAuthDone = true;
            this.waitForCache = 5;
            this.otpEmail = result.EMAIL;
            this.remainingOtpTime = result.TTL_IN_SECONDS;
            this.remainingOtpTimeMinutes = Math.floor(this.remainingOtpTime / 60);
            this.remainingOtpTimeSeconds = this.remainingOtpTime % 60;
        }
        this.otpLoading = false;
        this.signInForm.form.enable();
    }

    Verify_Otp() {
        if (!this.otp) {
            this.CmSvc.ShowMessage("Please enter an OTP");
            return;
        }
        this.loading = true;
        this._authService.Verify_Otp(this.otp).then(result => {
            if (result) {
                this.isOtpVerified = true;
            }
            this.loading = false;
        })
    }

    Login_OTP_Verification() {
        if (!this.otp) {
            this.CmSvc.ShowMessage("Please enter an OTP");
            return;
        }
        this.loading = true;
        this.signInForm.form.disable();
        this._authService.Login_OTP_Verification(this.otp).then(result => {
            if (result) {
                if (this.rememberMe == true) {
                    localStorage.setItem('username', this.username);
                }
                else {
                    localStorage.removeItem('username');
                }
                const redirectURL = this._activatedRoute.snapshot.queryParamMap.get('redirectURL') || '/signed-in-redirect';
                this._router.navigateByUrl(redirectURL);
            } else {
                this.loading = false;
                this.signInForm.form.enable();
            }
        })
    }

    Change_Password() {
        if (this.newPassword != this.confirmPassword) {
            this.CmSvc.ShowMessage("Passwords do not match");
            return;
        }
        if (this.passwordStrength <= 2) {
            this.CmSvc.ShowMessage("Password is not strong enough");
            return;
        }
        this.loading = true;
        this.signInForm.form.disable();
        this._authService.changeForgottenPassword(this.username, this.otp, this.newPassword).then(result => {
            if (result) {
                this.CmSvc.ShowMessage("Password changed, signing you in...");
                this.password = this.newPassword;
                this.Login_OTP_Verification();
            } else {
                this.signInForm.form.enable();
                this.loading = false;
            }
        })
    }

    autoGeneratePassword() {
        let generatedPassword = this.CmSvc.Generate_Random_String(12);
        this.newPassword = generatedPassword;
        this.confirmPassword = generatedPassword;
        this.Clipboard.copy(generatedPassword);
        this.CmSvc.ShowMessage("Password copied to clipboard");
    }

    Go_To_Build_History() {
        this._router.navigateByUrl('/build-history')
    }

    ngOnDestroy() {
        clearInterval(this.otpInterval);
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
