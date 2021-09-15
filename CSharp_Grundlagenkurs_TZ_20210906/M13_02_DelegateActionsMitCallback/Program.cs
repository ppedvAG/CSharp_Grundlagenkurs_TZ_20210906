using System;

namespace M13_02_DelegateActionsMitCallback
{
    class Program
    {
        public delegate void FinishWorkedDelegate(string message);
        public delegate void OnProcessing(int value);


        public delegate void BinFertigMitDatenbankAuslesenDelegate(string message);
        public delegate void RESTFulFinishDelegate(string message);

        static void Main(string[] args)
        {
            FinishWorkedDelegate finishWorkedDelegate = new FinishWorkedDelegate(FinishResultMethod);
            OnProcessing processingDelegate = new OnProcessing(OutputCurrentPercentStatus);


            MethodeWithCallback(11, 22, finishWorkedDelegate, processingDelegate);



            BinFertigMitDatenbankAuslesenDelegate binFertigMitDatenbankAuslesenDelegate = new BinFertigMitDatenbankAuslesenDelegate(FinishDatabaseMethod);






        }

        public static void MethodeWithCallback(int param1, int param2, FinishWorkedDelegate messageDelegate, OnProcessing onProcessing)
        {
            //Wo werden Callbacks verwendet

            // In dieser Methode -> Mache ich folgendes 
            // 1.) [Callen einen ANDEREN PC an] Wir verbinden uns auf eine DB und lesen Daten aus
            // 2.) Aus den ausgelesen Daten kann ich Parameter herauslesen und diese kann im Schritt 3
            // 3.) [Callen einen ANDEREN PC an] Wir gehen auf einen RESTful-Service und wollen ein Erbebnis auslesen 
            // 4.) Wir konventieren das Erbnis in ein anderes um



            //Wir haben einiges Berechnet 
            for (int i = 0; i <= 100; i++)
                onProcessing(i);


            //Pseudo Berechnung



            //Delegate wird in einer Callback Methode immer am Ende ausgeführt (dann wenn das Ergebnis vorliegt) 
            messageDelegate("The Number is " + (param1 + param2).ToString());
        }


        public void MethodeMitCallback2 (string connectionString, string urlRESTfulService, BinFertigMitDatenbankAuslesenDelegate binFertigMitDatenbankAuslesenDelegate, RESTFulFinishDelegate finishRESTfulDelegate)
        {
            // In dieser Methode -> Mache ich folgendes 
            // 1.) [Callen einen ANDEREN PC an] Wir verbinden uns auf eine DB und lesen Daten aus
            binFertigMitDatenbankAuslesenDelegate("Habe ein Ergebnis aus der DB erhalten. Ist sauber durchgelaufen");
            // 2.) Aus den ausgelesen Daten kann ich Parameter herauslesen und diese kann im Schritt 3
            // 3.) [Callen einen ANDEREN PC an] Wir gehen auf einen RESTful-Service und wollen ein Erbebnis auslesen 
            finishRESTfulDelegate("Habe Daten aus dem Service herausgelesen");
            // 4.) Wir konventieren das Erbnis in ein anderes um
        }
        //Diese Methode wird am Ende einer langen Bearbeitung aufgerufen


        public static void FinishDatabaseMethod(string message)
        {
            Console.WriteLine(message);


            //label5.Text = message;
        }

        public static void FinishResultMethod (string message)
        {
            Console.WriteLine(message);
        }

        public static void OutputCurrentPercentStatus(int percentValue)
        {
            Console.WriteLine($"{percentValue} %");
        }
    }
}
