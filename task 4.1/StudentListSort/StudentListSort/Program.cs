using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var studList = new List<Student>
            {
                new Student
                {
                    Name = "Gena Vedrov",
                    Adress ="Pupkina 5",
                    Birth = new DateTime(2001, 11, 3, 0, 0, 0),
                    School = School.School31
                },
                new Student
                {
                    Name = "Dima Hrenov",
                    Adress ="Pupkina 5",
                    Birth = new DateTime(2002, 10, 13, 0, 0, 0),
                    School = School.School28
                },
                new Student
                {
                    Name = "Jenia Borsh",
                    Adress ="Pupkina 3",
                    Birth = new DateTime(1999, 7, 9, 0, 0, 0),
                    School = School.School31
                },
                new Student
                {
                    Name = "Kiril Kirov",
                    Adress ="Pupkina 3",
                    Birth = new DateTime    (1997, 11, 23, 0, 0, 0),
                    School = School.School26
                },
                new Student
                {
                    Name = "Slava Sedoi",
                    Adress ="Pupkina 10",
                    Birth = new DateTime(1999, 12, 29 , 0, 0, 0),
                    School = School.School26
                },
                new Student
                {
                    Name = "Evgenii Kosmos",
                    Adress ="Pupkina 1",
                    Birth = new DateTime(1998, 4, 12, 0, 0, 0),
                    School = School.School28
                },
                new Student
                {
                    Name = "Repa Moneta",
                    Adress ="Pupkina 9",
                    Birth = new DateTime(1999, 3, 19, 0, 0, 0),
                    School = School.School31
                },
                new Student
                {
                    Name = "Vera Zangieva",
                    Adress ="Pupkina 9",
                    Birth = new DateTime(2000, 1, 13, 0, 0, 0),
                    School = School.School31
                },
                new Student
                {
                    Name = "Sorok Sedmaia Hromosoma",
                    Adress ="Pupkina 3",
                    Birth = new DateTime(1998, 10, 22, 0, 0, 0),
                    School = School.School28
                },
                new Student
                {
                    Name = "Leeroi Jenkins",
                    Adress ="Pupkina 7",
                    Birth = new DateTime(1999, 3, 11, 0, 0, 0),
                    School = School.School26
                }


            };

            Display(studList, School.School31); // Before
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            studList.Sort();
            Console.WriteLine("\nSorting...\n");
            Display(studList, School.School31); // After
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();


        }

        static void Display(List<Student> obj, School sc)
        {
            foreach (Student t in obj)
                if (t.School == sc)
                {
                    Console.WriteLine("\nName: {0} , LastName{1}, Middle Name: {2}, Birth: {3:d}\n", t.Name,t.Adress,t.School, t.Birth);
                }
            Console.WriteLine("\n------------------\n");
        }




        internal class Student : IComparable<Student>
        {
            public string Name;
            public string Adress;
            public DateTime Birth;
            public School School;

            public int CompareTo(Student obj)
            {
                if (Birth > obj.Birth)
                    return 1;
                if (Birth < obj.Birth)
                    return -1;
                return 0;
            }
        }
        internal enum School
        {
            School31 = 0,
            School28 = 1,
            School26 = 2,
            
        }

    }
}
