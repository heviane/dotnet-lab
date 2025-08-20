using Models;

public class ClassesAppCourse
{
    public void Run()
    {
        Console.WriteLine("--- Executando Demonstração da ClassesAppCourse ---");
        // ========================= Aula sobre Classes =========================

        // ------------------------- Pessoas
        Console.WriteLine($"\n--- Pessoas: ---");
        Pessoa pessoa1 = new Pessoa
        {
            Id = 1,
            Name = "Maria",
            LastName = "Silva",
            Birthday = new DateTime(1990, 5, 25)
        };
        pessoa1.Apresentar();
        Pessoa pessoa2 = new Pessoa
        {
            Id = 2,
            Name = "João",
            LastName = "Souza",
            Birthday = new DateTime(2016, 3, 15)
        };
        pessoa2.Apresentar();

        // ------------------------- Curso e Alunos
        // Instanciando o curso
        Console.WriteLine($"\n--- Curso e Alunos: ---");
        Course dotNetCourse = new Course();
        dotNetCourse.Name = "Fundamentos de .NET";
        dotNetCourse.Description = "Aprenda C# e a plataforma .NET do zero.";
        dotNetCourse.Students = new List<Pessoa>();  // Inicializando a lista vazia de alunos do curso
        // Adicionando alunos ao curso
        dotNetCourse.AddStudent(pessoa1);
        dotNetCourse.AddStudent(pessoa2);
        dotNetCourse.ListStudents();
        dotNetCourse.GetStudentCount();
        Console.WriteLine($"Total de alunos matriculados no curso '{dotNetCourse.Name}': {dotNetCourse.GetStudentCount()}");
        // Removendo um aluno do curso
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

        Console.WriteLine("--- Demonstração de Classes Concluída ---");
    }
}
