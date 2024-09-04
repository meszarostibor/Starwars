using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    internal class Tanitvany : Erohasznalo
    {

        float tincsHossza;
        int kepzettsegiSzint;

        public double TincsHossza
        {
            get { return tincsHossza; }
        }

        public int KepzettsegiSzint
        {
            get { return kepzettsegiSzint; }
            set
            {
                if (value <= 100)
                {
                    kepzettsegiSzint = value;
                }
                else
                {
                    kepzettsegiSzint = 100;
                }
            }

        }


        #region Konstruktorok
        public Tanitvany(string nev) : base(nev + " Ifjú")
        {
            tincsHossza = rnd.Next(5, 160)/10;
            kepzettsegiSzint = rnd.Next(0, 101);
        }

        public Tanitvany(string nev,float tincsHossza,int kepzettsegiSzint) : base(nev + " Ifjú")
        {
            if (tincsHossza >= 0.5 && tincsHossza <= 15)
            {
                this.tincsHossza = tincsHossza;
            }
            else 
            {
                throw new Exception("Az érték tartományon kívűl");
            }   
            this.tincsHossza = tincsHossza;
            KepzettsegiSzint = kepzettsegiSzint;
        }


        #endregion
        #region Destructor
        ~Tanitvany() { }
        #endregion

        public override string ToString()
        {
            return $"Név: {Nev}\nMidikloriánok száma: {MidiklorianokSzama}\nKard színe: {Kard}\nOldal: {OldalNeve}\nTincs hossza: {TincsHossza}\nKépzettségi szint: {KepzettsegiSzint}";
        }

    }
}
