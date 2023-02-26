using System;

namespace MyFirstOOPCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("");
                //Console.WriteLine("What's your first name?");
                //string firstName = Console.ReadLine();

                //Console.WriteLine($"{firstName} what's your last name?");
                //string lastName = Console.ReadLine();

                //Console.WriteLine($"{firstName} when is your birthday? yyyy/mm/dd");
                //string[] birthday = Console.ReadLine().Split('/');
                //var dateObjectBirthDate = new Date(Convert.ToInt16(birthday[0]), Convert.ToInt16(birthday[1]), Convert.ToInt16(birthday[2]));

                //Console.WriteLine($"{firstName} when they hired you? yyyy/mm/dd");
                //string[] hireday = Console.ReadLine().Split('/');
                //var dateObjectHiringDate = new Date(Convert.ToInt16(hireday[0]), Convert.ToInt16(hireday[1]), Convert.ToInt16(hireday[2]));

                //Console.WriteLine($"{firstName} you are employed?");
                //bool isActive = Convert.ToBoolean(Console.ReadLine());

                //Console.WriteLine($"{firstName} what is your salary");
                //decimal salary = decimal.Parse(Console.ReadLine());

                //SalaryEmployee salaryEmployeeObject = new SalaryEmployee()
                //{
                //    Id = 1233,
                //    FirstName = firstName,
                //    LastName = lastName,
                //    BirthDate = dateObjectBirthDate,
                //    HiringDate = dateObjectHiringDate,
                //    IsActive = true,
                //    salary = salary
                //};
                //Console.WriteLine("*******************");
                //Console.WriteLine("* Salary Employee *");
                //Console.WriteLine("*******************");
                //Console.WriteLine(salaryEmployeeObject.ToString());
                Console.WriteLine("");

                Console.WriteLine("What's your first name?");
                string firstName = Console.ReadLine();

                Console.WriteLine($"{firstName} what's your last name?");
                string lastName = Console.ReadLine();

                Console.WriteLine($"{firstName} when is your birthday? yyyy/mm/dd");
                string[] birthday = Console.ReadLine().Split('/');
                var dateObjectBirthDate = new Date(Convert.ToInt16(birthday[0]), Convert.ToInt16(birthday[1]), Convert.ToInt16(birthday[2]));

                Console.WriteLine($"{firstName} when they hired you? yyyy/mm/dd");
                string[] hireday = Console.ReadLine().Split('/');
                var dateObjectHiringDate = new Date(Convert.ToInt16(hireday[0]), Convert.ToInt16(hireday[1]), Convert.ToInt16(hireday[2]));

                Console.WriteLine($"{firstName} you are employed?");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine($"{firstName} Type ypur in percentage?");
                double commissionPercentage = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{firstName} Type your sales?");
                decimal sale = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmployee = new CommissionEmployee() 
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate, 
                    IsActive = isActive,
                    CommissionPercentge = commissionPercentage,
                    Sales = sale
                };
                Console.WriteLine("***********************");
                Console.WriteLine("* Commission Employee *");
                Console.WriteLine("***********************");
                Console.WriteLine("");
                Console.WriteLine(commissionEmployee.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
