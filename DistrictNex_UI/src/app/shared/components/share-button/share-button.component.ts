import { Clipboard } from '@angular/cdk/clipboard';
import { Overlay, OverlayRef } from '@angular/cdk/overlay';
import { TemplatePortal } from '@angular/cdk/portal';
import { Component, Input, OnDestroy, TemplateRef, ViewChild, ViewContainerRef } from '@angular/core';
import { MatButton } from '@angular/material/button';
import { ThemePalette } from '@angular/material/core';
import { MatDialog } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { CommonService } from 'app/core/Services/common.service';
import { Params_Upload_Share_File } from 'app/core/Services/proxyExt.service';
import { MapService } from 'app/modules/map/map.service';
import { toPng } from 'html-to-image';
import jsPDF from 'jspdf';
import { QrCodeModalComponent } from '../qr-code-modal/qr-code-modal.component';
import { ShareEmailModalComponent } from '../share-email-modal/share-email-modal.component';

@Component({
    selector: 'share-button',
    templateUrl: './share-button.component.html',
    styleUrls: ['./share-button.component.scss']
})
export class ShareButtonComponent implements OnDestroy {

    @Input() isFab = false;
    @Input() oNgClass: string;
    @Input() oPdfName: string;
    @Input() orientation: 'p' | 'portrait' | 'l' | 'landscape';


    oLink: string;
    oList_Selected_email: string[] = [];

    value = 50;
    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';
    displayProgressSpinner = false;

    @ViewChild('shortcutsOrigin') private _shortcutsOrigin: MatButton;
    @ViewChild('shortcutsPanel') private _shortcutsPanel: TemplateRef<any>;

    private _overlayRef: OverlayRef;

    constructor(
        private dialog: MatDialog,
        private _overlay: Overlay,
        private CmSvc: CommonService,
        private Clipboard: Clipboard,
        private MapService: MapService,
        private _viewContainerRef: ViewContainerRef,
    ) { }

    uploadPdf(isDownload = false): Promise<boolean> {
        return new Promise(resolve => {
            const oList_Page_to_print = document.getElementsByClassName('page-to-print');
            const oList_Promise: Promise<string>[] = [];
            const filter = (node: HTMLElement) => {
                const exclusionClasses = ['remove-on-pdf'];
                return !exclusionClasses.some((classname) => node.classList?.contains(classname));
            }
            for (let i = 0; i < oList_Page_to_print.length; i++) {
                oList_Promise.push(new Promise<string>((resolve, reject) => {
                    toPng((oList_Page_to_print[i] as HTMLElement), {
                        width: oList_Page_to_print[i].scrollWidth,
                        height: oList_Page_to_print[i].scrollHeight,
                        filter: filter,
                    }).then(dataUrl => {
                        var img = new Image();
                        img.onload = () => {
                            var canvas = document.createElement('canvas');
                            canvas.width = img.width;
                            canvas.height = img.height;
                            canvas.getContext('2d').drawImage(img, 0, 0);
                            resolve(canvas.toDataURL());
                        };
                        img.onerror = reject;
                        img.src = dataUrl;
                    });
                }));
            }
            Promise.all(oList_Promise).then(oList_Data_url => {
                var doc = new jsPDF(this.orientation, 'pt', 'a4', true);
                oList_Data_url.forEach((data_url, i) => {
                    var imgProps = doc.getImageProperties(data_url);
                    var pdfWidth = doc.internal.pageSize.getWidth() - 20;
                    var pdfHeight = (imgProps.height * pdfWidth) / imgProps.width;
                    doc.addImage(data_url, 'PNG', 10, 10, pdfWidth, pdfHeight, undefined, 'FAST');
                    if ((oList_Data_url.length - 1) != i) {
                        doc.addPage();
                    }
                });
                if (!isDownload) {
                    const oParams_Upload_Share_File = new Params_Upload_Share_File();
                    oParams_Upload_Share_File.USER_ID = this.CmSvc.oUser_Details.USER_ID;
                    oParams_Upload_Share_File.FormData = new FormData();
                    oParams_Upload_Share_File.FormData.append('file', doc.output("blob"), this.oPdfName + ".pdf");
                    this.MapService.Upload_Share_File(oParams_Upload_Share_File).then(result => {
                        if (result) {
                            this.oLink = result;
                            resolve(true);
                        } else {
                            resolve(false);
                        }
                    });
                } else {
                    doc.save(this.oPdfName + ".pdf");
                    resolve(true);
                }
            }).catch(function (error) {
                this.CmSvc.ShowMessage('Failed to generate PDF');
                resolve(false);
            });
        });
    }

    openSharePanel(): void {
        if (!this._shortcutsPanel || !this._shortcutsOrigin) {
            return;
        }

        if (!this._overlayRef) {
            this._createOverlay();
        }

        this._overlayRef.attach(new TemplatePortal(this._shortcutsPanel, this._viewContainerRef));
    }

    closePanel(): void {
        if (this._overlayRef) {
            this._overlayRef.detach();
        }
    }

    generateQr() {
        if (this.oLink) {
            this.dialog.open(QrCodeModalComponent, {
                data: this.oLink,
            });
        } else {
            this.displayProgressSpinner = true;
            this.uploadPdf().then(result => {
                this.displayProgressSpinner = false;
                if (result) {
                    this.dialog.open(QrCodeModalComponent, {
                        data: this.oLink,
                    });
                }
            });
        }
    }

    shareByEmail() {
        if (this.oLink) {
            this.dialog.open(ShareEmailModalComponent, {
                width: '500px',
                data: this.oLink,
            });
        } else {
            this.displayProgressSpinner = true;
            this.uploadPdf().then(result => {
                this.displayProgressSpinner = false;
                if (result) {
                    this.dialog.open(ShareEmailModalComponent, {
                        width: '500px',
                        data: this.oLink,
                    });
                }
            });
        }
    }

    generateWebLink() {
        if (this.oLink) {
            this.Clipboard.copy(this.oLink);
            this.CmSvc.ShowMessage("Link is copied to clipboard");
        } else {
            this.displayProgressSpinner = true;
            this.uploadPdf().then(result => {
                this.displayProgressSpinner = false;
                if (result) {
                    this.CmSvc.ShowMessage("Link generated successfully");
                }
            })
        }
    }

    printPdf() {
        this.displayProgressSpinner = true;
        this.uploadPdf(true).then(() => {
            this.displayProgressSpinner = false;
        });
    }

    private _createOverlay(): void {
        this._overlayRef = this._overlay.create({
            hasBackdrop: true,
            backdropClass: 'smartr-backdrop-on-mobile',
            scrollStrategy: this._overlay.scrollStrategies.block(),
            positionStrategy: this._overlay.position()
                .flexibleConnectedTo(this._shortcutsOrigin._elementRef.nativeElement)
                .withLockedPosition(true)
                .withPush(true)
                .withPositions([
                    {
                        originX: 'start',
                        originY: 'bottom',
                        overlayX: 'start',
                        overlayY: 'top'
                    },
                    {
                        originX: 'start',
                        originY: 'top',
                        overlayX: 'start',
                        overlayY: 'bottom'
                    },
                    {
                        originX: 'end',
                        originY: 'bottom',
                        overlayX: 'end',
                        overlayY: 'top'
                    },
                    {
                        originX: 'end',
                        originY: 'top',
                        overlayX: 'end',
                        overlayY: 'bottom'
                    }
                ])
        });

        this._overlayRef.backdropClick().subscribe(() => {
            this._overlayRef.detach();
        });
    }

    ngOnDestroy(): void {
        if (this._overlayRef) {
            this._overlayRef.dispose();
        }
    }
}
