import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule } from '@angular/router';
import { SmartrVerticalNavigationAsideItemComponent } from 'app/shared/navigation/vertical/components/aside/aside.component';
import { SmartrVerticalNavigationBasicItemComponent } from 'app/shared/navigation/vertical/components/basic/basic.component';
import { SmartrVerticalNavigationCollapsableItemComponent } from 'app/shared/navigation/vertical/components/collapsable/collapsable.component';
import { SmartrVerticalNavigationDividerItemComponent } from 'app/shared/navigation/vertical/components/divider/divider.component';
import { SmartrVerticalNavigationGroupItemComponent } from 'app/shared/navigation/vertical/components/group/group.component';
import { SmartrVerticalNavigationSpacerItemComponent } from 'app/shared/navigation/vertical/components/spacer/spacer.component';
import { SmartrVerticalNavigationComponent } from 'app/shared/navigation/vertical/vertical.component';
import { MatIconReplacerModule } from '../directives/mat-icon-replacer.module';
import { SmartrScrollbarModule } from '../directives/scrollbar/scrollbar.module';

@NgModule({
    declarations: [
        SmartrVerticalNavigationAsideItemComponent,
        SmartrVerticalNavigationBasicItemComponent,
        SmartrVerticalNavigationCollapsableItemComponent,
        SmartrVerticalNavigationDividerItemComponent,
        SmartrVerticalNavigationGroupItemComponent,
        SmartrVerticalNavigationSpacerItemComponent,
        SmartrVerticalNavigationComponent
    ],
    imports: [
        SmartrScrollbarModule,
        CommonModule,
        RouterModule,
        MatButtonModule,
        MatDividerModule,
        MatIconModule,
        MatMenuModule,
        MatTooltipModule,
        MatIconReplacerModule,
    ],
    exports: [
        SmartrVerticalNavigationComponent
    ]
})
export class SmartrNavigationModule {
}
