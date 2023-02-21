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
            _year = VadateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string date = $"{_year:0000}/{_month:00}/{ _day:00}";
            return date;
        }

        private int ValidateMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("The month is invalid!");
        }

        private int ValidateDay(int day, int month, int year)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; 
            if(month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            if(day >= 1 && day <= daysPerMonth[month]) 
            {
                return day;
            }
            throw new DayException("The day is invalid!");
        }

        private int VadateYear(int year)
        {
            if(year >= 1900)
            {
                return year;
            }
            throw new YearException("The year is invalid!");
        }

        private bool IsLeapYear(int year)
        {
            bool isLeap = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
            return isLeap;
        }
        #endregion
    }
}
