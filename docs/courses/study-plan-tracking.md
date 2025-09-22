# 🗓️ Plano de Estudos e Acompanhamento 🎓

Acompanhamento do progresso baseado nos roadmap de estudo.

---

## 🟢 Fase 1: Fundamentos do .NET e C#

### Tools

- [X] Instalar o .NET SDK (versão mais recente).
- [X] Instalar o Visual Studio Code e as extensões recomendadas.
- [X] Usar Git e GitHub para criar repositórios de projetos e de estudos e documentações.
- [X] .NET CLI (Command Line Interface)
- [X] NuGet: Gerenciador de Pacotes.
- [X] Console Applications
- [X] Debugging
- [ ] Profiling básico: Fundamental para otimizar o desempenho e a eficiência de suas aplicações.
  - [ ] Visual Studio Code - Ferramentas de diagnóstico do .NET via linha de comando.
  - [ ] Visual Studio - Com interface gráfica de profiling integrada.
- [ ] APIs RESTful
  - [X] Entender os conceitos de HTTP (Verbos, Status Codes), arquitetura REST e JSON.
  - [X] Web API Minimal e Web API com Controllers e Models
  - [X] Documentação com Swagger/OpenAPI
  - [X] Criação de endpoints (CRUD com dados em memória)
  - [X] Testes em mode Debug com Postamn
  - [X] Testes com .http, curl e Postman
  - [ ] Criação de endpoints (CRUD com dados em banco de dados relacional)
  - [ ] Versionamento de API
  - [ ] Autenticação e Autorização com JWT
  - [ ] Boas práticas de segurança: Validação de entrada (Input Validation), gerenciamento de segredos (Secret Management), princípios do OWASP.

### Fundamentos do .NET

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
    - [X] `interface`: Define um "contrato" de funcionalidades que uma `class` ou `struct` pode implementar.
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
- [X] Boas práticas (Nomenclatura, Convenções, Organização)
  - [X] Nomenclaturas
  - [X] Comentários
  - [X] Convenções
  - [X] Espaços em branco
  - [ ] Organização de Código
    - [X] namespaces
    - [X] Remover blocos de código
- [X] Exceptions:
  - [X] Tratamento de exceções: try, catch, finally.
  - [X] Lançamento de exceções: throw.
  - [X] Tipos de Exceções: genéricas e especificas.
  - [X] Stack Trace.
- [X] Colections (Implementações de Estruturas de Dados em C# usando POO)
  - [X] Arrays (Arranjos)
  - [X] Listas (`List<T>`)
  - [X] Filas (`Queue<T>`)
  - [X] Pilhas (`Stack<T>`)
  - [X] Dicionários/Mapas (`Dictionary<TKey, TValue>`)
  - [X] Conjuntos (`HashSet<T>`)
- [X] Serialização e Deserialização de Objetos
- [ ] Delegates *tipos de dados*, eventos, LINQ
- [ ] Async/await e programação assíncrona

### Programação Orientada a Objetos (POO)

- [X] **Classes e Objetos**: Entendimento do conceito e da sintaxe.
- [X] **Membros de uma Classe**: Propriedades, Métodos e Construtores.
- [X] **Modificadores de Acesso**: `public`, `private`, `protect`.

- [X] Pilares:
  - [X] **Encapsulamento**: `private set`.
  - [X] **Herança**: `class Filha : Pai`, `base`, `sealed`.
  - [X] **Polimorfismo**: `virtual` e `override`.
  - [X] **Abstração**: `abstract class` e `interface`.
