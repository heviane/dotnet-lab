# MVC (Model View Controller)

## Model

## View

## Controller

Uma **Controller** é uma classe C# responsável por agrupar um conjunto de *endpoints* (ou *actions*) relacionados.
Ela recebe requisições HTTP, processa a lógica necessária e retorna uma resposta.

É o ponto de entrada principal da API.
É o pilar do padrão **MVC (Model-View-Controller)** em APIs.

### Anatomia de uma Controller

Uma controller típica possui os seguintes elementos (exemplo completo em `src/api/Apps/TaskManager/`):

```csharp
// 1. Atributos que definem o comportamento da controller
[ApiController]
[Route("api/[controller]")] // Define a rota base: ex: /api/tasks
public class TasksController : ControllerBase // 2. Herda de ControllerBase
{
    // 3. Métodos (Actions) que respondem a verbos HTTP
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "Task 1", "Task 2" };
    }
}
```

1. **Atributos**:
   - `[ApiController]`: Habilita um conjunto de funcionalidades úteis, como a inferência automática de origem dos parâmetros (model binding) e a validação automática do `ModelState`.
   - `[Route("api/[controller]")]`: Define o padrão da URL para acessar esta controller. `[controller]` é um token que é substituído pelo nome da classe sem o sufixo "Controller" (neste caso, `tasks`).

2. **Herança de `ControllerBase`**: Fornece acesso a métodos e propriedades úteis para lidar com requisições HTTP, como `Ok()`, `NotFound()`, `BadRequest()`, e acesso ao `HttpContext`.

3. **Actions (Ações)**: São os métodos públicos dentro da controller que respondem às requisições. Cada action é mapeada para um verbo HTTP através de atributos:
   - `[HttpGet]`: Para buscar dados.
   - `[HttpPost]`: Para criar um novo recurso.
   - `[HttpPut]`: Para atualizar um recurso existente.
   - `[HttpDelete]`: Para remover um recurso.

### Como Criar uma Controller

1. **Crie o projeto**: Use o template `webapi`.

    ```bash
    dotnet new webapi -o MinhaApi
    ```

2. **Crie o arquivo**: Dentro da pasta `Controllers`, crie uma nova classe com o sufixo `Controller`. Ex: `ProductsController.cs`.
3. **Implemente a classe**: Faça a classe herdar de `ControllerBase` e adicione os atributos `[ApiController]` e `[Route]`.
4. **Adicione as Actions**: Crie os métodos públicos e decore-os com os atributos de verbo HTTP (`[HttpGet]`, `[HttpPost]`, etc.).
