using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Rend
    {
        List<Mester> mesterek = new List<Mester>();
        List<Tanitvany> tanitvanyok = new List<Tanitvany>();

        public int TanacstagokSzama()
        {
            int eredmeny = 0;
            foreach (Mester i in Mesterek)
            {
                if (i.Tanacstag == true) { eredmeny++; }
            }
            return eredmeny;
        }

        public List<Mester> Mesterek {
            get { return mesterek; }
        }

        public List<Tanitvany> Tanitvanyok { 
            get { return tanitvanyok; }
        } 
        
        public List<Tanitvany> tanitvanyokXSzinuKarddal(KardSzine kardFajta)
        {
            List<Tanitvany> lista = new List<Tanitvany>();            
            foreach (Tanitvany i in Tanitvanyok)
            {
                if (i.Kard == kardFajta && i.Oldal == true) { lista.Add(i); }
            }            
            return lista;
        }

        #region Konstruktor
        public Rend(int mesterekSzama, int tanitvanyokSzama)
        {
            for (int i = 1; i <= mesterekSzama + tanitvanyokSzama; i++)
            {
                if (i <= mesterekSzama)
                {
                    mesterek.Add(new Mester($"Erőhasználó {i}"));
                }
                else
                {
                    tanitvanyok.Add(new Tanitvany($"Erőhasználó {i}"));
                }               
            }
        }
        #endregion

        #region Destructor
        ~Rend() { }
        #endregion
    }
}
