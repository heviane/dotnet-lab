using Models;

public class ClassesApp
{
    public void Run()
    {
        Console.WriteLine("--- Executando Demonstração da Classe ClassesApp ---");
        // ========================= Aula sobre Classes =========================

        Console.WriteLine($"\n--- Pessoas ---");
        // ------------------------- Como criar e instanciar uma classe
        // Forma 1: Atribuição Separada (É mais verboso e requer mais linhas de código.)
        // Primeiro, cria uma instância "vazia" do objeto. Depois, atribui valor a cada uma de suas propriedades, uma por uma, em linhas separadas.
        var pessoa1 = new Pessoa();
        pessoa1.Id = 1;
        pessoa1.Name = "Maria";
        pessoa1.LastName = "Silva";
        pessoa1.Birthday = new DateTime(1990, 5, 25);
        pessoa1.Apresentar();

        // Forma 2: Inicializador de Objeto (É mais conciso, legível e a forma preferida e mais moderna de inicializar objetos em C#.)
        // Permite criar a instância e atribuir valores iniciais às suas propriedades em uma única instrução, dentro de chaves {}.
        // Isso requer que a classe Pessoa tenha um construtor sem parâmetros.
        // SE DEFINIR UM CONSTRUTOR COM PARÂMETROS, O CONSTRUTOR SEM PARÂMETROS É REMOVIDO. E NÃO PODERÁ MAIS USAR INICIALIZADORES DE OBJETO.
        var pessoa2 = new Pessoa
        {
            Id = 2,
            Name = "João",
            LastName = "Souza",
            Birthday = new DateTime(2016, 3, 15),
        };
        pessoa2.Apresentar();

        // Forma 3: Construtor com parâmetros (É a forma mais eficiente e recomendada de inicializar objetos em C#.)
        // Permite criar a instância e atribuir valores iniciais às suas propriedades diretamente no construtor.
        // Isso é a forma mais eficiente e recomendada de inicializar objetos em C#.
        // SE DEFINIR UM CONSTRUTOR SEM PARÂMETROS, O CONSTRUTOR COM PARÂMETROS É REMOVIDO. E NÃO PODERÁ MAIS USAR INICIALIZADORES DE OBJETO.
        var pessoa3 = new Pessoa(3, "Ana", "Pereira", new DateTime(2002, 8, 10));
        pessoa3.Apresentar();

        var pessoa4 = new Pessoa(id: 3, name: "Helena", lastname: "Rodrigues", birthday: new DateTime(1961, 6, 17));
        pessoa4.Apresentar();

        // ------------------------- Como usar classes em conjunto (Composição)
        // Vamos criar um curso e adicionar os alunos que criamos acima.

        // 1. Criar uma instância do curso
        var dotNetCourse = new Course
        {
            Name = "Fundamentos de .NET",
            Description = "Aprenda C# e a plataforma .NET do zero."
        };

        // 2. Adicionar os alunos existentes ao curso
        dotNetCourse.AddStudent(pessoa1);
        dotNetCourse.AddStudent(pessoa2);

        // 3. Listar os alunos do curso usando o método que criamos
        dotNetCourse.ListStudents();
        dotNetCourse.GetStudentCount();
        Console.WriteLine($"Total de alunos matriculados no curso '{dotNetCourse.Name}': {dotNetCourse.GetStudentCount()}");

        // 4. Remover um aluno do curso
        Console.WriteLine($"\n--- Removendo aluno: {pessoa1.FullName} ---");
        if (dotNetCourse.RemoveStudent(pessoa1))
        {
            Console.WriteLine($"O aluno {pessoa1.FullName} foi removido com sucesso do curso '{dotNetCourse.Name}'.");
        }
        else
        {
            Console.WriteLine($"O aluno {pessoa1.FullName} não pôde ser removido (não estava matriculado).");
        }
        dotNetCourse.ListStudents();
        Console.WriteLine($"Total de alunos matriculados no curso '{dotNetCourse.Name}': {dotNetCourse.GetStudentCount()}");

        // ------------------------- Como chamar métodos com e sem estado
        // Exemplo: Chamando método com estado (com instanciação de objetos)
        var game = new DiceGame(); // Jogo de dados
        game.Play();

        // Exemplo: Chamando método sem estado (com referência direta) - classe estática
        // A classe Employee é estática, então não precisamos criar uma instância dela.

        Console.WriteLine("\n--- Títulos de Funcionários ---");
        int[] employeeLevels = { 40, 50, 100, 200, 300, 400 };

        foreach (var level in employeeLevels)
        {
            string title = Employee.GetTitle(level);
            // Usamos {level,3} para alinhar o número à direita em um espaço de 3 caracteres.
            Console.WriteLine($"- Level: {level,3} => Title: {title}");
        }

        Console.WriteLine("--- Demonstração de Classes Concluída ---");
    }
}
