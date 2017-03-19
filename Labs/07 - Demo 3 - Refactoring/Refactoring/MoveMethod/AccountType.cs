namespace Refactoring.MoveMethod
{
    public class AccountType
    {
        public bool IsPremium { get; }

        public AccountType(bool premium)
        {
            IsPremium = premium;
        }
        
    }
}