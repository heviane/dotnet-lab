using System;
using System.IO;

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

        // Path.Combine é a forma mais segura de montar caminhos de arquivo
        string fullPath = Path.Combine(directoryPath, fileName);
        Console.WriteLine($"\nTentando ler o arquivo em: {Path.GetFullPath(fullPath)}");

        try
        {
            string[] lines = File.ReadAllLines(fullPath);

            Console.WriteLine("\n--- Início do Conteúdo do Arquivo ---");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("--- Fim do Conteúdo do Arquivo ---\n");
        }
        catch (FileNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERRO: O arquivo '{fileName}' não foi encontrado no diretório '{directoryPath}'.");
            Console.ResetColor();
            Console.WriteLine("Verifique se o nome do arquivo foi digitado corretamente.");
        }
        catch (Exception ex) // Captura outras exceções, exceções genéricas (ex: permissão de acesso)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\nOcorreu um erro inesperado ao tentar ler o arquivo: {ex.Message}");
            Console.ResetColor();
        }
        finally
        {
            Console.WriteLine("\n--- Fim da execução do programa. ---");
        }
    }
}
