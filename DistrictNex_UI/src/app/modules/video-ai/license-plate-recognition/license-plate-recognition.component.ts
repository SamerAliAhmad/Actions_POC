import { Component, Input } from '@angular/core';
import { Entity } from 'app/core/Services/proxy.service';

@Component({
    selector: 'license-plate-recognition',
    templateUrl: './license-plate-recognition.component.html',
    styleUrls: ['./license-plate-recognition.component.scss']
})
export class LicensePlateRecognitionComponent {
    @Input() oEntity: Entity;
    selectedTab = 2;
}
