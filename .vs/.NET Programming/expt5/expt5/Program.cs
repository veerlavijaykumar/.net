using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expt5
{
   class Base
    {
        public virtual void display()
        {
            Console.WriteLine("parent");
        }
    }
    class Derived : Base
    {
        public override void display()

        {
            Console.WriteLine("child");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.display();
            Base b1=new Derived();
            b1.display();
            Derived d=new Derived();
            d.display();
        }
    }
}
