# Lista `List<T>`

Listas são coleções de elementos que podem ser acessados por um índice. Em C#, as listas são frequentemente representadas pela classe `List<T>`, onde `T` é o tipo dos elementos da lista.

## Características Principais

- **Dinâmicas**: Diferente dos arrays, listas podem crescer e encolher conforme necessário.
- **Indexadas**: Cada elemento na lista pode ser acessado por um índice, começando em 0.
- **Tipos Genéricos**: Você pode criar listas de qualquer tipo de dado, seja ele primitivo ou um tipo personalizado.

## Operações Básicas

- **Adicionar**: Adiciona um elemento ao final da lista.
- **Remover**: Remove um elemento específico da lista.
- **Acessar**: Acessa um elemento pelo seu índice.

## Exemplo de Uso

```csharp
List<int> numeros = new List<int>();
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);

int primeiroNumero = numeros[0]; // Acessa o primeiro elemento
int segundoNumero  = numeros[1]; // Acessa o segundo elemento
numeros.Remove(2); // Remove o elemento 2 da lista

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
```

## Considerações Importantes

- A classe `List<T>` faz parte do namespace `System.Collections.Generic`, então certifique-se de incluí-lo no início do seu arquivo com `using System.Collections.Generic;`.
- Listas oferecem várias outras funcionalidades, como ordenação, busca e filtragem, que podem ser exploradas conforme necessário.
- Operações como adicionar e remover elementos são geralmente rápidas, mas podem envolver realocações internas se a capacidade da lista for excedida.
- Para tipos personalizados, é importante implementar corretamente os métodos `Equals` e `GetHashCode` se você planeja usar métodos de busca ou remoção baseados em valor.

## Referências

- [Documentação Oficial do .NET sobre Listas](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)
