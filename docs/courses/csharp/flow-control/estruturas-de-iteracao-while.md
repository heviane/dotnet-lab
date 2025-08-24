# Estruturas de Iteração (Loops)

Permitem que o código execute um bloco repetidamente:

- for
- foreach
- while
- do while

## Instruções `do-while` e `while`

Use as instruções do-while e while para iterar enquanto uma expressão booleana for avaliada como verdadeira.

As instruções do-while e while permitem controlar o fluxo de execução de código fazendo um loop por meio de um bloco de código até que uma condição seja atendida. Ao trabalhar com a instrução foreach, iteramos uma vez para cada item em sequência, como uma matriz. A instrução for nos permite iterar um número predeterminado de vezes e controlar o processo de iteração. As instruções do-while e while permitem iterar por meio de um bloco de código com a intenção que a lógica dentro do bloco de código afetará quando for possível parar a iteração.

### Objetivos de aprendizagem

- Escrever o código que usa a instrução do-while para a iteração em um bloco de código
- Escreva um código que use a instrução while para iterar por um bloco de código
- Use a instrução continue para ir diretamente para a avaliação booliana

### O que é uma instrução do-while?

A do-while instrução executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true. Como essa expressão é avaliada após cada execução do loop, um loop do-while é executado uma ou mais vezes.

```csharp
do
{
    // This code executes at least one time
} while (true);
```

O fluxo de execução começa dentro do símbolo de chave. O código é executado pelo menos uma vez e, em seguida, a expressão booliana ao lado da while palavra-chave é avaliada. Se a expressão booliana retornar true, o bloco de código será executado novamente.
Ao codificar duramente a expressão booliana, truecriamos um loop infinito, um loop que nunca terminará, pelo menos, não como está escrito no momento. Precisaríamos de uma maneira de sair do loop dentro do bloco de código.

Neste exemplo, um número aleatório entre 1 e 10 é gerado e impresso no console. O loop continua até que o número 7 seja gerado. Observe que a expressão booliana é avaliada após a execução do bloco de código, portanto, o número 7 será impresso no console.

```csharp
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
```

Um aprendizado importante para essa primeira tarefa é que o bloco de código de um do-while loop será executado pelo menos uma vez. Poderia iterar um grande número de vezes, e é improvável que saibamos antecipadamente quantas iterações haverá.

Também é importante observar que o código dentro do bloco de código está influenciando a continuação ou não continuação da iteração pelo bloco de código. Um bloco de código que influencia os critérios de saída é um motivo principal para selecionar uma do-while ou while instruções em vez de uma das outras instruções de iteração.

Tanto o foreach quanto o for dependem de fatores externos para determinar o número de iterações do bloco de código.

Exemplo: Escrever uma instrução while que faça a iteração somente enquanto um número aleatório for maior que determinado valor.

```csharp
Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
```

> Observação: Nesse caso, posicionamos a while palavra-chave e a expressão booliana antes do bloco de código. Isso altera o significado do código e atua como um "portão" para permitir que o fluxo de execução só entre se a expressão booleana for avaliada como verdadeira.

No código superior, usamos random para inicializar nossa int variável chamada current. Nossa próxima linha de código ativa é nossa while instrução.
A instrução while fará a iteração com base na expressão booliana (current >= 3). Não sabemos a qual valor será atribuído current, mas há possibilidades que afetam nosso while loop:

- Se current for inicializado para um valor maior ou igual a 3, a expressão booliana retornará truee o fluxo de execução entrará no bloco de código. Dentro do bloco de código, a primeira coisa que fazemos é escrever o valor de current no console. Em seguida, ainda dentro do bloco de código, atualizamos o valor de current com um novo valor aleatório. Neste ponto, o controle volta para a parte superior da while instrução em que a expressão booliana é avaliada. Esse processo continua até que a expressão booleana retorne false e o fluxo de execução saia do bloco de código.
- Se current for inicializado (na parte superior do nosso código) para um valor menor que 3, a expressão booliana retornará falsee o bloco de código nunca será executado.

A linha de código final grava o valor de current no console. Esse código é executado independentemente da execução do bloco de código da iteração e permite escrever o valor final de current no console.

## Use a instrução `continue` para ir diretamente para a expressão booleana

Em alguns casos, será necessário fazer short-circuit no restante do código no bloco de código e continuar para a próxima iteração.
Podemos fazer isso usando a instrução `continue`.

```csharp
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
```

Observe que retornamos ao `do-while`. Um do-while garante que o loop itera pelo menos uma vez.

A primeira coisa que fazemos dentro do bloco de código é atribuir um novo valor aleatório a current. Em seguida, verificamos se current é maior ou igual a 8. Se essa expressão retornar true, a palavra-chave continue transferirá o controle para o final do bloco de código, e while avaliará (current != 7). Portanto, o loop continuará a iterar enquanto o valor de current não for igual a 7.

A chave desta etapa do exercício é a linha de código que contém a continue palavra-chave:

```csharp
if (current >= 8) continue;
```

Como nosso código que grava o valor do current console está localizado após o if (current >= 8) continue;, nosso código garante que um valor current maior ou igual a 8 nunca será gravado na janela de saída.

## Considere a diferença entre as instruções `continue` e `break`

Como você viu nesta última etapa, a instrução `continue` transfere a execução para o final da iteração atual. Esse comportamento é diferente do comportamento que vimos com a instrução `break`. A instrução `break` encerra a iteração (ou switch) e transfere o controle para a instrução que segue a instrução encerrada. Se não houver nenhuma instrução após a instrução encerrada, o controle será transferido para o final do arquivo ou método.

## Recapitular

- A instrução do-while faz a iteração por meio de um bloco de código pelo menos uma vez e pode continuar realizando esse processo com base em uma expressão Booliana. A avaliação da expressão booliana geralmente depende de algum valor gerado ou recuperado dentro do bloco de código.
- A instrução while avalia uma expressão booliana primeiro e continua a iteração pelo bloco de código, desde que a expressão booliana seja avaliada como true.
- A palavra-chave continue para passar imediatamente para a expressão booliana.
