# Criar comentários de código eficazes

Neste exercício, você adicionará observações ao seu código e desabilitaremos temporariamente determinadas linhas de código da compilação. Em seguida, verá como o compilador do C# compreende o espaço em branco e como usar espaço em branco para aumentar a legibilidade do seu código.

## O que é um comentário de código?

Um comentário de código é uma instrução para o compilador ignorar tudo que vem após os símbolos de comentário de código na linha atual.

```csharp
// This is a code comment!
```

Isso pode não parecer útil a princípio, mas é útil em três situações:

- Quando você quer deixar uma observação sobre a intenção de uma passagem de código. Pode ser útil incluir comentários de código que descrevem a finalidade ou o processo de pensamento quando você está escrevendo um conjunto particularmente desafiador de instruções de codificação. Isso facilitará muito seu trabalho no futuro.
- Quando você deseja remover temporariamente o código do aplicativo para tentar uma abordagem diferente, mas ainda não está convencido de que sua nova ideia funcionará. Você poderá comentar o código, escrever o novo código e, quando estiver convencido de que o novo código funcionará da maneira desejada, você poderá excluir o antigo (código comentado) com segurança.
- Adicionar uma mensagem como **TODO** para lembrá-lo de examinar uma determinada passagem de código posteriormente. Embora você deva usar isso criteriosamente, esse é uma abordagem útil. Você pode estar trabalhando em outro recurso e ler uma linha de código que desperta uma preocupação. Em vez de ignorar a nova preocupação, você pode marcá-la para investigação posterior.

>**Observação:** Os comentários de código devem ser usados para dizer o que o código não pode fazer. Muitas vezes, os desenvolvedores atualizam o código mas esquecem de atualizar os comentários. É melhor usar comentários para ideias de nível superior e não adicionar comentários sobre como uma linha de código individual funciona.

## Recapitulação

- Use comentários de código a fim de deixar observações significativas para si mesmo sobre os problemas que cada trecho de código específico resolve.
- Não use os comentários de código para explicar como funciona o C# ou a biblioteca de classes do .NET.
- Use comentários de código ao experimentar temporariamente soluções alternativas até que você esteja pronto para confirmar a nova solução de código; nesse ponto, você poderá excluir o código antigo.
- Nunca confie em comentários. Eles podem não refletir o estado atual do código após muitas alterações e atualizações.
