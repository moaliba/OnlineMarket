using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Domain.Models
{
    public class Sell
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string FactorNumber { get; set; }

        public string CustomerName { get; set; }

        public decimal Amount { get; set; }

        public DateTime SellDate { get; set; }

        public string SellPersianDate { get; set; }

        public long Price { get; set; }
    }
}
