using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public abstract class PlaneTicketFactory
    {
        protected abstract PlaneTicket MakeTicket(Holder holder, Tuple<String, String> places, double price, bool isCorporate);

        public PlaneTicket CreateTicket(Holder holder, Tuple<String, String> places, double price, bool isCorporate) => MakeTicket(holder, places, price, isCorporate);
    }
}
