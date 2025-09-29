# Array

É uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.

Armazenar e iterar em sequências de dados usando Matrizes e a instrução `foreach`.
As matrizes permitem armazenar sequências de valores em uma única estrutura de dados.

Em outras palavras, imagine uma única variável que pode conter vários valores, e então você poderá classificá-los, reverter a ordem deles, executar loop em cada valor, inspecioná-los individualmente e assim por diante.

## Objetivos de aprendizagem

- Criar e inicializar uma matriz.
- Definir e obter os valores em matrizes.
- Percorrer cada elemento de uma matriz usando a instrução `foreach`.

## O que é uma matriz?

Uma matriz é uma coleção de elementos de dados individuais acessíveis por meio de um único nome de variável. Use um índice numérico baseado em zero para acessar cada elemento de uma matriz. As matrizes permitem que você crie uma coleção de valores de dados que compartilhe uma finalidade ou características comuns em um único nome de variável para facilitar o processamento.

Uma matriz é uma variável especial que contém uma coleção de elementos de dados relacionados.

## Exemplo de Uso

Uma matriz é um tipo especial de variável que pode conter vários valores do mesmo tipo de dados. A sintaxe da declaração é ligeiramente diferente para uma matriz porque você precisa especificar o tipo de dados e o tamanho da matriz.

```csharp
string[] orderIDs = new string[3]; // Declaração de matriz de cadeias de caracteres.

orderIDs[0] = "A123";  // Adicionando valores à matriz.
orderIDs[1] = "B456";
orderIDs[2] = "C789";

Console.WriteLine(orderIDs[0]); // Acessando o valor da matriz pelo índice.
Console.WriteLine(orderIDs[1]);
Console.WriteLine(orderIDs[2]);
```

- O operador `new` cria uma instância de uma matriz na memória do computador que pode conter três valores de cadeia de caracteres.
- O primeiro conjunto de colchetes `[]` simplesmente indica ao compilador que a variável de nome `orderIDs` é uma matriz.
- O segundo conjunto de colchetes `[3]` indica o número de elementos que a matriz conterá.

> **Observação:** Esse exemplo demonstra como declarar uma matriz de cadeias de caracteres. No entanto, é possível criar matrizes de qualquer tipos de dados – inclusive os tipos primitivos, como `int` e `bool`, e tipos mais complexos como `classes`.

## Considerações Importantes sobre acesso

- Acesse cada elemento de uma matriz para definir ou obter seus valores usando um índice baseado em zero dentro de colchetes.
- Se você tentar acessar um índice fora dos limites da matriz, será gerada uma exceção de runtime.
- A propriedade `Length` é uma maneira programática de determinar o número de elementos em uma matriz.

## Executar um loop em uma matriz usando o foreach

A instrução `foreach` fornece uma maneira simples e limpa de iterar através dos elementos de uma matriz. Ela processa os elementos da matriz em ordem de índice crescente, começando no índice 0 e terminando no índice Comprimento - 1. Ela usa uma variável temporária para manter o valor do elemento da matriz associado à iteração atual. Cada iteração executará o bloco de código localizado abaixo da declaração foreach.

```csharp
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] numbers = new int[5];
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

Abaixo da palavra-chave `foreach`, o bloco de código que contém `Console.WriteLine(name);` será executado uma vez para cada elemento da matriz names. Como o runtime do .NET executa um loop em cada elemento da matriz, o valor armazenado no elemento atual da matriz `names` será atribuído à variável temporária `name` para facilitar o acesso dentro do bloco de código.

## Considerações Importantes sobre a instrução `foreach`

- Use a instrução `foreach` para iterar em cada elemento de uma matriz, executando o bloco de código associado uma vez para cada elemento da matriz.
- A instrução `foreach` define o valor do elemento atual na matriz como uma variável temporária, que pode ser usada no corpo do bloco de código.
- Use o operador de incremento `++` para adicionar 1 ao valor atual de uma variável.

## Referências

- [Documentação Oficial do .NET sobre Arrays](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
- [Documentação Oficial do .NET sobre foreach](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement)
