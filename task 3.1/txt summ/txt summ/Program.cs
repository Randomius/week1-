using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace txt_summ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file pass:");
            string fName = Console.ReadLine();
            FileInfo fi = new FileInfo(fName);
            string txt = File.ReadAllText(fName);
            string[] mas = new string[] { " ", "\r", "\n" };
            string[] result;

            result = txt.Split(mas, StringSplitOptions.None);

            int kol = 0;
            int sum = 0;
            
            if (!fi.Exists)
            {
                Console.WriteLine("File not exist.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            foreach (string s in result)
            {
                try
                {


                    {

                        kol++;
                        sum += Convert.ToInt32(s);


                    }

                    



                }
                catch (FormatException)
                {

                }
            }
            Console.WriteLine("sum of numbers" + sum);
            Console.ReadKey();
        }
    }
}
