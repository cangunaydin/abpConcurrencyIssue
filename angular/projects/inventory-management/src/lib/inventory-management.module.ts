import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { InventoryManagementComponent } from './components/inventory-management.component';
import { InventoryManagementRoutingModule } from './inventory-management-routing.module';

@NgModule({
  declarations: [InventoryManagementComponent],
  imports: [CoreModule, ThemeSharedModule, InventoryManagementRoutingModule],
  exports: [InventoryManagementComponent],
})
export class InventoryManagementModule {
  static forChild(): ModuleWithProviders<InventoryManagementModule> {
    return {
      ngModule: InventoryManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<InventoryManagementModule> {
    return new LazyModuleFactory(InventoryManagementModule.forChild());
  }
}
