import { IsActiveMatchOptions } from '@angular/router';

export interface SmartrNavigationItem {
    id?: string;
    title?: string;
    subtitle?: string;
    type:
    | 'aside'
    | 'basic'
    | 'collapsable'
    | 'divider'
    | 'group'
    | 'spacer';
    hidden?: (item: SmartrNavigationItem) => boolean;
    active?: boolean;
    disabled?: boolean;
    tooltip?: string;
    link?: string;
    externalLink?: boolean;
    target?:
    | '_blank'
    | '_self'
    | '_parent'
    | '_top'
    | string;
    exactMatch?: boolean;
    isActiveMatchOptions?: IsActiveMatchOptions;
    function?: (item: SmartrNavigationItem) => void;
    classes?: {
        title?: string;
        subtitle?: string;
        icon?: string;
        wrapper?: string;
    };
    icon?: string;
    badge?: {
        title?: string;
        classes?: string;
    };
    children?: SmartrNavigationItem[];
    meta?: any;
}

export type SmartrVerticalNavigationAppearance =
    | 'default'
    | 'compact'
    | 'dense'
    | 'thin';

export type SmartrVerticalNavigationMode =
    | 'over'
    | 'side';

export type SmartrVerticalNavigationPosition =
    | 'left'
    | 'right';

export interface Navigation {
    default: SmartrNavigationItem[];
}
