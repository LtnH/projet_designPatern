using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WeekendPriceCalculationStrategy : IPriceCalculationStrategy
{
    public decimal CalculatePrice(int days)
    {
        int standardPricePerDay = 10;
        int weekendSpecialPrice = 15;

        if (days == 1)
        {
            return standardPricePerDay;
        }
        else if (days == 2)
        {
            return weekendSpecialPrice;
        }
        else if (days > 2)
        {
            return weekendSpecialPrice + (days - 2) * standardPricePerDay;
        }
        else
        {
            return 0;
        }
    }
}
