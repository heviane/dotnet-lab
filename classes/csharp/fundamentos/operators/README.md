# Operadores

Existem vários tipos de operadores em C#.
Eles são usados para realizar operações em variáveis e valores.

Abaixo, listei as categorias mais importantes e alguns exemplos de cada uma.

---

## 1. Operadores Aritméticos

Usados para realizar operações matemáticas.

* `+` (Adição): `x + y`
* `-` (Subtração): `x - y`
* `*` (Multiplicação): `x * y`
* `/` (Divisão): `x / y`
* `%` (Módulo - resto da divisão): `x % y`
* `++` (Incremento): `x++`
* `--` (Decremento): `x--`

---

## 2. Operadores de Atribuição

Usados para atribuir valores a variáveis.

* `=` (Atribuição simples): `x = 10`
* `+=` (Adição e atribuição): `x += 5` (o mesmo que `x = x + 5`)
* `-=` (Subtração e atribuição): `x -= 5` (o mesmo que `x = x - 5`)
* `*=` (Multiplicação e atribuição): `x *= 5` (o mesmo que `x = x * 5`)
* `/=` (Divisão e atribuição): `x /= 5` (o mesmo que `x = x / 5`)
* `%=` (Módulo e atribuição): `x %= 5` (o mesmo que `x = x % 5`)

---

## 3. Operadores de Comparação

Usados para comparar dois valores, retornando um valor booleano (`true` ou `false`).

* `==` (Igual a): `x == y`
* `!=` (Diferente de): `x != y`
* `>` (Maior que): `x > y`
* `<` (Menor que): `x < y`
* `>=` (Maior ou igual a): `x >= y`
* `<=` (Menor ou igual a): `x <= y`

---

## 4. Operadores Lógicos

Usados para combinar expressões booleanas.

* `&&` (E lógico - AND condicional): `x > 5 && y < 10`
* `||` (Ou lógico - OR condicional): `x == 1 || y == 1`
* `!` (Negação lógica - NOT): `! (x > 5)`

---

## 5. Operadores Bitwise

Usados para realizar operações a nível de bits.

* `&` (E binário)
* `|` (Ou binário)
* `^` (Ou exclusivo binário)
* `~` (Complemento de um)
* `<<` (Deslocamento de bits para a esquerda)
* `>>` (Deslocamento de bits para a direita)
* `^=` (XOR e atribuição)

---

## 6. Operadores Condicionais

Esses operadores são atalhos para lógica condicional.

* **Operador Ternário (`? :`)**: `(idade >= 18) ? "Adulto" : "Jovem"`
* **Operador de Coalescência Nula (`??`)**: `nome ?? "Anônimo"` (retorna "Anônimo" se `nome` for `null`)

---

## 7. Operadores de Acesso a Membros e Chaves

* `.` (Ponto): Usado para acessar membros de um objeto. Ex: `Console.WriteLine()`
* `[]` (Colchetes): Usado para acessar elementos de arrays, listas, ou dicionários. Ex: `meuArray[0]`

---

## 8. Outros Operadores

* **`as`**: Converte um objeto para um tipo compatível, retornando `null` se a conversão falhar.
* **`is`**: Verifica se um objeto é de um determinado tipo. Retorna `true` ou `false`.
* **`new`**: Cria uma nova instância de um objeto. Ex: `new MinhaClasse()`
* **`sizeof`**: Retorna o tamanho em bytes de um tipo de valor.
* **`typeof`**: Retorna o tipo de um objeto. Ex: `typeof(string)`

Esta lista cobre a maioria dos operadores que você encontrará no dia a dia com C#.
Entender como eles funcionam e a ordem de precedência entre eles é crucial para escrever código robusto.
