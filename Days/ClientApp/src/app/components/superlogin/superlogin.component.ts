import { Component, OnInit } from '@angular/core';
import { AccountService } from '../../account/account.service';
import { IUserInfo, IUserRInfo } from '../../account/user-info';

interface IUsuario {
  email: string;
  password: string;
  confirmPassword: string;
}


@Component({
  selector: 'app-superlogin',
  templateUrl: './superlogin.component.html',
  styleUrls: ['./superlogin.component.css']
})
export class SuperloginComponent implements OnInit {

  constructor(private accountService: AccountService, private router: Router) { }

  user: IUsuario;

  ngOnInit() {
    this.user = <IUsuario>{};
  }

  email: string;

  logIn() {
    let userInfo: IUserInfo = Object.assign({}, this.user);
    this.accountService.logIn(userInfo).subscribe(token => this.takeToken(token),
      error => this.manageError(error));
  }

  register() {
    let userInfo: IUserRInfo = Object.assign({}, this.user);
    this.accountService.create(userInfo).subscribe(token => this.takeToken(token),
      error => this.manageError(error));
  }

  takeToken(token) {
    localStorage.setItem('token', token.token);
    localStorage.setItem('tokenExpiration', token.expiration);
    this.router.navigate([""]);
  }

  manageError(error) {
    if (error && error.error) {
      alert(error.error([""]));
    }
  }
}
