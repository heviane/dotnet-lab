# Entendendo Valores Literais

Em programação, um **valor literal** (ou simplesmente "literal") é um valor fixo que é escrito diretamente no código-fonte. Ele não é uma variável, mas sim o próprio dado, representado em sua forma "literal".

Pense nele como um valor "hard-coded".

**Exemplos de Literais em C#:**

- `10` (um literal do tipo inteiro)
- `3.14m` (um literal do tipo decimal)
- `true` (um literal do tipo booleano)
- `'A'` (um literal do tipo char)
- `"Olá, Mundo!"` (um literal do tipo string)

## Qual a diferença entre "Valores Literais" e "Strings"?

Essa é uma excelente pergunta conceitual. A melhor forma de entender é:

> "String" é um **tipo de dado**, enquanto um "valor literal" é a **forma como um valor é escrito** no código.

Vamos detalhar:

- **String**: É um **tipo de dado** (`System.String`) usado para representar texto (uma sequência de caracteres). Quando você declara uma variável `string nome;`, você está dizendo que a variável `nome` irá armazenar dados do tipo texto.

- **Valor Literal**: É um valor fixo no código. Um **string literal** é, portanto, um valor literal cujo tipo é `string`.

### Analogia

Pense na seguinte analogia:

- **Valor Literal** é como a palavra "carro". É uma categoria geral.
- **String Literal** é como a expressão "carro vermelho". É um tipo específico de carro.

Assim como existem outros tipos de "carros" (literais), como "carro azul" (`100`, um literal inteiro) ou "carro verde" (`true`, um literal booleano), um **string literal** (`"Olá"`) é apenas um dos vários tipos de valores literais que existem.

### Tabela Resumo

| Conceito | Definição | Exemplo em C# |
| :--- | :--- | :--- |
| **Valor Literal** | Um valor fixo escrito diretamente no código. | `123`, `true`, `"texto"` |
| **String** | Um **tipo de dado** que representa texto. | `string nome = "Ana";` (Aqui, `string` é o tipo) |
| **String Literal** | Um **valor literal** cujo tipo é `string`. | `"Ana"` (É a representação literal do texto) |

### Exemplo Prático

```csharp
//    [tipo] [variável] = [valor literal];
      string  saudacao  = "Olá, Mundo!"; // "Olá, Mundo!" é um string literal
      int     idade     = 30;            // 30 é um integer literal
      bool    ativo     = true;          // true é um boolean literal
```

Neste código, `"Olá, Mundo!"`, `30` e `true` são todos **valores literais**. A variável `saudacao` armazena um valor cujo tipo é `string` e cuja representação no código é um **string literal**.
