using System;
using System.Collections.Generic;

#nullable disable

namespace project_chip_cart.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Categories { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Userid { get; set; }
    }
}
