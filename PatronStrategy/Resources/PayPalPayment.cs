using PatronStrategy.Services;

namespace PatronStrategy.Resources
{
    public class PayPalPayment : IPaymentStrategy
    {
        public bool Validate(decimal amount) => amount >= 10;

        public decimal CalculateCommission(decimal amount) => amount * 0.03m + 1.00m;

        public void Authorize()
        {
            Console.WriteLine("🔐 Verificando cuenta PayPal...");
            Thread.Sleep(400);
            Console.WriteLine("✅ Cuenta verificada.");
        }

        public void Pay(decimal amount)
        {
            if (!Validate(amount))
            {
                Console.WriteLine("❌ PayPal requiere mínimo 10.00.");
                return;
            }

            Authorize();
            var commission = CalculateCommission(amount);
            Console.WriteLine($"🅿️ Comisión aplicada: {commission:C}");
            Console.WriteLine($"➡️ Pagado: {amount - commission:C}");
        }
    }
}
