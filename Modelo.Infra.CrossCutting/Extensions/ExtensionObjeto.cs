using System;

namespace Modelo.Infra.CrossCutting.Extensions
{
    /// <summary>
    /// Classe de extensoes de objetos
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   27/07/2019
    /// </remarks>
    public static class ExtensionObjeto
    {
        /// <summary>
        /// verifica se um objeto é nulo
        /// </summary>
        /// <param name="objeto">objeto a ser verificado</param>
        /// <returns>retorna true se for nulo ou false caso não seja</returns>
        /// <remarks>
        /// Autor:  Luiz Fernando
        /// Data:   27/07/2019
        /// </remarks>
        public static bool IsNull(this object objeto)
        {
            return objeto == null || objeto == DBNull.Value;
        }

        /// <summary>
        /// verifica se o objeto não é nulo
        /// </summary>
        /// <param name="objeto">objeto a ser verificado</param>
        /// <returns>retorna true se o objeto não for nulo false se o objeto for nulo</returns>
        /// <remarks>
        /// Autor:  Luiz Fernando
        /// Data:   27/07/2019
        /// </remarks>
        public static bool IsNotNull(this object objeto)
        {
            return !objeto.IsNull();
        }
    }
}
