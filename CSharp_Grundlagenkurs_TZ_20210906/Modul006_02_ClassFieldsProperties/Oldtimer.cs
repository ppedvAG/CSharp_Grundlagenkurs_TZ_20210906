using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_ClassFieldsProperties
{
    public class Oldtimer
    {
        //Class - Member Variable (Field) 
        private string _marke;

        #region Zugriffs-Methoden auf _marke
        //SetMarke setzt die Variable _marke
        public void SetMarke(string marke)
        {
            //if (marke == string.Empty)
            //    throw new ArgumentException();


            _marke = marke;
        }

        //GetMarke liest die Variable _marke aus
        public string GetMarke()
        {
            return _marke;
        }
        #endregion

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
