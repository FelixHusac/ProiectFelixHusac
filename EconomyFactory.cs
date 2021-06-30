using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class EconomyFactory : PlaneTicketFactory
    {
        protected override PlaneTicket MakeTicket(Holder holder, Tuple<String, String> places, double price, bool isCorporate)
        {
            PlaneTicket Ticket = new EconomyTicket(holder, places, price, isCorporate);
            return Ticket;
        }
    }
}
