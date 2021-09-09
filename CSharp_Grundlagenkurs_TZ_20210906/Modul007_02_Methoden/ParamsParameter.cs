using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_Methoden
{
    public class ParamsParameter
    {

        public int Addiere(params int[] zahlen)
        {
            int summer = 0;

            for (int i = 0; i < zahlen.Length; i++)
                summer += zahlen[i];

            return summer;
        }

        public int AddiereOld(int[] zahlen)
        {
            int summer = 0;

            for (int i = 0; i < zahlen.Length; i++)
                summer += zahlen[i];

            return summer;
        }
    }
}
