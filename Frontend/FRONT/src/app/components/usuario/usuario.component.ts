import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/Models/Usuario';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {

  nome!: string;
  dataNascimento!: Date;
  usuarios!: Usuario;
  constructor(
    private http: HttpClient,
    private router: Router,
  ) { }

  ngOnInit(): void {

  }

  cadastrar(): void{
    let usuario: Usuario ={
      nome: this.nome,
      dataNascimento: this.dataNascimento,
    };
    this.http.post<Usuario>("https://localhost:5001/api/usuario/cadastrar", usuario)
  .subscribe({
    next:(usuarios) =>{
      this.usuarios = usuarios;
    } 
  })
  }

  

}
