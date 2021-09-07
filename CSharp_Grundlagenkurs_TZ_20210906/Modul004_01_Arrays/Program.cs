using System;
using System.Linq;

namespace Modul004_01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[5]; //ein Integer Array von der Länge 5

            zahlen[0] = default(int); //default bedeut, gebe mir den Default-Wert (0) auf zahl[0]

            string[] woerter = new string[] { "ppedv", "CSharp", "Grundkurs" }; //eine string-Array mit einer Laenge von drei

            double[] gleitkommzahlen = new double[] { 6.29, 1.58, 4.79, 6.55 };
            double result = gleitkommzahlen.Sum(); //Achtung Sum() kommt aus dem Assembly -> System.Linq; 

            zahlen[0] = 1; //Index 0 -> Start-Index Wert
            zahlen[1] = 2;
            zahlen[2] = 3;
            zahlen[3] = 4;
            zahlen[4] = 5; //Index 4 -> End-Index Wert 
                           //zahlen[5] -> OutOfRangeException (6te Element gib es nicht) 

            string wort1 = woerter[0]; //wort1 =>"ppedv"

            //Funktionen und Eigenschaften von Arrays
            int laenger = zahlen.Length; //länge eines Arrays mit der Property Length

            //Contains -> benötigt System.Linq;
            bool enthaelt = woerter.Contains("CSharp"); //true 

            string csvPattern = "Kevin;Winter;Berlin;Trainer";
            string[] csvParts = csvPattern.Split(';');

            string vorname = csvParts[0];
            string nachname = csvParts[1];
            string ort = csvParts[2];
            string job = csvParts[3];


            //Rundumblick in System.Linq

            //Min/Max -> benötigt System.Linq;
            double kleinsteZahl = gleitkommzahlen.Min(); //kleinster Wert im Array wird herausgegeben
            double hoechsteZahle = gleitkommzahlen.Max();
            double durschnittsWert = gleitkommzahlen.Average();
            double ersteZahl = gleitkommzahlen.First();
            double letzteZahl = gleitkommzahlen.Last();
            double sum1 = gleitkommzahlen.Sum();


            ////Deklaration einer mehrdimensionalen Array
            int[,] zweiDimensionen;

            

            //zweidimensionale Array mit zwei Zeilen und fuenf Spalten initialisieren
            zweiDimensionen = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10  } };

            //zweidimensionale Array mit vier Zeilen und drei Spalten
            zweiDimensionen = new int[4, 3];
            zweiDimensionen[0, 0] = 22;
            zweiDimensionen[0, 1] = 33;
            zweiDimensionen[0, 2] = 44;

            zweiDimensionen[1, 0] = 22;
            zweiDimensionen[1, 1] = 44;
            zweiDimensionen[1, 2] = 66;


            zweiDimensionen[2, 0] = 3;
            zweiDimensionen[2, 1] = 6;
            zweiDimensionen[2, 2] = 9;

            zweiDimensionen[3, 0] = 7;
            zweiDimensionen[3, 1] = 14;
            //zweiDimensionen[2, 1] ohne direkte zuweisung wird default also 0 gesetzt



            int[,,] array3D = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };

            //Anzahl der Dimensionen
            int dimensionen = array3D.Rank;//3 -> [2, 3, 2]

            //Anzahl aller Elemente
            int laenge3D = array3D.Length;//12 -> { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };

            //Laenge der einzelnen Dimensionen
            int laenge1 = array3D.GetLength(0);//2
            int laenge2 = array3D.GetLength(1);//3
            int laenge3 = array3D.GetLength(2);//2



            //Initialisierung durch setzen der Laenge
            int[][] verzweigteArray = new int[4][];

            //Initialisierung durch direkte Zuweisung der Elemente
            verzweigteArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 } };

            //Zugriff ueber Index
            int jaggedWert = verzweigteArray[0][2];// 3

            //Zuweisung ueber Index
            verzweigteArray[1][1] = 5;

            Console.ReadLine();
        }
    }
}
