using System.Collections.Generic;

namespace Modelo.Infra.CrossCutting.Extensions
{
    /// <summary>
    /// Classe de extensions de lista.
    /// </summary>
    /// <remarks>
    /// Autor   : Luiz Fernando
    /// Data    : 13/04/2020
    /// </remarks>
    public static class ExtensionLista
    {

        public static bool IsNotEmpty<T>(this IList<T> lista)
        {
            if (lista.IsNotNull())
                return lista.Count > 0;
            else
                return false;
        }
    }
}
