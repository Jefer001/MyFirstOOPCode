using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class HourlyEmplyee : Employee
    {
        #region Properties
        public double Hours { get; set; }
        public decimal HoursValue { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HoursValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Hours.....................{Hours:N2}\n\t" +
                $"Value per hour ...........{HoursValue:C2}\n\t" +
                $"Value to Pay..............{GetValueToPay():C2}";
        }
        #endregion
    }
}
