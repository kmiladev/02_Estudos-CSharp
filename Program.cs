using _02_Estudos.Models; // ONDE ESTÁ LOCALIZADO MINHA CLASSE QUE ESTÁ SENDO INSTANCIADA; 

Pessoa pessoa1 = new Pessoa(); // instanciar a classe Pessoa, variavel criada para ser manipulada.

pessoa1.Nome = "Camila";
pessoa1.Idade = 39;
pessoa1.Altura = 1.59;
// passando os dados da pessoa1 / sempre que quero dar atributos, chamar método usar . "ponto" (variável.solicitação)
pessoa1.Apresentar();
// método da pessoa1

// Pessoa é a classe que eu quero instanciar.
// pessoa1 é uma variavel Eu posso escolher o nome que eu quero. 
// new Pessoa() - classe instanciada, objeto existente.


DateTime dataAtual = DateTime.Today.AddDays(5); // DateTime não é uma classe, é um tipo Struct