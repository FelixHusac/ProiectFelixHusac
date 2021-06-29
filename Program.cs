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

            Holder h;
            PlaneTicket t;
            Discount d;

            String stopper = "Y";
            do {
                List<String> paramList = new List<String>();
                paramList = GatherData();
                h = new Holder(paramList[0], paramList[1], int.Parse(paramList[2]));

                Console.WriteLine("A mai zburat? Y/N");
                if(Console.ReadLine().ToString() == "Y")
                {
                    Console.WriteLine("Dati numarul de zboruri efectuate: ");
                    h.SetNrOfFlights(int.Parse(Console.ReadLine()));
                }

                
                Console.WriteLine("Clasa biletului: " +
                    "\n\t1. First Class\n\t" +
                    "2. Business Class\n\t" +
                    "3.Economy Class\n\t");
                int choice = int.Parse(Console.ReadLine());
                t = SelectTicketType(choice, h);


                Console.WriteLine(t.GetTicketDetails());

                d = new Discount();

                if(t.GetTicketStatus() == false)
                {
                    d.SetDiscountStrategy(new DiscountNormal());
                    d.CalculateDiscount(t);
                }
                else
                {
                    d.SetDiscountStrategy(new DiscountCorporate());
                    d.CalculateDiscount(t);
                }
                
                Ionel.ProcessDiscount(d,t);

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

        public static PlaneTicket SelectTicketType(int i, Holder h)
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

            PlaneTicket t;
            if (i == 1)
            {
                t = new FirstClassFactory().CreateTicket(h, places, price, corporate);
                return t;
            }
            else if (i == 2)
            {
                t = new BusinessTicketFactory().CreateTicket(h, places, price, corporate);
                return t;
            }
            else
            {
                t = new EconomyFactory().CreateTicket(h, places, price, corporate);
                return t;
            }
        }
    }
}
