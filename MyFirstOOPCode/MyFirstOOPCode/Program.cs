using System;

namespace MyFirstOOPCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee salaryEmployeeObject = new SalaryEmployee();
            try
            {
                //var dateObjectBirthDate = new Date(1920, 2, 8);
                //var dateObjectHiringDate = new Date(2023, 1, 1);
                Console.WriteLine("");
                Console.WriteLine("What's your first name?");
                salaryEmployeeObject.FirstName = Console.ReadLine();
                Console.WriteLine($"{salaryEmployeeObject.FirstName} what's your last name?");
                salaryEmployeeObject.LastName = Console.ReadLine();
                Console.WriteLine($"{salaryEmployeeObject.FirstName} when is your birthday? aaaa/mm/dd");
                string[] birthday = Console.ReadLine().Split('/');
                salaryEmployeeObject.BirthDate = new Date(int.Parse(birthday[0]), int.Parse(birthday[1]), int.Parse(birthday[2]));
                Console.WriteLine($"{salaryEmployeeObject.FirstName} when they hired you?");
                string[] hireday = Console.ReadLine().Split('/');
                salaryEmployeeObject.HiringDate = new Date(int.Parse(hireday[0]), int.Parse(hireday[1]), int.Parse(hireday[2]));
                Console.WriteLine($"{salaryEmployeeObject.FirstName} you are employed?");
                salaryEmployeeObject.IsActive = ValidateIsActive(Console.ReadLine().ToLower());
                Console.WriteLine($"{salaryEmployeeObject.FirstName} what is your salary");
                salaryEmployeeObject.salary = decimal.Parse(Console.ReadLine());
                //SalaryEmployee salaryEmployeeObject = new SalaryEmployee()
                //{

                //    Id = 1233,
                //    FirstName = "Maria",
                //    LastName = "Sanl",
                //    BirthDate = dateObjectBirthDate,
                //    HiringDate = dateObjectHiringDate,
                //    IsActive = true,
                //    salary = 1600000.56M
                //};
                Console.WriteLine(salaryEmployeeObject.ToString());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            bool ValidateIsActive(string employee)
            {
                if(employee != "yes" && employee != "no")
                {
                    Console.WriteLine($"{salaryEmployeeObject.FirstName} you are employed?");
                    salaryEmployeeObject.IsActive = ValidateIsActive(Console.ReadLine().ToLower());
                }
                return employee == "yes";
            }
        }
    }
}
