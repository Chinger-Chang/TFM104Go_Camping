using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Models
{
    public class CalPrice
    {
        public static decimal CalDaysPrice(DateTime beginDate, DateTime endDate, decimal moPrice, decimal holiPrice)
        {
            var curDate = beginDate;
            decimal total = 0;
            while (curDate < endDate)
            {
                //判斷星期幾
                DayOfWeek day = curDate.DayOfWeek;
                if (day == DayOfWeek.Sunday || day == DayOfWeek.Saturday)
                {
                    //價格
                    total += holiPrice;
                }
                else
                {
                    total += moPrice;
                }
                curDate = curDate.AddDays(1);
            }
            return total;
        }
    }
}
