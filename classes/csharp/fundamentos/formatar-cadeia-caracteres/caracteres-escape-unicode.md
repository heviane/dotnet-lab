# Formatação de cadeia de caracteres básica

Combine dados de texto literal e variável que contêm caracteres especiais, formatação e Unicode em mensagens significativas para o usuário final.

Neste módulo, você usará sequências de escape de caractere para formatar cadeias de caracteres literais de texto a fim de incluir caracteres especiais, como tabulação, alimentação de linha e até mesmo caracteres de idiomas diferentes, como scripts Kanji ou cirílico. Você aprenderá a concatenar duas cadeias de caracteres e usará a interpolação de cadeias de caracteres para criar um modelo de cadeia de caracteres literal com partes substituíveis.

Ao final deste módulo, você poderá controlar como seus dados são exibidos para os usuários finais de seus aplicativos.

## Objetivos de aprendizagem

Depois de concluir este módulo, você poderá:

- Criar dados de cadeia de caracteres contendo guias, novas linhas e outros caracteres especiais
- Criar dados de cadeia de caracteres contendo caracteres Unicode
- Combinar dados de cadeia de caracteres em um novo valor de cadeia de caracteres por meio de concatenação
- Combinar dados de cadeia de caracteres em um novo valor de cadeia de caracteres por meio de interpolação

### Combinar cadeias de caracteres usando sequências de escape de caracteres

#### Formatar cadeias de caracteres literais

Uma sequência de caracteres de escape é uma instrução especial para que o runtime insira um caractere especial que afetará a saída da cadeia de caracteres. Em C#, a sequência de caracteres de escape começa com uma barra invertida `\` seguida pelo caractere que será escapado.

Por exemplo, a sequência `\n` adicionará uma nova linha e uma sequência `\t` adicionará uma guia.

O seguinte código usa sequências de caracteres de escape para adicionar linhas e guias:

```csharp
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
```

Output:
`Hello`
`World!`
`Hello   World!`

E se você precisar inserir uma **aspa dupla** em uma cadeia de caracteres literal?
Se você não usar a sequência de escape de caracteres, confundirá o compilador, pois ele achará que você deseja terminar a cadeia de caracteres prematuramente. O compilador não entenderá a finalidade dos caracteres após a segunda aspa dupla.

```csharp
Console.WriteLine("Hello "World"!");
```

O Editor .NET colocará uma linha ondulada vermelha em World. No entanto, se você tentar executar o código mesmo assim, verá a seguinte saída:

`(1,27): error CS1003: Syntax error, ',' expected`
`(1,27): error CS0103: The name 'World' does not exist in the current context`
`(1,32): error CS1003: Syntax error, ',' expected`

Para lidar com isso, use a sequência de escape \":

```csharp
Console.WriteLine("Hello \"World\"!");
```

Output: `Hello "World"!`

E se você precisar usar a barra invertida para outras finalidades, como exibir um caminho de arquivo?

```csharp
Console.WriteLine("c:\source\repos");
```

O C# reserva a barra invertida para sequências de escape. Portanto, se você executar o código, o compilador exibirá o seguinte erro:

Output: `(1,22): error CS1009: Unrecognized escape sequence`

O problema é a sequência `\s`. `\r` não produz um erro porque é uma sequência de escape válida para um retorno de carro. No entanto, não é recomendado usar um retorno de carro neste contexto.

Para resolver o problema, use `\\` para exibir uma barra invertida simples.

```csharp
Console.WriteLine("c:\\source\\repos");
```

Output: `c:\source\repos`

#### Formatar a saída usando sequências de escape de caracteres

```csharp
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
```

Output:

`Generating invoices for customer "Contoso Corp" ...`

`Invoice: 1021           Complete!`
`Invoice: 1022           Complete!`

`Output Directory:`

#### Literal de cadeia de caracteres verbatim

Um literal de cadeia de caracteres textual manterá todo o espaço em branco e os caracteres sem a necessidade de escapar da barra invertida. Para criar uma cadeia de caracteres textual, use a diretiva **@** antes da cadeia de caracteres literal.

```csharp
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
```

Observe que a cadeia de caracteres abrange duas linhas e o espaço em branco gerado por essa instrução do C# é mantido na saída a seguir.
Output:

    `c:\source\repos`
        `(this is where your code goes)`

#### Formatar a saída usando literais de cadeia de caracteres verbatim

Adicione a seguinte linha de código abaixo do código que você criou anteriormente:

```csharp
Console.Write(@"c:\invoices");
```

Agora, execute o código. Você verá o seguinte resultado que inclui o "diretório de saída":
Output:

`Generating invoices for customer "Contoso Corp" ...`

`Invoice: 1021           Complete!`
`Invoice: 1022           Complete!`

`Output Directory:`
`c:\invoices`

#### Caracteres de escape Unicode

Você também pode adicionar caracteres codificados em cadeias de caracteres literais usando a sequência de escape `\u` e, em seguida, um código de quatro caracteres representando algum caractere em Unicode (UTF-16).

```csharp
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```

> **Observação**: Existem várias advertências.
Primeiro, alguns consoles, como o prompt de comando do Windows, não exibirão todos os caracteres Unicode. Ele substituirá esses caracteres por caracteres de ponto de interrogação. Além disso, os exemplos usados aqui são UTF-16. Alguns caracteres exigem UTF-32 e, portanto, exigem uma sequência de escape diferente. Esse é um assunto complicado, e este módulo pretende apenas mostrar o que é possível. Dependendo de sua necessidade, talvez seja necessário gastar bastante tempo aprendendo e trabalhando com caracteres Unicode em seus aplicativos.

#### Formatar a saída usando caracteres de escape Unicode

Para concluir o modelo da ferramenta de linha de comando, você adicionará uma frase em japonês que tem a seguinte tradução: "para gerar faturas em japonês". Em seguida, você exibirá uma cadeia de caracteres verbatim literal que representa um comando que o usuário pode inserir. Você também adicionará algumas sequências de escape para a formatação.

```csharp
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
```

Para garantir que o código esteja correto, compare-o com o seguinte:

```csharp
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
```

Output:

`Generating invoices for customer "Contoso Corp" ...`

`Invoice: 1021           Complete!`
`Invoice: 1022           Complete!`

`Output Directory:`
`c:\invoices`

`日本の請求書を生成するには：`
    `c:\invoices\app.exe -j`

### Recapitulando

Veja o que você aprendeu sobre a formatação de cadeias de caracteres literais até agora:

- Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação `\t`, uma nova linha `\n` ou uma aspa dupla `\"`.
- Use um caractere de escape para a barra invertida `\\` quando precisar usar uma barra invertida em todos os outros cenários.
- Use a diretiva `@` para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
- Use o `\u` mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
- Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo.

### Combinar cadeias de caracteres usando a concatenação de cadeias de caracteres

Muitas vezes, você precisará combinar dados de várias fontes diferentes, incluindo cadeias de caracteres literais e variáveis contendo dados de texto e numéricos. Nesta unidade, você usará a concatenação de cadeia de caracteres para combinar dois ou mais valores em uma nova cadeia de caracteres.

#### O que é concatenação de cadeias de caracteres?

A concatenação de cadeias de caracteres consiste simplesmente na combinação de dois ou mais valores string em um novo valor string. Ao contrário da adição, o segundo valor é acrescentado ao final do primeiro valor e assim por diante. No exercício a seguir, você escreverá o código para concatenar os valores string.

#### Concatenar uma cadeia de caracteres literal e uma variável

Para concatenar duas cadeias de caracteres, use o operador de concatenação de cadeia de caracteres, que é o símbolo de adição `+`.

```csharp
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);
```

Output: `Hello Bob`

Observe a ordem: a primeira cadeia de caracteres "Hello " é a primeira na nova cadeia de caracteres e o valor na variável `firstName` é acrescentado ao final dela.

#### Concatenar diversas variáveis e cadeias de caracteres literais

Você pode executar várias operações de concatenação na mesma linha de código.

```csharp
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);
```

Aqui, você cria uma mensagem mais complexa combinando diversas variáveis e cadeias de caracteres literais.

Output: `Hello Bob!`

#### Como evitar variáveis intermediárias

Nas etapas anteriores, você usou uma variável extra para conter a nova cadeia de caracteres resultante da operação de concatenação. A menos que você tenha um bom motivo para fazer isso, você pode (e deve) evitar usar variáveis intermediárias executando a operação de concatenação conforme necessário.

```csharp
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
```

Output: `Hello Bob!`

### Recapitulando

Veja o que você aprendeu sobre a concatenação de cadeias de caracteres até agora:

- A concatenação de cadeia de caracteres permite combinar cadeias de caracteres literais menores e variáveis em uma única cadeia de caracteres.
- Evite criar variáveis intermediárias se adicioná-las não aumentar a legibilidade.

### Combinar cadeias de caracteres usando a interpolação de cadeias de caracteres

Embora a concatenação de cadeia de caracteres seja simples e conveniente, a interpolação de cadeia de caracteres está crescendo em popularidade em situações nas quais você precisa combinar muitas cadeias de caracteres literais e variáveis em uma única mensagem formatada.

#### O que é interpolação de cadeia de caracteres?

A interpolação de cadeia de caracteres combina vários valores em uma única cadeia de caracteres literal usando um "modelo" e uma ou mais expressões de interpolação. Uma expressão de interpolação é indicada por um símbolo de chave de abertura e fechamento `{ }`. Você pode colocar qualquer expressão C# que retorne um valor entre chaves. A cadeia de caracteres literal se torna um modelo quando ele é prefixado pelo caractere `$`.

Em outras palavras, em vez de escrever a seguinte linha de código:

```csharp
string message = greeting + " " + firstName + "!";
```

Você pode escrever esta linha de código mais concisa:

```csharp
string message = $"{greeting} {firstName}!";
```

Neste exemplo simples, você economiza alguns pressionamentos de tecla. Você pode imaginar como a interpolação de cadeia de caracteres muito mais concisa pode estar em operações mais complexas. Além disso, muitas localizam a sintaxe de interpolação de cadeia de caracteres mais limpa e mais fácil de ler.

No exercício a seguir, você reescreverá as mensagens anteriores usando a interpolação de cadeia de caracteres.

#### Usar a interpolação de cadeia de caracteres para combinar uma cadeia de caracteres literal e um valor variável

Para interpolar duas cadeias de caracteres juntas, você cria uma cadeia de caracteres literal e prefixa a cadeia de caracteres com o símbolo `$`. A cadeia de caracteres literal deve conter pelo menos um conjunto de chaves `{}`, e dentro desses caracteres você usa o nome de uma variável.

```csharp
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
```

Output: `Hello Bob!`

#### Usar a interpolação de cadeia de caracteres com diversas cadeias de caracteres literais e variáveis

Você pode executar várias operações de interpolação na mesma linha de código.

```csharp
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);
```

Output: `Update to Windows 11`

#### Evitar variáveis intermediárias

Da mesma forma que você fez no exercício anterior, é possível eliminar a variável temporária para armazenar a mensagem.

```csharp
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");
```

Output: `Update to Windows 11!`

#### Combinar literais textuais e interpolação de cadeia de caracteres

Suponha que você precise usar um literal textual em seu modelo. Você pode usar o símbolo `@` de prefixo literal textual e o símbolo `$` de interpolação de cadeia de caracteres juntos.

```csharp
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

Output: `C:\Output\First-Project\Data`

Neste exemplo, o símbolo `$` permite que você referencie a variável `projectName` dentro das chaves, enquanto o símbolo `@` permite que você use o caractere `\` sem escape.

### Recapitulando

Veja o que você aprendeu até agora sobre a interpolação de cadeias de caracteres:

- A interpolação de cadeia de caracteres fornece uma melhoria na concatenação de cadeia de caracteres, reduzindo o número de caracteres necessários em algumas situações.
- Você pode combinar a interpolação de cadeias de caracteres e literais textuais combinando os símbolos para cada um e usando-o como um prefixo para o modelo de cadeia de caracteres.

## Exercicios

```csharp
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");
Console.WriteLine($"\n{russianMessage}:");
Console.WriteLine($@"c:\Exercise\{projectName}\ru-RU\data.txt");
```

```csharp
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");
```
