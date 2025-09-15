using HelpDesk.Models;

class Program
{
    static void Main()
    {
        string linhaProjeto = Console.ReadLine();
        string nomeProjeto = linhaProjeto.Substring(9);

        string linhaConsultor = Console.ReadLine();
        string nomeConsultor = linhaConsultor.Substring(11);

        string linhaNotas = Console.ReadLine();
        string notasApenas = linhaNotas.Substring(7);
        string[] partes = notasApenas.Split(", ");

        // Criação do objeto Projeto com os dados extraídos
        Projeto projeto = new Projeto
        {
            Nome = nomeProjeto,
            Consultor = nomeConsultor,
            Qualidade = int.Parse(partes[0]),
            Prazo = int.Parse(partes[1]),
            Satisfacao = int.Parse(partes[2])
        };

        projeto.ExibirInformacoes();
    }
}
