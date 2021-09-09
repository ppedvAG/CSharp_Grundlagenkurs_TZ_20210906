using System;

namespace Modul007_02_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionaleParameters optionaleParameters = new OptionaleParameters();
            OptionaleParameters optionaleParameters1 = new(); //verkürzte Schreibweise. seit C# 8.0

            string[] myStrings = { "eins", "zwei", "drei" };

            string result1 = optionaleParameters.StringsVerbinden(myStrings);
            Console.WriteLine(result1);
            string result2 = optionaleParameters.StringsVerbinden(myStrings, '*');
            Console.WriteLine(result2);


            ParamsParameter paramsParameter = new ParamsParameter();
            paramsParameter.Addiere();
            paramsParameter.Addiere(1, 2, 3, 4);
            paramsParameter.Addiere(1, 2, 3, 4, 5, 6, 7, 8, 9);


            int[] meinZahlenArray = { 1, 2, 3 };
            paramsParameter.AddiereOld(meinZahlenArray);

            OutInRefParameter outInRefParameter = new OutInRefParameter();


            int min=10;
            int max=20;
            float avg=30;


            float result = outInRefParameter.Berechne(11, 22, out min, out max, out avg);

            Addiere addiere = new Addiere();
            addiere.Zahl1 = 11;
            addiere.Zahl2 = 22;

            outInRefParameter.Berechne(addiere); // hier wird die Referenz übergen

            //hier hat min den Wert von 11
            //hier hat max den Wert von 22
            int convertedValue;

            //Out wird z.b in TryParse verwendet 
            if(int.TryParse("12345", out convertedValue))
            {
                Console.WriteLine($"Juhu iam a number {convertedValue}");
            }
        }
    }
}
