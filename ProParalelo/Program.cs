using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProParalelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 for
            Stopwatch tiempo = new Stopwatch();
            var listaEntero = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            tiempo.Start();
            Parallel.For(0, 100, (i) => Console.WriteLine(i));
            Console.WriteLine("Hola itero");
            tiempo.Stop();
            var ticks = tiempo.ElapsedTicks;
            Console.WriteLine($"se demoro:{ticks}");
            //2 foreach
            Stopwatch tiempo1 = new Stopwatch();
            var lista = Enumerable.Range(0, 10);
            tiempo1.Start();
            Parallel.ForEach(lista, (num) =>
            {
                Console.WriteLine("hola llego al foreach");
                Console.WriteLine(num);
                tiempo1.Stop();
            });
            var ticks1 = tiempo.ElapsedTicks;
            Console.WriteLine($"se demoro:{ticks1}");
        }
    }
}
