using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_ClassFieldsProperties
{
    public class ElectroCar
    {
        private string _marke;
        private string _model;
        private int _baujahr;
        private int _reichweite = 100;

        //Konstruktor -> Initialisieren unsere MemberVariablen 

        public ElectroCar(string marke, string model, int baujahr, int höchstgeschwindigkeit)
        {
            //_marke = marke; //einfache zuweisung
            Marke = marke; //zuweisung via Property mit dem Benefitz, die Validierung mitzuverwenden
            Model = model;
            Baujahr = baujahr;
            Höchstgeschwindigkeit = höchstgeschwindigkeit;
        }

        //Properties 

        public string Marke
        {
            set
            {
                //Bei Set-Property haben wir eine Hilfsvariable Namens 'value'

                //Prüfe, dass zugewiesener Wert, etwas enthält
                if(!string.IsNullOrEmpty(value))
                    _marke = value;
            }

            get
            {
                return _marke;
            }
        }


        //Verkürzte Schreibweise zu Property Marke 
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int Reichweite
        {
            get
            {
                return _reichweite;
            }
        }

        //Kleines Update C# 8.0 
        public int Höchstgeschwindigkeit { get; init; } //init kann nur via Konstruktor befüllt werden, danach ist Höchstgeschwindigkeit nur noch readonly 
        public int Baujahr { get => _baujahr; set => _baujahr = value; }

        //Methoden

        #region Allgemeine Methoden
        public void Beschleunigen()
        {

        }

        public void MotorEin()
        {

        }

        public void Bremsen()
        {

        }
        #endregion 
    }
}
