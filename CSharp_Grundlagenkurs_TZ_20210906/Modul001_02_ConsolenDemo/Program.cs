using System;

namespace Modul001_02_ConsolenDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Agrumente Ausgeben
            //wird ein Argument übergeben
            if (args.Length > 0)
            {
                Console.WriteLine(args[0], args[1]);
            }
            #endregion

            #region Write
            Console.Write("Text ohne abschließenden Zeilenumbruch");
            Console.Write("Und dieser Text, steht auch in der selben Zeile");
            #endregion

            #region ReadLine()
            Console.WriteLine("##### ReadLine() #######");
            Console.WriteLine("Wie teuer darf ein Hotelzimmer sein: ");
            string zimmerPreis = Console.ReadLine();

            Console.WriteLine($"Sie haben folgenden Betrag eingegeben {zimmerPreis}");
            #endregion

            #region AusgabeVarianten mit WriteLine
            Console.WriteLine("Sie haben folgenden Betrag eingegeben " + zimmerPreis); //unschöne variante 
            Console.WriteLine("Sie haben folgenden Betrag eingegeben {0} kann hier auch weiter einen Text verfassen ->  {1}", zimmerPreis, "Servus"); //von printf abgeschaut

            #endregion

            #region ReadKey
            Console.Clear(); //CLS 

            Console.WriteLine("##### Readkey #####");

            Console.WriteLine("(1) Menüpunkt A");
            Console.WriteLine("(2) Menüpunkt B");
            Console.WriteLine("(3) Menüpunkt C");
            Console.WriteLine("(x) Exit");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            

            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine(Environment.NewLine + "Anzeige Menüpunkt A");
            }
            if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\nAnzeige Menüpunkt B");
            }
            if (consoleKeyInfo.Key == ConsoleKey.D3 || consoleKeyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine("Anzeige Menüpunkt C");
            }

            if (consoleKeyInfo.Key == ConsoleKey.X)
            {
                return; //Programm wird beendet
            }
            #endregion
        }
    }
}
