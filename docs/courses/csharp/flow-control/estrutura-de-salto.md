# Estruturas de Salto

Permitem pular para outra parte do código ou sair de uma estrutura.

## Instrução `break`

A instrução `break` é usada para sair de um loop ou de uma estrutura de controle como `switch`. Ela interrompe a execução do loop ou da estrutura imediatamente e continua com o código após o bloco.

**ERRO:** Em C#, se você omitir uma instrução `break` (ou outra instrução de saída como `return` ou `throw`) em uma seção `case` que contém código, você receberá um erro de compilação. O compilador C# não permitirá que o código seja executado.
O erro específico é o `CS0163: "O controle não pode passar de um rótulo de caso ('case X:') para outro"`.

**Por que isso acontece?** Os projetistas da linguagem C# tomaram essa decisão para evitar um tipo de bug muito comum em outras linguagens, onde o programador esquece o `break` e o código "cai" (**fall-through**) para o próximo case sem querer, executando lógica não intencional. Em C#, a sua intenção deve ser explícita.

### Recapitulação

- Omissão de break em um case com código: Causa um erro de compilação (CS0163).
- "Fall-through" intencional: É permitido apenas empilhando cases vazios para que eles compartilhem o mesmo bloco de código e a mesma instrução de saída (break, return, etc.).

Essa é uma das características de segurança do C# que ajuda a escrever um código mais robusto e com menos bugs inesperados.

## Instrução continue

O comando `continue` pula o restante do código da iteração atual e avança para a próxima iteração do loop.

## Instrução `return`

A instrução `return` encerra a execução de um método e retorna o controle para o código que o chamou. Opcionalmente, ele pode retornar um valor.

## Instrução `goto`

O comando `goto` transfere o controle do programa para uma instrução marcada com um rótulo. **Seu uso é fortemente desaconselhado** em código moderno por dificultar a leitura e a manutenção, criando o que se conhece como "spaghetti code".
