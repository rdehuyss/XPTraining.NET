namespace Cegeka.Education.Greeting.UnitTests
{
    using System;

    public class TimeSupplierStub : ITimeSupplier
    {
        private readonly DateTime _dummyDate;

        public TimeSupplierStub(DateTime dummyDate)
        {
            _dummyDate = dummyDate;
        }

        public int GetHourOfDay()
        {
            return _dummyDate.Hour;
        }

        public int GetMinute()
        {
            throw new NotImplementedException();
        }

        public int GetSeconds()
        {
            throw new NotImplementedException();
        }
    }
}