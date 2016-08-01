namespace Cegeka.Education.Greeting
{
    using System;

    public class Greeting
    {
        private readonly ITimeSupplier _timeSupplier;

        public Greeting(ITimeSupplier timeSupplier)
        {
            if (timeSupplier == null)
            {
                throw new ArgumentNullException("timeSupplier", @"Greeting / Greeting");
            }

            _timeSupplier = timeSupplier;
        }

        public string GetGreeting()
        {
            if (_timeSupplier.GetHourOfDay() > 12)
            {
                return "Good Afternoon";
            }

            return "Good Morning";
        }
    }
}