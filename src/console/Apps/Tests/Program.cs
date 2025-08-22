using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        // Setando a cultura do programa (Necessário para quando for diferente da cultura do sistema)
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        DemonstrarFormatacaoNumericaWithToString();
        DemonstrarFormatacaoNumericaWithInterpolacao();
        DemonstrarFormatacaoNumericaPersonalizada();
    }

    public static void DemonstrarFormatacaoNumericaWithToString()
    {
        Console.WriteLine("--- Demonstração de Formatação Numérica, Moeda e Percentual com o especificador de formato e o método ToString() ---");

        decimal valor = 1234.5678m;

        Console.WriteLine("\n--- Formato Numérico (N) ---");
        Console.WriteLine($"N0: {valor.ToString("N0")}"); // Output: 1.235
        Console.WriteLine($"N1: {valor.ToString("N1")}"); // Output: 1.234,6
        Console.WriteLine($"N8: {valor.ToString("N8")}"); // Output: 1.234,56780000

        Console.WriteLine("\n--- Formato de Moeda (C) ---");
        Console.WriteLine($"C0: {valor.ToString("C0")}"); // Output: R$ 1.235
        Console.WriteLine($"C1: {valor.ToString("C1")}"); // Output: R$ 1.234,6
        Console.WriteLine($"C8: {valor.ToString("C8")}"); // Output: R$ 1.234,56780000

        Console.WriteLine("\n--- Formato Percentual (P) ---");
        double percentual = 0.456;
        Console.WriteLine($"P0: {percentual.ToString("P0")}"); // Output: 46%
        Console.WriteLine($"P1: {percentual.ToString("P1")}"); // Output: 45,6%
        Console.WriteLine($"P8: {percentual.ToString("P8")}"); // Output: 45,60000000%
        Console.WriteLine("\n-------------------------------------------------------------");
    }

    public static void DemonstrarFormatacaoNumericaWithInterpolacao()
    {
        Console.WriteLine("--- Demonstração de Formatação Numérica, Moeda e Percentual com o especificador de formato e interpolação de strings ---");

        decimal valor = 1234.5678m;

        Console.WriteLine("\n--- Formato Numérico (N) ---");
        Console.WriteLine($"N0: {valor:N0}"); // Output: 1.235
        Console.WriteLine($"N1: {valor:N1}"); // Output: 1.234,6
        Console.WriteLine($"N8: {valor:N8}"); // Output: 1.234,56780000

        Console.WriteLine("\n--- Formato de Moeda (C) ---");
        Console.WriteLine($"C0: {valor:C0}"); // Output: R$ 1.235
        Console.WriteLine($"C1: {valor:C1}"); // Output: R$ 1.234,6
        Console.WriteLine($"C8: {valor:C8}"); // Output: R$ 1.234,56780000

        Console.WriteLine("\n--- Formato Percentual (P) ---");
        double percentual = 0.456;
        Console.WriteLine($"P0: {percentual:P0}"); // Output: 46%
        Console.WriteLine($"P1: {percentual:P1}"); // Output: 45,6%
        Console.WriteLine($"P8: {percentual:P8}"); // Output: 45,60000000%
        Console.WriteLine("\n-------------------------------------------------------------");
    }

    public static void DemonstrarFormatacaoNumericaPersonalizada()
    {
        Console.WriteLine("--- Demonstração de Formatação Numérica Personalizada ---");

        double numero = 1234.5678;

        // Separador de milhar e duas casas decimais
        Console.WriteLine($"Separador de milhar e 2 casas decimais: {numero.ToString("#,##0.00")}"); // Output: 1.234,57

        // Número fixo de dígitos antes e depois da vírgula
        Console.WriteLine($"Formato fixo: {numero.ToString("00000.0000")}"); // Output: 01234,5678

        // Formato com símbolo personalizado
        Console.WriteLine($"Com símbolo: {numero.ToString("#,##0.00 'unidades'")}"); // Output: 1.234,57 unidades

        // Formato negativo entre parênteses
        double negativo = -9876.543;
        Console.WriteLine($"Negativo entre parênteses: {negativo.ToString("#,##0.00;(#,##0.00)")}"); // Output: (9.876,54)

        int numeroInteiro = 123456;
        Console.WriteLine($"Número inteiro personalizado: {numeroInteiro.ToString("##-##-##")}"); // Output: 123.456

        Console.WriteLine("\n-------------------------------------------------------------");
    }
}
