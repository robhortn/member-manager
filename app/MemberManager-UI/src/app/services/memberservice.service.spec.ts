import { TestBed, inject } from '@angular/core/testing';

import { MemberserviceService } from './memberservice.service';

describe('MemberserviceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MemberserviceService]
    });
  });

  it('should be created', inject([MemberserviceService], (service: MemberserviceService) => {
    expect(service).toBeTruthy();
  }));
});
