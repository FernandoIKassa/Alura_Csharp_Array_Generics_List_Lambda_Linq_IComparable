using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionaVarios<T>(this List<T> listaDeTeiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaDeTeiros.Add(item);
            }
        }
    }
}
