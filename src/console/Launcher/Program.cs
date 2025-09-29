﻿using System.Diagnostics;

/// <summary>
/// Representa um projeto que pode ser executado pelo Launcher.
/// Usar um 'record' é uma forma concisa de criar um objeto imutável para guardar dados.
/// </summary>
public record Project(string Name, string Path);

class LauncherApp
{
    /// <summary>
    /// Ponto de entrada principal do Launcher.
    /// </summary>
    static void Main(string[] args)
    {
        // Descobre os projetos dinamicamente, lendo os diretórios.
        var projects = DiscoverProjects();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("      🚀 .NET Lab Launcher 🚀      ");
            Console.WriteLine("===================================");
            Console.WriteLine("Escolha um projeto para executar:");

            for (int i = 0; i < projects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {projects[i].Name}");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("0. Sair do Launcher");
            Console.WriteLine("===================================");
            Console.Write("Digite sua opção: ");

            string? choice = Console.ReadLine();

            if (int.TryParse(choice, out int projectIndex) && projectIndex > 0 && projectIndex <= projects.Count)
            {
                RunProject(projects[projectIndex - 1]);
            }
            else if (choice == "0")
            {
                Console.WriteLine("Até mais!");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
        }
    }

    /// <summary>
    /// Descobre projetos de console na pasta Apps dinamicamente.
    /// </summary>
    /// <returns>Uma lista de projetos encontrados.</returns>
    static List<Project> DiscoverProjects()
    {
        var launcherPath = AppDomain.CurrentDomain.BaseDirectory;
        // O caminho base é .../bin/Debug/net9.0, então precisamos subir 4 níveis
        // para chegar em 'src/console/' e então acessar 'Apps'.
        // ../../../.. -> src/console/
        var appsPath = Path.GetFullPath(Path.Combine(launcherPath, "..", "..", "..", "..", "Apps"));

        if (!Directory.Exists(appsPath))
        {
            return new List<Project>();
        }

        return Directory.GetFiles(appsPath, "*.csproj", SearchOption.AllDirectories)
                        // Usamos o caminho absoluto (a variável 'proj' já contém o caminho completo) para o arquivo de projeto.
                        // Isso é mais robusto do que calcular um caminho relativo,
                        // pois funciona independentemente do diretório de trabalho do processo.
                        .Select(proj => new Project(Name: Path.GetFileNameWithoutExtension(proj), Path: proj))
                        .OrderBy(p => p.Name)
                        .ToList();
    }

    /// <summary>
    /// Inicia um novo processo para executar o projeto selecionado via 'dotnet run'.
    /// Ao final, oferece a opção de reiniciar o projeto ou voltar ao menu principal.
    /// </summary>
    /// <param name="project">O projeto a ser executado.</param>
    static void RunProject(Project project)
    {
        bool restartApp;
        do
        {
            Console.Clear();
            Console.WriteLine($"Executando: {project.Name}...");
            Console.WriteLine(new string('-', 50));

            var processInfo = new ProcessStartInfo("dotnet", $"run --project \"{project.Path}\"");
            var process = Process.Start(processInfo);
            process?.WaitForExit(); // Aguarda o processo do projeto finalizar.

            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"\nExecução de '{project.Name}' finalizada.");
            Console.WriteLine("\nPressione [R] para reiniciar ou qualquer outra tecla para voltar ao menu do Launcher.");

            var key = Console.ReadKey();
            restartApp = (key.Key == ConsoleKey.R);

        } while (restartApp);
    }
}
