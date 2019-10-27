import { Component } from '@angular/core';
import { Usuario } from '../../modelo/usuario/usuario';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "luizfernando_rodrigues12@hotmail.com" && this.usuario.senha == "1234") {
    }
  }
}
