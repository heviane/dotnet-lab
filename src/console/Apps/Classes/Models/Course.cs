using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class Course
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Pessoa> Students { get; set; } = new List<Pessoa>();

        public void AddStudent(Pessoa student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "O aluno não pode ser nulo.");
            }
            Students.Add(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"\n--- Alunos do curso: {Name} ---");
            if (Students.Any())
            {
                foreach (var student in Students)
                {
                    Console.WriteLine($"- {student.FullName}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno matriculado neste curso.");
            }
        }

        public void ListStudentsEnumerated()
        {
            Console.WriteLine($"\n--- Alunos do curso: {Name} ---");
            if (Students.Any())
            {
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {Students[i].FullName}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno matriculado neste curso.");
            }
        }

        public int GetStudentCount()
        {
            return Students.Count;
        }

        public bool RemoveStudent(Pessoa student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "O aluno não pode ser nulo.");
            }
            return Students.Remove(student);
        }
    }
}
