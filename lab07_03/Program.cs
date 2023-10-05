using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, inicio_año, final_año;
            Console.Write("Ingrese el año en el que terminará el calculo de años bisiestos: ");
            final_año = int.Parse(Console.ReadLine());
            inicio_año = 1900;

            Console.WriteLine("Estos años son los bisiestos desde 1900 hasta " + final_año + ": ");
            for (i= inicio_año; i <= final_año; i++)
            {
                if ((i %4==0 && i %100!=0) || (i % 400 == 0))
                {
                    Console.WriteLine(+i);
                }
            }
            Console.ReadKey();
        }
    }
}
