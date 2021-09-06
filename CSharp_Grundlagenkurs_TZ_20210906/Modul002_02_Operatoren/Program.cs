using System;

namespace Modul002_02_Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //einfache Rechenoperatoren
            int zahl1 = 4;
            int zahl2 = 2;

            //Rechengrundarten
            int addition = zahl1 + zahl2;
            int substraktion = zahl1 - zahl2;
            int multiplikation = zahl1 * zahl2;
            int subtraktion = zahl1 / zahl2;


            //Was ist Modulo? % 
            int zahl3 = 14;
            int zahl4 = 3;
            int modulo = zahl3 % zahl4; // 14 % 3  => 2 (REST) 

            Random rd = new Random(); //bekommen irgendeine Zufallszahl....von 0 bis int.MaxValue
            int result = rd.Next(); // 44.567 / 100 = 445 + REST: 567

            // Eine Zufallszahl zwischen 1 und 99;
            int randomNumberUnd100 = result % 100;


            //Inkrementieren + Dekrementieren

            int meineZahl = 5;

            meineZahl++; //Erhöhe Zahl um den Wert 1


            //Vergleichen Inkrementierung als Pre oder Suffix
            
            meineZahl = 5;
            Console.WriteLine(meineZahl++); //Variable wird zuerst ausgegeben, danach erst um 1 erhöht
            
            meineZahl = 5;
            Console.WriteLine(++meineZahl); //Variable wird zuerst erhöht und danach wird ausgegeben. 



            meineZahl = 5; //Startwert für dieses Beispiel

            //meineZahl erhöht sich mit dem Wert '5' 
            meineZahl += 5;

            meineZahl -= 8;

            meineZahl *= meineZahl;

            meineZahl /= 2;





            //Gleitzkommazahlen runden
            double zahl6 = Math.Round(4.89); //kaufm. Runden => 5

            decimal a = 1.994444m;

            Math.Round(a, 2); //returns 1.99

            double zahl7 = Math.Ceiling(4.14); // immer wird augegerunden -> 5
            double zah8 = Math.Floor(4.76); //wird immer abgerundet => 4 

            decimal kommaRundung = decimal.Round(3.156m, MidpointRounding.ToEven);


            for (decimal value = 100m; value <= 102m; value += .1m)
                Console.WriteLine("{0} --> {1}", value, decimal.Round(value));




            // The example displays the following output:
            //     100 --> 100
            //     100.1 --> 100
            //     100.2 --> 100
            //     100.3 --> 100
            //     100.4 --> 100
            //     100.5 --> 100
            //     100.6 --> 101
            //     100.7 --> 101
            //     100.8 --> 101
            //     100.9 --> 101
            //     101.0 --> 101
            //     101.1 --> 101
            //     101.2 --> 101
            //     101.3 --> 101
            //     101.4 --> 101
            //     101.5 --> 102
            //     101.6 --> 102
            //     101.7 --> 102
            //     101.8 --> 102
            //     101.9 --> 102
            //     102.0 --> 102
        }
    }
}
