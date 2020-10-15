import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AlunosComponent } from './view/alunos/alunos.component';
import { DashboardComponent } from './view/dashboard/dashboard.component';
// import { ProfessoresComponent } from './view/professores/professores.component';
// import { PaisComponent } from './view/cadastro/endereco/pais/pais.component';
import { AuthLoginComponent } from './view/auth-login/auth-login.component';
import { MasterComponent } from './view/master/master.component';
import { SampleGuard } from './guards/sample.guard';


// const routes: Routes = [
//   {path:'', redirectTo:'dashboard',pathMatch:'full'},
//   {path:'professores',component:ProfessoresComponent},
//   {path:'alunos',component:AlunosComponent},
//   {path:'dashboard',component:DashboardComponent},
//   {path:'pais',component:PaisComponent},
//   {path:'login',component:AuthLoginComponent}

// ];

const routes: Routes = [
  { path: 'login', component: AuthLoginComponent },
  {
      path: 'master',
      component: MasterComponent,
      canActivate: [SampleGuard],
      children: [
      { path: 'home', component: DashboardComponent },
      { path: 'alunos', component: AlunosComponent },
      ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
