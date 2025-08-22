using Models;
using Models.Exceptions;
using System;

public class BankAccountApp
{
    public void Run()
    {
        Console.WriteLine("--- Executando Demonstração da Conta Bancária ---");

        // Criando uma conta com saldo inicial
        var minhaConta = new ContaBancaria("12345-6", "Heviane Bastos", 100.00m);
        minhaConta.ExibirSaldo();
        Console.WriteLine(new string('-', 20));

        try
        {
            // Operação 1: Depósito válido
            Console.WriteLine("Depositando R$ 50,00...");
            minhaConta.Depositar(50.00m);
            minhaConta.ExibirSaldo();

            // Operação 2: Saque válido
            Console.WriteLine("\nSacando R$ 80,00...");
            minhaConta.Sacar(80.00m);
            minhaConta.ExibirSaldo();

            // Operação 3: Tentativa de saque que vai falhar
            Console.WriteLine("\nTentando sacar R$ 100,00 (mais que o saldo)...");
            minhaConta.Sacar(100.00m); // Esta linha deve lançar a exceção
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERRO: {ex.Message}");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
            Console.ResetColor();
        }
        finally
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Operação finalizada.");
            minhaConta.ExibirSaldo();
        }

        Console.WriteLine("\n--- Demonstração da Conta Bancária Concluída ---");
    }
}
