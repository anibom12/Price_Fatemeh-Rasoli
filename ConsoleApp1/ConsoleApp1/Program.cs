using ConsoleApp1;
using Dia2Lib;
using System.Diagnostics;
using System.Globalization;

Stock stock = new Stock("THPW");
Console.WriteLine("Please enter the price");
decimal price = decimal.Parse(Console.ReadLine());
stock.Price = price;

string fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
ILogger input = new FileService(fileName);

stock.PriceChanged += stock_PriceChanged;
void stock_PriceChanged(object sender, PriceChangeEventAregs e)
{
    if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
        input.Alret("Alert, 10% stock price increase!");
}
Console.WriteLine("Please enter new price");



decimal newPrice = decimal.Parse(Console.ReadLine());
stock.Price = newPrice;




input.Logger($"Old price={price.ToString()}");
input.Logger($"New price={newPrice.ToString()}");

Process.Start("notepad", fileName);




