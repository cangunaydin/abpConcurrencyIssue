import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CampaignManagementComponent } from './components/campaign-management.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: CampaignManagementComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CampaignManagementRoutingModule {}
