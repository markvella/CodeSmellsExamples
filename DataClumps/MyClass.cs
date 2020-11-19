using System;
using System.IO;

namespace DataClumps
{
    public class ReportFilter
    {
        public string Title { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
    public class TransactionFilter
    {
        public int UserId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
