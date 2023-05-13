import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Entity } from 'app/core/Services/proxy.service';

@Component({
    selector: 'building-selector',
    templateUrl: './building-selector.component.html',
    styleUrls: ['./building-selector.component.scss']
})
export class BuildingSelectorComponent implements OnInit {

    @Input() oEntity: Entity;
    @Input() isSmallSelector: boolean;
    @Output() entityClickedEventEmitter = new EventEmitter<Entity>();

    oList_Entity: Entity[] = [];

    constructor(
        private CmSvc: CommonService,
    ) { }

    ngOnInit() {
        this.Set_Entity_List();
    }

    Set_Entity_List() {
        this.oList_Entity = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.filter(oEntity => oEntity.SITE_ID == this.oEntity.SITE_ID);
    }

    entityClicked(i_Entity: Entity) {
        if (i_Entity.ENTITY_ID != this.oEntity.ENTITY_ID) {
            localStorage.setItem('pinnedEntityId', JSON.stringify(i_Entity.ENTITY_ID));
            this.entityClickedEventEmitter.emit(i_Entity);
        }
    }

}
