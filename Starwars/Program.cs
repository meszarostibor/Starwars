using System;
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
            Mester Jedi0 = new Mester("Luke");
            Console.WriteLine(Jedi0);
            Console.WriteLine();
            Mester Jedi1 = new Mester("Ben Kenobi",true,20,KopenyFajta.KAPUCNIS_BARNA);
            Console.WriteLine(Jedi1);
            Console.WriteLine();

            Tanitvany Padavan0 = new Tanitvany("Anakin");
            Console.WriteLine(Padavan0);
            Console.ReadKey();
        }
    }
}
