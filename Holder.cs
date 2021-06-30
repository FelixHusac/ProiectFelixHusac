using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class Holder
    {
        private String _firstName { get; }

        private String _lastName { get; }

        private int _age { get; }

        private int _nrOfFlights = 0;

        public int GetNrOfFlights() => _nrOfFlights;

        public int GetAge() => _age;

        public void SetNrOfFlights(int newNr)
        {
            _nrOfFlights = newNr;
        }

        public override string ToString()
        {
            return "Detaliile detiantorului:" +
                " \n\tNume: " + _firstName + " " + _lastName +
                "\n\tVarsta: " + _age +
                "\n\tNumar de zboruri efectuate: " + _nrOfFlights;
        }

        public Holder(String firstName, String lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

    }
}