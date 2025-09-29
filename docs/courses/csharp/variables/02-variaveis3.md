# Declarar variáveis locais de tipo implícito

O compilador C# funciona nos bastidores para ajudar você enquanto você escreve seu código. Ele pode inferir o tipo de dados da variável com base em seu valor inicializado.

Nesta unidade, você aprenderá sobre esse recurso, chamado **variáveis locais de tipo implícito**.

## O que são variáveis locais de tipo implícito?

Uma variável local de tipo implícito é criada usando a palavra-chave **var** seguida de uma inicialização de variável. Por exemplo:

```csharp
var message = "Hello world!";
```

Neste exemplo, uma variável de cadeia de caracteres foi criada usando a palavra-chave **var** em vez da palavra-chave **string**.

A palavra-chave **var** informa ao compilador C# que o tipo de dados está implícito pelo valor atribuído. Depois que o tipo é implícito, a variável age da mesma forma como se o próprio tipo de dados real tivesse sido usado para declará-lo. A palavra-chave **var** é usada para salvar em pressionamentos de tecla quando os tipos são longos ou quando o tipo é óbvio no contexto.

Como a variável **message** é definida imediatamente como o **string valor "Hello World!"**, o compilador de C# entende a intenção e trata cada instância de message como uma instância do tipo string. De fato, a variável message é definida para ser um string e para nunca poder ser alterada. Por exemplo:

```csharp
var message = "Hello World!";
message = 10.703m;
```

Output: `(2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'`

> **Observação**: Outras linguagens de programação usam a palavra-chave **var** de modo diferente.
> Em C#, variáveis são atribuídas a um tipo pelo compilador, independentemente de você usar o nome do tipo de dados real ou permita ao compilador implicar o tipo de dados. Em outras palavras, o tipo é bloqueado no momento da declaração e, portanto, nunca poderá conter valores de um tipo de dados diferente.

As variáveis que usam a palavra-chave **var** devem ser inicializadas!

É importante entender que a palavra-chave **var** depende do valor usado para inicializar a variável.
Se tentar usar a palavra-chave **var** sem inicializar a variável, você receberá um erro quando tentar compilar seu código.

```csharp
var message;
```

Output: `(1,5): error CS0818: Implicitly-typed variables must be initialized`

## Por que usar a palavra-chave var?

A palavra-chave **var** foi amplamente adotado na comunidade C#.
É provável que se você vir um exemplo de código em um livro ou online, verá a palavra-chave **var** usada em vez do nome do tipo de dados real. Portanto, é importante entender seu uso.

A palavra-chave **var** tem um uso importante em C#.
Muitas vezes, o tipo de uma variável é óbvio com base em sua inicialização. Nesses casos, é mais simples usar a palavra-chave var.

A palavra-chave **var** também pode ser útil ao planejar o código para um aplicativo. Ao começar a desenvolver um código para uma tarefa, talvez você não saiba imediatamente qual tipo de dados usar. Usar **var** pode ajudar você a desenvolver sua solução de maneira mais dinâmica.

> **DICA**: Ao começar, é recomendável que você continue a usar o nome do tipo de dados real ao declarar variáveis até se sentir mais confortável trabalhando com código.
> Usar o tipo de dados ao declarar variáveis ajudará você a ser mais intencional ao escrever seu código.

## Exercicio

Eexibir mensagem formatada usando uma combinação de valores literais e variáveis:

```csharp
string name = "Bob";
int amount = 3;
float price = 34.40F;
decimal total = 103.20m;

Console.Write("Hello, " + name + "! Temos " + amount + " produtos, cada um custa R$ " + price + ", totalizando R$ " + total);
```

```csharp
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");
```

```csharp
var name = 'Bob'
var age  = 32;

Console.Write("Hello, " + name + "! You are " + age + " years old.");
```

Usando a sintaxe C# básica, você criou valores literais de vários tipos de dados diferentes. Você declarou variáveis e também definiu e recuperou valores dessas variáveis. Você também inicializou variáveis e aprendeu a usar a var palavra-chave para digitar implicitamente uma variável inferindo o tipo da inicialização.

## Recapitulando

Aqui está o que você aprendeu sobre a palavra-chave **var** até agora:

- A palavra-chave **var** informa ao compilador para inferir o tipo de dados da variável com base no valor para o qual ele é inicializado.
Você provavelmente verá a palavra-chave **var** enquanto lê o código de outras pessoas. No entanto, você deve usar o tipo de dados quando possível.
