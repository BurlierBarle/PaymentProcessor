using PatronStrategy.Repository;
using PatronStrategy.Resources;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Pagos con Strategy Pattern (Complejo) ===");

        var credit = new PaymentProcessor(new CreditCardPayment());
        credit.Process(300);

        var paypal = new PaymentProcessor(new PayPalPayment());
        paypal.Process(50);

        var bank = new PaymentProcessor(new BankTransferPayment());
        bank.Process(500);
    }
}
