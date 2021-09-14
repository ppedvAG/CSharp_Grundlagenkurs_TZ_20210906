using System;

namespace M012_03_SOLID_LizkovischeRegel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class LottoGenerator
    {
        public int[] GeneriereLottozahlen ()
        {
            Random rand = new Random();
            int[] retArray = new int[7];


            retArray[0] = rand.Next(1, 50);
            retArray[1] = rand.Next(1, 50);
            retArray[2] = rand.Next(1, 50);
            retArray[3] = rand.Next(1, 50);
            retArray[4] = rand.Next(1, 50);
            retArray[5] = rand.Next(1, 50);
            retArray[6] = rand.Next(1, 50);#

            return retArray;
        }
    }

    public class MitarbeiterGehaltsVorschlag : LottoGenerator
    {
        public int Gehaltsvorschlag()
        {
            //Ich benötige Zufallszahlen

            int[] returnArray = GeneriereLottozahlen();

            int summary = returnArray[0] * returnArray[1] + returnArray[2] + returnArray[3] - returnArray[3];

            return summary;
        }
    }


    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Apple
    //{
    //    //public override string GetColor()
    //    //{
    //    //    return "Orange";
    //    //}
    //}




    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }


}
