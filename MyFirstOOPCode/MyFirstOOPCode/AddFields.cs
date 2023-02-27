using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class AddFields 
    {
        #region Attributes
        private string firstName;
        private string lastName;
        private string[] birthday;
        private Date dateObjectBirthDate;
        private Date dateObjectHiringDate;
        private bool isActive;
        private decimal salary;
        private Employee salaryEmployee;
        #endregion

        #region Methods
        public void EnterSalaryEmployee()
        {
            Console.WriteLine("");
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine($"{firstName} what's your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine($"{firstName} when is your birthday? yyyy/mm/dd");
            birthday = Console.ReadLine().Split('/');
            dateObjectBirthDate = new Date(Convert.ToInt16(birthday[0]), Convert.ToInt16(birthday[1]), Convert.ToInt16(birthday[2]));

            Console.WriteLine($"{firstName} when they hired you? yyyy/mm/dd");
            string[] hireday = Console.ReadLine().Split('/');
            dateObjectHiringDate = new Date(Convert.ToInt16(hireday[0]), Convert.ToInt16(hireday[1]), Convert.ToInt16(hireday[2]));

            Console.WriteLine($"{firstName} you are employed?");
            isActive = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"{firstName} what is your salary");
            salary = decimal.Parse(Console.ReadLine());

            salaryEmployee = new SalaryEmployee()
            {
                Id = 1233,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObjectBirthDate,
                HiringDate = dateObjectHiringDate,
                IsActive = isActive,
                salary = salary
            };
        }

        public object AddSalaryEmployee()
        {
            return salaryEmployee;
        }

        public string ToString(object typeEmployee)
        {
            return typeEmployee.ToString();
        }
        #endregion
    }
}
