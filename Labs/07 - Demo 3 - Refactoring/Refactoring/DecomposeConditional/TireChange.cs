namespace Refactoring.DecomposeConditional
{
    public class TireChange
    {
        private static readonly int WINTER_START = 12;
        private static readonly int WINTER_END = 2;
        private int _quantity;
        private int _winterrate;
        private int _winterservicecharge;
        private int _summerrate;

        public TireChange(int quantity, int winterrate, int winterservicecharge, int summerrate)
        {
            _quantity = quantity;
            _winterrate = winterrate;
            _winterservicecharge = winterservicecharge;
            _summerrate = summerrate;
        }

        public int Charge(int monthOfYear)
        {
            int charge;
            if (monthOfYear >= WINTER_START || monthOfYear <= WINTER_END)
            {
                charge = _quantity * _winterrate + _winterservicecharge;
            }
            else
            {
                charge = _quantity * _summerrate;
            }
            return charge;
        }
    }
}