﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum); 
        }
    }
}
