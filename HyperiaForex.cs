using System;

public struct CurrencyAmount
{
    readonly decimal _amount;
    readonly string _currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        _amount = amount;
        _currency = currency;
    }
    
    public static bool operator ==(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount == amountB._amount;
    }

    public static bool operator !=(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount != amountB._amount;
    }

    public static bool operator <(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount < amountB._amount;
    }

    public static bool operator >(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount > amountB._amount;
    }

    public static decimal operator +(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount + amountB._amount;
    }

    public static decimal operator -(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount - amountB._amount;
    }

    public static decimal operator *(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount * amountB._amount;
    }

    public static decimal operator /(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA._currency != amountB._currency) throw new ArgumentException();
        return amountA._amount / amountB._amount;
    }

    public static explicit operator double(CurrencyAmount amount) => (double)amount._amount;
    public static implicit operator decimal(CurrencyAmount amount) => amount._amount;
}
