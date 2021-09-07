using System;
using System.Collections.Generic;

namespace Modul003_03_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Zählschleife
            Console.WriteLine("inkrementale for-Schleife");

            int value = 10;
            Console.WriteLine(value++);
            value = 10;
            Console.WriteLine(++value);


            //0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            for (int i = 0; i < 10; i++)
                Console.Write($"{i}");

            for (int i = 0; i < 10; i++)
            {
                //Body Bereich -> wird bei 2 CodeZeilen und mehr verwenden 
                Console.Write($"{i}");
            }
            Console.Write("\n"); //Zeilenumbruch

            for (int i = 10; i > 0; i-- )
            {
                Console.Write($"{i}, ");
            }//10, 9, 8, 7, 6, 5, 4, 3, 2, 1,
            Console.Write("\n"); //Zeilenumbruch
            #endregion


            int[] zahlen = new int[] { 1, 5, 7, 9, 4, 2, 6, 45, 581 };
            
            /*** Index **** | **** Wert ****/
            /*     0        |       1      */
            /*     1        |       5      */
            /*     2        |       7      */
            /*     3        |       9      */
            /*     4        |       4      */
            /*     5        |       2      */

            Console.WriteLine("Schleife mit Array");

            for (int i = 0; i < zahlen.Length; i++)
            {
                //ueber den Index i muss auf das Element zugegriffen werden
                Console.Write($"{zahlen[i]}, ");
            }
            Console.Write("\n");

            List<int> numListe = new List<int>();
            numListe.Add(12);
            numListe.Add(44);
            numListe.Add(55);
            numListe.Add(123);
            numListe.Add(77);

            // von einer Liste in ein Array Konventieren
            int[] convertedArray = numListe.ToArray();

            //Mithilfe eines Arrays kann man mehrere Einträge in einer Liste durchführen.
            numListe.AddRange(zahlen);

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($"{zahlen[i]}, ");
            }
            Console.Write("\n");


            //int retValue = zahlen[20]; //Dies wird eine IndexOutOfRangeException

            #region foreach
            //Geht jedes Element eines Array oder Liste durch
            foreach (int currentIntegerValue in zahlen)
            {
                //Wenn ich hier ankomme, dann hat mein Array -> zahlen mindestens einen Eintrag 
                Console.Write(currentIntegerValue);

            } //Wenn zahlen leer ist oder eine List<int> leer ist, gibt es keinen Durchlauf
            Console.Write("\n");
            #endregion


            //Nachbau einer For-Schleife


            //while_statement
            //: 'while' '(' boolean_expression ')' embedded_statement
            //;

            #region while - Schleife
            int n = 0;
            while (n < 5) //Condition 
            {
                //Solange n kleiner als 5 ist, komme ich in den While-Body
                Console.Write(n);
                n++;
            }

            string bedingung = "true";
            int count = 0;

            //Eine Endlosschleife mit einem Explizeten Ende
            while (bedingung == "true")
            {
                count++;
                Console.WriteLine(count);
                
                if (count == 10000)
                {
                    bedingung = "false";
                    Console.WriteLine("Set Bedingung auf false");
                }
            }
            Console.WriteLine("Sind jetzt ausserhalb der while-Schleife");

            #endregion

            #region Do while Schleife (Fussgesteuerte) 
            bedingung = "true";
            count = 0;

            //Hier wird erst ausgeführt und danach geprüft, ob wir noch ein weiteren Durchlauf angehen. 
            do
            {
                count++;
                Console.WriteLine(count);

                if (count == 10000)
                {
                    bedingung = "false";
                    Console.WriteLine("Set Bedingung auf false");
                }
            } while (bedingung == "wahr");

            #endregion


            #region continue

            Console.WriteLine("7er Reihenfolge bis 1000");
            for (int i = 0; i < 1000; i++)
            {
                if (i % 7 != 0)
                    continue; //gehe einfach in den nächsten Schleifendurchlauf

                //Ich werde ausgeführt, wenn continue nicht aufgerufen wurde -> also eine 7er Zahl 
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\n");

            #endregion


            for (int i = 0; i <10;i++)
            {
                if (i > 5)
                    break; // Springe aus der Schleif
                
                Console.Write($"{i}, ");

                for (int x = 0; x < 30; x++)
                {
                    if (x > 5)
                    {
                        break; //Springe aus meiner Inneren For-Schleife heraus 
                    }
                }
                //also hier hin
            } //von break springe ich hier hin 
        }
    }
}
