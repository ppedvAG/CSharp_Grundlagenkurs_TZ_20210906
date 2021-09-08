using System;
using System.Linq;

namespace LABS_Lotto_Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] benutzerZahlen = new int[3];
            int[] zufallsZahlen = new int[3];
            int treffer = 0;

            //Schleife zum Würfeln der Zahlen
            for (int  i = 0; i < zufallsZahlen.Length; i++)
            {
                //Deklaration eines Zwischenspeichers

                int temp;

                do
                {
                    //Würfeln der Zahl in den Zwischenspeicher;
                    temp = generator.Next(1, 11);

                } while (zufallsZahlen.Contains(temp));

                zufallsZahlen[i] = temp;
            }

            //Schleife zum Erfragen der Benutzerzahlen
            for (int i = 0; i < benutzerZahlen.Length; i++)
            {
                Console.Write("Gib eine Zahl zwischen 1 und 10 ein :");
                benutzerZahlen[i] = int.Parse(Console.ReadLine());
            }

            //Schleife zum Ausgeben der Gewinnzahlen UND zum Zählen der Treffer

            foreach(int zahl in zufallsZahlen)
            {
                Console.Write($" {zahl}");

                //Hochzählen der Treffervariablen bei Vorkommen in beiden Arrays
                if (benutzerZahlen.Contains(zahl))
                    treffer++;
            }

            //Ausgabe der Treffer
            Console.WriteLine($"\n\nDu hast {treffer} richtige Zahl(en) erraten");

            Console.ReadKey();




            ////array -> Contain

            //int zufallszahl = generator.Next(1, 10);

            //if (!zufallsZahlen.Contains(zufallszahl))
            //{

            //    zufallsZahlen[0] = zufallszahl;
            //}
        }
    }
}
