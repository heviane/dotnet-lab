# Fila `Queue<T>`

As filas são estruturas de dados que seguem o princípio **FIFO (First In, First Out)**, ou seja, o primeiro elemento a entrar na fila é o primeiro a sair. Em C#, a classe `Queue<T>` do namespace `System.Collections.Generic` é usada para implementar filas genéricas.

## Operações Básicas

- **Enqueue**: Adiciona um elemento ao final da fila.
- **Dequeue**: Remove e retorna o elemento do início da fila.
- **Peek**: Retorna o elemento do início da fila sem removê-lo
- **IsEmpty**: Verifica se a fila está vazia.
- **Count**: Retorna o número de elementos na fila.

## Exemplo de Uso

```csharp
using System.Collections.Generic
using System;

class FilaExemplo
{
    static void Main(string[] args)
    {
        Queue<int> fila = new Queue<int>();

        // Sempre adiciona o elemento no final da fila
        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);

        foreach(int elemento in fila)
            Console.WriteLine(elemento);

        // Sempre remove o primeiro elemento da fila
        Console.WriteLine("Elemento removido: " + fila.Dequeue());

        Console.WriteLine("Elemento no início da fila: " + fila.Peek());
        Console.WriteLine("Número de elementos na fila: " + fila.Count);
    }
}
// Saída:
// 1
// 2
// 3
// Elemento removido: 1
// Elemento no início da fila: 2
// Número de elementos na fila: 2
```

## Considerações Importantes

- A classe `Queue<T>` é genérica, permitindo que você crie filas de qualquer tipo de dados.
- As operações de `Enqueue` e `Dequeue` são geralmente muito eficientes, com complexidade média de tempo O(1).
- Tentar remover um elemento de uma fila vazia lançará uma exceção. Use a propriedade `Count` para verificar se a fila está vazia antes de chamar `Dequeue`.

## Referências

- [Documentação Oficial do Queue<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1)
- [Coleções Genéricas em C#](https://learn.microsoft.com/en-us/dotnet/standard/collections/generic-collections)
- [Artigo sobre Filas em C#](https://www.c-sharpcorner.com/article/understanding-queue-in-c-sharp/)
