# Tuplas

As tuplas são estruturas de dados que permitem agrupar um número fixo de elementos de tipos diferentes em um único objeto, sem a necessidade de criar uma `class` ou `struct` para isso.

No C# moderno (7.0+), a sintaxe `(int, string)` é uma forma amigável de usar o `struct` **`System.ValueTuple`**, que é um tipo de valor leve e eficiente. Existe também a versão legada, a `class` **`System.Tuple`**, que é um tipo de referência e menos performático.

**Recomendação**: Sempre prefira a sintaxe moderna `(valor1, valor2)` por sua performance e legibilidade.

## Exemplo: `ValueTuple` (Struct, Recomendado)

```csharp
// Declaração de uma tupla nomeada. Por baixo dos panos, é um ValueTuple.
(int Id, string FirstName, string LastName) person = (1, "Heviane", "Bastos");

// Acessando os elementos pelos nomes definidos
Console.WriteLine($"ID: {person.Id}, Name: {person.FirstName}");

// Declaração sem nomes explícitos (acesso por Item1, Item2...)
(int, string, string) otherPerson = (2, "Gemini", "AI");
Console.WriteLine($"ID: {otherPerson.Item1}, Name: {otherPerson.Item2}");
```

## Exemplo: `Tuple` (Classe, Legado)

```csharp
// Sintaxe mais verbosa, cria um objeto na heap (menos performático)
var personLegacy = Tuple.Create(3, "John", "Doe");
Console.WriteLine($"ID: {personLegacy.Item1}, Name: {personLegacy.Item2}");
```

## Desconstrução (Deconstruction)

Desestruturar os valores de uma tupla em variáveis separadas:

```csharp
// A tupla 'person' foi declarada no exemplo anterior
var (id, firstName, lastName) = person;
Console.WriteLine($"ID: {id}, First Name: {firstName}, Last Name: {lastName}");
```

## Tuplas como Retorno de Métodos

- Podemos ter um método que retorna uma tupla, ou seja, usar tuplas para retornar múltiplos valores de um método: O uso mais comum e poderoso de tuplas é para retornar múltiplos valores de um método de forma clara.

```csharp
(int Id, string FirstName, string LastName) GetPerson() => (5, "Alice", "Smith");

var personData = GetPerson();
Console.WriteLine($"ID: {personData.Id}, First Name: {personData.FirstName}, Last Name: {personData.LastName}");
```

## Vantagens das Tuplas

- **Simplicidade e Concisão**: Permitem agrupar dados relacionados sem a sobrecarga de criar uma class ou struct.
- **Performance**: Por serem structs (ValueTuple), são muito eficientes para cenários de curta duração, como retornos de métodos.
- **Flexibilidade**: Facilitam a desconstrução e o trabalho com múltiplos valores retornados.

## Considerações Importantes

- **Escopo de Uso**: Tuplas são ideais para uso interno e temporário (ex: métodos privados). Para dados que viajam por várias camadas da aplicação (como modelos de domínio), uma `class` ou `record` ainda é a melhor escolha.
- **Mutabilidade**: ValueTuple é um struct mutável. Seus campos podem ser alterados após a criação, a menos que sejam declarados com readonly.

---

## Conclusão

As tuplas são uma ferramenta poderosa em C# para agrupar e manipular múltiplos valores de forma simples e eficiente. Elas são especialmente úteis para retornos de métodos e para agrupar dados relacionados sem a sobrecarga de criar classes adicionais.

| Característica | `System.ValueTuple` (Tupla Moderna) | `System.Tuple` (Tupla Legada) |
| :--- | :--- | :--- |
| **Tipo** | `struct` (Tipo de Valor) | `class` (Tipo de Referência) |
| **Performance** | **Alta**. Alocada na Stack. | **Baixa**. Alocada na Heap. |
| **Sintaxe** | `(int, string)` | `Tuple.Create(int, string)` |
| **Acesso** | `Item1`, `Item2` ou nomes (`.Id`) | `Item1`, `Item2` |
| **Uso Recomendado**| **Sempre que precisar de tuplas.** | Apenas em código antigo ou APIs que exigem. |

No contexto moderno do C#, **tupla é sinônimo de `ValueTuple`, que é um `struct`**.
