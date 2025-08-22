using System.Globalization;
using System.Net;

namespace Examples.Format;

/// <summary>
/// Esta classe contém exemplos práticos de como formatar valores de data e hora (DateTime) em C#.
/// </summary>
public class FormatDateTime
{
    /// <summary>
    /// Método principal que executa todos os exemplos de formatação de DateTime.
    /// </summary>
    public static void Run()
    {
        // Setando a cultura para pt-BR para consistência nos exemplos
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        Console.WriteLine("--- Executando Exemplos de Formatação de DateTime ---");
        DemonstrateStandardFormats();
        DemonstrateCustomFormats();
        DemonstrateCultureInfluence();
        DemonstrateOtherFormats();
        Console.WriteLine("--- Fim dos Exemplos de Formatação de DateTime ---");
    }

    /// <summary>
    /// Demonstra os especificadores de formato padrão para DateTime.
    /// </summary>
    private static void DemonstrateStandardFormats()
    {
        Console.WriteLine("\n--- 1. Formatos Padrão (Standard Formats) ---");
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Data e hora atual: {agora}\n");

        Console.WriteLine($"'d' (Data curta): {agora:d}");
        Console.WriteLine($"'D' (Data longa): {agora:D}");
        Console.WriteLine($"'t' (Hora curta): {agora:t}");
        Console.WriteLine($"'T' (Hora longa): {agora:T}");
        Console.WriteLine($"'f' (Data/hora completa curta): {agora:f}");
        Console.WriteLine($"'F' (Data/hora completa longa): {agora:F}");
        Console.WriteLine($"'g' (Data/hora geral curta): {agora:g}");
        Console.WriteLine($"'G' (Data/hora geral longa): {agora:G}");
        Console.WriteLine($"'o' (Padrão ISO 8601): {agora:o}");
        Console.WriteLine($"'s' (Padrão classificável): {agora:s}");
    }

    /// <summary>
    /// Demonstra especificadores de formato personalizados para DateTime.
    /// </summary>
    private static void DemonstrateCustomFormats()
    {
        Console.WriteLine("\n--- 2. Formatos Personalizados (Custom Formats) ---");
        DateTime evento = new DateTime(2024, 12, 25, 20, 0, 0);
        Console.WriteLine($"Data do evento: {evento}\n");

        Console.WriteLine($"Formato brasileiro (dd/MM/yyyy HH:mm): {evento.ToString("dd/MM/yyyy HH:mm")}");
        Console.WriteLine($"Formato americano (MM/dd/yy h:mm tt): {evento.ToString("MM/dd/yy h:mm tt", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Formato para logs (yyyy-MM-dd_HH-mm-ss): {evento.ToString("yyyy-MM-dd_HH-mm-ss")}");
        Console.WriteLine($"Formato por extenso: {evento.ToString("dddd, dd 'de' MMMM 'de' yyyy")}");
    }

    /// <summary>
    /// Demonstra como a cultura (CultureInfo) afeta a formatação da data.
    /// </summary>
    private static void DemonstrateCultureInfluence()
    {
        Console.WriteLine("\n--- 3. Influência da Cultura (CultureInfo) ---");
        DateTime data = new DateTime(2025, 1, 30);

        Console.WriteLine($"Padrão (pt-BR): {data.ToString("D", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"Inglês (en-US): {data.ToString("D", new CultureInfo("en-US"))}");
        Console.WriteLine($"Francês (fr-FR): {data.ToString("D", new CultureInfo("fr-FR"))}");
    }

    private static void DemonstrateOtherFormats()
    {
        Console.WriteLine("\n--- 4. Outras Formatações de Data e Hora ---");

        // DateTime parsedDateTime = DateTime.Parse("2023-10-25T14:30:55");
        // DateTime parsedDateTime = DateTime.TryParse("2023-10-25T14:30:55", out DateTime result) ? result : DateTime.MinValue;
        // DateTime parsedDateTime = DateTime.TryParseExact("2023-10-25T14:30:55", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) ? result : DateTime.MinValue;

        bool sucesso = DateTime.TryParseExact(
            "15/08/2024 18:45",
            "dd/MM/yyyy HH:mm",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime parsedDateTime
        );
        Console.WriteLine($"Conversão bem-sucedida? {sucesso} - Data e hora analisada: {parsedDateTime}");
        Console.WriteLine($"Short Date: {parsedDateTime.ToShortDateString()}"); // Formato curto
        Console.WriteLine($"Long Date: {parsedDateTime.ToLongDateString()}");  // Formato longo
        Console.WriteLine($"Short Time: {parsedDateTime.ToShortTimeString()}"); // Formato curto
        Console.WriteLine($"Long Time: {parsedDateTime.ToLongTimeString()}");  // Formato longo
    }
}
