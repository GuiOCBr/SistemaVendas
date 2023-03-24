using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class CategoryViewModel
    {
        public int? Code { get; set; }

        [Required(ErrorMessage="Informe a descrição da categoria")]
        public string Description { get; set; }
    }
}


// Model conversa com as entities 