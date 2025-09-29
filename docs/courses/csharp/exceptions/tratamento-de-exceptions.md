# Tratamento de Exceptions

## Bloco `try`

O bloco `try` é utilizado para envolver o código que pode gerar uma exceção. Se uma exceção ocorrer, o fluxo de execução será transferido para o bloco `catch` correspondente.

## Bloco `catch`

O bloco `catch` é utilizado para capturar e tratar a exceção que ocorreu no bloco `try`. Ele pode ser usado para registrar o erro, exibir uma mensagem ao usuário ou realizar outras ações corretivas.

Podemos ter várias exceções (vários blocos `catch`), mas somente uma delas será capturada, sempre a primeira que ocorrer.

Tudo que está no bloco `catch`é um tratamento. O programa não conseguiu continuar, pois o compilador não conseguiu tratar a exceção, e agora está passando a responsabilidade para você, programador.

### Exceções Genéricas e Exceções Específicas

## Bloco `finally`

O bloco `finally` é executado sempre, independente de ocorrer ou não uma exceção.

Exemplos de quando usar:

- Garantir que certos recursos sejam liberados, mesmo que uma exceção ocorra.
- Liberar recursos, como memória ou conexões de rede.
- Fechar arquivos abertos.
- Fechar conexões de banco de dados.

## RESUMO

## BOAS PRÁTICAS

- Sempre começar com as exceções especificas, depois as exceções genéricas.
