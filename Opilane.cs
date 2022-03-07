using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Opilane : Inimene
    {
        string ruhm;
        double hinne;
        bool toetus;
        public Opilane() { }
        public Opilane(string Eesnimi, string Perenimi, string Ruhm):base(Eesnimi,Perenimi)
        {
            ruhm = Ruhm;
        }
        public string Ruhm
        {
            set { ruhm = value; }
            get { return ruhm; }
        }     

        public int vanus
        {
            set { vanus = value; }
            get { return vanus; }
        }

        public double Hinne
        {
            set 
            {  if (value>1 && value<5) hinne = value; }
            get { return hinne; }
        }
        public bool Toetus
        {
            get
            {
                if (hinne>3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;

            }

        }
        public void Info()
        {
            string t = "";
            Console.WriteLine("Opilane: {0} {1}", Eesnimi, Perenimi);
            Console.WriteLine("Opilane vanus: {0}",Vanus);
            if (toetus == true)
            {
                t = "Saan toetust kätte";
            }
            else if (Toetus==false && hinne>0)
            {
                t = "Ei saa toetust";
            }
            else
            {
                t = "Andmed hinnetest puuduvad";
            }
            Console.WriteLine("Minu keskmine hinne on {0}. {1}", hinne, t);
        }
    }
}
