using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_Polymorphiesmus_Virtual
{

    //Klassen können nicht von sealed - Klassen erben  -> Use Case -> Singleton Pattern 
    public sealed class SchluesselwortVirtualAndSealed : DocumentObject
    {
        public void Hallo()
        {

        }


        public override void Print()
        {
            base.Print();
        }
    }


}
