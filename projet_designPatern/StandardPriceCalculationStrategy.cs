using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StandardPriceCalculationStrategy : IPriceCalculationStrategy
{
    public decimal CalculatePrice(int days)
    {
        return (decimal)(10.0 * days);
    }
}