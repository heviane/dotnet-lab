using Models;

public class ClassesApp
{
    public void Run()
    {
        Console.WriteLine("--- Executando Demonstração de Classes ---");
        // ========================= Aula sobre Classes =========================
        // ------------------------- Como criar e instanciar uma classe

        // Forma 1: Atribuição Separada (É mais verboso e requer mais linhas de código.)
        // Primeiro, cria uma instância "vazia" do objeto. Depois, atribui valor a cada uma de suas propriedades, uma por uma, em linhas separadas.
        var pessoa1 = new Pessoa();
        pessoa1.Id = 1;
        pessoa1.Name = "Maria";
        pessoa1.Age = 28;
        pessoa1.Apresentar();

        // Forma 2: Inicializador de Objeto (É mais conciso, legível e a forma preferida e mais moderna de inicializar objetos em C#.)
        // Permite criar a instância e atribuir valores iniciais às suas propriedades em uma única instrução, dentro de chaves {}.
        var pessoa2 = new Pessoa
        {
            Id = 1,
            Name = "João",
            Age = 30,
            Birthday = new DateTime(1982, 9, 26)
        };
        pessoa2.Apresentar();

        // ------------------------- Como chamar métodos com e sem estado
        var game = new DiceGame();
        game.Play();

        // ------------------------- Como usar uma classe estática
        int employeeLevel = 200;
        string title = Employee.GetTitle(employeeLevel);
        Console.WriteLine($"John Smith, {title}");
        Console.WriteLine("--- Demonstração de Classes Concluída ---");
    }
}
