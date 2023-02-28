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
                //addFields.EnterSalaryEmployee();
                //Console.WriteLine("*******************");
                //Console.WriteLine("* Salary Employee *");
                //Console.WriteLine("*******************");
                //Console.WriteLine($"{addFields.ToString(addFields.AddSalaryEmployee())}");
                //Console.WriteLine("");
                //addFields.EnterCommissionEmployee();
                //Console.WriteLine("***********************");
                //Console.WriteLine("* Commission Employee *");
                //Console.WriteLine("***********************");
                //Console.WriteLine($"{addFields.ToString(addFields.AddCommissionSalary())}");
                //Console.WriteLine("");
                //addFields.EnterHourlyEmployee();
                //Console.WriteLine("*******************");
                //Console.WriteLine("* Hourly Employee *");
                //Console.WriteLine("*******************");
                ////Console.WriteLine($"{addFields.ToString(addFields.AddHourlyEmployee())}");
                //Console.WriteLine("");
                //addFields.EnterBaseCommissionEmployee();
                //Console.WriteLine("****************************");
                //Console.WriteLine("* Base Commission Employee *");
                //Console.WriteLine("****************************");
                //Console.WriteLine($"{addFields.ToString(addFields.AddBaseCommissionEmployee())}");
                Console.WriteLine("");
                Console.WriteLine("***********");
                Console.WriteLine("* Invoice *");
                Console.WriteLine("***********");
                Console.WriteLine($"{addFields.ToString(addFields.AddInvoice())}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}