namespace Models
{
    public class Pessoa
    {
        // Propriedades - são usadas para armazenar dados de uma classe.
        public int Id { get; set; }
        //public required string Name { get; set; } // 'required' indica que a propriedade é obrigatória (não pode ser nula) *** Recomendado e mais atual ***
        //public string? Name { get; set; } // '?' indica que a propriedade é opcional (pode ser nula)
        public string Name { get; set; } = string.Empty; // inicializada com string vazia
        public int Age { get; set; }
        public DateTime Birthday { get; set; }

        // Métodos - são usados para definir comportamentos de uma classe.
        public void Apresentar()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"{today} - {today.DayOfWeek}: Olá, meu nome é {Name}, tenho {Age} anos, pois nasci em {Birthday.ToString("dd/MM/yyyy")}.");
        }
    }
}
