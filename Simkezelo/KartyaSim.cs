using System;
using System.Collections.Generic;
using System.Text;

namespace Simkezelo
{
    public class KartyaSim

    {
        public bool a = false;
        public int sorszam;
        public int[] pin;
        public int egyenleg;
        public Kapcsolatok[] kapcsolatok = new Kapcsolatok[20];
        public int Sorszam()
        {
            int sorszam1;
            Console.WriteLine("A kártya sorszáma: ");
            sorszam1 = int.Parse(Console.ReadLine());
            sorszam = sorszam1;
            return sorszam1;
        }

        public int Egyenleg ()
        {
            int egyenleg1;
            Console.WriteLine("Mennyivel töltsük fel az egyenleged?");
            egyenleg1 = int.Parse(Console.ReadLine());
            egyenleg += egyenleg1;
            return egyenleg1;
        }

        public int[] PIN()
        {
            int[] pinKod = new int[4];
            Random rnd = new Random();
            for (int i = 0; i<pinKod.Length; i++)
            {
                pinKod[i]=rnd.Next(0, 9);
                
            }

            pin = pinKod;
            return pinKod;
    }
        

    }
}
