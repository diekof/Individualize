import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

import { Aluno } from '../../models/aluno';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  public alunoForm: FormGroup;
  public titulo = 'Listagem de alunos';
  public alunoSelecionado: Aluno;
  public modalRef: BsModalRef;

  public alunos = [
    {id: 1, nome:'Marta', sobrenome:'bugs', telefone:'99999999'},
    {id: 1, nome:'Paula', sobrenome:'bugs', telefone:'99999999'},
    {id: 1, nome:'Laura', sobrenome:'bugs', telefone:'99999999'},
    {id: 1, nome:'Luiza', sobrenome:'bugs', telefone:'99999999'},
    {id: 1, nome:'Lucas', sobrenome:'bugs', telefone:'99999999'},
    {id: 1, nome:'Pedro', sobrenome:'bugs', telefone:'99999999'},
    {id: 1, nome:'Paulo', sobrenome:'bugs', telefone:'99999999'}
  ];

  constructor(private fb: FormBuilder,
    private modalService: BsModalService) {
    this.criarForm();
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  ngOnInit() {
  }

  criarForm(){
    this.alunoForm = this.fb.group({
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['']
    });
  }

  alunoSubmit(){
    console.log(this.alunoForm.value);
  }

  alunoSelect(aluno: Aluno){
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno);
  }

  voltar(){
    this.alunoSelecionado=null;
  }


}
