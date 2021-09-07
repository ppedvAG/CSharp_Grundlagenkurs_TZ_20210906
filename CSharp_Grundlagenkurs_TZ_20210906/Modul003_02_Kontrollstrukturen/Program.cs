using System;

namespace Modul003_02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib den Akkustand ein: ");
            int akkuStand = int.Parse(Console.ReadLine());

            string akkuStatus = string.Empty;

            if (akkuStand > 20 && akkuStand <= 100)
            {
                akkuStatus = "Akku ist in Ordnung";
            }
            else if (akkuStand > 0 && akkuStand <= 20)
            {
                akkuStatus = "Akku sollte geladen werden.";
            }
            else if (akkuStand == 0)
            {
                akkuStatus = "Akku ist leer";
            }
            else
            {
                akkuStatus = "Akku ist defekt";
            }


            int myNumber = 33;
            bool result = myNumber == 33 ? true : false; // Condition: myNumber == 33 ? 
                                                         // [Condition] ? [Wahrblock] : [ElseBlock]

            DateTime dt = new DateTime(2003, 5, 10);
            string returnStr = string.Empty;

            switch(dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    returnStr = "Montag";
                    break;
                case DayOfWeek.Tuesday:
                    returnStr = "Dienstag";
                    break;
                case DayOfWeek.Wednesday:
                    returnStr = "Mittwoch";
                    Console.WriteLine("Kann man mehrfache verwenden");
                    break; // break springt bis Ende von Switch
                case DayOfWeek.Thursday:
                    returnStr = "Donnerstag";
                    break;
                case DayOfWeek.Friday:
                    returnStr = "Freitag";
                    break;

                default:
                    returnStr = "Wochenende";
                    break;
            } //von break komme ich hier an und will gleich wissen was Obst ist :-) 

            Console.Write("Gebe Obst ein: ");
            string obst = Console.ReadLine();
            string farbe = string.Empty;

            switch (obst)
            {
                case "Kirsche":
                    farbe = "rot";
                    break;
                case "Banane": //wenn obst == "Banane" die kommende Anweisung ausfuehren
                case "Zitrone":
                    farbe = "gelb";
                    break;
                case "Orange":
                    farbe = "orange";
                    break;
                default:
                    farbe = "unbekannt";
                    break;


            }

            Console.WriteLine($"Obst: {obst} - Farbe: {farbe}");
            Console.ReadLine();
        }
    }
}
