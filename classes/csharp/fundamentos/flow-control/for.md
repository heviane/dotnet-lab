# Iterar por meio de um bloco de código usando a instrução for

Usar a instrução de iteração for para fazer loop um número predefinido de vezes e controlar o processo de iteração.

Neste módulo, você começará escrevendo instruções `for` que farão a interação um número específico de vezes. Depois de implementar uma instrução for básica, você aprenderá a implementar instruções for que fazem a interação de trás para frente em uma matriz, ignoram elementos da matriz durante uma iteração ou processam apenas elementos especificados dela (alterando o inicializador, a condição e o iterador da instrução for).

Ao final deste módulo, você será capaz de usar instruções for para implementar a lógica de loop quando as instruções foreach não derem suporte ao cenário.

## Objetivos de aprendizagem

- Usar a instrução `for` para passar o loop por um bloco de código
- Modificar como o .NET Runtime executa a lógica de loop, alterando o valor do iterador, a condição e o padrão.
- Examinar a sintaxe da instrução for que permite controlar o padrão de iteração.

## O que é a declaração for?

A instrução for itera por um bloco de código um número específico de vezes. Esse nível de controle torna a instrução for exclusiva entre as outras instruções de iteração. A instrução foreach itera por um bloco de código uma vez para cada item em uma sequência de dados, como uma matriz ou coleção. A while instrução itera por meio de um bloco de código até que uma condição seja atendida.

Além disso, a instrução for oferece muito mais controle sobre o processo de iteração, expondo as condições para a iteração.

O loop `for` é usado quando o número de iterações é conhecido antecipadamente. Ele consiste em três partes principais: inicialização, condição e incremento/decremento.

    ```csharp
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"O valor de i é: {i}");
    }
    ```

> **Observação:** Todas as três seções (inicializador, condição e iterador) são opcionais. No entanto, na prática, normalmente todas as três seções são usadas.

Exemplo com break:

    ```csharp
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        if (i == 7) break;
    }
    ```

Exemplo com matriz:

    ```csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = names.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(names[i]);
    }
    ```

> **Observação:** Poderíamos ter iterado para frente através dos elementos do matriz construindo a instrução for da seguinte forma: for (int i = 0; i < names.Length; i++).

Exemplo de limitação da instrução `foreach`:

    ```csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    foreach (var name in names)
    {
        // Can't do this:
        if (name == "David") name = "Sammy";
    }
    ```

Output: `Cannot assign to name because it is a 'foreach iteration variable'`

> Em outras palavras, você não pode reatribuir o valor de name porque ele faz parte da implementação interna da iteração foreach.

Supere a limitação da instrução `foreach` usando a instrução `for`:

    ```csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = 0; i < names.Length; i++)
        if (names[i] == "David") names[i] = "Sammy";

    foreach (var name in names) Console.WriteLine(name);
    ```

Output: `Alex, Eddie, Sammy, Michael`

Outra versão do exemplo anterior, mas com uma apresentação diferente:

    ```csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };

    for (int i = 0; i < names.Length; i++)
    {
        if (names[i] == "David")
        {
            names[i] = "Sammy";
        }
    }

    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
    ```

## Recapitulação

- A instrução de iteração `for` permite iterar por meio de um bloco de código um número específico de vezes.
- A instrução de iteração `for` permite controlar todos os aspectos da mecânica da iteração alterando as três condições dentro dos parênteses:
  - o inicializador;
  - a condição;
  - o iterador.
- É comum usar a instrução for quando você precisa controlar como deseja iterar por cada item em uma matriz.
- Se o seu bloco de código tiver apenas uma linha de código, você pode eliminar as chaves e os espaços em branco, se desejar.

Modificar o inicializador, a condição e o iterador de uma for instrução fornece controle preciso sobre a lógica de iteração.
