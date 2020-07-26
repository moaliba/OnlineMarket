using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Domain.Models
{
    public class ExpenceDocument
    {
        public int Id { get; set; }

        public int DocumentNumber { get; set; }

        public string FactorNumber { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterPersianDate { get; set; }

        public long Price { get; set; }
    }
}
