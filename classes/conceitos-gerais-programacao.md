# Conceitos gerais sobre programação

## O que é uma linguagem de programação?

Linguagens de programação como o C# permitem que você escreva instruções a serem executadas pelo computador. Cada linguagem de programação tem uma sintaxe própria, mas após aprender a primeira, ao tentar aprender outra você perceberá rapidamente que todas elas têm muitos conceitos semelhantes. O trabalho de uma linguagem de programação é permitir que uma pessoa expresse sua intenção para o computador, de maneira compreensível e legível por humanos. As instruções que você escreve em uma linguagem de programação são chamadas de **"código-fonte"** ou apenas de **"código"**. Os desenvolvedores de software escrevem código.

> Neste ponto, um desenvolvedor pode atualizar e alterar códigos, mas o computador não pode entendê-los diretamente. Primeiro, o código precisa ser compilado em um formato que o computador possa entender.

## O que é compilação?

Um programa especial chamado compilador converte o código-fonte em um formato diferente que a CPU (unidade de processamento central) do computador pode executar.
Por que o código precisa ser compilado? Embora a maioria das linguagens de programação pareça enigmática no início, elas podem ser mais facilmente compreendidas por humanos do que a linguagem preferencial do computador. A CPU entende as instruções expressas ativando ou desativando milhares ou milhões de pequenos comutadores. Os compiladores conectam esses dois mundos convertendo as instruções legíveis por humanos em um conjunto de instruções compreensível para o computador.

## O que é sintaxe?

As regras para escrever código em C# são chamadas de sintaxe. Assim como as linguagens humanas têm regras sobre pontuação e estrutura de frases, as linguagens de programação de computador também têm regras. Essas regras definem as palavras-chave e os operadores de C# e como eles são combinados para formar programas.

> Ao escrever um código no Editor do .NET, você pode ter notado alterações sutis nas cores de diferentes palavras e símbolos. O realce de sintaxe é um recurso útil que você começará a usar para identificar facilmente erros em seu código que não estão em conformidade com as regras de sintaxe do C#.

## Vamos nos concentrar na seguinte linha de código em C#:

```csharp
    Console.WriteLine("Hello World!");
```

Ao executar o seu código, você notou que a mensagem `Hello World!` foi impressa no console de saída. Quando a frase é colocada entre **aspas duplas** no código C#, ela é chamada de **cadeia de caracteres literal**. Em outras palavras, literalmente, você queria enviar os caracteres H, e, l, l, o e assim por diante à saída.

A parte `Console` é chamada de **classe**. As classes "contêm" **métodos**; ou também podemos dizer que os métodos residem nas classes. Para visitar o método, é necessário saber em qual classe ele está. Por enquanto, pense em uma classe como uma forma de representar um objeto. Nesse caso, todos os métodos que operam no console de saída são definidos dentro da classe Console.

Também há um ponto que separa o nome da classe Console e o nome do método WriteLine(). O ponto é o **operador de acesso a membro**. Em outras palavras, o ponto é a forma como você "navega" da classe para um dos métodos dela.

A parte `WriteLine()` é chamada de método. Você sempre pode identificar um método porque, após ele, há um conjunto de parênteses. Cada método tem um trabalho. O trabalho do método WriteLine() é gravar uma linha de dados no console de saída. Os dados impressos são enviados entre os parênteses de abertura e de fechamento como um parâmetro de entrada. Alguns métodos precisam de parâmetros de entrada, enquanto outros não. Mas se você quiser invocar um método, sempre precisará usar os parênteses após o nome dele. Os parênteses são conhecidos como o **operador de invocação de método**.

Por fim, o `ponto e vírgula` é o final do **operador de instrução**. Uma instrução é uma instrução completa em C#. O ponto e vírgula indica ao compilador que você terminou de inserir o comando.

## Entender o fluxo de execução

Além disso, é importante entender o fluxo de execução. Em outras palavras, as instruções de código foram executadas em ordem, uma linha por vez, até não haver mais instruções a serem executadas. Algumas instruções exigirão que a CPU aguarde antes de continuar. Outras instruções podem ser usadas para alterar o fluxo de execução.
