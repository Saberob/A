import { Component, OnInit } from '@angular/core';

interface IUsuario {
  id: any;
  email: string;
  password: string;
}


@Component({
  selector: 'app-superlogin',
  templateUrl: './superlogin.component.html',
  styleUrls: ['./superlogin.component.css']
})
export class SuperloginComponent implements OnInit {

  constructor() { }

  user: IUsuario;

  ngOnInit() {
    this.user = <IUsuario>{};
  }

  email: string;


}
