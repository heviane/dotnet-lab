using Models;
using System;

public class InheritanceApp
{
    public void Run()
    {
        Console.WriteLine("\n--- Demonstração de Herança e Polimorfismo Inicializada ---");

        // 1. Criando uma instância da classe derivada (Student)
        var student = new Student
        {
            // Propriedades herdadas da classe base (Pessoa)
            Id = 3,
            Name = "Ana",
            LastName = "Pereira",
            Birthday = new DateTime(2002, 8, 10),

            // Propriedade específica da classe derivada (Student)
            StudentID = "RA2024-001"
        };

        // 2. Chamando o método Apresentar()
        // Graças ao Polimorfismo (override), a versão do método da classe Student será chamada.
        student.Apresentar();
        /* --------- Como está implementado os métodos na classe Pessoa e Student:
            Na classe pessoa: public virtual void Apresentar()
            Na classe Student: public override void Apresentar()
        */
        // Saída esperada:
        // Olá, meu nome é Ana Pereira, tenho 22 anos e meu ID de estudante é RA2024-001.

        Console.WriteLine("--- Demonstração de Herança e Polimorfismo Concluída ---");
    }
}
