using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_01_Object
{

    public class Beine
    {
        public double Länge { get; set; }

        public Beine(int länge)
        {
            this.Länge = länge;
        }
    }


    public class Person : IDisposable
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public DateTime Geburtstag { get; set; }

        public int  HaarFarbe { get; set; }

        public Beine LinkesBein { get; set; }
        public Beine RechtesBein { get; set; }

        //public Person() //Default Konstruktor -> Wenn eine Klasse keinen Konstruktor besetzt, wird beim kompilieren ein Default Konstruktor hinzugeneriert
        //{

        //}

        //Shortcut: ctor + tab + tab
        //Default-Konstruktor hat keine Parameter und kümmert sich um die Default Befüllung
        public Person()
        {
            Vorname = string.Empty;
            Nachname = string.Empty;
            Geburtstag = default(DateTime); //Jesus - Geburt wird hier angegeben
            HaarFarbe = default(int);
        }

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }


        public Person(string vorname, string nachname, DateTime geburtstag)
            : this(vorname, nachname) //Ich rufe aus meiner Klasse einen anderen Konstruktor auf 
        {
            //Problem an dieser lösung ist, dass:
            //- Vorname = vorname;
            //- Nachname = nachname;
            // Doppelt jetzt vorkommen

            //Vorname = vorname;
            //Nachname = nachname;

            Geburtstag = geburtstag;
        }

        public Person(string vorname, string nachname, DateTime geburtstag, int haarfarbe)
            : this(vorname, nachname, geburtstag)
        {
            HaarFarbe = haarfarbe;
        }

        public Person(string vorname, string nachname, DateTime geburtstag, int haarfarbe, Beine linkesBein, Beine rechtsBein)
            : this(vorname, nachname, geburtstag, haarfarbe)
        {
            LinkesBein = linkesBein;
            RechtesBein = null; //hier geht was schief -> habe das mit null dachgestellt
        }


        public void CallGC ()
        {
           
        }

        public void Dispose()
        {
            // here you can free the resources you allocated explicitly
            System.GC.SuppressFinalize(this);
        }


        #region Dekonstruktor  //Destruktor wird durch die GC aufgerufen
        ~Person ()
        {
            Console.WriteLine("Destruktoraufruf: das Objekt wird nun zerstoert"); 
        }
        #endregion

    }
}
