using System;

namespace Modul005_01_StatischeMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahlA = 4;
            int zahlB = 2;

            float zahlC = 3.33f;


            float result = Addiere(5, 4.5f);

            float result1 = Addiere(zahlA, zahlC, zahlC);
        }

        static int Addiere(int zahl1, int zahl2)
        {
            int result = zahl1 + zahl2;
            return result;
        }

        static float Addiere(int zahl1, float zahl2)
        {
            float result = zahl1 + zahl2;
            return result;
        }

        static float Addiere(int zahl1, float zahl2, float zahl3)
        {
            float result = zahl1 + zahl2 + zahl3;
            return result;
        }
    }
}
