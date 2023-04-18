import { Component, OnInit } from '@angular/core';
import { InventoryManagementService } from '../services/inventory-management.service';

@Component({
  selector: 'lib-inventory-management',
  template: ` <p>inventory-management works!</p> `,
  styles: [],
})
export class InventoryManagementComponent implements OnInit {
  constructor(private service: InventoryManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
