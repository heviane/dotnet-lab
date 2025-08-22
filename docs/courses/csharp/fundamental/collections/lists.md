# Listas

Listas são coleções de elementos que podem ser acessados por um índice. Em C#, as listas são frequentemente representadas pela classe `List<T>`, onde `T` é o tipo dos elementos da lista.

## Criando uma Lista

Para criar uma lista, você pode usar a seguinte sintaxe:

```csharp
List<int> numeros = new List<int>();
```

## Adicionando Elementos

Para adicionar elementos a uma lista, você pode usar o método `Add()`:

```csharp
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
```

## Acessando Elementos

Você pode acessar elementos de uma lista usando o índice, que começa em 0:

```csharp
int primeiroNumero = numeros[0]; // Acessa o primeiro elemento
int segundoNumero = numeros[1]; // Acessa o segundo elemento
```

## Iterando sobre uma Lista

Você pode iterar sobre os elementos de uma lista usando um loop `foreach`:

```csharp
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
```

## Removendo Elementos

Para remover um elemento de uma lista, você pode usar o método `Remove()`:

```csharp
numeros.Remove(2); // Remove o elemento 2 da lista
```
