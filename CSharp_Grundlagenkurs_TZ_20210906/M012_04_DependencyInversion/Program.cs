using System;

namespace M012_04_DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programmierer B kann jetzt den CarService Testen
            //Bad Sample

            #region schlechtes Beispiel
            CarService carService = new CarService();
            #endregion



            #region Gutes Beispiel -> Arbeiten mit Interfaces
            //Zum Testen 
            ICar myMockObject = new MockCar();
            carService.RepairCar(myMockObject); //Test Objet kann ich hier verwenden 


            //Produktiv
            ICar myCarObj = new Car();
            ICarV2 carV2Obj = new MockCarV2();

            carService.RepairCar(carV2Obj); //Funktioniert, weil in ICarV2 das ICar Interface enthalten ist. Objekt hat alles was es brauch.....also ICar 


            carService.RepairCar(myCarObj); //Test Objet kann ich hier verwenden 



            carService.RepairCar(carV2Obj);
            #endregion

            //wäre auch möglich
            //myCarObj = myMockObject; //Hier werden alle felder zugewiesen, die aus ICAr kommen 



            MyBikeService myBikeService = new MyBikeService();


            MockBike mockBikeV1 = new MockBike();
            MockBikeV2 mockBikeV2 = new MockBikeV2();

            myBikeService.RepairBike(mockBikeV1);

            myBikeService.RepairBike(mockBikeV2);





            IBike myBike = new MyBike();


        }
    }


    #region BadCode
    public class EasyCar //Programmierer A: 5 Tage (Tag 1 -> Tag 5)
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
    }

    //Werkstatt
    public class EasyCarService  //Programmierer B: 3 Tage (Tag 5/6 bis Tag 8)
    {
        public void RepairCar(EasyCar car) //Programmiere B muss warten, bis EasyCar fertig implementiert ist. 
        {
            //Repariere das Auto 
        }
    }
    #endregion


    #region Gute Variante 1 
    public interface ICar
    {
        int Id { get; set; }
        string Marke { get; set; }
        string Modell { get; set; }
        int Baujahr { get; set; }
    }

    public interface ICarV2 : ICar
    {
        public string Farbe { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
        void RepairCar(ICarV2 car);
    }

    public class Car : ICar //Programmierer A - 5 Tage (Tag1 - Tag 5) 
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
    }


    public class MockCarV2 : ICarV2
    {
        public int Id { get; set; } = 1;
        public string Marke { get; set; } = "VW";
        public string Modell { get; set; } = "Polo";
        public int Baujahr { get; set; } = 1999;

        public string Farbe { get; set; } = "blau";
    }

    public class CarV2 : ICarV2
    {
        public int Id { get; set; } 
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }

        public string Farbe { get; set; } 
    }

    //Mock Objeckte sind Objekte für Funktionstest 
    public class MockCar : ICar //Programmierer A - 5 Tage (Tag1 - Tag 5) 
    {
        public int Id { get; set; } = 1;
        public string Marke { get; set; } = "VW";
        public string Modell { get; set; } = "Polo";
        public int Baujahr { get; set; } = 1999;
    }
    

    public class CarService : ICarService // Programmierer B - 3 Tage (Tag1 - Tag3)
    {
        public void RepairCar(ICar car)
        {
           //Repairere Auto
        }

        public void RepairCar(ICarV2 car)
        {
            //Repairere Auto
        }
    }

    #endregion

    #region Weitere Variante (nur abstrakte Klasse)
    



    public abstract class BaseBikeObj
    {
        public abstract string Marke { get; set; }
        public abstract string Modell { get; set; }
        public abstract int Baujahr { get; set; }
    }

    public abstract class BaseBikeObjV2 : BaseBikeObj
    {
        public abstract string Farbe { get; set; }
    }

    public abstract class BikeServiceBase
    {
        public abstract void RepairBike(BaseBikeObj baseBikeObj);
    }

    public class MyBikeService : BikeServiceBase
    {
        public override void RepairBike(BaseBikeObj baseBikeObj)
        {
            //Repairiere Bike
        }
    }



    public class Bike : BaseBikeObj
    {
        public override string Marke { get; set; }
        public override string Modell { get; set; }
        public override int Baujahr { get; set; }
    }


    public class MockBike : BaseBikeObj
    {
        public override string Marke { get; set; } = "Ducati";
        public override string Modell { get; set; } = "Sehr schnell";
        public override int Baujahr { get; set; } = 2018;
    }





    public class BikeV2 : BaseBikeObjV2
    {
        public override string Marke { get; set; }
        public override string Modell { get; set; }
        public override int Baujahr { get; set; }
        public override string Farbe { get; set; }
    }

    public class MockBikeV2 : BaseBikeObjV2
    {
        public override string Marke { get; set; } = "Honda";
        public override string Modell { get; set; } = "Hornet";
        public override int Baujahr { get; set; } = 2007;
        public override string Farbe { get; set; } = "rot";
    }







    #endregion



    #region abstract mit interface
    public interface IBike
    {
        string Marke { get; set; }
        string Modell { get; set; }
        int Baujahr { get; set; }
    }

    public abstract class BikeBase : IBike
    {
        public  abstract string Marke { get; set; }
        public  abstract string Modell { get; set; }
        public  abstract  int Baujahr { get; set; }
    }


    public class MyBike : BikeBase
    {
        public override string Marke { get; set; }
        public override string Modell { get; set; }
        public override int Baujahr { get; set; }
    }


    #endregion
}
