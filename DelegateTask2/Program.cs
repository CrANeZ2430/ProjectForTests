var stock = new Stock("APPL");

stock.StockChanged += (price, stockName) =>
{
    Console.WriteLine($"Stock: {stockName}, New Price: ${price}");
    if (price >= 160)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Alert: {stockName} stock price exceeded $160.00!");
        Console.ResetColor();
    }
};

while (stock.Price < 160)
{
    stock.DisplayPrice();
}



class Stock
{
    private string StockName { get; }
    public decimal Price { get; private set; }
    public event Action<decimal, string> StockChanged;

    public Stock(string stockName)
    {
        StockName = stockName;
    }

    private void ChangePrice()
    {
        Price = Random.Shared.Next(200);
    }

    public void DisplayPrice()
    {
        ChangePrice();
        StockChanged?.Invoke(Price, StockName);
        Thread.Sleep(2000);
    }
}