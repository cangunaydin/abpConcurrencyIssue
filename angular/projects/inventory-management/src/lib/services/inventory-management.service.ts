import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class InventoryManagementService {
  apiName = 'InventoryManagement';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/InventoryManagement/sample' },
      { apiName: this.apiName }
    );
  }
}
