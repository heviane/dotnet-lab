# Concatenação e Interpolação de Strings

Em C#, combinar (ou juntar) strings é uma tarefa comum.
Existem duas abordagens principais para isso: **concatenação** e **interpolação**.

Embora ambas atinjam o mesmo objetivo, a interpolação é geralmente preferida por sua legibilidade e eficiência, especialmente em cenários complexos.

## Concatenação com o Operador `+`

A forma mais tradicional de juntar strings é usando o operador de adição `+`. Ele funciona bem para combinações simples.

```csharp
string firstName = "Bob";
string message = "Hello " + firstName + "!";
Console.WriteLine(message); // Output: Hello Bob
```

## Interpolação de String com `$`

A interpolação, introduzida em C# 6, permite embutir variáveis diretamente em uma string literal, prefixando-a com o símbolo `$`. As chaves indicam a substituição à ser feita. O código se torna mais limpo e fácil de ler.

```csharp
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message); // Output: Hello Bob!
```

Para exemplos práticos e executáveis, consulte o arquivo `FormatStrings.cs`.
