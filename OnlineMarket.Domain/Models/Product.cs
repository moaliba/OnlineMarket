using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public decimal MinimumAmount { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<WarehouseEntrance> WarehouseEntrances { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }
    }
}
