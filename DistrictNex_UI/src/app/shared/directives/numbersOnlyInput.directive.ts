import { Directive, ElementRef, HostListener } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';

@Directive({
    selector: 'input[numbersOnly]'
})
export class NumbersOnlyInputDirective {

    constructor(
        private el: ElementRef,
        private CmSvc: CommonService
    ) { }

    @HostListener('keydown', ['$event']) onKeyDown(event: KeyboardEvent) {
        if (['Delete', 'Backspace'].indexOf(event.key) !== -1 ||
            // Allow: Ctrl+A
            (event.key == 'a' && event.ctrlKey === true) ||
            // Allow: Ctrl+C
            (event.key == 'c' && event.ctrlKey === true) ||
            // Allow: Ctrl+V
            (event.key == 'v' && event.ctrlKey === true) ||
            // Allow: Ctrl+X
            (event.key == 'x' && event.ctrlKey === true) ||
            // Allow: Ctrl+Z
            (event.key == 'z' && event.ctrlKey === true) ||
            // Allow: home, end, left, right
            (event.key == 'ArrowLeft' || event.key == 'ArrowUp' || event.key == 'ArrowRight' || event.key == 'ArrowDown')) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if (event.shiftKey || !(/^[0-9]$/i.test(event.key))) {
            event.preventDefault();
        }
    }

    @HostListener('paste', ['$event']) onPaste(event) {
        // Don't allow pasted text that contains non-numerics
        var pastedText = (event.originalEvent || event).clipboardData.getData('text/plain');

        if (pastedText) {
            var regEx = new RegExp('^[0-9]*$');
            if (!regEx.test(pastedText)) {
                this.CmSvc.ShowMessage("The pasted text contains characters different than numbers, it has not been pasted");
                event.preventDefault();
            }
        }
    }
}
