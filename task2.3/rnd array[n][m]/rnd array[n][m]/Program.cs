using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnd_array_n__m_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 4;
            int temp;
            int k = 1;

            Console.WriteLine("Creating new array:{0}x{1}", n, m);
            Random rnd = new Random();
            int[,] array = new int[n,m];
            int[] sumArray = new int[m];
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("{0}colum:", j + 1);
                for (int i = 0; i < n; i++)
                {
                    array[i, j] = rnd.Next(-500,500);
                    Console.WriteLine(array[i, j]);
                    sumArray[j] = sumArray[j] + array[i, j];
                }
                Console.WriteLine("culum sum:{0}", sumArray[j]);
            }
            Console.WriteLine("press any key to sort");
            Console.ReadKey();
            while (k != 0)
            {

                for (int j = 0; j < m - 1; j++)
                {

                    k = 0;

                    if (sumArray[j] < sumArray[j + 1])
                    {
                        temp = sumArray[j];
                        sumArray[j] = sumArray[j + 1];
                        sumArray[j + 1] = temp;

                        for (int i = 0; i < n - 1; i++)
                        {
                            {
                                temp = array[i, j];
                                array[i, j] = array[i, j + 1];
                                array[i, j + 1] = temp;

                            }
                        }
                        k++;
                    }
                }
            }
            Console.WriteLine("sorted array:");
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("{0}colum:", j + 1);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i, j]);
                }                
                Console.WriteLine("culum sum:{0}",sumArray[j]);
            }


            Console.WriteLine("press any key to end program"); 
            Console.ReadKey();
        }
    }
}
