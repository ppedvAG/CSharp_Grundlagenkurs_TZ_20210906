using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_02_Polymorphiesmus_abstract
{
    //Regeln zu Abstrakten Klassen


    // - Wenn eine Klasse eine abstrakte Methode oder Property beinhaltet, wird die Klasse als abstrakt markiert. 
    // - Von abstrakten Klassen können wir keine Instanzen bauen 
    // - Eine Abstrakte Klasse dient lediglich als Schablone

    public abstract class BaseClass
    {
        protected int _z = 99;
        protected int _x = 100;
        protected int _y = 150;

        public abstract void AbstractMethode();

        public abstract int X { get; }
        public abstract int Y { get; }

        public abstract int Z { get; set; }

    }


    public class DerivedClass : BaseClass
    {
        public override int X
        {
            get
            {
                return _x;
            }
        }

        public override int Y => _y;

        public override int Z 
        { 
            get => _z; 
            set => _z = value; 
        }

        public override void AbstractMethode()
        {
            Console.WriteLine("Abstrakte Methoden müssen ausimplementiert werden");
        }
    }
}
