# Expressões Condicionais

Expressões condicionais são trechos de código que avaliam uma condição e retornam um valor com base no resultado dessa avaliação. Elas são uma forma poderosa e concisa de implementar lógica de decisão diretamente em atribuições ou chamadas de método.

As principais expressões condicionais em C# são:

---

## 1. Operador Condicional Ternário (`?:`)

É a forma mais clássica e concisa de um `if-else` que retorna um valor. A estrutura é sempre uma condição, um valor para o caso verdadeiro e um valor para o caso falso.

**Sintaxe:**

```csharp
condição ? valor_se_verdadeiro : valor_se_falso;
```

**Exemplo:**

```csharp
int idade = 20;
string status = (idade >= 18) ? "Maior de idade" : "Menor de idade";
// A variável 'status' receberá o valor "Maior de idade".
```

---

## 2. Switch Expression (a partir do C# 8.0)

É uma evolução moderna e mais poderosa da instrução `switch`. Ela também é uma expressão (retorna um valor) e usa uma sintaxe mais limpa baseada em correspondência de padrões.

**Sintaxe:**

```csharp
variavelParaAvaliar switch
{
    padrao1 => resultado1,
    padrao2 => resultado2,
    _      => resultado_padrao
};
```

**Exemplo:**

```csharp
DayOfWeek dia = DayOfWeek.Monday;
string tipoDeDia = dia switch
{
    DayOfWeek.Saturday => "Fim de semana",
    DayOfWeek.Sunday   => "Fim de semana",
    _                  => "Dia de semana" // O `_` é o caso padrão (default)
};
// A variável 'tipoDeDia' receberá o valor "Dia de semana".
```

---

## 3. Operadores de Coalescência Nula (`??` e `??=`)

Embora sejam especializados para tratar valores `null`, eles também funcionam como expressões condicionais, pois escolhem um valor com base na condição de um valor ser nulo ou não.

### Operador `??`

Retorna o valor do operando da esquerda se ele não for `null`; caso contrário, avalia o operando da direita e retorna seu resultado.

**Sintaxe:**

```csharp
variavelQuePodeSerNula ?? valorPadrao;
```

**Exemplo:**

```csharp
string nome = null;
string nomeExibicao = nome ?? "Usuário Anônimo";
// 'nomeExibicao' receberá "Usuário Anônimo" porque 'nome' é nulo.
```

### Operador de Atribuição `??=` (a partir do C# 8.0)

Atribui o valor do operando da direita ao operando da esquerda somente se o operando da esquerda for avaliado como `null`.

**Sintaxe:**

```csharp
variavel ??= expressaoDeAtribuicao;
```

**Exemplo:**

```csharp
List<int> numeros = null;
numeros ??= new List<int>(); // Como 'numeros' é nulo, uma nova lista é atribuída a ele.
numeros.Add(5);
```
