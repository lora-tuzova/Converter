Console.WriteLine("Type in the current price of USD in UAH: ");
try
{
    decimal u = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Type in the current price of EUR in UAH: ");
    decimal e = decimal.Parse(Console.ReadLine());
    Converter converter = new Converter(u, e);
    while (true)
    {
        Console.WriteLine("Which convertation do you wish to perform? Type 1 for UAH to USD, 2 for UAH to EUR, 3 for USD to UAH, 4 for EUR to UAH");
        string i = Console.ReadLine();
        switch (i)
        {
            case "1":
                converter.ConvertUAHtoUSD();
                break;
            case "2":
                converter.ConvertUAHtoEUR();
                break;
            case "3":
                converter.ConvertUSDtoUAH();
                break;
            case "4":
                converter.ConvertEURtoUAH();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;

        }

    }
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
    public void ConvertUAHtoUSD()
    {
        try
        {
            Console.WriteLine("Type in the amount of money in UAH: ");
            decimal UAH = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Amount in USD: {UAH / USDtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Format of amount is incorrect");
        }
    }

    public void ConvertUAHtoEUR()
    {
        try
        {
            Console.WriteLine("Type in the amount of money in UAH: ");
            decimal UAH = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Amount in EUR: {UAH / EURtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Format of amount is incorrect");
        }
    }

    public void ConvertUSDtoUAH()
    {
        try
        {
            Console.WriteLine("Type in the amount of money in USD: ");
            decimal USD = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Amount in UAH: {USD * USDtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Format of amount is incorrect");
        }
    }

    public void ConvertEURtoUAH()
    {
        try
        {
            Console.WriteLine("Type in the amount of money in UAH: ");
            decimal EUR = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Amount in UAH: {EUR * EURtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Format of amount is incorrect");
        }
    }
}
