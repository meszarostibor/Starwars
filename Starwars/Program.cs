using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rend ujRend = new Rend(100, 20);
            Console.WriteLine($"A Jedi tanácsnak {ujRend.TanacstagokSzama()} tagja van.");
            Console.WriteLine();
            Mester legtobbTanitvany=null;// ujRend.Mesterek[0];
            int maxTanitvany = 0;
            foreach(Mester i in ujRend.Mesterek)
            {
                if (i.Kopeny == KopenyFajta.KAPUCNIS_SZURKE) {
                    if (i.KorabbiTanitvanyok > maxTanitvany) { 
                        maxTanitvany = i.KorabbiTanitvanyok;
                        legtobbTanitvany = i;
                    }                    
                }
            }
            Console.WriteLine($"Az a szürke kapucnis köpenyt viselő mester akinek a  legtöbb tanítvánnya volt: \n{legtobbTanitvany}");                               
            Console.ReadKey();
        }
    }
}
