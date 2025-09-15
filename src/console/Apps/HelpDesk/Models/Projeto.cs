using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace HelpDesk.Models
{
    public class Projeto
    {
        // Nome do projeto
        public string Nome { get; set; }
        // Nome do consultor
        public string Consultor { get; set; }
        // Nota de qualidade
        public double Qualidade { get; set; }
        // Nota de prazo
        public double Prazo { get; set; }
        // Nota de satisfação
        public double Satisfacao { get; set; }


        // TODO: Crie o método que calcula a média das notas
        public double CalcularMedia()
        {
            return (Qualidade + Prazo + Satisfacao) / 3;
        }

        // Método que imprime as informações no formato solicitado
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Projeto: {Nome}");
            Console.WriteLine($"Consultor: {Consultor}");
            Console.WriteLine($"Notas: Qualidade: {Qualidade}, Prazo: {Prazo}, Satisfacao: {Satisfacao}");
            Console.WriteLine($"Media: {CalcularMedia().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
