# Operadores Lógicos

Usados para combinar expressões booleanas.

* `&&` (E lógico - AND condicional): `x > 5 && y < 10`
* `||` (Ou lógico - OR condicional): `x == 1 || y == 1`
* `!` (Negação lógica - NOT): `! (x > 5)`

---

## Ordem de Precedência

Assim como na matemática, a ordem de precedência determina a sequência em que os operadores lógicos são avaliados em uma expressão.

A ordem de precedência, da mais alta para a mais baixa, é a seguinte:

1. **`!` (Operador NOT Lógico)**
2. **`&&` (Operador AND Lógico Condicional)**
3. **`||` (Operador OR Lógico Condicional)**

```csharp
bool a = true;
bool b = false;
bool c = true;

// A expressão completa é: a && b || c
// Sem parênteses, a precedência é avaliada da seguinte forma:
bool resultado = (a && b) || c;

// Primeiro, `a && b` é avaliado:
// true && false = false

// Em seguida, o resultado anterior é avaliado com `|| c`:
// false || true = true

Console.WriteLine(resultado); // A saída será 'True'
```

Se quiséssemos que a operação `||` fosse avaliada primeiro, precisaríamos usar parênteses para forçar essa ordem:

```csharp
bool a = true;
bool b = false;
bool c = true;

// A expressão completa é: a && (b || c)
bool resultadoComParenteses = a && (b || c);

// Primeiro, `b || c` é avaliado:
// false || true = true

// Em seguida, o resultado anterior é avaliado com `a &&`:
// true && true = true

Console.WriteLine(resultadoComParenteses); // A saída também será 'True' neste caso.
```

No entanto, a ordem de precedência pode ser crucial para obter o resultado desejado. Um outro exemplo:

```csharp
bool x = false;
bool y = true;
bool z = true;

bool resultado = x || y && z;
// Sem parênteses, `y && z` é avaliado primeiro, resultando em `true`.
// Depois, `x || true` é avaliado, resultando em `true`.
// O resultado final é `true`.
```

No entanto, se a intenção fosse avaliar `x || y` primeiro:

```csharp
bool x = false;
bool y = true;
bool z = true;

bool resultadoComParenteses = (x || y) && z;
// Primeiro, `x || y` é avaliado, resultando em `true`.
// Depois, `true && z` é avaliado, resultando em `true`.
// O resultado final é `true`.
```

Embora em alguns casos o resultado possa ser o mesmo, como nos exemplos acima, é uma boa prática de programação usar parênteses para deixar a intenção da sua expressão explícita. Isso aumenta a legibilidade e evita erros.

Lembre-se que essa ordem de precedência se aplica apenas aos operadores lógicos. Outros tipos de operadores, como os aritméticos (`*`, `/`, `+`, `-`), também têm suas próprias regras de precedência, que são avaliadas antes dos operadores de comparação e dos lógicos.
