# 🚀 Fluxo de Trabalho para Contribuições

1. **Faça um Fork do Repositório**

- Clique no botão "Fork" no canto superior direito da página do repositório.

2. **Clone o seu Fork**

```bash
git clone https://github.com/SEU-USUARIO/dotnet-lab.git
cd dotnet-lab
```

3. **Crie uma Nova Branch**

- Crie uma branch descritiva para a sua alteração a partir da `main`.
- Use um prefixo como `feat/` para novas funcionalidades, `fix/` para correções, ou `docs/` para documentação.

```bash
git checkout -b feat/nova-calculadora-api
```

4. **Faça suas Alterações**

- Escreva seu código ou documentação.
- Se adicionar código, adicione também os testes correspondentes. Garanta que os testes existentes continuam passando.
- Certifique-se de que seu código segue as convenções definidas no arquivo `.editorconfig`.

5. **Faça o Commit das suas Alterações**

- Escreva uma mensagem de commit clara e descritiva.

 ```bash
 git commit -m "feat: Adiciona endpoint de multiplicação na API da calculadora"
```

6. **Envie suas Alterações para o seu Fork**

```bash
git push origin feat/nova-calculadora-api
```

7. **Abra um Pull Request (PR)**

- Vá para o repositório original e você verá um aviso para criar um Pull Request a partir da sua nova branch.
- Abra o Pull Request para a branch `main`.
- Preencha o template do PR com uma descrição clara das suas alterações.

Aguarde a revisão e obrigado por sua contribuição! 💙
