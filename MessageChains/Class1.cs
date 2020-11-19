using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace MessageChains
{
    internal class Item
    {
        public string Name { get; set; }
        public Item GetChild()
        {
            return new Item();
        }
    }
    public class MyBeautifulClass
    {
        List<Item> items = new List<Item>();
        public string GetChildNameOfFirstElement(string name)
        {
            return items.First(x => x.Name.Equals(name)).GetChild().Name;
        }
    }
}
