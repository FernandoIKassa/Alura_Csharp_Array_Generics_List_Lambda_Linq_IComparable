using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContasCorrente
    {
        private ContaCorrente[] _contas;
        /// <summary>
        /// Próxima posicao do array em que pode-se adicionar um item
        /// </summary>
        private int _proximaPosicao;
        public ListaDeContasCorrente(int capacidadeInicial = 5)
        {
            _contas = new ContaCorrente[5];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente contaASerAdicionada)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {contaASerAdicionada.Agencia}/{contaASerAdicionada.Numero}");
            _contas[_proximaPosicao] = contaASerAdicionada;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_contas.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _contas.Length * 2;
            Console.WriteLine("Aumentando capacidade da lista!");
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            for (int i = 0; i < _contas.Length; i++)
            {
                novoArray[i] = _contas[i];
            }

            _contas = novoArray;
        }

    }
}