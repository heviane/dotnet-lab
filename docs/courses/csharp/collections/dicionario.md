# Dicionário/Mapa `Dictionary<TKey, TValue>`

É uma coleção genérica que armazena pares de chave-valor.
Ele permite o acesso rápido aos valores com base em suas chaves únicas.
Para armazenar valores únicos sem uma ordem específica.

## Características Principais

- **Chaves Únicas**: Cada chave no dicionário deve ser única.
- **Acesso Rápido**: Acesso eficiente aos valores usando suas chaves.
- **Tipos Genéricos**: Pode armazenar qualquer tipo de chave e valor.

## Operações Básicas

- **Adicionar**: Adiciona um novo par chave-valor.
- **Remover**: Remove um par chave-valor com base na chave.
- **Acessar**: Recupera o valor associado a uma chave específica.

## Exemplo de Uso

```csharp
using System;
using System.Collections.Generic;

public class ExemploDicionario {
    static void Main() {
        // Criação de um dicionário que mapeia strings para inteiros
        Dictionary<string, int> idades = new Dictionary<string, int>();

        // Adicionando pares chave-valor
        idades.Add("Alice", 30);
        idades.Add("Bob", 25);
        idades["Charlie"] = 35; // Outra forma de adicionar

        // Acessando valores
        Console.WriteLine($"Idade de Alice: {idades["Alice"]}");

        // Verificando se uma chave existe
        if (idades.ContainsKey("Bob")) {
            Console.WriteLine("Bob está no dicionário.");
        }

        // Removendo um par chave-valor
        idades.Remove("Charlie");

        idades["Alice"] = 40; // Atualizando o valor de uma chave existente

        // Iterando sobre o dicionário
        foreach (var par in idades) {
            Console.WriteLine($"{par.Key} tem {par.Value} anos.");
        }
    }
}
```

## Considerações Importantes

- A classe `Dictionary<TKey, TValue>` é genérica, permitindo que você crie dicionários de qualquer tipo de chave e valor.
- O desempenho das operações de adição, remoção e acesso é geralmente muito bom, com complexidade média de tempo O(1).
- Tentar adicionar uma chave que já existe lançará uma exceção. Use `ContainsKey` para verificar antes de adicionar.
- A ordem dos elementos no dicionário não é garantida. Se a ordem for importante, considere usar `SortedDictionary<TKey, TValue>` ou `OrderedDictionary`.
- Para tipos personalizados como chave, é importante sobrescrever os métodos `GetHashCode` e `Equals` para garantir o comportamento correto do dicionário.

## Referências

- [Documentação Oficial do Dictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)
- [Coleções Genéricas em C#](https://learn.microsoft.com/en-us/dotnet/standard/collections/generic-collections)
- [Diferença entre Dictionary, Hashtable e SortedDictionary](https://learn.microsoft.com/en-us/dotnet/standard/collections/comparing-generic-and-nongeneric-collections)
- [Guia de Boas Práticas para Coleções em C#](https://learn.microsoft.com/en-us/dotnet/standard/collections/best-practices)
- [Stack Overflow: Quando usar Dictionary vs List em C#](https://stackoverflow.com/questions/2447771/when-to-use-dictionary-vs-list-in-c-sharp)
- [Vídeo Explicativo sobre Dictionary em C#](https://www.youtube.com/watch?v=1gkX9b6v4jA)
- [Artigo sobre Performance de Dicionários em C#](https://www.red-gate.com/simple-talk/dotnet/net-development/dictionary-performance-in-c/)
- [Tutorial Interativo de Dictionary em C#](https://dotnetfiddle.net/)
