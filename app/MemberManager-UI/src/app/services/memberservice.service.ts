import { Injectable } from '@angular/core';
// import { Http, HttpModule } from '@angular/http';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import 'rxjs/Rx/';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class MemberService {

  server_url = 'http://localhost:55648/api/member/4';
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
    return this.http.get(this.server_url);
  }

}
