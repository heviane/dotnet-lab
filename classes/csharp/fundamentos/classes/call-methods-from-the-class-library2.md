# Valores de retorno e parâmetros de métodos

Na unidade anterior, você usou um cenário de codificação de "lançamento de dados" para ilustrar a **diferença entre métodos com estado (instância) e sem estado (estáticos)**. Esse mesmo cenário pode ajudar você a entender outros conceitos importantes sobre métodos de chamada.

Por exemplo:

- Manipular o valor de retorno de um método.
- Parâmetros de método e passagem de argumentos para um método.
- Escolher uma versão sobrecarregada de um método.

## Valores retornados

Alguns métodos foram criados para concluir sua função e terminar "silenciosamente".
Em outras palavras, eles não retornam um valor quando são finalizados. Eles são denominados métodos nulos.

Outros métodos são projetados para retornar um valor após a conclusão. O valor de retorno é normalmente o resultado de uma operação. Um valor de retorno é a principal maneira de um método se comunicar com o código que o chama.

Você viu que o método `Random.Next()` retorna um tipo `int` com o valor do número gerado aleatoriamente. No entanto, um método pode ser projetado para retornar qualquer tipo de dados, até mesmo outra classe.

Por exemplo, a classe `String` tem alguns métodos que retornam uma cadeia de caracteres, um inteiro ou um booleano.
Ao chamar um método que retorna um valor, geralmente você atribui o valor de retorno a uma variável. Dessa forma, é possível usar o valor posteriormente no código.

No cenário do lançamento de dados, você atribuiu o valor de retorno de Random.Next() à variável roll:

```csharp
int roll = dice.Next(1, 7);
```

Em alguns casos, é possível usar o valor de retorno diretamente, sem atribuí-lo a uma variável.
Por exemplo, é possível imprimir o valor de retorno no console da seguinte maneira:

```csharp
Console.WriteLine(dice.Next(1, 7));
```

Mesmo que um método retorne um valor, é possível chamá-lo sem usar o valor de retorno.
Por exemplo, é possível ignorar o valor de retorno chamando o método da seguinte maneira:

```csharp
dice.Next(1, 7);
```

No entanto, ignorar o valor de retorno seria inútil.
O motivo pelo qual você está chamando o método `Next()` é para recuperar o próximo valor aleatório.

## Parâmetros e argumentos do método na instrução de chamada

Ao chamar um método, você pode passar valores que o método usará para concluir sua tarefa. Esses valores são chamados de **argumentos**. O método usa os argumentos para atribuir valores aos parâmetros definidos na assinatura do método.Um método pode exigir um ou mais parâmetros para realizar sua tarefa, ou nenhum.

> **Observação:** Geralmente, os termos **'parâmetro'** e **'argumento'** são usados de forma intercambiável. No entanto, **“parâmetro”** refere-se à variável que está sendo usada no método. O **“argumento”** é o valor transmitido quando o método é chamado.

A maioria dos métodos é projetada para aceitar um ou mais parâmetros. Os parâmetros podem ser usados para configurar como o método executa seu trabalho ou podem ser operados diretamente.

Por exemplo:

- O método `Random.Next()` usa parâmetros para configurar os limites superior e inferior do valor retornado.
- O método `Console.WriteLine()` usa o parâmetro diretamente, imprimindo o valor no console.

Os métodos usam uma **assinatura de método** para definir o número de parâmetros que o método aceitará, bem como o tipo de dados de cada parâmetro. A instrução de codificação que chama o método deve aderir aos requisitos especificados pela assinatura do método. Alguns métodos fornecem opções para o número e o tipo de parâmetros que o método aceita.

Quando um chamador invoca o método, ele fornece **valores concretos**, chamados **argumentos**, para cada **parâmetro**. Os argumentos devem ser compatíveis com o parâmetro de tipo. Entretanto, o nome do argumento, se for usado no código de chamada, não precisará ser o mesmo que o nome do parâmetro definido no método.

```csharp
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

- A primeira linha de código cria uma instância da classe Random chamada `dice`.
- A segunda linha de código usa o método `dice.Next(1, 7)` para atribuir um valor aleatório a um número inteiro chamado `roll`. Observe que a instrução chamada fornece dois argumentos separados por um símbolo ,. O método `Next()` inclui uma assinatura de método que aceita dois parâmetros do tipo `int`. Esses parâmetros são usados para configurar os marcos de delimitação inferior e superior do número aleatório que é retornado.
- A terceira linha de código usa o método `Console.WriteLine()` para imprimir o valor de `roll` no console.

Os argumentos passados para um método devem ter o mesmo tipo de dados que os parâmetros correspondentes definidos pelo método. Se você tentar passar um argumento digitado incorretamente para um método, o compilador do C# detectará o erro e forçará você a atualizar a instrução de chamada antes que o código seja compilado e executado. A verificação de tipo é uma das maneiras que o C# e o .NET usam para evitar que os usuários finais encontrem erros em tempo de execução.

> **Observação:** Embora os parâmetros sejam usados com frequência, nem todos os métodos exigem parâmetros para concluir sua tarefa. Por exemplo, a classe `Console` inclui um método `Console.Clear()` que não usa parâmetros. Como esse método é usado para limpar todas as informações exibidas no console, ele não precisa de parâmetros para concluir sua tarefa.

## Métodos sobrecarregados

Muitos métodos na Biblioteca de Classes do .NET têm assinaturas de método sobrecarregado. Entre outras coisas, isso permite que você chame o método com ou sem argumentos especificados na instrução de chamada.

**Um método sobrecarregado é definido com várias assinaturas de método.**

Os métodos sobrecarregados oferecem diferentes maneiras de chamar o método ou diferentes tipos de dados.

Em alguns casos, versões sobrecarregadas de um método são usadas para definir um parâmetro usando tipos de dados diferentes.

Por exemplo, o método `Console.WriteLine()` tem 19 versões sobrecarregadas diferentes. A maioria dessas sobrecargas permite que o método aceite diferentes tipos e faça a gravação das informações especificadas no console.

```csharp
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);
```

Neste exemplo, você invocará três versões sobrecarregadas separadas do método `WriteLine()`:

- O primeiro método `WriteLine()` usa uma assinatura de método que define um parâmetro `int`.
- O segundo método `WriteLine()` usa uma assinatura de método que define zero parâmetros.
- O terceiro método `WriteLine()` usa uma assinatura de método que define um parâmetro `string`.

Em outros casos, as versões sobrecarregadas de um método definem um número diferente de parâmetros. Os parâmetros alternativos podem ser usados para fornecer mais controle sobre o resultado desejado.

Por exemplo, o método `Random.Next()` tem versões sobrecarregadas que permitem que você defina vários níveis de restrição no número gerado aleatoriamente.

O exercício a seguir chama o método `Random.Next()` para gerar valores inteiros aleatórios com diferentes níveis de restrição:

```csharp
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
```

Output:
`First roll: 342585470`
`Second roll: 43`
`Third roll: 89`

Como os números gerados são aleatórios, seus resultados serão diferentes. No entanto, este exemplo demonstra o intervalo de resultados que podem ser exibidos.

Reserve um minuto para analisar o código:

- A primeira versão do método `Next()` não define um limite superior e inferior; portanto, o método retornará valores que variam de 0 a 2,147,483,647, que é o valor máximo que um int pode armazenar.
- A segunda versão do método `Next()` especifica o valor máximo como um limite superior, portanto, nesse caso, espere um valor aleatório entre 0 e 100.
- A terceira versão do método `Next()` especifica os valores mínimo e máximo. Portanto, nesse caso, é possível esperar um valor aleatório entre 50 e 100.

Veja a seguinte lista rápida do que você já aprendeu:

- Você examinou como usar o valor de retorno de um método (quando o método fornece um valor de retorno).
- Você examinou como um método pode usar parâmetros que são definidos como tipos de dados específicos.
- Você examinou as versões sobrecarregadas de alguns métodos que incluem parâmetros ou tipos de parâmetro diferentes.

## Usar o IntelliSense

O Visual Studio Code inclui recursos do **IntelliSense** que são parte da plataforma de um serviço de linguagem.

Por exemplo, o serviço de linguagem C# fornece preenchimentos de código inteligentes com base na semântica da linguagem e em uma análise do código-fonte. Nesta seção, você usará o IntelliSense para implementar o método `Random.Next()`.

Como o IntelliSense é exposto no editor de código, é possível aprender muito sobre um método sem sair do ambiente de codificação. O IntelliSense fornece dicas e informações de referência em uma janela pop-up abaixo do local do cursor conforme você insere o código. Quando você estiver digitando o código, a janela pop-up do IntelliSense mudará o conteúdo de acordo com o contexto.

Por exemplo, conforme você insere a palavra `dice` lentamente, o IntelliSense mostrará todas as palavras-chave, identificadores (ou melhor, nomes de variáveis no código) e classes C# na biblioteca de classes do .NET que correspondem às letras inseridas. Os recursos de preenchimento automático do editor de código podem ser usados para terminar de digitar a palavra que é a primeira correspondência no pop-up do IntelliSense. Experimente.

1. Verifique o código abaixo:

    ```csharp
    Random dice = new Random();
    int roll1 = dice.Next();
    int roll2 = dice.Next(101);
    int roll3 = dice.Next(50, 101);

    Console.WriteLine($"First roll: {roll1}");
    Console.WriteLine($"Second roll: {roll2}");
    Console.WriteLine($"Third roll: {roll3}");
    ```

2. Na parte inferior do arquivo de código, para experimentar o IntelliSense, insira lentamente as letras **d**, **i** e **c**.

3. Observe a janela pop-up do IntelliSense que aparece quando você começa a digitar.

   Quando o IntelliSense aparecer, uma lista de sugestões aparecerá nele. Ao inserir **dic**, o identificador **dice** deverá estar no topo da lista.

4. Pressione a tecla **Tab** no teclado.

   Observe que toda a palavra **dice** é preenchida no editor. É possível usar as teclas de seta para cima e para baixo a fim de alterar a seleção antes de pressionar a tecla **Tab**.

    > **Observação:** Se a janela do IntelliSense desaparecer, ela poderá ser reaberta usando a tecla `backspace` do teclado e digitando novamente o último símbolo.

5. Para especificar o operador de acesso de membro, insira um caractere `.`.

   Observe que o pop-up do IntelliSense reaparece ao inserir **.** e mostra uma lista não filtrada de todos os métodos (e outros membros da classe) disponíveis.

6. Digite **N**

   A lista será filtrada e a palavra **Next** deve ser a primeira seleção.

7. Para preencher automaticamente a palavra inteira, pressione a tecla **Tab**.

8. Para especificar o operador de invocação de método, insira **(**

   Observe que o parêntese de fechamento é adicionado automaticamente para você.

   O operador de invocação de método é o conjunto de parênteses localizado à direita do nome do método. Essa parte da instrução de chamada é o local em que você especifica os argumentos que serão passados para o método. O operador de invocação de método é necessário ao chamar o método.

9. Observe que o pop-up do IntelliSense agora exibe informações detalhadas sobre o método `Random.Next()`.

10. Reserve um minuto para examinar o pop-up do IntelliSense sobre o método `Random.Next()`.

    > **Observação:** Se o pop-up do IntelliSense fechou antes de você examiná-lo, exclua o operador de invocação **( )** e insira **(** para exibir o pop-up do IntelliSense.

    Observe que a janela pop-up inclui três seções, uma à esquerda e duas à direita.

    No lado direito, você verá `int Random.Next()` na seção superior e `Returns a non-negative random integer`. na seção inferior. O `int` define o tipo de retorno do método. Isso significa que quando esta versão do método for executada, ela retornará um valor do tipo `int`.

    No lado esquerdo do pop-up do IntelliSense, 1/3 é exibido.
    O 1/3 indica que está é a primeira das três assinaturas de método do método `Next()`. Observe que essa versão da assinatura do método permite que o método funcione sem parâmetros (nenhum argumento passado ao método na instrução de chamada).

    Observe que também há uma pequena seta acima e abaixo do 1/3.

11. Para examinar a segunda versão sobrecarregada do método, pressione a tecla de seta para baixo no teclado.

    É possível usar as teclas de seta para cima e para baixo a fim de navegar entre as diversas versões sobrecarregadas. Ao fazer isso, 1/3, 2/3 e 3/3 serão exibidos no lado esquerdo do pop-up do IntelliSense e explicações úteis aparecerão à direita.

12. Reserve um minuto para examinar cada uma das versões sobrecarregadas do método `Random.Next()`.

    A segunda versão sobrecarregada do método, 2/3, informa que o método `Next()` pode aceitar um parâmetro `int maxValue`. A descrição informa que `maxValue` é o limite superior exclusivo para o número que você deseja que o método `Next()` gere. Exclusive indica que o número de retorno será menor que `maxValue`. Portanto, ao especificar `dice.Next(1,7);`, a rolagem máxima de dados será 6. Observe que a mensagem na parte inferior da seção foi atualizada para: `Returns a non-negative random integer that is less than the specified maximum`.

    A terceira versão do método, 3/3, informa que o método `Next()` pode aceitar `int minValue` e `int maxValue` como parâmetros. O novo parâmetro, `minValue`, é um limite inferior para o número que você deseja que o método `Next()` gere. Como o limite inferior é inclusivo em vez de exclusivo, o valor de retorno pode ser igual a `minValue`. A mensagem na parte inferior agora indica: `Returns a random integer that is within a specified range`.

    Nesse caso, o **IntelliSense** fornece todas as informações necessárias para selecionar a sobrecarga apropriada, incluindo uma explicação detalhada de `maxValue` e `minValue`. No entanto, você pode se deparar com situações em que precisará consultar a documentação do método.

## Use learn.microsoft.com para obter informações sobre métodos sobrecarregados

A segunda maneira de saber mais sobre versões sobrecarregadas dos métodos é consultar a documentação do método. A documentação também o ajudará a entender exatamente qual é a finalidade de cada parâmetro.

1. Para começar, abra o navegador da Web e o mecanismo de pesquisa de sua preferência:

2. Pesquise por `C# Random.Next()`

    Sua pesquisa deve incluir o nome da classe e o nome do método. Também convém incluir o termo **C#** para garantir que não obtenha resultados acidentais para outras linguagens de programação.

3. Selecione o principal resultado da pesquisa que começa com **https://learn.microsoft.com**.

    Nesse caso, o título do link deve aparecer como `Random.Next Method`.

    Veja o link caso você tenha um problema para encontrá-lo usando um mecanismo de pesquisa:

    [Método Random.Next](https://learn.microsoft.com/pt-br/dotnet/api/system.random.next)

4. Abra o link para C# Random.Next().

5. Confira rapidamente a documentação.

    Role para baixo pelo conteúdo da página para ver os diversos exemplos de código. Observe que é possível executar os exemplos na janela do navegador.
    A documentação do **learn.microsoft.com** segue um formato padrão para cada classe e método na biblioteca de classes do .NET.

6. Na parte superior da página da Web, localize a seção Sobrecargas.

    Observe que há três versões sobrecarregadas do método listado. Cada versão sobrecarregada listada inclui um hiperlink para um local mais abaixo na página.

7. Para navegar "na página" para uma descrição da segunda versão sobrecarregada, selecione `Next(Int32)`.

    A documentação de cada versão do método inclui o seguinte:

    - Breve descrição da funcionalidade do método
    - Definição do método
    - Parâmetros que o método aceita
    - Valores retornados
    - Exceções que podem ser geradas
    - Exemplos do método em uso
    - Outras observações sobre o método

8. Reserve um minuto para revisar a seção Parâmetros.

    Na seção Parâmetros, você pode ler que o parâmetro `maxValue` é o "limite superior exclusivo do número aleatório a ser gerado." Um limite superior exclusivo significa que, se você quiser números não maiores que 10, deverá passar o valor 11.

    Também é possível ler na próxima linha: "`maxValue` deve ser maior ou igual a 0". O que acontece se você ignorar esta instrução? Observe na seção Exceções que o método retorna um `ArgumentOutOfRangeException` quando `maxValue` é menor que 0.

    >**Observação:** O conteúdo em **learn.microsoft.com** é a "única fonte de verdade" da biblioteca de classes do .NET. É importante reservar um tempo para ler a documentação a fim de entender como um determinado método funcionará.

## Recapitulação

- Os métodos podem não aceitar nenhum parâmetro ou vários parâmetros, dependendo de como foram projetados e implementados. Ao passar vários parâmetros, separe-os com um símbolo **,**.
- Os métodos poderão retornar um valor quando concluírem sua tarefa ou não retornar nada (nulo).
- Os métodos sobrecarregados dão suporte a várias implementações do método, cada uma com uma assinatura de método exclusiva (o número de parâmetros e o tipo de dados de cada parâmetro).
- O **IntelliSense** pode ajudar a escrever códigos mais rapidamente. Ele fornece uma referência rápida aos métodos, seus valores de retorno, suas versões sobrecarregadas e os tipos de seus parâmetros.
- **learn.microsoft.com** é a "fonte da verdade" quando você deseja saber como funcionam os métodos na Biblioteca de classes do .NET.
