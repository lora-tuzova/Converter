Console.WriteLine("Type in the current price of USD in UAH: ");
try
{
    decimal u = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Type in the current price of EUR in UAH: ");
    decimal e = decimal.Parse(Console.ReadLine());
    Converter converter = new Converter(u, e);
    converter.ToConvert();
}
catch
{
    Console.WriteLine("Format of price is incorrect");
}


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
        try
        {
            Console.WriteLine("Type in the amount of money in UAH: ");
            decimal UAH = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Amount in USD: {UAH / USDtoUAH}\n");
            Console.WriteLine($"Amount in EUR: {UAH / EURtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Format of amount is incorrect");
        }
    }
}
