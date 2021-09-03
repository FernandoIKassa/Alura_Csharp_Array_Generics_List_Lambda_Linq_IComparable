using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Comparador
{
    class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            // Equivalente
            // return x.Agencia.CompareTo(y.Agencia);

            if (x.Agencia < y.Agencia)
            {
                return -1; // X fica na frente de Y
            }

            if (x.Agencia == y.Agencia)
            {
                return 0; // São equivalentes
            }

            return 1;
        }
    }
}
