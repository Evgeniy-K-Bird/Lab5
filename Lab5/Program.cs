using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите массив из 7 чисел");
            Console.WriteLine();
            int n = 7;
            int o = 1;
            double[] array = new double[n];
            for (int i = 0; i <= n - 1; i++, o++)
            {
                Console.Write("Впишите значение {0}:    ", o);

                array[i] = int.Parse(Console.ReadLine());
            }
            double itog = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                itog = itog + array[i];
            }
            itog = itog / n;
            Console.WriteLine();
            Console.Write("Среднее арифмитическое = {0}", itog);
            Console.ReadKey();
        }
    }
}
