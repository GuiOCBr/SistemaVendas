using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Entities
{
    public class Category
    {
        [Key]
        public int? Code { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Product { get; set; }

    }
}
