using System;
using System.Collections.Generic;
using System.Text;

namespace AlternativeClasses
{
    public class Deposit
    {
        public decimal Convert(string currencyCodeTo, decimal value)
        {
            switch (currencyCodeTo) { 
                case "EUR":
                    return value * 1.5m;
                default:
                    throw new ArgumentException("Invalid currency.", nameof(currencyCodeTo));
            }
        }
    }
}
