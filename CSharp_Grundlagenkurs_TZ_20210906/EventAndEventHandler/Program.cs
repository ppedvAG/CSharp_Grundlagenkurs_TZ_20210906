using System;

namespace EventAndEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessComponent processBusinessComponent = new ProcessBusinessComponent();

            processBusinessComponent.CurrentPercentStatus += ProcessBusinessComponent_CurrentPercentStatus;
            processBusinessComponent.ProcessCompleted += ProcessBusinessComponent_ProcessCompleted;


            processBusinessComponent.StartProcess();




            ProcessBusinessComponent2 processBusinessComponent2 = new ProcessBusinessComponent2();

            processBusinessComponent2.ProcessCompleted += ProcessBusinessComponent2_ProcessCompleted;
            processBusinessComponent2.ProcessCompletedNew += ProcessBusinessComponent2_ProcessCompletedNew;
            processBusinessComponent2.StartProcess();

        }

        private static void ProcessBusinessComponent2_ProcessCompletedNew(object sender, EventArgs e)
        {
            FinsihAtTimeEventArgs result = (FinsihAtTimeEventArgs)e;
            Console.WriteLine($"Sind um { result} fertig geworden");
        }


        /// <summary>
        /// Hier komme ich hin, wenn ProcessBusinessComponent.StartProcess fertig ist 
        /// </summary>
        /// <param name="sender">Von wo aus, wurde das Event gefeuert</param>
        /// <param name="e">Parameter die Übergeben werden..... aktuell EventArgs.Empty</param>
        private static void ProcessBusinessComponent2_ProcessCompleted(object sender, EventArgs e)
        {
            
        }

        private static void ProcessBusinessComponent_ProcessCompleted()
        {
            Console.WriteLine("Ich bin fertig!");
        }

        private static void ProcessBusinessComponent_CurrentPercentStatus(int n)
        {
            Console.WriteLine(n);
        }

        //Event möchten wir an dieser Stelle ausgeben (ausserhalb von ProcessBusinessComponents) 

        // Events -> Eventmethoden 



    }
}
