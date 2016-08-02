using System;
using System.Runtime.Serialization;

namespace Flight
{
    public class FlightFullyBookedException : Exception
    {
        public FlightFullyBookedException()
        {
        }

        public FlightFullyBookedException(string message) : base(message)
        {
        }

        public FlightFullyBookedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}