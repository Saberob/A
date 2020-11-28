import { Component } from '@angular/core';


@Component({
  selector: 'login-app',
  templateUrl: './login.component.html',
  styleUrls:['./login.component.css']
})



export class LoginComponent {
  public nombre = "Leo"

  email:string;

  password:string;

  sumar() {
    this.email = this.email+1
  }
  



}
