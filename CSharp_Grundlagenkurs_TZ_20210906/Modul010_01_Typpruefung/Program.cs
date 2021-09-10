using System;
using System.Collections.Generic;

namespace Modul010_01_Typpruefung
{
    class Program
    {
        static void Main(string[] args)
        {
            MeineBasisKlasse basisKlasse = new();
            MeineAbgeleiteteKlasse abgeleiteteKlasse = new();

            Type basisKlassenTyp = basisKlasse.GetType();

            Type abgeleiteteKlassenTyp = typeof(MeineAbgeleiteteKlasse);

            #region GetType und typof - Prüfung
            if (basisKlasse.GetType() == typeof(MeineBasisKlasse))
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineBasisKlasse) \t ->Instanz basisKlasse ist eine Klasse vom Typ-> MeineBasisKlasse");
            }
            else
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineBasisKlasse) -> Typ wurde nicht gefunden");
            }


            if (basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse))
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> Basisklasse kennt die abgeleitete Klasse (das darf nicht gehen)");
            }
            else
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> Basisklasse kennt nicht die abgeleitete Klasse");
            }


            //Vererbgung kapiert typeof nicht
            //Modul010_01_Typpruefung.MeineAbgeleiteteKlasse == Modul010_01_Typpruefung.MeineBasisKlasse
            if (abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse))
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse) -> abgeleitete Klasse kennt den Typ MeineBasisKlasse");
            }
            else
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse) -> abgeleitete Klasse kennt nicht den Typ MeineBasisKlasse");
            }

            if (abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse))
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> abgeleitete Klasse kennt den Typ MeineAbgeleiteteKlasse");
            }
            else
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> abgeleitete Klasse kennt nicht den Typ MeineAbgeleiteteKlasse");
            }
            #endregion



            List<Shape> geometrieCollection = new List<Shape>();

            geometrieCollection.Add(new Rectangle() { x = 5, y = 6 });
            geometrieCollection.Add(new Circle(4));
            geometrieCollection.Add(new Sphere(7));
            
            
            foreach(Shape currentShape in geometrieCollection)
            {
                //hier wird der richtige Typ verwendet
                currentShape.Area(); //<-- Allgemeine MEthode, die in allen Geometrie Formen vorzufinden ist. 


                // If mit dem Operator 'is' ist eine intelligentere Erweiterung zu TypeOf / GetType
                if (currentShape is Rectangle rectangle)
                {
                    rectangle.WeitereWichtigeMethode();
                }
                else if (currentShape is Circle circle)
                {

                }
                else if(currentShape is Sphere)
                {

                }
            }

            if (abgeleiteteKlasse is MeineAbgeleiteteKlasse)
            {
                Console.WriteLine("Kennt MeineAbgeleiteteKlasse(sich selbst)");
            }

            if (abgeleiteteKlasse is MeineBasisKlasse)
            {
                Console.WriteLine("Kennt Basisklasse");
            }





            
        }


        static void MusterabgleichMitSwitch(Shape shape)
        {
            switch (shape)
            {
                //Type Checking with Casting + when-Condition
                case Rectangle r when r.x == r.y:
                    Console.WriteLine("Ist ein Quatrat");
                    break;
                case Rectangle:
                    Console.WriteLine("Ist ein Rechteck");
                    break;
                case Circle:
                    Console.WriteLine("Ist ein Kreis");
                    //100 Codezeilen -> besser in Methode auslagern
                    break;
                case Sphere:
                    Console.WriteLine("Ist eine Kugel");
                    break;
            }
        }
    }




    #region Sample1  typeof(T)
    class MeineBasisKlasse
    {

    }

    class MeineAbgeleiteteKlasse : MeineBasisKlasse
    {

    }
    #endregion


    #region Geometrie
    public class Shape
    {
        public const double PI = Math.PI;
        public double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    public class Rectangle : Shape
    {
        //Hie müssen wir nichts überschreiben (x*y) reicht komplett aus für eine Rechtseckberechnung

        public void WeitereWichtigeMethode()
        {

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
    }

    class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
    #endregion
}
