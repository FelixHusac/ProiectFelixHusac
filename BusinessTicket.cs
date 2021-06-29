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

        public Holder GetCurrentHolder()
        {
            return _holder;
        }

        public String GetTicketDetails()
        {
            return _holder.ToString() + "\n-----\n" +
                "Plecare: " + _departure +
                "\nSosire: " + _arrival +
                "\nPret bilet: " + _price +
                "\nEste bilet Corporate: " + _isCorporate;
        }

        public double GetTicketPrice()
        {
            return _price > 0.0 ? _price : 1000.0;
        }

        public bool GetTicketStatus()
        {
            return _isCorporate;
        }

        public string GetTicketType()
        {
            return "Business Class";
        }

        public string GetTicketDeparture()
        {
            return _departure != "" ? _departure : "Destinatie invalida";
        }

        public string GetTicketDestination()
        {
            return _arrival != "" ? _arrival : "Plecare invalida";
        }

        public void SetTicketPrice(double price)
        {
            this._price = price;
        }

        public BusinessTicket(Holder holder, Tuple<String, String> places, double price, bool isCorporate)
        {
            this._holder = holder;
            this._departure = places.Item1;
            this._arrival = places.Item2;
            this._price = price;
            this._isCorporate = isCorporate;
        }
    }
}
