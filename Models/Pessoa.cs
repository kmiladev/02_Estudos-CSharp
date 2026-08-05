using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace _02_Estudos.Models // namespáce é a organização das classes. nome do projeto / nome da classe (sempre organizar por afinidade)
{
    public class Pessoa // class indica que é uma classe / Pessoa é o nome da classe, sempre primeira letra maiúscula de cada palavra;
    {
        public string Nome { get; set; } // string é o tipo / Nome é o atributo (usar letra miúscula para atributos/propriedades)
        public int Idade { get; set; } // get - busca valor, set atribui o valor EX. Nome = "Camila" - estou setando o valor , set)
        public double Altura { get; set; }
        public void Apresentar() // Apresentar é o método, ação
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos e {Altura.ToString(CultureInfo.InvariantCulture)} de altura");
            // Classe.Método("parâmetro ou argumento");
            // se eu quiser quebrar a linha no print da tela usar \n
            //Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");
        }
    }
}
// PALAVRAS RESERVADAS NÃO PODEM SER USADAS: public, void, int, class entc.
// CLASSE É UM MODELO DE UM OBJETO QUE VAI SER CRIADO, UM CONCEITO RESERVADO DA VIDA REAL. ISSO É UMA ABSTRAÇÃO EM POO.