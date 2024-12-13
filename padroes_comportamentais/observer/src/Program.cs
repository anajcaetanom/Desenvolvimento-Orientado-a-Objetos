namespace observer;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order();
        
        order.Attach(new EmailNotifier());
        order.Attach(new SmsNotifier());
        
        order.UpdateStatus("Shipped");
    }
}