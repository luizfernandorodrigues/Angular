"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.BaseServico = void 0;
var http_1 = require("@angular/common/http");
var BaseServico = /** @class */ (function () {
    function BaseServico() {
    }
    Object.defineProperty(BaseServico.prototype, "headers", {
        //protected UrlServiceV1: string = "https://localhost:44320/api/v1/";
        get: function () {
            return new http_1.HttpHeaders().set('content-type', 'application/json');
        },
        enumerable: false,
        configurable: true
    });
    return BaseServico;
}());
exports.BaseServico = BaseServico;
//# sourceMappingURL=base.servico.js.map