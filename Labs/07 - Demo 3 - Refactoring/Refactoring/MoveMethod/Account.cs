namespace Refactoring.MoveMethod
{
    public class Account
    {
        private AccountType Type { get; }

        private int DaysOverdrawn { get; }

        public Account(AccountType type, int daysOverdrawn)
        {
            Type = type;
            DaysOverdrawn = daysOverdrawn;
        }

        public double Bankcharge()
        {
            var result = 4.5;

            result += OverdraftCharge();

            return result;
        }

        private double OverdraftCharge()
        {
            if (Type.IsPremium)
            {
                double result = 10;
                if (DaysOverdrawn > 7)
                    result += (DaysOverdrawn - 7) * 1.0;
                return result;
            }
            return DaysOverdrawn * 1.75;
        }
        
    }
}