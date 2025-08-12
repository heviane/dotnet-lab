# Arrays

Armazenar e iterar em sequências de dados usando Matrizes e a instrução `foreach`.
As matrizes permitem armazenar sequências de valores em uma única estrutura de dados.

Em outras palavras, imagine uma única variável que pode conter vários valores, e então você poderá classificá-los, reverter a ordem deles, executar loop em cada valor, inspecioná-los individualmente e assim por diante.

## Objetivos de aprendizagem

Neste módulo, você vai:

- Criar e inicializar uma matriz.
- Defina e obtenha valores em matrizes.
- Percorrer cada elemento de uma matriz usando a instrução `foreach`.

## O que é uma matriz?

Uma matriz é uma coleção de elementos de dados individuais acessíveis por meio de um único nome de variável. Use um índice numérico baseado em zero para acessar cada elemento de uma matriz. As matrizes permitem que você crie uma coleção de valores de dados que compartilhe uma finalidade ou características comuns em um único nome de variável para facilitar o processamento.

### Como declarar matrizes e acessar os elementos delas

Uma matriz é um tipo especial de variável que pode conter vários valores do mesmo tipo de dados. A sintaxe da declaração é ligeiramente diferente para uma matriz porque você precisa especificar o tipo de dados e o tamanho da matriz.

```csharp
string[] fraudulentOrderIDs = new string[3];
```

O operador `new` cria uma instância de uma matriz na memória do computador que pode conter três valores de cadeia de caracteres.

O primeiro conjunto de colchetes `[]` simplesmente indica ao compilador que a variável de nome `fraudulentOrderIDs` é uma matriz. Já o segundo conjunto de colchetes `[3]` indica o número de elementos que a matriz conterá.

> **Observação:** Esse exemplo demonstra como declarar uma matriz de cadeias de caracteres. No entanto, é possível criar matrizes de qualquer tipos de dados – inclusive os tipos primitivos, como `int` e `bool`, e tipos mais complexos como `classes`.

### Recapitulação

Aqui estão as coisas mais importantes a serem lembradas ao trabalhar com matrizes:

- Uma matriz é uma variável especial que contém uma coleção de elementos de dados relacionados.
- Você deve memorizar o formato básico de uma declaração de variável de matriz.
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
```

Abaixo da palavra-chave `foreach`, o bloco de código que contém `Console.WriteLine(name);` será executado uma vez para cada elemento da matriz names. Como o runtime do .NET executa um loop em cada elemento da matriz, o valor armazenado no elemento atual da matriz `names` será atribuído à variável temporária `name` para facilitar o acesso dentro do bloco de código.

### Recapitulando

Tópicos sobre instruções foreach e valores incrementais que você aprendeu nesta unidade:

- Use a instrução `foreach` para iterar em cada elemento de uma matriz, executando o bloco de código associado uma vez para cada elemento da matriz.
- A instrução `foreach` define o valor do elemento atual na matriz como uma variável temporária, que pode ser usada no corpo do bloco de código.
- Use o operador de incremento `++` para adicionar 1 ao valor atual de uma variável.
