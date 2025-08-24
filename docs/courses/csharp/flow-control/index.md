# Estruturas de controle de fluxo

São essenciais para ditar a ordem em que as instruções do seu código são executadas.

Elas se dividem em três categorias principais:

    1.  **Tomada de Decisão:** Permitem que o código execute diferentes blocos com base em condições.
    2.  **Iteração (Loops):** Permitem que o código execute um bloco repetidamente.
    3.  **Salto:** Permitem pular para outra parte do código ou sair de uma estrutura.

> Toda **estrutura de decisão** é uma **estrutura de controle de fluxo**, mas nem toda estrutura de controle de fluxo é uma estrutura de decisão.

-----

## Estruturas de Tomada de Decisão

### `if-else`

A estrutura `if-else` avalia uma condição booleana. Se a condição for `true`, o código dentro do `if` é executado. Caso contrário, o código dentro do `else` (se existir) é executado.

    ```csharp
    int idade = 20;

    if (idade >= 18)
    {
        Console.WriteLine("Maior de idade");
    }
    else
    {
        Console.WriteLine("Menor de idade");
    }
    ```

-----

### `switch-case`

A estrutura `switch` avalia uma expressão e a compara com vários "casos" possíveis. É ideal para quando você precisa testar uma variável contra múltiplos valores.

    ```csharp
    string fruta = "maçã";

    switch (fruta)
    {
        case "banana":
            Console.WriteLine("É uma banana.");
            break;
        case "maçã":
            Console.WriteLine("É uma maçã.");
            break;
        default:
            Console.WriteLine("Não é uma banana nem uma maçã.");
            break;
    }
    ```

    A partir do C\# 8.0, o **`switch` expression** oferece uma sintaxe mais concisa para cenários de correspondência de padrões.

    ```csharp
    string resultado = fruta switch
    {
        "banana" => "É uma banana.",
        "maçã"   => "É uma maçã.",
        _        => "Não é uma banana nem uma maçã."
    };
    Console.WriteLine(resultado);
    ```

-----

## Estruturas de Iteração (Loops)

### `for`

    O loop `for` é usado quando você sabe exatamente quantas vezes deseja repetir um bloco de código. Ele consiste em três partes: inicialização, condição e iteração.

    ```csharp
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"O valor de i é: {i}");
    }
    ```

-----

### `foreach`

    O loop `foreach` é usado para iterar sobre os elementos de uma coleção (como arrays, listas, etc.). É a forma mais segura e comum de percorrer coleções.

    ```csharp
    string[] nomes = { "Alice", "Bob", "Charlie" };

    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }
    ```

-----

### `while`

    O loop `while` continua a executar um bloco de código **enquanto** uma condição booleana for `true`. A condição é testada no início de cada iteração.

    ```csharp
    int contador = 0;

    while (contador < 3)
    {
        Console.WriteLine($"Contador é: {contador}");
        contador++;
    }
    ```

-----

### `do-while`

    O loop `do-while` é semelhante ao `while`, mas a condição é testada no **final** de cada iteração. Isso garante que o bloco de código seja executado pelo menos uma vez.

    ```csharp
    int numero = 5;

    do
    {
        Console.WriteLine($"O número é: {numero}");
        numero++;
    } while (numero < 5); // A condição é falsa, mas o loop foi executado uma vez.
    ```

    ```csharp
    int numero;

    do
    {
        Console.Write("Digite um número (0 para sair): ");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Você digitou: {numero}");
    } while (numero != 0);
    ```

    `Console.ReadLine()` funciona no terminal de debug do VSCode?

-----

## Estruturas de Salto

### `break`

    O comando `break` encerra imediatamente o loop ou a estrutura `switch` mais próxima.

    ```csharp
    for (int i = 0; i < 10; i++)
    {
        if (i == 5)
        {
            break; // Sai do loop quando i for 5
        }
        Console.WriteLine(i);
    }
    ```

    **Saída:** `0 1 2 3 4`

    -----

### `continue`

    O comando `continue` pula o restante do código da iteração atual e avança para a próxima iteração do loop.

    ```csharp
    for (int i = 0; i < 5; i++)
    {
        if (i == 2)
        {
            continue; // Pula a iteração quando i for 2
        }
        Console.WriteLine(i);
    }
    ```

    **Saída:** `0 1 3 4`

    -----

### `return`

    O comando `return` encerra a execução de um método e retorna o controle para o código que o chamou. Opcionalmente, ele pode retornar um valor.

    ```csharp
    public int Somar(int a, int b)
    {
        int resultado = a + b;
        return resultado; // Retorna o valor de 'resultado'
    }
    ```

-----

### `goto`

    O comando `goto` transfere o controle do programa para uma instrução marcada com um rótulo. **Seu uso é fortemente desaconselhado** em código moderno por dificultar a leitura e a manutenção, criando o que se conhece como "spaghetti code".

    ```csharp
    // Este é um exemplo de má prática, evite usar `goto`.
    goto RótuloAqui;

    Console.WriteLine("Este código nunca será executado.");

    RótuloAqui:
    Console.WriteLine("Saltou para o rótulo.");
    ```
