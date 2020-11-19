using System;
using System.Collections.Generic;

namespace FeatureEnvy
{
    public class Item
    {
        public bool IsOutOfStock;
        public decimal Price;
        public decimal Tax;
        public bool IsOnSale;
        public decimal SaleDiscount;
    }
    public class Basket
    {
        private List<Item> _items;

        public decimal TotalPrice { get; private set; }

        void AddItem(Item i)
        {
            _items.Add(i);

            foreach(var item in _items)
            {
                TotalPrice += GetTotalPrice(item);
            }
        }
        private decimal GetTotalPrice(Item i)
        {
            if (i.IsOutOfStock)
                throw new Exception($"Item {i} is out of stock.");
            var price = i.Price + i.Tax;
            if (i.IsOnSale)
                price = price - i.SaleDiscount * price;
            return price;
        }
    }
}
