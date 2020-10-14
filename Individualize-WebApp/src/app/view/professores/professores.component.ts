import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Professor } from '../../models/Professor';


@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  public professorForm: FormGroup;
  public titulo = 'Listagem de professores';
  public professorSelecionado: Professor;

  public professores = [
    {id:1, nome:'LAURO', disciplina:'matematica'},
    {id:2, nome:'MARCIO', disciplina:'portugues'},
    {id:3, nome:'GARCIA', disciplina:'geografia'}
  ];


  constructor(private fb: FormBuilder) {
    this.criarForm();
  }

  ngOnInit() {
  }

  criarForm(){
    this.professorForm = this.fb.group({
      nome: ['', Validators.required],
      disciplina: ['', Validators.required]
    });
  }

  professorSubmit(){
    console.log(this.professorForm.value);
  }

  professorSelect(professor: Professor){
    this.professorSelecionado = professor;
    this.professorForm.patchValue(professor);
  }

  voltar(){
    this.professorSelecionado=null;
  }


}
