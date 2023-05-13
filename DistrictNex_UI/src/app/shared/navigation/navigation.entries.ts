import { requestOpenDistrictInsightSubject } from 'app/core/Models/constants';

import { SmartrNavigationItem } from './navigation.types';

export const defaultNavigation: SmartrNavigationItem[] = [
    {
        id: 'map',
        title: 'Site Map',
        type: 'basic',
        icon: 'mat_outline:maps_home_work',
        link: '/map',
        tooltip: 'Map',
    },
    {
        id: 'reports',
        title: 'Reports',
        type: 'basic',
        icon: 'heroicons_outline:document-report',
        link: '/reports',
        tooltip: 'Reports',
    },
    {
        id: 'video-ai',
        title: 'Video AI',
        type: 'basic',
        icon: 'heroicons_outline:video-camera',
        link: '/video-ai',
        tooltip: 'Video AI',
    },
    {
        id: 'insights-panel',
        title: 'oidc',
        type: 'basic',
        icon: 'mat_outline:insights',
        tooltip: 'District Insight',
        function: () => { requestOpenDistrictInsightSubject.next() }
    },
];
