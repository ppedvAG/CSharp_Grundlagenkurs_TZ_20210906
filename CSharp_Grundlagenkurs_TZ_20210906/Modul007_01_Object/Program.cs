using System;

namespace Modul007_01_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 1
            Person person = new Person("Maxi", "Muster");




            Person person1 = new Person("Max", "Muster", DateTime.Now);


            Person person2 = new Person("Max", "Muster", DateTime.Now, 5);

            Person person3 = new Person(); //private Person()

            Beine linkesBein = new Beine(100);
            Beine rechtesBein = new Beine(99);

            Person personMitLinkenUndRechtenBein = new Person("Heike", "Musterfrau", 
                DateTime.Now, 3, linkesBein, rechtesBein);

            //Gegenüberstellung -> Person wird ohne Konstruktor befüllt
            //Person ohneKonstruktor = new Person();
            //ohneKonstruktor.Geburtstag = DateTime.Now;
            //ohneKonstruktor.Vorname = "Kevin";
            //ohneKonstruktor.Nachname = "Winter";
            //ohneKonstruktor.RechtesBein = new Beine(100);
            //ohneKonstruktor.LinkesBein = new Beine(100);
            //ohneKonstruktor.HaarFarbe = 123;
            
            
            GC.SuppressFinalize(person); ///Person wird Explizit abgeräumt.

        }//Was passiert mit den Objekten, wenn das Programm hier ist. 


        
    }
}
