using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndEventHandler
{
    public class ProcessBusinessComponent2
    {
        public event EventHandler ProcessCompleted;
        public event EventHandler ProcessCompletedNew;


        public void StartProcess()
        {
            //Mach etwas 
            OnProcessCompleted(EventArgs.Empty); //Wir übegeben keinen Parameter


            FinsihAtTimeEventArgs finsihAtTimeEventArgs = new FinsihAtTimeEventArgs();
            finsihAtTimeEventArgs.CurrentTime = DateTime.Now;

            //Neues Beispiel
            OnProcessCompletedNew(finsihAtTimeEventArgs);
        }

        protected virtual void OnProcessCompleted (EventArgs e)
        {
            //sender = ProcessBusinessComponent2
            ProcessCompleted?.Invoke(this, e);
        }
        protected virtual void OnProcessCompletedNew(EventArgs e)
        {
            //sender = ProcessBusinessComponent2
            ProcessCompletedNew?.Invoke(this, e);
        }

    }


    public class FinsihAtTimeEventArgs : EventArgs
    {
        public DateTime CurrentTime { get; set; }
    }
}
