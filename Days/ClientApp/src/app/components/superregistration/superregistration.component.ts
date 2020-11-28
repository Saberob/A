import { Component, OnInit } from '@angular/core';

interface IPerfil {
  email: string
  password: string
  description: string
  day: number
  month: number
  year: number
}

@Component({
  selector: 'app-superregistration',
  templateUrl: './superregistration.component.html',
  styleUrls: ['./superregistration.component.css']
})
export class SuperregistrationComponent implements OnInit {

  constructor() { }

  perfil: IPerfil;

  ngOnInit() {
    this.perfil = <IPerfil>{};
  }

}
