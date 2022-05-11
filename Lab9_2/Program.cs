using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear:");
            Rooty line_r = new Linear(2, 3);
            Console.WriteLine(line_r.Result());
            Printy line_p = new Linear(2, 3);
            line_p.Print();

            Console.WriteLine("");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("");

            Console.WriteLine("Square:");
            Rooty square_r = new Square(9, -12, -5);
            Console.WriteLine(Math.Round(square_r.Result_A(), 2));
            Console.WriteLine(Math.Round(square_r.Result_B(), 2));
            Printy square_p = new Square(9, -12, -5);
            square_p.Print();

            Console.ReadKey();
        }
    }
}
