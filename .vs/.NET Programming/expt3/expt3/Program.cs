using System;

namespace expt3
{
    internal class Program
    {
        String name;
        int age;
        String address;

        Program()
        {
            name = "Vijay";
            age = 30;
            address = "tenali";
            Console.WriteLine("{0}, {1}, {2}", name, age, address);
        }

        Program(String name)
        {
            this.name = name;
            Console.WriteLine(name);
        }

        Program(String name, String address)
        {
            this.name = name;
            this.address = address;
            Console.WriteLine("{0}, {1}", name, address);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();                   // Calls default constructor
            Program p2 = new Program("Charlie");          // Calls constructor with 1 parameter
            Program p3 = new Program("Naresh", "Vijayawada");  // Calls constructor with 2 parameters
        }
    }
}
