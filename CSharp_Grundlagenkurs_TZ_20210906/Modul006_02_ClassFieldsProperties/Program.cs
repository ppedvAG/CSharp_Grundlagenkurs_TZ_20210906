using System;

namespace Modul006_02_ClassFieldsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Oldtimer oldtimer = new Oldtimer();


            //beim Aufruf eines Konstruktors, kann ich Properties mit "init" befüllen -> danach ist "init" nicht mehr befüllbar und daher readonly
            ElectroCar electroCar = new ElectroCar("VW", "Polo", 1999, 115);

            //Hier bekomme ich einen Fehler, weil Init-Properties hier readonly sind
            //electroCar.Höchstgeschwindigkeit = 130;


        }
    }
}
