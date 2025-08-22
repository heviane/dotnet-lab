# 🗓️ Plano de Estudos e Acompanhamento 🎓

Acompanhamento do progresso baseado nos roadmap de estudo.

---

## 🟢 Fase 1: Fundamentos do .NET e C#

### Tools

- [X] Instalar o .NET SDK (versão mais recente).
- [X] Instalar o Visual Studio Code e as extensões recomendadas.
- [X] Usar Git e GitHub para criar repositórios de projetos e de estudos e documentações.
- [X] Aplicações de Console com o uso do dotnet CLI no terminal.

### Fundamentos do C#

- [ ] Tipos de Dados (Tipos de Valor e Tipos de Referência):

  - [ ] Tipo de Valor (Value Type)
    - [X] Numéricos Inteiros: `int`, `short`, `long`, `byte`.
    - [X] Numéricos Reais: `float`, `double`, `decimal`.
    - [X] Booleano: `bool`.
    - [X] Caractere: `char`.
    - [ ] `struct`: É um tipo de valor, ideal para pequenas estruturas de dados onde o valor em si é mais importante que a identidade do objeto (ex: um ponto 2D, uma cor RGB).
    - [ ] `enum`: É um Tipo de Valor que permite definir um conjunto de constantes nomeadas.

  - [ ] Tipo de Referência (Reference Type)
    - [X] `string`: Frequentemente discutido junto com os primitivos porque possui uma sintaxe literal ("meu texto") e é usado constantemente, más é Tipo de Referência.
    - [X] `class`: É a palavra-chave usada para definir Tipos de Referência (Reference Types) personalizados.
      - É uma categoria para definir seus próprios tipos de referência complexos.
      - Quando você cria uma class, você está definindo um novo tipo de referência. Instâncias de classes são armazenadas na `Heap`, e as variáveis que as referenciam contêm o endereço de memória para esses **objetos**.
    - [X] `object`: É o tipo base fundamental do qual todos os outros tipos (de valor e de referência) derivam.
      - É o tipo de referência universal do qual todos os outros tipos herdam.
      - Apesar de ser a raiz de toda a hierarquia de tipos, `object` em si é um **Tipo de Referência**.
    - [X] `array`: É uma coleção de tamanho fixo que armazena múltiplos elementos do mesmo tipo.
    - [ ] `delegate`: É um tipo que funciona como um "ponteiro" seguro para um método, permitindo que métodos sejam tratados como dados.
    - [ ] `interface`: Define um "contrato" de funcionalidades que uma `class` ou `struct` pode implementar.

- [X] Variáveis
- [X] Constantes
- [X] Escopo de variáveis
- [X] Operadores:
  - [X] Aritméticos
  - [X] Relacionais
  - [X] Lógicos
  - [X] Atribuição
  - [X] Comparação
  - [X] Bitwise
- [X] Estruturas de Controle de Fluxo:
  - [X] Decisão (if else, switch)
  - [X] Iteração / Repetição (for, foreach, while, do while)
  - [X] Salto (Break, Continue, Return)
- [X] Manipulação/Formatação de Valores de tipos primitivos.
- [X] Boas práticas....Review...
  - [X] Nomenclaturas
  - [X] Comentários
  - [X] Convenções
  - [X] Espaços em branco
  - [X] Remover blocos de código
- [X] Exceptions:
  - [X] Tratamento de exceções: try, catch, finally.
  - [X] Lançamento de exceções: throw.
  - [X] Tipos de Exceções: genéricas e especificas.
  - [X] Stack Trace.

- [ ] Colections (Implementações de Estruturas de Dados em C# usando POO)
  - [X] Arrays (Arranjos)
  - [X] Listas (`List<T>`)
  - [ ] Filas (`Queue<T>`)
  - [ ] Pilhas (`Stack<T>`)
  - [ ] Dicionários (`Dictionary<TKey, TValue>`)
  - [ ] Conjuntos (`HashSet<T>`)

### Programação Orientada a Objetos (POO)

- [X] **Classes e Objetos**: Entendimento do conceito e da sintaxe.
- [X] **Membros de uma Classe**: Propriedades, Métodos e Construtores.
- [X] **Modificadores de Acesso**: `public`, `private`, `protect`.

- [ ] Pilares:
  - [ ] **Encapsulamento**: Aprofundamento com `private set` e validações.
  - [ ] **Herança**: `class Filha : Pai`, `base`, `sealed`.
  - [ ] **Polimorfismo**: `virtual` e `override`.
  - [ ] **Abstração**: `abstract class` e `interface`.
