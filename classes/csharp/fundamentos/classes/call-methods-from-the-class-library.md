# Chamar métodos da Biblioteca de Classes

Use a funcionalidade na Biblioteca de Classes do .NET chamando métodos que retornam valores, aceitam parâmetros de entrada e mais.

## Objetivos de aprendizagem

Neste módulo, você vai:

- Chamar métodos sem estado na Biblioteca de Classes do .NET.
- Chamar métodos com estado na Biblioteca de Classes do .NET.
  - Crie uma instância de classes da Biblioteca de Classes do .NET para chamar métodos que mantêm o estado.
- Use o **IntelliSense** para saber mais sobre métodos e as versões de sobrecarga, o tipo de dado retornado e os tipos de dados dos parâmetros de entrada dele.
- Use a documentação do **Microsoft Learn** para pesquisar a função de um método, bem como as eventuais sobrecargas que ele tenha, o tipo de valor retornado, os parâmetros de entrada e o que cada parâmetro representa.

### Chamar métodos com estado e sem estado

```csharp
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

Explicação:

- Na terceira linha, é incluido uma referência à classe Console, que chama o método Console.WriteLine() diretamente.
- Na primeira linha, usa-se uma técnica diferente para chamar o método Random.Next().
    > A técnica usada é criar uma instância da classe Random (chamada dado) e, em seguida, chamar o método Next() nessa instância (objeto).

- A razão, é porque alguns métodos são **"com estado"** e outros são **"sem estado"**.

#### Estado

O termo **estado** é usado para descrever a condição do ambiente de execução em um momento específico no tempo. Conforme seu código executa linha por linha, os valores são armazenados em variáveis. A qualquer momento durante a execução, o estado atual do aplicativo é a coleção de todos os valores armazenados na memória.

##### Sem Estado

Alguns métodos não dependem do estado atual do aplicativo para funcionarem corretamente.

Em outras palavras, os métodos sem estado são implementados para que possam funcionar sem referenciar ou alterar os valores já armazenados na memória. Os métodos sem estado também são conhecidos como métodos estáticos.

Por exemplo, o método `Console.WriteLine()` não depende de nenhum valor armazenado na memória. Ele executa sua função e termina sem afetar o estado do aplicativo de qualquer forma.

##### Com Estado

Outros métodos, contudo, devem ter acesso ao estado do aplicativo para funcionar corretamente.

Em outras palavras, os métodos com estado são construídos de maneira que os torna dependentes de valores armazenados na memória por linhas de código anteriores já executadas. Ou eles modificam o estado do aplicativo atualizando valores ou armazenando novos valores na memória. Eles também são conhecidos como **métodos de instância**.

Os métodos com estado (instância) controlam seu estado em campos, que são variáveis definidas na classe. Cada nova instância da classe tem sua própria cópia desses campos nos quais o estado é armazenado.

Uma única classe pode dar suporte a métodos com e sem estado. No entanto, quando você precisa chamar métodos com estado, deve primeiro criar uma instância da classe para que o método possa acessar o estado.

### Criar uma instância de uma classe

Uma **instância de uma classe** é chamada como um **objeto**.

Para criar uma instância de uma classe, use o operador `new`.
Considere a seguinte linha de código que cria uma instância da classe `Random` para criar um objeto chamado dice:

```csharp
Random dice = new Random();
```

O operador `new` faz várias coisas importantes:

- Primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo objeto com base na classe `Random`.
- Ele cria o objeto e o armazena no endereço de memória.
- Retorna o endereço da memória para que possa ser salvo no objeto `dice`.

Desse ponto em diante, quando o objeto `dice` é referenciado no código, o .NET Runtime realiza uma pesquisa nos bastidores para dar a ilusão de que você está trabalhando diretamente com o próprio objeto.

Seu código usa o objeto `dice` como uma variável que armazena o estado da classe `Random`. Quando você chama o método `Next()` no objeto `dice`, o método usa o estado armazenado no objeto `dice` para gerar um número aleatório.

A versão mais recente do Runtime do .NET permite que você crie uma instância de um objeto sem ter que repetir o nome do tipo (invocação de construtor com tipo de destino).

Por exemplo, o código a seguir criará uma nova instância da classe `Random`:

```csharp
Random dice = new();
```

A intenção é simplificar a legibilidade do código. Você sempre usa parênteses ao escrever uma expressão new do tipo de destino.

#### Por que o método Next() é com estado?

- Talvez você esteja se perguntando por que o método Next() foi implementado como um método com estado?
- Os designers da Biblioteca de Classes do .NET não conseguiram descobrir uma maneira de gerar um número aleatório sem exigir estado?
- E o que exatamente está sendo armazenado ou referenciado pelo método `Next()`?

Essas são perguntas justas.

Em um alto nível, os computadores são bons em seguir instruções específicas para criar um resultado confiável e repetível. Para criar a ilusão de aleatoriedade, os desenvolvedores do método `Next()` decidiram capturar a data e hora até a fração de um milissegundo e usar isso para propagar um algoritmo que produz um número diferente a cada vez. Embora não seja totalmente aleatório, isso é suficiente para a maioria dos aplicativos. O estado capturado e mantido durante o tempo de vida do objeto `dice` é o valor inicial. Cada chamada subsequente ao método `Next()` está executando novamente o algoritmo, mas verifica se a semente é alterada para que o mesmo valor não seja (necessariamente) retornado.

No entanto, para usar o método `Random.Next()`, você não precisa entender como ele funciona. O importante é saber que alguns métodos exigem que você crie uma instância de uma classe antes de chamá-los, enquanto outros não.

#### Como é possível determinar se você precisa criar uma instância de uma classe ante de chamar seus métodos?

Uma abordagem para determinar se um método é um método com ou sem estado é consultar a documentação.

A documentação inclui exemplos que mostram se ele deve ser chamado por meio da instância do objeto ou diretamente da classe.

> **Observação:** Às vezes, você precisa rolar para baixo na página da documentação para encontrar os exemplos de código.

Como alternativa à pesquisa na documentação do produto, é possível tentar acessar o método diretamente por meio da própria classe. Se isso funcionar, você saberá que é um método sem estado. O pior que pode acontecer é você receber um erro de compilação.

Tente acessar o método `Random.Next()` diretamente e veja o que acontece:

```csharp
int result = Random.Next();
```

Você já sabe que `Next()` é um método com estado, no entanto, este exemplo demonstra como o Editor do Visual Studio Code reage quando você tenta acessar um método incorretamente.

Observe que uma linha ondulada vermelha aparece abaixo de `Random.Next()`, indicando que há um erro de compilação.
Se você estiver interessado em usar um método sem estado, nenhuma linha ondulada vermelha aparecerá.
Passe o ponteiro do mouse sobre a linha ondulada vermelha.

Uma janela pop-up deve aparecer com a seguinte mensagem:

Output: `(1,14): error CS0120: An object reference is required for the non-static field, method, or property 'Random.Next()'`

Como você viu no código do início da unidade, é possível corrigir esse erro criando uma instância da classe `Random` antes de acessar o método `Next()`. Por exemplo:

```csharp
Random dice = new Random();
int roll = dice.Next();
Console.WriteLine(roll);
```

Nesse caso, o método `Next()` é chamado sem parâmetros de entrada.

### Recapitulação

- Para chamar métodos de uma classe na Biblioteca de Classes do .NET, use o formato ClassName.MethodName(), em que o símbolo . é o operador de acesso de membro para acessar um método definido na classe e os símbolos () são os operadores de invocação de método.
- Ao chamar um método sem estado, não é necessário criar uma instância de sua classe primeiro.
- Ao chamar um método com estado, é necessário criar uma instância da classe e acessar o método no objeto.
- Use o operador new para criar uma instância de uma classe.
- Uma instância de uma classe é chamada como um objeto.
