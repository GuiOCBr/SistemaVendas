using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenda.Entities
{
    public class Sale
    {
        [Key]

        public int? Code { get; set; }

        public DateTime Date { get; set; }

        public int Total { get; set; }

        [ForeignKey("Client")]
        public int CodeClient { get; set; }

        public Client Client { get; set; }

        public ICollection<SaleProduct> Products { get; set; }


    }
}
