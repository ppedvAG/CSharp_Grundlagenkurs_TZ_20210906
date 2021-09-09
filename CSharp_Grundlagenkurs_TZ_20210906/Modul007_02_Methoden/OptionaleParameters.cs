using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_Methoden
{
    public class OptionaleParameters
    {
        //optionale Parameter am Ende der Parameterliste
        //Wenn Variable 'trenner' nicht befüllt wird, initialisiert sich die Variable 'trenner' mit dem angegeben Defaultwert '/'
        public string StringsVerbinden(string[] strings, char trenner = '/')
        {
            string resultString = strings[0];

            for (int i = 1; i < strings.Length; i++)
            {
                resultString += (trenner + strings[i]);
            }

            return resultString;
        }
    }

    
}
