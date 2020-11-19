using System;
using System.Collections.Generic;

namespace DivergentChange.Bad
{
    public class Product
    {
        private readonly string _type;

        public Product(string type)
        {
            this._type = type;
        }
        public double GetBaseAmount()
        {
            switch (_type)
            {
                case "food":
                    return 10;
                case "drinks":
                    return 7;
                case "books":
                    return 3;
                case "vitamins":
                    return 1;
                default:
                    return 0;
            }
        }


        public double GetTaxPercent()
        {
            switch (_type)
            {
                case "food":
                case "drinks":
                    return 24;
                case "books":
                    return 8;
                case "vitamins":
                    return 3;
                default:
                    return 0;
            }
        }



        public string GetProductCategory()
        {
            switch (_type)
            {
                case "food":
                case "drinks":
                    return "Food and Beverages";
                case "books":
                    return "Education";
                case "vitamins":
                    return "Pharmaceutical";
                default:
                    return "-";

            }
        }
    }
}

