using System;

namespace M012_02_SOLID_OpenClosePrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ReportGenerator
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            //Allgemeine Initialisierungen -< z.b Wo ist mein OutputPath oder Name des Reports 
            
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                //Libary für PDF Export
                //Fülllogik us
                // Report generation with employee data in PDF.
            }
            if (ReportType == "CSVReport")
            {

            }



        }
    }

    #endregion

    #region Besserer Code - Variante 1
    public abstract class ReportGeneratorBase
    {
        public abstract void Generate();
    }

    public class PDFGenerator : ReportGeneratorBase
    {
        //Hier kann man weitere Implementierung angehen für PDF - Optionen

        public override void Generate()
        {
            //Generiere eine PDF
        }
    }

    public class CrystalReportsGenerator : ReportGeneratorBase
    {
        public override void Generate()
        {
            //Genierer ein CR
        }
    }
    #endregion

    #region Variante 2 - Mit Interface


    public interface IReportGenerator
    {
         void Generate();
    }


    public class PDF2Generator : IReportGenerator
    {
        public void Generate()
        {
            //Generiere eine PDF
        }
    }

    public class CR2Generator : IReportGenerator
    {
        public void Generate()
        {
            //Generiere eine CR
        }
    }

    #endregion







}
