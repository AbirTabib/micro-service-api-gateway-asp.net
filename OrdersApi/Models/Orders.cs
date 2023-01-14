namespace OrdersApi.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public String? CustomersName { get; set; }
        public int ProductId { get; set; }
    }
}
