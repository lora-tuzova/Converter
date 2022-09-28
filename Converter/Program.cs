Console.WriteLine("Type in the current price of USD in UAH: ");
decimal u = decimal.Parse(Console.ReadLine());
Console.WriteLine("Type in the current price of EUR in UAH: ");
decimal e = decimal.Parse(Console.ReadLine());
Converter converter = new Converter(u, e);
converter.ToConvert();

class Converter
{
    decimal USDtoUAH;
    decimal EURtoUAH;
    public Converter (decimal USD, decimal EUR)
    {
        USDtoUAH = USD;
        EURtoUAH = EUR;
    }
    public void ToConvert()
    {
        Console.WriteLine("Type in the amount of money in UAH: ");
        decimal UAH = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"Amount in USD: {UAH / USDtoUAH}\n");
        Console.WriteLine($"Amount in EUR: {UAH / EURtoUAH}\n");
    }
}