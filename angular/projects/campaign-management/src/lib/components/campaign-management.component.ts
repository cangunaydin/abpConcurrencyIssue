import { Component, OnInit } from '@angular/core';
import { CampaignManagementService } from '../services/campaign-management.service';

@Component({
  selector: 'lib-campaign-management',
  template: ` <p>campaign-management works!</p> `,
  styles: [],
})
export class CampaignManagementComponent implements OnInit {
  constructor(private service: CampaignManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
