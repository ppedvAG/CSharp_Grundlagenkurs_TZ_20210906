
using System;
using System.Collections.Generic;

namespace Modul011_01_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<JahresmarktStand> meinJahresmarkt = new List<JahresmarktStand>();

            meinJahresmarkt.Add(new MirrorCabinett());
            meinJahresmarkt.Add(new AutoScooter());
            meinJahresmarkt.Add(new Achterbahn());


            //wir wollen alle Stände besuchen

            foreach(JahresmarktStand aktuellerStand in meinJahresmarkt)
            {
                if (aktuellerStand is IFSK16)
                {
                    //Kurzschreibweise -> Casten und Verwenden in einem
                    ((IFSK16)aktuellerStand).IsChecked("Kleiner Fritz");


                    //Casten
                    IFSK16 aktuellerStandMitFSKPRüfung = (IFSK16)aktuellerStand;
                    
                    
                    aktuellerStandMitFSKPRüfung.IsChecked("Kleiner Fritz");
                    



                }

                //Inzanz von Achterhan gibt mir alle MEthode von Basisklasse und AchterbahnKlasse (müssen public sein) 
                if (aktuellerStand is Achterbahn achterbahn)
                {
                    achterbahn.TicketKaufen();
                    achterbahn.IsChecked(23);
                    achterbahn.StarteAchterbahn();
                }
            }
        }
    }


    #region Jahresmark
    public class JahresmarktStand
    {
        public int Miete { get; set; }
        public int Quatratmeter { get; set; }

        public DateTime OffenVon { get; set; }
        public DateTime OffenBis { get; set; }

        public int AnzahlDerMitarbeiter { get; set; }

        public void TicketKaufen()
        {

        }
    }

    public interface IFSK16
    {
        bool IsChecked(object Person);
    }

    public interface IToileteAvailable
    {
        int AnzahlDerToiletten { get; set; }
        bool IsToileteOpen { get; set; }
    }

    public class Achterbahn : JahresmarktStand, IFSK16, IToileteAvailable
    {
        public int LaengeDerAchterbahn { get; set; }
        public int HoeheDerAchterbahn { get; set; }
        public int AnzahlDerToiletten { get; set; }
        public bool IsToileteOpen { get; set; }

        public bool IsChecked(object Person)
        {
            //Prüfung auf alter....Person muss über 16 Jahre alt sein

            return true;
        }

        public void StarteAchterbahn()
        {

        }

        public void StoppeAchterbahn()
        {

        }
    }


    public class MirrorCabinett : JahresmarktStand, ICloneable
    { 
        public int WegeZumZiel { get; set; }

        public object Clone()
        {
            return new MirrorCabinett() { AnzahlDerMitarbeiter = 2, Miete = 34, WegeZumZiel = 2 };
        }
    }

    public class AutoScooter : JahresmarktStand, IToileteAvailable
    {
        public int AnzahlDerAutos { get; set; }
        public int AnzahlDerToiletten { get; set; }
        public bool IsToileteOpen { get; set; }
    }

    public class HorrorCabinett : JahresmarktStand, IFSK16
    {
        public bool IsChecked(object Person)
        {
            //Prüfung auf alter....Person muss über 16 Jahre alt sein

            return true;
        }
    }
    #endregion


}
