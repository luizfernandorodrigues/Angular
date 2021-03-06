﻿using Modelo.Domain.Entidades.Acesso;
using Modelo.Domain.Interfaces.Repositorios;

namespace Modelo.Domain.Interfaces.Repositorios.Acesso
{
    /// <summary>
    /// Interface de acesso a dados do objeto usuario
    /// </summary>
    /// <remarks>
    /// Autor   :Luiz Fernando
    /// Data    :26/01/2020
    /// </remarks>
    public interface IRepositorioUsuario : IRepositorioBase<Usuario>
    {
        /// <summary>
        /// Retorna um usuário a partir de um email e senha
        /// </summary>
        /// <param name="senha">Senha do usario cadastrado na base de dados</param>
        /// <param name="email">Email do usuario cadastrado na base de dados</param>
        /// <returns>Retorna um objeto usuario</returns>
        /// <remarks>
        /// Autor   :Luiz Fernando
        /// Data    :26/01/2020
        /// </remarks>
        Usuario Login(string senha, string email);
        
        /// <summary>
        /// Retorna true caso o usuário exista na base atraves da busca peplo e-mail
        /// </summary>
        /// <param name="email">Email do usuario para verificar</param>
        /// <returns>Retorna verdadeiro caso o usuario exista na base de dados</returns>
        /// <remarks>
        /// Autor   :Luiz Fernando
        /// Data    :02/02/2020
        /// </remarks>
        bool VerificaUsuario(string email);
    }
}
