using System;

namespace Models
{
    /// <summary>
    /// Representa uma conta bancária.
    /// O construtor garante que toda conta seja criada com um número e um titular,
    /// prevenindo a existência de contas em estado inválido.
    /// </summary>
    public class ContaBancaria
    {
        // Propriedades essenciais, definidas apenas na criação do objeto.
        // O 'init' permite que a propriedade seja definida apenas no construtor ou em um inicializador de objeto.
        public string NumeroConta { get; init; }
        public string NomeTitular { get; init; }

        // O saldo pode ser alterado depois, então usamos um 'private set' para controlar as modificações através de métodos (Depositar, Sacar).
        public decimal Saldo { get; private set; }

        /// <summary>
        /// Construtor principal. Exige os dados essenciais para criar uma conta válida.
        /// </summary>
        /// <param name="numeroConta">O número da conta. Não pode ser nulo ou vazio.</param>
        /// <param name="nomeTitular">O nome do titular. Não pode ser nulo ou vazio.</param>
        /// <param name="saldoInicial">O saldo inicial da conta (opcional, padrão é 0).</param>
        public ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial = 0)
        {
            // --- Validação (Guard Clauses) ---
            if (string.IsNullOrWhiteSpace(numeroConta))
            {
                throw new ArgumentException("O número da conta não pode ser nulo ou vazio.", nameof(numeroConta));
            }

            if (string.IsNullOrWhiteSpace(nomeTitular))
            {
                throw new ArgumentException("O nome do titular não pode ser nulo ou vazio.", nameof(nomeTitular));
            }

            if (saldoInicial < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(saldoInicial), "O saldo inicial não pode ser negativo.");
            }

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

        public void ExibirSaldo()
        {
            Console.WriteLine($"Conta: {NumeroConta} | Titular: {NomeTitular} | Saldo: {Saldo:C}");
        }
    }
}
