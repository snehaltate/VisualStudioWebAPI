using System;
using System.Collections.Generic;

#nullable disable

namespace project_chip_cart.Models
{
    public partial class OrderTable
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
