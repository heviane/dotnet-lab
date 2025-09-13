# Método Desconstrutor

O método desconstrutor é usado para extrair os valores das propriedades de um objeto e atribuí-los a variáveis individuais. Ele é especialmente útil quando você deseja trabalhar com os valores das propriedades de um objeto de forma mais direta e conveniente.

## Pontos Chaves

- O método desconstrutor é definido usando a palavra-chave `Deconstruct`.
- Ele deve ter parâmetros `out` que correspondem às propriedades que você deseja extrair do objeto.

## Vantagens

- **Facilidade de Uso**: Permite extrair múltiplas propriedades de um objeto de forma concisa e clara.
- **Melhora a Legibilidade**: O uso de desconstrutores pode tornar o código mais legível, especialmente quando se trabalha com objetos que possuem várias propriedades.

## Exemplos

- [Classe Pessoa](../../../../src/console/Apps/Classes/Models/Pessoa.cs): Um exemplo prático de como usar o método desconstrutor para extrair propriedades de um objeto Pessoa.

```csharp
// Classe Pessoa.cs
public class Pessoa
{
    // Construtores (Propriedades recebem variáveis)
    public Pessoa(int id, string name, string lastName, DateTime birthday)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Birthday = birthday;
    }

    // Desconstrutores (Variáveis recebem propriedades)
    public void Deconstruct(out int id, out string name, out string lastName, out DateTime birthday)
    {
        id = Id;
        name = Name;
        lastName = LastName;
        birthday = Birthday;
    }

    // ....
}

// Instanciando a classe Pessoa
var pessoa = new Pessoa(1, "João", "Silva", new DateTime(1990, 1, 1));
// Desconstruindo o objeto Pessoa
var (_, nome, sobrenome, _) = pessoa; // Descartando variáveis não usadas com underline ( _ ).
Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}");
```

## Referências

- [Documentação Oficial do C# sobre Deconstructors](https://learn.microsoft.com/en-us/dotnet/csharp/deconstruct)
- [Blog Post sobre Desconstrutores em C#](https://devblogs.microsoft.com/dotnet/welcome-to-c-7-0/#deconstructors)
