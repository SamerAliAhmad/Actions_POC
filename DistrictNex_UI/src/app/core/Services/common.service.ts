import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DomSanitizer } from '@angular/platform-browser';
import { ColoringService } from 'app/shared/services/coloring.service';
import { cloneDeep } from 'lodash';
import { Map } from 'mapbox-gl';
import { Subject } from 'rxjs';
import { Preset_time } from '../Models/models';
import { Alert_settings, Area, Area_Kpi_Dialog_Data, Default_chart_color, Default_settings, Dimension, Dimension_chart_configuration, Dimension_index, District, Entity, Face_Target_Response_Category, Kpi, Kpi_chart_configuration, License_Plate_Category, Niche_categories, Organization_Data, Organization_Data_with_Accessible_Top_Level_Data, Organization_color_scheme, Organization_data_source_kpi, Organization_theme, Setup, Setup_category, Site, Site_Kpi_Dialog_Data, Specialized_chart_configuration, Stream_Data, User_Accessible_Data, User_Accessible_Level_List, User_Details, User_districtnex_module, User_theme } from './proxy.service';

@Injectable()
export class CommonService {
    IS_LOGGED_IN = false;
    oUser_Details: User_Details = new User_Details();
    Is_Google_Map_Loaded = false;
    GeoJSON_Source: string;
    Ticket = '';

    saved_top_level_id: number;
    saved_organization_id: number;
    chosen_route: string;

    oMap: Map;
    APIUrl = '';
    Asset_Endpoint = '';
    ReportUrl = `${location.origin}/reports/view/`;

    Signalr_Data_Hub = "datahub";
    SignalR_Realtime_Server_Endpoint = '';

    oUser_Accessible_Data: User_Accessible_Data;
    oUser_Accessible_Level_List: User_Accessible_Level_List;

    oList_Site_Kpi_Data: Site_Kpi_Dialog_Data[];
    oList_Area_Kpi_Data: Area_Kpi_Dialog_Data[];

    oList_Organization_theme: Organization_theme[];
    oUser_theme: User_theme;
    oList_Setup: Setup[];
    oList_Main_Kpi: Kpi[];
    oList_Dimension: Dimension[];
    oList_Auto_Generated_Kpi: Kpi[];
    oList_Accessible_Site: Site[] = [];
    oList_Accessible_Area: Area[] = [];
    oList_Preset_time: Preset_time[] = [];
    oList_Setup_category: Setup_category[];
    oList_Accessible_Entity: Entity[] = [];
    oList_Alert_settings: Alert_settings[];
    oList_Dimension_Index: Dimension_index[];
    oList_Accessible_District: District[] = [];
    oList_Niche_categories: Niche_categories[];
    oList_Default_chart_color: Default_chart_color[] = [];
    oList_Face_Target_List: Face_Target_Response_Category[];
    oList_License_Plate_Categories: License_Plate_Category[];
    oList_Kpi_chart_configuration: Kpi_chart_configuration[] = [];
    oList_Accessible_districtnex_module: User_districtnex_module[] = [];
    oList_Organization_data_source_kpi: Organization_data_source_kpi[] = [];
    oList_Dimension_chart_configuration: Dimension_chart_configuration[] = [];
    oList_Specialized_chart_configuration: Specialized_chart_configuration[] = [];
    oList_Organization_Data_with_Accessible_Top_Level_Data: Organization_Data_with_Accessible_Top_Level_Data[] = [];

    userTheme = {
        ORGANIZATION_FAVICON_URL: 'assets/images/logo/picacity/favicon.ico',
        DARK_SQUARE_LOGO_URL: 'assets/images/logo/picacity/logo-black-square.png',
        DARK_RECTANGLE_LOGO_URL: 'assets/images/logo/picacity/logo-black-rect.png',
        LIGHT_SQUARE_LOGO_URL: 'assets/images/logo/picacity/logo-white-square.png',
        LIGHT_RECTANGLE_LOGO_URL: 'assets/images/logo/picacity/logo-white-rect.png'
    }
    oCurrent_Applied_Organization_color_scheme: Organization_color_scheme;

    oStream_Data: Stream_Data;
    oSignInSubject = new Subject<void>();
    oSignOutSubject = new Subject<void>();
    oSignedOutSubject = new Subject<void>();
    oToggle_Module_Subject = new Subject<boolean>();
    oResetBdcWalkthroughSubject = new Subject<void>();
    oToggle_Alerts_Drawer_Subject = new Subject<void>();
    oUpdateApplicationImagesSubject = new Subject<void>();
    oDefaultSettings: Default_settings = new Default_settings();

    oToggle_Change_Organization_Subject = new Subject<void>();

    isEditRemovedExtrusionsOn = false;

    constructor(
        private snackBar: MatSnackBar,
        private Sanitizer: DomSanitizer,
        private ColoringService: ColoringService
    ) {
        this.oDefaultSettings.DATA_RETENTION_PERIOD = 30;
        this.oDefaultSettings.PLATFORM_BUTTON = '#0E7DC2';
        this.oDefaultSettings.PLATFORM_PRIMARY = '#002439';
        this.oDefaultSettings.ORGANIZATION_FAVICON_URL = 'assets/images/logo/picacity/favicon.ico';
        this.oDefaultSettings.DARK_SQUARE_LOGO_URL = 'assets/images/logo/picacity/logo-black-square.png';
        this.oDefaultSettings.DARK_RECTANGLE_LOGO_URL = 'assets/images/logo/picacity/logo-black-rect.png';
        this.oDefaultSettings.LIGHT_SQUARE_LOGO_URL = 'assets/images/logo/picacity/logo-white-square.png';
        this.oDefaultSettings.LIGHT_RECTANGLE_LOGO_URL = 'assets/images/logo/picacity/logo-white-rect.png';
    }

    Set_Application_Theme() {
        this.oList_Organization_theme = this.oList_Organization_Data_with_Accessible_Top_Level_Data.find(oOrganization_Data_with_Accessible_Top_Level_Data => oOrganization_Data_with_Accessible_Top_Level_Data.ORGANIZATION_DATA.ORGANIZATION_ID == this.saved_organization_id)?.ORGANIZATION_DATA.LIST_ORGANIZATION_THEME;
        if (this.oList_Organization_theme?.length > 0) {
            if (!this.oUser_theme) {
                this.oUser_theme = new User_theme();
                this.oUser_theme.USER_THEME_ID = -1;
                this.oUser_theme.USER_ID = this.oUser_Details.USER_ID;
                this.oUser_theme.ORGANIZATION_THEME_ID = this.oList_Organization_theme[0].ORGANIZATION_THEME_ID;
            } else {
                let index = this.oList_Organization_theme.findIndex(oOrganization_theme => oOrganization_theme.ORGANIZATION_THEME_ID == this.oUser_theme.ORGANIZATION_THEME_ID);
                if (index == -1) {
                    this.oUser_theme.ORGANIZATION_THEME_ID = this.oList_Organization_theme[0].ORGANIZATION_THEME_ID;
                }
            }
        } else {
            this.oUser_theme = null;
        }
        this.Update_App_Colors(this.oList_Organization_Data_with_Accessible_Top_Level_Data.find(oOrganization_Data_with_Accessible_Top_Level_Data => oOrganization_Data_with_Accessible_Top_Level_Data.ORGANIZATION_DATA.ORGANIZATION_ID == this.saved_organization_id)?.ORGANIZATION_DATA.LIST_ORGANIZATION_COLOR_SCHEME[0]);
        this.Update_App_Images();
    }

    Update_Default_Settings(i_Default_settings: Default_settings = new Default_settings()) {
        this.oDefaultSettings = i_Default_settings;
        if (i_Default_settings.DARK_RECTANGLE_LOGO_URL) {
            this.oDefaultSettings.DARK_RECTANGLE_LOGO_URL = i_Default_settings.DARK_RECTANGLE_LOGO_URL;
        }
        if (i_Default_settings.DARK_SQUARE_LOGO_URL) {
            this.oDefaultSettings.DARK_SQUARE_LOGO_URL = i_Default_settings.DARK_SQUARE_LOGO_URL;
        }
        if (i_Default_settings.LIGHT_RECTANGLE_LOGO_URL) {
            this.oDefaultSettings.LIGHT_RECTANGLE_LOGO_URL = i_Default_settings.LIGHT_RECTANGLE_LOGO_URL;
        }
        if (i_Default_settings.LIGHT_SQUARE_LOGO_URL) {
            this.oDefaultSettings.LIGHT_SQUARE_LOGO_URL = i_Default_settings.LIGHT_SQUARE_LOGO_URL;
        }
        if (i_Default_settings.ORGANIZATION_FAVICON_URL) {
            this.oDefaultSettings.ORGANIZATION_FAVICON_URL = i_Default_settings.ORGANIZATION_FAVICON_URL;
        }
        if (i_Default_settings.DEFAULT_SETTINGS_ID !== undefined) {
            this.oDefaultSettings.DEFAULT_SETTINGS_ID = i_Default_settings.DEFAULT_SETTINGS_ID;
        }
        if (i_Default_settings.PLATFORM_PRIMARY) {
            this.oDefaultSettings.PLATFORM_PRIMARY = i_Default_settings.PLATFORM_PRIMARY;
            this.ColoringService.generateThemeColor(this.oDefaultSettings.PLATFORM_PRIMARY)
        }
        if (i_Default_settings.PLATFORM_BUTTON) {
            this.oDefaultSettings.PLATFORM_BUTTON = i_Default_settings.PLATFORM_BUTTON;
        }
        document.documentElement.style.setProperty('--smartr-button', this.oDefaultSettings.PLATFORM_BUTTON);
        if (this.isDark(this.oDefaultSettings.PLATFORM_BUTTON)) {
            document.documentElement.style.setProperty('--smartr-button-text', 'white')
        } else {
            document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
        }
        const floor_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.Data_level_setup.VALUE == "Floor")?.COLOR;
        const entity_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.Data_level_setup.VALUE == "Entity")?.COLOR;
        const site_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.Data_level_setup.VALUE == "Site")?.COLOR;
        const area_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.Data_level_setup.VALUE == "Area")?.COLOR;
        const district_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.Data_level_setup.VALUE == "District")?.COLOR;
        document.documentElement.style.setProperty('--floor-chart-color', floor_color);
        document.documentElement.style.setProperty('--entity-chart-color', entity_color);
        document.documentElement.style.setProperty('--site-chart-color', site_color);
        document.documentElement.style.setProperty('--area-chart-color', area_color);
        document.documentElement.style.setProperty('--district-chart-color', district_color);

        this.userTheme.DARK_RECTANGLE_LOGO_URL = this.oDefaultSettings.DARK_RECTANGLE_LOGO_URL;
        this.userTheme.ORGANIZATION_FAVICON_URL = this.oDefaultSettings.ORGANIZATION_FAVICON_URL;
        this.userTheme.DARK_SQUARE_LOGO_URL = this.oDefaultSettings.DARK_SQUARE_LOGO_URL;
        this.userTheme.LIGHT_RECTANGLE_LOGO_URL = this.oDefaultSettings.LIGHT_RECTANGLE_LOGO_URL;
        this.userTheme.LIGHT_SQUARE_LOGO_URL = this.oDefaultSettings.LIGHT_SQUARE_LOGO_URL;
    }

    Update_App_Colors(i_Organization_color_scheme: Organization_color_scheme = this.oUser_Details.Organization.List_Organization_color_scheme[0]) {
        if (this.oCurrent_Applied_Organization_color_scheme?.ORGANIZATION_COLOR_SCHEME_ID != i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID) {
            this.oCurrent_Applied_Organization_color_scheme = i_Organization_color_scheme;
            var Floor_Setup_ID = this.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Floor");
            var Entity_Setup_ID = this.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity");
            var Site_Setup_ID = this.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
            var Area_Setup_ID = this.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area");
            var District_Setup_ID = this.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District");
            let oList_Organization_chart_color = i_Organization_color_scheme.List_Organization_chart_color;
            if (i_Organization_color_scheme.PLATFORM_PRIMARY) {
                this.ColoringService.generateThemeColor(i_Organization_color_scheme.PLATFORM_PRIMARY)
            }
            if (i_Organization_color_scheme.PLATFORM_BUTTON) {
                document.documentElement.style.setProperty('--smartr-button', i_Organization_color_scheme.PLATFORM_BUTTON);
                if (this.isDark(i_Organization_color_scheme.PLATFORM_BUTTON)) {
                    document.documentElement.style.setProperty('--smartr-button-text', 'white')
                } else {
                    document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
                }
            }
            let floor_color = oList_Organization_chart_color.find(oOrganization_chart_color => oOrganization_chart_color.DATA_LEVEL_SETUP_ID == Floor_Setup_ID).COLOR;
            if (!floor_color) {
                floor_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == Floor_Setup_ID).COLOR;
            }
            let entity_color = oList_Organization_chart_color.find(oOrganization_chart_color => oOrganization_chart_color.DATA_LEVEL_SETUP_ID == Entity_Setup_ID).COLOR;
            if (!entity_color) {
                entity_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == Entity_Setup_ID).COLOR;
            }
            let site_color = oList_Organization_chart_color.find(oOrganization_chart_color => oOrganization_chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID).COLOR;
            if (!site_color) {
                site_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID).COLOR;
            }
            let area_color = oList_Organization_chart_color.find(oOrganization_chart_color => oOrganization_chart_color.DATA_LEVEL_SETUP_ID == Area_Setup_ID).COLOR;
            if (!area_color) {
                area_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == Area_Setup_ID).COLOR;
            }
            let district_color = oList_Organization_chart_color.find(oOrganization_chart_color => oOrganization_chart_color.DATA_LEVEL_SETUP_ID == District_Setup_ID).COLOR;
            if (!district_color) {
                district_color = this.oDefaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == District_Setup_ID).COLOR;
            }
            document.documentElement.style.setProperty('--floor-chart-color', floor_color);
            document.documentElement.style.setProperty('--entity-chart-color', entity_color);
            document.documentElement.style.setProperty('--site-chart-color', site_color);
            document.documentElement.style.setProperty('--area-chart-color', area_color);
            document.documentElement.style.setProperty('--district-chart-color', district_color);
        }
    }

    Update_App_Images() {
        const oOrganization_Data: Organization_Data = this.oList_Organization_Data_with_Accessible_Top_Level_Data?.find(oOrganization_Data_with_Accessible_Top_Level_Data => oOrganization_Data_with_Accessible_Top_Level_Data.ORGANIZATION_DATA.ORGANIZATION_ID == this.saved_organization_id)?.ORGANIZATION_DATA;
        if (oOrganization_Data) {
            this.userTheme.DARK_RECTANGLE_LOGO_URL = oOrganization_Data.DARK_RECTANGLE_LOGO_URL ?? this.userTheme.DARK_RECTANGLE_LOGO_URL;
            this.userTheme.ORGANIZATION_FAVICON_URL = oOrganization_Data.ORGANIZATION_FAVICON_URL ?? this.userTheme.ORGANIZATION_FAVICON_URL;
            this.userTheme.DARK_SQUARE_LOGO_URL = oOrganization_Data.DARK_SQUARE_LOGO_URL ?? this.userTheme.DARK_SQUARE_LOGO_URL;
            this.userTheme.LIGHT_RECTANGLE_LOGO_URL = oOrganization_Data.LIGHT_RECTANGLE_LOGO_URL ?? this.userTheme.LIGHT_RECTANGLE_LOGO_URL;
            this.userTheme.LIGHT_SQUARE_LOGO_URL = oOrganization_Data.LIGHT_SQUARE_LOGO_URL ?? this.userTheme.LIGHT_SQUARE_LOGO_URL;
        } else {
            this.userTheme.DARK_RECTANGLE_LOGO_URL = this.oUser_Details.Organization.DARK_RECTANGLE_LOGO_URL ?? this.userTheme.DARK_RECTANGLE_LOGO_URL;
            this.userTheme.ORGANIZATION_FAVICON_URL = this.oUser_Details.Organization.ORGANIZATION_FAVICON_URL ?? this.userTheme.ORGANIZATION_FAVICON_URL;
            this.userTheme.DARK_SQUARE_LOGO_URL = this.oUser_Details.Organization.DARK_SQUARE_LOGO_URL ?? this.userTheme.DARK_SQUARE_LOGO_URL;
            this.userTheme.LIGHT_RECTANGLE_LOGO_URL = this.oUser_Details.Organization.LIGHT_RECTANGLE_LOGO_URL ?? this.userTheme.LIGHT_RECTANGLE_LOGO_URL;
            this.userTheme.LIGHT_SQUARE_LOGO_URL = this.oUser_Details.Organization.LIGHT_SQUARE_LOGO_URL ?? this.userTheme.LIGHT_SQUARE_LOGO_URL;
        }
        this.oUpdateApplicationImagesSubject.next();
    }

    Sanitize(url: string) {
        return this.Sanitizer.bypassSecurityTrustResourceUrl(url);
    }


    set_Map(i_Map: Map) {
        this.oMap = cloneDeep(i_Map);
    }

    ShowMessage(message: string, d: number = 1000): void {
        this.snackBar.open(message, '', { duration: d });
    }

    ToTitleCase(word: string) {
        return word?.replace(word[0], word[0].toUpperCase());
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

    Handle_Exception(msg: string): void {
        if ((msg != null) && (msg !== '')) {
            if (msg.includes('SESSION_INVALID')) {
                this.oSignOutSubject.next();
                this.ShowMessage("Your account has been deactivated");
                return;
            }
            if (msg.includes('ACCESS_DENIED')) {
                location.reload();
                this.ShowMessage("Access has changed");
                return;
            }
            if (msg.includes('SESSION_EXPIRED')) {
                this.oSignOutSubject.next();
                this.ShowMessage("Your session has expired");
                return;
            }
            this.ShowMessage(msg, 3000);
        }
    }

    Handle_Stack_Trace(msg: string): void {
        if ((msg != null) && (msg !== '')) {
            // this.ShowMessage(msg, 3000);
        }
    }

    Handle_Success() {
        this.ShowMessage("Success!", 3000);
    }

    Get_Setup_ID_By_Value(Value: string): number {
        return this.oList_Setup?.find(setup => setup.VALUE == Value).SETUP_ID;
    }

    Get_Setup_Category_By_SETUP_CATEGORY_NAME(NAME: string): Setup_category {
        return this.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME.toLowerCase() == NAME.toLowerCase());
    }

    Get_Data_Level_Setup_From_Setup_Category_List_By_SETUP_ID(ID: number): Setup {
        return this.Get_Setup_Category_By_SETUP_CATEGORY_NAME("Data Level").List_Setup.find(setup => setup.SETUP_ID == ID);
    }

    Get_Setup_By_Setup_Category_Name_And_SETUP_ID(SETUP_CATEGORY_NAME: string, SETUP_ID: number): Setup {
        let oSetup_Category = this.oList_Setup_category.find(oSetup_Category => oSetup_Category.SETUP_CATEGORY_NAME.toLowerCase() == SETUP_CATEGORY_NAME.toLowerCase());
        return oSetup_Category.List_Setup.find(oSetup => oSetup.SETUP_ID == SETUP_ID);
    }

    Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE(SETUP_CATEGORY_NAME: string, VALUE: string): number {
        let oSetup_Category = this.Get_Setup_Category_By_SETUP_CATEGORY_NAME(SETUP_CATEGORY_NAME);
        return oSetup_Category.List_Setup?.find(setup => setup.VALUE.toLowerCase() == VALUE.toLowerCase()).SETUP_ID;
    }

    Get_Dimension_By_DIMENSION_ID(DIMENSION_ID: number): Dimension {
        return this.oList_Dimension.find(dimension => dimension.DIMENSION_ID == DIMENSION_ID);
    }

    inside(point, vs) {
        var x = point[0], y = point[1];

        var inside = false;
        for (var i = 0, j = vs.length - 1; i < vs.length; j = i++) {
            var xi = vs[i][0], yi = vs[i][1];
            var xj = vs[j][0], yj = vs[j][1];

            var intersect = ((yi > y) != (yj > y))
                && (x < (xj - xi) * (y - yi) / (yj - yi) + xi);
            if (intersect) inside = !inside;
        }

        return inside;
    };

    CheckString(input: string): boolean {
        if (input != null && input != undefined && input != "null" && input != "undefined") {
            return true;
        }
        else {
            return false;
        }
    }

    Are_Objects_Equal(Object1, Object2) {
        return JSON.stringify(Object1) === JSON.stringify(Object2);
    }

    lerp = (x, y, a) => x * (1 - a) + y * a;
    clamp = (a, min = 0, max = 1) => Math.min(max, Math.max(min, a));
    invlerp = (x, y, a) => this.clamp((a - x) / (y - x));
    range = (x1, y1, x2, y2, a) => this.lerp(x2, y2, this.invlerp(x1, y1, a));

    ngOnDestroy() {
        this.oSignInSubject.unsubscribe();
        this.oSignOutSubject.unsubscribe();
        this.oSignedOutSubject.unsubscribe();
        this.oToggle_Module_Subject.unsubscribe();
        this.oResetBdcWalkthroughSubject.unsubscribe();
        this.oUpdateApplicationImagesSubject.unsubscribe();
        this.oToggle_Alerts_Drawer_Subject.unsubscribe();
    }
}
