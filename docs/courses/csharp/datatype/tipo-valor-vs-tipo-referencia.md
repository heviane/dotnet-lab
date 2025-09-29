# Tipos de Valor vs. Tipos de Referência

> Entender a diferença entre Tipos de Valor e Tipos de Referência é um dos conceitos mais importantes para se tornar um desenvolvedor C# proficiente, pois impacta diretamente a performance e o comportamento do seu código.

A distinção crucial em C# está na forma como os dados são armazenados e gerenciados na memória, dividindo os tipos em duas grandes categorias.

## As Duas Categorias Principais

1. **Tipos de Valor (Value Types)**: Armazenam seu valor **diretamente** na memória, geralmente na **Stack** (Pilha). A Stack é uma área de memória de acesso muito rápido, usada para dados de curta duração.

    - **Exemplos:** `int`, `double`, `bool`, `char`, `decimal`, `struct`, `enum`.

2. **Tipos de Referência (Reference Types)**: Armazenam uma **referência** (um endereço) para o local onde o valor real está. O objeto em si fica na **Heap**, uma área de memória maior e mais flexível, gerenciada pelo *Garbage Collector*.

    - **Exemplos:** `class`, `string`, `array`, `delegate`, `interface`.

### A Grande Dúvida: `class` vs. `struct`

A escolha entre `class` e `struct` é a decisão mais comum relacionada a essa diferença.

#### `class` (Tipo de Referência)

É o pilar da Programação Orientada a Objetos. Use uma `class` para representar entidades com identidade e comportamento complexo.

```csharp
public class Cliente { /* ... */ }

Cliente clienteA = new Cliente { Nome = "João" };
Cliente clienteB = clienteA; // Copia a REFERÊNCIA

clienteB.Nome = "Maria";

Console.WriteLine(clienteA.Nome); // Saída: "Maria"
```

Como `clienteA` e `clienteB` apontam para o mesmo objeto na Heap, a mudança em um reflete no outro.

#### `struct` (Tipo de Valor)

Use uma `struct` para pequenos agregados de dados onde o valor em si é mais importante que a identidade.

```csharp
public struct Ponto { public int X; public int Y; }

Ponto pontoA = new Ponto { X = 10, Y = 20 };
Ponto pontoB = pontoA; // Copia o VALOR

pontoB.X = 100;

Console.WriteLine(pontoA.X); // Saída: 10
```

Como `pontoB` é uma cópia completa de `pontoA`, a mudança em um não afeta o outro.

---

## Tabela Comparativa: `class` vs. `struct`

| Característica | `class` (Tipo de Referência) | `struct` (Tipo de Valor) |
| :--- | :--- | :--- |
| **Armazenamento** | Heap (objeto) + Stack (referência) | Stack (geralmente) |
| **Atribuição** | Copia a referência (apontam para o **mesmo** objeto) | Copia o valor (cria um objeto **independente**) |
| **Herança** | Suporta herança de outra classe | Não suporta herança (mas pode implementar interfaces) |
| **Valor `null`** | Pode ser `null` | Não pode ser `null` (a menos que seja `Nullable<T>`) |
| **Uso Ideal** | Objetos complexos, entidades de negócio (Cliente, Produto), quando o polimorfismo é necessário. | Pequenos agregados de dados, imutáveis, onde a performance de cópia é importante (Ponto, Cor, Coordenada). |

## E os outros tipos?

| Tipo | Categoria | Descrição |
| :--- | :--- | :--- |
| **`interface`** | Referência | Define um contrato de funcionalidades que uma `class` ou `struct` pode implementar. |
| **`string`** | Referência | Tipo especial para texto. É imutável, o que o faz se comportar como um tipo de valor em algumas operações. |
| **`array`** | Referência | Coleção de elementos de um mesmo tipo. |
| **`delegate`** | Referência | Um "ponteiro para um método". Base para eventos e LINQ. |
| **`enum`** | Valor | Um conjunto de constantes numéricas nomeadas, para melhorar a legibilidade do código. |
