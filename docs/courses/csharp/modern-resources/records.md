# Records

Os *records* são um recurso moderno do C# introduzido na versão 9.0, projetado para facilitar a criação de tipos imutáveis e focados em dados. Eles são particularmente úteis quando você deseja representar entidades que possuem propriedades, mas não comportamentos complexos.

## Características Principais

- **Imutabilidade**: Por padrão, as propriedades de um *record* são imutáveis. Isso significa que, uma vez criado, o estado do objeto não pode ser alterado.

- **Igualdade por Valor**: Dois *records* são considerados iguais se todas as suas propriedades forem iguais, ao contrário das classes tradicionais, onde a igualdade é baseada na referência do objeto.

- **Sintaxe Concisa**: A sintaxe para definir *records* é mais curta e clara, facilitando a leitura e manutenção do código.

## Definindo um Record

```csharp
public record Pessoa(string Nome, int Idade);
```

Neste exemplo, `Pessoa` é um *record* com duas propriedades: `Nome` e `Idade`.
## Usando Records

```csharp
Pessoa pessoa = new Pessoa("João", 30);
Console.WriteLine(pessoa.Nome); // Saída: João
Console.WriteLine(pessoa.Idade); // Saída: 30
```

## Imutabilidade
```csharp
// pessoa.Nome = "Maria"; // Isso causará um erro de compilação, pois
// as propriedades são imutáveis por padrão.
```

## Igualdade por Valor

```csharp
Pessoa pessoa1 = new Pessoa("João", 30);
Pessoa pessoa2 = new Pessoa("João", 30);
Console.WriteLine(pessoa1 == pessoa2); // Saída: True
```

## Sintaxe Concisa

```csharp
Pessoa pessoa = new Pessoa("João", 30);
Console.WriteLine(pessoa); // Saída: Pessoa { Nome = João, Idade = 30 }
```

## Herança em Records

```csharp
public record Funcionario(string Nome, int Idade, string Cargo) : Pessoa(Nome, Idade);
```

Neste exemplo, `Funcionario` herda de `Pessoa`, adicionando uma nova propriedade `Cargo`.

## Modificação com `with`

```csharp
Pessoa pessoa1 = new Pessoa("João", 30);
Pessoa pessoa2 = pessoa1 with { Idade = 31 }; // Cria uma nova
Console.WriteLine(pessoa2); // Saída: Pessoa { Nome = João, Idade = 31 }
```

instância com a Idade modificada

## Conclusão

Os *records* são uma poderosa adição ao C#, proporcionando uma maneira eficiente e clara de trabalhar com dados imutáveis. Eles são ideais para cenários onde a integridade dos dados é crucial, como em aplicações financeiras, sistemas de inventário e muito mais. Ao utilizar *records*, você pode escrever código mais limpo, seguro e fácil de manter.
