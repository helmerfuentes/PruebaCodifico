import { HttpClient } from '@angular/common/http';
import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Usuario } from './Models/usuario';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'SPA';
  public usuario:string="";
  public respuesta= <Usuario>{};
  public InformacionConsultada:boolean=false;


constructor(private http:HttpClient) {

}
ConsultarUsuario(){
  this.InformacionConsultada=true
  this.http.get<Usuario>(`https://api.github.com/users/${this.usuario}`)
  .subscribe((res:Usuario)=>{
    this.respuesta=res;
    console.log(this.respuesta.login)
        
    },
    err=>{
      this.respuesta= <Usuario>{};
      
    })
  }

}
