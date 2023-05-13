import { AbstractControl, ValidatorFn } from '@angular/forms';

export const duplicates = (stringList: string[]): ValidatorFn => (control: AbstractControl): { duplicates: boolean } | null => {
    const selection: any = control.value;
    if (stringList.includes(selection)) {
        return { duplicates: true };
    }
    return null;
};
