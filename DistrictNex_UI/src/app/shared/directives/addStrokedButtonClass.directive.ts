import { AfterViewInit, Directive, ElementRef } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';

@Directive({
    selector: '[mat-stroked-button]'
})
export class AddStrokedButtonClassDirective implements AfterViewInit {

    constructor(
        private el: ElementRef,
        private CmSvc: CommonService,
    ) { }

    ngAfterViewInit() {
        this.el.nativeElement.classList.add("smartr-button");
        if (this.CmSvc.oUser_theme) {
            let THEME_CLASS = this.CmSvc.oList_Organization_theme.find(oOrganization_theme => oOrganization_theme.ORGANIZATION_THEME_ID == this.CmSvc.oUser_theme.ORGANIZATION_THEME_ID).THEME_CLASS;
            this.el.nativeElement.classList.add(THEME_CLASS);
        }
    }
}