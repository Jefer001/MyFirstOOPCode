using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode
{
    public class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day;
        #endregion

        #region Builder
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string date = $"{_year:0000}/{_month:00}/{ _day:00}";
            return date;
        }
        #endregion
    }
}
