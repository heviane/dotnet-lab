# Conjunto `HashSet<T>`

Os conjuntos são coleções que armazenam elementos únicos, ou seja, não permitem duplicatas. Em C#, a implementação mais comum de conjuntos é a classe `HashSet<T>`, que faz parte do namespace `System.Collections.Generic`.

## Características Principais

- **Elementos Únicos**: Não permite elementos duplicados.
- **Operações Rápidas**: Operações como adição, remoção e verificação de existência são geralmente muito rápidas.
- **Tipos Genéricos**: Pode armazenar qualquer tipo de dados.

## Operações Básicas

- **Adicionar**: Adiciona um elemento ao conjunto.
- **Remover**: Remove um elemento do conjunto.
- **Contém**: Verifica se um elemento está presente no conjunto.
- **Tamanho**: Retorna o número de elementos no conjunto.

## Exemplo de Uso

```csharp
using System;
using System.Collections.Generic;
public class ExemploConjunto {
    static void Main() {
        // Criação de um HashSet de inteiros
        HashSet<int> numeros = new HashSet<int>();

        // Adicionando elementos
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);
        numeros.Add(2); // Tentativa de adicionar um duplicado (não será adicionado)

        // Verificando se um elemento existe
        if (numeros.Contains(2)) {
            Console.WriteLine("O conjunto contém o número 2.");
        }

        // Removendo um elemento
        numeros.Remove(3);

        // Exibindo o tamanho do conjunto
        Console.WriteLine($"O conjunto tem {numeros.Count} elementos.");

        // Iterando sobre o conjunto
        foreach (var numero in numeros) {
            Console.WriteLine(numero);
        }
    }
}
```

## Considerações Importantes

- A classe `HashSet<T>` é genérica, permitindo que você crie conjuntos de qualquer tipo de dados.
- O desempenho das operações de adição, remoção e verificação de existência é geralmente muito bom, com complexidade média de tempo O(1).
- A ordem dos elementos em um `HashSet<T>` não é garantida. Se a ordem for importante, considere usar `SortedSet<T>`, que mantém os elementos ordenados.

## Referências

- [Documentação Oficial do HashSet<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1)
