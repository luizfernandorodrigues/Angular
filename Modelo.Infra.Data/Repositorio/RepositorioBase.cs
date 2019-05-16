using Modelo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Modelo.Infra.Data.Repositorio
{
    public class RepositorioBase<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        public RepositorioBase()
        {
                
        }
        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Deletar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public IEquatable<TEntity> ObterTudo(Expression<Func<TEntity, bool>> predicado = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
