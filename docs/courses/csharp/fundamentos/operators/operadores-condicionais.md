# Operadores Condicionais

Existem três tipos principais de operadores condicionais em C#:

    1.  **Operador Condicional Ternário (`?:`)**
    2.  **Operador de Coalescência Nula (`??`)**
    3.  **Operadores Lógicos Condicionais (`&&` e `||`)**

## 1. Operador Condicional Ternário (`?:`)

    Este é um atalho para uma instrução `if-else`. Ele avalia uma expressão booleana e retorna um de dois valores, dependendo se a expressão é verdadeira ou falsa. Sua sintaxe é:

    ```csharp
    condicao ? valorSeVerdadeiro : valorSeFalso;
    ```

    **Exemplo:**

    ```csharp
    int idade = 20;
    string status = (idade >= 18) ? "Maior de idade" : "Menor de idade";
    // A variável 'status' será "Maior de idade"
    ```

-----

## 2. Operador de Coalescência Nula (`??`)

    Este operador fornece um valor padrão para tipos de valor e referência que podem ser nulos. Se o operando da esquerda não for nulo, ele retorna esse valor. Caso contrário, ele retorna o operando da direita. Sua sintaxe é:

    ```csharp
    expressaoQuePodeSerNula ?? valorPadrao;
    ```

    **Exemplo:**

    ```csharp
    string nome = ObterNomeDeUsuario(); // Suponha que este método retorne null às vezes
    string nomeExibicao = nome ?? "Usuário Anônimo";
    // Se 'nome' for null, a variável 'nomeExibicao' será "Usuário Anônimo".
    ```

    Também existe o **Operador de Atribuição de Coalescência Nula (`??=`)**, disponível a partir do C\# 8.0. Ele atribui o valor do operando da direita ao operando da esquerda somente se o operando da esquerda for nulo.

    **Exemplo:**

    ```csharp
    List<string> lista = null;
    lista ??= new List<string>(); // Atribui uma nova lista, pois 'lista' é null
    lista.Add("Item A");
    ```

-----

## 3. Operadores Lógicos Condicionais (`&&` e `||`)

    Esses operadores são usados para combinar expressões booleanas e são frequentemente chamados de "short-circuiting" ou "de curto-circuito" porque não avaliam o segundo operando se o resultado já puder ser determinado a partir do primeiro.

    * **`&&` (AND Condicional):** Retorna `true` apenas se ambos os operandos forem `true`. Se o primeiro operando for `false`, o segundo não é avaliado.
    * **`||` (OR Condicional):** Retorna `true` se pelo menos um dos operandos for `true`. Se o primeiro operando for `true`, o segundo não é avaliado.

    **Exemplo com `&&`:**

    ```csharp
    // Se 'usuario' for null, a segunda condição (usuario.IsAdmin) não será avaliada,
    // evitando uma exceção NullReferenceException.
    if (usuario != null && usuario.IsAdmin)
    {
        // ...
    }
    ```

    **Exemplo com `||`:**

    ```csharp
    // Se a 'idade' for 18, a segunda condição (cargo == "Gerente") não será avaliada.
    if (idade >= 18 || cargo == "Gerente")
    {
        // ...
    }
    ```
