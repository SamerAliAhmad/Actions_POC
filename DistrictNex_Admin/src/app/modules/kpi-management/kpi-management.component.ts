import { Location } from '@angular/common';
import { MatDrawer } from '@angular/material/sidenav';
import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'kpi-management',
  templateUrl: './kpi-management.component.html',
  styleUrls: ['./kpi-management.component.scss']
})
export class KpiManagementComponent implements OnInit {

  isDrawerOpened: boolean = true;
  @ViewChild('drawer') drawer: MatDrawer;

  drawerMode: 'over' | 'side' = 'side';
  panelList = [
    {
      id: 1,
      name: 'Data Source',
    },
    {
      id: 2,
      name: 'Kpi',
    },
    {
      id: 3,
      name: 'Organization Data Source Kpi',
    },
  ];
  selectedPanel = this.panelList[0];
  constructor(
    private Location: Location,

  ) { }

  ngOnInit(): void {
  }

  goToPanelfromLoc(id): void {
    if (this.panelList.some(x => x.id === id)) {
      this.selectedPanel = this.panelList.filter(x => x.id == id)[0];
    } else {
      this.selectedPanel = this.panelList[0];
    }
    localStorage.setItem('OrgDetailPanel', this.selectedPanel.id.toString());
  }

  goBack(): void {
    this.Location.back();
  }

}
