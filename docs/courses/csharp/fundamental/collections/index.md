# Coleções (Collections)

Uma coleção é, essencialmente, um objeto que agrupa múltiplos elementos (outros objetos) em uma única unidade. Pense nelas como contêineres especializados para armazenar, gerenciar e manipular grupos de dados de forma eficiente.

Diferente de um `Array` simples, que tem um tamanho fixo, a maioria das coleções é dinâmica, permitindo adicionar ou remover itens facilmente. Elas também oferecem métodos otimizados para busca, ordenação e outras manipulações de dados.

As coleções mais comuns em C# estão no namespace `System.Collections.Generic`. O uso da versão genérica (com `<T>`) é a prática recomendada, pois garante a segurança de tipo (type safety), evitando erros em tempo de compilação.

---

## Principais Tipos de Coleções

### 1. `List<T>` (Lista)

- **O que é?** A coleção de uso geral mais comum. É basicamente um array dinâmico.
- **Quando usar?** Quando você precisa de uma lista de itens e quer acessá-los pelo índice (posição). É excelente para armazenar uma sequência de elementos e iterar sobre eles.
- **Exemplo:**

```csharp
// Lista de strings
List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("João");
Console.WriteLine(nomes[0]); // Acessa o primeiro item: "Maria"
```

### 2. `Dictionary<TKey, TValue>` (Dicionário/Mapa)

- **O que é?** Uma coleção de pares chave-valor. Cada item no dicionário tem uma chave única que é usada para recuperar o valor associado.
- **Quando usar?** Quando você precisa de buscas muito rápidas e não se importa com a ordem dos itens. Perfeito para associar um dado a outro, como um ID de usuário ao seu nome. Em outras linguagens, é conhecido como *map* ou *hash map*.
- **Exemplo:**

  ```csharp
  // Dicionário para armazenar notas de alunos
  Dictionary<string, double> notas = new Dictionary<string, double>();
  notas.Add("Ana", 9.5);
  notas.Add("Carlos", 7.0);
  Console.WriteLine(notas["Ana"]); // Acessa a nota da Ana: 9.5
  ```

### 3. `Queue<T>` (Fila)

- **O que é?** Uma coleção que segue a lógica **FIFO** (First-In, First-Out). O primeiro item a entrar é o primeiro a sair.
- **Quando usar?** Para processar itens em ordem de chegada, como uma fila de impressão, requisições em um servidor ou tarefas a serem executadas.
- **Exemplo:**

  ```csharp
  // Fila de atendimento
  Queue<string> filaAtendimento = new Queue<string>();
  filaAtendimento.Enqueue("Cliente A"); // Adiciona ao fim da fila
  filaAtendimento.Enqueue("Cliente B");
  string proximo = filaAtendimento.Dequeue(); // Remove e retorna o primeiro item: "Cliente A"
  ```

### 4. `Stack<T>` (Pilha)

- **O que é?** Uma coleção que segue a lógica **LIFO** (Last-In, First-Out). O último item a entrar é o primeiro a sair.
- **Quando usar?** Para funcionalidades como "desfazer" (undo) em um editor, o histórico de navegação de um browser (botão "voltar") ou para inverter uma sequência de itens.
- **Exemplo:**

  ```csharp
  // Pilha de histórico de ações
  Stack<string> historico = new Stack<string>();
  historico.Push("Ação 1"); // Adiciona ao topo da pilha
  historico.Push("Ação 2");
  string ultimaAcao = historico.Pop(); // Remove e retorna o último item: "Ação 2"
  ```

### 5. `HashSet<T>` (Conjunto)

- **O que é?** Uma coleção que armazena apenas valores **únicos** e não ordenados.
- **Quando usar?** Quando você precisa garantir que não haja duplicatas e quer verificar de forma extremamente rápida se um item existe na coleção.
- **Exemplo:**

  ```csharp
  // Conjunto de tags únicas
  HashSet<string> tags = new HashSet<string>();
  tags.Add("dotnet");
  tags.Add("csharp");
  tags.Add("dotnet"); // Esta adição será ignorada, pois o item já existe.
  Console.WriteLine(tags.Count); // Resultado: 2
  ```

---

## Conceitualmente

As Coleções são implementações concretas em C# de conceitos de Estruturas de Dados, que são um tópico fundamental da Ciência da Computação. Essas implementações, por sua vez, são construídas usando os princípios da Programação Orientada a Objetos (POO).

**Vamos detalhar:**

1. **Conceito (Ciência da Computação)**: A ideia de uma "lista", uma "fila", uma "pilha" ou um "dicionário" (mapa) são conceitos teóricos de estruturas de dados. Eles definem como os dados devem ser organizados e quais operações podem ser realizadas sobre eles (adicionar, remover, buscar, etc.). Esses conceitos existem independentemente de qualquer linguagem de programação.
2. **Implementação (C#)**: O C# pega esses conceitos teóricos e oferece classes prontas para uso, como `List<T>`, `Dictionary<TKey, TValue>`, etc. Essas classes são a maneira como o .NET Framework permite que você trabalhe com essas estruturas de dados sem precisar criá-las do zero.
3. **Relação com POO**: É aqui que tudo se conecta. Essas implementações em C# são exemplos perfeitos de POO em ação:
   - **São Classes**: `List<T>` é uma classe. Você cria um objeto (uma instância) dela para usar: `var minhaLista = new List<string>();`.
   - **Encapsulamento**: Elas escondem a complexidade interna. Você não precisa saber como uma `List<T>` gerencia a memória ou como um `Dictionary<TKey, TValue>` calcula o hash para encontrar um item rapidamente. Você apenas usa seus métodos públicos (.Add(), .Remove(), etc.).
   - **Abstração e Polimorfismo**: Todas elas implementam interfaces comuns, como `IEnumerable<T>`. Isso permite que você trate diferentes tipos de coleções de forma uniforme (polimorfismo), por exemplo, usando um loop foreach em qualquer uma delas.

**RESUMINDO**: As coleções são a materialização, em C#, de conceitos de estruturas de dados, e essa materialização é feita através de classes que seguem os princípios da POO.
