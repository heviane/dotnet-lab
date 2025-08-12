using Models;

// ========================= Aula sobre Classes =========================
// ------------------------- Como criar e instanciar uma classe

// Forma 1: Atribuição Separada (É mais verboso e requer mais linhas de código.)
// Primeiro, cria uma instância "vazia" do objeto. Depois, atribui valor a cada uma de suas propriedades, uma por uma, em linhas separadas.
var pessoa1 = new Models.Pessoa();
pessoa1.Id = 1;
pessoa1.Name = "Maria";
pessoa1.Age = 28;
pessoa1.Apresentar();

// Forma 2: Inicializador de Objeto (É mais conciso, legível e a forma preferida e mais moderna de inicializar objetos em C#.)
// Permite criar a instância e atribuir valores iniciais às suas propriedades em uma única instrução, dentro de chaves {}.
var pessoa2 = new Models.Pessoa
{
    Id = 1,
    Name = "João",
    Age = 30,
    Birthday = new DateTime(1982, 9, 26)
};
pessoa2.Apresentar();

/*
    No final das contas, o resultado é exatamente o mesmo.
    A segunda forma é apenas um "syntactic sugar" para tornar o código mais limpo e fácil de escrever.
*/

// ------------------------- Como chamar métodos com e sem estado
// ----- Métodos com estado - Instanciando uma classe
var game = new DiceGame();
game.Play();

// ----- Métodos sem estado - Chamando um método diretamente
var largerValue = Math.Max(100, 200);
Console.WriteLine(largerValue);

// ------------------------- Como usar uma classe estática
int employeeLevel = 200;
string employeeName = "John Smith";

string title = Employee.GetTitle(employeeLevel); // Chamamos método estático da classe Employee
Console.WriteLine($"{employeeName}, {title}");
