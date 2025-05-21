using PatronStrategy.Services;

namespace PatronStrategy.Resources
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public bool Validate(decimal amount) => amount > 0;

        public decimal CalculateCommission(decimal amount) => amount * 0.02m;

        public void Authorize()
        {
            Console.WriteLine("🔐 Autorizando tarjeta de crédito...");
            Thread.Sleep(500);
            Console.WriteLine("✅ Autorización exitosa.");
        }

        public void Pay(decimal amount)
        {
            if (!Validate(amount))
            {
                Console.WriteLine("❌ Monto inválido.");
                return;
            }

            Authorize();
            var commission = CalculateCommission(amount);
            Console.WriteLine($"💳 Comisión aplicada: {commission:C}");
            Console.WriteLine($"➡️ Pagado: {amount - commission:C}");
        }
    }
}
