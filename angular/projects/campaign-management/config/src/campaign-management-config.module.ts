import { ModuleWithProviders, NgModule } from '@angular/core';
import { CAMPAIGN_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class CampaignManagementConfigModule {
  static forRoot(): ModuleWithProviders<CampaignManagementConfigModule> {
    return {
      ngModule: CampaignManagementConfigModule,
      providers: [CAMPAIGN_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
