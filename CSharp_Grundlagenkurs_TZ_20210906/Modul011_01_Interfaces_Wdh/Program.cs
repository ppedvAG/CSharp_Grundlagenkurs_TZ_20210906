using System;
using System.Collections.Generic;

namespace Modul011_01_Interfaces_Wdh
{
    class Program
    {
        static void Main(string[] args)
        {
            Plain myJet1 = new Plain("Airbus", "A599", 1200, 12000, 15);
            Car myCar1 = new Car("Ferarri", "Enzo", 400, 4, false, false, null);
            Car myCar2 = new Car("VW", "Polo", 140, 4, true, false, null);
           
            Segelschiff segelschiff = new Segelschiff("PapierSchiff", "1.0", 15, 1, 2, 20, false);


            Car myCar4 = null;
            Plain myPlain = null;
            Segelschiff mySegler = null;
            VehicleGarage myGarage = new VehicleGarage(50);
            Random random = new Random();
            try
            {
                for (int i = 0; i < 30; i++)
                {
                    int randomValue = random.Next(1, 4);

                    switch (randomValue)
                    {
                        case 1:
                            int mitOderOhneKofferraum = random.Next(1, 3);
                            if (mitOderOhneKofferraum==1)
                                myCar1 = new Car("Ranger", "Jeep", 160, 4, false, true, new Kofferraum(5));
                            else
                                myCar1 = new Car("Ranger", "Jeep", 160, 4, false, true, null);
                            myGarage.Einparken(myCar1);
                            break;

                        case 2:
                            myPlain = new Plain("Airbus", "A599", 1200, 12000, 15);
                            myGarage.Einparken(myPlain);
                            break;
                        case 3:
                            mySegler = new Segelschiff("PapierSchiff", "1.0", 15, 1, 2, 20, false);
                            myGarage.Einparken(mySegler);
                            break;

                        default:
                            Console.WriteLine("Objekt konnte nicht erstellt");
                            break;
                    }

                    //if (i == 25)
                    //    myCar1 =  new Car(string.Empty, "Jeep", 160, 4, false, true);

                }
            }
            
            catch (Vehicle.VehicleException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


            myGarage.InventarAusgabe();
            myGarage.AutosMitKofferraum();
            Console.WriteLine(Vehicle.ZeigeAnzahlFahrzeuge());
        }
    }

    public class BeladungsItem
    {
        public string Bezeichnung;
        public float Gewicht;

    }
    public interface IBeladbar
    {
        public int Ladeflaeche { get; set; }
        public int AktuelleBeladung { get; set; }

        List<BeladungsItem> InventarListe { get; set; }
    }

    public class Kofferraum : IBeladbar
    {
        public int Ladeflaeche { get; set; }
        public int AktuelleBeladung { get; set; } = 0; //Defaultwerte
        public List<BeladungsItem> InventarListe { get; set; } = new List<BeladungsItem>(); //Inventarliste Default


       

        //Leerer Kofferraum
        public Kofferraum(int ladeflaeche)
        {
            Ladeflaeche = ladeflaeche;
        }

        //gefüllter Kofferraum 
        public Kofferraum (int ladeFlaeche, int aktuelleBeladung, List<BeladungsItem> InventarListe)
            :this(ladeFlaeche)
        {
            
            AktuelleBeladung = aktuelleBeladung;
            this.InventarListe = InventarListe;
        }


    }



    public class Vehicle
    {
        private int _aktuelleGeschwindigkeit;
        private int _maxGeschwindigkeit;
        private string _marke;

        // Zentraler Speicherort und besten geeeignet um ALLE erstellte Objekte zu zählen
        public static int AnzahlErstellterFahrzeuge { get; private set; } = 0; //Metainfo -> Wieviele Vehicles(Car, Plan, Ship) wurden erstellt
        public static int MaxAnzahlErstellerFahrzeuge { get; private set; } = 50; //Es dürfen Maximal nur 50 Fahrzeuge erstellt werden
        public static string ZeigeAnzahlFahrzeuge()
        {
            return "Es wurden " + AnzahlErstellterFahrzeuge + " produziert";
        }


        public Vehicle()
        {
            MotoLäuft = false;


            if (AnzahlErstellterFahrzeuge < MaxAnzahlErstellerFahrzeuge)
                AnzahlErstellterFahrzeuge++;
            else throw new VehicleException($"Die Anzahl Maximaler Vehicles wurde erreicht {AnzahlErstellterFahrzeuge} / {MaxAnzahlErstellerFahrzeuge}");



        }

        public Vehicle(string marke, string modell, int maxGeschwindigkeit)
            : this()
        {
            MaxGeschwindigkeit = maxGeschwindigkeit;
            Modell = modell;
            Marke = marke;
        }

        public string Marke 
        {
            get => _marke; // { return _marke: } 
            
            set
            {
                if (value == string.Empty)
                    throw new Exception("Marke muss einen Inhalt vorweisen");


                _marke = value;
            }
        }
        public string Modell { get; set; }

        public int AktuelleGeschwindigkeit
        {
            get { return _aktuelleGeschwindigkeit; }

            set
            {
                if (value >= 0 && value <= MaxGeschwindigkeit)
                    _aktuelleGeschwindigkeit = value;
            }
        }

        public int MaxGeschwindigkeit
        {
            get { return _maxGeschwindigkeit; }

            set
            {
                if (value >= 0)
                    _maxGeschwindigkeit = value;
            }
        }


        public virtual bool MotoLäuft { get; set; }

        public virtual void StarteMotor ()
        {
            MotoLäuft = true;
        }

        public virtual void MotorStoppen()
        {
            MotoLäuft = false;
            AktuelleGeschwindigkeit = 0;
        }



        public virtual void Bremsen(int geschwindigkeit)
        {
            AktuelleGeschwindigkeit = AktuelleGeschwindigkeit - geschwindigkeit;
        }

        public virtual void Beschleunigen ( int geschwindigkeit)
        {
            AktuelleGeschwindigkeit = AktuelleGeschwindigkeit - geschwindigkeit;
        }

        public class VehicleException : Exception
        {
            public VehicleException(string message)
                :base(message)
            {

            }
        }
    }


    public class Car : Vehicle, IBeladbar
    {
        public int Raeder { get; set; }
       
        public bool IsAutomaticGetriebe { get; set; }
        public bool MitAnhangerKupplung { get; set; }


        //BEISPIEL WIE MAN VIA INTERFACES 
        public IBeladbar Beladbar { get; set; } //WEnn Auto Beladbar ist...dann ist Objekt Beladbar nicht null 
        public int Ladeflaeche
        {
            get 
            { 
                if (Beladbar != null)
                {
                    return Beladbar.Ladeflaeche;
                }
                return default(int); //0 wird zurück gegeben
            }
            set
            {
                if (Beladbar != null)
                {
                    Beladbar.Ladeflaeche = value;
                }
            }
        }


        public int AktuelleBeladung
        {
            get
            {
                if (Beladbar != null)
                {
                    return Beladbar.AktuelleBeladung;
                }
                return default(int); //0 wird zurück gegeben
            }
            set
            {
                if (Beladbar != null)
                {
                    Beladbar.AktuelleBeladung = value;
                }
            }
        }

        public List<BeladungsItem> InventarListe
        {
            get
            {
                if (Beladbar != null)
                {
                    return Beladbar.InventarListe;
                }
                return null; //0 wird zurück gegeben
            }
            set
            {
                if (Beladbar != null)
                {
                    Beladbar.InventarListe = value;
                }
            }
        }

        

        public Car(string marke, string modell, int maxGeschwindigkeit, int raeder, bool isAutomatic, bool mitAnhaenger, IBeladbar beladbar)
            :base(marke, modell, maxGeschwindigkeit)
        {
            Raeder = raeder;
            IsAutomaticGetriebe = isAutomatic;
            MitAnhangerKupplung = mitAnhaenger;
            
            if (beladbar != null)
                Beladbar = beladbar;
        }
    }






    public interface IPassengerList
    {
        List<string> PassengerList { get; set; }
    }

    public class Plain : Vehicle
    {
        public int MaxFlughoehe { get; set; }
        public int AktuelleFlughohe { get; set; }

        public int Spannweite { get; set; }


        public Plain(string marke, string modell, int maxGeschwindigkeit, int maxFlughoehe, int spannweite)
            :base(marke, modell, maxGeschwindigkeit)
        {
            AktuelleFlughohe = 0;
            Spannweite = spannweite;
        }

        public override void MotorStoppen()
        {
            if (AktuelleGeschwindigkeit == 0)
            {
                base.MotorStoppen(); // -> MotoLäuft = false;  AktuelleGeschwindigkeit = 0;
                AktuelleFlughohe = 0;
            }
            else
                new PlainCrashWarningException("Motor kann nicht gestoppt werden. Flugzeug befindet sich in der Luft ");
        }


        public class PlainCrashWarningException : Exception //Exception muss immer abgeleitet werden
        {
            public  PlainCrashWarningException(string message)
                :base (message)
            {
            }
        }
    }

    //public enum Antriebskraft { Muskelkraft, Wind, Motor, Electro }
    public enum C02Abdruck { Klimaneutral, NormaleBelastung, StarkeBelastung }

    public class Ship : Vehicle
    {
        public int Tiefgang { get; set; }
        //public Antriebskraft Antrieb { get; set; }

        public Ship(string marke, string modell, int maxGeschwindigkeit, int tiefgang)
            :base (marke, modell, maxGeschwindigkeit)
        {
            Tiefgang = tiefgang;
        }
        //public int Masten { get; set; }
        //public int Segelflaeche { get; set; }
        //public int RuderAnzahl { get; set; }

        public override void StarteMotor()
        {
            // Ruder
        }
    }

    public class Segelschiff : Ship
    {
        public int Masten { get; set; }
        public int Segelflaeche { get; set; }

        public bool SegelGesetzt { get; set; }

        public Segelschiff(string marke, string modell, int maxGeschwindigkeit, int tiefgang, int masten, int segelflaeche, bool segelGesetzt)
            :base(marke, modell, maxGeschwindigkeit, tiefgang)
        {
            Masten = masten;
            Segelflaeche = segelflaeche;
            SegelGesetzt = segelGesetzt;
        }

        public override void StarteMotor()
        {
            
            if (SegelGesetzt)
                base.StarteMotor(); // Flag für Motor ist bei Segelschiff eine Status -> kein Motor

        }

        //Motor darf hier nicht verwenden -> Basisklasse - MotorStoppen / MotorStarten
    }

    public class Ruderboot : Ship
    {
        public int RuderAnzahl { get; set; }

        public int Ruderer { get; set; }


        public Ruderboot(string marke, string modell, int maxGeschwindigkeit, int tiefgang, int ruderAnzahl, int ruderer)
            :base(marke, modell, maxGeschwindigkeit, tiefgang)
        {
            RuderAnzahl = ruderAnzahl;
            Ruderer = ruderer;
        }


        public override void StarteMotor()
        {
            if (Ruderer > 0)
            {
                base.StarteMotor();
            }
        }


    }

    public class Motorboot : Ship
    {
        public Motorboot(string marke, string modell, int maxGeschwindigkeit, int tiefgang)
            :base(marke, modell, maxGeschwindigkeit, tiefgang) 
            {

            }
    }


    public class VehicleGarage
    {
        List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public int MaxVehicles { get; set; } = 10; //Default sind 10
        
        public VehicleGarage(int maxVehicles)
        {
            //Vehicles = new List<Vehicle>();
            MaxVehicles = maxVehicles;
        }

        public void Einparken(Vehicle vehicle)
        {
            if (!vehicle.MotoLäuft && MaxVehicles > Vehicles.Count)
                Vehicles.Add(vehicle);
        }

        public void InventarAusgabe()
        {
            int segelbootCounter = 0;
            int carCounter = 0;
            int plainCounter = 0;

            foreach (Vehicle vehicle in Vehicles)
            {


                if (vehicle is Segelschiff)
                {
                    segelbootCounter++;
                }
                else if (vehicle is Car)
                {
                    carCounter++;
                }
                else if (vehicle is Plain)
                {
                    plainCounter++;
                }
                else
                {
                    throw new Exception("This object is not supportet");
                }
            }

            Console.WriteLine("Inventarliste meiner Garage: ");
            Console.WriteLine($"Segelboote: {segelbootCounter}");
            Console.WriteLine($"Autos: {carCounter}");
            Console.WriteLine($"Flugzeuge: {plainCounter}");
        }


        public void AutosMitKofferraum()
        {
            int AutosMitKofferraum = 0; 
            foreach(Vehicle vehicle in Vehicles)
            {
                if (vehicle is Car myCar)
                {
                    if (myCar.Beladbar != null)
                    {
                        AutosMitKofferraum++;
                    }
                }
            }


            Console.WriteLine($"{AutosMitKofferraum} Autos mit Kofferraum existieren");
        }



    }



}
