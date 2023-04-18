import { ModuleWithProviders, NgModule } from '@angular/core';
import { INVENTORY_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class InventoryManagementConfigModule {
  static forRoot(): ModuleWithProviders<InventoryManagementConfigModule> {
    return {
      ngModule: InventoryManagementConfigModule,
      providers: [INVENTORY_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
