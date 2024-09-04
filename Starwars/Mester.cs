using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{

    public class Mester : Erohasznalo
    {

        private bool tanacstag = false;
        KopenyFajta kopeny;
        private int korabbiTanitvanyok;
        public bool Tanacstag
        {
            get
            {
                return tanacstag;
            }
            set
            {
                if (this.Oldal == false)
                {
                    tanacstag = false;
                }
                else if (tanacstag == false)
                {
                    tanacstag = value;
                }
            }
        }
        public KopenyFajta Kopeny
        {
            get { return kopeny; }
        }

        void kopenycsere(KopenyFajta kopeny)
        {
            this.kopeny = kopeny;
        }

        public int KorabbiTanitvanyok
        {
            get { return korabbiTanitvanyok; }
            set
            {
                if (value < 21)
                {
                    korabbiTanitvanyok = value;
                }
                else
                {
                    korabbiTanitvanyok = 20;
                }
            }
        }
        #region Konstruktorok
        public Mester(string nev) : base(nev + " Mester")
        {

            if (rnd.Next(0, 2) == 0)
            {
                Tanacstag = false;
            }
            else
            {
                Tanacstag = true;
            }
            KorabbiTanitvanyok = rnd.Next(0, 21);
            kopenycsere((KopenyFajta)rnd.Next(0, 3));
        }

        public Mester(string nev, bool tanacstag, int korabbiTanitvanyok, KopenyFajta kopeny) : base(nev + " Mester")
        {
            this.tanacstag = tanacstag;
            this.korabbiTanitvanyok = korabbiTanitvanyok;
            this.kopeny = kopeny;
        }
        #endregion

        #region Destructor
        ~Mester() { }
        #endregion

        public override string ToString()
        {
            return $"Név: {Nev}\nMidikloriánok száma: {MidiklorianokSzama}\nKard színe: {Kard}\nOldal: {OldalNeve}\nTanácstag: {tanacstag}\nKorábbi tanítványok: {KorabbiTanitvanyok}\nKöpeny: {Kopeny}";
        }

    }
}

