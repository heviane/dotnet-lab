# Variáveis

## Declarar variáveis

Um literal é, literalmente, um valor embutido em código.

Valores embutidos em código são valores constantes e inalterados durante a execução do programa. No entanto, a maioria dos aplicativos exigirá que você trabalhe com valores que você não conhece muito com antecedência. Em outras palavras, você precisará trabalhar com dados provenientes de usuários, de arquivos ou de toda a rede.
Quando você precisar trabalhar com dados que não são embutidos em código, você declarará uma variável.

## O que é uma variável?

Uma variável é um contêiner para armazenar um tipo de valor.

As variáveis são importantes porque seus valores podem mudar ou variar durante a execução de um programa. As variáveis podem ser atribuídas, lidas e alteradas. Você usa variáveis para armazenar valores que pretende usar em seu código.
Um nome de variável é um rótulo amigável que o compilador atribui a um endereço de memória. Quando você deseja armazenar ou alterar um valor nesse endereço de memória ou sempre que quiser recuperar o valor armazenado, basta usar o nome da variável que você criou.

## Declarar uma variável

Para criar uma nova variável, primeiro você deve declarar o tipo de dados da variável e, em seguida, dar-lhe um nome:

```csharp
string firstName;
```

Nesse caso, você está criando uma nova variável de tipo string chamada firstName. De agora em diante, essa variável só pode conter valores de cadeia de caracteres.
Você pode escolher qualquer nome desde que ele adere a algumas regras de sintaxe C# para variáveis de nomenclatura.

## Regras e convenções de nome variável

Um desenvolvedor de software disse uma vez famosamente "A parte mais difícil do desenvolvimento de software é nomear coisas." Não só o nome de uma variável precisa seguir determinadas regras de sintaxe, como também deve ser usado para tornar o código mais legível e compreensível. Isso é pedir demais de uma única linha de código!

**Aqui estão algumas considerações importantes sobre nomes de variáveis:**

- Nomes de variáveis podem conter caracteres alfanuméricos e o caractere de sublinhado. Caracteres especiais não são permitidos.
- Nomes de variáveis devem começar com uma letra alfabética ou um sublinhado, não um número.
- Nomes de variáveis diferenciam maiúsculas de minúsculas, o que significa que `string Value;` e `string value;` são duas variáveis diferentes.
- Nomes de variáveis não podem ser uma palavra-chave do C#.

Há convenções de codificação que ajudam a manter as variáveis legíveis e fáceis de identificar. À medida que você desenvolve aplicativos maiores, essas convenções de codificação podem ajudá-lo a acompanhar variáveis entre outros textos.

**Aqui estão algumas convenções de codificação para variáveis:**

- Nomes de variáveis devem usar **camelCase**, que é um estilo de escrita que usa uma letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente. Por exemplo, `string thisIsCamelCase;`.
- Nomes das variáveis devem começar com uma letra alfabética. Os desenvolvedores usam o sublinhado para uma finalidade especial, portanto, tente não usá-lo por enquanto.
- Nomes de variáveis devem ser descritivos e significativos. Escolha um nome para sua variável que represente o tipo de dados que ele conterá.
- Nomes de variáveis devem ser uma ou mais palavras inteiras acrescentadas. Não use contrações ou abreviações porque o nome da variável (e, portanto, sua finalidade) pode não estar claro para outras pessoas que estão lendo seu código.
- Nomes de variáveis não devem incluir o tipo de dados da variável. Você pode ver alguns conselhos para usar um estilo como `string strValue;`. Esse conselho não é mais atual.

O exemplo `string firstName;` segue todas essas regras e convenções, supondo que você queira usar essa variável para armazenar dados que representam o nome de alguém.

**Exemplos de nome de variável:**

```csharp
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;
```

## Recapitulando

Aqui está o que você aprendeu até agora sobre variáveis:

- Variáveis são valores temporários que você armazena na memória do computador.
- Antes de usar uma variável, você precisa declará-la.
- Para declarar uma variável, primeiro selecione um tipo de dados para o tipo de dados que deseja armazenar e dê à variável um nome que siga as regras.

> Agora que você sabe como declarar uma variável, vamos aprender a definir, recuperar e inicializar o valor de uma variável.
