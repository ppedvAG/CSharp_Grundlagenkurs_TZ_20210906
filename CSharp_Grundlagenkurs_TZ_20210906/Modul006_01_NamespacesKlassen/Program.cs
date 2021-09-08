using First = Modul006_01_NamespacesKlassen.ErstesNamespace;
using Second = Modul006_01_NamespacesKlassen.ZweitesNamespace;

using System;
using Modul006_01_NamespacesKlassen.DritteNamespace;

namespace Modul006_01_NamespacesKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Absolute Angabe des Namespaces + Klasse
            Modul006_01_NamespacesKlassen.ErstesNamespace.MeineKlasse class1 = new ErstesNamespace.MeineKlasse();
            Modul006_01_NamespacesKlassen.ZweitesNamespace.MeineKlasse class2 = new ZweitesNamespace.MeineKlasse();

            //Namespaces mit Aliase -> //Namespace mit Alias  -> https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/using-directive
            First.MeineKlasse class1a = new First.MeineKlasse();
            Second.MeineKlasse class2a = new Second.MeineKlasse();

            //MeineKlasse aus dem dritten Namespace
            MeineKlasse meineKlasse = new MeineKlasse();
            
        }
    }
}
