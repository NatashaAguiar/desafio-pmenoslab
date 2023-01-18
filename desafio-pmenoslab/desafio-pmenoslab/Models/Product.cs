namespace desafio_pmenoslab.Models
{
    public class Product
    {
        public Product(string description)
        {
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}


