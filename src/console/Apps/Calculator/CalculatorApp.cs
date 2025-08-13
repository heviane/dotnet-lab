public class CalculatorApp
{
    public void Run()
    {
        Console.WriteLine("--- Calculadora Simples em C# ---");

        Console.Write("Digite o primeiro número: ");
        string? input1 = Console.ReadLine();
        // Usamos double.TryParse para uma conversão segura de texto para número.
        double.TryParse(input1, out double num1);

        Console.Write("Digite o segundo número: ");
        string? input2 = Console.ReadLine();
        double.TryParse(input2, out double num2);

        Console.Write("Escolha a operação (+, -, *, /): ");
        string? operation = Console.ReadLine();

        double result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"O resultado é: {result}");
        }
    }
}
