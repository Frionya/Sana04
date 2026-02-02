using System;
using Sana04;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- Test Airplane ---");
        MyDate date1 = new MyDate(2024, 10, 15, 12, 00);
        MyDate date2 = new MyDate(2024, 10, 15, 14, 30);

        Airplane flight = new Airplane("Kyiv", "Warsaw", date1, date2);

        Console.WriteLine($"Рейс: {flight.PropStartCity} - {flight.PropFinishCity}");
        Console.WriteLine($"Час в дорозі: {flight.GetTotalTime()} хв");
        Console.WriteLine($"Прибуває в той же день? {flight.IsArrivingToday()}");

        Console.WriteLine("\n--- Test Product ---");
        Currency usd = new Currency("USD", 41.2);
        Product laptop = new Product("Laptop X", 1000, usd, 5, "Dell", 1.5);

        Console.WriteLine($"Товар: {laptop.PropName}");
        Console.WriteLine($"Ціна за одиницю (UAH): {laptop.GetPriceInUAH()} грн");
        Console.WriteLine($"Загальна вартість складу (UAH): {laptop.GetTotalPriceInUAH()} грн");
        Console.WriteLine($"Загальна вага: {laptop.GetTotalWeight()} кг");
    }
}