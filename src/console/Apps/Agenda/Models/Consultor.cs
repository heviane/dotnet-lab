using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Consultor
    {
        public string Nome { get; set; }
        public Agendamento Agendamento { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome}:");

            if (Agendamento == null)
            {
                Console.WriteLine("Nenhum agendamento cadastrado");
            }
            else
            {
                Agendamento.Exibir();
            }
        }
    }
}
