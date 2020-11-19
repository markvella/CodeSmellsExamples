using System;
using System.Collections.Generic;

namespace AlternativeClasses
{
    public class CurrencyExchange
    {
        public decimal Exchange(string currencyCodeTo, decimal value)
        {
            if (currencyCodeTo.Equals("EUR"))
            {
                return value * 1.5m;
            }
            else
            {
                throw new ArgumentException("Invalid currency.",nameof(currencyCodeTo));
            }
        }
    }
}
