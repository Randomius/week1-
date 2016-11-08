using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job1
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student;
            student.fio  = "Ivanov Ivan Ivanovic";
            student.FormOfEducation = "dnvnaia";
            student.course = 3;
            student.faculty = "stroitelnui";

            student.Info();//output student info

            Console.ReadLine();

        }


        public struct Students //struct
        {
            public string fio;
            public string FormOfEducation;
            public int course;
            public string faculty;

            public void Info()
            {

                Console.WriteLine ("Ф.И.О.:'{0}', форма обучения: '{1}', курс: '{2}', факультет: '{3}' ", fio , FormOfEducation, course, faculty);//console output students info 

            }


        }
        
    }
}
