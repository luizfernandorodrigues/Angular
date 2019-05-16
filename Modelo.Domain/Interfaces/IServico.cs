using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Modelo.Domain.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo serviço
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   15/05/2019
    /// </remarks>
    /// <typeparam name="TEntity"></typeparam>
    public interface IServico<TEntity> where TEntity : Entidades.EntidadeAbstrata
    {
        TEntity Adicionar<T>(TEntity entity) where T : AbstractValidator<TEntity>;
        TEntity Alterar<T>(TEntity entity) where T : AbstractValidator<TEntity>;
        void Remover(TEntity entity);
        TEntity ObterPorId(Expression<Func<TEntity, bool>> predicado);
        IEquatable<TEntity> ObterTudo(Expression<Func<TEntity, bool>> predicado = null);

    }
}
