# Primeiro código C#

Vamos nos concentrar na seguinte linha de código:

```csharp
    Console.WriteLine("Hello World!");
```

Ao executar o seu código, você notou que a mensagem `Hello World!` foi impressa no console de saída. Quando a frase é colocada entre **aspas duplas** no código C#, ela é chamada de **cadeia de caracteres literal**. Em outras palavras, literalmente, você queria enviar os caracteres H, e, l, l, o e assim por diante à saída.

A parte `Console` é chamada de **classe**. As classes "contêm" **métodos**; ou também podemos dizer que os métodos residem nas classes. Para visitar o método, é necessário saber em qual classe ele está. Por enquanto, pense em uma classe como uma forma de representar um objeto. Nesse caso, todos os métodos que operam no console de saída são definidos dentro da classe `Console`.

Também há um ponto que separa o nome da classe `Console` e o nome do método `WriteLine()`. O ponto é o **operador de acesso a membro**. Em outras palavras, o ponto é a forma como você "navega" da classe para um dos métodos dela.

A parte `WriteLine()` é chamada de método. Você sempre pode identificar um método porque, após ele, há um conjunto de parênteses. Cada método tem um trabalho. O trabalho do método `WriteLine()` é gravar uma linha de dados no console de saída. Os dados impressos são enviados entre os parênteses de abertura e de fechamento como um parâmetro de entrada. Alguns métodos precisam de parâmetros de entrada, enquanto outros não. Mas se você quiser invocar um método, sempre precisará usar os parênteses após o nome dele. Os parênteses são conhecidos como o **operador de invocação de método**.

Por fim, o `ponto e vírgula` é o final do **operador de instrução**. Uma instrução é uma instrução completa em C#. O ponto e vírgula indica ao compilador que você terminou de inserir o comando.

## Entender o fluxo de execução

Além disso, é importante entender o fluxo de execução. Em outras palavras, as instruções de código foram executadas em ordem, uma linha por vez, até não haver mais instruções a serem executadas. Algumas instruções exigirão que a CPU aguarde antes de continuar. Outras instruções podem ser usadas para alterar o fluxo de execução.

> Ao escrever um código no Editor do .NET, você pode ter notado alterações sutis nas cores de diferentes palavras e símbolos. O realce de sintaxe é um recurso útil que você começará a usar para identificar facilmente erros em seu código que não estão em conformidade com as regras de sintaxe do C#.
