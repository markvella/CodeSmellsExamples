using System;
using System.Collections.Generic;

namespace InappropriateIntimacy
{
    public class Item
    {
        private readonly Invoice _invoice;

        public Item(Invoice invoice)
        {
            _invoice = invoice;
        }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public void ChangeQuantity(int newQuantity)
        {
            Quantity = newQuantity;
            _invoice.CalculateTotal();
        }
    }

    public class Invoice
    {
        List<Item> Items = new List<Item>();

        public decimal Total { get; private set; }

        internal void CalculateTotal()
        {
            foreach (var item in Items)
            {
                Total = item.Quantity * item.Price;
            }
        }
    }
}
