using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    /* Essa classe foi criada apenas como um exercício de fixação adicional para compreender e fixar os conceiotos da Etapa 1.
       
       Propriedades que devem existir: Nome, Preco, Quantidade;
       Regras: Nome não pode ser vazio.
               Preco não pode ser negativo.
               Quantidade não pode ser negativa.

       Métodos: AdicionarEstoque(int quantidade)
                RemoverEstoque(int quantidade)
                ObterValorTotal() com retorno Preco x Quantidade

      Construtor: criar o construtor que permita fazer: 

      Produto produto = new Produto("Caderno", 25.90, 10)
    */
    public class Produto
    {
        // construtor que eu vou criar
        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            
        }
        //campos privados para utilizar no get e no set.                
        private string _nome;
        private decimal _preco;
        private int _quantidade;

        //propriedades
        public string Nome
        {
            get => _nome.ToUpper();
            // porque não posso deixar apenas GET, tenho que passar algo pra ele também?
            set

            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public decimal Preco
        {
            get => _preco;

            set
            {
                if (value < 0)
                {

                    throw new ArgumentException("Valor não pode ser menor que ZERO");
                }
                _preco = value;
            }
        }
        public int Quantidade
        {
            get => _quantidade; // esse campo representa o meu estoque atual que vai ser designado para a propriedade Quantidade.
            // Quando alguém pedir Quantidade, será devolvido o valor armazenado em _quantidade.

            set
            {
                if (value < 0)
                {

                    throw new ArgumentException("Quantidade não pode ser menor que ZERO");
                }
                _quantidade = value;
            }
        }

        //métodos
        // public int AdicionarEstoque(int quantidade)
        // {
        //     return Quantidade.Add(quantidade);
        // }
        // acima escrevi o método de forma incorreta, o certo é retornar um voidv porque ele está fazendo uma ação.

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > Quantidade) // se quantidade a ser removida for maior que meu estoque atual dar erro. (eu poderia colocar _quantidade no lugar de Quantidade?)
            {
                throw new ArgumentException("Quantidade informada maior que o estoque atual.");
            }
            Quantidade -= quantidade;


        }
        public decimal ObterValorTotal()
        {
            return Preco * Quantidade;
        }


    }
}