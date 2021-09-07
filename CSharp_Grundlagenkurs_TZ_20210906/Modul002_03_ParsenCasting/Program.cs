using System;

namespace Modul002_03_ParsenCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 25;

            #region Implizit / Explizit int -> string 
            //Implizite Konventierung in einen String durch den "+" Operator

            string satz1 = "Wert der Zahl: " + zahl1; //Im Hintergrund (ToString())

            //explizierte Konvertierung durch die Methode ".ToString()"
            string satz2 = "Wert der Zahl: " + zahl1.ToString();
            #endregion


            Console.Write("Autopreis : ");
            
            string autoPreisEingabe = Console.ReadLine(); //Zahl sollte im Text sein.

            int preis1 = Convert.ToInt32(autoPreisEingabe); //Hier entsteht eine Exception, wenn im String ein Zeichen vorkommt, dass nicht nummerisch ist

            int preis2 = int.Parse(autoPreisEingabe);
            
            int preis3;

            if (int.TryParse(autoPreisEingabe, out preis3)) //Wenn autoPreisEingabe eine Zahl darstellt, wird Preis3 in der Methode TryParse befüllt
            {
                //Wenn ich hier bin, dann ist der String ein Zahlenwert gewesen
                //UND ich kann mit preis3 hier weiterarbeiten 

                Console.WriteLine(preis3);
            }
            else
            {
                //Fehlmelderung oder Exception 
            }

            string zahlenwort2 = "123,456";
            float zahl4 = float.Parse(zahlenwort2);

            //Wir verwenden lieber float.Parse :-) 
            float zahl5 = Single.Parse(zahlenwort2);

            //Hier wird das Komma abgeschnitten
            int zahl6 = (int)zahl4;

            decimal decimalValue = 123.123456789123456789m;

            double doubleValue = (double)decimalValue;











        }
    }
}
