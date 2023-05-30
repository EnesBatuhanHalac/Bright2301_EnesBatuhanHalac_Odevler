namespace StoreApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }=string.Empty;
        public decimal Price { get; set; }
    }
}