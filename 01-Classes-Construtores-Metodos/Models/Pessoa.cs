using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    { // meu construtor // logo abaixo da classe por padrão.
        public Pessoa() // construtor 1 que não recebe nenhum parametro 
        {

        }

        public Pessoa(string nome, string sobrenome) // construtor 2 que contém parametro (nome e sobrenome, que é recebido pelas propriedades Nome, Sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome; //campo - valor que vai armazenar o nome. nao recebe get e set.
        private int _idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            // posso simplesmente usar : get=>_nome.ToUpper(); body expressions 

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;

            }


        }


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
