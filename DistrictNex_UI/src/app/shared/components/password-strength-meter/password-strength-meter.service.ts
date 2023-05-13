import { Injectable } from '@angular/core';
import { AbstractControl, ValidatorFn } from '@angular/forms';
import * as zxcvbn from 'zxcvbn';

@Injectable({
    providedIn: 'root'
})
export class PasswordStrengthMessages {
    hasNumber: string;
    hasSmallCase: string;
    hasCapitalCase: string;
    minLengthMatch: string;
    hasSpecialCharacters: string;
}
export class PasswordStrengthMeterService {
    hasNumberRegex: RegExp = /\d/;
    hasSmallCaseRegex: RegExp = /[a-z]/;
    hasCapitalCaseRegex: RegExp = /[A-Z]/;
    hasSpecialCharactersRegex: RegExp = /[ !@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]/;
    score(password: string): number {
        const result = zxcvbn(password);
        return result.score;
    }
    scoreWithFeedback(password: string): { score: number; feedback: { suggestions: string[]; warning: string } } {
        const result = zxcvbn(password);
        return {
            score: result.score,
            feedback: result.feedback
        };
    }
    patternValidator(text: string, regex: RegExp): boolean {
        return text == null ? true : regex.test(text);
    }
    strongPasswordValidator(password: string, minLength: number): PasswordStrengthMessages {
        return !password ? null : {
            minLengthMatch: password.length >= minLength ? '' : `Password Length Must be Greater or Equal to ${minLength}.`,
            hasNumber: this.patternValidator(password, this.hasNumberRegex) ? '' : 'Password Must Contain at Least One Number.',
            hasSmallCase: this.patternValidator(password, this.hasSmallCaseRegex) ? '' : 'Password Must Contain at Least One Small Case Letter',
            hasCapitalCase: this.patternValidator(password, this.hasCapitalCaseRegex) ? '' : 'Password Must Contain at Least One Capital Case Letter',
            hasSpecialCharacters: this.patternValidator(password, this.hasSpecialCharactersRegex) ? '' : 'Password Must Contain at Least One Special Character'
        };
    }
    strongPasswordFormControlValidator(minLength: number): ValidatorFn {
        return (control: AbstractControl): PasswordStrengthMessages => {
            if (!control.value) {
                // if control is empty return no error
                return null;
            }
            return this.strongPasswordValidator(control.value, minLength);
        };
    }
}
