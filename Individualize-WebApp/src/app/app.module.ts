import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AlunosComponent } from './view/alunos/alunos.component';
import { ProfessoresComponent } from './view/professores/professores.component';
import { DashboardComponent } from './view/dashboard/dashboard.component';
import { PaisComponent } from './view/cadastro/endereco/pais/pais.component';

import { NavComponent } from './componentes/nav/nav.component';
import { TituloComponent } from './componentes/titulo/titulo.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';


@NgModule({
  declarations: [
    AppComponent,
      AlunosComponent,
      ProfessoresComponent,
      DashboardComponent,
      PaisComponent,
      NavComponent,
      TituloComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    FormsModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
