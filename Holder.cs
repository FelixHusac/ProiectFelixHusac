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

        public int GetNrOfFlights()
        {
            return _nrOfFlights;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetNrOfFlights(int newNr)
        {
            this._nrOfFlights = newNr;
        }

        public override string ToString()
        {
            return "Detaliile detiantorului:" +
                " \n\tNume: " + _firstName + " " + _lastName +
                "\n\tVarsta: " + _age +
                "\n\tNumar de zboruri efectuate: " + _nrOfFlights;
        }

        public Holder(String _firstName, String _lastName, int _age)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._age = _age;
        }

    }
}