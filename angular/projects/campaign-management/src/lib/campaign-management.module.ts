import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CampaignManagementComponent } from './components/campaign-management.component';
import { CampaignManagementRoutingModule } from './campaign-management-routing.module';

@NgModule({
  declarations: [CampaignManagementComponent],
  imports: [CoreModule, ThemeSharedModule, CampaignManagementRoutingModule],
  exports: [CampaignManagementComponent],
})
export class CampaignManagementModule {
  static forChild(): ModuleWithProviders<CampaignManagementModule> {
    return {
      ngModule: CampaignManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<CampaignManagementModule> {
    return new LazyModuleFactory(CampaignManagementModule.forChild());
  }
}
