using System;
using System.Collections.Generic;

namespace Modul009_01_Polymorphiesmus_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Obst obst = new Obst();
            obst.Gewicht = 1;
            Console.WriteLine(obst.WasBinIch());

            
            Apfel apfel = new Apfel();
            Console.WriteLine(apfel.WasBinIch());






            double r = 3.0, h = 5.0;
            Rectangle rectangle = new Rectangle(3, 5);
            Circle c = new Circle(r);
            Sphere s = new Sphere(r);
            Cylinder l = new Cylinder(r, h);

            //Wenn eine überschriebene Methode in der abgeleiteten Klasse gefunden wird, dann wird diese aufgerufen
            //Wenn nicht, wird die BasisMethode aufgerufen

            Console.WriteLine("Area of Rectangle   = {0:F2}", rectangle.Area());
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());



            ////Shape ist der Basistyp und c1 bietet nur das an, was in Shape definiert wurde
            //Shape c1 = new Circle(r);

            //c1.Area(); // -> hier call er Circle.Area 
            //c1.BasisklassenMethode();

            //List<Shape> geoFormenListe = new List<Shape>();
            //geoFormenListe.Add(new Circle(5));
            //geoFormenListe.Add(new Sphere(4));
            //geoFormenListe.Add(new Cylinder(3, 4));


            //foreach (Shape currentShape in geoFormenListe)
            //{
            //    currentShape.Area();
            //    currentShape.BasisklassenMethode();
            //}

            //foreach (Shape currentShape in geoFormenListe)
            //{

            //    //1.) currentShape is Circle -> wird geprüft ob currentShape ein Circle ist

            //    if (currentShape is Circle circle)
            //    {
            //        circle.CircleMethode();
            //        circle.RotateCircle();
            //    }
            //}
               
        }
    }


    #region Beispiel Obst

    public class Obst
    {
        //Virtual Property
        public virtual int Gewicht { get; set; }


        //virtual Methode
        public virtual string WasBinIch()
        {
            return "Ich bin Obst";
        }
    }

    public class Apfel : Obst
    {
        public override string WasBinIch()
        {
            string wasbinIch = base.WasBinIch(); //hier callen wir OBst.WasBinIch auf

            wasbinIch += " und kann zu Apfemus verarbeitet werden";

            return wasbinIch;
        }
    }
    #endregion

    #region Geometrie

    public class Shape
    {
        public const double PI = Math.PI;

        protected double x, y;

        public Shape()
        {

        }

        public Shape(double x, double y)
        {
            //this.x = Member in Klasse 
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }

        public void BasisklassenMethode()
        { 
        }
    }

    public class Rectangle : Shape
    {
        //Hie müssen wir nichts überschreiben (x*y) reicht komplett aus für eine Rechtseckberechnung
        public Rectangle(int x, int y)
            : base(x, y)
        {

        }
    }

    public class Quatrat : Shape
    {
        public Quatrat(int länge)
            :base(länge, länge)
        {

        }
        public override double Area()
        {
            //if (x != y)
            //    throw new ArgumentException("x ist nicht gleich y");

            return base.Area();
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {

        }


        public override double Area()
        {
            return PI * x * x;
        }

        public void RotateCircle()
        {
            // Kreis rotiert
        }

        public void CircleMethode()
        {
        }
    }


    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }

        public void RotateSphere()
        {
            // Kreis rotiert
        }


        public void SphereMethode()
        {
        }
    }


    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }


        public void Output()
        {
            // Ausgabe von Variablen
        }
    }
    #endregion
}
