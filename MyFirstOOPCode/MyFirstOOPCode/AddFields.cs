using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class AddFields 
    {
        #region Attributes
        private int id;
        private string firstName;
        private string lastName;
        private string[] birthday;
        private Date dateObjectBirthDate;
        private Date dateObjectHiringDate;
        private bool isActive;
        private decimal salary;
        private double commissionPercentage;
        private decimal sale;
        private double hours;
        private decimal hoursValue;
        private decimal Base;
        private decimal payRoll;
        private Employee salaryEmployee;
        private Employee commissionEmployee;
        private Employee HourlyEmployee;
        private Employee baseCommissionEmployee;
        private Invoice invoice;
        #endregion

        #region Public methods
        public void EnterSalaryEmployee()
        {
            EnterBaseInformation();

            Console.WriteLine($"{firstName} what is your salary");
            salary = decimal.Parse(Console.ReadLine());
        }

        public void EnterCommissionEmployee()
        {
            EnterBaseInformation();

            EntercommissionPercentage();

            Console.WriteLine($"{firstName} Type your sales?");
            sale = Convert.ToDecimal(Console.ReadLine());
        }

        public void EnterHourlyEmployee()
        {
            EnterBaseInformation();

            Console.WriteLine($"{firstName} your number of hours?");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{firstName} your value per hour?");
            hoursValue = Convert.ToDecimal(Console.ReadLine());
        }

        public void EnterBaseCommissionEmployee()
        {
            EnterBaseInformation();

            EntercommissionPercentage();

            Console.WriteLine($"{firstName} Type your sales?");
            sale = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"{firstName} your salary base?");
            Base = Convert.ToDecimal(Console.ReadLine());
        }

        public object AddSalaryEmployee()
        {
            salaryEmployee = new SalaryEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObjectBirthDate,
                HiringDate = dateObjectHiringDate,
                IsActive = isActive,
                salary = salary
            };
            return salaryEmployee;
        }

        public object AddCommissionSalary()
        {
            commissionEmployee = new CommissionEmployee()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObjectBirthDate,
                HiringDate = dateObjectHiringDate,
                IsActive = isActive,
                CommissionPercentge = commissionPercentage,
                Sales = sale
            };
            return commissionEmployee;
        }

        public object AddHourlyEmployee()
        {
            HourlyEmployee = new HourlyEmplyee()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObjectBirthDate,
                HiringDate = dateObjectHiringDate,
                IsActive = isActive,
                Hours = hours,
                HoursValue = hoursValue
            };
            return HourlyEmployee;
        }

        public object AddBaseCommissionEmployee()
        {
            baseCommissionEmployee = new BaseCommissionEmployee()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObjectBirthDate,
                HiringDate = dateObjectHiringDate,
                IsActive = isActive,
                CommissionPercentge = commissionPercentage,
                Sales = sale,
                Base = Base
            };
            return baseCommissionEmployee;
        }

        public object AddInvoice()
        {
            invoice = new Invoice()
            {
                Id = 2010,
                Description = "iPhone",
                Price = 1500M,
                Quantity = 3
            };
            return invoice;
        }

        public void inicial()
        {
            ICollection<Employee> employees = new List<Employee>() 
            {
                salaryEmployee,
                commissionEmployee,
                HourlyEmployee, 
                baseCommissionEmployee,
            };
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payRoll += employee.GetValueToPay();
                Console.WriteLine("");
            }
        }

        public string Print()
        {
            return string.Format("Total Payroll............{0}", payRoll);
        }

        public string ToString(object typeEmployee)
        {
            return typeEmployee.ToString();
        }
        #endregion

        #region Private methods
        private void EnterBaseInformation()
        {
            Console.WriteLine("");
            Console.WriteLine("What's your Id?");
            id = Convert.ToInt32(Console.ReadLine());

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

            Console.WriteLine($"{firstName} you are employed? Yes/No");
            isActive = ValidateIsActive(Console.ReadLine().ToLower());
        }

        private void EntercommissionPercentage()
        {
            Console.WriteLine($"{firstName} Type your percentage?");
            commissionPercentage = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
        }

        private bool ValidateIsActive(string answer)
        {
            if (answer != "yes" && answer != "no")
            {
                Console.WriteLine($"{firstName} you are employed?");
                isActive = ValidateIsActive(Console.ReadLine().ToLower());
            }
            return answer == "yes";
        }
        #endregion
    }
}
