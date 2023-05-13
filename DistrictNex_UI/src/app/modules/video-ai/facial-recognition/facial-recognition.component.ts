import { Component, Input, OnInit } from '@angular/core';
import { Entity } from 'app/core/Services/proxy.service';

@Component({
    selector: 'facial-recognition',
    templateUrl: './facial-recognition.component.html',
    styleUrls: ['./facial-recognition.component.scss']
})
export class FacialRecognitionComponent implements OnInit {
    @Input() oEntity: Entity;

    selectedPanel: string = 'facial-recognition';

    panels: any[] = [
        {
            id: 'facial-recognition',
            title: 'Recognition History',
        },
        {
            id: 'face-list',
            title: 'Face List',
        },
        {
            id: 'face-search',
            title: 'Face Search',
        }
    ];

    ngOnInit(): void {
        if (localStorage.getItem('FacialRecognitionPanel')) {
            if (this.selectedPanel !== localStorage.getItem('FacialRecognitionPanel')) {
                this.goToPanelfromLoc(localStorage.getItem('FacialRecognitionPanel'));
            }
        }
    }

    goToPanelfromLoc(panel: string): void {
        if (this.panels.some(x => x.id === panel)) {
            this.selectedPanel = panel;
            localStorage.setItem('FacialRecognitionPanel', panel);
        } else {
            this.selectedPanel = 'facial-recognition';
            localStorage.setItem('FacialRecognitionPanel', 'facial-recognition');
        }
    }

    goToPanel(panel: string): void {
        this.selectedPanel = panel;
        localStorage.setItem('FacialRecognitionPanel', panel);
    }

}
