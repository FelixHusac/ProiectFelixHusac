using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class DiscountNormal : DiscountStrategy
    {
        public override double CalculateDiscount(PlaneTicket ticket)
        {
            Holder h = ticket.GetCurrentHolder();
            if(h.GetNrOfFlights() != 0)
            {
                return ((h.GetAge() / 10) * 0.3) + (h.GetNrOfFlights() / 10);
            }
            return (h.GetAge() / 10) * 0.3;
        }
    }
}
