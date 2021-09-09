using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_Methoden
{
    public class OutInRefParameter
    {
        //Out Variablen verwenden wir bei Werttypen, die wir als Referenz verwenden möchten 
        //OUT hat eine Bedinung, die Variable muss befüllt werden 
        public float Berechne (int zahl1, int zahl2, out int min, out int max, out float avg) //Zeiger (Speicheradresse) wird von min, max und avg übergeben
        {
            float summe = zahl1 + zahl2;

            if (zahl1 < zahl2)
            {
                min = zahl1;
                max = zahl2;
            }
            else
            {
                min = zahl2;
                max = zahl1;
            }

            avg = summe / 2;


            return summe;
        }
    
        public float Berechne (Addiere addiere)
        {
            if (addiere.Zahl1 > addiere.Zahl2)
            {
                addiere.Max = addiere.Zahl1;
                addiere.Min = addiere.Zahl2;
            }
            else
            {
                addiere.Max = addiere.Zahl2; 
                addiere.Min = addiere.Zahl1;
            }

            addiere.AVG = (addiere.Zahl1 + addiere.Zahl2) / 2;
            return addiere.Zahl1 + addiere.Zahl2;
        }

        //Bei Verwendung von 'in' wird die Variable als readonly behandelt. 
        public float Berechne(int zahl1, int zahl2, in int Faktor)
        {
            //in int ist readonly
            //Faktor = 123; - 
            return zahl1 + zahl2;
        }

        public float BerechneMitRef(int zahl1, int zahl2, ref int Faktor)
        {
            Faktor = 123;
            return zahl1 + zahl2 + Faktor;
        }
    }

    public class Addiere //Klassen sind Referenztypen
    {
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }

        public int Max { get; set; }
        public int Min { get; set; }

        public int AVG { get; set; }
    }
}
