using System;
using Models.Exceptions;

namespace Models
{
    public class ContaBancaria
    {
        public string NumeroConta { get; init; } // O 'init' permite que a propriedade seja definida apenas no construtor ou em um inicializador de objeto.
        public string NomeTitular { get; init; }
        public decimal Saldo { get; private set; } // Saldo pode ser alterado depois, então usamos um 'private set' para controlar as modificações através de métodos (Depositar, Sacar).

        public ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial = 0)
        {
            if (string.IsNullOrWhiteSpace(numeroConta)) { throw new ArgumentException("O número da conta não pode ser nulo ou vazio.", nameof(numeroConta)); }
            if (string.IsNullOrWhiteSpace(nomeTitular)) { throw new ArgumentException("O nome do titular não pode ser nulo ou vazio.", nameof(nomeTitular)); }
            if (saldoInicial < 0) { throw new ArgumentOutOfRangeException(nameof(saldoInicial), "O saldo inicial não pode ser negativo."); }

            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0) throw new ArgumentOutOfRangeException(nameof(valor), "O valor do depósito deve ser positivo.");
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado. Novo saldo: {Saldo:C}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0) { throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque deve ser positivo."); }
            if (Saldo < valor) { throw new SaldoInsuficienteException($"Saldo insuficiente. Você tentou sacar {valor:C}, mas seu saldo atual é de {Saldo:C}."); }

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}.");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Conta: {NumeroConta} | Titular: {NomeTitular} | Saldo: {Saldo:C}");
        }
    }
}
