var op = new OrderProcessor(123);

op.OrderCompleted += orderNumber =>
{
    Console.WriteLine($"Order completed: Order #{orderNumber} \nNotification: Your order #{orderNumber} is now complete!");
};

op.MakeOrder();

internal class OrderProcessor
{
    internal delegate void OrderHandler(byte orderNumber);
    
    public event OrderHandler? OrderCompleted;

    private byte OrderNumber { get; }

    internal OrderProcessor(byte orderNumber)
    {
        OrderNumber = orderNumber;
    }

    public void MakeOrder()
    {
        Console.WriteLine($"Order placed: Order #{OrderNumber}");
        Console.WriteLine($"Processing order: Order #{OrderNumber}");
        OrderCompleted?.Invoke(OrderNumber);
    }
}