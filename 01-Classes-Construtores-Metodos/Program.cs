using System.Net.NetworkInformation;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Camila";
p1.Sobrenome = "Melo";

Pessoa p2 = new Pessoa();
p2.Nome = "Sophia";
p2.Sobrenome = "Divina";

Pessoa p3 = new Pessoa("Estevam", "Melo"); // muito mais fácil e economiza linhas


Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso = "Inglês";

cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();

// Produto produto1 = new Produto("Caderno", 19.90m, 15);
// Console.WriteLine($"Nosso estoque atual é de : {produto1}");
// produto1.AdicionarEstoque(5);
// produto1.ObterValorTotal();
// produto1.RemoverEstoque(8);
// minha criação acima com erros.
//Abaixo corrigido:
Produto produto1 = new Produto("Caderno", 19.90m, 15);

Console.WriteLine($"Produto: {produto1.Nome}");
Console.WriteLine($"Preço: {produto1.Preco}");
Console.WriteLine($"Estoque atual: {produto1.Quantidade}");

produto1.AdicionarEstoque(5);

Console.WriteLine($"Estoque após adicionar 5: {produto1.Quantidade}");

produto1.RemoverEstoque(8);

Console.WriteLine($"Estoque após remover 8: {produto1.Quantidade}");

Console.WriteLine($"Valor total do estoque: {produto1.ObterValorTotal()}");

// testanto a classe ContaBancária criada para entendimento do conteúdo estudado.

ContaBancaria contaBancaria = new ContaBancaria("Camila", 500);

Console.WriteLine($"Titular: {contaBancaria.Titular}");
Console.WriteLine($"Saldo Atual: {contaBancaria.Saldo}");

contaBancaria.Depositar(300);
contaBancaria.Sacar(50);

contaBancaria.ExibirSaldo();

ContaBancaria contaBancaria01 = new ContaBancaria("Estevam", 1000);

Console.WriteLine($"Titular: {contaBancaria01.Titular}");
Console.WriteLine($"Saldo Atual: {contaBancaria01.Saldo}");

contaBancaria01.Depositar(500);
contaBancaria01.ExibirSaldo();

contaBancaria01.Sacar(200);
contaBancaria01.ExibirSaldo();

contaBancaria01.Depositar(0);
contaBancaria01.ExibirSaldo();

cursoDeIngles.ListarAlunos();

