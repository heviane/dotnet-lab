// O Program.cs agora apenas cria uma instância da nossa aplicação e a executa. Toda a lógica está encapsulada na classe ClassesApp.

using Models;
var app = new ClassesApp();
app.Run();

var appCourse = new ClassesAppCourse();
appCourse.Run();

/* =========================== Demonstração de Herança e Polimorfismo ===========================
    A classe InheritanceApp demonstra o uso de herança e polimorfismo em C#:
    - Herança é um passo fundamental para criar um código mais organizado e reutilizável.
    - Polimorfismo permite que classes derivadas alterem o comportamento de métodos herdados, proporcionando flexibilidade e extensibilidade.

    A sugestão mais clássica e didática é criar uma classe Student (Aluno) que herda de Pessoa.
    - A lógica é que "todo Aluno é uma Pessoa", mas possui características adicionais, como um ID de estudante.

    Isso nos permite demonstrar dois pilares da POO de uma só vez:
    - Herança: Student reutilizará todos os membros de Pessoa.
    - Polimorfismo: Faremos com que o Student se "apresente" de uma forma um pouco diferente da Pessoa, sobrescrevendo o método Apresentar.
*/
var inheritanceApp = new InheritanceApp();
inheritanceApp.Run();

/* =========================== Demonstração de Construtores ===========================
    A classe ContaBancaria demonstra um uso real e prático de construtores.
    Ao exigir 'numeroConta' e 'nomeTitular' na criação, garantimos que nenhuma instância da conta exista em um estado inválido.
*/
Console.WriteLine("\n--- Demonstração de Construtores com ContaBancaria ---");

// Tentativa de criar uma conta sem os dados essenciais (isto agora gera um erro de compilação!)
// var contaInvalida = new ContaBancaria(); // ERRO: Não há um construtor que não receba argumentos.

// Forma correta: fornecendo os dados obrigatórios no construtor.
var conta1 = new ContaBancaria("12345-6", "Heviane Bastos", 1000.50m);
conta1.ExibirSaldo();

var conta2 = new ContaBancaria("98765-4", "Tony Stark"); // Usando o parâmetro opcional 'saldoInicial' (será 0)
conta2.ExibirSaldo();
conta2.Depositar(500);

Console.WriteLine("--- Demonstração de Construtores Concluída ---");
