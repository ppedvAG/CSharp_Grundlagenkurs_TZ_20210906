using System;

namespace Modul004_02_Enums
{

    
    enum Wochentag { Mo=1, Di, Mi, Do, Fr, Sa, So} //Wenn kein Index explizit angegeben wird, dann beginnt ales von 0 



    [Flags]
    enum Fruechte
    {
        Keines = 0,
        Orange = 1,
        Kirsche = 2,
        Banane = 4,
        Apfel = 8,
        Pflaume = 16,
        Birne = 32
    }


    [Flags]
    public enum DinnerItems
    {
        None = 0,
        Entree = 1,
        Appetizer = 2,
        Side = 4,
        Dessert = 8,
        Beverage = 16,
        BarBeverage = 32
    }

    class Program
    {
        static void Main(string[] args)
        {

            //schlechte Alternative 
            string[] TagInDerWoche = new string[] { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            //TagInDerWoche[0] -> Montag 

            Wochentag wochentag = Wochentag.Mi;

            if (wochentag == Wochentag.Mi)
            {

            }


            //Enum ueber eine switch-Anweisung ueberpruefen lassen
            string hinweis = string.Empty;
            switch (wochentag)
            {
                case Wochentag.Mo:
                case Wochentag.Di:
                case Wochentag.Mi:
                case Wochentag.Do:
                case Wochentag.Fr:
                    hinweis = "Leider ist noch kein Wochenende..";
                    break;
                case Wochentag.Sa:
                case Wochentag.So:
                    hinweis = "Wuhu! Endlich Wochenende!";
                    break;
                default:
                    break;
            }
            Console.WriteLine("Hello World!");


            Fruechte fruchtkorb = Fruechte.Orange | Fruechte.Banane | Fruechte.Birne; 

            int fruchtKorbAsInteger = Fruechte.Orange | Fruechte.Banane | Fruechte.Birne;

        }
    }
}
