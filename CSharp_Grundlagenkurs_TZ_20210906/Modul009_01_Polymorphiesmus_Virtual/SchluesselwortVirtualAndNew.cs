using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_Polymorphiesmus_Virtual
{
    public class Fahrzeug
    {
        public virtual string WasBinIch()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Auto : Fahrzeug
    {
        public new string WasBinIch() //<-- ich bin nur noch eine normale public - Methode
        {
            return "Ich bin ein Auto";
        }
    }

    public class ElectroCar : Auto
    {
        public override string WasBinIch() //<-- ich finde in meiner Parent-Klasse nur eine normale Methode...... override schhlägt daher fehl. 
        {
            return "Ich bin ein ElectroCar";
        }

    }
}
