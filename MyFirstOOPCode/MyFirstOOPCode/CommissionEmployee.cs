using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class CommissionEmployee : Employee
    {
        #region Fields
        private readonly int percentage = 100;
        #endregion

        #region Properties
        public double CommissionPercentge { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ConvertPercentage(CommissionPercentge);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Commission Percentage ......{ConvertPercentage(CommissionPercentge):P2}\n\t" +
                $"Sales.......................{Sales:C2}\n\t" +
                $"Value to Pay................{GetValueToPay():C2}\n\t";
        }

        public double ConvertPercentage(double commissionPercentag)
        {
            return commissionPercentag / percentage;
        }
        #endregion
    }
}
