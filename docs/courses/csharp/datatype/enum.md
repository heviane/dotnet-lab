# enum (enumeração)

É um Tipo de Valor que permite definir um conjunto de constantes nomeadas.

Pense nele como uma forma de dar nomes significativos a um grupo de valores inteiros relacionados, tornando o código mais legível e menos propenso a erros do que usar números "mágicos" diretamente.

## Exemplo

```csharp
public enum DiasDaSemana
{
    Segunda = 1,
    Terca = 2,
    Quarta = 3,
    Quinta = 4,
    Sexta = 5,
    Sabado = 6,
    Domingo = 7
}

// Uso:
DiasDaSemana hoje = DiasDaSemana.Terca;
Console.WriteLine((int)hoje); // Saída: 2
```
