using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebApplication.Data
{
    [Table("product")]
    public class Product
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        public string? description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double price { get; set; }

        public byte? discount { get; set; }
    }
}
