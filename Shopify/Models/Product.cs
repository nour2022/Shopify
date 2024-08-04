using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopify.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Image { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal? discount { get; set; }
        public bool IsAvailable { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;


    }
}
