using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_ClassFieldsProperties
{
    public class BobbyCar
    {

        //intern wird eine Member-Variable angelegt
        //private string _marke/marke -> automatisch hinzugefügt


        private string _model;

        //Auto-Property
        public string Marke { get; set; } //Zur das Programm kompiliert, wird im eine Member-Variale automatisch erstellt 

        //Auto-Property soll zu einer normalen Property mit MemberVariable umkonventiert werden
        //1.) Ausgangspunkt -> Autoproperty -> public string Model { get; set; }

        //2.) Get und SEt werden ausimplementiert, wenn z.b eine Validierung benötigt wird
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
    }
}
