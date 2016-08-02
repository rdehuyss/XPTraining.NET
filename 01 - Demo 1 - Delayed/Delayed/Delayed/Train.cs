using System;
using System.Collections.Generic;

namespace Delayed
{
    public class Train
    {
        private readonly double _hoursDelayed;
        private Dictionary<double, string> _messageOnHoursDelayed; 

        public Train(double hoursDelayed)
        {
            _hoursDelayed = hoursDelayed;
            _messageOnHoursDelayed = new Dictionary<double, string>();
            _messageOnHoursDelayed.Add(0, "Nice 'n' Rolling");
            _messageOnHoursDelayed.Add(1, "Just another day at the train");
            _messageOnHoursDelayed.Add(1.5, "We now support doubles");
            _messageOnHoursDelayed.Add(2, "This train is annoying me");
            _messageOnHoursDelayed.Add(3, "B-u-u-urn it!");
        }

        public string GetCustomerSatisfaction()
        {
            if(_messageOnHoursDelayed.ContainsKey(_hoursDelayed))
            {
                return _messageOnHoursDelayed[_hoursDelayed];
            }

            throw new Exception();
        }
    }
}