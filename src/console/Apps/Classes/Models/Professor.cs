using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    public sealed class Professor : Pessoa
    {

        public Student()
        {
            // método construtor vazio, assim não será obrigatório
            // Chamada aparecerá 2 opções: com construtor (obrigatório) e sem construtor (opcional)
        }

        public override void Apresentar()
        {
            // Chama a implementação original do método Apresentar da classe base (Pessoa). Isso evita a repetição de código.
            base.Apresentar();
            // Adiciona a informação extra, específica do professor.
            Console.WriteLine("  > Eu sou um professor.");
        }

    }
}
