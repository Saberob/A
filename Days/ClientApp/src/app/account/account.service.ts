import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IUserInfo } from './user-info';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  // pass : Aa123456!

  private apiURL = this.baseUrl + "api/account";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  create(userInfo: IUserInfo): Observable<any> {
    return this.http.post<any>(this.apiURL + "/Create", userInfo);
  }

  logIn(userInfo: IUserInfo): Observable<any> {
    return this.http.post<any>(this.apiURL + "Login", userInfo);
  }

  getToken(): string {
    return localStorage.getItem("token");
  }

  getExpirationToken(): string {
    return localStorage.getItem("tokenExpiration");
  }

  logOut() {
    localStorage.removeItem("token");
    localStorage.removeItem("tokenExpiration");
  }

  IsLoged(): boolean {
    var exp = this.getExpirationToken();

    if (!exp) { // no existe el token
      return false;
    }

    var now = new Date().getTime();
    var dateExp = new Date(exp);

    if (now >= dateExp.getTime()) {
      localStorage.removeItem("token");
      localStorage.removeItem("tokenExpiration");
      return false;
    } else {
      return true;
    }
  }
}
