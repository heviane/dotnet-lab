namespace HelloWorld;

/// <summary>
/// Uma classe responsável por gerar saudações.
/// </summary>
public class Greeter
{
    /// <summary>
    /// Exibe uma saudação personalizada no console.
    /// </summary>
    /// <param name="name">O nome a ser saudado.</param>
    public void SayHello(string name)
    {
        // Se o nome for nulo ou vazio, usa um valor padrão.
        string finalName = string.IsNullOrWhiteSpace(name) ? "Mundo" : name;
        Console.WriteLine($"Olá, {finalName}!");
    }
}
