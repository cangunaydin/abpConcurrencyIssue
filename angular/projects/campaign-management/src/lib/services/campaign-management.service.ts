import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class CampaignManagementService {
  apiName = 'CampaignManagement';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/CampaignManagement/sample' },
      { apiName: this.apiName }
    );
  }
}
