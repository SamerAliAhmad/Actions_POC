import { InjectionToken } from '@angular/core';

export type Layout =
    | 'empty'
    // Horizontal
    | 'centered'
    | 'enterprise'
    | 'material'
    | 'modern'
    // Vertical
    | 'classic'
    | 'classy'
    | 'compact'
    | 'dense'
    | 'futuristic'
    | 'thin';

export interface AppConfig {
    layout: Layout;
    scheme: Scheme;
    theme: Theme;
}

export const SMARTR_APP_CONFIG = new InjectionToken<any>('SMARTR_APP_CONFIG');

// Types
export type Scheme = 'auto' | 'dark' | 'light';
export type Screens = { [key: string]: string };
export type Theme = 'theme-default' | string;
export type Themes = { id: string; name: string }[];

/**
 * AppConfig interface. Update this interface to strictly type your config
 * object.
 */
export interface AppConfig {
    layout: Layout;
    scheme: Scheme;
    screens: Screens;
    theme: Theme;
    themes: Themes;
}

export const appConfig: AppConfig = {
    layout: 'thin',
    scheme: 'light',
    screens: {
        sm: '600px',
        md: '960px',
        lg: '1280px',
        xl: '1440px'
    },
    theme: 'theme-brand',
    themes: [
        {
            id: 'theme-default',
            name: 'Default'
        },
        {
            id: 'theme-brand',
            name: 'Brand'
        },
        {
            id: 'theme-teal',
            name: 'Teal'
        },
        {
            id: 'theme-rose',
            name: 'Rose'
        },
        {
            id: 'theme-purple',
            name: 'Purple'
        },
        {
            id: 'theme-amber',
            name: 'Amber'
        }
    ]
};
