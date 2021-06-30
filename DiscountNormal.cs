using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class DiscountNormal : IDiscountStrategy
    {
        public double CalculateDiscount(PlaneTicket ticket)
        {
            var Holder = ticket.GetCurrentHolder();
            var DiscountCalculator = new DiscountCalculator();
            return DiscountCalculator.Calculate(Holder.GetAge(), Holder.GetNrOfFlights(), 0.3) / 4;
        }
    }
}
