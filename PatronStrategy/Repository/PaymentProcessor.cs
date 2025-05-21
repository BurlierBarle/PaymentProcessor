using PatronStrategy.Services;

namespace PatronStrategy.Repository
{
    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _strategy;

        public PaymentProcessor(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Process(decimal amount)
        {
            Console.WriteLine("[INFO] Iniciando proceso de pago...");
            _strategy.Pay(amount);
            Console.WriteLine("[INFO] Proceso de pago completado.\n");
        }
    }
}
