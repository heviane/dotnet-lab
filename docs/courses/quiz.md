# Quiz

Este quiz aborda conceitos essenciais da linguagem C# e da plataforma .NET para validar seu conhecimento.

---

## Conceitos de Métodos e Classes

**O que são *parâmetros* de métodos?**
> **Resposta:** São as variáveis declaradas na definição de um método, que recebem os valores quando o método é chamado.

**O que são *argumentos* de métodos?**
> **Resposta:** São os valores concretos passados para os parâmetros de um método quando ele é invocado.
> > *Explicação:* A definição do método especifica os **parâmetros**. A instrução de chamada fornece os **argumentos**.

**O que é um método *sobrecarregado*?**
> **Resposta:** É um método que possui múltiplas implementações na mesma classe, cada uma com uma assinatura de método diferente (ou seja, diferentes tipos ou número de parâmetros).

**O que é um *valor de retorno*?**
> **Resposta:** É o valor que um método retorna ao código que o chamou após sua execução ser concluída.

**O que é um *objeto*?**
> **Resposta:** É uma instância de uma classe.

**Quais símbolos representam o *operador de invocação de método*?**
> **Resposta:** Parênteses `()`.

---

## Manipulação de Strings

**Como incluir caracteres Unicode em uma string?**
> **Resposta:** Usando a sequência de escape `\u` seguida por um código hexadecimal de quatro caracteres. Ex: `\u00A9` para o símbolo ©.

**Qual sequência de escape representa um caractere de *tabulação*?**
> **Resposta:** `\t`. É útil para alinhar texto em colunas.

**Qual sequência de escape representa um caractere de *nova linha*?**
> **Resposta:** `\n`.

**Qual o resultado de `Console.WriteLine("C:\new\folder")` e como corrigir?**
> **Resposta:** O resultado será `C:`, seguido de uma nova linha e `ewolder`, pois `\n` é interpretado como nova linha.
>
> **Correções:**
> 1.  **Usar barra invertida dupla:** `Console.WriteLine("C:\\new\\folder");`
> 2.  **Usar uma string verbatim (recomendado):** `Console.WriteLine(@"C:\new\folder");`

**Qual símbolo é usado como prefixo em uma string para habilitar a *interpolação*?**
> **Resposta:** O cifrão `$`.

**Em qual situação a *interpolação de string* é mais eficiente que a concatenação?**
> **Resposta:** Ao construir mensagens complexas com múltiplas variáveis e literais, pois o código se torna mais legível e de fácil manutenção.

---

## Estruturas de Controle e Escopo

**O que é um *bloco de código*?**
> **Resposta:** Uma ou mais linhas de código agrupadas por chaves `{ }` que devem ser tratadas como uma única unidade.

**O que é uma *expressão booleana*?**
> **Resposta:** Qualquer código que é avaliado e retorna um valor booleano (`true` ou `false`).

**Qual instrução é usada para sair de um loop `for` antes que sua iteração normal seja concluída?**
> - `exit;`
> - `break;`
> - `return;`
>
> **Resposta:** `break;`

**Um desenvolvedor precisa capturar a entrada do usuário repetidamente até que uma condição de saída seja atendida (ex: pressionar uma tecla especial). Qual a melhor instrução de iteração para esse caso?**
> **Resposta:** `do-while`. Garante que o bloco de código seja executado pelo menos uma vez e é ideal para loops que dependem de uma condição que só pode ser verificada no final da iteração.

**Um desenvolvedor precisa iterar por todos os itens de uma coleção, mas não precisa do índice de cada item. Qual a instrução de iteração mais adequada?**
> **Resposta:** `foreach`. É mais simples e legível para percorrer coleções quando o índice não é necessário.

**Quando é mais apropriado usar um `switch-case` em vez de um `if-elseif-else`?**
> **Resposta:** Quando se está comparando uma única variável contra múltiplos valores constantes. Geralmente, é mais legível que uma longa cadeia de `if-elseif-else`.

**Por que um desenvolvedor escolheria uma instrução `for` em vez de `foreach` para processar uma matriz multidimensional?**
> **Resposta:** A instrução `for` permite um controle granular sobre os índices de cada dimensão da matriz, facilitando a navegação por linhas e colunas separadamente.

**Por que é importante definir o escopo de uma variável no nível mais baixo possível?**
> **Resposta:** Para reduzir o consumo de memória e a complexidade do código, evitando "poluição" do escopo e potenciais conflitos de nomes. Isso mantém o volume de segurança e os recursos do aplicativo menores.

**Analise o cenário de escopo:**
> Um desenvolvedor inicializa `int var1 = 5;` fora de um bloco `if`. Dentro do bloco `if`, ele inicializa `int var2 = 6;` e depois executa `var1 = var1 + var2;`. A condição do `if` é verdadeira. Qual o valor de `var1` exibido na primeira linha *após* o bloco `if`?
>
> 1.  Um erro é gerado, pois `var2` não está no escopo.
> 2.  O valor 5 é exibido.
> 3.  O valor 11 é exibido.
>
> **Resposta:** **3. O valor 11 é exibido.** `var1` foi declarada em um escopo externo, portanto, continua acessível após o bloco `if`. A alteração feita em seu valor dentro do bloco é mantida.

---

## Boas Práticas e .NET

**Um desenvolvedor está atualizando um projeto em equipe. Qual é o uso mais apropriado para comentários de código durante o processo?**
> 1.  Comentar cada linha de código individualmente.
> 2.  Deixar comentários antigos e adicionar novos dizendo que os antigos não se aplicam.
> 3.  Resumir as alterações em um comentário de bloco no topo do arquivo ou método.
>
> **Resposta:** **3. Resumir as alterações em um comentário de bloco.** Comentários devem explicar o "porquê" do código, não o "o quê". Resumir uma mudança complexa é um bom uso.

**Qual das seguintes afirmações sobre a Biblioteca de Classes do .NET é verdadeira?**
> 1.  Ela sempre define métodos sobrecarregados para cada método.
> 2.  Ela contém as definições para os tipos de dados fundamentais usados em C#.
> 3.  Ela é tão grande que aumenta o tempo de desenvolvimento.
>
> **Resposta:** **2. Ela contém as definições para os tipos de dados fundamentais usados em C#** (como `System.Int32` para `int`, `System.String` para `string`, etc.).

**Quais dos símbolos a seguir representam o operador de invocação de método necessário para executar um método?**
> 1. .
> 2. {}
> 3. ()
>
> **Resposta: 3**
