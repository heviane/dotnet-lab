# Executar operações básicas com números

Conheça os operadores e técnicas usados para executar operações matemáticas básicas em dados numéricos.

## Objetivos de aprendizagem

Depois de concluir este módulo, você poderá:

- Executar operações matemáticas em valores numéricos
- Observe a conversão de tipo implícito entre cadeias de caracteres e valores numéricos
- Converter temporariamente um tipo de dados em outro

## Realizar adição com conversão implícita de dados

Muitas vezes, você deseja executar operações matemáticas sobre dados numéricos. Você começará com a adição nesta unidade, depois passará para outras operações na próxima unidade, pois há uma lição importante a ser aprendida sobre como o compilador do C# analisa e interpreta o seu código.

### Adicionar dois valores numéricos

Para somar dois números, você usará o operador de adição, que é o sinal de mais `+`.
Sim, o mesmo símbolo de mais `+` que você usa para concatenação de cadeias de caracteres também é usado para adição. A reutilização de um símbolo com várias finalidades é, às vezes, chamada de **"sobrecarregar o operador"**, e ocorre frequentemente em C#.

Neste caso, o compilador entende o que você está tentando fazer. O compilador analisa o código e vê que o `+ (operador)` está posicionado entre dois valores numéricos (operandos). Considerando os tipos de dados das variáveis (ambos são ints), ele conclui que você deseja adicionar os dois valores.

```csharp
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
```

Output: `19`

### Misturar tipos de dados para forçar as conversões de tipo implícitas

O que acontece se você tenta usar o símbolo `+` com os valores string e int?

```csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
```

Output: `Bob sold 7 widgets.`

Neste caso, o compilador entende que você deseja usar o símbolo `+` para concatenar os dois operandos. Ele deduz isso porque o símbolo `+` está rodeado por operandos dos tipos de dados `string` e `int`. Sendo assim, ele tenta converter implicitamente a variável `intwidgetsSold` em um `string` temporariamente, para que possa concatenar o restante da cadeia de caracteres. O compilador tenta ajudá-lo quando pode, mas o ideal é que você seja explícito quanto às suas intenções.

### Tentar um caso mais avançado de adição de números e concatenação de cadeias de caracteres

```csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
```

Output: `Bob sold 77 widgets.`

Em vez de adicionar a variável `intwidgetsSold` ao literal `int7`, o compilador trata tudo como uma cadeia de caracteres e concatena tudo.

### Adicionar parênteses para esclarecer sua intenção ao compilador

```csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
```

Output: `Bob sold 14 widgets.`

O símbolo de parênteses `()` se torna outro **operador sobrecarregado**. Neste caso, os parênteses de abertura e fechamento formam o operador de ordem de operações, exatamente como na matemática. Você indica que quer que os parênteses internos sejam resolvidos primeiro, resultando na adição dos valores `int`, `widgetsSold` e o valor `7`. Após isso ser resolvido, ele converterá implicitamente o resultado em uma cadeia de caracteres para que possa ser concatenado ao restante da mensagem.

> **Observação:** Provavelmente, você deveria evitar executar um cálculo e uma concatenação em uma única linha de código. A ideia aqui é ajudar você a entender como ver operadores e operandos da maneira que o compilador faz.

### Recapitulando

Veja o que você aprendeu até agora sobre operações matemáticas:

- Você pode executar operações matemáticas, como de adição, em números.
- A concatenação de cadeias de caracteres e a adição usam o símbolo de adição `+`. Isso é chamado de **sobrecarregar um operador** e o compilador infere o uso adequado com base nos tipos de dados em que opera.
- Quando puder, o compilador converterá implicitamente um `int` em um `string` se for óbvio que o desenvolvedor está tentando concatenar a representação de cadeia de caracteres de um número para fins de apresentação.
- É possível usar parênteses para definir a ordem das operações, a fim de informar explicitamente ao compilador que deseja executar determinadas operações antes de outras.

> Agora você compreende as noções básicas da adição e, mais importante, da conversão implícita entre tipos de dados numéricos e de cadeia de caracteres.

## Vamos examinar várias outras operações matemáticas comuns em dados numéricos

Exemplo de código para realizar a **adição**, **subtração**, **multiplicação** e **divisão**, com inteiros:

```csharp
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
```

Como você pode ver:

- `+` é o operador de adição
- `-`é o operador de subtração
- `*` é o operador de multiplicação
- `/` é o operador de divisão

No entanto, o **quociente** resultante do exemplo de divisão pode não ser o que você esperava.
Os valores após a casa decimal são **truncados**, pois ele está definido como um `int`, e este não pode conter valores após a casa decimal.

### Realizar uma divisão usando dados decimais literais

Para que a divisão funcione corretamente, use um tipo de dados que dê suporte a dígitos fracionários após o ponto decimal, como `decimal`.

```csharp
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
```

Output: `Decimal quotient: 1.4`

Para que isso funcione, o **quociente** (à esquerda do operador de atribuição) deve ser do tipo `decimal` e pelo menos um dos números que estão sendo divididos também deve ser do tipo `decimal` (ambos também podem ser do tipo decimal).

```csharp
decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;
```

No entanto, as seguintes linhas de código não funcionam (ou fornecem resultados imprecisos):

```csharp
int decimalQuotient = 7 / 5.0m;
int decimalQuotient = 7.0m / 5;
int decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7 / 5;
```

### Adicionar o código para converter os resultados da divisão de números inteiros

E se você não estiver trabalhando com valores literais? Em outras palavras, e se você precisar dividir duas variáveis do tipo `int`, mas não quiser que o resultado seja truncado?

Nesse caso, você precisa executar uma **conversão de tipo de dados** de `int` em `decimal`, que instrui o compilador a tratar temporariamente um valor como se ele fosse um tipo de dados diferente.

Para converter `int` em `decimal`, você adiciona o operador de conversão antes do valor. É possível usar o nome do tipo de dados entre parênteses na frente do valor para convertê-lo. Nesse caso, adicione `(decimal)` antes das variáveis `first` e `second`.

```csharp
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
```

Output: `1.4`

> **Observação:** Você aprendeu três usos para o operador de parênteses:
    > - invocação de método
    > - ordem de operações
    > - coerção

### Escrever o código para determinar o resto após a divisão de inteiros

O operador de módulo `%` informa o resto da divisão de int.

O que você realmente aprende com isso é se um número é divisível por outro. Isso pode ser útil durante operações de processamento longo ao percorrer em loop centenas ou milhares de registros de dados quando deseja fornecer comentários para o usuário final após cada 100 registros de dados terem sido processados.

```csharp
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
```

Output:
`Modulus of 200 / 5 : 0`
`Modulus of 7 / 5 : 2`

Quando o módulo é `0`, isso significa que o dividendo é divisível pelo divisor.

### Ordem de operações

Conforme você aprendeu no exercício anterior, é possível usar os símbolos `()` como os operadores de ordem das operações. No entanto, esta não é a única forma da ordem das operações ser determinada.

Em matemática, **PEMDAS** é um acrônimo que ajuda os alunos a se lembrar da ordem das operações. A ordem é:

- Parêntese (o que estiver dentro do parêntese é executado primeiro)
- Exponentes
- Multiplicação e Divisão (da esquerda para a direita)
- Adição e Subtração (da esquerda para a direita)

C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes. Embora não haja um operador de expoente em C#, é possível usar o método `System.Math.Pow`. O módulo "Chamar métodos da Biblioteca de Classes .NET usando C#" apresentará esse e outros métodos.

### Recapitulação

- Use operadores como `+`, `-`, `*` e `/` para executar operações matemáticas básicas.
- A divisão de dois valores `int` resultará no truncamento dos valores após o ponto decimal. Para manter os valores após o ponto decimal, primeiro você precisará converter o divisor ou o dividendo (ou ambos) de `int` em um número de ponto flutuante como `decimal`, em seguida, o quociente deverá ser do mesmo tipo de ponto flutuante para evitar o truncamento.
- Execute uma operação de conversão para tratar um valor temporariamente como se ele fosse um tipo de dados diferente.
- Use o operador `%` para capturar o resto após a divisão.
- A ordem das operações seguirá as regras do acrônimo **PEMDAS**.

## Incrementar e decrementar valores

As operações básicas finais que você aprenderá neste módulo são como incrementar e decrementar valores usando operadores especiais que são combinações de símbolos.
Com frequência, você precisará incrementar e/ou decrementar valores, especialmente quando estiver escrevendo lógicas de loop ou o códigos que interagem com estruturas de dados.

O operador `+=` adiciona e atribui o valor à direita do operador ao valor à esquerda do operador.
Portanto, as linhas dois e três do seguinte snippet de código são equivalentes:

```csharp
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
```

O operador `++` incrementa em uma (1) unidade o valor da variável.
Portanto, as linhas dois e três do seguinte snippet de código são equivalentes:

```csharp
int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.
```

Essas mesmas técnicas podem ser usadas para subtração, multiplicação e muito mais.
As etapas do exercício a seguir destacarão algumas delas.

> **Observação:** Operadores como `+=`, `-=`, `*=`, `++` e `--` são conhecidos como operadores de atribuição composta porque compõem uma operação além de atribuir o resultado à variável. O operador `+=` é chamado especificamente de operador de atribuição de adição.

### Escrever código para incrementar e decrementar um valor

```csharp
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
```

Output:
`First increment: 2`
`Second increment: 3`
`Third increment: 4`
`First decrement: 3`
`Second decrement: 2`
`Third decrement: 1`

> **Observação:** No “segundo incremento”, você usou `value += 1;`. No entanto, você poderia ter usado um valor int literal (ou uma variável) para incrementar esse valor. O mesmo se aplica ao "segundo decremento": `value -= 1`;.

### Posicionar os operadores de incremento e decremento

Os operadores de incremento e decremento têm uma característica interessante: dependendo da posição em que são usados, eles executam a operação correspondente antes ou depois de recuperarem o valor. Em outras palavras, se você usar o operador antes do valor, como em `++value`, o incremento ocorrerá antes que o valor seja recuperado. Da mesma forma, `value++` incrementará o valor após ele ser recuperado.

Usar o operador de incremento antes e depois do valor

```csharp
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
```

Output:
`First: 2`
`Second: 2`
`Third: 3`
`Fourth: 4`

Observe esta linha de código:

```csharp
Console.WriteLine($"Second: {value++}");
```

Há duas etapas nesta linha:

- Recuperar valor atual da variável `value` e usá-lo na operação de interpolação de cadeias de caracteres.
- Incrementar o valor.

A próxima linha de código confirma que o valor foi, de fato, incrementado.

```csharp
Console.WriteLine("Third: " + value);
```

Por outro lado, considere a última linha de código:

```csharp
Console.WriteLine("Fourth: " + (++value));
```

Aqui, a ordem das operações é alterada porque o operador `++` é colocado antes do operando `value`.

- Incrementar o valor.
- Recupere o novo valor incrementado da variável `value` e use-o na operação de string.

Embora não seja estritamente necessário, você adicionou parênteses em torno da expressão `(++value)` para melhorar a legibilidade. Ver tantos operadores `+` próximos uns dos outros faz com que pareça que o código poderia ser mal compreendido por outros desenvolvedores. Decisões estilísticas como essa são subjetivas. No entanto, como escreverá o código apenas uma vez, mas o lerá muitas vezes, você deve priorizar a legibilidade.

## Recapitulando incremento e decremento

Veja o que você aprendeu até agora sobre operações matemáticas em C#:

- Use operadores de atribuição compostos como `+=`, `-=`, `*=`, `++` e `--` para executar uma operação matemática como incremento ou decremento e, em seguida, atribua o resultado à variável original.
- Operadores de incremento e decremento são executados de forma diferente quando o operador está antes ou depois do operando.

### Exercicios

```csharp
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
```

> **Observação:** É preferível não ver tantos valores após o ponto decimal. O ideal é que o valor seja formatado para um único valor após o ponto decimal: 34.4.

## Resumo

Sua meta era executar operações básicas em dados numéricos e de cadeia de caracteres. Como um desafio de codificação, você converteu um valor de uma unidade de medida (Fahrenheit) para outra (Celsius) e exibiu o resultado em uma mensagem formatada.

Você usou vários operadores para executar operações matemáticas e de cadeia de caracteres básicas. Você aprendeu como alguns símbolos são reutilizados (sobrecarregados) como operadores diferentes, dependendo do contexto. Aprendeu como os tipos de dados dos operandos influenciam o significado dos operadores. Por fim, você aprendeu a alterar o tipo de dados de um valor usando o operador cast.
