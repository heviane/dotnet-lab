using System.Diagnostics;

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
        // Define a lista de projetos que o Launcher pode executar.
        // Os caminhos são relativos ao diretório do projeto Launcher.
        var projects = new List<Project>
        {
            new Project("Hello World", "../HelloWorld/HelloWorld.csproj"),
            new Project("Calculadora", "../Apps/Calculator/Calculator.csproj"),

            // ... Revisar e melhorar os projetos abaixos ...
            new Project("Desafios de Loops", "../Loops/Loops.csproj"),
            new Project("Estudos de Classes", "../Classes/Classes.csproj")
            // Adicione novos projetos aqui........................
        };

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
