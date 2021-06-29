using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public interface PlaneTicket
    {
        string GetTicketType();
        double GetTicketPrice();
        void SetTicketPrice(double price);

        String GetTicketDetails();
        bool GetTicketStatus();

        String GetTicketDestination();
        String GetTicketDeparture();

        Holder GetCurrentHolder();
    }
}
