import { AbstractControl, ValidatorFn } from '@angular/forms';

export const requireMatch = (stringList: string[]): ValidatorFn => (control: AbstractControl): { incorrect: boolean } | null => {
    const selection: any = control.value;
    if (!stringList.includes(selection)) {
        return { incorrect: true };
    }
    return null;
};
