import { IEntidade } from "../../IEntidade";

export class Pais implements IEntidade {
    id: number;
    nome: string;
    codigo: number;
    observacao: string
}
