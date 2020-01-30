import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { Pais } from "../../../modelo/cadastro/logradouro/pais";

@Injectable({
    providedIn: 'root'
})
export class PaisServico implements OnInit {
    private _baseUrl: string;
    public paises: Pais[];

    get headers(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    ngOnInit(): void {
        this.paises = [];
    }

    public obterPaises(): Observable<Pais[]> {
        return this.http.get<Pais[]>(this._baseUrl + 'api/pais/');
    }

    public obterPais(idPais: number): Observable<Pais> {
        return this.http.get<Pais>(this._baseUrl + 'api/pais/');
    }

    public cadastrar(pais: Pais): Observable<Pais> {
        return this.http.post<Pais>(this._baseUrl + 'api/pais/cadastrar', JSON.stringify(pais), { headers: this.headers });
    }

    public salvar(pais: Pais): Observable<Pais> {
        return this.http.post<Pais>(this._baseUrl + 'api/pais/salvar', JSON.stringify(pais), { headers: this.headers });
    }

    public excluir(pais: Pais): Observable<Pais> {
        return this.http.post<Pais>(this._baseUrl + 'api/pais/excluir', JSON.stringify(pais), { headers: this.headers });
    }

}
