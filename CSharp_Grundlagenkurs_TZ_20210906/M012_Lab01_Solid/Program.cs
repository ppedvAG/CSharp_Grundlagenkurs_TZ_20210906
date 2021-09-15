using System;
using System.ComponentModel.DataAnnotations;

namespace M012_Lab01_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region Bad Code

    public class BadEmployee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        public string ReportType { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(BadEmployee em)
        {
            // Insert into employee table.
            return true;
        }
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>


        public void GenerateReport(BadEmployee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }

    #endregion

    #region Good

    //Mal angenommen, das ist ein POCO - Object  (Entity Framework Core) 
    public class GoodEmployee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public interface IKey<T>  
    {
        T Key { get; set; }
    }

    public class GoodEmployeeVariante2 : IKey<Guid>
    {
        public Guid Key { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }

    public  class EmployeeRepository
    {
        public void Insert(GoodEmployee employee)
        {
            //Speichere In DB
        }
    }

    public abstract class ReportGeneratorBase
    {
        public abstract void Generate();
    }

    public class CrystalGeneratorReport : ReportGeneratorBase
    {
        public override void Generate()
        {
            //Generiere ein Crystal Report
        }
    }

    public class List10GeneratorReport : ReportGeneratorBase
    {
        public override void Generate()
        {
            //Generiere ein Crystal Report
        }
    }

    public class CSVGeneratorReport : ReportGeneratorBase
    {
        public override void Generate()
        {
            //Generiere ein Crystal Report
        }
    }




    public class MyProgramm //UI pder Präsentations Layer
    {
        ReportGeneratorBase report = null;

        public void ReportGeneratorWindow ()
        {
            Console.WriteLine("(1) List10");
            Console.WriteLine("(2) CR");
            Console.WriteLine("(3) CSV");
            Console.Write("Welcher Reporter möchten Sie auswählen? :");
            int auswahl = Convert.ToInt32(Console.ReadKey());
            
            switch (auswahl)
            {
                case 1:
                    report = new List10GeneratorReport();
                    break;
                case 2:
                    report = new CSVGeneratorReport();
                    break;
                case 3:
                    report = new CrystalGeneratorReport();
                    break;
                default:
                    Console.WriteLine("Kein Reporter gefunden");
                    break;
            }




            report.Generate();
        }
    }



    #endregion
}


