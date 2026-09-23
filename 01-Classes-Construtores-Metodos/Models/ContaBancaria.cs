using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models

/* exercicio proposto de fixação. 
Classe: ContaBancaria
Propriedade: Titular / Saldo
Regras:
-Titular não pode ser vazio.
-Saldo não pode ser negativo.
Métodos: Depositar(decimal valor) / Sacar(decimal valor) / ExibirSaldo()
Regras:

Depositar: 
-valor deve ser maior que zero;
-aumenta o saldo.

Sacar: 
-valor deve ser maior que zero;
-não pode sacar mais do que o saldo;
-diminui o saldo.

ExibirSaldo: 
-deve retornar o saldo atual.

Construtor

Deve permitir: ContaBancaria conta = new ContaBancaria("Camila", 500);
*/
{
    public class ContaBancaria
    {
        // contrutor
        public ContaBancaria()
        {
            
        }
        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    
        private string _titular;
        private decimal _saldo;

        public string Titular 
        { 
            get => _titular.ToUpper();

            set
            {
                {
                if( value == "")
                throw new ArgumentException($"Nome do titular não pode ser vazio.");
                }
            _titular = value;
            }
        }
        public decimal Saldo 
        { 
            get => _saldo; 

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O saldo não pode ser menor que 0");
                }
                _saldo = value; 

            }
        }

        public void Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser maior que 'ZERO'");
            }
            // Saldo = (_saldo += valorDeposito); eu havia escrito dessa forma, mas não é necessário, estaria duplicando a propriedade aqui.posso fazer abaixo: 
            Saldo += valorDeposito;
            Console.WriteLine("Depósito realizado com sucesso.");   
            
        }


        public void Sacar(decimal valorSaque)
        {
            if (valorSaque <= 0)
            {
                throw new ArgumentException("Valor do saque deve ser maior que 'ZERO'");
            }
            else if (valorSaque > Saldo)
            {
                throw new ArgumentException("Valor do saque não pode ser maior que o valor do saldo atual");
            }
            //Saldo = (_saldo -= valorSaque);
            Saldo -= valorSaque;
            Console.WriteLine("Saque realizado com sucesso.");
        }
    // os métodos sacar e depositar eu havia criado com tipo decimal, porém eu estava fazendo o calculo sem atribuir. Nesse caso faz mais sentido eu usar void.
    // quando estava usando o decimal eu nao estava alterando o valor do saldo.

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da sua conta é de: {Saldo:C}");
        }
    }

}