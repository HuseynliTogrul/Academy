
using Academy.Service.Services.Implimentations;
using System;

namespace Academy.Service.Services
{
    public class AcademyService
    {
        StudentService studentService = new StudentService();
        TeacherService teacherService = new TeacherService();
        public void RunApp()
        {
            ShowMenu();
            void ShowMenu()
            {
                Console.WriteLine("1-create student");
                Console.WriteLine("2-show students");
                Console.WriteLine("3-id student");
                Console.WriteLine("4-create teacher");
                Console.WriteLine("5-show teachers");
                Console.WriteLine("6-id teacher");
                Console.WriteLine("0-close");
            }
            string request = Console.ReadLine();

            while (request != "0")
            {
                switch (request)
                {
                    case "1":
                        studentService.CreateStudent();
                        break;
                    case "2":
                        studentService.ShowStudent();
                        break;
                    case "3":
                        studentService.GetByIdStudent();
                        break;
                    case "4":
                        teacherService.CreateTeacher();
                        break;
                    case "5":
                        teacherService.ShowTeacher();
                        break;
                    case "6":
                        teacherService.GetByIdTeacher();
                        break;
                    default:
                        Console.WriteLine("duzgun deyer gir");
                        break;
                }
                ShowMenu();
                request = Console.ReadLine();
            }
        }
    }
}