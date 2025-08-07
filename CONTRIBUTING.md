# 🤝 Como Contribuir

Ficamos muito felizes com seu interesse em contribuir com o Laboratório de Estudos .NET! Toda ajuda é bem-vinda. Este documento guia você pelo processo de contribuição.

Ao participar, você concorda em seguir nosso [Código de Conduta](./CODE_OF_CONDUCT.md).

## 🗺️ Por Onde Começar?

Não sabe por onde começar? Você pode:

- Procurar por issues abertas, especialmente aquelas com a etiqueta `good first issue`.
- Melhorar a documentação existente (`docs/`).
- Adicionar um novo projeto de estudo em `src/` que explore um conceito .NET ainda não abordado.
- Adicionar mais exemplos ou testes a um projeto existente.

## 🐛 Reportando Bugs e Sugerindo Melhorias

Para reportar um bug ou sugerir uma nova funcionalidade/estudo, por favor, **crie uma Issue** no GitHub. Forneça o máximo de detalhes possível para que possamos entender e reproduzir o problema ou a sua ideia.

## 🚀 Processo de Pull Request (PR)

Para contribuir com código ou documentação, siga estes passos:

1. **Faça um Fork:** Crie um "fork" deste repositório para a sua conta do GitHub.

2. **Clone o Fork:** Clone o seu fork para a sua máquina local.

    ```bash
    git clone https://github.com/SEU-USUARIO/dotnet-lab.git
    cd dotnet-lab
    ```

3. **Crie uma Branch:** Crie uma nova branch para suas alterações. Use um nome descritivo.

    ```bash
    # Para uma nova funcionalidade ou estudo
    git checkout -b feature/nome-da-sua-feature

    # Para uma correção de bug
    git checkout -b fix/descricao-do-bug
    ```

4. **Faça suas Alterações:** Implemente seu código, correção ou melhoria.

    - **Siga os padrões de código:** Nosso repositório usa um arquivo `.editorconfig` para manter a consistência. Certifique-se de que seu editor está configurado para usá-lo.
    - **Atualize a documentação:** Se sua alteração impacta a forma como o projeto funciona, atualize a documentação relevante.

5. **Faça o Commit:** Escreva uma mensagem de commit clara e concisa em inglês. Recomendamos o padrão Conventional Commits.

    ```bash
    git commit -m "feat: Add new study on Minimal APIs"
    git commit -m "docs: Fix typo in README.md"
    ```

6. **Envie para o seu Fork:**

    ```bash
    git push origin feature/nome-da-sua-feature
    ```

7. **Abra um Pull Request:** Volte ao repositório original no GitHub e abra um Pull Request da sua branch para a branch `main` do nosso repositório. Preencha o template do PR com os detalhes da sua contribuição.

## 🥇 Licença

Ao contribuir, você concorda que suas contribuições serão licenciadas sob a [Creative Commons Atribuição-NãoComercial-CompartilhaIgual 4.0 Internacional (CC BY-NC-SA 4.0)](./LICENSE.md).

Obrigado pela sua contribuição!
