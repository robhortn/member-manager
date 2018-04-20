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

  constructor(private memberService: MemberService) {

  }

  ngOnInit() {
    // this.memberService.loaddata().subscribe(data => {
    //   this.currentMember = data;
    // });
    this.memberSearchQuery.Id = 0;
    this.memberService.getMembers(this.memberSearchQuery).subscribe(data => {
      this.members = data;
    });
  }
}
