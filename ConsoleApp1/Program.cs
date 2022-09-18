// See https://aka.ms/new-console-template for more informat

Console.WriteLine();
DateTime dt1 = new DateTime();
dt1 = DateTime.Now;
DateTime dt2 = dt1.AddDays(1);
Console.WriteLine(dt1.ToString("yyyy-mm-dd"));
List<AssetTracking> assetTracking = PrepareAssetTracking();
List<ExchangeRate> exchangeRates = PrepareExchangeRates();

Console.ReadLine();
// List of input from user

// office object
    Office officeIndia = new("India");
    Office officeSweden = new("Sweden");

new Computer(("Lenovo", "xxx", Date("2022-09-18"), officeIndia, 1000, "INR", 100),
                new Computer("HP", "XXX", Date("2022-08-10"),officeIndia, 1000, "SEK",7.5),
                new Phone("iPhone", "13",Date("2022-09-23"),officeSweden, 900, "SEK",8),
                new Phone("sony", "xperia", Date("2022-07-20"),officeSweden, 500, "SEK",2),
                new Phone("Nokia", "1100", Date("2022-05-17"),officeSweden, 600, "INR",10)              
            );

        
Console.WriteLine(Brand + " " + Model + " " + Date + " " + officeIndia + " " + Price in USD + " " + LocalPrice + " " ExchangeRate);
// List of exchange rates

static List<ExchangeRate> PrepareExchangeRates()
{
    return new List<ExchangeRate>()
            {
                new ExchangeRate("INR",8),
                new ExchangeRate("SEK", 1.00),
                
            };
}

class AssetTracking
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateTime Date { get; set; }
    public string Office { get; set; }
    public double Price { get; set; }
    public string LocalCurrency { get; set; }
    public double ExchangeRate { get; set; }
}



class Computer : AssetTracking
{
    public Computer(string brand, string model, DateTime Date, string office, double Price, string Localcurrency, double exchangeRate)
    {
        Brand = brand;
        Model = model;
        Date = date;
        Office = office;
        Price = Price;
        LocalCurrency = Localcurrency;
        ExchangeRate = exchangeRate;
    }
}
class Phone : AssetTracking
{
    public Phone(string brand, string model, Datetime date, string office, double Price, string Localcurrency, double exchangeRate)
    {
        Brand = brand;
        Model = model;
        Date = date;
        Office = office;
        Price = price;
        LocalCurrency = localcurrency;
        ExchangeRate = exchangerate;
    }
};









