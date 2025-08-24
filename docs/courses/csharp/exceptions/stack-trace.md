# Stack Trace (ou "pilha de chamadas")

É como um "rastro de migalhas de pão" que o seu programa deixa para trás. Quando um erro (uma exceção) acontece, o stack trace mostra o caminho exato, método por método, que o código percorreu até chegar ao ponto do erro.

Pense nele como um relatório de detetive que responde a duas perguntas cruciais:

- **Onde o erro aconteceu?** (A primeira linha do stack trace geralmente aponta para o arquivo e a linha exata).
- **Como o programa chegou lá?** (As linhas seguintes mostram a sequência de métodos que foram chamados para chegar àquele ponto).
É a ferramenta mais importante para um desenvolvedor depurar um problema, pois ela revela a origem e o contexto do erro.

## Exemplo Prático

Vamos usar o seu arquivo `/src/console/Apps/File/Program.cs` como exemplo. O código atual tenta ler um arquivo que não existe e isso causa uma quebra no programa. Podemos melhorá-lo para capturar o erro e exibir o stack trace de forma controlada, tornando-o um excelente exemplo didático.

```csharp
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=============== Demonstração de Leitura de Arquivo e Stack Trace ===============");

        // O caminho para um arquivo que não existe, para forçar uma exceção.
        string filePath = "data/arquivo_inexistente.txt";

        try
        {
            Console.WriteLine($"\nTentando ler o arquivo: {filePath}");
            // Esta linha irá falhar e lançar uma FileNotFoundException.
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Arquivo lido com sucesso:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERRO: O arquivo não foi encontrado.");
            Console.WriteLine($"Mensagem: {ex.Message}");
            Console.ResetColor();

            Console.WriteLine("\n--- Stack Trace (O 'rastro' do erro): ---");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nO programa continua executando após tratar o erro.");
        }
    }
}
```

Ao executar este código, a saída será algo como:

```plaintext
=============== Demonstração de Leitura de Arquivo e Stack Trace ===============

Tentando ler o arquivo: data/arquivo_inexistente.txt

ERRO: O arquivo não foi encontrado.
Mensagem: Could not find file '.../dotnet-lab/src/console/Apps/File/bin/Debug/net8.0/data/arquivo_inexistente.txt'.

--- Stack Trace (O 'rastro' do erro): ---
   at System.IO.File.ReadAllLines(String path)
   at Program.Main() in /Users/hevianebastos/Library/Mobile Documents/com~apple~CloudDocs/Projects/GitHub/heviane/dotnet-lab/src/console/Apps/File/Program.cs:line 16
------------------------------------------

O programa continua executando após tratar o erro.
```

**Analisando o Stack Trace da saída:**

1. **at Program.Main() in .../File/Program.cs:line 16**: Esta é a parte mais importante para você. Diz que o problema começou no seu método `Main`, no arquivo `Program.cs`, na linha 16.
2. **at System.IO.File.ReadAllLines(String path)**: Informa que o seu método `Main` chamou o método `ReadAllLines` da biblioteca do .NET, e foi dentro dele que o erro foi originalmente detectado.

Em resumo, o **stack trace** é o mapa que leva você diretamente à cena do crime no seu código.
