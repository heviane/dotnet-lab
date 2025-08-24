# Lançamento de Exceptions

## Bloco `throw`

O bloco `throw` é utilizado para lançar uma exceção manualmente.

### Conceito de Stack Trace (pilha de chamadas)

Quando uma exceção é lançada, o .NET cria um objeto `Exception` que contém informações sobre o erro ocorrido. Esse objeto inclui um rastreamento de pilha (stack trace), que é uma lista de chamadas de métodos que estavam em execução no momento em que a exceção foi lançada.

O **stack trace** mostra a sequência de métodos que foram chamados, começando pelo método onde a exceção foi lançada e indo até o ponto de entrada do programa. Ele fornece informações sobre os arquivos de código fonte, números de linha e nomes dos métodos envolvidos.

O **stack trace** é uma ferramenta valiosa para depuração, pois permite que os desenvolvedores identifiquem onde ocorreu o erro no código e quais métodos estavam envolvidos na execução naquele momento.

Ou seja, quando um erro ocorre em um programa, o .NET utiliza o conceito de pilha de chamadas (stack trace) para rastrear a sequência de métodos que foram chamados até o ponto onde a exceção foi lançada.

*A exceção lançada vai sendo jogada para cima na pilha até encontrar um bloco `catch` que a pegue para tratar, caso contrário continua sendo joagada para cima até terminar a pilha, até o último chamador. E se nesse caminho, não houver nenhum tratamento, a exceção será lançada sem tratamento e o programa será encerrado abruptamente.*

Resumindo, quando uma exceção é lançada, ela faz o caminho de volta na pilha de chamadas.
