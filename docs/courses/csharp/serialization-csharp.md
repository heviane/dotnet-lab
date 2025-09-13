# O que é Serialização?

No contexto de .NET e C#, **serialização** é o processo de converter o estado de um objeto (ou seja, os valores de suas propriedades e campos) em um formato que pode ser facilmente armazenado ou transmitido. O processo inverso, que recria o objeto a partir desses dados, é chamado de **desserialização**.

Pense nisso como tirar uma "fotografia" de um objeto em um determinado momento. Essa "fotografia" (os dados serializados) pode ser salva em um arquivo, enviada pela internet para outra aplicação ou armazenada em um banco de dados. Mais tarde, você pode usar essa "fotografia" para reconstruir uma cópia exata do objeto original.

## Por que Serializar é Importante?

A serialização é um conceito fundamental na programação e é usada para:

1. **Persistência de Dados**: Salvar o estado de um objeto em um arquivo no disco. Por exemplo, salvar as configurações de um usuário ou o progresso de um jogo.
2. **Comunicação entre Aplicações**: Enviar objetos através de uma rede. É a base para o funcionamento de APIs web (REST), onde um servidor envia dados (geralmente em formato JSON) para um cliente (um navegador ou app mobile).
3. **Caching**: Armazenar objetos usados com frequência em memória (como um `MemoryCache`) ou em um serviço de cache distribuído (como o Redis) para acesso rápido, evitando a necessidade de recriá-los ou buscá-los no banco de dados repetidamente.
4. **Transferência de Dados**: Copiar ou clonar objetos.

## Formatos Comuns de Serialização

Existem vários formatos para representar os dados de um objeto. Os mais comuns são:

- **JSON (JavaScript Object Notation)**: O padrão de fato para APIs web modernas. É leve, legível por humanos e fácil de ser processado por máquinas. É um formato de texto que segue a sintaxe do JavaScript.
- **XML (eXtensible Markup Language)**: Um formato mais antigo e verboso, mas ainda muito usado em sistemas corporativos e configurações (como arquivos `.csproj`).
- **Binário**: Converte o objeto em um fluxo compacto de bytes. É o formato mais performático e que ocupa menos espaço, mas não é legível por humanos.

## Exemplo Prático em C# com JSON

A biblioteca padrão e recomendada para trabalhar com JSON em .NET é a `System.Text.Json`.

Vamos ver como serializar e desserializar um objeto simples.

**1. O Objeto que queremos serializar**

Primeiro, definimos uma classe simples em C#.

```csharp
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public List<string> Tags { get; set; }
}
```

```json
{
    "Id": 1,
    "Nome": "Bota feminina",
    "Preco": "200.00",
    "Tags": "feminino"
}
```

**2. Serializando o Objeto (Objeto -> JSON)**

Agora, criamos uma instância dessa classe e a convertemos em uma string JSON.

```csharp
using System;
using System.Text.Json;
using System.Collections.Generic;

public class ExemploSerializacao
{
    public static void Main()
    {
        // 1. Criar o objeto
        var meuProduto = new Produto
        {
            Id = 101,
            Nome = "Teclado Mecânico RGB",
            Preco = 350.99m,
            Tags = new List<string> { "gamer", "periféricos", "rgb" }
        };

        // 2. Serializar o objeto para uma string JSON
        // Usamos JsonSerializerOptions para formatar o JSON de forma legível (indented)
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(meuProduto, options);

        Console.WriteLine("--- Objeto Serializado para JSON ---");
        Console.WriteLine(jsonString);

        // 3. Desserializar a string JSON de volta para um objeto
        Produto produtoRecuperado = JsonSerializer.Deserialize<Produto>(jsonString);

        Console.WriteLine("\n--- JSON Desserializado para Objeto ---");
        Console.WriteLine($"ID: {produtoRecuperado.Id}");
        Console.WriteLine($"Nome: {produtoRecuperado.Nome}");
        Console.WriteLine($"Preço: {produtoRecuperado.Preco}");
        Console.WriteLine($"Primeira Tag: {produtoRecuperado.Tags[0]}");
    }
}
```

### Resumo do Fluxo

O processo pode ser visualizado da seguinte forma:

`Objeto C# (Produto)` -> **Serialização** (`JsonSerializer.Serialize`) -> `String JSON` -> **Desserialização** (`JsonSerializer.Deserialize`) -> `Novo Objeto C# (Produto)`

A serialização é uma ponte essencial que permite que os objetos do seu programa existam fora da memória da aplicação, tornando possível a comunicação, o armazenamento e a persistência de dados de forma estruturada.

## References

- [Serialização, um conceito fundamental da ciência da computação](../geral/serialization-geral.md)
