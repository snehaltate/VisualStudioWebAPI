using System;
using System.Collections.Generic;

#nullable disable

namespace project_chip_cart.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? Orderid { get; set; }
        public int? Cartid { get; set; }
        public int? Productid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
