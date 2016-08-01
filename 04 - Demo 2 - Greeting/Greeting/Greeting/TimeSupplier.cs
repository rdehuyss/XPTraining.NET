namespace Cegeka.Education.Greeting
{
    using System;

    public class TimeSupplier : ITimeSupplier
    {
        public int GetHourOfDay()
        {
            return DateTime.Now.Hour;
        }

        public int GetMinute()
        {
            return DateTime.Now.Minute;
        }

        public int GetSeconds()
        {
            return DateTime.Now.Second;
        }
    }
}