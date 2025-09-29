# Qual a diferença entre `Exception` e `ApplicationException`?

Essa é uma excelente pergunta que toca em um ponto importante da história e das boas práticas do .NET.

A principal diferença é que System.Exception é a classe base para todas as exceções no .NET, enquanto System.ApplicationException foi criada com a intenção de ser a classe base para exceções definidas por aplicações, mas essa prática agora é considerada obsoleta.

Vamos detalhar cada uma.

## 1. `System.Exception` (A Classe Base Universal)

`Exception` é a raiz de todas as exceções. Qualquer erro que possa ser "lançado" (`throw`) no .NET, seja pelo próprio runtime (como `NullReferenceException`) ou por código de aplicação, herda direta ou indiretamente desta classe.

**Quando usar `Exception`?**: Você quase nunca vai lançar uma instância de Exception diretamente (throw new Exception("...")). Em vez disso, a prática correta é criar suas próprias classes de exceção, mais específicas, que herdam de Exception. Isso torna seu código mais claro e permite que quem o utiliza possa capturar erros específicos.

## 2. `System.ApplicationException` (A Prática Obsoleta)

No início do .NET Framework, a ideia era que as exceções fossem divididas em dois grandes grupos:

- `System.SystemException`: Para exceções lançadas pelo Common Language Runtime (CLR).
- `System.ApplicationException`: Para exceções lançadas por aplicações de "usuário" (ou seja, o seu código).

O objetivo era permitir que você pudesse fazer um `catch` (ApplicationException) para capturar apenas os erros gerados pela sua lógica de negócio, ignorando os erros do sistema.

**Por que se tornou obsoleta?** Essa distinção nunca se provou muito útil na prática e não foi aplicada de forma consistente, nem mesmo pelas bibliotecas da Microsoft. Com o tempo, a recomendação oficial mudou.

**Recomendação Atual:** A Microsoft agora aconselha que novas classes de exceção customizadas devem herdar diretamente de `System.Exception`, e não de `ApplicationException` pois não agrega mais valor.

## A Prática Recomendada Atualmente: Criar Exceções Customizadas

A abordagem moderna e correta é criar classes de exceção específicas para os erros do seu domínio de negócio, herdando diretamente de System.Exception. Isso torna seu código mais expressivo e robusto.

Exemplo Prático: `SaldoInsuficienteException`

Vamos imaginar que na nossa ContaBancaria, precisamos garantir que um saque não deixe o saldo negativo. Se isso acontecer, devemos lançar um erro específico.

1. Crie a Classe de Exceção Customizada

Primeiro, criamos uma nova classe para representar esse erro específico. É uma boa prática criar um arquivo separado para ela.

```csharp
using System;

namespace Models.Exceptions
{
    /// <summary>
    /// Exceção lançada quando uma tentativa de saque é maior que o saldo disponível.
    /// </summary>
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message) : base(message) { }
    }
}
```

2. Use a Exceção na Lógica de Negócio

Agora, vamos adicionar um método Sacar na classe ContaBancaria e usar nossa nova exceção para sinalizar uma regra de negócio violada.

```csharp
using System;
using Models.Exceptions;

namespace Models
{
    public class ContaBancaria
    {
        public string NumeroConta { get; init; }
        public string NomeTitular { get; init; }
        public decimal Saldo { get; private set; }

        // Construtor para inicializar a conta
        public ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial = 0)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque deve ser positivo.");
            }

            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException($"Saldo insuficiente. Você tentou sacar {valor:C}, mas seu saldo atual é de {Saldo:C}.");
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}.");
        }

        // Outros métodos como Depositar e ExibirSaldo...
    }
}
```

3. Como Tratar a Exceção

No código que utiliza a ContaBancaria, você pode agora capturar especificamente esse erro e tratá-lo de forma adequada.

```csharp
// Exemplo de como usar em um Program.cs
var minhaConta = new ContaBancaria("123", "Heviane", 100.00m);

try
{
    Console.WriteLine("Tentando sacar R$ 50,00...");
    minhaConta.Sacar(50.00m); // Isso vai funcionar.
    minhaConta.ExibirSaldo();

    Console.WriteLine("\nTentando sacar R$ 80,00...");
    minhaConta.Sacar(80.00m); // Isso vai lançar a exceção.
}
catch (SaldoInsuficienteException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Erro de operação: {ex.Message}");
    Console.ResetColor();
}
catch (Exception ex) // Captura genérica para outros erros inesperados
{
    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("\nOperação finalizada.");
    minhaConta.ExibirSaldo();
}
```

## Resumo

| Característica | System.Exception | System.ApplicationException |
|:---|:---|:---|
| Propósito | Classe base para todas as exceções no .NET. | Intenção original de ser a base para exceções de aplicação. |
| Uso Atual | Recomendado. Use como classe base para suas exceções customizadas. | **Obsoleto**. Não use para novas exceções. |
| Boa Prática | Crie classes específicas que herdam de `Exception` (ex: `SaldoInsuficienteException`). | Evite completamente. Herde de `Exception`. |

<!--
[PROMPT_SUGGESTION]Me explique o que são e como usar os construtores padrão de uma classe de exceção customizada.[/PROMPT_SUGGESTION]
-->
