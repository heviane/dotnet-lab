# Trabalhando com variáveis

Como as variáveis são contêineres temporários de armazenamento para dados, elas devem ser gravadas e lidas.
Neste exercício, você declarará uma variável, atribuirá-lhe um valor, recuperará seu valor e muito mais.

## Criar sua primeira variável

Para declarar uma variável, insira o tipo de dados que deseja usar seguido de um nome para a variável.
Para atribuir um valor a uma variável, use o operador de atribuição, que é um único caractere =igual a .
> Observação: Atribuir um valor também é chamado de "definir a variável" ou simplesmente uma operação "set".

```csharp
string firstName;
firstName = "Bob";
```

### Atribuir incorretamente um valor a uma variável

É importante observar que a atribuição ocorre da direita para a esquerda.
Em outras palavras, o compilador C# deve primeiro entender o valor no lado direito do operador de atribuição, em seguida, ele pode executar a atribuição para a variável no lado esquerdo do operador de atribuição. Se você reverter a ordem, confundirá o compilador C#.

```csharp
string firstName;
"Bob" = firstName;
```

Output: `(2,1): error CS0131: The left-hand side of an assignment must be a variable, property or indexer`

### Atribuir incorretamente um valor do tipo de dados incorreto à variável

Você aprendeu que o C# foi projetado para impor tipos.
Ao trabalhar com variáveis, a imposição de tipos significa que você não pode atribuir um valor de um tipo de dados a uma variável declarada para conter outro tipo de dados diferente.

```csharp
int firstName;
firstName = "Bob";
```

Output: `(2,9): error CS0029: Cannot implicitly convert type 'string' to 'int'`

A mensagem de erro indica o que o compilador C# tenta fazer nos bastidores. Ele tentou "converter implicitamente" a cadeia de caracteres "Bob" para ser um valor `int`; no entanto, isso é impossível. Mesmo assim, o C# tentou fazer a conversão, mas falha, pois não há equivalente numérico para a palavra "Bob".

Você aprenderá mais sobre a **conversão de tipo implícita e explícita** posteriormente. Por enquanto, basta lembrar que uma variável só pode conter valores correspondentes ao tipo de dados especificado.

## Recuperar um valor armazenado na variável

Para recuperar um valor de uma variável, basta usar o nome da variável.
Este exemplo definirá o valor de uma variável e, em seguida, recuperará esse valor e o exibirá no console.

```csharp
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
```

Output: `Bob`

Recuperar um valor de uma variável também é chamado de "obtenção da variável", ou simplesmente, uma operação "**get**".
Ao escrever linhas de código, você verá que o compilador está verificando seu código e detectando possíveis erros. O compilador é uma ótima ferramenta para ajudá-lo a corrigir o código mais cedo. Agora que você está familiarizado com diferentes tipos de erros, pode corrigir rapidamente erros com a ajuda das mensagens de erro do compilador.

## Reatribuir o valor de uma variável

Você pode reutilizar e reatribuir a variável quantas vezes quiser. Este exemplo ilustra essa ideia.

```csharp
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
```

Output:
`Bob`
`Liem`
`Isabella`
`Yasmin`

## Inicializar a variável

Você deve definir uma variável para um valor antes de obter o valor da variável. Caso contrário, você verá um erro.

```csharp
string firstName;
Console.WriteLine(firstName);
```

Output: `(2,19): error CS0165: Use of unassigned local variable 'firstName'`

Para evitar a possibilidade de uma variável local não atribuída, é recomendável que você defina o valor assim que possível depois de declará-lo.
Na verdade, você pode executar a declaração e definir o valor da variável em uma linha de código. Essa técnica é chamada de **inicialização da variável**.

```csharp
string firstName = "Bob";
Console.WriteLine(firstName);
```

Output: `Bob`

## Recapitulando

Aqui está o que você aprendeu sobre como trabalhar com variáveis até agora:

- Você deve atribuir (definir) um valor a uma variável antes de recuperar (obter) um valor de uma variável.
- Você pode inicializar uma variável atribuindo um valor à variável no ponto da declaração.
- A atribuição ocorre da direita para a esquerda.
- Use um só caractere de igualdade como o operador de atribuição.
- Para recuperar o valor da variável, basta usar o nome da variável.

> Unidade seguinte: Declarar variáveis locais de tipo implícito.
