# Guia: Arquitetura com Camadas Domain e Infrastructure

 À medida que os projetos crescem, a simples separação em `Controllers`, `Models` e `Entities` pode não ser suficiente. Para construir aplicações robustas, testáveis e fáceis de manter, adotamos padrões de arquitetura mais avançados, como a **Arquitetura Limpa (Clean Architecture)** e o **Design Orientado a Domínio (DDD)**.

 A introdução das camadas `Domain` e `Infrastructure` é um passo fundamental nessa direção. O objetivo é simples: separar o **"o quê"** (as regras de negócio) do **"como"** (os detalhes técnicos).

 ---

## 1. A Camada de `Domain` (O Núcleo do Negócio)

 Pense na camada de `Domain` como o cérebro e o coração da sua aplicação. Ela contém a lógica e as regras que definem o seu negócio, independentemente de qualquer tecnologia.

- **Responsabilidade**: Definir **o que** a aplicação faz.
- **Regra de Ouro**: Esta camada não pode ter dependências de frameworks, bancos de dados ou qualquer detalhe externo. É puro C#.

### O que vai dentro da pasta `Domain`?

1. **Entities (Entidades)**: As classes que representam os conceitos centrais do seu negócio (`Contact`, `User`, `Product`). Elas possuem uma identidade (`Id`) e um ciclo de vida.

2. **Value Objects (Objetos de Valor)**: Classes que representam um valor, como `Email`, `Address` ou `Money`. Eles não têm identidade e são imutáveis, ajudando a encapsular regras de validação (ex: um `Email` não pode ser criado com um formato inválido).

3. **Repository Interfaces (Contratos de Persistência)**: Este é um ponto crucial. O `Domain` define o **contrato** de como ele precisa acessar os dados, mas não se importa com a implementação. Ele diz: "Eu preciso de algo que possa salvar, buscar e deletar um `Contact`".

*Exemplo de interface no `Domain`:*

```csharp
// Domain/Interfaces/IContactRepository.cs
public interface IContactRepository
{
    Task<Contact> GetByIdAsync(int id);
    Task<IEnumerable<Contact>> GetAllAsync();
    Task AddAsync(Contact contact);
    Task UpdateAsync(Contact contact);
    Task DeleteAsync(int id);
}
```

 ---

## 2. A Camada de `Infrastructure` (Os Detalhes Técnicos)

 A camada de `Infrastructure` é onde a "mágica" técnica acontece. Ela implementa os contratos (interfaces) definidos no `Domain` usando ferramentas e tecnologias específicas.

- **Responsabilidade**: Definir **como** as coisas são feitas.
- **Regra de Ouro**: Esta camada depende do `Domain`, mas o `Domain` **nunca** depende da `Infrastructure`. Isso é chamado de **Princípio da Inversão de Dependência**.

### O que vai dentro da pasta `Infrastructure`?

1. **Repository Implementations**: A implementação concreta das interfaces de repositório, usando uma tecnologia específica como o Entity Framework Core.

*Exemplo de implementação no `Infrastructure`:*

```csharp
// Infrastructure/Data/Repositories/EFContactRepository.cs
public class EFContactRepository : IContactRepository
{
    private readonly AgendaContext _context;

    public EFContactRepository(AgendaContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Contact contact)
    {
        await _context.Contacts.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

    // ... outras implementações da interface
}
```

2. **Acesso a Dados**: O `DbContext` do Entity Framework, as configurações de conexão e as `Migrations` pertencem aqui, pois são detalhes de implementação da persistência.

3. **Serviços Externos**: Código para se comunicar com outras APIs, enviar e-mails (usando SendGrid, por exemplo), fazer upload de arquivos para um S3, etc.

 ---

## Estrutura de Projeto Sugerida

Ao aplicar esses conceitos, a estrutura de uma API pode evoluir para algo mais organizado e escalável:

```text
 /src/api/Apps/HelloWorld/
 │
 ├── Application/         # Camada de Aplicação (orquestração)
 │   ├── DTOs/            # Seus DTOs (CreateContactDto, ContactResponseDto)
 │   └── UseCases/        # Lógica de casos de uso (ex: CreateContactUseCase)
 │
 ├── Domain/              # O CORAÇÃO DO NEGÓCIO
 │   ├── Entities/        # Suas entidades (Contact.cs)
 │   └── Interfaces/      # Contratos (IContactRepository.cs)
 │
 ├── Infrastructure/      # DETALHES TÉCNICOS
 │   ├── Data/
 │   │   ├── Context/     # AgendaContext.cs
 │   │   ├── Migrations/  # Migrações do EF
 │   │   └── Repositories/# Implementações (EFContactRepository.cs)
 │   └── Services/        # Serviços externos (EmailService.cs)
 │
 └── WebApi/              # PONTO DE ENTRADA (Apresentação)
     ├── Controllers/     # Seus controllers (ContactController.cs)
     └── Program.cs       # Configuração e injeção de dependência
```

> **Nota**: Adicionamos a camada `Application` para orquestrar o fluxo entre a `WebApi` e o `Domain`, e a `WebApi` (ou `Presentation`) para lidar exclusivamente com as requisições HTTP.

## Conclusão: Por que se preocupar com isso?

 1. **Testabilidade**: Você pode testar suas regras de negócio (`Domain`) de forma isolada, sem precisar de um banco de dados ou de uma API externa.
 2. **Flexibilidade**: Quer trocar o SQL Server pelo PostgreSQL? Basta criar uma nova implementação do repositório na `Infrastructure`. O `Domain` não será afetado.
 3. **Manutenção**: A separação clara de responsabilidades torna o código mais fácil de entender, depurar e evoluir.
