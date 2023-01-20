namespace desafio_pmenoslab.Models
{
    public class Stock
    {
        public Product Product { get; set; }
        public Store Store { get; set; }
        public int Id { get; set; }
        public int Quantity{ get; set; }

    }
}
