import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SuperloginComponent } from './superlogin/superlogin.component';
import { SuperregistrationComponent } from './superregistration/superregistration.component';
import { InicioComponent } from './inicio/inicio.component';
import { SalasComponent } from './salas/salas.component';
import { SalaschatComponent } from './salaschat/salaschat.component';
import { HabitosComponent } from './habitos/habitos.component';
import { ConsejosComponent } from './consejos/consejos.component';
import { PerfilComponent } from './perfil/perfil.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { Routes,RouterModule } from '@angular/router';



@NgModule({
  declarations: [ SuperloginComponent, SuperregistrationComponent, InicioComponent, SalasComponent, SalaschatComponent, HabitosComponent, ConsejosComponent, PerfilComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    RouterModule,
  ],
  exports: [
    SuperloginComponent,
    SuperregistrationComponent,
    InicioComponent,
    SalaschatComponent,
    SalasComponent,
    HabitosComponent,
    ConsejosComponent,
    PerfilComponent,
  ],
})
export class ComponentsModule { }
