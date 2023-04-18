import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { CampaignManagementComponent } from './campaign-management.component';

describe('CampaignManagementComponent', () => {
  let component: CampaignManagementComponent;
  let fixture: ComponentFixture<CampaignManagementComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ CampaignManagementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CampaignManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
