import { Component, OnInit } from "@angular/core";
import { Pais } from "../../modelo/cadastro/logradouro/pais";
import { PaisServico } from "../../servicos/cadastro/logradouro/pais.servico";

@Component({
  selector: "pesquisa-produto",
  templateUrl: "./pesquisa.pais.component.html",
  styleUrls: ["./pesquisa.pais.component.html"],
})
export class PesquisaPaisComponent implements OnInit {
  public paises: Pais[];

  ngOnInit(): void {}

  constructor(private paisServico: PaisServico) {
    this.paisServico.obterPaises().subscribe(
      (data) => {
        this.paises = data;
      },
      (erro) => {
        console.log("Ocorreu um erro: " + erro.error);
      }
    );
  }
}
