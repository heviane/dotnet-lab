# Formatação Personalizada para Outros Tipos

A capacidade de formatação em C# não se limita a números. Vários outros tipos de dados importantes também implementam a interface `IFormattable`, permitindo um controle preciso sobre sua representação em string.

## Formatação de GUID (`System.Guid`)

Um `Guid` (Identificador Único Global) pode ser formatado de diferentes maneiras para incluir ou omitir hifens, chaves ou parênteses.

**Principais Especificadores:**

- `N`: 32 dígitos, sem separadores.
- `D`: 32 dígitos separados por hifens (padrão).
- `B`: Formato `D` entre chaves `{}`.
- `P`: Formato `D` entre parênteses `()`.
- `X`: Formato hexadecimal entre chaves.

```csharp
Guid meuGuid = Guid.NewGuid();

Console.WriteLine($"Guid Padrão (D): {meuGuid.ToString("D")}");
// Saída Exemplo: 12345678-1234-1234-1234-1234567890ab

Console.WriteLine($"Guid Numérico (N): {meuGuid.ToString("N")}");
// Saída Exemplo: 123456781234123412341234567890ab

Console.WriteLine($"Guid com Chaves (B): {meuGuid.ToString("B")}");
// Saída Exemplo: {12345678-1234-1234-1234-1234567890ab}

Console.WriteLine($"Guid com Parênteses (P): {meuGuid.ToString("P")}");
// Saída Exemplo: (12345678-1234-1234-1234-1234567890ab)
```

---

## Formatação de Enumerações (`Enum`)

Enumerações podem ser formatadas para exibir seu nome simbólico ou seu valor numérico subjacente em diferentes bases.

**Principais Especificadores:**

- `G` ou `F`: Exibe o nome do membro da enumeração (padrão).
- `D`: Exibe o valor numérico em formato decimal.
- `X`: Exibe o valor numérico em formato hexadecimal.

```csharp
public enum Status { Pendente = 0, Processando = 1, Concluido = 2, Erro = -1 }

Status statusAtual = Status.Processando;

Console.WriteLine($"Nome (G): {statusAtual.ToString("G")}"); // Saída: Processando
Console.WriteLine($"Valor Decimal (D): {statusAtual.ToString("D")}"); // Saída: 1
Console.WriteLine($"Valor Hexadecimal (X): {statusAtual.ToString("X")}"); // Saída: 00000001
```
