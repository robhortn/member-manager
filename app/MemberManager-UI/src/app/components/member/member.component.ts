import { Component, OnInit } from '@angular/core';
import { MemberService } from '../../services/memberservice.service';
import { MergeMapOperator } from 'rxjs/operators/mergeMap';

@Component({
  selector: 'app-member',
  templateUrl: './member.component.html',
  styleUrls: ['./member.component.css']
})
export class MemberComponent implements OnInit {

  members = [];
  currentMember = {
    Id: 0,
    FirstName: 'Place',
    LastName: 'Holder'
  };

  constructor(private memberService: MemberService) {

  }

  ngOnInit() {
    this.memberService.loaddata().subscribe(data => {
      this.currentMember = data;
    });
  }
}
