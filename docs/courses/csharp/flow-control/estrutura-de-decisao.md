# Estruturas de Decisão (ou Condicionais)

Elas permitem que o código escolha um caminho para seguir com base em uma condição.

## Principais Estruturas Condicionais

### Instruções if, else e else if

São instruções de controle de fluxo.
São comandos que determinam qual bloco de código será executado com base em uma condição.
Lógica de decisão.

- **`if`**: Executa um bloco de código se uma condição for verdadeira.
- **`else`**: Executa um bloco de código se a condição for falsa.
- **`else if`**: Executa um bloco de código se a condição for verdadeira.

#### Recapitulação

- Use uma instrução if para ramificar sua lógica de código. A instrução de decisão if executará o código em seu bloco de código se sua expressão booliana for verdadeira. Caso contrário, o runtime ignorará o bloco de código e continuará para a próxima linha de código após o bloco de código.
- Uma expressão booliana é qualquer expressão que retorna um valor booliano.
- Os operadores boolianos comparam os dois valores, à esquerda e à direita, em termos de igualdade, comparação e muito mais.
- Um bloco de código é definido por chaves { }. Ele coleta linhas de código que devem ser tratadas como uma única unidade.
- O operador lógico AND && agrega duas expressões de forma que as duas subexpressões devam ser verdadeiras para que toda a expressão seja verdadeira.
- O operador lógico OR || agrega duas expressões de forma que, se alguma das subexpressões for verdadeira, toda a expressão será verdadeira.

---

### Instrução switch-case

Saiba como adicionar lógica de ramificação que compara uma variável ou expressão a muitos valores possíveis.
A instrução `switch` permite que você teste uma variável contra vários valores possíveis (casos).
É uma alternativa mais limpa e organizada ao uso de múltiplos `if-else`.

```csharp
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
    default:
        Console.WriteLine("Not found");
        break;
}
```

A expressão de correspondência (também chamada de expressão de **comutador**) é o valor após a palavra-chave switch, nesse caso(fruit).

Cada seção de comutador é definida por um padrão de caso. Os padrões de caso são construídos usando a palavra-chave case seguida por um valor. O primeiro padrão de caso neste exemplo é: case "apple":. Os padrões de caso são expressões booleanas que são avaliadas para resultar em true ou false. Cada seção de comutador inclui um pequeno número de linhas de código que serão executadas se o padrão de caso for uma correspondência para a expressão de correspondência.

Neste exemplo, se fruit for atribuído um valor de "apple", o primeiro padrão de caso será considerado como true e essa seção de troca será executada.
Uma instrução alternar deve incluir pelo menos uma seção de comutador, mas normalmente conterá três ou mais seções de comutador.

A opção é mais usada quando:

- Você tem um único valor (variável ou expressão) que deseja corresponder a muitos valores possíveis.
- Para uma determinada correspondência, você precisa executar no máximo algumas linhas de código.

O switch bloco de código contém uma lista de seções de comutador, cada uma das quais inclui um ou mais rótulos de comutador.
Além disso, cada seção de comutador inclui uma lista de instruções que será executada se o rótulo for igual à expressão de comutador definida na parte superior da instrução alternar.

A expressão de comutador é avaliada em relação aos rótulos de maiúsculas e minúsculas até que um valor igual à expressão de comutador seja encontrado. Se nenhum dos rótulos corresponder, a lista de instruções do caso default será executada. Se nenhum padrão for incluído, o controle será transferido para o ponto final da instrução alternar. Cada rótulo deve fornecer um tipo de valor que corresponda ao tipo especificado na expressão de comutador.

> **Observação:** O rótulo opcional `default` pode aparecer em qualquer posição na lista de seções de comutador. No entanto, a maioria dos desenvolvedores opta por colocá-lo por último porque faz mais sentido (logicamente) posicionar default como a opção final. Independentemente da posição, a default seção será avaliada por último.

Observe que cada seção do interruptor está separada da próxima:

Somente uma seção de comutador tem permissão para ser executada. Isso significa que a execução de uma seção alternar não pode “cair” na próxima seção alternar. A palavra-chave break é uma das várias maneiras de encerrar uma seção de comutador antes de chegar à próxima seção. Se você esquecer a palavra-chave break (ou, opcionalmente, a palavra-chave return), o compilador gerará um erro.

#### Recapitulando

- Use a instrução switch quando você tiver um valor com muitas correspondências possíveis, cada correspondência que exija uma ramificação em sua lógica de código.
- Uma única seção de opção que contém a lógica de código que pode ser correspondida usando um ou mais rótulos definidos pela palavra-chave case.
- Use a palavra-chave opcional default para criar um rótulo e uma seção de opção que serão usados quando nenhum outro rótulo de caso corresponder.

- A palavra-chave `break` redireciona a execução de código e impede que uma seção de comutador continue na próxima seção.
- Se não houver rótulos de valor correspondentes `case` , o rótulo opcional `default` será usado como o valor correspondente.
- Uma única seção de opção pode ter vários rótulos.

Para refletir: pontos fortes/fracos da declaração `switch` quando comparado à construção `if-elseif-else`.

- O que acontece se uma instrução break (ou palavra-chave alternativa que impede "fall-through") for omitida em um caso de alternância?
    R: Um erro de compilação será gerado.
