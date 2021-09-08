using System;

namespace Modul004_Wdh_EnumVsArrays
{
    public enum Anrede { Herr, Frau, Divers }
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[10];
            stringArray[0] = "Apfel";





            //......








            Console.WriteLine(stringArray[0]); 

            Anrede anrede = Anrede.Herr;

            //if (anrede == Anrede.Frau || anrede == Anrede.Herr)


        }
    }
}
