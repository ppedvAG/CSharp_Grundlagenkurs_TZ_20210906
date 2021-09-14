using System;

namespace M012_01_SOLID_SingleResponsibilityPrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region Schlechtes Beispiel
    public class EmployeeBad
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(EmployeeBad em)
        {
            // Insert into employee table.
            return true;
        }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(EmployeeBad em)
        {
            // Report generation with employee data using crystal report.
        }
    }
    #endregion


    #region verbsserte Variante
    //POCO - Object
    public class Employee //Repräsentiert 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Können noch viel Properties beinhalten
    }

    //Das Repository-Pattern
    //Für Datenbanken wird ein Repository verwendet. Ein Repository bezieht sich auf eine Tabelle -> 1:1 
    public class EmployeeRepository
    {
        //CRUD -> Create / Read / Update / Delete 


        public void Insert (Employee employee)
        {
            //Employee wird in der Tabelle gespeichert. 
        }
    }


    public class ReportGenerator
    {
        public void Generate()
        {
            //Mach ein Report
        }

        public string OutputFolder; 
    }
    #endregion
}
