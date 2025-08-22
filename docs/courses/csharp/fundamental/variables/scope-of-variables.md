# Controlar o escopo da variável e a lógica usando blocos de código

Use blocos de código com mais confiança, compreendendo o modo como eles afetam a visibilidade e a acessibilidade de construções de nível superior e inferior no código.

As instruções de seleção e iteração usam blocos de código para agrupar as linhas de código que devem ser executadas, ignoradas ou iteradas. Mas essa não é a única finalidade para blocos de código. Os blocos de código também podem ser usados para controlar ou limitar a acessibilidade variável. A variável **"scope"** refere-se à parte de um aplicativo em que uma variável está acessível. Entender como um bloco de código afeta o escopo da variável é uma parte importante da programação do computador.

## Objetivos de aprendizagem

- Entenda o impacto de declarar e inicializar variáveis dentro e fora dos blocos de código.
- Melhore a legibilidade dos blocos de código nas instruções `if`.
- Descreva a finalidade e a hierarquia de escopo para namespaces, classes e métodos.

## Blocos de código e escopo de variável

Um bloco de código é uma ou mais instruções que definem um caminho de execução. As instruções fora do bloco de código afetam quando, se e com que frequência o bloco é executado em tempo de execução. Os blocos de código normalmente são delimitados por chaves, **{ }**.

Além do efeito no caminho de execução, os blocos de código também podem afetar o escopo das variáveis.

## Blocos de código afetam o escopo de uma declaração de variáveis

O escopo da variável refere-se à visibilidade dela para os demais códigos do seu aplicativo.

Uma variável com **escopo local** só pode ser acessada dentro do bloco de código no qual ela está definida. Se você tentar acessar a variável fora do bloco de código, obterá um erro do compilador.

## Examinar a interpretação do compilador do código

Para ajudá-lo a evitar erros de runtime, o compilador analisa seu código no Visual Studio Code e durante o processo de compilação. No entanto, o compilador nem sempre interpretará seu código da mesma maneira que você.

Considere os dois exemplos de código a seguir que parecem servir à mesma finalidade:

```csharp
// Code sample 1
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
```

```csharp
// Code sample 2
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
```

Você pode pensar que esses dois exemplos devem sempre produzir o mesmo resultado, mas o compilador interpreta esses dois exemplos de código de forma diferente.

No primeiro exemplo de código, o compilador interpreta flag como uma variável de booliano à qual pode ter atribuída um valor de true ou false. O compilador conclui que, se flag for false, value não será inicializado quando o segundo Console.WriteLine() for executado.

Essencialmente, o compilador considera como possíveis os dois caminhos de execução de código a seguir:

```csharp
// path when flag = true
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
```

E:

```csharp
// path when flag = false
int value;
Console.WriteLine($"Outside the code block: {value}");
```

Como o compilador considera o segundo caminho uma possibilidade (para o exemplo de código 1), ele gera uma mensagem de erro durante o processo de compilação. Além disso, o editor de código no Visual Studio Code avisa sobre esse problema exibindo uma linha de rabiscos vermelhos em value (abaixo do bloco de código).

No segundo exemplo de código, o compilador conclui que o conteúdo do bloco de código da instrução `if` sempre será executado (`true` sempre é `true`). O compilador não gera um erro de build porque interpreta o segundo exemplo de código para ter um único caminho de execução conforme a seguir:

```csharp
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
```

## Recapitulação

- Quando você declara uma variável dentro de um bloco de código, a visibilidade dela é local para esse bloco de código e essa variável não pode ser acessada fora do bloco de código.
- Para garantir que uma variável esteja visível dentro e fora de um bloco de código, você deve declarar a variável antes do bloco de código (fora e acima do bloco de código).
- Verifique se as variáveis são inicializadas antes que seu código tente acessá-las (para todos os caminhos de execução de código possíveis).
