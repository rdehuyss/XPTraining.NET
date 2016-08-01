namespace VampireSlayer
{
    using System;

    public class Hunter
    {
        public bool CanHunt(DateTime huntingTime)
        {
            return huntingTime.Hour > 0 && huntingTime.Hour < 6;
        }
    }
}
