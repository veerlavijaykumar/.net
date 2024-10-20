using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expt7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number  : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number  : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of tw numbers is :  "+(a+b));
        }
    }
}
