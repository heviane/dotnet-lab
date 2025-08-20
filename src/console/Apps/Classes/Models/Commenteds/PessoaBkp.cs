namespace Models
{
    public class PessoaBkp
    {

        // --- Propriedades e Campos --- São conceitos fundamentais em C# para armazenar e manipular dados dentro de uma classe.

        // --- Propriedades --- são usadas para armazenar dados de uma classe - sempre tem métodos getters e setters.
        // Propriedades são membros de uma classe que fornecem acesso controlado a campos privados
        // Propriedades são usadas para encapsular campos, permitindo controle sobre como os dados são acessados e modificados.
        // Propriedades são como campos, mas com lógica adicional para acessar e modificar os valores.

        // --- Campos --- são usados para armazenar dados diretamente, sem lógica adicional.
        // Campos são variáveis que armazenam dados diretamente, mas não oferecem controle adicional.
        // Em C#, é comum usar propriedades para acessar e modificar campos, pois elas permitem adicionar lógica personalizada
        // (como validação ou formatação) ao acessar ou modificar os dados.

        // Eles são declarados como variáveis dentro da classe e geralmente são privados, acessíveis apenas dentro da própria classe.
        // Campos não têm lógica de acesso ou modificação, são simplesmente usados para armazenar valores.
        // Eles são úteis quando você precisa de armazenamento simples e não precisa de lógica adicional para acessar ou modificar os valores.

        // --- Propriedades automáticas - são uma forma simplificada de declarar propriedades sem lógica adicional, (sem getters e setters personalizados).
        // Elas são úteis quando você só precisa armazenar dados sem lógica extra.
        // O compilador C# cria automaticamente os campos de apoio para você.

        // --- Exemplo de propriedade com lógica personalizada
        // Campos de apoio ("backing fields") privados para armazenar os valores reais.
        private string _name = string.Empty;
        private int _age;
        // Propriedade pública 'Name' com lógica personalizada no getter.
        public string Name
        {
            get { return _name.ToUpper(); } // Retorna o valor em maiúsculas.
            set { _name = value; }          // Define o valor, armazenando-o no campo de apoio _name.
        }

        /* ------ EXEMPLO DE ERRO COMUM ------
            erro: uma chamada recursiva infinita dentro das suas propriedades.

            public string Name
            {
                get { return Name.ToUpper(); } // PROBLEMA AQUI
                set;
            }

            Dentro do get da propriedade Name, você está chamando a própria propriedade Name.
            Isso cria um loop infinito: para obter o valor de Name, o código chama Name, que por sua vez chama Name,
            e assim por diante, até que o programa quebre com um erro de estouro de pilha (StackOverflowException).

            A Solução: Campos de Apoio (Backing Fields)
            Quando você precisa adicionar lógica customizada a um get ou set (como validação ou formatação),
            você não pode mais usar a sintaxe de propriedade automática ({ get; set; }).
            Você precisa criar manualmente um campo privado (chamado de backing field) para armazenar o valor,
            e a propriedade pública servirá como um "portão" para acessar e modificar esse campo.
        */

        // --- Exemplo de propriedade automática
        // public string Name { get; set; }
        public int Id { get; set; }                 // 'Id' é uma propriedade automática que armazena um int.
        //public required string Name { get; set; } // 'required' indica que a propriedade é obrigatória (não pode ser nula) *** Recomendado e mais atual ***
        //public string? Name { get; set; }         // '?' indica que a propriedade é opcional (pode ser nula)
        public DateTime Birthday { get; set; }

        // --- Métodos get e set - são usados para acessar e modificar as propriedades de uma classe.
        // Get - é usado para obter o valor da propriedade
        // Set - é usado para definir o valor da propriedade.

        // --- Exemplos de uso de get e set:
        // public string Name { get; set; } = "João"; // 'Name' é uma propriedade com um valor padrão de "João"
        // Console.WriteLine(pessoa.Name);            // Acessa o valor da propriedade 'Name' usando o método get de forma implícita
        // pessoa.Name = "Maria";                     // Define o valor da propriedade 'Name' usando o método set de forma implícita
        // Console.WriteLine(pessoa.Name);            // Acessa o novo valor da propriedade 'Name' usando o método get de forma implícita

        public int Age
        {
            get
            {
                _age = (int)((DateTime.Now - Birthday).TotalDays / 365.25);
                return _age;

            }
            /*
            set
            {
                if (value < 0)
                {
                    // Lança uma exceção se a idade for negativa.
                    throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative");
                }
                _age = value; // Agora atribui o valor ao campo de apoio _age.
            }
            */
        }

        // --- Exemplo de propriedade com Body Expression (Forma recomendada: Mais legível e concisa)
        // --- Exemplo de propriedade somente leitura (Read-Only Property)
        // Possui apenas o método get, não tem o método set.
        // Propriedade que retorna um valor calculado com base em outras propriedades.
        public bool IsAdult => Age >= 18;

        // --- Exemplo de propriedade com Body Expression
        // Deve ser usado sempre que o código for de uma única linha, sem lógica adicional.
        /* 2 formas de usar Body Expression:

            // Forma mais simples e moderna:
            public string Name => _name.ToUpper();

            // Forma mais explícita:
            public string Name
            {
                get => _name.ToUpper(); // Retorna o nome em maiúsculas
                set => _name = value;   // Define o nome, armazenando-o no campo de apoio _name
            }
        */

        public string LastName { get; set; } = string.Empty;

        // --- Exemplo de propriedade somente leitura (Read-Only Property)
        // Propriedade que só tem o método get, não tem o método set.
        // O valor é definido apenas no construtor ou diretamente na declaração.
        // => refere-se a Body Expression.
        public string FullName => $"{Name} {LastName}"; // Propriedade somente leitura que concatena Name e LastName.
        public string FullName2 { get { return $"{Name} {LastName}"; } } // Mesma propriedade FullName, mas sem usar Body Expression.


        // --- Método Constructor - é um método especial usado para inicializar objetos de uma classe.
        // O construtor com parâmetros foi removido. Como o código em `ClassesApp.cs` usa `new Pessoa()` e inicializadores de objeto, ele precisa de um construtor sem parâmetros.
        // Ao remover o construtor customizado, o compilador C# fornece um construtor público e sem parâmetros automaticamente, o que resolve o problema.

        // Métodos - são usados para definir comportamentos de uma classe.
        public virtual void Apresentar()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"- Olá, meu nome é {FullName}, tenho {Age} anos, pois nasci em {Birthday.ToString("dd/MM/yyyy")}. Sou maior de idade? {IsAdult}.");
            // Name, Age e Birthday estão retornando os valores via método get, que é implicito.
        }
    }
}
