using System;
using System.Globalization;
using Agenda.Models;

class Program
{
    static void Main()
    {

        string linhaConsultor = Console.ReadLine();

        string nomeConsultor = linhaConsultor.Replace("Consultor:", "").Trim();

        Console.ReadLine();

        string linhaAgendamento = Console.ReadLine();

        var consultor = new Consultor { Nome = nomeConsultor };

        if (!string.IsNullOrWhiteSpace(linhaAgendamento))
        {
            string[] partes = linhaAgendamento.Split(',');
            var agendamento = new Agendamento
            {
                NomeCliente = partes[0].Trim(),
                Data = DateTime.ParseExact(partes[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Descricao = partes[2].Trim()
            };
            consultor.Agendamento = agendamento;
        }
        consultor.ExibirInformacoes();
    }
}
