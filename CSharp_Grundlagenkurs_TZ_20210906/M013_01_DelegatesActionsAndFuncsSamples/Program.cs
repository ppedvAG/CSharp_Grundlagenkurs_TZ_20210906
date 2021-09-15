using System;

namespace M013_01_DelegatesActionsAndFuncsSamples
{
    //Delegate zeigt auf eine Methode
    //Die Methode die wir dann verwenden, hat ein int als Rückgabetype, ein int in der Parameterliste
    delegate int NumbChange(int n);

    delegate int CalculationDelegate(int zahl1, int zahl2);


    delegate void MultipleParameterDelegate(int z1, float kommazahl, decimal geldbetrag);
    class Program
    {
        static void Main(string[] args)
        {
            #region Einfaches Delegate mit AddNumber und SubNumber Methode
            NumbChange numbChange = new NumbChange(AddNumber); //Zeiger auf Methodenadresse

            int result = numbChange(11); //Hier rufen wir die Methode AddNumber auf

            numbChange += SubNumber; //SubNumber wird dem delegate zusätzlich noch angehängt

            result = numbChange(11);

            numbChange -= AddNumber;
            result = numbChange(11);
            #endregion

            #region Ein weiteres Delegate
            CalculationDelegate calculationDelegate = new CalculationDelegate(Addition);
            result = calculationDelegate(11, 22);
            #endregion


            //Action kann nur mit Methoden zusammenarbeiten die ein VOID zurückgeben
            #region Action - Delegate
            Action a1 = new Action(A);
            a1 += B;
            a1();


            //Ich kann mit allen Methoden zusammen arbeiten die so ausschauen:
            // void Methode (int param1);
            Action<int> actionWithOneIntegerParameter = new Action<int>(C);
            actionWithOneIntegerParameter(11);


            Action<int, float, decimal> myActionDelegate = new Action<int, float, decimal>(C);
            myActionDelegate(23, 23.6f, 19.99m);

            MultipleParameterDelegate multipleParameterDelegate = new MultipleParameterDelegate(C);
            multipleParameterDelegate(23, 23.6f, 19.99m);
            #endregion


            #region Func
            // Func arbeitet mit Methoden zusammen, die einen Rückgabewert zurückgeben 
            //Bei Func ist die letzte Typangabe der Rückgabewert
            Func<int, int, int> func = new Func<int, int, int>(Addition);

            result = func(11, 22);

            //Gegenüberstellung zu delegate
            //CalculationDelegate calculationDelegate = new CalculationDelegate(Addition);
            //result = calculationDelegate(11, 22);
            #endregion
        }

        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }

        public static void C(int zahl)
        {
            Console.WriteLine("C" + zahl);
        }

        public static void C(int zahl, float zahl2, decimal zahl3)
        {
            Console.WriteLine("C" + zahl);
        }


        public static int AddNumber(int number)
        {
            return number += 5; // Number wird um den Wert 5 erhöht
        }

        public static int SubNumber(int number)
        {
            return number -= 7; // Number wird um den Wert 5 erhöht
        }

        public static int Addition(int z1, int z2)
        {
            return z1 + z2;
        }
    }

    
}
