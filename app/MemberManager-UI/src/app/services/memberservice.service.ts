import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/Rx';
import {Observable} from 'rxjs/Rx'

import { Member } from '../components/member/member.component';

@Injectable()
export class MemberService {

  server_url = 'http://localhost:55648/api/member';
  serviceData = null;

  constructor(private http: Http) { 

  }

  private extractData(res) {

    if (res.status < 200 || res.status >= 300) {
      throw new Error('Bad response status: ' + res.status);
    }

    // console.log(res.json());
    this.serviceData = (res.json());
    return this.serviceData || {};
  }

  loaddata(): Observable<any> {
    return this.http.get(this.server_url)
      .map(this.extractData);
  }

}
