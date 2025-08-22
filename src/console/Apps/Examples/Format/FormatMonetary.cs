using System.Globalization;

namespace Examples.Format;

/// <summary>
/// Esta classe contém exemplos práticos de como formatar valores monetários em C#.
/// </summary>
public class FormatMonetary
{
    /// <summary>
    /// Método principal que executa todos os exemplos de formatação monetária.
    /// </summary>
    public static void Run()
    {

        // Setando a cultura do programa (Necessário para quando for diferente da cultura do sistema)
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        Console.WriteLine("--- Executando Exemplos de Formatação Monetária ---");
        DemonstrateInterpolationC();
        DemonstrateToStringC();
        DemonstrateCultureControl();
        DemonstrateCustomDecimalFormats();
        Console.WriteLine("--- Fim dos Exemplos de Formatação Monetária ---");
    }

    /// <summary>
    /// Demonstra a formatação monetária usando interpolação de string com ':C'.
    /// </summary>
    public static void DemonstrateInterpolationC()
    {
        Console.WriteLine("\n--- Exemplo: Interpolação de String com ':C' ---");

        decimal preco = 123.45m;
        string mensagem = $"O preço do produto é {preco:C}";

        Console.WriteLine(mensagem);
        Console.WriteLine("Saída em um sistema pt-BR: O preço do produto é R$ 123,45");
        Console.WriteLine("Saída em um sistema en-US: O preço do produto é $123.45");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstra a formatação monetária usando o método ToString(\"C\").
    /// </summary>
    public static void DemonstrateToStringC()
    {
        Console.WriteLine("--- Exemplo: ToString(\"C\") ---");

        double valorTotal = 1999.99;
        Console.WriteLine(valorTotal.ToString("C"));
        Console.WriteLine("Saída em um sistema pt-BR: R$ 1.999,99");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstra o controle de cultura na formatação monetária.
    /// </summary>
    public static void DemonstrateCultureControl()
    {
        Console.WriteLine("--- Exemplo: Controlando a Cultura ---");

        decimal valor = 543.21m;

        // Forçar a formatação para o padrão dos Estados Unidos (dólar)
        Console.WriteLine($"Valor em en-US: {valor.ToString("C", new CultureInfo("en-US"))}"); // Saída: $543.21

        // Forçar a formatação para o padrão do Brasil (real)
        Console.WriteLine($"Valor em pt-BR: {valor.ToString("C", new CultureInfo("pt-BR"))}"); // Saída: R$ 543,21
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstra formatações personalizadas para valores com casas decimais.
    /// </summary>
    public static void DemonstrateCustomDecimalFormats()
    {
        Console.WriteLine("--- Exemplo: Formatações Personalizadas com Casas Decimais ---");

        decimal valor = 1234.5678m;

        // Separador fixo e símbolo monetário manual
        Console.WriteLine($"R$ {valor.ToString("0.00")}"); // Saída: R$ 1234.57


        decimal preco = 49.99m;
        Console.WriteLine(preco.ToString("'Preço:' R$ #,##0.00")); // Saída: Preço: R$ 49,99

        Console.WriteLine();
    }
}
