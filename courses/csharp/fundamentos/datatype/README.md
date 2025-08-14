# Tipos de Dados

Tipos de dados são categorias que definem o tipo de valor que uma variável pode armazenar, como números, texto, ou valores verdadeiros/falsos. Eles são fundamentais em C# porque a linguagem é **fortemente tipada**, o que significa que toda variável deve ter um tipo de dado definido, e esse tipo é estritamente verificado em tempo de compilação.

Isso traz várias vantagens:

* **Segurança:** Impede que você cometa erros, como tentar somar uma string com um número.
* **Otimização:** O compilador sabe exatamente quanta memória precisa reservar para a variável.
* **Legibilidade:** Outros desenvolvedores conseguem entender rapidamente a intenção da sua variável.

---

## Principais Categorias e Exemplos de Tipos de Dados

Os tipos de dados em C# podem ser divididos em três categorias principais: tipos de valor, tipos de referência e ponteiros. No uso diário, você trabalhará principalmente com os dois primeiros.

### Tipos de Valor (Value Types)

    Variáveis de tipos de valor armazenam seu valor diretamente na memória. Quando você atribui uma variável a outra, o valor é copiado.

    * **Tipos Numéricos Integrais:**
        * `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`
        * **Exemplo:** `int idade = 30;` (geralmente usado para números inteiros)

    * **Tipos Numéricos de Ponto Flutuante:**
        * `float`, `double` (mais comum e com maior precisão)
        * **Exemplo:** `double preco = 19.99;`

    * **Tipo Decimal:**
        * `decimal` (ideal para cálculos financeiros, pois tem maior precisão e evita erros de arredondamento)
        * **Exemplo:** `decimal salario = 1500.50m;` (o sufixo `m` é obrigatório)

    * **Tipo Booleano:**
        * `bool` (armazena `true` ou `false`)
        * **Exemplo:** `bool isAtivo = true;`

    * **Tipo Caractere:**
        * `char` (armazena um único caractere Unicode)
        * **Exemplo:** `char inicial = 'A';`

---

### Tipos de Referência (Reference Types)

    Variáveis de tipos de referência armazenam uma referência (um endereço de memória) para o local onde o valor real está armazenado. Quando você atribui uma variável a outra, a referência é copiada, não o valor.

    * **`string`:**
        * Representa uma sequência de caracteres. É um tipo de referência, mas se comporta como um tipo de valor em muitos cenários (é imutável).
        * **Exemplo:** `string nome = "Maria";`

    * **Classes:**
        * A base para a programação orientada a objetos.
        * **Exemplo:** `MinhaClasse meuObjeto = new MinhaClasse();`

    * **Interfaces:**
        * Definem um contrato de comportamento.
        * **Exemplo:** `IMeuContrato contrato = new MinhaClasseQueImplementa();`

    * **Arrays:**
        * Uma coleção de elementos do mesmo tipo.
        * **Exemplo:** `int[] numeros = { 1, 2, 3 };`

---

### Tipos Especiais

    * **`var`:**
        * A palavra-chave `var` permite que o compilador infira o tipo da variável a partir do valor que está sendo atribuído a ela. Isso não significa que a variável não tem um tipo, mas sim que o tipo é definido em tempo de compilação.
        * **Exemplo:** `var numero = 100;` (o compilador infere `int`)
        * **Exemplo:** `var texto = "Olá";` (o compilador infere `string`)

    Entender a diferença entre tipos de valor e tipos de referência é um dos conceitos mais importantes para programadores C#, pois afeta diretamente como os dados são manipulados na memória.
