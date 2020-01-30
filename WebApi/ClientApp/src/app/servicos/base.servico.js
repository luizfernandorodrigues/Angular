"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var http_1 = require("@angular/common/http");
var BaseServico = /** @class */ (function () {
    function BaseServico() {
    }
    Object.defineProperty(BaseServico.prototype, "headers", {
        get: function () {
            return new http_1.HttpHeaders().set('content-type', 'application/json');
        },
        enumerable: true,
        configurable: true
    });
    return BaseServico;
}());
exports.BaseServico = BaseServico;
//# sourceMappingURL=base.servico.js.map