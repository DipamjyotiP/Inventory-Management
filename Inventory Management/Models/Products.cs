using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Management.Models
{
    public partial class Products
    {

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter AvailableQuantity")]
        public int AvailableQuantity { get; set; }
    }
}
