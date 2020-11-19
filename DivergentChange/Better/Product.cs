using System;
using System.Collections.Generic;
using System.Text;

namespace DivergentChange.Better
{
    /*
     * 
     * This is still not the ideal solution but it's much better to maintain
     * 
     * */

    public class ProductInfo
    {
        public double TaxPercentage { get; set; }
        public double BasePrice { get; set; }
        public string ProductCategory { get; set; }
    }

    public class Product
    {
        public static Dictionary<string, ProductInfo> _productInfo = new Dictionary<string, ProductInfo>
        {
            { "food", new ProductInfo
                {
                    TaxPercentage = 24,
                    BasePrice = 10,
                    ProductCategory = "Food and Beverages"
                }
            },
            { "drinks", new ProductInfo
                {
                    TaxPercentage = 24,
                    BasePrice = 7,
                    ProductCategory = "Food and Beverages"
                }
            },
            { "books", new ProductInfo
                {
                    TaxPercentage = 8,
                    BasePrice = 3,
                    ProductCategory = "Food and Beverages"
                }
            }

        };
        private readonly string _type;

        public Product(string type)
        {
            _type = type;
        }
        public double GetBaseAmount()
        {
            return _productInfo[_type].BasePrice;
        }

        public double GetTaxPercent()
        {
            return _productInfo[_type].TaxPercentage;
        }

        public string GetProductCategory()
        {
            return _productInfo[_type].ProductCategory;
        }
    }
}
