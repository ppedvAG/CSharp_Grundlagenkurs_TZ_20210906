using System;

namespace Modul001_01_HelloWorld
{
    class Program
    {

        //Traditionelle Einstiegpunkt in C# 
        static void Main(string[] args) //args Argumente (optionale Angaben) - dir.ex /p -> '/p' war ein Argument 
        {
            Console.Write("Liebe Teilnehmer -> ");
            Console.Write("Hello World \n"); //\n = Zeilenumbruch
            Console.WriteLine("Hello World!");

            Console.ReadLine(); //Ab .NET 5 und Visual Studio 2019 16.4 muss man kein Readline verwenden
        }
    }
}
