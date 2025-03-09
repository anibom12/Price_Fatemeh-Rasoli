using System;
using System.Linq.Expressions;

namespace ConsoleApp1;

public class Stock
{
    private string symbol;
    private decimal price;
    public Stock(string symbol)
    {
        this.symbol = symbol;
    }
    public event EventHandler<PriceChangeEventAregs> PriceChanged;
    protected virtual void OnPriceChange(PriceChangeEventAregs e)
    {
        PriceChanged?.Invoke(this, e);
    }
    public decimal Price
    {
        get => price;
        set
        {
            if (price == value) return;
            decimal oldprice = price;
            price = value;
            OnPriceChange(new PriceChangeEventAregs(oldprice, price));
        }
    }
    



}
