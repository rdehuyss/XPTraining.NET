using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    public class Flight
    {
        private readonly int _maxNumberOfSeats;

        private readonly HashSet<string> _passengers;

        public Flight(int maxNumberOfSeats)
        {
            _maxNumberOfSeats = maxNumberOfSeats;
            _passengers = new HashSet<string>();
        }

        public void AddPassenger(string person)
        {
		    if (IsFlightFull()) {
                throw new FlightFullyBookedException("Flight is already full!");
            }
            _passengers.Add(person);
        }

        private bool IsFlightFull()
        {
            return NumberOfPassengers() >= _maxNumberOfSeats;
        }

        public int NumberOfPassengers()
        {
            return _passengers.Count;
        }

        public bool IsPassengerOnFlight(string person)
        {
            return _passengers.Contains(person);
        }

        public HashSet<string> ListPassengers()
        {
            return _passengers;
        }

        public int MaxNumberOfSeats()
        {
            return _maxNumberOfSeats;
        }

    }
}
