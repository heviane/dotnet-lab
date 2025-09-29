namespace Examples;

/// <summary>
/// Contém um exemplo de demonstração da estrutura de controle switch-case.
/// Manter exemplos em classes separadas e estáticas é uma ótima prática
/// para organizar o código e facilitar a chamada a partir do Program.cs.
/// </summary>
public static class DayOfTheWeek
{
    /// <summary>
    /// Executa o exemplo do switch-case.
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("      Exemplo de Switch-Case       ");
        Console.WriteLine("===================================");
        Console.WriteLine("Digite um número de 1 a 7 para ver o dia da semana correspondente:");
        Console.Write("Sua opção: ");

        string? input = Console.ReadLine();
        int.TryParse(input, out int dayNumber);

        string dayName;

        switch (dayNumber)
        {
            case 1: dayName = "Domingo"; break;
            case 2: dayName = "Segunda-feira"; break;
            case 3: dayName = "Terça-feira"; break;
            case 4: dayName = "Quarta-feira"; break;
            case 5: dayName = "Quinta-feira"; break;
            case 6: dayName = "Sexta-feira"; break;
            case 7: dayName = "Sábado"; break;
            default: dayName = "Valor inválido! Por favor, digite um número entre 1 e 7."; break;
        }

        Console.WriteLine(dayName);
    }
}
