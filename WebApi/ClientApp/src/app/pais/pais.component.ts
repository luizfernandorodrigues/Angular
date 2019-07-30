import { Component } from "@angular/core";

@Component({
  selector:"pais",
  template:"<html><body>{{obterNome()}}</body></html>"
})
export class PaisComponent {
  id: number;
  nome: string;
  observacoes: string;
  codigo: string;
  TimesTamp: Date;


  public obterNome():string {
    return "teste";
  }
}
