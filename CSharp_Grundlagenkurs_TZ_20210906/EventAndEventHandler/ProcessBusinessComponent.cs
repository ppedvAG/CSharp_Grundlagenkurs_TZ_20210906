using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndEventHandler
{
    public delegate void Percent(int n);
    public delegate void Notify(); 

    public class ProcessBusinessComponent
    {
        //Diese zwei public Delegates-> werden später von aussen initialisiert und eine Methode wird dann hinterlegt
        public event Percent CurrentPercentStatus; // ProcessBusinessComponent_CurrentPercentStatus
        public event Notify ProcessCompleted;  // ProcessBusinessComponent_ProcessCompleted


        public void StartProcess()
        {
            for (int i = 0; i < 100; i++)
            {
                //Mach irgendwas



                //Müssen aktuellen Prozentstatus nach aussen signalisieren
                OnProcessPercentStatus(i);
            }

            //Hier müssen wir nach aussern erzählen, das wir fertig sind

            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted();
            ProcessCompleted?.Invoke();
        }

        protected virtual void OnProcessPercentStatus(int percent)
        {
            CurrentPercentStatus?.Invoke(percent);
        }


        //wäre hier die Methode für Percent-Ausgabe oder Finish - Ausgabe
    }
}
