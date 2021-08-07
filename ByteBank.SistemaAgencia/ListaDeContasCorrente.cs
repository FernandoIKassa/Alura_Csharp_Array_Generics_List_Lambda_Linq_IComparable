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
            _contas = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente contaASerAdicionada)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {contaASerAdicionada.Agencia}/{contaASerAdicionada.Numero}");
            _contas[_proximaPosicao] = contaASerAdicionada;
            _proximaPosicao++;
        }

        public void Remover (ContaCorrente contaASerDeletada)
        {
            int indiceConta = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _contas[i];
                if (contaAtual.Equals(contaASerDeletada))
                {
                    indiceConta = i;
                    break;
                }
            }

            for (int i = indiceConta; i < _proximaPosicao -1; i++)
            {
                _contas[i] = _contas[i + 1];
            }

            _proximaPosicao--;
            _contas[_proximaPosicao] = null;
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

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _contas[i];
                Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }
        /// <summary>
        /// Retorna conta corrente do índice informado
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public ContaCorrente GetItemNoIndice(int indice)
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

        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            foreach (ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }
        }
    }
}