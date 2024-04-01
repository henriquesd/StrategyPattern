namespace StrategyPattern
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}