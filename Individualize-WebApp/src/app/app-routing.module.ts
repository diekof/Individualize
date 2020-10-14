import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AlunosComponent } from './view/alunos/alunos.component';
import { DashboardComponent } from './view/dashboard/dashboard.component';
import { ProfessoresComponent } from './view/professores/professores.component';
import { PaisComponent } from './view/cadastro/endereco/pais/pais.component';


const routes: Routes = [
  {path:'', redirectTo:'dashboard',pathMatch:'full'},
  {path:'professores',component:ProfessoresComponent},
  {path:'alunos',component:AlunosComponent},
  {path:'dashboard',component:DashboardComponent},
  {path:'pais',component:PaisComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
