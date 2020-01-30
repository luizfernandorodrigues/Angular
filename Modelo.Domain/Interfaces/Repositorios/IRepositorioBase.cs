using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Modelo.Domain.Interfaces.Repositorios
{
    /// <summary>
    /// Interface que representa o contrato para efetuar o crud
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   15/05/2019
    /// </remarks>
    /// <typeparam name="TEntity">Classe de entidade</typeparam>
    public interface IRepositorioBase<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(Expression<Func<TEntity, bool>> predicado);
        IEnumerable<TEntity> ObterTudo(Expression<Func<TEntity, bool>> predicado = null);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
    }
}
