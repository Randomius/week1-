using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
           // int temp;
            Random rnd = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-500, 500);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("for sort press any key...");
            Console.ReadKey();
            Array.Sort(array);
            //не запускает последний цикл сортировки и один элемент остается не отсортирован
            /*   for (int i = 0; i < n - 1; i++)
            {
                while (array[i]<array[i+1])
                {

                    for (int j = 0; j < n - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;                            
                        }
                    }
                }
            }*/


            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();

        }
    }
}
