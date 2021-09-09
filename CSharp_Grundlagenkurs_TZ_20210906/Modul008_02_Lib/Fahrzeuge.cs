
using System;

namespace Modul008_02_Lib
{
    //public => ueberall
    //private => innerhalb der selben Klasse
    //internal => innerhalb der aktuellen Assembly
    //protected => innerhalb der selben Klasse oder innerhalb abgeleiteter Klassen

    //protected internal => innerhalb der aktuellen Assembly oder abgeleitet Klasse in anderer Assembly
    //private protected => innerhalb der selben Klasse oder innerhalb einer abgeleiteten Klasse in der aktuellen Assembly

    public class Fahrzeug
    {
        public int publicGeschwindigkeit; 
        private string privateFarbe; // kann nur innerhalb der Fahrzeugklassen verwendet werden 
        internal object internalRadio;

        protected object protectedAntrieb;
        
        protected internal object protectedinternalKofferraum;
        private protected object privateprotectedLenkrad;

        public void Lackiere()
        {
            //Private kann nur innerhalb der Klasse verwendet werden, die in dieser auch definiert ist. 
            this.privateFarbe = "Orange";
        }
    }

    

    public class ElectroCar : Fahrzeug
    {
        public void WhatCanIUseIntern()
        {
            //Auf welche Variablen kann intern zugreifen 

            this.internalRadio = new object();
            this.privateprotectedLenkrad = new object();
            this.protectedAntrieb = new object();
            this.protectedinternalKofferraum = new object();
            this.publicGeschwindigkeit = 12;


            
        }
    }



    public class Haribo
    {
        public Fahrzeug Fahrzeug { get; set; }

        public void TuWas()
        {
            Fahrzeug.internalRadio = 123;
        
        }
    }
}

