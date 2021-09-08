using System;

namespace Modul007_01_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 1
            Person person = new Person("Maxi", "Muster");


            Person person1 = new Person("Max", "Muster", DateTime.Now);


            Person person2 = new Person("Max", "Muster", DateTime.Now, 5);

            Beine linkesBein = new Beine(100);
            Beine rechtesBein = new Beine(99);

            Person personMitLinkenUndRechtenBein = new Person("Heike", "Musterfrau", DateTime.Now, 3, linkesBein, rechtesBein);
        }
    }
}
