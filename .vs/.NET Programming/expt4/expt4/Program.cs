using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expt4
{
    internal class Program
    {
        public void display(string message) { Console.WriteLine(message); }
        public void display(String message,int i)
        {
            Console.WriteLine("{0},{1}",message,i);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.display("Hello");
            Program p1 = new Program();
            p1.display("VVIT", 1);
        }
    }
}
