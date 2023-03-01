﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay();
        }

        public decimal TotalGetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Base........................{Base:C2}\n\t" +
                $"Tota value to Pay...........{TotalGetValueToPay():C2}\n\t";
        }
        #endregion
    }
}
