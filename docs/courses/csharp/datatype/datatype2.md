# Tipos de Dados

Em C#, os tipos de dados são a base para garantir a segurança e a eficiência do código. A linguagem é **fortemente tipada**, o que significa que toda variável deve ter um tipo definido, e esse tipo é verificado em tempo de compilação.

Isso traz várias vantagens:

* **Segurança:** Impede que você cometa erros, como tentar somar uma string com um número.
* **Otimização:** O compilador sabe exatamente quanta memória precisa reservar para a variável.
* **Legibilidade:** Outros desenvolvedores conseguem entender rapidamente a intenção da sua variável.

## O que são Tipos Primitivos?

**Tipos primitivos** são os tipos de dados mais básicos e fundamentais, diretamente suportados pelo compilador. Pense neles como os "átomos" ou "blocos de construção" da linguagem. Em C#, a maioria dos tipos primitivos são **Tipos de Valor** e são, na verdade, apelidos (aliases) para `structs` predefinidas no namespace `System`.

Por exemplo, a palavra-chave `int` é um apelido para a `struct` `System.Int32`.

---

## Tipos Primitivos (Tipos de Valor)

Variáveis de tipos de valor armazenam seu valor **diretamente** na memória (geralmente na Stack). Quando você atribui uma variável a outra, o valor é **copiado**.

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

## Tipos de Referência Essenciais

Variáveis de tipos de referência armazenam uma **referência** (um endereço de memória) para o local onde o valor real está armazenado (na Heap). Quando você atribui uma variável a outra, a referência é copiada, não o valor.

* **`string`:**
  * Representa uma sequência de caracteres. É um tipo de referência, mas tem um comportamento especial de imutabilidade que o faz parecer um tipo de valor em algumas situações.
  * **Exemplo:** `string nome = "Maria";`

* **`object`:**
  * É o tipo base fundamental do qual todos os outros tipos (de valor e de referência) derivam.
  * Apesar de ser a raiz de toda a hierarquia de tipos, `object` em si é um Tipo de Referência.
  * É o tipo de referência universal do qual todos os outros tipos herdam, mas não é um tipo primitivo no sentido de ser um tipo de valor fundamental diretamente mapeado para uma struct simples.
  * **Exemplo:** `object qualquerCoisa = 10;`

Outros tipos de referência importantes incluem `class`, `interface`, `array` e `delegate`.

* **`class`:**
  * É a palavra-chave usada para definir Tipos de Referência (Reference Types) personalizados.
  * É uma categoria para definir seus próprios tipos de referência complexos.
  * Quando você cria uma class, você está definindo um novo tipo de referência. Instâncias de classes são armazenadas na `Heap`, e as variáveis que as referenciam contêm o endereço de memória para esses **objetos**.

---

## Inferência de Tipo com `var`

A palavra-chave `var` instrui o compilador a **inferir** o tipo da variável a partir da expressão à direita da atribuição. A variável ainda é fortemente tipada, mas você não precisa escrever o tipo explicitamente.

* **Exemplo:** `var numero = 100;` (o compilador infere que `numero` é do tipo `int`)
* **Exemplo:** `var texto = "Olá";` (o compilador infere que `texto` é do tipo `string`)

Entender a diferença entre tipos de valor e tipos de referência é um dos conceitos mais importantes para programadores C#, pois afeta diretamente como os dados são manipulados na memória.
