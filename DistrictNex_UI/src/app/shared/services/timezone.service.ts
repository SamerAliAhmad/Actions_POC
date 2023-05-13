import { Injectable } from '@angular/core';
import moment from 'moment';

@Injectable({
    providedIn: 'root'
})
export class TimezoneService {

    oList_Timezone: string = (Intl as any).supportedValuesOf('timeZone');

    private _oCurrent_Timezone_Offset: string;
    public get oCurrent_Timezone_Offset() {
        return this._oCurrent_Timezone_Offset;
    }
    public set oCurrent_Timezone_Offset(value: string) { }

    private _oCurrent_Timezone: string = "";
    public get oCurrent_Timezone() {
        return this._oCurrent_Timezone;
    }
    public set oCurrent_Timezone(value: string) {
        this._oCurrent_Timezone = value;
        localStorage.setItem("selected timezone", this._oCurrent_Timezone);

        const dateText = Intl.DateTimeFormat([], {
            timeZone: this._oCurrent_Timezone,
            timeZoneName: "longOffset"
        }).format(new Date());
        this._oCurrent_Timezone_Offset = dateText.split(" ")[1].slice(3) || '+0';
    }

    constructor() {
        this.oCurrent_Timezone = Intl.DateTimeFormat().resolvedOptions().timeZone;
        let oSaved_Timezone = localStorage.getItem("selected timezone");
        if (oSaved_Timezone && this.oList_Timezone.includes(oSaved_Timezone)) {
            this.oCurrent_Timezone = oSaved_Timezone;
        }
    }

    Transform_Date_To_Current_Timezone(date: string | Date, isUtc: boolean = false) {
        return moment(date).utcOffset(isUtc ? "+00:00" : this.oCurrent_Timezone_Offset, true);
    }

    Get_Timezone_Offset(timezone: string) {
        const dateText = Intl.DateTimeFormat([], { timeZone: timezone, timeZoneName: "longOffset" }).format(new Date);
        return dateText.split(" ")[1].slice(3) || '+0';
    }
}
