using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Modelo.Infra.Data.Repositorio
{
    /// <summary>
    /// Classe base do repositorio que implementa o contrato de CRUD
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   17/05/2019
    /// </remarks>
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        #region Propriedades
        protected readonly ApiContexto ApiContexto;
        #endregion Propriedades

        #region Métodos Publicos
        public RepositorioBase(ApiContexto apiContexto)
        {
            ApiContexto = apiContexto;
        }
        public void Adicionar(TEntity entity)
        {
            ApiContexto.Set<TEntity>().Add(entity);
            ApiContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            ApiContexto.Set<TEntity>().Update(entity);
            ApiContexto.SaveChanges();
        }

        public void Deletar(TEntity entity)
        {
            ApiContexto.Remove(entity);
            ApiContexto.SaveChanges();
        }

        public TEntity ObterPorId(Expression<Func<TEntity, bool>> predicado)
        {
            return ApiContexto.Set<TEntity>().FirstOrDefault(predicado);
        }

        public IEnumerable<TEntity> ObterTudo(Expression<Func<TEntity, bool>> predicado = null)
        {
            if (predicado != null)
            {
                return ApiContexto.Set<TEntity>().Where(predicado);
            }
            return ApiContexto.Set<TEntity>().AsEnumerable();
        }

        public void Dispose()
        {
            ApiContexto.Dispose();
        }
        #endregion Métodos Publicos
    }
}
