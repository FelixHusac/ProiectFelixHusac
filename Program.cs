using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler Ionel = new Director();
            Handler Costel = new Manager();
            Handler Gigel = new President();

            Ionel.SetHigherUp(Costel);
            Costel.SetHigherUp(Gigel);

            Holder Holder;
            PlaneTicket Ticket;
            Discount Discount;

            String stopper = "Y";
            do {
                List<String> paramList = new List<String>();
                paramList = GatherData();
                Holder = new Holder(paramList[0], paramList[1], int.Parse(paramList[2]));

                Console.WriteLine("A mai zburat? Y/N");
                if(Console.ReadLine().ToString() == "Y")
                {
                    Console.WriteLine("Dati numarul de zboruri efectuate: ");
                    Holder.SetNrOfFlights(int.Parse(Console.ReadLine()));
                }

                
                Console.WriteLine("Clasa biletului: " +
                    "\n\t1. First Class\n\t" +
                    "2. Business Class\n\t" +
                    "3.Economy Class\n\t");
                int choice = int.Parse(Console.ReadLine());
                Ticket = SelectTicketType(choice, Holder);


                Console.WriteLine(Ticket.GetTicketDetails());

                Discount = new Discount();

                if(Ticket.GetTicketStatus() == false)
                {
                    Discount.SetDiscountStrategy(new DiscountNormal());
                    Discount.CalculateDiscount(Ticket);
                }
                else
                {
                    Discount.SetDiscountStrategy(new DiscountCorporate());
                    Discount.CalculateDiscount(Ticket);
                }
                
                Ionel.ProcessDiscount(Discount,Ticket);

                Console.WriteLine("Continuati? Y/N");
                stopper = Console.ReadLine().ToString();
            } while (stopper != "N");
        }

        public static List<String> GatherData()
        {
            Console.WriteLine("Dati numele utilizatorului: ");
            String fname = Console.ReadLine().ToString();

            Console.WriteLine("Dati prenumele utilizatorului: ");
            String lname = Console.ReadLine().ToString();

            Console.WriteLine("Dati varsta utilizatorului: ");
            String age = Console.ReadLine();

            List<String> paramList = new List<String>() { fname, lname, age };
            return paramList;
        }

        public static PlaneTicket SelectTicketType(int choice, Holder holder)
        {
            Console.WriteLine("Dati plecarea: ");
            String departure = Console.ReadLine().ToString();

            Console.WriteLine("Dati sosirea: ");
            String arrival = Console.ReadLine().ToString();
            Tuple<String, String> places = Tuple.Create(departure, arrival);

            Console.WriteLine("Introduceti pretul: ");
            double price = double.Parse(Console.ReadLine());

            bool corporate = false;
            Console.WriteLine("Este bilet CORPORATE? Y/N");
            if (Console.ReadLine().ToString() == "Y")
            {
                corporate = true;
            }
            else
            {
                corporate = false;
            }

            PlaneTicket Ticket = choice switch
            {
                1 => new FirstClassFactory().CreateTicket(holder, places, price, corporate),
                2 => new BusinessTicketFactory().CreateTicket(holder, places, price, corporate),
                3 => new EconomyFactory().CreateTicket(holder, places, price, corporate)
            };
            return Ticket;
        }
    }
}
