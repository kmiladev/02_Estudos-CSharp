using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        //propriedades
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        /* além dessa opção, identica a opção de cima, eu posso utilizar outra opção com retorno: 

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }*/
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        // public void ListarAlunos()
        // {
        //     Console.WriteLine($"Alunos do curso de: {NomeCurso}");
        //     foreach (Pessoa aluno in Alunos)
        //     {
        //         Console.WriteLine(aluno.NomeCompleto);
        //     }
        // }

        // REFATORANDO O MÉTODO LISTARALUNOS()

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {NomeCurso}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "N°" + count + " - " + Alunos[count].NomeCompleto; - formato concatenação, usa sinal de +
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; // usando interpolação - símbolo de dolar
                Console.WriteLine(texto);
                // usei o +1 dentro de {count + 1} para que seja exibido o valor na tela de forma correta, iniciando a lista por 1 e mantendo o ocunt no formato correto para ser lido pelo sistema, que iniica a leitura da lista pelo indice 0.
            }
        }
    }
}