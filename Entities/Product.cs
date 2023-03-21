using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenda.Entities
{
    public class Product
    {
        [Key]

        public int? Code { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public decimal Value { get; set; }

        [ForeignKey("Category")]

        public int CodeCategory { get; set; }

        public Category Category { get; set; }

        public ICollection<SaleProduct> Sales { get; set; }

    }
}
