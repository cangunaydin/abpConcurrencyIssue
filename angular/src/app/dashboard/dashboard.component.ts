import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'Doohlink.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'Doohlink.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
