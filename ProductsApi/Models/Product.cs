namespace ProductsApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string stockQte { get; set; }
        public double Price { get; set; }
    }
}
