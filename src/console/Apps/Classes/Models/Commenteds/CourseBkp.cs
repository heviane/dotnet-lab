using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class CourseBkp
    {
        public string Name { get; set; } = string.Empty; // Nome do curso, propriedade automática.
        public string Description { get; set; } = string.Empty; // Descrição do curso
        public List<Pessoa> Students { get; set; } = new List<Pessoa>(); // Lista de alunos inscritos no curso

        public void AddStudent(Pessoa student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "O aluno não pode ser nulo.");
            }
            Students.Add(student); // Adiciona um aluno à lista de alunos do curso
        }

        // Método para listar os alunos matriculados no curso.
        public void ListStudents()
        {
            Console.WriteLine($"\n--- Alunos do curso: {Name} ---");
            if (Students.Any()) // Verifica se a lista de alunos não está vazia.
            {
                foreach (var student in Students)
                {
                    // Usa a propriedade FullName da classe Pessoa.
                    Console.WriteLine($"- {student.FullName}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno matriculado neste curso.");
            }
        }

        // Método para obter o número total de alunos matriculados no curso.
        public int GetStudentCount()
        {
            return Students.Count; // Retorna a contagem de alunos na lista.
        }

        // Método para remover um aluno do curso, retornando true se bem-sucedido.
        public bool RemoveStudent(Pessoa student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "O aluno não pode ser nulo.");
            }
            // O método List<T>.Remove(item) já retorna um bool indicando se a remoção foi bem-sucedida.
            // Podemos retornar seu resultado diretamente.
            return Students.Remove(student);
        }

        /*
            - A versão que retorna um bool é mais flexível e reutilizável,
            pois permite que o código que a chama decida o que fazer com base no sucesso ou falha da operação.
            - A versão que retorna void e escreve no console mistura responsabilidades (lógica de negócio com interação de UI).
            RESUMO: A melhor abordagem é manter apenas a versão que retorna bool, pois ela é mais alinhada com boas práticas de design de software,
            promovendo a separação de preocupações e facilitando a manutenção e reutilização do código.
            ==>> Com essa refatoração, seu código fica mais limpo, correto e segue melhores práticas de design.

                // Método para remover um aluno do curso.
            public void RemoveStudent(Pessoa student)
            {
                if (student == null)
                {
                    throw new ArgumentNullException(nameof(student), "O aluno não pode ser nulo.");
                }
                if (Students.Contains(student))
                {
                    Students.Remove(student); // Remove o aluno da lista de alunos do curso.
                    Console.WriteLine($"O aluno {student.FullName} foi removido do curso '{Name}'.");
                }
                else
                {
                    Console.WriteLine($"O aluno {student.FullName} não está matriculado neste curso.");
                }
            }
        */
    }
}
