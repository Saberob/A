import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './paginas/login/login.component';
import { RegistrationComponent } from './paginas/registration/registration.component';
import { ComponentsModule } from './components/components.module';
import { SuperloginComponent } from './components/superlogin/superlogin.component';
import { ConsejosComponent } from './components/consejos/consejos.component';
import { HabitosComponent } from './components/habitos/habitos.component';
import { SalasComponent } from './components/salas/salas.component';
import { SalaschatComponent } from './components/salaschat/salaschat.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { PerfilComponent } from './components/perfil/perfil.component';

import { AccountService } from './account/account.service';
import { AuthInterceptorService } from './services/auth-interceptor.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    AccountService,
    {
      provide: HTTP_INTERCEPTORS,
      userClass: AuthInterceptorService,
      multi: true
    }
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ComponentsModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: SuperloginComponent, pathMatch: 'full' },
      { path: 'home', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'login', component: LoginComponent },
      { path: 'registration', component: RegistrationComponent },
      { path: 'superlogin', component: SuperloginComponent },
      { path: 'consejocom', component: ConsejosComponent , },
      { path: 'habitoscom', component: HabitosComponent },
      { path: 'salascom', component: SalasComponent },
      { path: 'salaschat', component: SalaschatComponent },
      { path: 'iniciocom', component: InicioComponent },
      { path: 'perfilcom', component: PerfilComponent },

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
