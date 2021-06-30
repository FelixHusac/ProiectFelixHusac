using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class Discount
    {
        private IDiscountStrategy _discountStrategy;
        private double _discount = 0.0;
        public void PrintDiscount()
        {
            Console.WriteLine("\n\tDicountul oferit: " + _discount);
        }

        public double GetDiscount() => _discount;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void CalculateDiscount(PlaneTicket ticket)
        {
            _discount = _discountStrategy.CalculateDiscount(ticket);
        }

        public void ApplyDiscountToTicket(PlaneTicket ticket)
        {
            var holder = ticket.GetCurrentHolder();
            holder.SetNrOfFlights(holder.GetNrOfFlights() + 1);
            ticket.SetTicketPrice(ticket.GetTicketPrice() * _discount);
            Console.WriteLine("**** NOUL PRET **** \n" + ticket.GetTicketPrice());
        }
    }
}
