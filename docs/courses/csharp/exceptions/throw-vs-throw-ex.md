# Qual a diferença entre `throw` e `throw ex`?

No C#, a diferença entre `throw` e `throw ex` está relacionada ao contexto de exceção e à preservação da pilha de chamadas (stack trace).

A diferença fundamental está em como o `stack trace` (a "pilha de chamadas" que mostra a origem do erro) é preservado.

- **`throw;`**: Re-lança a exceção original que foi capturada, preservando o stack trace original. Isso significa que você saberá exatamente em que linha e em qual método o erro ocorreu inicialmente. Esta é a forma correta e recomendada.

- **`throw ex;`**: Lança uma "nova" exceção usando a instância ex que você capturou. O problema é que isso reseta o stack trace. A nova pilha de chamadas começará na linha onde você escreveu throw ex;, escondendo a verdadeira causa do problema. Esta prática deve ser evitada.

Vamos ver um exemplo prático para demonstrar a diferença:

## Cenário de Demonstração

Imagine que temos três métodos:

1. MetodoProblematico(): Onde o erro original acontece (uma divisão por zero).
2. MetodoIntermediario(): Captura o erro, talvez para registrar um log, e depois o re-lança.
3. Main(): Onde a chamada inicial é feita e a exceção é finalmente tratada.

### Código de Exemplo

```csharp
public class ExemploStackTrace
{
    public static void Main()
    {
        Console.WriteLine("--- Cenário 1: Usando 'throw;' (Boa Prática) ---");
        try
        {
            MetodoIntermediario_ComThrow();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Stack Trace PRESERVADO:");
            Console.ResetColor();
            Console.WriteLine(ex.StackTrace);
        }

        Console.WriteLine("\n--------------------------------------------------\n");

        Console.WriteLine("--- Cenário 2: Usando 'throw ex;' (Má Prática) ---");
        try
        {
            MetodoIntermediario_ComThrowEx();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Stack Trace PERDIDO:");
            Console.ResetColor();
            Console.WriteLine(ex.StackTrace);
        }
    }

    // BOA PRÁTICA: Usa 'throw;'
    public static void MetodoIntermediario_ComThrow()
    {
        try
        {
            MetodoProblematico();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Logando o erro em MetodoIntermediario: {ex.Message}");
            // Re-lança a exceção original, mantendo toda a informação dela.
            throw;
        }
    }

    // MÁ PRÁTICA: Usa 'throw ex;'
    public static void MetodoIntermediario_ComThrowEx()
    {
        try
        {
            MetodoProblematico();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Logando o erro em MetodoIntermediario: {ex.Message}");
            // Lança a exceção como se fosse nova, perdendo a origem.
            throw ex;
        }
    }

    // O método onde o erro realmente acontece.
    public static void MetodoProblematico()
    {
        int zero = 0;
        // A linha abaixo vai lançar uma DivideByZeroException.
        int resultado = 10 / zero;
    }
}
```

### Saída do Console

```plaintext
--- Cenário 1: Usando 'throw;' (Boa Prática) ---
Logando o erro em MetodoIntermediario: Attempted to divide by zero.
✅ Stack Trace PRESERVADO:
   at ExemploStackTrace.MetodoProblematico() in C:\...\ExemploStackTrace.cs:line 61
   at ExemploStackTrace.MetodoIntermediario_ComThrow() in C:\...\ExemploStackTrace.cs:line 31
   at ExemploStackTrace.Main() in C:\...\ExemploStackTrace.cs:line 11

--------------------------------------------------

--- Cenário 2: Usando 'throw ex;' (Má Prática) ---
Logando o erro em MetodoIntermediario: Attempted to divide by zero.
❌ Stack Trace PERDIDO:
   at ExemploStackTrace.MetodoIntermediario_ComThrowEx() in C:\...\ExemploStackTrace.cs:line 50
   at ExemploStackTrace.Main() in C:\...\ExemploStackTrace.cs:line 23
```

### Análise da Saída

- No **Cenário 1 (`throw;`)**, o stack trace nos mostra claramente a jornada completa do erro: começou em `MetodoProblematico()`, passou por `MetodoIntermediario_ComThrow()` e foi capturado em `Main()`. É fácil encontrar a causa raiz.
- No **Cenário 2 (`throw ex;`)**, o stack trace foi resetado. Ele nos diz que o erro veio de `MetodoIntermediario_ComThrowEx()`, mas esconde completamente a informação de que a causa original estava dentro de `MetodoProblematico()`. Em um sistema complexo, isso tornaria a depuração um pesadelo.

## Quando é aceitável não usar `throw;`?

A única situação em que você não usaria throw; é quando você quer encapsular a exceção original dentro de uma nova exceção, mais específica, para adicionar mais contexto. Nesse caso, você passa a exceção original no construtor da nova exceção, como `InnerException`.

```csharp
 Show full code block
// Usando a classe SaldoInsuficienteException do contexto anterior
try
{
    // Alguma operação que lança uma exceção genérica, ex: FormatException
    var valor = decimal.Parse("abc");
    minhaConta.Depositar(valor);
}
catch (Exception ex)
{
    // Encapsula a exceção original em uma mais específica do seu domínio.
    // O stack trace original é preservado dentro da InnerException.
    throw new InvalidOperationException("Ocorreu um erro ao processar o depósito. Verifique os dados de entrada.", ex);
}
```

Neste caso, você não perde a informação original, pois ela fica acessível através da propriedade ex.InnerException.

## Resumo

| Sintaxe | Efeito no Stack Trace | Quando Usar |
|:---|:---|:---|
| throw; | Preserva o stack trace original.| Sempre que você precisar re-lançar a mesma exceção após tratá-la parcialmente (ex: logar o erro).|
| throw ex; | Reseta o stack trace, escondendo a origem.| Nunca. É considerada uma má prática que dificulta a depuração.|
| throw new MyException("...", ex);| Cria uma nova exceção, mas preserva a original como `InnerException`.| Quando você precisa adicionar contexto de negócio a um erro, encapsulando a exceção original.|
