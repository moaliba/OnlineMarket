using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Domain.Models
{
    public class WarehouseEntrance
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public decimal Amount { get; set; }

        public DateTime EntranceDate { get; set; }

        public string EntrancePersianDate { get; set; }

        public string FactorNumber { get; set; }
    }
}
