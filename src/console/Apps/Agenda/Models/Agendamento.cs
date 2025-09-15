using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Agendamento
    {
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Data.ToString("dd/MM/yyyy")} - {NomeCliente}: {Descricao}");
        }
    }
}
