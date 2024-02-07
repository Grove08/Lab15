using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_2
{
    internal class Program
    {
        static void Main(string[] args)
 {
        ArithProgression ap = new ArithProgression();
        ap.setStart(1);
        Console.WriteLine("Арифметическая прогрессия:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(ap.getNext());
        }

        GeomProgression gp = new GeomProgression();
        gp.setStart(1);
        Console.WriteLine("\nГеометрическая прогрессия:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(gp.getNext());
        }
            Console.ReadKey();
    }
    }
}
