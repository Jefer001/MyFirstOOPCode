using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class SalaryEmployee : Employee
    {
        #region Properties
        public decimal salary { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Value to pay.........{GetValueToPay():C2}";
        }
        #endregion
    }
}
