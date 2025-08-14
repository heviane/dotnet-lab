# Avaliar expressões boolianas para tomar decisões

Conheça os operadores e as técnicas necessárias para avaliar e comparar valores em suas instruções de decisão.

A lógica de decisão é baseada em expressões, conhecidas como expressões boolianas que são avaliadas como "true" ou "false". Os desenvolvedores usam vários tipos de operadores para criar expressões boolianas que atendem aos requisitos de codificação. Quando as expressões são avaliadas, a execução do código se ramifica com base no resultado.

A linguagem C# dá suporte a uma ampla gama de operadores (como igualdade, comparação e operadores boolianos), cada um deles serve a uma finalidade específica ao implementar a lógica de decisão.

## Objetivos de aprendizagem

- Use operadores para criar expressões boolianas que testam a comparação e a igualdade.
- Use métodos internos para a classe de cadeia de caracteres para executar melhores avaliações em cadeias de caracteres.
- Use o operador de negação para testar o oposto de uma determinada condição.
- Use o operador condicional para executar uma avaliação embutida.

## Avaliar uma expressão

A lógica de decisão é usada para estabelecer caminhos alternativos por meio do código, em que a decisão sobre qual caminho seguir se baseia na avaliação de uma expressão.

## O que é uma expressão?

Uma expressão é qualquer combinação de valores (literais ou variáveis), operadores e métodos que retornam um único valor. Uma instrução é considerada uma instrução completa no C#, e as instruções englobam uma ou mais expressões.

Você poderia estar pensando que o valor retornado por uma expressão seria um número ou talvez uma cadeia de caracteres.

É verdade que os desenvolvedores usam diferentes tipos de expressões para fins diferentes. Nesse caso, ao desenvolver uma instrução de seleção `if`, você usará uma expressão que retorna `true` ou `false`. Os desenvolvedores se referem a esse tipo de expressão como uma **expressão booleana**. Quando o código inclui uma expressão booliana, o valor retornado é sempre um valor único true ou false. As expressões boolianas são importantes porque seu código pode usar essas expressões para decidir qual bloco de código deve ser executado.

Há muitos tipos diferentes de operadores que você pode usar em uma expressão booliana. Por exemplo, a instrução `if` acima usa o operador `==` de igualdade para verificar se uma variável de cadeia de caracteres é atribuída a um valor específico. O operador escolhido dependerá dos caminhos de código disponíveis, das condições associadas aos caminhos e da lógica do aplicativo subjacente.

## Avaliando igualdade e desigualdade

Uma das avaliações de código mais comuns é uma marca para conferir se dois valores são iguais.
Ao verificar a igualdade, você localizará o operador de igualdade `==` entre os dois valores que estão sendo verificados. Se os valores em ambos os lados do operador de igualdade forem equivalentes, a expressão retornará `true`. Caso contrário, retornará `false`.

Por outro lado, talvez você também precise verificar se dois valores não são iguais. Para marcar a desigualdade, você usará o operador `!=` de desigualdade entre os dois valores.

Talvez você se pergunte por que precisa de operadores de igualdade e desigualdade. O motivo ficará mais claro à medida que você aprender a criar instruções de ramificação e começar a escrever código do mundo real. Dois operadores que executam tarefas opostas permitem que você seja mais expressivo e compacto.

## Recapitulação

- Há muitos tipos diferentes de expressões que são avaliadas como `true` ou `false`.
- Avalie a igualdade usando o operador `==`.
- A avaliação da igualdade de cadeias de caracteres exige que você considere a possibilidade de que as cadeias de caracteres tenham diferenças no uso de maiúsculas e minúsculas e de espaços à esquerda ou à direita. Dependendo da sua situação, use os métodos auxiliares `ToLower()` ou `ToUpper()` e o método auxiliar `Trim()` para melhorar a probabilidade de duas cadeias de caracteres serem iguais.
- Avalie a desigualdade usando o operador `!=`.
- Avalie maior que, menor que e operações semelhantes usando operadores de comparação como `>, <, >= e <=`.
- Se um método retornar um `bool`, ele poderá ser usado como uma expressão booliana.
- Use o operador de negação lógica `!` para avaliar o oposto de uma determinada expressão.

Operadores de comparação válidos: **==, !=, >, , <, >=e <=**.

## O que é o operador condicional?

O operador condicional `?:` avalia uma expressão booliana e retorna um dos dois resultados, dependendo se a expressão booliana é avaliada como verdadeira ou falsa. O operador condicional normalmente é chamado de **operador condicional ternário**.

Sintaxe:

`<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>`

Exemplo:

```csharp
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
```

> **Observação:** Embora este exemplo específico seja compacto e mostre essa possibilidade, ele é um pouco mais difícil de ler. Nem sempre é uma boa ideia combinar linhas de código, especialmente quando afeta negativamente a legibilidade geral do código. Geralmente, essa é uma decisão subjetiva.

## Recapitulando

Você deve se lembrar dos seguintes fatos sobre o operador condicional:

- Você pode usar o operador condicional para reduzir o tamanho do código, mas deve garantir que o código resultante seja fácil de ler.
- Você pode usar o operador condicional quando precisar retornar um valor baseado em uma condição binária. Seu código retornará a primeira opção quando a condição for avaliada como `true` e retornará a segunda opção quando a condição for avaliada como `false`.

> Exercícios: Desenvolver instruções de decisão para várias situações usando expressões boolianas e operadores.
