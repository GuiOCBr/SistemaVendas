namespace SistemaVenda.Entities
{
    public class SaleProduct
    {
        public int CodeSale { get; set; }

        public int CodeProduct { get; set; }

        public double Amount { get; set; }

        public decimal UnitaryValue { get; set; }

        public decimal TotalValue { get; set; }

        public Product Product { get; set; }

        public Sale Sale { get; set; }

    }
}
