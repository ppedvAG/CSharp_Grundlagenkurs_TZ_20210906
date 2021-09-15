using System;

namespace M13_02_ActionMitCallback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Action<string> actionMessageDelegate = new Action<string>(FinishResultMethode);
            MethodWithCallback(11, 22, actionMessageDelegate);
        }


        public static void MethodWithCallback(int param1, int param2, Action<string> messageDelegate)
        {
            //Es wird hier viel berechnet... 
            
            //In der letzten Zeile (dann wenn alles fertig berechnet ist)
            messageDelegate("The number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }


        public static void FinishResultMethode(string message)
        {
            Console.WriteLine(message);
        }
    }
}
