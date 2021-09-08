using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_03_PartialClass
{


    //Partial Class ist eine Klasse, die über mehrere Dateien hinweg definiert wird 

    //Meist wird eine Partial-Klasse verwenden, wenn wir einen Code-Generator verwenden 
    // Eine Datei wird komplett vom Code-Genrator befüllt 
    // Die weitere Datei wird verwenden um den Programmierer Implementierungen anzubieten. 
    public partial class PersonPartial
    {

        //DIESER QUELLCODE WURDE MIT EINEM CODE-GENERATOR ERSTELLT 
        public int Alter { get; set; }

        public string Name { get; set; }

        public void StehAuf()
        {
            //.....
        }

        //ich möchte was dazu programmieren. 
    }
}
