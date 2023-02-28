using MyFirstOOPCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class Invoice : Ipay
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Public methods 
        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Description: {Description}\n\t" +
                $"Quantity............{Quantity}\n\t" +
                $"Price...............{Price:C2}\n\t" +
                $"Invoice Value.......{GetValueToPay():C2}";
        }
        #endregion
    }
}
