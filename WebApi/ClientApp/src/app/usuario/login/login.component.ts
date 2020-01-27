import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Usuario } from '../../modelo/usuario/usuario';
import { UsuarioServico } from '../../servicos/usuario/usuario.servico';

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

    public usuario;
    public returnUrl: string;
    public mensagem: string;

    constructor(private router: Router, private activateRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
    }

    ngOnInit(): void {
        this.returnUrl = this.activateRouter.snapshot.queryParams['returnUrl'];
        this.usuario = new Usuario();
    }

    entrar() {
        this.usuarioServico.verificarUsuario(this.usuario).subscribe(
            usuario_json => {
                this.usuarioServico.usuario = usuario_json;
                if (this.returnUrl == null)
                    this.router.navigate(['/']);
                else
                    this.router.navigate([this.returnUrl]);
            },
            err => {
                console.log(err.error);
                this.mensagem = err.error;
            }
        );



        //if (this.usuario.email == "luizfernando_rodrigues12@hotmail.com" && this.usuario.senha == "1234") {
        //    sessionStorage.setItem("usuario-autenticado", "1");
        //    this.router.navigate([this.returnUrl]);
        //}
    }
}
