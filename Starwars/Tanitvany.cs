using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Tanitvany : Erohasznalo
    {
        float tincsHossza;
        int kepzettsegiSzint;

        public float TincsHossza
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
                else//kjlkj
                {
                    kepzettsegiSzint = 100;
                }
            }
        }


        #region Konstruktorok
        public Tanitvany(string nev) : base(nev + " Ifjú")
        {
            float hossz = 0;
            while (hossz < 0.5 || hossz > 15)
            {
                hossz = (float)rnd.NextDouble() * 15;
            }
            this.tincsHossza = hossz;
            this.kepzettsegiSzint = rnd.Next(0, 101);
        }

        public Tanitvany(string nev, float tincsHossza, int kepzettsegiSzint) : base("Ifjú " + nev)
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
