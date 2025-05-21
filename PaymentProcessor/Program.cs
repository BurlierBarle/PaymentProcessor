class Program
{
    static void Main()
    {
        var processor = new PaymentProcessor.Component.PaymentProcessor();

        processor.ProcessPayment("CreditCard", 250);
        processor.ProcessPayment("PayPal", 100);
        processor.ProcessPayment("BankTransfer", 500);
    }
}