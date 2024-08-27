using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Erohasznalo
    {
        #region Mezők
        string nev = "";
        int midiklorianokSzama = 0;
        KardSzine kardSzine = 0;
        bool oldal = true;
        byte oldalValtozasSzama = 0;
        Random rnd = new Random();
        #endregion

        public string Nev
        {
            get { return nev; }
        }

        public int MidiklorianokSzama
        {
            get { return midiklorianokSzama; }
        }

        public KardSzine Kard
        {
            get { return kardSzine; }
        }

        public bool Oldal
        {
            get { return oldal; }
        }


        public string OldalNeve
        {
            get
            {
                if (oldal == true)
                {
                    return "Jó oldal";
                }
                else
                {
                    return "Sötét oldal";
                }
            }
        }

        public void OldaltValt()
        {
            if (oldalValtozasSzama < 2)
            {
                oldal = !oldal;
                oldalValtozasSzama += 1;
            }
        }

        #region Konstruktor
        public Erohasznalo(string nev)
        {
            if (nev.Length > 3)
            {
                this.nev = nev;
            }
            else
            {
                throw new Exception($"A név túl rövid! ({nev})");
            }

            midiklorianokSzama = rnd.Next(3000, 20001);

            if (rnd.Next(0, 100) < 80)
            {
                oldal = true;
            }
            else { 
                oldal = false;
            }

            if (oldal == false)
            {
                kardSzine = 0;
            }
            else {
                kardSzine = (KardSzine)rnd.Next(1, 5);
            }
        }
        #endregion

        #region Megjelenítés
        public override string ToString()
        {
            return $"Név: {Nev}\nMidikloriánok száma: {MidiklorianokSzama}\nKard színe: {Kard}\nOldal: {OldalNeve}";
        }
        #endregion
    }







}
