using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Comparador;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> idades = new List<int>();
            var idades = new List<int>();

            //List<string> nomes = new List<string>();

            //ContaCorrente contas = new ContaCorrente(1234, 43215678);
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(1234, 4312),
                new ContaCorrente(290, 31299),
                new ContaCorrente(1234, 312),
                new ContaCorrente(14, 11232),
                new ContaCorrente(598, 3765)
            };

            var nomes = new List<string>()
            {
                "Zuneide",
                "Mariana",
                "Almeida",
                "Alan"
            };

            idades.AdicionaVarios(1, 2, 99, 32);

            idades.Sort();
            nomes.Sort();
            
            //contas.Sort();
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            /* foreach (var idade in idades)
             {
                 Console.WriteLine(idade);
             }

             foreach (var nome in nomes)
             {
                 Console.WriteLine(nome);
             }*/

            foreach (var conta in contas)
            {
                Console.WriteLine($"Agencia: {conta.Agencia} | Numero: {conta.Numero}");
            }

            Console.ReadLine();
        }

        static void TestaListCollection()
        {
            List<int> idades = new List<int>();

            idades.Add(12);
            idades.Add(2);
            idades.Add(56);

            idades.Remove(2);
        }

        static void TestaListaGenerica()
        {
            Lista<int> idades = new Lista<int>();
            idades.AdicionarVarios(16, 22, 13, 2, 87, 99);
            idades.Remover(99);

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# parte 1", "C# parte 2", "C# parte 3");

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(1234, 56785435), new ContaCorrente(1234, 78464356));
        }
        
        
        static void TestaListaDeContaCorrente()
        {
            ListaDeContasCorrente lista = new ListaDeContasCorrente(capacidadeInicial: 10);

            ContaCorrente contaTeste = new ContaCorrente(99999, 99999);

            /*lista.Adicionar(new ContaCorrente(1234, 12345));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(contaTeste);
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
*/
            lista.AdicionarVarios(
                new ContaCorrente(1234, 111215),
                new ContaCorrente(1234, 732885),
                new ContaCorrente(1234, 832199),
                new ContaCorrente(1234, 321325)
                    );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente conta = lista[i];
                Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            }
        }

        static void TestaArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[3];
            contas[0] = new ContaCorrente(1234, 123456);
            contas[1] = new ContaCorrente(4321, 431276);
            contas[2] = new ContaCorrente(1234, 542354);

             /*ContaCorrente[] contas = new ContaCorrente[]
             {
                new ContaCorrente(1234, 123456),
                new ContaCorrente(4321, 431276),
                new ContaCorrente(1234, 542354),
             };*/


            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }
        }
    }
}
