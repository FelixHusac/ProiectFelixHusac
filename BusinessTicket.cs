using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    class BusinessTicket : PlaneTicket
    {

        private Holder _holder;
        private String _departure;
        private String _arrival;
        private double _price;
        private bool _isCorporate = false;

        public Holder GetCurrentHolder() => _holder;

        public String GetTicketDetails()
        {
            return _holder.ToString() + "\n-----\n" +
                "Plecare: " + _departure +
                "\nSosire: " + _arrival +
                "\nPret bilet: " + _price +
                "\nEste bilet Corporate: " + _isCorporate;
        }

        public double GetTicketPrice() => _price;

        public bool GetTicketStatus() => _isCorporate;

        public string GetTicketType() => "Business Class";

        public string GetTicketDeparture() => _departure;

        public string GetTicketDestination() => _arrival;

        public void SetTicketPrice(double price)
        {
            _price = price;
        }

        public BusinessTicket(Holder holder, Tuple<String, String> places, double price, bool isCorporate)
        {
            _holder = holder;
            _departure = places.Item1;
            _arrival = places.Item2;
            _price = price;
            _isCorporate = isCorporate;
        }
    }
}
