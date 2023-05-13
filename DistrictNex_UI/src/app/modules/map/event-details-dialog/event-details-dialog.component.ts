import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Public_Event } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';

@Component({
    selector: 'event-details-dialog',
    templateUrl: './event-details-dialog.component.html',
    styleUrls: ['./event-details-dialog.component.scss']
})
export class EventDetailsDialogComponent {

    constructor(
        public TimezoneService: TimezoneService,
        @Inject(MAT_DIALOG_DATA) public oPublic_event: Public_Event,
    ) { }

}
