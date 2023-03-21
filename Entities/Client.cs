using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Entities
{
    public class Client
    {
        [Key]
        public int? Code { get; set; }

        public string Name { get; set}

        public string CNPJ_CPF { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public ICollection<Sale> Sales { get; set; }




    }
}
