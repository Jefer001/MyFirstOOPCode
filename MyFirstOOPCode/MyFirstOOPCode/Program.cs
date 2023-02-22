using System;

namespace MyFirstOOPCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObjectBirthDate = new Date(1992, 2, 2);
                var dateObjectHiringDate = new Date(2013, 1, 1);

                Console.WriteLine("");
                SalaryEmployee salaryEmployeeObject = new SalaryEmployee()
                {
                    Id = 1233,
                    FirstName = "Maria",
                    LastName = "Sanl",
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = true,
                    salary = 1600000.56M
                };
                Console.WriteLine(salaryEmployeeObject.ToString());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
