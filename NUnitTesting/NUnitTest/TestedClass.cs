using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    class TestedClass
    {
        /// <summary>
        /// Determine Maximum Days in a Month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public int DaysInMonth(int year, int month)
        {
            if (year < 1000 || year > 3000) return 0;
            switch (month)
            {
                #region Months with 31 days
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                #endregion
                #region Months with 30 days
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                #endregion
                case 2:
                    if (year % 400 == 0) return 29;
                    else
                    {
                        if (year % 100 == 0) return 28;
                        else
                        {
                            if (year % 4 == 0) return 29;
                            return 28;
                        }
                    }
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Date Validation
        /// </summary>
        /// <param name="day">Day(1~31)</param>
        /// <param name="month">Month(1~12)</param>
        /// <param name="year">Year(1000~3000)</param>
        /// <returns></returns>
        public bool IsValidDate(int year, int month, int day)
        {
            if (month > 0 && month < 13)
            {
                if (day >= 1)
                {
                    if (day <= DaysInMonth(year, month)) return true;
                }
            }
            return false;
        }
    }
}
