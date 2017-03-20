using System;

namespace Refactoring.IntroduceParameterObject
{
    public class Entry
    {
        public DateTime ChargeDate { get; }
        public double Value { get; }
        public Entry(double value, DateTime chargeDate)
        {
            Value = value;
            ChargeDate = chargeDate;
        }

    }
}