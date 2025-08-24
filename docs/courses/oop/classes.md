# 🏛️ Classes

Uma **classe** é a planta ou o modelo para criar objetos. Ela define um conjunto de propriedades (dados) e métodos (comportamentos) que os objetos criados a partir dela terão. É o conceito fundamental da Programação Orientada a Objetos (OOP).

---

## Sintaxe Básica

A declaração de uma classe é simples. Usamos a palavra-chave `class` seguida pelo nome da classe.

```csharp
public class Produto
{
    // Membros da classe (campos, propriedades, métodos)

    // Campo (armazena o dado internamente)
    private string _nome;

    // Propriedade (expõe o dado de forma controlada)
    public string Nome { get; set; }
    public double Preco { get; set; }

    // Método (define um comportamento)
    public void AplicarDesconto(double percentual)
    {
        Preco -= Preco * (percentual / 100);
    }
}
```

Neste exemplo, `Produto` é uma classe que pode ser usada para criar múltiplos objetos de produto, cada um com seu próprio nome e preço.
