import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Subject } from 'rxjs';
import { Area, Default_settings, Dimension, District, Districtnex_module, Entity, Kpi, Organization, Setup, Setup_category, Site, Top_level, User_Details } from './proxy.service';

@Injectable()
export class CommonService {
    Ticket = '';
    IS_LOGGED_IN = false;
    oUser_Details: User_Details;
    Is_Google_Map_Loaded = false;

    APIUrl = '';

    oList_Kpi: Kpi[];
    oList_Area: Area[];
    oList_Site: Site[];
    oList_Setup: Setup[];
    oList_Entity: Entity[];
    oList_District: District[];
    oList_Top_level: Top_level[];
    oList_Dimension: Dimension[];
    oList_Organization: Organization[];
    oList_Setup_category: Setup_category[];
    oList_Districtnex_module: Districtnex_module[];

    NUMBER_OF_USERS: number;

    oOrganization: Organization;

    userTheme = {
        ORGANIZATION_FAVICON_URL: 'assets/images/logo/picacity/favicon.ico',
        DARK_SQUARE_LOGO_URL: 'assets/images/logo/picacity/logo-black-square.png',
        DARK_RECTANGLE_LOGO_URL: 'assets/images/logo/picacity/logo-black-rect.png',
        LIGHT_SQUARE_LOGO_URL: 'assets/images/logo/picacity/logo-white-square.png',
        LIGHT_RECTANGLE_LOGO_URL: 'assets/images/logo/picacity/logo-white-rect.png',
    }

    defaultSettings: Default_settings = new Default_settings();

    signInSubject = new Subject<void>();
    signOutSubject = new Subject<void>();
    signedOutSubject = new Subject<void>();
    clearDataSubject = new Subject<void>();
    onDisplayImageChanged = new Subject<void>();

    constructor(private snackBar: MatSnackBar) {
        this.defaultSettings.DATA_RETENTION_PERIOD = 30;
        this.defaultSettings.PLATFORM_BUTTON = '#0E7DC2';
        this.defaultSettings.PLATFORM_PRIMARY = '#002439';
        this.defaultSettings.ORGANIZATION_FAVICON_URL = 'assets/images/logo/picacity/favicon.ico';
        this.defaultSettings.DARK_SQUARE_LOGO_URL = 'assets/images/logo/picacity/logo-black-square.png';
        this.defaultSettings.DARK_RECTANGLE_LOGO_URL = 'assets/images/logo/picacity/logo-black-rect.png';
        this.defaultSettings.LIGHT_SQUARE_LOGO_URL = 'assets/images/logo/picacity/logo-white-square.png';
        this.defaultSettings.LIGHT_RECTANGLE_LOGO_URL = 'assets/images/logo/picacity/logo-white-rect.png';
    }

    ShowMessage(message: string, d: number = 1000): void {
        this.snackBar.open(message, '', { duration: d });
    }

    formatDate(date): any {
        const d = new Date(date);
        let month = '' + (d.getMonth() + 1);
        let day = '' + d.getDate();
        const year = d.getFullYear();

        if (month.length < 2) {
            month = '0' + month;
        }
        if (day.length < 2) {
            day = '0' + day;
        }
        return [year, month, day].join('-');
    }

    isNumeric(str) {
        if (typeof str != "string") {
            return false;
        }
        return !isNaN(parseInt(str)) && !isNaN(parseFloat(str));
    }

    isDark(color) {
        var c = color.substring(1);      // strip #
        var rgb = parseInt(c, 16);   // convert rrggbb to decimal
        var r = (rgb >> 16) & 0xff;  // extract red
        var g = (rgb >> 8) & 0xff;  // extract green
        var b = (rgb >> 0) & 0xff;  // extract blue

        var luma = 0.2126 * r + 0.7152 * g + 0.0722 * b; // per ITU-R BT.709

        if (luma < 138) {
            return true;
        }
    }

    getRoute(fullRoute) {
        let route = fullRoute.split('/').pop().toUpperCase();
        if (this.isNumeric(route)) {
            route = '';
        }
        return route;
    }

    toTitleCase(str) {
        return str.replace(
            /\w\S*/g,
            function (txt) {
                return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
            }
        );
    }

    Get_Enum_String_Keys_List(EnumVal) {
        return Object.keys(EnumVal).filter(x => isNaN(parseInt(x)));
    }

    CheckString(input: string): boolean {
        if (input != null && input != undefined && input != "null" && input != "undefined") {
            return true;
        }
        else {
            return false;
        }
    }

    Objects_Equal(obj1, obj2): boolean {
        return JSON.stringify(obj1) == JSON.stringify(obj2);
    }

    Objects_Different(obj1, obj2): boolean {
        return JSON.stringify(obj1) != JSON.stringify(obj2);
    }

    Are_Strings_Equal(string1: string, string2: string): boolean {
        return string1.trim().toLowerCase() == string2.trim().toLowerCase();
    }

    Are_Passwords_Equal(password: string, confirm_password: string): boolean {
        if (password.length != confirm_password.length) {
            return false;
        }
        var mismatch = 0;
        for (var i = 0; i < password.length; ++i) {
            mismatch |= (password.charCodeAt(i) ^ confirm_password.charCodeAt(i));
        }
        return mismatch == 0;
    }

    Generate_Random_String(stringLength = 12, includeAlpha = true, includeCalpha = true, includeNum = true, includeSpecials = true): string {
        const numberChars = "0123456789";
        const upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const lowerChars = "abcdefghijklmnopqrstuvwxyz";
        const specials = ',.!@#$%^&*';
        const allChars = (includeNum ? numberChars : '') + (includeCalpha ? upperChars : '') + (includeAlpha ? lowerChars : '') + (includeSpecials ? specials : '');
        let randPasswordArray = Array(stringLength);
        randPasswordArray[0] = numberChars;
        randPasswordArray[1] = upperChars;
        randPasswordArray[2] = lowerChars;
        randPasswordArray = randPasswordArray.fill(allChars, 3);
        return this.Shuffle_Array(randPasswordArray.map(function (x) { return x[Math.floor(Math.random() * x.length)] })).join('');
    }

    Shuffle_Array(array) {
        for (var i = array.length - 1; i > 0; i--) {
            var j = Math.floor(Math.random() * (i + 1));
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        return array;
    }

    Handle_Success(msg = 'Success!', timeout = 3000): void {
        if ((msg != null) && (msg !== '')) {
            this.ShowMessage(msg, timeout);
        }
    }

    Handle_Exception(msg: string): void {
        if ((msg != null) && (msg !== '')) {
            if (msg.includes('SESSION_INVALID')) {
                this.signOutSubject.next();
                this.ShowMessage("Your account has been deactivated");
                return;
            }
            if (msg.includes('SESSION_EXPIRED')) {
                this.signOutSubject.next();
                this.ShowMessage("Your session has expired");
                return;
            }
            if (msg.includes('ACCESS_DENIED')) {
                this.signOutSubject.next();
                this.ShowMessage("Access has changed, please sign in again");
                return;
            }
            this.ShowMessage(msg, 3000);
        }
    }

    Handle_Stack_Trace(msg: string): void {
        if ((msg != null) && (msg !== '')) {
        }
    }

    No_Changes_Message(): void {
        this.ShowMessage("No changes were made", 3000);
    }

    Get_Dimension_By_DIMENSION_ID(DIMENSION_ID: number): Dimension {
        return this.oList_Dimension.find(dimension => dimension.DIMENSION_ID == DIMENSION_ID);
    }

    Get_Kpi_By_KPI_ID(KPI_ID: number): Kpi {
        return this.oList_Kpi.find(kpi => kpi.KPI_ID == KPI_ID);
    }

    Is_String_Empty(str: string) {
        return !str || str == '';
    }

    Get_Setup_By_SETUP_ID(SETUP_ID: number): Setup {
        return this.oList_Setup.find(setup => setup.SETUP_ID == SETUP_ID);
    }

    Get_Setup_ID_By_Value(Value: string): number {
        return this.oList_Setup.find(setup => setup.VALUE == Value).SETUP_ID;
    }

    Get_Setup_Category_By_SETUP_CATEGORY_NAME(NAME: string): Setup_category {
        return this.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME.toLowerCase() == NAME.toLowerCase());
    }

    Get_Setup_By_Setup_Category_Name_And_SETUP_ID(SETUP_CATEGORY_NAME: string, SETUP_ID: number): Setup {
        let oSetup_Category = this.oList_Setup_category.find(oSetup_Category => oSetup_Category.SETUP_CATEGORY_NAME.toLowerCase() == SETUP_CATEGORY_NAME.toLowerCase());
        return oSetup_Category.List_Setup.find(oSetup => oSetup.SETUP_ID == SETUP_ID);
    }

    Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE(SETUP_CATEGORY_NAME: string, VALUE: string): number {
        let oSetup_Category = this.Get_Setup_Category_By_SETUP_CATEGORY_NAME(SETUP_CATEGORY_NAME);
        return oSetup_Category.List_Setup?.find(setup => setup.VALUE.toLowerCase() == VALUE.toLowerCase()).SETUP_ID;
    }

    Get_Setup_By_Setup_Category_Name_And_Setup_VALUE(SETUP_CATEGORY_NAME: string, VALUE: string): Setup {
        let oSetup_Category = this.Get_Setup_Category_By_SETUP_CATEGORY_NAME(SETUP_CATEGORY_NAME);
        return oSetup_Category.List_Setup?.find(setup => setup.VALUE.toLowerCase() == VALUE.toLowerCase());
    }

    ngOnDestroy(): void {
        this.signInSubject.unsubscribe();
        this.signOutSubject.unsubscribe();
        this.clearDataSubject.unsubscribe();
        this.signedOutSubject.unsubscribe();
        this.onDisplayImageChanged.unsubscribe();
    }
}
