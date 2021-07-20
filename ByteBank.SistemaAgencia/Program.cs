using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContasCorrente lista = new ListaDeContasCorrente();
            lista.Adicionar(new ContaCorrente(1234, 12345));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 12345));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 43215));
            lista.Adicionar(new ContaCorrente(1234, 85674));
            lista.Adicionar(new ContaCorrente(1234, 12345));


            /*ContaCorrente[] contas = new ContaCorrente[3];
            contas[0] = new ContaCorrente(1234, 123456);
            contas[1] = new ContaCorrente(4321, 431276);
            contas[2] = new ContaCorrente(1234, 542354);*/

            /*ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(1234, 123456),
	            new ContaCorrente(4321, 431276),
	            new ContaCorrente(1234, 542354),
            };
            

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }*/

            Console.ReadLine();
        }
    }
}
