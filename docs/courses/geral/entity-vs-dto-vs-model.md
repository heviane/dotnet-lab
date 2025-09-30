# Guia: Entidade vs. DTO vs. Modelo

Entender a diferença entre **Entidade (Entity)**, **DTO (Data Transfer Object)** e **Modelo (Model)** é crucial para construir APIs bem arquitetadas, seguras e fáceis de manter. Embora os termos pareçam similares, seus papéis são distintos.

---

## Resumo Rápido

| Termo | Papel Principal | Onde Vive? | Exemplo no Projeto |
| :--- | :--- | :--- | :--- |
| **Entidade** | Representar uma tabela do banco de dados. | Camada de Dados / Domínio | `Contact.cs` |
| **DTO** | Transportar dados entre a API e o cliente. | Camada de Aplicação / Apresentação | (Ex: `CreateContactDto`) |
| **Modelo** | Termo genérico. Em APIs, geralmente se refere a DTOs. | Varia, mas geralmente na Camada de Apresentação. | `User.cs` |

---

## 1. Entidade (Entity)

Uma **Entidade** é um reflexo direto de uma tabela no seu banco de dados. O objetivo dela é mapear a estrutura dos dados que serão persistidos.

- **Responsabilidade**: Representar os dados como eles existem no banco.
- **Características**:
  - Possui um `Id` (chave primária).
  - Suas propriedades correspondem às colunas da tabela.
  - É a classe que o **Entity Framework** usa no `DbSet<T>` para criar tabelas e realizar operações de CRUD.

### Exemplo (do nosso projeto)

A classe `Contact` é uma Entidade perfeita.

```csharp
// src/api/Apps/HelloWorld/Entities/Contact.cs
public class Contact
{
    public int Id { get; set; }       // Chave primária
    public string Name { get; set; }    // Coluna no banco
    public string Phone { get; set; }   // Coluna no banco
    public string Email { get; set; }   // Coluna no banco
    public bool IsActive { get; set; }  // Coluna no banco
}
```

> **⚠️ Boa Prática**: Nunca exponha uma Entidade diretamente nos endpoints da sua API. Fazer isso acopla sua API à estrutura do banco de dados e pode vazar dados sensíveis (como hashes de senha, flags internas, etc.).

---

## 2. DTO (Data Transfer Object)

Um **DTO** é um objeto simples, sem comportamento, moldado para um propósito específico: transferir dados. Ele é o **"contrato"** da sua API. Você o usa para definir exatamente quais dados sua API vai receber ou enviar em uma requisição.

- **Responsabilidade**: Carregar dados entre as camadas da aplicação, principalmente entre o controller (API) e o cliente (navegador, app mobile).
- **Características**:
  - Não tem lógica de negócio. É apenas um "saco de dados".
  - É customizado para uma operação específica (ex: `CreateUserDto`, `UserLoginDto`, `UpdateProductDto`).
  - Ajuda a ocultar detalhes da sua Entidade que o cliente não precisa saber.

### Exemplo (criando DTOs para `Contact`)

```csharp
// DTO para criar um novo contato.
// Note a ausência do Id, pois ele será gerado pelo banco.
public class CreateContactDto
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}

// DTO para visualizar um contato.
// Poderíamos omitir campos que não são relevantes para a visualização.
public class ContactViewDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}
```

---

## 3. Modelo (Model)

"Model" é o termo mais genérico e, por isso, o mais confuso. O significado dele depende muito do contexto da arquitetura.

- **No padrão MVC (Model-View-Controller)**: O "Model" representa os dados e a lógica de negócio da aplicação. É um conceito amplo que pode incluir Entidades, DTOs e outros objetos.
- **No contexto de Web API (nosso caso)**: A pasta `Models` é frequentemente usada como um local para guardar classes que representam dados, mas que não são necessariamente Entidades. Na prática, **os arquivos dentro da sua pasta `Models` funcionam como DTOs**.

A classe `User.cs` do nosso projeto é um exemplo dessa ambiguidade. Ela está na pasta `Models`, mas possui propriedades que parecem de uma Entidade (`Id`, `CreatedAt`) e outras que nunca deveriam ser expostas (`Password`). O ideal seria refatorá-la, separando-a em uma `UserEntity` e DTOs específicos (`CreateUserDto`, `UserViewDto`).

## Conclusão: Por que usar essa separação?

1. **Segurança**: Você controla exatamente quais dados são expostos, evitando vazar informações sensíveis (como senhas ou flags internas).
2. **Desacoplamento**: A sua API (que usa DTOs) não quebra se você precisar alterar a estrutura do banco de dados (Entidades). O "contrato" com o cliente permanece estável.
3. **Clareza**: Fica óbvio qual o formato de dados esperado para cada operação, melhorando a legibilidade e a manutenção do código.
