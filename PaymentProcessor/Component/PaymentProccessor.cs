namespace PaymentProcessor.Component
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string method, decimal amount)
        {
            Console.WriteLine($"[INFO] Iniciando pago de {amount:C} usando {method}...");

            if (amount <= 0)
            {
                Console.WriteLine("❌ Error: El monto debe ser mayor a 0.");
                return;
            }

            if (method == "CreditCard")
            {
                Console.WriteLine("Autorizando tarjeta...");
                Thread.Sleep(500);
                var commission = amount * 0.02m;
                Console.WriteLine($"✅ Tarjeta autorizada. Comisión: {commission:C}");
                Console.WriteLine($"➡️ Pagado: {amount - commission:C}");
            }
            else if (method == "PayPal")
            {
                Console.WriteLine("Verificando cuenta PayPal...");
                Thread.Sleep(400);
                var commission = amount * 0.03m + 1.00m;
                Console.WriteLine($"✅ PayPal verificado. Comisión: {commission:C}");
                Console.WriteLine($"➡️ Pagado: {amount - commission:C}");
            }
            else if (method == "BankTransfer")
            {
                Console.WriteLine("Generando orden de transferencia...");
                Thread.Sleep(300);
                var commission = 2.50m;
                Console.WriteLine($"✅ Orden generada. Comisión fija: {commission:C}");
                Console.WriteLine($"➡️ Pagado: {amount - commission:C}");
            }
            else
            {
                Console.WriteLine($"❌ Error: Método '{method}' no soportado.");
                throw new NotSupportedException("Método de pago no soportado");
            }

            Console.WriteLine("[INFO] Proceso finalizado.\n");
        }
    }
}

