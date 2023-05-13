import { Subject } from 'rxjs';

export const requestOpenDistrictInsightSubject = new Subject<void>();
export const openDistrictInsightSubject = new Subject<void>();

export const polygonColors = ['#e8423c', '#38fff2', 'orange', '#3ce84b', '#ebeb3d', '#e8423c', '#ebeb3d', 'green']

export const View_Type_List = ["top_level", "district", "area", "site", "entity"];

export enum Enum_Map_view {
    entity,
    site,
    area,
    district,
    top_level,
}

export enum Enum_Enum_Dimension_Status {
    enabled,
    disabled,
    hidden,
}

export enum Enum_Up_Down {
    UP,
    DOWN
}