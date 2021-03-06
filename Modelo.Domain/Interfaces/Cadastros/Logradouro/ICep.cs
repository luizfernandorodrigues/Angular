﻿using Modelo.Domain.Entidades.Cadastros.Logradouro;

namespace Modelo.Domain.Interfaces.Cadastros.Logradouro
{
    public interface ICep : IEntidade
    {
        string CodigoEnderecamentoPostal { get; set; }
        long Cidade_Id { get; set; }
        Cidade Cidade { get; set; }
    }
}
