using Examples;
using Examples.Format;

/// <summary>
/// Ponto de entrada para o projeto "Examples".
/// A responsabilidade do Program.cs aqui é orquestrar qual exemplo será executado.
/// </summary>
public class Program
{
    /// <summary>
    /// Representa um item de exemplo que pode ser executado.
    /// Usamos um 'record' para criar um tipo imutável e conciso.
    /// </summary>
    public record ExampleItem(string Category, string Name, Action RunAction);

    static void Main(string[] args)
    {
        // Lista de todos os exemplos disponíveis.
        // Adicione novos exemplos aqui conforme você os cria em suas respectivas pastas.
        var examples = new List<ExampleItem>
        {
            // Formatações
            new ExampleItem("Formatação", "Concatenação e Interpolação", FormatString.Run),
            new ExampleItem("Formatação", "Valores Monetários", FormatMonetary.Run),
            new ExampleItem("Formatação", "Data e Hora (DateTime)", FormatDateTime.Run),

            // Fluxos de Controle
            new ExampleItem("Fluxos", "If-Else - Par ou Ímpar", ParOrImpar.Run),
            new ExampleItem("Fluxos", "Switch Case - Day Of The Week", DayOfTheWeek.Run),
            new ExampleItem("Fluxos", "Switch Case - Plan Recommendation", PlanRecommendation.Run),

            // Adicione mais exemplos aqui:
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("      📚 Exemplos de C# 📚      ");
            Console.WriteLine("===================================");
            Console.WriteLine("Escolha um exemplo para executar:");

            // Agrupa e exibe os exemplos por categoria
            var groupedExamples = examples.GroupBy(e => e.Category).OrderBy(g => g.Key);
            var displayedExamples = new List<ExampleItem>(); // Lista plana para mapear o número escolhido ao exemplo

            int currentDisplayNumber = 1;
            foreach (var group in groupedExamples)
            {
                Console.WriteLine($"\n--- {group.Key} ---");
                foreach (var example in group.OrderBy(e => e.Name))
                {
                    Console.WriteLine($"{currentDisplayNumber}. {example.Name}");
                    displayedExamples.Add(example); // Adiciona à lista plana para seleção
                    currentDisplayNumber++;
                }
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("0. Voltar ao menu principal do Launcher");
            Console.WriteLine("===================================");
            Console.Write("Digite sua opção: ");

            string? choice = Console.ReadLine();

            if (int.TryParse(choice, out int selectedNumber) && selectedNumber > 0 && selectedNumber < currentDisplayNumber)
            {
                var selectedExample = displayedExamples[selectedNumber - 1]; // Obtém o exemplo pelo índice

                Console.Clear();
                Console.WriteLine($"Executando: {selectedExample.Category} - {selectedExample.Name}...");
                Console.WriteLine(new string('=', 50));
                selectedExample.RunAction(); // Executa o exemplo
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de exemplos...");
                Console.ReadKey();
            }
            else if (choice == "0")
            {
                break; // Sai do menu de exemplos
            }
            else
            {
                Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
        }
    }
}
