namespace Cegeka.Education.Greeting
{
    public interface ITimeSupplier
    {
        int GetHourOfDay();

        int GetMinute();
        
        int GetSeconds();
    }
}