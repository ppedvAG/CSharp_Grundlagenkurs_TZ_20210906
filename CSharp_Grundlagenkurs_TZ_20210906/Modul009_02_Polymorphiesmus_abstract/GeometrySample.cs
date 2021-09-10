using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_02_Polymorphiesmus_abstract
{
    public abstract class Shape //Von Shape können wir keine Instanz erzeugen, weil die abstract ist. Abstrakte Klassen sind mehr als eine Vorlage zu sehen. 
    {
        public abstract int GetArea(); //Wenn eine Methode mit 'abstract' definiert wird, MUSS die Klasse auch mit abstract definiert werden!

        public virtual double Radiusbeerechnung ()
        {
            return Math.PI;
        }
    }

    public class Square : Shape
    {
        int side;

        public Square(int n)
        {
            side = n;
        }

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea()
        {
            return side * side;
        }
    }


    public class Circle : Shape
    {
        public override int GetArea() // Diese Methode wird garantiert, dass wir eine Flächenberechnung haben -> abstract sei Dank!
        {
            return 1 + 2 + 3; //soezielle Formel like 1+2+3
        }


        public override double Radiusbeerechnung() //Optionale Überschreibungsmöglichkeit WENN Radiusberechnung bei einem Kreis sinnvoll ist.
        {
            return 1 + 2 + 3 + 4 + 5;
        }
    }
    // Output: Area of the square = 144
}
