import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
    selector: '[decimalsOnly]'
})
export class DecimalsOnlyDirective {

    private regex: RegExp = new RegExp(/^[0-9]*\.?[0-9]*$/g);
    private specialKeys: Array<string> = ['Backspace', 'Tab', '.'];

    constructor(private el: ElementRef) { }

    @HostListener('keypress', ['$event'])
    onKeyDown(event: KeyboardEvent): void {
        const current: string = this.el.nativeElement.value;
        const next: string = current.concat(event.key);
        if (event.key == '.' && current.includes('.')) {
            event.preventDefault();
        }

        if (this.specialKeys.indexOf(event.key) !== -1) {
            return;
        }

        if ((next && !String(next).match(this.regex))) {
            event.preventDefault();
        }
    }
}
