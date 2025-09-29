# Como fazer Profiling Básico no C#

Fundamental para otimizar o desempenho e a eficiência de suas aplicações.

- **Visual Studio**: Possui interface gráfica de profiling integrada.
- **Visual Studio Code**: Não possui interface gráfica de profiling integrada.
  - Extensões como "Performance Profiler" ou uso de ferramentas externas.
  - Ferramentas de diagnóstico do .NET via linha de comando (são muito poderosas).

## Passo a Passo com Ferramentas de diagnóstico do .NET via linha de comando

### Como Fazer Profiling de CPU

O processo envolve usar dois terminais:

- um para rodar sua aplicação.
- outro para rodar a ferramenta de profiling.

1. Instalar a Ferramenta dotnet-trace

Se você ainda não a tem, instale-a globalmente.

```bash
dotnet tool install --global dotnet-trace
```

Se já estiver instalada, você pode atualizá-la:

```bash
dotnet tool update --global dotnet-trace
```

2. Preparar e Executar a Aplicação

```csharp
// Program.cs
using System.Diagnostics;

Console.WriteLine("Iniciando a aplicação de exemplo para profiling.");
Console.WriteLine($"Process ID: {Process.GetCurrentProcess().Id}"); // Adicionado para facilitar!

ProcessamentoLento();
AlocacaoDeMemoria();

Console.WriteLine("Processamento concluído. Pressione Enter para sair.");
Console.ReadLine();

static void ProcessamentoLento()
{
    Console.WriteLine("Iniciando processamento lento...");
    long counter = 0;
    for (int i = 0; i < 1_000_000_000; i++)
    {
        counter++;
    }
    Console.WriteLine("Processamento lento finalizado.");
}

static void AlocacaoDeMemoria()
{
    Console.WriteLine("Iniciando alocação de memória...");
    var lista = new List<string>();
    for (int i = 0; i < 100_000; i++)
    {
        lista.Add($"Item número {i}");
    }
    Console.WriteLine("Alocação de memória finalizada.");
}
```

Agora, no primeiro terminal do VS Code, execute sua aplicação:

```bash
dotnet run
```

A aplicação vai iniciar e mostrar o ID do Processo (PID). Anote esse número.

```plaintext
Iniciando a aplicação de exemplo para profiling.
Process ID: 12345  <-- ANOTE ESTE NÚMERO
Iniciando processamento lento...
```

3. Iniciar a Coleta de Dados

Abra um segundo terminal no VS Code (clicando no ícone + na aba do terminal). Enquanto a aplicação está rodando, execute o dotnet-trace para começar a coletar dados, usando o PID que você anotou:

```bash
# Substitua 12345 pelo PID da sua aplicação
dotnet-trace collect --process-id 12345
```

A ferramenta começará a coletar os dados de performance. Deixe-a rodando até que sua aplicação termine o `ProcessamentoLento`. Depois, você pode parar a coleta pressionando `Ctrl+C` no segundo terminal.

Ao parar, um arquivo de trace (ex: `trace.nettrace`) será salvo no diretório atual.

4. Analisar o Arquivo de Trace

O arquivo `.nettrace` contém todos os dados brutos. Você tem algumas opções para visualizá-lo de forma amigável:

- **Opção A (Recomendada)**: Abrir no Visual Studio (IDE Completa) Se você tem o Visual Studio (Community, Professional ou Enterprise) instalado, essa é a maneira mais fácil. Apenas dê um duplo clique no arquivo trace.nettrace e ele abrirá a mesma interface gráfica de análise que vimos antes, com o "Hot Path" e a lista de funções.

- **Opção B (Rápida e Online)**: Usar o SpeedScope Para uma análise rápida e baseada na web, você pode usar o site [https://www.speedscope.app/](https://www.speedscope.app/).
  - Acesse o site.
  - Arraste e solte seu arquivo trace.nettrace na página.
  - Ele exibirá um "flame graph", que é uma visualização do tempo de CPU gasto em cada função. Funções mais "largas" no gráfico são as que mais consumiram tempo. Você verá claramente o ProcessamentoLento dominando o gráfico.

### Como Fazer Profiling da Memória

Para uma análise básica de memória via linha de comando, você pode usar a ferramenta dotnet-counters.

1. **Instale a ferramenta**:

```bash
dotnet tool install --global dotnet-counters
```

2. **Monitore em tempo real**: Enquanto sua aplicação roda, execute no segundo terminal:

```bash
# Substitua 12345 pelo PID da sua aplicação
dotnet-counters monitor --process-id 12345
```

Isso mostrará em tempo real contadores como o uso da CPU, o tamanho do heap da memória (GC Heap Size) e o número de exceções, o que já dá uma boa pista sobre o comportamento da aplicação.

## CONCLUSÃO

Embora o VS Code exija o uso da linha de comando, as ferramentas `dotnet-trace` e `dotnet-counters` são extremamente eficazes e formam a base do diagnóstico de performance em .NET, independentemente do editor que você usa.
