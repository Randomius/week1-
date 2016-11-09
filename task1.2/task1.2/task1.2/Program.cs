using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //create array of sruct
            Student[] students = new Student[10];
            //fill array
            students[0].FirstName = "Dmitrii";
            students[0].SecondName = "Nefedov";
            students[0].Age = 22;
            students[0].Faculty = "Economics";
            students[0].FormOfEducation = "Daily";
            students[0].Course = 1;

            students[1].FirstName = "Genadii";
            students[1].SecondName = "vertoletov";
            students[1].Age = 23;
            students[1].Faculty = "Build";
            students[1].FormOfEducation = "Daily";
            students[1].Course = 2;

            students[2].FirstName = "Anton";
            students[2].SecondName = "Grifonov";
            students[2].Age = 22;
            students[2].Faculty = "Economics";
            students[2].FormOfEducation = "Daily";
            students[2].Course = 1;

            students[3].FirstName = "Stanislav";
            students[3].SecondName = "Kisilev";
            students[3].Age = 24;
            students[3].Faculty = "Economics";
            students[3].FormOfEducation = "Evening";
            students[3].Course = 3;

            students[4].FirstName = "Kriss";
            students[4].SecondName = "Mededev";
            students[4].Age = 22;
            students[4].Faculty = "Economics";
            students[4].FormOfEducation = "Daily";
            students[4].Course = 1;

            students[5].FirstName = "Ivan";
            students[5].SecondName = "Kenedy";
            students[5].Age = 22;
            students[5].Faculty = "Economics";
            students[5].FormOfEducation = "Daily";
            students[5].Course = 1;

            students[6].FirstName = "Irina";
            students[6].SecondName = "Soroka";
            students[6].Age = 22;
            students[6].Faculty = "Economics";
            students[6].FormOfEducation = "Daily";
            students[6].Course = 1;

            students[7].FirstName = "Anastasia";
            students[7].SecondName = "Grishina";
            students[7].Age = 22;
            students[7].Faculty = "Build";
            students[7].FormOfEducation = "Evening";
            students[7].Course = 1;

            students[8].FirstName = "Konstantin";
            students[8].SecondName = "Adamov";
            students[8].Age = 22;
            students[8].Faculty = "Economics";
            students[8].FormOfEducation = "Daily";
            students[8].Course = 1;

            students[9].FirstName = "Random";
            students[9].SecondName = "Sluchainii";
            students[9].Age = 22;
            students[9].Faculty = "Economics";
            students[9].FormOfEducation = "Daily";
            students[9].Course = 1;

            foreach(Student student in students)
            {
                student.output();
            }
            Console.WriteLine("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }

        


        
        public struct Student//create struct
        {
            public string FirstName;
            public string SecondName;
            public int Age;
            public string Faculty;
            public string FormOfEducation;
            public int Course;

            //int i;

           public void output()
            {

                Console.WriteLine("Name:'{0}',2ndName:'{1},Age:'{2}', Faculty:'{3}',FOE:'{4}',couse:'{5}'", FirstName, SecondName, Age, Faculty, FormOfEducation, Course);
            }

            
        }
    }
}
