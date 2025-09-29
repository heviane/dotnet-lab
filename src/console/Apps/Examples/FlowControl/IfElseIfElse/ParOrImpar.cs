namespace Examples;

/// <summary>
/// Contém um exemplo de demonstração da estrutura de controle switch-case.
/// Manter exemplos em classes separadas e estáticas é uma ótima prática
/// para organizar o código e facilitar a chamada a partir do Program.cs.
/// </summary>
public static class ParOrImpar
{
    /// <summary>
    /// Executa o exemplo do if - else if - else
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("      Exemplo de If-ElseIf-Else     ");
        Console.WriteLine("===================================");
        Console.WriteLine("Digite um número inteiro positivo para verificar se é par ou ímpar:");
        Console.Write("Sua opção: ");

        string? input = Console.ReadLine();
        int.TryParse(input, out int number);
        Console.Write($"Você digitou: {number}. ");

        if (number < 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo.");
            return;
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }

    }
}
