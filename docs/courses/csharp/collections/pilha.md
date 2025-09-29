# Pilha `Stack<T>`

Pilhas (Stacks) são estruturas de dados do tipo **LIFO (Last In, First Out)**, onde o último elemento adicionado é o primeiro a ser removido. Em C#, a classe `Stack<T>` na biblioteca `System.Collections.Generic` é usada para implementar pilhas.

## Operações Básicas

- **Push**: Adiciona um elemento ao topo da pilha.
- **Pop**: Remove e retorna o elemento do topo da pilha.
- **Peek**: Retorna o elemento do topo da pilha sem removê-lo.
- **IsEmpty**: Verifica se a pilha está vazia.
- **Count**: Retorna o número de elementos na pilha.

## Exemplo de Uso

```csharp
using System;
using System.Collections.Generic;

class PilhaExemplo
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();

        // Sempre adiciona o elemento no topo da pilha
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);

        foreach(int elemento in pilha)
            Console.WriteLine(elemento);

        // Sempre remove o elemento do topo da pilha
        Console.WriteLine("Elemento removido: " + pilha.Pop());

        Console.WriteLine("Elemento no topo da pilha: " + pilha.Peek());
        Console.WriteLine("Número de elementos na pilha: " + pilha.Count);
    }
}
// Saída:
// 3
// 2
// 1
// Elemento removido: 3
// Elemento no topo da pilha: 2
// Número de elementos na pilha: 2
```

## Considerações Importantes

- A classe `Stack<T>` é genérica, permitindo que você crie pilhas de qualquer tipo de dados.
- As operações `Push` e `Pop` são muito eficientes, com complexidade média de tempo O(1).
- Tentar chamar `Pop` ou `Peek` em uma pilha vazia lançará uma exceção `InvalidOperationException`. Use a propriedade `Count` para verificar se a pilha está vazia antes de realizar essas operações.

## Referências

- [Stack](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.stack)
