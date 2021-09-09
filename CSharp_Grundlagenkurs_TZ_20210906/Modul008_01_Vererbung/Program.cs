using System;

namespace Modul008_01_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Lebewesen lebewesen = new Lebewesen(33);
            //lebewesen.Alter;
            //lebewesen.Schlafen();


            Mensch mensch = new Mensch(33, "Hamburg");
            mensch.Init(); // 
            //mensch.Alter
            //mensch.Schlafen();

            //mensch.Wohnort
            //mensch.Lesen();


            Mitarbeiter mitarbeiter = new Mitarbeiter(33, "Düsseldorf", "Sparkasse");
            //mitarbeiter.Arbeitgeber

            Freiberufler freelancer = new Freiberufler(33, "Dresden", "EDV Laden GmbH");
            //freelancer.Auftraggeber
        }
    }


    //BasisKlasse
    public class Lebewesen
    {
        public int Alter { get; set; }

        public Lebewesen(int alter)
        {
            Alter = alter;
        }

        public void Schlafen()
        {
            //zzzZZZzzzZZZZz
        }

        public void Essen()
        {

        }
    }

    public class Mensch : Lebewesen
    {
        public string Wohnort { get; set; }


        public Mensch(int alter, string wohnort)
            : base (alter) 
        {
            Wohnort = wohnort;

            
        }


        public  void Init()
        {

        }


        public void Lesen()
        {
            //Ein Mensch kann Lesen
        }




        


    }

    public class Mitarbeiter : Mensch
    {
        public string Arbeitgeber { get; set; }

        public Mitarbeiter(int alter, string wohnort, string arbeitgeber)
            :base(33, "Heidelberg")
        {
            Arbeitgeber = arbeitgeber;
        }

        public void Vertragsverhandlung()
        {

        }

        public DateTime ArbeitszeitVon { get; set; }
        public DateTime ArbeitzeitBis { get; set; }

        public bool IsStaatlichKrankenversichert { get; set; }

        public int Urlaubstage { get; set; }
    }

    public class Freiberufler : Mensch
    {
        

        public string Auftraggeber { get; set; }
        public Freiberufler(int alter, string wohnort, string auftraggeber)
            :base(alter,wohnort)
        {
            Auftraggeber = auftraggeber;
        }
        public void Abbrechnung()
        {

        }

        public void Aquise()
        {

        }
    }
}
