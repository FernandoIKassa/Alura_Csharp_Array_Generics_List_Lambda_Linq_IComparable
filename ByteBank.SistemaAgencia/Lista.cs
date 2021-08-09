using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Lista<T>
    {
        private T[] _contas;
        /// <summary>
        /// Próxima posicao do array em que pode-se adicionar um item
        /// </summary>
        private int _proximaPosicao;
        public Lista(int capacidadeInicial = 5)
        {
            _contas = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(T contaASerAdicionada)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            //Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {contaASerAdicionada.Agencia}/{contaASerAdicionada.Numero}");
            _contas[_proximaPosicao] = contaASerAdicionada;
            _proximaPosicao++;
        }

        public void Remover(T contaASerDeletada)
        {
            int indiceConta = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T contaAtual = _contas[i];
                if (contaAtual.Equals(contaASerDeletada))
                {
                    indiceConta = i;
                    break;
                }
            }

            for (int i = indiceConta; i < _proximaPosicao - 1; i++)
            {
                _contas[i] = _contas[i + 1];
            }

            _proximaPosicao--;
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

            T[] novoArray = new T[novoTamanho];
            for (int i = 0; i < _contas.Length; i++)
            {
                novoArray[i] = _contas[i];
            }

            _contas = novoArray;
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T conta = _contas[i];
                //Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }
        /// <summary>
        /// Retorna conta corrente do índice informado
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _contas[indice];
        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T conta in itens)
            {
                Adicionar(conta);
            }
        }
    }
}
