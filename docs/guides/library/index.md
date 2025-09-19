# Class Library (classlib)

É um projeto que não é executável por si só, mas que agrupa código reutilizável (classes, funções, lógica de negócio) para ser compartilhado entre outros projetos (como uma API e um App de Console).
É fundamental para organizar o código em soluções maiores.

## Comandos para trabalhar com o projeto

Comando para criar:

```bash
dotnet new classlib -o <NomeDoProjeto>
```

Comando para adicionar referência a um projeto existente:

```bash
dotnet add <NomeDoProjeto> reference <CaminhoDoProjetoReferenciado>
```
