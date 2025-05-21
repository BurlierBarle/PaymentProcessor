using PatronStrategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Resources
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public bool Validate(decimal amount) => amount >= 100;

        public decimal CalculateCommission(decimal amount) => 2.50m;

        public void Authorize()
        {
            Console.WriteLine("📄 Generando orden de transferencia...");
            Thread.Sleep(300);
            Console.WriteLine("✅ Orden generada.");
        }

        public void Pay(decimal amount)
        {
            if (!Validate(amount))
            {
                Console.WriteLine("❌ Transferencias requieren mínimo 100.00.");
                return;
            }

            Authorize();
            var commission = CalculateCommission(amount);
            Console.WriteLine($"🏦 Comisión aplicada: {commission:C}");
            Console.WriteLine($"➡️ Pagado: {amount - commission:C}");
        }
    }
}
