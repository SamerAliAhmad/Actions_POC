import { ChangeDetectorRef, Component, OnInit, ViewChild } from '@angular/core';
import { GoogleMap } from '@angular/google-maps';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Log, Site } from 'app/core/Services/proxy.service';
import { LogsService } from 'app/modules/logs/logs.service';

@Component({
    selector: 'dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
    markers = [];
    currentUserName: string;
    zoom = 7
    center: google.maps.LatLngLiteral
    options: google.maps.MapOptions = {
        // mapTypeId: 'map',
        zoomControl: true,
        scrollwheel: true,
        disableDoubleClickZoom: false,
        keyboardShortcuts: false,
        center: {
            lng: this.CmSvc.oList_Site.reduce((total, next) => total + next.CENTER_LONGITUDE, 0) / this.CmSvc.oList_Site.length,
            lat: this.CmSvc.oList_Site.reduce((total, next) => total + next.CENTER_LATITUDE, 0) / this.CmSvc.oList_Site.length,
        },
    }
    oList_Site: Site[];
    oList_Entity: Entity[];
    NUMBER_OF_USERS: number;

    logsLoaded = false;
    isGoogleMapLoaded = false;

    logsDataSource: MatTableDataSource<Log> = new MatTableDataSource();
    logsTableColumns: string[] = ['message', 'entryDate'];
    @ViewChild('logsTable', { read: MatSort }) logsTableMatSort: MatSort;


    @ViewChild(GoogleMap) map!: GoogleMap;

    constructor(
        private CmSvc: CommonService,
        private LogsService: LogsService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.isGoogleMapLoaded = this.CmSvc.Is_Google_Map_Loaded
        this.currentUserName = this.CmSvc.oUser_Details.FIRST_NAME + ' ' + this.CmSvc.oUser_Details.LAST_NAME;
        this.oList_Site = this.CmSvc.oList_Site;
        this.oList_Entity = this.CmSvc.oList_Entity;
        this.NUMBER_OF_USERS = this.CmSvc.NUMBER_OF_USERS;
    }

    ngOnInit() {
        this.LogsService.getLogsWithFilters(null, null, null, null, null, null, null, null, 0, 10).then(logs => {
            this.logsDataSource.data = logs.List_Log;
            this.logsLoaded = true;
            this.logsDataSource.sort = this.logsTableMatSort;
        });
    }

    ngAfterViewInit() {
        this.markers = [];
        this.CmSvc.oList_Site.forEach(site => {
            var icon = {
                url: site.LOGO_URL, // url
                scaledSize: new google.maps.Size(50, 50), // scaled size
                origin: new google.maps.Point(0, 0), // origin
                anchor: new google.maps.Point(0, 0) // anchor
            };

            this.markers.push({
                position: {
                    lat: site.CENTER_LATITUDE,
                    lng: site.CENTER_LONGITUDE,
                },
                title: site.NAME,
                options: {
                    draggable: false,
                    icon: icon
                },
            })
        })
        const bounds = this.getBounds(this.markers);
        this.map.googleMap.fitBounds(bounds);
        this._changeDetectorRef.detectChanges();
    }

    getBounds(markers) {
        let north;
        let south;
        let east;
        let west;

        for (const marker of markers) {
            // set the coordinates to marker's lat and lng on the first run.
            // if the coordinates exist, get max or min depends on the coordinates.
            north = north !== undefined ? Math.max(north, marker.position.lat) : marker.position.lat;
            south = south !== undefined ? Math.min(south, marker.position.lat) : marker.position.lat;
            east = east !== undefined ? Math.max(east, marker.position.lng) : marker.position.lng;
            west = west !== undefined ? Math.min(west, marker.position.lng) : marker.position.lng;
        };

        const bounds = { north, south, east, west };

        return bounds;
    }

    zoomIn() {
        if (this.zoom < this.options.maxZoom) this.zoom++
    }

    zoomOut() {
        if (this.zoom > this.options.minZoom) this.zoom--
    }
}
