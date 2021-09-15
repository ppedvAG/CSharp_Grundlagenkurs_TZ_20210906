using System;
using System.Collections;
using System.Collections.Generic;

namespace M014_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Liste
            //using System.Collections.Generic;
            IList<string> namensListe = new List<string>();
            
            namensListe.Add("Felix");
            namensListe.Add("Maya");
            
            if (!namensListe.Contains("Felix"))
                namensListe.Add("Felix");


            for (int i = 0; i < namensListe.Count; i++)
            {
                Console.WriteLine(namensListe[i]);
            }

            foreach (string currentString in namensListe)
                Console.WriteLine(currentString);

            #endregion


            #region Dictionary Vs Hashtable

            //Aufbau eines Dictionaries

            // KEY-Spalte | Value-Spalte
            //  int       |    string   ->  IDictionary<int, string>

            //wichtig bei Dictionary -> Key muss eindeutig sein. 
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Hannes");
            dict.Add(2, "Andre");
            //dict.Add(2, "Kevin"); // -> Würde ein Fehler entstehen, weil Key (2) mehrfach vorkommt. 

            if (!dict.ContainsKey(2))
                dict.Add(2, "Hallejullia");

            foreach (KeyValuePair<int, string> currentDictEntry in dict)
            {
                Console.WriteLine(currentDictEntry.Key);
                Console.WriteLine(currentDictEntry.Value);
            }

            KeyValuePair<int, string> neuerEintragViaKeyValuePair = new KeyValuePair<int, string>(3, "Happy Hour");
            dict.Add(neuerEintragViaKeyValuePair);



            #region AntiBeispiel Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(new DateTime(), "hallo");
            hashtable.Add(123, 5.67m);
            hashtable.Add(hashtable, "hallo");


            for (int i = 0; i < hashtable.Count; i++)
            {
                
            }
            #endregion
            #endregion

            #region Stack
            Stack<string> stringStack = new Stack<string>();

            //mit Push wird ein Element hinzugefuegt
            stringStack.Push("Element 1"); //Beispiel Kartenstapel.... der neuste Eintrag, liegt immer ganz oben
            stringStack.Push("Element 2");
            stringStack.Push("Element 3");
            stringStack.Push("Element 4");
            stringStack.Push("Element 5");

            foreach (string item in stringStack)
            {
                Console.WriteLine(item);
            }
            //Element 1
            //Element 2

            //mit Pop bekommt man das oberste Element zurueck und es wird aus dem Stack entfernt
            stringStack.Pop();   //=>  Element 5 herunternehmen und löscht diesen wieder vom Stapel 

            stringStack.Peek();  //Element 4 wird ausgelesen und nicht gelöscht(Element 5 extisiert nicht mehr durch Pop) -
            #endregion

            #region Queue
            //arbeitet nach dem First In - First Out Prinzip
            //Elemente werden in eine Reihe gepackt und nacheinander abgearbeitet
            Queue<string> stringQueue = new Queue<string>();

            //mit Enqueue wird ein Element hinzugefuegt
            stringQueue.Enqueue("Element 1");
            stringQueue.Enqueue("Element 2");


            foreach (var item in stringQueue)
            {
                Console.WriteLine(item);
            }

            //mit Dequeue bekommt man das aelteste Element zurueck und es wird aus der Queue entfernt
            stringQueue.Dequeue();   //=>  Element 1 herunternehmen


            //mit Peak bekommt man das aelteste Element zurueck
            stringQueue.Peek();  //=> "Element 1"
            #endregion
        }
    }
}
