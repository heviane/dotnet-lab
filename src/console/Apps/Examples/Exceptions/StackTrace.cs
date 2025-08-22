using System;

namespace Examples.Exceptions;

/// <summary>
/// Demonstra o conceito de Stack Trace (pilha de chamadas) ao forçar uma exceção em um método aninhado.
/// </summary>
public class StackTrace
{
    public void Run()
    {
        Console.WriteLine("--- Demonstração de Rastreabilidade de Exceção (Stack Trace) ---");
        try
        {
            // A chamada inicial que desencadeará a exceção em um método aninhado.
            MetodoA();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nExceção capturada no método Run()!");
            Console.WriteLine($"Tipo da Exceção: {ex.GetType().Name}");
            Console.WriteLine($"Mensagem: {ex.Message}");
            Console.ResetColor();

            Console.WriteLine("\n--- Stack Trace (O 'rastro' do erro) ---");
            Console.WriteLine("O rastreamento abaixo mostra a ordem inversa das chamadas:");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("------------------------------------------");
        }
        Console.WriteLine("\n--- Demonstração Concluída ---");
    }

    private void MetodoA()
    {
        Console.WriteLine("Entrando no Método A... chamando B.");
        MetodoB(); // Chama o próximo método na cadeia.
    }

    private void MetodoB()
    {
        Console.WriteLine("Entrando no Método B... O erro vai acontecer aqui!");
        throw new InvalidOperationException("Ocorreu um erro específico no Método B.");
    }
}
// Esta classe demonstra como capturar e exibir informações de rastreamento de pilha
// quando uma exceção é lançada em um método aninhado.
// A pilha de chamadas ajuda a entender a sequência de métodos que levaram ao erro.
// É uma ferramenta valiosa para depuração e diagnóstico de problemas em código complexo.
// A mensagem de erro e o rastreamento de pilha são exibidos no console para fácil visualização.
// A cor do texto é alterada para vermelho para destacar a mensagem de erro.
// A execução do programa continua após a captura da exceção, permitindo que o usuário veja o resultado da demonstração.
// A estrutura do código é simples, com métodos aninhados para simular uma cadeia de chamadas,
// e uma exceção é lançada intencionalmente para demonstrar o conceito de Stack Trace.
// A classe é projetada para ser executada em um ambiente de console, onde o usuário
// pode interagir e ver os resultados diretamente no terminal.
// A demonstração é concluída com uma mensagem final, indicando que o exemplo foi executado com sucesso.
