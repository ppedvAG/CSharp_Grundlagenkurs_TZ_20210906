using System;
using System.Collections.Generic;

namespace Modul009_03_Polymorphiesmus_ListenSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wie kann ich alle Dokumente auf einmal ausdrucken? 
            //Meine Liste von DocumentBase kann alle Objekte aufnehmen, die von DocumentBase abgeleitet sind
            
            
            List<DocumentBase> docListe = new List<DocumentBase>();
            //DocBase kann man nicht hinzufügen

            docListe.Add(new PDFDocument());
            docListe.Add(new WordDocument());
            docListe.Add(new ExcelDocument());


            //Ich will alle Docs in meiner Liste ausdrucken lassen

            foreach (DocumentBase currentObject in docListe)
            {
                currentObject.Print();
            }


            //Geburtstagsliste 

            List<Person> birthdayListe = new List<Person>();
            birthdayListe.Add(new Eva());
            birthdayListe.Add(new Gustav());
            birthdayListe.Add(new Pascal());
            birthdayListe.Add(new Maria());

            foreach (Person currentPerson in birthdayListe)
                currentPerson.Isst();


        }
    }

    public abstract class DocumentBase
    {
        public string Name { get; set; }
        public string Title { get; set; }


        public abstract void Print();
    }

    public class PDFDocument : DocumentBase
    {
        public override void Print()
        {
            Console.WriteLine("Drucke ein PDF-Dokument aus");
        }
    }



    public class WordDocument : DocumentBase
    {
        public override void Print()
        {
            Console.WriteLine("Drucke ein Word-Dokument aus");
        }
    }

    public class ExcelDocument : DocumentBase
    {
        public override void Print()
        {
            Console.WriteLine("Drucke ein Excel-Dokument aus");
        }
    }


    public abstract class Person
    {
        public abstract void Isst();
        
    }

    public class Eva : Person
    {
        public override void Isst()
        {
            Console.WriteLine("Eva isst");
        }
    }

    public class Gustav : Person
    {
        public override void Isst()
        {
            Console.WriteLine("Gustav isst");
        }
    }

    public class Pascal : Person
    {
        public override void Isst()
        {
            Console.WriteLine("Pascal isst");
        }
    }


    public class Maria : Person
    {
        public override void Isst()
        {
            Console.WriteLine("Maria isst");
        }
    }

}
