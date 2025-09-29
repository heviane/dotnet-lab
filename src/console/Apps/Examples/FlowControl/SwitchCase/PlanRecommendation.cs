using System;

public static class PlanRecommendation
{
    public static void Run()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("      Exemplo de Switch-Case       ");
        Console.WriteLine("===================================");
        Console.WriteLine("Digite um plano (basico, intermediario, avancado, premium):");
        Console.Write("Sua opção: ");

        string entrada = Console.ReadLine();

        switch (entrada)
        {
            case "basico":
                Console.WriteLine("Recomendado: plano basico");
                break;
            case "intermediario":
                Console.WriteLine("Recomendado: plano intermediario");
                break;
            case "avancado":
            case "premium":
                Console.WriteLine("Recomendado: plano avancado");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha entre basico, intermediario, avancado ou premium.");
                break;
        }
    }
}
