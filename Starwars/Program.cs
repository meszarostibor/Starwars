﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Erohasznalo Jedi = new Erohasznalo("Luke");

           
            Console.WriteLine(Jedi);
            Console.ReadKey();
        }
    }
}
