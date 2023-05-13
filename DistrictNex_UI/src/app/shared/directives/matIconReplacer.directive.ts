import { AfterViewInit, Directive, Input, OnChanges, OnDestroy, SimpleChanges } from '@angular/core';
import { MatIcon } from '@angular/material/icon';
import { CommonService } from 'app/core/Services/common.service';
import { Subject, takeUntil } from 'rxjs';

@Directive({
    selector: 'mat-icon'
})
export class MatIconReplacerDirective implements AfterViewInit, OnChanges, OnDestroy {

    @Input() svgIcon: string;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private el: MatIcon,
        private CmSvc: CommonService,
    ) { }

    ngAfterViewInit(): void {
        this.CmSvc.oUpdateApplicationImagesSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.ngOnChanges({});
        });
    }

    ngOnChanges(changes: SimpleChanges) {
        /***** THIS CODE WILL BE APPLIED FOR LATER ICONS ~ WITH SOME CHANGE *****/
        // *** We need to split the icon at the : first
        // this._matIconRegistry.getNamedSvgIcon(this.el.svgIcon, organization.ICON_NAMESPACE).subscribe({
        //     next: result => {
        //         this.el.svgIcon = $`{organization.ICON_NAMESPACE}:{this.el.svgIcon}`
        //     },
        //     error: er => {
        //         this.el.svgIcon = this.el.svgIcon (part after the :)
        //     }
        // });
        if (this.CmSvc.oUser_theme) {
            let THEME_NAME = this.CmSvc.oList_Organization_theme.find(oOrganization_theme => oOrganization_theme.ORGANIZATION_THEME_ID == this.CmSvc.oUser_theme.ORGANIZATION_THEME_ID).THEME_NAME;
            if (THEME_NAME == "Telus") {
                switch (this.el.svgIcon) {
                    case "mat_outline:maps_home_work":
                        this.el.svgIcon = "telus:map";
                        break;
                    case "heroicons_outline:document-report":
                        this.el.svgIcon = "telus:document";
                        break;
                    case "heroicons_outline:video-camera":
                        this.el.svgIcon = "telus:security-camera";
                        break;
                    case "mat_outline:insights":
                        this.el.svgIcon = "telus:charts-bar-2";
                        break;
                    case "fullscreen":
                        this.el.svgIcon = "telus:fullscreen-expand";
                        break;
                    case "fullscreen_exit":
                        this.el.svgIcon = "telus:fullscreen-minimize";
                        break;
                    case "heroicons_outline:filter":
                        this.el.svgIcon = "telus:clipboard";
                        break;
                    case "mat_outline:pin_invoke":
                        this.el.svgIcon = "telus:link-external";
                        break;
                    case "mat_outline:pin_end":
                        this.el.svgIcon = "telus:modal";
                        break;
                    case "heroicons_outline:x":
                        this.el.svgIcon = "telus:close";
                        break;
                    case "mat_solid:build":
                        this.el.svgIcon = "telus:warranty";
                        break;
                    case "mat_outline:arrow_downward":
                        this.el.svgIcon = "telus:arrow-down";
                        break;
                    case "mat_outline:arrow_upward":
                        this.el.svgIcon = "telus:arrow-up";
                        break;
                    case "mat_outline:directions_car":
                        this.el.svgIcon = "telus:car";
                        break;
                    case "mat_outline:sync":
                        this.el.svgIcon = "telus:refresh";
                        break;
                    case "mat_outline:shield":
                        this.el.svgIcon = "telus:firewall";
                        break;
                    case "mat_outline:emoji_transportation":
                        this.el.svgIcon = "telus:car";
                        break;
                    case "mat_outline:monetization_on":
                        this.el.svgIcon = "telus:money";
                        break;
                    case "mat_outline:browser_not_supported":
                        this.el.svgIcon = "telus:replay";
                        break;
                    case "mat_outline:corporate_fare":
                        this.el.svgIcon = "telus:offices";
                        break;
                    case "heroicons_outline:globe":
                        this.el.svgIcon = "telus:globe-1";
                        break;
                    case "heroicons_outline:bell":
                        this.el.svgIcon = "telus:bell";
                        break;
                    case "heroicons_outline:trash":
                        this.el.svgIcon = "telus:delete";
                        break;
                    case "heroicons_outline:printer":
                        this.el.svgIcon = "telus:print";
                        break;
                    case "mat_outline:location_on":
                        this.el.svgIcon = "telus:location-regular";
                        break;
                    case "mat_outline:category":
                        this.el.svgIcon = "telus:grid";
                        break;
                    case "heroicons_solid:information-circle":
                        this.el.svgIcon = "telus:information";
                        break;
                    case "mat_outline:edit_note":
                        this.el.svgIcon = "telus:clipboard";
                        break;
                    case "mat_outline:border_outer":
                        this.el.svgIcon = "telus:grid";
                        break;
                    case "heroicons_outline:library":
                        this.el.svgIcon = "telus:bank";
                        break;
                    case "mat_outline:settings":
                        this.el.svgIcon = "telus:settings";
                        break;
                    case "mat_outline:picture_as_pdf":
                        this.el.svgIcon = "telus:download-pdf";
                        break;
                    case "heroicons_outline:mail":
                        this.el.svgIcon = "telus:email";
                        break;
                    case "heroicons_outline:phone":
                        this.el.svgIcon = "telus:call";
                        break;
                    case "heroicons_outline:briefcase":
                        this.el.svgIcon = "telus:briefcase";
                        break;
                    case "mat_outline:lock":
                        this.el.svgIcon = "telus:lock-closed";
                        break;
                    case "heroicons_solid:pencil-alt":
                        this.el.svgIcon = "telus:edit";
                        break;
                    case "heroicons_outline:user-circle":
                        this.el.svgIcon = "telus:user";
                        break;
                }
            }
        }
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}