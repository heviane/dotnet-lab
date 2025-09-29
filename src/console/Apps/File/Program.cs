using System;
using System.IO;
using File;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=============== Demonstração de Leitura de Arquivo ===============");

        const string directoryPath = "data";

        Console.Write($"\nDigite o nome do arquivo (com extensão) que está no diretório '{directoryPath}' (ex: example1.txt): ");
        string? fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Nome do arquivo inválido. Encerrando.");
            return;
        }

        string fullPath = Path.Combine(directoryPath, fileName);
        Console.WriteLine($"\nTentando ler o arquivo em: {Path.GetFullPath(fullPath)}");

        var reader = new ReadingFile();
        var (success, lines, error) = reader.ReadFile(fullPath); // Desconstrução da tupla retornada.

        if (success)
        {
            Console.WriteLine("\n--- Início do Conteúdo do Arquivo ---");
            // O operador '!' (null-forgiving) informa ao compilador que 'lines' não será nulo aqui.
            foreach (string line in lines!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("--- Fim do Conteúdo do Arquivo ---\n");
        }
        else
        {
            // Trata o erro com base no tipo da exceção retornada
            if (error is FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nERRO: O arquivo '{fileName}' não foi encontrado no diretório '{directoryPath}'.");
                Console.ResetColor();
                Console.WriteLine("Verifique se o nome do arquivo foi digitado corretamente.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nOcorreu um erro inesperado ao tentar ler o arquivo: {error?.Message}");
                Console.ResetColor();
            }
        }

        Console.WriteLine("\n--- Fim da execução do programa. ---");
    }
}
