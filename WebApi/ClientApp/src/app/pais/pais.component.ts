import { Component, OnInit } from "@angular/core";
import { Pais } from "../modelo/cadastro/logradouro/pais";
import { PaisServico } from "../servicos/cadastro/logradouro/pais.servico";

@Component({
    selector: 'pais',
    templateUrl: './pais.component.html',
    styleUrls: ['./pais.component.css']
})
export class PaisComponent implements OnInit {
  public pais: Pais;
  public mensagem: string;


    constructor(private paisServico: PaisServico) {

    }

    ngOnInit(): void {
        this.pais = new Pais();
    }

    public cadastrar() {
        this.paisServico.cadastrar(this.pais)
            .subscribe(
                paisJson => {
                    console.log(paisJson);
                },
                erro => {
                    console.log(erro.error);
                }
            );
    }
}
