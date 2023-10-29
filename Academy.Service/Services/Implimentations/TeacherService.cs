
using Academy.Core.Models.BaseModels;
using Academy.Core.Models;
using Academy.Service.Services.Interfaces;
using Academy.Service.Services.StringService;
using System.Collections.Generic;
using System;

namespace Academy.Service.Services.Implimentations
{
    public class TeacherService : ITeacherService
    {
        List<Teacher> teachers = new List<Teacher>();
        public void CreateTeacher()
        {
            Console.WriteLine("Add Teacher Name:");
            string Name = Console.ReadLine();
            Name = Name.Str();
            Console.WriteLine("Add Teacher Surname:");
            string Surname = Console.ReadLine();
            Surname = Surname.Str();
            Console.WriteLine("Add Teacher Age:");
            int.TryParse(Console.ReadLine(), out int Age);
            Console.WriteLine("Add Teacher Salary:");
            int.TryParse(Console.ReadLine(), out int Salary);

            Teacher teacher = new Teacher();
            teacher.Name = Name;
            teacher.Surname = Surname;
            teacher.Age = Age;
            teacher.Salary = Salary;

            teachers.Add(teacher);
            Console.WriteLine("Succesfull add :)");
        }

        public void GetByIdTeacher()
        {
            Console.WriteLine("Add Id:");
            int.TryParse(Console.ReadLine(), out int id);
            Teacher result = null;
            foreach (Teacher teacher in teachers)
            {
                if (teacher.Id == id)
                {
                    result = teacher;
                    break;
                }
            }
            if (result == null)
            {
                Console.WriteLine("Id tapilmadi :(");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public void ShowTeacher()
        {
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}
