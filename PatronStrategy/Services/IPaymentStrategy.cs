namespace PatronStrategy.Services
{
    public interface IPaymentStrategy
    {
        bool Validate(decimal amount);
        decimal CalculateCommission(decimal amount);
        void Authorize();
        void Pay(decimal amount);
    }
}
