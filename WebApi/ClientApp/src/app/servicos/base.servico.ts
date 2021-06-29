import { HttpHeaders } from "@angular/common/http";

export class BaseServico {

  //protected UrlServiceV1: string = "https://localhost:44320/api/v1/";
    get headers(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }
}
