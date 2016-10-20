using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleIt__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int x = int.Parse(Console.ReadLine());
            x = DoubleIt(x);
            Console.WriteLine("I've taken the liberty of doubling your number: " + x);
        }
        static int DoubleIt(int x)  
        {
            int result;
            result = x * 2;
            return result;
        }
    }
}


