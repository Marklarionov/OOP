using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {



            Inimene naine1 = new Inimene("Marina", 21, Emakeel.saksa, 60);
            naine1.Tervitame();

            Inimene[] inimesed = new Inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Nimi: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitame();
            }

            Inimene mees = new Inimene();
            mees.Eesnimi = "Mark";
            Console.WriteLine("Ma olen {0}. Kui vana ma olen?", mees.Eesnimi);
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();
            Inimene naine2 = new Inimene("Alenka", 18, Emakeel.vene, 55);
            naine2.Tervitame();

            Console.ReadLine();
        }
    }
}
