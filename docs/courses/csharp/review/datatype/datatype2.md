# Tipos de Dados

    Os tipos de dados desempenham uma função central no C#.
    Na verdade, a ênfase nos tipos de dados é um dos principais recursos de distinção do C# em comparação com outras linguagens, como JavaScript. Os designers do C# acreditavam que podem ajudar os desenvolvedores a evitar bugs de software comuns aplicando tipos de dados.

## Objetivos de aprendizagem

- Criar valores literais para cinco tipos de dados básicos
- Declarar e inicializar variáveis
- Recuperar e definir valores em variáveis
- Permitir que o compilador determine o tipo de dados para sua variável ao inicializar

## Valor literal

Um valor literal é um valor constante que nunca é alterado. Anteriormente, você exibia uma cadeia de caracteres literal no console de saída. Em outras palavras, você literalmente queria que a sequência de caracteres alfanuméricos `H, e, l, l, o` e assim por diante fosse exibida no console de saída.

Use o tipo de dados de cadeia de caracteres sempre que você tiver palavras alfanuméricas, frases ou dados para apresentação, não cálculo.

### 1. Literais de caracteres (char e string)

Se você quiser apenas um caractere alfanumérico impresso na tela, poderá criar um char literal usando um caractere alfanumérico entre **aspas simples**.
O termo **char** é uma abreviação de **caractere**.

    Exemplo:

    ```csharp
    Console.WriteLine('b');
    ```

    As `aspas simples` criam um **caractere literal**.
    As `aspas duplas` criam um **string**.

    Exemplo:

    ```csharp
    Console.WriteLine('Hello World!');
    ```

Você obteria o seguinte erro:

> (1,19): error CS1012: Too many characters in character literal

Note as aspas simples ao redor de Hello World!.

Quando você usa `aspas simples`, o compilador C# espera um único caractere.
No entanto, nesse caso, a sintaxe de caractere literal foi usada, mas foram fornecidos 12 caracteres!

USE `char` sempre que tem um único caractere alfanumérico para apresentação (não cálculo).

### 2. Literais de inteiros

Um número inteiro não contém uma decimal, ou seja, sem frações.
Um `int` literal não requer outros operadores como o `string` ou `char`.

    ```csharp
    Console.WriteLine(123);
    ```

### 3. Literais de ponto flutuante

Um número de ponto flutuante contém uma decimal, por exemplo, 3.14159.
O C# dá suporte a três tipos de dados para representar números decimais, e cada tipo dá suporte a diferentes graus de precisão:

- float: ~6-9 digits
- doublee: ~15-17 digits
- decimal: 28-29 digits

Aqui, a precisão reflete o número de dígitos além do decimal que são precisos.

    ```csharp
    Console.WriteLine(0.25F); // float
    ```

Para criar um **float literal**, acrescente a letra F após o número.
Nesse contexto, o **F** é denominado **sufixo literal**.
O sufixo literal informa ao compilador que você deseja trabalhar com um valor do tipo float.
Você pode usar um f minúsculo ou um F maiúsculo como sufixo literal para um float.

**IMPORTANTE:** Observe que o float é o tipo menos preciso, portanto, é melhor usar esse tipo para valores fracionários fixos para evitar erros de computação inesperados.

    ```csharp
    Console.WriteLine(2.625); // double
    ```

Para criar um **double literal**, basta inserir um número decimal.
O compilador usa como padrão um double literal quando um número decimal é inserido sem um sufixo literal.

    ```csharp
    Console.WriteLine(12.39816m); // decimal
    ```

Para criar um **literal decimal**, acrescente a letra m após o número.
Nesse contexto, o **m** é chamado **sufixo literal**.
O sufixo literal indica ao compilador que você deseja trabalhar com um valor do tipo decimal.
Você pode usar tanto a letra minúscula m quanto a letra maiúscula M como sufixo literal para um decimal.

### 4. Literais booleanos

Se você quisesse imprimir um valor que representasse true ou false, você poderia usar um literal booleano. O termo bool é curto para Boolean.

    ```csharp
    Console.WriteLine(true);
    Console.WriteLine(false);
    ```

Os bool literais representam a ideia de verdade e falsidade.

## Tipos de dados definem recursos

Se você precisar executar uma operação matemática em valores numéricos, deverá usar um tipo numérico.
Se você precisar usar dados para apresentação ou manipulação de texto, não cálculo, deverá usar um tipo de dados `string` ou `char`.

Suponha que você precise coletar dados de um usuário, como um número de telefone ou código postal. Dependendo do país/região em que você mora, esses dados podem consistir em caracteres numéricos. No entanto, como você raramente executa cálculos matemáticos em números de telefone e códigos postais, você deve preferir usar um string tipo de dados ao trabalhar com eles.

O mesmo pode ser dito de bool. Se você precisar trabalhar com as palavras "true" e "false" em seu aplicativo, usará um string. No entanto, se você precisar trabalhar com o conceito de true ou false ao executar uma avaliação, use um bool.

É importante saber que esses valores podem se parecer com seus literais de cadeias de caracteres equivalentes. Em outras palavras, você pode pensar que essas instruções são as mesmas:

    ```csharp
    Console.WriteLine("123");
    Console.WriteLine(123);

    Console.WriteLine("true");
    Console.WriteLine(true);
    ```

No entanto, é apenas a saída exibida que parece ser semelhante. O fato é que os tipos de coisas que você pode fazer com o `int` ou `bool` subjacente serão diferentes de seu `string` equivalente.

## Recapitulando

Há muitos tipos de dados, mas você se concentrará em apenas alguns por enquanto:

- **string** para palavras, frases ou quaisquer dados alfanuméricos para apresentação, não para cálculo
- **char** para um único caractere alfanumérico
- **int** para um número inteiro
- **decimal** para um número com um componente fracionário
- **bool** para um true/false valor
