using System;
using System.Collections.Generic;

namespace MysteriousName
{
    internal class Itm
    {
        public int Qty { get; set; }
        public int Amt { get; set; }
    }
    public class Inv
    {
        internal List<Itm> Itms { get; set; } = new List<Itm>();
        public decimal CalTotAmt()
        {
            var totAmt = 0;
            foreach (var item in Itms)
            {
                totAmt += item.Qty * item.Amt;
            }
            return totAmt;
        }
    }
}
