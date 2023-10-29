
using Academy.Core.Models;
using Academy.Core.Models.BaseModels;
using Academy.Service.Services.Interfaces;
using Academy.Service.Services.StringService;
using System;
using System.Collections.Generic;

namespace Academy.Service.Services.Implimentations
{
    public class StudentService : IStudentService
    {
        List<Student> students = new List<Student>();
        public void CreateStudent()
        {
            Console.WriteLine("Add Student Name:");
            string Name = Console.ReadLine();
            Name = Name.Str();
            Console.WriteLine("Add Student Surname:");
            string Surname = Console.ReadLine();
            Surname = Surname.Str();
            Console.WriteLine("Add Student Age:");
            int.TryParse(Console.ReadLine(), out int Age);
            Console.WriteLine("Add Student Average:");
            int.TryParse(Console.ReadLine(), out int Average);

            Student student = new Student();
            student.Name = Name;
            student.Surname = Surname;
            student.Age = Age;
            student.Average = Average;

            students.Add(student);
            Console.WriteLine("Succesfull add :)");
        }

        public void GetByIdStudent()
        {
            Console.WriteLine("Add Id:");
            int.TryParse(Console.ReadLine(), out int id);
            Person result = null;
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    result = student;
                    break;
                }
            }
            if(result == null)
            {
                Console.WriteLine("Id tapilmadi :(");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public void ShowStudent()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
