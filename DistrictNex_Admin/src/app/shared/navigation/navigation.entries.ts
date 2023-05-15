import { SmartrNavigationItem } from './navigation.types';

export const superAdminNavigation: SmartrNavigationItem[] = [
    {
        id: 'home',
        title: 'Dashboard',
        type: 'basic',
        icon: 'heroicons_outline:chart-pie',
        link: '/home',
    },
    {
        id: 'organization-management',
        title: 'Organization Management',
        type: 'basic',
        icon: 'heroicons_outline:library',
        link: '/organization-management',
    },
    {
        id: 'kpi-management',
        title: 'Kpi Management',
        type: 'basic',
        icon: 'heroicons_outline:share',
        link: '/kpi-management',
    },
    {
        id: 'my-organization',
        title: 'My Organization',
        type: 'collapsable',
        icon: 'heroicons_outline:briefcase',
        children: [
            {
                id: 'general-details',
                title: 'General Details',
                type: 'basic',
                link: '/my-organization/general-details'
            },
            {
                id: 'access-control',
                title: 'Organization Access Control',
                type: 'basic',
                link: '/my-organization/access-control'
            },
            {
                id: 'module-access',
                title: 'Organization Module Access',
                type: 'basic',
                link: '/my-organization/module-access'
            },
            {
                id: 'user-quota',
                title: 'User Quota',
                type: 'basic',
                link: '/my-organization/user-quota'
            },
            {
                id: 'user-management',
                title: 'User Managemenet',
                type: 'basic',
                link: '/my-organization/user-management'
            },
            {
                id: 'theme-settings',
                title: 'Theme Settings',
                type: 'basic',
                link: '/my-organization/theme-settings',
            },
            {
                id: 'organization-images',
                title: 'Organization Images',
                type: 'basic',
                link: '/my-organization/organization-images',
            },
            {
                id: 'data-settings',
                title: 'Data Settings',
                type: 'basic',
                link: '/my-organization/data-settings'
            },
        ]
    },
    {
        id: 'video-ai-management',
        title: 'Video AI Management',
        type: 'basic',
        icon: 'heroicons_outline:video-camera',
        link: '/video-ai-management',
    },
    {
        id: 'logs',
        title: 'Logs',
        type: 'basic',
        icon: 'mat_outline:list_alt',
        link: '/logs',
    },
    {
        id: 'default-settings',
        title: 'Default Settings',
        type: 'basic',
        icon: 'heroicons_outline:cog',
        link: '/default-settings',
    },
];
export const organizationAdminNavigation: SmartrNavigationItem[] = [
    {
        id: 'user-management',
        title: 'User Management',
        type: 'basic',
        icon: 'heroicons_outline:library',
        link: '/my-organization/user-management'
    },
    {
        id: 'theme-settings',
        title: 'Theme Settings',
        type: 'basic',
        icon: 'mat_outline:palette',
        link: '/my-organization/theme-settings'
    },
    {
        id: 'organization-images',
        title: 'Organization Images',
        type: 'basic',
        icon: 'mat_outline:image',
        link: '/my-organization/organization-images',
    },
    {
        id: 'logs',
        title: 'Logs',
        type: 'basic',
        icon: 'mat_outline:list_alt',
        link: '/logs',
    },
];
