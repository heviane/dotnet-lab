namespace Examples.Format;

/// <summary>
/// Esta classe contém exemplos práticos de como combinar strings em C#
/// usando concatenação e interpolação.
/// </summary>
public class FormatString
{
    /// <summary>
    /// Método principal que executa todos os exemplos de formatação de string.
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("--- Executando Exemplos de Formatação de Strings ---");
        ExecutarExemploConcatenacao();
        ExecutarExemploInterpolacao();
        Console.WriteLine("--- Fim dos Exemplos ---");
    }

    /// <summary>
    /// Demonstra a concatenação de strings usando o operador '+'.
    /// </summary>
    public static void ExecutarExemploConcatenacao()
    {
        Console.WriteLine("\n--- Exemplo de Concatenação ---");

        string nome = "Maria";
        string sobrenome = "Silva";
        string nomeCompleto = "Nome: " + nome + " " + sobrenome;

        Console.WriteLine(nomeCompleto);
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstra a interpolação de strings usando o prefixo '$'.
    /// </summary>
    public static void ExecutarExemploInterpolacao()
    {
        Console.WriteLine("--- Exemplo de Interpolação ---");

        string produto = "Laptop";
        double preco = 4500.50;
        int quantidade = 2;
        string mensagem = $"Produto: {produto}, Preço: {preco:C}, Quantidade: {quantidade}";

        Console.WriteLine(mensagem);
        Console.WriteLine();
    }
}
