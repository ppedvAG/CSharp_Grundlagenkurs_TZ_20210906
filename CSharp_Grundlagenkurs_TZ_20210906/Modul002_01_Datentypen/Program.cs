using System;

namespace Modul002_01_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# - Datentypen

            //char -> Textzeichen -> basiert auf  Tabelle
            char textzeichen = 'A'; //basiert auf Ascii Tabelle

            //cw + Tab + Tab
            Console.WriteLine(textzeichen); //textzeichen wird verwendet + Warning wird nicht mehr angezeigt

            string text = "ABCDEFGH";

            string einenLeerenString = string.Empty; //besser als einLeerenString = "";

            bool boolean = true; //true oder false



            string stringWithEscapeSigns = "Hallo liebe Teilnehmer \nWillkommen in C# Kurs \t\t und hier benutze ich einen Tabulator";

            Console.WriteLine(stringWithEscapeSigns);

            string pfad = "C:\\Windows\\Temp"; //Das wäre ein Datenpfad mit doppelten \
            string schickerDatenPfad = @$"C:\Windows\Temp   \n \t  {pfad}";
            Console.WriteLine(schickerDatenPfad);



            #region Nummerische Datentypen (Ganzzahlen) 
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/built-in-types
            byte minByte = 0;
            byte maxByte = 255;

            byte giveMeMaxByteValue = byte.MaxValue;
            byte giveMeLowestByteValue = byte.MinValue;

            //16 Bit

            short minShort = short.MinValue;
            short maxShort = short.MaxValue;

            ushort unsignedShortMin = ushort.MinValue;
            ushort unsignedShortMax = ushort.MaxValue;

            //32 Bit
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;

            //64 Bit
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
        #endregion



            #region Gleitkomma Datentypen
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

            double doubleValue = 69.64;

            float floatValue = 12.343f; //bei festen Zahlen Zuordnungen muss man f angeben.

            //decimal wird für Geldbeträge verwendet -> Microsoft garantiert eine Fehlerfreie verwenden 
            decimal geldbeatraege = 29.99m; //decimal Geld
            #endregion


            #region Wertetypen und Referenztypen
            //Wertetypen: (übergeben immer eine Kopie) 
            // -> int, byte, short, long (alle nummerische Werte)
            // -> bool 
            // -> Gleitkomma Datentypen float, double, decimal; 
            // -> char? 
            // -> struct 


            //Referenztypen
            // - string ist offiziell ein Referenztyp -> Verhält sich aber wie ein Wertetype
            // - class  -> alles was objekte sind
            // - interface
            // - record
            #endregion


            #region CSharp Datentypen Vs .NET Datentypen
            int test;
            bool boolean1 = true;


            //Nativen Datentypen in .NET 
            //Int32 test1; 
            //String string = "Hallo";
            //Decimal decimalDatentyp


            #endregion


            #region Nullbare Datentypen

            int meineZahl = -1;

            int? meineNullbareZahl = null;

            if (meineNullbareZahl.HasValue) //hat meine Variable eine nummerische Zuordnung schon erfahren 
                meineNullbareZahl = 123;

            Console.WriteLine(meineNullbareZahl);
            Console.WriteLine(meineNullbareZahl.Value);


            string nullbarerString = null;

            if (string.IsNullOrEmpty(nullbarerString))
            {

            }
            #endregion





        }
    }
}
