# Expressões

No contexto de programação, uma **expressão** é qualquer trecho de código que pode ser avaliado para produzir um único valor. Pense nela como uma "frase" no código que tem um significado e um resultado. Esse resultado pode ser um número, uma string, um valor booleano, ou até mesmo uma instância de um objeto.

A principal característica de uma expressão é que ela sempre retorna um valor.

Por exemplo:

* `1 + 2` é uma expressão que retorna o valor `3`.
* `"Olá" + " " + "Mundo"` é uma expressão que retorna o valor `"Olá Mundo"`.
* `x > 5` é uma expressão que retorna um valor booleano, `true` ou `false`.

Diferente de uma **declaração** ou **instrução** (como um `if` ou um `for`), que realiza uma ação, uma expressão é fundamentalmente sobre o cálculo e a obtenção de um valor.

-----

## Tipos de Expressões

As expressões podem ser classificadas em várias categorias, dependendo do tipo de valor que elas retornam e dos operadores que utilizam.

### 1. Expressões Literais e Constantes

São as formas mais simples de expressões. Elas representam valores fixos.

* **Exemplos:**
  * `10` (literal inteiro)
  * `3.14` (literal de ponto flutuante)
  * `"Hello World"` (literal de string)
  * `true` (literal booleano)

### 2. Expressões de Variáveis

O nome de uma variável por si só é uma expressão, pois ele é avaliado para o valor que a variável armazena.

* **Exemplo:**
  * Se `int x = 10;`, a expressão `x` retorna o valor `10`.

### 3. Expressões Aritméticas

Usam operadores aritméticos para realizar cálculos matemáticos.

* **Exemplos:**
  * `5 * (2 + 3)`
  * `temperatura - 20`
  * `idade / 2`

### 4. Expressões Lógicas e de Comparação

Produzem um valor booleano (`true` ou `false`).

* **Expressão de Comparação:**
  * `idade > 18`
  * `nome == "Alice"`

* **Expressão Lógica:**
  * `(saldo > 0) && (ativo == true)`

### 5\. Expressões de Atribuição

Atribuem um valor a uma variável. Embora a atribuição seja uma instrução, a expressão de atribuição retorna o valor que foi atribuído.

* `int y = 5;` (A expressão `y = 5` retorna o valor `5` e o atribui à variável `y`)

### 6\. Expressões de Chamada de Método

Uma chamada de método é uma expressão se o método tiver um tipo de retorno (ou seja, se ele não for `void`). O valor da expressão é o valor retornado pelo método.

* `string.Join(",", "a", "b", "c")` retorna a string `"a,b,c"`.
* `Math.Max(10, 20)` retorna o valor `20`.

### 7\. Expressões de Criação de Objeto

Usam a palavra-chave `new` para criar uma nova instância de uma classe.

* `new List<string>()` retorna uma nova instância de uma lista de strings.

### 8\. Expressões Condicionais

São expressões que retornam um valor com base na avaliação de uma condição booleana. As principais são o **operador ternário (`?:`)** e as **`switch expressions`**.

Para uma explicação detalhada, consulte o documento dedicado:
➡️ Expressões Condicionais

## RESUMO

A diferença entre expressões e instruções é um conceito-chave na programação. As expressões constroem os valores, enquanto as instruções usam esses valores para executar ações.
