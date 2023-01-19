namespace desafio_pmenoslab.Models
{
    public class Stock
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
    }
}
