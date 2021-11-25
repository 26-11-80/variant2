using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            double val = Convert.ToDouble (Console.ReadLine());
            // int val = 9;
            for (int i = 1; i <= 2 * val - 1; i++)

                Console.WriteLine(i + ": "+ (i*i));
            Console.ReadKey(true);
        }
    }
}
