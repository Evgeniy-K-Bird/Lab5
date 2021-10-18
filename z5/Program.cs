using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N, для матрицы размером NxN:");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            bool o = false;
            bool o1 = !o;
            int b = 0;
            int i = 0;
            int j = 0;
            for (i = 0; i < n; i++)
            {
                if (n%2==0)
                {
                    o = !o;
                }
                else
                {
                    o1 = !o1;
                }
                Console.WriteLine();
                for (j = 0; j < n; j++, o = !o)
                {
                    if (o == true)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = 1;
                    }
                    array[i, j] = b;
                    Console.Write("{0} ", array[i, j]);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
            }
}

        
