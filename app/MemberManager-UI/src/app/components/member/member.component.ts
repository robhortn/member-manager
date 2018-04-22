import { Member } from './../../models/member';
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
  currentMember = {};
  memberSearchQuery = new Member();
  testCallReturnMessage = {};

  constructor(private memberService: MemberService) {

  }

  ngOnInit() {
    // this.memberService.loaddata().subscribe(data => {
    //   this.currentMember = data;
    // });
    this.memberSearchQuery.Active = true;
    this.memberService.getMembers(this.memberSearchQuery).subscribe(data => {
      this.members = data;
    // this.memberService.testCall().subscribe(data => {
    //      this.testCallReturnMessage = data.toString;
    });
  }
}
