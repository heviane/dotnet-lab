# Criar código legível com convenções, espaço em branco e comentários

Escreva um código que seja mais fácil de ler, atualizar e dar suporte ao uso de convenções de nomenclatura, comentários e espaço em branco.

O código escrito deve comunicar sua intenção ao compilador e a outros desenvolvedores por quem ele possa ser lido. Além disso, como você é o desenvolvedor que lerá o código com mais frequência, frequentemente meses depois de ter escrito originalmente, é do seu interesse escrever um código claro e fácil de entender. Lembre-se de que você escreve o código uma vez, mas precisa lê-lo muitas vezes.

## Objetivos de aprendizagem

- Escolher nomes descritivos para as variáveis que descrevam a finalidade e a intenção delas.
- Usar comentários de código para instruir temporariamente o compilador a ignorar linhas de código;
- Usar comentários de código para justificar a finalidade ou requisitos de nível superior para um trecho de código.
- Escrever código que use espaço em branco de modo eficaz para transmitir a relação de linhas de código.

## Escolher nomes de variável que sigam as regras e convenções

Um desenvolvedor de software disse uma vez: "A parte mais difícil do desenvolvimento de software é nomear coisas." Não só o nome de uma variável precisa seguir determinadas regras de sintaxe, como também deve ser usado para tornar o código mais legível e compreensível. Isso é pedir demais de uma única linha de código!

### Regras para nome de variáveis

Há algumas regras de nomenclatura variável que são impostas pelo compilador C#.

- Nomes de variáveis podem conter caracteres alfanuméricos e o caractere de sublinhado (_). Caracteres especiais como jogo da velha #, o traço - e o cifrão $ não são permitidos.
- Nomes de variáveis devem começar com uma letra alfabética ou um sublinhado, não um número. O uso de um caractere de sublinhado para iniciar um nome de variável normalmente é reservado para campos de instância privada.
- Nomes de variáveis NÃO devem ser uma palavra-chave C#. Por exemplo, essas declarações de nome de variável não serão permitidas: `float float;` ou `string string;`.
- Os nomes de variáveis diferenciam maiúsculas de minúsculas, o que significa que `string MyValue;` e `string myValue;` são duas variáveis diferentes.

### Convenções de nome de variável

Convenções são sugestões que são acordadas pela comunidade de desenvolvimento de software.

Embora você esteja livre para decidir não seguir essas convenções, elas são tão populares que pode dificultar a compreensão do código por outros desenvolvedores. Você deve praticar a adoção dessas convenções e torná-las parte de seus próprios hábitos de codificação.

- Nomes de variáveis devem usar **camelCase**.
- Nomes de variáveis devem ser descritivos e significativos em seu aplicativo. Você deve escolher um nome para a variável que representa o tipo de dados que ele conterá (não o tipo de dados). Por exemplo: `bool orderComplete;` e não `bool isComplete;`.
- Nomes de variáveis devem ser uma ou mais palavras inteiras acrescentadas. Não use contratações porque o nome da variável pode não ser claro para outras pessoas que estão lendo seu código. Por exemplo: `decimal orderAmount;` e não `decimal odrAmt;`.
- Nomes de variáveis não devem incluir o tipo de dados da variável. Você pode ver alguns conselhos para usar um estilo como `string strMyValue;`. Era um estilo popular anos atrás. No entanto, a maioria dos desenvolvedores não segue mais esse conselho e há boas razões para não usá-lo.

O exemplo `string firstName;` segue todas essas regras e convenções, supondo que você queira usar essa variável para armazenar dados que representam o nome de alguém.

Aqui estão alguns exemplos de declarações variáveis (usando tipos de dados comuns):

```csharp
char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer;
```

### Outras convenções de nomenclatura

As regras e convenções descritas acima são para **variáveis locais**. Uma variável local é uma variável com escopo dentro do corpo de um método ou uma variável em um aplicativo de console que usa instruções de nível superior (como o código neste módulo).

Há outros tipos de constructos que você pode usar em seus aplicativos e muitos têm suas próprias convenções. Por exemplo, as classes geralmente são usadas na programação em C# e têm convenções associadas. Embora você não esteja criando classes neste módulo, é importante que você saiba que as convenções de nomenclatura que você acabou de aprender se encaixam em uma estrutura de nomenclatura maior.

## Escolher nomes de classes que sigam as regras e convenções

### Regras para nome de classes

### Convenções de nome de classes

- Nomes de `classes` devem usar **PascalCase**.
- Nomes de `propriedades` de classe devem usar **PascalCase**.
- Nomes de `métodos` de classe devem usar **PascalCase**.
- Não abreviar nomes.
- `Underline` é o único caractere especial aceito para nomes de classes, atributos, métodos.
- É recomendado que o nome do arquivo fonte `.cs` tenha o mesmo nome da `classe` declarada dentro dele.

## OBS

As sintaxes são obrigatórias e as convenções são recomendações.

convenções de escrita de nomes de classes, métodos e variáveis.
Esses padrões não impedem o funcionamento do código, mas servem como boas práticas e padronização na linguagem.
As duas convenções de escrita usados na linguagem C# são: camelCase e PascalCase.
