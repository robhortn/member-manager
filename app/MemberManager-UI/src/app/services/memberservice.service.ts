import { Member } from './../models/member';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import 'rxjs/Rx/';
import { Observable } from 'rxjs/Observable';

const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

@Injectable()
export class MemberService {

  server_url = 'http://localhost:55648/api/';
  serviceData = null;

  constructor(private http: HttpClient) {

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
    // return this.serviceData;
    return this.http.get(this.server_url + 'member/4');
  }

  getMembers(member: Member): Observable<any> {
    // return this.serviceData;
    const url = this.server_url + 'member/find';
    const body = JSON.stringify(member);
    return this.http.post(url, body, httpOptions);
  }

  testCall() {
    // return this.serviceData;
    const url = this.server_url + 'put';
    const body = JSON.stringify('{"Id": "4"}');
    return this.http.put(url, body, httpOptions);
  }
}
