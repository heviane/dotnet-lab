# Quiz

1. O que são **parâmetros** de métodos?

   São as variáveis usadas dentro do método.

2. O que são **argumentos** de métodos?

   Os valores transmitidos para um método na instrução de chamada.

    > A definição do método especifica os nomes e tipos de quaisquer parâmetros obrigatórios. Quando um chamador invoca o método, a instrução de chamada fornece valores concretos, chamados de argumentos, para cada parâmetro.

3. O que é um método sobrecarregado?

   É um método que dá suporte à diversas implementações do método, cada uma com uma assinatura de método exclusiva.

4. O que é um valor de retorno?

   É um tipo de valor retornado por um método.

5. O que é um objeto?

    É uma instância de uma classe.

6. Qual das seguintes afirmações é verdadeira?

    1. A Biblioteca de Classes do .NET sempre define métodos sobrecarregados para cada método.
    2. A Biblioteca de Classes do .NET contém definições para tipos de dados usados no C#.
    3. A biblioteca de classes do .NET inclui tantas classes que, na verdade, aumenta o tempo de desenvolvimento.

    Item 2 é verdadeira.

7. Quais símbolos representam o operador de invocação de método necessário para executar um método?

    Parenteses **( )**

8. O que é um bloco de código?

    Linhas de código que devem ser tratadas como uma única unidade.
    Um bloco de código é definido por chaves { }. Ele coleta linhas de código que devem ser tratadas como uma única unidade.

9. O que é uma instrução ou expressão booliana?

    Código que retorna **true** ou **false**.
    Uma expressão booliana é qualquer código que retorna um valor booliano, true ou false.

10. Um desenvolvedor está trabalhando com outros dois para atualizar uma coleção de aplicativos. Os desenvolvedores usarão comentários de código durante o processo de atualização. Qual das opções a seguir descreve um uso apropriado dos comentários de código?

    1. Quando as atualizações são feitas, os desenvolvedores usam comentários de linha e de bloco para identificar cada atualização de código individual.
    2. Quando as atualizações são feitas, os desenvolvedores deixam todos os comentários de código existentes intactos. Novos comentários são adicionados para indicar quando comentários antigos não se aplicam mais.
    3. Quando as atualizações são feitas, os desenvolvedores resumem as alterações usando comentários de bloco.

    **R: Item 3 é verdadeira.**

11. Um desenvolvedor escreve um código que inclui um bloco de código da instrução if. Eles inicializam uma variável de inteiro para um valor de 5 acima (fora) do bloco de código. Eles inicializam uma segunda variável de inteiro para um valor de 6 na primeira linha dentro do bloco de código. A expressão booleana para o bloco de código é avaliada como true se a primeira variável inteira tiver um valor maior que 0. Na segunda linha dentro do bloco de código, a soma dos dois valores é atribuída à primeira variável. Na primeira linha depois (fora) do bloco de código, ele escreve um código para exibir o valor do primeiro integer. Qual é o resultado quando a instrução de código usada para exibir o primeiro integer é executada?

    1. Nenhum erro é gerado e o valor inteiro é exibido. O valor exibido é a soma do primeiro com o segundo inteiro.
    2. Nenhum erro é gerado e o valor inteiro é exibido. O valor exibido é o valor inicializado acima do bloco de código.
    3. Um erro é gerado porque a primeira variável não está no escopo após o bloco de código.

    **R: Item 1 é o correto!** Como o primeiro inteiro é inicializado acima do código da instrução if, ele continua dentro do escopo mesmo após o bloco de código. Além disso, como ambos os inteiros estão no escopo e inicializados com valores dentro do bloco de código, a adição dos valores é executada corretamente. Por fim, embora o segundo inteiro não exista fora do bloco de código, o primeiro inteiro mantém as alterações em seu valor que ocorreram dentro do bloco de código.

1. Como incluir caracteres Unicode em uma cadeia de caracteres?
`\u`seguido por um código de quatro caracteres.
2. Qual sequência de escape você usaria para inserir um caractere de guia em uma cadeia de caracteres C#?
`\t`. Essa sequência de escape é útil para alinhar texto em colunas, tabelas ou qualquer formatação que precise de espaçamento uniforme.
3. O que será exibido com `Console.WriteLine("C:\new\folder")`? E quais as formas para resolver?
`C:\ewolder`
4. Qual símbolo é prefixado em uma cadeia de caracteres em C# para habilitar a interpolação?
`$`
5. Seu aplicativo precisa exibir uma mensagem combinando o nome e o sobrenome de um usuário em uma saudação. Qual método você deve optar por combinar essas cadeias de caracteres para melhor legibilidade e manutenção?
Interpolação de cadeia de caracteres.
6. Em qual situação seria mais eficiente usar a interpolação de cadeia de caracteres em vez de concatenação?
Construir mensagens complexas com várias variáveis e literais.
7. Qual sequência de escape representa um caractere de nova linha?
`\n`
8. Se você precisar formatar sua cadeia de caracteres para exibir um caminho de arquivo, qual sequência de escape deve ser usada para barras invertidas em C#?

    Para exibir um caminho de arquivo com barras invertidas, a sequência de escape que você deve usar é a **barra invertida dupla (`\\`)**.
    A barra invertida simples (`\`) é um caractere especial para o compilador (usado para escapes como `\n` para nova linha).
    Para que ele entenda que você quer uma barra invertida literal, você deve "escapar" o próprio caractere, dobrando-o.

    ```csharp
    string caminho = "C:\\Users\\SeuUsuario\\Documentos";
    Console.WriteLine(caminho);
    ```

    **Alternativa Recomendada (String Verbatim)**

    Embora a barra invertida dupla funcione, a forma mais comum e recomendada para caminhos de arquivo é usar uma **string verbatim**, prefixada com o símbolo `@`.
    Uma string verbatim ignora todas as sequências de escape, tratando cada caractere como um literal.

    ```csharp
    string caminhoVerbatim = @"C:\Users\SeuUsuario\Documentos";
    Console.WriteLine(caminhoVerbatim);
    ```

    O resultado é o mesmo, mas o código fica mais limpo e legível, eliminando a necessidade de duplicar as barras invertidas. Por isso, essa é a prática preferida entre os desenvolvedores para lidar com caminhos de arquivo.
