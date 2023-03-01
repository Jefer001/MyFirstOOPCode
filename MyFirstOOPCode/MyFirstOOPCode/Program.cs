using System;

namespace MyFirstOOPCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AddFields addFields = new AddFields();
                //Console.WriteLine("*******************");
                //Console.WriteLine("* Salary Employee *");
                //Console.WriteLine("*******************");
                //addFields.EnterSalaryEmployee();

                //Console.WriteLine("");
                //Console.WriteLine("***********************");
                //Console.WriteLine("* Commission Employee *");
                //Console.WriteLine("***********************");
                //addFields.EnterCommissionEmployee();

                //Console.WriteLine("");
                //Console.WriteLine("*******************");
                //Console.WriteLine("* Hourly Employee *");
                //Console.WriteLine("*******************");
                //addFields.EnterHourlyEmployee();

                Console.WriteLine("");
                Console.WriteLine("****************************");
                Console.WriteLine("* Base Commission Employee *");
                Console.WriteLine("****************************");
                addFields.EnterBaseCommissionEmployee();

                //    Console.WriteLine("");
                //    Console.WriteLine("***********");
                //    Console.WriteLine("* Invoice *");
                //    Console.WriteLine("***********");
                //    Console.WriteLine($"{addFields.ToString(addFields.AddInvoice())}");
                addFields.Print();
                Console.WriteLine(addFields.PrintPayRoll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}