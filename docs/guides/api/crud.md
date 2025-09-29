# CRUD

A sigla CRUD representa as quatro operações básicas para a manipulação de dados em um sistema:

- Create (Criar)
- Read (Ler)
- Update (Atualizar)
- Delete (Deletar)

Exemplo de CRUD em `src/api/Apps/TaskManager/Controllers/TasksController.cs`:

1. Create (Criar): Adicionar uma nova tarefa.
    Método: CreateTask
    Verbo HTTP: [HttpPost]
    O que faz: Recebe os dados de uma nova tarefa no corpo da requisição, atribui um ID a ela e a adiciona à lista _tasks.
    Read (Ler): Consultar as tarefas existentes.

2. Read (Ler): Consultar as tarefas existentes.
    Métodos: GetTasks e GetTask(int id)
    Verbo HTTP: [HttpGet]
    O que faz: O primeiro método retorna a lista completa de tarefas. O segundo retorna uma única tarefa específica, buscando-a pelo seu id.
    Update (Atualizar): Modificar uma tarefa existente.

3. Update (Atualizar): Modificar uma tarefa existente.
    Método: UpdateTask
    Verbo HTTP: [HttpPut("{id}")]
    O que faz: Recebe o id da tarefa a ser modificada e os novos dados. Em seguida, encontra a tarefa na lista e atualiza suas propriedades.
    Delete (Deletar): Remover uma tarefa.

4. Delete (Deletar): Remover uma tarefa.
    Método: DeleteTask
    Verbo HTTP: [HttpDelete("{id}")]
    O que faz: Recebe o id de uma tarefa, a encontra na lista e a remove.
    Em resumo, ter um "CRUD completo" significa que sua API tem toda a funcionalidade básica necessária para gerenciar o ciclo de vida de um recurso (neste caso, as tarefas).
