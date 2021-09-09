using Modul008_02_Lib;
using System;

namespace Modul008_02_Zugriffmodifier
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectroCar electroCar = new ElectroCar();
            electroCar.Lackiere(); //public void Fahrzeug.Lackiere()
            electroCar.publicGeschwindigkeit = 12; //public int publicGeschwindigkeit;
            electroCar.WhatCanIUseIntern(); //public void WhatCanIUseIntern()

        }
    }
}
