import { HttpHeaders } from "@angular/common/http";

export class BaseServico {
    get headers(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }
}
